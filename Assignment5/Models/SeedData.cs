using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Assignment5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookstoreDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookstoreDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        Title = "The Blue Sword",
                        Author = "Robin McKinley",
                        Publisher = "Greenwillow Books",
                        ISBN = "978-0441068807",
                        Category = "Fantasy",
                        Classification = "Fiction",
                        Price = 17.99,
                        NumPages = 248
                    },

                    new Book
                    {
                        Title = "Salt, Fat, Acid, Heat",
                        Author = "Samin Nosrat",
                        Publisher = "Simon and Schuster",
                        ISBN = "978-1476753836",
                        Category = "Cooking",
                        Classification = "Nonfiction",
                        Price = 19.75,
                        NumPages = 480
                    },

                    new Book
                    {
                        Title = "From the Mixed-up Files of Mrs. Basil E. Frankweiler",
                        Author = "e.l. konigsburg",
                        Publisher = "Atheneum Books for Young Readers",
                        ISBN = "978-0689711817",
                        Category = "Children's novel",
                        Classification = "Fiction",
                        Price = 7.99,
                        NumPages = 168
                    },

                    new Book
                    {
                        Title = "Template",
                        Author = "author",
                        Publisher = "publisher",
                        ISBN = "isbn",
                        Category = "category",
                        Classification = "Fiction",
                        Price = 00.00,
                        NumPages = 0
                    },

                    new Book
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Category = "Classic",
                        Classification = "Fiction",
                        Price = 9.95,
                        NumPages = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon and Schuster",
                        ISBN = "978-0743270755",
                        Category = "Biography",
                        Classification = "Nonfiction",
                        Price = 14.58,
                        NumPages = 944 

                    },


                    new Book
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Category = "Biography",
                        Classification = "Nonfiction",
                        Price = 21.54,
                        NumPages = 832

                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        Author = "Ronald C. White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Category = "Biography",
                        Classification = "Nonfiction",
                        Price = 11.61,
                        NumPages = 864

                    },

                    new Book
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Category = "Historical",
                        Classification = "Nonfiction",
                        Price = 13.33,
                        NumPages = 528

                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Category = "Historical Fiction",
                        Classification = "Fiction",
                        Price = 15.95,
                        NumPages = 288

                    },

                    new Book
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Category = "Self-Help",
                        Classification = "Nonfiction",
                        Price = 14.99,
                        NumPages = 304

                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Category = "Self-Help",
                        Classification = "Nonfiction",
                        Price = 21.66,
                        NumPages = 240

                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Category = "Business",
                        Classification = "Nonfiction",
                        Price = 29.16,
                        NumPages = 400

                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Category = "Thrillers",
                        Classification = "Fiction",
                        Price = 15.03,
                        NumPages = 642

                    }



                );


                context.SaveChanges();
            }
        }
 
    }
}
