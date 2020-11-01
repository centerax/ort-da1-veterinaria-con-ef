using System;
using System.Runtime.Serialization;

namespace Dominio
{
    [Serializable]
    public class YaExisteClienteConEsaIdException : Exception
    {
        private string message;
        public override string Message
        {
            get { return message; }
        }
        public YaExisteClienteConEsaIdException()
        {
            this.message = "Ya existe un cliente con esa Id";
        }
    }
}