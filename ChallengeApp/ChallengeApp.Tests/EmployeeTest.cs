namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {

        [Test]
        public void WhenGetStatisticCalled_ShouldReturnCorrectMAx()
        {
            var employye = new Empoyee("Robert", "Ktoś", 52);

            employye.AddGrade(2);
            employye.AddGrade(3);
            employye.AddGrade(5);

            var statistic = employye.GetStatistics();

            Assert.AreEqual(5, statistic.Max);           
        }


        [Test]
        public void WhenGetStatisticCalled_ShouldReturnCorrectMin()
        {
            var employye = new Empoyee("Robert", "Ktoś", 52);

            employye.AddGrade(2);
            employye.AddGrade(3);
            employye.AddGrade(5);

            var statistic = employye.GetStatistics();

            Assert.AreEqual(2, statistic.Min);
        }

        [Test]
        public void WhenGetStatisticCalled_ShouldReturnCorrectAverge()
        {
            var employye = new Empoyee("Robert", "Ktoś", 52);

            employye.AddGrade(2);
            employye.AddGrade(3);
            employye.AddGrade(5);

            var statistic = employye.GetStatistics();

            Assert.AreEqual(Math.Round(3.33 ,2) , Math.Round(statistic.Average, 2));
        }

        [Test]
        public void TestArequalForeach()
        {
            var employye = new Empoyee("Robert", "Ktoś", 52);

            employye.AddGrade(2);
            employye.AddGrade(3);
            employye.AddGrade(5);

            var statistic = employye.GetStatisticsWhieForeach();
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistic.Average, 2));
           
        }
        [Test]
        public void TestMinForeach()
        {
            var employye = new Empoyee("Robert", "Ktoś", 52);

            employye.AddGrade(2);
            employye.AddGrade(3);
            employye.AddGrade(5);

            var statistic = employye.GetStatisticsWhieForeach();
                        
            Assert.AreEqual(2, statistic.Min);

        }
        [Test]
        public void TestMaxForeach()
        {
            var employye = new Empoyee("Robert", "Ktoś", 52);

            employye.AddGrade(2);
            employye.AddGrade(3);
            employye.AddGrade(5);

            var statistic = employye.GetStatisticsWhieForeach();

            Assert.AreEqual(2, statistic.Man);

        }

    }
}
