using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        /// <summary>
        /// variables
        /// </summary>
        private int numberOfRides;
        private double totalFare;
        private double averageFare;

        /// <summary>
        /// parameter constructor for setting data
        /// </summary>
        /// <param name="numberOfRides"></param>
        /// <param name="totalFare"></param>
        public InvoiceSummary(int numberOfRides,double totalFare)
        {
            this.totalFare = numberOfRides;
            this.totalFare = totalFare;
            this.averageFare = this.totalFare / this.numberOfRides;
        }

        /// <summary>
        /// overriding equals method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is InvoiceSummary))
                return false;
            InvoiceSummary inputedObject = (InvoiceSummary)obj;
            return this.numberOfRides==inputedObject.numberOfRides && this.totalFare==inputedObject.totalFare && this.averageFare==inputedObject.averageFare;
        }

        /// <summary>
        /// overriding GetHashCode method
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.numberOfRides.GetHashCode() ^ this.totalFare.GetHashCode() ^ this.averageFare.GetHashCode();
        }
    }
}
