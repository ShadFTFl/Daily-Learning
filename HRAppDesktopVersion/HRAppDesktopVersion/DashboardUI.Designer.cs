namespace HRAppDesktopVersion
{
    partial class DashboardUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminActivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frequentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeEvaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designationEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupEvaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.adminActivityToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.employeeToolStripMenuItem.Text = "Employee Summary Report";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // adminActivityToolStripMenuItem
            // 
            this.adminActivityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frequentToolStripMenuItem,
            this.masterToolStripMenuItem});
            this.adminActivityToolStripMenuItem.Name = "adminActivityToolStripMenuItem";
            this.adminActivityToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.adminActivityToolStripMenuItem.Text = "Admin Activity";
            // 
            // frequentToolStripMenuItem
            // 
            this.frequentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeEntryToolStripMenuItem,
            this.employeeEvaluationToolStripMenuItem});
            this.frequentToolStripMenuItem.Name = "frequentToolStripMenuItem";
            this.frequentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.frequentToolStripMenuItem.Text = "Frequent";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.designationEntryToolStripMenuItem,
            this.setupEvaluationToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // employeeEntryToolStripMenuItem
            // 
            this.employeeEntryToolStripMenuItem.Name = "employeeEntryToolStripMenuItem";
            this.employeeEntryToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.employeeEntryToolStripMenuItem.Text = "Employee Entry";
            this.employeeEntryToolStripMenuItem.Click += new System.EventHandler(this.employeeEntryToolStripMenuItem_Click);
            // 
            // employeeEvaluationToolStripMenuItem
            // 
            this.employeeEvaluationToolStripMenuItem.Name = "employeeEvaluationToolStripMenuItem";
            this.employeeEvaluationToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.employeeEvaluationToolStripMenuItem.Text = "Employee Evaluation";
            this.employeeEvaluationToolStripMenuItem.Click += new System.EventHandler(this.employeeEvaluationToolStripMenuItem_Click);
            // 
            // designationEntryToolStripMenuItem
            // 
            this.designationEntryToolStripMenuItem.Name = "designationEntryToolStripMenuItem";
            this.designationEntryToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.designationEntryToolStripMenuItem.Text = "Setup Designation";
            this.designationEntryToolStripMenuItem.Click += new System.EventHandler(this.designationEntryToolStripMenuItem_Click);
            // 
            // setupEvaluationToolStripMenuItem
            // 
            this.setupEvaluationToolStripMenuItem.Name = "setupEvaluationToolStripMenuItem";
            this.setupEvaluationToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.setupEvaluationToolStripMenuItem.Text = "Setup Evaluation";
            this.setupEvaluationToolStripMenuItem.Click += new System.EventHandler(this.setupEvaluationToolStripMenuItem_Click);
            // 
            // DashboardUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 341);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminActivityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frequentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeEvaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designationEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupEvaluationToolStripMenuItem;
    }
}