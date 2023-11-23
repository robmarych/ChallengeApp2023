namespace ChallengeApp.Tests
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void WhenUserCollectTwoSetOfPoints()
        {
            //    // arrange
            //    int age1 = 10;
            //    int age2 = 3;


            //    // act 
            //    int result = age1 + age2;

            //    // asser

            //    Assert.AreEqual(14, result);

            //    //Assert.Pass();
            // arrange

            var user = new User("Rober", "123456a");

            user.AddScore(5);
            user.AddScore(6);

            // act 
            var result = user.Result;

            //Aramnge

            Assert.AreEqual(11, result);

        }
        [Test]
        public void WhenEmployeeCollectTwoSorues_ShouldCorrectResult()
        {
            //arrang

            var empoyee1 = new Empoyee("Robert", "Nowy", 52);
            empoyee1.AddScore(5);
            empoyee1.AddScore(6);
            empoyee1.AddScore(1);
            empoyee1.AddScore(-12);
            //act 
            var result = empoyee1.Result;

            //Aramnge 
            Assert.AreEqual(0, result);
        }
    }
}