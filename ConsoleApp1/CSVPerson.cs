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
        string filename = "SampleData.txt";


        public IEnumerable<Person> GetPerson()
        {
            List<Person> list = new List<Person>();
            using (StreamReader sr = new StreamReader(dirname + filename))
            {
                string[] tmp;
                while (sr.Peek() > -1)
                {
                    tmp = sr.ReadLine().Split(',');
                    list.Add(new Person(tmp[0], tmp[1], int.Parse(tmp[2])));
                }

                return list;
            }
        }
    }
        
}
