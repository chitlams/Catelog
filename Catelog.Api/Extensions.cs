using Catelog.Api.Dtos;
using Catelog.Api.Entities;

namespace Catelog.Api
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate

            };
        }
    }
}