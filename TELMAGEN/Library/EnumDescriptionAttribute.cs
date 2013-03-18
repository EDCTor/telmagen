using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace TELMAGEN
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple=false, Inherited= false)]
    public class EnumDescriptionAttribute : Attribute
    {
        public static string GetDescription(Enum value)
        {           
            FieldInfo fi = value.GetType().GetField(value.ToString());

            EnumDescriptionAttribute[] attributes =
                (EnumDescriptionAttribute[])fi.GetCustomAttributes(
                    typeof(EnumDescriptionAttribute), false);

            return (attributes.Length > 0) ? attributes[0].Description : null;
        }

        string description = null;

        public EnumDescriptionAttribute(string description)
        {
            Debug.Assert(description != null);

            this.description = description;
        }

        public string Description
        {
            get
            {
                return this.description;
            }
        }

        public override string ToString()
        {
            return description;
        }
    }
}
