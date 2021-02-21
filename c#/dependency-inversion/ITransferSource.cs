using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependency_inversion
{
    public interface ITransferSource
    {
        void RemoveFunds(decimal value);
    }
}
