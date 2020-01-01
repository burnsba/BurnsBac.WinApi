﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BurnsBac.WinApi.Hid.Usage
{
    /// <summary>
    /// Usages for PowerDevice usage page (132).
    /// </summary>
    /// <remarks>
    /// https://www.freebsddiary.org/APC/usb_hid_usages.php .
    /// </remarks>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1602:Enumeration items should be documented", Justification = "WinApi")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "CS1591", Justification = "WinApi")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1300", Justification = "WinApi")]
    public enum PowerDevice
    {
        Undefined = 0x00,
        iName = 0x01,
        PresentStatus = 0x02,
        ChangedStatus = 0x03,
        UPS = 0x04,
        PowerSupply = 0x05,
        BatterySystem = 0x10,
        BatterySystemID = 0x11,
        Battery = 0x12,
        BatteryID = 0x13,
        Charger = 0x14,
        ChargerID = 0x15,
        PowerConverter = 0x16,
        PowerConverterID = 0x17,
        OutletSystem = 0x18,
        OutletSystemID = 0x19,
        Input = 0x1A,
        InputID = 0x1B,
        Output = 0x1C,
        OutputID = 0x1D,
        Flow = 0x1E,
        FlowID = 0x1F,
        Outlet = 0x20,
        OutletID = 0x21,
        Gang = 0x22,
        GangID = 0x23,
        Sink = 0x24,
        SinkID = 0x25,
        Voltage = 0x30,
        Current = 0x31,
        Frequency = 0x32,
        ApparentPower = 0x33,
        ActivePower = 0x34,
        PercentLoad = 0x35,
        Temperature = 0x36,
        Humidity = 0x37,
        ConfigVoltage = 0x40,
        ConfigCurrent = 0x41,
        ConfigFrequency = 0x42,
        ConfigApparentPower = 0x43,
        ConfigActivePower = 0x44,
        ConfigPercentLoad = 0x45,
        ConfigTemperature = 0x46,
        ConfigHumidity = 0x47,
        SwitchOnControl = 0x50,
        SwitchOffControl = 0x51,
        ToggleControl = 0x52,
        LowVoltageTransfer = 0x53,
        HighVoltageTransfer = 0x54,
        DelayBeforeReboot = 0x55,
        DelayBeforeStartup = 0x56,
        DelayBeforeShutdown = 0x57,
        Test = 0x58,
        Vendorspecificcommand = 0x59,
        Present = 0x60,
        Good = 0x61,
        InternalFailure = 0x62,
        VoltageOutOfRange = 0x63,
        FrequencyOutOfRange = 0x64,
        Overload = 0x65,
        OverCharged = 0x66,
        OverTemperature = 0x67,
        ShutdownRequested = 0x68,
        ShutdownImminent = 0x69,
        VendorSpecificAnswerValid = 0x6A,
        SwitchOnOff = 0x6B,
        Switcheble = 0x6C,
        Used = 0x6D,
        Boost = 0x6E,
        Buck = 0x6F,
        Initialized = 0x70,
        Tested = 0x71,
    }
}
