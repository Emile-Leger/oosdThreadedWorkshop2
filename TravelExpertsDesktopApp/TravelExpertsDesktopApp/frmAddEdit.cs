using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsDB;
using System.IO;
using System.Data.SqlClient;

namespace TravelExpertsDesktopApp
{
    public partial class frmAddEdit : MetroFramework.Forms.MetroForm
    {
        private string message; //this property is a parameter of the forms constructor it distiguishes the add and edit modes of the form
        private byte[] PkgImg; //a placeholder array for holding image date with no active package
        public Package activePackage { get; set; }
        public Package newPackage { get; set; }


        public frmAddEdit()
        {
            InitializeComponent();
        }

        //The form constructor for edit mode
        public frmAddEdit(string message, Package package)
        {            
            InitializeComponent();
            this.Text = message;
            this.message = message;
            this.activePackage = package;
            PkgImg = package.PkgImg;
            displayPackage();
            btnConfirm.Text = "Confirm";
        }

        //the form constructor for add mode
        public frmAddEdit(string message)
        {
            InitializeComponent();
            this.Text = message;
            this.message = message;           
            btnConfirm.Text = "Add";
        }

        //format the Product-supplier list view
        private void frmAddEdit_Load(object sender, EventArgs e)
        {
            ListView lstView = lvProductSuppliers;
            int nCols = lstView.Columns.Count;
            if (nCols > 0)
            {
                int colWidth = 0;
                foreach (ColumnHeader column in lstView.Columns)
                {
                    colWidth += column.Width;
                }
                lstView.Columns[nCols - 1].Width = lstView.Columns[nCols - 1].Width + (lstView.Width - colWidth);
            }
        }

