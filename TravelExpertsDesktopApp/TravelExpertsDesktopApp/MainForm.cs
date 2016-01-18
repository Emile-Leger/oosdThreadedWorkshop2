using MetroFramework.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        public List<Package> packages;

        public MainForm()
        {
            InitializeComponent();
            this.StyleManager = msmStyle;            
        }
        //when the form loads, display the names of each product in the combo box
        private void MainForm_Load(object sender, EventArgs e)
        {
            ClearControls();
            updatePackages();
        }
        //fills the combo box with packages from the database
        private void updatePackages()
        {            
            cbPackages.Items.Clear();
            packages = TravelExpertsDB.TravelExpertsDB.GetAllPackages();
            foreach (Package package in packages)
            {
                cbPackages.Items.Add(package);
            }
        }
        //show the add/edit form in add mode, ie, no active product.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEdit myForm = new frmAddEdit(ADD_MESSAGE);            
            myForm.ShowDialog();
        }
        //show the add/edit dialogue, in edit mode, ie imports the active package
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (activePackage != null)
            {
                frmAddEdit myForm = new frmAddEdit(EDIT_MESSAGE, activePackage);
                myForm.ShowDialog();
                if (myForm.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    updatePackages();
                    ClearControls();
                }
            }
            else
            {
                MessageBox.Show("Please select a package to edit.");
            }
        }

        
        //set the active package based on the combo box selection
        private void cbPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearControls();
            activePackage = (Package)cbPackages.SelectedItem;
            activePackage.fillSuppliers();
            DisplayPackage();
        }

      
        // to clear the textboxes
        private void ClearControls()
        {
            lblStart.Text = "";
            lblEnd.Text = "";
            lblPrice.Text = "";
            lblCommission.Text = "";
            lblDescription.Text = "";
            txtSearch.Text = "";
            pbPkgImg.Image = null;
            cbPackages.Focus();
            txtSearch.Focus();
            lbProductSuppliers.Items.Clear();             
        }
        //Displays all the data from the active package
        private void DisplayPackage()
        {
            lblStart.Text = activePackage.PkgStartDate.ToString();
            lblEnd.Text = activePackage.PkgEndDate.ToString();
            lblDescription.Text = activePackage.PkgDesc;
            lblPrice.Text = activePackage.PkgBasePrice.ToString("c");
            lblCommission.Text = activePackage.PkgAgencyCommission.ToString("c");
            cbPackages.Text = activePackage.PackageId.ToString();
            if (activePackage.PkgImg != null)
                pbPkgImg.Image = MainForm.arrayToImage(activePackage.PkgImg);
            foreach (Product_Supplier ps in activePackage.productSuppliers)
            {
                lbProductSuppliers.Items.Add(ps); 
            }            
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //converts a byte array into an image object for display on the form
        public static Image arrayToImage(byte[] pkgImage)
        {
            using (MemoryStream ms = new MemoryStream(pkgImage))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
