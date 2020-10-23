using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3
{

    public class Reporter
    {
        private IDataProvider dataProvider;

        // Dependancy injection through constructor
        // can pass anytype of class that implements IDataProvider
        public Reporter(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }


        public void CreateReport()
        {
            dataProvider.Read();
       
        }
    }


}
