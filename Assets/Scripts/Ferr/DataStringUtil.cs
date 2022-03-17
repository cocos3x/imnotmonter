using UnityEngine;

namespace Ferr
{
    public static class DataStringUtil
    {
        // Fields
        private static string _key;
        
        // Methods
        public static string Encrypt(string aData, string aKey)
        {
            string val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_11 = aKey;
            if((System.String.IsNullOrEmpty(value:  val_11)) != false)
            {
                    val_12 = 536885683;
                if(((mem[536885870] & true) == 0) && (mem[536885799] == 0))
            {
                    val_12 = 536885683;
            }
            
                val_11 = mem[mem[536885775]];
                val_11 = mem[536885775];
            }
            
            System.Text.Encoding val_2 = System.Text.Encoding.Unicode;
            System.Security.Cryptography.Aes val_3 = System.Security.Cryptography.Aes.Create();
            val_13 = 0;
            536892935 = new System.Security.Cryptography.Rfc2898DeriveBytes(password:  val_11, salt:  536881741);
            System.IO.MemoryStream val_5 = 536890411;
            val_5 = new System.IO.MemoryStream();
            536885435 = new System.Security.Cryptography.CryptoStream(stream:  536890411, transform:  0, mode:  1);
            var val_15 = mem[536885435];
            if((mem[536885435] + 178) == 0)
            {
                goto label_11;
            }
            
            var val_14 = 0;
            label_13:
            val_13 = mem[mem[536885435] + 88 + 0];
            val_13 = mem[536885435] + 88 + 0;
            if(val_13 == 536888187)
            {
                goto label_12;
            }
            
            val_14 = val_14 + 1;
            if(((uint)val_14 & 65535) < (mem[536885435] + 178))
            {
                goto label_13;
            }
            
            label_11:
            val_14 = 536885435;
            goto label_14;
            label_12:
            var val_7 = (mem[536885435] + 88) + 0;
            val_15 = val_15 + (((mem[536885435] + 88 + 0) + 4) << 3);
            val_14 = val_15 + 188;
            label_14:
            if(1 != 0)
            {
                    var val_8 = 1 - 1;
                if((1152921510122832032 + ((1 - 1)) << 2) == 140)
            {
                    val_15 = val_8;
            }
            
            }
            else
            {
                    val_15 = 0;
            }
            
            string val_9 = System.Convert.ToBase64String(inArray:  536890411);
            var val_10 = val_8 + 1;
            var val_16 = mem[536890411];
            if((mem[536890411] + 178) == 0)
            {
                goto label_21;
            }
            
            val_13 = 0;
            label_23:
            if((mem[536890411] + 88 + 0) == 536888187)
            {
                goto label_22;
            }
            
            val_13 = val_13 + 1;
            if(((uint)val_13 & 65535) < (mem[536890411] + 178))
            {
                goto label_23;
            }
            
            label_21:
            val_16 = val_5;
            goto label_24;
            label_22:
            var val_11 = (mem[536890411] + 88) + 0;
            val_16 = val_16 + (((mem[536890411] + 88 + 0) + 4) << 3);
            val_16 = val_16 + 188;
            label_24:
            if(val_13 == 0)
            {
                goto label_26;
            }
            
            var val_17 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_27;
            }
            
            val_13 = 0;
            label_29:
            if((mem[1179403735] + 0) == 536888187)
            {
                goto label_28;
            }
            
            val_13 = val_13 + 1;
            if(((uint)val_13 & 65535) < mem[1179403825])
            {
                goto label_29;
            }
            
            label_27:
            val_17 = val_13;
            goto label_30;
            label_28:
            var val_12 = mem[1179403735] + 0;
            val_17 = val_17 + (((mem[1179403735] + 0) + 4) << 3);
            val_17 = val_17 + 188;
            label_30:
            label_26:
            if(val_10 == 0)
            {
                    return;
            }
            
