﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MuseVNWeb.DataAccess.Data;

#nullable disable

namespace MuseVN.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("GameTags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("SupportedLanguage")
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
                            GameTags = "[\"Fantasy\",\"Horror\",\"Romance\",\"NSFW\"]",
                            Platform = "[\"Windows\"]",
                            Price = 550.0,
                            SupportedLanguage = "[\"English\"]",
                            Title = "Saya no Uta"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateOnly(2012, 6, 28),
                            Description = "In the school the three people met. Their relation had been changed in the season, and turned into three love stories.\r\n\r\nMakoto has been admiring a girl he has seen on the train. That girl is Kotonoha Katsura, and he even managed to take a photo of her with his cell phone. Due to new seating in his class, he ends up next to Sekai Saionji, a nosy, but sweet and sincere girl. As she snoops for his cell phone while talking to him, she discovers his crush and vows to help him until Kotonoha agrees to go out with him. When Sekai finally gets them together, she realizes her own feelings after finding out that the person Kotonoha liked was, in fact, Makoto. While waiting for her train next to Makoto, who was waiting for Kotonoha, she has him talking about how he can repay her for all of her help. Before leaving for her train, she kisses him and cries when she boards the way home. Kotonoha happily arrives for her date with Makoto shortly after. With all three main characters carrying different expressions on their faces, the story begins.",
                            Developer = "Overflow",
                            GameTags = "[\"Drama\",\"Romance\",\"Slice of Life\",\"NSFW\"]",
                            Platform = "[\"Windows\"]",
                            Price = 1100.0,
                            SupportedLanguage = "[\"English\"]",
                            Title = "School Days"
                        });
                });

            modelBuilder.Entity("MuseVN.Models.Tag", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("Action")
                        .HasColumnType("bit");

                    b.Property<bool>("Comedy")
                        .HasColumnType("bit");

                    b.Property<bool>("Drama")
                        .HasColumnType("bit");

                    b.Property<bool>("Educational")
                        .HasColumnType("bit");

                    b.Property<bool>("Fantasy")
                        .HasColumnType("bit");

                    b.Property<bool>("Horror")
                        .HasColumnType("bit");

                    b.Property<bool>("Mystery")
                        .HasColumnType("bit");

                    b.Property<bool>("NSFW")
                        .HasColumnType("bit");

                    b.Property<bool>("Romance")
                        .HasColumnType("bit");

                    b.Property<bool>("ScienceFiction")
                        .HasColumnType("bit");

                    b.Property<bool>("SliceOfLife")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Action = false,
                            Comedy = false,
                            Drama = false,
                            Educational = false,
                            Fantasy = true,
                            Horror = true,
                            Mystery = false,
                            NSFW = true,
                            Romance = true,
                            ScienceFiction = false,
                            SliceOfLife = false
                        },
                        new
                        {
                            id = 2,
                            Action = false,
                            Comedy = false,
                            Drama = true,
                            Educational = false,
                            Fantasy = false,
                            Horror = false,
                            Mystery = false,
                            NSFW = true,
                            Romance = true,
                            ScienceFiction = false,
                            SliceOfLife = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
