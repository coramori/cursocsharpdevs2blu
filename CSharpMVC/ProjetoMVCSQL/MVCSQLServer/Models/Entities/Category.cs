using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCSQLServer.Models.Entities
{
    [Table("category")]
    public class Category
    {
        [Column("id")]
        [Display(Name = "Code")]
        public int Id { get; set; }

        [Column("name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public ICollection<Game>? Games { get; set; }
    }
}
