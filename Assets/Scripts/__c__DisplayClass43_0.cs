using UnityEngine;
private sealed class PickerWheel.<>c__DisplayClass43_0
{
    // Fields
    public PickerWheel <>4__this;
    public float prevAngle;
    public float currentAngle;
    public bool isIndicatorOnTheLine;
    public WheelPiece piece;
    
    // Methods
    public PickerWheel.<>c__DisplayClass43_0()
    {
    
    }
    internal void <Spin>b__0()
    {
        float val_3;
        PickerWheel val_4;
        bool val_5;
        float val_4 = this.prevAngle;
        val_4 = val_4 - this.currentAngle;
        float val_5 = System.Math.Abs(val_4);
        if((this.<>4__this) < 0)
        {
            goto label_1;
        }
        
        if(this.isIndicatorOnTheLine == false)
        {
            goto label_2;
        }
        
        val_4 = this.<>4__this;
        if((this.<>4__this) != 0)
        {
            goto label_3;
        }
        
        val_4 = this.<>4__this;
        if(val_4 == 0)
        {
            goto label_4;
        }
        
        label_3:
        UnityEngine.AudioClip val_1 = this.<>4__this.audioSource.clip;
        this.<>4__this.audioSource.PlayOneShot(clip:  this.<>4__this.audioSource);
        val_5 = this.isIndicatorOnTheLine ^ 1;
        goto label_7;
        label_2:
        val_5 = true;
        label_7:
        this.isIndicatorOnTheLine = val_5;
        this.prevAngle = this.currentAngle;
        label_1:
        UnityEngine.Vector3 val_2 = eulerAngles;
        this.currentAngle = val_3;
        return;
        label_4:
    }
    internal void <Spin>b__1()
    {
        this.<>4__this._isSpinning = false;
        if((this.<>4__this.onSpinEndEvent) != 0)
        {
                this.<>4__this.onSpinEndEvent.Invoke(arg0:  this.piece);
        }
        
        this.<>4__this.onSpinStartEvent = 0;
        this.<>4__this.onSpinEndEvent = 0;
        if((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) == false)
        {
                return;
        }
        
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        UnityEngine.Vector3 val_3 = eulerAngles;
        -1073708883.StartAngleSpin = val_3.x;
    }

}
