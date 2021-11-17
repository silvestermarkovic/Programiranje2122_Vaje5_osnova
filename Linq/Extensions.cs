using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    //razširitve morajo biti statični razred!!!
    public static class Extensions
    {
        
        //statična metoda
        public static void IzpisiELemente<T>(this IEnumerable<T> list)
        {
            Console.Write("Elementi seznama so: ");
            int count = 0;
            foreach (var item in list)
            {
                count++;
                Console.WriteLine(item.ToString() + $"{(count == list.Count() ? Environment.NewLine : ",")} ");
            }
            Console.WriteLine();
        }
    }
}
