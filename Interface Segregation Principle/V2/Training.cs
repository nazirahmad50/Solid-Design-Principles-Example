using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2
{
    // The training class doesnt need the weight and OS properties, this introduces tight coupling
    public class Training : IProduct
    {
        public int Price { get; set; }
        public int Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OS { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
