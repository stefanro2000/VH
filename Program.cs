using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//task: count identical entries in a list/array, etc.
namespace Count_Identical
{
    class Program
    {
        private static IEnumerable<KeyValuePair<string, int>> FindDuplicates(string[] list) {
            Dictionary<string, int> stringSet = new Dictionary<string, int>();
            foreach (var item in list)
            {
                int count;
                if (stringSet.TryGetValue(item, out count))
                {
                    stringSet[item] = count + 1;
                }
                else
                {
                    stringSet[item] = 1;
                }
            }
            return stringSet.Where(p => p.Value >1);
        }


        public static int Count_Entries(string[] list)
        {
            HashSet<string> stringSet = new HashSet<string>();
            int count= 1;
            foreach (var item in list)
            {
                if (stringSet.Contains(item))
                {
                    count++;
                }
                else
                {
                    stringSet.Add(item);
                }               
            }
            return count;
        }

        static void Main(string[] args)
        {
            int result;
            IEnumerable<KeyValuePair<string, int>> output = new Dictionary<string, int>();
            String[] list = { "abc", "adc", "adv", "abc", "acd" };
            result =  Count_Identical.Program.Count_Entries(list);
            output = FindDuplicates(list);
            output.ToList().ForEach(x => Console.WriteLine(x.Key));

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
