using Benefits.DAO;
using Benefits.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.View
{
    class ListarEmpresas
    {
        public static void RenderListOfCompanies()
        {
            foreach (Empresa e in EmpresaDAO.ShowCompanies())
            {
                Console.WriteLine(e);
            }
        }
    }
}
