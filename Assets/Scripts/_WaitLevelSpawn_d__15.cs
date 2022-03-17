using UnityEngine;
private sealed class LevelCutRopeManager.<WaitLevelSpawn>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public int id;
    public LevelCutRopeManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelCutRopeManager.<WaitLevelSpawn>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_28;
        int val_29;
        string val_30;
        var val_31;
        UnityEngine.GameObject val_32;
        int val_33;
        int val_34;
        val_28 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_28;
        }
        
        this.<>1__state = 0;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266339] + 8) == 0)
        {
            goto label_5;
        }
        
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IsOldUser) == false)
        {
            goto label_7;
        }
        
        label_5:
        if((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) == false)
        {
            goto label_10;
        }
        
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        if(this.id <= (-1073708883.NumberCutRopeLevel))
        {
            goto label_10;
        }
        
        object val_7 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_8 = -1073708883.NumberCutRopeLevel;
        goto label_12;
        label_1:
        this.<>1__state = 0;
        WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_28 = 0;
        mem[3221266237] = val_28;
        return (bool)val_28;
        label_7:
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_11 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_13 = (mem[3221266339] + 16) + ((-1073708883.CurrentLevel) << 2);
        val_29 = mem[(mem[3221266339] + 16 + (val_12) << 2) + 16];
        val_29 = (mem[3221266339] + 16 + (val_12) << 2) + 16;
        label_12:
        this.id = val_29;
        label_10:
        if((this.<>4__this) != 0)
        {
                this.<>4__this.StartLevelTracking();
        }
        else
        {
                0.StartLevelTracking();
        }
        
        string val_14 = this.id.ToString();
        string val_15 = this.<>4__this.levelPrefabPath(this.<>4__this.levelPrefabPath) + this.id;
        System.Type val_16 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073758215)});
        UnityEngine.Object val_17 = UnityEngine.Resources.Load(path:  this.<>4__this.levelPrefabPath, systemTypeInstance:  1073758215);
        if((this.<>4__this.levelPrefabPath) != 0)
        {
                val_30 = this.<>4__this.levelPrefabPath;
            val_31 = this.id;
        }
        else
        {
                val_31;
            val_30 = this.<>4__this.levelPrefabPath;
        }
        
        string val_20 = UnityEngine.Random.Range(minInclusive:  21, maxExclusive:  30).ToString();
        string val_21 = val_30 + 605938952;
        val_32 = 0;
        System.Type val_22 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073758215)});
        UnityEngine.Object val_23 = UnityEngine.Resources.Load(path:  val_30, systemTypeInstance:  1073758215);
        UnityEngine.Transform val_24 = this.<>4__this.transform;
        UnityEngine.Object val_25 = UnityEngine.Object.Instantiate(original:  val_30, parent:  this.<>4__this);
        if(val_30 != null)
        {
                if(null != 536887303)
        {
                val_30 = 0;
        }
        
            val_32 = val_30;
        }
        
        this.<>4__this.levelSpawn = val_32;
        Weight val_26 = this.<>4__this + 36.GetComponent<Weight>();
        if((this.<>4__this + 36) != 0)
        {
                val_33 = mem[this.<>4__this + 36 + 12];
            val_33 = this.<>4__this + 36 + 12;
            this.<>4__this.totalRope = val_33;
            val_34 = mem[this.<>4__this + 36 + 16];
            val_34 = this.<>4__this + 36 + 16;
            this.<>4__this.totalHuggyRope = val_34;
        }
        else
        {
                this.<>4__this.totalRope = 0;
            this.<>4__this.totalHuggyRope = 2621443;
            val_33 = this.<>4__this.totalRope;
            val_34 = this.<>4__this.totalHuggyRope;
        }
        
        this.<>4__this.currentRope = val_33;
        this.<>4__this.totalEnemy = this.<>4__this + 36 + 20;
        if(val_33 < 1)
        {
                0 = 1;
        }
        
        this.<>4__this.currentHuggyRope = val_34;
        this.<>4__this.currentEnemy = this.<>4__this + 36 + 20;
        if(val_34 < 1)
        {
                0 = 1;
        }
        
        this.<>4__this.allRopeCut = true;
        this.<>4__this.allHuggyRopeCut = true;
        if((this.<>4__this + 36 + 20) < 1)
        {
                0 = 1;
        }
        
        this.<>4__this.allEnemyDead = true;
        this.<>4__this.huggyBase = this.<>4__this + 36 + 24;
        this.<>4__this.mistressControl = this.<>4__this + 36 + 28;
        this.<>4__this.StopCoroutine(methodName:  -1610602599);
        UnityEngine.WaitForSeconds val_27 = 536896849;
        val_27 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_27;
        val_28 = 1;
        this.<>1__state = val_28;
        return (bool)val_28;
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
