using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonDataAccesor dao = new CSVPerson();
            var workerlist = dao.GetPerson();

            ////お小遣いの平均値をコンソールに表示
            Console.WriteLine("小遣いの平均値は,{0}円です", Calculater.Average(workerlist));

            //お小遣いが一番多い人の名前と金額
            var richpeople = Calculater.SearchRichPerson(workerlist);
            foreach (var p in richpeople)
            {
                Console.WriteLine("お小遣いが一番多い人は，{0}さんで，{1}円です。", p.name, p.money.ToString());
            }

            //お小遣いが一番少ない人の名前と金額
            var poorpeople = Calculater.SearchPoorPerson(workerlist);
            foreach (var p in poorpeople)
            {
                Console.WriteLine("お小遣いが一番少ない人は，{0}さんで，{1}円です。", p.name, p.money.ToString());
            }
            Console.WriteLine();

            //FFで要求①
            IEnumerable<Person> ff_datalist = workerlist.Where(x =>
                                                  x.id.Substring(0, 3)
                                                  == "100");
            Console.WriteLine("FFの小遣いの平均値は,{0}円です", Calculater.Average(ff_datalist));


            var ff_richpeople = Calculater.SearchRichPerson(ff_datalist);
            foreach (var p in ff_richpeople)
            {
                Console.WriteLine("FFでお小遣いが一番多い人は，{0}さんで，{1}円です。", p.name, p.money.ToString());
            }
            var ff_poorpeople = Calculater.SearchPoorPerson(ff_datalist);
            foreach (var p in ff_poorpeople)
            {
                Console.WriteLine("FFでお小遣いが一番少ない人は，{0}さんで，{1}円です。", p.name, p.money.ToString());
            }
            Console.WriteLine();


            //FFSで要求①
            IEnumerable<Person> ffs_datalist = workerlist.Where(x =>
                                                 x.id.Substring(0, 3)
                                                 == "128");
            Console.WriteLine("FFSの小遣いの平均値は,{0}円です", Calculater.Average(ffs_datalist));

            var ffs_richpeople = Calculater.SearchRichPerson(ffs_datalist);
            foreach (var p in richpeople)
            {
                Console.WriteLine("FFSでお小遣いが一番多い人は，{0}さんで，{1}円です。", p.name, p.money.ToString());
            }
            var ffs_poorpeople = Calculater.SearchPoorPerson(ffs_datalist);
            foreach (var p in poorpeople)
            {
                Console.WriteLine("FFSでお小遣いが一番少ない人は，{0}さんで，{1}円です。", p.name, p.money.ToString());
            }

        }
    }
}
