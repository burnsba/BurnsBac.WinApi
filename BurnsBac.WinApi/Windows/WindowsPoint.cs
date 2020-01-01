using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BurnsBac.WinApi.Windows
{
    /// <summary>
    /// The POINT structure defines the x- and y-coordinates of a point.
    /// </summary>
    /// <remarks>
    /// http://pinvoke.net/default.aspx/Structures/POINT.html .
    /// https://docs.microsoft.com/en-us/windows/win32/api/windef/ns-windef-point .
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1202:Elements should be ordered by access", Justification = "WinApi")]
    public struct WindowsPoint
    {
        private static WindowsPoint _invalid = new WindowsPoint(int.MinValue, int.MinValue);

        /// <summary>
        /// The x-coordinate of the point.
        /// </summary>
        public int X;

        /// <summary>
        /// The y-coordinate of the point.
        /// </summary>
        public int Y;

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsPoint"/> struct.
        /// </summary>
        /// <param name="x">X position.</param>
        /// <param name="y">Y position.</param>
        public WindowsPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets a value indicating whether the point is invalid or not.
        /// </summary>
        public static WindowsPoint Invalid
        {
            get
            {
                return _invalid;
            }
        }

        /// <summary>
        /// Converts to point.
        /// </summary>
        /// <param name="p">Point to convert.</param>
        public static implicit operator System.Drawing.Point(WindowsPoint p)
        {
            return new System.Drawing.Point(p.X, p.Y);
        }

        /// <summary>
        /// Converts to point.
        /// </summary>
        /// <param name="p">Point to convert.</param>
        public static implicit operator WindowsPoint(System.Drawing.Point p)
        {
            return new WindowsPoint(p.X, p.Y);
        }

        /// <summary>
        /// Calculates delta to a point.
        /// </summary>
        /// <param name="p">Point to find delta to.</param>
        /// <returns>Difference between the two points.</returns>
        public WindowsPoint Delta(WindowsPoint p)
        {
            return new WindowsPoint(p.X - X, p.Y - Y);
        }
    }
}
