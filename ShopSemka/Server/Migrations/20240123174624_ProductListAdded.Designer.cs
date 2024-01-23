﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ShopSemka.Server.Data;

#nullable disable

namespace ShopSemka.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240123174624_ProductListAdded")]
    partial class ProductListAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ShopSemka.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Spoločenstvo prsteňa je fantasy román od spisovateľa J. R. R. Tolkiena. Predstavuje prvú časť trilógie Pán prsteňov.",
                            ImageURL = "https://mrtns.sk/tovar/_xl/134/xl134254.jpg?v=17050651822",
                            Price = 11.39m,
                            Title = "Spoločenstvo prsteňa"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Hobbit, alebo cesta tam a späť je fantasy román J. R. R. Tolkiena vydaný 21. septembra 1937. V slovenčine vyšiel prvýkrát v roku 1973.",
                            ImageURL = "https://mrtns.sk/tovar/_xl/134/xl134257.jpg?v=17050651812",
                            Price = 11.15m,
                            Title = "Hobbit, alebo cesta tam a späť"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Malý princ je najznámejšie dielo francúzskeho spisovateľa a pilota Antoineho de Saint-Exupéryho. Je to najslávnejší rozprávkový príbeh modernej literatúry.",
                            ImageURL = "https://www.pantarhei.sk/media/catalog/product/4/6/998f08d-00460809-23.jpg",
                            Price = 11.35m,
                            Title = "Malý princ"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Zbohom zbraniam je román Ernesta Hemingwaya, dej sa odohráva na talianskom fronte počas Prvej svetovej vojny. Kniha bola vydaná v roku 1929.",
                            ImageURL = "https://mrtns.sk/tovar/_xl/204/xl204133.jpg?v=16968287412",
                            Price = 9.99m,
                            Title = "Zbohom zbraniam"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}