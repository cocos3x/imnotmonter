using UnityEngine;
private sealed class HandTarget.<>c__DisplayClass45_0
{
    // Fields
    public bool isDestroyLine;
    public HandTarget <>4__this;
    
    // Methods
    public HandTarget.<>c__DisplayClass45_0()
    {
    
    }
    internal void <WithdrawHand>b__0()
    {
        if(this.isDestroyLine != false)
        {
                this.<>4__this.HideLine(hideHand:  false);
        }
        else
        {
                this.<>4__this.firstTarget = true;
        }
        
        this.<>4__this.rope2D.rope.enabled = false;
        this.<>4__this.rope2D.rending = false;
        this.<>4__this.handInSkeleton.SetActive(value:  true);
        UnityEngine.GameObject val_1 = this.<>4__this.handSprite.gameObject;
        this.<>4__this.handSprite.SetActive(value:  false);
    }

}
