﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BurnsBac.WinApi.SetupApi
{
    /// <summary>
    /// A variable of type DWORD that specifies control options that filter the device
    /// information elements that are added to the device information set. This parameter
    /// can be a bitwise OR of zero or more of the following flags. For more information
    /// about combining these flags, see the following Remarks section.
    /// </summary>
    /// <remarks>
    /// https://www.pinvoke.net/default.aspx/setupapi.setupdigetclassdevs .
    /// </remarks>
    [Flags]
    public enum DiGetClassFlags : uint
    {
        /// <summary>
        /// Return only the device that is associated with the system default device
        /// interface, if one is set, for the specified device interface classes.
        /// </summary>
        DIGCF_DEFAULT = 0x00000001,  // only valid with DIGCF_DEVICEINTERFACE

        /// <summary>
        /// Return only devices that are currently present in a system.
        /// </summary>
        DIGCF_PRESENT = 0x00000002,

        /// <summary>
        /// Return a list of installed devices for all device setup classes or all device
        /// interface classes.
        /// </summary>
        DIGCF_ALLCLASSES = 0x00000004,

        /// <summary>
        /// Return only devices that are a part of the current hardware profile.
        /// </summary>
        DIGCF_PROFILE = 0x00000008,

        /// <summary>
        /// Return devices that support device interfaces for the specified device
        /// interface classes. This flag must be set in the Flags parameter if the
        /// Enumerator parameter specifies a device instance ID.
        /// </summary>
        DIGCF_DEVICEINTERFACE = 0x00000010,
    }
}
