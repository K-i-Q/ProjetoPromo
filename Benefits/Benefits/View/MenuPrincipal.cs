using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.View
{
    class MenuPrincipal
    {
        public static void RenderizarMenuPrincipal()
        {
            int menu = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("        MENU PRINCIPAL");
                Console.WriteLine("_____________________________");
                Console.WriteLine("1 - Menu CLIENTES");
                Console.WriteLine("2 - Menu EMPRESAS");
                Console.WriteLine("0 - Sair");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        //MENU CLIENTES
                        MenuClientes.RenderizarMenuClientes();
                        break;
                    case 2:
                        //MENU EMPRESAS
                        MenuEmpresas.RenderizarMenuEmpresas();
                        break;
                    case 0:
                        //saindo
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Digite qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (menu != 0);
        }
    }
}
