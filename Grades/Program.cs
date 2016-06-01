using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.IO;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        { 
            GradeBook book = new GradeBook("yj's book");
            try
            {
                string[] lines = File.ReadAllLines("grades.txt");
                foreach (string line in lines)
                {
                    float grade = float.Parse(line);
                    book.AddGrade(grade);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Could not locate the file grades.txt");
                return;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("No access");
                return;
            }

            book.WriteGrades(Console.Out);
            try
            {
                Console.WriteLine("Please Emter a name for the book");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Invalid Name");
            }

            GradeStatistics stats = book.ComputeStatistics();


            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine("{0}: {1} ", stats.LetterGrade, stats.Description);
            Console.ReadKey();
        }

    }
}
