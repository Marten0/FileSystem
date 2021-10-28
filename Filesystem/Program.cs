using System;
using System.IO;

namespace Filesystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = @"C:\Users\opilane\samples";
            Console.WriteLine("Enter directory name");
            string userdirectory = Console.ReadLine();

            string newDirectoryFullPath = @$"{rootdirectory}\{userdirectory}";
            Console.WriteLine(newDirectoryFullPath);

            bool directoryExists = Directory.Exists(newDirectoryFullPath);

            if (directoryExists)
            {
                Console.WriteLine($"{userdirectory} already exists in {rootdirectory}");
            }
            else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"Directory {userdirectory} has been created.");
            }

            Directory.CreateDirectory(newDirectoryFullPath);


        }
    }
}
