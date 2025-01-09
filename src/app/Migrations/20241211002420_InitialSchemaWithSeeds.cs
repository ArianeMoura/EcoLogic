using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace app.Migrations
{
    /// <inheritdoc />
    public partial class InitialSchemaWithSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CpfCnpj = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sigla = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FontesDeEnergia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EficienciaMedia = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FontesDeEnergia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GruposPermissoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GruposPermissoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EstadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cidades_Estados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermissoesGruposPermissoes",
                columns: table => new
                {
                    GruposPermissoesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissoesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissoesGruposPermissoes", x => new { x.GruposPermissoesId, x.PermissoesId });
                    table.ForeignKey(
                        name: "FK_PermissoesGruposPermissoes_GruposPermissoes_GruposPermissoesId",
                        column: x => x.GruposPermissoesId,
                        principalTable: "GruposPermissoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissoesGruposPermissoes_Permissoes_PermissoesId",
                        column: x => x.PermissoesId,
                        principalTable: "Permissoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosGruposPermissoes",
                columns: table => new
                {
                    GruposPermissoesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuariosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosGruposPermissoes", x => new { x.GruposPermissoesId, x.UsuariosId });
                    table.ForeignKey(
                        name: "FK_UsuariosGruposPermissoes_GruposPermissoes_GruposPermissoesId",
                        column: x => x.GruposPermissoesId,
                        principalTable: "GruposPermissoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuariosGruposPermissoes_Usuarios_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usinas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CapacidadeKW = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusOperacional = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CidadeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FonteDeEnergiaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usinas_Cidades_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usinas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usinas_FontesDeEnergia_FonteDeEnergiaId",
                        column: x => x.FonteDeEnergiaId,
                        principalTable: "FontesDeEnergia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProducoesDeEnergia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsinaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataProducao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnergiaGeradaKW = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    EficienciaOperacional = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProducoesDeEnergia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProducoesDeEnergia_Usinas_UsinaId",
                        column: x => x.UsinaId,
                        principalTable: "Usinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "CpfCnpj", "CreatedAt", "Nome", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("287a57bd-d799-40a8-a53b-7cdf0918c92b"), "34567890123", new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(1890), "Carlos Souza", null },
                    { new Guid("3a67dbbd-8504-4707-8af7-6455689f5244"), "12345678901", new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(1880), "João Silva", null },
                    { new Guid("85eb2b2e-3b96-4bb0-81d2-4094635b02f2"), "45678901234", new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(1900), "Ana Santos", null },
                    { new Guid("a4ce91c3-4d92-413f-b588-70699337681b"), "56789012345", new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(1900), "Pedro Costa", null },
                    { new Guid("aa9d0cb3-3eb9-40f0-b95a-5481fb4310d1"), "23456789012", new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(1890), "Maria Oliveira", null }
                });

            migrationBuilder.InsertData(
                table: "Estados",
                columns: new[] { "Id", "CreatedAt", "Name", "Sigla", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0b6f9e9b-8493-493a-82e9-6ccca0bb6a62"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(1660), "Rio de Janeiro", "RJ", null },
                    { new Guid("2a3afe25-f1e6-478c-be98-2cfa7ba00b7b"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(1670), "Paraná", "PR", null },
                    { new Guid("4dc48fd3-bb60-47b8-aeb3-3c11f5b346c5"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(1670), "Bahia", "BA", null },
                    { new Guid("67542890-1c72-4f60-8243-88f8389c5502"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(1670), "Minas Gerais", "MG", null },
                    { new Guid("8e4ca77b-9dbb-419a-b189-b8abec84b933"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(1660), "São Paulo", "SP", null }
                });

            migrationBuilder.InsertData(
                table: "FontesDeEnergia",
                columns: new[] { "Id", "CreatedAt", "EficienciaMedia", "Tipo", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1085090d-be10-461d-bb01-a5557381cf62"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(1950), null, "Biomassa", null },
                    { new Guid("2d6d5d12-f951-4509-8067-c6eb46c5d828"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(1950), null, "Eólica", null },
                    { new Guid("cd585e21-3a5c-42db-9b33-96f2ebbc6243"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(1940), null, "Solar", null }
                });

            migrationBuilder.InsertData(
                table: "Permissoes",
                columns: new[] { "Id", "CreatedAt", "Nome", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("460d1d59-bcec-4608-b65b-b9bad21993a0"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(2010), "Cidades", null },
                    { new Guid("4ebd9f8e-125b-4a06-a961-4ba3f5d38525"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(2000), "Usinas", null },
                    { new Guid("7117b8c7-dea0-452b-9cd3-6c0a19dccc8b"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(2020), "ProducaoDeEnergia", null },
                    { new Guid("932bc69f-df62-4d30-8b9d-5bf66520a80f"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(2030), "GruposPermissoes", null },
                    { new Guid("a69daa42-7d7d-42ac-98d9-d6e681a700f4"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(2010), "Estados", null },
                    { new Guid("c4816589-6bf7-4da6-afca-c70d2b05a90f"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(2020), "FontesDeEnergia", null },
                    { new Guid("df7049fc-6b6f-4934-bfab-1a984d1ca801"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(2030), "Permissoes", null },
                    { new Guid("f90c0219-8682-4cec-949f-8d154bffcdc7"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(2020), "Usuarios", null },
                    { new Guid("fcf7d927-da4a-412a-88f7-a205e71fcd44"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(2010), "Clientes", null }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "CreatedAt", "EstadoId", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00e918b1-4e98-43cd-908f-1f588e851830"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(1780), new Guid("4dc48fd3-bb60-47b8-aeb3-3c11f5b346c5"), "Salvador", null },
                    { new Guid("696a30b8-aba8-484d-85f3-442d9c690ae5"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(1770), new Guid("8e4ca77b-9dbb-419a-b189-b8abec84b933"), "Campinas", null },
                    { new Guid("916f355e-bb09-4935-9362-f3ea120f5b03"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(1770), new Guid("67542890-1c72-4f60-8243-88f8389c5502"), "Uberlândia", null },
                    { new Guid("b552ed81-4ac1-4b99-911a-026e4ee6a5ca"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(1770), new Guid("0b6f9e9b-8493-493a-82e9-6ccca0bb6a62"), "Niterói", null },
                    { new Guid("bc04f978-fca7-41d0-bb77-e838c7a51668"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(1780), new Guid("2a3afe25-f1e6-478c-be98-2cfa7ba00b7b"), "Curitiba", null }
                });

            migrationBuilder.InsertData(
                table: "Usinas",
                columns: new[] { "Id", "CapacidadeKW", "CidadeId", "ClienteId", "CreatedAt", "DataInicio", "Endereco", "FonteDeEnergiaId", "Nome", "StatusOperacional", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("298e9c1e-1045-46f9-a43c-33f2db4d6081"), 1500.0m, new Guid("b552ed81-4ac1-4b99-911a-026e4ee6a5ca"), new Guid("aa9d0cb3-3eb9-40f0-b95a-5481fb4310d1"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(2210), new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua B, 456", new Guid("2d6d5d12-f951-4509-8067-c6eb46c5d828"), "Usina Eólica RJ", "Operando", null },
                    { new Guid("5f544973-7cd4-493a-81c0-4cd0f3900cb9"), 800.0m, new Guid("916f355e-bb09-4935-9362-f3ea120f5b03"), new Guid("287a57bd-d799-40a8-a53b-7cdf0918c92b"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(2220), new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua C, 789", new Guid("1085090d-be10-461d-bb01-a5557381cf62"), "Usina Biomassa MG", "Operando", null },
                    { new Guid("6b32cc14-2ec2-4519-96e8-ee117148e316"), 1000.0m, new Guid("696a30b8-aba8-484d-85f3-442d9c690ae5"), new Guid("3a67dbbd-8504-4707-8af7-6455689f5244"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(2200), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua A, 123", new Guid("cd585e21-3a5c-42db-9b33-96f2ebbc6243"), "Usina Solar SP", "Operando", null },
                    { new Guid("79b105d9-dfc4-4c19-a307-9b22f61ed7c0"), 1200.0m, new Guid("00e918b1-4e98-43cd-908f-1f588e851830"), new Guid("85eb2b2e-3b96-4bb0-81d2-4094635b02f2"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(2220), new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua D, 321", new Guid("cd585e21-3a5c-42db-9b33-96f2ebbc6243"), "Usina Solar BA", "Em Manutenção", null },
                    { new Guid("879ea38e-91ed-4605-8117-ed617c362791"), 2000.0m, new Guid("bc04f978-fca7-41d0-bb77-e838c7a51668"), new Guid("a4ce91c3-4d92-413f-b588-70699337681b"), new DateTime(2024, 12, 10, 21, 24, 19, 779, DateTimeKind.Local).AddTicks(2230), new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua E, 654", new Guid("2d6d5d12-f951-4509-8067-c6eb46c5d828"), "Usina Eólica PR", "Operando", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cidades_EstadoId",
                table: "Cidades",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CpfCnpj",
                table: "Clientes",
                column: "CpfCnpj",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PermissoesGruposPermissoes_PermissoesId",
                table: "PermissoesGruposPermissoes",
                column: "PermissoesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProducoesDeEnergia_UsinaId",
                table: "ProducoesDeEnergia",
                column: "UsinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usinas_CidadeId",
                table: "Usinas",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Usinas_ClienteId",
                table: "Usinas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Usinas_FonteDeEnergiaId",
                table: "Usinas",
                column: "FonteDeEnergiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ClienteId",
                table: "Usuarios",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosGruposPermissoes_UsuariosId",
                table: "UsuariosGruposPermissoes",
                column: "UsuariosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PermissoesGruposPermissoes");

            migrationBuilder.DropTable(
                name: "ProducoesDeEnergia");

            migrationBuilder.DropTable(
                name: "UsuariosGruposPermissoes");

            migrationBuilder.DropTable(
                name: "Permissoes");

            migrationBuilder.DropTable(
                name: "Usinas");

            migrationBuilder.DropTable(
                name: "GruposPermissoes");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "FontesDeEnergia");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Estados");
        }
    }
}
