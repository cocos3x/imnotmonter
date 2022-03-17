using UnityEngine;
private sealed class Json.Serializer
{
    // Fields
    private System.Text.StringBuilder builder;
    
    // Methods
    private Json.Serializer()
    {
        System.Text.StringBuilder val_1 = 536894635;
        val_1 = new System.Text.StringBuilder();
        this.builder = val_1;
    }
    public static string Serialize(object obj)
    {
        Json.Serializer val_1 = 536899473;
        val_1 = new Json.Serializer();
        if(val_1 != 0)
        {
                this.SerializeValue(value:  obj);
        }
        else
        {
                this.SerializeValue(value:  obj);
        }
        
        if(mem[536899481] == 0)
        {
            
        }
    
    }
    private void SerializeValue(object value)
    {
        string val_3;
        if(value == 0)
        {
            goto label_1;
        }
        
        if(null == 536894583)
        {
            goto label_2;
        }
        
        if(null == 536884213)
        {
            goto label_3;
        }
        
        if(value == 0)
        {
            goto label_4;
        }
        
        this.SerializeArray(anArray:  value);
        return;
        label_1:
        val_3 = -1610599037;
        goto label_6;
        label_2:
        this.SerializeString(str:  value);
        return;
        label_3:
        string val_1 = value.ToLower();
        val_3 = value;
        label_6:
        System.Text.StringBuilder val_2 = this.builder.Append(value:  val_3);
        return;
        label_4:
        if(value != 0)
        {
                this.SerializeObject(obj:  value);
            return;
        }
        
        if(null != 536884721)
        {
                this.SerializeOther(value:  value);
            return;
        }
        
        this.SerializeString(str:  value);
    }
    private void SerializeObject(System.Collections.IDictionary obj)
    {
        var val_11;
        string val_12;
        var val_13;
        string val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        System.Text.StringBuilder val_1 = this.builder.Append(value:  '{');
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_11 = obj;
        val_12 = obj;
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_13 = val_12;
        val_14 = val_12;
        label_32:
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_12 = (uint)val_14 & 65535;
        val_15 = val_14;
        if(val_14 == 0)
        {
            goto label_17;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_16 = val_14;
        if(1 == 1)
        {
                System.Text.StringBuilder val_6 = this.builder.Append(value:  ',');
        }
        
        this.SerializeString(str:  val_14);
        System.Text.StringBuilder val_7 = this.builder.Append(value:  ':');
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_17 = obj;
        this.SerializeValue(value:  obj);
        goto label_32;
        label_17:
        val_18 = 0;
        val_19 = 22711796;
        if(val_14 != 0)
        {
                val_12 = val_14;
            val_14 = val_18;
            val_19 = 0;
            val_19 = val_19 + 1;
            val_20 = val_12;
            val_18 = val_14;
        }
        
        if(1 != 0)
        {
                var val_10 = 1 - 1;
        }
        
        System.Text.StringBuilder val_11 = this.builder.Append(value:  '}');
    }
    private void SerializeArray(System.Collections.IList anArray)
    {
        System.Text.StringBuilder val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_8 = this.builder;
        System.Text.StringBuilder val_1 = val_8.Append(value:  '[');
        var val_9 = 0;
        val_8 = 0;
        val_9 = val_9 + 1;
        val_8 = (uint)val_9 & 65535;
        val_9 = anArray;
        label_20:
        val_8 = 0;
        val_8 = val_8 + 1;
        val_10 = anArray;
        if(anArray == 0)
        {
            goto label_12;
        }
        
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_11 = anArray;
        if(1 == 1)
        {
                System.Text.StringBuilder val_5 = this.builder.Append(value:  ',');
        }
        
        this.SerializeValue(value:  anArray);
        goto label_20;
        label_12:
        val_12 = 22711796;
        if(anArray != 0)
        {
                val_12 = 0;
            val_8 = 0;
            val_12 = val_12 + 1;
            val_8 = (uint)val_12 & 65535;
            val_13 = anArray;
        }
        
        if(1 != 0)
        {
                var val_7 = 1 - 1;
        }
        
        System.Text.StringBuilder val_8 = this.builder.Append(value:  ']');
    }
    private void SerializeString(string str)
    {
        System.Text.StringBuilder val_11;
        var val_12;
        var val_13;
        string val_12 = str;
        var val_13 = 0;
        System.Text.StringBuilder val_1 = this.builder.Append(value:  '"');
        System.Char[] val_2 = val_12.ToCharArray();
        val_12 = val_12 + 16;
        label_30:
        if(val_13 >= str.m_firstChar)
        {
            goto label_4;
        }
        
        string val_3 = 1152921504621649920 - 8;
        if(val_3 > 5)
        {
            goto label_6;
        }
        
        var val_4 = 17867504 + (17867504 + ((1152921504621649920 - 8)) << 2);
        if(val_3 == 5)
        {
                17867504 + ((1152921504621649920 - 8)) << 2 = (17867504 + ((1152921504621649920 - 8)) << 2) & (this << (17867504 + ((1152921504621649920 - 8)) << 2));
            17867504 + ((1152921504621649920 - 8)) << 2 = (17867504 + ((1152921504621649920 - 8)) << 2) & 1159161456;
            17867504 + ((1152921504621649920 - 8)) << 2 = (17867504 + ((1152921504621649920 - 8)) << 2) & (this.builder >> 17867504);
            17867504 + ((1152921504621649920 - 8)) << 2 = (17867504 + ((1152921504621649920 - 8)) << 2) & ((((((17867504 + ((1152921504621649920 - 8)) << 2 & (this) << 17867504 + ((1152921504621649920 - 8)) << 2) & 1159161456) & ((int)this.builder) >> 17867504)) << (32-as. 
            
        
        
        
        
        
           
        )) | (((((17867504 + ((1152921504621649920 - 8)) << 2 & (this) << 17867504 + ((1152921504621649920 - 8)) << 2) & 1159161456) & ((int)this.builder) >> 17867504)) << as. 
            
        
        
        
        
        
           
        ));
            17867504 + ((1152921504621649920 - 8)) << 2 = (17867504 + ((1152921504621649920 - 8)) << 2) & (((((((17867504 + ((1152921504621649920 - 8)) << 2 & (this) << 17867504 + ((1152921504621649920 - 8)) << 2) & 1159161456) & ((int)this.builder) >> 17867504) & (((((17867504 + ((1152921504621649920 - 8)) ) << (32-17867504)) | ((((((17867504 + ((1152921504621649920 - 8)) << 2 & (this) << 17867504 + ((1152921504621649920 - 8)) << 2) & 1159161456) & ((int)this.builder) >> 17867504) & (((((17867504 + ((1152921504621649920 - 8)) ) << 17867504));
            17867504 + ((1152921504621649920 - 8)) << 2 = (17867504 + ((1152921504621649920 - 8)) << 2) & ((IP) << 3);
        }
        
        val_11 = this.builder;
        val_12 = 22797820;
        goto label_28;
        label_6:
        if(null == 92)
        {
            goto label_9;
        }
        
        if(null != 34)
        {
            goto label_10;
        }
        
        val_11 = this.builder;
        val_12 = 22797804;
        goto label_28;
        label_10:
        int val_5 = System.Convert.ToInt32(value:  '');
        val_5 = val_5 - 32;
        if(val_5 <= 94)
        {
            goto label_15;
        }
        
        string val_6 = System.Convert.ToString(value:  val_5, toBase:  16);
        string val_7 = val_5.PadLeft(totalWidth:  4, paddingChar:  '0');
        string val_8 = -1610602241(-1610602241) + val_5;
        val_13 = -1610602241;
        goto label_20;
        label_9:
        val_11 = this.builder;
        val_12 = 22797808;
        label_28:
        label_20:
        System.Text.StringBuilder val_9 = val_11.Append(value:  -1610602261);
        label_32:
        val_12 = val_12 + 2;
        val_13 = val_13 + 1;
        goto label_30;
        label_15:
        System.Text.StringBuilder val_10 = this.builder.Append(value:  '');
        goto label_32;
        label_4:
        System.Text.StringBuilder val_11 = this.builder.Append(value:  '"');
    }
    private void SerializeOther(object value)
    {
        if(value == 0)
        {
            goto label_1;
        }
        
        if(null != 536893745)
        {
                536893745 = 4985924;
            536893745 = 22712448;
            536893745 = 536888987;
        }
        
        if(null != 536893745)
        {
                if(null != 536896155)
        {
                536896155 = 4990344;
            536896155 = 22712456;
            536896155 = 536889041;
        }
        
            if(null != 536896155)
        {
                if(null != 536886067)
        {
                536886067 = 5016072;
            536886067 = 22714780;
            536886067 = 536893177;
        }
        
            if(null != 536886067)
        {
                if(null != 536884367)
        {
                536884367 = 5016024;
            536884367 = 22712444;
            536884367 = 536888971;
        }
        
            if(null != 536884367)
        {
                if(null != 536896141)
        {
                536896141 = 4999060;
            536896141 = 22716228;
            536896141 = 536896177;
            goto label_6;
        }
        
        }
        
        }
        
        }
        
        }
        
        label_9:
        System.Text.StringBuilder val_1 = this.builder.Append(value:  value);
        return;
        label_1:
        label_8:
        this.SerializeString(str:  value);
        return;
        label_6:
        if(null != 536885795)
        {
            goto label_8;
        }
        
        goto label_9;
    }

}
