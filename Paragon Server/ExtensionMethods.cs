using System.Security.Cryptography;
using System.Text;

namespace Paragon_Server
{
    internal static class ExtensionMethods
    {
        public static string Hash<T>(this string input, string salt) where T : HashAlgorithm, new()
        {
            using (T algo = new T())
            {
                byte[] data = algo.ComputeHash(Encoding.UTF8.GetBytes(input + salt));

                StringBuilder sBuilder = new StringBuilder();
                foreach (byte b in data)
                {
                    sBuilder.Append(b.ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }
    }
}
