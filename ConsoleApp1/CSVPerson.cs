using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class CSVPerson : IPersonDataAccesor
    {

        string dirname = @"C:\Users\naoki\Desktop\課題\List\";
        string filename = "0.txt";


        public List<Person> GetPerson()
        {
            List<Person> workerlist = new List<Person>();
            //ファイルが存在するか確認
            if (File.Exists(dirname + filename))
            {
                using (StreamReader sr = new StreamReader(dirname + filename))
                {
                    string[] tmp;
                    while (sr.Peek() > -1)
                    {
                        string oneSentence = sr.ReadLine();
                        tmp = oneSentence.Split(',');
                        //要素が３つか確認。
                        if (tmp.Count() == 3)
                        {
                            workerlist.Add(new Person(tmp[0], tmp[1], int.Parse(tmp[2])));
                        }

                        else
                        {
                            Console.WriteLine("データに誤りがあります。");
                            Console.WriteLine($"混入したデータは、{oneSentence}です。");
                            Console.WriteLine($"現在参照しているファイルのパスは{dirname + filename}です。");
                            this.dirname = CSVFileCorrector.ReloadDIrectory(dirname);
                            this.filename = CSVFileCorrector.ReloadFile(filename);
                            this.GetPerson();
                        }

                    }
                }
            }
            //ファイルが存在しないとき
            else
            {
                this.dirname = CSVFileCorrector.ReloadDIrectory(dirname);
                this.filename = CSVFileCorrector.ReloadFile(filename);
                this.GetPerson();

            }

            //要素が１つ以上あるか。
            bool elementExist = CSVFileCorrector.CheckElementsExists(workerlist);
            if (elementExist == false)
            {
                this.dirname = CSVFileCorrector.ReloadDIrectory(dirname);
                this.filename = CSVFileCorrector.ReloadFile(filename);
                this.GetPerson();
            }

            return workerlist;

        }

    }
}
        

