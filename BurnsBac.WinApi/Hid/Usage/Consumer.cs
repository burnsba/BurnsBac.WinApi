﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BurnsBac.WinApi.Hid.Usage
{
    /// <summary>
    /// Usages for Consumer usage page (12).
    /// </summary>
    /// <remarks>
    /// https://www.freebsddiary.org/APC/usb_hid_usages.php .
    /// </remarks>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1602:Enumeration items should be documented", Justification = "WinApi")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "CS1591", Justification = "WinApi")]
    public enum Consumer
    {
        Unassigned = 0x00,
        ConsumerControl = 0x01,
        NumericKeyPad = 0x02,
        ProgrammableButtons = 0x03,
        Increment_10 = 0x20,
        Increment_100 = 0x21,
        AM_PM = 0x22,
        Power = 0x30,
        Reset = 0x31,
        Sleep = 0x32,
        SleepAfter = 0x33,
        SleepMode = 0x34,
        Illumination = 0x35,
        FunctionButtons = 0x36,
        Menu = 0x40,
        MenuPick = 0x41,
        MenuUp = 0x42,
        MenuDown = 0x43,
        MenuLeft = 0x44,
        MenuRight = 0x45,
        MenuEscape = 0x46,
        MenuValueIncrease = 0x47,
        MenuValueDecrease = 0x48,
        DataOnScreen = 0x60,
        ClosedCaption = 0x61,
        ClosedCaptionSelect = 0x62,
        VCR_TV = 0x63,
        BroadcastMode = 0x64,
        Snapshot = 0x65,
        Still = 0x66,
        Selection = 0x80,
        AssignSelection = 0x81,
        ModeStep = 0x82,
        RecallLast = 0x83,
        EnterChannel = 0x84,
        OrderMovie = 0x85,
        Channel = 0x86,
        MediaSelection = 0x87,
        MediaSelectComputer = 0x88,
        MediaSelectTV = 0x89,
        MediaSelectWWW = 0x8A,
        MediaSelectDVD = 0x8B,
        MediaSelectTelephone = 0x8C,
        MediaSelectProgramGuide = 0x8D,
        MediaSelectVideoPhone = 0x8E,
        MediaSelectGames = 0x8F,
        MediaSelectMessages = 0x90,
        MediaSelectCD = 0x91,
        MediaSelectVCR = 0x92,
        MediaSelectTuner = 0x93,
        Quit = 0x94,
        Help = 0x95,
        MediaSelectTape = 0x96,
        MediaSelectCable = 0x97,
        MediaSelectSatellite = 0x98,
        MediaSelectSecurity = 0x99,
        MediaSelectHome = 0x9A,
        MediaSelectCall = 0x9B,
        ChannelIncrement = 0x9C,
        ChannelDecrement = 0x9D,
        MediaSelectSAP = 0x9E,
        VCRPlus = 0xA0,
        Once = 0xA1,
        Daily = 0xA2,
        Weekly = 0xA3,
        Monthly = 0xA4,
        Play = 0xB0,
        Pause = 0xB1,
        Record = 0xB2,
        FastForward = 0xB3,
        Rewind = 0xB4,
        ScanNextTrack = 0xB5,
        ScanPreviousTrack = 0xB6,
        Stop = 0xB7,
        Eject = 0xB8,
        RandomPlay = 0xB9,
        SelectDisC = 0xBA,
        EnterDisc = 0xBB,
        Repeat = 0xBC,
        Tracking = 0xBD,
        TrackNormal = 0xBE,
        SlowTracking = 0xBF,
        FrameForward = 0xC0,
        FrameBack = 0xC1,
        Mark = 0xC2,
        ClearMark = 0xC3,
        RepeatFromMark = 0xC4,
        ReturnToMark = 0xC5,
        SearchMarkForward = 0xC6,
        SearchMarkBackwards = 0xC7,
        CounterReset = 0xC8,
        ShowCounter = 0xC9,
        TrackingIncrement = 0xCA,
        TrackingDecrement = 0xCB,
        Volume = 0xE0,
        Balance = 0xE1,
        Mute = 0xE2,
        Bass = 0xE3,
        Treble = 0xE4,
        BassBoost = 0xE5,
        SurroundMode = 0xE6,
        Loudness = 0xE7,
        MPX = 0xE8,
        VolumeUp = 0xE9,
        VolumeDown = 0xEA,
        SpeedSelect = 0xF0,
        PlaybackSpeed = 0xF1,
        StandardPlay = 0xF2,
        LongPlay = 0xF3,
        ExtendedPlay = 0xF4,
        Slow = 0xF5,
        FanEnable = 0x100,
        FanSpeed = 0x101,
        Light = 0x102,
        LightIlluminationLevel = 0x103,
        ClimateControlEnable = 0x104,
        RoomTemperature = 0x105,
        SecurityEnable = 0x106,
        FireAlarm = 0x107,
        PoliceAlarm = 0x108,
        BalanceRight = 0x150,
        BalanceLeft = 0x151,
        BassIncrement = 0x152,
        BassDecrement = 0x153,
        TrebleIncrement = 0x154,
        TrebleDecrement = 0x155,
        SpeakerSystem = 0x160,
        ChannelLeft = 0x161,
        ChannelRight = 0x162,
        ChannelCenter = 0x163,
        ChannelFront = 0x164,
        ChannelCenterFront = 0x165,
        ChannelSide = 0x166,
        ChannelSurround = 0x167,
        ChannelLowFrequencyEnhancement = 0x168,
        ChannelTop = 0x169,
        ChannelUnknown = 0x16A,
        Subchannel = 0x170,
        SubchannelIncrement = 0x171,
        SubchannelDecrement = 0x172,
        AlternateAudioIncrement = 0x173,
        AlternateAudioDecrement = 0x174,
        ApplicationLaunchButtons = 0x180,
        AL_LaunchButtonConfigurationTool = 0x181,
        AL_ProgrammableButtonConfiguration = 0x182,
        AL_ConsumerControlConfiguration = 0x183,
        AL_WordProcessor = 0x184,
        AL_TextEditor = 0x185,
        AL_Spreadsheet = 0x186,
        AL_GraphicsEditor = 0x187,
        AL_PresentationApp = 0x188,
        AL_DatabaseApp = 0x189,
        AL_EmailReader = 0x18A,
        AL_Newsreader = 0x18B,
        AL_Voicemail = 0x18C,
        AL_Contacts_AddressBook = 0x18D,
        AL_Calendar_Schedule = 0x18E,
        AL_Task_ProjectManager = 0x18F,
        AL_Log_Journal_Timecard = 0x190,
        AL_Checkbook_Finance = 0x191,
        AL_Calculator = 0x192,
        AL_A_VCapture_Playback = 0x193,
        AL_LocalMachineBrowser = 0x194,
        AL_LAN_WANBrowser = 0x195,
        AL_InternetBrowser = 0x196,
        AL_RemoteNetworking_ISPConnect = 0x197,
        AL_NetworkConference = 0x198,
        AL_NetworkChat = 0x199,
        AL_Telephony_Dialer = 0x19A,
        AL_Logon = 0x19B,
        AL_Logoff = 0x19C,
        AL_Logon_Logoff = 0x19D,
        AL_TerminalLock_Screensaver = 0x19E,
        AL_ControlPanel = 0x19F,
        AL_CommandLineProcessor_Run = 0x1A0,
        AL_Process_TaskManager = 0x1A1,
        AL_SelectTast_Application = 0x1A2,
        AL_NextTask_Application = 0x1A3,
        AL_PreviousTask_Application = 0x1A4,
        AL_PreemptiveHaltTask_Application = 0x1A5,
        GenericGUIApplicationControls = 0x200,
        AC_New = 0x201,
        AC_Open = 0x202,
        AC_Close = 0x203,
        AC_Exit = 0x204,
        AC_Maximize = 0x205,
        AC_Minimize = 0x206,
        AC_Save = 0x207,
        AC_Print = 0x208,
        AC_Properties = 0x209,
        AC_Undo = 0x21A,
        AC_Copy = 0x21B,
        AC_Cut = 0x21C,
        AC_Paste = 0x21D,
        AC_SelectAll = 0x21E,
        AC_Find = 0x21F,
        AC_FindandReplace = 0x220,
        AC_Search = 0x221,
        AC_GoTo = 0x222,
        AC_Home = 0x223,
        AC_Back = 0x224,
        AC_Forward = 0x225,
        AC_Stop = 0x226,
        AC_Refresh = 0x227,
        AC_PreviousLink = 0x228,
        AC_NextLink = 0x229,
        AC_Bookmarks = 0x22A,
        AC_History = 0x22B,
        AC_Subscriptions = 0x22C,
        AC_ZoomIn = 0x22D,
        AC_ZoomOut = 0x22E,
        AC_Zoom = 0x22F,
        AC_FullScreenView = 0x230,
        AC_NormalView = 0x231,
        AC_ViewToggle = 0x232,
        AC_ScrollUp = 0x233,
        AC_ScrollDown = 0x234,
        AC_Scroll = 0x235,
        AC_PanLeft = 0x236,
        AC_PanRight = 0x237,
        AC_Pan = 0x238,
        AC_NewWindow = 0x239,
        AC_TileHorizontally = 0x23A,
        AC_TileVertically = 0x23B,
        AC_Format = 0x23C,
    }
}
