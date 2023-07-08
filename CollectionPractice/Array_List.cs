using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    public class Array_List
    {
        //Its a non-Generic collection
        //it is same as array except its size increase dynamically
        //it shows the element of multiple data type
        public void MyArrayList()
        {
            ArrayList arrayList = new ArrayList();  
            arrayList.Add(1);
            arrayList.Add(2.8);
            arrayList.Add("Muskan");
            arrayList.Add("a");
            arrayList.Add("b");
            arrayList.Insert(0, 1);
            arrayList.Insert(10, 20);
            arrayList.Insert(2, "shaikh");
            //arrayList.Remove(1);
            arrayList.RemoveAt(0);
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}
        }
    }
}
