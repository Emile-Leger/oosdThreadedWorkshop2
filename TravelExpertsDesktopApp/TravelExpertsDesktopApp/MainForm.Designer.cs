namespace TravelExpertsDesktopApp
{
    partial class MainForm
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
            this.tcPackages = new MetroFramework.Controls.MetroTabControl();
            this.tpPackages = new MetroFramework.Controls.MetroTabPage();
            this.lvProductSuppliers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDescription = new MetroFramework.Controls.MetroLabel();
            this.msmStyle = new MetroFramework.Components.MetroStyleManager();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblCommission = new MetroFramework.Controls.MetroLabel();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.lblEnd = new MetroFramework.Controls.MetroLabel();
            this.lblStart = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pbPkgImg = new System.Windows.Forms.PictureBox();
            this.btnExit = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnAdd = new MetroFramework.Controls.MetroTile();
            this.btnEdit = new MetroFramework.Controls.MetroTile();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.lblPkgName = new MetroFramework.Controls.MetroLabel();
            this.cbPackages = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpProductSuppliers = new MetroFramework.Controls.MetroTabPage();
            this.lblEntityMode = new System.Windows.Forms.Label();
            this.pnlNewProdSup = new System.Windows.Forms.Panel();
            this.lblProduct = new MetroFramework.Controls.MetroLabel();
            this.lblBy = new MetroFramework.Controls.MetroLabel();
            this.lblSupplier = new MetroFramework.Controls.MetroLabel();
            this.btnAddProdSup = new MetroFramework.Controls.MetroButton();
            this.btnEditProdSupp = new MetroFramework.Controls.MetroButton();
            this.btnCreateProdSup = new MetroFramework.Controls.MetroButton();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtNewName = new MetroFramework.Controls.MetroTextBox();
            this.lblProdOrSup = new MetroFramework.Controls.MetroLabel();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.tcPackages.SuspendLayout();
            this.tpPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPkgImg)).BeginInit();
            this.tpProductSuppliers.SuspendLayout();
            this.pnlNewProdSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPackages
            // 
            this.tcPackages.Controls.Add(this.tpPackages);
            this.tcPackages.Controls.Add(this.tpProductSuppliers);
            this.tcPackages.CustomBackground = false;
            this.tcPackages.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.tcPackages.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            this.tcPackages.Location = new System.Drawing.Point(23, 63);
            this.tcPackages.Name = "tcPackages";
            this.tcPackages.SelectedIndex = 1;
            this.tcPackages.Size = new System.Drawing.Size(1127, 398);
            this.tcPackages.Style = MetroFramework.MetroColorStyle.Blue;
            this.tcPackages.StyleManager = this.msmStyle;
            this.tcPackages.TabIndex = 0;
            this.tcPackages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tcPackages.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tcPackages.UseStyleColors = false;
            // 
            // tpPackages
            // 
            this.tpPackages.Controls.Add(this.lvProductSuppliers);
            this.tpPackages.Controls.Add(this.lblDescription);
            this.tpPackages.Controls.Add(this.metroLabel2);
            this.tpPackages.Controls.Add(this.metroLabel9);
            this.tpPackages.Controls.Add(this.metroLabel8);
            this.tpPackages.Controls.Add(this.metroLabel7);
            this.tpPackages.Controls.Add(this.metroLabel6);
            this.tpPackages.Controls.Add(this.lblCommission);
            this.tpPackages.Controls.Add(this.lblPrice);
            this.tpPackages.Controls.Add(this.lblEnd);
            this.tpPackages.Controls.Add(this.lblStart);
            this.tpPackages.Controls.Add(this.metroLabel1);
            this.tpPackages.Controls.Add(this.pbPkgImg);
            this.tpPackages.Controls.Add(this.btnExit);
            this.tpPackages.Controls.Add(this.btnDelete);
            this.tpPackages.Controls.Add(this.btnAdd);
            this.tpPackages.Controls.Add(this.btnEdit);
            this.tpPackages.Controls.Add(this.label8);
            this.tpPackages.Controls.Add(this.txtSearch);
            this.tpPackages.Controls.Add(this.lblPkgName);
            this.tpPackages.Controls.Add(this.cbPackages);
            this.tpPackages.Controls.Add(this.label1);
            this.tpPackages.CustomBackground = false;
            this.tpPackages.HorizontalScrollbar = false;
            this.tpPackages.HorizontalScrollbarBarColor = true;
            this.tpPackages.HorizontalScrollbarHighlightOnWheel = false;
            this.tpPackages.HorizontalScrollbarSize = 10;
            this.tpPackages.Location = new System.Drawing.Point(4, 35);
            this.tpPackages.Name = "tpPackages";
            this.tpPackages.Size = new System.Drawing.Size(1119, 359);
            this.tpPackages.Style = MetroFramework.MetroColorStyle.Blue;
            this.tpPackages.StyleManager = this.msmStyle;
            this.tpPackages.TabIndex = 0;
            this.tpPackages.Text = "Search Travel Packages";
            this.tpPackages.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tpPackages.VerticalScrollbar = false;
            this.tpPackages.VerticalScrollbarBarColor = true;
            this.tpPackages.VerticalScrollbarHighlightOnWheel = false;
            this.tpPackages.VerticalScrollbarSize = 10;
            // 
            // lvProductSuppliers
            // 
            this.lvProductSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvProductSuppliers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvProductSuppliers.Location = new System.Drawing.Point(447, 197);
            this.lvProductSuppliers.Name = "lvProductSuppliers";
            this.lvProductSuppliers.Size = new System.Drawing.Size(251, 123);
            this.lvProductSuppliers.TabIndex = 71;
            this.lvProductSuppliers.UseCompatibleStateImageBehavior = false;
            this.lvProductSuppliers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product ";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Supplier";
            this.columnHeader2.Width = 155;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.CustomBackground = false;
            this.lblDescription.CustomForeColor = false;
            this.lblDescription.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblDescription.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDescription.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDescription.Location = new System.Drawing.Point(447, 161);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 19);
            this.lblDescription.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDescription.StyleManager = this.msmStyle;
            this.lblDescription.TabIndex = 70;
            this.lblDescription.Text = "metroLabel5";
            this.lblDescription.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDescription.UseStyleColors = false;
            // 
            // msmStyle
            // 
            this.msmStyle.OwnerForm = this;
            this.msmStyle.Style = MetroFramework.MetroColorStyle.Blue;
            this.msmStyle.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(330, 159);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = this.msmStyle;
            this.metroLabel2.TabIndex = 69;
            this.metroLabel2.Text = "Description:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.CustomBackground = false;
            this.metroLabel9.CustomForeColor = false;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel9.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel9.Location = new System.Drawing.Point(330, 140);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(84, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel9.StyleManager = this.msmStyle;
            this.metroLabel9.TabIndex = 68;
            this.metroLabel9.Text = "Commission:";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel9.UseStyleColors = false;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.CustomBackground = false;
            this.metroLabel8.CustomForeColor = false;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel8.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel8.Location = new System.Drawing.Point(330, 121);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(41, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel8.StyleManager = this.msmStyle;
            this.metroLabel8.TabIndex = 67;
            this.metroLabel8.Text = "Price:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel8.UseStyleColors = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.CustomBackground = false;
            this.metroLabel7.CustomForeColor = false;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel7.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel7.Location = new System.Drawing.Point(330, 102);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.StyleManager = this.msmStyle;
            this.metroLabel7.TabIndex = 66;
            this.metroLabel7.Text = "End Date:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel7.UseStyleColors = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = false;
            this.metroLabel6.CustomForeColor = false;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel6.Location = new System.Drawing.Point(330, 83);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(71, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.StyleManager = this.msmStyle;
            this.metroLabel6.TabIndex = 65;
            this.metroLabel6.Text = "Start Date:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel6.UseStyleColors = false;
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.CustomBackground = false;
            this.lblCommission.CustomForeColor = false;
            this.lblCommission.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblCommission.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblCommission.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblCommission.Location = new System.Drawing.Point(447, 142);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(83, 19);
            this.lblCommission.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCommission.StyleManager = this.msmStyle;
            this.lblCommission.TabIndex = 64;
            this.lblCommission.Text = "metroLabel5";
            this.lblCommission.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCommission.UseStyleColors = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.CustomBackground = false;
            this.lblPrice.CustomForeColor = false;
            this.lblPrice.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblPrice.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblPrice.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblPrice.Location = new System.Drawing.Point(447, 123);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(83, 19);
            this.lblPrice.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPrice.StyleManager = this.msmStyle;
            this.lblPrice.TabIndex = 63;
            this.lblPrice.Text = "metroLabel4";
            this.lblPrice.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPrice.UseStyleColors = false;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.CustomBackground = false;
            this.lblEnd.CustomForeColor = false;
            this.lblEnd.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblEnd.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblEnd.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblEnd.Location = new System.Drawing.Point(447, 103);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(83, 19);
            this.lblEnd.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblEnd.StyleManager = this.msmStyle;
            this.lblEnd.TabIndex = 62;
            this.lblEnd.Text = "metroLabel3";
            this.lblEnd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblEnd.UseStyleColors = false;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.CustomBackground = false;
            this.lblStart.CustomForeColor = false;
            this.lblStart.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblStart.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblStart.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblStart.Location = new System.Drawing.Point(447, 84);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(83, 19);
            this.lblStart.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblStart.StyleManager = this.msmStyle;
            this.lblStart.TabIndex = 61;
            this.lblStart.Text = "metroLabel2";
            this.lblStart.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblStart.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(326, 197);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = this.msmStyle;
            this.metroLabel1.TabIndex = 60;
            this.metroLabel1.Text = "Product Suppliers:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // pbPkgImg
            // 
            this.pbPkgImg.Location = new System.Drawing.Point(734, 68);
            this.pbPkgImg.Name = "pbPkgImg";
            this.pbPkgImg.Size = new System.Drawing.Size(346, 252);
            this.pbPkgImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPkgImg.TabIndex = 58;
            this.pbPkgImg.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.ActiveControl = null;
            this.btnExit.CustomBackground = false;
            this.btnExit.CustomForeColor = false;
            this.btnExit.Location = new System.Drawing.Point(181, 253);
            this.btnExit.Name = "btnExit";
            this.btnExit.PaintTileCount = true;
            this.btnExit.Size = new System.Drawing.Size(118, 66);
            this.btnExit.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnExit.StyleManager = this.msmStyle;
            this.btnExit.TabIndex = 57;
            this.btnExit.Text = "Exit Program";
            this.btnExit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnExit.TileCount = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.CustomBackground = false;
            this.btnDelete.CustomForeColor = false;
            this.btnDelete.Location = new System.Drawing.Point(57, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintTileCount = true;
            this.btnDelete.Size = new System.Drawing.Size(118, 66);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDelete.StyleManager = this.msmStyle;
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete Package";
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDelete.TileCount = 0;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveControl = null;
            this.btnAdd.CustomBackground = false;
            this.btnAdd.CustomForeColor = false;
            this.btnAdd.Location = new System.Drawing.Point(57, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintTileCount = true;
            this.btnAdd.Size = new System.Drawing.Size(118, 66);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAdd.StyleManager = this.msmStyle;
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Add new Package";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAdd.TileCount = 0;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveControl = null;
            this.btnEdit.CustomBackground = false;
            this.btnEdit.CustomForeColor = false;
            this.btnEdit.Location = new System.Drawing.Point(181, 178);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaintTileCount = true;
            this.btnEdit.Size = new System.Drawing.Size(118, 66);
            this.btnEdit.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnEdit.StyleManager = this.msmStyle;
            this.btnEdit.TabIndex = 54;
            this.btnEdit.Text = "Edit Package";
            this.btnEdit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEdit.TileCount = 0;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(54, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Search Packages";
            // 
            // txtSearch
            // 
            this.txtSearch.CustomBackground = false;
            this.txtSearch.CustomForeColor = false;
            this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtSearch.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtSearch.Location = new System.Drawing.Point(57, 123);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(223, 23);
            this.txtSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.StyleManager = this.msmStyle;
            this.txtSearch.TabIndex = 51;
            this.txtSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.UseStyleColors = false;
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.CustomBackground = false;
            this.lblPkgName.CustomForeColor = false;
            this.lblPkgName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPkgName.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblPkgName.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblPkgName.Location = new System.Drawing.Point(300, 35);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(125, 25);
            this.lblPkgName.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPkgName.StyleManager = this.msmStyle;
            this.lblPkgName.TabIndex = 41;
            this.lblPkgName.Text = "Package Name";
            this.lblPkgName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPkgName.UseStyleColors = false;
            // 
            // cbPackages
            // 
            this.cbPackages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPackages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPackages.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cbPackages.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cbPackages.FormattingEnabled = true;
            this.cbPackages.ItemHeight = 23;
            this.cbPackages.Location = new System.Drawing.Point(57, 67);
            this.cbPackages.Name = "cbPackages";
            this.cbPackages.Size = new System.Drawing.Size(226, 29);
            this.cbPackages.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbPackages.StyleManager = this.msmStyle;
            this.cbPackages.TabIndex = 39;
            this.cbPackages.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbPackages.SelectedIndexChanged += new System.EventHandler(this.cbPackages_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Select a Travel Package";
            // 
            // tpProductSuppliers
            // 
            this.tpProductSuppliers.Controls.Add(this.lblEntityMode);
            this.tpProductSuppliers.Controls.Add(this.pnlNewProdSup);
            this.tpProductSuppliers.Controls.Add(this.btnAddProdSup);
            this.tpProductSuppliers.Controls.Add(this.btnEditProdSupp);
            this.tpProductSuppliers.Controls.Add(this.btnCreateProdSup);
            this.tpProductSuppliers.Controls.Add(this.txtName);
            this.tpProductSuppliers.Controls.Add(this.txtNewName);
            this.tpProductSuppliers.Controls.Add(this.lblProdOrSup);
            this.tpProductSuppliers.Controls.Add(this.dgvResults);
            this.tpProductSuppliers.Controls.Add(this.metroLabel4);
            this.tpProductSuppliers.Controls.Add(this.metroLabel3);
            this.tpProductSuppliers.Controls.Add(this.dgvSuppliers);
            this.tpProductSuppliers.Controls.Add(this.dgvProducts);
            this.tpProductSuppliers.CustomBackground = false;
            this.tpProductSuppliers.HorizontalScrollbar = false;
            this.tpProductSuppliers.HorizontalScrollbarBarColor = true;
            this.tpProductSuppliers.HorizontalScrollbarHighlightOnWheel = false;
            this.tpProductSuppliers.HorizontalScrollbarSize = 10;
            this.tpProductSuppliers.Location = new System.Drawing.Point(4, 35);
            this.tpProductSuppliers.Name = "tpProductSuppliers";
            this.tpProductSuppliers.Size = new System.Drawing.Size(1119, 359);
            this.tpProductSuppliers.Style = MetroFramework.MetroColorStyle.Blue;
            this.tpProductSuppliers.StyleManager = this.msmStyle;
            this.tpProductSuppliers.TabIndex = 1;
            this.tpProductSuppliers.Text = "Product Supplier Manager";
            this.tpProductSuppliers.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tpProductSuppliers.VerticalScrollbar = false;
            this.tpProductSuppliers.VerticalScrollbarBarColor = true;
            this.tpProductSuppliers.VerticalScrollbarHighlightOnWheel = false;
            this.tpProductSuppliers.VerticalScrollbarSize = 10;
            // 
            // lblEntityMode
            // 
            this.lblEntityMode.BackColor = System.Drawing.Color.White;
            this.lblEntityMode.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntityMode.Location = new System.Drawing.Point(705, 125);
            this.lblEntityMode.Name = "lblEntityMode";
            this.lblEntityMode.Size = new System.Drawing.Size(180, 49);
            this.lblEntityMode.TabIndex = 17;
            // 
            // pnlNewProdSup
            // 
            this.pnlNewProdSup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewProdSup.Controls.Add(this.lblProduct);
            this.pnlNewProdSup.Controls.Add(this.lblBy);
            this.pnlNewProdSup.Controls.Add(this.lblSupplier);
            this.pnlNewProdSup.Location = new System.Drawing.Point(882, 53);
            this.pnlNewProdSup.Name = "pnlNewProdSup";
            this.pnlNewProdSup.Size = new System.Drawing.Size(236, 57);
            this.pnlNewProdSup.TabIndex = 16;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.SystemColors.Control;
            this.lblProduct.CustomBackground = true;
            this.lblProduct.CustomForeColor = false;
            this.lblProduct.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblProduct.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblProduct.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblProduct.Location = new System.Drawing.Point(-1, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(37, 19);
            this.lblProduct.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblProduct.StyleManager = null;
            this.lblProduct.TabIndex = 12;
            this.lblProduct.Text = "hello";
            this.lblProduct.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblProduct.UseStyleColors = false;
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.BackColor = System.Drawing.SystemColors.Control;
            this.lblBy.CustomBackground = true;
            this.lblBy.CustomForeColor = false;
            this.lblBy.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblBy.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblBy.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBy.Location = new System.Drawing.Point(0, 19);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(37, 19);
            this.lblBy.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBy.StyleManager = null;
            this.lblBy.TabIndex = 10;
            this.lblBy.Text = "hello";
            this.lblBy.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBy.UseStyleColors = false;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.SystemColors.Control;
            this.lblSupplier.CustomBackground = true;
            this.lblSupplier.CustomForeColor = false;
            this.lblSupplier.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblSupplier.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblSupplier.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblSupplier.Location = new System.Drawing.Point(0, 38);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(37, 19);
            this.lblSupplier.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSupplier.StyleManager = null;
            this.lblSupplier.TabIndex = 11;
            this.lblSupplier.Text = "hello";
            this.lblSupplier.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSupplier.UseStyleColors = false;
            // 
            // btnAddProdSup
            // 
            this.btnAddProdSup.Highlight = false;
            this.btnAddProdSup.Location = new System.Drawing.Point(703, 236);
            this.btnAddProdSup.Name = "btnAddProdSup";
            this.btnAddProdSup.Size = new System.Drawing.Size(167, 23);
            this.btnAddProdSup.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAddProdSup.StyleManager = null;
            this.btnAddProdSup.TabIndex = 15;
            this.btnAddProdSup.Text = "Add";
            this.btnAddProdSup.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAddProdSup.Click += new System.EventHandler(this.btnAddProdSup_Click);
            // 
            // btnEditProdSupp
            // 
            this.btnEditProdSupp.Highlight = false;
            this.btnEditProdSupp.Location = new System.Drawing.Point(703, 195);
            this.btnEditProdSupp.Name = "btnEditProdSupp";
            this.btnEditProdSupp.Size = new System.Drawing.Size(167, 23);
            this.btnEditProdSupp.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnEditProdSupp.StyleManager = null;
            this.btnEditProdSupp.TabIndex = 14;
            this.btnEditProdSupp.Text = "update";
            this.btnEditProdSupp.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEditProdSupp.Click += new System.EventHandler(this.btnEditProdSupp_Click);
            // 
            // btnCreateProdSup
            // 
            this.btnCreateProdSup.Highlight = false;
            this.btnCreateProdSup.Location = new System.Drawing.Point(703, 53);
            this.btnCreateProdSup.Name = "btnCreateProdSup";
            this.btnCreateProdSup.Size = new System.Drawing.Size(167, 57);
            this.btnCreateProdSup.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCreateProdSup.StyleManager = null;
            this.btnCreateProdSup.TabIndex = 13;
            this.btnCreateProdSup.Text = "Create Product-Supplier";
            this.btnCreateProdSup.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCreateProdSup.Click += new System.EventHandler(this.btnCreateProdSup_Click);
            // 
            // txtName
            // 
            this.txtName.CustomBackground = false;
            this.txtName.CustomForeColor = false;
            this.txtName.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtName.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtName.Location = new System.Drawing.Point(882, 195);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(236, 23);
            this.txtName.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.StyleManager = null;
            this.txtName.TabIndex = 9;
            this.txtName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.UseStyleColors = false;
            // 
            // txtNewName
            // 
            this.txtNewName.CustomBackground = false;
            this.txtNewName.CustomForeColor = false;
            this.txtNewName.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtNewName.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtNewName.Location = new System.Drawing.Point(882, 236);
            this.txtNewName.Multiline = false;
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.SelectedText = "";
            this.txtNewName.Size = new System.Drawing.Size(236, 23);
            this.txtNewName.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewName.StyleManager = null;
            this.txtNewName.TabIndex = 8;
            this.txtNewName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewName.UseStyleColors = false;
            // 
            // lblProdOrSup
            // 
            this.lblProdOrSup.AutoSize = true;
            this.lblProdOrSup.CustomBackground = false;
            this.lblProdOrSup.CustomForeColor = false;
            this.lblProdOrSup.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblProdOrSup.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblProdOrSup.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblProdOrSup.Location = new System.Drawing.Point(352, 25);
            this.lblProdOrSup.Name = "lblProdOrSup";
            this.lblProdOrSup.Size = new System.Drawing.Size(49, 25);
            this.lblProdOrSup.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblProdOrSup.StyleManager = null;
            this.lblProdOrSup.TabIndex = 7;
            this.lblProdOrSup.Text = "hello";
            this.lblProdOrSup.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblProdOrSup.UseStyleColors = false;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToOrderColumns = true;
            this.dgvResults.AllowUserToResizeColumns = false;
            this.dgvResults.AllowUserToResizeRows = false;
            this.dgvResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.ColumnHeadersVisible = false;
            this.dgvResults.Location = new System.Drawing.Point(387, 53);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.Size = new System.Drawing.Size(211, 303);
            this.dgvResults.TabIndex = 6;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = false;
            this.metroLabel4.CustomForeColor = false;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(157, 25);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Suppliers";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = false;
            this.metroLabel3.CustomForeColor = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(31, 25);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(78, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Products";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AllowUserToOrderColumns = true;
            this.dgvSuppliers.AllowUserToResizeColumns = false;
            this.dgvSuppliers.AllowUserToResizeRows = false;
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.ColumnHeadersVisible = false;
            this.dgvSuppliers.Location = new System.Drawing.Point(170, 53);
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.Size = new System.Drawing.Size(211, 303);
            this.dgvSuppliers.TabIndex = 3;
            this.dgvSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellClick);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToOrderColumns = true;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.ColumnHeadersVisible = false;
            this.dgvProducts.Location = new System.Drawing.Point(42, 53);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(122, 303);
            this.dgvProducts.TabIndex = 2;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 483);
            this.Controls.Add(this.tcPackages);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Movable = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.StyleManager = this.msmStyle;
            this.Text = "Travel Package Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcPackages.ResumeLayout(false);
            this.tpPackages.ResumeLayout(false);
            this.tpPackages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPkgImg)).EndInit();
            this.tpProductSuppliers.ResumeLayout(false);
            this.tpProductSuppliers.PerformLayout();
            this.pnlNewProdSup.ResumeLayout(false);
            this.pnlNewProdSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tcPackages;
        private MetroFramework.Controls.MetroTabPage tpPackages;
        private MetroFramework.Components.MetroStyleManager msmStyle;
        private MetroFramework.Controls.MetroTile btnExit;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnAdd;
        private MetroFramework.Controls.MetroTile btnEdit;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel lblPkgName;
        private MetroFramework.Controls.MetroComboBox cbPackages;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblCommission;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroLabel lblEnd;
        private MetroFramework.Controls.MetroLabel lblStart;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pbPkgImg;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblDescription;
        private System.Windows.Forms.ListView lvProductSuppliers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MetroFramework.Controls.MetroTabPage tpProductSuppliers;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.DataGridView dgvProducts;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblProdOrSup;
        private System.Windows.Forms.DataGridView dgvResults;
        private MetroFramework.Controls.MetroLabel lblSupplier;
        private MetroFramework.Controls.MetroLabel lblBy;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtNewName;
        private MetroFramework.Controls.MetroLabel lblProduct;
        private MetroFramework.Controls.MetroButton btnEditProdSupp;
        private MetroFramework.Controls.MetroButton btnCreateProdSup;
        private MetroFramework.Controls.MetroButton btnAddProdSup;
        private System.Windows.Forms.Panel pnlNewProdSup;
        private System.Windows.Forms.Label lblEntityMode;
    }
}

