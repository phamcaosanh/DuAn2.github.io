using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Http;

namespace ComicsStore.Models.ViewModels
{
    public class ComicViewModel
    {
        [Display(Name = "Tên Truyện")]
        public string Title { get; set; }
        [Display(Name = "Ngày Phát Hành")]
        [DataType(DataType.Date)]
        public DateTime Release { get; set; }
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Giá")]
        [Range(1, 10000000)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(Name = "Thể Loại")]

        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        public IFormFile ImageComic { get; set; }
    }
}
