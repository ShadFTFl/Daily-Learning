using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRAppDesktopVersion
{
    public partial class DashboardUI : Form
    {
        public DashboardUI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSummaryReportUI aEmployeeSummaryReportUI = new EmployeeSummaryReportUI();
            aEmployeeSummaryReportUI.Show();
        }

        private void designationEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesignationSetupUI aDesignationSetupUI = new DesignationSetupUI();
            aDesignationSetupUI.Show();
        }

        private void setupEvaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvaluationSetupUI aEvaluationSetupUI = new EvaluationSetupUI();
            aEvaluationSetupUI.Show();
        }

        private void employeeEvaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeEvaluationEntryUI employeeEvaluationEntryUI = new EmployeeEvaluationEntryUI();
            employeeEvaluationEntryUI.Show();
        }

        private void employeeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeEntryUI anEmployeeEntryUI = new EmployeeEntryUI();
            anEmployeeEntryUI.Show();
        }
    }
}
