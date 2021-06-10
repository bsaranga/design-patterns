using System.Collections;
using System.Collections.Generic;
using System.Linq;
using open_closed.Enums;
using open_closed.Models;

namespace open_closed
{
    public class ProductFilter
    {
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            return products.Where(p => p.color.Equals(color));
        }

        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            return products.Where(p => p.size.Equals(size));
        }

        public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
        {
            return products.Where(p => p.color.Equals(color) && p.size.Equals(size));
        }
    }
}