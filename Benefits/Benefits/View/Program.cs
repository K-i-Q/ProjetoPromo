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

            int menu = 0;
            do
            {
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Remover Cliente");
                Console.WriteLine("4 - Editar Cliente");
                Console.WriteLine("0 - Sair");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        //cadastrar
                        CadastrarCliente.RenderRegisterClient();
                        break;
                    case 2:
                        //listar
                        ListarClientes.RenderListOfClients();
                        break;
                    case 3:
                        //remover
                        RemoverCliente.RenderRemoveClient();
                        break;
                    case 4:
                        //editar
                        break;
                    case 0:
                        //saindo
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (menu != 0);
        }
    }
}
