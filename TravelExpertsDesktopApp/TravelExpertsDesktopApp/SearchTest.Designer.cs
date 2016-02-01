namespace TravelExpertsDesktopApp
{
    partial class SearchTest
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
            this.txtName = new MetroFramework.Controls.MetroTextBox();
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
            this.cbProductSuppliers.Location = new System.Drawing.Point(12, 48);
            this.cbProductSuppliers.Name = "cbProductSuppliers";
            this.cbProductSuppliers.Size = new System.Drawing.Size(351, 29);
            this.cbProductSuppliers.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbProductSuppliers.StyleManager = null;
            this.cbProductSuppliers.TabIndex = 15;
            this.cbProductSuppliers.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtName
            // 
            this.txtName.CustomBackground = false;
            this.txtName.CustomForeColor = false;
            this.txtName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtName.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtName.Location = new System.Drawing.Point(12, 48);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(351, 29);
            this.txtName.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.StyleManager = null;
            this.txtName.TabIndex = 16;
            this.txtName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.UseStyleColors = false;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // SearchTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 241);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbProductSuppliers);
            this.Name = "SearchTest";
            this.Text = "SearchTest";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbProductSuppliers;
        private MetroFramework.Controls.MetroTextBox txtName;
    }
}