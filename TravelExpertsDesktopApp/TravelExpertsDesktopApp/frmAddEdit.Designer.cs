namespace TravelExpertsDesktopApp
{
    partial class frmAddEdit
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtCommission = new MetroFramework.Controls.MetroTextBox();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.btnConfirm = new MetroFramework.Controls.MetroTile();
            this.btnCancel = new MetroFramework.Controls.MetroTile();
            this.btnImg = new MetroFramework.Controls.MetroTile();
            this.btnEditProducts = new MetroFramework.Controls.MetroTile();
            this.lvProductSuppliers = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Supplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(11, 112);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Package Name:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = false;
            this.metroLabel3.CustomForeColor = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(11, 148);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Start Date:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = false;
            this.metroLabel4.CustomForeColor = false;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(11, 164);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "End Date:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = false;
            this.metroLabel5.CustomForeColor = false;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel5.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel5.Location = new System.Drawing.Point(11, 193);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(72, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.StyleManager = null;
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Base Price:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel5.UseStyleColors = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = false;
            this.metroLabel6.CustomForeColor = false;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel6.Location = new System.Drawing.Point(11, 222);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(84, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.StyleManager = null;
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Commission:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel6.UseStyleColors = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.CustomBackground = false;
            this.metroLabel7.CustomForeColor = false;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel7.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel7.Location = new System.Drawing.Point(11, 251);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(77, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.StyleManager = null;
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Description:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel7.UseStyleColors = false;
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Location = new System.Drawing.Point(135, 147);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 22);
            this.dtpStart.TabIndex = 15;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Location = new System.Drawing.Point(135, 164);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpEnd.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.CustomBackground = false;
            this.txtName.CustomForeColor = false;
            this.txtName.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtName.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtName.Location = new System.Drawing.Point(135, 112);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.StyleManager = null;
            this.txtName.TabIndex = 17;
            this.txtName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.UseStyleColors = false;
            // 
            // txtPrice
            // 
            this.txtPrice.CustomBackground = false;
            this.txtPrice.CustomForeColor = false;
            this.txtPrice.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtPrice.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtPrice.Location = new System.Drawing.Point(135, 193);
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(200, 23);
            this.txtPrice.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.StyleManager = null;
            this.txtPrice.TabIndex = 18;
            this.txtPrice.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.UseStyleColors = false;
            // 
            // txtCommission
            // 
            this.txtCommission.CustomBackground = false;
            this.txtCommission.CustomForeColor = false;
            this.txtCommission.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtCommission.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtCommission.Location = new System.Drawing.Point(135, 222);
            this.txtCommission.Multiline = false;
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.SelectedText = "";
            this.txtCommission.Size = new System.Drawing.Size(200, 23);
            this.txtCommission.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCommission.StyleManager = null;
            this.txtCommission.TabIndex = 19;
            this.txtCommission.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCommission.UseStyleColors = false;
            // 
            // txtDescription
            // 
            this.txtDescription.CustomBackground = false;
            this.txtDescription.CustomForeColor = false;
            this.txtDescription.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtDescription.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtDescription.Location = new System.Drawing.Point(135, 251);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(200, 116);
            this.txtDescription.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.StyleManager = null;
            this.txtDescription.TabIndex = 20;
            this.txtDescription.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.UseStyleColors = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.ActiveControl = null;
            this.btnConfirm.CustomBackground = false;
            this.btnConfirm.CustomForeColor = false;
            this.btnConfirm.Location = new System.Drawing.Point(413, 396);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.PaintTileCount = true;
            this.btnConfirm.Size = new System.Drawing.Size(133, 46);
            this.btnConfirm.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnConfirm.StyleManager = null;
            this.btnConfirm.TabIndex = 22;
            this.btnConfirm.Text = "AddEdit";
            this.btnConfirm.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnConfirm.TileCount = 0;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveControl = null;
            this.btnCancel.CustomBackground = false;
            this.btnCancel.CustomForeColor = false;
            this.btnCancel.Location = new System.Drawing.Point(552, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaintTileCount = true;
            this.btnCancel.Size = new System.Drawing.Size(133, 46);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCancel.StyleManager = null;
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCancel.TileCount = 0;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnImg
            // 
            this.btnImg.ActiveControl = null;
            this.btnImg.CustomBackground = false;
            this.btnImg.CustomForeColor = false;
            this.btnImg.Location = new System.Drawing.Point(135, 396);
            this.btnImg.Name = "btnImg";
            this.btnImg.PaintTileCount = true;
            this.btnImg.Size = new System.Drawing.Size(133, 46);
            this.btnImg.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnImg.StyleManager = null;
            this.btnImg.TabIndex = 24;
            this.btnImg.Text = "Add Image";
            this.btnImg.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnImg.TileCount = 0;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // btnEditProducts
            // 
            this.btnEditProducts.ActiveControl = null;
            this.btnEditProducts.CustomBackground = false;
            this.btnEditProducts.CustomForeColor = false;
            this.btnEditProducts.Location = new System.Drawing.Point(274, 396);
            this.btnEditProducts.Name = "btnEditProducts";
            this.btnEditProducts.PaintTileCount = true;
            this.btnEditProducts.Size = new System.Drawing.Size(133, 46);
            this.btnEditProducts.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnEditProducts.StyleManager = null;
            this.btnEditProducts.TabIndex = 25;
            this.btnEditProducts.Text = "Edit Products";
            this.btnEditProducts.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEditProducts.TileCount = 0;
            this.btnEditProducts.Click += new System.EventHandler(this.btnEditProducts_Click);
            // 
            // lvProductSuppliers
            // 
            this.lvProductSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvProductSuppliers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.Supplier});
            this.lvProductSuppliers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProductSuppliers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvProductSuppliers.Location = new System.Drawing.Point(355, 88);
            this.lvProductSuppliers.Name = "lvProductSuppliers";
            this.lvProductSuppliers.Size = new System.Drawing.Size(330, 122);
            this.lvProductSuppliers.TabIndex = 26;
            this.lvProductSuppliers.UseCompatibleStateImageBehavior = false;
            this.lvProductSuppliers.View = System.Windows.Forms.View.Details;
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 135;
            // 
            // Supplier
            // 
            this.Supplier.Text = "Supplier";
            this.Supplier.Width = 137;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(355, 216);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(330, 151);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 27;
            this.pbImage.TabStop = false;
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            // 
            // frmAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(724, 483);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lvProductSuppliers);
            this.Controls.Add(this.btnEditProducts);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Location = new System.Drawing.Point(0, 0);
            this.Movable = false;
            this.Name = "frmAddEdit";
            this.Resizable = false;
            this.Text = "Add Travel Package";
            this.Load += new System.EventHandler(this.frmAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroTextBox txtCommission;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroTile btnConfirm;
        private MetroFramework.Controls.MetroTile btnCancel;
        private MetroFramework.Controls.MetroTile btnImg;
        private MetroFramework.Controls.MetroTile btnEditProducts;
        private System.Windows.Forms.ListView lvProductSuppliers;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Supplier;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.OpenFileDialog ofdImage;

    }
}