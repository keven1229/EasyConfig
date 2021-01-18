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

namespace EasyConfig
{
    public partial class Form1 : Form
    {
        int processorCount;
        string url;
        bool valid = false;

        public Form1()
        {
            InitializeComponent();
            label22.Text = Application.ProductVersion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processorCount = Environment.ProcessorCount;
            Console.WriteLine("发现 {0} 个处理器", processorCount);
            label7.Text = processorCount.ToString();
            string osVersion = Environment.OSVersion.Version.ToString();
            string platform = Environment.OSVersion.Platform.ToString();
            label8.Text = osVersion;
            label9.Text = platform;
        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Kingsoft\JX3\zhcn_hd");
                if (key == null)
                {
                    label2.Text="读取失败，无法找到指定客户端安装位置";
                    valid = false;
                }
                else
                {
                    try
                    {
                        url = key.GetValue("installPath").ToString();
                        url = Path.GetDirectoryName(url);
                        url = Path.Combine(url, "config", "config.default.ini");
                    }
                    catch
                    {

                    }
                    if (File.Exists(url))
                    {
                        label2.Text = url;
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                        label2.Text = "读取失败，注册表不包含有效目录";
                    }
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Kingsoft\JX3\zhcn_exp");
                if (key == null)
                {
                    label2.Text="读取失败，无法找到指定客户端安装位置";
                    valid = false;
                }
                else
                {
                    try
                    {
                        url = key.GetValue("installPath").ToString();
                        url = Path.GetDirectoryName(url);
                        url = Path.Combine(url, "config", "config.default.ini");
                    }
                    catch
                    {

                    }
                    if (File.Exists(url))
                    {
                        label2.Text = url;
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                        label2.Text = "读取失败，注册表不包含有效目录";
                    }

                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\kingsoft\JX3\zhtw_hd");
                if (key == null)
                {
                    label2.Text = "读取失败，无法找到指定客户端安装位置";
                    valid = false;
                }
                else
                {
                    try
                    {
                        url = key.GetValue("installPath").ToString();
                        url = Path.GetDirectoryName(url);
                        url = Path.Combine(url, "config", "config.default.ini");
                    }
                    catch
                    {

                    }
                    if (File.Exists(url))
                    {
                        label2.Text = url;
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                        label2.Text = "读取失败，注册表不包含有效目录";
                    }

                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\App Paths\MovieEditorLauncher.exe");
                if (key == null)
                {
                    label2.Text="读取失败，无法找到指定客户端安装位置";
                    valid = false;
                }
                else
                {
                    try
                    {
                        url = key.GetValue("").ToString();
                        url = Path.GetDirectoryName(url);
                        url = Path.Combine(url, "config.ini");
                    }
                    catch
                    {

                    }
                    if (File.Exists(url))
                    {
                        label2.Text = url;
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                        label2.Text = "读取失败，注册表不包含有效目录";
                    }
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valid)
            {
                INIConfigHelper config = new INIConfigHelper(url);
                try
                {
                    config.IniWriteValue("KG3DENGINE", "NumCpuThread", processorCount.ToString());
                    MessageBox.Show("成功！！！\n\n已将" + url + "\n的" + "NumCpuThread改为" + processorCount.ToString());
                }
                catch(Exception ex)
                {
                    MessageBox.Show("修改失败：\n" + ex);
                }
            }
            else
            {
                MessageBox.Show("没有获取有效的目录，请重新选择");
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\kingsoft\JX3\zhcn_hd");
                if (key == null)
                {
                    label2.Text = "读取失败，无法找到指定客户端安装位置";
                    valid = false;
                }
                else
                {
                    try
                    {
                        url = key.GetValue("installPath").ToString();
                        url = Path.GetDirectoryName(url);
                        url = Path.Combine(url, "config", "config.default.ini");
                    }
                    catch
                    {

                    }
                    if (File.Exists(url))
                    {
                        label2.Text = url;
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                        label2.Text = "读取失败，注册表不包含有效目录";
                    }

                }
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\kingsoft\JX3\zhcn_exp");
                if (key == null)
                {
                    label2.Text = "读取失败，无法找到指定客户端安装位置";
                    valid = false;
                }
                else
                {
                    try
                    {
                        url = key.GetValue("installPath").ToString();
                        url = Path.GetDirectoryName(url);
                        url = Path.Combine(url, "config", "config.default.ini");
                    }
                    catch
                    {

                    }
                    if (File.Exists(url))
                    {
                        label2.Text = url;
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                        label2.Text = "读取失败，注册表不包含有效目录";
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (valid)
            {
                System.Diagnostics.Process.Start(url);
            }
            else
            {
                MessageBox.Show("没有获取有效的目录，请重新选择");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (valid)
            {
                INIConfigHelper config = new INIConfigHelper(url);
                try
                {
                    config.IniWriteValue("KG3DENGINE", "NumCpuThread", "1");
                    MessageBox.Show("已将" + url + "\n的" + "NumCpuThread恢复");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("修改失败：\n" + ex);
                }
            }
            else
            {
                MessageBox.Show("没有获取有效的目录，请重新选择");
            }
        }
    }
}
