﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BurnsBac.WinApi.User32
{
    /// <summary>
    /// Union struct for <see cref="RawInput"/>. Contains data for the object.
    /// </summary>
    /// <remarks>
    /// https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-rawinput
    /// .
    /// I was having some kind of issue marsharlling this with the overlapping
    /// field offsets, so I made this non-union.
    /// </remarks>
    public struct RawInputData
    {
        /// <summary>
        /// If the data comes from a keyboard, this is the raw input data.
        /// </summary>
        public RawKeyboard Keyboard;

        /// <summary>
        /// If the data comes from a mouse, this is the raw input data.
        /// </summary>
        public RawMouse Mouse;

        /// <summary>
        ///  If the data comes from an HID, this is the raw input data.
        /// </summary>
        public RawHid Hid;
    }
}
