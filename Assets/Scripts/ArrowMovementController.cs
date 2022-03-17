using UnityEngine;
public class ArrowMovementController : MonoBehaviour
{
    // Fields
    private PlatformMoveController platformMoveController;
    private Arrow arrow;
    private UnityEngine.Transform arrowStartPos;
    private UnityEngine.Transform arrowCheckPos;
    private Spine.Unity.SkeletonAnimation arrowSkeleton;
    private UnityEngine.GameObject arrowPrefab;
    private string currentAnimationState;
    protected UnityEngine.LayerMask raycastLayer;
    private float findDistance;
    private bool isRaycast;
    private float delayTime;
    
    // Methods
    private void Start()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.arrowSkeleton)) == false)
        {
                return;
        }
        
        this.SetAnimation(name:  -1610600013, loop:  true, timeScale:  null, _callBack:  1065353216);
    }
    private void Update()
    {
        this.FindTarget();
    }
    private void FindTarget()
    {
        var val_3;
        float val_8;
        float val_9;
        float val_28;
        int val_38;
        float val_39;
        float val_40;
        float val_41;
        float val_55;
        float val_56;
        var val_57;
        var val_58;
        float val_59;
        var val_60;
        float val_61;
        float val_62;
        if(this.isRaycast == false)
        {
                return;
        }
        
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = eulerAngles;
        var val_55 = val_3;
        val_55 = val_55 + 90f;
        val_55 = val_55 * 0.01745329f;
        UnityEngine.Transform val_4 = this.transform;
        UnityEngine.Vector3 val_5 = eulerAngles;
        var val_56 = val_3;
        val_56 = val_56 + 90f;
        val_56 = val_56 * 0.01745329f;
        UnityEngine.Transform val_6 = this.transform;
        UnityEngine.Vector3 val_7 = position;
        val_55 = val_8;
        val_56 = val_9;
        float val_58 = 0.12f;
        var val_57 = val_55;
        if((UnityEngine.Object.op_Implicit(exists:  this.arrowSkeleton)) != false)
        {
                UnityEngine.Vector3 val_11 = position;
            val_55 = val_8;
            val_56 = val_9;
        }
        
        val_57 = val_57 * val_58;
        val_58 = val_56 * val_58;
        val_56 = val_58 + val_56;
        val_55 = val_57 + val_55;
        UnityEngine.Transform val_13 = this.transform;
        val_57 = this;
        if((UnityEngine.Object.op_Implicit(exists:  this.arrowSkeleton)) == false)
        {
            goto label_12;
        }
        
        UnityEngine.Vector3 val_14 = right;
        UnityEngine.Transform val_15 = this.transform;
        UnityEngine.Vector3 val_16 = localScale;
        float val_59 = val_8;
        val_59 = val_8 * val_59;
        int val_18 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.raycastLayer});
        UnityEngine.RaycastHit2D val_19 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = 9.501058E-16f, y = val_55}, direction:  new UnityEngine.Vector2() {x = val_56, y = val_59}, distance:  val_59, layerMask:  val_9 * val_59);
        UnityEngine.Transform val_20 = this.transform;
        UnityEngine.Vector3 val_21 = right;
        UnityEngine.Transform val_22 = this.transform;
        UnityEngine.Vector3 val_23 = localScale;
        UnityEngine.Color val_24 = UnityEngine.Color.blue;
        float val_25 = val_3 * val_8;
        float val_26 = val_9 * val_8;
        float val_27 = val_8 * val_8;
        val_58 = val_3;
        val_59 = val_28;
        val_25 = val_25 * this.findDistance;
        val_26 = val_26 * this.findDistance;
        val_27 = val_27 * this.findDistance;
        val_60 = val_25;
        val_61 = val_27;
        if(((mem[536885944] & true) != 0) || (mem[536885873] != 0))
        {
            goto label_20;
        }
        
        val_58 = val_58;
        goto label_20;
        label_12:
        UnityEngine.Vector3 val_29 = up;
        int val_30 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.raycastLayer});
        UnityEngine.RaycastHit2D val_31 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = 9.501058E-16f, y = val_55}, direction:  new UnityEngine.Vector2() {x = val_56, y = val_8}, distance:  val_29.x, layerMask:  val_9);
        UnityEngine.Transform val_32 = this.transform;
        UnityEngine.Vector3 val_33 = up;
        UnityEngine.Color val_34 = UnityEngine.Color.blue;
        val_59 = val_28;
        val_61 = val_8 * this.findDistance;
        if(((mem[536885944] & true) == 0) && (mem[536885873] == 0))
        {
                val_62 = ???;
        }
        
        label_20:
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_55, y = val_56, z = 0f}, dir:  new UnityEngine.Vector3() {x = val_61, y = val_9 * this.findDistance, z = val_3 * this.findDistance}, color:  new UnityEngine.Color() {r = val_62, a = val_59});
        if((UnityEngine.RaycastHit2D.op_Implicit(hit:  new UnityEngine.RaycastHit2D() {m_Centroid = new UnityEngine.Vector2() {x = 0f}, m_Point = new UnityEngine.Vector2(), m_Normal = new UnityEngine.Vector2() {x = ???, y = val_41}, m_Distance = val_39, m_Fraction = val_40, m_Collider = val_38})) == false)
        {
                return;
        }
        
        UnityEngine.Collider2D val_43 = 0.collider;
        UnityEngine.GameObject val_44 = 0.gameObject;
        if((0.CompareTag(tag:  -1610605337)) != true)
        {
                UnityEngine.Collider2D val_46 = 0.collider;
            UnityEngine.GameObject val_47 = 0.gameObject;
            if((0.CompareTag(tag:  -1610608497)) != true)
        {
                UnityEngine.Collider2D val_49 = 0.collider;
            UnityEngine.GameObject val_50 = 0.gameObject;
            if((0.CompareTag(tag:  -1610607699)) != true)
        {
                UnityEngine.Collider2D val_52 = 0.collider;
            UnityEngine.GameObject val_53 = 0.gameObject;
            if((0.CompareTag(tag:  -1610607703)) == false)
        {
                return;
        }
        
        }
        
        }
        
        }
        
        this.isRaycast = false;
        this.ShootArrow();
    }
    private void ShootArrow()
    {
        bool val_1 = UnityEngine.Object.op_Implicit(exists:  this.platformMoveController);
        this.Invoke(methodName:  -1610608785, time:  null);
    }
    private void DelayShoot()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.arrow)) != false)
        {
                this.arrow.ForceWithDirection();
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.arrowStartPos)) == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.arrowSkeleton)) == false)
        {
                return;
        }
        
        536882991 = new System.Action(object:  646788880, method:  new IntPtr(1610679135));
        this.SetAnimation(name:  -1610601669, loop:  false, timeScale:  null, _callBack:  1073741824);
    }
    public void SetAnimation(string name, bool loop, float timeScale = 1, System.Action _callBack)
    {
        var val_1;
        AnimationState.TrackEntryDelegate val_8;
        var val_9;
        var val_10;
        bool val_11;
        ArrowMovementController.<>c__DisplayClass16_0 val_2 = 536898001;
        val_2 = new ArrowMovementController.<>c__DisplayClass16_0();
        val_8 = val_2;
        mem[536898009] = val_1;
        if((System.String.op_Equality(a:  name, b:  this.currentAnimationState)) != false)
        {
                return;
        }
        
        Spine.Animation val_4 = _callBack.FindAnimation(animationName:  name);
        if(_callBack != 0)
        {
                val_10 = 0;
            Spine.AnimationState val_5 = this.arrowSkeleton.AnimationState;
            val_11 = loop;
            Spine.TrackEntry val_6 = this.arrowSkeleton.SetAnimation(trackIndex:  0, animationName:  name, loop:  val_11);
            val_9 = this.arrowSkeleton;
            mem2[0] = _callBack;
            if(mem[536898009] != 0)
        {
                val_8 = 536897929;
            val_11 = 0;
            val_8 = new AnimationState.TrackEntryDelegate(object:  536898001, method:  new IntPtr(1610679139));
            val_9.add_Complete(value:  536897929);
        }
        
        }
        
        this.currentAnimationState = name;
    }
    public ArrowMovementController()
    {
        this.isRaycast = true;
        this.findDistance = 20f;
        this.delayTime = 0.1f;
    }
    private void <DelayShoot>b__15_0()
    {
        float val_3;
        float val_13;
        float val_17;
        var val_21;
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  this.arrowPrefab, position:  new UnityEngine.Vector3() {x = R6, y = R7, z = SL}, rotation:  new UnityEngine.Quaternion() {x = val_3});
        if(this.arrowPrefab != 0)
        {
                UnityEngine.Transform val_5 = this.arrowPrefab.transform;
            val_21 = this.arrowPrefab;
        }
        else
        {
                UnityEngine.Transform val_6 = this.arrowPrefab.transform;
            val_21 = this.arrowPrefab;
        }
        
        UnityEngine.Transform val_7 = this.arrowPrefab.transform;
        UnityEngine.Vector3 val_8 = localScale;
        UnityEngine.Transform val_9 = this.transform;
        UnityEngine.Vector3 val_10 = localScale;
        UnityEngine.Transform val_11 = this.arrowPrefab.transform;
        UnityEngine.Vector3 val_12 = localScale;
        UnityEngine.Transform val_14 = this.arrowPrefab.transform;
        UnityEngine.Vector3 val_15 = localScale;
        val_21.localScale = new UnityEngine.Vector3() {x = val_3 * val_3, y = val_13, z = val_17};
        Weight val_18 = this.arrowPrefab.GetComponent<Weight>();
        UnityEngine.Transform val_19 = this.transform;
        UnityEngine.Vector3 val_20 = localScale;
        this.arrowPrefab.ForceWithDirection(dir:  (int)val_3);
    }

}
