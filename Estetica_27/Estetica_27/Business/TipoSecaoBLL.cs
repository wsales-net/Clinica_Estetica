using Estetica_27.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetica_27.Business
{
    public class TipoSecaoBLL
    {
        public DataTable FindAll() //FindAll = Encontrar tudo
        {
            TipoSecaoDAL dal = new TipoSecaoDAL();
            return dal.FindAll();
        }
    }
}
