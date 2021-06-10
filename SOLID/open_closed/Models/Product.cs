using open_closed.Enums;

namespace open_closed.Models
{
    public class Product
    {
        public string name { get; set; }
        public Color color { get; set; }
        public Size size { get; set; }

        public Product(string _name, Color _color, Size _size)
        {
            name = _name;
            color = _color;
            size = _size;
        }
    }
}