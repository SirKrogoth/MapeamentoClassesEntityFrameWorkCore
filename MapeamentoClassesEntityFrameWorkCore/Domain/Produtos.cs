using System.ComponentModel.DataAnnotations;

namespace MapeamentoClassesEntityFrameWorkCore.Domain
{
    public class Produtos
    {
        [Key]
        public int ID { get; set; }
        public string Descricao { get; set; }
        public int CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}