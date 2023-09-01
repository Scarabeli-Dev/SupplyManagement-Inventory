using Inventory.Infrastructure.Context;
using Inventory.Infrastructure.Repositories.Interfaces;

namespace Inventory.Infrastructure.Repositories
{
    public class InventoryMovementRepository : GeneralRepository, IInventoryMovementRepository
    {
        private readonly InventoryContext _context;

        public InventoryMovementRepository(InventoryContext context) : base(context)
        {
            _context = context;
        }
    }
}
