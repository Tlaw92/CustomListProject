using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLists
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> thing = new MyList<int>();

            List<int> flamingo = new List<int>();
            flamingo.Add(1);
            flamingo.Add(2);
            flamingo.Add(3);
            flamingo.Add(4);
            flamingo.Add(5);
            flamingo.Add(6);
            flamingo.Add(7);
            flamingo.Add(8);
            flamingo.Add(9);
        }
    }
}
