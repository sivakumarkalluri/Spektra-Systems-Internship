using ProductsAPI.Models;

namespace ProductsAPI.Repositories
{
    public interface IImageRespository
    {
        Task<Image> Upload(Image image);
    }
}
