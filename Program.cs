using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodePractice_Arrays_AdamIshak
{
    internal class Program
    {
        static void Main(string[] args)


        {
            string[] students = new string[5] { "Zach", "Wong", "Hannah", "Kris", "Sam" };
            Console.WriteLine("Student Names:");
            for (int i = 0; i < students.Length; i++)

             Console.WriteLine(students[i]);

            int[] numbers = new int[] { 5, 12, 8, 88, 7 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) ;

            Console.WriteLine(numbers[sum]);

            Console.WriteLine($"Sum: {sum}");
            double[] doubles = new double[] { 5.2, 7.9, 10.0, 4, 9.7 };
            Console.WriteLine(doubles);

            foreach (var num in doubles) ;

            Console.WriteLine("var num in doubles");

            


        }









    }  
    


 }       
       


    


