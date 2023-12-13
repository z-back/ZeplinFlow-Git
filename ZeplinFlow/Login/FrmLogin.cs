using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeplinFlow.Main;
using ZeplinFlow.Model;

namespace ZeplinFlow.Login
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        YMKFLOWEntities db = new YMKFLOWEntities();
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            int increaseAmount = 30;

            int newRed = Math.Min(255, panelControl1.BackColor.R + increaseAmount);
            int newGreen = Math.Min(255, panelControl1.BackColor.G + increaseAmount);
            int newBlue = Math.Min(255, panelControl1.BackColor.B + increaseAmount);

            panelControl1.BackColor = Color.FromArgb(20, newRed, newGreen, newBlue);


        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String username = UsernameTxt.Text;
                String password = PasswordTxt.Text;
                var query = from x in db.Users where x.Username == username && x.Password == password select x;
                if (UsernameTxt.Text == "" || PasswordTxt.Text == "")
                {
                    XtraMessageBox.Show("Lütfen gerekli alanları doldurunuz! ");
                }
                else if (query.Any())
                {

                    FrmMain frm = new FrmMain();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    XtraMessageBox.Show("Girilen bilgileri kontrol edip tekrar deneyiniz! ");
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}