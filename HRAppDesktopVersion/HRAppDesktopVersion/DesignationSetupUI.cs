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
    public partial class DesignationSetupUI : Form
    {
        public DesignationSetupUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Designation aDesignation = new Designation() {  Title = designationTextBox.Text, Responsibility = responsibilityTextBox.Text };
            EmployeeDbGateway employeeDb = new EmployeeDbGateway();
            employeeDb.AddDesignation(aDesignation);
            ShowDesginations();
        }

        private void DesignationSetupUI_Load(object sender, EventArgs e)
        {
            ShowDesginations();
        }

        void ShowDesginations()
        {
            EmployeeDbGateway employeeDb = new EmployeeDbGateway();
            List<Designation> designations = employeeDb.GetDesginations();

            designationListView.Items.Clear();
            foreach (Designation designation in designations)
            {
                string RowTesx = designation.Title + ", " + designation.Responsibility;
                designationListView.Items.Add(RowTesx);
            }
        }
    }
}
