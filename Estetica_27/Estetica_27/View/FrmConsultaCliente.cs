using Estetica_27.Business;
using Estetica_27.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estetica_27.View
{
    public partial class FrmConsultaCliente : Form
    {
        public FrmConsultaCliente()
        {
            InitializeComponent();
        }

        TipoSecaoBLL tipoSecaoService = new TipoSecaoBLL();
        SecaoBLL contatoService = new SecaoBLL();

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAlteracaoCliente frm = new FrmAlteracaoCliente();
            frm.Show();
        }
    }
}
