using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BiblioDataInfo.Model
{
    [Table("InstituicaoEnsino")]
    public class InstituicaoEnsino
    {
        [Key]
        [Column("Id")]
        public int Id{ get; set; }

        [Column("Nome")]
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Column("Sigla")]
        [Required]
        [StringLength(10)]
        public string Sigla { get; set; }

        [Column("Endereco")]
        [Required]
        [StringLength(100)]
        public string Endereco { get; set; }

        [Column("Cnpj")]
        [Required]
        [StringLength(20)]
        public string Cnpj { get; set; }

        [Column("Telefone")]
        [Required]
        [StringLength(20)]
        public string Telefone { get; set; }
    }
}
