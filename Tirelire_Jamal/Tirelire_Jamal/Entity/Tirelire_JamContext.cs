using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Tirelire_Jamal
{
    public partial class Tirelire_JamContext : DbContext
    {
        public Tirelire_JamContext()
        {
        }

        public Tirelire_JamContext(DbContextOptions<Tirelire_JamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adresse> Adresse { get; set; }
        public virtual DbSet<Avis> Avis { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Commande> Commande { get; set; }
        public virtual DbSet<Couleur> Couleur { get; set; }
        public virtual DbSet<DetailCommande> DetailCommande { get; set; }
        public virtual DbSet<Fabricant> Fabricant { get; set; }
        public virtual DbSet<Produit> Produit { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=Tirelire_Jam;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adresse>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdFacturation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdLivraison)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Avis>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Idclient).HasColumnName("IDClient");

                entity.Property(e => e.Idproduit).HasColumnName("IDProduit");

                entity.HasOne(d => d.IdclientNavigation)
                    .WithMany(p => p.Avis)
                    .HasForeignKey(d => d.Idclient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Avis_Client");

                entity.HasOne(d => d.IdproduitNavigation)
                    .WithMany(p => p.Avis)
                    .HasForeignKey(d => d.Idproduit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Avis_Produit");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateNaissance)
                    .HasColumnName("Date_Naissance")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idadresse).HasColumnName("IDAdresse");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdadresseNavigation)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.Idadresse)
                    .HasConstraintName("FK_Client_Adresse");
            });

            modelBuilder.Entity<Commande>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Commentaire)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Idclient).HasColumnName("IDClient");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdclientNavigation)
                    .WithMany(p => p.Commande)
                    .HasForeignKey(d => d.Idclient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Commande_Client");
            });

            modelBuilder.Entity<Couleur>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetailCommande>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Idcommande).HasColumnName("IDCommande");

                entity.Property(e => e.Idproduit).HasColumnName("IDProduit");

                entity.HasOne(d => d.IdcommandeNavigation)
                    .WithMany(p => p.DetailCommande)
                    .HasForeignKey(d => d.Idcommande)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetailCommande_Commande");

                entity.HasOne(d => d.IdproduitNavigation)
                    .WithMany(p => p.DetailCommande)
                    .HasForeignKey(d => d.Idproduit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetailCommande_Produit");
            });

            modelBuilder.Entity<Fabricant>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Produit>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Idcouleur).HasColumnName("IDCouleur");

                entity.Property(e => e.Idfabricant).HasColumnName("IDFabricant");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.IdcouleurNavigation)
                    .WithMany(p => p.Produit)
                    .HasForeignKey(d => d.Idcouleur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Produit_Couleur");

                entity.HasOne(d => d.IdfabricantNavigation)
                    .WithMany(p => p.Produit)
                    .HasForeignKey(d => d.Idfabricant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Produit_Fabricant");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
