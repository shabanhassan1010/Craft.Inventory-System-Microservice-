using huzcodes.Persistence.Implementations.EfRepository;

namespace Craft.Inventory.Infastructure.Data
{
    internal class InventoryRepository<TEntity> : HuzcodesRepository<TEntity> where TEntity : class
    {
        public InventoryRepository(ApplicationDBContext context):base(context)
        {
            
        }
    }
}
