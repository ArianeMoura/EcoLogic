using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Data;
using app.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace app.Database
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Usina> Usinas { get; set; }
        public DbSet<FonteDeEnergia> FontesDeEnergia { get; set; }
        public DbSet<ProducaoDeEnergia> ProducoesDeEnergia { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Permissao> Permissoes { get; set; }
        public DbSet<GrupoPermissao> GruposPermissoes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // Configuring many-to-many relationships
            
            modelBuilder.Entity<GrupoPermissao>()
                .HasMany(g => g.Permissoes)
                .WithMany(p => p.GruposPermissoes)
                .UsingEntity(j => j.ToTable("PermissoesGruposPermissoes"));

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.GruposPermissoes)
                .WithMany(g => g.Usuarios)
                .UsingEntity(j => j.ToTable("UsuariosGruposPermissoes"));

            // Defining unique constraints and configurations
            modelBuilder.Entity<Cliente>()
                .HasIndex(c => c.CpfCnpj)
                .IsUnique();

            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.Email)
                .IsUnique();

            SeedData.Initialize(modelBuilder);

        }
    }
}
