using SistemaBiblitecarioManas.Entities.Enum;

namespace SistemaBiblitecarioManas.Entities.Entities
{
    public class LivroEntity : BaseEntity
    {
        public string NomeLivro { get; set; }
        public string NomeAutor { get; set; }
        public GeneroDoLivro GeneroDoLivro { get; set; }
    }
}
