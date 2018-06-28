using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Data 
    {
        public static List<IPerson> datalist = new List<IPerson>();

        public IEnumerable<IPerson> CreatDataList(string filepath)
        {
            List<IPerson> list = new List<IPerson>();
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
