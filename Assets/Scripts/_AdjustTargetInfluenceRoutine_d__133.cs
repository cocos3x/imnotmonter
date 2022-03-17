using UnityEngine;
private sealed class ProCamera2D.<AdjustTargetInfluenceRoutine>d__133 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.CameraTarget cameraTarget;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2D <>4__this;
    public float duration;
    public float influenceH;
    public float influenceV;
    public bool removeIfZeroInfluence;
    private float <startInfluenceH>5__2;
    private float <startInfluenceV>5__3;
    private float <t>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2D.<AdjustTargetInfluenceRoutine>d__133(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        Com.LuisPedroFonseca.ProCamera2D.CameraTarget val_6;
        float val_7;
        Com.LuisPedroFonseca.ProCamera2D.CameraTarget val_8;
        val_5 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
        this.<>1__state = 0;
        if(this.cameraTarget == 0)
        {
            goto label_3;
        }
        
        this.<startInfluenceH>5__2 = this.cameraTarget.TargetInfluenceH;
        val_6 = this.cameraTarget;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>1__state) <= 1)
        {
            goto label_5;
        }
        
        if(this.removeIfZeroInfluence == false)
        {
                return (bool)val_5;
        }
        
        val_8 = this.cameraTarget;
        if(val_8 > 0)
        {
                return (bool)val_5;
        }
        
        val_8 = this.cameraTarget;
        if(val_8 > 0)
        {
                return (bool)val_5;
        }
        
        bool val_1 = this.<>4__this.CameraTargets.Remove(item:  this.cameraTarget);
        return (bool)val_5;
        label_3:
        val_6 = this.cameraTarget;
        this.<startInfluenceH>5__2 = this.cameraTarget.TargetInfluenceH;
        if(val_6 == 0)
        {
            goto label_14;
        }
        
        label_4:
        val_7 = 0f;
        this.<startInfluenceV>5__3 = this.cameraTarget.TargetInfluenceV;
        this.<t>5__4 = 0f;
        label_5:
        float val_5 = this.duration;
        val_5 = (this.<>4__this.<DeltaTime>k__BackingField) / val_5;
        val_5 = val_7 + val_5;
        this.<t>5__4 = val_5;
        this.cameraTarget.TargetInfluenceH = this.<startInfluenceH>5__2;
        val_8 = this.cameraTarget;
        float val_3 = Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  val_5, end:  null, value:  this.<>4__this.<DeltaTime>k__BackingField, type:  this.<startInfluenceH>5__2), end:  null, value:  this.<>4__this.<DeltaTime>k__BackingField, type:  this.<startInfluenceV>5__3);
        this.cameraTarget.TargetInfluenceV = this.<startInfluenceV>5__3;
        UnityEngine.YieldInstruction val_4 = this.<>4__this.GetYield();
        this.<>2__current = this.<>4__this;
        val_5 = 1;
        this.<>1__state = val_5;
        return (bool)val_5;
        label_14:
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
