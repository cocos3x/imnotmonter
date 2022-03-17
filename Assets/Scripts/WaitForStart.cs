using UnityEngine;
public class DOTweenCYInstruction.WaitForStart : CustomYieldInstruction
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
        
        bool val_1 = this.t.<playedOnce>k__BackingField;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public DOTweenCYInstruction.WaitForStart(DG.Tweening.Tween tween)
    {
        this.t = tween;
    }

}
