using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MoveIlheus.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Respondents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Email = table.Column<string>(nullable: true),
                    Duracao = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respondents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Titulo = table.Column<string>(nullable: true),
                    Dimensao = table.Column<int>(nullable: false),
                    Final = table.Column<bool>(nullable: false),
                    Sequencia = table.Column<int>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    ZoomLevel = table.Column<int>(nullable: false),
                    FormularioId = table.Column<int>(nullable: false),
                    ProximaPaginaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pages_Forms_FormularioId",
                        column: x => x.FormularioId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pages_Pages_ProximaPaginaId",
                        column: x => x.ProximaPaginaId,
                        principalTable: "Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Tipo = table.Column<int>(nullable: false),
                    Texto = table.Column<string>(nullable: true),
                    Valor = table.Column<int>(nullable: false),
                    Sequencia = table.Column<int>(nullable: false),
                    Obrigatorio = table.Column<bool>(nullable: false),
                    TituloConteudosDesenho = table.Column<string>(nullable: true),
                    MensagemNovoDesenho = table.Column<string>(nullable: true),
                    PaginaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contents_Pages_PaginaId",
                        column: x => x.PaginaId,
                        principalTable: "Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PageRestrictions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nome = table.Column<string>(nullable: true),
                    PaginaId = table.Column<int>(nullable: false),
                    ProximaPaginaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageRestrictions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PageRestrictions_Pages_PaginaId",
                        column: x => x.PaginaId,
                        principalTable: "Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentRestrictions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nome = table.Column<string>(nullable: true),
                    ConteudoId = table.Column<int>(nullable: false),
                    PaginaAlvoId = table.Column<int>(nullable: false),
                    ConteudoAlvoId = table.Column<int>(nullable: false),
                    OpcaoAlvoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentRestrictions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContentRestrictions_Contents_ConteudoId",
                        column: x => x.ConteudoId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DrawingsContents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Tipo = table.Column<int>(nullable: false),
                    Texto = table.Column<string>(nullable: true),
                    Valor = table.Column<int>(nullable: false),
                    Sequencia = table.Column<int>(nullable: false),
                    Obrigatorio = table.Column<bool>(nullable: false),
                    ConteudoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrawingsContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrawingsContents_Contents_ConteudoId",
                        column: x => x.ConteudoId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Texto = table.Column<string>(nullable: true),
                    Valor = table.Column<int>(nullable: false),
                    ConteudoId = table.Column<int>(nullable: true),
                    ConteudoDesenhoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_DrawingsContents_ConteudoDesenhoId",
                        column: x => x.ConteudoDesenhoId,
                        principalTable: "DrawingsContents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Options_Contents_ConteudoId",
                        column: x => x.ConteudoId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Texto = table.Column<string>(nullable: true),
                    Valor = table.Column<int>(nullable: false),
                    Marcado = table.Column<bool>(nullable: false),
                    ConteudoId = table.Column<int>(nullable: false),
                    OpcaoId = table.Column<int>(nullable: true),
                    RespondenteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Contents_ConteudoId",
                        column: x => x.ConteudoId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answers_Options_OpcaoId",
                        column: x => x.OpcaoId,
                        principalTable: "Options",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Answers_Respondents_RespondenteId",
                        column: x => x.RespondenteId,
                        principalTable: "Respondents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentsRestrictionsPage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nome = table.Column<string>(nullable: true),
                    RestricaoPaginaId = table.Column<int>(nullable: false),
                    ConteudoId = table.Column<int>(nullable: false),
                    OpcaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentsRestrictionsPage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContentsRestrictionsPage_Contents_ConteudoId",
                        column: x => x.ConteudoId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentsRestrictionsPage_Options_OpcaoId",
                        column: x => x.OpcaoId,
                        principalTable: "Options",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentsRestrictionsPage_PageRestrictions_RestricaoPaginaId",
                        column: x => x.RestricaoPaginaId,
                        principalTable: "PageRestrictions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Drawings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Tipo = table.Column<int>(nullable: false),
                    RespostaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drawings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drawings_Answers_RespostaId",
                        column: x => x.RespostaId,
                        principalTable: "Answers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coordinates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    DesenhoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coordinates_Drawings_DesenhoId",
                        column: x => x.DesenhoId,
                        principalTable: "Drawings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DrawingsAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Texto = table.Column<string>(nullable: true),
                    Valor = table.Column<int>(nullable: false),
                    Marcado = table.Column<bool>(nullable: false),
                    ConteudoDesenhoId = table.Column<int>(nullable: false),
                    OpcaoId = table.Column<int>(nullable: true),
                    DesenhoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrawingsAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrawingsAnswers_DrawingsContents_ConteudoDesenhoId",
                        column: x => x.ConteudoDesenhoId,
                        principalTable: "DrawingsContents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrawingsAnswers_Drawings_DesenhoId",
                        column: x => x.DesenhoId,
                        principalTable: "Drawings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrawingsAnswers_Options_OpcaoId",
                        column: x => x.OpcaoId,
                        principalTable: "Options",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnswerOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Valor = table.Column<int>(nullable: false),
                    RespostaId = table.Column<int>(nullable: true),
                    RespostaDesenhoId = table.Column<int>(nullable: true),
                    OpcaoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnswerOptions_Options_OpcaoId",
                        column: x => x.OpcaoId,
                        principalTable: "Options",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnswerOptions_DrawingsAnswers_RespostaDesenhoId",
                        column: x => x.RespostaDesenhoId,
                        principalTable: "DrawingsAnswers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnswerOptions_Answers_RespostaId",
                        column: x => x.RespostaId,
                        principalTable: "Answers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerOptions_OpcaoId",
                table: "AnswerOptions",
                column: "OpcaoId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerOptions_RespostaDesenhoId",
                table: "AnswerOptions",
                column: "RespostaDesenhoId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerOptions_RespostaId",
                table: "AnswerOptions",
                column: "RespostaId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_ConteudoId",
                table: "Answers",
                column: "ConteudoId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_OpcaoId",
                table: "Answers",
                column: "OpcaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_RespondenteId",
                table: "Answers",
                column: "RespondenteId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentRestrictions_ConteudoId",
                table: "ContentRestrictions",
                column: "ConteudoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_PaginaId",
                table: "Contents",
                column: "PaginaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentsRestrictionsPage_ConteudoId",
                table: "ContentsRestrictionsPage",
                column: "ConteudoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentsRestrictionsPage_OpcaoId",
                table: "ContentsRestrictionsPage",
                column: "OpcaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentsRestrictionsPage_RestricaoPaginaId",
                table: "ContentsRestrictionsPage",
                column: "RestricaoPaginaId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinates_DesenhoId",
                table: "Coordinates",
                column: "DesenhoId");

            migrationBuilder.CreateIndex(
                name: "IX_Drawings_RespostaId",
                table: "Drawings",
                column: "RespostaId");

            migrationBuilder.CreateIndex(
                name: "IX_DrawingsAnswers_ConteudoDesenhoId",
                table: "DrawingsAnswers",
                column: "ConteudoDesenhoId");

            migrationBuilder.CreateIndex(
                name: "IX_DrawingsAnswers_DesenhoId",
                table: "DrawingsAnswers",
                column: "DesenhoId");

            migrationBuilder.CreateIndex(
                name: "IX_DrawingsAnswers_OpcaoId",
                table: "DrawingsAnswers",
                column: "OpcaoId");

            migrationBuilder.CreateIndex(
                name: "IX_DrawingsContents_ConteudoId",
                table: "DrawingsContents",
                column: "ConteudoId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_ConteudoDesenhoId",
                table: "Options",
                column: "ConteudoDesenhoId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_ConteudoId",
                table: "Options",
                column: "ConteudoId");

            migrationBuilder.CreateIndex(
                name: "IX_PageRestrictions_PaginaId",
                table: "PageRestrictions",
                column: "PaginaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pages_FormularioId",
                table: "Pages",
                column: "FormularioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pages_ProximaPaginaId",
                table: "Pages",
                column: "ProximaPaginaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerOptions");

            migrationBuilder.DropTable(
                name: "ContentRestrictions");

            migrationBuilder.DropTable(
                name: "ContentsRestrictionsPage");

            migrationBuilder.DropTable(
                name: "Coordinates");

            migrationBuilder.DropTable(
                name: "DrawingsAnswers");

            migrationBuilder.DropTable(
                name: "PageRestrictions");

            migrationBuilder.DropTable(
                name: "Drawings");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Respondents");

            migrationBuilder.DropTable(
                name: "DrawingsContents");

            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "Forms");
        }
    }
}
