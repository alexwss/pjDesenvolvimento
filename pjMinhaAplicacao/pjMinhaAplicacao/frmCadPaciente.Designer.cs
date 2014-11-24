namespace pjMinhaAplicacao
{
    partial class frmCadPaciente
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
            System.Windows.Forms.Label iD_CONSULTALabel;
            System.Windows.Forms.Label nOME_PACIENTELabel;
            System.Windows.Forms.Label nOME_MEDICOLabel;
            System.Windows.Forms.Label dATALabel;
            System.Windows.Forms.Label hORARIOLabel;
            this.btnPesquisaPaciente = new System.Windows.Forms.Button();
            this.txtCodConsulta = new System.Windows.Forms.TextBox();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.txtNomeMedico = new System.Windows.Forms.TextBox();
            this.dpData = new System.Windows.Forms.DateTimePicker();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.nOME_PACIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tESTEDataSet = new pjMinhaAplicacao.TESTEDataSet();
            this.nOME_PACIENTETableAdapter = new pjMinhaAplicacao.TESTEDataSetTableAdapters.NOME_PACIENTETableAdapter();
            this.tableAdapterManager = new pjMinhaAplicacao.TESTEDataSetTableAdapters.TableAdapterManager();
            iD_CONSULTALabel = new System.Windows.Forms.Label();
            nOME_PACIENTELabel = new System.Windows.Forms.Label();
            nOME_MEDICOLabel = new System.Windows.Forms.Label();
            dATALabel = new System.Windows.Forms.Label();
            hORARIOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nOME_PACIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisaPaciente
            // 
            this.btnPesquisaPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisaPaciente.Location = new System.Drawing.Point(505, 22);
            this.btnPesquisaPaciente.Name = "btnPesquisaPaciente";
            this.btnPesquisaPaciente.Size = new System.Drawing.Size(133, 42);
            this.btnPesquisaPaciente.TabIndex = 0;
            this.btnPesquisaPaciente.Text = "Pesquisar";
            this.btnPesquisaPaciente.UseVisualStyleBackColor = true;
            this.btnPesquisaPaciente.Click += new System.EventHandler(this.btnPesquisaPaciente_Click);
            // 
            // iD_CONSULTALabel
            // 
            iD_CONSULTALabel.AutoSize = true;
            iD_CONSULTALabel.Location = new System.Drawing.Point(12, 47);
            iD_CONSULTALabel.Name = "iD_CONSULTALabel";
            iD_CONSULTALabel.Size = new System.Drawing.Size(82, 13);
            iD_CONSULTALabel.TabIndex = 2;
            iD_CONSULTALabel.Text = "ID CONSULTA:";
            // 
            // txtCodConsulta
            // 
            this.txtCodConsulta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nOME_PACIENTEBindingSource, "ID_CONSULTA", true));
            this.txtCodConsulta.Location = new System.Drawing.Point(100, 44);
            this.txtCodConsulta.Name = "txtCodConsulta";
            this.txtCodConsulta.ReadOnly = true;
            this.txtCodConsulta.Size = new System.Drawing.Size(62, 20);
            this.txtCodConsulta.TabIndex = 3;
            // 
            // nOME_PACIENTELabel
            // 
            nOME_PACIENTELabel.AutoSize = true;
            nOME_PACIENTELabel.Location = new System.Drawing.Point(-4, 76);
            nOME_PACIENTELabel.Name = "nOME_PACIENTELabel";
            nOME_PACIENTELabel.Size = new System.Drawing.Size(98, 13);
            nOME_PACIENTELabel.TabIndex = 4;
            nOME_PACIENTELabel.Text = "NOME PACIENTE:";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomePaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nOME_PACIENTEBindingSource, "NOME_PACIENTE", true));
            this.txtNomePaciente.Location = new System.Drawing.Point(100, 73);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(541, 20);
            this.txtNomePaciente.TabIndex = 5;
            // 
            // nOME_MEDICOLabel
            // 
            nOME_MEDICOLabel.AutoSize = true;
            nOME_MEDICOLabel.Location = new System.Drawing.Point(7, 108);
            nOME_MEDICOLabel.Name = "nOME_MEDICOLabel";
            nOME_MEDICOLabel.Size = new System.Drawing.Size(87, 13);
            nOME_MEDICOLabel.TabIndex = 6;
            nOME_MEDICOLabel.Text = "NOME MEDICO:";
            // 
            // txtNomeMedico
            // 
            this.txtNomeMedico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeMedico.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nOME_PACIENTEBindingSource, "NOME_MEDICO", true));
            this.txtNomeMedico.Location = new System.Drawing.Point(100, 105);
            this.txtNomeMedico.Name = "txtNomeMedico";
            this.txtNomeMedico.Size = new System.Drawing.Size(541, 20);
            this.txtNomeMedico.TabIndex = 7;
            // 
            // dATALabel
            // 
            dATALabel.AutoSize = true;
            dATALabel.Location = new System.Drawing.Point(55, 137);
            dATALabel.Name = "dATALabel";
            dATALabel.Size = new System.Drawing.Size(39, 13);
            dATALabel.TabIndex = 8;
            dATALabel.Text = "DATA:";
            // 
            // dpData
            // 
            this.dpData.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nOME_PACIENTEBindingSource, "DATA", true));
            this.dpData.Location = new System.Drawing.Point(100, 131);
            this.dpData.Name = "dpData";
            this.dpData.Size = new System.Drawing.Size(200, 20);
            this.dpData.TabIndex = 9;
            // 
            // hORARIOLabel
            // 
            hORARIOLabel.AutoSize = true;
            hORARIOLabel.Location = new System.Drawing.Point(34, 160);
            hORARIOLabel.Name = "hORARIOLabel";
            hORARIOLabel.Size = new System.Drawing.Size(60, 13);
            hORARIOLabel.TabIndex = 10;
            hORARIOLabel.Text = "HORARIO:";
            // 
            // txtHorario
            // 
            this.txtHorario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nOME_PACIENTEBindingSource, "HORARIO", true));
            this.txtHorario.Location = new System.Drawing.Point(100, 157);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(200, 20);
            this.txtHorario.TabIndex = 11;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(9, 247);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(85, 44);
            this.btnGravar.TabIndex = 12;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(100, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 44);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(557, 247);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(81, 44);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // nOME_PACIENTEBindingSource
            // 
            this.nOME_PACIENTEBindingSource.DataMember = "NOME_PACIENTE";
            this.nOME_PACIENTEBindingSource.DataSource = this.tESTEDataSet;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CONTASTableAdapter = null;
            this.tableAdapterManager.NOME_PACIENTETableAdapter = this.nOME_PACIENTETableAdapter;
            this.tableAdapterManager.UpdateOrder = pjMinhaAplicacao.TESTEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmCadPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(650, 298);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(iD_CONSULTALabel);
            this.Controls.Add(this.txtCodConsulta);
            this.Controls.Add(nOME_PACIENTELabel);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(nOME_MEDICOLabel);
            this.Controls.Add(this.txtNomeMedico);
            this.Controls.Add(dATALabel);
            this.Controls.Add(this.dpData);
            this.Controls.Add(hORARIOLabel);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.btnPesquisaPaciente);
            this.Name = "frmCadPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pacientes";
            this.Load += new System.EventHandler(this.frmCadPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nOME_PACIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisaPaciente;
        private TESTEDataSet tESTEDataSet;
        private System.Windows.Forms.BindingSource nOME_PACIENTEBindingSource;
        private TESTEDataSetTableAdapters.NOME_PACIENTETableAdapter nOME_PACIENTETableAdapter;
        private TESTEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtCodConsulta;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.TextBox txtNomeMedico;
        private System.Windows.Forms.DateTimePicker dpData;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
    }
}