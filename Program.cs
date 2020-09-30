using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> MyList = new List<string>();
            MyList.Add("lion");
            MyList.Add("cat");
            MyList.Add("dog");
            MyList.Add("elephant");
            foreach (var item in MyList)
            {
                Console.WriteLine(item);
            }
            MyList.Remove("dog");
            foreach (var item in MyList)
            {
                Console.WriteLine(item);
            }
            var animal = from name in MyList
                         orderby name.Length
                         select name;
            foreach (var item in animal)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Cat index :");
            Console.WriteLine(MyList.IndexOf("cat"));
        }
    }
}
