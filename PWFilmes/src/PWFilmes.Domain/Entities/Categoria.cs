using PWFilmes.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWFilmes.Domain.Entities
{
    public class Categoria : EntityBase
    {
        public string Descricao { get; set; }

        public Categoria(string descricao)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
        }
    }
}
