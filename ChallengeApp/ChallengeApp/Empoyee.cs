using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Empoyee
    {
        private List<float> grades = new List<float>();

        //public Empoyee()
        //    : base(name)
        //{

        //}
        public Empoyee(string name, string surname, int age) //, char sex)
           // :base(name, surname, age , sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
           // this.Sex = sex;

        }
        
         public string Name { get;  private set; }
         public string Surname { get; private set; }
         public int Age { get; private set;}
         //public char Sex { get; private set; }  
 
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {

                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("invaliut  grade value");
                //Console.WriteLine("invaliut  grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char letter))
            {
                AddGrade (letter);
            }

            else
            {
                throw new Exception("String in not flota");
                //Console.WriteLine("String in not flota");
            }
        }

        public void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(long grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(int grade)
        {
            this.AddGrade(grade);
        }

        public void AddGrade(char grade)
        {
            //this.AddGrade((float)grade);


            switch(grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                    this.grades.Add(80);
                    break;
                case 'C':
                    this.grades.Add(60);
                    break;
                case 'D':
                    this.grades.Add(40);
                    break;
                case 'E':
                    this.grades.Add(20);
                    break;
                default:
                    Console.WriteLine("Wrong Letter");
                    break;
            }
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

            switch (statistic.Average)
            {
                case var average when average >= 80:
                    statistic.AvetageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistic.AvetageLetter = 'B';
                    break;
                case var averge when averge >= 40:
                    statistic.AvetageLetter = 'C';
                    break;
                case var averge when averge >= 20:
                    statistic.AvetageLetter = 'D';
                    break;
                default:                 
                    throw new Exception("String in not flota");
            }

            return statistic;
        }

        //public Statistics GetStatisticsWhieForeach()
        //{

        //    var statistic = SetDefaultStatisctic();
        //    foreach (var grade in grades)
        //    {
        //        statistic.Max = Math.Max(statistic.Max, grade);
        //        statistic.Min = Math.Min(statistic.Min, grade);
        //        statistic.Average += grade;
        //    }
        //    statistic.Average = statistic.Average / grades.Count;

        //    return statistic;
        //}

        //public Statistics SetDefaultStatisctic()
        //{
        //    var statistic = new Statistics();
        //    statistic.Average = 0;
        //    statistic.Max = float.MinValue;
        //    statistic.Min = float.MaxValue; 
        //    return statistic;
        //}

        //public Statistics GetStatisticsWithDoWhie()
        //{

        //    var statistic = SetDefaultStatisctic();

        //    int index = 0;
        //    do
        //    {

        //        statistic.Max = Math.Max(statistic.Max, this.grades[index]);
        //        statistic.Min = Math.Min(statistic.Min, this.grades[index]);
        //        statistic.Average += this.grades[index];
        //        index++;

        //    } while (index < this.grades.Count);
        //    statistic.Average = statistic.Average / grades.Count;

        //    return statistic;

        //}

        //public Statistics GetStatisticFor()
        //{
        //    var statistic = SetDefaultStatisctic();
        //    //int index = 0;

        //    for (int i = 0; i < grades.Count; i++)
        //    {
        //        statistic.Max = Math.Max(statistic.Max, grades[i]);
        //        statistic.Min = Math.Min(statistic.Min, grades[i]);
        //        statistic.Average += grades[i];
        //    }
        //    statistic.Average=statistic.Average / grades.Count;           

        //    return statistic;
        //}



    }
}
