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

namespace TravelExpertsDesktopApp
{
    public partial class frmAddEdit : MetroFramework.Forms.MetroForm
    {
        private string message;
        public Package activePackage { get; set; }


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
            displayPackage();
            btnConfirm.Text = "Edit";
        }
        //the form constructor for add mode
        public frmAddEdit(string message)
        {
            InitializeComponent();
            this.Text = message;
            this.message = message;
            this.activePackage = new Package();
            btnConfirm.Text = "Add";
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
            if (activePackage.PkgImg != null)
                pbImage.Image = MainForm.arrayToImage(activePackage.PkgImg);
            foreach (Product_Supplier ps in activePackage.productSuppliers)
            {
                ListViewItem lvi = new ListViewItem(new[] { ps.ProductName, ps.SupName });
                lvProductSuppliers.Items.Add(lvi);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Package newPackage = new Package();
            newPackage = createPackage();
            try
            {
                if (this.message == "Enter Package Details")//the user is in the add form
                {
                    if (TravelExpertsDB.TravelExpertsDB.AddPackage(newPackage) > 0)
                    {
                        this.DialogResult = DialogResult.OK;                        
                        this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Abort;//add failed, close the form and display a message
                    }                    
                }
                else
                {

                    if (TravelExpertsDB.TravelExpertsDB.UpdatePackage(activePackage, newPackage))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Abort;//update failed, close the form and display message
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private Package createPackage()
        {
            Package newPackage = new Package();
            //handle the ToString currency format
            string newBasePrice = txtPrice.Text.Replace(",", "").Replace("$", "");
            string newCommission = txtCommission.Text.Replace(",", "").Replace("$", "");
            //create a new package from the form controls     

            newPackage.PkgName = txtName.Text;
            newPackage.PkgStartDate = dtpStart.Value;
            newPackage.PkgEndDate = dtpEnd.Value;
            newPackage.PkgDesc = txtDescription.Text;
            newPackage.PkgBasePrice = Convert.ToDecimal(newBasePrice);
            newPackage.PkgAgencyCommission = Convert.ToDecimal(newCommission);
            newPackage.PkgImg = activePackage.PkgImg;
            return newPackage;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
        //Select an image for the active package, must be JPG format
        private void btnImg_Click(object sender, EventArgs e)
        {
            Image pkgImage; ;
            byte[] imageData;
            ofdImage.InitialDirectory = "C:\\Users\\433080\\Desktop\\images";
            ofdImage.Filter = "Image files (*.jpg)|*.jpg";
            ofdImage.FileName = "";
            ofdImage.ShowDialog();
            if (ofdImage.FileName != "")
            {
                using (FileStream fs = new FileStream(ofdImage.FileName, FileMode.Open, FileAccess.Read))
                {
                    imageData = new byte[fs.Length];
                    activePackage.PkgImg = imageData;
                    fs.Read(imageData, 0, (int)fs.Length);
                }
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pkgImage = Image.FromStream(ms);
                    //pkgImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                }

                pbImage.Image = pkgImage;
            }
            else
            {
                pbImage = null;
            }
        }

        private void btnEditProducts_Click(object sender, EventArgs e)
        {
            if (activePackage != null)
            {
                frmEditProductSuppliers myForm = new frmEditProductSuppliers(activePackage);
                myForm.ShowDialog();
            }
            else
            {
                Package p = createPackage();
                frmEditProductSuppliers myForm = new frmEditProductSuppliers(p);
                myForm.ShowDialog();
            }
        }
               
    }
}
