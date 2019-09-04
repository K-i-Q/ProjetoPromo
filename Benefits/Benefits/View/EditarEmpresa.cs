using Benefits.DAO;
using Benefits.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.View
{
    class EditarEmpresa
    {
        public static void RenderizarEditCompany()
        {
            Empresa e = new Empresa();
            
            Console.WriteLine("Digite o nome");
            e.Nome = Console.ReadLine().ToLower();
            e = EmpresaDAO.FindCompany(e);

            Console.WriteLine("Digite o novo nome");
            e.Nome = Console.ReadLine().ToLower();
            Console.WriteLine("Digite o novo email");
            e.Email = Console.ReadLine().ToLower();
            Console.WriteLine("Digite o novo telefone");
            e.Telefone = Console.ReadLine().ToLower();
            //Criar valores para alteração
            EmpresaDAO.EditCompany(e);

        }
    }
}
