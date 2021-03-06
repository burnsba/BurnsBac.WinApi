﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BurnsBac.WinApi.Hid.Usage
{
    /// <summary>
    /// Usages for Digitizer usage page (13).
    /// </summary>
    /// <remarks>
    /// https://www.freebsddiary.org/APC/usb_hid_usages.php .
    /// </remarks>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1602:Enumeration items should be documented", Justification = "WinApi")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "CS1591", Justification = "WinApi")]
    public enum Digitizer
    {
        Undefined = 0x00,
        Digitizer = 0x01,
        Pen = 0x02,
        LightPen = 0x03,
        TouchScreen = 0x04,
        TouchPad = 0x05,
        WhiteBoard = 0x06,
        CoordinateMeasuringMachine = 0x07,
        _3DDigitizer = 0x08,
        StereoPlotter = 0x09,
        ArticulatedArm = 0x0A,
        Armature = 0x0B,
        MultiplePointDigitizer = 0x0C,
        FreeSpaceWand = 0x0D,
        Stylus = 0x20,
        Puck = 0x21,
        Finger = 0x22,
        TipPressure = 0x30,
        BarrelPressure = 0x31,
        InRange = 0x32,
        Touch = 0x33,
        Untouch = 0x34,
        Tap = 0x35,
        Quality = 0x36,
        DataValid = 0x37,
        TransducerIndex = 0x38,
        TabletFunctionKeys = 0x39,
        ProgramChangeKeys = 0x3A,
        BatteryStrength = 0x3B,
        Invert = 0x3C,
        XTilt = 0x3D,
        YTilt = 0x3E,
        Azimuth = 0x3F,
        Altitude = 0x40,
        Twist = 0x41,
        TipSwitch = 0x42,
        SecondaryTipSwitch = 0x43,
        BarrelSwitch = 0x44,
        Eraser = 0x45,
        TabletPick = 0x46,
    }
}
