using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class VeterinariaContext : DbContext
    {
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
