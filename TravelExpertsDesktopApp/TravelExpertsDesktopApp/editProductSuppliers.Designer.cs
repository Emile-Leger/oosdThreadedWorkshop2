namespace TravelExpertsDesktopApp
{
    partial class editProductSuppliers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbProductSuppliers = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.lblPackageName = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // cbProductSuppliers
            // 
            this.cbProductSuppliers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProductSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductSuppliers.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cbProductSuppliers.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cbProductSuppliers.FormattingEnabled = true;
            this.cbProductSuppliers.ItemHeight = 23;
            this.cbProductSuppliers.Location = new System.Drawing.Point(23, 124);
            this.cbProductSuppliers.Name = "cbProductSuppliers";
            this.cbProductSuppliers.Size = new System.Drawing.Size(285, 29);
            this.cbProductSuppliers.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbProductSuppliers.StyleManager = null;
            this.cbProductSuppliers.TabIndex = 0;
            this.cbProductSuppliers.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(23, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(160, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Select a Product Supplier:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(23, 159);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(285, 128);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(23, 293);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(91, 55);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Remove";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = false;
            this.metroButton2.Location = new System.Drawing.Point(120, 293);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(91, 55);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.StyleManager = null;
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Confirm";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton3
            // 
            this.metroButton3.Highlight = false;
            this.metroButton3.Location = new System.Drawing.Point(217, 293);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(91, 55);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton3.StyleManager = null;
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = "Cancel";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.CustomBackground = false;
            this.lblPackageName.CustomForeColor = false;
            this.lblPackageName.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblPackageName.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblPackageName.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblPackageName.Location = new System.Drawing.Point(23, 72);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(97, 19);
            this.lblPackageName.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPackageName.StyleManager = null;
            this.lblPackageName.TabIndex = 6;
            this.lblPackageName.Text = "Package Name";
            this.lblPackageName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPackageName.UseStyleColors = false;
            // 
            // editProductSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 371);
            this.Controls.Add(this.lblPackageName);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbProductSuppliers);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "editProductSuppliers";
            this.Text = "Edit Product Suppliers";
            this.Load += new System.EventHandler(this.editProductSuppliers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbProductSuppliers;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListView listView1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel lblPackageName;
    }
}