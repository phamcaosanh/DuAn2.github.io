using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace ComicsStore.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private ComicsStoreDbContext context;
        public EFOrderRepository(ComicsStoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Order> Orders => context.Orders
        .Include(o => o.Lines)
        .ThenInclude(l => l.Comic);
        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.Comic));
            if (order.OrderID == 0)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
    }
}