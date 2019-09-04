using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.View
{
    class MenuClientes
    {
        public static void RenderizarMenuClientes()
        {
            int menu = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("        MENU CLIENTES");
                Console.WriteLine("_____________________________");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Remover Cliente");
                Console.WriteLine("4 - Editar Cliente");
                Console.WriteLine("0 - Voltar ao Menu Principal");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        //cadastrar cliente
                        Console.WriteLine("Cadastrar Cliente");
                        CadastrarCliente.RenderRegisterClient();
                        break;
                    case 2:
                        //listar clientes
                        Console.WriteLine("Listar Clientes");
                        ListarClientes.RenderListOfClients();
                        break;
                    case 3:
                        //remover cliente
                        Console.WriteLine("Remover Cliente");
                        RemoverCliente.RenderRemoveClient();
                        break;
                    case 4:
                        //editar cliente
                        Console.WriteLine("Editar Cliente");
                        EditarCliente.RenderizarEditClient();
                        break;
                    case 0:
                        //voltar ao menu principal
                        MenuPrincipal.RenderizarMenuPrincipal();
                        break;
                    default:
                        Console.WriteLine("Opção " + menu + " inválida");
                        break;
                }

                Console.WriteLine("Digite qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (menu != 0);
        }
    }
}
