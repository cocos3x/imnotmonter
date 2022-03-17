using UnityEngine;
private sealed class WarpTextExample.<WarpText>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TMPro.Examples.WarpTextExample <>4__this;
    private float <old_CurveScale>5__2;
    private UnityEngine.AnimationCurve <old_curve>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WarpTextExample.<WarpText>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_9;
        if((this.<>1__state) != 1)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        label_16:
        if(((this.<>4__this.m_TextComponent.m_havePropertiesChanged) == true) || ((this.<>4__this.m_TextComponent.m_havePropertiesChanged) == true))
        {
            goto label_5;
        }
        
        UnityEngine.Keyframe[] val_1 = mem[this.<old_curve>5__3].keys;
        float val_3 = (mem[this.<old_curve>5__3]) + 44.value;
        UnityEngine.AnimationCurve val_13 = this.<>4__this.VertexCurve;
        UnityEngine.Keyframe[] val_4 = val_13.keys;
        val_13 = val_13 + 44;
        float val_5 = val_13.value;
        if(val_13 == 1)
        {
            goto label_12;
        }
        
        label_5:
        this.<old_CurveScale>5__2 = this.<>4__this.CurveScale;
        UnityEngine.AnimationCurve val_6 = this.<>4__this.CopyAnimationCurve(curve:  this.<>4__this.VertexCurve);
        this.<old_curve>5__3 = this.<>4__this;
        if((this.<>4__this.m_TextComponent.m_textInfo.characterCount) == 0)
        {
            goto label_16;
        }
        
        UnityEngine.Bounds val_7 = bounds;
        UnityEngine.Vector3 val_8 = min;
        UnityEngine.Bounds val_10 = bounds;
        UnityEngine.Vector3 val_11 = max;
        if((this.<>4__this.m_TextComponent.m_textInfo.characterCount) >= 1)
        {
                float val_12 = val_9 - val_9;
        }
    
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
