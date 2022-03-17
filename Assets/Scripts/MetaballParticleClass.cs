using UnityEngine;
public class MetaballParticleClass : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject MObject;
    public float LifeTime;
    public Water2D.Water2D_Spawner SpawnerParent;
    public bool witinTarget;
    public UnityEngine.Vector2 Editor_Velocity;
    public UnityEngine.Vector2 Velocity_Limiter_X;
    public UnityEngine.Vector2 Velocity_Limiter_Y;
    public bool ScaleDown;
    public float endSize;
    public bool BlendingColor;
    private bool _active;
    private float delta;
    private UnityEngine.Rigidbody2D rb;
    private UnityEngine.CircleCollider2D cc;
    private UnityEngine.TrailRenderer tr;
    private UnityEngine.SpriteRenderer sr;
    private UnityEngine.Collider2D[] Contacts;
    private float deltaSimul;
    private float fixedDeltaSimul;
    private float wakeUpTime;
    private UnityEngine.Vector3 pos_aux;
    private bool ScaleDownIsPerforming;
    private UnityEngine.Vector2 deltaScale;
    private UnityEngine.Vector2 initScale;
    private UnityEngine.Vector2 tmpScale;
    private int breathFrames;
    private int framesCount;
    
    // Properties
    public bool Active { get; set; }
    
    // Methods
    public bool get_Active()
    {
        return (bool)this._active;
    }
    public void set_Active(bool value)
    {
        float val_7;
        var val_8;
        float val_9;
        UnityEngine.GameObject val_10;
        Water2D.Water2D_Spawner val_11;
        this._active = value;
        val_9 = 22713552;
        val_10 = this.MObject;
        if((UnityEngine.Object.op_Implicit(exists:  val_10)) != false)
        {
                this.MObject.SetActive(value:  value);
            val_10 = this.tr;
            if((UnityEngine.Object.op_Implicit(exists:  val_10)) != false)
        {
                val_10 = this.tr;
            val_10.Clear();
        }
        
        }
        
        if(value != false)
        {
                float val_9 = 0f;
            val_9 = this.delta * val_9;
            this.delta = val_9;
            float val_3 = UnityEngine.Time.time;
            this.wakeUpTime = 0f;
        }
        else
        {
                if((UnityEngine.Object.op_Implicit(exists:  this.SpawnerParent)) != false)
        {
                val_11 = this.SpawnerParent;
            if(val_11 != 0)
        {
                val_10 = this.SpawnerParent.DropsUsed;
        }
        else
        {
                val_11 = 244;
            val_10 = 1879048193;
        }
        
            mem[244] = 1879048192;
        }
        
            if(this.rb != 0)
        {
                UnityEngine.Vector2 val_6 = velocity;
            float val_11 = 0f;
            float val_10 = val_7;
            val_10 = val_10 * val_11;
            val_11 = val_8 * val_11;
            val_10 = val_10;
            val_9 = val_11;
            this.rb.velocity = new UnityEngine.Vector2() {x = val_9, y = val_10};
        }
        
            float val_12 = 0f;
            val_12 = this.delta * val_12;
            this.delta = val_12;
        }
        
        this.ScaleDownIsPerforming = false;
    }
    private void OnEnable()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.SpawnerParent)) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.gameObject;
        string val_3 = this.SpawnerParent.name;
        string val_4 = this.SpawnerParent.DropsUsed.ToString();
        string val_5 = this.SpawnerParent + -1610602177(-1610602177) + this.SpawnerParent.DropsUsed;
        this.name = this.SpawnerParent;
    }
    private void OnDisable()
    {
    
    }
    private void Start()
    {
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        this.rb = this;
        UnityEngine.Transform val_2 = this.GetComponent<UnityEngine.Transform>();
        this.tr = this;
        UnityEngine.Transform val_3 = this.GetComponent<UnityEngine.Transform>();
        this.cc = this;
        UnityEngine.Transform val_4 = this.GetComponent<UnityEngine.Transform>();
        this.sr = this;
        this.Contacts = 536881819;
    }
    private void Update()
    {
        if(this._active == false)
        {
                return;
        }
        
        if(this.ScaleDown != false)
        {
                if(this.ScaleDownIsPerforming == false)
        {
                this.ScaleDownIsPerforming = true;
            this.ScaleDownIsPerforming = this.ScaleDownIsPerforming;
        }
        
            this.ScaleDownPerform();
        }
        
        this.VelocityLimiter();
        if(this.BlendingColor == true)
        {
                this.BlendingColor = this;
            this.Blend();
        }
        
        if(this.SpawnerParent.Water2DEmissionType == 1)
        {
                return;
        }
        
        if(this.SpawnerParent.Water2DEmissionType < 0)
        {
                return;
        }
        
        if(this.SpawnerParent.Water2DEmissionType > 1)
        {
                float val_3 = 0f;
            val_3 = this.delta * val_3;
            this.delta = val_3;
            this.Active = false;
        }
        else
        {
                float val_1 = UnityEngine.Time.deltaTime;
            uint val_4 = 0;
            val_4 = this.delta + val_4;
            this.delta = val_4;
        }
        
        if(this.SpawnerParent.Water2DEmissionType > 1)
        {
                float val_5 = 0f;
            val_5 = this.deltaSimul * val_5;
            this.deltaSimul = val_5;
            this.OnCollisionEnter2DEditor();
            return;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        uint val_6 = 0;
        val_6 = this.deltaSimul + val_6;
        this.deltaSimul = val_6;
    }
    private void AnimInEditor()
    {
        float val_2;
        UnityEngine.Vector3 val_3;
        UnityEngine.Vector2 val_1 = UnityEngine.Physics2D.gravity;
        this.Editor_Velocity = this.Editor_Velocity;
        mem[1152921509766053936] = R7;
        UnityEngine.Transform val_4 = this.transform;
        UnityEngine.Vector3 val_5 = position;
        UnityEngine.Vector3 val_7 = val_3;
        float val_8 = val_2;
        val_7 = val_7 + this.Editor_Velocity;
        mem[1152921509766054012] = 0;
        val_8 = val_8 + mem[1152921509766053936];
        this.pos_aux = val_7;
        mem[1152921509766054008] = val_8;
        UnityEngine.Transform val_6 = this.transform;
        this.position = new UnityEngine.Vector3() {x = this.pos_aux, y = R7, z = 6.111816E-08f};
    }
    private void VelocityLimiter()
    {
        if(this.rb == 0)
        {
                return;
        }
        
        UnityEngine.Vector2 val_2 = velocity;
        UnityEngine.Vector2 val_3 = velocity;
        if(this.rb < 0)
        {
                this.Velocity_Limiter_Y = S6;
        }
        
        if(this.rb < 0)
        {
                this.Velocity_Limiter_X = S2;
        }
        
        this.rb.velocity = new UnityEngine.Vector2() {x = this.Velocity_Limiter_X, y = this.Velocity_Limiter_Y};
    }
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.ContactPoint2D[] val_2 = collision.contacts;
        UnityEngine.Collider2D val_3 = collision.m_Rigidbody.collider;
        UnityEngine.GameObject val_4 = collision.m_Rigidbody.gameObject;
        this.SpawnerParent.InvokeOnCollisionEnter2D(obj:  864504592, other:  collision.m_Rigidbody);
    }
    private void OnCollisionEnter2DEditor()
    {
        float val_4;
        float val_5;
        float val_14;
        UnityEngine.Collider2D[] val_15;
        var val_16;
        if(UnityEngine.Application.isPlaying == true)
        {
                return;
        }
        
        if(this.cc == 0)
        {
                return;
        }
        
        if(this.Contacts == null)
        {
                return;
        }
        
        UnityEngine.Vector2 val_3 = position;
        val_14 = val_5;
        float val_6 = this.cc.radius;
        val_15 = this.Contacts;
        float val_14 = 0.9f;
        val_14 = this.cc * val_14;
        if((UnityEngine.Physics2D.OverlapCircleNonAlloc(point:  new UnityEngine.Vector2() {x = val_4, y = val_14}, radius:  val_14, results:  val_14)) < 1)
        {
                return;
        }
        
        val_16 = 4;
        goto label_11;
        label_27:
        if(this.Contacts[0] != 0)
        {
                UnityEngine.GameObject val_10 = this.gameObject;
            val_14 = this;
            if(this.Contacts[0].GetInstanceID() != this.GetInstanceID())
        {
                UnityEngine.GameObject val_12 = this.gameObject;
            val_14 = this.Contacts;
            UnityEngine.Collider2D val_17 = val_14[0];
            UnityEngine.GameObject val_13 = val_17.gameObject;
            this.SpawnerParent.InvokeOnCollisionEnter2D(obj:  864874640, other:  val_17);
        }
        
        }
        
        val_16 = 5;
        label_11:
        val_15 = val_16 - 4;
        if(val_15 < this.SpawnerParent)
        {
            goto label_27;
        }
    
    }
    private void ScaleItDown()
    {
        if(this.ScaleDownIsPerforming == false)
        {
                this.ScaleDownIsPerforming = true;
            this.ScaleDownIsPerforming = this.ScaleDownIsPerforming;
        }
        
        this.ScaleDownPerform();
    }
    private void ScaleDownPerform()
    {
        float val_4;
        float val_5;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Vector3 val_3 = localScale;
        float val_6 = UnityEngine.Time.deltaTime;
        float val_7 = this.delta / this.LifeTime;
        val_7 = val_7 * 0;
        val_7 = val_7 * 0.8f;
        float val_8 = UnityEngine.Mathf.Clamp01(value:  val_7);
        float val_9 = this.endSize - val_5;
        float val_10 = this.endSize - val_4;
        this.localScale = new UnityEngine.Vector3() {x = val_4, y = val_5, z = 0f};
    }
    private void Blend()
    {
        float val_3;
        float val_4;
        float val_30;
        float val_31;
        float val_32;
        float val_33;
        float val_34;
        float val_35;
        float val_36;
        var val_37;
        if(this.cc == 0)
        {
                return;
        }
        
        if(mem[1152921509767278948] == 0)
        {
                mem[1152921509767278948] = 536881819;
        }
        
        var val_30 = mem[1152921509767279008];
        if(val_30 < mem[1152921509767279004])
        {
                val_30 = val_30 + 1;
            mem[1152921509767279008] = val_30;
            return;
        }
        
        val_30 = mem[1152921509767278932];
        mem[1152921509767279008] = 0;
        UnityEngine.Vector2 val_2 = velocity;
        float val_5 = val_3.sqrMagnitude;
        if(val_30 < 0)
        {
                return;
        }
        
        UnityEngine.Vector2 val_6 = position;
        val_31 = val_3;
        val_32 = val_4;
        float val_7 = this.cc.radius;
        val_33 = 1.085612E-19f;
        UnityEngine.GameObject val_8 = this.gameObject;
        val_30 = this;
        val_34 = this.layer;
        float val_31 = 0.3f;
        int val_10 = val_34 & 31;
        val_31 = this.cc * val_31;
        val_10 = 1 << val_10;
        if((UnityEngine.Physics2D.OverlapCircleNonAlloc(point:  new UnityEngine.Vector2() {x = val_31, y = val_32}, radius:  val_31, results:  val_31, layerMask:  536881819)) < 1)
        {
                return;
        }
        
        val_32 = 4;
        goto label_15;
        label_55:
        if(mem[536881835] != 0)
        {
                UnityEngine.GameObject val_13 = mem[536881835].gameObject;
            if(mem[536881835].activeSelf != false)
        {
                UnityEngine.GameObject val_16 = this.gameObject;
            val_34 = this;
            if(mem[536881835].GetInstanceID() != this.GetInstanceID())
        {
                string val_18 = mem[536881835].tag;
            if((System.String.op_Inequality(a:  mem[536881835], b:  -1610606363)) != true)
        {
                UnityEngine.Transform val_20 = mem[536881835].GetComponent<UnityEngine.Transform>();
            UnityEngine.Color val_21 = color;
            val_34 = val_4;
            val_33 = val_4;
            UnityEngine.Color val_22 = color;
            val_30 = val_3;
            if((UnityEngine.Color.op_Equality(lhs:  new UnityEngine.Color() {r = val_30, g = val_34, b = val_3, a = val_33}, rhs:  new UnityEngine.Color() {b = val_3, a = val_4})) == true)
        {
                return;
        }
        
            val_34 = mem[1152921509767278944];
            UnityEngine.Color val_24 = color;
            val_33 = 0;
            UnityEngine.Color val_25 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = 6.97363E-08f, a = val_3}, b:  new UnityEngine.Color() {r = val_4, g = val_30, b = val_34, a = val_3}, t:  val_24.r);
            if(val_34 == 0)
        {
                val_36 = ???;
            val_35 = ???;
        }
        
            val_34.color = new UnityEngine.Color() {r = val_35, g = val_36, b = val_3, a = val_4};
            UnityEngine.Transform val_26 = mem[536881835].GetComponent<UnityEngine.Transform>();
            if((mem[536881835] + 20 + 136) != 0)
        {
                UnityEngine.Transform val_27 = mem[536881835].GetComponent<UnityEngine.Transform>();
            val_33 = mem[536881835];
            UnityEngine.Color val_28 = color;
            UnityEngine.Color val_29 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = 6.97363E-08f, g = val_3, b = val_34, a = val_3}, b:  new UnityEngine.Color() {r = val_33, a = val_3}, t:  val_28.r);
            val_37 = 0;
            val_34 = val_4;
            if(val_33 == 0)
        {
                val_37 = 0;
        }
        
            val_33.color = new UnityEngine.Color() {r = val_3, g = val_34, b = val_3, a = val_4};
        }
        
        }
        
        }
        
        }
        
        }
        
        val_32 = val_32 + 1;
        label_15:
        val_30 = mem[1152921509767278948];
        val_31 = val_32 - 4;
        if(val_31 < mem[536881831])
        {
            goto label_55;
        }
    
    }
    private void Blend2()
    {
        float val_15;
        float val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        float val_36;
        var val_37;
        val_32 = 22713552;
        if(this.cc == 0)
        {
                return;
        }
        
        var val_33 = mem[1152921509767399200];
        if(val_33 < mem[1152921509767399196])
        {
                val_33 = val_33 + 1;
            mem[1152921509767399200] = val_33;
            return;
        }
        
        mem[1152921509767399200] = 0;
        UnityEngine.Vector2 val_2 = 0.velocity;
        float val_3 = 0.sqrMagnitude;
        if(mem[1152921509767399124] < 0)
        {
                return;
        }
        
        val_33 = 22713352;
        if(mem[536890951] == 0)
        {
                MetaballParticleClass[] val_5 = Water2D.MultiColorManager.GetAllParticles();
        }
        
        if((mem[536890951] + 32) == 0)
        {
                return;
        }
        
        val_34 = 0;
        val_35 = 4;
        goto label_12;
        label_51:
        UnityEngine.GameObject val_6 = mem[536890951] + 32 + 16.gameObject;
        UnityEngine.GameObject val_7 = this.gameObject;
        if((mem[536890951] + 32 + 16) != this)
        {
                UnityEngine.GameObject val_8 = mem[536890951] + 32 + 16.gameObject;
            if((mem[536890951] + 32 + 16.activeSelf) != false)
        {
                UnityEngine.GameObject val_10 = mem[536890951] + 32 + 16.gameObject;
            string val_11 = mem[536890951] + 32 + 16.tag;
            if((System.String.op_Inequality(a:  mem[536890951] + 32 + 16, b:  -1610606363)) != true)
        {
                UnityEngine.Transform val_13 = mem[536890951] + 32 + 16.transform;
            UnityEngine.Vector3 val_14 = 0.position;
            UnityEngine.GameObject val_16 = this.gameObject;
            UnityEngine.Transform val_17 = this.transform;
            UnityEngine.Vector3 val_18 = 0.position;
            float val_34 = 0f;
            float val_35 = 0f;
            float val_36 = val_15;
            val_34 = 0f - val_34;
            val_35 = 0f - val_35;
            val_36 = val_15 - val_36;
            float val_19 = val_34.sqrMagnitude;
            float val_20 = this.cc.radius;
            float val_21 = this.cc.radius;
            UnityEngine.CircleCollider2D val_37 = this.cc;
            val_37 = val_37 + 0.1f;
            val_37 = (this.cc + 0.1f) * val_37;
            if(this.cc < 0)
        {
                var val_23 = 536882187 + 0;
            mem2[0] = mem[536890951] + 32 + 16;
            val_34 = 1;
        }
        
        }
        
        }
        
        }
        
        val_35 = 5;
        label_12:
        if(val_34 <= 59)
        {
                mem[536890951] = mem[mem[536890951] + 32 + 12];
            mem[536890951] = mem[536890951] + 32 + 12;
        }
        
        if((val_35 - 4) < mem[536890951])
        {
            goto label_51;
        }
        
        val_32 = 536882187;
        if(val_34 < 1)
        {
                return;
        }
        
        val_35 = 536882203;
        val_34 = 0;
        goto label_53;
        label_67:
        if(mem[536882203] != 0)
        {
                UnityEngine.GameObject val_25 = mem[536882203].gameObject;
            Weight val_26 = mem[536882203].GetComponent<Weight>();
            UnityEngine.Color val_27 = 0.color;
            val_36 = 0f;
            val_37;
            UnityEngine.Color val_28 = 0.color;
            if((UnityEngine.Color.op_Equality(lhs:  new UnityEngine.Color() {r = 0f, g = 0f, b = R6, a = R7}, rhs:  new UnityEngine.Color() {r = 0f, g = 0f})) == true)
        {
                return;
        }
        
            UnityEngine.Color val_30 = 0.color;
            UnityEngine.Color val_32 = UnityEngine.Color.LerpUnclamped(a:  new UnityEngine.Color() {r = 7.05902E-08f, g = 0f, b = 0f}, b:  new UnityEngine.Color() {r = val_31, g = val_36, b = 0f, a = R6}, t:  val_30.r);
            val_36 = 0;
            mem[1152921509767399136].color = new UnityEngine.Color() {r = 0f, g = 0f, b = R6};
            val_32 = 536882187;
            val_35 = val_35;
        }
        
        val_34 = 1;
        label_53:
        if(val_34 < mem[536882199])
        {
            goto label_67;
        }
    
    }
    public MetaballParticleClass()
    {
        this.breathFrames = 6;
    }

}
