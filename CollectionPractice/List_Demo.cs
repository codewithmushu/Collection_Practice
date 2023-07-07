using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    //List<T> class represents the list of objects which can be accessed with index
    //List is Dynamic, We can resize the list
    public class List_Demo
    {
        //creating a list of integers
        List<int> list = new List<int>();   

        public void Adding()
        {
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count of List -" + list.Count);
            Console.WriteLine("list of capacity -" + list.Capacity);
            list.Add(1);
            list.Add(2);
            Console.WriteLine("list of capacity -" + list.Capacity);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count of List -" + list.Count);
            Console.WriteLine("list of capacity -" + list.Capacity);
            Console.WriteLine("Find Element " + list.Contains(1));
            Console.WriteLine("Remove Element " + list.Remove(1));
            list.RemoveAt(5);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("******************************");
            list.Add(87);
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("******************************");
            list.Add(55);
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("******************************");
       

        }
    }
}
