namespace ChallengeApp
{
    public interface IEmployee
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }

        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(double grade);
        void AddGrade(char grade);
        void AddGrade(int grade);
        Statistics GetStatistics();
    }
}
