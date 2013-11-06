using System.Security.Cryptography;
using System.Text;

namespace Paragon_Database
{
    public static class ExtensionMethods
    {
        public static string Hash<T>(this string input, string salt) where T : HashAlgorithm, new()
        {
            using (T hash = new T())
            {
                byte[] data = hash.ComputeHash(Encoding.UTF8.GetBytes(input + salt));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in data)
                    builder.Append(b.ToString("x2"));

                return builder.ToString();
            }
        }
    }
}
