using Estetica_27.Model.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetica_27.Model
{
    public class Secao
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private String _nome;
        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        
        private TipoSecaoEnum _tipoSecao;
        public TipoSecaoEnum TipoSecao
        {
            get { return _tipoSecao; }
            set { _tipoSecao = value; }
        }

        private string _telefone;
        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        private double valor;
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private DateTime _dataAtendimento;
        public DateTime DataAtendimento
        {
            get { return _dataAtendimento; }
            set { _dataAtendimento = value; }
        }

        private DateTime _dataCadastro;
        
        public DateTime DataCadastro
        {
            get { return _dataCadastro; }
            set { _dataCadastro = value; }
        }
    }
}
