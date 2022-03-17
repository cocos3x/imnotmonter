using UnityEngine;
public class SawCutRope : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform[] movePoints;
    private int startPos;
    private float moveSpeed;
    private float rotateSpeed;
    private float rotateTarget;
    private bool canRotate;
    
    // Methods
    private void Start()
    {
        if(this.canRotate != false)
        {
                UnityEngine.Transform val_1 = this.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DORotate(target:  613184400, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = this.rotateTarget}, duration:  this.rotateSpeed, mode:  this.rotateSpeed);
            DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  613184400, loops:  0, loopType:  0);
            DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  613184400, ease:  1);
        }
        
        this.SetMove();
    }
    private void SetMove()
    {
        if(this == 0)
        {
                return;
        }
        
        if(this.startPos >= this)
        {
                this.startPos = 1152921509515262223;
        }
        
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Transform val_5 = this.movePoints[this.startPos];
        UnityEngine.Vector3 val_2 = position;
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOMove(target:  613447952, endValue:  new UnityEngine.Vector3(), duration:  val_2.x, snapping:  false);
        this.StartMoving(num:  this.startPos + 1);
    }
    private void StartMoving(int num)
    {
        var val_14;
        var val_15;
        UnityEngine.Transform val_16;
        var val_17;
        DG.Tweening.TweenCallback val_18;
        var val_19;
        SawCutRope.<>c__DisplayClass8_0 val_1 = 536900873;
        val_1 = new SawCutRope.<>c__DisplayClass8_0();
        if(val_1 != 0)
        {
                val_14 = val_1;
            mem[536900881] = num;
            mem[536900885] = this;
        }
        else
        {
                val_14 = 8;
            mem[8] = num;
            mem[12] = this;
        }
        
        if(val_14 < 12)
        {
                UnityEngine.Transform val_2 = this.transform;
            val_15 = this;
            val_16 = this.movePoints[mem[8]];
            UnityEngine.Vector3 val_3 = position;
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOMove(target:  613830288, endValue:  new UnityEngine.Vector3(), duration:  this.moveSpeed, snapping:  this.moveSpeed);
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetSpeedBased<DG.Tweening.Tweener>(t:  613830288);
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  613830288, ease:  1);
            val_17 = val_15;
            val_18 = 536895905;
            val_19 = 22774080;
        }
        else
        {
                mem[8] = 0;
            UnityEngine.Transform val_7 = this.transform;
            val_15 = this;
            val_16 = this.movePoints[mem[8]];
            UnityEngine.Vector3 val_8 = position;
            DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOMove(target:  613830288, endValue:  new UnityEngine.Vector3(), duration:  this.moveSpeed, snapping:  this.moveSpeed);
            DG.Tweening.Tweener val_10 = DG.Tweening.TweenSettingsExtensions.SetSpeedBased<DG.Tweening.Tweener>(t:  613830288);
            DG.Tweening.Tweener val_11 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  613830288, ease:  1);
            val_17 = val_15;
            val_18 = 536895905;
            val_19 = 22774084;
        }
        
        val_18 = new DG.Tweening.TweenCallback(object:  536900873, method:  new IntPtr(1610678585));
        DG.Tweening.Tweener val_13 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  613830288, action:  536895905);
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        var val_21;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.GameObject val_3 = collision.gameObject;
        val_21 = collision;
        bool val_4 = val_21.CompareTag(tag:  -1610607703);
        if((-1073701079.CanCheck()) == false)
        {
            goto label_4;
        }
        
        if(val_4 != false)
        {
                val_21 = 22742212;
            WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266339].Dead();
            WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead(huggyDeadType:  1);
            WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701079.Lose();
        }
        
        UnityEngine.GameObject val_8 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610605337)) == false)
        {
            goto label_23;
        }
        
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266339].Dead();
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701079.Lose();
        goto label_23;
        label_4:
        if(val_4 != false)
        {
                WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead(huggyDeadType:  1);
        }
        
        UnityEngine.GameObject val_13 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610605337)) != false)
        {
                WorldTimeAPI val_15 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266339].Dead();
        }
        
        label_23:
        UnityEngine.GameObject val_16 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610608497)) == false)
        {
                return;
        }
        
        UnityEngine.Transform val_18 = collision.GetComponent<UnityEngine.Transform>();
        collision.Dead(enemyDeadBy:  0);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_20 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609911, volume:  null);
    }
    public SawCutRope()
    {
        this.canRotate = true;
        this.rotateTarget = 360f;
    }

}
