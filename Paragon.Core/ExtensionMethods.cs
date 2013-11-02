using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Paragon.Core
{
    internal static class ExtensionMethods
    {
        public static void Close<T>(this T service)
        {
// ReSharper disable once SuspiciousTypeConversion.Global
            IClientChannel channel = service as IClientChannel;

            if (channel != null)
                channel.Close();
        }

    }
}
