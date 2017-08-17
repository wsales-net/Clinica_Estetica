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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "well" || txtUsuario.Text == "WELL") && txtSenha.Text == "conectar" || txtSenha.Text == "CONECTAR")
            {
                FrmPrincipal frm = new FrmPrincipal();
                frm.Show();
                this.Hide();

                MessageBox.Show("Bem Vindo! " + txtUsuario.Text);
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
