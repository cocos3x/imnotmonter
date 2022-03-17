using UnityEngine;
public class DynamitePinPullController : MonoBehaviour
{
    // Fields
    private UnityEngine.Rigidbody2D myBody;
    private UnityEngine.BoxCollider2D myCollider;
    private UnityEngine.LayerMask detonateLayerMask;
    private float radius;
    private bool isFalling;
    
    // Methods
    private void FixedUpdate()
    {
        this.CheckFalling();
    }
    private void Detonate()
    {
        float val_3;
        float val_4;
        float val_36;
        var val_44;
        float val_45;
        float val_46;
        var val_47;
        float val_48;
        var val_50;
        val_44 = this;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = position;
        val_46 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.detonateLayerMask});
        UnityEngine.Collider2D[] val_6 = UnityEngine.Physics2D.OverlapCircleAll(point:  new UnityEngine.Vector2() {x = val_3, y = val_4}, radius:  val_2.x, layerMask:  this.radius);
        val_47 = val_3;
        if((val_3 + 12) >= 1)
        {
                val_48 = val_47 + 16;
            do
        {
            val_46 = mem[(val_3 + 16) + 0];
            val_46 = (val_3 + 16) + 0;
            if((val_46.CompareTag(tag:  -1610605337)) != false)
        {
                WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266323].Dead();
            WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701037.Lose();
        }
        
            if((val_46.CompareTag(tag:  -1610607699)) != false)
        {
                WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead();
            WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701037.Lose();
        }
        
            if((val_46.CompareTag(tag:  -1610608497)) != false)
        {
                UnityEngine.Transform val_14 = val_46.GetComponent<UnityEngine.Transform>();
            if(val_46 != 0)
        {
                mem2[0] = 4;
        }
        else
        {
                mem[68] = 4;
        }
        
            val_46.Dead();
        }
        
            if((val_46.CompareTag(tag:  -1610602529)) != false)
        {
                if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_17 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            UnityEngine.Transform val_18 = val_46.transform;
            UnityEngine.Vector3 val_19 = position;
            UnityEngine.GameObject val_20 = -1073701087.GetItem(key:  -1610604487, position:  new UnityEngine.Vector3() {x = R5, y = R8, z = ???});
            WorldTimeAPI val_21 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701087.Despaw(go:  -1073701087, delay:  val_19.x);
            val_44 = val_44;
            val_47 = val_47;
            val_48 = val_48;
        }
        
            UnityEngine.GameObject val_22 = val_46.gameObject;
            val_46.SetActive(value:  false);
        }
        
            if((val_46.CompareTag(tag:  -1610605165)) != false)
        {
                UnityEngine.Transform val_24 = this.transform;
            UnityEngine.Vector3 val_25 = position;
            UnityEngine.Vector2 val_26 = ClosestPoint(position:  new UnityEngine.Vector2() {x = val_46, y = val_3});
            val_44 = val_44;
            UnityEngine.Transform val_27 = this.transform;
            UnityEngine.Vector3 val_28 = position;
            float val_42 = val_3;
            float val_43 = val_4;
            val_42 = val_3 - val_42;
            val_43 = val_4 - val_43;
            UnityEngine.Vector2 val_29 = normalized;
            UnityEngine.Transform val_30 = val_46.GetComponent<UnityEngine.Transform>();
            val_45 = val_4 * 10f;
            val_47 = val_47;
            val_46 = val_3 * 10f;
            val_46.AddForce(force:  new UnityEngine.Vector2() {x = val_46, y = val_45}, mode:  1);
        }
        
            val_50 = 0 + 1;
        }
        while(val_50 < (val_3 + 12));
        
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                val_47 = 22742080;
            WorldTimeAPI val_33 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_48 = -1073701087;
            UnityEngine.Transform val_34 = this.transform;
            val_50 = 0;
            UnityEngine.Vector3 val_35 = position;
            val_46 = val_36;
            UnityEngine.GameObject val_37 = val_48.GetItem(key:  -1610608315, position:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_46});
            WorldTimeAPI val_38 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701087.Despaw(go:  -1073701087, delay:  val_35.x);
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_40 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610608315, volume:  val_35.x);
        }
        
        UnityEngine.GameObject val_41 = this.gameObject;
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
                if((collision.CompareTag(tag:  -1610607699)) == false)
        {
                return;
        }
        
        }
        
        }
        
        this.Detonate();
    }
    public DynamitePinPullController()
    {
        this.radius = 1f;
    }

}
