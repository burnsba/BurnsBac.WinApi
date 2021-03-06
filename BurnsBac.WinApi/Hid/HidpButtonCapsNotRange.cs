﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BurnsBac.WinApi.Hid
{
    /// <summary>
    /// Union struct for <see cref="HidpButtonCaps"/>.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1202:Elements should be ordered by access", Justification = "WinApi")]
    public struct HidpButtonCapsNotRange
    {
        /// <summary>
        /// Reserved for internal system use.
        /// </summary>
        [FieldOffset(0)]
        internal ushort Reserved1;

        /// <summary>
        /// Indicates a usage ID.
        /// </summary>
        [FieldOffset(2)]
        public ushort Usage;

        /// <summary>
        /// Indicates a string descriptor ID for the usage specified by NotRange.Usage.
        /// </summary>
        [FieldOffset(4)]
        public ushort StringIndex;

        /// <summary>
        /// Reserved for internal system use.
        /// </summary>
        [FieldOffset(6)]
        internal ushort Reserved2;

        /// <summary>
        /// Indicates a designator ID for the usage specified by NotRange.Usage.
        /// </summary>
        [FieldOffset(8)]
        public ushort DesignatorIndex;

        /// <summary>
        /// Reserved for internal system use.
        /// </summary>
        [FieldOffset(10)]
        internal ushort Reserved3;

        /// <summary>
        /// Indicates the data index of the usage specified by NotRange.Usage.
        /// </summary>
        [FieldOffset(12)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1202:Elements should be ordered by access", Justification = "explicit layout")]
        public ushort DataIndex;

        /// <summary>
        /// Reserved for internal system use.
        /// </summary>
        [FieldOffset(14)]
        internal ushort Reserved4;

        /// <summary>
        /// Creates object from raw bytes.
        /// </summary>
        /// <param name="bytes">Byte array to read from.</param>
        /// <param name="offset">Offset to start reading from.</param>
        /// <returns>New object.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1119:Statement should not use unnecessary parenthesis", Justification = "WinApi")]
        public static HidpButtonCapsNotRange FromByteArray(byte[] bytes, int offset)
        {
            var hbc = new HidpButtonCapsNotRange()
            {
                Reserved1 = (ushort)(((ushort)bytes[offset + 1] << 8) | (ushort)(bytes[offset + 0])),
                Usage = (ushort)(((ushort)bytes[offset + 3] << 8) | (ushort)(bytes[offset + 2])),
                StringIndex = (ushort)(((ushort)bytes[offset + 5] << 8) | (ushort)(bytes[offset + 4])),
                Reserved2 = (ushort)(((ushort)bytes[offset + 7] << 8) | (ushort)(bytes[offset + 6])),
                DesignatorIndex = (ushort)(((ushort)bytes[offset + 9] << 8) | (ushort)(bytes[offset + 8])),
                Reserved3 = (ushort)(((ushort)bytes[offset + 11] << 8) | (ushort)(bytes[offset + 10])),
                DataIndex = (ushort)(((ushort)bytes[offset + 13] << 8) | (ushort)(bytes[offset + 12])),
                Reserved4 = (ushort)(((ushort)bytes[offset + 15] << 8) | (ushort)(bytes[offset + 14])),
            };

            return hbc;
        }
    }
}
