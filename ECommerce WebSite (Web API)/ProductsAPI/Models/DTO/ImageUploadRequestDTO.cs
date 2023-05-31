﻿using System.ComponentModel.DataAnnotations;

namespace ProductsAPI.Models.DTO
{
    public class ImageUploadRequestDTO
    {
        [Required]
        public IFormFile File { get; set; }

        [Required]
        public string FileName { get; set; }

        [Required]

        public string FileDescription { get; set; }
    }
}
