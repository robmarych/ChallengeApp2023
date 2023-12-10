namespace ChallengeApp
{
    public abstract class EmplyeeBase : IEmployee
    {
        public EmplyeeBase(string mame, string surname, int age)
        {
            this.Name = mame;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name {get; private set;}
                
        public int Age { get; private set;}

        public string Surname { get; private set; }
        


        public abstract void AddGrade(string grade);


        public abstract void AddGrade(double grade);

        public abstract void AddGrade(char grade);


        public abstract void AddGrade(int grade);


        public abstract Statistics GetStatistics();
  
    }
}
