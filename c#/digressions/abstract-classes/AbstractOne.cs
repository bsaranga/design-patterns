using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_classes
{
    public abstract class AbstractOne
    {
        private int Life { get; set; }

        public abstract void SetLife(int life);

        public abstract int GetLife();

        public string GetLife2()
        {
            return "";
        }
    }
}
