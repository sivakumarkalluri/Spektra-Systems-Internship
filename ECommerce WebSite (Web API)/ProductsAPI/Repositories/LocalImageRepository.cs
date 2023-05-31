using ProductsAPI.Models;

namespace ProductsAPI.Repositories
{
    public class LocalImageRepository : IImageRespository
    {
        //To get the path for Local Folder
        public readonly IWebHostEnvironment webHostEnvironment;
        public readonly IHttpContextAccessor httpContextAccessor;
        private readonly ProductDbContext productDbContext;

        public LocalImageRepository(IWebHostEnvironment webHostEnvironment,IHttpContextAccessor httpContextAccessor,ProductDbContext productDbContext) {
            this.webHostEnvironment = webHostEnvironment;
            this.httpContextAccessor = httpContextAccessor;
            this.productDbContext = productDbContext;
        }
        public async Task<Image> Upload(Image image)
        {
            var localFilePath = Path.Combine(webHostEnvironment.ContentRootPath, "Images", $"{image.FileName}{image.FileExtension}");

            //Reads the file stream and uploading
            using var stream = new FileStream(localFilePath, FileMode.Create);
            await image.File.CopyToAsync(stream);

            var urlFilePath = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}{httpContextAccessor.HttpContext.Request.PathBase}/Images/{image.FileName}{image.FileExtension}";

            image.FilePath = urlFilePath;

            image.Id = 1;

            await productDbContext.Images.AddAsync(image);
            await productDbContext.SaveChangesAsync();

            return image;
            

        }
    }
}
