using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomLists
{
    public class MyList<T>
    {
        private int count;
        public int capacity;

        public int Count
        {
            get
            {
                return count;
            }
        }

        private T[] _items;


        public T this[int index] 
        { 
            //If index is outside of the count/ throw exception.
            
            get
            {
                return _items[index];
            }
            set 
            {
                _items[index] = value;
            }
        }

        public MyList()
        {
            count = 0;
            capacity = 4;
         
            _items = new T[capacity];
        }
        public void Add(T itemToAdd)
        {
            if(count == capacity)
            {
                T[] temporaryArray = new T[capacity *= 2];
                for (int i = 0; i < count; i++)
                {
                    temporaryArray[i] = _items[i];
                }
                _items = temporaryArray;
            }
            
            _items[count] = itemToAdd;
            count++;
            //_items = new T[capacity *=2];
        }


        public int Find(T itemToFind)
        {
            //Check each item in _items
            //if item matches item to find
            //return index where it was found
            //if nothing found return a negative number.
            return 1;
        }

        public void RemoveAt(int start)
        {
            for (int i = start + 1; i < count; i++)
            {
                _items[i - 1] = _items[i];
            }
            count --;
        }

        public bool Remove(T itemToRemove)
        {
            bool foundItem = false;
            T[] temporaryArray = new T[count];
            for (int i = 0, j = 0; i < count; i++, j++)
            {
                //
                if (_items[i].Equals(itemToRemove) && foundItem == false)
                {
                    foundItem = true;
                    
                    j--;
                }
                else
                {
                    temporaryArray[j] = _items[i];
                    
                }
                
                
            }
            if (foundItem == true)
            {
                count--;
            }
            _items = temporaryArray;
            return foundItem;
        }

    }
}
