using System.Security.Cryptography;
using System.Text;

namespace FinalsHRApplicantProcessWindowsApplication.Helpers
{
    public static class PasswordHelper
    {
        public static string Hash(string plainText)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
    }
}
