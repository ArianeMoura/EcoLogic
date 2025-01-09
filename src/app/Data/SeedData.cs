using Microsoft.EntityFrameworkCore;
using app.Models.Entities;
using System;
using System.Collections.Generic;

namespace app.Data
{
    public static class SeedData
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            // Seed Estados with fixed IDs
            var estadoSP = Guid.NewGuid();
            var estadoRJ = Guid.NewGuid();
            var estadoMG = Guid.NewGuid();
            var estadoBA = Guid.NewGuid();
            var estadoPR = Guid.NewGuid();
            
            var estados = new List<Estado>
            {
                new() { Id = estadoSP, Name = "São Paulo", Sigla = "SP", CreatedAt = DateTime.Now },
                new() { Id = estadoRJ, Name = "Rio de Janeiro", Sigla = "RJ", CreatedAt = DateTime.Now },
                new() { Id = estadoMG, Name = "Minas Gerais", Sigla = "MG", CreatedAt = DateTime.Now },
                new() { Id = estadoBA, Name = "Bahia", Sigla = "BA", CreatedAt = DateTime.Now },
                new() { Id = estadoPR, Name = "Paraná", Sigla = "PR", CreatedAt = DateTime.Now }
            };
            modelBuilder.Entity<Estado>().HasData(estados);

            var cidadeCampinas = Guid.NewGuid();
            var cidadeNiteroi = Guid.NewGuid();
            var cidadeUberlandia = Guid.NewGuid();
            var cidadeSalvador = Guid.NewGuid();
            var cidadeCuritiba = Guid.NewGuid();

            // Seed Cidades using EstadoId instead of Estado navigation property
            var cidades = new List<Cidade>
            {   
                new() { Id = cidadeCampinas, Name = "Campinas", EstadoId = estadoSP, CreatedAt = DateTime.Now },
                new() { Id = cidadeNiteroi, Name = "Niterói", EstadoId = estadoRJ, CreatedAt = DateTime.Now },
                new() { Id = cidadeUberlandia, Name = "Uberlândia", EstadoId = estadoMG, CreatedAt = DateTime.Now },
                new() { Id = cidadeSalvador, Name = "Salvador", EstadoId = estadoBA, CreatedAt = DateTime.Now },
                new() { Id = cidadeCuritiba, Name = "Curitiba", EstadoId = estadoPR, CreatedAt = DateTime.Now }
            };
            modelBuilder.Entity<Cidade>().HasData(cidades);


            
            // Seed Clientes with fixed IDs
            var clienteJoao = Guid.NewGuid();
            var clienteMaria = Guid.NewGuid();
            var clienteCarlos = Guid.NewGuid();
            var clienteAna = Guid.NewGuid();
            var clientePedro = Guid.NewGuid();

            var clientes = new List<Cliente>
            {
                new() { Id = clienteJoao, Nome = "João Silva", CpfCnpj = "12345678901", CreatedAt = DateTime.Now },
                new() { Id = clienteMaria, Nome = "Maria Oliveira", CpfCnpj = "23456789012", CreatedAt = DateTime.Now },
                new() { Id = clienteCarlos, Nome = "Carlos Souza", CpfCnpj = "34567890123", CreatedAt = DateTime.Now },
                new() { Id = clienteAna, Nome = "Ana Santos", CpfCnpj = "45678901234", CreatedAt = DateTime.Now },
                new() { Id = clientePedro, Nome = "Pedro Costa", CpfCnpj = "56789012345", CreatedAt = DateTime.Now }
            };
            modelBuilder.Entity<Cliente>().HasData(clientes);

            // Seed FonteDeEnergia with fixed IDs
            var fonteSolar = Guid.NewGuid();
            var fonteEolica = Guid.NewGuid();
            var fonteBiomassa = Guid.NewGuid();

            var fontesDeEnergia = new List<FonteDeEnergia>
            {
                new() { Id = fonteSolar, Tipo = "Solar", CreatedAt = DateTime.Now },
                new() { Id = fonteEolica, Tipo = "Eólica", CreatedAt = DateTime.Now },
                new() { Id = fonteBiomassa, Tipo = "Biomassa", CreatedAt = DateTime.Now }
            };
            modelBuilder.Entity<FonteDeEnergia>().HasData(fontesDeEnergia);

            // Seed Permissoes with fixed IDs
            var permUsinas = Guid.NewGuid();
            var permClientes = Guid.NewGuid();
            var permCidades = Guid.NewGuid();
            var permEstados = Guid.NewGuid();
            var permFontes = Guid.NewGuid();
            var permProducao = Guid.NewGuid();
            var permUsuarios = Guid.NewGuid();
            var permGrupos = Guid.NewGuid();
            var permPermissoes = Guid.NewGuid();

