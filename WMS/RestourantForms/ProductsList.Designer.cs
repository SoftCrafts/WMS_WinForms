namespace WMS.RestourantForms
{
    partial class ProductsList
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn22 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn24 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn25 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn26 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn27 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn4 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn28 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.MasterTemplate = new Telerik.WinControls.UI.RadGridView();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Delete = new Telerik.WinControls.UI.RadButton();
            this.btn_New = new Telerik.WinControls.UI.RadButton();
            this.btn_Card = new Telerik.WinControls.UI.RadButton();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_New)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel1.BackColor = System.Drawing.Color.White;
            this.radPanel1.Controls.Add(this.MasterTemplate);
            this.radPanel1.Location = new System.Drawing.Point(12, 113);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(631, 298);
            this.radPanel1.TabIndex = 24;
            this.radPanel1.ThemeName = "TelerikMetro";
            // 
            // MasterTemplate
            // 
            this.MasterTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MasterTemplate.BackColor = System.Drawing.SystemColors.Control;
            this.MasterTemplate.Cursor = System.Windows.Forms.Cursors.Default;
            this.MasterTemplate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MasterTemplate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MasterTemplate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MasterTemplate.Location = new System.Drawing.Point(23, 31);
            // 
            // MasterTemplate
            // 
            this.MasterTemplate.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn22.EnableExpressionEditor = false;
            gridViewTextBoxColumn22.FieldName = "Product_ID";
            gridViewTextBoxColumn22.HeaderText = "Код";
            gridViewTextBoxColumn22.Name = "Product_ID";
            gridViewTextBoxColumn23.EnableExpressionEditor = false;
            gridViewTextBoxColumn23.FieldName = "PRODUCT_NAME";
            gridViewTextBoxColumn23.HeaderText = "Артикул Име";
            gridViewTextBoxColumn23.Name = "PRODUCT_NAME";
            gridViewTextBoxColumn23.Width = 200;
            gridViewTextBoxColumn24.EnableExpressionEditor = false;
            gridViewTextBoxColumn24.FieldName = "PRODUCT_TYPE_NAME";
            gridViewTextBoxColumn24.HeaderText = "Тип";
            gridViewTextBoxColumn24.Name = "PRODUCT_TYPE_NAME";
            gridViewTextBoxColumn24.Width = 126;
            gridViewTextBoxColumn25.EnableExpressionEditor = false;
            gridViewTextBoxColumn25.FieldName = "Description";
            gridViewTextBoxColumn25.HeaderText = "Мерна ед.";
            gridViewTextBoxColumn25.Name = "Description";
            gridViewTextBoxColumn25.Width = 90;
            gridViewTextBoxColumn26.EnableExpressionEditor = false;
            gridViewTextBoxColumn26.FieldName = "SALES_PRICE";
            gridViewTextBoxColumn26.HeaderText = "Прод. Цена";
            gridViewTextBoxColumn26.Name = "SALES_PRICE";
            gridViewTextBoxColumn26.Width = 100;
            gridViewTextBoxColumn27.EnableExpressionEditor = false;
            gridViewTextBoxColumn27.FieldName = "PRUCHASE_PRICE";
            gridViewTextBoxColumn27.HeaderText = "Покуп. Цена";
            gridViewTextBoxColumn27.Name = "PRUCHASE_PRICE";
            gridViewTextBoxColumn27.Width = 100;
            gridViewCheckBoxColumn4.EnableExpressionEditor = false;
            gridViewCheckBoxColumn4.FieldName = "BOM_ITEM";
            gridViewCheckBoxColumn4.HeaderText = "Сложен";
            gridViewCheckBoxColumn4.MinWidth = 20;
            gridViewCheckBoxColumn4.Name = "BOM_ITEM";
            gridViewCheckBoxColumn4.ReadOnly = true;
            gridViewCheckBoxColumn4.Width = 85;
            gridViewTextBoxColumn28.EnableExpressionEditor = false;
            gridViewTextBoxColumn28.FieldName = "RECIPE_HEADER_NAME";
            gridViewTextBoxColumn28.HeaderText = "Рецепта Име";
            gridViewTextBoxColumn28.Name = "RECIPE_HEADER_NAME";
            gridViewTextBoxColumn28.Width = 164;
            this.MasterTemplate.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn22,
            gridViewTextBoxColumn23,
            gridViewTextBoxColumn24,
            gridViewTextBoxColumn25,
            gridViewTextBoxColumn26,
            gridViewTextBoxColumn27,
            gridViewCheckBoxColumn4,
            gridViewTextBoxColumn28});
            this.MasterTemplate.MasterTemplate.DataSource = this.ProductsBindingSource;
            this.MasterTemplate.MasterTemplate.EnableAlternatingRowColor = true;
            this.MasterTemplate.MasterTemplate.EnableFiltering = true;
            this.MasterTemplate.Name = "MasterTemplate";
            this.MasterTemplate.ReadOnly = true;
            this.MasterTemplate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MasterTemplate.Size = new System.Drawing.Size(583, 240);
            this.MasterTemplate.TabIndex = 7;
            this.MasterTemplate.Text = "radGridView1";
            this.MasterTemplate.ThemeName = "TelerikMetro";
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.White;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(233, 20);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(140, 31);
            this.lbl_Title.TabIndex = 23;
            this.lbl_Title.Text = "Артикули";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(12, 85);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(110, 22);
            this.btn_Delete.TabIndex = 22;
            this.btn_Delete.Text = "Изтриване";
            this.btn_Delete.ThemeName = "TelerikMetro";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_New
            // 
            this.btn_New.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(12, 57);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(110, 22);
            this.btn_New.TabIndex = 21;
            this.btn_New.Text = "Нов";
            this.btn_New.ThemeName = "TelerikMetro";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Card
            // 
            this.btn_Card.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Card.Location = new System.Drawing.Point(12, 29);
            this.btn_Card.Name = "btn_Card";
            this.btn_Card.Size = new System.Drawing.Size(110, 22);
            this.btn_Card.TabIndex = 20;
            this.btn_Card.Text = "Карта";
            this.btn_Card.ThemeName = "TelerikMetro";
            this.btn_Card.Click += new System.EventHandler(this.btn_Card_Click);
            // 
            // ProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(655, 431);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Card);
            this.Name = "ProductsList";
            this.Text = "Артикули";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_New)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.Label lbl_Title;
        private Telerik.WinControls.UI.RadButton btn_Delete;
        private Telerik.WinControls.UI.RadButton btn_New;
        private Telerik.WinControls.UI.RadButton btn_Card;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private System.Windows.Forms.BindingSource ProductsBindingSource;
        private Telerik.WinControls.UI.RadGridView MasterTemplate;
    }
}