using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BurnsBac.WinApi.User32
{
    /// <summary>
    /// Contains the raw input from a device.
    /// </summary>
    /// <remarks>
    /// https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-rawinput .
    /// </remarks>
    public struct RawInput
    {
        /// <summary>
        /// Header info.
        /// </summary>
        public RawInputHeader Header;

        /// <summary>
        /// Input data.
        /// </summary>
        public RawInputData Data;

        /// <summary>
        /// Creates object from raw bytes.
        /// </summary>
        /// <param name="bytes">Byte array to read from.</param>
        /// <param name="offset">Offset to start reading from.</param>
        /// <param name="nextByteOffset">Index for the byte after the last byte read to create this object.</param>
        /// <returns>New object.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1119:Statement should not use unnecessary parenthesis", Justification = "WinApi")]
        public static RawInput FromBytes(byte[] bytes, int offset, out int nextByteOffset)
        {
            RawInput ri;

            int headerOffset;
            int dataOffset;

            var header = RawInputHeader.FromBytes(bytes, offset + 0, out headerOffset);

            if ((int)bytes[offset] == (int)RawInputDeviceType.Mouse)
            {
                ri = new RawInput()
                {
                    Header = header,
                    Data = new RawInputData()
                    {
                        Mouse = RawMouse.FromBytes(bytes, headerOffset, out dataOffset),
                    },
                };
            }
            else if ((int)bytes[offset] == (int)RawInputDeviceType.Keyboard)
            {
                ri = new RawInput()
                {
                    Header = header,
                    Data = new RawInputData()
                    {
                        Keyboard = RawKeyboard.FromBytes(bytes, headerOffset, out dataOffset),
                    },
                };
            }
            else if ((int)bytes[offset] == (int)RawInputDeviceType.Hid)
            {
                ri = new RawInput()
                {
                    Header = header,
                    Data = new RawInputData()
                    {
                        Hid = RawHid.FromBytes(bytes, headerOffset, out dataOffset),
                    },
                };
            }
            else
            {
                throw new NotSupportedException();
            }

            nextByteOffset = dataOffset;

            return ri;
        }
    }
}
