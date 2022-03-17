using UnityEngine;
public class LevelProgressScriptable : ScriptableObject
{
    // Fields
    public System.Collections.Generic.List<LevelProgress> levelProgress;
    
    // Methods
    public void SetTime()
    {
        List.Enumerator<T> val_1 = GetEnumerator();
        goto label_2;
        label_4:
        mem2[0] = 40;
        label_2:
        if(MoveNext() == true)
        {
            goto label_4;
        }
        
        Dispose();
    }
    public void SetIndexLevel()
    {
        var val_1 = 0;
        goto label_1;
        label_6:
        if(true <= val_1)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + 0;
        val_1 = 1;
        mem2[0] = val_1;
        label_1:
        if(val_1 < val_1)
        {
            goto label_6;
        }
    
    }
    public LevelProgressScriptable()
    {
        536878059 = new System.Collections.Generic.List<Page>();
        this.levelProgress = 536878059;
    }

}
