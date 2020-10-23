using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2
{
    public class Server : IProduct
    {
        public int Price { get; set; }
        public int Weight { get; set; }
        public string OS { get; set; }
    }
}
