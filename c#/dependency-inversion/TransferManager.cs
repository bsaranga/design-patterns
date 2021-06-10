using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependency_inversion
{
    public class TransferManager
    {
        public ITransferSource Source { get; set; }
        public ITransferDestination Destination { get; set; }
        public decimal Value { get; set; }

        public TransferManager(ITransferSource src, ITransferDestination dst, decimal val)
        {
            Source = src;
            Destination = dst;
            Value = val;
        }

        public void Transfer()
        {
            Source.RemoveFunds(Value);
            Destination.AddFunds(Value);
        }
    }
}
