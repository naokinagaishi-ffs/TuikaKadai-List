using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class CSVData :IData
    {
        public List<Person> datalist = new List<Person>();

        public IEnumerable<Person> CreatDataList(string filepath)
        {
            List<Person> list = new List<Person>();
            using (StreamReader sr = new StreamReader(filepath))
            {
                string[] tmp;
                while (sr.Peek() > -1)
                {
                    tmp = sr.ReadLine().Split(',');
                    list.Add(new Person(int.Parse(tmp[0]),
                                            tmp[1],
                                            double.Parse(tmp[2])
                                            ));
                }

                return list;
            }
        }
    }
}
