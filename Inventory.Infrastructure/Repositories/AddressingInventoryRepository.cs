using Inventory.Infrastructure.Context;
using Inventory.Infrastructure.Repositories.Interfaces;

namespace Inventory.Infrastructure.Repositories
{
    public class AddressingInventoryRepository : GeneralRepository, IAddressingInventoryRepository
    {
        private readonly InventoryContext _context;

        public AddressingInventoryRepository(InventoryContext context) : base(context)
        {
            _context = context;
        }
    }
}
