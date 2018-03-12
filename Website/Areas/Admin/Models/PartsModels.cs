﻿using Microsoft.AspNetCore.Http;
using Microsoft.VisualStudio.Web.CodeGeneration.Utils;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Website.Areas.Admin.Models {
    public class PartCreateEditModel {
        public int Id { get; set; }
        [Required, StringLength(100, ErrorMessage = "Title must be less than 100 characters.")]
        public string Title { get; set; }
        [Required, StringLength(500, ErrorMessage = "Description must be less than 500 characters.")]
        public string Description { get; set; }
        [Required]
        public decimal? Price { get; set; }
        [Required]
        public decimal? Shipping { get; set; }
        [StringLength(20, ErrorMessage = "Buy Now Id must be less than 20 characters.")]
        public string BuyNowId { get; set; }
        [DisplayName("Image Files")]
        public List<IFormFile> FileUploads { get; set; }
        [DisplayName("Is Lenzkirch?")]
        public bool IsLenzkirch { get; set; }
        public List<Resource> Images { get; set; }
    }

    public class PartSortModel {
        public int id { get; set; }
        public int sortOrder { get; set; }
    }
}
