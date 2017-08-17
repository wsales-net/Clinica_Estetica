using Estetica_27.Business.Exceptions;
using Estetica_27.DAL;
using Estetica_27.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetica_27.Business
{
    public class SecaoBLL
    {
        public bool Insert(Secao c)
        {
            if (c.TipoSecao == Model.Enuns.TipoSecaoEnum.Virilha && c.Valor == 0)
            {
                throw new ValorException("Digite o valor da Seção:");
            }

            bool salvou = false;
            new SecaoDAL().Insert(c);
            if (c.Id > 0)
            {
                salvou = true;
            }
            return salvou;
        }

        public DataTable FindAll()
        {
            SecaoDAL cDAL = new SecaoDAL();
            return cDAL.FindAll();
        }

        public Secao FindById(int id)
        {
            SecaoDAL cDAL = new SecaoDAL();
            return cDAL.FindById(id);
        }

        public bool Update(Secao c)
        {
            bool atualizou = false;
            SecaoDAL cDAL = new SecaoDAL();
            if (cDAL.Update(c) > 0)
            {
                atualizou = true;
            }
            return atualizou;
        }

        public bool Delete(int c)
        {
            bool deletou = false;
            SecaoDAL cDAL = new SecaoDAL();
            if (cDAL.Delete(c) > 0)
            {
                deletou = true;
            }
            return deletou;
        }
    }
}