            var permissoes = new List<Permissao>
            {
                new() { Id = permUsinas, Nome = "Usinas", CreatedAt = DateTime.Now },
                new() { Id = permClientes, Nome = "Clientes", CreatedAt = DateTime.Now },
                new() { Id = permCidades, Nome = "Cidades", CreatedAt = DateTime.Now },
                new() { Id = permEstados, Nome = "Estados", CreatedAt = DateTime.Now },
                new() { Id = permFontes, Nome = "FontesDeEnergia", CreatedAt = DateTime.Now },
                new() { Id = permProducao, Nome = "ProducaoDeEnergia", CreatedAt = DateTime.Now },
                new() { Id = permUsuarios, Nome = "Usuarios", CreatedAt = DateTime.Now },
                new() { Id = permGrupos, Nome = "GruposPermissoes", CreatedAt = DateTime.Now },
                new() { Id = permPermissoes, Nome = "Permissoes", CreatedAt = DateTime.Now }
            };
            modelBuilder.Entity<Permissao>().HasData(permissoes);

            

            // Seed Usinas with fixed IDs
            var usinaSolarSP = Guid.NewGuid();
            var usinaEolicaRJ = Guid.NewGuid();
            var usinaBiomassaMG = Guid.NewGuid();
            var usinaSolarBA = Guid.NewGuid();
            var usinaEolicaPR = Guid.NewGuid();

            var usinas = new List<Usina>
            {
                new() { 
                    Id = usinaSolarSP, 
                    Nome = "Usina Solar SP", 
                    CapacidadeKW = 1000.0M, 
                    DataInicio = DateTime.Parse("2022-01-01"), 
                    StatusOperacional = "Operando", 
                    Endereco = "Rua A, 123", 
                    ClienteId = clienteJoao, 
                    CidadeId = cidadeCampinas, 
                    FonteDeEnergiaId = fonteSolar, 
                    CreatedAt = DateTime.Now 
                },
                new() { 
                    Id = usinaEolicaRJ, 
                    Nome = "Usina Eólica RJ", 
                    CapacidadeKW = 1500.0M, 
                    DataInicio = DateTime.Parse("2022-02-01"), 
                    StatusOperacional = "Operando", 
                    Endereco = "Rua B, 456", 
                    ClienteId = clienteMaria, 
                    CidadeId = cidadeNiteroi, 
                    FonteDeEnergiaId = fonteEolica, 
                    CreatedAt = DateTime.Now 
                },
                new() { 
                    Id = usinaBiomassaMG, 
                    Nome = "Usina Biomassa MG", 
                    CapacidadeKW = 800.0M, 
                    DataInicio = DateTime.Parse("2022-03-01"), 
                    StatusOperacional = "Operando", 
                    Endereco = "Rua C, 789", 
                    ClienteId = clienteCarlos, 
                    CidadeId = cidadeUberlandia, 
                    FonteDeEnergiaId = fonteBiomassa, 
                    CreatedAt = DateTime.Now 
                },
                new() { 
                    Id = usinaSolarBA, 
                    Nome = "Usina Solar BA", 
                    CapacidadeKW = 1200.0M, 
                    DataInicio = DateTime.Parse("2022-04-01"), 
                    StatusOperacional = "Em Manutenção", 
                    Endereco = "Rua D, 321", 
                    ClienteId = clienteAna, 
                    CidadeId = cidadeSalvador, 
                    FonteDeEnergiaId = fonteSolar, 
                    CreatedAt = DateTime.Now 
                },
                new() { 
                    Id = usinaEolicaPR, 
                    Nome = "Usina Eólica PR", 
                    CapacidadeKW = 2000.0M, 
                    DataInicio = DateTime.Parse("2022-05-01"), 
                    StatusOperacional = "Operando", 
                    Endereco = "Rua E, 654", 
                    ClienteId = clientePedro, 
                    CidadeId = cidadeCuritiba, 
                    FonteDeEnergiaId = fonteEolica, 
                    CreatedAt = DateTime.Now 
                }
            };
            modelBuilder.Entity<Usina>().HasData(usinas);

            

            // Repeat similar steps for FonteDeEnergia, Usinas, GrupoPermissao, Permissao, and Usuarios entities
            // Assign fixed IDs for related entities and reference foreign key IDs explicitly.
            // Example for Usinas (using ClienteId and CidadeId):
            
           
            
            // Apply similar corrections to the remaining entities, using explicit IDs.

            // Seed GrupoPermissao with fixed IDs
            // var grupoAdmin = Guid.NewGuid();
            // var grupoOperador = Guid.NewGuid();
            // var grupoVisualizador = Guid.NewGuid();

            // var gruposPermissoes = new List<GrupoPermissao>
            // {
            //     new() { Id = grupoAdmin, Nome = "Administrador", CreatedAt = DateTime.Now },
            //     new() { Id = grupoOperador, Nome = "Operador", CreatedAt = DateTime.Now },
            //     new() { Id = grupoVisualizador, Nome = "Visualizador", CreatedAt = DateTime.Now }
            // };
            // modelBuilder.Entity<GrupoPermissao>().HasData(gruposPermissoes);

            // // Seed Usuarios
            // var adminUser = Guid.NewGuid();
            // var operadorUser = Guid.NewGuid();

