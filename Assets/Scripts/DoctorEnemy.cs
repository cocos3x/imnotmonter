using UnityEngine;
public class DoctorEnemy : EnemyPinPullBase
{
    // Methods
    protected override void Start()
    {
        this.Start();
    }
    protected override void Attack()
    {
        var val_4;
        if(true != 0)
        {
                return;
        }
        
        mem[1152921509523417413] = 1;
        mem[1152921509523417399] = 0;
        val_4 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_4 = 536884781;
        }
        
        536882991 = new System.Action(object:  621603088, method:  new IntPtr(1610678715));
        static_value_015E7C99.SetAnimation(name:  mem[536884873] + 76, loop:  false, timeScale:  null, _callBack:  1065353216);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610608685, volume:  null);
    }
    protected override void Raycast()
    {
        float val_3;
        float val_4;
        float val_14;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        this.Raycast();
        UnityEngine.Bounds val_1 = bounds;
        UnityEngine.Vector3 val_2 = center;
        float val_48 = val_3;
        UnityEngine.Bounds val_5 = bounds;
        UnityEngine.Vector3 val_6 = extents;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.left;
        float val_50 = 0.1f;
        float val_8 = val_3 + val_50;
        val_48 = val_48 - val_8;
        int val_9 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = val_5.m_Extents.z + 60});
        UnityEngine.RaycastHit2D val_10 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = 1.235413E-16f, y = val_48}, direction:  new UnityEngine.Vector2() {x = val_4, y = val_3}, distance:  val_8, layerMask:  val_4);
        UnityEngine.Vector2 val_11 = point;
        UnityEngine.Color val_12 = UnityEngine.Color.red;
        float val_49 = val_10.m_Normal.x;
        val_49 = val_4 - val_49;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_48, y = val_4, z = 0f}, dir:  new UnityEngine.Vector3() {x = val_3 - val_48, y = val_49, z = 0f}, color:  new UnityEngine.Color() {a = val_14});
        UnityEngine.Bounds val_15 = bounds;
        UnityEngine.Vector3 val_16 = center;
        UnityEngine.Bounds val_17 = bounds;
        mem2[0] = val_17.m_Extents.y;
        UnityEngine.Vector3 val_18 = extents;
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.right;
        float val_20 = val_3 + val_50;
        val_50 = val_3 + val_20;
        int val_21 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = val_5.m_Extents.z + 60});
        UnityEngine.RaycastHit2D val_22 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = 1.235413E-16f, y = val_50}, direction:  new UnityEngine.Vector2() {x = val_4, y = val_3}, distance:  val_20, layerMask:  val_4);
        UnityEngine.Vector2 val_23 = point;
        UnityEngine.Color val_24 = UnityEngine.Color.red;
        float val_51 = val_4;
        val_51 = val_4 - val_51;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_50, y = val_4, z = 0f}, dir:  new UnityEngine.Vector3() {x = val_3 - val_50, y = val_51, z = val_22.m_Collider}, color:  new UnityEngine.Color());
        UnityEngine.Collider2D val_26 = mem[val_22.m_Distance + (8)].collider;
        if((621702976 == 0) || ((val_5.m_Extents.z + 56) != 0))
        {
            goto label_21;
        }
        
        UnityEngine.Collider2D val_29 = mem[val_22.m_Distance + (8)].collider;
        val_48 = mem[val_22.m_Distance + (8)].CompareTag(tag:  -1610605337);
        UnityEngine.Collider2D val_31 = mem[val_22.m_Distance + (8)].collider;
        if(val_48 == false)
        {
            goto label_17;
        }
        
        UnityEngine.GameObject val_32 = mem[val_22.m_Distance + (8)].gameObject;
        mem2[0] = ;
        WorldTimeAPI val_33 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_49 = mem[3221266323];
        if(val_49 == 0)
        {
            goto label_19;
        }
        
        val_50 = mem[mem[3221266323] + 48];
        val_50 = mem[3221266323] + 48;
        goto label_20;
        label_17:
        if((mem[val_22.m_Distance + (8)].CompareTag(tag:  -1610607699)) == false)
        {
            goto label_21;
        }
        
        UnityEngine.Collider2D val_35 = mem[val_22.m_Distance + (8)].collider;
        UnityEngine.GameObject val_36 = mem[val_22.m_Distance + (8)].gameObject;
        mem2[0] = ;
        goto label_23;
        label_19:
        val_49 = 48;
        val_50 = 1835037;
        label_20:
        mem[48] = 1835038;
        label_23:
        mem2[0] = 1;
        label_21:
        UnityEngine.Collider2D val_37 = mem[val_22.m_Distance + (0)].collider;
        if(621702968 == 0)
        {
                return;
        }
        
        if((val_5.m_Extents.z + 56) != 0)
        {
                return;
        }
        
        UnityEngine.Collider2D val_40 = mem[val_22.m_Distance + (0)].collider;
        val_48 = mem[val_22.m_Distance + (0)].CompareTag(tag:  -1610605337);
        UnityEngine.Collider2D val_42 = mem[val_22.m_Distance + (0)].collider;
        if(val_48 == false)
        {
            goto label_32;
        }
        
        UnityEngine.GameObject val_43 = mem[val_22.m_Distance + (0)].gameObject;
        mem2[0] = ;
        WorldTimeAPI val_44 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_51 = mem[3221266323];
        if(val_51 == 0)
        {
            goto label_34;
        }
        
        val_52 = mem[mem[3221266323] + 48];
        val_52 = mem[3221266323] + 48;
        goto label_35;
        label_32:
        if((mem[val_22.m_Distance + (0)].CompareTag(tag:  -1610607699)) == false)
        {
                return;
        }
        
        UnityEngine.Collider2D val_46 = mem[val_22.m_Distance + (0)].collider;
        UnityEngine.GameObject val_47 = mem[val_22.m_Distance + (0)].gameObject;
        mem2[0] = ;
        goto label_38;
        label_34:
        val_51 = 48;
        val_52 = mem[48];
        label_35:
        mem[48] = 1835039;
        label_38:
        mem2[0] = 1;
    }
    protected override void AudioDead(TypeEnemyPinPullDie type)
    {
        var val_4;
        var val_5;
        this.AudioDead(type:  type);
        bool val_1 = SingletonMonoBehaviour<TransitionFX>.Exists();
        if(type == 2)
        {
                if(val_1 == false)
        {
                return;
        }
        
            WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_4 = -1073701113;
            val_5 = 22786324;
        }
        else
        {
                if(val_1 == false)
        {
                return;
        }
        
            WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_4 = -1073701113;
            val_5 = 22784972;
        }
        
        val_4.Shot(clip:  -1610608687, volume:  null);
    }
    public DoctorEnemy()
    {
    
    }
    private void <Attack>b__1_0()
    {
        this.Idle();
        mem[1152921509523873608] = 0;
        mem[1152921509523873605] = 0;
    }

}
