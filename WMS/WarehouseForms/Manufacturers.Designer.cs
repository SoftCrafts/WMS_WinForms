namespace WMS.WarehouseForms
{
    partial class Manufacturers
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.btn_Card = new Telerik.WinControls.UI.RadButton();
            this.radGridView2 = new Telerik.WinControls.UI.RadGridView();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_New = new Telerik.WinControls.UI.RadButton();
            this.btn_Delete = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_New)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Card
            // 
            this.btn_Card.Location = new System.Drawing.Point(12, 12);
            this.btn_Card.Name = "btn_Card";
            this.btn_Card.Size = new System.Drawing.Size(84, 22);
            this.btn_Card.TabIndex = 12;
            this.btn_Card.Text = "Карта";
            this.btn_Card.Click += new System.EventHandler(this.btn_Card_Click);
            // 
            // radGridView2
            // 
            this.radGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridView2.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView2.Location = new System.Drawing.Point(12, 40);
            // 
            // 
            // 
            gridViewTextBoxColumn1.FieldName = "Country_Code";
            gridViewTextBoxColumn1.HeaderText = "Държава";
            gridViewTextBoxColumn1.Name = "Country_Code";
            gridViewTextBoxColumn1.Width = 60;
            this.radGridView2.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1});
            this.radGridView2.MasterTemplate.DataSource = this.manufacturerBindingSource;
            this.radGridView2.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGridView2.MasterTemplate.EnableFiltering = true;
            this.radGridView2.Name = "radGridView2";
            this.radGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView2.Size = new System.Drawing.Size(800, 284);
            this.radGridView2.TabIndex = 11;
            this.radGridView2.Text = "radGridView2";
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "manufacturer";
            this.manufacturerBindingSource.CurrentChanged += new System.EventHandler(this.manufacturerBindingSource_CurrentChanged);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(102, 12);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(84, 22);
            this.btn_New.TabIndex = 13;
            this.btn_New.Text = "Нов";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(192, 12);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(84, 22);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Изтриване";
            // 
            // Manufacturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 540);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Card);
            this.Controls.Add(this.radGridView2);
            this.Name = "Manufacturers";
            this.Text = "Марки";
            this.Load += new System.EventHandler(this.Manufacturers_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_New)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btn_Card;
        private Telerik.WinControls.UI.RadGridView radGridView2;
        private Telerik.WinControls.UI.RadButton btn_New;
        private Telerik.WinControls.UI.RadButton btn_Delete;
    //    private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
      //  private DataSet1TableAdapters.manufacturerTableAdapter manufacturerTableAdapter;



    }
}