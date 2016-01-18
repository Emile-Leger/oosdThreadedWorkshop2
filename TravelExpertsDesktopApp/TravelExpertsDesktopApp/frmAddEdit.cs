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
        private Package activePackage;


        public frmAddEdit()
        {
            InitializeComponent();
        }
        //The form is in edit mode
        public frmAddEdit(string message, Package package)
        {            
            InitializeComponent();
            this.Text = message;
            this.message = message;
            this.activePackage = package;
            displayPackage();
            btnConfirm.Text = "Edit";
        }
        //the form is in add mode
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
            string newBasePrice = txtPrice.Text.Replace(",","").Replace("$","");
            string newCommission = txtCommission.Text.Replace(",", "").Replace("$", "");
                 
            Package newPackage = new Package();
            newPackage.PkgName = txtName.Text;
            newPackage.PkgStartDate = dtpStart.Value;
            newPackage.PkgEndDate = dtpEnd.Value;
            newPackage.PkgDesc = txtDescription.Text;                
            newPackage.PkgBasePrice = Convert.ToDecimal(newBasePrice);
            newPackage.PkgAgencyCommission = Convert.ToDecimal(newCommission);
            newPackage.PkgImg = activePackage.PkgImg;
            try
            {
                if (this.message == "Enter Package Details")
                {
                    TravelExpertsDB.TravelExpertsDB.AddPackage(newPackage);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    TravelExpertsDB.TravelExpertsDB.UpdatePackage(activePackage, newPackage);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
               
    }
}
