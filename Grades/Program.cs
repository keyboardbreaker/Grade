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
            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();


            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine("{0}: {1} ", stats.LetterGrade, stats.Description);
            Console.ReadKey();
        }

    }
}
