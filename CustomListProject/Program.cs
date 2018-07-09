using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> firstList = new CustomList<int>();
            int value = 10;
            firstList.Add(value);
            firstList.Add(value);
            firstList.Add(value);
            firstList.Add(value);
            firstList.Add(value);
            firstList.Add(value);
            firstList.Add(value);
            firstList.Add(value);
            firstList.Add(value);
            firstList.Add(value);
            foreach (int i in firstList)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
