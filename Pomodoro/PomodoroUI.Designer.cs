
namespace Pomodoro
{
    partial class PomodoroUI
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
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rbtnPomodoro = new System.Windows.Forms.RadioButton();
            this.rbtnShortBreak = new System.Windows.Forms.RadioButton();
            this.rbtnLongBreak = new System.Windows.Forms.RadioButton();
            this.rbtnCustom = new System.Windows.Forms.RadioButton();
            this.txtCustomTime = new System.Windows.Forms.TextBox();
            this.tblTask = new System.Windows.Forms.Label();
            this.ddlTasks = new System.Windows.Forms.ComboBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.lblReport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(32, 37);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(179, 78);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "25:00";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(32, 118);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(53, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(91, 118);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(51, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "||  /  >";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(148, 118);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(54, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rbtnPomodoro
            // 
            this.rbtnPomodoro.AutoSize = true;
            this.rbtnPomodoro.Checked = true;
            this.rbtnPomodoro.Location = new System.Drawing.Point(234, 50);
            this.rbtnPomodoro.Name = "rbtnPomodoro";
            this.rbtnPomodoro.Size = new System.Drawing.Size(82, 19);
            this.rbtnPomodoro.TabIndex = 4;
            this.rbtnPomodoro.TabStop = true;
            this.rbtnPomodoro.Text = "Pomodoro";
            this.rbtnPomodoro.UseVisualStyleBackColor = true;
            // 
            // rbtnShortBreak
            // 
            this.rbtnShortBreak.AutoSize = true;
            this.rbtnShortBreak.Location = new System.Drawing.Point(234, 75);
            this.rbtnShortBreak.Name = "rbtnShortBreak";
            this.rbtnShortBreak.Size = new System.Drawing.Size(85, 19);
            this.rbtnShortBreak.TabIndex = 5;
            this.rbtnShortBreak.Text = "Short Break";
            this.rbtnShortBreak.UseVisualStyleBackColor = true;
            // 
            // rbtnLongBreak
            // 
            this.rbtnLongBreak.AutoSize = true;
            this.rbtnLongBreak.Location = new System.Drawing.Point(234, 100);
            this.rbtnLongBreak.Name = "rbtnLongBreak";
            this.rbtnLongBreak.Size = new System.Drawing.Size(84, 19);
            this.rbtnLongBreak.TabIndex = 6;
            this.rbtnLongBreak.Text = "Long Break";
            this.rbtnLongBreak.UseVisualStyleBackColor = true;
            // 
            // rbtnCustom
            // 
            this.rbtnCustom.AutoSize = true;
            this.rbtnCustom.Location = new System.Drawing.Point(234, 122);
            this.rbtnCustom.Name = "rbtnCustom";
            this.rbtnCustom.Size = new System.Drawing.Size(67, 19);
            this.rbtnCustom.TabIndex = 7;
            this.rbtnCustom.TabStop = true;
            this.rbtnCustom.Text = "Custom";
            this.rbtnCustom.UseVisualStyleBackColor = true;
            // 
            // txtCustomTime
            // 
            this.txtCustomTime.Location = new System.Drawing.Point(302, 120);
            this.txtCustomTime.Name = "txtCustomTime";
            this.txtCustomTime.Size = new System.Drawing.Size(30, 23);
            this.txtCustomTime.TabIndex = 8;
            this.txtCustomTime.Text = "10";
            // 
            // tblTask
            // 
            this.tblTask.AutoSize = true;
            this.tblTask.Location = new System.Drawing.Point(14, 11);
            this.tblTask.Name = "tblTask";
            this.tblTask.Size = new System.Drawing.Size(29, 15);
            this.tblTask.TabIndex = 9;
            this.tblTask.Text = "Task";
            // 
            // ddlTasks
            // 
            this.ddlTasks.FormattingEnabled = true;
            this.ddlTasks.Location = new System.Drawing.Point(49, 8);
            this.ddlTasks.Name = "ddlTasks";
            this.ddlTasks.Size = new System.Drawing.Size(233, 23);
            this.ddlTasks.TabIndex = 11;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(288, 7);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(19, 23);
            this.btnAddTask.TabIndex = 12;
            this.btnAddTask.Text = "+";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(313, 7);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(19, 23);
            this.btnRemoveTask.TabIndex = 13;
            this.btnRemoveTask.Text = "-";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblReport.Location = new System.Drawing.Point(258, 147);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(42, 15);
            this.lblReport.TabIndex = 14;
            this.lblReport.Text = "Report";
            this.lblReport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblReport_MouseClick);
            // 
            // PomodoroUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 165);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.ddlTasks);
            this.Controls.Add(this.tblTask);
            this.Controls.Add(this.txtCustomTime);
            this.Controls.Add(this.rbtnCustom);
            this.Controls.Add(this.rbtnLongBreak);
            this.Controls.Add(this.rbtnShortBreak);
            this.Controls.Add(this.rbtnPomodoro);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTime);
            this.Name = "PomodoroUI";
            this.Text = "Pomodoro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rbtnPomodoro;
        private System.Windows.Forms.RadioButton rbtnShortBreak;
        private System.Windows.Forms.RadioButton rbtnLongBreak;
        private System.Windows.Forms.RadioButton rbtnCustom;
        private System.Windows.Forms.TextBox txtCustomTime;
        private System.Windows.Forms.Label tblTask;
        private System.Windows.Forms.ComboBox ddlTasks;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Label lblReport;
    }
}

