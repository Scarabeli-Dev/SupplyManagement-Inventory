using Inventory.Domain.Enums;
using Inventory.Domain;

namespace Inventory.Application.Dtos
{
    public class ItemDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
        public IEnumerable<ItemsAddressingDto> Addressings { get; set; }
        public string Observation { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<StockCountingDto> StockTaking { get; set; }
        public IEnumerable<InventoryMovementDto> InventoryMovement { get; set; }

    }
}