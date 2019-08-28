using Benefits.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits
{
    class Program
    {
        static void Main(string[] args)
        {

            CadastrarCliente.RenderRegisterClient();
            ListarClientes.RenderListOfClients();
            Console.ReadKey();
            RemoverCliente.RenderRemoveClient();
            ListarClientes.RenderListOfClients();
            Console.ReadKey();
        }
    }
}
