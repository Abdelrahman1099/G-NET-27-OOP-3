using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    static class BookingHelper
    {
        public static void printAll(IPrintable[] items)
        {
            foreach (var item in items)
            {
                item.Print();
            }
        }
    }
}
