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
            fillDGVs();       
        }
        //initialize the data grid views on the Manage Product-Suppliers tab panel
        private void fillDGVs()
        {
            dgvProducts.DataSource = TravelExpertsDB.TravelExpertsDB.GetAllProducts();
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProducts.Columns[0].Visible = false;            
            dgvProducts.AutoResizeColumns();
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            dgvSuppliers.DataSource = TravelExpertsDB.TravelExpertsDB.GetAllSuppliers();
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.RowHeadersVisible = false;
            dgvSuppliers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSuppliers.Columns[0].Visible = false;
            dgvSuppliers.AutoResizeColumns();
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResults.RowHeadersVisible = false;
            dgvResults.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;            
            dgvResults.AutoResizeColumns();
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            if (myForm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Successfully added" + myForm.activePackage);
            }
            else if (myForm.DialogResult == DialogResult.Abort)
            {
                MessageBox.Show("Failed to add" + myForm.activePackage +"please try again");
            }
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
                    MessageBox.Show("Successfully updated " + myForm.activePackage);
                }
                else if (myForm.DialogResult == DialogResult.Abort)
                {
                    MessageBox.Show("Failed to edit " + myForm.activePackage);
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
            lvProductSuppliers.Items.Clear();             
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
                ListViewItem lvi = new ListViewItem(new[] { ps.ProductName, ps.SupName });
                lvProductSuppliers.Items.Add(lvi);
            }           
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show(this.Size.ToString());
        }

        //converts a byte array into an image object for display on the form
        public static Image arrayToImage(byte[] pkgImage)
        {
            using (MemoryStream ms = new MemoryStream(pkgImage))
            {
                return Image.FromStream(ms);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmEditProductSuppliers edit = new frmEditProductSuppliers(activePackage);
            edit.ShowDialog();
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count != 0)
            {
                
                Product selectedProduct = (Product)dgvProducts.SelectedRows[0].DataBoundItem;
                int productId = selectedProduct.ProductId;
                lblProdOrSup.Text = "All suppliers of " + selectedProduct.ProdName;
                dgvResults.DataSource = TravelExpertsDB.TravelExpertsDB.GetSuppliersFromProductId(productId);
                dgvResults.Columns[0].Visible = false;
            }
        }

        private void dgvSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count != 0)
            {
                
                Supplier selectedSupplier = (Supplier)dgvSuppliers.SelectedRows[0].DataBoundItem;
                int supplierId = selectedSupplier.SupplierID;
                lblProdOrSup.Text = "All Products supplied by " + selectedSupplier.SupName;
                dgvResults.DataSource = TravelExpertsDB.TravelExpertsDB.GetProductsFromSupplierId(supplierId);
                dgvResults.Columns[0].Visible = false;
            }
        }
    }
}
