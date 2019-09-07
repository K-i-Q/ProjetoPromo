using Benefits.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.DAO
{
    class EmpresaClienteDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        //Cadastra a contratação de uma empresa para um cliente
        public static void HireCompany(EmpresaCliente empresaCliente)
        {
            ctx.EmpresaCliente.Add(empresaCliente);
            ctx.SaveChanges();
        }

        public static List<EmpresaCliente> ShowAllCompanyClient() => ctx.EmpresaCliente.ToList();

        //WIP show companies hire by client
        public static void ShowContractorsByClient(Cliente c)
        {
            Empresa e = new Empresa();

            foreach (EmpresaCliente empresaCliente in ShowAllCompanyClient())
            {
                if (c.ClienteId == empresaCliente.ClienteId)
                {
                    e = EmpresaDAO.FindCompanyById(empresaCliente.EmpresaId);
                    Console.WriteLine(e.Nome);
                }
            }
        }
    }
}
