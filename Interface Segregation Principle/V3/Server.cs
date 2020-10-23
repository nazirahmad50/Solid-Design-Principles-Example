using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V3.interfaces;

namespace V3
{
    public class Server : IProduct, IComputer, IDeliverable
    {
        public int Price { get; set; }
        public int Weight { get; set; }
        public string OS { get; set; }
    }
}
