using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Oglasi.Data;

namespace Oglasi.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180410011617_OglasiMigration")]
    partial class OglasiMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Oglasi.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Oglasi.Models.Fotografije", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OglasId");

                    b.Property<byte[]>("PodaciOSlici");

                    b.Property<int?>("ProizvodId");

                    b.HasKey("Id");

                    b.HasIndex("OglasId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Fotografije");
                });

            modelBuilder.Entity("Oglasi.Models.Gradovi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImeGrada");

                    b.HasKey("Id");

                    b.ToTable("Gradovi");
                });

            modelBuilder.Entity("Oglasi.Models.Kategorije", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NazivKategorije");

                    b.HasKey("Id");

                    b.ToTable("Kategorije");
                });

            modelBuilder.Entity("Oglasi.Models.KategorijeProdavnice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NazivKategorije");

                    b.HasKey("Id");

                    b.ToTable("KategorijeProdavnice");
                });

            modelBuilder.Entity("Oglasi.Models.Oglasi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Aktivan");

                    b.Property<int>("AutorId");

                    b.Property<string>("AutorId1");

                    b.Property<int>("BrojPregleda");

                    b.Property<int>("Cena");

                    b.Property<int>("GradId");

                    b.Property<bool>("Objavljen");

                    b.Property<int>("Obnoviti");

                    b.Property<string>("OsobaZaKontakt");

                    b.Property<string>("TekstOglasa")
                        .IsRequired();

                    b.Property<string>("Telefon");

                    b.Property<int>("TrajanjeOglasa");

                    b.Property<int>("VrstaOglasa");

                    b.HasKey("Id");

                    b.HasIndex("AutorId1");

                    b.HasIndex("GradId");

                    b.ToTable("Oglasi");
                });

            modelBuilder.Entity("Oglasi.Models.OglasiPotkategorije", b =>
                {
                    b.Property<int>("OglasiId");

                    b.Property<int>("PotkategorijeId");

                    b.HasKey("OglasiId", "PotkategorijeId");

                    b.HasIndex("PotkategorijeId");

                    b.ToTable("OglasiPotkategorije");
                });

            modelBuilder.Entity("Oglasi.Models.Poruke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naslov");

                    b.Property<string>("PosiljalacId");

                    b.Property<string>("PrimalacId");

                    b.Property<string>("TekstPoruke")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("PosiljalacId");

                    b.HasIndex("PrimalacId");

                    b.ToTable("Poruke");
                });

            modelBuilder.Entity("Oglasi.Models.Potkategorije", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("KategorijeId");

                    b.Property<string>("NazivPotkategorije");

                    b.HasKey("Id");

                    b.HasIndex("KategorijeId");

                    b.ToTable("Potkategorije");
                });

            modelBuilder.Entity("Oglasi.Models.Prodavnice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("KategorijeProdavniceId");

                    b.Property<string>("NazivProdavnice");

                    b.HasKey("Id");

                    b.HasIndex("KategorijeProdavniceId");

                    b.ToTable("Prodavnice");
                });

            modelBuilder.Entity("Oglasi.Models.Proizvodi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cena");

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.Property<int>("ProdavniceId");

                    b.HasKey("Id");

                    b.HasIndex("ProdavniceId");

                    b.ToTable("Proizvodi");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Oglasi.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Oglasi.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Oglasi.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Oglasi.Models.Fotografije", b =>
                {
                    b.HasOne("Oglasi.Models.Oglasi", "Oglas")
                        .WithMany("Fotografije")
                        .HasForeignKey("OglasId");

                    b.HasOne("Oglasi.Models.Proizvodi", "Proizvod")
                        .WithMany("Fotografije")
                        .HasForeignKey("ProizvodId");
                });

            modelBuilder.Entity("Oglasi.Models.Oglasi", b =>
                {
                    b.HasOne("Oglasi.Models.ApplicationUser", "Autor")
                        .WithMany()
                        .HasForeignKey("AutorId1");

                    b.HasOne("Oglasi.Models.Gradovi", "Grad")
                        .WithMany("Oglasi")
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Oglasi.Models.OglasiPotkategorije", b =>
                {
                    b.HasOne("Oglasi.Models.Oglasi", "Oglas")
                        .WithMany("OglasiPotkategorije")
                        .HasForeignKey("OglasiId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Oglasi.Models.Potkategorije", "Potkategorija")
                        .WithMany("OglasiPotkagorije")
                        .HasForeignKey("PotkategorijeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Oglasi.Models.Poruke", b =>
                {
                    b.HasOne("Oglasi.Models.ApplicationUser", "Posiljalac")
                        .WithMany()
                        .HasForeignKey("PosiljalacId");

                    b.HasOne("Oglasi.Models.ApplicationUser", "Primalac")
                        .WithMany()
                        .HasForeignKey("PrimalacId");
                });

            modelBuilder.Entity("Oglasi.Models.Potkategorije", b =>
                {
                    b.HasOne("Oglasi.Models.Kategorije", "Kategorija")
                        .WithMany("Potkategorije")
                        .HasForeignKey("KategorijeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Oglasi.Models.Prodavnice", b =>
                {
                    b.HasOne("Oglasi.Models.KategorijeProdavnice", "KategorijaProdavnice")
                        .WithMany("Prodavnice")
                        .HasForeignKey("KategorijeProdavniceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Oglasi.Models.Proizvodi", b =>
                {
                    b.HasOne("Oglasi.Models.Prodavnice", "Prodavnica")
                        .WithMany("Proizvodi")
                        .HasForeignKey("ProdavniceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
