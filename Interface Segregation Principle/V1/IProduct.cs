using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1
{
    public interface IProduct
    {
        int Price { get; set; }
        int Weight { get; set; }
        string OS { get; set; }

    }
}
