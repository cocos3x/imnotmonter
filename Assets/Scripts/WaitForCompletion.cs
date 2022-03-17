using UnityEngine;
public class DOTweenCYInstruction.WaitForCompletion : CustomYieldInstruction
{
    // Fields
    private readonly DG.Tweening.Tween t;
    
    // Properties
    public override bool keepWaiting { get; }
    
    // Methods
    public override bool get_keepWaiting()
    {
        if((this.t.<active>k__BackingField) == false)
        {
                return false;
        }
        
        bool val_1 = DG.Tweening.TweenExtensions.IsComplete(t:  this.t);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public DOTweenCYInstruction.WaitForCompletion(DG.Tweening.Tween tween)
    {
        this.t = tween;
    }

}
