using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotXpressTime
{
    internal class Orders
    {
        public string? Customer { get; set; }
        public double  Total { get; set; }
        public string MenuItem { get; set; }
        public int Quantity { get; set; }
    }
}
