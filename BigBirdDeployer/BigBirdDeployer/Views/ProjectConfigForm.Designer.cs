﻿namespace BigBirdDeployer.Views
{
    partial class ProjectConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectConfigForm));
            this.BTSave = new System.Windows.Forms.Button();
            this.BTCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBFolder = new System.Windows.Forms.TextBox();
            this.TBJarFile = new System.Windows.Forms.TextBox();
            this.TBPort = new System.Windows.Forms.TextBox();
            this.TBVersionCache = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBDesc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBAutoStart = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBParameter = new System.Windows.Forms.TextBox();
            this.LBParameter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTSave
            // 
            this.BTSave.Location = new System.Drawing.Point(261, 277);
            this.BTSave.Name = "BTSave";
            this.BTSave.Size = new System.Drawing.Size(75, 23);
            this.BTSave.TabIndex = 0;
            this.BTSave.Text = "保存";
            this.BTSave.UseVisualStyleBackColor = true;
            this.BTSave.Click += new System.EventHandler(this.BTSave_Click);
            // 
            // BTCancel
            // 
            this.BTCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTCancel.Location = new System.Drawing.Point(342, 277);
            this.BTCancel.Name = "BTCancel";
            this.BTCancel.Size = new System.Drawing.Size(75, 23);
            this.BTCancel.TabIndex = 1;
            this.BTCancel.Text = "取消";
            this.BTCancel.UseVisualStyleBackColor = true;
            this.BTCancel.Click += new System.EventHandler(this.BTCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "工程名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "文件夹名称";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(114, 20);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(303, 21);
            this.TBName.TabIndex = 4;
            // 
            // TBFolder
            // 
            this.TBFolder.Location = new System.Drawing.Point(114, 47);
            this.TBFolder.Name = "TBFolder";
            this.TBFolder.Size = new System.Drawing.Size(303, 21);
            this.TBFolder.TabIndex = 5;
            // 
            // TBJarFile
            // 
            this.TBJarFile.Location = new System.Drawing.Point(114, 74);
            this.TBJarFile.Name = "TBJarFile";
            this.TBJarFile.Size = new System.Drawing.Size(303, 21);
            this.TBJarFile.TabIndex = 6;
            // 
            // TBPort
            // 
            this.TBPort.Location = new System.Drawing.Point(114, 101);
            this.TBPort.Name = "TBPort";
            this.TBPort.Size = new System.Drawing.Size(142, 21);
            this.TBPort.TabIndex = 7;
            // 
            // TBVersionCache
            // 
            this.TBVersionCache.Location = new System.Drawing.Point(114, 128);
            this.TBVersionCache.Name = "TBVersionCache";
            this.TBVersionCache.Size = new System.Drawing.Size(142, 21);
            this.TBVersionCache.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "运行Jar包名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "端口号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "版本缓存个数";
            // 
            // LBDesc
            // 
            this.LBDesc.AutoSize = true;
            this.LBDesc.Location = new System.Drawing.Point(25, 282);
            this.LBDesc.Name = "LBDesc";
            this.LBDesc.Size = new System.Drawing.Size(77, 12);
            this.LBDesc.TabIndex = 13;
            this.LBDesc.Text = "执行结果描述";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(262, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "0：不清除历史版本";
            // 
            // CBAutoStart
            // 
            this.CBAutoStart.AutoSize = true;
            this.CBAutoStart.Enabled = false;
            this.CBAutoStart.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.CBAutoStart.Location = new System.Drawing.Point(114, 218);
            this.CBAutoStart.Name = "CBAutoStart";
            this.CBAutoStart.Size = new System.Drawing.Size(156, 16);
            this.CBAutoStart.TabIndex = 15;
            this.CBAutoStart.Text = "程序运行，自动启动服务";
            this.CBAutoStart.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(25, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "自动启动";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "运行参数";
            // 
            // TBParameter
            // 
            this.TBParameter.Location = new System.Drawing.Point(114, 155);
            this.TBParameter.Name = "TBParameter";
            this.TBParameter.Size = new System.Drawing.Size(303, 21);
            this.TBParameter.TabIndex = 17;
            // 
            // LBParameter
            // 
            this.LBParameter.AutoSize = true;
            this.LBParameter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBParameter.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.LBParameter.Location = new System.Drawing.Point(112, 179);
            this.LBParameter.Name = "LBParameter";
            this.LBParameter.Size = new System.Drawing.Size(173, 12);
            this.LBParameter.TabIndex = 19;
            this.LBParameter.Text = "-Dspring.profiles.active=dev";
            this.LBParameter.Click += new System.EventHandler(this.LBParameter_Click);
            // 
            // ProjectConfigForm
            // 
            this.AcceptButton = this.BTSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTCancel;
            this.ClientSize = new System.Drawing.Size(450, 313);
            this.Controls.Add(this.LBParameter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBParameter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBAutoStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LBDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBVersionCache);
            this.Controls.Add(this.TBPort);
            this.Controls.Add(this.TBJarFile);
            this.Controls.Add(this.TBFolder);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTCancel);
            this.Controls.Add(this.BTSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "项目工程配置";
            this.Load += new System.EventHandler(this.ProjectConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTSave;
        private System.Windows.Forms.Button BTCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBFolder;
        private System.Windows.Forms.TextBox TBJarFile;
        private System.Windows.Forms.TextBox TBPort;
        private System.Windows.Forms.TextBox TBVersionCache;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CBAutoStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBParameter;
        private System.Windows.Forms.Label LBParameter;
    }
}