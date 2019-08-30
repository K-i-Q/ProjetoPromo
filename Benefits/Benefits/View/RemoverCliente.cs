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
            Console.WriteLine("Qual nome do cliente que deseja remover? ");
            ClienteDAO.RemoveClient(Console.ReadLine());
        }
    }
}
