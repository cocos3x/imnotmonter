using UnityEngine;

namespace Dmobin
{
    public static class Encoding
    {
        // Methods
        public static byte[] GetBytes(string str)
        {
            int val_2 = str.m_stringLength;
            val_2 = val_2 << 1;
            System.Char[] val_1 = str.ToCharArray();
            System.Buffer.BlockCopy(src:  str, srcOffset:  0, dst:  536881741, dstOffset:  0, count:  mem[536881753]);
        }
        public static string GetString(byte[] bytes)
        {
            var val_1 = R1 + ((R1) >> 31);
            val_1 = val_1 >> 1;
            System.Buffer.BlockCopy(src:  bytes, srcOffset:  0, dst:  536881793, dstOffset:  0, count:  536881793);
            return 0.CreateString(val:  536881793);
        }
    
    }

}
