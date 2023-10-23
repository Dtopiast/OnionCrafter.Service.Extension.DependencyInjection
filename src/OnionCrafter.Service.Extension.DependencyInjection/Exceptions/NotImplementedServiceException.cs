namespace OnionCrafter.Service.Extension.DependencyInjection.Exceptions
{
    /// <summary>
    /// Represents an exception for a service that is not implemented.
    /// </summary>
    [Serializable]
    public class NotImplementedServiceException : Exception
    {
        /// <summary>
        /// Creates a new instance of the NotImplementedServiceException class.
        /// </summary>
        /// <returns>
        /// A new instance of the NotImplementedServiceException class.
        /// </returns>
        public NotImplementedServiceException()
        { }

        /// <summary>
        /// Initializes a new instance of the NotImplementedServiceException class with a specified error message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <returns>A new instance of the NotImplementedServiceException class.</returns>
        public NotImplementedServiceException(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of the NotImplementedServiceException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        /// <returns>A new instance of the NotImplementedServiceException class.</returns>
        public NotImplementedServiceException(string message, Exception inner) : base(message, inner) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotImplementedServiceException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the source or destination.</param>
        /// <returns>
        /// A new instance of the <see cref="NotImplementedServiceException"/> class.
        /// </returns>
        protected NotImplementedServiceException(
                System.Runtime.Serialization.SerializationInfo info,
                System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}