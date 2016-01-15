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

        public MainForm()
        {
            InitializeComponent();
            this.StyleManager = msmStyle;
            
        }

        private Package package;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEdit myForm = new frmAddEdit();
            myForm.addpackage = true;
            DialogResult result = myForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                package = myForm.package;
                cbPackages.Text = package.ProductId.ToString();
                this.DisplayProduct();
            }
            //myForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {            
            frmAddEdit myForm = new frmAddEdit();
            myForm.addpackage = false;
            myForm.package = package;
            DialogResult result = myForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                package = myForm.package;
                this.DisplayProduct();
            }
            else 
            {
                this.GetProduct(package.PackageID);
                if (package != null)
                    this.DisplayProduct();
                else
                    this.ClearControls();
            }
          //  myForm.ShowDialog();
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
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            cbPackages.Select();
        }

        private void DisplayPackage()
        {
            lblStart.Text =package.PkgStartDate.ToString();
            lblEnd.Text = package.PkgEndDate.ToString();
            lblBasePrice.Text =package.PkgBasePrice.ToString();
            lblCommission.Text = package.PkgAgencyCommission.ToString();
            cbPackages.Text = package.PackageId.ToString(); 
        }

        private void getPackage(int packageId)
        {
            try
            {
                package = TravelExpertsDB.GetPackage(packageId);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString())
;
            }
        }
    }
}
