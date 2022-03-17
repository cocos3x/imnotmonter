using UnityEngine;
private sealed class ProCamera2DContentFitter.<UpdateFixedAspectRatio>d__42 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DContentFitter <>4__this;
    private bool <isPillarbox>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DContentFitter.<UpdateFixedAspectRatio>d__42(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        float val_7;
        var val_8;
        float val_9;
        float val_10;
        bool val_11;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_6 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        val_7 = this.<>4__this._targetHeight;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.<>4__this.ProCamera2D;
        if((this.<>4__this) == 0)
        {
            goto label_7;
        }
        
        val_9 = this.<>4__this._targetAspectRatio;
        val_10 = this.<>4__this.HorizontalAlignment;
        goto label_8;
        label_3:
        val_7 = 8.407791E-45f;
        label_4:
        float val_6 = this.<>4__this._targetWidth;
        val_6 = val_6 * 0.5f;
        float val_2 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2DContentFitter.ScreenAspectRatio;
        uint val_7 = 0;
        val_7 = val_6 / val_7;
        if(mem[536892213] > 0)
        {
                val_8 = 1;
        }
        
        this.<isPillarbox>5__2 = true;
        val_11 = this.<>4__this._useLetterOrPillarboxing;
        if(val_11 == true)
        {
                val_11 = 1;
        }
        
        if((this.<>4__this._prevUseLetterOrPillarboxing) == true)
        {
                this.<>4__this._prevUseLetterOrPillarboxing = 1;
        }
        
        if(1 != 1)
        {
                if(val_11 == true)
        {
                val_11 = 1;
        }
        
            this.<>4__this.ToggleLetterPillarboxing(value:  true);
            val_11 = this.<>4__this._useLetterOrPillarboxing;
        }
        
        if(val_11 != false)
        {
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = this.<>4__this.ProCamera2D;
            if((this.<isPillarbox>5__2) == true)
        {
                this.<isPillarbox>5__2 = 1;
        }
        
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DContentFitter.UpdateLetterPillarbox(cam:  this.<>4__this, isPillarbox:  true, targetAspectRatio:  val_7, horizontalAlignment:  null, verticalAlignment:  val_7 * 0.5f);
        }
        
        UnityEngine.WaitForEndOfFrame val_5 = 536896839;
        val_5 = new UnityEngine.WaitForEndOfFrame();
        this.<>2__current = val_5;
        val_6 = 1;
        this.<>1__state = val_6;
        return (bool)val_6;
        label_7:
        val_9 = 7.286752E-44f;
        val_10 = 3.587324E-43f;
        label_8:
        if((this.<isPillarbox>5__2) == true)
        {
                this.<isPillarbox>5__2 = 1;
        }
        
        val_6 = 0;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DContentFitter.UpdateCameraAlignment(cam:  this.<>4__this, isPillarbox:  true, targetAspectRatio:  null, horizontalAlignment:  null, verticalAlignment:  null);
        return (bool)val_6;
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
