using Benefits.DAO;
using Benefits.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.View
{
    class ListarEmpresasContratadas
    {
        //WIP show companies hire by client
        public static void RenderShowCompanyHire()
        {
            Cliente c = new Cliente();
            List<Empresa> ec = new List<Empresa>();

            Console.WriteLine("Nome do cliente: ");
            c.Nome = Console.ReadLine();
            c = ClienteDAO.FindClient(c);

            Console.WriteLine(EmpresaClienteDAO.ShowContractorsByClient(c));
            
        }
    }
}
