﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi;

namespace WebApi.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi.Model.Acompanhamentos", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ativo")
                        .HasColumnType("bit");

                    b.Property<string>("descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("ACOMPANHAMENTOS");
                });

            modelBuilder.Entity("WebApi.Model.Adicional", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ativo")
                        .HasColumnType("bit");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("ADICIONAIS");
                });

            modelBuilder.Entity("WebApi.Model.Caixa", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<string>("descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipoMovimentacao")
                        .HasColumnType("int");

                    b.Property<decimal>("valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("CAIXA");
                });

            modelBuilder.Entity("WebApi.Model.Casquinha", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CASQUINHAS");
                });

            modelBuilder.Entity("WebApi.Model.Cliente", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ativo")
                        .HasColumnType("bit");

                    b.Property<string>("bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("CLIENTES");
                });

            modelBuilder.Entity("WebApi.Model.Estoque", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("acompanhamentoId")
                        .HasColumnType("bigint");

                    b.Property<long>("adicionalId")
                        .HasColumnType("bigint");

                    b.Property<long>("casquinhaId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("quantidadeAcompanhamento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("quantidadeAdicional")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("quantidadeCasquinha")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("quantidadeSabores")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("saboresId")
                        .HasColumnType("bigint");

                    b.Property<int>("tipoMovimentacao")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("acompanhamentoId");

                    b.HasIndex("adicionalId");

                    b.HasIndex("casquinhaId");

                    b.HasIndex("saboresId");

                    b.ToTable("ESTOQUE");
                });

            modelBuilder.Entity("WebApi.Model.GrupoUsuario", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("GRUPO_USUARIO");
                });

            modelBuilder.Entity("WebApi.Model.GrupoUsuarioPermissao", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("grupoUsuarioId")
                        .HasColumnType("bigint");

                    b.Property<long>("permissaoId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("grupoUsuarioId");

                    b.HasIndex("permissaoId");

                    b.ToTable("GRUPO_USUARIO_PERMISSAO");
                });

            modelBuilder.Entity("WebApi.Model.ItensVenda", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("acompanhamentosId")
                        .HasColumnType("bigint");

                    b.Property<long>("adicionalId")
                        .HasColumnType("bigint");

                    b.Property<long>("casquinhaId")
                        .HasColumnType("bigint");

                    b.Property<long>("saborId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("valorAcompanhamentos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("valorAdicional")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("valorCasquinha")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("valorSabor")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("vendaId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("vendaId");

                    b.ToTable("ITENS_VENDA");
                });

            modelBuilder.Entity("WebApi.Model.Permissao", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("PERMISSAO");
                });

            modelBuilder.Entity("WebApi.Model.Sabores", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("SABORES");
                });

            modelBuilder.Entity("WebApi.Model.Usuario", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ativo")
                        .HasColumnType("bit");

                    b.Property<string>("login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("USUARIOS");
                });

            modelBuilder.Entity("WebApi.Model.UsuarioPermissao", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("permissaoId")
                        .HasColumnType("bigint");

                    b.Property<long>("usuarioId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("permissaoId");

                    b.HasIndex("usuarioId");

                    b.ToTable("USUARIO_PERMISSAO");
                });

            modelBuilder.Entity("WebApi.Model.UsuariosGrupoUsuarios", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("grupoUsuarioId")
                        .HasColumnType("bigint");

                    b.Property<long>("usuarioId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("grupoUsuarioId");

                    b.HasIndex("usuarioId");

                    b.ToTable("USUARIOS_GRUPO_USUARIOS");
                });

            modelBuilder.Entity("WebApi.Model.Venda", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("dataVenda")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("valorTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("VENDAS");
                });

            modelBuilder.Entity("WebApi.Model.Estoque", b =>
                {
                    b.HasOne("WebApi.Model.Acompanhamentos", "acompanhamento")
                        .WithMany()
                        .HasForeignKey("acompanhamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Model.Adicional", "adicional")
                        .WithMany()
                        .HasForeignKey("adicionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Model.Casquinha", "casquinha")
                        .WithMany()
                        .HasForeignKey("casquinhaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Model.Sabores", "sabores")
                        .WithMany()
                        .HasForeignKey("saboresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApi.Model.GrupoUsuarioPermissao", b =>
                {
                    b.HasOne("WebApi.Model.GrupoUsuario", "grupoUsuario")
                        .WithMany()
                        .HasForeignKey("grupoUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Model.Permissao", "permissao")
                        .WithMany()
                        .HasForeignKey("permissaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApi.Model.ItensVenda", b =>
                {
                    b.HasOne("WebApi.Model.Venda", "venda")
                        .WithMany("listaItens")
                        .HasForeignKey("vendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApi.Model.UsuarioPermissao", b =>
                {
                    b.HasOne("WebApi.Model.Permissao", "permissao")
                        .WithMany()
                        .HasForeignKey("permissaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Model.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApi.Model.UsuariosGrupoUsuarios", b =>
                {
                    b.HasOne("WebApi.Model.GrupoUsuario", "grupoUsuario")
                        .WithMany()
                        .HasForeignKey("grupoUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Model.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
