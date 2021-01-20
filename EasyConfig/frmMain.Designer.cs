
namespace EasyConfig
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optZhcnExpPakv3 = new System.Windows.Forms.RadioButton();
            this.optZhcnHdPakv3 = new System.Windows.Forms.RadioButton();
            this.optCustom = new System.Windows.Forms.RadioButton();
            this.optMovieEditor = new System.Windows.Forms.RadioButton();
            this.optZhtwHdPakv3 = new System.Windows.Forms.RadioButton();
            this.optZhcnExp = new System.Windows.Forms.RadioButton();
            this.optZhcnHd = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOsPlatform = new System.Windows.Forms.Label();
            this.lblOsVersion = new System.Windows.Forms.Label();
            this.lblProcessorCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblConfigLocation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optZhcnExpPakv3);
            this.groupBox1.Controls.Add(this.optZhcnHdPakv3);
            this.groupBox1.Controls.Add(this.optCustom);
            this.groupBox1.Controls.Add(this.optMovieEditor);
            this.groupBox1.Controls.Add(this.optZhtwHdPakv3);
            this.groupBox1.Controls.Add(this.optZhcnExp);
            this.groupBox1.Controls.Add(this.optZhcnHd);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(220, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1.选择客户端版本";
            // 
            // optZhcnExpPakv3
            // 
            this.optZhcnExpPakv3.AutoSize = true;
            this.optZhcnExpPakv3.Location = new System.Drawing.Point(3, 68);
            this.optZhcnExpPakv3.Margin = new System.Windows.Forms.Padding(2);
            this.optZhcnExpPakv3.Name = "optZhcnExpPakv3";
            this.optZhcnExpPakv3.Size = new System.Drawing.Size(209, 16);
            this.optZhcnExpPakv3.TabIndex = 6;
            this.optZhcnExpPakv3.TabStop = true;
            this.optZhcnExpPakv3.Text = "主服测试服PakV3(zhcn_exp_pakv3)";
            this.optZhcnExpPakv3.UseVisualStyleBackColor = true;
            this.optZhcnExpPakv3.CheckedChanged += new System.EventHandler(this.optClientVersion_CheckedChanged);
            // 
            // optZhcnHdPakv3
            // 
            this.optZhcnHdPakv3.AutoSize = true;
            this.optZhcnHdPakv3.Location = new System.Drawing.Point(3, 51);
            this.optZhcnHdPakv3.Margin = new System.Windows.Forms.Padding(2);
            this.optZhcnHdPakv3.Name = "optZhcnHdPakv3";
            this.optZhcnHdPakv3.Size = new System.Drawing.Size(203, 16);
            this.optZhcnHdPakv3.TabIndex = 5;
            this.optZhcnHdPakv3.TabStop = true;
            this.optZhcnHdPakv3.Text = "主服正式服PakV3(zhcn_hd_pakv3)";
            this.optZhcnHdPakv3.UseVisualStyleBackColor = true;
            this.optZhcnHdPakv3.CheckedChanged += new System.EventHandler(this.optClientVersion_CheckedChanged);
            // 
            // optCustom
            // 
            this.optCustom.AutoSize = true;
            this.optCustom.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.optCustom.Location = new System.Drawing.Point(3, 119);
            this.optCustom.Margin = new System.Windows.Forms.Padding(2);
            this.optCustom.Name = "optCustom";
            this.optCustom.Size = new System.Drawing.Size(59, 16);
            this.optCustom.TabIndex = 4;
            this.optCustom.TabStop = true;
            this.optCustom.Text = "自定义";
            this.optCustom.UseVisualStyleBackColor = true;
            this.optCustom.CheckedChanged += new System.EventHandler(this.optClientVersion_CheckedChanged);
            // 
            // optMovieEditor
            // 
            this.optMovieEditor.AutoSize = true;
            this.optMovieEditor.Location = new System.Drawing.Point(3, 102);
            this.optMovieEditor.Margin = new System.Windows.Forms.Padding(2);
            this.optMovieEditor.Name = "optMovieEditor";
            this.optMovieEditor.Size = new System.Drawing.Size(209, 16);
            this.optMovieEditor.TabIndex = 3;
            this.optMovieEditor.TabStop = true;
            this.optMovieEditor.Text = "视频编辑器(MovieEditor)(实验性)";
            this.optMovieEditor.UseVisualStyleBackColor = true;
            this.optMovieEditor.CheckedChanged += new System.EventHandler(this.optClientVersion_CheckedChanged);
            // 
            // optZhtwHdPakv3
            // 
            this.optZhtwHdPakv3.AutoSize = true;
            this.optZhtwHdPakv3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.optZhtwHdPakv3.Location = new System.Drawing.Point(3, 85);
            this.optZhtwHdPakv3.Margin = new System.Windows.Forms.Padding(2);
            this.optZhtwHdPakv3.Name = "optZhtwHdPakv3";
            this.optZhtwHdPakv3.Size = new System.Drawing.Size(203, 16);
            this.optZhtwHdPakv3.TabIndex = 2;
            this.optZhtwHdPakv3.TabStop = true;
            this.optZhtwHdPakv3.Text = "国际正式服PakV3(zhtw_hd_pakv3)";
            this.optZhtwHdPakv3.UseVisualStyleBackColor = true;
            this.optZhtwHdPakv3.CheckedChanged += new System.EventHandler(this.optClientVersion_CheckedChanged);
            // 
            // optZhcnExp
            // 
            this.optZhcnExp.AutoSize = true;
            this.optZhcnExp.Location = new System.Drawing.Point(3, 34);
            this.optZhcnExp.Margin = new System.Windows.Forms.Padding(2);
            this.optZhcnExp.Name = "optZhcnExp";
            this.optZhcnExp.Size = new System.Drawing.Size(143, 16);
            this.optZhcnExp.TabIndex = 1;
            this.optZhcnExp.TabStop = true;
            this.optZhcnExp.Text = "主服测试服(zhcn_exp)";
            this.optZhcnExp.UseVisualStyleBackColor = true;
            this.optZhcnExp.CheckedChanged += new System.EventHandler(this.optClientVersion_CheckedChanged);
            // 
            // optZhcnHd
            // 
            this.optZhcnHd.AutoSize = true;
            this.optZhcnHd.Location = new System.Drawing.Point(3, 17);
            this.optZhcnHd.Margin = new System.Windows.Forms.Padding(2);
            this.optZhcnHd.Name = "optZhcnHd";
            this.optZhcnHd.Size = new System.Drawing.Size(137, 16);
            this.optZhcnHd.TabIndex = 0;
            this.optZhcnHd.TabStop = true;
            this.optZhcnHd.Text = "主服正式服(zhcn_hd)";
            this.optZhcnHd.UseVisualStyleBackColor = true;
            this.optZhcnHd.CheckedChanged += new System.EventHandler(this.optClientVersion_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.lblOsPlatform);
            this.groupBox2.Controls.Add(this.lblOsVersion);
            this.groupBox2.Controls.Add(this.lblProcessorCount);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 172);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(403, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "系统信息";
            // 
            // lblOsPlatform
            // 
            this.lblOsPlatform.AutoSize = true;
            this.lblOsPlatform.Location = new System.Drawing.Point(96, 40);
            this.lblOsPlatform.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOsPlatform.Name = "lblOsPlatform";
            this.lblOsPlatform.Size = new System.Drawing.Size(65, 12);
            this.lblOsPlatform.TabIndex = 5;
            this.lblOsPlatform.Text = "OsPlatform";
            // 
            // lblOsVersion
            // 
            this.lblOsVersion.AutoSize = true;
            this.lblOsVersion.Location = new System.Drawing.Point(96, 28);
            this.lblOsVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOsVersion.Name = "lblOsVersion";
            this.lblOsVersion.Size = new System.Drawing.Size(59, 12);
            this.lblOsVersion.TabIndex = 4;
            this.lblOsVersion.Text = "OsVersion";
            // 
            // lblProcessorCount
            // 
            this.lblProcessorCount.AutoSize = true;
            this.lblProcessorCount.Location = new System.Drawing.Point(96, 16);
            this.lblProcessorCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProcessorCount.Name = "lblProcessorCount";
            this.lblProcessorCount.Size = new System.Drawing.Size(89, 12);
            this.lblProcessorCount.TabIndex = 3;
            this.lblProcessorCount.Text = "ProcessorCount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "系统平台";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "系统内核版本";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "CPU线程数";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRestore);
            this.groupBox3.Controls.Add(this.btnView);
            this.groupBox3.Controls.Add(this.btnApply);
            this.groupBox3.Controls.Add(this.lblConfigLocation);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(230, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(412, 164);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2.确认目录/应用修改";
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(19, 102);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "恢复默认";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(110, 76);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(96, 23);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "打开配置文件";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(19, 76);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "应用更改";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblConfigLocation
            // 
            this.lblConfigLocation.AutoSize = true;
            this.lblConfigLocation.Location = new System.Drawing.Point(16, 35);
            this.lblConfigLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfigLocation.Name = "lblConfigLocation";
            this.lblConfigLocation.Size = new System.Drawing.Size(149, 12);
            this.lblConfigLocation.TabIndex = 1;
            this.lblConfigLocation.Text = "---请从左侧选择客户端---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择的目录：";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(595, 222);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(47, 12);
            this.lblVersion.TabIndex = 37;
            this.lblVersion.Text = "Version";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 36);
            this.label3.TabIndex = 36;
            this.label3.Text = "作者：双一念破 今天咕了吗\r\n念破-卿风歌酒知今朝 帮会收人\r\nkeven@kevenidc.com\r\n";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "配置设置 (*.ini)|*.ini";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 238);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "EasyConfig-by Keven&KevenIDC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optMovieEditor;
        private System.Windows.Forms.RadioButton optZhtwHdPakv3;
        private System.Windows.Forms.RadioButton optZhcnExp;
        private System.Windows.Forms.RadioButton optZhcnHd;
        private System.Windows.Forms.RadioButton optCustom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblConfigLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOsPlatform;
        private System.Windows.Forms.Label lblOsVersion;
        private System.Windows.Forms.Label lblProcessorCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton optZhcnHdPakv3;
        private System.Windows.Forms.RadioButton optZhcnExpPakv3;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

