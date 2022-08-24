using TestingExperience.DateTimeFuncs;

namespace TestingConsoleFunctions
{
    public class DateTimeFuncsTests
    {
        [TestCase(2019, 09, 10)]
        [TestCase(2021, 09, 10)]
        [TestCase(2020, 09, 10)]
        public void IsDateTimeBeforeToday_True(int year, int month, int day)
        {
            var dateTime = new DateTime(year, month, day);
            Assert.IsTrue(DateTimeComparisons.IsDateBeforeNow(dateTime));
        }

        [TestCase(2022, 09, 10)]
        [TestCase(2023, 09, 10)]
        [TestCase(2024, 09, 10)]
        public void IsDateTimeAfterToday_True(int year, int month, int day)
        {
            var dateTime = new DateTime(year, month, day);
            Assert.IsTrue(DateTimeComparisons.IsDateAfterNow(dateTime));
        }

        [TestCase(2022, 08, 15)]
        public void IsDateTimeToday_True(int year, int month, int day)
        {
            var dateTime = new DateTime(year, month, day);
            Assert.IsTrue(DateTimeComparisons.IsDateNow(dateTime));
        }
    }
}