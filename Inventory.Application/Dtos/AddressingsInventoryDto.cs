using Inventory.Domain;

namespace Inventory.Application.Dtos
{
    public class AddressingsInventoryDto
    {
        public int Id { get; set; }
        public int AddressingId { get; set; }
        public AddressingDto Addressing { get; set; }
        public int InventoryStartId { get; set; }
        public InventoriesDto InventoryStart { get; set; }
        public bool AddressingCountRealized { get; set; }
        public bool AddressingCountEnded { get; set; }
        public IEnumerable<StockCountingDto> StockTaking { get; set; }

    }
}