using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        //items classın  içinde oldğuğu için aşağıdaki publictende buraya ulaşabiliriz
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        //aşağıya t vermemizin sebebi sayı da string de false de yazabilmek için
        //program.cs de MyListten sonra string dersek t stringe dönüşür
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
