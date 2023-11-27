using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Empoyee
    {
        private List<float> grades = new List<float>();
        public Empoyee( string name,  string surname , int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        
        public string Name { get;  private set; }
        public string Surname { get; private set; }
        public int Age { get; private set;}

        //public float Result
        //{
        //    get { return grades.Sum(); }
        //}
        public void AddGrade(float number) 
        {
           grades.Add(number);
        }

        public Statistics GetStatistics()
        {
            var statistic = new Statistics();
            statistic.Average = 0;
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                statistic.Max = Math.Max(statistic.Max, grade);
                statistic.Min = Math.Min(statistic.Min, grade);

                statistic.Average += grade; 
            }   
            statistic.Average = statistic.Average / grades.Count;

            return statistic;
        }

    }
}
