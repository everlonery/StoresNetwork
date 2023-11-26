using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork
{
    internal static class PropNameHelper
    {
        public static string GetDisplayName<T>(string propertyName)
        {
            var propertyInfo = typeof(T).GetProperty(propertyName);
            if (propertyInfo != null)
            {
                var displayNameAttribute = propertyInfo.GetCustomAttribute<DisplayNameAttribute>();
                if (displayNameAttribute != null)
                {
                    return displayNameAttribute.DisplayName;
                }
            }
            return propertyName;
        }
    }
}
