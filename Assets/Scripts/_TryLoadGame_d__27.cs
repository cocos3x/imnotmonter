using UnityEngine;
private sealed class MoregameManager.<TryLoadGame>d__27 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public MoregameItemUi item;
    public MoregameManager <>4__this;
    private UnityEngine.WWW <w>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MoregameManager.<TryLoadGame>d__27(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        UnityEngine.WWW val_11;
        var val_12;
        if((this.<>1__state) != 1)
        {
                val_10 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_10;
        }
        
            this.<>1__state = 0;
            UnityEngine.WWW val_1 = 536896821;
            val_11 = val_1;
            val_1 = new UnityEngine.WWW(url:  this.item.Infor.IconLink);
            this.<w>5__2 = val_11;
            mem[1152921509394556348] = this.<w>5__2;
            val_10 = 1;
            this.<>1__state = val_10;
            return (bool)val_10;
        }
        
        val_11 = this.<w>5__2;
        this.<>1__state = 0;
        string val_2 = val_11.error;
        if(val_11 != 0)
        {
                val_10 = false;
            this.item.IsLoading = val_10;
            return (bool)val_10;
        }
        
        UnityEngine.Texture2D val_3 = this.<w>5__2.texture;
        UnityEngine.Texture2D val_5 = this.<w>5__2.texture;
        this.<w>5__2.Reset();
        UnityEngine.Texture2D val_6 = 536895327;
        val_11 = val_6;
        val_6 = new UnityEngine.Texture2D(width:  this.<w>5__2.MoveNext(), height:  this.<w>5__2, textureFormat:  3, mipChain:  false);
        this.<w>5__2.LoadImageIntoTexture(texture:  536895327);
        if((this.<>4__this) != 0)
        {
                string val_7 = this.<>4__this.GetPackage(link:  this.item.Infor.GameLink);
            val_12 = this.<>4__this;
        }
        else
        {
                string val_8 = 0.GetPackage(link:  this.item.Infor.GameLink);
            val_12 = 0;
        }
        
        if((this.<>4__this.MoregameLoaded.ContainsKey(key:  null)) != true)
        {
                this.<>4__this.MoregameLoaded.Add(key:  null, value:  536895327);
        }
        
        val_10 = 0;
        this.item.ApplyMoregameInfor(texture:  536895327, gameName:  this.item.Infor.GameName);
        return (bool)val_10;
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
