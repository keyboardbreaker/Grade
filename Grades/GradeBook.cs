using System;
using System.Collections.Generic;


namespace Grades
{
    public class GradeBook
    {
        public string _name;//field
        private List<float> grades;

        public GradeBook(string name = "There is no Name") //default value
        {
            Name = name;
            grades = new List<float>();
        }

        public string Name //property
        { get; set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
        }

        

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats= new GradeStatistics();
            
            float sum = 0f;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum/grades.Count;
            return stats;
        }
    }
}
