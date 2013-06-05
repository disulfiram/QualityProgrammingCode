namespace CalendarSystemTests
{
    using System;
    using CompanyCalendarSystem;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        public void ParseAddEvent_EventName()
        {
            Command command = Command.Parse("AddEvent 2000-01-01T01:00:00 | party Viki | home");
            string actual = command.Name;
            string expected = "AddEvent";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ParseAddEvent_EventParameters()
        {
            Command command = Command.Parse("AddEvent 2000-01-01T01:00:00 | party Viki | home");
           
            string[] actual = command.Parameters;
            string[] expected = new string[] { "2000-01-01T01:00:00", "party Viki", "home" };
            bool areEqual = true;
            for (int i = 0; i < actual.Length; i++)
            {
                if (actual[i] != expected[i])
                {
                    areEqual = false;
                }
            }

            Assert.IsTrue(areEqual);
        }

        [TestMethod]
        public void ParseAddEvent_EventParametersCount()
        {
            Command command = Command.Parse("AddEvent 2000-01-01T01:00:00 | party Viki | home");

            int actual = command.Parameters.Length;
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ParseAddEvent_InvalidCommand()
        {
            Command.Parse("AddEvent:2000-01-01T01:00:00|Testing|home");
        }
    }
}