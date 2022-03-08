
namespace AplikasiPenjualanAlatTulis.Forms
{
    partial class FormAdmin
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
            this.txNamaAdmin = new System.Windows.Forms.TextBox();
            this.txIdAdmin = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.visionStoreDataSet1 = new AplikasiPenjualanAlatTulis.VisionStoreDataSet1();
            this.administratorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.administratorTableAdapter = new AplikasiPenjualanAlatTulis.VisionStoreDataSet1TableAdapters.AdministratorTableAdapter();
            this.tableAdapterManager = new AplikasiPenjualanAlatTulis.VisionStoreDataSet1TableAdapters.TableAdapterManager();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.idadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.visionStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Admin";
            // 
            // txNamaAdmin
            // 
            this.txNamaAdmin.Location = new System.Drawing.Point(135, 33);
            this.txNamaAdmin.Name = "txNamaAdmin";
            this.txNamaAdmin.Size = new System.Drawing.Size(208, 22);
            this.txNamaAdmin.TabIndex = 2;
            // 
            // txIdAdmin
            // 
            this.txIdAdmin.Location = new System.Drawing.Point(135, 66);
            this.txIdAdmin.Name = "txIdAdmin";
            this.txIdAdmin.Size = new System.Drawing.Size(208, 22);
            this.txIdAdmin.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(123, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(214, 117);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(85, 30);
            this.btnDELETE.TabIndex = 6;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(305, 117);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(396, 117);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 30);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // visionStoreDataSet1
            // 
            this.visionStoreDataSet1.DataSetName = "VisionStoreDataSet1";
            this.visionStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // administratorBindingSource
            // 
            this.administratorBindingSource.DataMember = "Administrator";
            this.administratorBindingSource.DataSource = this.visionStoreDataSet1;
            // 
            // administratorTableAdapter
            // 
            this.administratorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratorTableAdapter = this.administratorTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarangTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.Detail_TransaksiTableAdapter = null;
            this.tableAdapterManager.TransaksiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AplikasiPenjualanAlatTulis.VisionStoreDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AutoGenerateColumns = false;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idadminDataGridViewTextBoxColumn,
            this.namaadminDataGridViewTextBoxColumn});
            this.dgvAdmin.DataSource = this.administratorBindingSource;
            this.dgvAdmin.Location = new System.Drawing.Point(32, 191);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.Size = new System.Drawing.Size(564, 189);
            this.dgvAdmin.TabIndex = 9;
            this.dgvAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // idadminDataGridViewTextBoxColumn
            // 
            this.idadminDataGridViewTextBoxColumn.DataPropertyName = "id_admin";
            this.idadminDataGridViewTextBoxColumn.HeaderText = "id_admin";
            this.idadminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idadminDataGridViewTextBoxColumn.Name = "idadminDataGridViewTextBoxColumn";
            this.idadminDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaadminDataGridViewTextBoxColumn
            // 
            this.namaadminDataGridViewTextBoxColumn.DataPropertyName = "nama_admin";
            this.namaadminDataGridViewTextBoxColumn.HeaderText = "nama_admin";
            this.namaadminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaadminDataGridViewTextBoxColumn.Name = "namaadminDataGridViewTextBoxColumn";
            this.namaadminDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txIdAdmin);
            this.Controls.Add(this.txNamaAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visionStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNamaAdmin;
        private System.Windows.Forms.TextBox txIdAdmin;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private VisionStoreDataSet1 visionStoreDataSet1;
        private System.Windows.Forms.BindingSource administratorBindingSource;
        private VisionStoreDataSet1TableAdapters.AdministratorTableAdapter administratorTableAdapter;
        private VisionStoreDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaadminDataGridViewTextBoxColumn;
    }
}