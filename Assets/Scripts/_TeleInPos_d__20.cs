using UnityEngine;
private sealed class BossRopeRescueController.<TeleInPos>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public BossRopeRescueController <>4__this;
    public UnityEngine.Vector3 posMove;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BossRopeRescueController.<TeleInPos>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        float val_10;
        float val_13;
        int val_18;
        var val_19;
        if((this.<>1__state) != 1)
        {
                val_18 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_18;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = 536896849;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            this.<>2__current = val_1;
            val_18 = 1;
            this.<>1__state = val_18;
            return (bool)val_18;
        }
        
        this.<>1__state = 0;
        UnityEngine.Transform val_2 = this.<>4__this.transform;
        int val_3 = DG.Tweening.DOTween.Kill(targetOrId:  this.<>4__this, complete:  false);
        UnityEngine.Transform val_4 = this.<>4__this.skeletonBoss.transform;
        UnityEngine.Transform val_5 = this.<>4__this.skeletonBoss.transform;
        UnityEngine.Vector3 val_6 = localScale;
        UnityEngine.Transform val_8 = this.<>4__this.skeletonBoss.transform;
        UnityEngine.Vector3 val_9 = localScale;
        UnityEngine.Transform val_11 = this.<>4__this.skeletonBoss.transform;
        UnityEngine.Vector3 val_12 = localScale;
        this.<>4__this.skeletonBoss.localScale = new UnityEngine.Vector3() {x = val_7 ^ 2147483648, y = val_10, z = val_13};
        UnityEngine.Transform val_15 = this.<>4__this.transform;
        UnityEngine.Transform val_16 = this.<>4__this.transform;
        this.<>4__this.position = new UnityEngine.Vector3() {x = this.posMove, y = this.<>4__this, z = 1.722114E-13f};
        val_19 = 536884273;
        if(((mem[536884460] & true) == 0) && (mem[536884389] == 0))
        {
                val_19 = 536884273;
        }
        
        val_18 = 0;
        this.<>4__this.SetAnimBoss(name:  mem[536884365] + 8, loop:  true, _callBack:  0);
        val_7 = 1073741824;
        UnityEngine.Coroutine val_17 = this.<>4__this.StartCoroutine(methodName:  -1610608783, value:  536893745);
        return (bool)val_18;
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
