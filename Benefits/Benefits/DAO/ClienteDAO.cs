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
        public static List<Cliente> Clientes = new List<Cliente>();

        //ADD new Client
        public static void RegisterClient(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        //List all Clients
        public static void ShowClients()
        {
            foreach (Cliente cliente in Clientes)
            {
                Console.WriteLine(cliente);
            }
        }

        //Remove a Client
        public static void RemoveClient(Cliente cliente)
        {
            if (Clientes.Contains(FindClient(cliente)))
            {
                Clientes.Remove(FindClient(cliente));
            }
        }

        //Find a Client
        public static Cliente FindClient(Cliente cliente)
        {
            foreach (Cliente c in Clientes)
            {
                if (c.Equals(cliente))
                {
                    return c;
                }
            }
            return null;
        }
    }
}
