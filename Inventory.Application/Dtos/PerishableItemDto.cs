namespace Inventory.Application.Dtos
{
    public class PerishableItemDto
    {
        public int Id { get; set; }
        public DateTime? FabricationDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string ItemBatch { get; set; } = string.Empty;
        public decimal PerishableItemQuantity { get; set; }
        public decimal PerishableItemPreviousQuantity { get; set; } = 0;
        public int StockTakingId { get; set; }
        public StockCountingDto StockTaking { get; set; }

    }
}