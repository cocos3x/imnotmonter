using UnityEngine;
public class HandTarget : MonoBehaviour
{
    // Fields
    private UnityEngine.Rigidbody2D rb2D;
    private Rope2D rope2D;
    private UnityEngine.GameObject handInSkeleton;
    private UnityEngine.GameObject handFakeInSkeleton;
    private UnityEngine.SpriteRenderer handSprite;
    private UnityEngine.Color colorHand;
    private InputController inputController;
    private UnityEngine.Transform handHoldingItem;
    private float speed;
    private bool isHoldingItem;
    private TypeHand typeHand;
    private UnityEngine.Sprite spriteHand_1;
    private UnityEngine.Sprite spriteHand_2;
    private UnityEngine.Sprite spriteHand_3;
    private UnityEngine.Sprite spriteHand_4;
    private bool firstTarget;
    private bool destroyLine;
    private int indexMouseTarget;
    private bool pressing;
    private bool stopAll;
    private UnityEngine.Vector3 _posHandHuggy;
    private bool inTarget;
    private System.Action callBackHandInTarget;
    private System.Action callBackHandOutTarget;
    
    // Properties
    public TypeHand GetTypeHand { get; }
    public System.Collections.Generic.List<UnityEngine.Vector3> wayPointsMove { get; }
    public System.Collections.Generic.List<UnityEngine.Vector3> wayPointsMoveHand { get; }
    
