namespace WMS
{
    partial class MainMenu
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
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem9 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem7 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem8 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "Продажби";
            this.radMenuItem2.AccessibleName = "Продажби";
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Продажби";
            this.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.AccessibleDescription = "Складови Операции";
            this.radMenuItem4.AccessibleName = "Складови Операции";
            this.radMenuItem4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem3,
            this.radMenuItem6,
            this.radMenuItem7,
            this.radMenuItem8});
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Склад";
            this.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.AccessibleDescription = "Справки";
            this.radMenuItem5.AccessibleName = "Справки";
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Справки";
            this.radMenuItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem9
            // 
            this.radMenuItem9.AccessibleDescription = "Настройки";
            this.radMenuItem9.AccessibleName = "Настройки";
            this.radMenuItem9.Name = "radMenuItem9";
            this.radMenuItem9.Text = "Настройки";
            this.radMenuItem9.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "Марки";
            this.radMenuItem1.AccessibleName = "Марки";
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Марки";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radMenuItem1.Click += new System.EventHandler(this.radMenuItem1_Click_1);
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.AccessibleDescription = "Модели";
            this.radMenuItem3.AccessibleName = "Модели";
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Модели";
            this.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radMenuItem3.Click += new System.EventHandler(this.radMenuItem3_Click);
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.AccessibleDescription = "Артикули";
            this.radMenuItem6.AccessibleName = "Артикули";
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Text = "Артикули";
            this.radMenuItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem7
            // 
            this.radMenuItem7.AccessibleDescription = "Складове";
            this.radMenuItem7.AccessibleName = "Складове";
            this.radMenuItem7.Name = "radMenuItem7";
            this.radMenuItem7.Text = "Складове";
            this.radMenuItem7.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem8
            // 
            this.radMenuItem8.AccessibleDescription = "Складови Места";
            this.radMenuItem8.AccessibleName = "Складови Места";
            this.radMenuItem8.Name = "radMenuItem8";
            this.radMenuItem8.Text = "Складови Места";
            this.radMenuItem8.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 355);
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem2,
            this.radMenuItem4,
            this.radMenuItem5,
            this.radMenuItem9});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.radMenu1.Size = new System.Drawing.Size(803, 29);
            this.radMenu1.TabIndex = 2;
            this.radMenu1.Text = "radMenu1";
            this.radMenu1.ThemeName = "TelerikMetro";
            this.Controls.Add(this.radMenu1);
            this.IsMdiContainer = true;
            this.Name = "MainMenu";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "WMS";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem9;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem6;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem7;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem8;
        private Telerik.WinControls.UI.RadMenu radMenu1;
    }
}
