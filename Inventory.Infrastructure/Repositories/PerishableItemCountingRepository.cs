using Inventory.Infrastructure.Context;
using Inventory.Infrastructure.Repositories.Interfaces;

namespace Inventory.Infrastructure.Repositories
{
    public class PerishableItemCountingRepository : GeneralRepository, IPerishableItemCountingRepository
    {
        private readonly InventoryContext _context;

        public PerishableItemCountingRepository(InventoryContext context) : base(context)
        {
            _context = context;
        }
    }
}
