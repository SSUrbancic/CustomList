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
            /* CustomList<int> firstList = new CustomList<int>();
             CustomList<int> secondList = new CustomList<int>();
             firstList.Add(1);
             firstList.Add(1);
             firstList.Add(1);
             firstList.Add(1);
             firstList.Add(2);
             firstList.Add(3);
             secondList.Add(1);
             secondList.Add(2);
             secondList.Add(4);
             secondList.Add(6);
             CustomList<int> thirdList = new CustomList<int>();
             thirdList = firstList - secondList;
             foreach (int i in thirdList)
             {
                 Console.WriteLine(i);
             }
             Console.ReadLine();
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();
            CustomList<int> thirdList = new CustomList<int>();
            int value1 = 8;
            int value2 = 9;
            //Act
            firstList.Add(value1);
            firstList.Add(value1);
            firstList.Add(value1);
            firstList.Add(value1);
            firstList.Add(value1);
            secondList.Add(value2);
            secondList.Add(value2);
            secondList.Add(value2);
            secondList.Add(value2);
            thirdList = thirdList.Zip(firstList, secondList);
            int expectedLength = 8;
            int actualLength = thirdList.Length();
            Console.WriteLine(thirdList);
            Console.ReadLine();*/
            CustomList<int> firstList = new CustomList<int>();

            int value1 = 8;
            int value2 = 9;
            //Act
            firstList.Add(value1);
            firstList.Add(value2);
            firstList.Add(value1);
            firstList.Add(value2);
            firstList.Add(value1);
            firstList.Add(value2);
            firstList.Add(value1);
            firstList.Add(value2);
            firstList.Add(value1);
            
            Console.WriteLine(firstList.ToString());
            Console.ReadLine();
        }
    }
}
