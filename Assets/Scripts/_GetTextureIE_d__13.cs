using UnityEngine;
private sealed class MoregameItemUi.<GetTextureIE>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public MoregameItemUi <>4__this;
    private UnityEngine.WWW <w>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MoregameItemUi.<GetTextureIE>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        UnityEngine.WWW val_9;
        if((this.<>1__state) != 1)
        {
                val_8 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_8;
        }
        
            this.<>1__state = 0;
            UnityEngine.WWW val_1 = 536896821;
            val_1 = new UnityEngine.WWW(url:  this.<>4__this.Infor.IconLink);
            this.<w>5__2 = val_1;
            mem[1152921509391435452] = this.<w>5__2;
            val_8 = 1;
            this.<>1__state = val_8;
            return (bool)val_8;
        }
        
        val_9 = this.<w>5__2;
        this.<>1__state = 0;
        val_8 = 0;
        string val_2 = val_9.error;
        if(val_9 != 0)
        {
                return (bool)val_8;
        }
        
        UnityEngine.Texture2D val_3 = this.<w>5__2.texture;
        UnityEngine.Texture2D val_5 = this.<w>5__2.texture;
        this.<w>5__2.Reset();
        val_9 = this.<w>5__2;
        536895327 = new UnityEngine.Texture2D(width:  this.<w>5__2.MoveNext(), height:  val_9, textureFormat:  3, mipChain:  false);
        this.<w>5__2.LoadImageIntoTexture(texture:  536895327);
        string val_7 = this.<>4__this.GetPackage(link:  this.<>4__this.Infor.GameLink);
        this.<>4__this.IconView.texture = 536895327;
        val_8 = 0;
        this.<>4__this.IconView.enabled = true;
        return (bool)val_8;
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
