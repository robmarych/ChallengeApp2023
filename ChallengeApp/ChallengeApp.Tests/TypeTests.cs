namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        //referemcje
        [Test]
        public void Test()
        {
            //arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Tomasz");

            //act

            //assert
            Assert.AreNotEqual(user1, user2);   
        }

        //wartosciowe
        [Test]
        public void Test2() 
        {
            //arrange
            int number1 = 1;
            int number2 = 2;

            //act

            //asssert
            Assert.AreEqual(number1, number2);  
        }
        private User GetUser(string name) 
        {
            return new User(name);
        }
    }
}
