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
    /// Main Form Detail Transaksi
    /// </summary>

    public partial class FormDetailTransaksi : Form
    {

        /// <summary>
        /// Dekralasi variabel
        /// </summary>

        //Fields
        private string kstr = "data source= LAPTOP-LD2MHLOM; database=VisionStore; User " + "ID=sa; Password=sa";

        private SqlConnection koneksi;

        private string DetailTransaksiTerpilih;


        /// <summary>
        /// Constructor Edit Mode
        /// </summary>

        //Construktor
        public bool EditMode { get; private set; }

        /// <summary>
        /// Method Form Detail Transaksi
        /// </summary>
        //FormDetailTransaksi
        public FormDetailTransaksi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(kstr);
            refreshform();
        }

        /// <summary>
        /// Method FormDetailTraksaksi_Load
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //FormDetailTransaksi_load yang berisi data source dalam datagridview
        private void FormDetailTransaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visionStoreDataSet1.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.visionStoreDataSet1.Transaksi);
            // TODO: This line of code loads data into the 'visionStoreDataSet1.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.visionStoreDataSet1.Barang);
            // TODO: This line of code loads data into the 'visionStoreDataSet1.Detail_Transaksi' table. You can move, or remove it, as needed.
            this.detail_TransaksiTableAdapter.Fill(this.visionStoreDataSet1.Detail_Transaksi);

        }

        /// <summary>
        /// Method Refreshform
        /// untuk merefresh textbox yang ada di dalam form
        /// </summary>
        //Method
        //Method RefreshForm untuk refresh text box yang ada di form
        private void refreshform()
        {
            txDetail.Text = "";
            cbTransaksi.Text = "";
            cbKodeBarang.Text = "";
            cbHarga.Text = "";
            txKuantitas.Text = "";
            SetEnable(false);

        }


        /// <summary>
        /// Method SetEnable
        /// </summary>
        /// <param name="enabled">parameter enable</param>
        //Method SetEnable
        private void SetEnable(bool enabled)
        {
            txDetail.Enabled = enabled;
            cbTransaksi.Enabled = enabled;
            cbKodeBarang.Enabled = enabled;
            cbHarga.Enabled = enabled;
            txKuantitas.Enabled = enabled;
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
            string str = "select * from dbo.Detail_Transaksi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvDetail.DataSource = ds.Tables[0];
            koneksi.Close();
        }


        /// <summary>
        /// Method Button Add
        /// Untuk menambahkan data
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Toolbox
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
            string idDetail = txDetail.Text;
            string kodeTransaksi = cbTransaksi.Text;
            string kodeBarang = cbKodeBarang.Text;
            int harga = int.Parse(cbHarga.Text);
            int kuantias = int.Parse(txKuantitas.Text);
            int subTotal = harga * kuantias;



            if (idDetail == "")
            {
                MessageBox.Show("Masukkan Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (EditMode)
                {
                    koneksi.Open();
                    string str = "update dbo.Detail_Transaksi set id_detail = @detail, kode_transaksi = @kodeTr, kode_barang = @kodeBr, harga = @harga, kuantitas =@qty, sub_total = @stotal where id_detail = @detail";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("detail", DetailTransaksiTerpilih));
                    cmd.Parameters.Add(new SqlParameter("kodeTr", kodeTransaksi)); ;
                    cmd.Parameters.Add(new SqlParameter("kodeBr", kodeBarang));
                    cmd.Parameters.Add(new SqlParameter("harga", harga));
                    cmd.Parameters.Add(new SqlParameter("qty", kuantias));
                    cmd.Parameters.Add(new SqlParameter("stotal", subTotal));
                    cmd.ExecuteNonQuery();
                    koneksi.Close();
                }
                else
                {
                    koneksi.Open();
                    string str = "insert into dbo.Detail_Transaksi(id_detail, kode_transaksi, kode_barang, harga, kuantitas, sub_total)" + "values(@id, @kodetr, @kodebr, @harga, @qty, @stotal)";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("id", idDetail));
                    cmd.Parameters.Add(new SqlParameter("kodetr", kodeTransaksi)); ;
                    cmd.Parameters.Add(new SqlParameter("kodebr", kodeBarang));
                    cmd.Parameters.Add(new SqlParameter("harga", harga));
                    cmd.Parameters.Add(new SqlParameter("qty", kuantias));
                    cmd.Parameters.Add(new SqlParameter("stotal", subTotal));
                    cmd.ExecuteNonQuery();

                    koneksi.Close();
                    MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
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
            string DetailTr = txDetail.Text;

            if (DetailTr == "")
            {
                MessageBox.Show("Masukkan Kode Transaksi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var hasil = MessageBox.Show("Anda yakin menghapus data?", "Konfirmasi Menghapus data", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    koneksi.Open();
                    string str = "delete from dbo.Detail_Transaksi where id_detail = @id";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("id", DetailTransaksiTerpilih));
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
        //Button Delete untuk menghapus data
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
            txDetail.Clear();
            txKuantitas.Clear();
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
            var row = dgvDetail.Rows[cellRow];
            txDetail.Text = row.Cells[0].Value.ToString();
            DetailTransaksiTerpilih = row.Cells[0].Value.ToString();
        }
    }
}
