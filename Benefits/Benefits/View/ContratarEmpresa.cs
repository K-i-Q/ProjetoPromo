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

            Console.WriteLine("Nome do cliente: ");
            c.Nome = Console.ReadLine();
            c = ClienteDAO.FindClient(c);

            Console.WriteLine("Nome da empresa: ");
            e.Nome = Console.ReadLine();
            e = EmpresaDAO.FindCompany(e);

            c.Empresas.Add(e);

            e.Clientes.Add(c);

            //System.InvalidOperationException: 
            //The property 'EmpresaId' is part of the object's key information and cannot be modified

            ClienteDAO.EditClient(c);
            EmpresaDAO.EditCompany(e);
        }
    }
}
