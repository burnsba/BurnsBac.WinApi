using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using BurnsBac.WinApi.Hid;

namespace BurnsBac.WinApi.Error
{
    /// <summary>
    /// Exception if HID method does not return success.
    /// </summary>
    public class HidpStatusException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HidpStatusException"/> class.
        /// </summary>
        public HidpStatusException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HidpStatusException"/> class.
        /// </summary>
        /// <param name="message">Error message.</param>
        public HidpStatusException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HidpStatusException"/> class.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <param name="innerException">Inner exception.</param>
        public HidpStatusException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HidpStatusException"/> class.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        protected HidpStatusException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Gets or sets status code that triggered exception.
        /// </summary>
        public HidpStatus StatusCode { get; set; }
    }
}
