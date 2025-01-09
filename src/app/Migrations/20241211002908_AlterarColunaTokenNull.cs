using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace app.Migrations
{
    /// <inheritdoc />
    public partial class AlterarColunaTokenNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("460d1d59-bcec-4608-b65b-b9bad21993a0"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("4ebd9f8e-125b-4a06-a961-4ba3f5d38525"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("7117b8c7-dea0-452b-9cd3-6c0a19dccc8b"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("932bc69f-df62-4d30-8b9d-5bf66520a80f"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("a69daa42-7d7d-42ac-98d9-d6e681a700f4"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("c4816589-6bf7-4da6-afca-c70d2b05a90f"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("df7049fc-6b6f-4934-bfab-1a984d1ca801"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("f90c0219-8682-4cec-949f-8d154bffcdc7"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("fcf7d927-da4a-412a-88f7-a205e71fcd44"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("298e9c1e-1045-46f9-a43c-33f2db4d6081"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("5f544973-7cd4-493a-81c0-4cd0f3900cb9"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("6b32cc14-2ec2-4519-96e8-ee117148e316"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("79b105d9-dfc4-4c19-a307-9b22f61ed7c0"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("879ea38e-91ed-4605-8117-ed617c362791"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("00e918b1-4e98-43cd-908f-1f588e851830"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("696a30b8-aba8-484d-85f3-442d9c690ae5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("916f355e-bb09-4935-9362-f3ea120f5b03"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b552ed81-4ac1-4b99-911a-026e4ee6a5ca"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bc04f978-fca7-41d0-bb77-e838c7a51668"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("287a57bd-d799-40a8-a53b-7cdf0918c92b"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("3a67dbbd-8504-4707-8af7-6455689f5244"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("85eb2b2e-3b96-4bb0-81d2-4094635b02f2"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("a4ce91c3-4d92-413f-b588-70699337681b"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("aa9d0cb3-3eb9-40f0-b95a-5481fb4310d1"));

            migrationBuilder.DeleteData(
                table: "FontesDeEnergia",
                keyColumn: "Id",
                keyValue: new Guid("1085090d-be10-461d-bb01-a5557381cf62"));

            migrationBuilder.DeleteData(
                table: "FontesDeEnergia",
                keyColumn: "Id",
                keyValue: new Guid("2d6d5d12-f951-4509-8067-c6eb46c5d828"));

            migrationBuilder.DeleteData(
                table: "FontesDeEnergia",
                keyColumn: "Id",
                keyValue: new Guid("cd585e21-3a5c-42db-9b33-96f2ebbc6243"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("0b6f9e9b-8493-493a-82e9-6ccca0bb6a62"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("2a3afe25-f1e6-478c-be98-2cfa7ba00b7b"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("4dc48fd3-bb60-47b8-aeb3-3c11f5b346c5"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("67542890-1c72-4f60-8243-88f8389c5502"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("8e4ca77b-9dbb-419a-b189-b8abec84b933"));

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "CpfCnpj", "CreatedAt", "Nome", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("004a84c4-a3c5-497b-8050-bb8d797e78b3"), "56789012345", new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5580), "Pedro Costa", null },
                    { new Guid("2f31225a-874c-4386-9d9c-2b4f0dc792e4"), "45678901234", new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5580), "Ana Santos", null },
                    { new Guid("5e5b05de-4f2f-4c92-acaf-3bd044194c09"), "23456789012", new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5570), "Maria Oliveira", null },
                    { new Guid("a915718e-05bf-4c16-93b2-290c470b26cb"), "34567890123", new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5580), "Carlos Souza", null },
                    { new Guid("f5ef2702-b680-45e3-9474-7ff0150287c1"), "12345678901", new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5570), "João Silva", null }
                });

            migrationBuilder.InsertData(
                table: "Estados",
                columns: new[] { "Id", "CreatedAt", "Name", "Sigla", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2bb267b2-467a-428b-96c1-850b320b1dec"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5440), "Minas Gerais", "MG", null },
                    { new Guid("3b1b353e-22f6-4b2c-acef-c2b49b2e5e4d"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5450), "Bahia", "BA", null },
                    { new Guid("b89a67d6-9b23-40ef-a53e-4298beaa4172"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5450), "Paraná", "PR", null },
                    { new Guid("c25c7d74-0f11-48e6-93b2-6900ced2e3a7"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5430), "São Paulo", "SP", null },
                    { new Guid("dee95539-01d3-444f-a8bc-d912acf77701"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5440), "Rio de Janeiro", "RJ", null }
                });

            migrationBuilder.InsertData(
                table: "FontesDeEnergia",
                columns: new[] { "Id", "CreatedAt", "EficienciaMedia", "Tipo", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5a6da5e6-92c6-4b76-b4de-796e7adb89c9"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5610), null, "Solar", null },
                    { new Guid("9a7569a7-2d89-4676-bf98-e0a60731170e"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5620), null, "Biomassa", null },
                    { new Guid("b7e858f0-cb5c-47d5-903a-18de5d8d7533"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5620), null, "Eólica", null }
                });

            migrationBuilder.InsertData(
                table: "Permissoes",
                columns: new[] { "Id", "CreatedAt", "Nome", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01af61a1-1d90-4f2c-aac7-411d7afafa11"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5680), "Clientes", null },
                    { new Guid("2c554482-ba28-40a7-995c-fb386724465c"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5680), "Usinas", null },
                    { new Guid("42292c6a-fdc0-4ace-a5f7-879c47c7907f"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5700), "GruposPermissoes", null },
                    { new Guid("6a78caf9-d0f4-49b2-9c23-ac99ef9b43d2"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5700), "Usuarios", null },
                    { new Guid("6f725aaf-cb57-4714-842c-aad9c1fad2af"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5690), "ProducaoDeEnergia", null },
                    { new Guid("7bd6c62d-0ebd-4ae4-b5af-25ddd17099e3"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5690), "Estados", null },
                    { new Guid("d218c393-7e42-4e30-9587-8b9ab465ec3a"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5700), "Permissoes", null },
                    { new Guid("e3542ece-5682-43b7-a482-976c93ee4aab"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5680), "Cidades", null },
                    { new Guid("e50676d8-e31f-44b3-8617-2a109b98344a"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5690), "FontesDeEnergia", null }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "CreatedAt", "EstadoId", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("44aacd98-8fb5-4416-a32f-aec0535e32c7"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5520), new Guid("3b1b353e-22f6-4b2c-acef-c2b49b2e5e4d"), "Salvador", null },
                    { new Guid("45432663-7878-4c61-98e9-7bbf69fef4a5"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5520), new Guid("c25c7d74-0f11-48e6-93b2-6900ced2e3a7"), "Campinas", null },
                    { new Guid("7f3da876-cc3b-48ab-9338-83c2324c57d5"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5530), new Guid("b89a67d6-9b23-40ef-a53e-4298beaa4172"), "Curitiba", null },
                    { new Guid("9f68ee08-82b4-4b93-b879-99c7f52feac7"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5520), new Guid("2bb267b2-467a-428b-96c1-850b320b1dec"), "Uberlândia", null },
                    { new Guid("d23704a4-23d7-4629-80a2-13a888cc70dc"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5520), new Guid("dee95539-01d3-444f-a8bc-d912acf77701"), "Niterói", null }
                });

            migrationBuilder.InsertData(
                table: "Usinas",
                columns: new[] { "Id", "CapacidadeKW", "CidadeId", "ClienteId", "CreatedAt", "DataInicio", "Endereco", "FonteDeEnergiaId", "Nome", "StatusOperacional", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0e0fd4ac-ee1d-4e67-bed5-4c12af18a5c5"), 2000.0m, new Guid("7f3da876-cc3b-48ab-9338-83c2324c57d5"), new Guid("004a84c4-a3c5-497b-8050-bb8d797e78b3"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5860), new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua E, 654", new Guid("b7e858f0-cb5c-47d5-903a-18de5d8d7533"), "Usina Eólica PR", "Operando", null },
                    { new Guid("191d64b4-b1e5-4620-85bc-21664572cbd6"), 1500.0m, new Guid("d23704a4-23d7-4629-80a2-13a888cc70dc"), new Guid("5e5b05de-4f2f-4c92-acaf-3bd044194c09"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5840), new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua B, 456", new Guid("b7e858f0-cb5c-47d5-903a-18de5d8d7533"), "Usina Eólica RJ", "Operando", null },
                    { new Guid("250422c9-b82a-4f4c-9192-fc2200d6c982"), 800.0m, new Guid("9f68ee08-82b4-4b93-b879-99c7f52feac7"), new Guid("a915718e-05bf-4c16-93b2-290c470b26cb"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua C, 789", new Guid("9a7569a7-2d89-4676-bf98-e0a60731170e"), "Usina Biomassa MG", "Operando", null },
                    { new Guid("a047bb01-c13b-457d-8c75-e156b67e73a6"), 1200.0m, new Guid("44aacd98-8fb5-4416-a32f-aec0535e32c7"), new Guid("2f31225a-874c-4386-9d9c-2b4f0dc792e4"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua D, 321", new Guid("5a6da5e6-92c6-4b76-b4de-796e7adb89c9"), "Usina Solar BA", "Em Manutenção", null },
                    { new Guid("ad9c8864-8068-4cae-977f-aa5a1ff6aab5"), 1000.0m, new Guid("45432663-7878-4c61-98e9-7bbf69fef4a5"), new Guid("f5ef2702-b680-45e3-9474-7ff0150287c1"), new DateTime(2024, 12, 10, 21, 29, 8, 638, DateTimeKind.Local).AddTicks(5830), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua A, 123", new Guid("5a6da5e6-92c6-4b76-b4de-796e7adb89c9"), "Usina Solar SP", "Operando", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("01af61a1-1d90-4f2c-aac7-411d7afafa11"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("2c554482-ba28-40a7-995c-fb386724465c"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("42292c6a-fdc0-4ace-a5f7-879c47c7907f"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("6a78caf9-d0f4-49b2-9c23-ac99ef9b43d2"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("6f725aaf-cb57-4714-842c-aad9c1fad2af"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("7bd6c62d-0ebd-4ae4-b5af-25ddd17099e3"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("d218c393-7e42-4e30-9587-8b9ab465ec3a"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("e3542ece-5682-43b7-a482-976c93ee4aab"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("e50676d8-e31f-44b3-8617-2a109b98344a"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("0e0fd4ac-ee1d-4e67-bed5-4c12af18a5c5"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("191d64b4-b1e5-4620-85bc-21664572cbd6"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("250422c9-b82a-4f4c-9192-fc2200d6c982"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("a047bb01-c13b-457d-8c75-e156b67e73a6"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("ad9c8864-8068-4cae-977f-aa5a1ff6aab5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("44aacd98-8fb5-4416-a32f-aec0535e32c7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("45432663-7878-4c61-98e9-7bbf69fef4a5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7f3da876-cc3b-48ab-9338-83c2324c57d5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9f68ee08-82b4-4b93-b879-99c7f52feac7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d23704a4-23d7-4629-80a2-13a888cc70dc"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("004a84c4-a3c5-497b-8050-bb8d797e78b3"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("2f31225a-874c-4386-9d9c-2b4f0dc792e4"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("5e5b05de-4f2f-4c92-acaf-3bd044194c09"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("a915718e-05bf-4c16-93b2-290c470b26cb"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("f5ef2702-b680-45e3-9474-7ff0150287c1"));

            migrationBuilder.DeleteData(
                table: "FontesDeEnergia",
                keyColumn: "Id",
                keyValue: new Guid("5a6da5e6-92c6-4b76-b4de-796e7adb89c9"));

            migrationBuilder.DeleteData(
                table: "FontesDeEnergia",
                keyColumn: "Id",
                keyValue: new Guid("9a7569a7-2d89-4676-bf98-e0a60731170e"));

            migrationBuilder.DeleteData(
                table: "FontesDeEnergia",
                keyColumn: "Id",
                keyValue: new Guid("b7e858f0-cb5c-47d5-903a-18de5d8d7533"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("2bb267b2-467a-428b-96c1-850b320b1dec"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("3b1b353e-22f6-4b2c-acef-c2b49b2e5e4d"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("b89a67d6-9b23-40ef-a53e-4298beaa4172"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("c25c7d74-0f11-48e6-93b2-6900ced2e3a7"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("dee95539-01d3-444f-a8bc-d912acf77701"));

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
