using Benefits.DAO;
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
            ClienteDAO.ShowClients();
        }
    }
}
