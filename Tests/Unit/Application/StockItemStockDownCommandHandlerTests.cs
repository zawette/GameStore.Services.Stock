using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Commands.Item;
using Application.Commands.Item.Handlers;
using Application.Exceptions;
using Application.Services;
using Domain.Repositories;
using NSubstitute;
using Shouldly;
using Xunit;

namespace Tests.Unit.Application
{
    public class StockItemStockDownCommandHandlerTests
    {
        [Fact]
        public async Task given_invalid_itemId_should_throw_an_exception()
        {
            var command = new StockItemStockDownCommand() { Id = Guid.NewGuid(), Amount = 1 };
            var exception = await Record.ExceptionAsync(async () => await _handler.Handle(command, new CancellationToken()));
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<ItemNotFoundException>();
        }
        [Fact]
        public async Task given_valid_itemId_and_amount_should_succeed(){

        }

        #region Arrange
        private readonly IItemRepository _repository;
        private readonly IEventProcessor _eventProcessor;
        private readonly StockItemStockDownCommandHandler _handler;

        public StockItemStockDownCommandHandlerTests()
        {
            _repository = Substitute.For<IItemRepository>();
            _eventProcessor = Substitute.For<IEventProcessor>();
            _handler = new StockItemStockDownCommandHandler(_repository, _eventProcessor);
        }

        #endregion
    }
}
