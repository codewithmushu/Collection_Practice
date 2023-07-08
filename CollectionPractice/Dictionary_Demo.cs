using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    public class Dictionary_Demo
    {
        //Its a Generic collection it will store key value pair
        //Define under System.Collection.namespace
        //In Dictionary the key can't be null but the value can be null
        //The key must be unique duplicate key is not allaowed
        //We can store only same data type value
        public void Dictionary()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("1","Muskan");
            keyValuePairs.Add("2", "Shaikh");
            keyValuePairs.Add("3", "Food");
            keyValuePairs.Add("4", "Fatima");
            Console.WriteLine("*********************************");
            Console.WriteLine(keyValuePairs["3"]);
            keyValuePairs["2"] = "Audi";
            Console.WriteLine("*********************************");
            Console.WriteLine(keyValuePairs["2"]);
            keyValuePairs.Remove("2");
            Console.WriteLine("*********************************");
            keyValuePairs.Clear();
            foreach(KeyValuePair<string, string> pair in keyValuePairs)
            {
                Console.WriteLine(pair.Key +":" + pair.Value);
            }
            for(int i = 0; i <keyValuePairs.Count; i++)
            {
                var item = keyValuePairs.ElementAt(i);
            }
        }
    }
}
