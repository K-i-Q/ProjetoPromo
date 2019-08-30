using Benefits.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.DAO
{
    class ClienteDAO
    {
        private static Context ctx = new Context();

        //ADD new Client
        public static void RegisterClient(Cliente cliente)
        {
            ctx.Clientes.Add(cliente);
            ctx.SaveChanges();
        }

        //List all Clients
        public static List<Cliente> ShowClients() => ctx.Clientes.ToList();

        //Remove a Client
        public static void RemoveClient(string cliente)
        {

            ctx.Clientes.Remove(FindClient(cliente));
            ctx.SaveChanges();
        }

        //Find a Client
        public static Cliente FindClient(string cliente)
        {
            foreach (Cliente c in ShowClients())
            {
                if (cliente == c.Nome)
                {
                    return c;
                }
            }
            return null;
        }
    }
}
