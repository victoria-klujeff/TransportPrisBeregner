using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranportPrisBeregner
{
    public class TransportPrisBeregner
    {
        public int TransportBeregner(int afstand, int vaegt)
        {
            if (afstand < 5 && vaegt < 10)
            {
                return 0;
            }
            if (vaegt < 10)
            {
                return 75;
            }
            if (afstand < 5)
            {
                return 50;
            }
            return 100;
        }

            
    }
}
