using Inventory.Infrastructure.Context;
using Inventory.Infrastructure.Repositories.Interfaces;

namespace Inventory.Infrastructure.Repositories
{
    public class StockTakingRepository : GeneralRepository, IStockTakingRepository
    {
        private readonly InventoryContext _context;

        public StockTakingRepository(InventoryContext context) : base(context)
        {
            _context = context;
        }
    }
}
