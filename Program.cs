using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter length of array: ");

            // הגדרת אורך המערך: 
            int lengthOfArray = Convert.ToInt32(Console.ReadLine());


            // מספר להכפלת התאים. 
            Console.WriteLine("Enter number to multiply: ");
            int NumToMul = Convert.ToInt32(Console.ReadLine());


            // אתחול המערך: 
            int[] arr = new int[lengthOfArray];

            Console.WriteLine($"Num of elements: {lengthOfArray}, num to mul:{NumToMul}");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * NumToMul;
                Console.Write(arr[i] + ", ");
            }

        }
    }
}