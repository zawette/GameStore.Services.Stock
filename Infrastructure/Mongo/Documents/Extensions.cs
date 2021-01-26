using Domain.Entities;

namespace Infrastructure.Mongo.Documents
{
    public static class Extensions
    {
        public static Item asItem(this ItemDocument itemDocument)
            => new Item(itemDocument.Id, itemDocument.Version, itemDocument.Amount);

        public static ItemDocument asItemDocument(this Item item)
            => new ItemDocument() { Id = item.Id, Version = item.Version, Amount = item.Amount };
    }
}