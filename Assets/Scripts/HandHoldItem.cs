using UnityEngine;
public class HandHoldItem : HoldItemBase
{
    // Fields
    private bool canHold;
    private UnityEngine.Rigidbody2D rigidbody2D;
    private bool canTargetHand;
    private System.Collections.Generic.List<UnityEngine.Transform> listTargets;
    private int itemID;
    private HandTarget hand;
    private HandHoldItem.TypeItemHold typeItem;
    
    // Properties
    public int ItemID { get; }
    
    // Methods
    private void Start()
    {
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        this.rigidbody2D = this;
        this.canHold = true;
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  682165776, method:  new IntPtr(1610679715));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  682165776, eventID:  25, callback:  536873423);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  682165776, method:  new IntPtr(1610679717));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  682165776, eventID:  35, callback:  536873423);
    }
    private void OnDisable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  682277776, method:  new IntPtr(1610679719));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  682277776, eventID:  25, callback:  536873423);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  682277776, method:  new IntPtr(1610679721));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  682277776, eventID:  35, callback:  536873423);
    }
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        var val_9;
        float val_10;
        HandTarget val_17;
        bool val_18;
        val_17 = 22999521;
        if(this.canTargetHand == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_1 = collision.gameObject;
        val_17 = collision.layer;
        if(val_17 != (UnityEngine.LayerMask.NameToLayer(layerName:  -1610608505)))
        {
                return;
        }
        
        if(this.canHold == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_4 = collision.gameObject;
        Weight val_5 = collision.GetComponent<Weight>();
        this.hand = collision;
        val_17 = this.hand;
        val_18 = false;
        if((UnityEngine.Object.op_Implicit(exists:  val_17)) == false)
        {
                return;
        }
        
        this.canHold = val_18;
        UnityEngine.Transform val_7 = this.hand.transform;
        UnityEngine.Vector2 val_8 = GetPosHandTarget(trasHand:  682406160);
        UnityEngine.Transform val_11 = this.transform;
        UnityEngine.Vector3 val_12 = position;
        UnityEngine.Transform val_13 = this.transform;
        UnityEngine.Vector3 val_14 = position;
        float val_17 = val_10;
        float val_15 = val_9 - val_9;
        val_17 = val_10 - val_17;
        val_15.Normalize();
        this.hand.ChangeStatusHand(statusHand:  3);
        val_18 = val_17;
        this.hand.HandTargetPos(posTarget:  new UnityEngine.Vector2() {x = 4.203895E-45f, y = 0f}, Direc:  new UnityEngine.Vector2() {x = val_15, y = val_18});
        UnityEngine.Transform val_16 = this.transform;
        val_17 = this;
        this.hand.AddHoldingObject(handHoldItem:  682406160);
        UnityEngine.Object.Destroy(obj:  this.rigidbody2D);
    }
    private UnityEngine.Vector2 GetPosHandTarget(UnityEngine.Transform trasHand)
    {
        float val_2;
        float val_3;
        var val_10;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.one;
        val_10 = 4;
        goto label_1;
        label_11:
        UnityEngine.Vector3 val_4 = position;
        if((R5 + 12) <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Vector3 val_5 = position;
        float val_6 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_2, y = val_3}, b:  new UnityEngine.Vector2() {x = val_2, y = val_3});
        if((R5 + 8 + 16) > 0)
        {
                if((val_2 + 12) <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.Vector3 val_7 = position;
        }
        
        val_10 = 5;
        label_1:
        if((val_10 - 4) < (val_2 + 8 + 16 + 12))
        {
            goto label_11;
        }
        
        this = val_2;
        mem[1152921509584352916] = val_3;
        return new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
    }
    public override void SetCanHoldMe(bool _canHold)
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SynchronizationContextBehavoir val_2 = this.AddComponent<SynchronizationContextBehavoir>();
        this.rigidbody2D = this;
        bool val_3 = UnityEngine.Object.op_Implicit(exists:  this.hand);
        this.Invoke(methodName:  -1610610349, time:  null);
    }
    private void ActiveCanHold()
    {
        this.canHold = true;
    }
    public int get_ItemID()
    {
        return (int)this.itemID;
    }
    public void DestroyItem()
    {
        float val_5;
        float val_6;
        float val_7;
        var val_20;
        var val_21;
        var val_22;
        float val_24;
        var val_25;
        var val_26;
        var val_27;
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
            goto label_13;
        }
        
        if(this.typeItem == 2)
        {
            goto label_2;
        }
        
        if(this.typeItem != 1)
        {
            goto label_13;
        }
        
        val_20 = 22742080;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_21 = -1073701087;
        UnityEngine.Transform val_3 = this.transform;
        val_22 = 0;
        UnityEngine.Vector3 val_4 = position;
        val_24 = val_6;
        UnityEngine.GameObject val_8 = val_21.GetItem(key:  -1610609875, position:  new UnityEngine.Vector3() {x = val_5, y = val_24, z = val_7});
        WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_25 = -1073701087;
        val_25.Despaw(go:  -1073701087, delay:  val_4.x);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
            goto label_13;
        }
        
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_26 = -1073701113;
        val_27 = 22797276;
        goto label_9;
        label_2:
        val_20 = 22742080;
        WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_21 = -1073701087;
        UnityEngine.Transform val_13 = this.transform;
        val_22 = 0;
        UnityEngine.Vector3 val_14 = position;
        val_24 = val_6;
        UnityEngine.GameObject val_15 = val_21.GetItem(key:  -1610609341, position:  new UnityEngine.Vector3() {x = val_5, y = val_24, z = val_7});
        WorldTimeAPI val_16 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_25 = -1073701087;
        val_25.Despaw(go:  -1073701087, delay:  val_14.x);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
            goto label_13;
        }
        
        WorldTimeAPI val_18 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_26 = -1073701113;
        val_27 = 22793620;
        label_9:
        val_26.Shot(clip:  -1610604359, volume:  val_14.x);
        label_13:
        UnityEngine.GameObject val_19 = this.gameObject;
        this.SetActive(value:  false);
    }
    public HandHoldItem()
    {
        this.canTargetHand = true;
        val_1 = new UnityEngine.MonoBehaviour();
    }
    private void <Start>b__7_0(UnityEngine.Component sender, object param)
    {
        this.canHold = false;
    }
    private void <Start>b__7_1(UnityEngine.Component sender, object param)
    {
        this.canHold = true;
    }
    private void <OnDisable>b__8_0(UnityEngine.Component sender, object param)
    {
        this.canHold = false;
    }
    private void <OnDisable>b__8_1(UnityEngine.Component sender, object param)
    {
        this.canHold = true;
    }

}
