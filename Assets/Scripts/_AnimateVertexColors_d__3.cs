using UnityEngine;
private sealed class VertexColorCycler.<AnimateVertexColors>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TMPro.Examples.VertexColorCycler <>4__this;
    private TMPro.TMP_TextInfo <textInfo>5__2;
    private int <currentCharacter>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VertexColorCycler.<AnimateVertexColors>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        TMPro.TMP_CharacterInfo[] val_9;
        int val_10;
        int val_11;
        val_8 = 0;
        if((this.<>1__state) != 1)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        label_30:
        if((this.<textInfo>5__2.characterCount) == 0)
        {
            goto label_3;
        }
        
        TMPro.TMP_MeshInfo val_14 = this.<textInfo>5__2.meshInfo[(0 + 0) << 3];
        val_9 = this.<textInfo>5__2.characterInfo;
        val_10 = this.<currentCharacter>5__3;
        if(0 != 0)
        {
                UnityEngine.Color32 val_5 = new UnityEngine.Color32(r:  (int)(UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  255)) & 255, g:  (int)(UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  255)) & 255, b:  (int)(UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  255)) & 255, a:  255);
            mem2[0] = val_5.r;
            TMPro.TMP_MeshInfo val_7 = val_14 + ((0f + 1) << 2);
            tangents = val_5.r;
            TMPro.TMP_MeshInfo val_9 = val_14 + ((0f + 2) << 2);
            val_9 = 0f + 3;
            tangents = val_5.r;
            TMPro.TMP_MeshInfo val_10 = val_14 + (val_9 << 2);
            tangents = val_5.r;
            val_10 = this.<>4__this.m_TextComponent;
        }
        
        int val_15 = this.<currentCharacter>5__3;
        val_15 = val_15 + 1;
        this.<currentCharacter>5__3 = this.<textInfo>5__2.characterCount;
        UnityEngine.WaitForSeconds val_11 = 536896849;
        val_11 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_11;
        val_11 = 2;
        goto label_24;
        label_1:
        if((this.<>1__state) != 0)
        {
                return (bool)val_8;
        }
        
        this.<>1__state = 0;
        this.<textInfo>5__2 = this.<>4__this.m_TextComponent.m_textInfo;
        this.<currentCharacter>5__3 = 0;
        UnityEngine.Color32 val_12 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
        goto label_30;
        label_3:
        UnityEngine.WaitForSeconds val_13 = 536896849;
        val_13 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_13;
        val_11 = 1;
        label_24:
        this.<>1__state = val_11;
        val_8 = 1;
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
