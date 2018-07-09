using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        //Members(HAS A)

        // generic aray
        public T[] myArray;
        private int count;
        private int capacity;
        private int length;


        //Constructor
        public CustomList()
        {
            capacity = 5;
            myArray = new T[capacity];
            count = 0;
        }
        //Methods(CAN DO)
        public T this[int i] //INDEXER
        {
            get { return myArray[i]; }
            set { myArray[i] = value; }
        }
        public virtual int Capacity
        {
            get;
        }
        public virtual int Count
        {
            get;
        }
        public void Add(T value)
        {
            TestCapacity();
            myArray[count] = value;
            count++;

        }
        public void TestCapacity()
        {
            double eightyPercentCapacity = capacity * .8;
            if (count == eightyPercentCapacity)
            {
                capacity = capacity * 2;
                T[] tempArray = new T[capacity];
                myArray = tempArray;
            }
        }
        public int Length()
        {
            int length = count;
            return length;
        }
        public void Remove(T value)
        {
            T[] tempArray = new T[capacity];
            int indexOffSet = 0;
            int loopLimit = count;
            bool foundValue = false;
            for (int i = 0; i < loopLimit; i++)
            {
                if (!value.Equals(myArray[i]) && foundValue == true || value.Equals(myArray[i]) && foundValue == true)
                {
                    tempArray[i - indexOffSet] = myArray[i];
                }
                if (value.Equals(myArray[i]) && foundValue == false)
                {
                    foundValue = true;
                    indexOffSet++;
                    count--;
                }
            }
            myArray = tempArray;
        }
    }
}
