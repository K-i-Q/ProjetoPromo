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
            List<EmpresaCliente> ec = new List<EmpresaCliente>();

            Console.WriteLine("Nome do cliente: ");
            c.Nome = Console.ReadLine();
            c = ClienteDAO.FindClient(c);

            ec = EmpresaClienteDAO.ShowContractorsByClient(c);
            foreach (EmpresaCliente e in ec)
            {
                Console.WriteLine(e.Empresa.Nome + "\n");
            }
        }
    }
}
