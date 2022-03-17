using UnityEngine;
private sealed class WorldTimeAPI.<GetRealDateTimeFromAPI>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WorldTimeAPI <>4__this;
    private UnityEngine.Networking.UnityWebRequest <webRequest>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WorldTimeAPI.<GetRealDateTimeFromAPI>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_11;
        UnityEngine.Networking.UnityWebRequest val_12;
        var val_13;
        if((this.<>1__state) != 1)
        {
                val_11 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_11;
        }
        
            this.<>1__state = 0;
            UnityEngine.Networking.UnityWebRequest val_1 = UnityEngine.Networking.UnityWebRequest.Get(uri:  -1610600129);
            this.<webRequest>5__2 = -1610600129;
            UnityEngine.Debug.Log(message:  -1610600317);
            UnityEngine.Networking.UnityWebRequestAsyncOperation val_2 = mem[this.<webRequest>5__2].SendWebRequest();
            this.<>2__current = mem[this.<webRequest>5__2];
            val_11 = 1;
            this.<>1__state = val_11;
            return (bool)val_11;
        }
        
        val_12 = this.<webRequest>5__2;
        this.<>1__state = 0;
        if(val_12.isNetworkError == true)
        {
            goto label_8;
        }
        
        val_12 = this.<webRequest>5__2;
        if(val_12.isHttpError == false)
        {
            goto label_10;
        }
        
        label_8:
        val_11 = 0;
        string val_5 = this.<webRequest>5__2.error;
        string val_6 = -1610608397(-1610608397) + this.<webRequest>5__2(this.<webRequest>5__2);
        val_13 = -1610608397;
        goto label_14;
        label_10:
        UnityEngine.Networking.DownloadHandler val_7 = this.<webRequest>5__2.downloadHandler;
        string val_8 = this.<webRequest>5__2.text;
        TimeData val_9 = UnityEngine.JsonUtility.FromJson<TimeData>(json:  this.<webRequest>5__2);
        System.DateTime val_10 = ParseDateTime(datetime:  this.<>4__this);
        if((this.<>4__this) != 0)
        {
                this.<>4__this._currentDateTime = new System.DateTime();
            mem2[0] = ???;
        }
        else
        {
                mem[20] = ???;
            mem[16] = ???;
        }
        
        this.<>4__this.IsTimeLoaded = true;
        val_11 = 0;
        val_13 = -1610604269;
        label_14:
        UnityEngine.Debug.Log(message:  -1610604269);
        return (bool)val_11;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        22713476 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
