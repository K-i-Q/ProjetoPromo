﻿using Benefits.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.DAO
{
    class ClienteDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        //ADD new Client
        public static void RegisterClient(Cliente cliente)
        {
            ctx.Clientes.Add(cliente);
            ctx.SaveChanges();
        }
        //List all Clients
        public static List<Cliente> ShowClients() => ctx.Clientes.ToList();
        //Remove a Client
        public static void RemoveClient(Cliente cliente)
        {
            ctx.Clientes.Remove(FindClient(cliente));
            ctx.SaveChanges();
        }
        //Find a Client
        public static Cliente FindClient(Cliente cliente)
        {
            return ctx.Clientes.FirstOrDefault(x => x.Nome.Equals(cliente.Nome));

            //foreach (Cliente c in ShowClients())
            //{
            //    if (cliente == c)
            //    {
            //        return c;
            //    }
            //}
            //return null;
        }
        //Edit a Client
        public static void EditClient(Cliente cliente)
        {
           ctx.Entry(cliente).State = EntityState.Modified;
           ctx.SaveChanges();
        }
    }
}
