using System;
using Xunit;
using Domain.Entities;
using Shouldly;
using System.Linq;
using Domain.Events;

namespace Tests.Unit
{
    public class CreateItemTests
    {
        [Fact]
        public void given_valid_id_item_should_be_created()
        {
            //Arange
            var id = Guid.NewGuid();
            var amount = 1;

            //Act
            var item = Item.Create(id, amount);

            //Assert
            item.ShouldNotBeNull();
            item.Id.ShouldBe(id);
            item.Events.Count.ShouldBe(1);

            var @event = item.Events.Single();
            @event.ShouldBeOfType<ItemCreated>();
        }
    }
}
