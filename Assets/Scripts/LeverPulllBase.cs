using UnityEngine;
public class LeverPulllBase : MonoBehaviour
{
    // Fields
    protected UnityEngine.GameObject leverHandleObject;
    private PlatformMoveController moveController;
    private UnityEngine.BoxCollider2D myCollider;
    protected UnityEngine.HingeJoint2D hinge;
    public float speedRotate;
    protected UnityEngine.Vector3 rotateLeft;
    protected UnityEngine.Vector3 rotateRight;
    protected bool isRight;
    protected bool isPress;
    protected bool isRotating;
    
    // Methods
    protected void SetupStartRotate()
    {
        float val_8;
        float val_9;
        float val_10;
        float val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_12 = mem[536891407];
        val_12 = val_12 & 512;
        if(this.isRight != false)
        {
                val_12 = 0;
            if(this.hinge != 0)
        {
                UnityEngine.JointAngleLimits2D val_2 = 0.limits;
            0.min = val_2.m_LowerAngle;
            0.max = val_2.m_LowerAngle;
            val_12 = 0;
            this.hinge.limits = new UnityEngine.JointAngleLimits2D() {m_LowerAngle = 0f, m_UpperAngle = 0f};
        }
        
            val_13 = 0;
            UnityEngine.Transform val_3 = this.leverHandleObject.transform;
            val_14 = this.leverHandleObject;
        }
        else
        {
                val_12 = 0;
            if(this.hinge != 0)
        {
                UnityEngine.JointAngleLimits2D val_5 = 0.limits;
            0.min = val_5.m_LowerAngle;
            0.max = val_5.m_LowerAngle;
            val_12 = 0;
            this.hinge.limits = new UnityEngine.JointAngleLimits2D() {m_LowerAngle = 0f, m_UpperAngle = 0f};
        }
        
            val_13 = 0;
            UnityEngine.Transform val_6 = this.leverHandleObject.transform;
            val_14 = this.leverHandleObject;
        }
        
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 3.863889E-16f, y = mem[this.rotateLeft + (0)], z = mem[this.rotateLeft + (4)]});
        val_14.rotation = new UnityEngine.Quaternion() {x = val_8, y = val_9, z = val_10, w = val_11};
    }
    public void PressRotate()
    {
        float val_5;
        DG.Tweening.Tweener val_15;
        DG.Tweening.TweenCallback val_16;
        var val_17;
        UnityEngine.Transform val_1 = this.leverHandleObject.transform;
        int val_2 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.leverHandleObject, complete:  false);
        UnityEngine.Transform val_3 = this.leverHandleObject.transform;
        if(this.isRight != false)
        {
                UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 3.903299E-16f, y = mem[this.rotateRight + (0)], z = mem[this.rotateRight + (4)]});
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DORotateQuaternion(target:  this.leverHandleObject, endValue:  new UnityEngine.Quaternion() {w = val_5}, duration:  this.speedRotate);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetSpeedBased<DG.Tweening.Tweener>(t:  this.leverHandleObject, isSpeedBased:  true);
            DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.leverHandleObject, ease:  1);
            val_15 = this.leverHandleObject;
            val_16 = 536895905;
            val_17 = 22762064;
        }
        else
        {
                UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 3.903299E-16f, y = mem[this.rotateLeft + (0)], z = mem[this.rotateLeft + (4)]});
            DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions.DORotateQuaternion(target:  this.leverHandleObject, endValue:  new UnityEngine.Quaternion() {w = val_5}, duration:  this.speedRotate);
            DG.Tweening.Tweener val_11 = DG.Tweening.TweenSettingsExtensions.SetSpeedBased<DG.Tweening.Tweener>(t:  this.leverHandleObject, isSpeedBased:  true);
            DG.Tweening.Tweener val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.leverHandleObject, ease:  1);
            val_15 = this.leverHandleObject;
            val_16 = 536895905;
            val_17 = 22762068;
        }
        
        val_16 = new DG.Tweening.TweenCallback(object:  635515280, method:  new IntPtr(1610678951));
        DG.Tweening.Tweener val_14 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  val_15, action:  536895905);
    }
    public void Press()
    {
        if(this.isRotating != false)
        {
                return;
        }
        
        bool val_4 = this.isPress;
        this.isRotating = true;
        val_4 = val_4 ^ 1;
        this.isPress = val_4;
        this.isRight = this.isRight ^ 1;
        this.myCollider.enabled = false;
        this.PressRotate();
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610605253, volume:  null);
    }
    private void MovePlatform()
    {
        this.moveController.MoveByScriptActivated();
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        this.Press();
    }
    public LeverPulllBase()
    {
        mem[1152921509537810368] = 0;
        mem[1152921509537810372] = 3253731328;
    }
    private void <PressRotate>b__11_0()
    {
        this.isRotating = false;
        this.moveController.MoveByScriptActivated();
    }
    private void <PressRotate>b__11_1()
    {
        this.isRotating = false;
        this.moveController.MoveByScriptActivated();
    }

}
