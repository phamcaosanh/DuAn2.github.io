using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ComicsStore.Models
{
    public class MyCart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public virtual void AddItem(Comic comic, int quantity)
        {
            CartLine line = Lines
            .Where(b => b.Comic.ComicID == comic.ComicID)
            .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Comic = comic,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public virtual void RemoveLine(Comic comic) =>
        Lines.RemoveAll(l => l.Comic.ComicID == comic.ComicID);
        public decimal ComputeTotalValue() =>
        Lines.Sum(e => e.Comic.Price * e.Quantity);
        public virtual void Clear() => Lines.Clear();
    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Comic Comic { get; set; }
        public int Quantity { get; set; }
    }
}