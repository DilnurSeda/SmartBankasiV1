namespace SmartBankasi.UI
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Girisyap = new DevExpress.XtraEditors.CheckButton();
            this.txt_LoginPassword = new DevExpress.XtraEditors.TextEdit();
            this.txt_LoginName = new DevExpress.XtraEditors.TextEdit();
            this.picture_Login = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LoginPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LoginName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Girisyap);
            this.panel1.Controls.Add(this.txt_LoginPassword);
            this.panel1.Controls.Add(this.txt_LoginName);
            this.panel1.Location = new System.Drawing.Point(119, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 228);
            this.panel1.TabIndex = 0;
            // 
            // btn_Girisyap
            // 
            this.btn_Girisyap.Location = new System.Drawing.Point(23, 179);
            this.btn_Girisyap.Name = "btn_Girisyap";
            this.btn_Girisyap.Size = new System.Drawing.Size(219, 31);
            this.btn_Girisyap.TabIndex = 2;
            this.btn_Girisyap.Text = "GİRİŞ YAP";
            this.btn_Girisyap.CheckedChanged += new System.EventHandler(this.btn_Girisyap_CheckedChanged);
            // 
            // txt_LoginPassword
            // 
            this.txt_LoginPassword.Location = new System.Drawing.Point(23, 126);
            this.txt_LoginPassword.Name = "txt_LoginPassword";
            this.txt_LoginPassword.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txt_LoginPassword.Properties.Appearance.Options.UseBackColor = true;
            this.txt_LoginPassword.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("txt_LoginPassword.Properties.ContextImageOptions.SvgImage")));
            this.txt_LoginPassword.Properties.NullText = "  Şifre";
            this.txt_LoginPassword.Properties.PasswordChar = '*';
            this.txt_LoginPassword.Size = new System.Drawing.Size(219, 36);
            this.txt_LoginPassword.TabIndex = 1;
            // 
            // txt_LoginName
            // 
            this.txt_LoginName.Location = new System.Drawing.Point(23, 70);
            this.txt_LoginName.Name = "txt_LoginName";
            this.txt_LoginName.Properties.AllowFocused = false;
            this.txt_LoginName.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txt_LoginName.Properties.Appearance.Options.UseBackColor = true;
            this.txt_LoginName.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("txt_LoginName.Properties.ContextImageOptions.SvgImage")));
            this.txt_LoginName.Properties.NullText = "  Kullanıcı Adı";
            this.txt_LoginName.Size = new System.Drawing.Size(219, 36);
            this.txt_LoginName.TabIndex = 0;
            // 
            // picture_Login
            // 
            this.picture_Login.BackColor = System.Drawing.Color.Transparent;
            this.picture_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_Login.BackgroundImage")));
            this.picture_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_Login.Location = new System.Drawing.Point(195, 33);
            this.picture_Login.Name = "picture_Login";
            this.picture_Login.Size = new System.Drawing.Size(120, 94);
            this.picture_Login.TabIndex = 0;
            this.picture_Login.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 351);
            this.Controls.Add(this.picture_Login);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMART BANKASI";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_LoginPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LoginName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picture_Login;
        private DevExpress.XtraEditors.TextEdit txt_LoginPassword;
        private DevExpress.XtraEditors.TextEdit txt_LoginName;
        private DevExpress.XtraEditors.CheckButton btn_Girisyap;
    }
}