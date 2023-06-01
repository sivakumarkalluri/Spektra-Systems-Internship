using ProductsAPI.Models;

namespace ProductsAPI.Repositories
{
    public interface IImageRespository
    {
        Task<string> Upload(IFormFile file,string fileName);
    }
}
