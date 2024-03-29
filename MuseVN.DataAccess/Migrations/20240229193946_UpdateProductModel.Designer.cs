﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MuseVNWeb.DataAccess.Data;

#nullable disable

namespace MuseVN.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240229193946_UpdateProductModel")]
    partial class UpdateProductModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MuseVN.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Fantasy"
                        });
                });

            modelBuilder.Entity("MuseVN.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "English"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Simplified Chinese"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Traditional Chinese"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Tagalog"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Spanish"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "Japanese"
                        });
                });

            modelBuilder.Entity("MuseVN.Models.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Platforms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Linux"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Mac"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Windows"
                        });
                });

            modelBuilder.Entity("MuseVN.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Developer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateOnly(2013, 5, 5),
                            Description = "The story centers around Fuminori Sakisaka, a medical school student involved in a vehicle accident that claimed the lives of both his parents and left him with critical injuries.\r\nHe was rescued by experimental brain surgery that coincidentally altered his perception of the world dramatically.\r\n\r\nEverything now seems to be composed of slimy intestines and gore to him. In addition, the rest of his senses: touch, hearing, smell, and taste, are also impaired, similar to his sight, further damaging his mental health.\r\n\r\nFuminori's desire to live dwindles, and one night, while still in the hospital, he contemplates suicide. However, a girl in a white dress named Saya appears before him. Compared to the horrible surroundings, she looks completely normal, if not downright gorgeous. Fuminori soon falls in love with Saya, and she becomes his raison d'être.\r\n\r\nAs time passes, Fuminori gets increasingly secluded from the rest of his normal life as he embarks on a mission to find a specific person Saya is looking for. Fuminori's friends and doctor get more concerned as he acts strangely over time. Nonetheless, they will soon cross paths, for better or worse...",
                            Developer = "Nitro Plus",
                            ImageUrl = "",
                            Language = "English",
                            Platform = "Windows",
                            Price = 499.0,
                            Tag = "Drama, Romance",
                            Title = "Saya no Uta"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateOnly(2012, 6, 28),
                            Description = "In the school the three people met. Their relation had been changed in the season, and turned into three love stories.\r\n\r\nMakoto has been admiring a girl he has seen on the train. That girl is Kotonoha Katsura, and he even managed to take a photo of her with his cell phone. Due to new seating in his class, he ends up next to Sekai Saionji, a nosy, but sweet and sincere girl. As she snoops for his cell phone while talking to him, she discovers his crush and vows to help him until Kotonoha agrees to go out with him. When Sekai finally gets them together, she realizes her own feelings after finding out that the person Kotonoha liked was, in fact, Makoto. While waiting for her train next to Makoto, who was waiting for Kotonoha, she has him talking about how he can repay her for all of her help. Before leaving for her train, she kisses him and cries when she boards the way home. Kotonoha happily arrives for her date with Makoto shortly after. With all three main characters carrying different expressions on their faces, the story begins.",
                            Developer = "Overflow",
                            ImageUrl = "",
                            Language = "English",
                            Platform = "Windows",
                            Price = 999.0,
                            Tag = "Drama, Romance",
                            Title = "School Days"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateOnly(2016, 3, 31),
                            Description = "-Decide The Fate Of All Mankind-\r\nCAN YOU CHANGE THE COURSE OF FATE?\r\nAND SAVE THE ONES CLOSEST TO YOU?\r\n\r\nSteins;Gate follows a rag-tag band of tech-savvy young students who discover the means of changing the past via mail, using a modified microwave. Their experiments into how far they can go with their discovery begin to spiral out of control as they become entangled in a conspiracy surrounding SERN, the organisation behind the Large Hadron Collider, and John Titor who claims to be from a dystopian future.",
                            Developer = "Nitro Origin",
                            ImageUrl = "",
                            Language = "English",
                            Platform = "Windows",
                            Price = 749.0,
                            Tag = "Drama, Romance, Science Fiction",
                            Title = "Steins:Gate"
                        });
                });

            modelBuilder.Entity("MuseVN.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Educational"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 7,
                            DisplayOrder = 7,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 8,
                            DisplayOrder = 8,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 9,
                            DisplayOrder = 9,
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = 10,
                            DisplayOrder = 10,
                            Name = "NSFW"
                        },
                        new
                        {
                            Id = 11,
                            DisplayOrder = 11,
                            Name = "Slife of Life"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
