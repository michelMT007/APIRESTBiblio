using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BiblioDataInfo.Model
{
    [Table("ItensEmprestimo")]
    public class ItensEmprestimo
    {
        [Key]   
        public int Id { get; set; }
        
        [Column("IdEMprestimo")]
        public long IdEMprestimo { get; set; }

        [Column("IdLivro")]
        public long IdLivro { get; set; }

        [Column("DataEmprestimo")]
        [Required]
        [StringLength(20)]
        public string DataEmprestimo { get; set; }

        [Column("DataDevolucao")]
        [Required]
        [StringLength(20)]
        public string DataDevolucao { get; set; }
        public bool Emprestado { get; set; }

        [ForeignKey("Emprestimo")]
        public long IdEmprestimo { get; set; }
        public virtual Emprestimo Emprestimo { get; set; }      

        public ItensEmprestimo(long idemprestimo,long Idlivro)
        {
            IdEMprestimo = idemprestimo;
            IdLivro = Idlivro;  
            var datahora = new DateTime();
            DataEmprestimo = datahora.Date.ToString();
            DataDevolucao = datahora.AddDays(30).ToString();
        }
        public ItensEmprestimo(long idemprestimo)
        {
            IdEMprestimo = idemprestimo;
        }
        public ItensEmprestimo()
        {
                
        }
    }
}