        //update controls with active package data
        private void displayPackage()
        {            
            txtName.Text = activePackage.PkgName;
            txtPrice.Text = activePackage.PkgBasePrice.ToString("c");
            txtCommission.Text = activePackage.PkgAgencyCommission.ToString("c");
            dtpStart.Text = activePackage.PkgStartDate.ToShortDateString();
            dtpEnd.Text = activePackage.PkgEndDate.ToShortDateString();
            txtDescription.Text = activePackage.PkgDesc;
            if (activePackage.PkgImg.Length != 4)//this indicates that 
                pbImage.Image = MainForm.arrayToImage(activePackage.PkgImg);
            lvProductSuppliers.Items.Clear();
            foreach (Product_Supplier ps in activePackage.productSuppliers)
            {
                ListViewItem lvi = new ListViewItem(new[] { ps.ProductName, ps.SupName });
                lvProductSuppliers.Items.Add(lvi);               
            }
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {            
            if (isValidData())
            {
                createPackage();//creates a packages out of form controls
                try
                {
                    //if (message == "Enter Package Details")//the user is in the add form
                    if(activePackage == null)
                    {
                        int newID = TravelExpertsDB.TravelExpertsDB.AddPackage(newPackage);//add the package
                        if (newID != -1)
                        {
                            newPackage.PackageId = newID;
                            activePackage = newPackage;
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            DialogResult = DialogResult.Abort;//add failed, close the form and display a message
                        }
                    }
                    else
                    {
                        if (TravelExpertsDB.TravelExpertsDB.UpdatePackage(activePackage, newPackage))
                        {
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            DialogResult = DialogResult.Abort;//update failed, close the form and display message
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add Failed " + ex.Message);
                }
            }
        }

        private void createPackage()
        {            
            //handle the ToString currency format
            string newBasePrice = txtPrice.Text.Replace(",", "").Replace("$", "");
            string newCommission = txtCommission.Text.Replace(",", "").Replace("$", "");

            //create a new package from the form controls
            newPackage = new Package();
            newPackage.PkgName = txtName.Text;
            newPackage.PkgStartDate = dtpStart.Value;
            newPackage.PkgEndDate = dtpEnd.Value;
            newPackage.PkgDesc = txtDescription.Text;
            newPackage.PkgBasePrice = Convert.ToDecimal(newBasePrice);
            if (txtCommission.Text == "")
                newPackage.PkgAgencyCommission = 0m;
            else                         
                newPackage.PkgAgencyCommission = Convert.ToDecimal(newCommission);
            if (PkgImg != null)
                newPackage.PkgImg = PkgImg;
                        
        }
        //close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {                    
            Close();
        }
        //Select an image for the active package, must be JPG format
        private void btnImg_Click(object sender, EventArgs e)
        {
            Image pkgImage;             
            ofdImage.InitialDirectory = "C:\\Users\\433080\\Desktop\\images";
            ofdImage.Filter = "Image files (*.jpg)|*.jpg";
            ofdImage.FileName = "";
            ofdImage.ShowDialog();
            if (ofdImage.FileName != "")
            {
                using (FileStream fs = new FileStream(ofdImage.FileName, FileMode.Open, FileAccess.Read))
                {
                    PkgImg = new byte[fs.Length];
                    if (activePackage != null)
                        activePackage.PkgImg = PkgImg;
                    fs.Read(PkgImg, 0, (int)fs.Length);
                }
                using (MemoryStream ms = new MemoryStream(PkgImg))
                {
                    pkgImage = Image.FromStream(ms);                    
                }

                pbImage.Image = pkgImage;
            }
            else
            {
                pbImage = null;
            }
        }
        //opens the Products section for the active package. if there is no active package
        private void btnEditProducts_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {                
                if (activePackage != null)
                {                    
                    frmEditProductSuppliers myForm = new frmEditProductSuppliers(activePackage);
                    myForm.ShowDialog();
                }
                else
                {
                    createPackage();
                    int PackageId = TravelExpertsDB.TravelExpertsDB.AddPackage(newPackage);
                    newPackage.PackageId = PackageId;
                    activePackage = newPackage;
                    frmEditProductSuppliers myForm = new frmEditProductSuppliers(activePackage);
                    myForm.ShowDialog();
                    
                }
                
                if (activePackage.productSuppliers != null)
                {
                    lvProductSuppliers.Items.Clear();
                    foreach (Product_Supplier ps in activePackage.productSuppliers)
                    {
                        ListViewItem lvi = new ListViewItem(new[] { ps.ProductName, ps.SupName });
                        lvProductSuppliers.Items.Add(lvi);
                    }
                }
            }
        }
        
        private bool isValidData()
        {
            string newBasePrice = txtPrice.Text.Replace(",", "").Replace("$", "");
            string newCommission = txtCommission.Text.Replace(",", "").Replace("$", "");
            txtPrice.Text = txtPrice.Text.Replace(",", "").Replace("$", "");
            txtCommission.Text = txtCommission.Text.Replace(",", "").Replace("$", "");
            if (Validator.IsPresent(txtName, "Package Name") && Validator.IsPresent(txtPrice, "Package base price") 
             && Validator.IsPresent(txtDescription, "Package Description") && Validator.IsDecimal(txtPrice, "Package base price") 
             && Validator.IsPositive(txtPrice, "Package base price"))                
            {
                if (Validator.IsPresent(txtCommission) && Validator.IsDecimal(txtCommission, "Package Commission") 
                && Validator.IsPositive(txtCommission, "Package Commission") && !Validator.PriceIsGreaterThan(newBasePrice, newCommission))
                {
                    MessageBox.Show("The package commission must be lower than the base price");
                    return false;
                }

                if (dtpStart.Value != DateTime.Now && dtpEnd.Value != DateTime.Now)
                {
                    if (!Validator.DateIsAfter(dtpStart.Value, dtpEnd.Value))
                    {
                        MessageBox.Show("The package end date emust be after the start date");
                        return false;
                    }
                }
                return true;                   
            }
            return false;    
        }               
    }
}
