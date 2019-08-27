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
            foreach (Cliente c in Clientes)
            {
                if (Clientes.Contains(cliente))
                {
                    Clientes.Remove(c);
                }
            }
        }
    }
}
