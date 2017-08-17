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
    public partial class FrmAlteracaoCliente : Form
    {
        public FrmAlteracaoCliente()
        {
            InitializeComponent();
        }

        TipoSecaoBLL tipoSecaoService = new TipoSecaoBLL();
        SecaoBLL contatoService = new SecaoBLL();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
             this.Close();
        }
        
        Secao s = new Secao();

        private Secao GetForm()
        {
            Secao s = new Secao();
            s.Id = 0;
            s.Nome = txtNome.Text;
            s.TipoSecao = (TipoSecaoEnum)cbxTipoSecao.SelectedValue;
            s.Telefone = TelefoneConverter.Unformat(txtTelefone.Text);
            s.Valor = 0;
            s.DataAtendimento = DateTime.Parse(txtAtendimento.Text);
            s.DataCadastro = DateTime.Parse(txtCadastro.Text);

            if (!string.IsNullOrEmpty(txtId.Text))
            {
                s.Id = int.Parse(txtId.Text);
            }
            if (!string.IsNullOrEmpty(txtValor.Text))
            {
                s.Valor = Convert.ToDouble(txtValor.Text);
            }
            return s;
        }

        private void CarregarTipoSecao()
        {
            //Indica para o banco qual é a fonte de dados
            cbxTipoSecao.DataSource = tipoSecaoService.FindAll();
            //Campo do banco a ser aprensentado no ComboBox.
            cbxTipoSecao.DisplayMember = "TIPO_DE_DESCRICAO";
            //Campo do Banco que contém o ID
            cbxTipoSecao.ValueMember = "TIPO_ID";
        }


        public void ClearForm()
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtAtendimento.Text = string.Empty;
            txtCadastro.Text = string.Empty;
            cbxTipoSecao.SelectedValue = 1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    throw new Exception("Selecione um contato.");
                }
                
                bool atualizou = contatoService.Update(GetForm());

                if (atualizou)
                {
                    LoadSecao();
                    ClearForm();
                    MessageBox.Show("Contato atualizou com sucesso.", "Agente - Mesangem", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agenda - ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FrmAlteracaoCliente_Load(object sender, EventArgs e)
        {
            CarregarTipoSecao();
            LoadSecao();
        }

        private void LoadSecao()
        {
            dgvSecao.DataSource = contatoService.FindAll();
        }

        private void LoadSecao(Secao s)
        {
            txtId.Text = s.Id.ToString();
            txtNome.Text = s.Nome;
            cbxTipoSecao.SelectedValue = s.TipoSecao;
            txtTelefone.Text = s.Telefone;
            txtValor.Text = s.Valor.ToString();
            txtAtendimento.Text = s.DataAtendimento.ToString("dd/MM/yyyy");
            txtCadastro.Text = string.Format("{0:dd/MM/yyyy}", s.DataCadastro);
        }

        private void dgvSecao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvSecao.Rows[e.RowIndex].Cells[0].Value);
            LoadSecao(contatoService.FindById(id));
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    throw new Exception("Selecione um contato.");
                }
                bool excluiu = contatoService.Delete(int.Parse(txtId.Text));

                if (excluiu)
                {
                    LoadSecao();
                    ClearForm();
                    MessageBox.Show("Contato deletado com sucesso.", "Agente - Mesangem", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agenda - ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
