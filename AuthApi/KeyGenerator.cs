using System;
using System.Security.Cryptography;
using System.Text;

public class KeyGenerator
{
    public static string GenerateSecretKey(int keySizeInBits)
    {
        byte[] keyBytes = new byte[keySizeInBits / 8]; // Convert bits to bytes
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(keyBytes);
        }
        return Convert.ToBase64String(keyBytes);
    }
}
