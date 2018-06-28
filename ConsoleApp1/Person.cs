using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    public class Person:IPerson
    {
        public int id;
        public string name;
        public double money;
        
        public Person(int id,string name, double money)
        {
            this.id = id;
            this.name = name;
            this.money = money;
        }

    }
}
