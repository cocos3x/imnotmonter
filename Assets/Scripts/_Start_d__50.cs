using UnityEngine;
private sealed class ProCamera2DPanAndZoom.<Start>d__50 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DPanAndZoom <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DPanAndZoom.<Start>d__50(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        int val_7;
        val_6 = this;
        val_7 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
            this.<>1__state = 0;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.<>4__this.ProCamera2D;
            float val_6 = 0.5f;
            val_6 = (this.<>4__this.MaxZoomOutAmount) * val_6;
            this.<>4__this._initialCamSize = val_6;
            this.<>2__current = 0;
            val_7 = 1;
            this.<>1__state = val_7;
            return (bool)val_7;
        }
        
        this.<>1__state = 0;
        val_7 = 0;
        UnityEngine.GameObject val_2 = this.<>4__this.gameObject;
        val_6 = this.<>4__this;
        UnityEngine.SceneManagement.Scene val_3 = val_6.scene;
        if(val_3.m_Handle.buildIndex != 1)
        {
                return (bool)val_7;
        }
        
        val_7 = 0;
        UnityEngine.GameObject val_5 = this.<>4__this._panTarget.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.<>4__this._panTarget);
        return (bool)val_7;
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
