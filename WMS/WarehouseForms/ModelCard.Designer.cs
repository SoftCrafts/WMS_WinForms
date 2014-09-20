namespace WMS.WarehouseForms
{
    partial class ModelCard
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
            this.btn_Save = new Telerik.WinControls.UI.RadButton();
            this.btn_Back = new Telerik.WinControls.UI.RadButton();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.date_picker_Prod_Date = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Model_ID = new System.Windows.Forms.Label();
            this.txt_Model_ID = new Telerik.WinControls.UI.RadTextBox();
            this.cmb_Manufacturer = new Telerik.WinControls.UI.RadDropDownList();
            this.txt_Model_Name = new Telerik.WinControls.UI.RadTextBox();
            this.lbl_Manufacturer_ID = new System.Windows.Forms.Label();
            this.lbl_Model_Name = new System.Windows.Forms.Label();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_picker_Prod_Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Model_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Manufacturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Model_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(12, 13);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(84, 24);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Запиши";
            this.btn_Save.ThemeName = "TelerikMetro";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(12, 43);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(84, 24);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "Назад";
            this.btn_Back.ThemeName = "TelerikMetro";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.White;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(151, 2);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(206, 31);
            this.lbl_Title.TabIndex = 9;
            this.lbl_Title.Text = "Модели Карта";
            // 
            // date_picker_Prod_Date
            // 
            this.date_picker_Prod_Date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_picker_Prod_Date.Location = new System.Drawing.Point(181, 132);
            this.date_picker_Prod_Date.Name = "date_picker_Prod_Date";
            this.date_picker_Prod_Date.Size = new System.Drawing.Size(287, 27);
            this.date_picker_Prod_Date.TabIndex = 17;
            this.date_picker_Prod_Date.TabStop = false;
            this.date_picker_Prod_Date.Text = "Sunday, August 17, 2014";
            this.date_picker_Prod_Date.Value = new System.DateTime(2014, 8, 17, 2, 43, 46, 955);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Дата Производство";
            // 
            // lbl_Model_ID
            // 
            this.lbl_Model_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Model_ID.AutoSize = true;
            this.lbl_Model_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Model_ID.Location = new System.Drawing.Point(14, 42);
            this.lbl_Model_ID.Name = "lbl_Model_ID";
            this.lbl_Model_ID.Size = new System.Drawing.Size(80, 21);
            this.lbl_Model_ID.TabIndex = 12;
            this.lbl_Model_ID.Text = "Модел ID:";
            // 
            // txt_Model_ID
            // 
            this.txt_Model_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Model_ID.Enabled = false;
            this.txt_Model_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Model_ID.Location = new System.Drawing.Point(181, 40);
            this.txt_Model_ID.Name = "txt_Model_ID";
            this.txt_Model_ID.Size = new System.Drawing.Size(287, 27);
            this.txt_Model_ID.TabIndex = 10;
            // 
            // cmb_Manufacturer
            // 
            this.cmb_Manufacturer.AllowShowFocusCues = false;
            this.cmb_Manufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Manufacturer.AutoCompleteDisplayMember = null;
            this.cmb_Manufacturer.AutoCompleteValueMember = null;
            this.cmb_Manufacturer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Manufacturer.Location = new System.Drawing.Point(181, 71);
            this.cmb_Manufacturer.Name = "cmb_Manufacturer";
            this.cmb_Manufacturer.Size = new System.Drawing.Size(287, 27);
            this.cmb_Manufacturer.TabIndex = 16;
            // 
            // txt_Model_Name
            // 
            this.txt_Model_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Model_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Model_Name.Location = new System.Drawing.Point(181, 101);
            this.txt_Model_Name.Name = "txt_Model_Name";
            this.txt_Model_Name.Size = new System.Drawing.Size(287, 27);
            this.txt_Model_Name.TabIndex = 11;
            // 
            // lbl_Manufacturer_ID
            // 
            this.lbl_Manufacturer_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Manufacturer_ID.AutoSize = true;
            this.lbl_Manufacturer_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Manufacturer_ID.Location = new System.Drawing.Point(14, 73);
            this.lbl_Manufacturer_ID.Name = "lbl_Manufacturer_ID";
            this.lbl_Manufacturer_ID.Size = new System.Drawing.Size(57, 21);
            this.lbl_Manufacturer_ID.TabIndex = 13;
            this.lbl_Manufacturer_ID.Text = "Марка";
            // 
            // lbl_Model_Name
            // 
            this.lbl_Model_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Model_Name.AutoSize = true;
            this.lbl_Model_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Model_Name.Location = new System.Drawing.Point(14, 101);
            this.lbl_Model_Name.Name = "lbl_Model_Name";
            this.lbl_Model_Name.Size = new System.Drawing.Size(41, 21);
            this.lbl_Model_Name.TabIndex = 14;
            this.lbl_Model_Name.Text = "Име";
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel1.BackColor = System.Drawing.Color.White;
            this.radPanel1.Controls.Add(this.txt_Model_ID);
            this.radPanel1.Controls.Add(this.date_picker_Prod_Date);
            this.radPanel1.Controls.Add(this.lbl_Model_Name);
            this.radPanel1.Controls.Add(this.label1);
            this.radPanel1.Controls.Add(this.lbl_Manufacturer_ID);
            this.radPanel1.Controls.Add(this.lbl_Model_ID);
            this.radPanel1.Controls.Add(this.txt_Model_Name);
            this.radPanel1.Controls.Add(this.cmb_Manufacturer);
            this.radPanel1.Location = new System.Drawing.Point(12, 88);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(494, 257);
            this.radPanel1.TabIndex = 18;
            // 
            // ModelCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(530, 357);
            this.ControlBox = false;
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Save);
            this.Name = "ModelCard";
            this.Text = "Модели Карта";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ModelCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_picker_Prod_Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Model_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Manufacturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Model_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btn_Save;
        private Telerik.WinControls.UI.RadButton btn_Back;
        private System.Windows.Forms.Label lbl_Title;
        private Telerik.WinControls.UI.RadDateTimePicker date_picker_Prod_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Model_ID;
        private Telerik.WinControls.UI.RadTextBox txt_Model_ID;
        private Telerik.WinControls.UI.RadDropDownList cmb_Manufacturer;
        private Telerik.WinControls.UI.RadTextBox txt_Model_Name;
        private System.Windows.Forms.Label lbl_Manufacturer_ID;
        private System.Windows.Forms.Label lbl_Model_Name;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
    }
}