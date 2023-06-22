using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjCrudeSimples.Models
{
    [Table ("Produtos")]
    public class Produto
    {
        [Column("Id")]
        [Display (Name = "Id")]

        public int Id { get; set; }

        [Column ("Descricao")]
        [Display(Name = "Descricao")]

        public string Name { get; set;} = string.Empty;
    }
}
