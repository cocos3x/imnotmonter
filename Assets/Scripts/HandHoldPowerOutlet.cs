using UnityEngine;
public class HandHoldPowerOutlet : HoldItemBase
{
    // Fields
    private PowerOutletController powerOutlet;
    
    // Methods
    public override void SetCanHoldMe(bool _canHold)
    {
        if(_canHold == false)
        {
                return;
        }
        
        this.powerOutlet.HandDontHold();
    }
    public HandHoldPowerOutlet()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
