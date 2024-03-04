namespace ShoppingCart.Data
{
    public class SeedData
    {
        public static void Initialize(DataContext context)
        {
            context.Database.EnsureCreated();

            // Look for any products.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            var category1 = new Models.Category
            {
                Name = "Category 1",
                Slug = "category-1"
            };
            var category2 = new Models.Category
            {
                Name = "Category 2",
                Slug = "category-2"
            };

            context.Products.AddRange(
                               new Models.Product
                               {
                                   Name = "Product 1",
                                   Slug = "product-1",
                                   Description = "Description for product 1",
                                   Price = 100,
                                   Category = category1

                               },
                                              new Models.Product
                                              {
                                                  Name = "Product 2",
                                                  Slug = "product-2",
                                                  Description = "Description for product 2",
                                                  Price = 200,
                                                  Category = category2
                                              }
                                                         );

            context.Categories.
                AddRange(category1, category2);

            context.SaveChanges();
        }
    }
}
