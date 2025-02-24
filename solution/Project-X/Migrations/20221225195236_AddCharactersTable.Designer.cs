﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Project_X.DatabaseUtils;

namespace ProjectX.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221225195236_AddCharactersTable")]
    partial class AddCharactersTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Shared.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AdminTypes")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("Social")
                        .HasColumnType("text");

                    b.HasKey("AccountId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Shared.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AccountId")
                        .HasColumnType("integer");

                    b.Property<float>("Appearance")
                        .HasColumnType("real");

                    b.Property<int>("Armor")
                        .HasColumnType("integer");

                    b.Property<float>("Blush")
                        .HasColumnType("real");

                    b.Property<float>("Brows")
                        .HasColumnType("real");

                    b.Property<float>("Cheekbones")
                        .HasColumnType("real");

                    b.Property<float>("Cheeks")
                        .HasColumnType("real");

                    b.Property<float>("ChinProfile")
                        .HasColumnType("real");

                    b.Property<float>("ChinShape")
                        .HasColumnType("real");

                    b.Property<float>("ClothingStyle")
                        .HasColumnType("real");

                    b.Property<float>("ColorSkin")
                        .HasColumnType("real");

                    b.Property<float>("Costume")
                        .HasColumnType("real");

                    b.Property<float>("EyeColor")
                        .HasColumnType("real");

                    b.Property<float>("Eyes")
                        .HasColumnType("real");

                    b.Property<int?>("FatherId")
                        .HasColumnType("integer");

                    b.Property<float>("Forehead")
                        .HasColumnType("real");

                    b.Property<float>("Glasses")
                        .HasColumnType("real");

                    b.Property<float>("Hairstyles")
                        .HasColumnType("real");

                    b.Property<float>("Headress")
                        .HasColumnType("real");

                    b.Property<int>("Health")
                        .HasColumnType("integer");

                    b.Property<float>("Jaw")
                        .HasColumnType("real");

                    b.Property<float>("Lips")
                        .HasColumnType("real");

                    b.Property<float>("Makeup")
                        .HasColumnType("real");

                    b.Property<float>("MolesAndFreckles")
                        .HasColumnType("real");

                    b.Property<int?>("MotherId")
                        .HasColumnType("integer");

                    b.Property<float>("Nose")
                        .HasColumnType("real");

                    b.Property<float>("NoseProfile")
                        .HasColumnType("real");

                    b.Property<float>("NoseTip")
                        .HasColumnType("real");

                    b.Property<float>("Pomade")
                        .HasColumnType("real");

                    b.Property<int>("Sex")
                        .HasColumnType("integer");

                    b.Property<float>("SkinAging")
                        .HasColumnType("real");

                    b.Property<float>("SkinDamage")
                        .HasColumnType("real");

                    b.Property<float>("SkinDefects")
                        .HasColumnType("real");

                    b.Property<float>("SkinType")
                        .HasColumnType("real");

                    b.HasKey("CharacterId");

                    b.HasIndex("AccountId");

                    b.HasIndex("FatherId");

                    b.HasIndex("MotherId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("Shared.Models.Father", b =>
                {
                    b.Property<int>("FatherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("RussianName")
                        .HasColumnType("text");

                    b.HasKey("FatherId");

                    b.ToTable("Father");
                });

            modelBuilder.Entity("Shared.Models.Mother", b =>
                {
                    b.Property<int>("MotherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("RussianName")
                        .HasColumnType("text");

                    b.HasKey("MotherId");

                    b.ToTable("Mother");
                });

            modelBuilder.Entity("Shared.Models.Character", b =>
                {
                    b.HasOne("Shared.Models.Account", null)
                        .WithMany("Сharacters")
                        .HasForeignKey("AccountId");

                    b.HasOne("Shared.Models.Father", "Father")
                        .WithMany()
                        .HasForeignKey("FatherId");

                    b.HasOne("Shared.Models.Mother", "Mother")
                        .WithMany()
                        .HasForeignKey("MotherId");

                    b.OwnsOne("Shared.Models.Finances", "Finance", b1 =>
                        {
                            b1.Property<int>("CharacterId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer")
                                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                            b1.Property<int>("Bank")
                                .HasColumnType("integer");

                            b1.Property<int>("Cash")
                                .HasColumnType("integer");

                            b1.HasKey("CharacterId");

                            b1.ToTable("Characters");

                            b1.WithOwner()
                                .HasForeignKey("CharacterId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
