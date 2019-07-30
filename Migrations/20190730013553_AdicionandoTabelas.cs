using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MoveIlheus.Migrations
{
    public partial class AdicionandoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "forms",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_forms", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "respondents",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    email = table.Column<string>(nullable: true),
                    duracao = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_respondents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    titulo = table.Column<string>(nullable: true),
                    dimensao = table.Column<int>(nullable: false),
                    final = table.Column<bool>(nullable: false),
                    sequencia = table.Column<int>(nullable: false),
                    latitude = table.Column<double>(nullable: false),
                    longitude = table.Column<double>(nullable: false),
                    zoom_level = table.Column<int>(nullable: false),
                    formulario_id = table.Column<int>(nullable: false),
                    proxima_pagina_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pages", x => x.id);
                    table.ForeignKey(
                        name: "FK_pages_forms_formulario_id",
                        column: x => x.formulario_id,
                        principalTable: "forms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pages_pages_proxima_pagina_id",
                        column: x => x.proxima_pagina_id,
                        principalTable: "pages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "contents",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    tipo = table.Column<int>(nullable: false),
                    texto = table.Column<string>(nullable: true),
                    valor = table.Column<int>(nullable: false),
                    sequencia = table.Column<int>(nullable: false),
                    obrigatorio = table.Column<bool>(nullable: false),
                    titulo_conteudos_desenho = table.Column<string>(nullable: true),
                    mensagem_novo_desenho = table.Column<string>(nullable: true),
                    pagina_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contents", x => x.id);
                    table.ForeignKey(
                        name: "FK_contents_pages_pagina_id",
                        column: x => x.pagina_id,
                        principalTable: "pages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "page_restrictions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nome = table.Column<string>(nullable: true),
                    pagina_id = table.Column<int>(nullable: false),
                    proxima_pagina_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_page_restrictions", x => x.id);
                    table.ForeignKey(
                        name: "FK_page_restrictions_pages_pagina_id",
                        column: x => x.pagina_id,
                        principalTable: "pages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "content_restrictions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nome = table.Column<string>(nullable: true),
                    conteudo_id = table.Column<int>(nullable: false),
                    pagina_alvo_id = table.Column<int>(nullable: false),
                    conteudo_alvo_id = table.Column<int>(nullable: false),
                    opcao_alvo_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_content_restrictions", x => x.id);
                    table.ForeignKey(
                        name: "FK_content_restrictions_contents_conteudo_id",
                        column: x => x.conteudo_id,
                        principalTable: "contents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "drawings_contents",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    tipo = table.Column<int>(nullable: false),
                    texto = table.Column<string>(nullable: true),
                    valor = table.Column<int>(nullable: false),
                    sequencia = table.Column<int>(nullable: false),
                    obrigatorio = table.Column<bool>(nullable: false),
                    conteudo_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drawings_contents", x => x.id);
                    table.ForeignKey(
                        name: "FK_drawings_contents_contents_conteudo_id",
                        column: x => x.conteudo_id,
                        principalTable: "contents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "options",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    texto = table.Column<string>(nullable: true),
                    valor = table.Column<int>(nullable: false),
                    conteudo_id = table.Column<int>(nullable: true),
                    conteudo_desenho_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_options", x => x.id);
                    table.ForeignKey(
                        name: "FK_options_drawings_contents_conteudo_desenho_id",
                        column: x => x.conteudo_desenho_id,
                        principalTable: "drawings_contents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_options_contents_conteudo_id",
                        column: x => x.conteudo_id,
                        principalTable: "contents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "answers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    texto = table.Column<string>(nullable: true),
                    valor = table.Column<int>(nullable: false),
                    marcado = table.Column<bool>(nullable: false),
                    conteudo_id = table.Column<int>(nullable: false),
                    opcao_id = table.Column<int>(nullable: true),
                    respondente_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_answers", x => x.id);
                    table.ForeignKey(
                        name: "FK_answers_contents_conteudo_id",
                        column: x => x.conteudo_id,
                        principalTable: "contents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_answers_options_opcao_id",
                        column: x => x.opcao_id,
                        principalTable: "options",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_answers_respondents_respondente_id",
                        column: x => x.respondente_id,
                        principalTable: "respondents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contents_restrictions_page",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nome = table.Column<string>(nullable: true),
                    restricao_pagina_id = table.Column<int>(nullable: false),
                    conteudo_id = table.Column<int>(nullable: false),
                    opcao_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contents_restrictions_page", x => x.id);
                    table.ForeignKey(
                        name: "FK_contents_restrictions_page_contents_conteudo_id",
                        column: x => x.conteudo_id,
                        principalTable: "contents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contents_restrictions_page_options_opcao_id",
                        column: x => x.opcao_id,
                        principalTable: "options",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contents_restrictions_page_page_restrictions_restricao_pagi~",
                        column: x => x.restricao_pagina_id,
                        principalTable: "page_restrictions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "drawings",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    tipo = table.Column<int>(nullable: false),
                    resposta_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drawings", x => x.id);
                    table.ForeignKey(
                        name: "FK_drawings_answers_resposta_id",
                        column: x => x.resposta_id,
                        principalTable: "answers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "coordinates",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    latitude = table.Column<double>(nullable: false),
                    longitude = table.Column<double>(nullable: false),
                    desenho_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coordinates", x => x.id);
                    table.ForeignKey(
                        name: "FK_coordinates_drawings_desenho_id",
                        column: x => x.desenho_id,
                        principalTable: "drawings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "drawings_answers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    texto = table.Column<string>(nullable: true),
                    valor = table.Column<int>(nullable: false),
                    marcado = table.Column<bool>(nullable: false),
                    conteudo_desenho_id = table.Column<int>(nullable: false),
                    opcao_id = table.Column<int>(nullable: true),
                    desenho_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drawings_answers", x => x.id);
                    table.ForeignKey(
                        name: "FK_drawings_answers_drawings_contents_conteudo_desenho_id",
                        column: x => x.conteudo_desenho_id,
                        principalTable: "drawings_contents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_drawings_answers_drawings_desenho_id",
                        column: x => x.desenho_id,
                        principalTable: "drawings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_drawings_answers_options_opcao_id",
                        column: x => x.opcao_id,
                        principalTable: "options",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "answer_options",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    valor = table.Column<int>(nullable: false),
                    resposta_id = table.Column<int>(nullable: true),
                    resposta_desenho_id = table.Column<int>(nullable: true),
                    opcao_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_answer_options", x => x.id);
                    table.ForeignKey(
                        name: "FK_answer_options_options_opcao_id",
                        column: x => x.opcao_id,
                        principalTable: "options",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_answer_options_drawings_answers_resposta_desenho_id",
                        column: x => x.resposta_desenho_id,
                        principalTable: "drawings_answers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_answer_options_answers_resposta_id",
                        column: x => x.resposta_id,
                        principalTable: "answers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_answer_options_opcao_id",
                table: "answer_options",
                column: "opcao_id");

            migrationBuilder.CreateIndex(
                name: "IX_answer_options_resposta_desenho_id",
                table: "answer_options",
                column: "resposta_desenho_id");

            migrationBuilder.CreateIndex(
                name: "IX_answer_options_resposta_id",
                table: "answer_options",
                column: "resposta_id");

            migrationBuilder.CreateIndex(
                name: "IX_answers_conteudo_id",
                table: "answers",
                column: "conteudo_id");

            migrationBuilder.CreateIndex(
                name: "IX_answers_opcao_id",
                table: "answers",
                column: "opcao_id");

            migrationBuilder.CreateIndex(
                name: "IX_answers_respondente_id",
                table: "answers",
                column: "respondente_id");

            migrationBuilder.CreateIndex(
                name: "IX_content_restrictions_conteudo_id",
                table: "content_restrictions",
                column: "conteudo_id");

            migrationBuilder.CreateIndex(
                name: "IX_contents_pagina_id",
                table: "contents",
                column: "pagina_id");

            migrationBuilder.CreateIndex(
                name: "IX_contents_restrictions_page_conteudo_id",
                table: "contents_restrictions_page",
                column: "conteudo_id");

            migrationBuilder.CreateIndex(
                name: "IX_contents_restrictions_page_opcao_id",
                table: "contents_restrictions_page",
                column: "opcao_id");

            migrationBuilder.CreateIndex(
                name: "IX_contents_restrictions_page_restricao_pagina_id",
                table: "contents_restrictions_page",
                column: "restricao_pagina_id");

            migrationBuilder.CreateIndex(
                name: "IX_coordinates_desenho_id",
                table: "coordinates",
                column: "desenho_id");

            migrationBuilder.CreateIndex(
                name: "IX_drawings_resposta_id",
                table: "drawings",
                column: "resposta_id");

            migrationBuilder.CreateIndex(
                name: "IX_drawings_answers_conteudo_desenho_id",
                table: "drawings_answers",
                column: "conteudo_desenho_id");

            migrationBuilder.CreateIndex(
                name: "IX_drawings_answers_desenho_id",
                table: "drawings_answers",
                column: "desenho_id");

            migrationBuilder.CreateIndex(
                name: "IX_drawings_answers_opcao_id",
                table: "drawings_answers",
                column: "opcao_id");

            migrationBuilder.CreateIndex(
                name: "IX_drawings_contents_conteudo_id",
                table: "drawings_contents",
                column: "conteudo_id");

            migrationBuilder.CreateIndex(
                name: "IX_options_conteudo_desenho_id",
                table: "options",
                column: "conteudo_desenho_id");

            migrationBuilder.CreateIndex(
                name: "IX_options_conteudo_id",
                table: "options",
                column: "conteudo_id");

            migrationBuilder.CreateIndex(
                name: "IX_page_restrictions_pagina_id",
                table: "page_restrictions",
                column: "pagina_id");

            migrationBuilder.CreateIndex(
                name: "IX_pages_formulario_id",
                table: "pages",
                column: "formulario_id");

            migrationBuilder.CreateIndex(
                name: "IX_pages_proxima_pagina_id",
                table: "pages",
                column: "proxima_pagina_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "answer_options");

            migrationBuilder.DropTable(
                name: "content_restrictions");

            migrationBuilder.DropTable(
                name: "contents_restrictions_page");

            migrationBuilder.DropTable(
                name: "coordinates");

            migrationBuilder.DropTable(
                name: "drawings_answers");

            migrationBuilder.DropTable(
                name: "page_restrictions");

            migrationBuilder.DropTable(
                name: "drawings");

            migrationBuilder.DropTable(
                name: "answers");

            migrationBuilder.DropTable(
                name: "options");

            migrationBuilder.DropTable(
                name: "respondents");

            migrationBuilder.DropTable(
                name: "drawings_contents");

            migrationBuilder.DropTable(
                name: "contents");

            migrationBuilder.DropTable(
                name: "pages");

            migrationBuilder.DropTable(
                name: "forms");
        }
    }
}
