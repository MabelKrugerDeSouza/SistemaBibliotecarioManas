using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaBibliotecarioManas.Infra.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LIVROS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeLivro = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NomeAutor = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Editora = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Paginas = table.Column<int>(type: "int", nullable: false),
                    Idioma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DataPublicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deletado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIVROS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PESSOAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePessoa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CPF = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    Data_Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefone = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    Pessoa_Rua = table.Column<string>(type: "varchar(80)", nullable: true),
                    Pessoa_Bairro = table.Column<string>(type: "varchar(50)", nullable: true),
                    Pessoa_Cidade = table.Column<string>(type: "varchar(40)", nullable: true),
                    Pessoa_CEP = table.Column<string>(type: "varchar(8)", nullable: true),
                    Pessoa_Numero = table.Column<string>(type: "varchar(6)", nullable: true),
                    Pessoa_Complemento = table.Column<string>(type: "varchar(70)", nullable: true),
                    Pessoa_UF = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Deletado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PESSOAS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "USUARIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeUsuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Deletado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LIVROS");

            migrationBuilder.DropTable(
                name: "PESSOAS");

            migrationBuilder.DropTable(
                name: "USUARIOS");
        }
    }
}
