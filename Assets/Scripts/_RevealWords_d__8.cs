using UnityEngine;
private sealed class TextConsoleSimulator.<RevealWords>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TMPro.TMP_Text textComponent;
    private int <totalWordCount>5__2;
    private int <totalVisibleCharacters>5__3;
    private int <counter>5__4;
    private int <visibleCount>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TextConsoleSimulator.<RevealWords>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        int val_5;
        int val_6;
        int val_7;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_4 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
        this.<>1__state = 0;
        val_5 = this;
        this.<totalWordCount>5__2 = this.textComponent.m_textInfo.wordCount;
        this.<totalVisibleCharacters>5__3 = this.textComponent.m_textInfo.characterCount;
        this.<counter>5__4 = 0;
        this.<visibleCount>5__5 = 0;
        goto label_9;
        label_1:
        val_5 = this.<totalWordCount>5__2;
        this.<>1__state = 0;
        label_9:
        int val_1 = val_5 + 1;
        if(val_1 == 0)
        {
            goto label_10;
        }
        
        var val_4 = val_1;
        if(val_1 >= val_5)
        {
            goto label_11;
        }
        
        val_4 = val_4 - 1;
        TMPro.TMP_WordInfo val_5 = this.textComponent.m_textInfo.wordInfo[val_4 << 4];
        goto label_18;
        label_2:
        this.<>1__state = 0;
        goto label_17;
        label_10:
        val_6 = 0;
        goto label_18;
        label_11:
        if(val_1 != val_5)
        {
            goto label_23;
        }
        
        val_6 = this.<totalVisibleCharacters>5__3;
        label_18:
        this.<visibleCount>5__5 = val_6;
        label_23:
        this.textComponent.maxVisibleCharacters = val_6;
        if((this.<visibleCount>5__5) >= (this.<totalVisibleCharacters>5__3))
        {
            goto label_21;
        }
        
        label_17:
        int val_6 = this.<counter>5__4;
        val_6 = val_6 + 1;
        this.<counter>5__4 = val_6;
        UnityEngine.WaitForSeconds val_2 = 536896849;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_2;
        val_7 = 2;
        goto label_22;
        label_21:
        UnityEngine.WaitForSeconds val_3 = 536896849;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_3;
        val_7 = 1;
        label_22:
        this.<>1__state = val_7;
        val_4 = 1;
        return (bool)val_4;
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
