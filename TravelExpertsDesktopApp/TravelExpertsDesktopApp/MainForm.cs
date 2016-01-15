using MetroFramework.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsDB;


namespace TravelExpertsDesktopApp
{

   
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        const string ADD_MESSAGE = "Enter Package Details";
        const string EDIT_MESSAGE = "Edit Package Details";
        public Package activePackage;

        public MainForm()
        {
            InitializeComponent();
            this.StyleManager = msmStyle;
            
        }        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEdit myForm = new frmAddEdit(ADD_MESSAGE);            
            myForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {            
            frmAddEdit myForm = new frmAddEdit(EDIT_MESSAGE);            
            myForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

      
        // to clear the textboxes
        private void ClearControls()
        {
            lblStart.Text = "";
            lblEnd.Text = "";
            lblBasePrice.Text = "";
            lblCommission.Text = "";
            cbPackages.SelectedIndex = 0;
            txtSearch.Text = "";             
            cbPackages.Select();
        }

        private void DisplayPackage()
        {
            lblStart.Text = activePackage.PkgStartDate.ToString();
            lblEnd.Text = activePackage.PkgEndDate.ToString();
            lblBasePrice.Text = activePackage.PkgBasePrice.ToString();
            lblCommission.Text = activePackage.PkgAgencyCommission.ToString();
            cbPackages.Text = activePackage.PackageId.ToString(); 
        }      
    }
}
