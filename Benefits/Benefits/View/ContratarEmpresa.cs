using Benefits.DAO;
using Benefits.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.View
{
    class ContratarEmpresa
    {
        public static void RenderHireCompany()
        {
            Cliente c = new Cliente();
            Empresa e = new Empresa();
            EmpresaCliente ec = new EmpresaCliente();

            Console.WriteLine("Nome do cliente: ");
            c.Nome = Console.ReadLine();
            c = ClienteDAO.FindClient(c);

            Console.WriteLine("Nome da empresa: ");
            e.Nome = Console.ReadLine();
            e = EmpresaDAO.FindCompany(e);

            ec.ClienteId = c.ClienteId;
            ec.Cliente = c;
            ec.EmpresaId = e.EmpresaId;
            ec.Empresa = e;

            EmpresaClienteDAO.HireCompany(ec);
        }
    }
}
