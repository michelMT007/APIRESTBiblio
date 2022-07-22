using BiblioDataInfo.VO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BiblioDataInfo.Model
{
    [Table("Emprestimo")]
    public class Emprestimo
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("IdUsuario")]
        [Required]
        public long IdUsuario { get; set; }

        [Column("IdUsuario")]
        [Required]
        public long IdLivro { get; set; }

        [Column("DataEmprestimo")]
        [Required]
        public string DataEmprestimo{ get; set; }

        [Column("Datadevolucao")]
        [StringLength(60)]
        public string Datadevolucao { get; set; }

        [Column("EmprestimoAtivo")]
        public bool EmprestimoAtivo { get; set; }

        public ICollection<ItensEmprestimo> Itens { get; set; }
        public Emprestimo()
        {
            
        }
    }
}
