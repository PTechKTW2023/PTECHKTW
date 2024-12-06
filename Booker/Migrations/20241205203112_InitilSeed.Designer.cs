﻿// <auto-generated />
using System;
using Booker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Booker.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241205203112_InitilSeed")]
    partial class InitilSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Booker.Data.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Level")
                        .HasColumnType("bit");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Grade = "1",
                            Level = true,
                            Subject = "Polski",
                            Title = "Ponad słowami 1 cz. 1"
                        },
                        new
                        {
                            Id = 2,
                            Grade = "1",
                            Level = true,
                            Subject = "Polski",
                            Title = "Ponad słowami 1 cz. 2"
                        },
                        new
                        {
                            Id = 3,
                            Grade = "2",
                            Level = true,
                            Subject = "Polski",
                            Title = "Ponad słowami 2 cz. 1"
                        },
                        new
                        {
                            Id = 4,
                            Grade = "2/3",
                            Level = true,
                            Subject = "Polski",
                            Title = "Ponad słowami 2 cz. 2"
                        },
                        new
                        {
                            Id = 5,
                            Grade = "3",
                            Level = true,
                            Subject = "Polski",
                            Title = "Ponad słowami 3 cz. 1"
                        },
                        new
                        {
                            Id = 6,
                            Grade = "4",
                            Level = true,
                            Subject = "Polski",
                            Title = "Ponad słowami 3 cz. 2"
                        },
                        new
                        {
                            Id = 7,
                            Grade = "5",
                            Level = true,
                            Subject = "Polski",
                            Title = "Ponad słowami 4"
                        },
                        new
                        {
                            Id = 8,
                            Grade = "Zależnie od poziomu",
                            Level = true,
                            Subject = "Język angielski",
                            Title = "Focus 2 Podręcznik"
                        },
                        new
                        {
                            Id = 9,
                            Grade = "Zależnie od poziomu",
                            Level = true,
                            Subject = "Język angielski",
                            Title = "Focus 3 Podręcznik"
                        },
                        new
                        {
                            Id = 10,
                            Grade = "Zależnie od poziomu",
                            Level = true,
                            Subject = "Język angielski",
                            Title = "Focus 4 Podręcznik"
                        },
                        new
                        {
                            Id = 11,
                            Grade = "Zależnie od poziomu",
                            Level = true,
                            Subject = "Język angielski",
                            Title = "Focus 5 Podręcznik"
                        },
                        new
                        {
                            Id = 12,
                            Grade = "Zależnie od poziomu",
                            Level = true,
                            Subject = "Język angielski",
                            Title = "Focus 2 Ćwiczenia"
                        },
                        new
                        {
                            Id = 13,
                            Grade = "Zależnie od poziomu",
                            Level = true,
                            Subject = "Język angielski",
                            Title = "Focus 3 Ćwiczenia"
                        },
                        new
                        {
                            Id = 14,
                            Grade = "Zależnie od poziomu",
                            Level = true,
                            Subject = "Język angielski",
                            Title = "Focus 4 Ćwiczenia"
                        },
                        new
                        {
                            Id = 15,
                            Grade = "Zależnie od poziomu",
                            Level = true,
                            Subject = "Język angielski",
                            Title = "Focus 5 Ćwiczenia"
                        },
                        new
                        {
                            Id = 16,
                            Grade = "4",
                            Level = true,
                            Subject = "Język angielski",
                            Title = "My matura perspectives [nowa era]"
                        },
                        new
                        {
                            Id = 17,
                            Grade = "5",
                            Level = true,
                            Subject = "Język angielski",
                            Title = "Repetytorium [Macmillan]"
                        },
                        new
                        {
                            Id = 18,
                            Grade = "5",
                            Level = false,
                            Subject = "Język angielski",
                            Title = "Repetytorium maturzysty [Oxford]"
                        },
                        new
                        {
                            Id = 19,
                            Grade = "5",
                            Level = true,
                            Subject = "Język angielski",
                            Title = "Repetytorium maturzysty [Cambridge, PWN]"
                        },
                        new
                        {
                            Id = 20,
                            Grade = "1",
                            Level = true,
                            Subject = "Język Niemiecki",
                            Title = "Welttour Deutsch 1"
                        },
                        new
                        {
                            Id = 21,
                            Grade = "2",
                            Level = true,
                            Subject = "Język Niemiecki",
                            Title = "Welttour Deutsch 2"
                        },
                        new
                        {
                            Id = 22,
                            Grade = "3",
                            Level = true,
                            Subject = "Język Niemiecki",
                            Title = "Welttour Deutsch 3"
                        },
                        new
                        {
                            Id = 23,
                            Grade = "4/5",
                            Level = true,
                            Subject = "Język Niemiecki",
                            Title = "Welttour Deutsch 4"
                        },
                        new
                        {
                            Id = 24,
                            Grade = "1",
                            Level = true,
                            Subject = "Język Niemiecki",
                            Title = "Effekt 1"
                        },
                        new
                        {
                            Id = 25,
                            Grade = "2",
                            Level = true,
                            Subject = "Język Niemiecki",
                            Title = "Effekt 2"
                        },
                        new
                        {
                            Id = 26,
                            Grade = "3",
                            Level = true,
                            Subject = "Język Niemiecki",
                            Title = "Effekt 3"
                        },
                        new
                        {
                            Id = 27,
                            Grade = "4/5",
                            Level = true,
                            Subject = "Język Niemiecki",
                            Title = "Effekt 4"
                        },
                        new
                        {
                            Id = 28,
                            Grade = "1",
                            Level = true,
                            Subject = "Biologia",
                            Title = "Biologia na czasie 1"
                        },
                        new
                        {
                            Id = 29,
                            Grade = "2/3",
                            Level = true,
                            Subject = "Biologia",
                            Title = "Biologia na czasie 2"
                        },
                        new
                        {
                            Id = 30,
                            Grade = "4",
                            Level = true,
                            Subject = "Biologia",
                            Title = "Biologia na czasie 3"
                        },
                        new
                        {
                            Id = 31,
                            Grade = "1",
                            Level = false,
                            Subject = "Biologia",
                            Title = "Biologia na czasie 1"
                        },
                        new
                        {
                            Id = 32,
                            Grade = "2",
                            Level = false,
                            Subject = "Biologia",
                            Title = "Biologia na czasie 2"
                        },
                        new
                        {
                            Id = 33,
                            Grade = "3/4",
                            Level = false,
                            Subject = "Biologia",
                            Title = "Biologia na czasie 3"
                        },
                        new
                        {
                            Id = 34,
                            Grade = "1,2,3",
                            Level = true,
                            Subject = "Chemia",
                            Title = "To jest chemia 1"
                        },
                        new
                        {
                            Id = 35,
                            Grade = "4",
                            Level = true,
                            Subject = "Chemia",
                            Title = "To jest chemia 2"
                        },
                        new
                        {
                            Id = 36,
                            Grade = "1,2,3",
                            Level = false,
                            Subject = "Chemia",
                            Title = "To jest chemia 1"
                        },
                        new
                        {
                            Id = 37,
                            Grade = "4,5",
                            Level = false,
                            Subject = "Chemia",
                            Title = "To jest chemia 2"
                        },
                        new
                        {
                            Id = 38,
                            Grade = "1",
                            Level = true,
                            Subject = "EDB",
                            Title = "Edukacja dla bezpieczeństwa [wsip]"
                        },
                        new
                        {
                            Id = 39,
                            Grade = "1",
                            Level = false,
                            Subject = "Fizyka",
                            Title = "Fizyka 1 [wsip]"
                        },
                        new
                        {
                            Id = 40,
                            Grade = "2",
                            Level = false,
                            Subject = "Fizyka",
                            Title = "Fizyka 2 [wsip]"
                        },
                        new
                        {
                            Id = 41,
                            Grade = "3",
                            Level = false,
                            Subject = "Fizyka",
                            Title = "Fizyka 3 [wsip]"
                        },
                        new
                        {
                            Id = 42,
                            Grade = "4/5",
                            Level = false,
                            Subject = "Fizyka",
                            Title = "Fizyka 4 [wsip]"
                        },
                        new
                        {
                            Id = 43,
                            Grade = "1/2",
                            Level = true,
                            Subject = "Geografia",
                            Title = "Oblicza geografii 1"
                        },
                        new
                        {
                            Id = 44,
                            Grade = "3/4",
                            Level = true,
                            Subject = "Geografia",
                            Title = "Oblicza geografii 2"
                        },
                        new
                        {
                            Id = 45,
                            Grade = "1/2",
                            Level = true,
                            Subject = "Geografia",
                            Title = "Oblicz geografii karty pracy 1"
                        },
                        new
                        {
                            Id = 46,
                            Grade = "3/4",
                            Level = true,
                            Subject = "Geografia",
                            Title = "Oblicz geografii karty pracy 2"
                        },
                        new
                        {
                            Id = 47,
                            Grade = "1",
                            Level = true,
                            Subject = "Historia",
                            Title = "Historia [wsip] 1"
                        },
                        new
                        {
                            Id = 48,
                            Grade = "2",
                            Level = true,
                            Subject = "Historia",
                            Title = "Historia [wsip] 2"
                        },
                        new
                        {
                            Id = 49,
                            Grade = "3",
                            Level = true,
                            Subject = "Historia",
                            Title = "Historia [wsip] 3"
                        },
                        new
                        {
                            Id = 50,
                            Grade = "4",
                            Level = true,
                            Subject = "Historia",
                            Title = "Historia [wsip] 4"
                        },
                        new
                        {
                            Id = 51,
                            Grade = "2",
                            Level = true,
                            Subject = "HiT",
                            Title = "Historia i teraźniejszość [wsip] 1"
                        },
                        new
                        {
                            Id = 52,
                            Grade = "3",
                            Level = true,
                            Subject = "HiT",
                            Title = "Historia i teraźniejszość [wsip] 2"
                        },
                        new
                        {
                            Id = 53,
                            Grade = "1/2",
                            Level = true,
                            Subject = "Informatyka",
                            Title = "Informatyka [operon]"
                        },
                        new
                        {
                            Id = 54,
                            Grade = "3/4",
                            Level = true,
                            Subject = "Informatyka",
                            Title = "Informatyka dla szkół ponadgimnazjalnych [Migra]"
                        },
                        new
                        {
                            Id = 55,
                            Grade = "1/2",
                            Level = false,
                            Subject = "Informatyka",
                            Title = "Informatyka [operon]"
                        },
                        new
                        {
                            Id = 56,
                            Grade = "3/4",
                            Level = false,
                            Subject = "Informatyka",
                            Title = "Informatyka dla szkół ponadgimnazjalnych [Migra]"
                        },
                        new
                        {
                            Id = 57,
                            Grade = "1/2",
                            Level = true,
                            Subject = "Matematyka",
                            Title = "NOWA MATeMAtyka 1"
                        },
                        new
                        {
                            Id = 58,
                            Grade = "2/3",
                            Level = true,
                            Subject = "Matematyka",
                            Title = "NOWA MATeMAtyka 2"
                        },
                        new
                        {
                            Id = 59,
                            Grade = "3/4",
                            Level = true,
                            Subject = "Matematyka",
                            Title = "NOWA MATeMAtyka 3"
                        },
                        new
                        {
                            Id = 60,
                            Grade = "4/5",
                            Level = true,
                            Subject = "Matematyka",
                            Title = "NOWA MATeMAtyka 4"
                        },
                        new
                        {
                            Id = 61,
                            Grade = "1/2",
                            Level = false,
                            Subject = "Matematyka",
                            Title = "NOWA MATeMAtyka 1"
                        },
                        new
                        {
                            Id = 62,
                            Grade = "2/3",
                            Level = false,
                            Subject = "Matematyka",
                            Title = "NOWA MATeMAtyka 2"
                        },
                        new
                        {
                            Id = 63,
                            Grade = "3/4",
                            Level = false,
                            Subject = "Matematyka",
                            Title = "NOWA MATeMAtyka 3"
                        },
                        new
                        {
                            Id = 64,
                            Grade = "4/5",
                            Level = false,
                            Subject = "Matematyka",
                            Title = "NOWA MATeMAtyka 4"
                        },
                        new
                        {
                            Id = 65,
                            Grade = "2/3",
                            Level = true,
                            Subject = "Podstawy przedsiębiorczości",
                            Title = "Krok w przedsiębiorczość"
                        },
                        new
                        {
                            Id = 66,
                            Grade = "1",
                            Level = true,
                            Subject = "Biznes i zarządzanie",
                            Title = "Krok w biznes i zarządzanie 1"
                        },
                        new
                        {
                            Id = 67,
                            Grade = "2",
                            Level = true,
                            Subject = "Biznes i zarządzanie",
                            Title = "Krok w biznes i zarządzanie 2"
                        },
                        new
                        {
                            Id = 68,
                            Grade = "1",
                            Level = true,
                            Subject = "Plastyka",
                            Title = "Spotkania ze sztuką 1"
                        },
                        new
                        {
                            Id = 69,
                            Grade = "4",
                            Level = true,
                            Subject = "WOS",
                            Title = "W centrum uwagi 1"
                        },
                        new
                        {
                            Id = 70,
                            Grade = "5",
                            Level = true,
                            Subject = "WOS",
                            Title = "W centrum uwagi 2"
                        },
                        new
                        {
                            Id = 71,
                            Grade = "3/4",
                            Level = false,
                            Subject = "Angielski zawodowy",
                            Title = "Electronics"
                        },
                        new
                        {
                            Id = 72,
                            Grade = "3/4",
                            Level = false,
                            Subject = "Angielski zawodowy",
                            Title = "Electrician"
                        },
                        new
                        {
                            Id = 73,
                            Grade = "3/4",
                            Level = false,
                            Subject = "Angielski zawodowy",
                            Title = "Software engineering"
                        },
                        new
                        {
                            Id = 74,
                            Grade = "3/4",
                            Level = false,
                            Subject = "Angielski zawodowy",
                            Title = "Computing"
                        },
                        new
                        {
                            Id = 75,
                            Grade = "3/4",
                            Level = false,
                            Subject = "Angielski zawodowy",
                            Title = "Mechanical engineering"
                        },
                        new
                        {
                            Id = 76,
                            Grade = "3/4",
                            Level = false,
                            Subject = "Angielski zawodowy",
                            Title = "Mechanics"
                        },
                        new
                        {
                            Id = 77,
                            Grade = "3/4",
                            Level = false,
                            Subject = "Angielski zawodowy",
                            Title = "Enviromental Science"
                        });
                });

            modelBuilder.Entity("Booker.Data.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Booker.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Booker.Data.Item", b =>
                {
                    b.HasOne("Booker.Data.Book", "Book")
                        .WithMany("Items")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Booker.Data.User", "User")
                        .WithMany("Items")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Booker.Data.Book", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Booker.Data.User", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}