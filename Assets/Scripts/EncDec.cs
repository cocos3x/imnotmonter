using UnityEngine;
public static class EncDec
{
    // Methods
    public static byte[] Encrypt(byte[] clearData, byte[] Key, byte[] IV)
    {
        System.IO.MemoryStream val_1 = 536890411;
        val_1 = new System.IO.MemoryStream();
        System.Security.Cryptography.Rijndael val_2 = System.Security.Cryptography.Rijndael.Create();
        if(0 != 0)
        {
            
        }
        
        536885435 = new System.Security.Cryptography.CryptoStream(stream:  536890411, transform:  0, mode:  1);
        if(val_1 == 0)
        {
            
        }
    
    }
    public static string Encrypt(string clearText, string Password)
    {
        System.Text.Encoding val_1 = System.Text.Encoding.Unicode;
        536891581 = new System.Security.Cryptography.PasswordDeriveBytes(strPassword:  Password, rgbSalt:  536881741);
        System.Byte[] val_3 = EncDec.Encrypt(clearData:  null, Key:  536891581, IV:  536891581);
        if((mem[536885524] & true) != 0)
        {
                return System.Convert.ToBase64String(inArray:  null);
        }
        
        if(mem[536885453] != 0)
        {
                return System.Convert.ToBase64String(inArray:  null);
        }
        
        return System.Convert.ToBase64String(inArray:  null);
    }
    public static byte[] Encrypt(byte[] clearData, string Password)
    {
        System.Security.Cryptography.PasswordDeriveBytes val_1 = 536891581;
        val_1 = new System.Security.Cryptography.PasswordDeriveBytes(strPassword:  Password, rgbSalt:  536881741);
        if(val_1 != 0)
        {
                return EncDec.Encrypt(clearData:  clearData, Key:  536891581, IV:  536891581);
        }
        
        return EncDec.Encrypt(clearData:  clearData, Key:  536891581, IV:  536891581);
    }
    public static void Encrypt(string fileIn, string fileOut, string Password)
    {
        System.IO.FileStream val_1 = 536886889;
        val_1 = new System.IO.FileStream(path:  fileIn, mode:  3, access:  1);
        536886889 = new System.IO.FileStream(path:  fileOut, mode:  4, access:  2);
        536891581 = new System.Security.Cryptography.PasswordDeriveBytes(strPassword:  Password, rgbSalt:  536881741);
        System.Security.Cryptography.Rijndael val_4 = System.Security.Cryptography.Rijndael.Create();
        if(0 != 0)
        {
            
        }
        
        536885435 = new System.Security.Cryptography.CryptoStream(stream:  536886889, transform:  0, mode:  1);
        do
        {
        
        }
        while(val_1 != 0);
        
        goto mem[536886889] + 324;
    }
    public static byte[] Decrypt(byte[] cipherData, byte[] Key, byte[] IV)
    {
        System.IO.MemoryStream val_1 = 536890411;
        val_1 = new System.IO.MemoryStream();
        System.Security.Cryptography.Rijndael val_2 = System.Security.Cryptography.Rijndael.Create();
        if(0 != 0)
        {
            
        }
        
        536885435 = new System.Security.Cryptography.CryptoStream(stream:  536890411, transform:  0, mode:  1);
        if(val_1 == 0)
        {
            
        }
    
    }
    public static string Decrypt(string cipherText, string Password)
    {
        System.Byte[] val_1 = System.Convert.FromBase64String(s:  cipherText);
        536891581 = new System.Security.Cryptography.PasswordDeriveBytes(strPassword:  Password, rgbSalt:  536881741);
        System.Byte[] val_3 = EncDec.Decrypt(cipherData:  cipherText, Key:  536891581, IV:  536891581);
        System.Text.Encoding val_4 = System.Text.Encoding.Unicode;
        if(0 == 0)
        {
            
        }
    
    }
    public static byte[] Decrypt(byte[] cipherData, string Password)
    {
        System.Security.Cryptography.PasswordDeriveBytes val_1 = 536891581;
        val_1 = new System.Security.Cryptography.PasswordDeriveBytes(strPassword:  Password, rgbSalt:  536881741);
        if(val_1 != 0)
        {
                return EncDec.Decrypt(cipherData:  cipherData, Key:  536891581, IV:  536891581);
        }
        
        return EncDec.Decrypt(cipherData:  cipherData, Key:  536891581, IV:  536891581);
    }
    public static void Decrypt(string fileIn, string fileOut, string Password)
    {
        System.IO.FileStream val_1 = 536886889;
        val_1 = new System.IO.FileStream(path:  fileIn, mode:  3, access:  1);
        536886889 = new System.IO.FileStream(path:  fileOut, mode:  4, access:  2);
        536891581 = new System.Security.Cryptography.PasswordDeriveBytes(strPassword:  Password, rgbSalt:  536881741);
        System.Security.Cryptography.Rijndael val_4 = System.Security.Cryptography.Rijndael.Create();
        if(0 != 0)
        {
            
        }
        
        536885435 = new System.Security.Cryptography.CryptoStream(stream:  536886889, transform:  0, mode:  1);
        do
        {
        
        }
        while(val_1 != 0);
        
        goto mem[536886889] + 324;
    }

}
