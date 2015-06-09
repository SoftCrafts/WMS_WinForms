namespace WMS.WarehouseForms
{
    partial class Models
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
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Delete = new Telerik.WinControls.UI.RadButton();
            this.btn_New = new Telerik.WinControls.UI.RadButton();
            this.btn_Card = new Telerik.WinControls.UI.RadButton();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_New)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(23, 31);
            // 
            // 
            // 
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Manufacturer_Name";
            gridViewTextBoxColumn1.HeaderText = "Марка";
            gridViewTextBoxColumn1.Name = "Manufacturer_Name";
            gridViewTextBoxColumn1.Width = 148;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.modelBindingSource;
            this.radGridView1.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(583, 240);
            this.radGridView1.TabIndex = 7;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "TelerikMetro";
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "model";
            this.modelBindingSource.CurrentChanged += new System.EventHandler(this.modelBindingSource_CurrentChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(12, 68);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(110, 22);
            this.btn_Delete.TabIndex = 17;
            this.btn_Delete.Text = "Изтриване";
            this.btn_Delete.ThemeName = "TelerikMetro";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_New
            // 
            this.btn_New.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(12, 40);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(110, 22);
            this.btn_New.TabIndex = 16;
            this.btn_New.Text = "Нов";
            this.btn_New.ThemeName = "TelerikMetro";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Card
            // 
            this.btn_Card.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Card.Location = new System.Drawing.Point(12, 12);
            this.btn_Card.Name = "btn_Card";
            this.btn_Card.Size = new System.Drawing.Size(110, 22);
            this.btn_Card.TabIndex = 15;
            this.btn_Card.Text = "Карта";
            this.btn_Card.ThemeName = "TelerikMetro";
            this.btn_Card.Click += new System.EventHandler(this.btn_Card_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.White;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(233, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(118, 31);
            this.lbl_Title.TabIndex = 18;
            this.lbl_Title.Text = "Модели";
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel1.BackColor = System.Drawing.Color.White;
            this.radPanel1.Controls.Add(this.radGridView1);
            this.radPanel1.Location = new System.Drawing.Point(12, 96);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(631, 298);
            this.radPanel1.TabIndex = 19;
            this.radPanel1.ThemeName = "TelerikMetro";
            // 
            // Models
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
            this.Name = "Models";
            this.Text = "Модели";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Models_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_New)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;

        private Telerik.WinControls.UI.RadButton btn_Delete;
        private Telerik.WinControls.UI.RadButton btn_New;
        private Telerik.WinControls.UI.RadButton btn_Card;
        private System.Windows.Forms.Label lbl_Title;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
      //  private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource modelBindingSource;
       // private DataSet1TableAdapters.modelTableAdapter modelTableAdapter;
    }
}