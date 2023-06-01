using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;
using ProductsAPI.Models.DTO;


namespace ProductsAPI.Repositories
{
    public class SqlProductRepository : IProductRepository
    {
        private readonly ProductDbContext dbContext;
        public SqlProductRepository(ProductDbContext dbContext) {
            this.dbContext = dbContext;
        }
        public async Task<List<Product>> GetAllProducts(string? genderFilter = null, string? productCategoryFilter = null, string? productSubCategoryFilter = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 6)
        {
            var products = dbContext.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(genderFilter))
            {
                products = products.Where(x => x.gender == genderFilter);
            }

            if (!string.IsNullOrWhiteSpace(productCategoryFilter))
            {
                products = products.Where(x => x.ProductCategory == productCategoryFilter);
            }

            if (!string.IsNullOrWhiteSpace(productSubCategoryFilter))
            {
                products = products.Where(x => x.ProductSubCategory == productSubCategoryFilter);
            }

            if(!string.IsNullOrWhiteSpace(sortBy))
            {
                if (sortBy.Equals("Name",StringComparison.OrdinalIgnoreCase))
                {
                    products= isAscending ? products.OrderBy(x=>x.Name): products.OrderByDescending(x=>x.Name);
                }
                else if (sortBy.Equals("Price", StringComparison.OrdinalIgnoreCase))
                {
                    products = isAscending ? products.OrderBy(x => x.Price) : products.OrderByDescending(x => x.Price);
                }
            }

            //Pagination

            //skipResults stores how many values to skip while coming to that page
            //For example if our pageNumber is 1 and pageSize is 6  then skipResults= (1-1)*6 = 0 so there will be no skipping for page1
            //if pageNumber is 2 and PageSize is 6 then skipResults= (2-1)*6 = 6 so we are skipping first 6 values
            
            var skipResults = (pageNumber - 1) * pageSize;

            //and our data for page1 is products.Skip(0).Take(6) so we are skipping 0 and taking 6 values
            //for page2 our skipResult is 6 so products.Skip(0).Take(6) so we are skipping 6 values before and taking 6 values (pageSize).
            return await products.Skip(skipResults).Take(pageSize).ToListAsync();
        }

        public async Task<Product> GetProductByID(int id)
        {
            return await dbContext.Products.FindAsync(id);
        }

        public async Task<Product>  AddProduct(Product product)
        {
            await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateProduct(int id,Product product)
        {
            var data = await dbContext.Products.FindAsync(id);
            if(data == null) {
                return null;
            }
           
            data.Name = product.Name;
            data.Description = product.Description;
            data.Price = product.Price;
            data.Discount = product.Discount;
            data.Images= product.Images;
            data.gender = product.gender;
            data.ProductCategory = product.ProductCategory;
            data.ProductSubCategory=product.ProductSubCategory;
            return data;

        }

        public async Task<Product> DeleteProduct(int id)
        {
            var data = await dbContext.Products.FindAsync(id);
            if (data == null)
            {
                return null;
            }
            dbContext.Products.Remove(data);
            await dbContext.SaveChangesAsync();
            return data;

        }

        public async Task<bool> UpdateImage(int id, string productImageUrl)
        {
            var prod=await GetProductByID(id);
            if (prod != null)
            {
                prod.Images = productImageUrl;
                await dbContext.SaveChangesAsync();
                return true;

            }
            return false;
        }
    }
}
