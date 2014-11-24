using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjMinhaAplicacao
{
    public partial class frmCadPaciente : Form
    {
        public frmCadPaciente()
        {
            InitializeComponent();
        }

        private void btnPesquisaPaciente_Click(object sender, EventArgs e)
        {
            FrmConsPacientes novaConsPaciente = new FrmConsPacientes();

            if (Application.OpenForms.OfType<FrmConsPacientes>().Count() < 1)
            {
                novaConsPaciente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Já está aberto Caro Usuário!");
            }
        }

        private void nOME_PACIENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nOME_PACIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tESTEDataSet);

        }

        private void frmCadPaciente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tESTEDataSet.NOME_PACIENTE' table. You can move, or remove it, as needed.
            this.nOME_PACIENTETableAdapter.Fill(this.tESTEDataSet.NOME_PACIENTE);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpaCampos()
        { 
            txtNomeMedico.Text = "";
            txtNomePaciente.Text = "";
            dpData.Text = "";
            txtHorario.Text = "";
            txtCodConsulta.Text = "";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtCodConsulta.Text == "")
            {
                nOME_PACIENTETableAdapter.InserePaciente(txtNomePaciente.Text, txtNomeMedico.Text, dpData.Text, txtHorario.Text);
                MessageBox.Show("Hááá Gravou ;D");
                LimpaCampos();
            }
            else
            {
                nOME_PACIENTETableAdapter.AtualizaPaciente(dpData.Text, txtHorario.Text, txtNomePaciente.Text, txtNomeMedico.Text, Convert.ToInt32(txtCodConsulta.Text));
                MessageBox.Show("Hááá Atualizou ;D");
                LimpaCampos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
    }
}
