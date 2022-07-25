using BiblioDataInfo.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BiblioDataInfo.Context
{
    public class AplicacaoContext : DbContext
    {
        public AplicacaoContext(DbContextOptions<AplicacaoContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=biblioteca;Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
            //"TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            optionsBuilder.UseSqlServer(@"Data Source=.,1450;User ID=SA;Password=Qwe!2345678;Connect Timeout=30; Initial Catalog=biblioteca; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
            public DbSet<Usuario> Usuarios { get; set; }
            public DbSet<Livro> Livros { get; set; }
            public DbSet<Emprestimo> Emprestimos { get; set; }
            public DbSet<InstituicaoEnsino> InstituicoesEnsino { get; set; }
            public DbSet<ItensEmprestimo> ItensEmprestimos { get; set; }

    }
}
