using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estetica_27.View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarCliente frm = new FrmCadastrarCliente();
            frm.Show();            
        }
        
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por usar o serviço! Volte Sempre.");
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult programa = MessageBox.Show("Sobre: Sistema Geclean \nEmpresa: System Tech \nVersão: 2.0 \nIdioma: Português",
                "Sobre o Programa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CadastrarAll_Click(object sender, EventArgs e)
        {
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAlteracaoCliente frm = new FrmAlteracaoCliente();
            frm.Show();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente frm = new FrmConsultaCliente();
            frm.Show();
        }
    }
}
