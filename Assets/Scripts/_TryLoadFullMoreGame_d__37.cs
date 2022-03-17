using UnityEngine;
private sealed class MoregameManager.<TryLoadFullMoreGame>d__37 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public MoregameInfor item;
    public MoregameManager <>4__this;
    private UnityEngine.WWW <w>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MoregameManager.<TryLoadFullMoreGame>d__37(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        MoregameInfor val_11;
        UnityEngine.WWW val_12;
        string val_13;
        UnityEngine.WWW val_14;
        var val_15;
        object val_16;
        System.Action<System.Boolean> val_17;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_10 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_10;
        }
        
        val_11 = this.item;
        this.<>1__state = 0;
        if(val_11 == 0)
        {
            goto label_3;
        }
        
        if(this.item.Portrait == false)
        {
            goto label_4;
        }
        
        label_17:
        val_12 = 22716548;
        val_13 = this.item.FullPortraitLink;
        goto label_5;
        label_1:
        val_14 = this.<w>5__2;
        this.<>1__state = 0;
        val_10 = 0;
        string val_1 = val_14.error;
        if(val_14 != 0)
        {
                return (bool)val_10;
        }
        
        UnityEngine.Texture2D val_2 = this.<w>5__2.texture;
        UnityEngine.Texture2D val_4 = this.<w>5__2.texture;
        this.<w>5__2.Reset();
        UnityEngine.Texture2D val_5 = 536895327;
        val_5 = new UnityEngine.Texture2D(width:  this.<w>5__2.MoveNext(), height:  this.<w>5__2, textureFormat:  3, mipChain:  false);
        val_14 = this.<w>5__2;
        val_14.LoadImageIntoTexture(texture:  536895327);
        if((this.<>4__this) == 0)
        {
            goto label_14;
        }
        
        string val_6 = this.<>4__this.GetPackage(link:  this.item.GameLink);
        goto label_15;
        label_3:
        if(this.item == 0)
        {
            goto label_16;
        }
        
        val_11 = this.item;
        if(this.item.Portrait == true)
        {
            goto label_17;
        }
        
        label_4:
        val_12 = 22716548;
        val_13 = this.item.FullLink;
        label_5:
        val_12 = new UnityEngine.WWW(url:  val_13);
        this.<w>5__2 = val_12;
        this.<>2__current = this.<w>5__2;
        val_10 = 1;
        this.<>1__state = val_10;
        return (bool)val_10;
        label_14:
        string val_7 = 0.GetPackage(link:  this.item.GameLink);
        label_15:
        this.<>4__this.featureImage = val_5;
        UnityEngine.Debug.Log(message:  -1610606241);
        val_15 = 536900057;
        if(((mem[536900244] & true) == 0) && (mem[536900173] == 0))
        {
                val_15 = 536900057;
        }
        
        val_16 = mem[536900149];
        val_17 = mem[mem[536900149] + 12];
        val_17 = mem[536900149] + 12;
        if(val_17 == 0)
        {
                if(((mem[536900244] & true) == 0) && (mem[536900173] == 0))
        {
                val_16 = mem[536900149];
        }
        
            val_17 = 536873261;
            val_17 = new System.Action<System.Boolean>(object:  val_16, method:  new IntPtr(1610676689));
            mem2[0] = val_17;
        }
        
        val_10 = 0;
        this.<>4__this.ShowMoregameFull(callBack:  536873261, forceFirstTime:  false);
        return (bool)val_10;
        label_16:
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
