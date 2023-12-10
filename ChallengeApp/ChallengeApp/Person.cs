namespace ChallengeApp
{
    public   class Person
    {
        public  Person(string name, string surname, int age, char sex)
        {
            Name = name; 
            Surname = surname;
            Age = age;
            Sex = sex;           
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public char Sex { get; private set;}

    }
}
