using UnityEngine;
private sealed class LevelBossManager.<DelayMoveCamera>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LevelBossManager <>4__this;
    public int indexMap;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelBossManager.<DelayMoveCamera>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_10;
        float val_11;
        float val_12;
        LevelBossManager val_15;
        int val_16;
        PlayerController val_17;
        DG.Tweening.TweenCallback val_18;
        var val_19;
        object val_20;
        System.Action val_21;
        val_15 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_16 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_16;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = 536896849;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_1;
        val_16 = 1;
        this.<>1__state = val_16;
        return (bool)val_16;
        label_1:
        this.<>1__state = 0;
        if(val_15 == 0)
        {
            goto label_5;
        }
        
        this.<>4__this.camMoving = true;
        goto label_6;
        label_2:
        this.<>1__state = 0;
        if(val_15 == 0)
        {
            goto label_7;
        }
        
        val_17 = this.<>4__this.playerController;
        goto label_8;
        label_5:
        mem[28] = 1;
        label_6:
        UnityEngine.Transform val_2 = this.<>4__this.cameraMain.transform;
        if((this.<>4__this.cameraMain) <= this.indexMap)
        {
                var val_15 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_15 = val_15 + (this.indexMap << 2);
        val_16 = 0;
        UnityEngine.Vector3 val_3 = position;
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.<>4__this.cameraMain, endValue:  new UnityEngine.Vector3(), duration:  val_3.x, snapping:  false);
        val_18 = 536895905;
        val_18 = new DG.Tweening.TweenCallback(object:  val_15, method:  new IntPtr(1610680681));
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.<>4__this.cameraMain, action:  536895905);
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetSpeedBased<DG.Tweening.Tweener>(t:  this.<>4__this.cameraMain);
        DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.<>4__this.cameraMain, ease:  1);
        return (bool)val_16;
        label_7:
        val_17 = 0;
        label_8:
        if(24 <= this.indexMap)
        {
                var val_16 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_16 = val_16 + (this.indexMap << 2);
        UnityEngine.Vector3 val_9 = position;
        val_18 = val_11;
        val_15 = 22718536;
        val_19 = 536899539;
        if(((mem[536899726] & true) == 0) && (mem[536899655] == 0))
        {
                val_19 = 536899539;
        }
        
        val_20 = mem[536899631];
        val_21 = mem[mem[536899631] + 4];
        val_21 = mem[536899631] + 4;
        if(val_21 == 0)
        {
                if(((mem[536899726] & true) == 0) && (mem[536899655] == 0))
        {
                val_20 = mem[536899631];
        }
        
            val_15 = mem[mem[536899631]];
            val_15 = val_20;
            val_21 = 536882991;
            val_21 = new System.Action(object:  val_15, method:  new IntPtr(1610680687));
            mem2[0] = val_21;
        }
        
        val_17.MoveToPos(posMove:  new UnityEngine.Vector3() {x = val_10, y = val_18, z = val_12}, timeMove:  val_9.x, onCompleted:  1082130432);
        UnityEngine.WaitForSeconds val_14 = 536896849;
        val_14 = new UnityEngine.WaitForSeconds(seconds:  val_9.x);
        this.<>2__current = val_14;
        val_16 = 1;
        this.<>1__state = 2;
        return (bool)val_16;
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
