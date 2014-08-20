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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn9 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn10 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn11 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn12 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn13 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn14 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Delete = new Telerik.WinControls.UI.RadButton();
            this.btn_New = new Telerik.WinControls.UI.RadButton();
            this.btn_Card = new Telerik.WinControls.UI.RadButton();
            this.dataSet1 = new WMS.DataSet1();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new WMS.DataSet1TableAdapters.itemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_New)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
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
            gridViewDecimalColumn1.DataType = typeof(long);
            gridViewDecimalColumn1.FieldName = "Item_ID";
            gridViewDecimalColumn1.HeaderText = "Item_ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "Item_ID";
            gridViewDecimalColumn2.DataType = typeof(long);
            gridViewDecimalColumn2.FieldName = "Item_Type";
            gridViewDecimalColumn2.HeaderText = "Item_Type";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "Item_Type";
            gridViewTextBoxColumn1.FieldName = "No";
            gridViewTextBoxColumn1.HeaderText = "No";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "No";
            gridViewTextBoxColumn2.FieldName = "Description";
            gridViewTextBoxColumn2.HeaderText = "Description";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Description";
            gridViewTextBoxColumn3.FieldName = "Unit_of_Measure";
            gridViewTextBoxColumn3.HeaderText = "Unit_of_Measure";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Unit_of_Measure";
            gridViewDecimalColumn3.DataType = typeof(long);
            gridViewDecimalColumn3.FieldName = "Manufacturer_ID";
            gridViewDecimalColumn3.HeaderText = "Manufacturer_ID";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "Manufacturer_ID";
            gridViewDecimalColumn4.DataType = typeof(long);
            gridViewDecimalColumn4.FieldName = "Model_ID";
            gridViewDecimalColumn4.HeaderText = "Model_ID";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "Model_ID";
            gridViewDecimalColumn5.DataType = typeof(float);
            gridViewDecimalColumn5.FieldName = "Purchase_Price";
            gridViewDecimalColumn5.HeaderText = "Purchase_Price";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.Name = "Purchase_Price";
            gridViewTextBoxColumn4.FieldName = "Purchase_Price_Currency_Code";
            gridViewTextBoxColumn4.HeaderText = "Purchase_Price_Currency_Code";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Purchase_Price_Currency_Code";
            gridViewDecimalColumn6.DataType = typeof(float);
            gridViewDecimalColumn6.FieldName = "Sales_Price";
            gridViewDecimalColumn6.HeaderText = "Sales_Price";
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.Name = "Sales_Price";
            gridViewTextBoxColumn5.FieldName = "Sales_Price_Currency_Code";
            gridViewTextBoxColumn5.HeaderText = "Sales_Price_Currency_Code";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Sales_Price_Currency_Code";
            gridViewDecimalColumn7.DataType = typeof(long);
            gridViewDecimalColumn7.FieldName = "Location_ID";
            gridViewDecimalColumn7.HeaderText = "Location_ID";
            gridViewDecimalColumn7.IsAutoGenerated = true;
            gridViewDecimalColumn7.Name = "Location_ID";
            gridViewDecimalColumn8.DataType = typeof(long);
            gridViewDecimalColumn8.FieldName = "Bin_ID";
            gridViewDecimalColumn8.HeaderText = "Bin_ID";
            gridViewDecimalColumn8.IsAutoGenerated = true;
            gridViewDecimalColumn8.Name = "Bin_ID";
            gridViewDecimalColumn9.DataType = typeof(long);
            gridViewDecimalColumn9.FieldName = "Inserted_by";
            gridViewDecimalColumn9.HeaderText = "Inserted_by";
            gridViewDecimalColumn9.IsAutoGenerated = true;
            gridViewDecimalColumn9.Name = "Inserted_by";
            gridViewDateTimeColumn1.FieldName = "Inserted_on";
            gridViewDateTimeColumn1.HeaderText = "Inserted_on";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "Inserted_on";
            gridViewDecimalColumn10.DataType = typeof(long);
            gridViewDecimalColumn10.FieldName = "Modified_by";
            gridViewDecimalColumn10.HeaderText = "Modified_by";
            gridViewDecimalColumn10.IsAutoGenerated = true;
            gridViewDecimalColumn10.Name = "Modified_by";
            gridViewDateTimeColumn2.FieldName = "Modified_on";
            gridViewDateTimeColumn2.HeaderText = "Modified_on";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "Modified_on";
            gridViewDecimalColumn11.DataType = typeof(float);
            gridViewDecimalColumn11.FieldName = "Length";
            gridViewDecimalColumn11.HeaderText = "Length";
            gridViewDecimalColumn11.IsAutoGenerated = true;
            gridViewDecimalColumn11.Name = "Length";
            gridViewDecimalColumn12.DataType = typeof(float);
            gridViewDecimalColumn12.FieldName = "Width";
            gridViewDecimalColumn12.HeaderText = "Width";
            gridViewDecimalColumn12.IsAutoGenerated = true;
            gridViewDecimalColumn12.Name = "Width";
            gridViewDecimalColumn13.DataType = typeof(float);
            gridViewDecimalColumn13.FieldName = "Height";
            gridViewDecimalColumn13.HeaderText = "Height";
            gridViewDecimalColumn13.IsAutoGenerated = true;
            gridViewDecimalColumn13.Name = "Height";
            gridViewDecimalColumn14.DataType = typeof(float);
            gridViewDecimalColumn14.FieldName = "Weight";
            gridViewDecimalColumn14.HeaderText = "Weight";
            gridViewDecimalColumn14.IsAutoGenerated = true;
            gridViewDecimalColumn14.Name = "Weight";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn6,
            gridViewTextBoxColumn5,
            gridViewDecimalColumn7,
            gridViewDecimalColumn8,
            gridViewDecimalColumn9,
            gridViewDateTimeColumn1,
            gridViewDecimalColumn10,
            gridViewDateTimeColumn2,
            gridViewDecimalColumn11,
            gridViewDecimalColumn12,
            gridViewDecimalColumn13,
            gridViewDecimalColumn14});
            this.radGridView1.MasterTemplate.DataSource = this.itemBindingSource;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(810, 362);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.White;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.Location = new System.Drawing.Point(386, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(137, 37);
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
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.dataSet1;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_New)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.Label lbl_Title;
        private Telerik.WinControls.UI.RadButton btn_Delete;
        private Telerik.WinControls.UI.RadButton btn_New;
        private Telerik.WinControls.UI.RadButton btn_Card;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DataSet1TableAdapters.itemTableAdapter itemTableAdapter;
    }
}