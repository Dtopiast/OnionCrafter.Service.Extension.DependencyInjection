namespace OnionCrafter.Service.Extension.DependencyInjection.Exceptions
{
    /// <summary>
    /// Exception thrown when a service configuration is not found.
    /// </summary>
    [Serializable]
    public class ServiceOptionNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceOptionNotFoundException"/> class.
        /// </summary>
        public ServiceOptionNotFoundException()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceOptionNotFoundException"/> class with a specified error message.
        /// </summary>
        public ServiceOptionNotFoundException(string message) : base(message)
        {
        }

        /// <summary>
        /// Constructor for ServiceOptionNotFoundException with a message and inner exception.
        /// </summary>
        public ServiceOptionNotFoundException(string message, Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceOptionNotFoundException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the source or destination.</param>
        /// <returns>
        /// A new instance of the <see cref="ServiceOptionNotFoundException"/> class.
        /// </returns>
        protected ServiceOptionNotFoundException(
                 System.Runtime.Serialization.SerializationInfo info,
                 System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}