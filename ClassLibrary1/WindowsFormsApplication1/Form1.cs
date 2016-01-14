using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (TravelExpertsDB.TravelExpertsDB.GetPackage(2) == null) MessageBox.Show("null");
            //TravelExpertsDB.Package pkg=new TravelExpertsDB.Package();
            //pkg.PackageID=5;
            //pkg.PkgName="jhkjk";
            //pkg.PkgStartDate=new DateTime(2015, 1, 18);
            //pkg.PkgEndDate=new DateTime(2016, 1, 18);
            //pkg.PkgDesc="nhkjh";
            //pkg.PkgBasePrice=2000.00M;
            //pkg.PkgAgencyCommission=150.00M;
            //TravelExpertsDB.TravelExpertsDB.AddPackage(pkg);


            List<Product> prod = TravelExpertsDB.GetProductsFromPackageId(4);
            DGV.DataSource = prod;


            //MessageBox.Show(test.ToString());
        }
    }
}
