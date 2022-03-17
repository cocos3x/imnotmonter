using UnityEngine;

namespace Sabresaurus.PlayerPrefsExtensions
{
    public static class SimpleEncryption
    {
        // Fields
        private static string key;
        private static System.Security.Cryptography.RijndaelManaged provider;
        
        // Methods
        private static void SetupProvider()
        {
            var val_3;
            System.Security.Cryptography.RijndaelManaged val_1 = 536892971;
            val_1 = new System.Security.Cryptography.RijndaelManaged();
            val_3 = 536893733;
            if(((mem[536893920] & true) == 0) && (mem[536893849] == 0))
            {
                    val_3 = 536893733;
            }
            
            mem2[0] = val_1;
            System.Text.Encoding val_2 = System.Text.Encoding.ASCII;
            if((mem[536893825] + 4) == 0)
            {
                
            }
        
        }
        public static string EncryptString(string sourceString)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = 536893733;
            if(((mem[536893920] & true) == 0) && (mem[536893849] == 0))
            {
                    val_3 = 536893733;
            }
            
            if((mem[536893825] + 4) == 0)
            {
                    Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.SetupProvider();
                val_3 = 536893733;
            }
            
            if(((mem[536893920] & true) == 0) && (mem[536893849] == 0))
            {
                    val_3 = 536893733;
            }
            
            System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
            val_4 = 0;
            var val_3 = mem[536893825] + 4;
            if((mem[536893825] + 4 + 178) == 0)
            {
                goto label_12;
            }
            
            val_4 = 0;
            label_14:
            if((mem[536893825] + 4 + 88 + 0) == 536888151)
            {
                goto label_13;
            }
            
            val_4 = val_4 + 1;
            if(((uint)val_4 & 65535) < (mem[536893825] + 4 + 178))
            {
                goto label_14;
            }
            
            label_12:
            val_5 = mem[536893825] + 4;
            goto label_15;
            label_13:
            var val_2 = (mem[536893825] + 4 + 88) + 0;
            val_3 = val_3 + (((mem[536893825] + 4 + 88 + 0) + 4) << 3);
            val_5 = val_3 + 220;
            label_15:
            if((mem[536885524] & true) != 0)
            {
                    return System.Convert.ToBase64String(inArray:  mem[536893825] + 4);
            }
            
            if(mem[536885453] != 0)
            {
                    return System.Convert.ToBase64String(inArray:  mem[536893825] + 4);
            }
            
            return System.Convert.ToBase64String(inArray:  mem[536893825] + 4);
        }
        public static string DecryptString(string sourceString)
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = 536893733;
            if(((mem[536893920] & true) == 0) && (mem[536893849] == 0))
            {
                    val_4 = 536893733;
            }
            
            if((mem[536893825] + 4) == 0)
            {
                    Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.SetupProvider();
                val_4 = 536893733;
            }
            
            if(((mem[536893920] & true) == 0) && (mem[536893849] == 0))
            {
                    val_4 = 536893733;
            }
            
            System.Byte[] val_1 = System.Convert.FromBase64String(s:  sourceString);
            var val_4 = mem[536893825] + 4;
            if((mem[536893825] + 4 + 178) == 0)
            {
                goto label_13;
            }
            
            val_5 = 0;
            label_15:
            if((mem[536893825] + 4 + 88 + 0) == 536888151)
            {
                goto label_14;
            }
            
            val_5 = val_5 + 1;
            if(((uint)val_5 & 65535) < (mem[536893825] + 4 + 178))
            {
                goto label_15;
            }
            
            label_13:
            val_6 = mem[536893825] + 4;
            goto label_16;
            label_14:
            var val_2 = (mem[536893825] + 4 + 88) + 0;
            val_4 = val_4 + (((mem[536893825] + 4 + 88 + 0) + 4) << 3);
            val_6 = val_4 + 220;
            label_16:
            System.Text.Encoding val_3 = System.Text.Encoding.UTF8;
            if(0 == 0)
            {
                
            }
        
        }
        public static string EncryptFloat(float value)
        {
            System.Byte[] val_1 = System.BitConverter.GetBytes(value:  value);
            string val_2 = System.Convert.ToBase64String(inArray:  null);
            if((mem[536893920] & true) != 0)
            {
                    return Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.EncryptString(sourceString:  null);
            }
            
            if(mem[536893849] != 0)
            {
                    return Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.EncryptString(sourceString:  null);
            }
            
            return Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.EncryptString(sourceString:  null);
        }
        public static string EncryptInt(int value)
        {
            System.Byte[] val_1 = System.BitConverter.GetBytes(value:  value);
            string val_2 = System.Convert.ToBase64String(inArray:  value);
            if((mem[536893920] & true) != 0)
            {
                    return Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.EncryptString(sourceString:  value);
            }
            
            if(mem[536893849] != 0)
            {
                    return Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.EncryptString(sourceString:  value);
            }
            
            return Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.EncryptString(sourceString:  value);
        }
        public static float DecryptFloat(string sourceString)
        {
            string val_1 = Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.DecryptString(sourceString:  sourceString);
            System.Byte[] val_2 = System.Convert.FromBase64String(s:  sourceString);
            if((mem[536884352] & true) != 0)
            {
                    return System.BitConverter.ToSingle(value:  sourceString, startIndex:  0);
            }
            
            if(mem[536884281] != 0)
            {
                    return System.BitConverter.ToSingle(value:  sourceString, startIndex:  0);
            }
            
            return System.BitConverter.ToSingle(value:  sourceString, startIndex:  0);
        }
        public static int DecryptInt(string sourceString)
        {
            string val_1 = Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.DecryptString(sourceString:  sourceString);
            System.Byte[] val_2 = System.Convert.FromBase64String(s:  sourceString);
            if((mem[536884352] & true) != 0)
            {
                    return System.BitConverter.ToInt32(value:  sourceString, startIndex:  0);
            }
            
            if(mem[536884281] != 0)
            {
                    return System.BitConverter.ToInt32(value:  sourceString, startIndex:  0);
            }
            
            return System.BitConverter.ToInt32(value:  sourceString, startIndex:  0);
        }
        private static SimpleEncryption()
        {
            mem2[0] = -1610610699;
            mem2[0] = 0;
        }
    
    }

}
