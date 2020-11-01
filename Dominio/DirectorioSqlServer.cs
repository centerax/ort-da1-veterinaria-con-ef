using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dominio.Exceptions;

namespace Dominio
{
    public class DirectorioSqlServer
    {
        public void AgregarCliente(Cliente unCliente)
        {
            ValidarCliente(unCliente);
            using (VeterinariaContext ctx = new VeterinariaContext())
            {
                ctx.Clientes.Add(unCliente);
                ctx.SaveChanges();
            }
        }

        private void ValidarCliente(Cliente unCliente)
        {
            using (VeterinariaContext ctx = new VeterinariaContext())
            {
                if (ctx.Clientes.Any(c => c.Nombre == unCliente.Nombre))
                    throw new YaExisteClienteConEseNombreException();
            }
        }

        public void AgregarMascota(Mascota unaMascota)
        {
            using (VeterinariaContext ctx = new VeterinariaContext())
            {
                ctx.Mascotas.Add(unaMascota);
                ctx.Entry(unaMascota.Duenio).State = EntityState.Unchanged;
                ctx.SaveChanges();
            }
        }

        public List<Cliente> ObtenerClientes()
        {
            using (VeterinariaContext ctx = new VeterinariaContext())
            {
                return ctx.Clientes.ToList();
            }
        }
    }
}
