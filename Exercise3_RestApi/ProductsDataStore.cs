using Exercise3_RestApi.Models;

namespace Exercise3_RestApi
{
    public class ProductsDataStore
    {
        public List<ProductDto> Products { get; set; }

        public ProductsDataStore()
        {
            Products = new List<ProductDto>()
            {
                new ProductDto()
                {
                    Id = 1,
                    Name = "Vacuum Cleaner",
                    Description = "Cleans the house"
                },
                new ProductDto()
                {
                    Id = 2,
                    Name = "Washing Machine",
                    Description = "Cleans the clothes"
                },
                new ProductDto()
                {
                    Id = 3,
                    Name = "Microwave",
                    Description = "Serves hot food"
                }
            };
        }
    }
}
