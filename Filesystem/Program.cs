using System;
using System.IO;

namespace Filesystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = @"C:\Users\opilane\samples";
            string userdirectory = "wishlist";

            string newDirectoryFullPath = @$"{rootdirectory}\{userdirectory}";
            Console.WriteLine(newDirectoryFullPath);

            Directory.CreateDirectory(newDirectoryFullPath);
        }
    }
}
