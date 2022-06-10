using System.Linq;
namespace ComicsStore.Models
{
    public interface IComicsStoreRepository
    {
        IQueryable<Comic> Comics { get; }
        void Save(Comic b);
        void Create(Comic b);
        void Delete(Comic b);
    }
}