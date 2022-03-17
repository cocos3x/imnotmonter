using UnityEngine;
private sealed class Water2D_Spawner.<CheckOnFill>d__108 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Water2D.Water2D_Spawner <>4__this;
    public UnityEngine.Collider2D shapeCollider;
    public float accuracy;
    private UnityEngine.ContactFilter2D <cf>5__2;
    private UnityEngine.Collider2D[] <allOverlappingColliders>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Water2D_Spawner.<CheckOnFill>d__108(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_11;
        Water2D.Water2D_Spawner val_12;
        var val_13;
        bool val_14;
        bool val_15;
        int val_16;
        Water2D.Water2D_Spawner val_17;
        var val_18;
        val_11 = 0;
        val_12 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_11;
        }
        
        this.<>1__state = 0;
        val_13 = this;
        this.<>4__this._checkOnFillRunning = true;
        this.<cf>5__2 = true;
        UnityEngine.LayerMask val_3 = UnityEngine.LayerMask.op_Implicit(intVal:  UnityEngine.Physics2D.GetLayerCollisionMask(layer:  this.<>4__this.DropObject.layer));
        this.<cf>5__2.SetLayerMask(layerMask:  new UnityEngine.LayerMask() {m_Mask = val_3.m_Mask});
        mem[1152921509834773133] = 1;
        this.<allOverlappingColliders>5__3 = 536881819;
        goto label_14;
        label_1:
        this.<>1__state = 0;
        if(this.shapeCollider == 0)
        {
                val_16 = mem[this.<cf>5__2 + (8)];
            val_15 = mem[this.<cf>5__2 + (4)];
            val_14 = mem[this.<cf>5__2 + (0)];
        }
        
        val_12 = val_12;
        val_13 = this.shapeCollider.OverlapCollider(contactFilter:  new UnityEngine.ContactFilter2D() {useTriggers = val_14, useLayerMask = val_14, useDepth = val_14, useOutsideDepth = val_14, useNormalAngle = val_15, useOutsideNormalAngle = val_15, layerMask = new UnityEngine.LayerMask() {m_Mask = val_16}, minDepth = mem[this.<cf>5__2 + (12)], maxDepth = mem[this.<cf>5__2 + (16)]}, results:  this.<allOverlappingColliders>5__3);
        if(val_12 == 0)
        {
            goto label_10;
        }
        
        if((this.<>4__this + 16) != 1)
        {
            goto label_11;
        }
        
        label_13:
        val_18 = mem[this.<>4__this + 244];
        val_18 = this.<>4__this + 244;
        goto label_12;
        label_10:
        if(2621443 == 1)
        {
            goto label_13;
        }
        
        label_11:
        val_18 = mem[this.<>4__this + 232];
        val_18 = this.<>4__this + 232;
        label_12:
        float val_10 = (float)val_18;
        val_10 = this.accuracy * val_10;
        if(2621443 <= 1)
        {
                UnityEngine.GameObject val_5 = mem[536896983].gameObject;
            val_12.InvokeOnShapeFill(obj:  mem[536896983], results:  0);
            val_13 = 536882401;
            mem[536882417] = -1610608135;
            val_17 = val_12 + 244;
            string val_6 = val_17.ToString();
            mem[536882421] = val_17;
            mem[536882425] = -1610612533;
            float val_11 = (float)val_17;
            val_11 = this.accuracy * val_11;
            string val_7 = (int)val_11.ToString();
            mem[536882429] = ;
            mem[536882433] = -1610597351;
            string val_8 = +536882401;
            UnityEngine.Debug.Log(message:  536882401);
            mem2[0] = 257;
        }
        
        label_14:
        if((this.<>4__this + 341) != 0)
        {
                val_11 = 0;
            mem2[0] = val_11;
            return (bool)val_11;
        }
        
        UnityEngine.WaitForFixedUpdate val_9 = 536896845;
        val_9 = new UnityEngine.WaitForFixedUpdate();
        this.<>2__current = val_9;
        val_11 = 1;
        this.<>1__state = val_11;
        return (bool)val_11;
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
