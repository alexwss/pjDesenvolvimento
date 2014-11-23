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
                novaConsPaciente.Show();
            }
            else
            {
                MessageBox.Show("Já está aberto Caro Usuário!");
            }
        }
    }
}
