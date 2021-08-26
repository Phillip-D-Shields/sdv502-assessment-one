using NUnit.Framework;

namespace AssessmentOne.Tests
{
    // each method in class TicketPriceController is assigned a [TextFixture] class
    // this makes the tests easier to read in the unit tests display
    [TestFixture]
    // testing Adult_Before_5()
    public class AdultBeforeFiveTests
    {
        // each [TextFixture] contains:
        // [TestCase(testArgs,..., expectedResult)]
        // public void When_StateBeingTested_Expect_expectedResult(type params,...)
        //          arrange
        //          act
        //          assert

        // Adult_Before_5(int prQuantity, string prPerson, string prDay, decimal prTime)
        [TestCase(1, "adult", "monday", 4, 14.50)]
        [TestCase(2, "adult", "monday", 4, 29.00)]
        [TestCase(0, "adult", "monday", 4, -1)]
        [TestCase(1, "student", "monday", 4, -1)]
        [TestCase(1, "adult", "monday", 6, -1)]
        [TestCase(1, "adult", "tuesday", 4, -1)]
        public void When_AdultBefore5PM_Expect_CorrectPrice(int argQuantity, string argPerson, string argDay,
            decimal argTime, decimal expectedResult)
        {
            // arrange      create instance for test
            var tpc = new TicketPriceController();
            // act          invoke instance.method(args,...)
            var testData = tpc.Adult_Before_5(argQuantity, argPerson, argDay, argTime);
            // assert       invoke Assert.AreEqual() to return arg equality via bool 
            Assert.AreEqual(testData, expectedResult);
        }
    }

    [TestFixture]
    // testing Adult_After_5()
    public class AdultAfterFiveTests
    {
        // Adult_After_5(int prQuantity, string prPerson, string prDay, decimal prTime)
        [TestCase(1, "adult", "monday", 6, 17.50)]
        [TestCase(2, "adult", "monday", 6, 35.00)]
        [TestCase(0, "adult", "monday", 6, -1)]
        [TestCase(1, "student", "monday", 6, -1)]
        [TestCase(1, "adult", "monday", 4, -1)]
        [TestCase(1, "adult", "tuesday", 6, -1)]
        public void When_AdultAfter5PM_Expect_CorrectPrice(int argQuantity, string argPerson, string argDay,
            decimal argTime, decimal expectedResult)
        {
            // arrange
            var tpc = new TicketPriceController();
            // act 
            var testData = tpc.Adult_After_5(argQuantity, argPerson, argDay, argTime);
            // assert
            Assert.AreEqual(testData, expectedResult);
        }
    }

    [TestFixture]
    // testing Adult_Tuesday()
    public class AdultTuesday
    {
        //   Adult_Tuesday(int prQuantity, string prPerson, string prDay)
        [TestCase(1, "adult", "tuesday", 13.00)]
        [TestCase(2, "adult", "tuesday", 26.00)]
        [TestCase(0, "adult", "tuesday", -1)]
        [TestCase(1, "senior", "tuesday", -1)]
        [TestCase(1, "adult", "monday", -1)]
        public void When_AdultTuesday_Expect_CorrectPrice(int argQuantity, string argPerson, string argDay,
            decimal expectedResult)
        {
            // arrange
            var tpc = new TicketPriceController();
            // act 
            var testData = tpc.Adult_Tuesday(argQuantity, argPerson, argDay);
            // assert
            Assert.AreEqual(testData, expectedResult);
        }
    }

    [TestFixture]
    // testing Child_Under_16()
    public class Child
    {
        //   Child_Under_16(int prQuantity, string prPerson)
        [TestCase(1, "child", 12.00)]
        [TestCase(2, "child", 24.00)]
        [TestCase(0, "child", -1)]
        [TestCase(1, "senior", -1)]
        [TestCase(1, "student", -1)]
        public void When_Child_Expect_CorrectPrice(int argQuantity, string argPerson, decimal expectedResult)
        {
            // arrange
            var tpc = new TicketPriceController();
            // act 
            var testData = tpc.Child_Under_16(argQuantity, argPerson);
            // assert
            Assert.AreEqual(testData, expectedResult);
        }
    }

    [TestFixture]
    // testing Student()
    public class Student
    {
        //   Child_Under_16(int prQuantity, string prPerson)
        [TestCase(1, "student", 14.00)]
        [TestCase(2, "student", 28.00)]
        [TestCase(0, "student", -1)]
        [TestCase(1, "senior", -1)]
        [TestCase(1, "adult", -1)]
        public void When_Child_Expect_CorrectPrice(int argQuantity, string argPerson, decimal expectedResult)
        {
            // arrange
            var tpc = new TicketPriceController();
            // act 
            var testData = tpc.Student(argQuantity, argPerson);
            // assert
            Assert.AreEqual(testData, expectedResult);
        }
    }

    [TestFixture]
    // testing Senior()
    public class Senior
    {
        //   Senior(int prQuantity, string prPerson)
        [TestCase(1, "senior", 12.00)]
        [TestCase(2, "senior", 24.00)]
        [TestCase(0, "senior", -1)]
        [TestCase(1, "child", -1)]
        [TestCase(1, "student", -1)]
        public void When_Senior_Expect_CorrectPrice(int argQuantity, string argPerson, decimal expectedResult)
        {
            // arrange
            var tpc = new TicketPriceController();
            // act 
            var testData = tpc.Senior(argQuantity, argPerson);
            // assert
            Assert.AreEqual(testData, expectedResult);
        }
    }

    [TestFixture]
    // testing Chick_Flick_Thursday()
    public class ChickFlickThursday
    {
        //   Chick_Flick_Thursday(int prQuantity, string prPerson, string prDay)
        [TestCase(1, "adult", "thursday", 21.50)]
        [TestCase(2, "adult", "thursday", 43.00)]
        [TestCase(0, "adult", "thursday", -1)]
        [TestCase(1, "child", "thursday", -1)]
        [TestCase(1, "student", "thursday", -1)]
        public void When_ChickFlickThursday_Expect_CorrectPrice(int argQuantity, string argPerson, string argDay,
            decimal expectedResult)
        {
            // arrange
            var tpc = new TicketPriceController();
            // act 
            var testData = tpc.Chick_Flick_Thursday(argQuantity, argPerson, argDay);
            // assert
            Assert.AreEqual(testData, expectedResult);
        }
    }

    [TestFixture]
    // testing Kids_Careers()
    public class KidsCareers
    {
        //   Kids_Careers(int prQuantity, string prDay, bool prHoliday)
        [TestCase(1, "wednesday", false, 12.00)]
        [TestCase(2, "wednesday", false, 24.00)]
        [TestCase(0, "wednesday", false, -1)]
        [TestCase(1, "wednesday", true, -1)]
        [TestCase(1, "thursday", false, -1)]
        public void When_KidsCareers_Expect_CorrectPrice(int argQuantity, string argDay, bool isHoliday,
            decimal expectedResult)
        {
            // arrange
            var tpc = new TicketPriceController();
            // act 
            var testData = tpc.Kids_Careers(argQuantity, argDay, isHoliday);
            // assert
            Assert.AreEqual(testData, expectedResult);
        }
    }
}