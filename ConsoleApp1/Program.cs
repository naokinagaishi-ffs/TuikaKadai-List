using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// 以下２点の拡張の可能性を考慮する
        /// １.計算方法が増える
        /// ２.データのフォーマット（CSV，DBとか）が変わる
        /// 
        /// 計算方法は、Calculaterクラスに追加していけばよい
        /// データのの形式は、IDataをIF継承させればよい ？
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CSVData data = new CSVData();
            //CSVCalculater csvcal = new CSVCalculater();

            string dirname = @"C:\Users\naoki\Desktop\課題\List\";
            string filename = "SampleData.txt";

            data.datalist.AddRange(data.CreatDataList(dirname + filename));

            ////お小遣いの平均値をコンソールに表示
            Console.WriteLine("小遣いの平均値は,{0}円です", Calculater.Average(data.datalist));

            //お小遣いが一番多い人の名前と金額
            var richpeople = Calculater.SearchRichPerson(data.datalist);
            foreach( var p in richpeople)
            {
                Console.WriteLine("お小遣いが一番多い人は，{0}さんで，{1}円です。", p.name, p.money.ToString());
            }

            //お小遣いが一番少ない人の名前と金額
            var poorpeople = Calculater.SearchPoorPerson(data.datalist);
            foreach( var p in poorpeople)
            {
                Console.WriteLine("お小遣いが一番少ない人は，{0}さんで，{1}円です。", p.name, p.money.ToString());
            }

            //FFで要求
            IEnumerable<Person> ff_datalist = data.datalist.Where(x =>
                                                  x.id.ToString().Substring(3)
                                                  == "100");
            var ff_richpeople = Calculater.SearchRichPerson(ff_datalist);
            foreach (var p in richpeople)
            {
                Console.WriteLine("FFでお小遣いが一番多い人は，{0}さんで，{1}円です。", p.name, p.money.ToString());
            }
            var ff_poorpeople = Calculater.SearchPoorPerson(ff_datalist);
            foreach (var p in poorpeople)
            {
                Console.WriteLine("FFでお小遣いが一番少ない人は，{0}さんで，{1}円です。", p.name, p.money.ToString());
            }

        }
    }
}
