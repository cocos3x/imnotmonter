using UnityEngine;
private sealed class Water2D_Spawner.<loop>d__88 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Water2D.Water2D_Spawner <>4__this;
    public float delay;
    public UnityEngine.Vector2 _initSpeed;
    public bool waitBetweenDropSpawn;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Water2D_Spawner.<loop>d__88(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_13;
        float val_14;
        float val_15;
        bool val_45;
        UnityEngine.GameObject val_47;
        Water2D_Spawner.<loop>d__88 val_50;
        var val_51;
        var val_52;
        Water2D_Spawner.<loop>d__88 val_53;
        float val_54;
        float val_55;
        float val_56;
        float val_57;
        float val_61;
        float val_62;
        var val_63;
        var val_64;
        int val_65;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 6802712 + (6802712 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                6802712 + (this.<>1__state) << 2 = (6802712 + (this.<>1__state) << 2) & ((6802712 + (this.<>1__state) << 2) << (6802712 + (this.<>1__state) << 2));
            6802712 + (this.<>1__state) << 2 = (6802712 + (this.<>1__state) << 2) & 45946800;
            mem2[0] = ((6802712 + (this.<>1__state) << 2 & (6802712 + (this.<>1__state) << 2) << 6802712 + (this.<>1__state) << 2) & 45946800) + ((6802712 + (this.<>1__state) << 2 & (6802712 + (this.<>1__state) << 2) << 6802712 + (this.<>1__state) << 2) & 45946800);
        }
        
            this.<>1__state = 0;
            val_45 = 0;
            if((this.<>4__this.<IsSpawning>k__BackingField) == true)
        {
                return (bool)val_45;
        }
        
            if((this.<>4__this.Water2DEmissionType) == 1)
        {
                val_45 = 0;
            UnityEngine.Debug.LogError(message:  -1610602415);
            return (bool)val_45;
        }
        
            val_53 = this;
            val_45 = true;
            this.<>4__this.<IsSpawning>k__BackingField = val_45;
            UnityEngine.WaitForSeconds val_6 = 536896849;
            val_6 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[1152921509832474492] = val_6;
            this.<>1__state = val_45;
            return (bool)val_45;
        }
        
        label_21:
        val_45 = 0;
        return (bool)val_45;
        label_64:
        if((SL + 296) != 0)
        {
            goto label_21;
        }
        
        var val_7 = (SL + 40) + (R8 << 2);
        Weight val_8 = (SL + 40 + (R8) << 2) + 16.GetComponent<Weight>();
        if(((SL + 40 + (R8) << 2) + 16 + 61) != 0)
        {
            goto label_26;
        }
        
        mem2[0] = 1;
        if(((SL + 40 + (R8) << 2) + 16 + 61) > 0)
        {
                -1f = SL + 56;
        }
        
        mem2[0] = -1f;
        var val_9 = (SL + 40) + (R8 << 2);
        UnityEngine.Transform val_10 = (SL + 40 + (R8) << 2) + 16.transform;
        UnityEngine.Transform val_11 = SL.transform;
        UnityEngine.Vector3 val_12 = position;
        val_54 = val_14;
        val_55 = val_15;
        (SL + 40 + (R8) << 2) + 16.position = new UnityEngine.Vector3() {x = val_13, y = val_54, z = val_55};
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.zero;
        float val_45 = val_14;
        var val_46 = val_13;
        val_45 = mem[1152921509832474508] - val_45;
        val_46 = mem[1152921509832474504] - val_46;
        val_45 = val_45 * val_45;
        val_56 = 9.999999E-11f;
        if((SL + 248) == 0)
        {
            goto label_32;
        }
        
        mem[1152921509832474504] = SL + 176;
        mem[1152921509832474508] = SL + 180;
        UnityEngine.Transform val_17 = (SL + 40 + (R8) << 2) + 16.transform;
        (SL + 40 + (R8) << 2) + 16.localScale = new UnityEngine.Vector3() {x = SL + 48, y = SL + 48, z = 1f};
        if((System.String.op_Equality(a:  SL + 12, b:  -1610605017)) == false)
        {
            goto label_34;
        }
        
        var val_19 = SL + 164;
        SL.SetRefractingWaterparams(intensity:  val_56, mag:  val_16.y, speed:  val_45);
        if(((SL + 40 + (R8) << 2) + 16 + 61) != 0)
        {
            goto label_41;
        }
        
        UnityEngine.GameObject val_20 = (SL + 40 + (R8) << 2) + 16.gameObject;
        Weight val_21 = (SL + 40 + (R8) << 2) + 16.GetComponent<Weight>();
        val_57 = mem[SL + 88];
        val_57 = SL + 88;
        if(((SL + 40 + (R8) << 2) + 16) == 0)
        {
                val_57 = val_57;
        }
        
        (SL + 40 + (R8) << 2) + 16.color = new UnityEngine.Color() {r = val_57, g = SL + 92, b = SL + 96, a = SL + 100};
        goto label_41;
        label_34:
        if((System.String.op_Equality(a:  SL + 12, b:  -1610603379)) != false)
        {
                var val_23 = SL + 88;
            val_56 = mem[SL + 140];
            val_56 = SL + 140;
            SL.SetToonWaterparams(fill:  new UnityEngine.Color() {r = mem[(SL + 88) + (0)], g = mem[(SL + 88) + (4)], b = mem[(SL + 88) + (8)], a = SL + 100}, stroke:  new UnityEngine.Color() {r = SL + 104, g = SL + 108, b = SL + 112, a = SL + 116}, alphaCutoff:  val_56, alphaStroke:  val_16.y);
        }
        else
        {
                if((System.String.op_Equality(a:  SL + 12, b:  -1610604997)) != false)
        {
                var val_25 = SL + 88;
            var val_26 = SL + 312;
            val_61 = mem[SL + 100];
            val_61 = SL + 100;
            mem2[0] = val_61;
            if(((SL + 40 + (R8) << 2) + 16 + 61) == 0)
        {
                UnityEngine.GameObject val_27 = (SL + 40 + (R8) << 2) + 16.gameObject;
            Weight val_28 = (SL + 40 + (R8) << 2) + 16.GetComponent<Weight>();
            val_62 = mem[SL + 88];
            val_62 = SL + 88;
            if(((SL + 40 + (R8) << 2) + 16) == 0)
        {
                val_62 = val_62;
        }
        
            (SL + 40 + (R8) << 2) + 16.color = new UnityEngine.Color() {r = val_62, g = SL + 92, b = SL + 96, a = SL + 100};
            var val_29 = SL + 88;
            val_61 = mem[SL + 100];
            val_61 = SL + 100;
        }
        
            val_56 = mem[SL + 140];
            val_56 = SL + 140;
            SL.SetRegularWaterparams(fill:  new UnityEngine.Color() {r = mem[(SL + 88) + (0)], g = mem[(SL + 88) + (4)], b = mem[(SL + 88) + (8)], a = val_61}, fresnel:  new UnityEngine.Color() {r = SL + 104, g = SL + 108, b = SL + 112, a = SL + 116}, alphaCutoff:  val_56, multiplier:  val_16.y);
        }
        
        }
        
        label_41:
        var val_30 = (SL + 40) + (R8 << 2);
        Weight val_31 = (SL + 40 + (R8) << 2) + 16.GetComponent<Weight>();
        if(((SL + 40 + (R8) << 2) + 16) <= 0)
        {
            goto label_49;
        }
        
        (SL + 40 + (R8) << 2) + 16.enabled = true;
        if(((SL + 40 + (R8) << 2) + 16) == 0)
        {
            goto label_50;
        }
        
        (SL + 40 + (R8) << 2) + 16.startWidth = val_56;
        (SL + 40 + (R8) << 2) + 16.endWidth = val_56;
        val_63 = mem[SL + 72];
        val_63 = SL + 72;
        goto label_51;
        label_49:
        (SL + 40 + (R8) << 2) + 16.enabled = false;
        goto label_52;
        label_50:
        (SL + 40 + (R8) << 2) + 16.startWidth = val_56;
        (SL + 40 + (R8) << 2) + 16.endWidth = val_56;
        val_63 = mem[SL + 72];
        val_63 = SL + 72;
        label_51:
        (SL + 40 + (R8) << 2) + 16.time = val_56;
        label_52:
        mem2[0] = SL + 216;
        mem2[0] = SL + 212;
        mem2[0] = SL + 224;
        mem2[0] = SL + 220;
        UnityEngine.Transform val_32 = (SL + 40 + (R8) << 2) + 16.GetComponent<UnityEngine.Transform>();
        if(((SL + 40 + (R8) << 2) + 16) != 0)
        {
                (SL + 40 + (R8) << 2) + 16.sharedMaterial = SL + 188;
            (SL + 40 + (R8) << 2) + 16.drag = val_56;
            (SL + 40 + (R8) << 2) + 16.angularDrag = val_56;
            val_64 = mem[SL + 204];
            val_64 = SL + 204;
        }
        else
        {
                (SL + 40 + (R8) << 2) + 16.sharedMaterial = SL + 188;
            (SL + 40 + (R8) << 2) + 16.drag = val_56;
            (SL + 40 + (R8) << 2) + 16.angularDrag = val_56;
            val_64 = mem[SL + 204];
            val_64 = SL + 204;
        }
        
        (SL + 40 + (R8) << 2) + 16.gravityScale = val_56;
        if((SL + 208) != 0)
        {
                (SL + 40 + (R8) << 2) + 16.constraints = 4;
        }
        
        val_54 = 22755240;
        UnityEngine.Transform val_33 = (SL + 40 + (R8) << 2) + 16.GetComponent<UnityEngine.Transform>();
        val_55 = mem[SL + 188];
        val_55 = SL + 188;
        (SL + 40 + (R8) << 2) + 16.sharedMaterial = val_55;
        UnityEngine.Transform val_34 = (SL + 40 + (R8) << 2) + 16.GetComponent<UnityEngine.Transform>();
        (SL + 40 + (R8) << 2) + 16.radius = val_56;
        mem2[0] = SL + 52;
        label_32:
        val_52 = 0;
        (SL + 40 + (R8) << 2) + 16.Active = true;
        mem2[0] = val_52;
        UnityEngine.Transform val_35 = SL.transform;
        UnityEngine.Quaternion val_36 = localRotation;
        UnityEngine.Vector2 val_37 = UnityEngine.Vector2.down;
        UnityEngine.Vector3 val_38 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 1.481556E-05f, y = R4, z = R5, w = R6}, point:  new UnityEngine.Vector3() {x = ???, y = val_13, z = val_14});
        UnityEngine.Transform val_39 = (SL + 40 + (R8) << 2) + 16.GetComponent<UnityEngine.Transform>();
        float val_47 = SL + 184;
        val_47 = val_13 * val_47;
        (SL + 40 + (R8) << 2) + 16.velocity = new UnityEngine.Vector2() {x = val_47, y = val_14 * val_47};
        var val_48 = SL + 244;
        val_50 = this;
        val_48 = val_48 + 1;
        mem2[0] = val_48;
        mem2[0] = (SL + 308) + 1;
        if(mem[1152921509832474512] == true)
        {
            goto label_61;
        }
        
        UnityEngine.GameObject val_42 = SL.gameObject;
        val_47 = SL;
        SL.InvokeOnSpawnerEmittinEachParticle(obj:  val_47);
        val_52 = 1152921509832474516;
        label_26:
        val_51 =  + 1;
        mem[1152921509832474516] = val_51;
        if(val_51 < (SL + 40 + 12))
        {
            goto label_64;
        }
        
        UnityEngine.WaitForEndOfFrame val_43 = 536896839;
        val_43 = new UnityEngine.WaitForEndOfFrame();
        mem[1152921509832474492] = val_43;
        val_65 = 3;
        goto label_65;
        label_61:
        UnityEngine.WaitForSeconds val_44 = 536896849;
        val_44 = new UnityEngine.WaitForSeconds(seconds:  val_47);
        mem[1152921509832474492] = val_44;
        val_65 = 2;
        label_65:
        this.<>1__state = val_65;
        val_45 = 1;
        return (bool)val_45;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        22713476 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
