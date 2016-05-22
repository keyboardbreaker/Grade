using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Markup;


namespace Grades
{
    public class GradeBook
    {
        public event NamedChangedDelegate NameChanged;

        public string _name;//field
        private List<float> _grades;

        public GradeBook(string name = "There is no Name") //default value
        {
            Name = name;
            _grades = new List<float>();
        }


        public string Name //property
        {
            get { return _name; }

            set
            {
                if (_name != value)
                {
                    var oldValue = _name;
                    _name = value;
                    if (NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.OldValue = oldValue;
                        args.NewValue = value;
                        NameChanged(this, args);
                    }
                }
            } 
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);
            }
        }

        

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats= new GradeStatistics();
            
            float sum = 0f;
            foreach (float grade in _grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum/_grades.Count;
            return stats;
        }

        public void WriteGrades(TextWriter textWriter)
        {
            textWriter.WriteLine("Grades:");
            for (int i = 0; i < _grades.Count; i++)
            {
                textWriter.WriteLine(_grades[i]);
            }
            textWriter.WriteLine("************");
        }
    }
}
