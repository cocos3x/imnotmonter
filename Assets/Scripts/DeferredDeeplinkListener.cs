using UnityEngine;
private class AdjustAndroid.DeferredDeeplinkListener : AndroidJavaProxy
{
    // Fields
    private System.Action<string> callback;
    
    // Methods
    public AdjustAndroid.DeferredDeeplinkListener(System.Action<string> pCallback)
    {
        this.callback = pCallback;
    }
    public bool launchReceivedDeeplink(UnityEngine.AndroidJavaObject deeplink)
    {
        System.Object[] val_2;
        var val_3;
        val_2 = 23000303;
        if(this.callback != 0)
        {
                val_3 = mem[mem[3221271783] + 186];
            val_3 = mem[3221271783] + 186;
            if(val_3 == 1)
        {
                val_3 = mem[mem[3221271783] + 186];
            val_3 = mem[3221271783] + 186;
        }
        
            val_2 = mem[mem[3221271783] + 92];
            val_2 = mem[3221271783] + 92;
            string val_1 = deeplink.Call<System.String>(methodName:  -1610597737, args:  val_2);
            this.callback.Invoke(obj:  deeplink);
        }
        
        if((mem[536883242] & true) != 0)
        {
                return (bool)mem[536883147];
        }
        
        if(mem[536883171] != 0)
        {
                return (bool)mem[536883147];
        }
        
        return (bool)mem[536883147];
    }

}
