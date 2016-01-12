using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;

namespace TravelExpertsDesktopApp
{
    public partial class frmAddEdit : MetroFramework.Forms.MetroForm
    {
        private string message;


        public frmAddEdit()
        {
            InitializeComponent();
        }

        public frmAddEdit(string message)
        {            
            InitializeComponent();
            this.Text = message;
            this.message = message;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(message);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

    }
}
