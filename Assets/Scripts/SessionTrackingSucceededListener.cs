using UnityEngine;
private class AdjustAndroid.SessionTrackingSucceededListener : AndroidJavaProxy
{
    // Fields
    private System.Action<com.adjust.sdk.AdjustSessionSuccess> callback;
    
    // Methods
    public AdjustAndroid.SessionTrackingSucceededListener(System.Action<com.adjust.sdk.AdjustSessionSuccess> pCallback)
    {
        this.callback = pCallback;
    }
    public void onFinishedSessionTrackingSucceeded(UnityEngine.AndroidJavaObject sessionSuccessData)
    {
        UnityEngine.AndroidJavaObject val_13;
        var val_14;
        var val_15;
        var val_16;
        UnityEngine.AndroidJavaObject val_17;
        var val_18;
        var val_19;
        UnityEngine.AndroidJavaObject val_20;
        var val_21;
        var val_22;
        var val_23;
        if(sessionSuccessData != 0)
        {
                true = this.callback;
        }
        
        if(true == 0)
        {
                return;
        }
        
        val_13 = 0;
        536883093 = new com.adjust.sdk.AdjustSessionSuccess();
        val_14 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_14 = 536883097;
        }
        
        string val_2 = sessionSuccessData.Get<System.String>(fieldName:  mem[536883189]);
        if((System.String.op_Equality(a:  sessionSuccessData, b:  -1610612735)) != true)
        {
                val_15 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_15 = 536883097;
        }
        
            string val_4 = sessionSuccessData.Get<System.String>(fieldName:  mem[536883189]);
            val_13 = sessionSuccessData;
        }
        
        mem[536883101] = val_13;
        val_16 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_16 = 536883097;
        }
        
        string val_5 = sessionSuccessData.Get<System.String>(fieldName:  mem[536883189] + 4);
        val_17 = 0;
        if((System.String.op_Equality(a:  sessionSuccessData, b:  -1610612735)) != true)
        {
                val_18 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_18 = 536883097;
        }
        
            string val_7 = sessionSuccessData.Get<System.String>(fieldName:  mem[536883189] + 4);
            val_17 = sessionSuccessData;
        }
        
        mem[536883105] = val_17;
        val_19 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_19 = 536883097;
        }
        
        string val_8 = sessionSuccessData.Get<System.String>(fieldName:  mem[536883189] + 28);
        val_20 = 0;
        if((System.String.op_Equality(a:  sessionSuccessData, b:  -1610612735)) != true)
        {
                val_21 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_21 = 536883097;
        }
        
            string val_10 = sessionSuccessData.Get<System.String>(fieldName:  mem[536883189] + 28);
            val_20 = sessionSuccessData;
        }
        
        mem[536883109] = val_20;
        val_22 = 536883097;
        if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
        {
                val_22 = 536883097;
        }
        
        string val_11 = sessionSuccessData.Get<System.String>(fieldName:  mem[536883189] + 52);
        val_23 = mem[mem[3221271783] + 186];
        val_23 = mem[3221271783] + 186;
        if(val_23 == 1)
        {
                val_23 = mem[mem[3221271783] + 186];
            val_23 = mem[3221271783] + 186;
        }
        
        string val_12 = sessionSuccessData.Call<System.String>(methodName:  -1610597737, args:  mem[3221271783] + 92);
        val_1.BuildJsonResponseFromString(jsonResponseString:  sessionSuccessData);
        this.callback.Invoke(obj:  536883093);
    }

}
