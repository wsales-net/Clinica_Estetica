using Estetica_27.Business;
using Estetica_27.Business.Exceptions;
using Estetica_27.Model;
using Estetica_27.Model.Enuns;
using Estetica_27.View.Converter;
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
    public partial class FrmCadastrarCliente : Form
    {
        public FrmCadastrarCliente()
        {
            InitializeComponent();
            cbxTipoSecao.DataSource = tipoSecaoService.FindAll(); //Carrega tudo
            cbxTipoSecao.DisplayMember = "TIPO_DE_DESCRICAO";
            cbxTipoSecao.ValueMember = "TIPO_ID";
        }

        //Instacia a classe de tipos de secoes na estética
        TipoSecaoBLL tipoSecaoService = new TipoSecaoBLL();
        //Instancia a classe para CRUD
        SecaoBLL SecaoService = new SecaoBLL();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Secao GetForm()
        {
            Secao c = new Secao();
            c.Id = 0;
            c.Nome = txtNome.Text;
            c.TipoSecao = (TipoSecaoEnum)cbxTipoSecao.SelectedValue;
            c.Telefone = TelefoneConverter.Unformat(txtTelefone.Text);
            c.DataCadastro = DateTime.Parse(txtCadastro.Text);
            c.DataAtendimento = DateTime.Parse(txtAtendimento.Text);
            c.Valor = 0;

            if (!string.IsNullOrEmpty(txtId.Text))
            {
                c.Id = int.Parse(txtId.Text);
            }
            if (!string.IsNullOrEmpty(txtValor.Text))
            {
                c.Valor = Convert.ToDouble(txtValor.Text);
            }
            return c;
        }

        //Limpa formulario
        public void ClearForm()
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtCadastro.Text = string.Empty;
            txtAtendimento.Text = string.Empty;
            cbxTipoSecao.SelectedValue = 1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool salvou = SecaoService.Insert(GetForm());

                if (salvou)
                {
                    ClearForm();
                    MessageBox.Show("Contato Salvo com sucesso.", "Agente - Mesangem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ValorException vpe)
            {
                MessageBox.Show(vpe.Message, "Agenda - ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agenda - ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmCadastrarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
