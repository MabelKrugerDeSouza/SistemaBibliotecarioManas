using System;

namespace SistemaBiblitecarioManas.Entities.Entities
{
    public class EmprestimoLivroEntity : BaseEntity
    {
        public int LivroId { get; set; }
        public int PessoaId { get; set; }
        public virtual PessoaEntity Pessoa { get; set; }
        public virtual LivroEntity  Livro { get; set; }
        public DateTime EmprestimoLivro { get; set; }
        public DateTime PrevisaoDevolucao { get; set; }
        public DateTime DataDevolucao { get; set; }
    }
}
