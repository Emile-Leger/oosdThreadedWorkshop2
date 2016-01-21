﻿using System;
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
    public partial class frmEditProductSuppliers : MetroFramework.Forms.MetroForm
    {
        List<Product_Supplier> prodSups; //the complete list of product suppliers
        List<Product_Supplier> addedProdSups;//the list of Product_Suppliers added, waiting to be committed to the package
        public Package activePackage { get; set; } //the selected package
        public Product_Supplier selectedProductSupplier { get; set; } //the product suppliers selected from the list of active package product suppliers

        //form constructor, sets active package, fills the product suppliers
        public frmEditProductSuppliers(Package package)
        {
            InitializeComponent();
            activePackage = package;
            this.Text = activePackage.PkgName;
            activePackage.fillSuppliers();
        }
        //on form load, fill the list of product suppliers and update the display
        private void editProductSuppliers_Load(object sender, EventArgs e)
        {
            prodSups = TravelExpertsDB.TravelExpertsDB.getAllProductSuppliers();
            updateDisplay();            
        }
        
                        
        //get the product supplier selected by the user.
        private void dgvProdSups_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgvProdSups.SelectedRows.Count != 0)
            {
                selectedProductSupplier = (Product_Supplier)dgvProdSups.SelectedRows[0].DataBoundItem;                
            }
            
        }
        //add the product_Supplier selected from the combo box to the package.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbProductSuppliers.SelectedItem != null)
                {
                    Product_Supplier newPs = (Product_Supplier)cbProductSuppliers.SelectedItem;
                    TravelExpertsDB.TravelExpertsDB.addProductSupplierToPackage(newPs, activePackage);
                    activePackage.fillSuppliers();
                    updateDisplay();
                }
                else
                {
                    MessageBox.Show("Please select a Product-Supplier to add");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(selectedProductSupplier.ToString() + " has already been added to " + activePackage.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to add " + selectedProductSupplier.ToString());
            }
        }
        //removes the selected product supplier from the package
        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (selectedProductSupplier != null || activePackage.productSuppliers.Count == 0)
            {
                if (TravelExpertsDB.TravelExpertsDB.removeProductSupplier(selectedProductSupplier.ProductSupplierId, activePackage.PackageId))
                {  //a row from Packages_Products_suppliers is deleted                        
                    activePackage.fillSuppliers();
                    updateDisplay();
                }
                else
                {
                    MessageBox.Show("Failed to remove " + selectedProductSupplier.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select a product-supplier to remove.");
            }
        }
        
       
        //method to update the display of the dialog
        private void updateDisplay()
        {
            foreach (Product_Supplier prodSup in prodSups)
            {
                cbProductSuppliers.Items.Add(prodSup);
            }
            dgvProdSups.DataSource = activePackage.productSuppliers;
            dgvProdSups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdSups.RowHeadersVisible = false;
            dgvProdSups.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProdSups.Columns[0].Visible = false;
            dgvProdSups.Columns[1].Visible = false;
            dgvProdSups.Columns[3].Visible = false;
            dgvProdSups.AutoResizeColumns();
            dgvProdSups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
