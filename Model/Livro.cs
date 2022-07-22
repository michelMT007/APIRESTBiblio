using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BiblioDataInfo.Model
{
    [Table("Livro")]
    public class Livro
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("Titulo")]
        [Required]
        [StringLength(60)]
        public string Titulo { get; set; }
        
        
        [Column("Genero")]
        [Required]
        [StringLength(30)]
        public string Genero { get; set; }
        
        
        [Column("Autor")]
        [Required]
        [StringLength(100)]
        public string Autor { get; set; }


        [Column("Sinopse")]
        [Required]
        [StringLength(300)]
        public string Sinopse { get; set; }

        [Column("Capa")]
        [Required]
        [StringLength(250)]
        public string Capa { get; set; }
    }
}
