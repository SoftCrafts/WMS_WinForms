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
            this.txt_Model_ID = new Telerik.WinControls.UI.RadTextBox();
            this.txt_Model_Name = new Telerik.WinControls.UI.RadTextBox();
            this.lbl_Model_ID = new System.Windows.Forms.Label();
            this.lbl_Manufacturer_ID = new System.Windows.Forms.Label();
            this.lbl_Model_Name = new System.Windows.Forms.Label();
            this.btn_Save = new Telerik.WinControls.UI.RadButton();
            this.btn_Back = new Telerik.WinControls.UI.RadButton();
            this.cmb_Manufacturer = new Telerik.WinControls.UI.RadDropDownList();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.date_picker_Prod_Date = new Telerik.WinControls.UI.RadDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Model_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Model_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Manufacturer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_picker_Prod_Date)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Model_ID
            // 
            this.txt_Model_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Model_ID.Enabled = false;
            this.txt_Model_ID.Location = new System.Drawing.Point(130, 20);
            this.txt_Model_ID.Name = "txt_Model_ID";
            this.txt_Model_ID.Size = new System.Drawing.Size(164, 20);
            this.txt_Model_ID.TabIndex = 0;
            // 
            // txt_Model_Name
            // 
            this.txt_Model_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Model_Name.Location = new System.Drawing.Point(130, 72);
            this.txt_Model_Name.Name = "txt_Model_Name";
            this.txt_Model_Name.Size = new System.Drawing.Size(164, 20);
            this.txt_Model_Name.TabIndex = 2;
            // 
            // lbl_Model_ID
            // 
            this.lbl_Model_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Model_ID.AutoSize = true;
            this.lbl_Model_ID.Location = new System.Drawing.Point(16, 22);
            this.lbl_Model_ID.Name = "lbl_Model_ID";
            this.lbl_Model_ID.Size = new System.Drawing.Size(57, 13);
            this.lbl_Model_ID.TabIndex = 3;
            this.lbl_Model_ID.Text = "Модел ID:";
            // 
            // lbl_Manufacturer_ID
            // 
            this.lbl_Manufacturer_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Manufacturer_ID.AutoSize = true;
            this.lbl_Manufacturer_ID.Location = new System.Drawing.Point(16, 47);
            this.lbl_Manufacturer_ID.Name = "lbl_Manufacturer_ID";
            this.lbl_Manufacturer_ID.Size = new System.Drawing.Size(40, 13);
            this.lbl_Manufacturer_ID.TabIndex = 4;
            this.lbl_Manufacturer_ID.Text = "Марка";
            // 
            // lbl_Model_Name
            // 
            this.lbl_Model_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Model_Name.AutoSize = true;
            this.lbl_Model_Name.Location = new System.Drawing.Point(16, 74);
            this.lbl_Model_Name.Name = "lbl_Model_Name";
            this.lbl_Model_Name.Size = new System.Drawing.Size(29, 13);
            this.lbl_Model_Name.TabIndex = 5;
            this.lbl_Model_Name.Text = "Име";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(12, 13);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(84, 24);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Запиши";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(15, 43);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(84, 24);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "Назад";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // cmb_Manufacturer
            // 
            this.cmb_Manufacturer.AllowShowFocusCues = false;
            this.cmb_Manufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Manufacturer.AutoCompleteDisplayMember = null;
            this.cmb_Manufacturer.AutoCompleteValueMember = null;
            this.cmb_Manufacturer.Location = new System.Drawing.Point(130, 46);
            this.cmb_Manufacturer.Name = "cmb_Manufacturer";
            this.cmb_Manufacturer.Size = new System.Drawing.Size(164, 20);
            this.cmb_Manufacturer.TabIndex = 8;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(151, 2);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(206, 31);
            this.lbl_Title.TabIndex = 9;
            this.lbl_Title.Text = "Модели Карта";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.date_picker_Prod_Date);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_Model_ID);
            this.panel1.Controls.Add(this.txt_Model_ID);
            this.panel1.Controls.Add(this.cmb_Manufacturer);
            this.panel1.Controls.Add(this.txt_Model_Name);
            this.panel1.Controls.Add(this.lbl_Manufacturer_ID);
            this.panel1.Controls.Add(this.lbl_Model_Name);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 258);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Дата Производство";
            // 
            // date_picker_Prod_Date
            // 
            this.date_picker_Prod_Date.Location = new System.Drawing.Point(130, 98);
            this.date_picker_Prod_Date.Name = "date_picker_Prod_Date";
            this.date_picker_Prod_Date.Size = new System.Drawing.Size(164, 20);
            this.date_picker_Prod_Date.TabIndex = 9;
            this.date_picker_Prod_Date.TabStop = false;
            this.date_picker_Prod_Date.Text = "Sunday, August 17, 2014";
            this.date_picker_Prod_Date.Value = new System.DateTime(2014, 8, 17, 2, 43, 46, 955);
            // 
            // ModelCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(530, 357);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Save);
            this.Name = "ModelCard";
            this.Text = "Модел Карта";
            this.Load += new System.EventHandler(this.ModelCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Model_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Model_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Manufacturer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_picker_Prod_Date)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txt_Model_ID;
        private Telerik.WinControls.UI.RadTextBox txt_Model_Name;
        private System.Windows.Forms.Label lbl_Model_ID;
        private System.Windows.Forms.Label lbl_Manufacturer_ID;
        private System.Windows.Forms.Label lbl_Model_Name;
        private Telerik.WinControls.UI.RadButton btn_Save;
        private Telerik.WinControls.UI.RadButton btn_Back;
        private Telerik.WinControls.UI.RadDropDownList cmb_Manufacturer;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDateTimePicker date_picker_Prod_Date;
    }
}