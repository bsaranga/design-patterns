using System;
using System.Collections.Generic;
using open_closed.Enums;
using open_closed.Interfaces;
using open_closed.Models;

namespace open_closed
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>()
            {
                new Product("XVibrator", Color.Blue, Size.Medium),
                new Product("FisherNet", Color.Red, Size.Large),
                new Product("FilterJam", Color.Green, Size.Small),
                new Product("Coolster", Color.Red, Size.Yuge),
                new Product("PagerX", Color.Red, Size.Small),
                new Product("CheckerNow", Color.Green, Size.Yuge),
                new Product("BreatherZ", Color.Red, Size.Large),
                new Product("LocusPocus", Color.Blue, Size.Small)
            };

            var filter = new ProductFilter();
            var filteredByColor = filter.FilterByColor(products, Color.Blue);
            var filteredBySize = filter.FilterBySize(products, Size.Small);
            var filteredBySizeAndColor = filter.FilterBySizeAndColor(products, Size.Large, Color.Red);

            var betterFilter = new BetterFilter();
            var colorSpec = new ColorSpecification(Color.Green);
            var sizeSpec = new SizeSpecification(Size.Small);

            var betterFilteredByColor = betterFilter.Filter(products, colorSpec);
            var betterFilteredBySize = betterFilter.Filter(products, sizeSpec);

        }
    }

    class ColorSpecification : ISpecification<Product>
    {
        private Color _color;
        public ColorSpecification(Color color)
        {
            _color = color;
        }
        public bool IsSatisfied(Product item)
        {
            return item.color.Equals(_color);
        }

    }
    class SizeSpecification : ISpecification<Product>
    {
        private Size _size;
        public SizeSpecification(Size size)
        {
            _size = size;
        }

        public bool IsSatisfied(Product item)
        {
            return item.size.Equals(_size);
        }
    }
}
