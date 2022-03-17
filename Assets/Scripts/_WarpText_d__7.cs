using UnityEngine;
private sealed class SkewTextExample.<WarpText>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TMPro.Examples.SkewTextExample <>4__this;
    private float <old_CurveScale>5__2;
    private float <old_ShearValue>5__3;
    private UnityEngine.AnimationCurve <old_curve>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SkewTextExample.<WarpText>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) != 1)
        {
            goto label_0;
        }
        
        this.<>1__state = 0;
        label_7:
        if((this.<>4__this.m_TextComponent.m_havePropertiesChanged) == false)
        {
            goto label_3;
        }
        
        label_17:
        this.<old_CurveScale>5__2 = this.<>4__this.CurveScale;
        UnityEngine.AnimationCurve val_1 = this.<>4__this.CopyAnimationCurve(curve:  this.<>4__this.VertexCurve);
        this.<old_curve>5__4 = this.<>4__this;
        this.<old_ShearValue>5__3 = this.<>4__this.ShearAmount;
        if((this.<>4__this.m_TextComponent.m_textInfo.characterCount) == 0)
        {
            goto label_7;
        }
        
        goto label_8;
        label_3:
        if((this.<>4__this.m_TextComponent.m_havePropertiesChanged) == true)
        {
            goto label_17;
        }
        
        UnityEngine.Keyframe[] val_2 = mem[this.<old_curve>5__4].keys;
        float val_4 = (mem[this.<old_curve>5__4]) + 44.value;
        UnityEngine.Keyframe[] val_5 = this.<>4__this + 16.keys;
        float val_7 = (this.<>4__this + 16) + 44.value;
        if(((this.<>4__this + 16 + 12) != 1) || ((this.<>4__this + 16 + 12) != 1))
        {
            goto label_17;
        }
        
        this.<>2__current = 0;
        goto label_18;
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
