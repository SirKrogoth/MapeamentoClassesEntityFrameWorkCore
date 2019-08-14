using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MapeamentoClassesEntityFrameWorkCore.Domain
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Produtos> Produtos { get; set; }

        public Categoria()
        {
            this.Produtos = new HashSet<Produtos>();
        }
    }
}