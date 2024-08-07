using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuelloCook.Models;

[Table("Categoria")]

    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string nome { get; set; }

        [StringLength(300)]
        public string foto { get; set; }

    }
