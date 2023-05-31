using ProductsAPI.Models;

namespace ProductsAPI.Repositories
{
    public interface IProductRepository
    {
       Task<List<Product>> GetAllProducts(string? genderFilter = null, string? productCategoryFilter = null, string? productSubCategoryFilter = null,string? sortBy=null, bool isAscending=true, int pageNumber = 1, int pageSize = 6);

        Task<Product> GetProductByID(int id);

        Task<Product> AddProduct(Product product);
        Task<Product?> UpdateProduct(int id,Product product);

        Task<Product?> DeleteProduct(int id);

    }
}
