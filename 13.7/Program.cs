using System;

namespace _13._7
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 20;
            int[] numbers = {101,142,147,189,199,
            207,222,234,289,296,
            310,319,388,394,417,
            429,447,521,536,600};

            int empID;
            int results;
           
            Console.WriteLine("Wprowadź identyfikator pracownika.");
            empID = int.Parse(Console.ReadLine());
            results = BinarySeach(numbers, 0, SIZE - 1, empID);

            if (results == -1)
            {
                Console.WriteLine("Nie udało się wyszukać pracownika o takim identyfiaktorze.");
            }
            else
            {
                Console.WriteLine("Znaleziono pracwonika o takim identyfikatorze przy indeksie " + results);
            }


        }
        public static int BinarySeach(int[] array, int first, int last, int value)
        {
            int middle;
            if (first > last)
            {
                return -1;
            }

            middle = (first + last) / 2;

            if (array[middle] == value)
            {
                return middle;
            }

            if (array[middle] < value)
            {
                return BinarySeach(array, middle + 1, last, value);
            }
            else
            {
                return BinarySeach(array, first, middle - 1, value);
            }
        }
    }
}
