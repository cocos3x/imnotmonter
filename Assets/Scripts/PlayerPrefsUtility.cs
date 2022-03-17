using UnityEngine;
public static class PlayerPrefsUtility
{
    // Fields
    public const string KEY_PREFIX = "ENC-";
    public const string VALUE_FLOAT_PREFIX = "0";
    public const string VALUE_INT_PREFIX = "1";
    public const string VALUE_STRING_PREFIX = "2";
    
    // Methods
    public static bool IsEncryptedKey(string key)
    {
        if(key != null)
        {
                return key.StartsWith(value:  -1610608621);
        }
        
        return key.StartsWith(value:  -1610608621);
    }
    public static string DecryptKey(string encryptedKey)
    {
        var val_4;
        if((encryptedKey.StartsWith(value:  -1610608621)) != false)
        {
                val_4 = -1610608621;
            if(val_4 == 0)
        {
                val_4 = -1610608621;
        }
        
            string val_2 = encryptedKey.Substring(startIndex:  mem[2684358683]);
            if((mem[536893920] & true) != 0)
        {
                return Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.DecryptString(sourceString:  encryptedKey);
        }
        
            if(mem[536893849] != 0)
        {
                return Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.DecryptString(sourceString:  encryptedKey);
        }
        
            return Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.DecryptString(sourceString:  encryptedKey);
        }
        
        22712548 = new System.InvalidOperationException(message:  22784080);
    }
    public static void SetEncryptedFloat(string key, float value)
    {
        string val_1 = Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.EncryptString(sourceString:  key);
        string val_2 = Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.EncryptFloat(value:  value);
        string val_3 = -1610608621(-1610608621) + key;
        string val_4 = -1610611655(-1610611655) + R1;
        UnityEngine.PlayerPrefs.SetString(key:  -1610608621, value:  -1610611655);
    }
    public static void SetEncryptedInt(string key, int value)
    {
        string val_1 = Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.EncryptString(sourceString:  key);
        string val_2 = Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.EncryptInt(value:  value);
        string val_3 = -1610608621(-1610608621) + key;
        string val_4 = -1610611593(-1610611593) + value;
        UnityEngine.PlayerPrefs.SetString(key:  -1610608621, value:  -1610611593);
    }
    public static void SetEncryptedString(string key, string value)
    {
        string val_1 = Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.EncryptString(sourceString:  key);
        string val_2 = Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.EncryptString(sourceString:  value);
        string val_3 = -1610608621(-1610608621) + key;
        string val_4 = -1610611217(-1610611217) + value;
        UnityEngine.PlayerPrefs.SetString(key:  -1610608621, value:  -1610611217);
    }
    public static object GetEncryptedValue(string encryptedKey, string encryptedValue)
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        if((encryptedValue.StartsWith(value:  -1610611655)) != false)
        {
                val_14 = -1610608621;
            if(val_14 == 0)
        {
                val_14 = -1610608621;
        }
        
            string val_2 = encryptedKey.Substring(startIndex:  mem[2684358683]);
            string val_3 = Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.DecryptString(sourceString:  encryptedKey);
            float val_4 = PlayerPrefsUtility.GetEncryptedFloat(key:  encryptedKey, defaultValue:  null);
            val_15 = 536893745;
            return;
        }
        
        if((encryptedValue.StartsWith(value:  -1610611593)) != false)
        {
                val_16 = -1610608621;
            if(val_16 == 0)
        {
                val_16 = -1610608621;
        }
        
            string val_6 = encryptedKey.Substring(startIndex:  mem[2684358683]);
            string val_7 = Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.DecryptString(sourceString:  encryptedKey);
            int val_8 = PlayerPrefsUtility.GetEncryptedInt(key:  encryptedKey, defaultValue:  0);
            val_15 = 536888987;
            return;
        }
        
        if((encryptedValue.StartsWith(value:  -1610611217)) != false)
        {
                val_17 = -1610608621;
            if(val_17 == 0)
        {
                val_17 = -1610608621;
        }
        
            string val_10 = encryptedKey.Substring(startIndex:  mem[2684358683]);
            string val_11 = Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.DecryptString(sourceString:  encryptedKey);
            string val_12 = PlayerPrefsUtility.GetEncryptedString(key:  encryptedKey, defaultValue:  -1610612735);
            return;
        }
        
