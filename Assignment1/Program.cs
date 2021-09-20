using System;
using System.IO;

namespace Assignment1
{
    class Program
    {

        static void Main(string[] args)
        {
            int size = 0;
            Console.Write("Enter array size: ");
            size = int.Parse(Console.ReadLine());
            if (size < 5)
            {
                Console.Write("Please Enter array size grater than 30: ");
                size = int.Parse(Console.ReadLine());
                if (size < 30)
                {
                    Console.WriteLine("You entered invalid array size.");
                    return;
                }
            }
            int[] arr = new int[size];
            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            printArray(arr, size);

            void printArray(int[] arr, int size)
            {
//                Console.WriteLine("Array elements are:");
                foreach (var number in arr)
                {
//                    Console.WriteLine(number);
                }
            }

            string file = "../../../DataFiles/TextFile1.txt";  // 3 directories back for reaching folder Assignment1 from folders: bin\Debug\netcoreapp3.1\

            // if file exists, empty the file
            if (File.Exists(file))
            {
                File.WriteAllText(file, "");
            }

            StreamWriter sw = new StreamWriter(file);
            foreach (var number in arr)
            {
                sw.WriteLine(number);
            }
            sw.Close();
            
            Console.WriteLine("Enter a number: ");
            int input = int.Parse(Console.ReadLine()), count=0;

            string[] fileLines = File.ReadAllLines(file);
           
//            Console.WriteLine("Array elements are: ");
            for (int i = 0; i < fileLines.Length; i++)
            {
                arr[i] = int.Parse(fileLines[i]);
//                Console.Write(" {0}", arr[i]);
            }
            foreach (var number in arr)
            {
                if (number == input)
                    count++;
            }
            Console.WriteLine("Count of all possible Pairs of type ({0},{0}) with unique numbers is: {1}.",input,count/2);   
                                                                                // 10,10,10 can make only one pair of (10,10) formula: count/2 = 3/2 = 1
//            File.Delete(file);
        }
    }
}
