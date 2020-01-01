using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BurnsBac.WinApi.Error
{
    /// <summary>
    /// Exception wrapper for GetLastErrorMessage.
    /// </summary>
    public class Win32ErrorCode : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Win32ErrorCode"/> class.
        /// </summary>
        public Win32ErrorCode()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Win32ErrorCode"/> class.
        /// </summary>
        /// <param name="message">Error message.</param>
        public Win32ErrorCode(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Win32ErrorCode"/> class.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <param name="innerException">Inner exception.</param>
        public Win32ErrorCode(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Win32ErrorCode"/> class.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        protected Win32ErrorCode(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Gets or sets windows error code.
        /// </summary>
        public int ErrorCode { get; set; }
    }
}
