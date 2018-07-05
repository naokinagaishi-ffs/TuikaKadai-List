using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CSVFileCorrector
    {
        public static string ReloadDIrectory(string dirname)
        {
            Console.WriteLine("もう一度フォルダのパスを入力してください。");
            dirname = Console.ReadLine();
            return dirname;
        } 

        public static string ReloadFile(string filename)
        {
            Console.WriteLine("もう一度ファイル名を入力してください。");
            filename = Console.ReadLine();
            return filename;
        }

        public static  bool CheckElementsExists(List<Person> list)
        {
            if(list.Count > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("ファイル内に要素がありません。");
                return false;
            }
        }
    }
}
