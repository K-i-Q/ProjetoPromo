using Benefits.DAO;
using Benefits.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.View
{
    class CadastrarCliente
    {
        public static void RenderRegisterClient()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Digite o nome: ");
            cliente.Nome = Console.ReadLine().ToLower();
            Console.WriteLine("Escolha o genero (m - masculino / f - feminino): ");
            cliente.Genero = Console.ReadLine().ToLower();
            Console.WriteLine("Digite a data de nascimento (Ex: 15/05/1996): ");
            cliente.DataNascimento = Console.ReadLine().ToLower();
            Console.WriteLine("Digite seu e-mail: ");
            cliente.Email = Console.ReadLine().ToLower();
            Console.WriteLine("Digite seu telefone (Ex: (41)99561-5900): ");
            cliente.Telefone = Console.ReadLine().ToLower();

            ClienteDAO.RegisterClient(cliente);
        }
    }
}
