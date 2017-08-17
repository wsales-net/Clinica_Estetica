using Estetica_27.Model.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetica_27.Model
{
    public class TipoContato
    {
        private Int32 id;
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }    
}
