using System.ComponentModel.DataAnnotations;

namespace Inventory.Domain
{
    public class AddressingsInventory
    {
        public int Id { get; set; }

        [Display(Name = "Endereçamento")]
        public int AddressingId { get; set; }

        [Display(Name = "Inventário")]
        public int InventoryStartId { get; set; }

        [Display(Name = "Inventário")]
        public Inventories InventoryStart { get; set; }

        [Display(Name = "Contagem Realizada")]
        public bool AddressingCountRealized { get; set; }

        [Display(Name = "Contagem Finalizada")]
        public bool AddressingCountEnded { get; set; }

        [Display(Name = "Contagens")]
        public IEnumerable<StockCounting> StockTaking { get; set; }
    }
}
