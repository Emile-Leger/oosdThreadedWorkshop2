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
    public partial class editProductSuppliers : MetroFramework.Forms.MetroForm
    {
        List<Product_Supplier> prodSups;
        public editProductSuppliers(Package activePackage)
        {
            InitializeComponent();

        }

        private void editProductSuppliers_Load(object sender, EventArgs e)
        {
            prodSups = TravelExpertsDB.TravelExpertsDB.getAllProductSuppliers();
            foreach (Product_Supplier prodSup in prodSups)
	        {
		         cbProductSuppliers.Items.Add(prodSup);
	        }
            
        }

    }
}
