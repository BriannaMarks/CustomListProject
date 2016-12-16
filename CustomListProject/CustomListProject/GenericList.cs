using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class GenericList<T> : IEnumerable
    {
        private T[] innerArray;
        private GenericList<T> randomList;
        T value;
        int listItem;
        bool checkForItem;
        public bool CheckForItem
        {
            get
            {
                return checkForItem;
            }
            set
            {
                checkForItem = value;
            }
        }
        public void IterationTest()
        {
            innerArray = new T[] {};
            randomList = new GenericList<T>() {};
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            int index;
            for (index = 0; index < innerArray.Length; index++)
            {
                yield return innerArray[index];
            }
            yield return "End of List";
        }

        public void CheckForListItem(T item)
        {
            if (item.Equals(randomList.value))
            {
                randomList.CheckForItem = true;   
            }
            else
            {
                randomList.CheckForItem = false;
            }
        }
        public void AddValueToArray(T item)
        {
            T[] addingArray = new T[innerArray.Length + 1];
            for (int i = 0; i < innerArray.Length; i++)
            {
                addingArray[i] = innerArray[i];
            }
            addingArray[innerArray.Length] = item;
            innerArray = addingArray;
        }
        public void RemoveValueFromList(T item)
        {
            T[] removingArray = new T[innerArray.Length - 1];
            for (int i = 0; i < innerArray.Length; i++)
            {
                if (checkForItem == true)
                {
                    removingArray[i - 1] = innerArray[i];
                }
                else
                {
                    removingArray[i] = innerArray[i];
                }
            }
            innerArray = removingArray;
        }
        public void CustomZipper(GenericList<T> FirstList, GenericList<T> SecondList)
        {
            if (FirstList.innerArray.Length > SecondList.innerArray.Length || FirstList.innerArray.Length < SecondList.innerArray.Length || FirstList.innerArray.Length == SecondList.innerArray.Length)
            {
                for (int i = 0; i < SecondList.innerArray.Length; i++)
                {
                    Console.WriteLine("{0} {1}", FirstList.innerArray[i], SecondList.innerArray[i]);
                }
                for (int i = SecondList.innerArray.Length; i < FirstList.innerArray.Length; i++)
                {
                    Console.WriteLine("{0}", FirstList.innerArray[i]);
                }
            }
        }
        public override string ToString()
        {
            string value = "random";

            return "Test:" + value;
        }
        public int CustomCount()
        {
            int index = 0;
            for (int i = 0; i < innerArray.Length; i++)
            {
                index++;
            }
            return index;
        }
    }
}
