using System.Collections.Generic;
using System.Linq;
using open_closed.Interfaces;
using open_closed.Models;

namespace open_closed
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            return items.Where(p => spec.IsSatisfied(p));
        }
    }
}