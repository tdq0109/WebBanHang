using System.ComponentModel.DataAnnotations;

namespace ASM_Final.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Tên Thương hiệu")]
		public string Name { get; set; }
		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Mô tả Thương hiệu")]
		public string Description { get; set; }
        public int Status { get; set; }
        public string Slug { get; set; }
    }
}
