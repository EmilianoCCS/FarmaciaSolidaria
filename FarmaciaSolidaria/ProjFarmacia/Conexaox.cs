namespace ProjFarmacia
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Conexaox : DbContext
    {
        public Conexaox()
            : base("name=ConexaoX")
        {
        }

        public virtual DbSet<Doadores> Doadores { get; set; }
        public virtual DbSet<Estoque> Estoque { get; set; }
        public virtual DbSet<Instituicoes> Instituicoes { get; set; }
        public virtual DbSet<Remedios> Remedios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doadores>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Doadores>()
                .Property(e => e.Cpf)
                .IsUnicode(false);

            modelBuilder.Entity<Doadores>()
                .Property(e => e.Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Doadores>()
                .Property(e => e.Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Doadores>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Doadores>()
                .Property(e => e.Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Doadores>()
                .Property(e => e.Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Doadores>()
                .HasMany(e => e.Remedios)
                .WithRequired(e => e.Doadores)
                .HasForeignKey(e => e.FK_Doadores_Id);

            modelBuilder.Entity<Doadores>()
                .HasMany(e => e.Estoque)
                .WithOptional(e => e.Doadores)
                .HasForeignKey(e => e.IdDoador);

            modelBuilder.Entity<Instituicoes>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Instituicoes>()
                .Property(e => e.Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Instituicoes>()
                .Property(e => e.Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Instituicoes>()
                .Property(e => e.UF)
                .IsUnicode(false);

            modelBuilder.Entity<Instituicoes>()
                .Property(e => e.Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Instituicoes>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<Instituicoes>()
                .Property(e => e.Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Instituicoes>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Instituicoes>()
                .HasMany(e => e.Estoque)
                .WithRequired(e => e.Instituicoes)
                .HasForeignKey(e => e.IdInstituicao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Remedios>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Remedios>()
                .Property(e => e.PrincipioAtivo)
                .IsUnicode(false);

            modelBuilder.Entity<Remedios>()
                .HasMany(e => e.Estoque)
                .WithRequired(e => e.Remedios)
                .HasForeignKey(e => e.IdRemedio)
                .WillCascadeOnDelete(false);
        }
    }
}
