using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TELMAGEN
{
    public class DataHelpers
    {
        /// <summary>
        /// convert to integer
        /// </summary>
        public static int? C2I(object o)
        {
            if (o is string)
            {
                int i = 0;
                if (int.TryParse((string)o, out i))
                {
                    return i;
                }
                else
                {
                    return null;
                }
            }
            else if (o is Int32)
            {
                return int.Parse(o.ToString());
            }
            else if (o is int)
            {
                return (int)o;
            }
            else if (o is long)
            {
                return int.Parse(o.ToString());
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// filter characters from the string that are not suitable for a filename in win32
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static string FilterStringForFileName(string filename)
        {
            filename = filename.Replace("/", string.Empty);
            filename = filename.Replace("\\", string.Empty);
            filename = filename.Replace(":", string.Empty);
            filename = filename.Replace("*", string.Empty);
            filename = filename.Replace("?", string.Empty);
            filename = filename.Replace("\"", string.Empty);
            filename = filename.Replace("<", string.Empty);
            filename = filename.Replace(">", string.Empty);
            filename = filename.Replace("|", string.Empty);

            return filename;
        }

        /// <summary>
        /// Take a color and make it lighter by a value between 0-1
        /// </summary>
        private static Color Lighten(Color inColor, double inAmount)
        {
            return Color.FromArgb(
              inColor.A,
              (int)Math.Min(255, inColor.R + 255 * inAmount),
              (int)Math.Min(255, inColor.G + 255 * inAmount),
              (int)Math.Min(255, inColor.B + 255 * inAmount));
        }
    }
}
