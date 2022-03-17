using UnityEngine;
private sealed class StoryPopup.<Start>d__2 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public StoryPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public StoryPopup.<Start>d__2(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_6 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
        this.<>1__state = 0;
        536896275 = new UnityEngine.Events.UnityAction(object:  this.<>4__this, method:  new IntPtr(1610682307));
        this.<>4__this.btn_Skip.m_OnClick.AddListener(call:  536896275);
        UnityEngine.GameObject val_2 = this.<>4__this.btn_Skip.gameObject;
        this.<>4__this.btn_Skip.SetActive(value:  false);
        UnityEngine.WaitForSeconds val_3 = 536896849;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_3;
        val_6 = 1;
        this.<>1__state = val_6;
        return (bool)val_6;
        label_1:
        this.<>1__state = 0;
        val_6 = 0;
        UnityEngine.GameObject val_4 = this.<>4__this.btn_Skip.gameObject;
        this.<>4__this.btn_Skip.SetActive(value:  true);
        return (bool)val_6;
        label_2:
        this.<>1__state = 0;
        this.<>4__this.PlayAnimStory();
        UnityEngine.WaitForSeconds val_5 = 536896849;
        val_5 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_5;
        val_6 = 1;
        this.<>1__state = 2;
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
