using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_classes
{
    public class ConcreteOne : AbstractOne
    {
        public int Life { get; set; }

        public override int GetLife()
        {
            return Life;
        }

        public override void SetLife(int life)
        {
            throw new NotImplementedException();
        }
    }
}
