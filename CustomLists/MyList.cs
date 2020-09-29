using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLists
{
    public class MyList<T>
    {
        public int count;
        public int size;
        
       

        private T[] _items;

        public MyList()
        {
            count = 0;
            size = 4;
         
            _items = new T[size];
        }
        public void Add(T flamingo)
        {
            
            _items[count] = flamingo;
            count++;
            //_items = new T[capacity *=2];
        }
       
    }
}
