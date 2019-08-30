using Benefits.DAO;
using Benefits.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.View
{
    class ListarClientes
    {
        public static void RenderListOfClients()
        {
            Console.WriteLine("Listar Clientes");
            foreach (Cliente c in ClienteDAO.ShowClients())
            {
                Console.WriteLine(c.Nome);
            }
        }
    }
}
