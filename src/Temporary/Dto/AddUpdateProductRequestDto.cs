using System.ComponentModel.DataAnnotations;

namespace Temporary.Dto
{
    public class AddUpdateProductRequestDto
    {
        public int ProductId { get; set; }
        [Required]
        [MaxLength(250)]
        public string ProductName { get; set; }
    }
}
