
namespace Pomodoro
{
    partial class Report
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdTaskInfo = new System.Windows.Forms.DataGridView();
            this.lblTaskTimeReport = new System.Windows.Forms.LinkLabel();
            this.lblTaskLog = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLogs
            // 
            this.grdTaskInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTaskInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTaskInfo.Location = new System.Drawing.Point(53, 87);
            this.grdTaskInfo.Name = "grdLogs";
            this.grdTaskInfo.RowTemplate.Height = 25;
            this.grdTaskInfo.Size = new System.Drawing.Size(536, 237);
            this.grdTaskInfo.TabIndex = 0;
            // 
            // lblTaskTimeReport
            // 
            this.lblTaskTimeReport.AutoSize = true;
            this.lblTaskTimeReport.Location = new System.Drawing.Point(187, 38);
            this.lblTaskTimeReport.Name = "lblTaskTimeReport";
            this.lblTaskTimeReport.Size = new System.Drawing.Size(96, 15);
            this.lblTaskTimeReport.TabIndex = 1;
            this.lblTaskTimeReport.TabStop = true;
            this.lblTaskTimeReport.Text = "Task Time Report";
            this.lblTaskTimeReport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblTaskTimeReport_MouseClick);
            // 
            // lblTaskLog
            // 
            this.lblTaskLog.AutoSize = true;
            this.lblTaskLog.Location = new System.Drawing.Point(65, 38);
            this.lblTaskLog.Name = "lblTaskLog";
            this.lblTaskLog.Size = new System.Drawing.Size(52, 15);
            this.lblTaskLog.TabIndex = 2;
            this.lblTaskLog.TabStop = true;
            this.lblTaskLog.Text = "Task Log";
            this.lblTaskLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTaskLog_LinkClicked);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 347);
            this.Controls.Add(this.lblTaskLog);
            this.Controls.Add(this.lblTaskTimeReport);
            this.Controls.Add(this.grdTaskInfo);
            this.Name = "Report";
            this.Text = "Pomodoro";
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTaskInfo;
        private System.Windows.Forms.LinkLabel lblTaskTimeReport;
        private System.Windows.Forms.LinkLabel lblTaskLog;
    }
}

