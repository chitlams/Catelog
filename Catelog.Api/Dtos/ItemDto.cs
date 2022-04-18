using System;

namespace Catelog.Api.Dtos
{
    public record ItemDto
    {
        //Record Types
        // - > Use for Immutable objects
        // - > With-expressions support
        // - > Value-based equality support


        //Here below init means immutable 
        // you can do this
        // Item item = new() { Id = Guid.NewGuid()};

        //But not this
        //item.Id = Guid.NewGuid();
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }

    }
}