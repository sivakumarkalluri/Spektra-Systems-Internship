using Azure.Core;
using Microsoft.AspNetCore.Authentication;
using ProductsAPI.Models;
using static System.Net.Mime.MediaTypeNames;

namespace ProductsAPI.Repositories
{
    public class LocalImageRepository : IImageRespository
    {
        public readonly IWebHostEnvironment webHostEnvironment;
        public readonly IHttpContextAccessor httpContextAccessor;
        private readonly ProductDbContext productDbContext;

        public LocalImageRepository(IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor, ProductDbContext productDbContext)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.httpContextAccessor = httpContextAccessor;
            this.productDbContext = productDbContext;
        }
        //To get the path for Local Folder
        public async Task<string> Upload(IFormFile file, string fileName)
        {
            var localFilePath = Path.Combine(webHostEnvironment.ContentRootPath, "Images", $"{fileName}");

            //var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"Images", fileName);
            using Stream fileStream = new FileStream(localFilePath, FileMode.Create);
            await file.CopyToAsync(fileStream);
            var urlFilePath = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}{httpContextAccessor.HttpContext.Request.PathBase}/Images/{fileName}";
            return urlFilePath;

        }
        private string GetServerRelativePath(string fileName)
        {
            return Path.Combine(@"Images", fileName);
        }
    }
}
