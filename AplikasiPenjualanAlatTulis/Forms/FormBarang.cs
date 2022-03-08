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
    /// Main Form Barang
    /// </summary>
    public partial class FormBarang : Form
    {

        /// <summary>
        /// Dekralasi variabel
        /// </summary>
        //Fields
        private string kstr = "data source= LAPTOP-LD2MHLOM; database=VisionStore; User " + "ID=sa; Password=sa";

        private SqlConnection koneksi;

        private string BarangTerpilih;


        /// <summary>
        /// Constructor Edit Mode
        /// </summary>
        //Construktor
        public bool EditMode { get; private set; }


        /// <summary>
        /// Method Form Barang
        /// </summary>
        //Form Barang
        public FormBarang()
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
        //FormBarang load berisi datasource dari dataset Barang
        private void FormBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visionStoreDataSet1.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.visionStoreDataSet1.Barang);

        }

        //Method
        //Method RefreshForm untuk refresh text box yang ada di form
        /// <summary>
        /// Method Refreshform
        /// untuk merefresh textbox yang ada di dalam form
        /// </summary>
        private void refreshform()
        {
            txNama.Text = "";
            txKode.Text = "";
            txHarga.Text = "";
            SetEnable(false);

        }

        /// <summary>
        /// Method SetEnable
        /// </summary>
        /// <param name="enabled">parameter enable</param>
        //Method SetEnable
        private void SetEnable(bool enabled)
        {
            txNama.Enabled = enabled;
            txKode.Enabled = enabled;
            txHarga.Enabled = enabled;
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
            string str = "select * from dbo.Barang";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvBarang.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        /// <summary>
        /// Method Button Add
        /// Untuk menambahkan data
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Toolbox
        //Button Add untuk menambahkan data
        private void button1_Click(object sender, EventArgs e)
        {
            SetEnable(true);
            EditMode = false;
        }


        /// <summary>
        /// Method button Delete
        /// Untuk menghapus data
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Button Delete untuk menghapus data
        private void button3_Click(object sender, EventArgs e)
        {
            string namaBrg = txNama.Text;

            if (namaBrg == "")
            {
                MessageBox.Show("Masukkan Nama Barang", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var hasil = MessageBox.Show("Anda yakin mengahpus data?", "Konfirmasi Mengahapus data", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    koneksi.Open();
                    string str = "delete from dbo.Barang where kode_barang = @id";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("id", BarangTerpilih));
                    cmd.ExecuteNonQuery();

                    koneksi.Close();
                    MessageBox.Show("Data Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refreshform();
                }
            }
        }

        /// <summary>
        /// Method Button Save
        /// Untuk menyimpan data
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Button Save untuk menyimpan data
        private void button2_Click(object sender, EventArgs e)
        {
            string nama = txNama.Text;
            string kode = txKode.Text;
            int harga = int.Parse(txHarga.Text);
            

            if (nama == "" && kode == "")
            {
                MessageBox.Show("Masukkan Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (EditMode)
                {
                    koneksi.Open();
                    string str = "update dbo.Barang set nama_barang= @name, kode_barang = @id, harga_satuan = @harga where kode_barang= @id";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("id", BarangTerpilih));
                    cmd.Parameters.Add(new SqlParameter("name", nama));
                    cmd.Parameters.Add(new SqlParameter("harga", harga));
                    cmd.ExecuteNonQuery();
                    koneksi.Close();
                }
                else
                {
                    koneksi.Open();
                    string str = "insert into dbo.Barang(nama_barang, kode_barang, harga_satuan)" + "values(@name, @id, @harga)";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("id", kode));
                    cmd.Parameters.Add(new SqlParameter("name", nama));
                    cmd.Parameters.Add(new SqlParameter("harga", harga));
                    cmd.ExecuteNonQuery();

                    koneksi.Close();
                    MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshform();
                }
                EditMode = false;
            }
        }

        /// <summary>
        /// Method Update data
        /// untuk mengupdate data
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Button update untuk memperbarui data
        private void button4_Click(object sender, EventArgs e)
        {
            EditMode = true;
            SetEnable(true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method Button Refresh
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Button Refresh untuk merefresh form dan menampilkan data di datagridview
        private void button5_Click(object sender, EventArgs e)
        {
            koneksi.Close();
            ShowDgv();
            txNama.Clear();
            txKode.Clear();
            txHarga.Clear();
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
            var row = dgvBarang.Rows[cellRow];
            txNama.Text = row.Cells[1].Value.ToString();
            txKode.Text = row.Cells[0].Value.ToString();
            BarangTerpilih = row.Cells[0].Value.ToString();
        }
    }
}
