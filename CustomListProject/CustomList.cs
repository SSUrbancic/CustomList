using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable<T>
    {
        //Members(HAS A)

        // generic aray
        public T[] myArray;
        private int count;
        private int capacity;


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
        public static CustomList<T> operator +(CustomList<T> List1, CustomList<T> List2)
        {
            CustomList<T> combinedList = new CustomList<T>();
            for(int i = 0; i < List1.count; i++)
            {
                combinedList.Add(List1[i]);
            }
            for (int i = 0; i < List2.count; i++)
            {
                combinedList.Add(List2[i]);
            }
            return combinedList;
        }
        public static CustomList<T> operator -(CustomList<T> List1, CustomList<T> List2)
        {
            T value;
            for (int i = 0; i < List1.count; i++)
            {
                value = List1[i];
                for (int j = 0; j < List2.count; j++)
                {
                    if (value.Equals(List2[j]))
                    {
                        List1.Remove(value);
                    }
                }
            }
            return List1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return myArray[i];
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
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
                for(int i = 0; i < count; i++)
                {
                    tempArray[i] = myArray[i];
                }
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
        public override string ToString()
        {
            int excessCount = capacity - count;
            int excessCharacterCount = excessCount * 2;
            StringBuilder newString = new StringBuilder();
            foreach (T i in myArray)
            {
                newString.Append(i).Append(", ");
            }
            string myArrayString = newString.ToString().Remove(newString.Length - excessCharacterCount - excessCount - 2);
            return myArrayString;
        }
        public CustomList<T> Zip(CustomList<T> List1, CustomList<T> List2)
        {
            CustomList<T> zippedArray = new CustomList<T>();
            T[] tempArray = new T[capacity];
            for (int i = 0; i < List1.count; i++)
            {
                for(int j = 0; j < List2.count; j++)
                {
                    zippedArray.Add(List1[i]);
                    zippedArray.Add(List2[j]);
                }
            }
            return zippedArray;
        }
    }
}
