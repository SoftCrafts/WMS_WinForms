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
            this.txt_Password = new Telerik.WinControls.UI.RadTextBox();
            this.lbl_Username = new Telerik.WinControls.UI.RadLabel();
            this.lbl_Password = new Telerik.WinControls.UI.RadLabel();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.btn_Login = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.cmb_User = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_User)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Password
            // 
            this.txt_Password.AutoSize = false;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_Password.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_Password.Location = new System.Drawing.Point(117, 102);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '●';
            this.txt_Password.Size = new System.Drawing.Size(167, 22);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.Text = "54sd439h";
            this.txt_Password.ThemeName = "TelerikMetro";
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnEnterPress);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = false;
            this.lbl_Username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(31, 77);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(80, 21);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "Потребител";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = false;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(31, 101);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(53, 21);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Парола";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(184, 130);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(100, 24);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Вход";
            this.btn_Login.ThemeName = "TelerikMetro";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(70, 40);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(80, 31);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Вход";
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.ForeColor = System.Drawing.Color.DarkRed;
            this.radLabel2.Location = new System.Drawing.Point(31, 48);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(253, 22);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Въведете потребителско име и парола";
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.radPanel1.Controls.Add(this.cmb_User);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.txt_Password);
            this.radPanel1.Controls.Add(this.btn_Login);
            this.radPanel1.Controls.Add(this.lbl_Username);
            this.radPanel1.Controls.Add(this.lbl_Password);
            this.radPanel1.Location = new System.Drawing.Point(66, 77);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(348, 195);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.ThemeName = "TelerikMetro";
            // 
            // cmb_User
            // 
            this.cmb_User.AutoCompleteDisplayMember = null;
            this.cmb_User.AutoCompleteValueMember = null;
            this.cmb_User.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmb_User.Location = new System.Drawing.Point(117, 76);
            this.cmb_User.Name = "cmb_User";
            this.cmb_User.Size = new System.Drawing.Size(167, 23);
            this.cmb_User.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(705, 386);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radPanel1);
            this.Name = "Login";
            this.ShowIcon = false;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txt_Password;
        private Telerik.WinControls.UI.RadLabel lbl_Username;
        private Telerik.WinControls.UI.RadLabel lbl_Password;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadButton btn_Login;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadDropDownList cmb_User;
    }
}