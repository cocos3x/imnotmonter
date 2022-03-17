using UnityEngine;
private class AdjustAndroid.AttributionChangeListener : AndroidJavaProxy
{
    // Fields
    private System.Action<com.adjust.sdk.AdjustAttribution> callback;
    
    // Methods
    public AdjustAndroid.AttributionChangeListener(System.Action<com.adjust.sdk.AdjustAttribution> pCallback)
    {
        this.callback = pCallback;
    }
    public void onAttributionChanged(UnityEngine.AndroidJavaObject attribution)
    {
        AdjustAndroid.AttributionChangeListener val_36;
        var val_37;
        UnityEngine.AndroidJavaObject val_38;
        var val_39;
        var val_40;
        UnityEngine.AndroidJavaObject val_41;
        var val_42;
        var val_43;
        UnityEngine.AndroidJavaObject val_44;
        var val_45;
        var val_46;
        UnityEngine.AndroidJavaObject val_47;
        var val_48;
        var val_49;
        UnityEngine.AndroidJavaObject val_50;
        var val_51;
        var val_52;
        UnityEngine.AndroidJavaObject val_53;
        var val_54;
        var val_55;
        UnityEngine.AndroidJavaObject val_56;
        var val_57;
        var val_58;
        UnityEngine.AndroidJavaObject val_59;
        var val_60;
        var val_61;
        UnityEngine.AndroidJavaObject val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        UnityEngine.AndroidJavaObject val_68;
        var val_69;
        val_36 = this;
        if(this.callback == 0)
        {
                return;
        }
        
        com.adjust.sdk.AdjustAttribution val_1 = 536883059;
        val_1 = new com.adjust.sdk.AdjustAttribution();
        val_37 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_37 = 536883097;
        }
        
        string val_2 = attribution.Get<System.String>(fieldName:  mem[536883189] + 44);
        val_38 = 0;
        if((System.String.op_Equality(a:  attribution, b:  -1610612735)) != true)
        {
                val_39 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_39 = 536883097;
        }
        
            string val_4 = attribution.Get<System.String>(fieldName:  mem[536883189] + 44);
            val_38 = attribution;
        }
        
        mem[536883091] = val_38;
        val_40 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_40 = 536883097;
        }
        
        string val_5 = attribution.Get<System.String>(fieldName:  mem[536883189] + 48);
        val_41 = 0;
        if((System.String.op_Equality(a:  attribution, b:  -1610612735)) != true)
        {
                val_42 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_42 = 536883097;
        }
        
            string val_7 = attribution.Get<System.String>(fieldName:  mem[536883189] + 48);
            val_41 = attribution;
        }
        
        mem[536883095] = val_41;
        val_43 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_43 = 536883097;
        }
        
        string val_8 = attribution.Get<System.String>(fieldName:  mem[536883189] + 8);
        val_44 = 0;
        if((System.String.op_Equality(a:  attribution, b:  -1610612735)) != true)
        {
                val_45 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_45 = 536883097;
        }
        
            string val_10 = attribution.Get<System.String>(fieldName:  mem[536883189] + 8);
            val_44 = attribution;
        }
        
        mem[536883071] = val_44;
        val_46 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_46 = 536883097;
        }
        
        string val_11 = attribution.Get<System.String>(fieldName:  mem[536883189] + 16);
        val_47 = 0;
        if((System.String.op_Equality(a:  attribution, b:  -1610612735)) != true)
        {
                val_48 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_48 = 536883097;
        }
        
            string val_13 = attribution.Get<System.String>(fieldName:  mem[536883189] + 16);
            val_47 = attribution;
        }
        
        mem[536883079] = val_47;
        val_49 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_49 = 536883097;
        }
        
        string val_14 = attribution.Get<System.String>(fieldName:  mem[536883189] + 12);
        val_50 = 0;
        if((System.String.op_Equality(a:  attribution, b:  -1610612735)) != true)
        {
                val_51 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_51 = 536883097;
        }
        
            string val_16 = attribution.Get<System.String>(fieldName:  mem[536883189] + 12);
            val_50 = attribution;
        }
        
        mem[536883075] = val_50;
        val_52 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_52 = 536883097;
        }
        
        string val_17 = attribution.Get<System.String>(fieldName:  mem[536883189] + 20);
        val_53 = 0;
        if((System.String.op_Equality(a:  attribution, b:  -1610612735)) != true)
        {
                val_54 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_54 = 536883097;
        }
        
            string val_19 = attribution.Get<System.String>(fieldName:  mem[536883189] + 20);
            val_53 = attribution;
        }
        
        mem[536883083] = val_53;
        val_55 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_55 = 536883097;
        }
        
        string val_20 = attribution.Get<System.String>(fieldName:  mem[536883189] + 40);
        val_56 = 0;
        if((System.String.op_Equality(a:  attribution, b:  -1610612735)) != true)
        {
                val_57 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_57 = 536883097;
        }
        
            string val_22 = attribution.Get<System.String>(fieldName:  mem[536883189] + 40);
            val_56 = attribution;
        }
        
        mem[536883087] = val_56;
        val_58 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_58 = 536883097;
        }
        
        string val_23 = attribution.Get<System.String>(fieldName:  mem[536883189]);
        val_59 = 0;
        if((System.String.op_Equality(a:  attribution, b:  -1610612735)) != true)
        {
                val_60 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_60 = 536883097;
        }
        
            string val_25 = attribution.Get<System.String>(fieldName:  mem[536883189]);
            val_59 = attribution;
        }
        
        mem[536883067] = val_59;
        val_61 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_61 = 536883097;
        }
        
        string val_26 = attribution.Get<System.String>(fieldName:  mem[536883189] + 56);
        val_62 = 0;
        if((System.String.op_Equality(a:  attribution, b:  -1610612735)) != true)
        {
                val_63 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_63 = 536883097;
        }
        
            string val_28 = attribution.Get<System.String>(fieldName:  mem[536883189] + 56);
            val_62 = attribution;
        }
        
        mem[536883099] = val_62;
        val_64 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_64 = 536883097;
        }
        
        string val_29 = attribution.Get<System.String>(fieldName:  mem[536883189] + 60);
        if(attribution == 0)
        {
            goto label_73;
        }
        
        val_65 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_65 = 536883097;
        }
        
        string val_30 = attribution.Get<System.String>(fieldName:  mem[536883189] + 60);
        if(attribution == 0)
        {
            goto label_73;
        }
        
        val_66 = mem[mem[3221271783] + 186];
        val_66 = mem[3221271783] + 186;
        if(val_66 == 1)
        {
                val_66 = mem[mem[3221271783] + 186];
            val_66 = mem[3221271783] + 186;
        }
        
        System.Nullable<System.Double> val_32 = new System.Nullable<System.Double>(value:  attribution.Call<System.Double>(methodName:  -1610600787, args:  mem[3221271783] + 92));
        val_36 = val_36;
        var val_33 = val_1 + 48;
        goto label_80;
        label_73:
        var val_34 = val_1 + 48;
        label_80:
        val_67 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_67 = 536883097;
        }
        
        string val_35 = attribution.Get<System.String>(fieldName:  mem[536883189] + 64);
        val_68 = 0;
        if((System.String.op_Equality(a:  attribution, b:  -1610612735)) != true)
        {
                val_69 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_69 = 536883097;
        }
        
            string val_37 = attribution.Get<System.String>(fieldName:  mem[536883189] + 64);
            val_68 = attribution;
        }
        
        mem[536883123] = val_68;
        this.callback.Invoke(obj:  536883059);
    }

}
