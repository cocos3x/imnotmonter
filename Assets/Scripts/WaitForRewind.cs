using UnityEngine;
public class DOTweenCYInstruction.WaitForRewind : CustomYieldInstruction
{
    // Fields
    private readonly DG.Tweening.Tween t;
    
    // Properties
    public override bool keepWaiting { get; }
    
    // Methods
    public override bool get_keepWaiting()
    {
        DG.Tweening.Tween val_2;
        var val_3;
        if((this.t.<active>k__BackingField) == false)
        {
            goto label_1;
        }
        
        if((this.t.<playedOnce>k__BackingField) == false)
        {
            goto label_3;
        }
        
        val_2 = this.t;
        if(this.t == 0)
        {
                val_2 = this.t;
        }
        
        int val_1 = DG.Tweening.TweenExtensions.CompletedLoops(t:  val_2);
        val_1 = val_1 + 1;
        float val_2 = (float)val_1;
        val_2 = (this.t.<position>k__BackingField) * val_2;
        if(this.t > 0)
        {
                val_3 = 1;
        }
        
        return (bool)val_3;
        label_1:
        val_3 = 0;
        return (bool)val_3;
        label_3:
        val_3 = 1;
        return (bool)val_3;
    }
    public DOTweenCYInstruction.WaitForRewind(DG.Tweening.Tween tween)
    {
        this.t = tween;
    }

}
