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
                url = key.GetValue("installPath").ToString();
                if (url == null)
                {
                    MessageBox.Show("读取失败，无法找到指定客户端安装位置");
                    valid = false;
                }
                else
                {
                    try
                    {
                        url = Path.GetDirectoryName(url);
                        //url = url.TrimEnd('M', 'o', 'v', 'i', 'e', 'E', 'd', 'i', 't', 'o', 'r', 'L', 'a', 'u', 'n', 'c', 'h', 'e', 'r', '.', 'e', 'x', 'e') + "config.ini";
                        //MessageBox.Show(url);
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
                url = key.GetValue("installPath").ToString();
                if (url == null)
                {
                    label2.Text="读取失败，无法找到指定客户端安装位置";
                    valid = false;
                }
                else
                {
                    try
                    {
                        url = Path.GetDirectoryName(url);
                        //url = url.TrimEnd('M', 'o', 'v', 'i', 'e', 'E', 'd', 'i', 't', 'o', 'r', 'L', 'a', 'u', 'n', 'c', 'h', 'e', 'r', '.', 'e', 'x', 'e') + "config.ini";
                        //MessageBox.Show(url);
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

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\App Paths\MovieEditorLauncher.exe");
                url = key.GetValue("").ToString();
                if (url == null)
                {
                    MessageBox.Show("读取失败，无法找到指定客户端安装位置");
                    valid = false;
                }
                else
                {
                    try
                    {
                        url = Path.GetDirectoryName(url);
                        //url = url.TrimEnd('M', 'o', 'v', 'i', 'e', 'E', 'd', 'i', 't', 'o', 'r', 'L', 'a', 'u', 'n', 'c', 'h', 'e', 'r', '.', 'e', 'x', 'e') + "config.ini";
                        //MessageBox.Show(url);
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
    }
}
