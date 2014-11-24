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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Mensagem de inicialização antes de executar a tela","Atenção abestado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPaciente novoCadCliente = new frmCadPaciente();

             if  (novoCadCliente.Created == false)
            {
                novoCadCliente.ShowDialog();
            }
        }
    }
}
