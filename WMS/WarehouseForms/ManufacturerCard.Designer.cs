namespace WMS.WarehouseForms
{
    partial class ManufacturerCard
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
            this.lbl_Name = new Telerik.WinControls.UI.RadLabel();
            this.txt_Name = new Telerik.WinControls.UI.RadTextBox();
            this.btn_Delete = new Telerik.WinControls.UI.RadButton();
            this.btn_New = new Telerik.WinControls.UI.RadButton();
            this.btn_Back = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.lbl_Website = new Telerik.WinControls.UI.RadLabel();
            this.txt_Website = new Telerik.WinControls.UI.RadTextBox();
            this.lbl_Country_Code = new Telerik.WinControls.UI.RadLabel();
            this.txt_Country_Code = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_New)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Website)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Website)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Country_Code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Country_Code)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.Location = new System.Drawing.Point(3, 12);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(29, 18);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Име";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(71, 12);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(173, 20);
            this.txt_Name.TabIndex = 2;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(192, 12);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(84, 22);
            this.btn_Delete.TabIndex = 17;
            this.btn_Delete.Text = "Изтриване";
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(102, 12);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(84, 22);
            this.btn_New.TabIndex = 16;
            this.btn_New.Text = "Нов";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(84, 22);
            this.btn_Back.TabIndex = 15;
            this.btn_Back.Text = "Назад";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.lbl_Website);
            this.radPanel1.Controls.Add(this.txt_Website);
            this.radPanel1.Controls.Add(this.lbl_Country_Code);
            this.radPanel1.Controls.Add(this.txt_Country_Code);
            this.radPanel1.Controls.Add(this.lbl_Name);
            this.radPanel1.Controls.Add(this.txt_Name);
            this.radPanel1.Location = new System.Drawing.Point(12, 40);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(486, 90);
            this.radPanel1.TabIndex = 18;
            // 
            // lbl_Website
            // 
            this.lbl_Website.Location = new System.Drawing.Point(3, 60);
            this.lbl_Website.Name = "lbl_Website";
            this.lbl_Website.Size = new System.Drawing.Size(47, 18);
            this.lbl_Website.TabIndex = 5;
            this.lbl_Website.Text = "Website";
            // 
            // txt_Website
            // 
            this.txt_Website.Location = new System.Drawing.Point(71, 60);
            this.txt_Website.Name = "txt_Website";
            this.txt_Website.Size = new System.Drawing.Size(173, 20);
            this.txt_Website.TabIndex = 6;
            // 
            // lbl_Country_Code
            // 
            this.lbl_Country_Code.Location = new System.Drawing.Point(3, 36);
            this.lbl_Country_Code.Name = "lbl_Country_Code";
            this.lbl_Country_Code.Size = new System.Drawing.Size(53, 18);
            this.lbl_Country_Code.TabIndex = 3;
            this.lbl_Country_Code.Text = "Държава";
            // 
            // txt_Country_Code
            // 
            this.txt_Country_Code.Location = new System.Drawing.Point(71, 36);
            this.txt_Country_Code.Name = "txt_Country_Code";
            this.txt_Country_Code.Size = new System.Drawing.Size(173, 20);
            this.txt_Country_Code.TabIndex = 4;
            // 
            // ManufacturerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 383);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Back);
            this.Name = "ManufacturerCard";
            this.Text = "ManufacturerCard";
            this.Load += new System.EventHandler(this.LoadData);
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_New)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Website)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Website)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Country_Code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Country_Code)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lbl_Name;
        private Telerik.WinControls.UI.RadTextBox txt_Name;
        private Telerik.WinControls.UI.RadButton btn_Delete;
        private Telerik.WinControls.UI.RadButton btn_New;
        private Telerik.WinControls.UI.RadButton btn_Back;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel lbl_Website;
        private Telerik.WinControls.UI.RadTextBox txt_Website;
        private Telerik.WinControls.UI.RadLabel lbl_Country_Code;
        private Telerik.WinControls.UI.RadTextBox txt_Country_Code;
    }
}