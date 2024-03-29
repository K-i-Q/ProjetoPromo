﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.Model
{
    [Table("Empresas")]
    class Empresa
    {
        [Key]
        public int EmpresaId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime CriadoEm { get; set; }
        public List<EmpresaCliente> EmpresaCliente { get; set; }


        public Empresa()
        {
            CriadoEm = DateTime.Now;
            EmpresaCliente = new List<EmpresaCliente>();
            
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("________________________________________");
            sb.Append("\n| ");
            sb.Append("Nome: ");
            sb.Append(Nome.ToUpper());
            sb.Append("\n| ");
            sb.Append("Email: ");
            sb.Append(Email.ToUpper());
            sb.Append("\n| ");
            sb.Append("Telefone: ");
            sb.Append(Telefone);
            sb.Append("\n| ");
            sb.Append("Cadastrado em: ");
            sb.Append(CriadoEm);
            sb.Append("\n| ");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            Empresa e = (Empresa)obj;
            return Nome == e.Nome;
        }
    }
}
