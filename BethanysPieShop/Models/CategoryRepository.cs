 namespace naneAgha.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly NaneAghaShopDbContext _naneAghaShopDbContext;

        public CategoryRepository(NaneAghaShopDbContext naneAghaShopDbContext)
        {
            _naneAghaShopDbContext = naneAghaShopDbContext;
        }


        public IEnumerable<Category> AllCategories =>
            _naneAghaShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
