﻿// <auto-generated />
using System;
using BD_VOLVO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BD_VOLVO.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20240127150058_UpdateContext")]
    partial class UpdateContext
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BD_VOLVO.ClienteConta", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<int>("IdConta")
                        .HasColumnType("int");

                    b.Property<string>("CEPCliente")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("EmailCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NacionalidadeCliente")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RuaCliente")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdCliente", "IdConta");

                    b.ToTable("ClienteContas");
                });

            modelBuilder.Entity("BD_VOLVO.ClienteReserva", b =>
                {
                    b.Property<int>("FkIdCliente")
                        .HasColumnType("int");

                    b.Property<int>("FkIdConta")
                        .HasColumnType("int");

                    b.Property<int>("fkReservaIdReserva")
                        .HasColumnType("int");

                    b.HasKey("FkIdCliente", "FkIdConta", "fkReservaIdReserva");

                    b.HasIndex("fkReservaIdReserva");

                    b.ToTable("ClienteReservas");
                });

            modelBuilder.Entity("BD_VOLVO.Consumo", b =>
                {
                    b.Property<int>("IdConsumo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdConsumo"));

                    b.Property<int>("fkClienteContaIdCliente")
                        .HasColumnType("int");

                    b.Property<int>("fkClienteContaIdConta")
                        .HasColumnType("int");

                    b.Property<int?>("fkFrigobar")
                        .HasColumnType("int");

                    b.Property<int?>("fkRestaurante")
                        .HasColumnType("int");

                    b.Property<int?>("fkServico")
                        .HasColumnType("int");

                    b.HasKey("IdConsumo");

                    b.HasIndex("fkFrigobar");

                    b.HasIndex("fkRestaurante");

                    b.HasIndex("fkServico");

                    b.HasIndex("fkClienteContaIdCliente", "fkClienteContaIdConta");

                    b.ToTable("Consumos");
                });

            modelBuilder.Entity("BD_VOLVO.Efetua", b =>
                {
                    b.Property<int>("fkClienteContaIdCliente")
                        .HasColumnType("int");

                    b.Property<int>("fkClienteContaIdConta")
                        .HasColumnType("int");

                    b.Property<int>("fkPagamentoIdPagamento")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("datetime2");

                    b.HasKey("fkClienteContaIdCliente", "fkClienteContaIdConta", "fkPagamentoIdPagamento");

                    b.HasIndex("fkPagamentoIdPagamento");

                    b.ToTable("Efetua");
                });

            modelBuilder.Entity("BD_VOLVO.Filial", b =>
                {
                    b.Property<int>("IdFilial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFilial"));

                    b.Property<string>("CEPFilial")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("NumeroQuartos")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeEstrelas")
                        .HasColumnType("int");

                    b.Property<string>("RuaFilial")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdFilial");

                    b.ToTable("Filiais");
                });

            modelBuilder.Entity("BD_VOLVO.Frigobar", b =>
                {
                    b.Property<int>("IdFrigobar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFrigobar"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.Property<int>("fkFrigobarIdFilial")
                        .HasColumnType("int");

                    b.HasKey("IdFrigobar");

                    b.HasIndex("fkFrigobarIdFilial");

                    b.ToTable("Frigobares");
                });

            modelBuilder.Entity("BD_VOLVO.Funcionario", b =>
                {
                    b.Property<int>("IdFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFuncionario"));

                    b.Property<string>("TipoFuncionario")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdFuncionario");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("BD_VOLVO.Pagamento", b =>
                {
                    b.Property<int>("IdPagamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPagamento"));

                    b.Property<string>("TipoPagamento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdPagamento");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("BD_VOLVO.Quarto", b =>
                {
                    b.Property<int>("IdQuarto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdQuarto"));

                    b.Property<bool>("SituacaoQuarto")
                        .HasColumnType("bit");

                    b.Property<int?>("fkIdFilial")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("fkReservaIdReserva")
                        .HasColumnType("int");

                    b.Property<int>("fkTipoQuarto")
                        .HasColumnType("int");

                    b.HasKey("IdQuarto");

                    b.HasIndex("fkIdFilial");

                    b.HasIndex("fkReservaIdReserva");

                    b.HasIndex("fkTipoQuarto");

                    b.ToTable("Quartos");
                });

            modelBuilder.Entity("BD_VOLVO.Reserva", b =>
                {
                    b.Property<int>("IdReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReserva"));

                    b.Property<float>("CobrancaDiaria")
                        .HasColumnType("real");

                    b.Property<DateTime>("DTCheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DTCheckOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataCancelamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("EstadoReserva")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("fkFuncionarioIdFuncionario")
                        .HasColumnType("int");

                    b.Property<int>("fkTipoQuarto")
                        .HasColumnType("int");

                    b.HasKey("IdReserva");

                    b.HasIndex("fkFuncionarioIdFuncionario");

                    b.HasIndex("fkTipoQuarto");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("BD_VOLVO.Restaurante", b =>
                {
                    b.Property<int>("IdRestaurante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRestaurante"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LocalConsumo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.Property<int>("fkRestauranteIdFilial")
                        .HasColumnType("int");

                    b.HasKey("IdRestaurante");

                    b.HasIndex("fkRestauranteIdFilial");

                    b.ToTable("Restaurantes");
                });

            modelBuilder.Entity("BD_VOLVO.Servicos", b =>
                {
                    b.Property<int>("IdServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdServico"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.Property<int>("fkServicoIdFilial")
                        .HasColumnType("int");

                    b.HasKey("IdServico");

                    b.HasIndex("fkServicoIdFilial");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("BD_VOLVO.Telefone", b =>
                {
                    b.Property<int>("IdTelefone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTelefone"));

                    b.Property<string>("NumeroTelefone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("TipoTelefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("fkClienteContaIdCliente")
                        .HasColumnType("int");

                    b.Property<int>("fkClienteContaIdConta")
                        .HasColumnType("int");

                    b.HasKey("IdTelefone");

                    b.HasIndex("fkClienteContaIdCliente", "fkClienteContaIdConta");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("BD_VOLVO.TipoQuarto", b =>
                {
                    b.Property<int>("IdTipoQuarto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoQuarto"));

                    b.Property<int>("Capacidade")
                        .HasColumnType("int");

                    b.Property<bool>("CapacidadeOpcional")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdTipoQuarto");

                    b.ToTable("TipoQuartos");
                });

            modelBuilder.Entity("BD_VOLVO.ClienteReserva", b =>
                {
                    b.HasOne("BD_VOLVO.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("fkReservaIdReserva")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BD_VOLVO.ClienteConta", "ClienteConta")
                        .WithMany()
                        .HasForeignKey("FkIdCliente", "FkIdConta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClienteConta");

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("BD_VOLVO.Consumo", b =>
                {
                    b.HasOne("BD_VOLVO.Frigobar", "Frigobar")
                        .WithMany()
                        .HasForeignKey("fkFrigobar");

                    b.HasOne("BD_VOLVO.Restaurante", "Restaurante")
                        .WithMany()
                        .HasForeignKey("fkRestaurante");

                    b.HasOne("BD_VOLVO.Servicos", "Servico")
                        .WithMany()
                        .HasForeignKey("fkServico");

                    b.HasOne("BD_VOLVO.ClienteConta", "ClienteConta")
                        .WithMany()
                        .HasForeignKey("fkClienteContaIdCliente", "fkClienteContaIdConta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClienteConta");

                    b.Navigation("Frigobar");

                    b.Navigation("Restaurante");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("BD_VOLVO.Efetua", b =>
                {
                    b.HasOne("BD_VOLVO.Pagamento", "Pagamento")
                        .WithMany()
                        .HasForeignKey("fkPagamentoIdPagamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BD_VOLVO.ClienteConta", "ClienteConta")
                        .WithMany()
                        .HasForeignKey("fkClienteContaIdCliente", "fkClienteContaIdConta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClienteConta");

                    b.Navigation("Pagamento");
                });

            modelBuilder.Entity("BD_VOLVO.Frigobar", b =>
                {
                    b.HasOne("BD_VOLVO.Filial", "Filial")
                        .WithMany()
                        .HasForeignKey("fkFrigobarIdFilial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filial");
                });

            modelBuilder.Entity("BD_VOLVO.Quarto", b =>
                {
                    b.HasOne("BD_VOLVO.Filial", "Filial")
                        .WithMany()
                        .HasForeignKey("fkIdFilial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BD_VOLVO.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("fkReservaIdReserva")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BD_VOLVO.TipoQuarto", "TipoQuarto")
                        .WithMany()
                        .HasForeignKey("fkTipoQuarto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filial");

                    b.Navigation("Reserva");

                    b.Navigation("TipoQuarto");
                });

            modelBuilder.Entity("BD_VOLVO.Reserva", b =>
                {
                    b.HasOne("BD_VOLVO.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("fkFuncionarioIdFuncionario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BD_VOLVO.TipoQuarto", "TipoQuarto")
                        .WithMany()
                        .HasForeignKey("fkTipoQuarto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");

                    b.Navigation("TipoQuarto");
                });

            modelBuilder.Entity("BD_VOLVO.Restaurante", b =>
                {
                    b.HasOne("BD_VOLVO.Filial", "Filial")
                        .WithMany()
                        .HasForeignKey("fkRestauranteIdFilial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filial");
                });

            modelBuilder.Entity("BD_VOLVO.Servicos", b =>
                {
                    b.HasOne("BD_VOLVO.Filial", "Filial")
                        .WithMany()
                        .HasForeignKey("fkServicoIdFilial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filial");
                });

            modelBuilder.Entity("BD_VOLVO.Telefone", b =>
                {
                    b.HasOne("BD_VOLVO.ClienteConta", "ClienteConta")
                        .WithMany()
                        .HasForeignKey("fkClienteContaIdCliente", "fkClienteContaIdConta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClienteConta");
                });
#pragma warning restore 612, 618
        }
    }
}