            // // Replace the Dictionary-based seeding with proper entity seeding
            // var usuarioGrupoPermissoes = new List<UsuarioGrupoPermissao>
            // {
            //     new() { UsuarioId = adminUser, GrupoPermissaoId = grupoAdmin },
            //     new() { UsuarioId = operadorUser, GrupoPermissaoId = grupoOperador }
            // };
            // modelBuilder.Entity<UsuarioGrupoPermissao>().HasData(usuarioGrupoPermissoes);

            // // Similarly, replace the GrupoPermissaoPermissao seeding
            // var grupoPermissaoPermissoes = new List<GrupoPermissaoPermissao>
            // {
            //     // Admin permissions
            //     new() { 
            //         GrupoPermissaoId = grupoAdmin, 
            //         PermissaoId = permUsinas, 
            //         GrupoPermissao = new GrupoPermissao { Id = grupoAdmin, Nome = "Administrador", CreatedAt = DateTime.Now } 
            //     },
            //     new() { 
            //         GrupoPermissaoId = grupoAdmin, 
            //         PermissaoId = permClientes, 
            //         GrupoPermissao = new GrupoPermissao { Id = grupoAdmin, Nome = "Administrador", CreatedAt = DateTime.Now } 
            //     },
            //     new() { 
            //         GrupoPermissaoId = grupoAdmin, 
            //         PermissaoId = permCidades, 
            //         GrupoPermissao = new GrupoPermissao { Id = grupoAdmin, Nome = "Administrador", CreatedAt = DateTime.Now } 
            //     },
            //     new() { 
            //         GrupoPermissaoId = grupoAdmin, 
            //         PermissaoId = permGrupos, 
            //         GrupoPermissao = new GrupoPermissao { Id = grupoAdmin, Nome = "Administrador", CreatedAt = DateTime.Now } 
            //     },
            //     new() { 
            //         GrupoPermissaoId = grupoAdmin, 
            //         PermissaoId = permPermissoes, 
            //         GrupoPermissao = new GrupoPermissao { Id = grupoAdmin, Nome = "Administrador", CreatedAt = DateTime.Now } 
            //     },
                
            //     // Operator permissions
            //     new() { 
            //         GrupoPermissaoId = grupoOperador, 
            //         PermissaoId = permUsinas, 
            //         GrupoPermissao = new GrupoPermissao { Id = grupoOperador, Nome = "Operador", CreatedAt = DateTime.Now } 
            //     },
            //     new() { 
            //         GrupoPermissaoId = grupoOperador, 
            //         PermissaoId = permProducao, 
            //         GrupoPermissao = new GrupoPermissao { Id = grupoOperador, Nome = "Operador", CreatedAt = DateTime.Now } 
            //     },
                
            //     // Viewer permissions
            //     new() { 
            //         GrupoPermissaoId = grupoVisualizador, 
            //         PermissaoId = permUsinas, 
            //         GrupoPermissao = new GrupoPermissao { Id = grupoVisualizador, Nome = "Visualizador", CreatedAt = DateTime.Now } 
            //     }
            // };
            // modelBuilder.Entity<GrupoPermissaoPermissao>().HasData(grupoPermissaoPermissoes);

            

            // var usuarios = new List<Usuario>
            // {
            //     new() { 
            //         Id = adminUser, 
            //         Nome = "Admin Sistema", 
            //         Email = "admin@sistema.com", 
            //         Password = "hashed_password_here",
            //         ClienteId = clienteJoao,
            //         CreatedAt = DateTime.Now 
            //     },
            //     new() { 
            //         Id = operadorUser, 
            //         Nome = "Operador Principal", 
            //         Email = "operador@sistema.com", 
            //         Password = "hashed_password_here",
            //         ClienteId = clienteMaria,
            //         CreatedAt = DateTime.Now 
            //     }
            // };
            // modelBuilder.Entity<Usuario>().HasData(usuarios);

            // // Seed ProducaoDeEnergia
            // var producoesEnergia = new List<ProducaoDeEnergia>
            // {
            //     new() {
            //         Id = Guid.NewGuid(),
            //         UsinaId = usinaSolarSP,
            //         DataProducao = DateTime.Parse("2024-01-15"),
            //         EnergiaGeradaKW = 850.50M,
            //         EficienciaOperacional = 85.5M,
            //         CreatedAt = DateTime.Now
            //     },
            //     new() {
            //         Id = Guid.NewGuid(),
            //         UsinaId = usinaEolicaRJ,
            //         DataProducao = DateTime.Parse("2024-01-15"),
            //         EnergiaGeradaKW = 1250.75M,
            //         EficienciaOperacional = 90.2M,
            //         CreatedAt = DateTime.Now
            //     },
            //     new() {
            //         Id = Guid.NewGuid(),
            //         UsinaId = usinaBiomassaMG,
            //         DataProducao = DateTime.Parse("2024-01-15"),
            //         EnergiaGeradaKW = 650.25M,
            //         EficienciaOperacional = 78.8M,
            //         CreatedAt = DateTime.Now
            //     }
            // };
            // modelBuilder.Entity<ProducaoDeEnergia>().HasData(producoesEnergia);

        }
    }
}
