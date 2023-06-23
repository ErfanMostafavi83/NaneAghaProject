using Microsoft.EntityFrameworkCore;

namespace naneAgha.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly NaneAghaShopDbContext _naneAghaShopDbContext;

        public PieRepository(NaneAghaShopDbContext naneAghaShopDbContext)
        {
            _naneAghaShopDbContext = naneAghaShopDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _naneAghaShopDbContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _naneAghaShopDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId)
        {
            return _naneAghaShopDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
