using System;
using System.Collections.Generic;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int max_size = 64 * 1024;
            Console.Write("Enter number of sectors: ");
            int c = ConsoleInput.Int(1, ConsoleInput.Infinity);
            List<int> sections = new();
            for (int i = 0; i < c-1; i++)
            {
                Console.Write($"Enter size of sector {i + 1}: ");
                int currentSector = ConsoleInput.Int(1, max_size);
                sections.Add(currentSector);
                max_size -= currentSector;
                Console.WriteLine($"Successfuly added sector. Space remains: {max_size}");
            }
            sections.Add(max_size);
            _ = new Sections();
        }
    }
}
