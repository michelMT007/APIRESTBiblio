using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BiblioDataInfo.Model
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("Nome")]
        [Required]
        [StringLength(60)]
        public string Nome { get; set; }

        [Column("CPF")]
        [Required]
        [StringLength(20)]
        public string CPF { get; set; }

        [Column("Telefone")]
        [Required]
        [StringLength(30)]
        public string Telefone { get; set; }

        [Column("Email")]
        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [Column("InstituicaoEnsino")]
        [Required]
        [StringLength(60)]
        public string InstituicaoEnsino { get; set; }
    }
}
