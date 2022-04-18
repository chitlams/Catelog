using System.ComponentModel.DataAnnotations;

namespace Catelog.Api
{
    public record UpdateItemDto
    {
        [Required]
        public string Name { get; init; }
        [Required]
        public decimal Price { get; set; }
    }

}