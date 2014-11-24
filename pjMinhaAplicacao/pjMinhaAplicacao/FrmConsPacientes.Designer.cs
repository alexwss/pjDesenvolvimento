namespace pjMinhaAplicacao
{
    partial class FrmConsPacientes
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
            this.dtgConsultaPacientes = new System.Windows.Forms.DataGridView();
            this.iDCONSULTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEPACIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEMEDICODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEPACIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tESTEDataSet = new pjMinhaAplicacao.TESTEDataSet();
            this.nOME_PACIENTETableAdapter = new pjMinhaAplicacao.TESTEDataSetTableAdapters.NOME_PACIENTETableAdapter();
            this.gbPesquisaPaciente = new System.Windows.Forms.GroupBox();
            this.btnPesquisarPacientes = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOMEPACIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTEDataSet)).BeginInit();
            this.gbPesquisaPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgConsultaPacientes
            // 
            this.dtgConsultaPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgConsultaPacientes.AutoGenerateColumns = false;
            this.dtgConsultaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultaPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCONSULTADataGridViewTextBoxColumn,
            this.nOMEPACIENTEDataGridViewTextBoxColumn,
            this.nOMEMEDICODataGridViewTextBoxColumn,
            this.dATADataGridViewTextBoxColumn,
            this.hORARIODataGridViewTextBoxColumn});
            this.dtgConsultaPacientes.DataSource = this.nOMEPACIENTEBindingSource;
            this.dtgConsultaPacientes.Location = new System.Drawing.Point(16, 93);
            this.dtgConsultaPacientes.Name = "dtgConsultaPacientes";
            this.dtgConsultaPacientes.RowHeadersVisible = false;
            this.dtgConsultaPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConsultaPacientes.Size = new System.Drawing.Size(754, 205);
            this.dtgConsultaPacientes.TabIndex = 0;
            this.dtgConsultaPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDCONSULTADataGridViewTextBoxColumn
            // 
            this.iDCONSULTADataGridViewTextBoxColumn.DataPropertyName = "ID_CONSULTA";
            this.iDCONSULTADataGridViewTextBoxColumn.HeaderText = "Código Consulta";
            this.iDCONSULTADataGridViewTextBoxColumn.Name = "iDCONSULTADataGridViewTextBoxColumn";
            this.iDCONSULTADataGridViewTextBoxColumn.Width = 200;
            // 
            // nOMEPACIENTEDataGridViewTextBoxColumn
            // 
            this.nOMEPACIENTEDataGridViewTextBoxColumn.DataPropertyName = "NOME_PACIENTE";
            this.nOMEPACIENTEDataGridViewTextBoxColumn.HeaderText = "Nome do Paciente";
            this.nOMEPACIENTEDataGridViewTextBoxColumn.Name = "nOMEPACIENTEDataGridViewTextBoxColumn";
            this.nOMEPACIENTEDataGridViewTextBoxColumn.Width = 200;
            // 
            // nOMEMEDICODataGridViewTextBoxColumn
            // 
            this.nOMEMEDICODataGridViewTextBoxColumn.DataPropertyName = "NOME_MEDICO";
            this.nOMEMEDICODataGridViewTextBoxColumn.HeaderText = "Nome do Médico";
            this.nOMEMEDICODataGridViewTextBoxColumn.Name = "nOMEMEDICODataGridViewTextBoxColumn";
            this.nOMEMEDICODataGridViewTextBoxColumn.Width = 200;
            // 
            // dATADataGridViewTextBoxColumn
            // 
            this.dATADataGridViewTextBoxColumn.DataPropertyName = "DATA";
            this.dATADataGridViewTextBoxColumn.HeaderText = "Data";
            this.dATADataGridViewTextBoxColumn.Name = "dATADataGridViewTextBoxColumn";
            this.dATADataGridViewTextBoxColumn.Width = 200;
            // 
            // hORARIODataGridViewTextBoxColumn
            // 
            this.hORARIODataGridViewTextBoxColumn.DataPropertyName = "HORARIO";
            this.hORARIODataGridViewTextBoxColumn.HeaderText = "Horário";
            this.hORARIODataGridViewTextBoxColumn.Name = "hORARIODataGridViewTextBoxColumn";
            this.hORARIODataGridViewTextBoxColumn.Width = 200;
            // 
            // nOMEPACIENTEBindingSource
            // 
            this.nOMEPACIENTEBindingSource.DataMember = "NOME_PACIENTE";
            this.nOMEPACIENTEBindingSource.DataSource = this.tESTEDataSet;
            // 
            // tESTEDataSet
            // 
            this.tESTEDataSet.DataSetName = "TESTEDataSet";
            this.tESTEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nOME_PACIENTETableAdapter
            // 
            this.nOME_PACIENTETableAdapter.ClearBeforeFill = true;
            // 
            // gbPesquisaPaciente
            // 
            this.gbPesquisaPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPesquisaPaciente.Controls.Add(this.txtPesquisa);
            this.gbPesquisaPaciente.Controls.Add(this.btnPesquisarPacientes);
            this.gbPesquisaPaciente.Location = new System.Drawing.Point(16, 9);
            this.gbPesquisaPaciente.Name = "gbPesquisaPaciente";
            this.gbPesquisaPaciente.Size = new System.Drawing.Size(756, 78);
            this.gbPesquisaPaciente.TabIndex = 1;
            this.gbPesquisaPaciente.TabStop = false;
            this.gbPesquisaPaciente.Text = "Pesquisar Pacientes";
            // 
            // btnPesquisarPacientes
            // 
            this.btnPesquisarPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarPacientes.Location = new System.Drawing.Point(625, 34);
            this.btnPesquisarPacientes.Name = "btnPesquisarPacientes";
            this.btnPesquisarPacientes.Size = new System.Drawing.Size(100, 26);
            this.btnPesquisarPacientes.TabIndex = 0;
            this.btnPesquisarPacientes.Text = "Pesquisar";
            this.btnPesquisarPacientes.UseVisualStyleBackColor = true;
            this.btnPesquisarPacientes.Click += new System.EventHandler(this.btnPesquisarPacientes_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(6, 38);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(586, 20);
            this.txtPesquisa.TabIndex = 1;
            // 
            // FrmConsPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 310);
            this.Controls.Add(this.gbPesquisaPaciente);
            this.Controls.Add(this.dtgConsultaPacientes);
            this.Name = "FrmConsPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsPacientes";
            this.Load += new System.EventHandler(this.FrmConsPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOMEPACIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTEDataSet)).EndInit();
            this.gbPesquisaPaciente.ResumeLayout(false);
            this.gbPesquisaPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConsultaPacientes;
        private TESTEDataSet tESTEDataSet;
        private System.Windows.Forms.BindingSource nOMEPACIENTEBindingSource;
        private TESTEDataSetTableAdapters.NOME_PACIENTETableAdapter nOME_PACIENTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCONSULTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEPACIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEMEDICODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbPesquisaPaciente;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisarPacientes;
    }
}