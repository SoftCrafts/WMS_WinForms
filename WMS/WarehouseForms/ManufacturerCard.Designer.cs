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
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_New)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.Location = new System.Drawing.Point(12, 51);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(29, 18);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Име";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(73, 51);
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
            // ManufacturerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 383);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Name = "ManufacturerCard";
            this.Text = "ManufacturerCard";
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_New)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lbl_Name;
        private Telerik.WinControls.UI.RadTextBox txt_Name;
        private Telerik.WinControls.UI.RadButton btn_Delete;
        private Telerik.WinControls.UI.RadButton btn_New;
        private Telerik.WinControls.UI.RadButton btn_Back;
    }
}