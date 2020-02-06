using System;
using System.IO;


namespace ConsoleApp.Exercises
{
    class ExFiles
    {
        public static void Run()
        {
            var workingDirectory = Environment.CurrentDirectory;
            var projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            var sampleFilePath = $"{projectDirectory}\\Sample File.txt";
            string text = File.ReadAllText(sampleFilePath);
            text = text.Replace("  ", " ");
            text = text.Replace("\n", "");

            int numberOfWords = 0;

            string[] words = text.Split(' ');
            string longestWord = "";

            foreach (var word in text.Split(' '))
            {
                if (!string.IsNullOrWhiteSpace(word) && !string.IsNullOrEmpty(word))
                {
                    numberOfWords += 1;
                }

                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }

            }

            Console.WriteLine(string.Format("Total number of words: {0} and the longest word is {1}.",
                numberOfWords,
                longestWord
            ));

        }
    }
}
