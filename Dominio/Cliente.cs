using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Descripcion { get; set; }
        public bool EsSocio { get; set; }

        public Cliente() { }

        override
        public string ToString()
        {
            return Nombre;
        }
    }
}
