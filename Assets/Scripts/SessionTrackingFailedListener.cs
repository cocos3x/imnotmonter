using UnityEngine;
private class AdjustAndroid.SessionTrackingFailedListener : AndroidJavaProxy
{
    // Fields
    private System.Action<com.adjust.sdk.AdjustSessionFailure> callback;
    
    // Methods
    public AdjustAndroid.SessionTrackingFailedListener(System.Action<com.adjust.sdk.AdjustSessionFailure> pCallback)
    {
        this.callback = pCallback;
    }
    public void onFinishedSessionTrackingFailed(UnityEngine.AndroidJavaObject sessionFailureData)
    {
        UnityEngine.AndroidJavaObject val_14;
        var val_15;
        var val_16;
        var val_17;
        UnityEngine.AndroidJavaObject val_18;
        var val_19;
        var val_20;
        UnityEngine.AndroidJavaObject val_21;
        var val_22;
        var val_23;
        var val_24;
        if(sessionFailureData != 0)
        {
                true = this.callback;
        }
        
        if(true == 0)
        {
                return;
        }
        
        val_14 = 0;
        536883091 = new com.adjust.sdk.AdjustSessionFailure();
        val_15 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_15 = 536883097;
        }
        
        string val_2 = sessionFailureData.Get<System.String>(fieldName:  mem[536883189]);
        if((System.String.op_Equality(a:  sessionFailureData, b:  -1610612735)) != true)
        {
                val_16 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_16 = 536883097;
        }
        
            string val_4 = sessionFailureData.Get<System.String>(fieldName:  mem[536883189]);
            val_14 = sessionFailureData;
        }
        
        mem[536883099] = val_14;
        val_17 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_17 = 536883097;
        }
        
        string val_5 = sessionFailureData.Get<System.String>(fieldName:  mem[536883189] + 4);
        val_18 = 0;
        if((System.String.op_Equality(a:  sessionFailureData, b:  -1610612735)) != true)
        {
                val_19 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_19 = 536883097;
        }
        
            string val_7 = sessionFailureData.Get<System.String>(fieldName:  mem[536883189] + 4);
            val_18 = sessionFailureData;
        }
        
        mem[536883103] = val_18;
        val_20 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_20 = 536883097;
        }
        
        mem[536883111] = sessionFailureData.Get<System.Boolean>(fieldName:  mem[536883189] + 24);
        string val_9 = sessionFailureData.Get<System.String>(fieldName:  mem[536883189] + 28);
        val_21 = 0;
        if((System.String.op_Equality(a:  sessionFailureData, b:  -1610612735)) != true)
        {
                val_22 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_22 = 536883097;
        }
        
            string val_11 = sessionFailureData.Get<System.String>(fieldName:  mem[536883189] + 28);
            val_21 = sessionFailureData;
        }
        
        mem[536883107] = val_21;
        val_23 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_23 = 536883097;
        }
        
        string val_12 = sessionFailureData.Get<System.String>(fieldName:  mem[536883189] + 52);
        val_24 = mem[mem[3221271783] + 186];
        val_24 = mem[3221271783] + 186;
        if(val_24 == 1)
        {
                val_24 = mem[mem[3221271783] + 186];
            val_24 = mem[3221271783] + 186;
        }
        
        string val_13 = sessionFailureData.Call<System.String>(methodName:  -1610597737, args:  mem[3221271783] + 92);
        val_1.BuildJsonResponseFromString(jsonResponseString:  sessionFailureData);
        this.callback.Invoke(obj:  536883091);
    }

}
