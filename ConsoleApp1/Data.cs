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
        public  List<CSVPerson> datalist = new List<CSVPerson>();

        public IEnumerable<CSVPerson> CreatDataList(string filepath)
        {
            List<CSVPerson> list = new List<CSVPerson>();
            using (StreamReader sr = new StreamReader(filepath))
            {
                string[] tmp;
                while (sr.Peek() > -1)
                {
                    tmp = sr.ReadLine().Split(',');
                    list.Add(new CSVPerson(int.Parse(tmp[0]),
                                            tmp[1],
                                            double.Parse(tmp[2])
                                            ));
                }

                return list;
            }
        }
    }
}
