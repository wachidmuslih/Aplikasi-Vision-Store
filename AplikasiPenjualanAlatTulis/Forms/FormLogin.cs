using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPenjualanAlatTulis.Forms
{

    /// <summary>
    /// Main Form Login
    /// </summary>
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            
        }


        /// <summary>
        /// Method Login Button
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Login Button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txEmail.Text.ToLower() == "admin@mail.com" && txPassword.Text.ToLower() == "123456")
            {
                MessageBox.Show("Login Sukses");

                MainMenuForm mainMenu = new MainMenuForm();
                mainMenu.Show();
                this.Hide();


            }
            else if (txEmail.Text.ToLower() != "admin" && txPassword.Text.ToLower() == "123456")
            {
                MessageBox.Show("Username salah");
                CancelLogin();
            }
            else if (txEmail.Text.ToLower() == "admin" && txPassword.Text.ToLower() != "123456")
            {
                MessageBox.Show("Password salah");
                CancelLogin();
            }
            else if (txEmail.Text.ToLower() == "" && txPassword.Text.ToLower() == "")
            {
                MessageBox.Show("Username dan Password harus diisi");
                CancelLogin();
            }
        }

        //Button Exit
        /// <summary>
        /// Method Button Exit
        /// Untuk keluar dari aplikasi
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Method Cancel Login
        /// Untuk membatalkan login
        /// </summary>
        //Method Cancel Login
        private void CancelLogin()
        {
            this.DialogResult = DialogResult.None;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
