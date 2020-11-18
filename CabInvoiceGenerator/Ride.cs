using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// ride class for set data for particular ride
    /// </summary>
    public class Ride
    {
        public double distance;
        public int time;

        /// <summary>
        /// parameter constructor for setting data
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="time"></param>
        public Ride(double distance,int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
