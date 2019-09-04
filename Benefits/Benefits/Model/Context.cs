using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.Model
{
    class Context : DbContext
    {
        //Nomear o arquivo do banco de dados
        public Context() : base("DbProjetoPromo")
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
    }
}
