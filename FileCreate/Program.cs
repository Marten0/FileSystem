using System;
using System.IO;
namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = @"C:\Users\opilane\samples\wishlist";
            Console.WriteLine("Enter file name");
            string fileName = Console.ReadLine();
            string fullFilePath = $@"{rootdirectory}\{fileName}.txt";

            bool directoryExists = Directory.Exists(rootdirectory);
            bool fileExists = File.Exists(fullFilePath);

            if (directoryExists && fileExists)
            {
                Console.WriteLine($"File {fileName} already exists {rootdirectory}");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"wishlist directory does not exist.");
                Directory.CreateDirectory(rootdirectory);
                
                File.Create(fullFilePath);
                

                File.Exists(rootdirectory);
            }
            else
            {
                File.Create(fullFilePath);
                Console.WriteLine($"File {fileName}.txt has been created.½§");
            }
               
        }
    }
}
