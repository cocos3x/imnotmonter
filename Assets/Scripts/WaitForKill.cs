using UnityEngine;
public class DOTweenCYInstruction.WaitForKill : CustomYieldInstruction
{
    // Fields
    private readonly DG.Tweening.Tween t;
    
    // Properties
    public override bool keepWaiting { get; }
    
    // Methods
    public override bool get_keepWaiting()
    {
        if(this.t != 0)
        {
                return (bool)this.t.<active>k__BackingField;
        }
        
        return (bool)this.t.<active>k__BackingField;
    }
    public DOTweenCYInstruction.WaitForKill(DG.Tweening.Tween tween)
    {
        this.t = tween;
    }

}