        22712548 = new System.InvalidOperationException(message:  22784080);
    }
    public static float GetEncryptedFloat(string key, float defaultValue = 0)
    {
        string val_1 = Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.EncryptString(sourceString:  key);
        string val_2 = -1610608621(-1610608621) + key;
        string val_3 = UnityEngine.PlayerPrefs.GetString(key:  -1610608621);
        if((System.String.IsNullOrEmpty(value:  -1610608621)) != false)
        {
                return (float)defaultValue;
        }
        
        string val_5 = -1610608621.Remove(startIndex:  0, count:  1);
        if((mem[536893920] & true) != 0)
        {
                return Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.DecryptFloat(sourceString:  -1610608621);
        }
        
        if(mem[536893849] != 0)
        {
                return Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.DecryptFloat(sourceString:  -1610608621);
        }
        
        return Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.DecryptFloat(sourceString:  -1610608621);
    }
    public static int GetEncryptedInt(string key, int defaultValue = 0)
    {
        string val_1 = Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.EncryptString(sourceString:  key);
        string val_2 = -1610608621(-1610608621) + key;
        string val_3 = UnityEngine.PlayerPrefs.GetString(key:  -1610608621);
        if((System.String.IsNullOrEmpty(value:  -1610608621)) != false)
        {
                return (int)defaultValue;
        }
        
        string val_5 = -1610608621.Remove(startIndex:  0, count:  1);
        if((mem[536893920] & true) != 0)
        {
                return Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.DecryptInt(sourceString:  -1610608621);
        }
        
        if(mem[536893849] != 0)
        {
                return Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.DecryptInt(sourceString:  -1610608621);
        }
        
        return Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.DecryptInt(sourceString:  -1610608621);
    }
    public static string GetEncryptedString(string key, string defaultValue = "")
    {
        string val_1 = Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.EncryptString(sourceString:  key);
        string val_2 = -1610608621(-1610608621) + key;
        string val_3 = UnityEngine.PlayerPrefs.GetString(key:  -1610608621);
        if((System.String.IsNullOrEmpty(value:  -1610608621)) != false)
        {
                return;
        }
        
        string val_5 = -1610608621.Remove(startIndex:  0, count:  1);
        if((mem[536893920] & true) != 0)
        {
                return Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.DecryptString(sourceString:  -1610608621);
        }
        
        if(mem[536893849] != 0)
        {
                return Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.DecryptString(sourceString:  -1610608621);
        }
        
        return Sabresaurus.PlayerPrefsExtensions.SimpleEncryption.DecryptString(sourceString:  -1610608621);
    }
    public static void SetBool(string key, bool value)
    {
        if(value == false)
        {
                value = 0;
        }
        
        if(value == true)
        {
                value = 1;
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  key, value:  1);
    }
    public static bool GetBool(string key, bool defaultValue = False)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) == false)
        {
                return (bool)defaultValue;
        }
        
        int val_2 = UnityEngine.PlayerPrefs.GetInt(key:  key);
        if(val_2 != 0)
        {
                val_2 = 1;
        }
        
        return true;
    }
    public static void SetEnum(string key, System.Enum value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  key, value:  value);
    }
    public static T GetEnum<T>(string key, T defaultValue); // 0
    public static object GetEnum(string key, System.Type enumType, object defaultValue)
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  key);
        if((System.String.IsNullOrEmpty(value:  key)) != false)
        {
                return;
        }
        
        if((mem[536886578] & true) != 0)
        {
                return System.Enum.Parse(enumType:  enumType, value:  key);
        }
        
        if(mem[536886507] != 0)
        {
                return System.Enum.Parse(enumType:  enumType, value:  key);
        }
        
        return System.Enum.Parse(enumType:  enumType, value:  key);
    }
    public static void SetDateTime(string key, System.DateTime value)
    {
        System.Globalization.CultureInfo val_1 = System.Globalization.CultureInfo.InvariantCulture;
        string val_2 = ???.ToString(format:  -1610599025, provider:  0);
        UnityEngine.PlayerPrefs.SetString(key:  key, value:  521414456);
    }
    public static System.DateTime GetDateTime(string key, System.DateTime defaultValue)
    {
        ulong val_6;
        var val_7;
        var val_8;
        ulong val_9;
        val_7 = R3;
        val_8 = R2;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  defaultValue.dateData);
        if((System.String.IsNullOrEmpty(value:  defaultValue.dateData)) != false)
        {
                mem2[0] = val_8;
            return new System.DateTime() {dateData = val_9};
        }
        
        val_7 = 0;
        System.Globalization.CultureInfo val_3 = System.Globalization.CultureInfo.InvariantCulture;
        val_8 = 0;
        System.DateTime val_4 = System.DateTime.Parse(s:  521534632, provider:  defaultValue.dateData, styles:  0);
        val_9 = val_6;
        mem2[0] = val_9;
        return new System.DateTime() {dateData = val_9};
    }
    public static void SetTimeSpan(string key, System.TimeSpan value)
    {
        string val_1 = ToString();
        UnityEngine.PlayerPrefs.SetString(key:  key, value:  521654840);
    }
    public static System.TimeSpan GetTimeSpan(string key, System.TimeSpan defaultValue)
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  defaultValue._ticks);
        if((System.String.IsNullOrEmpty(value:  defaultValue._ticks)) != false)
        {
                mem2[0] = R2;
            return new System.TimeSpan();
        }
        
        System.TimeSpan val_3 = System.TimeSpan.Parse(s:  521775016);
        mem2[0] = ???;
        return new System.TimeSpan();
    }

}
