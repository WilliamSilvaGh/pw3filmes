using PWFilmes.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWFilmes.Domain.Entities
{
    public class Filme : EntityBase
    {
        public string Nome { get; set; }
        public string Diretor { get; set; }
        public string Atores { get; set; }
        public short AnoLancamento { get; set; }
        public Guid CategoriaId {  get; set; }
        public virtual Categoria Categoria { get; set; }

        protected Filme() {}
        public Filme(
            string nome,
            string diretor,
            string atores,
            short anoLancamento,
            Categoria categoria)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Diretor = diretor;
            Atores = atores;
            AnoLancamento = anoLancamento;
            Categoria = categoria;            
        }
    }
}
