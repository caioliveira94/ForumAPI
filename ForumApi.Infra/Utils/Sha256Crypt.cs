using System.Text;
using System.Threading.Tasks;

namespace DTM.Infra.Utils
{
    public static class Sha256Crypt
    {
        public static async Task<string> Encrypt(string password)
        {
            byte[] passwordBytes = Encoding.Unicode.GetBytes(password);
            
            var hasher = System.Security.Cryptography.SHA256.Create();
            byte[] hashedBytes = hasher.ComputeHash(passwordBytes);
            return System.Convert.ToBase64String(hashedBytes);
        }
    }
}
