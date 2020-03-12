using System;
using System.Collections.Generic;
using System.Text;

namespace seed2.Domain.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Documento { get; set; }
        public string Telefone { get; set; }
        public int UnidadeId { get; set; }
        public Unidade Unidade { get; set; }
        public string Matricula { get; set; }
        public int? CursoId { get; set; }
        public string ImgUrl { get; set; }
        public string Code { get; set; }
        public bool? Ativo { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? AlterDate { get; set; }
        public int? AlterUser { get; set; }
    }
}
