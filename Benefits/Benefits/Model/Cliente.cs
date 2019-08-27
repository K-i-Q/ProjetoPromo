using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.Model
{
    class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public char Genero { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public Cliente()
        {

        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("| ");
            sb.Append("Nome: ");
            sb.Append(Nome);
            sb.Append("| Gênero: ");
            sb.Append(Genero);
            sb.Append("| Email: ");
            sb.Append(Email);
            sb.Append(" |");
            return sb.ToString();
        }
    }
}
