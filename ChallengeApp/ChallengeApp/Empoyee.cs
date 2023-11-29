﻿using System;
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
        public Empoyee( string name,  string surname , int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        
        public string Name { get;  private set; }
        public string Surname { get; private set; }
        public int Age { get; private set;}

 
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {

                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invaliut  grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String in not flota");
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
        //public void AddGrade(int grade)
        //{
        //    this.AddGrade(grade);
        //}

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

            //int index = 0;
            //do
            //{

            //    statistic.Max = Math.Max(statistic.Max, this.grades[index]);
            //    statistic.Min = Math.Min(statistic.Min, this.grades[index]);
            //    statistic.Average += this.grades[index];
            //    index++;

            //} while(index < this.grades.Count);


            return statistic;
        }

        public Statistics GetStatisticsWhieForeach()
        {

            var statistic = SetDefaultStatisctic();
            foreach (var grade in grades)
            {
                statistic.Max = Math.Max(statistic.Max, grade);
                statistic.Min = Math.Min(statistic.Min, grade);
                statistic.Average += grade;
            }
            statistic.Average = statistic.Average / grades.Count;

            return statistic;
        }

        public Statistics SetDefaultStatisctic()
        {
            var statistic = new Statistics();
            statistic.Average = 0;
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue; 
            return statistic;
        }

        public Statistics GetStatisticsWithDoWhie()
        {

            var statistic = SetDefaultStatisctic();

            int index = 0;
            do
            {

                statistic.Max = Math.Max(statistic.Max, this.grades[index]);
                statistic.Min = Math.Min(statistic.Min, this.grades[index]);
                statistic.Average += this.grades[index];
                index++;

            } while (index < this.grades.Count);
            statistic.Average = statistic.Average / grades.Count;

            return statistic;

        }

        public Statistics GetStatisticFor()
        {
            var statistic = SetDefaultStatisctic();
            //int index = 0;

            for (int i = 0; i < grades.Count; i++)
            {
                statistic.Max = Math.Max(statistic.Max, grades[i]);
                statistic.Min = Math.Min(statistic.Min, grades[i]);
                statistic.Average += grades[i];
            }
            statistic.Average=statistic.Average / grades.Count;           

            return statistic;
        }



    }
}
