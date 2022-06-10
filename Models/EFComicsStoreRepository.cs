using System.Linq;
namespace ComicsStore.Models
{
    public class EFComicsStoreRepository : IComicsStoreRepository
    {
        private ComicsStoreDbContext context;
        public EFComicsStoreRepository(ComicsStoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Comic> Comics => context.Comics;
        public void Create(Comic b)
        {
            context.Add(b);
            context.SaveChanges();
        }
        public void Delete(Comic b)
        {
            context.Remove(b); context.SaveChanges();
        }
        public void Save(Comic b)
        {
            context.SaveChanges();
        }
    }
}