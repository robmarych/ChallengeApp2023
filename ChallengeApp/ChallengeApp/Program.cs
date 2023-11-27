
using ChallengeApp;
//using System.Security.Cryptography.X509Certificates;

var employee = new Empoyee("Robert", "Jaki", 25);
employee.AddGrade(2);
employee.AddGrade(26);
employee.AddGrade(6);

var statistics =  employee.GetStatistics();
Console.WriteLine($"Averge: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


//List <Empoyee> lempoyee = new List<Empoyee>();


////lempoyee.Add(new Empoyee () {("XXXX", "SDFASF", 52))_  ;

//Empoyee empoyee1 = new Empoyee("Robert", "Nowy", 52);
//Empoyee empoyee2 = new Empoyee("Damina", "Damianski", 23);
//Empoyee empoyee3 = new Empoyee("Karol", "Kowalski", 44);



//empoyee1.AddScore(3);
//empoyee1.AddScore(4);
//empoyee1.AddScore(5);

//empoyee2.AddScore(4);
//empoyee2.AddScore(5);
//empoyee2.AddScore(6);

//empoyee3.AddScore(1);
//empoyee3.AddScore(2);
//empoyee3.AddScore(3);

//lempoyee.Add(empoyee1);
//lempoyee.Add(empoyee2);
//lempoyee.Add(empoyee3);


//var sum = empoyee1.Result;

//int MaxResult = -1;
//Empoyee ?empoyeeWithMaxReesut = null; 

//foreach (var empoyee in lempoyee)
//{
//    Console.WriteLine( empoyee.Name);
//    if (empoyee.Result > MaxResult )
//    {
//        MaxResult = empoyee.Result;
//        empoyeeWithMaxReesut = empoyee;
//    }
//}

//Console.WriteLine(empoyeeWithMaxReesut.Name +" "+ empoyeeWithMaxReesut.Surname+" "+ empoyeeWithMaxReesut.Age +" "+ empoyeeWithMaxReesut.Result);




//Console.WriteLine(empoyee1.Name +" "+ empoyee1.Surname +" "+empoyee1.Age );

//Console.WriteLine("");


//User user1 = new User("Robert", "1234546789");
//User user2 = new User("Darek", "1234546789");
//User user3 = new User("Karol", "1234546789");
//User user4 = new User("Damian", "1234546789");

//user1.AddScore(5);
//user1.AddScore(2);
//var result = user1.Result;
////foreach (var item in user1.Result)
////{
// //   Console.WriteLine(item);
////}    
//Console.WriteLine( result);

//class User
//{
//    //private int score;
//    private List<int> score = new List<int>();

//    public User(string login, string password)
//    {
//        Login = login;
//        Password = password;
//    }
//    public string Login { get; private set; }
//    public string Password { get; private set; }

//    public int Result   {
//        get 
//        {
//            return score.Sum();
//        }
//    }
//    public void AddScore(int number)
//    {
//        //score += number;
//        score.Add(number);
//    }
//}