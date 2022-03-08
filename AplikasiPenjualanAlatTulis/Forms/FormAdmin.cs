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
    /// Main class form Admin
    /// </summary>
    public partial class FormAdmin : Form
    {
        /// <summary>
        /// Dekralasi variabel
        /// </summary>
        //fields
        private string kstr = "data source= LAPTOP-LD2MHLOM; database=VisionStore; User " + "ID=sa; Password=sa";

        private SqlConnection koneksi;

        private string AdminTerpilih;


        /// <summary>
        /// Constructor EditMode
        /// </summary>
        //constructor
        public bool EditMode { get; private set; }


        /// <summary>
        /// Form Admin
        /// </summary>
        //Form Admin
        public FormAdmin()
        {
            InitializeComponent();
            koneksi = new SqlConnection(kstr);
            refreshform();
        }

        /// <summary>
        /// Method FormAdmin_Load
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data acara</param>
        //FormAdmin load
        //berisi implementasi dataset Administrator ke dalam datagridview
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visionStoreDataSet1.Administrator' table. You can move, or remove it, as needed.
            this.administratorTableAdapter.Fill(this.visionStoreDataSet1.Administrator);
        }

        /// <summary>
        /// Method Refresh form
        /// <remarks>Method ini digunakan untuk merefresh text box yang ada di form</remarks>
        /// </summary>
        //Method
        //Method RefreshForm untuk refresh text box yang ada di form
        private void refreshform()
        {
            txNamaAdmin.Text = "";
            txIdAdmin.Text = "";
            SetEnable(false);

        }

        /// <summary>
        /// Method SetEnable
        /// </summary>
        /// <param name="enabled">parameter enable</param>
        //Method SetEnable
        private void SetEnable(bool enabled)
        {
            txNamaAdmin.Enabled = enabled;
            txIdAdmin.Enabled = enabled;
            btnSave.Enabled = enabled;
        }


        /// <summary>
        /// Method Show Data Gridview
        /// Untuk menampilkan data pada data gridview
        /// </summary>
        //Method Show data in datagridview
        private void ShowDgv()
        {
            koneksi.Open();
            string str = "select * from dbo.Administrator";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvAdmin.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        //Toolbox

        /// <summary>
        /// Method dgv_CellContentClick
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Dgv CellContentClick
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellRow = e.RowIndex;
            var row = dgvAdmin.Rows[cellRow];
            txNamaAdmin.Text = row.Cells[1].Value.ToString();
            AdminTerpilih = row.Cells[0].Value.ToString();
        }


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

        /// <summary>
        /// Method Button Save
        /// Untuk menyimpan data
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Button Save untuk menyimpan data
        private void btnSave_Click(object sender, EventArgs e)
        {
            string nama = txNamaAdmin.Text;
            string idAdm = txIdAdmin.Text;

            if (nama == "" && idAdm == "")
            {
                MessageBox.Show("Masukkan Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (EditMode)
                {
                    koneksi.Open();
                    string str = "update dbo.Administrator set nama_admin = @name where id_admin= @id";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("id", AdminTerpilih));
                    cmd.Parameters.Add(new SqlParameter("name", nama));
                    cmd.ExecuteNonQuery();
                    koneksi.Close();
                }
                else
                {
                    koneksi.Open();
                    string str = "insert into dbo.Administrator(nama_admin, id_admin)" + "values(@name, @id)";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("id", idAdm));
                    cmd.Parameters.Add(new SqlParameter("name", nama));
                    cmd.ExecuteNonQuery();

                    koneksi.Close();
                    MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshform();
                }
                EditMode = false;
            }
        }

        /// <summary>
        /// Method Button Delete
        /// untuk menghapus data
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Button Delete untuk menghapus data
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            string namaAdm = txNamaAdmin.Text;

            if (namaAdm == "")
            {
                MessageBox.Show("Masukkan Nama Admin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var hasil = MessageBox.Show("Anda yakin mengahpus data?", "Konfirmasi Mengahapus data", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    koneksi.Open();
                    string str = "delete from dbo.Administrator where id_admin = @id";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("id", AdminTerpilih));
                    cmd.ExecuteNonQuery();

                    koneksi.Close();
                    MessageBox.Show("Data Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refreshform();
                }
            }
        }

        /// <summary>
        /// Method Button Update
        /// Untuk mengupdate data 
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Button update untuk memperbarui data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EditMode = true;
            SetEnable(true);
        }

        /// <summary>
        /// Method Button refresh
        /// Untuk merefresh textbox
        /// </summary>
        /// <param name="sender">yang berisi referensi ke kontrol/objek yang memunculkan event</param>
        /// <param name="e">parameter yang disebut e yang berisi data event data gridview</param>
        //Button Refresh untuk merefresh form 
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            koneksi.Close();
            ShowDgv();
            txNamaAdmin.Clear();
            txIdAdmin.Clear();
        }
    }

}
