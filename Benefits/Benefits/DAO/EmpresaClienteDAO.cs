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

        //WIP show companies hire by client
        public static List<EmpresaCliente> ShowContractorsByClient(Cliente c) => ctx.EmpresaCliente.Where(x => x.ClienteId.Equals(c.ClienteId)).ToList();
    }
}
