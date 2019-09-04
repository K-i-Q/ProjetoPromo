using Benefits.DAO;
using Benefits.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.View
{
    class RemoverCliente
    {
        public static void RenderRemoveClient()
        {
            Cliente c = new Cliente();
            Console.WriteLine("Qual nome do cliente que deseja remover? ");
            c.Nome = Console.ReadLine().ToLower();
            ClienteDAO.RemoveClient(c);
        }
    }
}
