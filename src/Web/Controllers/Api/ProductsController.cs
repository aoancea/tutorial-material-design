using System.Threading.Tasks;
using System.Web.Http;

namespace Tutorial.Material.Design.Web.Controllers.Api
{
    public class ProductsController : ApiController
    {
        [HttpGet]
        public async Task<Product[]> Get()
        {
            Product[] products = new Product[]
            {
                new Product() { Name = "Acrylic (Transparent)", Quantity = 25, Price = 2.90M },
                new Product() { Name = "Plywood (Birch)", Quantity = 50, Price = 1.25M },
                new Product() { Name = "Laminate (Gold on Blue)", Quantity = 10, Price = 2.35M },
                new Product() { Name = "Acrylic (Transparent)", Quantity = 25, Price = 2.90M },
                new Product() { Name = "Plywood (Birch)", Quantity = 50, Price = 1.25M },
                new Product() { Name = "Laminate (Gold on Blue)", Quantity = 10, Price = 2.35M },
                new Product() { Name = "Acrylic (Transparent)", Quantity = 25, Price = 2.90M },
                new Product() { Name = "Plywood (Birch)", Quantity = 50, Price = 1.25M },
                new Product() { Name = "Laminate (Gold on Blue)", Quantity = 10, Price = 2.35M },
                new Product() { Name = "Acrylic (Transparent)", Quantity = 25, Price = 2.90M },
                new Product() { Name = "Plywood (Birch)", Quantity = 50, Price = 1.25M },
                new Product() { Name = "Laminate (Gold on Blue)", Quantity = 10, Price = 2.35M },
                new Product() { Name = "Acrylic (Transparent)", Quantity = 25, Price = 2.90M },
                new Product() { Name = "Plywood (Birch)", Quantity = 50, Price = 1.25M },
                new Product() { Name = "Laminate (Gold on Blue)", Quantity = 10, Price = 2.35M },
            };

            return products;
        }
    }

    public class Product
    {
        public string Name { get; set; }

        public decimal Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
