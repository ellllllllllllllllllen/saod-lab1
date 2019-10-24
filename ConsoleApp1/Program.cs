using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Program
    {
        //Вычисляет большее по модулю число из массива
        static void Max(int[] arr) //1
        {
            int max = Math.Abs(arr[0]); //1
            for (int i = 0; i < arr.Length; i++) //1+2n    
                if (max < Math.Abs(arr[i])) //n
                    max = Math.Abs(arr[i]); //0...n    
            Console.WriteLine("The max module element of array: " + max); //1        
        }
        //Вычисляет сумму элементов между первым и вторым положительными числами
        static void Sum(int[] arr) //1
        {
            int sum = 0; //1
            int first = 0; //1
            int second = 0; //1
            for (int i = 0; i < arr.Length; i++) //1+2n
            {
                if (arr[i] > 0) //n
                {
                    first = i; //0...n
                    break; //1
                }
            }
            for (int i = first + 1; i < arr.Length; i++) //1+2n
            {
                if (arr[i] > 0) //n
                {
                    second = i; //0...n
                    break; //1
                }
            }
            for (int k = first + 1; k < second; k++) //1+2n
                sum += arr[k]; //0...n

            Console.WriteLine("The sum of the elements of the array located between the first and second positive elements: " + sum); //1
           
        }
        static void Main(string[] args)
        {
            int[] arr = { 4, -6, -3, 8, 3, -9, 2, 6, -5, 4 }; //1
            Max(arr); //1
            Sum(arr); //1
        }
    }
}
