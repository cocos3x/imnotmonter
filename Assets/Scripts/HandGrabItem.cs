using UnityEngine;
public class HandGrabItem : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform startPos;
    private UnityEngine.Transform endPos;
    private UnityEngine.Transform moveObject;
    private UnityEngine.Rigidbody2D holdingObject;
    private float moveSpeed;
    private Spine.Unity.SkeletonAnimation skeletonAnimation;
    private ItemAudio audio;
    private UnityEngine.Events.UnityEvent eventThrow;
    private bool canMove;
    private bool throwedObject;
    private bool movingToEnd;
    
    // Methods
    private void Start()
    {
        this.canMove = true;
    }
    private void Update()
    {
        float val_2;
        float val_3;
        float val_21;
        var val_22;
        float val_23;
        var val_24;
        var val_25;
        bool val_26;
        if(this.canMove == false)
        {
            goto label_1;
        }
        
        this.audio.PlaySound();
        if(this.movingToEnd == false)
        {
            goto label_3;
        }
        
        UnityEngine.Vector3 val_1 = position;
        val_21 = val_3;
        val_22 = 0;
        UnityEngine.Transform val_4 = this.endPos.transform;
        UnityEngine.Vector3 val_5 = position;
        float val_6 = UnityEngine.Time.deltaTime;
        uint val_21 = 0;
        val_21 = this.moveSpeed * val_21;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.MoveTowards(current:  new UnityEngine.Vector2() {x = 1.74331E-14f, y = val_2}, target:  new UnityEngine.Vector2() {x = val_21, y = val_2}, maxDistanceDelta:  val_21);
        this.moveObject.position = new UnityEngine.Vector3() {x = val_2, y = val_3, z = 0f};
        UnityEngine.Vector3 val_8 = position;
        val_23 = val_3;
        val_24 = 0;
        UnityEngine.Transform val_9 = this.endPos.transform;
        val_25 = this.endPos;
        UnityEngine.Vector3 val_10 = position;
        float val_11 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_2, y = val_23}, b:  new UnityEngine.Vector2() {x = val_2, y = val_3});
        if(this.endPos > 0)
        {
                return;
        }
        
        val_26 = 0;
        goto label_11;
        label_1:
        this.audio.audioSource.Stop();
        return;
        label_3:
        UnityEngine.Vector3 val_12 = position;
        val_21 = val_3;
        val_22 = 0;
        UnityEngine.Transform val_13 = this.startPos.transform;
        UnityEngine.Vector3 val_14 = position;
        float val_15 = UnityEngine.Time.deltaTime;
        uint val_22 = 0;
        val_22 = this.moveSpeed * val_22;
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.MoveTowards(current:  new UnityEngine.Vector2() {x = 1.74331E-14f, y = val_2}, target:  new UnityEngine.Vector2() {x = val_21, y = val_2}, maxDistanceDelta:  val_22);
        this.moveObject.position = new UnityEngine.Vector3() {x = val_2, y = val_3, z = 0f};
        UnityEngine.Vector3 val_17 = position;
        val_23 = val_3;
        val_24 = 0;
        UnityEngine.Transform val_18 = this.startPos.transform;
        val_25 = this.startPos;
        UnityEngine.Vector3 val_19 = position;
        float val_20 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_2, y = val_23}, b:  new UnityEngine.Vector2() {x = val_2, y = val_3});
        if(this.startPos > 0)
        {
                return;
        }
        
        val_26 = true;
        label_11:
        this.movingToEnd = val_26;
    }
    public void Stop()
    {
        this.canMove = false;
        this.audio.audioSource.Stop();
    }
    public void Move()
    {
        this.canMove = true;
        this.audio.PlaySound();
    }
    public void ThrowObject()
    {
        this.canMove = false;
        if(this.throwedObject == true)
        {
                return;
        }
        
        536882991 = new System.Action(object:  681792912, method:  new IntPtr(1610679695));
        MixSkinManager.SetAnimation(ske:  this.skeletonAnimation, name:  -1610598931, loop:  false, timeScale:  null, _callBack:  1065353216);
    }
    public HandGrabItem()
    {
        this.movingToEnd = true;
    }
    private void <ThrowObject>b__15_0()
    {
        if(this.eventThrow != 0)
        {
                this.eventThrow.Invoke();
        }
        
        this.throwedObject = true;
        UnityEngine.Transform val_1 = this.holdingObject.transform;
        UnityEngine.Transform val_2 = this.holdingObject.transform;
        this.holdingObject.parent = 682037392;
        this.holdingObject.bodyType = 0;
        this.audio.PlaySFX(name:  -1610606493);
    }

}
