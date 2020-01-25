using System;

namespace ArrayDemo
{
    public class CustomArray
    {
        public CustomArray(int length)
        {
            Elements = new int[length];
        }

        public int Count { get; set; }
        public int[] Elements { get; set; }

        public void Insert(int element)
        {
            if (Elements.Length > Count)
            {
                Elements[Count++] = element;
            }
            else
            {
                var biggerArray = new int[Count + 1];
                for (var i = 0; i < Elements.Length; i++)
                    biggerArray[i] = Elements[i];

                Elements = biggerArray;

                Elements[Count++] = element;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > Elements.Length)
                throw new IndexOutOfRangeException($"Input: {index} is either negative or is out of bound for array.");

            var smallerArray = new int[Elements.Length - 1];

            var j = 0;

            for (var i = 0; i < Elements.Length; i++)
            {
                if (i == index) continue;
                smallerArray[j++] = Elements[i];
            }

            Elements = smallerArray;
        }

        public int IndexOf(int element)
        {
            for (var i = 0; i < Elements.Length; i++)
                if (Elements[i] == element)
                    return i;

            return -1;
        }

        public int Max()
        {
            var temp = 0;

            foreach (var element in Elements)
                if (element > temp)
                    temp = element;

            return temp;
        }

        public CustomArray Intersect(CustomArray otherArray)
        {
            var sizeOfIntersectArray = Elements.Length > otherArray.Elements.Length
                ? otherArray.Elements.Length
                : Elements.Length;

            var intersectArray = new CustomArray(sizeOfIntersectArray);

            foreach (var element in Elements)
                if (otherArray.IndexOf(element) > 0)
                    intersectArray.Insert(element);

            return intersectArray;
        }

        public CustomArray Reverse()
        {
            var reversedArray = new CustomArray(Elements.Length);

            var j = 0;

            for (var i = Elements.Length - 1; i >= 0; i--)
                reversedArray.Elements[j++] = Elements[i];

            return reversedArray;
        }

        public void InsertAt(int index, int element)
        {
            var biggerArray = new int[Elements.Length + 1];

            var j = 0;

            for (var i = 0; i < Elements.Length; i++)
            {
                if (j == index) biggerArray[j++] = element;
                biggerArray[j++] = Elements[i];
            }

            Elements = biggerArray;
        }
    }
}