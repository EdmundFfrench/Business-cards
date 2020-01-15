// Author: Ed French
// SID: EJF143
// Edited: 23/09/2019

using System;
using System.IO;

namespace Business_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable to hold personal information
            string name;
            string telephoneNo;
            string organisation;
            string dateofBirth;
            string age;

            // Set the location fo the file to use
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BusinessCard.txt";

            try
            {
                
                // Create a streamreader to read business card file
                StreamReader sr = new StreamReader(filePath);

                // Read each line of file until there are no more details
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }

                sr.Close();

                // Wait for user to press enter
                Console.ReadLine();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File {0} not found", filePath);
            }

            // Ask user their name
            Console.WriteLine("What is your name?");
            // Assign response to variable
            name = Console.ReadLine();

            // Ask user their telephone no
            Console.WriteLine("What is your phone number?");
            // Assign response to variable
            telephoneNo = Console.ReadLine();

            // Ask user where they work/study
            Console.WriteLine("Where do you work/study?");
            // Assign response to variable
            organisation = Console.ReadLine();

            // Ask user what is there date of birth
            Console.WriteLine("What is your date of birth?");
            // Assign response to variable
            dateofBirth = Console.ReadLine();

            // Ask user's age
            Console.WriteLine("How old are you?");
            // Assign response to variable
            age = Console.ReadLine();

            // Write their details to a text file
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BusinessCard.txt";
            StreamWriter sw = new StreamWriter(docPath);

            // Write user's details on new lines
            sw.WriteLine("Place of work/study: " + organisation);
            sw.WriteLine("Name: " + name);
            sw.WriteLine("Tel No: " + telephoneNo);
            sw.WriteLine("D.O.B: " + dateofBirth);
            sw.WriteLine("Age: " + age);

            // Remeber you must close the streamwriter
            sw.Close();

            // Write user's details to console
            Console.WriteLine("Place of work/study: " + organisation);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Tel No: " + telephoneNo);
            Console.WriteLine("D.O.B: " + dateofBirth);
            Console.WriteLine("Age: " + age);

            // Wait for user to press enter to end program
            Console.ReadLine();
        }
    }
}
