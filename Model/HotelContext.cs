using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BD_VOLVO
{
    public class HotelContext : DbContext
    {
        // Tabelas do banco de dados
        public DbSet<Funcionario> Funcionarios { get; set; } = null!;
        public DbSet<TipoQuarto> TipoQuartos { get; set; } = null!;
        public DbSet<Reserva> Reservas { get; set; } = null!;
        public DbSet<Quarto> Quartos { get; set; } = null!;
        public DbSet<ClienteConta> ClienteContas { get; set; } = null!;
        public DbSet<Telefone> Telefones { get; set; } = null!;
        public DbSet<ClienteReserva> ClienteReservas { get; set; } = null!;
        public DbSet<Pagamento> Pagamentos { get; set; } = null!;
        public DbSet<Efetua> Efetua { get; set; } = null!;
        public DbSet<Filial> Filiais { get; set; } = null!;
        public DbSet<Servicos> Servicos { get; set; } = null!;
        public DbSet<Restaurante> Restaurantes { get; set; } = null!;
        public DbSet<Frigobar> Frigobares { get; set; } = null!;
        public DbSet<Consumo> Consumos { get; set; } = null!;

        // Configuração do contexto
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=HotelORM;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClienteConta>()
                .HasKey(c => new { c.IdCliente, c.IdConta });

            modelBuilder.Entity<ClienteReserva>()
                .HasKey(c => new { c.FkIdCliente, c.FkIdConta, c.fkReservaIdReserva });

            modelBuilder.Entity<Efetua>()
                .HasKey(e => new { e.fkClienteContaIdCliente, e.fkClienteContaIdConta, e.fkPagamentoIdPagamento });
        }
    }
}