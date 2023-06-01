using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAPI.Models
{
    [Table("Images")]
    public class Image
    {
       
        public int Id { get; set; }

        //This property is not going to be mapped with database table
        [NotMapped]
        public IFormFile File { get; set; }

        public string FileName { get; set; }

        public string? FileDescription { get; set; }

        public string FileExtension { get; set; }

        public long FileSizeInBytes { get; set; }

        public string FilePath { get; set; }

        
     

    }
}
