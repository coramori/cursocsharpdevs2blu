using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCSQLServer.Models.Entities
{
    [Table("games")]
    public class Game
    {
        [Column("id")]
        [Display(Name = "Code")]
        public int Id { get; set; }

        [Column("name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Column("CategoryId")]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }
    }
}
