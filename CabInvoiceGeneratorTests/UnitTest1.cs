using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInvoiceGeneratorTests
{
    public class Tests
    {
        /// <summary>
        /// invoice generator reference
        /// </summary>
        InvoiceGenerator invoiceGenerator = null; 

        /// <summary>
        /// Test Case for checking calculate fare function
        /// </summary>
        [Test]
        public void GivenDistanceAndTime_ShouldReturnTotalFare()
        {
            ///creating instance of InvoiceGenerator for normal ride
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;

            ///calculating fare
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;

            ///asserting values
            Assert.AreEqual(expected, fare);
        }
    }
}