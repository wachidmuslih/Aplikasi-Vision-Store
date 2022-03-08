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
    /// Main Form Transaksi
    /// </summary>
    public partial class FormTransaksi : Form
    {

        /// <summary>
        /// Dekralasi variabel
        /// </summary>
        //Fields
        private string kstr = "data source= LAPTOP-LD2MHLOM; database=VisionStore; User " + "ID=sa; Password=sa";

        private SqlConnection koneksi;

        private string TransaksiTerpilih;


        /// <summary>
        /// Constructor Edit Mode
        /// </summary>
        //Construktor
        public bool EditMode { get; private set; }

        //FormTransaksi
        /// <summary>
        /// Method Form Transaksi
        /// </summary>
        public FormTransaksi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(kstr);
            refreshform();
        }


        /// <summary>
        /// Method FormBarang_Load
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //FormCustomer_load yang berisi data source dalam datagridview
        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visionStoreDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.visionStoreDataSet1.Customer);
            // TODO: This line of code loads data into the 'visionStoreDataSet1.Administrator' table. You can move, or remove it, as needed.
            this.administratorTableAdapter.Fill(this.visionStoreDataSet1.Administrator);
            // TODO: This line of code loads data into the 'visionStoreDataSet1.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.visionStoreDataSet1.Transaksi);

        }



        /// <summary>
        /// Method Refreshform
        /// untuk merefresh textbox yang ada di dalam form
        /// </summary>
        //Method
        //Method RefreshForm untuk refresh text box yang ada di form
        private void refreshform()
        {
            txKodeTransaksi.Text = "";
            dtTanggal.Text = "";
            cbIdAdmin.Text= "";
            cbxIdCust.Text = "";
            txTotal.Text = "";
            txBayar.Text = "";
            SetEnable(false);

        }

        //Method SetEnable
        /// <summary>
        /// Method SetEnable
        /// </summary>
        /// <param name="enabled">parameter enable</param>
        private void SetEnable(bool enabled)
        {
            txKodeTransaksi.Enabled = enabled ;
            dtTanggal.Enabled = enabled;
            cbIdAdmin.Enabled = enabled;
            cbxIdCust.Enabled = enabled;
            txTotal.Enabled = enabled;
            txBayar.Enabled = enabled;
            
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
            string str = "select * from dbo.Transaksi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTransaksi.DataSource = ds.Tables[0];
            koneksi.Close();
        }



        //Toolbox

        //Button
        //Button Add untuk menambahkan data
        /// <summary>
        /// Method Button Add
        /// Untuk menambahkan data
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetEnable(true);
            EditMode = false;
        }


        //Button Save untuk menyimpan data
        /// <summary>
        /// Method Button Save
        /// Untuk menyimpan data
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            dtTanggal.Format = DateTimePickerFormat.Custom;
            dtTanggal.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            string tgl = dtTanggal.Text;
            string kode = txKodeTransaksi.Text;
            string idAdm = cbIdAdmin.Text;
            string idCs = cbxIdCust.Text;
            int total = int.Parse(txTotal.Text);
            int bayar = int.Parse(txBayar.Text);
            int kembali = bayar - total;
            


            if (kode == "" && idAdm == "" && idCs == "")
            {
                MessageBox.Show("Masukkan Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (EditMode)
                {
                    koneksi.Open();
                    string str = "update dbo.Transaksi set kode_transaksi = @kodee, tanggal = @tgl, id_admin = @ida, id_costumer =@idc, total = @ttl, bayar = @byr, kembalian = @kmbl where kode_transaksi = @kodee";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("kodee", TransaksiTerpilih));
                    cmd.Parameters.Add(new SqlParameter("tgl", tgl)); ;
                    cmd.Parameters.Add(new SqlParameter("ida", idAdm));
                    cmd.Parameters.Add(new SqlParameter("idc", idCs));
                    cmd.Parameters.Add(new SqlParameter("ttl", total));
                    cmd.Parameters.Add(new SqlParameter("byr", bayar));
                    cmd.Parameters.Add(new SqlParameter("kmbl", kembali));
                    cmd.ExecuteNonQuery();
                    koneksi.Close();
                }
                else
                {
                    koneksi.Open();
                    string str = "insert into dbo.Transaksi(kode_transaksi, tanggal, id_admin, id_costumer, total, bayar, kembalian)" + "values(@kode, @tgl, @ida, @idc, @total, @bayar, @kembali)";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("kode", kode));
                    cmd.Parameters.Add(new SqlParameter("tgl", tgl)); ;
                    cmd.Parameters.Add(new SqlParameter("ida", idAdm));
                    cmd.Parameters.Add(new SqlParameter("idc", idCs));
                    cmd.Parameters.Add(new SqlParameter("total", total));
                    cmd.Parameters.Add(new SqlParameter("bayar", bayar));
                    cmd.Parameters.Add(new SqlParameter("kembali", kembali));
                    cmd.ExecuteNonQuery();

                    koneksi.Close();
                    MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshform();
                }
                EditMode = false;
            }

        }

        private void dtTanggal_ValueChanged(object sender, EventArgs e)
        {

        }


        //Button Delete untuk menghapus data
        /// <summary>
        /// Method button Delete
        /// Untuk menghapus data
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Transaksi = txKodeTransaksi.Text;

            if (Transaksi == "")
            {
                MessageBox.Show("Masukkan Kode Transaksi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var hasil = MessageBox.Show("Anda yakin menghapus data?", "Konfirmasi Menghapus data", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    koneksi.Open();
                    string str = "delete from dbo.Transaksi where kode_transaksi = @id";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("id", TransaksiTerpilih));
                    cmd.ExecuteNonQuery();

                    koneksi.Close();
                    MessageBox.Show("Data Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refreshform();
                }
            }
        }

        //Button update untuk memperbarui data
        /// <summary>
        /// Method Update data
        /// untuk mengupdate data
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        private void btnUpdate_Click(object sender, EventArgs e)
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
            txKodeTransaksi.Clear();
            txTotal.Clear();
            txBayar.Clear();
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
            var row = dgvTransaksi.Rows[cellRow];
            txKodeTransaksi.Text = row.Cells[0].Value.ToString();
            TransaksiTerpilih = row.Cells[0].Value.ToString();
        }
    }
}
