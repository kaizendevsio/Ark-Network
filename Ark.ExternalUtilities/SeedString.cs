using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ark.ExternalUtilities
{
    public class SeedString
    {
        public string GenerateRandom(int length)
        {
            Random random = new Random();

            const string chars = "ABCDEFGHJKMNPQRSTUVWXYZabcdefghjkmnpqrstuvwxyz123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
