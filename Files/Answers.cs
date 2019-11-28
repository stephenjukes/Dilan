using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Files
{
    class Answers
    {
        static string fileInFolderA = @"c:\Users\Stephen\source\repos\Dilan\Files\Resources\FolderA\Test.txt";
        static string fileInFolderB = @"c:\Users\Stephen\source\repos\Dilan\Files\Resources\FolderB\Test.txt";
        static string fileInFolderC = @"c:\Users\Stephen\source\repos\Dilan\Files\Resources\FolderC\Test.txt";
        static string dictionary = @"c:\Users\Stephen\source\repos\Dilan\Files\Resources\Oxford_English_Dictionary.txt";
        static string[] filePaths = new string[] { fileInFolderA, fileInFolderB, fileInFolderC };

        public void Demonstrate()
        {
            DeleteFiles();

            var fileInfo = new FileInfo(fileInFolderA);
            using (fileInfo.Create()) { } ;

            fileInfo.AppendText();

            fileInfo.MoveTo(fileInFolderB);
            fileInfo.CopyTo(fileInFolderC);
            Console.WriteLine(fileInfo.Exists);

        }

        public void Demonstrate(FileMethod fileMethod)
        {
            typeof(Answers).GetMethod(fileMethod.ToString(), BindingFlags.NonPublic | BindingFlags.Instance).Invoke(this, null);
        }

        private void DeleteFiles()
        {
            foreach (var path in filePaths)
            {
                if (File.Exists(path)) File.Delete(path);
            }
        }

        private void Dictionary()
        {
            var word = "Abandon";
            var exerpt = new StringBuilder();
                  
            var pattern = word + @"[^a-z]";
            var items = File.ReadAllLines(dictionary)
                    .Where(line => !string.IsNullOrEmpty(line))
                    .Where(line => {
                        var firstWord = line.Split("  ")[0] == word;
                        //var match = Regex.Match(line, pattern).Value;
                        return firstWord;
                        //return !String.IsNullOrEmpty(match);
                    });

           foreach (var item in items)
            {
                var keyValuePair = item.Split("  ").ToList();

                var keyWord = keyValuePair[0];
                exerpt.AppendLine(keyWord);

                var value = keyValuePair[1];

                var partsOfSpeech = Regex
                    .Split(value, @"(?<=(\W?[nv]\.\s))")
                    .Where(part => !String.IsNullOrEmpty(part));

                foreach (var partOfSpeech in partsOfSpeech)
                {
                  
                    var definitions = Regex.Split(partOfSpeech, @"\.\s\d+");

                    foreach (var definition in definitions)
                    {
                        exerpt.AppendLine($"  {Array.IndexOf(definitions, definition) + 1}. {definition}");
                    }

                }

                Console.WriteLine(exerpt);
            }
        }

        private void CheckFilesExist()
        {
            Console.WriteLine("File exists in ...");
            foreach (var path in filePaths)
            {
                var pathArray = path.Split(@"\");
                var folder = pathArray[pathArray.Length - 2];

                Console.WriteLine($"- {folder}: {File.Exists(path)}");
            }
        }

        private void Create()
        {
            using (File.Create(fileInFolderA)) { } ;
        }

        private void AppendAllText()
        {
            File.AppendAllText(fileInFolderA, "A Bit of Fun\n\n");
        }

        private void AppendAllLines()
        {
            File.AppendAllLines(fileInFolderA, new string[] { "There once was a man called Bright", "Who could walk at the speed of light", "He went out one day", "In a relative way", "And came back the previous night" });
        }

        private void MoveAtoB()
        {
            File.Move(fileInFolderA, fileInFolderB);
        }

        private void CopyBtoC()
        {
            File.Copy(fileInFolderB, fileInFolderC);
        }

        private void ReadAllText()
        {
            var content = File.ReadAllText(fileInFolderC);

            Console.WriteLine($"{content.GetType()}\n");
            Console.WriteLine(content);
        }

        private void ReadAllLines()
        {
            var content = File.ReadAllLines(fileInFolderC);

            Console.WriteLine($"{content.GetType()}\n");
            foreach (var line in content)
            {
                Console.WriteLine(line);
            }
        }
    }
}
