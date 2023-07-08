using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Choose the below options");
                Console.WriteLine("1-List");
                Console.WriteLine("2-Array");
                Console.WriteLine("3-Array List");
                Console.WriteLine("4-Dictionary");
                int Choice=Convert.ToInt32(Console.ReadLine());
                

                switch(Choice)
                {
                    case 1:
                        Console.WriteLine("Welcome to list");
                        List_Demo list_Demo = new List_Demo();
                        list_Demo.Adding();
                        Console.ReadLine();
                        break;
                    case 2:
                        Array_Demo array_Demo = new Array_Demo();
                        array_Demo.Add();
                        Console.ReadLine();
                        break;
                    case 3:
                        Array_List array_List = new Array_List();
                        array_List.MyArrayList();
                        Console.ReadLine();
                        break;
                    case 4:
                        Dictionary_Demo dictionary_Demo = new Dictionary_Demo();
                        dictionary_Demo.Dictionary();
                        Console.ReadLine();
                        break;

                }
            }
            
        }
    }
}
