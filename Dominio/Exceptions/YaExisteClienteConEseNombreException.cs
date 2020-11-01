using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Exceptions
{
    public class YaExisteClienteConEseNombreException : Exception
    {
        private string message;
        public override string Message
        {
            get { return message; }
        }

        public YaExisteClienteConEseNombreException()
        {
            this.message = "Ya existe un cliente con ese Nombre";
        }
    }
}
