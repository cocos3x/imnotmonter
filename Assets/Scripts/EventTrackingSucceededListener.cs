using UnityEngine;
private class AdjustAndroid.EventTrackingSucceededListener : AndroidJavaProxy
{
    // Fields
    private System.Action<com.adjust.sdk.AdjustEventSuccess> callback;
    
    // Methods
    public AdjustAndroid.EventTrackingSucceededListener(System.Action<com.adjust.sdk.AdjustEventSuccess> pCallback)
    {
        this.callback = pCallback;
    }
    public void onFinishedEventTrackingSucceeded(UnityEngine.AndroidJavaObject eventSuccessData)
    {
        UnityEngine.AndroidJavaObject val_19;
        var val_20;
        var val_21;
        var val_22;
        UnityEngine.AndroidJavaObject val_23;
        var val_24;
        var val_25;
        UnityEngine.AndroidJavaObject val_26;
        var val_27;
        var val_28;
        UnityEngine.AndroidJavaObject val_29;
        var val_30;
        var val_31;
        UnityEngine.AndroidJavaObject val_32;
        var val_33;
        var val_34;
        var val_35;
        if(eventSuccessData != 0)
        {
                true = this.callback;
        }
        
        if(true == 0)
        {
                return;
        }
        
        val_19 = 0;
        536883079 = new com.adjust.sdk.AdjustEventSuccess();
        val_20 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_20 = 536883097;
        }
        
        string val_2 = eventSuccessData.Get<System.String>(fieldName:  mem[536883189]);
        if((System.String.op_Equality(a:  eventSuccessData, b:  -1610612735)) != true)
        {
                val_21 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_21 = 536883097;
        }
        
            string val_4 = eventSuccessData.Get<System.String>(fieldName:  mem[536883189]);
            val_19 = eventSuccessData;
        }
        
        mem[536883087] = val_19;
        val_22 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_22 = 536883097;
        }
        
        string val_5 = eventSuccessData.Get<System.String>(fieldName:  mem[536883189] + 4);
        val_23 = 0;
        if((System.String.op_Equality(a:  eventSuccessData, b:  -1610612735)) != true)
        {
                val_24 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_24 = 536883097;
        }
        
            string val_7 = eventSuccessData.Get<System.String>(fieldName:  mem[536883189] + 4);
            val_23 = eventSuccessData;
        }
        
        mem[536883091] = val_23;
        val_25 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_25 = 536883097;
        }
        
        string val_8 = eventSuccessData.Get<System.String>(fieldName:  mem[536883189] + 28);
        val_26 = 0;
        if((System.String.op_Equality(a:  eventSuccessData, b:  -1610612735)) != true)
        {
                val_27 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_27 = 536883097;
        }
        
            string val_10 = eventSuccessData.Get<System.String>(fieldName:  mem[536883189] + 28);
            val_26 = eventSuccessData;
        }
        
        mem[536883095] = val_26;
        val_28 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_28 = 536883097;
        }
        
        string val_11 = eventSuccessData.Get<System.String>(fieldName:  mem[536883189] + 36);
        val_29 = 0;
        if((System.String.op_Equality(a:  eventSuccessData, b:  -1610612735)) != true)
        {
                val_30 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_30 = 536883097;
        }
        
            string val_13 = eventSuccessData.Get<System.String>(fieldName:  mem[536883189] + 36);
            val_29 = eventSuccessData;
        }
        
        mem[536883099] = val_29;
        val_31 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_31 = 536883097;
        }
        
        string val_14 = eventSuccessData.Get<System.String>(fieldName:  mem[536883189] + 32);
        val_32 = 0;
        if((System.String.op_Equality(a:  eventSuccessData, b:  -1610612735)) != true)
        {
                val_33 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_33 = 536883097;
        }
        
            string val_16 = eventSuccessData.Get<System.String>(fieldName:  mem[536883189] + 32);
            val_32 = eventSuccessData;
        }
        
        mem[536883103] = val_32;
        val_34 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_34 = 536883097;
        }
        
        string val_17 = eventSuccessData.Get<System.String>(fieldName:  mem[536883189] + 52);
        val_35 = mem[mem[3221271783] + 186];
        val_35 = mem[3221271783] + 186;
        if(val_35 == 1)
        {
                val_35 = mem[mem[3221271783] + 186];
            val_35 = mem[3221271783] + 186;
        }
        
        string val_18 = eventSuccessData.Call<System.String>(methodName:  -1610597737, args:  mem[3221271783] + 92);
        val_1.BuildJsonResponseFromString(jsonResponseString:  eventSuccessData);
        this.callback.Invoke(obj:  536883079);
    }

}
