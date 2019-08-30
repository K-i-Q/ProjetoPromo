using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.Model
{
    [Table("Clientes")]
    class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public char Genero { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime CriadoEm { get; set; }

        public Cliente()
        {
            CriadoEm = DateTime.Now;
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

        public override bool Equals(object obj)
        {
            Cliente p = (Cliente)obj;
            return Nome == p.Nome;
        }
    }
}
