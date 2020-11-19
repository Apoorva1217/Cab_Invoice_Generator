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
        /// Test Case for checking calculate fare function for Normal
        /// </summary>
        [Test]
        public void GivenDistanceAndTimeForNormal_ShouldReturnTotalFare()
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

        /// <summary>
        /// Test Case for checking calculate fare function for Premium
        /// </summary>
        [Test]
        public void GivenDistanceAndTimeForPremium_ShouldReturnTotalFare()
        {
            ///creating instance of InvoiceGenerator for normal ride
            invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
            double distance = 2.0;
            int time = 5;

            ///calculating fare
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 40;

            ///asserting values
            Assert.AreEqual(expected, fare);
        }

        /// <summary>
        /// Test Case for checking calculate fare function for Normal multiple rides summary
        /// </summary>
        [Test]
        public void GivenMultipleRidesForNormal_ShouldReturnInvoiceSummary()
        {
            ///creating instance of invoice generator for normal ride
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            ///generating summary for rides
            InvoiceSummary invoiceSummary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedsummary = new InvoiceSummary(2, 30.0);

            ///asserting values
            Assert.AreEqual(expectedsummary, invoiceSummary);
        }

        /// <summary>
        /// Test Case for checking calculate fare function for Premium multiple rides summary
        /// </summary>
        [Test]
        public void GivenMultipleRidesForPremium_ShouldReturnInvoiceSummary()
        {
            ///creating instance of invoice generator for normal ride
            invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            ///generating summary for rides
            InvoiceSummary invoiceSummary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedsummary = new InvoiceSummary(2, 60.0);

            ///asserting values
            Assert.AreEqual(expectedsummary, invoiceSummary);
        }

        /// <summary>
        /// Test case for given invalid ride type should return exception
        /// </summary>
        [Test]
        public void GivenInvalidRideType_ShouldThrowCustomException()
        {
            ///creating instance of invoice generator
            invoiceGenerator = new InvoiceGenerator();
            double distance = 2.0;
            int time = 5;
            string expected = "Invalid Ride Type";
            try
            {
                ///calculating fare
                double fare = invoiceGenerator.CalculateFare(distance, time);
            }
            catch (CabInvoiceException exception)
            {
                ///asserting values
                Assert.AreEqual(expected, exception);
            }
        }

        /// <summary>
        /// Test case for given invalid distance should return exception
        /// </summary>
        [Test]
        public void GivenInvalidDistance_ShouldThrowCustomException()
        {
            ///creating instance of invoice generator
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = -2.0;
            int time = 5;
            string expected = "Invalid Distance";
            try
            {
                ///calculating fare
                double fare = invoiceGenerator.CalculateFare(distance, time);
            }
            catch (CabInvoiceException exception)
            {
                ///asserting values
                Assert.AreEqual(expected, exception);
            }
        }

        /// <summary>
        /// Test case for given invalid time should return exception
        /// </summary>
        [Test]
        public void GivenInvalidTime_ShouldThrowCustomException()
        {
            ///creating instance of invoice generator
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = -5;
            string expected = "Invalid Time";
            try
            {
                ///calculating fare
                double fare = invoiceGenerator.CalculateFare(distance, time);
            }
            catch (CabInvoiceException exception)
            {
                ///asserting values
                Assert.AreEqual(expected, exception);
            }
        }

        /// <summary>
        /// Test Case for Given Cab Invoice When UserId And Rides Pass Should Return Invoice Summary
        /// </summary>
        [Test]
        public void GivenCabInvoice_WhenUserIdAndRidesPass_ShouldReturnInvoiceSummary()
        {
            ///creating instance of invoice generator for normal ride
            invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
            string userId = "Appu12";
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
            invoiceGenerator.AddRides(userId, rides);

            ///generating summary for rides
            InvoiceSummary invoiceSummary = invoiceGenerator.GetInvoiceSummary(userId);
            InvoiceSummary expectedsummary = new InvoiceSummary(2, 60.0);

            ///asserting values
            Assert.AreEqual(expectedsummary, invoiceSummary);
        }
    }
}