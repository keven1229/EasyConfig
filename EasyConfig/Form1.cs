using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyConfig
{
    public partial class Form1 : Form
    {
        int processorCount;

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

    }
}
