using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //bu generik yapılara bir örnektir
            MyList<string> isimler = new MyList<string>();
            isimler.Add("engin");
        }
    }
}