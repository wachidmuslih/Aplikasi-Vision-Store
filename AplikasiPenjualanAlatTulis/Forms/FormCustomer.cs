using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPenjualanAlatTulis.Forms
{
    /// <summary>
    /// Main Form Customer
    /// </summary>
    public partial class FormCustomer : Form
    {
        /// <summary>
        /// Dekralasi variabel
        /// </summary>
        //Fields
        private string kstr = "data source= LAPTOP-LD2MHLOM; database=VisionStore; User " + "ID=sa; Password=sa";

        private SqlConnection koneksi;

        private string CustomerTerpilih;

        /// <summary>
        /// Constructor Edit Mode
        /// </summary>
        //Construktor
        public bool EditMode { get; private set; }

        /// <summary>
        /// Method Form Customer
        /// </summary>
        //FormCustomer
        public FormCustomer()
        {
            InitializeComponent();
            koneksi = new SqlConnection(kstr);
            refreshform();
        }

        /// <summary>
        /// Method FormCustomer_Load
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //FormCustomer_load yang berisi data source dalam datagridview
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visionStoreDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.visionStoreDataSet1.Customer);

        }


        /// <summary>
        /// Method Refreshform
        /// untuk merefresh textbox yang ada di dalam form
        /// </summary>
        //Method
        //Method RefreshForm untuk refresh text box yang ada di form
        private void refreshform()
        {
            txNamaCustomer.Text = "";
            txId.Text = "";
            txNotel.Text = "";
            txAlamat.Text = "";
            SetEnable(false);

        }

        /// <summary>
        /// Method SetEnable
        /// </summary>
        /// <param name="enabled">parameter enable</param>
        //Method SetEnable
        private void SetEnable(bool enabled)
        {
            txNamaCustomer.Enabled = enabled;
            txId.Enabled = enabled;
            txNotel.Enabled = enabled;
            txAlamat.Enabled = enabled;
            btnSave.Enabled = enabled;
        }

        /// <summary>
        /// method Show DataGridView
        /// Untuk menampilkan data di data gridview
        /// </summary>
        //Method Show data in datagridview
        private void ShowDgv()
        {
            koneksi.Open();
            string str = "select * from dbo.Customer";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvCustomer.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        /// <summary>
        /// Method Button Add
        /// Untuk menambahkan data
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Button
        //Button Add untuk menambahkan data
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetEnable(true);
            EditMode = false;
        }

        /// <summary>
        /// Method Button Save
        /// Untuk menyimpan data
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Button Save untuk menyimpan data
        private void btnSave_Click(object sender, EventArgs e)
        {
            string nama = txNamaCustomer.Text;
            string idCos = txId.Text;
            string nomor = txNotel.Text;
            string alamat = txAlamat.Text;

            if (nama == "" &&  idCos =="" && nomor =="" && alamat == "")
            {
                MessageBox.Show("Masukkan Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (EditMode)
                {
                    koneksi.Open();
                    string str = "update dbo.Customer set nama_costumer= @name, nomor_hp = @nmr, id_costumer = @id, alamat = @almt where id_costumer= @id";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("id", CustomerTerpilih));
                    cmd.Parameters.Add(new SqlParameter("name", nama));
                    cmd.Parameters.Add(new SqlParameter("nmr", nomor));
                    cmd.Parameters.Add(new SqlParameter("almt", alamat));
                    cmd.ExecuteNonQuery();
                    koneksi.Close();
                }
                else
                {
                    koneksi.Open();
                    string str = "insert into dbo.Customer(nama_costumer, id_costumer, nomor_hp, alamat)" + "values(@name, @id, @nmr, @almt)";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("id", idCos));
                    cmd.Parameters.Add(new SqlParameter("name", nama));
                    cmd.Parameters.Add(new SqlParameter("nmr", nomor));
                    cmd.Parameters.Add(new SqlParameter("almt", alamat));
                    cmd.ExecuteNonQuery();

                    koneksi.Close();
                    MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshform();
                }
                EditMode = false;
            }
        }

        /// <summary>
        /// Method button Delete
        /// Untuk menghapus data
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>

        //Button Delete untuk menghapus data
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string namaCust = txNamaCustomer.Text;

            if (namaCust == "")
            {
                MessageBox.Show("Masukkan Nama Costumer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var hasil = MessageBox.Show("Anda yakin mengahpus data?", "Konfirmasi Mengahapus data", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    koneksi.Open();
                    string str = "delete from dbo.Customer where id_costumer = @id";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("id", CustomerTerpilih));
                    cmd.ExecuteNonQuery();

                    koneksi.Close();
                    MessageBox.Show("Data Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refreshform();
                }
            }
        }

        /// <summary>
        /// Method Update data
        /// untuk mengupdate data
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Button update untuk memperbarui data
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditMode = true;
            SetEnable(true);
        }

        /// <summary>
        /// Method Button Refresh
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Button Refresh untuk merefresh form dan menampilkan data di datagridview
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            koneksi.Close();
            ShowDgv();
            txNamaCustomer.Clear();
            txId.Clear();
            txAlamat.Clear();
            txNotel.Clear();
        }

        /// <summary>
        /// Method dgv_CellContectClick
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Dgv CellContentClick
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellRow = e.RowIndex;
            var row = dgvCustomer.Rows[cellRow];
            txNamaCustomer.Text = row.Cells[1].Value.ToString();
            txId.Text = row.Cells[0].Value.ToString();
            CustomerTerpilih = row.Cells[0].Value.ToString();
        }
    }
}
