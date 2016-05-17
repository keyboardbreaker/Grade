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
        static void GiveBookAName(GradeBook book)
        {
            book.Name = "The GradeBook";
        }

        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Grade Book");
            Arrays();
            //Immutable();
            //PassByValueAndRef();
            //var book = new GradeBook();
            //book.AddGrade(91);
            //book.AddGrade(89.5f);
            //book.AddGrade(75f);
            //GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine("Average: " + stats.AverageGrade);
            //Console.WriteLine("Lowest: " + stats.LowestGrade);
            //Console.WriteLine("Highest: " + stats.HighestGrade);
        }

        private static void Arrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            foreach (float grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        private static void AddGrades(float[] grades)
        {
            if (grades.Length >= 3) { 
                grades[0] = 91f;
                grades[1] = 89.1f;
                grades[2] = 75f;
            }
        }

        private static void Immutable()
        {
            string name = " Yu-Jin ";
            var namePrint = name.Trim();

            Console.WriteLine(name);
            Console.WriteLine(namePrint);
        }

        private static void PassByValueAndRef()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(g2);
            Console.WriteLine(g1.Name);
            Console.ReadKey();
        }
    }
}
