using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>               // Bir array referans tip olduğu için new'lenme zorunluluğu vardır. 0 olarak
    {                            // new'lemek istiyoruz. Bu yüzden bir class new'lendiğinde çalışan bloğa "constructor" denir.     
        T[] items;
        
        // constructor
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
