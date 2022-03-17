using UnityEngine;
private class AdjustAndroid.EventTrackingFailedListener : AndroidJavaProxy
{
    // Fields
    private System.Action<com.adjust.sdk.AdjustEventFailure> callback;
    
    // Methods
    public AdjustAndroid.EventTrackingFailedListener(System.Action<com.adjust.sdk.AdjustEventFailure> pCallback)
    {
        this.callback = pCallback;
    }
    public void onFinishedEventTrackingFailed(UnityEngine.AndroidJavaObject eventFailureData)
    {
        UnityEngine.AndroidJavaObject val_20;
        var val_21;
        var val_22;
        var val_23;
        UnityEngine.AndroidJavaObject val_24;
        var val_25;
        var val_26;
        UnityEngine.AndroidJavaObject val_27;
        var val_28;
        var val_29;
        UnityEngine.AndroidJavaObject val_30;
        var val_31;
        var val_32;
        UnityEngine.AndroidJavaObject val_33;
        var val_34;
        var val_35;
        var val_36;
        if(eventFailureData != 0)
        {
                true = this.callback;
        }
        
        if(true == 0)
        {
                return;
        }
        
        val_20 = 0;
        536883077 = new com.adjust.sdk.AdjustEventFailure();
        val_21 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_21 = 536883097;
        }
        
        string val_2 = eventFailureData.Get<System.String>(fieldName:  mem[536883189]);
        if((System.String.op_Equality(a:  eventFailureData, b:  -1610612735)) != true)
        {
                val_22 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_22 = 536883097;
        }
        
            string val_4 = eventFailureData.Get<System.String>(fieldName:  mem[536883189]);
            val_20 = eventFailureData;
        }
        
        mem[536883085] = val_20;
        val_23 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_23 = 536883097;
        }
        
        string val_5 = eventFailureData.Get<System.String>(fieldName:  mem[536883189] + 4);
        val_24 = 0;
        if((System.String.op_Equality(a:  eventFailureData, b:  -1610612735)) != true)
        {
                val_25 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_25 = 536883097;
        }
        
            string val_7 = eventFailureData.Get<System.String>(fieldName:  mem[536883189] + 4);
            val_24 = eventFailureData;
        }
        
        mem[536883089] = val_24;
        val_26 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_26 = 536883097;
        }
        
        mem[536883105] = eventFailureData.Get<System.Boolean>(fieldName:  mem[536883189] + 24);
        string val_9 = eventFailureData.Get<System.String>(fieldName:  mem[536883189] + 28);
        val_27 = 0;
        if((System.String.op_Equality(a:  eventFailureData, b:  -1610612735)) != true)
        {
                val_28 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_28 = 536883097;
        }
        
            string val_11 = eventFailureData.Get<System.String>(fieldName:  mem[536883189] + 28);
            val_27 = eventFailureData;
        }
        
        mem[536883093] = val_27;
        val_29 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_29 = 536883097;
        }
        
        string val_12 = eventFailureData.Get<System.String>(fieldName:  mem[536883189] + 36);
        val_30 = 0;
        if((System.String.op_Equality(a:  eventFailureData, b:  -1610612735)) != true)
        {
                val_31 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_31 = 536883097;
        }
        
            string val_14 = eventFailureData.Get<System.String>(fieldName:  mem[536883189] + 36);
            val_30 = eventFailureData;
        }
        
        mem[536883097] = val_30;
        val_32 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_32 = 536883097;
        }
        
        string val_15 = eventFailureData.Get<System.String>(fieldName:  mem[536883189] + 32);
        val_33 = 0;
        if((System.String.op_Equality(a:  eventFailureData, b:  -1610612735)) != true)
        {
                val_34 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_34 = 536883097;
        }
        
            string val_17 = eventFailureData.Get<System.String>(fieldName:  mem[536883189] + 32);
            val_33 = eventFailureData;
        }
        
        mem[536883101] = val_33;
        val_35 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_35 = 536883097;
        }
        
        string val_18 = eventFailureData.Get<System.String>(fieldName:  mem[536883189] + 52);
        val_36 = mem[mem[3221271783] + 186];
        val_36 = mem[3221271783] + 186;
        if(val_36 == 1)
        {
                val_36 = mem[mem[3221271783] + 186];
            val_36 = mem[3221271783] + 186;
        }
        
        string val_19 = eventFailureData.Call<System.String>(methodName:  -1610597737, args:  mem[3221271783] + 92);
        val_1.BuildJsonResponseFromString(jsonResponseString:  eventFailureData);
        this.callback.Invoke(obj:  536883077);
    }

}
