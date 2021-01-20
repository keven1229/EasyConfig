using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;

namespace EasyConfig
{
    public partial class frmMain : Form
    {
        private class JX3ClientConfigInfo
        {
            // 记录客户端根目录的注册表路径
            public string ClientLocationRegPath { get; set; }
            // 记录客户端根目录的注册表键
            public string ClientLocationRegKey { get; set; }
            // 配置文件对客户端根目录的相对路径
            public string ClientConfigRelativePath { get; set; }

            public JX3ClientConfigInfo(string regPath, string regKey, string cfgPath)
            {
                this.ClientLocationRegPath = regPath;
                this.ClientLocationRegKey = regKey;
                this.ClientConfigRelativePath = cfgPath;
            }
        }

        int processorCount;
        string configFile;

        private readonly Dictionary<string, JX3ClientConfigInfo> clientInfoReg = new Dictionary<string, JX3ClientConfigInfo>{
            { nameof(optZhcnHd), new JX3ClientConfigInfo(@"SOFTWARE\Kingsoft\JX3\zhcn_hd", "installPath", "config/config.default.ini") },
            { nameof(optZhcnExp), new JX3ClientConfigInfo(@"SOFTWARE\Kingsoft\JX3\zhcn_exp", "installPath", "config/config.default.ini") },
            { nameof(optZhcnHdPakv3), new JX3ClientConfigInfo(@"SOFTWARE\WOW6432Node\kingsoft\JX3\zhcn_hd", "installPath", "config/config.default.ini") },
            { nameof(optZhcnExpPakv3), new JX3ClientConfigInfo(@"SOFTWARE\WOW6432Node\kingsoft\JX3\zhcn_exp", "installPath", "config/config.default.ini") },
            { nameof(optZhtwHdPakv3), new JX3ClientConfigInfo(@"SOFTWARE\WOW6432Node\kingsoft\JX3\zhtw_hd", "installPath", "config/config.default.ini") },
            { nameof(optMovieEditor), new JX3ClientConfigInfo(@"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\App Paths\MovieEditorLauncher.exe", string.Empty, "config.ini") },
        };

        private string GetConfigLocationFromRegKey(JX3ClientConfigInfo clientInfo)
        {
            string ret = string.Empty;
            RegistryKey key = Registry.LocalMachine.OpenSubKey(clientInfo.ClientLocationRegPath);
            if (key == null)
                throw new FileNotFoundException("读取失败，无法找到指定客户端安装位置");
            else
            {
                try
                {
                    string baseDir = Path.GetDirectoryName(key.GetValue(clientInfo.ClientLocationRegKey).ToString());
                    ret = Path.GetFullPath(Path.Combine(baseDir, clientInfo.ClientConfigRelativePath));
                }
                catch
                {

                }
                if (!File.Exists(ret))
                    throw new FileNotFoundException("读取失败，注册表不包含有效目录");
                return ret;
            }
        }

        private void ApplyThreadConfig(string configFile, int threadCount)
        {
            if (File.Exists(configFile))
            {
                INIConfigHelper config = new INIConfigHelper(configFile);
                try
                {
                    config.IniWriteValue("KG3DENGINE", "NumCpuThread", threadCount.ToString());
                    MessageBox.Show($"操作成功！{Environment.NewLine}已将 {configFile}{Environment.NewLine}的 NumCpuThread 设置为 {threadCount}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"修改失败：{Environment.NewLine}{ex}");
                }
            }
            else
            {
                MessageBox.Show("没有获取有效的目录，请重新选择");
            }
        }

        public frmMain()
        {
            InitializeComponent();
            lblVersion.Text = Application.ProductVersion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processorCount = Environment.ProcessorCount;
            Console.WriteLine("发现 {0} 个处理器", processorCount);
            lblProcessorCount.Text = processorCount.ToString();
            lblOsVersion.Text = Environment.OSVersion.Version.ToString();
            lblOsPlatform.Text = Environment.OSVersion.Platform.ToString();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (File.Exists(configFile))
                Process.Start(configFile);
            else
                MessageBox.Show("没有获取有效的目录，请重新选择");
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ApplyThreadConfig(configFile, processorCount);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            ApplyThreadConfig(configFile, 1);
        }

        private void optClientVersion_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton optSender = (RadioButton)sender;
            if(optSender.Checked)
            {
                if(optSender != optCustom)
                {
                    try
                    {
                        configFile = GetConfigLocationFromRegKey(this.clientInfoReg[optSender.Name]);
                        lblConfigLocation.ForeColor = Color.Green;
                        lblConfigLocation.Text = configFile;
                    }
                    catch(Exception ex)
                    {
                        lblConfigLocation.ForeColor = Color.Red;
                        lblConfigLocation.Text = ex.Message;
                    }
                }
                else
                {
                    if(openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        configFile = openFileDialog1.FileName;
                        lblConfigLocation.ForeColor = Color.Green;
                        lblConfigLocation.Text = configFile;
                    }
                    else
                    {
                        optCustom.Checked = false;
                        lblConfigLocation.ForeColor = Color.Red;
                        lblConfigLocation.Text = "请选择有效的 INI 配置文件";
                    }
                }
            }
        }
    }
}
