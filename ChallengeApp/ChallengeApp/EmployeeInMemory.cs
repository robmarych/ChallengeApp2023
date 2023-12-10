namespace ChallengeApp
{
    public class EmployeeInMemory : EmplyeeBase
    {
        public EmployeeInMemory(string mame, string surname, int age) 
            : base(mame, surname, age)
        {
        }

        public override void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
