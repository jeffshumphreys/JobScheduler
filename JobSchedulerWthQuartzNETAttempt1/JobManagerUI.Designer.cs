namespace JobSchedulerWthQuartzNETAttempt1
{
    partial class JobManagerUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Failed 2 minutes ago");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tickets", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Tasks");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Cherwell", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Footprints");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("ITSM", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Control-M");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Windows Task Scheduler");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("cron");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Runners", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Localization", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode10});
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slipScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseNextRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.cmForCherwellJobFailed = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.retry3rdTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveScheduleUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelTomorrowMorningsRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.cmForCherwellJobFailed.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQL Agent Job Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Localize Cherwell Tickets"});
            this.comboBox1.Location = new System.Drawing.Point(139, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Running",
            "Scheduled to Start Tomorrow Morning",
            "Disabled",
            "Failed Last Time",
            "Overran and had to Abort",
            "Ran Successfully and Timely Last n Times",
            "Keeps Failing Last n Times",
            "Intermittently Failes",
            "Ran Unusually Long Last Time",
            "Ran Unusually Short Last Time",
            "Still Constructing and Testing"});
            this.comboBox2.Location = new System.Drawing.Point(139, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(228, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Job Status";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Check Status";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Kill Job";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(140, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Edit Job";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(221, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Examine Run Stats";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(221, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Restart Job";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(139, 136);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Edit Schedule";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(959, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jobsToolStripMenuItem
            // 
            this.jobsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killToolStripMenuItem,
            this.editToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.editScheduleToolStripMenuItem,
            this.slipScheduleToolStripMenuItem,
            this.pauseNextRunToolStripMenuItem,
            this.startJobToolStripMenuItem});
            this.jobsToolStripMenuItem.Name = "jobsToolStripMenuItem";
            this.jobsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.jobsToolStripMenuItem.Text = "Jobs";
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.killToolStripMenuItem.Text = "Kill";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            // 
            // editScheduleToolStripMenuItem
            // 
            this.editScheduleToolStripMenuItem.Name = "editScheduleToolStripMenuItem";
            this.editScheduleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editScheduleToolStripMenuItem.Text = "Edit Schedule";
            // 
            // slipScheduleToolStripMenuItem
            // 
            this.slipScheduleToolStripMenuItem.Name = "slipScheduleToolStripMenuItem";
            this.slipScheduleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.slipScheduleToolStripMenuItem.Text = "Slip Schedule";
            // 
            // pauseNextRunToolStripMenuItem
            // 
            this.pauseNextRunToolStripMenuItem.Name = "pauseNextRunToolStripMenuItem";
            this.pauseNextRunToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pauseNextRunToolStripMenuItem.Text = "Pause Next Run";
            // 
            // startJobToolStripMenuItem
            // 
            this.startJobToolStripMenuItem.Name = "startJobToolStripMenuItem";
            this.startJobToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startJobToolStripMenuItem.Text = "Start Job";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 191);
            this.treeView1.Name = "treeView1";
            treeNode1.ContextMenuStrip = this.cmForCherwellJobFailed;
            treeNode1.Name = "Node10";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.Text = "Failed 2 minutes ago";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Tickets";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Tasks";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Cherwell";
            treeNode5.Name = "Node9";
            treeNode5.Text = "Footprints";
            treeNode6.Name = "Node1";
            treeNode6.Text = "ITSM";
            treeNode6.ToolTipText = "Service Management";
            treeNode7.Name = "Node4";
            treeNode7.Text = "Control-M";
            treeNode8.Name = "Node7";
            treeNode8.Text = "Windows Task Scheduler";
            treeNode9.Name = "Node8";
            treeNode9.Text = "cron";
            treeNode10.Name = "Node2";
            treeNode10.Text = "Runners";
            treeNode11.Name = "Node0";
            treeNode11.Text = "Localization";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(657, 370);
            this.treeView1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Run History";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(85, 167);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 22);
            this.button7.TabIndex = 13;
            this.button7.Text = "Change Scope to Selected";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // cmForCherwellJobFailed
            // 
            this.cmForCherwellJobFailed.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.cmForCherwellJobFailed.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retry3rdTimeToolStripMenuItem,
            this.descheduleToolStripMenuItem,
            this.moveScheduleUpToolStripMenuItem,
            this.cancelTomorrowMorningsRunToolStripMenuItem});
            this.cmForCherwellJobFailed.Name = "cmForCherwellJobFailed";
            this.cmForCherwellJobFailed.Size = new System.Drawing.Size(250, 92);
            // 
            // retry3rdTimeToolStripMenuItem
            // 
            this.retry3rdTimeToolStripMenuItem.Name = "retry3rdTimeToolStripMenuItem";
            this.retry3rdTimeToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.retry3rdTimeToolStripMenuItem.Text = "Retry (3rd time)";
            // 
            // descheduleToolStripMenuItem
            // 
            this.descheduleToolStripMenuItem.Name = "descheduleToolStripMenuItem";
            this.descheduleToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.descheduleToolStripMenuItem.Text = "Deschedule";
            // 
            // moveScheduleUpToolStripMenuItem
            // 
            this.moveScheduleUpToolStripMenuItem.Name = "moveScheduleUpToolStripMenuItem";
            this.moveScheduleUpToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.moveScheduleUpToolStripMenuItem.Text = "Move Schedule Up from 4:00 AM";
            // 
            // cancelTomorrowMorningsRunToolStripMenuItem
            // 
            this.cancelTomorrowMorningsRunToolStripMenuItem.Name = "cancelTomorrowMorningsRunToolStripMenuItem";
            this.cancelTomorrowMorningsRunToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.cancelTomorrowMorningsRunToolStripMenuItem.Text = "Cancel Tomorrow Morning\'s Run";
            // 
            // JobManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 730);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "JobManagerUI";
            this.Text = "Job Manager View";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmForCherwellJobFailed.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slipScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseNextRunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startJobToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ContextMenuStrip cmForCherwellJobFailed;
        private System.Windows.Forms.ToolStripMenuItem retry3rdTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveScheduleUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelTomorrowMorningsRunToolStripMenuItem;
    }
}

