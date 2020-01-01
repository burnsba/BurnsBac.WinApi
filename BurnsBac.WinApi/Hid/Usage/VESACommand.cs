using System;
using System.Collections.Generic;
using System.Text;

namespace BurnsBac.WinApi.Hid.Usage
{
    /// <summary>
    /// Usages for VESACommand usage page (131).
    /// </summary>
    /// <remarks>
    /// https://www.freebsddiary.org/APC/usb_hid_usages.php .
    /// </remarks>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1602:Enumeration items should be documented", Justification = "WinApi")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "CS1591", Justification = "WinApi")]
    public enum VESACommand
    {
        Undefined = 0x00,
        Settings = 0x01,
        Degauss = 0x02,
    }
}
