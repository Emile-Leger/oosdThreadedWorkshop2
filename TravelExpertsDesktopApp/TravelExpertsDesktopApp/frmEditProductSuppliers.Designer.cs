namespace TravelExpertsDesktopApp
{
    partial class frmEditProductSuppliers
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
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.dgvProdSups = new System.Windows.Forms.DataGridView();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdSups)).BeginInit();
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
            this.cbProductSuppliers.Location = new System.Drawing.Point(27, 116);
            this.cbProductSuppliers.Name = "cbProductSuppliers";
            this.cbProductSuppliers.Size = new System.Drawing.Size(331, 29);
            this.cbProductSuppliers.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbProductSuppliers.StyleManager = null;
            this.cbProductSuppliers.TabIndex = 0;
            this.cbProductSuppliers.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbProductSuppliers.SelectedIndexChanged += new System.EventHandler(this.cbProductSuppliers_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(27, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(160, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Select a Product Supplier:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Highlight = false;
            this.btnRemove.Location = new System.Drawing.Point(197, 330);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(161, 55);
            this.btnRemove.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnRemove.StyleManager = null;
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClose
            // 
            this.btnClose.Highlight = false;
            this.btnClose.Location = new System.Drawing.Point(23, 391);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(335, 55);
            this.btnClose.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnClose.StyleManager = null;
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Highlight = false;
            this.btnAdd.Location = new System.Drawing.Point(23, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 55);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAdd.StyleManager = null;
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvProdSups
            // 
            this.dgvProdSups.AllowUserToAddRows = false;
            this.dgvProdSups.AllowUserToDeleteRows = false;
            this.dgvProdSups.AllowUserToOrderColumns = true;
            this.dgvProdSups.AllowUserToResizeColumns = false;
            this.dgvProdSups.AllowUserToResizeRows = false;
            this.dgvProdSups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProdSups.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdSups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdSups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdSups.ColumnHeadersVisible = false;
            this.dgvProdSups.GridColor = System.Drawing.Color.White;
            this.dgvProdSups.Location = new System.Drawing.Point(27, 151);
            this.dgvProdSups.MultiSelect = false;
            this.dgvProdSups.Name = "dgvProdSups";
            this.dgvProdSups.ReadOnly = true;
            this.dgvProdSups.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProdSups.Size = new System.Drawing.Size(331, 173);
            this.dgvProdSups.TabIndex = 8;
            this.dgvProdSups.SelectionChanged += new System.EventHandler(this.dgvProdSups_SelectionChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.CustomBackground = false;
            this.txtSearch.CustomForeColor = false;
            this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearch.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtSearch.Location = new System.Drawing.Point(27, 116);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(303, 29);
            this.txtSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.StyleManager = null;
            this.txtSearch.TabIndex = 9;
            this.txtSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.UseStyleColors = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmEditProductSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 483);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvProdSups);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbProductSuppliers);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmEditProductSuppliers";
            this.Text = "Edit Product Suppliers";            
            this.Load += new System.EventHandler(this.editProductSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdSups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbProductSuppliers;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnRemove;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.DataGridView dgvProdSups;
        private MetroFramework.Controls.MetroTextBox txtSearch;
    }
}