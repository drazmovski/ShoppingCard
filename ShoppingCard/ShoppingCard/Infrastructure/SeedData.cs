using Microsoft.EntityFrameworkCore;
using ShoppingCard.Infrastructure;
using ShoppingCard.Models;


namespace ShoppingCard.Infrastracture
{
    public class SeedData
    { 
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                Category fruits = new Category { Name = "Fruits", Slug = "fruits" };
                Category shirts = new Category { Name = "Shirts", Slug = "shirts" };
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Apples",
                        Slug = "apples",
                        Description = "Juicy apples",
                        Price = 1.30M,
                        Category = fruits,
                        Image = "apples.jpg"

                    },
                    new Product
                    {
                        Name = "Bananas",
                        Slug = "bananas",
                        Description = "Fresh bananas",
                        Price = 3M,
                        Category = fruits,
                        Image = "bananas.jpg"
                    },
                      new Product
                      {
                          Name = "Watermelon",
                          Slug = "watermelon",
                          Description = "Juicy watermelon",
                          Price = 0.5M,
                          Category = fruits,
                          Image = "watermelon.jpg"
                      },
                       new Product
                       {
                           Name = "Grapefruit",
                           Slug = "grapefruit",
                           Description = "Juicy grapefruit",
                           Price = 2M,
                           Category = fruits,
                           Image = "grapefruit.jpg"
                       },
                       new Product
                       {
                           Name = "White Shirt",
                           Slug = "white-shirt",
                           Description = "White Shirt",
                           Price = 5.99M,
                           Category = shirts,
                           Image = "white shirt.jpg"
                       },
                       new Product
                       {
                           Name = "Black Shirt",
                           Slug = "black-shirt",
                           Description = "Black Shirt",
                           Price = 7.99M,
                           Category = shirts,
                           Image = "black shirt.jpg"
                       },
                       new Product
                       {
                           Name = "Yellow Shirt",
                           Slug = "yellow-shirt",
                           Description = "Yellow Shirt",
                           Price = 11.99M,
                           Category = shirts,
                           Image = "yellow shirt.jpg"
                       }, new Product
                       {
                           Name = "Grey Shirt",
                           Slug = "grey-shirt",
                           Description = "Grey Shirt",
                           Price = 12.99M,
                           Category = shirts,
                           Image = "grey shirt.jpg"
                       }
                    );

                context.SaveChanges();

            }
        }
    }
}

