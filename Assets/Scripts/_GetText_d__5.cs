using UnityEngine;
private sealed class OpenStore.<GetText>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public OpenStore <>4__this;
    private UnityEngine.Networking.UnityWebRequest <www>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public OpenStore.<GetText>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        var val_10;
        var val_11;
        UnityEngine.GameObject val_12;
        if((this.<>1__state) != 1)
        {
                val_9 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_9;
        }
        
            this.<>1__state = 0;
            UnityEngine.Networking.UnityWebRequest val_1 = UnityEngine.Networking.UnityWebRequest.Get(uri:  this.<>4__this.url);
            this.<www>5__2 = this.<>4__this.url;
            UnityEngine.Networking.UnityWebRequestAsyncOperation val_2 = this.<www>5__2.SendWebRequest();
            this.<>2__current = this.<www>5__2;
            val_9 = 1;
            this.<>1__state = val_9;
            return (bool)val_9;
        }
        
        this.<>1__state = 0;
        if((this.<www>5__2.isNetworkError) != true)
        {
                if((this.<www>5__2.isHttpError) == false)
        {
            goto label_9;
        }
        
        }
        
        val_9 = 0;
        string val_5 = this.<www>5__2.error;
        UnityEngine.Debug.Log(message:  this.<www>5__2);
        return (bool)val_9;
        label_9:
        UnityEngine.Networking.DownloadHandler val_6 = this.<www>5__2.downloadHandler;
        string val_7 = this.<www>5__2.text;
        LoadGameDictionary val_8 = UnityEngine.JsonUtility.FromJson<LoadGameDictionary>(json:  this.<www>5__2);
        if((this.<>4__this) != 0)
        {
                val_10 = this.<>4__this;
            this.<>4__this.data = this.<www>5__2;
            val_11 = this.<>4__this + 24 + -8;
        }
        else
        {
                val_10 = 24;
            mem[24] = this.<www>5__2;
            val_11 = 2621443;
        }
        
        if((this.<www>5__2 + 16) != 0)
        {
                this.<www>5__2 + 16 = 1;
        }
        
        val_11.SetActive(value:  true);
        if((this.<>4__this) != 0)
        {
                val_12 = this.<>4__this.iosButton;
        }
        else
        {
                val_12 = 1;
        }
        
        if((this.<www>5__2 + 17) != 0)
        {
                this.<www>5__2 + 17 = 1;
        }
        
        val_9 = 0;
        val_12.SetActive(value:  true);
        return (bool)val_9;
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
