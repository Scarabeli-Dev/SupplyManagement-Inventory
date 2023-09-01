namespace Inventory.Application.Dtos
{
    public class StockCountingDto
    {
        public int Id { get; set; }
        public DateTime? StockTakingDate { get; set; }
        public string ItemId { get; set; }
        public ItemDto Item { get; set; }
        public int AddressingsInventoryId { get; set; }
        public AddressingsInventoryDto AddressingsInventory { get; set; }
        public decimal StockTakingQuantity { get; set; }
        public decimal StockTakingPreviousQuantity { get; set; } = -1;
        public bool IsPerishableItem { get; set; }
        public List<PerishableItemDto> PerishableItem { get; set; }
        public string StockTakingObservation { get; set; }
        public bool ItemToRecount { get; set; }
        public int NumberOfCount { get; set; }

    }
}