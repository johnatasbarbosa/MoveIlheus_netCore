﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoveIlheus;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MoveIlheus.Migrations
{
    [DbContext(typeof(MoveIlheusContexto))]
    partial class MoveIlheusContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MoveIlheus.Models.Conteudo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("MensagemNovoDesenho")
                        .HasColumnName("mensagem_novo_desenho");

                    b.Property<bool>("Obrigatorio")
                        .HasColumnName("obrigatorio");

                    b.Property<int>("Sequencia")
                        .HasColumnName("sequencia");

                    b.Property<string>("Texto")
                        .HasColumnName("texto");

                    b.Property<int>("Tipo")
                        .HasColumnName("tipo");

                    b.Property<string>("TituloConteudosDesenho")
                        .HasColumnName("titulo_conteudos_desenho");

                    b.Property<int>("Valor")
                        .HasColumnName("valor");

                    b.Property<int>("paginaId")
                        .HasColumnName("pagina_id");

                    b.HasKey("Id");

                    b.HasIndex("paginaId");

                    b.ToTable("contents");
                });

            modelBuilder.Entity("MoveIlheus.Models.ConteudoDesenho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("ConteudoId")
                        .HasColumnName("conteudo_id");

                    b.Property<bool>("Obrigatorio")
                        .HasColumnName("obrigatorio");

                    b.Property<int>("Sequencia")
                        .HasColumnName("sequencia");

                    b.Property<string>("Texto")
                        .HasColumnName("texto");

                    b.Property<int>("Tipo")
                        .HasColumnName("tipo");

                    b.Property<int>("Valor")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex("ConteudoId");

                    b.ToTable("drawings_contents");
                });

            modelBuilder.Entity("MoveIlheus.Models.Coordenada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("DesenhoId")
                        .HasColumnName("desenho_id");

                    b.Property<double>("Latitude")
                        .HasColumnName("latitude");

                    b.Property<double>("Longitude")
                        .HasColumnName("longitude");

                    b.HasKey("Id");

                    b.HasIndex("DesenhoId");

                    b.ToTable("coordinates");
                });

            modelBuilder.Entity("MoveIlheus.Models.Desenho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("RespostaId")
                        .HasColumnName("resposta_id");

                    b.Property<int>("Tipo")
                        .HasColumnName("tipo");

                    b.HasKey("Id");

                    b.HasIndex("RespostaId");

                    b.ToTable("drawings");
                });

            modelBuilder.Entity("MoveIlheus.Models.Formulario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("forms");
                });

            modelBuilder.Entity("MoveIlheus.Models.Opcao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("ConteudoDesenhoId")
                        .HasColumnName("conteudo_desenho_id");

                    b.Property<int?>("ConteudoId")
                        .HasColumnName("conteudo_id");

                    b.Property<string>("Texto")
                        .HasColumnName("texto");

                    b.Property<int>("Valor")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex("ConteudoDesenhoId");

                    b.HasIndex("ConteudoId");

                    b.ToTable("options");
                });

            modelBuilder.Entity("MoveIlheus.Models.OpcaoResposta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("OpcaoId")
                        .HasColumnName("opcao_id");

                    b.Property<int?>("RespostaDesenhoId")
                        .HasColumnName("resposta_desenho_id");

                    b.Property<int?>("RespostaId")
                        .HasColumnName("resposta_id");

                    b.Property<int>("Valor")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex("OpcaoId");

                    b.HasIndex("RespostaDesenhoId");

                    b.HasIndex("RespostaId");

                    b.ToTable("answer_options");
                });

            modelBuilder.Entity("MoveIlheus.Models.Pagina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("Dimensao")
                        .HasColumnName("dimensao");

                    b.Property<bool>("Final")
                        .HasColumnName("final");

                    b.Property<int>("FormularioId")
                        .HasColumnName("formulario_id");

                    b.Property<double>("Latitude")
                        .HasColumnName("latitude");

                    b.Property<double>("Longitude")
                        .HasColumnName("longitude");

                    b.Property<int?>("ProximaPaginaId")
                        .HasColumnName("proxima_pagina_id");

                    b.Property<int>("Sequencia")
                        .HasColumnName("sequencia");

                    b.Property<string>("Titulo")
                        .HasColumnName("titulo");

                    b.Property<int>("ZoomLevel")
                        .HasColumnName("zoom_level");

                    b.HasKey("Id");

                    b.HasIndex("FormularioId");

                    b.HasIndex("ProximaPaginaId");

                    b.ToTable("pages");
                });

            modelBuilder.Entity("MoveIlheus.Models.Respondente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<TimeSpan>("Duracao")
                        .HasColumnName("duracao");

                    b.Property<string>("Email")
                        .HasColumnName("email");

                    b.HasKey("Id");

                    b.ToTable("respondents");
                });

            modelBuilder.Entity("MoveIlheus.Models.Resposta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("ConteudoId")
                        .HasColumnName("conteudo_id");

                    b.Property<bool>("Marcado")
                        .HasColumnName("marcado");

                    b.Property<int?>("OpcaoId")
                        .HasColumnName("opcao_id");

                    b.Property<int>("RespondenteId")
                        .HasColumnName("respondente_id");

                    b.Property<string>("Texto")
                        .HasColumnName("texto");

                    b.Property<int>("Valor")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex("ConteudoId");

                    b.HasIndex("OpcaoId");

                    b.HasIndex("RespondenteId");

                    b.ToTable("answers");
                });

            modelBuilder.Entity("MoveIlheus.Models.RespostaDesenho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("ConteudoDesenhoId")
                        .HasColumnName("conteudo_desenho_id");

                    b.Property<int>("DesenhoId")
                        .HasColumnName("desenho_id");

                    b.Property<bool>("Marcado")
                        .HasColumnName("marcado");

                    b.Property<int?>("OpcaoId")
                        .HasColumnName("opcao_id");

                    b.Property<string>("Texto")
                        .HasColumnName("texto");

                    b.Property<int>("Valor")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex("ConteudoDesenhoId");

                    b.HasIndex("DesenhoId");

                    b.HasIndex("OpcaoId");

                    b.ToTable("drawings_answers");
                });

            modelBuilder.Entity("MoveIlheus.Models.RestricaoConteudo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("ConteudoAlvoId")
                        .HasColumnName("conteudo_alvo_id");

                    b.Property<int>("ConteudoId")
                        .HasColumnName("conteudo_id");

                    b.Property<string>("Nome")
                        .HasColumnName("nome");

                    b.Property<int>("OpcaoAlvoId")
                        .HasColumnName("opcao_alvo_id");

                    b.Property<int>("PaginaAlvoId")
                        .HasColumnName("pagina_alvo_id");

                    b.HasKey("Id");

                    b.HasIndex("ConteudoId");

                    b.ToTable("content_restrictions");
                });

            modelBuilder.Entity("MoveIlheus.Models.RestricaoConteudoPagina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("ConteudoId")
                        .HasColumnName("conteudo_id");

                    b.Property<string>("Nome")
                        .HasColumnName("nome");

                    b.Property<int>("OpcaoId")
                        .HasColumnName("opcao_id");

                    b.Property<int>("RestricaoPaginaId")
                        .HasColumnName("restricao_pagina_id");

                    b.HasKey("Id");

                    b.HasIndex("ConteudoId");

                    b.HasIndex("OpcaoId");

                    b.HasIndex("RestricaoPaginaId");

                    b.ToTable("contents_restrictions_page");
                });

            modelBuilder.Entity("MoveIlheus.Models.RestricaoPagina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .HasColumnName("nome");

                    b.Property<int>("PaginaId")
                        .HasColumnName("pagina_id");

                    b.Property<int>("ProximaPaginaId")
                        .HasColumnName("proxima_pagina_id");

                    b.HasKey("Id");

                    b.HasIndex("PaginaId");

                    b.ToTable("page_restrictions");
                });

            modelBuilder.Entity("MoveIlheus.Models.Conteudo", b =>
                {
                    b.HasOne("MoveIlheus.Models.Pagina", "pagina")
                        .WithMany("Conteudos")
                        .HasForeignKey("paginaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MoveIlheus.Models.ConteudoDesenho", b =>
                {
                    b.HasOne("MoveIlheus.Models.Conteudo", "Conteudo")
                        .WithMany("ConteudosDesenhos")
                        .HasForeignKey("ConteudoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MoveIlheus.Models.Coordenada", b =>
                {
                    b.HasOne("MoveIlheus.Models.Desenho", "Desenho")
                        .WithMany("Coordenadas")
                        .HasForeignKey("DesenhoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MoveIlheus.Models.Desenho", b =>
                {
                    b.HasOne("MoveIlheus.Models.Resposta", "Resposta")
                        .WithMany("Desenhos")
                        .HasForeignKey("RespostaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MoveIlheus.Models.Opcao", b =>
                {
                    b.HasOne("MoveIlheus.Models.ConteudoDesenho", "ConteudoDesenho")
                        .WithMany("Opcoes")
                        .HasForeignKey("ConteudoDesenhoId");

                    b.HasOne("MoveIlheus.Models.Conteudo", "Conteudo")
                        .WithMany("Opcoes")
                        .HasForeignKey("ConteudoId");
                });

            modelBuilder.Entity("MoveIlheus.Models.OpcaoResposta", b =>
                {
                    b.HasOne("MoveIlheus.Models.Opcao", "Opcao")
                        .WithMany("OpcoesResposta")
                        .HasForeignKey("OpcaoId");

                    b.HasOne("MoveIlheus.Models.RespostaDesenho", "RespostaDesenho")
                        .WithMany("Opcoes")
                        .HasForeignKey("RespostaDesenhoId");

                    b.HasOne("MoveIlheus.Models.Resposta", "Resposta")
                        .WithMany("Opcoes")
                        .HasForeignKey("RespostaId");
                });

            modelBuilder.Entity("MoveIlheus.Models.Pagina", b =>
                {
                    b.HasOne("MoveIlheus.Models.Formulario", "Formulario")
                        .WithMany("Paginas")
                        .HasForeignKey("FormularioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MoveIlheus.Models.Pagina", "ProximaPagina")
                        .WithMany()
                        .HasForeignKey("ProximaPaginaId");
                });

            modelBuilder.Entity("MoveIlheus.Models.Resposta", b =>
                {
                    b.HasOne("MoveIlheus.Models.Conteudo", "Conteudo")
                        .WithMany("Respostas")
                        .HasForeignKey("ConteudoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MoveIlheus.Models.Opcao", "Opcao")
                        .WithMany()
                        .HasForeignKey("OpcaoId");

                    b.HasOne("MoveIlheus.Models.Respondente", "Respondente")
                        .WithMany("Respostas")
                        .HasForeignKey("RespondenteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MoveIlheus.Models.RespostaDesenho", b =>
                {
                    b.HasOne("MoveIlheus.Models.ConteudoDesenho", "ConteudoDesenho")
                        .WithMany("Respostas")
                        .HasForeignKey("ConteudoDesenhoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MoveIlheus.Models.Desenho", "Desenho")
                        .WithMany("RespostasDesenho")
                        .HasForeignKey("DesenhoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MoveIlheus.Models.Opcao", "Opcao")
                        .WithMany()
                        .HasForeignKey("OpcaoId");
                });

            modelBuilder.Entity("MoveIlheus.Models.RestricaoConteudo", b =>
                {
                    b.HasOne("MoveIlheus.Models.Conteudo", "Conteudo")
                        .WithMany("Restricoes")
                        .HasForeignKey("ConteudoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MoveIlheus.Models.RestricaoConteudoPagina", b =>
                {
                    b.HasOne("MoveIlheus.Models.Conteudo", "Conteudo")
                        .WithMany()
                        .HasForeignKey("ConteudoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MoveIlheus.Models.Opcao", "Opcao")
                        .WithMany()
                        .HasForeignKey("OpcaoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MoveIlheus.Models.RestricaoPagina", "RestricaoPagina")
                        .WithMany("RestricoesConteudosPagina")
                        .HasForeignKey("RestricaoPaginaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MoveIlheus.Models.RestricaoPagina", b =>
                {
                    b.HasOne("MoveIlheus.Models.Pagina", "Pagina")
                        .WithMany("Restricoes")
                        .HasForeignKey("PaginaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
