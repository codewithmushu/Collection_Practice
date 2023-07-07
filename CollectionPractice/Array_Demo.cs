using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    //Array is a collection of elements with same data type
    //Array index starts with zero
    //we can store only fix set of element in the array
    public class Array_Demo
    {
        public void Add()
        {
            //int[] myArray = { 1, 2, 3, 4 };
            //int[] myArray_Two =new int[5] ;
            Console.WriteLine("****************************");
            int[] myArray = new int[10];
            string[] myArray2 = new string[10];
            Console.WriteLine("****************************");
            int[] obj= new int[] {1,2,3,4};
            int[] ints = {5,6,7};
            Console.WriteLine("****************************");
            string[] strings_One = new string[5] {"Muskan","Amin","Shaikh","Sarfraz","Shaikh"};
            foreach(string ele in strings_One)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("****************************");
            for (int val=0; val<strings_One.Length; val++)
            {
                Console.WriteLine(strings_One[val]);
            }
            Console.WriteLine("****************************");
            int value = 0;
            while(value < strings_One.Length)
            {
                Console.WriteLine(strings_One[value]);
                value++;
            }
            string[] strings_Two = new string[] {"Apple","Banana" };
            Console.WriteLine("****************************");
        }
    }
}
