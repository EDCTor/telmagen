using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Drawing;

namespace TELMAGEN
{
    public enum TColor
    {
        [EnumDescription("Red")]
        [ColorCode(255,0,0)]
        RED,
        [EnumDescription("Blue")]
        [ColorCode(0,0,255)]
        BLUE,
        [EnumDescription("Green")]
        [ColorCode(0,255,0)]
        GREEN,
        [EnumDescription("Yellow")]
        [ColorCode(255, 255, 0)]
        YELLOW,
        [EnumDescription("Orange")]
        [ColorCode(255, 142, 0)]
        ORANGE,
        [EnumDescription("Pink")]
        [ColorCode(255, 0, 255)]
        PINK,
        [EnumDescription("Baby Blue")]
        [ColorCode(0, 255, 255)]
        BABYBLUE,
        [EnumDescription("Purple")]
        [ColorCode(162, 0, 255)]
        PURPLE,
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class ColorCodeAttribute : Attribute
    {
        public static Color GetColor(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            ColorCodeAttribute[] attributes =
                (ColorCodeAttribute[])fi.GetCustomAttributes(
                    typeof(ColorCodeAttribute), false);

            return attributes[0].Color;  // Possible IndexOutOfRangeException expected
        }

        public static SolidBrush GetBrush(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            ColorCodeAttribute[] attributes =
                (ColorCodeAttribute[])fi.GetCustomAttributes(
                    typeof(ColorCodeAttribute), false);

            return attributes[0].Brush;  // Possible IndexOutOfRangeException expected
        }

        int r = 0;
        int g = 0;
        int b = 0;

        public ColorCodeAttribute(int r, int g, int b)
        {
            this.r = r;
            this.b = b;
            this.g = g;
        }

        public Color Color
        {
            get
            {
                return Color.FromArgb(this.r, this.g, this.b);
            }
        }
        public SolidBrush Brush
        {
            get
            {
                return new SolidBrush(Color.FromArgb(this.r, this.g, this.b));
            }
        }
    }
}
