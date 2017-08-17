using Estetica_27.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estetica_27
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgbIniciar.Value < 100)
            {
                pgbIniciar.Value = pgbIniciar.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;

                FrmPrincipal login = new FrmPrincipal();
                login.ShowDialog();
            }
        }

        private void pbxSplash_Click(object sender, EventArgs e)
        {

        }
    }
}
