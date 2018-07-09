using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Members(HAS A)

        // generic aray
        public T[] myArray;
        private int count;
        private int capacity;


        //Constructor

        public virtual int Capacity { get; }
        public virtual int Count { get; }
        public CustomList()
        {
            capacity = 5;
            myArray = new T[capacity];
            count = 0;
        }
        //Methods(CAN DO)
        public T this[int i]
        {
            get { return myArray[i]; }
            set { myArray[i] = value; }
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
                //check 60% or 80%
                //cast 
                //type double for temporary value
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
        public void Remove()
        {
            
        }
    }
}

