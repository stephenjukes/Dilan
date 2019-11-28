using System;
using System.Collections;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercises

            // Use the static File class to ...

            // Create a file in location A (with a path argument)

            // Append a text string to the file

            // Append multiple lines of text to the file

            // Move the file to another location (B) (and change the name if you want)

            // Copy the file to another location (C)

            // Check if this file exists in each of your locations (A, B and C)

            // Read the content as a single string and log it to the console

            // Read the content as a collection of lines and log them to the console

            // Delete the file from each lcoation

            var answers = new Answers();
            answers.Demonstrate(FileMethod.Dictionary);

            
        }
    }

    enum FileMethod
    {
        DeleteFiles,
        CheckFilesExist,
        Create,
        AppendAllText,
        AppendAllLines,
        MoveAtoB,
        CopyBtoC,
        ReadAllText,
        ReadAllLines,
        Dictionary
    }
}


