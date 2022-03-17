using UnityEngine;
public class DOTweenCYInstruction.WaitForElapsedLoops : CustomYieldInstruction
{
    // Fields
    private readonly DG.Tweening.Tween t;
    private readonly int elapsedLoops;
    
    // Properties
    public override bool keepWaiting { get; }
    
    // Methods
    public override bool get_keepWaiting()
    {
        var val_2;
        if((this.t.<active>k__BackingField) != false)
        {
                if((DG.Tweening.TweenExtensions.CompletedLoops(t:  this.t)) < this.elapsedLoops)
        {
                val_2 = 1;
        }
        
            return (bool)val_2;
        }
        
        val_2 = 0;
        return (bool)val_2;
    }
    public DOTweenCYInstruction.WaitForElapsedLoops(DG.Tweening.Tween tween, int elapsedLoops)
    {
        this.t = tween;
        mem[1152921510324129564] = elapsedLoops;
    }

}
