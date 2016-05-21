using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        { 
            GradeBook book = new GradeBook("yj's book");
            book.AddGrade(91f);
            book.AddGrade(89.1f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistics();


            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LetterGrade);
            Console.ReadKey();
        }

    }
}
