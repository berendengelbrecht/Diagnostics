﻿using System;

namespace Decos.Diagnostics
{
    /// <summary>
    /// Defines methods for writing events and data to a log.
    /// </summary>
    public interface ILog
    {
        /// <summary>
        /// Determines whether messages of the specified log level are accepted.
        /// </summary>
        /// <param name="logLevel">The log level to check.</param>
        /// <returns>
        /// <c>true</c> if message with the specified log level will be written
        /// to the log; otherwise, <c>false</c>.
        /// </returns>
        bool IsEnabled(LogLevel logLevel);

        /// <summary>
        /// Writes a message to the log with the specified severity.
        /// </summary>
        /// <param name="logLevel">The severity of the message.</param>
        /// <param name="message">The text of the message to log.</param>
        void Write(LogLevel logLevel, string message);

        /// <summary>
        /// Writes structured data to the log with the specified severity.
        /// </summary>
        /// <typeparam name="T">The type of data to write.</typeparam>
        /// <param name="logLevel">The severity of the data.</param>
        /// <param name="data">The data to log.</param>
        void Write<T>(LogLevel logLevel, T data);

        /// <summary>
        /// Writes a message to the log with specified severity and customerID.
        /// </summary>
        /// <param name="logLevel">The severity of the message.</param>
        /// <param name="message">The text of the message to log.</param>
        /// <param name="customerID">The ID of the customer active on the moment of writing.</param>
        void Write(LogLevel logLevel, string message, Guid customerID);

        /// <summary>
        /// Writes structured data to the log with the specified and customerID.
        /// </summary>
        /// <typeparam name="T">The type of data to write.</typeparam>
        /// <param name="logLevel">The severity of the data.</param>
        /// <param name="data">The data to log.</param>
        /// <param name="customerID">The ID of the customer active on the moment of writing.</param>
        void Write<T>(LogLevel logLevel, T data, Guid customerID);

        /// <summary>
        /// Writes structured data to the log with the specified data set in a LogSenderDetails object.
        /// </summary>
        /// <typeparam name="T">The type of data to write.</typeparam>
        /// <param name="logLevel">The severity of the data.</param>
        /// <param name="data">The data to log.</param>
        /// <param name="senderDetails">Object containing data of the sender.</param>
        void Write<T>(LogLevel logLevel, T data, LogSenderDetails senderDetails);
    }

    /// <summary>
    /// Defines methods for writing events and data to a log.
    /// </summary>
    /// <typeparam name="TSource">
    /// The type (e.g. class) that acts as the source of logging information.
    /// </typeparam>
    /// <remarks>
    /// This interface is generally only used to enable resolving <see
    /// cref="ILog"/> instances using dependency injection directly.
    /// </remarks>
    public interface ILog<out TSource> : ILog
    {
    }
}