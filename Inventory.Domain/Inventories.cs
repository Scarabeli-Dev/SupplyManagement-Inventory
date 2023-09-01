using System.ComponentModel.DataAnnotations;

namespace Inventory.Domain
{
    public class Inventories
    {
        public int Id { get; set; }

        [Display(Name = "Data de Início")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime InventoryStartDate { get; set; }

        [Display(Name = "Estimativa de termino")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StockTakingFinishDate { get; set; }

        [Display(Name = "Depósito")]
        public int WarehouseId { get; set; }
       
        [Display(Name = "Concluído")]
        public bool IsCompleted { get; set; }

        [Display(Name = "Endereçamentos")]
        public IEnumerable<AddressingsInventory> Addressings { get; set; }
    }
}
