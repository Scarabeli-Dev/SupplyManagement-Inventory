namespace Inventory.Application.Dtos
{
    public class InventoriesDto
    {
        public int Id { get; set; }
        public DateTime InventoryStartDate { get; set; }
        public DateTime StockTakingFinishDate { get; set; }
        public int WarehouseId { get; set; }
        public WarehouseDto Warehouse { get; set; }
        public bool IsCompleted { get; set; }
        public IEnumerable<AddressingsInventoryDto> Addressings { get; set; }

    }
}