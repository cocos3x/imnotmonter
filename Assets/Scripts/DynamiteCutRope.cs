using UnityEngine;
public class DynamiteCutRope : MonoBehaviour
{
    // Fields
    private UnityEngine.Rigidbody2D myBody;
    private UnityEngine.LayerMask detonateLayerMask;
    private float radius;
    private bool isFalling;
    public bool isBooming;
    private float pushForce;
    
    // Methods
    private void FixedUpdate()
    {
        this.CheckFalling();
    }
    public void Detonate()
    {
        float val_3;
        float val_4;
        float val_20;
        DynamiteCutRope val_46;
        float val_47;
        float val_48;
        float val_49;
        var val_50;
        var val_51;
        val_46 = this;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = position;
        val_48 = val_4;
        val_49 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.detonateLayerMask});
        UnityEngine.Collider2D[] val_6 = UnityEngine.Physics2D.OverlapCircleAll(point:  new UnityEngine.Vector2() {x = val_3, y = val_48}, radius:  val_2.x, layerMask:  this.radius);
        val_50 = val_3;
        if((val_3 + 12) >= 1)
        {
                var val_7 = val_50 + 16;
            do
        {
            val_49 = mem[(val_3 + 16) + 0];
            val_49 = (val_3 + 16) + 0;
            if((val_49.CompareTag(tag:  -1610605337)) != false)
        {
                WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266339].Dead();
            WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701079.Lose();
        }
        
            if((val_49.CompareTag(tag:  -1610607703)) != false)
        {
                WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead(huggyDeadType:  2);
        }
        
            if((val_49.CompareTag(tag:  -1610608497)) != false)
        {
                UnityEngine.Transform val_14 = val_49.GetComponent<UnityEngine.Transform>();
            val_49.Dead(enemyDeadBy:  1);
        }
        
            if((val_49.CompareTag(tag:  -1610602529)) != false)
        {
                if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_17 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            UnityEngine.Transform val_18 = val_49.transform;
            UnityEngine.Vector3 val_19 = position;
            UnityEngine.GameObject val_21 = -1073701087.GetItem(key:  -1610604487, position:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_20});
            WorldTimeAPI val_22 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701087.Despaw(go:  -1073701087, delay:  val_19.x);
            val_50 = val_50;
            val_46 = val_46;
        }
        
            UnityEngine.GameObject val_23 = val_49.gameObject;
            val_49.SetActive(value:  false);
        }
        
            if((val_49.CompareTag(tag:  -1610605165)) != false)
        {
                UnityEngine.Transform val_25 = this.transform;
            UnityEngine.Vector3 val_26 = position;
            UnityEngine.Vector2 val_27 = ClosestPoint(position:  new UnityEngine.Vector2() {x = val_49, y = val_3});
            UnityEngine.Transform val_28 = this.transform;
            UnityEngine.Vector3 val_29 = position;
            float val_46 = val_3;
            float val_47 = val_4;
            val_46 = val_3 - val_46;
            val_47 = val_4 - val_47;
            UnityEngine.Vector2 val_30 = normalized;
            UnityEngine.Transform val_31 = val_49.GetComponent<UnityEngine.Transform>();
            val_47 = val_3 * mem[1152921509497338668];
            val_49.AddForce(force:  new UnityEngine.Vector2() {x = val_47, y = val_4 * mem[1152921509497338668]}, mode:  1);
        }
        
            if((val_49.CompareTag(tag:  -1610609921)) != false)
        {
                UnityEngine.Transform val_34 = val_49.GetComponent<UnityEngine.Transform>();
            if(((val_3 + 16) + 0 + 25) == 0)
        {
                UnityEngine.Transform val_35 = val_49.GetComponent<UnityEngine.Transform>();
            mem2[0] = 1;
            UnityEngine.Transform val_36 = val_49.GetComponent<UnityEngine.Transform>();
        }
        
        }
        
            val_51 = 0 + 1;
        }
        while(val_51 < (val_3 + 12));
        
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                val_50 = 22742080;
            WorldTimeAPI val_38 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            UnityEngine.Transform val_39 = this.transform;
            val_51 = 0;
            UnityEngine.Vector3 val_40 = position;
            val_48 = val_3;
            val_49 = val_4;
            UnityEngine.GameObject val_41 = -1073701087.GetItem(key:  -1610608315, position:  new UnityEngine.Vector3() {x = val_48, y = val_49, z = val_20});
            WorldTimeAPI val_42 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701087.Despaw(go:  -1073701087, delay:  val_40.x);
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_44 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610608315, volume:  val_40.x);
        }
        
        UnityEngine.GameObject val_45 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void CheckFalling()
    {
        UnityEngine.Vector2 val_1 = velocity;
        if(this.myBody <= 0)
        {
                0 = 1;
        }
        
        this.isFalling = true;
    }
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if(this.isFalling == false)
        {
                return;
        }
        
        this.Detonate();
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if((collision.CompareTag(tag:  -1610605337)) != true)
        {
                if((collision.CompareTag(tag:  -1610608497)) != true)
        {
                if((collision.CompareTag(tag:  -1610607703)) == false)
        {
                return;
        }
        
        }
        
        }
        
        this.Detonate();
    }
    public DynamiteCutRope()
    {
        this.pushForce = 3f;
        this.radius = 1f;
    }

}
