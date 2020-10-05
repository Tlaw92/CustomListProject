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

            List<int> MicroSoftList = new List<int>() { 1, 2, 3, 4, 5 };
            MicroSoftList.Add(2);
            //MicroSoftList.Count = 700;






            MicroSoftList[0] = 7;

            MyList<int> thing = new MyList<int>();
            //thing.Add(2);
            //int something = thing[0];
            //thing[0] = 7;
            //thing.Remove(5);
          
            thing.Add(167);
            thing.Add(234);
            thing.Add(365);
            thing.Add(425);
            thing.Add(524);
            thing.Add(626);
            thing.Add(777);
            thing.Add(824);
            thing.Add(987);
            thing.Remove(234);
            
        }
    }
}
