using UnityEngine;
private sealed class ProCamera2DContentFitter.<Start>d__34 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DContentFitter <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DContentFitter.<Start>d__34(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        int val_6;
        val_5 = this;
        val_6 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
            this.<>1__state = 0;
            if((this.<>4__this._useLetterOrPillarboxing) != false)
        {
                this.<>4__this.CreateLetterPillarboxingCamera();
        }
        
            this.<>2__current = 0;
            val_6 = 1;
            this.<>1__state = val_6;
            return (bool)val_6;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this._contentFitterMode) != 0)
        {
                return (bool)val_6;
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.<>4__this.ProCamera2D;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.<>4__this.ProCamera2D;
        val_6 = 0;
        float val_3 = R7.aspect;
        float val_5 = 0.5f;
        float val_4 = (this.<>4__this._targetWidth) * val_5;
        val_5 = (this.<>4__this._targetHeight) * val_5;
        val_4 = val_4 / R7;
        if(mem[536892213] > 0)
        {
                0 = 1;
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DContentFitter.UpdateCameraAlignment(cam:  1009075280, isPillarbox:  true, targetAspectRatio:  val_5, horizontalAlignment:  null, verticalAlignment:  val_4);
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
