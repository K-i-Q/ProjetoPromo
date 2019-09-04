using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.View
{
    class MenuEmpresas
    {
        public static void RenderizarMenuEmpresas()
        {
            int menu = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("        MENU EMPRESAS");
                Console.WriteLine("_____________________________");
                Console.WriteLine("1 - Cadastrar Empresa");
                Console.WriteLine("2 - Listar Empresas");
                Console.WriteLine("3 - Remover Empresa");
                Console.WriteLine("4 - Editar Empresa");
                Console.WriteLine("0 - Voltar ao Menu Principal");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        //cadastrar empresa
                        Console.WriteLine("Cadastrar empresa");
                        break;
                    case 2:
                        //listar empresas
                        Console.WriteLine("Listar empresas");
                        break;
                    case 3:
                        //remover empresa
                        Console.WriteLine("Remover empresa");
                        break;
                    case 4:
                        //editar empresa
                        Console.WriteLine("Editar empresa");
                        break;
                    case 0:
                        //voltar ao menu principal
                        MenuPrincipal.RenderizarMenuPrincipal();
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
