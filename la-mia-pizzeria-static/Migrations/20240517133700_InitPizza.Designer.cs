﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using la_mia_pizzeria_static.Models;

#nullable disable

namespace la_mia_pizzeria_static.Migrations
{
    [DbContext(typeof(Pizza.PizzaContext))]
    [Migration("20240517133700_InitPizza")]
    partial class InitPizza
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("la_mia_pizzeria_static.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descrizione")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Immagine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Prezzo")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Pizze");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descrizione = "Pomodoro, mozzarella",
                            Immagine = "https://it.ooni.com/cdn/shop/articles/Margherita-9920.jpg?crop=center&height=800&v=1644590028&width=800",
                            Nome = "Margherita",
                            Prezzo = 5.99f
                        },
                        new
                        {
                            Id = 2,
                            Descrizione = "Pomodoro, mozzarella, funghi, prosciutto, olive",
                            Immagine = "https://eu.tastescdns.net/thumbor/VJP6SNLk2DEU2dsGq68txsvJ1gg=/1050x1050/filters:quality(65):brightness(2):contrast(2):rgb(2,-2,0):sharpen(0.2,0.2,true)/it/recipe/U5RophhTF-GvUSAqWeas/8924d1f3ed0de2aeaf60f104c2d88f.jpeg",
                            Nome = "Capricciosa",
                            Prezzo = 7.99f
                        },
                        new
                        {
                            Id = 3,
                            Descrizione = "Pomodoro, mozzarella, carciofi, funghi, prosciutto, olive",
                            Immagine = "https://www.italianstylecooking.net/wp-content/uploads/2022/01/Pizza-quattro-stagioni.jpg",
                            Nome = "Quattro Stagioni",
                            Prezzo = 8.99f
                        },
                        new
                        {
                            Id = 4,
                            Descrizione = "Pomodoro, mozzarella, salame piccante",
                            Immagine = "https://www.pizzarecipe.org/wp-content/uploads/2019/01/Pizza-Diavola.jpg",
                            Nome = "Diavola",
                            Prezzo = 6.99f
                        },
                        new
                        {
                            Id = 5,
                            Descrizione = "Pomodoro, mozzarella, prosciutto, funghi",
                            Immagine = "https://wips.plug.it/cips/buonissimo.org/cms/2023/11/pizza-con-prosciutto-cotto-e-fromaggi.jpg",
                            Nome = "Prosciutto e Funghi",
                            Prezzo = 7.49f
                        },
                        new
                        {
                            Id = 6,
                            Descrizione = "Pomodoro, mozzarella di bufala, pomodorini",
                            Immagine = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSpawwdyXRRUEbi2rwTf8PPp-vS-MHbW9XZY5ArTC9ffg&s",
                            Nome = "Bufalina",
                            Prezzo = 9.99f
                        },
                        new
                        {
                            Id = 7,
                            Descrizione = "Pomodoro, mozzarella, gorgonzola, fontina, parmigiano",
                            Immagine = "https://primochef.it/wp-content/uploads/2020/04/SH_pizza_quattro_formaggi.jpg",
                            Nome = "Quattro Formaggi",
                            Prezzo = 8.49f
                        },
                        new
                        {
                            Id = 8,
                            Descrizione = "Pomodoro, mozzarella, verdure miste",
                            Immagine = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwGtVkw2_Lii-qhmcEhf-G9HHm7CvIGp2pxg6Z1r8QDw&s",
                            Nome = "Vegetariana",
                            Prezzo = 7.99f
                        },
                        new
                        {
                            Id = 9,
                            Descrizione = "Pomodoro, mozzarella, tonno, cipolla",
                            Immagine = "https://www.bofrost.it/on/demandware.static/-/Sites-IT-master-catalog/default/dwd5d1c55c/images/15196-Pizza-Tonno-e-Cipolla-R.jpg",
                            Nome = "Tonno e Cipolla",
                            Prezzo = 6.99f
                        },
                        new
                        {
                            Id = 10,
                            Descrizione = "Mozzarella, rosmarino, olio d'oliva",
                            Immagine = "https://cdn.cook.stbm.it/thumbnails/ricette/144/144925/hd750x421.jpg",
                            Nome = "Pizza Bianca",
                            Prezzo = 6.49f
                        },
                        new
                        {
                            Id = 11,
                            Descrizione = "Panna, mozzarella, pancetta, uova",
                            Immagine = "https://www.vincenzosplate.com/wp-content/uploads/2022/10/1500x1500-Photo-4_1951-How-to-Make-CARBONARA-PIZZA-Like-an-Italian-V1.jpg",
                            Nome = "Carbonara",
                            Prezzo = 8.99f
                        },
                        new
                        {
                            Id = 12,
                            Descrizione = "Pomodoro, mozzarella, salsiccia, friarielli",
                            Immagine = "https://scattidigusto.b-cdn.net/wp-content/uploads/2017/11/pizza-salsiccia-friarielli-migliore-Napoli.jpg",
                            Nome = "Salsiccia e Friarielli",
                            Prezzo = 8.49f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
