﻿namespace wangjiajun0724Project3clsWindowsFormsApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSource = new System.Windows.Forms.TabPage();
            this.tabDest = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtProcessedFile = new System.Windows.Forms.TextBox();
            this.optGenerateLog = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.groupEventLog = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnViewSummary = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabSource.SuspendLayout();
            this.tabDest.SuspendLayout();
            this.groupEventLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSource);
            this.tabControl1.Controls.Add(this.tabDest);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(541, 355);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSource
            // 
            this.tabSource.Controls.Add(this.optGenerateLog);
            this.tabSource.Controls.Add(this.txtProcessedFile);
            this.tabSource.Controls.Add(this.txtSource);
            this.tabSource.Controls.Add(this.label2);
            this.tabSource.Controls.Add(this.label1);
            this.tabSource.ImageIndex = 0;
            this.tabSource.Location = new System.Drawing.Point(4, 25);
            this.tabSource.Name = "tabSource";
            this.tabSource.Padding = new System.Windows.Forms.Padding(3);
            this.tabSource.Size = new System.Drawing.Size(533, 326);
            this.tabSource.TabIndex = 0;
            this.tabSource.Text = "Source Options";
            this.tabSource.UseVisualStyleBackColor = true;
            // 
            // tabDest
            // 
            this.tabDest.Controls.Add(this.btnViewSummary);
            this.tabDest.Controls.Add(this.btnRefresh);
            this.tabDest.Controls.Add(this.groupEventLog);
            this.tabDest.Controls.Add(this.txtDest);
            this.tabDest.Controls.Add(this.label3);
            this.tabDest.ImageIndex = 1;
            this.tabDest.Location = new System.Drawing.Point(4, 25);
            this.tabDest.Name = "tabDest";
            this.tabDest.Padding = new System.Windows.Forms.Padding(3);
            this.tabDest.Size = new System.Drawing.Size(533, 326);
            this.tabDest.TabIndex = 1;
            this.tabDest.Text = "Destination Options";
            this.tabDest.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "QQ图片20230313224849.png");
            this.imageList1.Images.SetKeyName(1, "QQ图片20230313224849.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "After Processing.Move Source File to";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(185, 45);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(245, 25);
            this.txtSource.TabIndex = 2;
            // 
            // txtProcessedFile
            // 
            this.txtProcessedFile.Location = new System.Drawing.Point(25, 185);
            this.txtProcessedFile.Name = "txtProcessedFile";
            this.txtProcessedFile.Size = new System.Drawing.Size(405, 25);
            this.txtProcessedFile.TabIndex = 3;
            // 
            // optGenerateLog
            // 
            this.optGenerateLog.AutoSize = true;
            this.optGenerateLog.Location = new System.Drawing.Point(25, 239);
            this.optGenerateLog.Name = "optGenerateLog";
            this.optGenerateLog.Size = new System.Drawing.Size(333, 19);
            this.optGenerateLog.TabIndex = 4;
            this.optGenerateLog.Text = "Generate Event Log for Bad File Format";
            this.optGenerateLog.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Destination Directory";
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(230, 21);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(203, 25);
            this.txtDest.TabIndex = 1;
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.ItemHeight = 15;
            this.lstEvents.Location = new System.Drawing.Point(11, 16);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(380, 199);
            this.lstEvents.TabIndex = 2;
            // 
            // groupEventLog
            // 
            this.groupEventLog.Controls.Add(this.lstEvents);
            this.groupEventLog.Location = new System.Drawing.Point(42, 51);
            this.groupEventLog.Name = "groupEventLog";
            this.groupEventLog.Size = new System.Drawing.Size(407, 233);
            this.groupEventLog.TabIndex = 3;
            this.groupEventLog.TabStop = false;
            this.groupEventLog.Text = "Event Log";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(63, 272);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(104, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh Log";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnViewSummary
            // 
            this.btnViewSummary.Location = new System.Drawing.Point(263, 272);
            this.btnViewSummary.Name = "btnViewSummary";
            this.btnViewSummary.Size = new System.Drawing.Size(128, 23);
            this.btnViewSummary.TabIndex = 5;
            this.btnViewSummary.Text = "View Summary";
            this.btnViewSummary.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(79, 374);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(104, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(279, 373);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabSource.ResumeLayout(false);
            this.tabSource.PerformLayout();
            this.tabDest.ResumeLayout(false);
            this.tabDest.PerformLayout();
            this.groupEventLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSource;
        private System.Windows.Forms.TabPage tabDest;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox optGenerateLog;
        private System.Windows.Forms.TextBox txtProcessedFile;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewSummary;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupEventLog;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnExit;
    }
}

