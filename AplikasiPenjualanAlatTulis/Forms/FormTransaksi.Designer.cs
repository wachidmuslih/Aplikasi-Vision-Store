
namespace AplikasiPenjualanAlatTulis.Forms
{
    partial class FormTransaksi
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.kodetransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcostumerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bayarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kembalianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visionStoreDataSet1 = new AplikasiPenjualanAlatTulis.VisionStoreDataSet1();
            this.transaksiTableAdapter = new AplikasiPenjualanAlatTulis.VisionStoreDataSet1TableAdapters.TransaksiTableAdapter();
            this.tableAdapterManager = new AplikasiPenjualanAlatTulis.VisionStoreDataSet1TableAdapters.TableAdapterManager();
            this.administratorTableAdapter = new AplikasiPenjualanAlatTulis.VisionStoreDataSet1TableAdapters.AdministratorTableAdapter();
            this.customerTableAdapter = new AplikasiPenjualanAlatTulis.VisionStoreDataSet1TableAdapters.CustomerTableAdapter();
            this.txKodeTransaksi = new System.Windows.Forms.TextBox();
            this.txTotal = new System.Windows.Forms.TextBox();
            this.txBayar = new System.Windows.Forms.TextBox();
            this.dtTanggal = new System.Windows.Forms.DateTimePicker();
            this.administratorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.administratorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbIdAdmin = new System.Windows.Forms.TextBox();
            this.cbxIdCust = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visionStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bayar";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(58, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(151, 154);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(242, 154);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(333, 155);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 30);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(424, 154);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 30);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.AutoGenerateColumns = false;
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodetransaksiDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.idadminDataGridViewTextBoxColumn,
            this.idcostumerDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.bayarDataGridViewTextBoxColumn,
            this.kembalianDataGridViewTextBoxColumn});
            this.dgvTransaksi.DataSource = this.transaksiBindingSource;
            this.dgvTransaksi.Location = new System.Drawing.Point(12, 194);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.RowHeadersWidth = 51;
            this.dgvTransaksi.RowTemplate.Height = 24;
            this.dgvTransaksi.Size = new System.Drawing.Size(1124, 228);
            this.dgvTransaksi.TabIndex = 11;
            this.dgvTransaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // kodetransaksiDataGridViewTextBoxColumn
            // 
            this.kodetransaksiDataGridViewTextBoxColumn.DataPropertyName = "kode_transaksi";
            this.kodetransaksiDataGridViewTextBoxColumn.HeaderText = "kode_transaksi";
            this.kodetransaksiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodetransaksiDataGridViewTextBoxColumn.Name = "kodetransaksiDataGridViewTextBoxColumn";
            this.kodetransaksiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "tanggal";
            this.tanggalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            this.tanggalDataGridViewTextBoxColumn.Width = 125;
            // 
            // idadminDataGridViewTextBoxColumn
            // 
            this.idadminDataGridViewTextBoxColumn.DataPropertyName = "id_admin";
            this.idadminDataGridViewTextBoxColumn.HeaderText = "id_admin";
            this.idadminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idadminDataGridViewTextBoxColumn.Name = "idadminDataGridViewTextBoxColumn";
            this.idadminDataGridViewTextBoxColumn.Width = 125;
            // 
            // idcostumerDataGridViewTextBoxColumn
            // 
            this.idcostumerDataGridViewTextBoxColumn.DataPropertyName = "id_costumer";
            this.idcostumerDataGridViewTextBoxColumn.HeaderText = "id_costumer";
            this.idcostumerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcostumerDataGridViewTextBoxColumn.Name = "idcostumerDataGridViewTextBoxColumn";
            this.idcostumerDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // bayarDataGridViewTextBoxColumn
            // 
            this.bayarDataGridViewTextBoxColumn.DataPropertyName = "bayar";
            this.bayarDataGridViewTextBoxColumn.HeaderText = "bayar";
            this.bayarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bayarDataGridViewTextBoxColumn.Name = "bayarDataGridViewTextBoxColumn";
            this.bayarDataGridViewTextBoxColumn.Width = 125;
            // 
            // kembalianDataGridViewTextBoxColumn
            // 
            this.kembalianDataGridViewTextBoxColumn.DataPropertyName = "kembalian";
            this.kembalianDataGridViewTextBoxColumn.HeaderText = "kembalian";
            this.kembalianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kembalianDataGridViewTextBoxColumn.Name = "kembalianDataGridViewTextBoxColumn";
            this.kembalianDataGridViewTextBoxColumn.Width = 125;
            // 
            // transaksiBindingSource
            // 
            this.transaksiBindingSource.DataMember = "Transaksi";
            this.transaksiBindingSource.DataSource = this.visionStoreDataSet1;
            // 
            // visionStoreDataSet1
            // 
            this.visionStoreDataSet1.DataSetName = "VisionStoreDataSet1";
            this.visionStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaksiTableAdapter
            // 
            this.transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratorTableAdapter = this.administratorTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarangTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.Detail_TransaksiTableAdapter = null;
            this.tableAdapterManager.TransaksiTableAdapter = this.transaksiTableAdapter;
            this.tableAdapterManager.UpdateOrder = AplikasiPenjualanAlatTulis.VisionStoreDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // administratorTableAdapter
            // 
            this.administratorTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // txKodeTransaksi
            // 
            this.txKodeTransaksi.Location = new System.Drawing.Point(126, 16);
            this.txKodeTransaksi.Name = "txKodeTransaksi";
            this.txKodeTransaksi.Size = new System.Drawing.Size(261, 22);
            this.txKodeTransaksi.TabIndex = 12;
            // 
            // txTotal
            // 
            this.txTotal.Location = new System.Drawing.Point(517, 17);
            this.txTotal.Name = "txTotal";
            this.txTotal.Size = new System.Drawing.Size(287, 22);
            this.txTotal.TabIndex = 16;
            // 
            // txBayar
            // 
            this.txBayar.Location = new System.Drawing.Point(517, 45);
            this.txBayar.Name = "txBayar";
            this.txBayar.Size = new System.Drawing.Size(287, 22);
            this.txBayar.TabIndex = 17;
            // 
            // dtTanggal
            // 
            this.dtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTanggal.Location = new System.Drawing.Point(126, 49);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.Size = new System.Drawing.Size(261, 22);
            this.dtTanggal.TabIndex = 18;
            this.dtTanggal.Value = new System.DateTime(2021, 7, 19, 10, 0, 25, 0);
            this.dtTanggal.ValueChanged += new System.EventHandler(this.dtTanggal_ValueChanged);
            // 
            // administratorBindingSource
            // 
            this.administratorBindingSource.DataMember = "Administrator";
            this.administratorBindingSource.DataSource = this.visionStoreDataSet1;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.visionStoreDataSet1;
            // 
            // administratorBindingSource1
            // 
            this.administratorBindingSource1.DataMember = "Administrator";
            this.administratorBindingSource1.DataSource = this.visionStoreDataSet1;
            // 
            // cbIdAdmin
            // 
            this.cbIdAdmin.Location = new System.Drawing.Point(126, 80);
            this.cbIdAdmin.Name = "cbIdAdmin";
            this.cbIdAdmin.Size = new System.Drawing.Size(261, 22);
            this.cbIdAdmin.TabIndex = 19;
            // 
            // cbxIdCust
            // 
            this.cbxIdCust.Location = new System.Drawing.Point(517, 77);
            this.cbxIdCust.Name = "cbxIdCust";
            this.cbxIdCust.Size = new System.Drawing.Size(286, 22);
            this.cbxIdCust.TabIndex = 20;
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 519);
            this.Controls.Add(this.cbxIdCust);
            this.Controls.Add(this.cbIdAdmin);
            this.Controls.Add(this.dtTanggal);
            this.Controls.Add(this.txBayar);
            this.Controls.Add(this.txTotal);
            this.Controls.Add(this.txKodeTransaksi);
            this.Controls.Add(this.dgvTransaksi);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visionStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvTransaksi;
        private VisionStoreDataSet1 visionStoreDataSet1;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private VisionStoreDataSet1TableAdapters.TransaksiTableAdapter transaksiTableAdapter;
        private VisionStoreDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodetransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcostumerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bayarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kembalianDataGridViewTextBoxColumn;
        private VisionStoreDataSet1TableAdapters.AdministratorTableAdapter administratorTableAdapter;
        private System.Windows.Forms.TextBox txKodeTransaksi;
        private System.Windows.Forms.TextBox txTotal;
        private System.Windows.Forms.TextBox txBayar;
        private System.Windows.Forms.DateTimePicker dtTanggal;
        private System.Windows.Forms.BindingSource administratorBindingSource;
        private VisionStoreDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource administratorBindingSource1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.TextBox cbIdAdmin;
        private System.Windows.Forms.TextBox cbxIdCust;
    }
}