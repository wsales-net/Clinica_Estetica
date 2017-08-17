using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetica_27.Business.Exceptions
{
    class ValorException : Exception
    {
        public ValorException()
            :base()
        {
        }
        public ValorException(string message)
                :base(message)
        {
        }
    }
}
