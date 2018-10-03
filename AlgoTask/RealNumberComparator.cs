using System;

namespace AlgoTask
{

    /*      Для Кости - Описать функцию Min2(A,B)1|Max2(A,B)2 вещественного типа, находящую
            минимальное1|максимальное2 из двух вещественных чисел A и B. С помощью этой функции
            найти минимальные1|максимальные2 из пар чисел A и B, A и C, A и D, если даны числа A, B, C, D. 
    */
    public class RealNumberComparator
    {

        public static double Min2(double a, double b)
        {

            if (a < b || Double.IsNaN(a))
            {
                return a;
            }

            return b;
        }

        public static double Max2(double a, double b)
        {
            if (a > b || Double.IsNaN(a))
            {
                return a;
            }

            return b;
        }


        static void Main(string[] args)
        {
            Console.Write("Enter four real numbers (A, B, C, D) separated by whitespace and ended by Enter: ");
            string[] inputNumbers = Console.ReadLine().Split();

            try
            {
                if (inputNumbers == null || inputNumbers.Length < 4)
                {
                    throw new FormatException("Error: unable to parse input or less than 4 numbers were entered.");
                }

                double[] parsedNumbers = new double[inputNumbers.Length];
                for (int i = 0; i < inputNumbers.Length; i++)
                {
                    parsedNumbers[i] = Double.Parse(inputNumbers[i]);
                }

                
                Console.WriteLine($"Finding max (A, B) max({parsedNumbers[0]}, {parsedNumbers[1]}): " + Max2(parsedNumbers[0], parsedNumbers[1]));
                Console.WriteLine($"Finding min (A, B) min({parsedNumbers[0]}, {parsedNumbers[1]}): " + Min2(parsedNumbers[0], parsedNumbers[1]));
                Console.WriteLine($"Finding max (A, C) max({parsedNumbers[0]}, {parsedNumbers[2]}): " + Max2(parsedNumbers[0], parsedNumbers[2]));
                Console.WriteLine($"Finding min (A, C) min({parsedNumbers[0]}, {parsedNumbers[2]}): " + Min2(parsedNumbers[0], parsedNumbers[2]));
                Console.WriteLine($"Finding max (A, D) max({parsedNumbers[0]}, {parsedNumbers[3]}): " + Max2(parsedNumbers[0], parsedNumbers[3]));
                Console.WriteLine($"Finding min (A, D) min({parsedNumbers[0]}, {parsedNumbers[3]}): " + Min2(parsedNumbers[0], parsedNumbers[3]));

            }
            catch(Exception e)
            {
                Console.WriteLine("Errors occured: \n" + e.Message);
            }          
        }
    }
}
