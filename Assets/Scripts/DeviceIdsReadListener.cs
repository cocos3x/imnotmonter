using UnityEngine;
private class AdjustAndroid.DeviceIdsReadListener : AndroidJavaProxy
{
    // Fields
    private System.Action<string> onPlayAdIdReadCallback;
    
    // Methods
    public AdjustAndroid.DeviceIdsReadListener(System.Action<string> pCallback)
    {
        this.onPlayAdIdReadCallback = pCallback;
    }
    public void onGoogleAdIdRead(string playAdId)
    {
        if(this.onPlayAdIdReadCallback == 0)
        {
                return;
        }
        
        this.onPlayAdIdReadCallback.Invoke(obj:  playAdId);
    }
    public void onGoogleAdIdRead(UnityEngine.AndroidJavaObject ajoAdId)
    {
        var val_2;
        if(ajoAdId != 0)
        {
                val_2 = mem[mem[3221271783] + 186];
            val_2 = mem[3221271783] + 186;
            if(val_2 == 1)
        {
                val_2 = mem[mem[3221271783] + 186];
            val_2 = mem[3221271783] + 186;
        }
        
            string val_1 = ajoAdId.Call<System.String>(methodName:  -1610597737, args:  mem[3221271783] + 92);
            this.onGoogleAdIdRead(playAdId:  ajoAdId);
            return;
        }
        
        this.onGoogleAdIdRead(playAdId:  null);
    }

}
