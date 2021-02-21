using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Tasks
{
    public partial class Program
    {
        const string pathTask3 = @"..\..\..\Tasks\Data\DataForMaxPairs.txt";
        const string pathTask1 = @"..\..\..\Tasks\Data\DataForPairs.txt";

        static void Main(string[] args)
        {
            //Task1

            List<string> dataForTask1 = File.ReadAllLines(pathTask1).ToList();
            Task1 task1 = new Task1();
            Console.WriteLine($"**Task1** \n");
            Console.WriteLine($"Input  ---->  Output");
            Console.WriteLine($"------------------------\n");
            foreach (var data in dataForTask1)
            {
                var pairCount = task1.Pair(data);
                Console.WriteLine($"{string.Join(",", data)} --> {pairCount}");

            }

            //Task3
            List<int[]> dataForTask3 = File.ReadAllLines(pathTask3).Select(line => JsonConvert.DeserializeObject<int[]>(line))
                                         .ToList();           
            Pair pair = new Pair();
            Console.WriteLine($"\n\n**Task3** \n");
            Console.WriteLine($"Input  ---->  Output");
            Console.WriteLine($"------------------------\n");
            foreach (var numbers in dataForTask3)
            {
                var pairCount = pair.MaxPair(numbers);
                Console.WriteLine($"{string.Join(",",numbers)} --> {pairCount}");

            }    

            Console.WriteLine("\npress any key to exit the process...");
            Console.ReadKey();

        }       
    }
}