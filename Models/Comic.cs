using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
namespace ComicsStore.Models
{
    public class Comic
    {
        public long ComicID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Chưa nhập tiêu đề")]
        [Display(Name = "Tên Truyện")]

        public string Title { get; set; }
        [Display(Name = "Ngày Phát Hành")]
        [DataType(DataType.Date)]
        public DateTime  Release { get; set; }
        [Required(ErrorMessage = "Chưa nhập mô tả")]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        [Display(Name = "Giá")]
        [Range(1, 10000000)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(Name = "Thể Loại")]

        [Required(ErrorMessage = "Chưa nhập thể loại")]
        [StringLength(30)]
        public string Genre { get; set; }
        public string ProfilePicture { get; set; }

    }
}