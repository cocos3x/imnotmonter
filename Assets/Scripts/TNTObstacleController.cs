using UnityEngine;
public class TNTObstacleController : ObstacleBase
{
    // Fields
    private UnityEngine.BoxCollider2D colliderr;
    public float radius;
    public float force;
    
    // Methods
    protected override void SetUpStart()
    {
        this.SetUpStart();
    }
    public override void DestroyWithLaser()
    {
        this.Detonate(time:  null);
    }
    public override void DestroyObject()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    public void Detonate(float time)
    {
        if(true == 0)
        {
                return;
        }
        
        mem[1152921509598785448] = 0;
        this.Invoke(methodName:  -1610603441, time:  time);
    }
    private void TimeSetStatusDetonate()
    {
        float val_3;
        float val_4;
        TNTObstacleController val_33;
        float val_34;
        var val_35;
        UnityEngine.Object val_36;
        var val_37;
        val_33 = this;
        mem[1152921509598897448] = 0;
        this.DetonateVFX();
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = position;
        val_34 = val_4;
        float val_33 = val_3;
        UnityEngine.Collider2D[] val_5 = UnityEngine.Physics2D.OverlapCircleAll(point:  new UnityEngine.Vector2() {x = val_33, y = val_34}, radius:  val_2.x);
        val_33 = val_33 + 16;
        val_35 = 0;
        goto label_4;
        label_36:
        val_36 = mem[(val_3 + 16) + 0];
        val_36 = (val_3 + 16) + 0;
        UnityEngine.GameObject val_6 = val_36.gameObject;
        val_34 = val_36;
        UnityEngine.GameObject val_7 = this.gameObject;
        if(val_34 == 697083152)
        {
            goto label_31;
        }
        
        if(val_36 == 0)
        {
            goto label_10;
        }
        
        if((val_36.CompareTag(tag:  -1610605795)) == false)
        {
            goto label_11;
        }
        
        label_16:
        UnityEngine.GameObject val_10 = val_36.gameObject;
        Weight val_11 = val_36.GetComponent<Weight>();
        val_34 = val_36;
        if((((val_3 + 16) + 0 + 12) - 2) >= 3)
        {
            goto label_14;
        }
        
        goto label_31;
        label_10:
        if((val_36.CompareTag(tag:  -1610605795)) == true)
        {
            goto label_16;
        }
        
        label_11:
        UnityEngine.Transform val_14 = val_36.GetComponent<UnityEngine.Transform>();
        if(val_36 == 0)
        {
            goto label_31;
        }
        
        UnityEngine.Transform val_16 = val_36.GetComponent<UnityEngine.Transform>();
        UnityEngine.Transform val_17 = this.transform;
        UnityEngine.Vector3 val_18 = position;
        val_34 = val_4;
        UnityEngine.Vector2 val_19 = ClosestPoint(position:  new UnityEngine.Vector2() {x = val_36, y = val_3});
        UnityEngine.Transform val_20 = this.transform;
        UnityEngine.Vector3 val_21 = position;
        float val_34 = val_3;
        float val_35 = val_4;
        val_34 = val_3 - val_34;
        val_35 = val_4 - val_35;
        UnityEngine.Vector2 val_22 = normalized;
        val_36 = val_36;
        var val_37 = val_3;
        var val_36 = val_4;
        UnityEngine.RigidbodyType2D val_23 = val_36.bodyType;
        val_33 = val_33;
        if(val_36 != 0)
        {
            goto label_31;
        }
        
        val_36 = val_36 * mem[1152921509598897488];
        val_37 = val_37 * mem[1152921509598897488];
        float val_24 = mem[1152921509598897444].mass;
        float val_38 = mem[1152921509598897444];
        val_37 = 0;
        val_38 = val_37 * val_38;
        val_34 = val_38;
        if(val_36 == 0)
        {
                val_37 = 0;
        }
        
        val_36.AddForce(force:  new UnityEngine.Vector2() {x = val_34, y = val_36 * val_38}, mode:  1);
        goto label_31;
        label_14:
        if(((val_3 + 16) + 0 + 12) == 1)
        {
                UnityEngine.Transform val_26 = val_34.GetComponent<UnityEngine.Transform>();
            val_34.Detonate(time:  val_2.x);
        }
        else
        {
                UnityEngine.Transform val_27 = this.transform;
            UnityEngine.Vector3 val_28 = position;
            UnityEngine.Vector2 val_29 = ClosestPoint(position:  new UnityEngine.Vector2() {x = val_36, y = val_3});
            val_36 = val_33;
            UnityEngine.Transform val_30 = this.transform;
            UnityEngine.Vector3 val_31 = position;
            float val_39 = val_3;
            float val_40 = val_4;
            val_39 = val_3 - val_39;
            val_40 = val_4 - val_40;
            UnityEngine.Vector2 val_32 = normalized;
            val_34.ForceWithTNTDirection(direction:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = 0f}, forceValue:  mem[1152921509598897488]);
            val_33 = val_36;
        }
        
        label_31:
        val_35 = 1;
        label_4:
        if(val_35 < (val_3 + 12))
        {
            goto label_36;
        }
    
    }
    private void DetonateVFX()
    {
        float val_7;
        float val_8;
        float val_9;
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            UnityEngine.GameObject val_3 = -1073701087.GetItem(itemType:  -1610602869);
            UnityEngine.Transform val_4 = -1073701087.transform;
            UnityEngine.Transform val_5 = this.transform;
            UnityEngine.Vector3 val_6 = position;
            -1073701087.position = new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9};
            WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701087.Despaw(go:  -1073701087, delay:  val_6.x);
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610608315, volume:  val_6.x);
    }
    public override void FallWithHang()
    {
    
    }
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if(collision == 0)
        {
                return;
        }
        
        this.Detonate(time:  null);
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
    
    }
    public TNTObstacleController()
    {
    
    }

}
