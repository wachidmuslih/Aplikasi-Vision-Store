﻿
namespace AplikasiPenjualanAlatTulis.Forms
{
    partial class FormCustomer
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
            this.txId = new System.Windows.Forms.TextBox();
            this.txNamaCustomer = new System.Windows.Forms.TextBox();
            this.txNotel = new System.Windows.Forms.TextBox();
            this.txAlamat = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.idcostumerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namacostumerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorhpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visionStoreDataSet1 = new AplikasiPenjualanAlatTulis.VisionStoreDataSet1();
            this.customerTableAdapter = new AplikasiPenjualanAlatTulis.VisionStoreDataSet1TableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new AplikasiPenjualanAlatTulis.VisionStoreDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visionStoreDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nomor Telepon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(163, 33);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(325, 22);
            this.txId.TabIndex = 4;
            // 
            // txNamaCustomer
            // 
            this.txNamaCustomer.Location = new System.Drawing.Point(163, 62);
            this.txNamaCustomer.Name = "txNamaCustomer";
            this.txNamaCustomer.Size = new System.Drawing.Size(325, 22);
            this.txNamaCustomer.TabIndex = 5;
            // 
            // txNotel
            // 
            this.txNotel.Location = new System.Drawing.Point(163, 94);
            this.txNotel.Name = "txNotel";
            this.txNotel.Size = new System.Drawing.Size(325, 22);
            this.txNotel.TabIndex = 6;
            // 
            // txAlamat
            // 
            this.txAlamat.Location = new System.Drawing.Point(163, 132);
            this.txAlamat.Name = "txAlamat";
            this.txAlamat.Size = new System.Drawing.Size(325, 22);
            this.txAlamat.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 179);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 179);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(221, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 30);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(312, 179);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 30);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "UPDATE";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(403, 179);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 30);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcostumerDataGridViewTextBoxColumn,
            this.namacostumerDataGridViewTextBoxColumn,
            this.nomorhpDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn});
            this.dgvCustomer.DataSource = this.customerBindingSource;
            this.dgvCustomer.Location = new System.Drawing.Point(39, 225);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(777, 218);
            this.dgvCustomer.TabIndex = 13;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // idcostumerDataGridViewTextBoxColumn
            // 
            this.idcostumerDataGridViewTextBoxColumn.DataPropertyName = "id_costumer";
            this.idcostumerDataGridViewTextBoxColumn.HeaderText = "id_costumer";
            this.idcostumerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcostumerDataGridViewTextBoxColumn.Name = "idcostumerDataGridViewTextBoxColumn";
            this.idcostumerDataGridViewTextBoxColumn.Width = 125;
            // 
            // namacostumerDataGridViewTextBoxColumn
            // 
            this.namacostumerDataGridViewTextBoxColumn.DataPropertyName = "nama_costumer";
            this.namacostumerDataGridViewTextBoxColumn.HeaderText = "nama_costumer";
            this.namacostumerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namacostumerDataGridViewTextBoxColumn.Name = "namacostumerDataGridViewTextBoxColumn";
            this.namacostumerDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomorhpDataGridViewTextBoxColumn
            // 
            this.nomorhpDataGridViewTextBoxColumn.DataPropertyName = "nomor_hp";
            this.nomorhpDataGridViewTextBoxColumn.HeaderText = "nomor_hp";
            this.nomorhpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomorhpDataGridViewTextBoxColumn.Name = "nomorhpDataGridViewTextBoxColumn";
            this.nomorhpDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.visionStoreDataSet1;
            // 
            // visionStoreDataSet1
            // 
            this.visionStoreDataSet1.DataSetName = "VisionStoreDataSet1";
            this.visionStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarangTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.Detail_TransaksiTableAdapter = null;
            this.tableAdapterManager.TransaksiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AplikasiPenjualanAlatTulis.VisionStoreDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 506);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txAlamat);
            this.Controls.Add(this.txNotel);
            this.Controls.Add(this.txNamaCustomer);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visionStoreDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.TextBox txNamaCustomer;
        private System.Windows.Forms.TextBox txNotel;
        private System.Windows.Forms.TextBox txAlamat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private VisionStoreDataSet1 visionStoreDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private VisionStoreDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private VisionStoreDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcostumerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namacostumerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorhpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
    }
}