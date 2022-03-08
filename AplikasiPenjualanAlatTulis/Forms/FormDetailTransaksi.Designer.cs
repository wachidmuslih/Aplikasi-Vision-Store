
namespace AplikasiPenjualanAlatTulis.Forms
{
    partial class FormDetailTransaksi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txDetail = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.iddetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodetransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodebarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuantitasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail_TransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visionStoreDataSet1 = new AplikasiPenjualanAlatTulis.VisionStoreDataSet1();
            this.detail_TransaksiTableAdapter = new AplikasiPenjualanAlatTulis.VisionStoreDataSet1TableAdapters.Detail_TransaksiTableAdapter();
            this.tableAdapterManager = new AplikasiPenjualanAlatTulis.VisionStoreDataSet1TableAdapters.TableAdapterManager();
            this.barangTableAdapter = new AplikasiPenjualanAlatTulis.VisionStoreDataSet1TableAdapters.BarangTableAdapter();
            this.transaksiTableAdapter = new AplikasiPenjualanAlatTulis.VisionStoreDataSet1TableAdapters.TransaksiTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txKuantitas = new System.Windows.Forms.TextBox();
            this.cbHarga = new System.Windows.Forms.TextBox();
            this.cbTransaksi = new System.Windows.Forms.ComboBox();
            this.cbKodeBarang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail_TransaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visionStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Detail Transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Transaksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kode Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kuantitas";
            // 
            // txDetail
            // 
            this.txDetail.Location = new System.Drawing.Point(144, 10);
            this.txDetail.Name = "txDetail";
            this.txDetail.Size = new System.Drawing.Size(194, 22);
            this.txDetail.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(84, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(266, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 30);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(357, 129);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 30);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(448, 129);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvDetail
            // 
            this.dgvDetail.AutoGenerateColumns = false;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddetailDataGridViewTextBoxColumn,
            this.kodetransaksiDataGridViewTextBoxColumn,
            this.kodebarangDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.kuantitasDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn});
            this.dgvDetail.DataSource = this.detail_TransaksiBindingSource;
            this.dgvDetail.Location = new System.Drawing.Point(15, 186);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.RowTemplate.Height = 24;
            this.dgvDetail.Size = new System.Drawing.Size(974, 236);
            this.dgvDetail.TabIndex = 16;
            this.dgvDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // iddetailDataGridViewTextBoxColumn
            // 
            this.iddetailDataGridViewTextBoxColumn.DataPropertyName = "id_detail";
            this.iddetailDataGridViewTextBoxColumn.HeaderText = "id_detail";
            this.iddetailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iddetailDataGridViewTextBoxColumn.Name = "iddetailDataGridViewTextBoxColumn";
            this.iddetailDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodetransaksiDataGridViewTextBoxColumn
            // 
            this.kodetransaksiDataGridViewTextBoxColumn.DataPropertyName = "kode_transaksi";
            this.kodetransaksiDataGridViewTextBoxColumn.HeaderText = "kode_transaksi";
            this.kodetransaksiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodetransaksiDataGridViewTextBoxColumn.Name = "kodetransaksiDataGridViewTextBoxColumn";
            this.kodetransaksiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodebarangDataGridViewTextBoxColumn
            // 
            this.kodebarangDataGridViewTextBoxColumn.DataPropertyName = "kode_barang";
            this.kodebarangDataGridViewTextBoxColumn.HeaderText = "kode_barang";
            this.kodebarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodebarangDataGridViewTextBoxColumn.Name = "kodebarangDataGridViewTextBoxColumn";
            this.kodebarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kuantitasDataGridViewTextBoxColumn
            // 
            this.kuantitasDataGridViewTextBoxColumn.DataPropertyName = "kuantitas";
            this.kuantitasDataGridViewTextBoxColumn.HeaderText = "kuantitas";
            this.kuantitasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kuantitasDataGridViewTextBoxColumn.Name = "kuantitasDataGridViewTextBoxColumn";
            this.kuantitasDataGridViewTextBoxColumn.Width = 125;
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "sub_total";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "sub_total";
            this.subtotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            this.subtotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // detail_TransaksiBindingSource
            // 
            this.detail_TransaksiBindingSource.DataMember = "Detail_Transaksi";
            this.detail_TransaksiBindingSource.DataSource = this.visionStoreDataSet1;
            // 
            // visionStoreDataSet1
            // 
            this.visionStoreDataSet1.DataSetName = "VisionStoreDataSet1";
            this.visionStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detail_TransaksiTableAdapter
            // 
            this.detail_TransaksiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarangTableAdapter = this.barangTableAdapter;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.Detail_TransaksiTableAdapter = this.detail_TransaksiTableAdapter;
            this.tableAdapterManager.TransaksiTableAdapter = this.transaksiTableAdapter;
            this.tableAdapterManager.UpdateOrder = AplikasiPenjualanAlatTulis.VisionStoreDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // transaksiTableAdapter
            // 
            this.transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Harga";
            // 
            // transaksiBindingSource
            // 
            this.transaksiBindingSource.DataMember = "Transaksi";
            this.transaksiBindingSource.DataSource = this.visionStoreDataSet1;
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "Barang";
            this.barangBindingSource.DataSource = this.visionStoreDataSet1;
            // 
            // txKuantitas
            // 
            this.txKuantitas.Location = new System.Drawing.Point(472, 74);
            this.txKuantitas.Name = "txKuantitas";
            this.txKuantitas.Size = new System.Drawing.Size(161, 22);
            this.txKuantitas.TabIndex = 21;
            // 
            // cbHarga
            // 
            this.cbHarga.Location = new System.Drawing.Point(472, 43);
            this.cbHarga.Name = "cbHarga";
            this.cbHarga.Size = new System.Drawing.Size(161, 22);
            this.cbHarga.TabIndex = 22;
            // 
            // cbTransaksi
            // 
            this.cbTransaksi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource, "kode_transaksi", true));
            this.cbTransaksi.DataSource = this.transaksiBindingSource;
            this.cbTransaksi.DisplayMember = "kode_transaksi";
            this.cbTransaksi.FormattingEnabled = true;
            this.cbTransaksi.Location = new System.Drawing.Point(144, 43);
            this.cbTransaksi.Name = "cbTransaksi";
            this.cbTransaksi.Size = new System.Drawing.Size(194, 24);
            this.cbTransaksi.TabIndex = 25;
            this.cbTransaksi.ValueMember = "kode_transaksi";
            // 
            // cbKodeBarang
            // 
            this.cbKodeBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "kode_barang", true));
            this.cbKodeBarang.FormattingEnabled = true;
            this.cbKodeBarang.Location = new System.Drawing.Point(471, 13);
            this.cbKodeBarang.Name = "cbKodeBarang";
            this.cbKodeBarang.Size = new System.Drawing.Size(162, 24);
            this.cbKodeBarang.TabIndex = 26;
            // 
            // FormDetailTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 487);
            this.Controls.Add(this.cbKodeBarang);
            this.Controls.Add(this.cbTransaksi);
            this.Controls.Add(this.cbHarga);
            this.Controls.Add(this.txKuantitas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txDetail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDetailTransaksi";
            this.Text = "FormDetailTransaksi";
            this.Load += new System.EventHandler(this.FormDetailTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail_TransaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visionStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txDetail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvDetail;
        private VisionStoreDataSet1 visionStoreDataSet1;
        private System.Windows.Forms.BindingSource detail_TransaksiBindingSource;
        private VisionStoreDataSet1TableAdapters.Detail_TransaksiTableAdapter detail_TransaksiTableAdapter;
        private VisionStoreDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodetransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodebarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuantitasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private VisionStoreDataSet1TableAdapters.BarangTableAdapter barangTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private System.Windows.Forms.TextBox txKuantitas;
        private VisionStoreDataSet1TableAdapters.TransaksiTableAdapter transaksiTableAdapter;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private System.Windows.Forms.TextBox cbHarga;
        private System.Windows.Forms.ComboBox cbTransaksi;
        private System.Windows.Forms.ComboBox cbKodeBarang;
    }
}