using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// 今回の研修ではLINQ,Listを使って計算
    /// </summary>
    public class Calculater  
    {
        
        
        
        public static double Average(IEnumerable<IPerson> list)
        {
            var result = list.Average(x =>x.money );

            return result;
        }

        public static IEnumerable<IPerson> SearchRichPerson(IEnumerable<IPerson> list)
        {
            double maxmoney = list.Max(x => x.money);
            
            var result = (from p in list where p.money == maxmoney select p);
            return result;
        }

        public  IEnumerable<IPerson> SearchPoorPerson(IEnumerable<IPerson> list)
        {
            double minmoney = list.Min(x => x.money);
            var result = list.Where(x => x.money == minmoney);
            return result;
        }
    }
}
