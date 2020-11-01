using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Directorio
    {
        public List<Cliente> listaClientes { get; set; }
        public List<Mascota> listaMascotas { get; set; }
        
        public Directorio()
        {
            listaClientes = new List<Cliente>();
            listaMascotas = new List<Mascota>();
        }

        public void AgregarCliente(Cliente unCliente)
        {
            ValidarCliente(unCliente);
            listaClientes.Add(unCliente);
        }

        private void ValidarCliente(Cliente unCliente)
        {
            if (listaClientes.Any(c => c.Id == unCliente.Id))
                throw new YaExisteClienteConEsaIdException();
        }

        public void AgregarMascota(Mascota unaMascota)
        {
            listaMascotas.Add(unaMascota);
        }
    }
}
