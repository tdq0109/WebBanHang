using System.ComponentModel.DataAnnotations;

namespace ASM_Final.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Tên Sản phẩm")]
		public string Name { get; set; }
		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Mô tả Sản phẩm")]
		public string Description { get; set; }
        public string Slug { get; set; }
		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Giá Sản phẩm")]
		public decimal Price { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }
    }
}
