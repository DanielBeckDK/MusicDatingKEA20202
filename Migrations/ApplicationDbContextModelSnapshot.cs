﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicDating.Data;

namespace MusicDating.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MusicDating.Models.Entities.Agent", b =>
                {
                    b.Property<int>("AgentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("InstrumentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.HasKey("AgentId");

                    b.HasIndex("InstrumentId");

                    b.ToTable("Agent");
                });

            modelBuilder.Entity("MusicDating.Models.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "199cab6c-1923-43dc-b538-c72eb40f2c41",
                            Email = "soren.remboll@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Søren",
                            LastName = "Rembøll",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "08f9da5f-6051-4c62-8358-4fb2279b2f61",
                            TwoFactorEnabled = false,
                            UserName = "soren.remboll@gmail.com"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ce79c426-6e1f-4b6a-8912-d909d1347bde",
                            EmailConfirmed = false,
                            FirstName = "Daniel",
                            LastName = "Beck",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8531b0d8-c90b-425d-b2c3-3265e2714bd6",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "41b5f064-94dc-440b-a161-258663279e2f",
                            EmailConfirmed = false,
                            FirstName = "Christian",
                            LastName = "1",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7a278964-4aa4-4319-ad1c-0d9ac229eba8",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ffd4430c-68db-41f8-95da-e7097821709e",
                            EmailConfirmed = false,
                            FirstName = "Christian",
                            LastName = "2",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c02f48a7-6c00-4968-a18a-b6972fa1b19c",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "581a263a-e44f-464b-8154-6af7f49f9808",
                            EmailConfirmed = false,
                            FirstName = "Christian",
                            LastName = "3",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4480070d-d7be-4c03-8859-21a901ababff",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aa0e84e0-b598-48ca-a7d0-b6277bc02c3c",
                            EmailConfirmed = false,
                            FirstName = "Christian",
                            LastName = "4",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e4c80d7a-bcb8-480a-8626-9150d8273df2",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("MusicDating.Models.Entities.Ensemble", b =>
                {
                    b.Property<int>("EnsembleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AdminUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("EnsembleDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("EnsembleName")
                        .HasColumnType("TEXT");

                    b.HasKey("EnsembleId");

                    b.HasIndex("AdminUserId");

                    b.ToTable("Ensembles");

                    b.HasData(
                        new
                        {
                            EnsembleId = 1,
                            EnsembleDescription = " Vi er TV2 og vi laver dårlig musik",
                            EnsembleName = "TV2"
                        },
                        new
                        {
                            EnsembleId = 2,
                            EnsembleDescription = "Vi er DR1 og vi æder licens penge til frokost",
                            EnsembleName = "DR1"
                        });
                });

            modelBuilder.Entity("MusicDating.Models.Entities.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GenreName")
                        .HasColumnType("TEXT");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            GenreName = "Metal"
                        },
                        new
                        {
                            GenreId = 2,
                            GenreName = "Rock"
                        },
                        new
                        {
                            GenreId = 3,
                            GenreName = "Classical"
                        },
                        new
                        {
                            GenreId = 4,
                            GenreName = "Pop"
                        },
                        new
                        {
                            GenreId = 5,
                            GenreName = "Funk"
                        });
                });

            modelBuilder.Entity("MusicDating.Models.Entities.GenreEnsemble", b =>
                {
                    b.Property<int>("GenreId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EnsembleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GenreId", "EnsembleId");

                    b.HasIndex("EnsembleId");

                    b.ToTable("GenreEnsemble");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            EnsembleId = 1
                        },
                        new
                        {
                            GenreId = 2,
                            EnsembleId = 2
                        });
                });

            modelBuilder.Entity("MusicDating.Models.Entities.Instrument", b =>
                {
                    b.Property<int>("InstrumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("InstrumentId");

                    b.ToTable("Instruments");

                    b.HasData(
                        new
                        {
                            InstrumentId = 1,
                            Name = "Trumpet"
                        },
                        new
                        {
                            InstrumentId = 2,
                            Name = "Piano"
                        },
                        new
                        {
                            InstrumentId = 3,
                            Name = "Saxophone"
                        },
                        new
                        {
                            InstrumentId = 4,
                            Name = "Drums"
                        },
                        new
                        {
                            InstrumentId = 5,
                            Name = "Bass"
                        });
                });

            modelBuilder.Entity("MusicDating.Models.Entities.UserEnsemble", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("EnsembleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id", "EnsembleId");

                    b.HasIndex("EnsembleId");

                    b.ToTable("UserEnsemble");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            EnsembleId = 1
                        },
                        new
                        {
                            Id = "2",
                            EnsembleId = 2
                        });
                });

            modelBuilder.Entity("MusicDating.Models.Entities.UserInstrument", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("InstrumentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id", "InstrumentId");

                    b.HasIndex("InstrumentId");

                    b.ToTable("UserInstrument");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            InstrumentId = 2,
                            Level = 5
                        },
                        new
                        {
                            Id = "2",
                            InstrumentId = 2,
                            Level = 3
                        },
                        new
                        {
                            Id = "3",
                            InstrumentId = 1,
                            Level = 1
                        },
                        new
                        {
                            Id = "3",
                            InstrumentId = 4,
                            Level = 1
                        },
                        new
                        {
                            Id = "2",
                            InstrumentId = 1,
                            Level = 1
                        });
                });

            modelBuilder.Entity("MusicDating.Models.Entities.UserInstrumentGenre", b =>
                {
                    b.Property<int>("UserInstrumentGenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GenreId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Id")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("InstrumentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserInstrumentGenreId");

                    b.HasIndex("GenreId");

                    b.HasIndex("Id", "InstrumentId");

                    b.ToTable("UserInstrumentGenre");

                    b.HasData(
                        new
                        {
                            UserInstrumentGenreId = 1,
                            GenreId = 2,
                            Id = "1",
                            InstrumentId = 2
                        },
                        new
                        {
                            UserInstrumentGenreId = 2,
                            GenreId = 2,
                            Id = "2",
                            InstrumentId = 2
                        },
                        new
                        {
                            UserInstrumentGenreId = 3,
                            GenreId = 5,
                            Id = "3",
                            InstrumentId = 1
                        },
                        new
                        {
                            UserInstrumentGenreId = 4,
                            GenreId = 5,
                            Id = "3",
                            InstrumentId = 4
                        },
                        new
                        {
                            UserInstrumentGenreId = 5,
                            GenreId = 1,
                            Id = "2",
                            InstrumentId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MusicDating.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MusicDating.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicDating.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MusicDating.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MusicDating.Models.Entities.Agent", b =>
                {
                    b.HasOne("MusicDating.Models.Entities.Instrument", "Instrument")
                        .WithMany("Agents")
                        .HasForeignKey("InstrumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MusicDating.Models.Entities.Ensemble", b =>
                {
                    b.HasOne("MusicDating.Models.Entities.ApplicationUser", "AdminUser")
                        .WithMany()
                        .HasForeignKey("AdminUserId");
                });

            modelBuilder.Entity("MusicDating.Models.Entities.GenreEnsemble", b =>
                {
                    b.HasOne("MusicDating.Models.Entities.Ensemble", "Ensemble")
                        .WithMany("GenreEnsembles")
                        .HasForeignKey("EnsembleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicDating.Models.Entities.Genre", "Genre")
                        .WithMany("GenreEnsembles")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MusicDating.Models.Entities.UserEnsemble", b =>
                {
                    b.HasOne("MusicDating.Models.Entities.Ensemble", "Ensemble")
                        .WithMany("UserEnsembles")
                        .HasForeignKey("EnsembleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicDating.Models.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("UserEnsembles")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MusicDating.Models.Entities.UserInstrument", b =>
                {
                    b.HasOne("MusicDating.Models.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("UserInstruments")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicDating.Models.Entities.Instrument", "Instrument")
                        .WithMany("UserInstruments")
                        .HasForeignKey("InstrumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MusicDating.Models.Entities.UserInstrumentGenre", b =>
                {
                    b.HasOne("MusicDating.Models.Entities.Genre", "Genre")
                        .WithMany("UserInstrumentGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicDating.Models.Entities.UserInstrument", "UserInstrument")
                        .WithMany("UserInstrumentGenres")
                        .HasForeignKey("Id", "InstrumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
