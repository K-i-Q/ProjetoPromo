using Benefits.DAO;
using Benefits.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.View
{
    class CadastrarEmpresa
    {
        public static void RenderRegisterCompany()
        {
            Empresa empresa = new Empresa();

            Console.WriteLine("Digite o nome: ");
            empresa.Nome = Console.ReadLine().ToLower();
            Console.WriteLine("Digite o e-mail: ");
            empresa.Email = Console.ReadLine().ToLower();
            Console.WriteLine("Digite seu telefone (Ex: (41)99561-5900): ");
            empresa.Telefone = Console.ReadLine().ToLower();

            EmpresaDAO.RegisterCompany(empresa);
        }
    }
}
