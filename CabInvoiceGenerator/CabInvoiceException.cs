using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// class for custom exception handling
    /// </summary>
    public class CabInvoiceException : Exception
    {
        /// <summary>
        /// enum for exception type
        /// </summary>
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE, 
            INVALID_DISTANCE,
            INVALID_TIME,
            NULL_RIDES,
            INVALID_USER_ID
        }

        ExceptionType type;
        /// <summary>
        /// parameter constructor for setting exception type and throwing exception
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public CabInvoiceException(ExceptionType type,string message) : base(message)
        {
            this.type = type;
        }
    }
}
