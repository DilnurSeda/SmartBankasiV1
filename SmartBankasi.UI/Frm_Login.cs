using SmartBankasi.BLL.Loginislemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBankasi.UI
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }   
        private void btn_Girisyap_CheckedChanged(object sender, EventArgs e)
        {
            LoginManager giris = new LoginManager();
           
            bool girisSorgu = giris.Login(txt_LoginName.Text, txt_LoginPassword.Text);
            
            if (girisSorgu)
            {
                Frm_Menu frm_menu = new Frm_Menu();
                this.Hide();
                frm_menu.lblmenukullaniciadi.Text = giris.kullaniciAdiSoyadi;
                //frm_menu.ye = giris.yetki_IDclass; 
                frm_menu.label1.Text = giris.kullanici_id.ToString();                           
                frm_menu.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
        }
    }
}
