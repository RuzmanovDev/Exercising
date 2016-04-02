namespace DataStructures
{
    using System;

    public class CustomArrayList
    {
        private object[] arr;
        private int count;

        //returns the actual list length
        public int Count
        {
            get
            {
                return count;
            }
        }

        private static readonly int INITIAL_CAPACITY = 4;

        //Initializes the array-based list - allocate memory

        public CustomArrayList()
        {
            arr = new object[INITIAL_CAPACITY];
            count = 0;
        }

        //adds element to the list 
        public void Add(object item)
        {
            Insert(count, item);
        }

        // inserts the specified element at a given position in this list
        private void Insert(int index, object item)
        {
            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index: " + index);
            }
            object[] extendedArr = arr;
            if (count + 1 == arr.Length)
            {
                extendedArr = new object[arr.Length * 2];
            }
            Array.Copy(arr, extendedArr, index);
            count++;
            Array.Copy(arr, index, extendedArr, index + 1, count - index - 1);
            extendedArr[index] = item;
            arr = extendedArr;
        }

        //returns the inex of the first occurrence
        //returns -1 if the item is not found
        public int IndexOf(object item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (item == arr[i])
                {
                    return i;
                }
            }
            return -1;
        }
        //clear the list
        public void Clear()
        {
            arr = new object[INITIAL_CAPACITY];
            count = 0;
        }
        //checks if an element exists
        public bool Contains(object item)
        {
            int index = IndexOf(item);
            bool found = (index != -1);
            return found;
        }
        //retrives the element on the set index
        public object this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }
                return arr[index];
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }
                arr[index] = value;
            }
        }

        //Removes elemen at the specific index
        public object RemoveAt(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }
            object item = arr[index];
            Array.Copy(arr, index + 1, arr, index, count - index + 1);
            arr[count - 1] = null;
            count--;

            return item;
        }
        //removes the specified item
        public int Remove(object item)
        {
            int index = IndexOf(item);
            if (index == -1)
            {
                return index;
            }
            Array.Copy(arr, index + 1, arr, index, count - index + 1);
            count--;
            return index;
        }
    }
}
