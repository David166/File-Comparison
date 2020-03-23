using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Object_Oriented_Programming_Assignment_2
{
    class Program
    {
        // Files that will be compared 
        public static string file1 = ""; 
        public static string file2 = "";
        public static string diff = "The files are different.";
        public static string diffNot = "The files are the same.";
        public 

        static void Main(string[] args)
        {
            UserInterface(); 
        }

        // Function that does a full byte-by-byte comparison to see whether or not two text files are the same
        static void fileCompare(string file1, string file2)
        {
            bool filesAreEqual = File.ReadAllBytes(file1).SequenceEqual(File.ReadAllBytes(file2));

            if (filesAreEqual == true) // If true
            {
                Console.WriteLine(diffNot);
            }
            else // If not
            {
                Console.WriteLine(diff);
            }
        }

        // Function that gets the user's first choice. First text file that is selected
        public static string GetUserFirstChoice(string fileName)
        {
            string choice;
            int choice2; 
            Console.WriteLine("Which two textfiles would you like to compare?\nSelect your first textfile by inputting the number that corresponds to your preferred textfile.\nThe available inputs are 1, 2, 3, 4, 5, 6.\n1 - GitRepositories_1a.txt\n2 - GitRepositories_1b.txt\n3 - GitRepositories_2a.txt\n4 - GitRepositories_2b.txt\n5 - GitRepositories_3a.txt\n6 - GitRepositories_3b.txt");
            choice = Console.ReadLine();
            choice2 = Convert.ToInt32(choice); // The user's input is taken as a string, and then converted into an integer for easier error handling
  
            // Each integer has a corresponding text file
            if (choice2 == 1) fileName = "GitRepositories_1a.txt";
            if (choice2 == 2) fileName = "GitRepositories_1b.txt";
            if (choice2 == 3) fileName = "GitRepositories_2a.txt";
            if (choice2 == 4) fileName = "GitRepositories_2b.txt";
            if (choice2 == 5) fileName = "GitRepositories_3a.txt";
            if (choice2 == 6) fileName = "GitRepositories_3b.txt";

            return fileName; // Must return something
        }

        // Function that gets the user's second choice. Second text file that is selected
        public static string GetUserSecondChoice(string fileName)
        {
            // The exact copy of the function above
            string choice;
            int choice2;
            Console.WriteLine("Now select your second textfile by inputting the number that corresponds to your preferred textfile.\nThe available inputs are 1, 2, 3, 4, 5, 6.\n1 - GitRepositories_1a.txt\n2 - GitRepositories_1b.txt\n3 - GitRepositories_2a.txt\n4 - GitRepositories_2b.txt\n5 - GitRepositories_3a.txt\n6 - GitRepositories_3b.txt");
            choice = Console.ReadLine();
            choice2 = Convert.ToInt32(choice);

            if (choice2 == 1) fileName = "GitRepositories_1a.txt";
            if (choice2 == 2) fileName = "GitRepositories_1b.txt";
            if (choice2 == 3) fileName = "GitRepositories_2a.txt";
            if (choice2 == 4) fileName = "GitRepositories_2b.txt";
            if (choice2 == 5) fileName = "GitRepositories_3a.txt";
            if (choice2 == 6) fileName = "GitRepositories_3b.txt";

            return fileName;
        }


        // Main function that gets called
        static void UserInterface()
        {
            try
            {
                string fileName = "1";
                fileCompare(GetUserFirstChoice(fileName), GetUserSecondChoice(fileName)); // Compares the user's selected text files
            }

            catch // To ensure that the program doesn't full on crash
            {
                Console.WriteLine("A number ranging from 1 to 6 was not inputted. Inputting a non-32bit integer is also unacceptable. Please exit the program and try again.");
            }

        }
    }
}
