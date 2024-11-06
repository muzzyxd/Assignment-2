using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        // First One
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        // Second
        static int FindMax(int num1, int num2, int num3)
        {
            int max = num1;

            if (num2 > max)
                max = num2;

            if (num3 > max)
                max = num3;

            return max;
        }

        //Third
        static double CalculateAverage(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3);
        }

        //Fourth
        static int FindMin(int num1, int num2, int num3)
        {
            int min = num1;

            if (num2 < min)
                min = num2;

            if (num3 < min)
                min = num3;

            return min;
        }

        //Fifth
        static double ConvertToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static void Main(string[] args)
        { 
    //-------------------------------------1

            int number1 = 5;
            int number2 = 4;

            int result = Multiply(number1, number2);

            Console.WriteLine($"The result of multiplying {number1} and { number2} is: { result}");

    //-------------------------------------2

            int n1 = 5;
            int n2 = 10;
            int n3 = 7;

            int max = FindMax(n1, n2, n3);

            Console.WriteLine($"The largest of the three numbers is: {max}");

    //--------------------------------------3
            int no1 = 8;
            int no2 = 15;
            int no3 = 22;

            double average = CalculateAverage(no1, no2, no3);

            Console.WriteLine($"The average of the three numbers is: {average}");
    //--------------------------------------4

            int num1 = 8;
            int num2 = 15;
            int num3 = 5;

            int minimum = FindMin(num1, num2, num3);

            Console.WriteLine($"The smallest of the three numbers is: {minimum}");

            //--------------------------------------5

            double celsiusTemp = 25.0;

            double fahrenheitTemp = ConvertToFahrenheit(celsiusTemp);

            Console.WriteLine($"The temperature in Fahrenheit is: {fahrenheitTemp}");

            Console.ReadLine();

        }
    }
}
