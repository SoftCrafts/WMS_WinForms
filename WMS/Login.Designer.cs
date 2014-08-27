namespace WMS
{
    partial class Login
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
            this.txt_Username = new Telerik.WinControls.UI.RadTextBox();
            this.txt_Password = new Telerik.WinControls.UI.RadTextBox();
            this.lbl_Username = new Telerik.WinControls.UI.RadLabel();
            this.lbl_Password = new Telerik.WinControls.UI.RadLabel();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.btn_Login = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(138, 75);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(167, 22);
            this.txt_Username.TabIndex = 0;
            this.txt_Username.ThemeName = "TelerikMetro";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(138, 101);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '●';
            this.txt_Password.Size = new System.Drawing.Size(167, 22);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.ThemeName = "TelerikMetro";
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Username
            // 
            this.lbl_Username.Location = new System.Drawing.Point(64, 77);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(68, 18);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "Потребител";
            // 
            // lbl_Password
            // 
            this.lbl_Password.Location = new System.Drawing.Point(64, 101);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(45, 18);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Парола";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(205, 129);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(100, 24);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Вход";
            this.btn_Login.ThemeName = "TelerikMetro";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 290);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Name = "Login";
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.txt_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txt_Username;
        private Telerik.WinControls.UI.RadTextBox txt_Password;
        private Telerik.WinControls.UI.RadLabel lbl_Username;
        private Telerik.WinControls.UI.RadLabel lbl_Password;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadButton btn_Login;
    }
}