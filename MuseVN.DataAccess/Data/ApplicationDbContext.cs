using Microsoft.EntityFrameworkCore;
using MuseVN.Models;

namespace MuseVNWeb.DataAccess.Data;

public class ApplicationDbContext : DbContext{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options){
        
    }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<Tag> Tags { get; set; } 

    public DbSet<Platform> Platforms { get; set; }

    public DbSet<Language> Languages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder){

        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Action", DisplayOrder = 1},
            new Category { Id = 2, Name = "Fantasy", DisplayOrder = 2 }
            );

        modelBuilder.Entity<Product>().HasData(
            new Product {
                Id = 1,
                Title = "Saya no Uta",
                Description = "The story centers around Fuminori Sakisaka, a medical school student involved in a vehicle accident that claimed the lives of both his parents and left him with critical injuries.\r\nHe was rescued by experimental brain surgery that coincidentally altered his perception of the world dramatically.\r\n\r\nEverything now seems to be composed of slimy intestines and gore to him. In addition, the rest of his senses: touch, hearing, smell, and taste, are also impaired, similar to his sight, further damaging his mental health.\r\n\r\nFuminori's desire to live dwindles, and one night, while still in the hospital, he contemplates suicide. However, a girl in a white dress named Saya appears before him. Compared to the horrible surroundings, she looks completely normal, if not downright gorgeous. Fuminori soon falls in love with Saya, and she becomes his raison d'être.\r\n\r\nAs time passes, Fuminori gets increasingly secluded from the rest of his normal life as he embarks on a mission to find a specific person Saya is looking for. Fuminori's friends and doctor get more concerned as he acts strangely over time. Nonetheless, they will soon cross paths, for better or worse...",
                Developer = "Nitro Plus",
                Price = 499.00,
                Date = new DateOnly(2013, 5, 5),
                TagId = 1,
                SupportedLangId = 1,
                PlatformId = 1,
                ImageUrl = ""

            },
            new Product {
                Id = 2,
                Title = "School Days",
                Description = "In the school the three people met. Their relation had been changed in the season, and turned into three love stories.\r\n\r\nMakoto has been admiring a girl he has seen on the train. That girl is Kotonoha Katsura, and he even managed to take a photo of her with his cell phone. Due to new seating in his class, he ends up next to Sekai Saionji, a nosy, but sweet and sincere girl. As she snoops for his cell phone while talking to him, she discovers his crush and vows to help him until Kotonoha agrees to go out with him. When Sekai finally gets them together, she realizes her own feelings after finding out that the person Kotonoha liked was, in fact, Makoto. While waiting for her train next to Makoto, who was waiting for Kotonoha, she has him talking about how he can repay her for all of her help. Before leaving for her train, she kisses him and cries when she boards the way home. Kotonoha happily arrives for her date with Makoto shortly after. With all three main characters carrying different expressions on their faces, the story begins.",
                Developer = "Overflow",
                Price = 999.00,
                Date = new DateOnly(2012, 6, 28),
                TagId = 2, 
                SupportedLangId = 2,
                PlatformId = 2,
                ImageUrl = ""

            },
            new Product {
                Id = 3,
                Title = "Steins:Gate",
                Description = "-Decide The Fate Of All Mankind-\r\nCAN YOU CHANGE THE COURSE OF FATE?\r\nAND SAVE THE ONES CLOSEST TO YOU?\r\n\r\nSteins;Gate follows a rag-tag band of tech-savvy young students who discover the means of changing the past via mail, using a modified microwave. Their experiments into how far they can go with their discovery begin to spiral out of control as they become entangled in a conspiracy surrounding SERN, the organisation behind the Large Hadron Collider, and John Titor who claims to be from a dystopian future.",
                Developer = "Nitro Origin",
                Price = 749.00,
                Date = new DateOnly(2016, 3, 31),
                TagId = 3,
                SupportedLangId = 3,
                PlatformId = 3,
                ImageUrl = ""
                
            }
        );

        modelBuilder.Entity<Tag>().HasData(
            new Tag { 
                Id = 1,
                Fantasy = true,
                Horror = true,
                Romance = true,
                NSFW = true

                },
            new Tag {
                Id = 2,
                Drama = true,
                Romance = true,
                SliceOfLife = true,
                NSFW = true

                },
            new Tag {
                Id = 3,
                Drama = true,
                Mystery = true,
                Romance = true,
                ScienceFiction = true

               }
        );

        modelBuilder.Entity<Platform>().HasData(
            new Platform {
                Id = 1,
                Windows = true

            },
            new Platform {
                Id = 2,
                Windows = true

            },
            new Platform {
                Id = 3,
                Windows = true

            }
        );

        modelBuilder.Entity<Language>().HasData(
            new Language {
                Id = 1,
                English = true,
                Japanese = true

            },
            new Language {
                Id = 2,
                English = true,
                Japanese = true

            },
            new Language {
                Id= 3,
                English = true,
                Japanese = true

            }
        );
    }

}
