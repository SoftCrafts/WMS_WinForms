namespace WMS.WarehouseForms
{
    partial class Items
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn29 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn30 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn31 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn32 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn33 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn34 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn35 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn36 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn37 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn5 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn38 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn6 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn39 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn40 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn41 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn42 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new WMS.DataSet();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Delete = new Telerik.WinControls.UI.RadButton();
            this.btn_New = new Telerik.WinControls.UI.RadButton();
            this.btn_Card = new Telerik.WinControls.UI.RadButton();
            this.itemTableAdapter = new WMS.DataSetTableAdapters.ItemTableAdapter();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_New)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel1.BackColor = System.Drawing.Color.White;
            this.radPanel1.Controls.Add(this.radGridView1);
            this.radPanel1.Location = new System.Drawing.Point(12, 92);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(838, 393);
            this.radPanel1.TabIndex = 29;
            this.radPanel1.ThemeName = "TelerikMetro";
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(14, 14);
            // 
            // radGridView1
            // 
            gridViewDecimalColumn29.DataType = typeof(long);
            gridViewDecimalColumn29.FieldName = "Item_ID";
            gridViewDecimalColumn29.HeaderText = "Item_ID";
            gridViewDecimalColumn29.IsAutoGenerated = true;
            gridViewDecimalColumn29.IsVisible = false;
            gridViewDecimalColumn29.Name = "Item_ID";
            gridViewDecimalColumn29.ReadOnly = true;
            gridViewDecimalColumn30.DataType = typeof(long);
            gridViewDecimalColumn30.FieldName = "Item_Type";
            gridViewDecimalColumn30.HeaderText = "Вид";
            gridViewDecimalColumn30.IsAutoGenerated = true;
            gridViewDecimalColumn30.Name = "Item_Type";
            gridViewDecimalColumn31.DataType = typeof(long);
            gridViewDecimalColumn31.FieldName = "Manufacturer_ID";
            gridViewDecimalColumn31.HeaderText = "Марка";
            gridViewDecimalColumn31.IsAutoGenerated = true;
            gridViewDecimalColumn31.Name = "Manufacturer_ID";
            gridViewDecimalColumn31.Width = 70;
            gridViewDecimalColumn32.DataType = typeof(long);
            gridViewDecimalColumn32.FieldName = "Model_ID";
            gridViewDecimalColumn32.HeaderText = "Модел";
            gridViewDecimalColumn32.IsAutoGenerated = true;
            gridViewDecimalColumn32.Name = "Model_ID";
            gridViewDecimalColumn32.Width = 70;
            gridViewTextBoxColumn11.FieldName = "No";
            gridViewTextBoxColumn11.HeaderText = "Номер";
            gridViewTextBoxColumn11.IsAutoGenerated = true;
            gridViewTextBoxColumn11.Name = "No";
            gridViewTextBoxColumn11.Width = 70;
            gridViewTextBoxColumn12.FieldName = "Description";
            gridViewTextBoxColumn12.HeaderText = "Описание";
            gridViewTextBoxColumn12.IsAutoGenerated = true;
            gridViewTextBoxColumn12.Name = "Description";
            gridViewTextBoxColumn12.Width = 250;
            gridViewTextBoxColumn13.FieldName = "Unit_of_Measure";
            gridViewTextBoxColumn13.HeaderText = "Ед.М.";
            gridViewTextBoxColumn13.IsAutoGenerated = true;
            gridViewTextBoxColumn13.Name = "Unit_of_Measure";
            gridViewDecimalColumn33.DataType = typeof(double);
            gridViewDecimalColumn33.FieldName = "Purchase_Price";
            gridViewDecimalColumn33.HeaderText = "Purchase_Price";
            gridViewDecimalColumn33.IsAutoGenerated = true;
            gridViewDecimalColumn33.IsVisible = false;
            gridViewDecimalColumn33.Name = "Purchase_Price";
            gridViewTextBoxColumn14.FieldName = "Purchase_Price_Currency_Code";
            gridViewTextBoxColumn14.HeaderText = "Purchase_Price_Currency_Code";
            gridViewTextBoxColumn14.IsAutoGenerated = true;
            gridViewTextBoxColumn14.IsVisible = false;
            gridViewTextBoxColumn14.Name = "Purchase_Price_Currency_Code";
            gridViewDecimalColumn34.DataType = typeof(double);
            gridViewDecimalColumn34.FieldName = "Sales_Price";
            gridViewDecimalColumn34.HeaderText = "Sales_Price";
            gridViewDecimalColumn34.IsAutoGenerated = true;
            gridViewDecimalColumn34.IsVisible = false;
            gridViewDecimalColumn34.Name = "Sales_Price";
            gridViewTextBoxColumn15.FieldName = "Sales_Price_Currency_Code";
            gridViewTextBoxColumn15.HeaderText = "Sales_Price_Currency_Code";
            gridViewTextBoxColumn15.IsAutoGenerated = true;
            gridViewTextBoxColumn15.IsVisible = false;
            gridViewTextBoxColumn15.Name = "Sales_Price_Currency_Code";
            gridViewDecimalColumn35.DataType = typeof(long);
            gridViewDecimalColumn35.FieldName = "Location_ID";
            gridViewDecimalColumn35.HeaderText = "Склад";
            gridViewDecimalColumn35.IsAutoGenerated = true;
            gridViewDecimalColumn35.Name = "Location_ID";
            gridViewDecimalColumn36.DataType = typeof(long);
            gridViewDecimalColumn36.FieldName = "Bin_ID";
            gridViewDecimalColumn36.HeaderText = "Складово място";
            gridViewDecimalColumn36.IsAutoGenerated = true;
            gridViewDecimalColumn36.Name = "Bin_ID";
            gridViewDecimalColumn36.Width = 100;
            gridViewDecimalColumn37.DataType = typeof(long);
            gridViewDecimalColumn37.FieldName = "Inserted_by";
            gridViewDecimalColumn37.HeaderText = "Inserted_by";
            gridViewDecimalColumn37.IsAutoGenerated = true;
            gridViewDecimalColumn37.IsVisible = false;
            gridViewDecimalColumn37.Name = "Inserted_by";
            gridViewDateTimeColumn5.FieldName = "Inserted_on";
            gridViewDateTimeColumn5.HeaderText = "Inserted_on";
            gridViewDateTimeColumn5.IsAutoGenerated = true;
            gridViewDateTimeColumn5.IsVisible = false;
            gridViewDateTimeColumn5.Name = "Inserted_on";
            gridViewDecimalColumn38.DataType = typeof(long);
            gridViewDecimalColumn38.FieldName = "Modified_by";
            gridViewDecimalColumn38.HeaderText = "Modified_by";
            gridViewDecimalColumn38.IsAutoGenerated = true;
            gridViewDecimalColumn38.IsVisible = false;
            gridViewDecimalColumn38.Name = "Modified_by";
            gridViewDateTimeColumn6.FieldName = "Modified_on";
            gridViewDateTimeColumn6.HeaderText = "Modified_on";
            gridViewDateTimeColumn6.IsAutoGenerated = true;
            gridViewDateTimeColumn6.IsVisible = false;
            gridViewDateTimeColumn6.Name = "Modified_on";
            gridViewDecimalColumn39.DataType = typeof(double);
            gridViewDecimalColumn39.FieldName = "Length";
            gridViewDecimalColumn39.HeaderText = "Length";
            gridViewDecimalColumn39.IsAutoGenerated = true;
            gridViewDecimalColumn39.IsVisible = false;
            gridViewDecimalColumn39.Name = "Length";
            gridViewDecimalColumn40.DataType = typeof(double);
            gridViewDecimalColumn40.FieldName = "Width";
            gridViewDecimalColumn40.HeaderText = "Width";
            gridViewDecimalColumn40.IsAutoGenerated = true;
            gridViewDecimalColumn40.IsVisible = false;
            gridViewDecimalColumn40.Name = "Width";
            gridViewDecimalColumn41.DataType = typeof(double);
            gridViewDecimalColumn41.FieldName = "Height";
            gridViewDecimalColumn41.HeaderText = "Height";
            gridViewDecimalColumn41.IsAutoGenerated = true;
            gridViewDecimalColumn41.IsVisible = false;
            gridViewDecimalColumn41.Name = "Height";
            gridViewDecimalColumn42.DataType = typeof(double);
            gridViewDecimalColumn42.FieldName = "Weight";
            gridViewDecimalColumn42.HeaderText = "Weight";
            gridViewDecimalColumn42.IsAutoGenerated = true;
            gridViewDecimalColumn42.IsVisible = false;
            gridViewDecimalColumn42.Name = "Weight";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn29,
            gridViewDecimalColumn30,
            gridViewDecimalColumn31,
            gridViewDecimalColumn32,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewDecimalColumn33,
            gridViewTextBoxColumn14,
            gridViewDecimalColumn34,
            gridViewTextBoxColumn15,
            gridViewDecimalColumn35,
            gridViewDecimalColumn36,
            gridViewDecimalColumn37,
            gridViewDateTimeColumn5,
            gridViewDecimalColumn38,
            gridViewDateTimeColumn6,
            gridViewDecimalColumn39,
            gridViewDecimalColumn40,
            gridViewDecimalColumn41,
            gridViewDecimalColumn42});
            this.radGridView1.MasterTemplate.DataSource = this.itemBindingSource;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(810, 362);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.White;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.Location = new System.Drawing.Point(386, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(138, 37);
            this.lbl_Title.TabIndex = 28;
            this.lbl_Title.Text = "Артикули";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btn_Delete.Location = new System.Drawing.Point(244, 64);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(110, 22);
            this.btn_Delete.TabIndex = 27;
            this.btn_Delete.Text = "Изтриване";
            this.btn_Delete.ThemeName = "TelerikMetro";
            // 
            // btn_New
            // 
            this.btn_New.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btn_New.Location = new System.Drawing.Point(128, 64);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(110, 22);
            this.btn_New.TabIndex = 26;
            this.btn_New.Text = "Нов";
            this.btn_New.ThemeName = "TelerikMetro";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Card
            // 
            this.btn_Card.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btn_Card.Location = new System.Drawing.Point(12, 64);
            this.btn_Card.Name = "btn_Card";
            this.btn_Card.Size = new System.Drawing.Size(110, 22);
            this.btn_Card.TabIndex = 25;
            this.btn_Card.Text = "Карта";
            this.btn_Card.ThemeName = "TelerikMetro";
            this.btn_Card.Click += new System.EventHandler(this.btn_Card_Click);
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataMember = "Item";
            this.itemBindingSource1.DataSource = this.dataSet;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 584);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Card);
            this.Name = "Items";
            this.Text = "Items";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_New)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.Label lbl_Title;
        private Telerik.WinControls.UI.RadButton btn_Delete;
        private Telerik.WinControls.UI.RadButton btn_New;
        private Telerik.WinControls.UI.RadButton btn_Card;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}