            var val_13 = val_10 - 1;
        }
        public static string Decrypt(string aData, string aKey)
        {
            string val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            val_12 = aKey;
            if((System.String.IsNullOrEmpty(value:  val_12)) != false)
            {
                    val_13 = 536885683;
                if(((mem[536885870] & true) == 0) && (mem[536885799] == 0))
            {
                    val_13 = 536885683;
            }
            
                val_12 = mem[mem[536885775]];
                val_12 = mem[536885775];
            }
            
            string val_2 = aData.Replace(oldValue:  -1610612561, newValue:  -1610611917);
            System.Byte[] val_3 = System.Convert.FromBase64String(s:  aData);
            System.Security.Cryptography.Aes val_4 = System.Security.Cryptography.Aes.Create();
            val_14 = 0;
            536892935 = new System.Security.Cryptography.Rfc2898DeriveBytes(password:  val_12, salt:  536881741);
            System.IO.MemoryStream val_6 = 536890411;
            val_6 = new System.IO.MemoryStream();
            536885435 = new System.Security.Cryptography.CryptoStream(stream:  536890411, transform:  0, mode:  1);
            var val_16 = mem[536885435];
            if((mem[536885435] + 178) == 0)
            {
                goto label_13;
            }
            
            var val_15 = 0;
            label_15:
            val_14 = mem[mem[536885435] + 88 + 0];
            val_14 = mem[536885435] + 88 + 0;
            if(val_14 == 536888187)
            {
                goto label_14;
            }
            
            val_15 = val_15 + 1;
            if(((uint)val_15 & 65535) < (mem[536885435] + 178))
            {
                goto label_15;
            }
            
            label_13:
            val_15 = 536885435;
            goto label_16;
            label_14:
            var val_8 = (mem[536885435] + 88) + 0;
            val_16 = val_16 + (((mem[536885435] + 88 + 0) + 4) << 3);
            val_15 = val_16 + 188;
            label_16:
            if(1 != 0)
            {
                    var val_9 = 1 - 1;
                if((1152921510122960416 + ((1 - 1)) << 2) == 153)
            {
                    val_16 = val_9;
            }
            
            }
            else
            {
                    val_16 = 0;
            }
            
            System.Text.Encoding val_10 = System.Text.Encoding.Unicode;
            var val_11 = val_9 + 1;
            var val_17 = mem[536890411];
            if((mem[536890411] + 178) == 0)
            {
                goto label_22;
            }
            
            val_14 = 0;
            label_24:
            if((mem[536890411] + 88 + 0) == 536888187)
            {
                goto label_23;
            }
            
            val_14 = val_14 + 1;
            if(((uint)val_14 & 65535) < (mem[536890411] + 178))
            {
                goto label_24;
            }
            
            label_22:
            val_17 = val_6;
            goto label_25;
            label_23:
            var val_12 = (mem[536890411] + 88) + 0;
            val_17 = val_17 + (((mem[536890411] + 88 + 0) + 4) << 3);
            val_17 = val_17 + 188;
            label_25:
            if(val_14 == 0)
            {
                goto label_27;
            }
            
            var val_18 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_28;
            }
            
            val_14 = 0;
            label_30:
            if((mem[1179403735] + 0) == 536888187)
            {
                goto label_29;
            }
            
            val_14 = val_14 + 1;
            if(((uint)val_14 & 65535) < mem[1179403825])
            {
                goto label_30;
            }
            
            label_28:
            val_18 = val_14;
            goto label_31;
            label_29:
            var val_13 = mem[1179403735] + 0;
            val_18 = val_18 + (((mem[1179403735] + 0) + 4) << 3);
            val_18 = val_18 + 188;
            label_31:
            label_27:
            if(val_11 == 0)
            {
                    return;
            }
            
            var val_14 = val_11 - 1;
        }
        public static System.Collections.Generic.List<string> SplitSmart(string aData, char aSeparator)
        {
            var val_8;
            var val_9;
            var val_10;
            int val_11;
            var val_12;
            var val_13;
            536878341 = new System.Collections.Generic.List<Page>();
            val_8 = -1610612735;
            string val_2 = aData.Trim();
            val_9 = aData;
            val_10 = 0;
            if((val_9.StartsWith(value:  -1610597137)) != false)
            {
                    if(val_9 != null)
            {
                    val_11 = aData.m_stringLength;
            }
            else
            {
                    val_11 = 0;
            }
            
                string val_4 = val_9.Substring(startIndex:  1, length:  -2);
                val_9 = val_9;
            }
            
            val_12 = 32;
            val_13 = 0;
            goto label_6;
            label_18:
            char val_5 = val_9.Chars[0];
            if(32 != 32)
            {
                goto label_7;
            }
            
            if(val_5 != aSeparator)
            {
                goto label_8;
            }
            
            536878341.Add(item:  -1610612735);
            val_12 = 32;
            val_8 = -1610612735;
            goto label_10;
            label_7:
            if(val_5 != 32)
            {
                goto label_11;
            }
            
            if(val_13 == 0)
            {
                    val_12 = 32;
            }
            
            if(val_13 != 0)
            {
                    val_13 = -1;
            }
            
            goto label_16;
            label_8:
            if(val_5 == '"')
            {
                goto label_13;
            }
            
            val_12 = 125;
            if(val_5 == '{')
            {
                goto label_16;
            }
            
            if(val_5 != ''')
            {
                    val_5 = 32;
            }
            
            val_12 = 32;
            goto label_16;
            label_11:
            if(val_5 == '{')
            {
                    val_13 = 1;
            }
            
            goto label_16;
            label_13:
            val_12 = 34;
            label_16:
            string val_6 = val_5.ToString();
            string val_7 = -1610612735(-1610612735) + 1221270442;
            val_8 = val_8;
            label_10:
            val_10 = 1;
            label_6:
            if(val_10 < aData.m_stringLength)
            {
                goto label_18;
            }
            
            if(mem[2684354569] >= 1)
            {
                    536878341.Add(item:  -1610612735);
            }
            
            if(34 != 32)
            {
                    536878341 = 0;
            }
        
        }
        private static DataStringUtil()
        {
            mem2[0] = -1610608195;
        }
    
    }

}
