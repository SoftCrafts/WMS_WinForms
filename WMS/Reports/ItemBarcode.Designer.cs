namespace WMS.Reports
{
    partial class ItemBarcode
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemBarcode));
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.detail = new Telerik.Reporting.DetailSection();
            this.descriptionDataTextBox = new Telerik.Reporting.TextBox();
            this.mANUFACTURER_NAMEDataTextBox = new Telerik.Reporting.TextBox();
            this.mODEL_NAMEDataTextBox = new Telerik.Reporting.TextBox();
            this.barcode1 = new Telerik.Reporting.Barcode();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(2D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.descriptionDataTextBox,
            this.mANUFACTURER_NAMEDataTextBox,
            this.mODEL_NAMEDataTextBox,
            this.barcode1,
            this.textBox1,
            this.textBox2,
            this.textBox3});
            this.detail.Name = "detail";
            this.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Dashed;
            // 
            // descriptionDataTextBox
            // 
            this.descriptionDataTextBox.CanGrow = false;
            this.descriptionDataTextBox.CanShrink = false;
            this.descriptionDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.90000009536743164D), Telerik.Reporting.Drawing.Unit.Inch(0.79791665077209473D));
            this.descriptionDataTextBox.Name = "descriptionDataTextBox";
            this.descriptionDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6979167461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582D));
            this.descriptionDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.descriptionDataTextBox.Value = "=Fields.Description";
            // 
            // mANUFACTURER_NAMEDataTextBox
            // 
            this.mANUFACTURER_NAMEDataTextBox.CanGrow = false;
            this.mANUFACTURER_NAMEDataTextBox.CanShrink = false;
            this.mANUFACTURER_NAMEDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.90000009536743164D), Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926D));
            this.mANUFACTURER_NAMEDataTextBox.Name = "mANUFACTURER_NAMEDataTextBox";
            this.mANUFACTURER_NAMEDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6979166269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985D));
            this.mANUFACTURER_NAMEDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.mANUFACTURER_NAMEDataTextBox.Value = "=Fields.MANUFACTURER_NAME";
            // 
            // mODEL_NAMEDataTextBox
            // 
            this.mODEL_NAMEDataTextBox.CanGrow = false;
            this.mODEL_NAMEDataTextBox.CanShrink = false;
            this.mODEL_NAMEDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.90000009536743164D), Telerik.Reporting.Drawing.Unit.Inch(0.40208330750465393D));
            this.mODEL_NAMEDataTextBox.Name = "mODEL_NAMEDataTextBox";
            this.mODEL_NAMEDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6979167461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.19999964535236359D));
            this.mODEL_NAMEDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.mODEL_NAMEDataTextBox.Value = "=Fields.MODEL_NAME";
            // 
            // barcode1
            // 
            this.barcode1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.097916759550571442D), Telerik.Reporting.Drawing.Unit.Inch(1.1000000238418579D));
            this.barcode1.Name = "barcode1";
            this.barcode1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5D), Telerik.Reporting.Drawing.Unit.Inch(0.80000007152557373D));
            this.barcode1.Symbology = Telerik.Reporting.Barcode.SymbologyType.Code128;
            this.barcode1.Value = "=Fields.Barcode";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = false;
            this.textBox1.CanShrink = false;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.097916759550571442D), Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606D), Telerik.Reporting.Drawing.Unit.Inch(0.19999995827674866D));
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox1.Value = "Модел";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = false;
            this.textBox2.CanShrink = false;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.097916759550571442D), Telerik.Reporting.Drawing.Unit.Inch(0.40208330750465393D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69996064901351929D), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985D));
            this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox2.Value = "Марка";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = false;
            this.textBox3.CanShrink = false;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.097916759550571442D), Telerik.Reporting.Drawing.Unit.Inch(0.79791665077209473D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69996064901351929D), Telerik.Reporting.Drawing.Unit.Inch(0.19999988377094269D));
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox3.Value = "Описание";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "WMS.Properties.Settings.beroebo_wmsConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.SelectCommand = resources.GetString("sqlDataSource1.SelectCommand");
            // 
            // ItemBarcode
            // 
            this.DataSource = this.sqlDataSource1;
            this.Filters.Add(new Telerik.Reporting.Filter("=Fields.Item_ID", Telerik.Reporting.FilterOperator.Equal, "=Parameters.Item_ID.Value"));
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.Name = "ItemBarcode";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            reportParameter1.Name = "Item_ID";
            reportParameter1.Text = "Артикул Номер";
            reportParameter1.Value = "";
            this.ReportParameters.Add(reportParameter1);
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(2.7000000476837158D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox descriptionDataTextBox;
        private Telerik.Reporting.TextBox mANUFACTURER_NAMEDataTextBox;
        private Telerik.Reporting.TextBox mODEL_NAMEDataTextBox;
        private Telerik.Reporting.Barcode barcode1;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.SqlDataSource sqlDataSource1;
    }
}