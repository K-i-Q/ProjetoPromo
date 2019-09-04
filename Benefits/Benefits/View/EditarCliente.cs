using Benefits.DAO;
using Benefits.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.View
{
    class EditarCliente
    {
        public static void RenderizarEditClient()
        {
            Cliente c = new Cliente();

            Console.WriteLine("Editar Cliente");
            Console.WriteLine("Digite o nome");
            c.Nome = Console.ReadLine().ToLower();
            c = ClienteDAO.FindClient(c);

            Console.WriteLine("Digite o novo nome");
            c.Nome = Console.ReadLine().ToLower();
            Console.WriteLine("Digite o novo gênero");
            c.Genero = Console.ReadLine().ToLower();
            Console.WriteLine("Digite o novo email");
            c.Email = Console.ReadLine().ToLower();
            Console.WriteLine("Digite a nova data de nascimento");
            c.DataNascimento = Console.ReadLine().ToLower();
            Console.WriteLine("Digite o novo telefone");
            c.Telefone = Console.ReadLine().ToLower();
            //Criar valores para alteração
            ClienteDAO.EditClient(c);

        }
    }
}
