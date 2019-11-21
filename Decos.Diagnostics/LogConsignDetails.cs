﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Decos.Diagnostics
{
    /// <summary>
    /// An object containing different kinds of data related to the sender of a log
    /// </summary>
    public class LogSenderDetails
    {
        /// <summary>
        /// Gets or sets the ID of the Customer who was active when the log was written.
        /// </summary>
        public Guid? CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the Session that was active when the log was written.
        /// </summary>
        public Guid? SessionId { get; set; }

        /// <summary>
        /// Initializes a new instance of LogSenderDetails
        /// </summary>
        /// <param name="customerId">ID of a customer</param>
        public LogSenderDetails(Guid? customerId)
        {
            CustomerId = customerId;
        }

        /// <summary>
        /// Initializes a new instance of LogSenderDetails
        /// </summary>
        /// <param name="customerId">ID of a customer</param>
        /// <param name="sessionId">ID of a session</param>
        public LogSenderDetails(Guid? customerId, Guid? sessionId)
        {
            CustomerId = customerId;
            SessionId = sessionId;
        }

        /// <summary>
        /// Checks if the CustomerID is set or not
        /// </summary>
        /// <returns>true if CustomerId is not null or empty.</returns>
        public Boolean HasCustomerId()
        {
            return CustomerId != null && CustomerId != Guid.Empty;
        }

        /// <summary>
        /// Checks if the SessionID is set or not
        /// </summary>
        /// <returns>true if SessionId is not null or empty.</returns>
        public Boolean HasSessionId()
        {
            return SessionId != null && SessionId != Guid.Empty;
        }
    }
}
