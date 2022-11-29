﻿// <auto-generated />
using System;
using Animal_Protection.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Animal_Protection.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221129173156_AddShortDescToApplication")]
    partial class AddShortDescToApplication
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Protection_Animal.Model.Entities.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Млекопитающее семейства кошачьих отряда хищных",
                            Image = "213f5974-f6f2-4df7-bd92-5aac6af79919.jpg",
                            Name = "Кошка"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Плацентарное млекопитающее отряда хищных семейства псовых",
                            Image = "2268e547-bf9b-41a7-9bbf-cc49f056171a.jpg",
                            Name = "Собака"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Животное из семейства лошадиных отряда непарнокопытных",
                            Image = "9b28c272-d3b3-432a-9a41-59c793511c81.jpg",
                            Name = "Лошадь"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Отряд птиц из инфракласса новонёбных",
                            Image = "793e7730-31ab-4384-a88b-9c1f100337d4.jpg",
                            Name = "Попугай"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Вид млекопитающих из рода евразийских ежей семейства ежовых",
                            Image = "29659e5f-cd62-41b3-9c67-9fea4e553f16.jpg",
                            Name = "Ёжик"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Семейство млекопитающих из отряда грызунов",
                            Image = "aadadb39-bdad-4b69-b917-01d11e7bf72e.jpg",
                            Name = "Мышь"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Общее название нескольких родов млекопитающих из семейства зайцевых",
                            Image = "b16b581e-465b-44ba-a565-17d8d5464ae8.png",
                            Name = "Кролик"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Подсемейство грызунов семейства хомяковых",
                            Image = "cc09001e-3027-49d9-b350-c6e0f7d189a1.jpg",
                            Name = "Хомяк"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Парафилетическая группа пресмыкающихся отряда чешуйчатых",
                            Image = "e4722329-15d2-4038-8689-bdf3d760a9a2.png",
                            Name = "Ящерица"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Парафилетическая группа водных позвоночных животных",
                            Image = "7d1975d5-cd16-4949-9670-7025f16650d0.jpg",
                            Name = "Рыбка"
                        });
                });

            modelBuilder.Entity("Protection_Animal.Model.Entities.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SenderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ShortDesciption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SenderId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("Protection_Animal.Model.Entities.ApplicationCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Продажа"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Передержка"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Такси для животных"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Случка"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Подарок"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Другое"
                        });
                });

            modelBuilder.Entity("Protection_Animal.Model.Entities.Client", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Protection_Animal.Model.Entities.Application", b =>
                {
                    b.HasOne("Protection_Animal.Model.Entities.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Protection_Animal.Model.Entities.ApplicationCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Protection_Animal.Model.Entities.Client", "Sender")
                        .WithMany("Applications")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Category");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("Protection_Animal.Model.Entities.Client", b =>
                {
                    b.Navigation("Applications");
                });
#pragma warning restore 612, 618
        }
    }
}
