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

namespace TravelExpertsDesktopApp
{
    public partial class SearchTest : Form
    {
        List<Product_Supplier> prodSups { get { return TravelExpertsDB.TravelExpertsDB.getAllProductSuppliers(); } }

        public SearchTest()
        {
            InitializeComponent();
        }       

        public List<Product_Supplier> SearchProdSups(string input)
        {            
            var results = from prodSup in prodSups
                          where prodSup.ProductName.ToLower().Contains(input.ToLower()) || prodSup.SupName.ToLower().Contains(input.ToLower())
                          select prodSup;            
            return results.ToList();                                           
        }

       

        private void cbProductSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = ((Product_Supplier)cbProductSuppliers.SelectedItem).ToString();

            
            cbProductSuppliers.DroppedDown = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            cbProductSuppliers.Items.Clear();
            cbProductSuppliers.Refresh();
            List<Product_Supplier> searchList = SearchProdSups(txtName.Text);
            foreach (var prodsup in searchList)
            {
                cbProductSuppliers.Items.Add(prodsup);
            }

            if (cbProductSuppliers.Items.Count > 8)
            {
                cbProductSuppliers.DropDownHeight = 8 * cbProductSuppliers.ItemHeight;
            }
            else
            {
                cbProductSuppliers.DropDownHeight = cbProductSuppliers.Items.Count * cbProductSuppliers.ItemHeight;
            }
            cbProductSuppliers.DroppedDown = true;
            Cursor.Current = Cursors.Default;
        }
    }
}
