using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MoveIlheus.Models;

namespace MoveIlheus
{
    public class MoveIlheusContexto:DbContext
    {
        public MoveIlheusContexto(DbContextOptions<MoveIlheusContexto> options) : base(options)         
        {         
        }       
        public MoveIlheusContexto()        
        {         
        }       
        // public DbSet<Formulario> Formularios { get; set; }
        // public DbSet<Pagina> Paginas { get; set; }
        // public DbSet<Conteudo> Conteudos { get; set; }
        // public DbSet<ConteudoDesenho> ConteudosDesenhos { get; set; }
        // public DbSet<Opcao> Opcoes { get; set; }
        // public DbSet<RestricaoPagina> RestricoesPagina { get; set; }
        // public DbSet<RestricaoConteudo> RestricoesConteudo { get; set; }
        // public DbSet<Resposta> Respostas { get; set; }
        // public DbSet<RespostaDesenho> RespostasDesenho { get; set; }
        // public DbSet<OpcaoResposta> OpcoesResposta { get; set; }
        // public DbSet<Desenho> Desenhos { get; set; }
        // public DbSet<Coordenada> Coordenadas { get; set; }
        // public DbSet<RestricaoConteudoPagina> RestricoesConteudosPagina { get; set; }
        // public DbSet<Respondente> Respondentes { get; set; }

        public DbSet<Formulario> Forms { get; set; }
        public DbSet<Pagina> Pages { get; set; }
        public DbSet<Conteudo> Contents { get; set; }
        public DbSet<ConteudoDesenho> DrawingsContents { get; set; }
        public DbSet<Opcao> Options { get; set; }
        public DbSet<RestricaoPagina> PageRestrictions { get; set; }
        public DbSet<RestricaoConteudo> ContentRestrictions { get; set; }
        public DbSet<Resposta> Answers { get; set; }
        public DbSet<RespostaDesenho> DrawingsAnswers { get; set; }
        public DbSet<OpcaoResposta> AnswerOptions { get; set; }
        public DbSet<RestricaoConteudoPagina> ContentsRestrictionsPage { get; set; }
        public DbSet<Desenho> Drawings { get; set; }
        public DbSet<Coordenada> Coordinates { get; set; }
        public DbSet<Respondente> Respondents { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Course>().ToTable("Course");
        //     modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
        //     modelBuilder.Entity<Student>().ToTable("Student");
        // }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     if (!optionsBuilder.IsConfigured)
        //     {
        //         IConfigurationRoot configuration = new ConfigurationBuilder()
        //         .SetBasePath(Directory.GetCurrentDirectory())
        //         .AddJsonFile("appsettings.json")
        //         .Build();
        //         var connectionString = configuration.GetConnectionString("DefaultConnection");
        //         optionsBuilder.UseSqlServer(connectionString);
        //     }
        // }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Match>()
        //                .HasRequired(m => m.HomeTeam)
        //                .WithMany(t => t.HomeMatches)
        //                .HasForeignKey(m => m.HomeTeamId)
        //                .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Match>()
        //                .HasRequired(m => m.GuestTeam)
        //                .WithMany(t => t.AwayMatches)
        //                .HasForeignKey(m => m.GuestTeamId)
        //                .WillCascadeOnDelete(false);
        //}
    }
}