    // Methods
    public TypeHand get_GetTypeHand()
    {
    
    }
    private void Start()
    {
        this.RopeColor();
        if(this.typeHand == 0)
        {
                22789056 = 22789048;
        }
        
        this.rope2D.CreateLine(nameLine:  -1610606645);
        this.handInSkeleton.SetActive(value:  true);
        UnityEngine.GameObject val_1 = this.handSprite.gameObject;
        this.handSprite.SetActive(value:  false);
        this.firstTarget = true;
    }
    private void OnEnable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  746497424, method:  new IntPtr(1610680767));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  746497424, eventID:  25, callback:  536873423);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  746497424, method:  new IntPtr(1610680769));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  746497424, eventID:  5, callback:  536873423);
    }
    private void OnDisable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  746609424, method:  new IntPtr(1610680771));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  746609424, eventID:  25, callback:  536873423);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  746609424, method:  new IntPtr(1610680773));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  746609424, eventID:  5, callback:  536873423);
    }
    private void RopeColor()
    {
        UnityEngine.Color32 val_1 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = this.colorHand});
        this.rope2D.lineColor = val_1;
    }
    public void ReleaseHoldingObject()
    {
        float val_9;
        if(this.isHoldingItem == false)
        {
                return;
        }
        
        this.isHoldingItem = false;
        UnityEngine.Debug.Log(message:  -1610598685);
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.Transform val_2 = -1073700957.transLevel;
        this.handHoldingItem.parent = -1073700957;
        UnityEngine.Transform val_3 = this.handHoldingItem.transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DORotate(target:  746853904, endValue:  new UnityEngine.Vector3(), duration:  val_4.x, mode:  1045220557);
        this.ChangeStatusHand(statusHand:  1);
        UnityEngine.GameObject val_6 = this.handSprite.gameObject;
        UnityEngine.Transform val_7 = this.handSprite.transform;
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(x:  val_4.x, y:  val_4.y, z:  val_4.z);
        this.handSprite.rotation = new UnityEngine.Quaternion() {x = R6, y = R7, z = SB, w = val_9};
        UnityEngine.Transform val_10 = this.handHoldingItem.GetComponent<UnityEngine.Transform>();
        if(this.handHoldingItem == 0)
        {
                return;
        }
    
    }
    public void AddHoldingObject(UnityEngine.Transform handHoldItem)
    {
        if(this.isHoldingItem == true)
        {
                return;
        }
        
        mem2[0] = 1;
        mem2[0] = handHoldItem;
        UnityEngine.Transform val_1 = R5.transform;
        handHoldItem.parent = R5;
    }
    public void HandTargetPos(UnityEngine.Vector2 posTarget, UnityEngine.Vector2 Direc)
    {
        float val_4;
        float val_5;
        float val_6;
        float val_7;
        float val_8 = 57.29578f;
        val_8 = Direc.y * val_8;
        UnityEngine.GameObject val_1 = this.handSprite.gameObject;
        UnityEngine.Transform val_2 = this.handSprite.transform;
        float val_9 = 90f;
        val_9 = val_8 + val_9;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(x:  val_9, y:  null, z:  null);
        this.handSprite.rotation = new UnityEngine.Quaternion() {x = val_4, y = val_5, z = val_6, w = val_7};
    }
    private void FixedUpdate()
    {
        var val_2;
        if(this.stopAll == false)
        {
                this.stopAll = this.pressing;
            goto label_0;
        }
        
        return;
        label_0:
        UnityEngine.Vector2 val_1 = velocity;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        var val_6 = val_2;
        val_6 = val_2 - val_6;
        double val_4 = val_6 * val_6;
        val_3.x = val_3.x + val_3.y;
        if(this.rb2D < 0)
        {
                return;
        }
        
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
        this.rb2D.velocity = new UnityEngine.Vector2() {x = R6, y = R7};
        this.rb2D.bodyType = 2;
        this.rope2D.rending = false;
        this.rope2D.rope.enabled = false;
    }
    private void OnMouseDown()
    {
        int val_6;
        if(this.stopAll == false)
        {
                this.stopAll = this.pressing;
            goto label_1;
        }
        
        return;
        label_1:
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if(mem[3221266371] == false)
        {
                return;
        }
        
        if(this.firstTarget != false)
        {
                this.handInSkeleton.SetActive(value:  false);
            UnityEngine.GameObject val_2 = this.handSprite.gameObject;
            this.handSprite.SetActive(value:  true);
            this.ChangeStatusHand(statusHand:  1);
            this.firstTarget = false;
        }
        
        this.rb2D.bodyType = 0;
        if(this.inTarget == true)
        {
                this.inTarget = this.callBackHandOutTarget;
        }
        
        if(this.inTarget != 0)
        {
                this.inTarget.Invoke();
        }
        
        val_6 = 0;
        if(UnityEngine.Input.touchCount >= 1)
        {
                val_6 = UnityEngine.Input.touchCount - 1;
        }
        
        this.pressing = true;
        this.indexMouseTarget = val_6;
        this.rope2D.rending = true;
        this.rope2D.rope.enabled = true;
    }
    private void OnMouseUp()
    {
        if(this.stopAll == true)
        {
                return;
        }
        
        if(this.pressing == false)
        {
                return;
        }
        
        this.pressing = false;
        this.ReleaseHoldingObject();
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.rb2D.velocity = new UnityEngine.Vector2() {x = R6, y = R7};
        if(this.inTarget == true)
        {
                this.inTarget = this;
            this.HandMoveToTarget();
        }
    
    }
    private void OnMouseDrag()
    {
        var val_4;
        float val_5;
        if(this.stopAll != false)
        {
                return;
        }
        
        if(this.pressing == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_1 = GetMousePosition(indexMouse:  this.inputController);
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3(), rhs:  new UnityEngine.Vector3() {x = -100f, y = 100f, z = 100f})) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = GetMousePosition(indexMouse:  this.inputController);
        var val_8 = val_4;
        var val_9 = val_5;
        UnityEngine.Vector2 val_6 = position;
        float val_10 = val_5;
        val_8 = val_8 - val_4;
        val_9 = val_9 - val_10;
        float val_7 = UnityEngine.Time.deltaTime;
        uint val_11 = 0;
        val_10 = val_9 * val_11;
        val_11 = val_8 * val_11;
        val_10 = val_10 * this.speed;
        val_11 = val_11 * this.speed;
        this.rb2D.velocity = new UnityEngine.Vector2() {y = val_10};
    }
    public void HandInTarget(UnityEngine.Vector3 _positon, System.Action _callBackHandInTarget, System.Action _callBackHandOutTarget)
    {
        this.inTarget = true;
        this.callBackHandInTarget = _callBackHandInTarget;
        this.callBackHandOutTarget = _callBackHandOutTarget;
    }
    private void HandMoveToTarget()
    {
        this.pressing = true;
        this.stopAll = true;
        this.ReleaseHoldingObject();
        this.rb2D.bodyType = 2;
        UnityEngine.Transform val_1 = this.rb2D.transform;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOMove(target:  747946512, endValue:  new UnityEngine.Vector3() {x = mem[this._posHandHuggy + (0)], y = mem[this._posHandHuggy + (4)], z = mem[this._posHandHuggy + (8)]}, duration:  null, snapping:  true);
        536895905 = new DG.Tweening.TweenCallback(object:  747946512, method:  new IntPtr(1610680775));
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  747946512, action:  536895905);
    }
    public void SaveCompletedHuggy()
    {
        this.stopAll = true;
    }
    public void HandOutTarget()
    {
        this.inTarget = false;
    }
    public System.Collections.Generic.List<UnityEngine.Vector3> get_wayPointsMove()
    {
        if(this.rope2D != 0)
        {
                return;
        }
    
    }
    public System.Collections.Generic.List<UnityEngine.Vector3> get_wayPointsMoveHand()
    {
        if(this.rope2D != 0)
        {
                return;
        }
    
    }
    private void WithdrawHand(bool isDestroyLine = True)
    {
        HandTarget.<>c__DisplayClass45_0 val_1 = 536899249;
        val_1 = new HandTarget.<>c__DisplayClass45_0();
        if(val_1 != 0)
        {
                mem[536899257] = isDestroyLine;
        }
        else
        {
                mem[8] = isDestroyLine;
        }
        
        mem[536899261] = this;
        if(this.firstTarget != false)
        {
                return;
        }
        
        this.ChangeStatusHand(statusHand:  1);
        536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>(collection:  this.rope2D.wayPoints);
        536878517.Reverse();
        this.pressing = true;
        this.stopAll = true;
        this.ReleaseHoldingObject();
        this.rope2D.rending = true;
        this.rope2D.rope.enabled = true;
        this.rb2D.bodyType = 2;
        UnityEngine.Transform val_3 = this.rb2D.transform;
        T[] val_4 = 536878517.ToArray();
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> val_5 = DG.Tweening.ShortcutExtensions.DOPath(target:  748567952, path:  536878517, duration:  null, pathType:  1092616192, pathMode:  0, resolution:  1, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  748567952, ease:  1);
        536895905 = new DG.Tweening.TweenCallback(object:  536899249, method:  new IntPtr(1610680779));
        DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  748567952, action:  536895905);
        DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetSpeedBased<DG.Tweening.Tweener>(t:  748567952);
    }
    private void Lose()
    {
        this.pressing = true;
        this.stopAll = true;
        this.rb2D.bodyType = 2;
        if(this.destroyLine == true)
        {
                return;
        }
        
        R4.WithdrawHand(isDestroyLine:  true);
    }
    public void TriggerEnterEnemy(UnityEngine.Collider2D other)
    {
        if((other.CompareTag(tag:  -1610608497)) == false)
        {
                return;
        }
        
        this.DestroyHand();
    }
    public void DestroyHand()
    {
        if(this.destroyLine == true)
        {
                return;
        }
        
        GameTool.EventDispatcherExtension.PostEvent(sender:  R4, eventID:  5);
        R4.HideLine(hideHand:  false);
    }
    public void HideLine(bool hideHand = False)
    {
        this.stopAll = true;
        this.destroyLine = true;
        UnityEngine.Transform val_1 = this.transform;
        int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  749085584, complete:  false);
        UnityEngine.GameObject val_3 = this.handSprite.gameObject;
        this.handSprite.SetActive(value:  false);
        if(hideHand != false)
        {
                this.handInSkeleton.SetActive(value:  false);
            this.handFakeInSkeleton.SetActive(value:  false);
        }
        
        this.rope2D.rending = false;
        this.rope2D.rope.enabled = false;
        if(this.typeHand == 0)
        {
                22778964 = 22778960;
        }
        
        UnityEngine.GameObject val_4 = UnityEngine.GameObject.Find(name:  -1610611695);
        if((-1610611695) != 0)
        {
                UnityEngine.Object.Destroy(obj:  -1610611695);
        }
        
        UnityEngine.GameObject val_6 = this.gameObject;
        this.SetActive(value:  false);
    }
    public void ChangeStatusHand(StatusHand statusHand)
    {
        UnityEngine.SpriteRenderer val_2;
        UnityEngine.Sprite val_3;
        var val_5;
        if(statusHand > 3)
        {
                return;
        }
        
        var val_1 = 18121244 + (18121244 + (statusHand) << 2);
        if(statusHand == 3)
        {
                18121244 = 18121244;
            18121244 = 18121244;
            18121244 = 18121244 & ((IP) >> 32);
            18121244 = 18121244 & (((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        ));
        }
        
        val_2 = this.handSprite;
        val_3 = this.spriteHand_1;
        sprite = ;
        val_5 = 2;
        R4 + 28 + 28.sortingOrder = 2;
    }
    public void SetRenderLine(bool value)
    {
        this.rope2D.rending = value;
        this.rope2D.rope.enabled = value;
    }
    public void SetStopTargetHand(bool value)
    {
        this.stopAll = value;
        if(value == false)
        {
                return;
        }
        
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.rb2D.velocity = new UnityEngine.Vector2() {x = R6, y = R7};
        this.rb2D.bodyType = 2;
    }
    public HandTarget()
    {
        this.firstTarget = true;
        this.speed = 600f;
    }
    private void <OnEnable>b__20_0(UnityEngine.Component Comparer, object param)
    {
        var val_1;
        if(param != 0)
        {
                Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            if(null != 0)
        {
                val_1 = 1;
        }
        
        }
        else
        {
                val_1 = 1;
        }
        
        this.WithdrawHand(isDestroyLine:  true);
    }
    private void <OnEnable>b__20_1(UnityEngine.Component Comparer, object param)
    {
        this.Lose();
    }
    private void <OnDisable>b__21_0(UnityEngine.Component Comparer, object param)
    {
        var val_1;
        if(param != 0)
        {
                Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            if(null != 0)
        {
                val_1 = 1;
        }
        
        }
        else
        {
                val_1 = 1;
        }
        
        this.WithdrawHand(isDestroyLine:  true);
    }
    private void <OnDisable>b__21_1(UnityEngine.Component Comparer, object param)
    {
        this.Lose();
    }
    private void <HandMoveToTarget>b__38_0()
    {
        this.stopAll = false;
        this.rope2D.rending = false;
        this.rope2D.rope.enabled = false;
        if(this.callBackHandInTarget == 0)
        {
                return;
        }
        
        this.callBackHandInTarget.Invoke();
    }

}
