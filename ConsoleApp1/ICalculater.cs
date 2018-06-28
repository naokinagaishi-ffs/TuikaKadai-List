using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //public interface ICalculater<E> where E:IPerson
    public interface ICalculater
    {
         double Average(IEnumerable<CSVPerson> list);
    }
}
