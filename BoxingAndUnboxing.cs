using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Evan");
            list.Add(DateTime.Today);

            var number = (int)list[1]; //InvalidCastException

            var anotherList = new List<int>();
            var names = new List<string>();
            //names.Add();
        }
    }
}