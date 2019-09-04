using Benefits.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.DAO
{
    class EmpresaDAO
    {
        private static Context ctx = new Context();

        //ADD new Company
        public static void RegisterCompany(Empresa empresa)
        {
            ctx.Empresas.Add(empresa);
            ctx.SaveChanges();
        }
        //List all Companies
        public static List<Empresa> ShowCompanies() => ctx.Empresas.ToList();
        //Remove a Company
        public static void RemoveCompany(Empresa empresa)
        {
            ctx.Empresas.Remove(FindCompany(empresa));
            ctx.SaveChanges();
        }
        //Find a Client
        public static Empresa FindCompany(Empresa empresa)
        {
            return ctx.Empresas.FirstOrDefault(x => x.Nome.Equals(empresa.Nome));

            //foreach (Empresa e in ShowCompanies())
            //{
            //    if (empresa == e)
            //    {
            //        return e;
            //    }
            //}
            //return null;
        }
        //Edit a Company
        public static void EditCompany(Empresa empresa)
        {
            ctx.Entry(empresa).State = EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
