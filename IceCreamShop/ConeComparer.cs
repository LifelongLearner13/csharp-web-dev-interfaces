using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public ConeComparer()
        {
        }

        public int Compare(Cone x, Cone y)
        {
            double diff = x.Cost - y.Cost;
            if (diff == 0)
            {
                return 0;
            }

            if (diff < 0)
            {
                return -1;
            }

            return 1;
        }
    }
}

