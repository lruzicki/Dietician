using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Dietician.Data;
using System;
using System.Linq;
using MvcMovie.Dietician;

namespace Dietician.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DieticianContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DieticianContext>>()))
            {
                // Look for any movies.
                if (context.Recipe.Any())
                {
                    return;   // DB has been seeded
                }

                Chef chef = new Chef();
                chef.Name = "BatterWejer";

                Chef chef2 = new Chef();
                chef2.Name = "Olivier";

                Chef chef3 = new Chef();
                chef3.Name = "Jayme";

                context.Recipe.AddRange(
                    
                    new Recipe
                    {
                        Title = "Sandwitch Bacon",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Breakfast",
                        Rating = "A5",
                        Price = 7.99M
                    },

                    new Recipe
                    {
                        Title = "Vege Sandwitch",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Breakfast",
                        Rating = "A5",
                        Price = 8.99M
                    },

                    new Recipe
                    {
                        Title = "Sandwitch Chicken",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Rating = "A5",
                        Genre = "Breakfast",
                        Price = 9.99M
                    },

                    new Recipe
                    {
                        Title = "Sandwitch Big",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Breakfast",
                        Rating = "A5",
                        Price = 3.99M
                    },
                    new Recipe
                    {
                        Title = "Vege Sandwitch",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Breakfast",
                        Rating = "A5",
                        Price = 8.99M
                    },

                    new Recipe
                    {
                        Title = "Sandwitch Chicken",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Rating = "A5",
                        Genre = "Breakfast",
                        Price = 9.99M
                    },
                    new Recipe
                    {
                        Title = "Vege Sandwitch",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Breakfast",
                        Rating = "A5",
                        Price = 8.99M
                    },

                    new Recipe
                    {
                        Title = "Sandwitch Chicken",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Rating = "A5",
                        Genre = "Breakfast",
                        Price = 9.99M
                    },
                    new Recipe
                    {
                        Title = "Vege Sandwitch",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Breakfast",
                        Rating = "A6",
                        Price = 8.99M
                    },

                    new Recipe
                    {
                        Title = "Soup Chicken",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Rating = "B6",
                        Genre = "Dinner",
                        Price = 9.99M
                    },
                    new Recipe
                    {
                        Title = "Vege Soup",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Dinner",
                        Rating = "A6",
                        Price = 8.99M
                    },

                    new Recipe
                    {
                        Title = "Soup Chicken",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Rating = "A2",
                        Genre = "Dinner",
                        Price = 9.99M
                    },
                    new Recipe
                    {
                        Title = "Vege Soup",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Dinner",
                        Rating = "A1",
                        Price = 8.99M
                    },

                    new Recipe
                    {
                        Title = "Soup Chicken",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Rating = "A1",
                        Genre = "Dinner",
                        Price = 9.99M
                    },
                    new Recipe
                    {
                        Title = "Super Vege Soup",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Dinner",
                        Rating = "A3",
                        Price = 8.99M
                    },

                    new Recipe
                    {
                        Title = "Sandwitch Chicken Soup",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Rating = "A5",
                        Genre = "Dinner",
                        Price = 9.99M
                    }
                );
                context.SaveChanges();
                context.Chefs.AddRange(

                    new Chef
                    {
                        Name = "Bejerkene"
                    }
                );
                context.SaveChanges();

            }
        }
    }
}