using System.ComponentModel.DataAnnotations;

namespace Catelog.Api
{
    public record CreateItemDto
    {
        [Required]
        public string Name { get; init; }
        [Required]
        public decimal Price { get; set; }
    }

}