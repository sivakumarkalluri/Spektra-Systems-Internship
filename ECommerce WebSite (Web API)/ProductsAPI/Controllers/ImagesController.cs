//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Routing.Constraints;
//using Microsoft.EntityFrameworkCore;
//using ProductsAPI.Models;
//using ProductsAPI.Models.DTO;
//using ProductsAPI.Repositories;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace ProductsAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ImagesController : ControllerBase
//    {
//        public IImageRespository ImageRespository { get; }
//        public ProductDbContext productDbContext { get; }

//        public ImagesController(IImageRespository imageRespository,ProductDbContext productDbContext)
//        {
//            ImageRespository = imageRespository;
//            this.productDbContext = productDbContext;
//        }

//        [HttpGet]

//        public async Task<IActionResult> Get()
//        {
//            var data= await this.productDbContext.Images.ToListAsync();
//            var images = new List<ImageDTOcs>();
//            foreach (var img in data)
//            {
//                images.Add(new ImageDTOcs()
//                {
//                    Id = img.Id,
//                    FilePath=img.FilePath,
                    
//                }
//                    );
//            }
//            return Ok(images);
//        }
      
//        // POST api/<ImagesController>
//        [HttpPost]
//        [Route("Upload")]
//        public async Task<IActionResult> Upload([FromForm] ImageUploadRequestDTO request)
//        {
//            ValidateFileUpload(request);
//            if(ModelState.IsValid)
//            {
//                var imageDomainModel = new Image
//                {
//                    File = request.File,
//                    FileName = request.FileName,
//                    FileExtension = Path.GetExtension(request.File.FileName),
//                    FileSizeInBytes = request.File.Length,
//                    FileDescription = request.FileDescription
//                };

//                await ImageRespository.Upload(imageDomainModel);

//                return Ok(imageDomainModel);

//            }
           
//            return BadRequest(ModelState);

//        }

//        private void ValidateFileUpload(ImageUploadRequestDTO request)
//        {
//            var allowedExtensions = new string[] { ".jpg", ".jpeg", ".png" };
//            if(allowedExtensions.Contains(Path.GetExtension(request.File.FileName))==false)
//            {
//                ModelState.AddModelError("file", "Unsupported File Extension");

//            }
//            if (request.File.Length > 10485760)
//            {
//                ModelState.AddModelError("file", "File Size More than 10MB Please Upload smaller Size..");
//            }
//        }

        
      
//    }
//}
