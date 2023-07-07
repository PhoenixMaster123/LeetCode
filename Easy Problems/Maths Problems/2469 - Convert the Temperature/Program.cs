using System;
using System.Collections.Generic;
using System.Linq;

namespace Convert_the_Temperature
{
    internal class Program
    {
        ////////////////////////////////////////////////////////////////////////////// First Variant //////////////////////////////////////////////////
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double[] convertor = ConvertTemperature(celsius);
            Console.WriteLine($"{convertor[0]:F5},  {convertor[1]:F5}");
        }

        private static double[] ConvertTemperature(double celsius)
        {
            double kelvin = Math.Round(celsius + 273.15, 5);
            double fahrenheit = Math.Round(celsius * 1.80 + 32.00, 5);
            return new double[] { kelvin, fahrenheit };
            // return new double[] { celsius + 273.15, celsius * 1.8 + 32.0 }; short version
        }


        ////////////////////////////////////////////////////////////////////////////// Second Variant - with List and method for formating //////////////////////////////////////////////////
        /* static void Main(string[] args)
         {
            double celsius = double.Parse(Console.ReadLine());
             List<double> result = new List<double>();
             ConvertTemperature(celsius,result);
             string formattedResult = FormatResult(result);
             Console.WriteLine(formattedResult);
         }
         private static List<double> ConvertTemperature(double celsius, List<double> result)
        {          
            double kelvin = celsius + 273.15;
            double fahrenheit = celsius * 1.80 + 32.00;
            result.Add(kelvin);
            result.Add(fahrenheit);
            return result;
        }

        private static string FormatResult(List<double> result)
        {
            string[] formattedValues = new string[result.Count];
            for (int i = 0; i < result.Count; i++)
            {
                formattedValues[i] = result[i].ToString("0.00000");
            }
            return string.Join(", ", formattedValues);
        }
        */
        ////////////////////////////////////////////////////////////////////////////// Third Variant - with List//////////////////////////////////////////////////
        /*static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double[] result = new double[2];
            ConvertTemperature(celsius, result);
            Console.WriteLine($"{result[0]:F5}, {result[1]:F5}");
        }

        private static double[] ConvertTemperature(double celsius, double[] finall)
        {
            double[] result = finall;
            double kelvin = celsius + 273.15;
            double fahrenheit = celsius * 1.80 + 32.00;
            result[0] = kelvin;
            result[1] = fahrenheit;
            return result;
        }
        */





    }
}
