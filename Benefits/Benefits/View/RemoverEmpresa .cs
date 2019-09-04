using Benefits.DAO;
using Benefits.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.View
{
    class RemoverEmpresa
    {
        public static void RenderRemoveCompany()
        {
            Empresa e = new Empresa();
            Console.WriteLine("Qual nome da empresa que deseja remover? ");
            e.Nome = Console.ReadLine().ToLower();
            EmpresaDAO.RemoveCompany(e);
        }
    }
}
