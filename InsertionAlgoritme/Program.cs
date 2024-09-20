namespace InsertionAlgoritme
{
    using System.Collections.Immutable;
    using System.Diagnostics;
    using System.IO;
    using System.Security.Cryptography.X509Certificates;

    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = ReadNumbersFromFile(@"C:\Users\nqvis\OneDrive\Skrivebord\Datamatiker\InsertionAlgoritme\InsertionAlgoritme\InsertionAlgoritme\10000WorstCaseSort.txt");
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number + ", ");
            //}

            //Opgave 2.

            //int[] numbers = ReadNumbersFromFile(@"C:\Users\nqvis\OneDrive\Skrivebord\Datamatiker\InsertionAlgoritme\InsertionAlgoritme\InsertionAlgoritme\100.txt");
            //Console.WriteLine("Inden sortering:");
            //PrintIntergerArray(numbers);
            //
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Efter sortering:");
            //InsertionSort(numbers);
            //PrintIntergerArray(numbers);

            //Opgave 4.

            //int[] numbers = ReadNumbersFromFile(@"C:\Users\nqvis\OneDrive\Skrivebord\Datamatiker\InsertionAlgoritme\InsertionAlgoritme\InsertionAlgoritme\TextFile1.txt");
            //Console.WriteLine("Inden sortering:");
            //PrintIntergerArray(numbers);
            //Console.WriteLine();
            //Console.WriteLine("Efter sortering:");
            //InsertionSort(numbers);
            //PrintIntergerArray(numbers);
            //Console.WriteLine();

            //Opgave 5.

            //int[] numbers = ReadNumbersFromFile(@"C:\Users\nqvis\OneDrive\Skrivebord\Datamatiker\InsertionAlgoritme\InsertionAlgoritme\InsertionAlgoritme\100.txt");
            //
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //
            //InsertionSort(numbers);
            //PrintIntergerArray(numbers);
            //
            //stopwatch.Stop();
            //
            //Console.WriteLine($"Tid til at sortere: {stopwatch.Elapsed.TotalMilliseconds} ms");

            //Opgave 6.

            //int[] numbers = ReadNumbersFromFile(@"C:\Users\nqvis\OneDrive\Skrivebord\Datamatiker\InsertionAlgoritme\InsertionAlgoritme\InsertionAlgoritme\1000.txt");
            ////Første test blev 355, 8011 ms.
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //
            //InsertionSort(numbers);
            //PrintIntergerArray(numbers);
            //stopwatch.Stop();
            //Console.WriteLine($"Tid til at sortere: {stopwatch.Elapsed.TotalMilliseconds} ms");

            //Opgave 9.

            //int[] numbers = ReadNumbersFromFile(@"C:\Users\nqvis\OneDrive\Skrivebord\Datamatiker\InsertionAlgoritme\InsertionAlgoritme\InsertionAlgoritme\10000.txt");
            //
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //
            //InsertionSort(numbers);
            //PrintIntergerArray(numbers);
            //stopwatch.Stop();
            //Console.WriteLine($"Tid til at sortere: {stopwatch.Elapsed.TotalMilliseconds} ms");

            //Opgave 11.

            //int[] numbers = ReadNumbersFromFile(@"C:\Users\nqvis\OneDrive\Skrivebord\Datamatiker\InsertionAlgoritme\InsertionAlgoritme\InsertionAlgoritme\10000SemtSort.txt");
            //
            //Stopwatch sw = Stopwatch.StartNew();
            //sw.Start();
            //
            //InsertionSort(numbers);
            //PrintIntergerArray(numbers);
            //
            //sw.Stop();
            //
            //Console.WriteLine($"Tid til at sortere: {sw.Elapsed.TotalMilliseconds} ms");

            //Opgave 12.

            int[] numbers = ReadNumbersFromFile(@"C:\Users\nqvis\OneDrive\Skrivebord\Datamatiker\InsertionAlgoritme\InsertionAlgoritme\InsertionAlgoritme\10000WorstCaseSort.txt");
            
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            
            InsertionSort(numbers);
            PrintIntergerArray(numbers);
            
            sw.Stop();
            
            Console.WriteLine($"Tid til at sortere: {sw.Elapsed.TotalMilliseconds} ms");
        }

        static int[] InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for(int j = i + 1; j > 0; j--)
                {
                    if(inputArray[j -1] > inputArray[j])
                    {
                        int temp = inputArray[j -1];
                        inputArray[j -1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }
        static void PrintIntergerArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.WriteLine(i.ToString());
            }
        }
        static int[] ReadNumbersFromFile(string filePath)
        {
            try
            {
                string fileContent = File.ReadAllText(filePath);

                string[] stringNumbers = fileContent.Split(',');

                int[] numbers = new int[stringNumbers.Length];

                for (int i = 0; i < stringNumbers.Length; i++)
                {
                    numbers[i] = int.Parse(stringNumbers[i].Trim());
                }
                return numbers;
            }
            catch (Exception ex) 
            {
                Console.WriteLine("FEjl under læsning af fil:" + ex.Message);
                return new int[0];
            }
        }
    }
}
