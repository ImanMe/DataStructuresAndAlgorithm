using System;

namespace ArrayDemo
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("----------Array Demo!----------");

            Console.WriteLine();
            Console.WriteLine("Insert and RemoveAt");

            var array = new CustomArray(3);
            array.Insert(10);
            array.Insert(20);
            array.Insert(30);
            array.Insert(40);
            array.Insert(10);
            array.Insert(20);
            array.Insert(30);
            array.Insert(40);
            array.RemoveAt(0);
            //array.RemoveAt(20);
            array.RemoveAt(4);

            PrintArray(array);

            Console.WriteLine();
            Console.WriteLine("Index of");

            Console.WriteLine(array.IndexOf(40));
            Console.WriteLine(array.IndexOf(400));

            Console.WriteLine();
            Console.WriteLine("Max");

            Console.WriteLine(array.Max());

            Console.WriteLine();
            Console.WriteLine("New Array");

            var newArray = new CustomArray(3);
            newArray.Insert(200);
            newArray.Insert(20);
            newArray.Insert(40);

            PrintArray(newArray);

            Console.WriteLine();
            Console.WriteLine("Intersect Array");

            var intersect = array.Intersect(newArray);
            PrintArray(intersect);

            Console.WriteLine();
            Console.WriteLine("Reversed Array");

            var reversedArray = array.Reverse();
            PrintArray(reversedArray);

            Console.WriteLine();
            Console.WriteLine("Insert At");
            array.InsertAt(3,12);
            PrintArray(array);
        }

        public static void PrintArray(CustomArray array)
        {
            foreach (var element in array.Elements)
                Console.WriteLine(element);
        }    
    }
}