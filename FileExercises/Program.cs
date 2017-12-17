using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read all text in a file, and output the number of words
            //var path = @"C:\Users\Benjamin\Desktop\FileExercise.txt";

            //var text = File.ReadAllText(path);
            //var words = text.Split(' ');

            //int count = 0;
            //foreach (var word in words)
            //{
            //    count++;
            //}

            //Console.WriteLine("Words in file: " + count);
            //Console.ReadKey();


            //Read a text file and display the longest word in the file.
            var path = @"C:\Users\Benjamin\Desktop\FileExercise.txt";

            var text = File.ReadAllText(path);
            var words = text.Split(' ');

            string longestWord = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > longestWord.Length)
                {
                    longestWord = words[i];
                }
            }

            Console.WriteLine("Longest word in file: " + longestWord);
            Console.ReadKey();
        }
    }
}
