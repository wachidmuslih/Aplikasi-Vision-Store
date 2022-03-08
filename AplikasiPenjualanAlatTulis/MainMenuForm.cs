using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPenjualanAlatTulis
{
    /// <summary>
    /// Main Form Main Menu
    /// </summary>

    public partial class MainMenuForm : Form
    {
        /// <summary>
        /// Dekralasi variabel
        /// </summary>
        //fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        /// <summary>
        /// Main Menu Form
        /// </summary>
        //MainMenuForm
        public MainMenuForm()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDekstop_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Method Button Data Barang
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Button
        //Button Data Barang
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBarang(), sender);
        }

        /// <summary>
        /// Method Button Data Customer
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Button Data Costumer
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCustomer(), sender);
        }


        /// <summary>
        /// Method Button Data Administrator
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Button Data Administrator/ Admin
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAdmin(), sender);
        }

        //Button Data Transaksi
        /// <summary>
        /// Method Button Data Transaksi
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTransaksi(), sender);
        }


        /// <summary>
        /// Method Button Detail Transaksi
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Button Data Detail transaksi
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDetailTransaksi(), sender);
        }

        /// <summary>
        /// Method Close Child Form
        /// untuk menutup child form
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Button Close Child Form
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        /// <summary>
        /// Method Button Exit
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Button Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Method Select Theme Color
        /// Untuk memilih warna pada tema
        /// </summary>
        /// <returns>mengembalikan warna</returns>
        //method
        //method selectThemeColor --> untuk mengambil warna tema secara acak/random
        private Color selectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        /// <summary>
        /// Method Active Button
        /// Method ini digunakan untuk mengaktifkan background button dengan mengimplementasikan warna tema secara acak
        /// </summary>
        /// <param name="btnSender">parameter button sender</param>
        //Method ActiveButton
        //Method ini digunakan untuk mengaktifkan background button dengan mengimplementasikan warna tema secara acak
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = selectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        /// <summary>
        /// Method DisableButton
        /// Method ini digunakan untuk menonaktifkan background button dengan mengimplementasikan warna tema default
        /// </summary>
        //Method DisableButton
        //Method ini digunakan untuk menonaktifkan background button dengan mengimplementasikan warna tema default
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.DarkBlue;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                }
            }
        }

        /// <summary>
        /// OpenChildFor
        /// Method ini digunakan untuk menampilkan child form kedalam MainMenuForm
        /// </summary>
        /// <param name="childForm">parameter child form</param>
        /// <param name="btnSender">parameter btnsender</param>
        //Method OpenChildForm
        //Method ini digunakan untuk menampilkan child form kedalam MainMenuForm
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDekstop.Controls.Add(childForm);
            this.panelDekstop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        /// <summary>
        /// Method Reset
        /// Method ini digunakan untuk mengembalikan thema dan Title di MainMenuForm
        /// </summary>
        //Method Reset
        //Method ini digunakan untuk mengembalikan thema dan Title di MainMenuForm
        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.ForestGreen;
            panelLogo.BackColor = Color.Navy;
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainMenuForm_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
