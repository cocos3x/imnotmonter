using UnityEngine;
private sealed class TextConsoleSimulator.<RevealCharacters>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TMPro.TMP_Text textComponent;
    public TMPro.Examples.TextConsoleSimulator <>4__this;
    private TMPro.TMP_TextInfo <textInfo>5__2;
    private int <totalVisibleCharacters>5__3;
    private int <visibleCount>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TextConsoleSimulator.<RevealCharacters>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        TMPro.Examples.TextConsoleSimulator val_2;
        var val_3;
        int val_4;
        int val_5;
        val_2 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_3 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
        this.<>1__state = 0;
        this.<textInfo>5__2 = this.textComponent.m_textInfo;
        this.<totalVisibleCharacters>5__3 = this.textComponent.m_textInfo.characterCount;
        this.<visibleCount>5__4 = 0;
        goto label_7;
        label_1:
        this.<>1__state = 0;
        label_7:
        if((this.<>4__this.hasTextChanged) != false)
        {
                this.<totalVisibleCharacters>5__3 = this.<textInfo>5__2.characterCount;
            this.<>4__this.hasTextChanged = false;
        }
        
        val_4 = this.<visibleCount>5__4;
        if(val_4 <= (this.<totalVisibleCharacters>5__3))
        {
            goto label_11;
        }
        
        UnityEngine.WaitForSeconds val_1 = 536896849;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_1;
        val_5 = 1;
        goto label_12;
        label_2:
        val_4 = 0;
        this.<visibleCount>5__4 = val_4;
        this.<>1__state = 0;
        label_11:
        val_2 = this.textComponent;
        val_2.maxVisibleCharacters = 0;
        this.<>2__current = 0;
        this.<visibleCount>5__4 = 1;
        val_5 = 2;
        label_12:
        this.<>1__state = val_5;
        val_3 = 1;
        return (bool)val_3;
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
