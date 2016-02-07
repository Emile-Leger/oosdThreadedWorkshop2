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
        const string PRODUCT_MESSAGE = "Edit Product Name";
        const string SUPPLIER_MESSAGE = "Edit Supplier Name";
        const string ADD_MESSAGE = "Enter Package Details";
        const string EDIT_MESSAGE = "Edit Package Details";
        
        private Product activeProduct;
        private Supplier activeSupplier;
        public Package activePackage;
        public List<Package> packages;
        public Supplier ActiveSupplier
        {
            get
            {
                return activeSupplier;
            }
            set
            {
                activeSupplier = value;
                btnEditProdSupp.Text = SUPPLIER_MESSAGE;
                btnAddProdSup.Text = "Add Supplier";
                lblEntityMode.Text = "Supplier";
                lblProdOrSup.Text = "Products supplied by " + ActiveSupplier.SupName;
                lblBy.Text = "by";
                txtName.Text = ActiveSupplier.SupName;
                lblSupplier.Text = ActiveSupplier.SupName;                                
            }
        }
        public Product ActiveProduct
        {
            get
            {
                return activeProduct;
            }
            set
            {
                activeProduct = value;
                lblProdOrSup.Text = "Suppliers of " + ActiveProduct.ProdName;
                txtName.Text = ActiveProduct.ProdName;
                lblProduct.Text = ActiveProduct.ProdName;
                btnEditProdSupp.Text = PRODUCT_MESSAGE;
                btnAddProdSup.Text = "Add Product";
                lblEntityMode.Text = "Product";                
            }
        }               
        public List<Product_Supplier> productSuppliers { get { return TravelExpertsDB.TravelExpertsDB.getAllProductSuppliers(); } }//look at

        public MainForm()
        {
            InitializeComponent();
                                     
        }
        //when the form loads, display the names of each product in the combo box
        private void MainForm_Load(object sender, EventArgs e)
        {
            StyleManager = msmStyle;
            msmStyle.Style = MetroFramework.MetroColorStyle.Blue;
            ClearControls();
            updatePackages();
            fillDGVs();
             
            
        }
        //initialize the data grid views on the Manage Product-Suppliers tab panel
        private void fillDGVs()
        {
            dgvSuppliers.DataSource = TravelExpertsDB.TravelExpertsDB.GetAllSuppliers();
            dgvProducts.DataSource = TravelExpertsDB.TravelExpertsDB.GetAllProducts();
            foreach (var ctrl in tpProductSuppliers.Controls)
            {
                if (ctrl is DataGridView)
                {
                    DataGridView dgv = (DataGridView)ctrl;
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgv.RowHeadersVisible = false;
                    dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    if (dgv.Name != "dgvResults")
                        dgv.Columns[0].Visible = false;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv.AutoResizeColumns();
                }
            }
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
                MessageBox.Show("Successfully added " + myForm.activePackage);
                ClearControls();
                updatePackages();
                fillDGVs(); 
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
                if (myForm.DialogResult == DialogResult.OK)
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
            lblPkgName.Text = "";            
            pbPkgImg.Image = null;
            cbPackages.Focus();
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
            lblPkgName.Text = activePackage.PkgName;
            cbPackages.Text = activePackage.PackageId.ToString();
            if (activePackage.PkgImg.Length != 4)
                pbPkgImg.Image = arrayToImage(activePackage.PkgImg);
            foreach (Product_Supplier ps in activePackage.productSuppliers)
            {
                ListViewItem lvi = new ListViewItem(new[] { ps.ProductName, ps.SupName });
                lvProductSuppliers.Items.Add(lvi);
            }         
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();            
        }

        //converts a byte array into an image object for display on the form
        public static Image arrayToImage(byte[] pkgImage)
        {
            using (MemoryStream ms = new MemoryStream(pkgImage))
            {
                return Image.FromStream(ms);
            }
        }        
                            
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (activePackage != null)
            {
                DialogResult result = MessageBox.Show("Really delete " + activePackage + " ? ", "Delete Package", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    TravelExpertsDB.TravelExpertsDB.RemoveAllProductSuppliersFromPackage(activePackage.PackageId);
                    TravelExpertsDB.TravelExpertsDB.DeletePackage(activePackage.PackageId);                    
                    updatePackages();
                    ClearControls();                    
                }
            }
        }
                
        //populates the datagrid view with the list of suppliers that provide the selected project
        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count != 0)
            {                                
                ActiveSupplier = (Supplier)dgvSuppliers.SelectedRows[0].DataBoundItem;                               
                dgvResults.DataSource = TravelExpertsDB.TravelExpertsDB.GetProductsFromSupplierId(activeSupplier.SupplierID);
                dgvResults.Columns[0].Visible = false;                
            }
        }
        //populates the datagrid view with the products supplied by the selected supplier
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.SelectedRows.Count != 0)
            {                
                ActiveProduct = (Product)dgvProducts.SelectedRows[0].DataBoundItem;                                
                dgvResults.DataSource = TravelExpertsDB.TravelExpertsDB.GetSuppliersFromProductId(ActiveProduct.ProductId);
                dgvResults.Columns[0].Visible = false;
            }
        }
        //Creates a new product-supplier from the selections of the first two datagrid views, the 
        private void btnCreateProdSup_Click(object sender, EventArgs e)
        {
            if (ActiveProduct != null && activeSupplier != null)
            {
                Product_Supplier newProdSup = createProductSupplier();
                if (ProdSupDoesNotExist(newProdSup))
                {
                    newProdSup.ProductSupplierId = TravelExpertsDB.TravelExpertsDB.AddProduct_Supplier(newProdSup);
                    MessageBox.Show("Added " + newProdSup);
                    fillDGVs();
                }
                else
                {
                    MessageBox.Show(newProdSup + " already exists and was not added.");
                }

            }
        }

        // creates a Product_Supplier obbject from the selected indices of each datagrid
        private Product_Supplier createProductSupplier()
        {
            Product_Supplier newProdSup = new Product_Supplier();
            newProdSup.ProductId = ActiveProduct.ProductId;
            newProdSup.ProductName = ActiveProduct.ProdName;
            newProdSup.SupName = activeSupplier.SupName;
            newProdSup.SupplierId = activeSupplier.SupplierID;
            return newProdSup;
        }

        //checks if the product supplier the user wants to add exists.
        public bool ProdSupDoesNotExist(Product_Supplier newPS)
        {
            var prodSups = productSuppliers.Where<Product_Supplier>(x => x.ProductName == newPS.ProductName && x.SupName == newPS.SupName);
            if (prodSups.Count() == 0)
            {
                return true;
            }

            return false;
        }

        //edit the name of a product or supplier 
        private void btnEditProdSupp_Click(object sender, EventArgs e)
        {
            //the user wants to edit a product
            if (btnEditProdSupp.Text == PRODUCT_MESSAGE)
            {
                Product newProduct = new Product();
                newProduct.ProdName = txtName.Text;
                newProduct.ProductId = ActiveProduct.ProductId;
                TravelExpertsDB.TravelExpertsDB.UpdateProduct(ActiveProduct,newProduct);
                fillDGVs();
            }
            //the user wants to edit a supplier
            if(btnEditProdSupp.Text == SUPPLIER_MESSAGE)
            {                
                Supplier newSupp = new Supplier();
                newSupp.SupName = txtName.Text;
                newSupp.SupplierID = activeSupplier.SupplierID;
                TravelExpertsDB.TravelExpertsDB.UpdateSupplier(activeSupplier,newSupp);
                fillDGVs();
            }
        }
        //add a new product or supplier.
        private void btnAddProdSup_Click(object sender, EventArgs e)
        {
            //the user wants to add a product
            if (btnEditProdSupp.Text == PRODUCT_MESSAGE)
            {
                Product newProduct = new Product();
                newProduct.ProdName = txtNewName.Text;                
                TravelExpertsDB.TravelExpertsDB.AddProduct(newProduct);
                fillDGVs();
            }
            //the user wants to add a supplier
            if (btnEditProdSupp.Text == SUPPLIER_MESSAGE)
            {
                Supplier newSupp = new Supplier();
                newSupp.SupName = txtNewName.Text;
                newSupp.SupplierID = GenerateSupplierId();
                TravelExpertsDB.TravelExpertsDB.AddSupplier(newSupp);
                fillDGVs();
            }
        }
        //reset the controls
        public void clearSelectedIndices()
        {
            dgvProducts.ClearSelection();
            dgvSuppliers.ClearSelection();
            dgvResults.ClearSelection();
            txtName.Text = "";
            txtNewName.Text = "";
            lblBy.Text = "";
            lblProduct.Text = "";
            lblSupplier.Text = "";
        }
        //generates a unique supplier ID for creating a new supplier.
        public int GenerateSupplierId()
        {
            List<Supplier> suppliers = TravelExpertsDB.TravelExpertsDB.GetAllSuppliers();//check against the database
            List<Supplier> sortedList = suppliers.OrderBy(x => x.SupplierID).ToList();//order by ascending supplier ID
            int newId = 0;
            foreach (var supplier in sortedList)
            {
                if (newId == supplier.SupplierID)//the supplier id is taken, next.
                    newId++;
                else//the supplier id is free
                    return newId;//use it
            }
            return -1;//something has gone horrible wrong
        }      
    }
}
