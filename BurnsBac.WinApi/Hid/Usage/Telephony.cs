﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BurnsBac.WinApi.Hid.Usage
{
    /// <summary>
    /// Usages for Telephony usage page (11).
    /// </summary>
    /// <remarks>
    /// https://www.freebsddiary.org/APC/usb_hid_usages.php .
    /// </remarks>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1602:Enumeration items should be documented", Justification = "WinApi")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "CS1591", Justification = "WinApi")]
    public enum Telephony
    {
        Unassigned = 0x00,
        Phone = 0x01,
        AnsweringMachine = 0x02,
        MessageControls = 0x03,
        Handset = 0x04,
        Headset = 0x05,
        TelephonyKeyPad = 0x06,
        ProgrammableButton = 0x07,
        HookSwitch = 0x20,
        Flash = 0x21,
        Feature = 0x22,
        Hold = 0x23,
        Redial = 0x24,
        Transfer = 0x25,
        Drop = 0x26,
        Park = 0x27,
        ForwardCalls = 0x28,
        AlternateFunction = 0x29,
        Line = 0x2A,
        SpeakerPhone = 0x2B,
        Conference = 0x2C,
        RingEnable = 0x2D,
        RingSelect = 0x2E,
        PhoneMute = 0x2F,
        CallerID = 0x30,
        SpeedDial = 0x50,
        StoreNumber = 0x51,
        RecallNumber = 0x52,
        PhoneDirectory = 0x53,
        VoiceMail = 0x70,
        ScreenCalls = 0x71,
        DoNotDisturb = 0x72,
        Message = 0x73,
        AnswerOnOff = 0x74,
        InsideDialTone = 0x90,
        OutsideDialTone = 0x91,
        InsideRingTone = 0x92,
        OutsideRingTone = 0x93,
        PriorityRingTone = 0x94,
        InsideRingback = 0x95,
        PriorityRingback = 0x96,
        LineBusyTone = 0x97,
        ReorderTone = 0x98,
        CallWaitingTone = 0x99,
        ConfirmationTone1 = 0x9A,
        ConfirmationTone2 = 0x9B,
        TonesOff = 0x9C,
        PhoneKey0 = 0xB0,
        PhoneKey1 = 0xB1,
        PhoneKey2 = 0xB2,
        PhoneKey3 = 0xB3,
        PhoneKey4 = 0xB4,
        PhoneKey5 = 0xB5,
        PhoneKey6 = 0xB6,
        PhoneKey7 = 0xB7,
        PhoneKey8 = 0xB8,
        PhoneKey9 = 0xB9,
        PhoneKeyStar = 0xBA,
        PhoneKeyPound = 0xBB,
        PhoneKeyA = 0xBC,
        PhoneKeyB = 0xBD,
        PhoneKeyC = 0xBE,
        PhoneKeyD = 0xBF,
    }
}
