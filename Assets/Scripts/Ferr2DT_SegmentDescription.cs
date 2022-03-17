using UnityEngine;
[Serializable]
public class Ferr2DT_SegmentDescription
{
    // Fields
    private Ferr2DT_TerrainDirection _applyTo;
    private float _zOffset;
    private float _yOffset;
    private float _capOffset;
    private UnityEngine.Rect _legacyLeftCap;
    private UnityEngine.Rect[] _leftCaps;
    private float[] _leftCapWeights;
    private float[] _leftCapColliderSize;
    private int[] _leftCapColliderType;
    private float[] _leftCapOffset;
    private UnityEngine.Rect _legacyInnerLeftCap;
    private UnityEngine.Rect[] _innerLeftCaps;
    private float[] _innerLeftCapWeights;
    private float[] _innerLeftCapColliderSize;
    private int[] _innerLeftCapColliderType;
    private float[] _innerLeftCapOffset;
    private UnityEngine.Rect _legacyRightCap;
    private UnityEngine.Rect[] _rightCaps;
    private float[] _rightCapWeights;
    private float[] _rightCapColliderSize;
    private int[] _rightCapColliderType;
    private float[] _rightCapOffset;
    private UnityEngine.Rect _legacyInnerRightCap;
    private UnityEngine.Rect[] _innerRightCaps;
    private float[] _innerRightCapWeights;
    private float[] _innerRightCapColliderSize;
    private int[] _innerRightCapColliderType;
    private float[] _innerRightCapOffset;
    private UnityEngine.Rect[] _bodies;
    private float[] _bodyWeights;
    private float _yOffsetPercent;
    private float _colliderOffset;
    private float _colliderThickness;
    private UnityEngine.PhysicsMaterial2D _physicsMaterial2D;
    private UnityEngine.PhysicMaterial _physicsMaterial3D;
    
    // Properties
    public Ferr2DT_TerrainDirection ApplyTo { get; set; }
    public float ZOffset { get; set; }
    public float YOffset { get; set; }
    public float YOffsetPercent { get; set; }
    public float CapOffset { get; set; }
    public float ColliderOffset { get; set; }
    public float ColliderThickness { get; set; }
    public UnityEngine.PhysicMaterial PhysicsMaterial3D { get; set; }
    public UnityEngine.PhysicsMaterial2D PhysicsMaterial2D { get; set; }
    public float SingleColliderCapSize { get; set; }
    public float SingleColliderCapOffset { get; set; }
    public Ferr2D_CapColliderType SingleColliderCapType { get; set; }
    public float EditorLeftCapOffset { get; set; }
    public float EditorRightCapOffset { get; set; }
    public float EditorInnerLeftCapOffset { get; set; }
    public float EditorInnerRightCapOffset { get; set; }
    public int EditorLeftCapType { get; set; }
    public int EditorRightCapType { get; set; }
    public int EditorInnerLeftCapType { get; set; }
    public int EditorInnerRightCapType { get; set; }
    public float EditorLeftCapColliderSize { get; set; }
    public float EditorRightCapColliderSize { get; set; }
    public float EditorInnerLeftCapColliderSize { get; set; }
    public float EditorInnerRightCapColliderSize { get; set; }
    public int BodyCount { get; }
    public Ferr2DT_TerrainDirection applyTo { get; set; }
    public float zOffset { get; set; }
    public float yOffset { get; set; }
    public float capOffset { get; set; }
    public UnityEngine.Rect leftCap { get; set; }
    public UnityEngine.Rect innerLeftCap { get; set; }
    public UnityEngine.Rect rightCap { get; set; }
    public UnityEngine.Rect innerRightCap { get; set; }
    public UnityEngine.Rect[] body { get; set; }
    
    // Methods
    public Ferr2DT_TerrainDirection get_ApplyTo()
    {
    
    }
    public void set_ApplyTo(Ferr2DT_TerrainDirection value)
    {
        this._applyTo = value;
    }
    public float get_ZOffset()
    {
        return (float)S0;
    }
    public void set_ZOffset(float value)
    {
        this._zOffset = ;
    }
    public float get_YOffset()
    {
        return (float)S0;
    }
    public void set_YOffset(float value)
    {
        this._yOffset = ;
    }
    public float get_YOffsetPercent()
    {
        return (float)S0;
    }
    public void set_YOffsetPercent(float value)
    {
        this._yOffsetPercent = ;
    }
    public float get_CapOffset()
    {
        return (float)S0;
    }
    public void set_CapOffset(float value)
    {
        this._capOffset = ;
    }
    public float get_ColliderOffset()
    {
        return (float)S0;
    }
    public void set_ColliderOffset(float value)
    {
        this._colliderOffset = ;
    }
    public float get_ColliderThickness()
    {
        return (float)S0;
    }
    public void set_ColliderThickness(float value)
    {
        this._colliderThickness = ;
    }
    public UnityEngine.PhysicMaterial get_PhysicsMaterial3D()
    {
    
    }
    public void set_PhysicsMaterial3D(UnityEngine.PhysicMaterial value)
    {
        this._physicsMaterial3D = value;
    }
    public UnityEngine.PhysicsMaterial2D get_PhysicsMaterial2D()
    {
    
    }
    public void set_PhysicsMaterial2D(UnityEngine.PhysicsMaterial2D value)
    {
        this._physicsMaterial2D = value;
    }
    public float get_SingleColliderCapSize()
    {
        return (float)this.SafeGet<System.Single>(aSource:  this._leftCapColliderSize, aDefault:  null, aIndex:  1065353216);
    }
    public void set_SingleColliderCapSize(float value)
    {
        this.SafeSet<System.Single>(aSource: ref  this._leftCapColliderSize, aValue:  value, aIndex:  R1);
        this.SafeSet<System.Single>(aSource: ref  this._innerLeftCapColliderSize, aValue:  value, aIndex:  R1);
        this.SafeSet<System.Single>(aSource: ref  this._rightCapColliderSize, aValue:  value, aIndex:  R1);
        this.SafeSet<System.Single>(aSource: ref  this._innerRightCapColliderSize, aValue:  value, aIndex:  R1);
    }
    public float get_SingleColliderCapOffset()
    {
        return (float)this.SafeGet<System.Single>(aSource:  this._leftCapOffset, aDefault:  null, aIndex:  0);
    }
    public void set_SingleColliderCapOffset(float value)
    {
        this.SafeSet<System.Single>(aSource: ref  this._leftCapOffset, aValue:  value, aIndex:  R1);
        this.SafeSet<System.Single>(aSource: ref  this._innerLeftCapOffset, aValue:  value, aIndex:  R1);
        this.SafeSet<System.Single>(aSource: ref  this._rightCapOffset, aValue:  value, aIndex:  R1);
        this.SafeSet<System.Single>(aSource: ref  this._innerRightCapOffset, aValue:  value, aIndex:  R1);
    }
    public Ferr2D_CapColliderType get_SingleColliderCapType()
    {
        int val_1 = this.SafeGet<System.Int32>(aSource:  this._leftCapColliderType, aDefault:  0, aIndex:  0);
    }
    public void set_SingleColliderCapType(Ferr2D_CapColliderType value)
    {
        this.SafeSet<System.Int32>(aSource: ref  this._leftCapColliderType, aValue:  value, aIndex:  0);
        this.SafeSet<System.Int32>(aSource: ref  this._innerLeftCapColliderType, aValue:  value, aIndex:  0);
        this.SafeSet<System.Int32>(aSource: ref  this._rightCapColliderType, aValue:  value, aIndex:  0);
        this.SafeSet<System.Int32>(aSource: ref  this._innerRightCapColliderType, aValue:  value, aIndex:  0);
    }
    public float get_EditorLeftCapOffset()
    {
        return (float)this.SafeGet<System.Single>(aSource:  this._leftCapOffset, aDefault:  null, aIndex:  0);
    }
    public void set_EditorLeftCapOffset(float value)
    {
        this.SafeSet<System.Single>(aSource: ref  this._leftCapOffset, aValue:  value, aIndex:  R1);
    }
    public float get_EditorRightCapOffset()
    {
        return (float)this.SafeGet<System.Single>(aSource:  this._rightCapOffset, aDefault:  null, aIndex:  0);
    }
    public void set_EditorRightCapOffset(float value)
    {
        this.SafeSet<System.Single>(aSource: ref  this._rightCapOffset, aValue:  value, aIndex:  R1);
    }
    public float get_EditorInnerLeftCapOffset()
    {
        return (float)this.SafeGet<System.Single>(aSource:  this._innerLeftCapOffset, aDefault:  null, aIndex:  0);
    }
    public void set_EditorInnerLeftCapOffset(float value)
    {
        this.SafeSet<System.Single>(aSource: ref  this._innerLeftCapOffset, aValue:  value, aIndex:  R1);
    }
    public float get_EditorInnerRightCapOffset()
    {
        return (float)this.SafeGet<System.Single>(aSource:  this._innerRightCapOffset, aDefault:  null, aIndex:  0);
    }
    public void set_EditorInnerRightCapOffset(float value)
    {
        this.SafeSet<System.Single>(aSource: ref  this._innerRightCapOffset, aValue:  value, aIndex:  R1);
    }
    public int get_EditorLeftCapType()
    {
        return (int)this.SafeGet<System.Int32>(aSource:  this._leftCapColliderType, aDefault:  0, aIndex:  0);
    }
    public void set_EditorLeftCapType(int value)
    {
        this.SafeSet<System.Int32>(aSource: ref  this._leftCapColliderType, aValue:  value, aIndex:  0);
    }
    public int get_EditorRightCapType()
    {
        return (int)this.SafeGet<System.Int32>(aSource:  this._rightCapColliderType, aDefault:  0, aIndex:  0);
    }
    public void set_EditorRightCapType(int value)
    {
        this.SafeSet<System.Int32>(aSource: ref  this._rightCapColliderType, aValue:  value, aIndex:  0);
    }
    public int get_EditorInnerLeftCapType()
    {
        return (int)this.SafeGet<System.Int32>(aSource:  this._innerLeftCapColliderType, aDefault:  0, aIndex:  0);
    }
    public void set_EditorInnerLeftCapType(int value)
    {
        this.SafeSet<System.Int32>(aSource: ref  this._innerLeftCapColliderType, aValue:  value, aIndex:  0);
    }
    public int get_EditorInnerRightCapType()
    {
        return (int)this.SafeGet<System.Int32>(aSource:  this._innerRightCapColliderType, aDefault:  0, aIndex:  0);
    }
    public void set_EditorInnerRightCapType(int value)
    {
        this.SafeSet<System.Int32>(aSource: ref  this._innerRightCapColliderType, aValue:  value, aIndex:  0);
    }
    public float get_EditorLeftCapColliderSize()
    {
        return (float)this.SafeGet<System.Single>(aSource:  this._leftCapColliderSize, aDefault:  null, aIndex:  0);
    }
    public void set_EditorLeftCapColliderSize(float value)
    {
        this.SafeSet<System.Single>(aSource: ref  this._leftCapColliderSize, aValue:  value, aIndex:  R1);
    }
    public float get_EditorRightCapColliderSize()
    {
        return (float)this.SafeGet<System.Single>(aSource:  this._rightCapColliderSize, aDefault:  null, aIndex:  0);
    }
    public void set_EditorRightCapColliderSize(float value)
    {
        this.SafeSet<System.Single>(aSource: ref  this._rightCapColliderSize, aValue:  value, aIndex:  R1);
    }
    public float get_EditorInnerLeftCapColliderSize()
    {
        return (float)this.SafeGet<System.Single>(aSource:  this._innerLeftCapColliderSize, aDefault:  null, aIndex:  0);
    }
    public void set_EditorInnerLeftCapColliderSize(float value)
    {
        this.SafeSet<System.Single>(aSource: ref  this._innerLeftCapColliderSize, aValue:  value, aIndex:  R1);
    }
    public float get_EditorInnerRightCapColliderSize()
    {
        return (float)this.SafeGet<System.Single>(aSource:  this._innerRightCapColliderSize, aDefault:  null, aIndex:  0);
    }
    public void set_EditorInnerRightCapColliderSize(float value)
    {
        this.SafeSet<System.Single>(aSource: ref  this._innerRightCapColliderSize, aValue:  value, aIndex:  R1);
    }
    public int get_BodyCount()
    {
        if(this._bodies != null)
        {
                return (int)this;
        }
        
        return (int)this;
    }
    public bool HasInnerLeft()
    {
        var val_4;
        var val_5;
        var val_6;
        UnityEngine.Rect val_7;
        var val_8;
        if(true == 0)
        {
                val_4 = 1152921509375781240;
            val_5 = 1152921509375781236;
            val_6 = 1152921509375781232;
            val_7 = this._legacyInnerLeftCap;
        }
        else
        {
            
        }
        
        UnityEngine.Rect val_1 = SafeGet<UnityEngine.Rect>(aSource:  473966896, aDefault:  new UnityEngine.Rect() {m_XMin = this._innerLeftCaps, m_YMin = 2.515206E+35f}, aIndex:  null);
        float val_2 = width;
        if(true == 0)
        {
                float val_3 = height;
            if(true != 0)
        {
                val_8 = 1;
        }
        
            return (bool)val_8;
        }
        
        val_8 = 1;
        return (bool)val_8;
    }
    public bool HasInnerRight()
    {
        var val_4;
        var val_5;
        var val_6;
        UnityEngine.Rect val_7;
        var val_8;
        if(true == 0)
        {
                val_4 = 1152921509375967040;
            val_5 = 1152921509375967036;
            val_6 = 1152921509375967032;
            val_7 = this._legacyInnerRightCap;
        }
        else
        {
            
        }
        
        UnityEngine.Rect val_1 = SafeGet<UnityEngine.Rect>(aSource:  474152624, aDefault:  new UnityEngine.Rect() {m_XMin = this._innerRightCaps, m_YMin = 2.515206E+35f}, aIndex:  null);
        float val_2 = width;
        if(true == 0)
        {
                float val_3 = height;
            if(true != 0)
        {
                val_8 = 1;
        }
        
            return (bool)val_8;
        }
        
        val_8 = 1;
        return (bool)val_8;
    }
    public Ferr2D_CapColliderType GetLeftCapType(bool aInner, int aId = -1)
    {
        System.Int32[] val_3;
        if((aInner != false) && (this.HasInnerLeft() != false))
        {
                val_3 = this._innerLeftCapColliderType;
        }
        else
        {
                val_3 = this._leftCapColliderType;
        }
        
        if(aId == 1)
        {
                aId = aId + 1;
        }
        
        int val_2 = this.SafeGet<System.Int32>(aSource:  mem[this._leftCapColliderType], aDefault:  0, aIndex:  aId);
    }
    public Ferr2D_CapColliderType GetRightCapType(bool aInner, int aId = -1)
    {
        System.Int32[] val_3;
        if((aInner != false) && (this.HasInnerRight() != false))
        {
                val_3 = this._innerRightCapColliderType;
        }
        else
        {
                val_3 = this._rightCapColliderType;
        }
        
        if(aId == 1)
        {
                aId = aId + 1;
        }
        
        int val_2 = this.SafeGet<System.Int32>(aSource:  mem[this._rightCapColliderType], aDefault:  0, aIndex:  aId);
    }
    public float GetLeftCapOffset(bool aInner, UnityEngine.Vector2 aUnitsPerUV, int aId = -1)
    {
        var val_8;
        var val_9;
        var val_10;
        UnityEngine.Rect val_11;
        var val_12;
        var val_13;
        var val_14;
        UnityEngine.Rect val_15;
        var val_16;
        System.Single[] val_19;
        var val_20;
        if(aId == 1)
        {
                aId = aId + 1;
        }
        
        if(aInner == false)
        {
            goto label_2;
        }
        
        bool val_1 = this.HasInnerLeft();
        if(val_1 == false)
        {
            goto label_2;
        }
        
        if(val_1 == true)
        {
            goto label_3;
        }
        
        val_8 = 1152921509376487288;
        val_9 = 1152921509376487284;
        val_10 = 1152921509376487280;
        val_11 = this._legacyInnerLeftCap;
        goto label_4;
        label_2:
        if(true == 0)
        {
                val_12 = 1152921509376487252;
            val_13 = 1152921509376487248;
            val_14 = 1152921509376487244;
            val_15 = this._legacyLeftCap;
        }
        else
        {
            
        }
        
        UnityEngine.Rect val_2 = SafeGet<UnityEngine.Rect>(aSource:  474672944, aDefault:  new UnityEngine.Rect() {m_XMin = this._leftCaps, m_YMin = 2.515206E+35f}, aIndex:  null);
        val_19 = this._leftCapOffset;
        goto label_7;
        label_3:
        label_4:
        val_16 = -1073689239;
        UnityEngine.Rect val_3 = SafeGet<UnityEngine.Rect>(aSource:  474672944, aDefault:  new UnityEngine.Rect() {m_XMin = this._innerLeftCaps, m_YMin = 2.515206E+35f}, aIndex:  null);
        val_19 = this._innerLeftCapOffset;
        label_7:
        float val_4 = this.SafeGet<System.Single>(aSource:  val_19, aDefault:  val_3.m_XMin, aIndex:  0);
        float val_5 = width;
        if(val_1 != true)
        {
                float val_6 = this.GetBodyMaxHeight();
            val_20 = 474672944 + 474672944;
        }
        else
        {
                float val_7 = width;
            val_20 = 474660896;
        }
        
        val_20 = 474672944 * val_20;
        return (float)val_20;
    }
    public float GetRightCapOffset(bool aInner, UnityEngine.Vector2 aUnitsPerUV, int aId = -1)
    {
        var val_8;
        var val_9;
        var val_10;
        UnityEngine.Rect val_11;
        var val_12;
        var val_13;
        var val_14;
        UnityEngine.Rect val_15;
        var val_16;
        System.Single[] val_19;
        var val_20;
        if(aId == 1)
        {
                aId = aId + 1;
        }
        
        if(aInner == false)
        {
            goto label_2;
        }
        
        bool val_1 = this.HasInnerRight();
        if(val_1 == false)
        {
            goto label_2;
        }
        
        if(val_1 == true)
        {
            goto label_3;
        }
        
        val_8 = 1152921509376894272;
        val_9 = 1152921509376894268;
        val_10 = 1152921509376894264;
        val_11 = this._legacyInnerRightCap;
        goto label_4;
        label_2:
        if(true == 0)
        {
                val_12 = 1152921509376894236;
            val_13 = 1152921509376894232;
            val_14 = 1152921509376894228;
            val_15 = this._legacyRightCap;
        }
        else
        {
            
        }
        
        UnityEngine.Rect val_2 = SafeGet<UnityEngine.Rect>(aSource:  475079856, aDefault:  new UnityEngine.Rect() {m_XMin = this._rightCaps, m_YMin = 2.515206E+35f}, aIndex:  null);
        val_19 = this._rightCapOffset;
        goto label_7;
        label_3:
        label_4:
        val_16 = -1073689239;
        UnityEngine.Rect val_3 = SafeGet<UnityEngine.Rect>(aSource:  475079856, aDefault:  new UnityEngine.Rect() {m_XMin = this._innerRightCaps, m_YMin = 2.515206E+35f}, aIndex:  null);
        val_19 = this._innerRightCapOffset;
        label_7:
        float val_4 = this.SafeGet<System.Single>(aSource:  val_19, aDefault:  val_3.m_XMin, aIndex:  0);
        float val_5 = width;
        if(val_1 != true)
        {
                float val_6 = this.GetBodyMaxHeight();
            val_20 = 475079856 + 475079856;
        }
        else
        {
                float val_7 = width;
            val_20 = 475067808;
        }
        
        val_20 = 475079856 * val_20;
        return (float)val_20;
    }
    public float GetLeftCapSize(bool aInner, UnityEngine.Vector2 aUnitsPerUV, int aId = -1)
    {
        var val_8;
        var val_9;
        var val_10;
        UnityEngine.Rect val_11;
        var val_12;
        var val_13;
        var val_14;
        UnityEngine.Rect val_15;
        var val_16;
        System.Single[] val_19;
        var val_20;
        if(aId == 1)
        {
                aId = aId + 1;
        }
        
        if(aInner == false)
        {
            goto label_2;
        }
        
        bool val_1 = this.HasInnerLeft();
        if(val_1 == false)
        {
            goto label_2;
        }
        
        if(val_1 == true)
        {
            goto label_3;
        }
        
        val_8 = 1152921509377301112;
        val_9 = 1152921509377301108;
        val_10 = 1152921509377301104;
        val_11 = this._legacyInnerLeftCap;
        goto label_4;
        label_2:
        if(true == 0)
        {
                val_12 = 1152921509377301076;
            val_13 = 1152921509377301072;
            val_14 = 1152921509377301068;
            val_15 = this._legacyLeftCap;
        }
        else
        {
            
        }
        
        UnityEngine.Rect val_2 = SafeGet<UnityEngine.Rect>(aSource:  475486768, aDefault:  new UnityEngine.Rect() {m_XMin = this._leftCaps, m_YMin = 2.515206E+35f}, aIndex:  null);
        val_19 = this._leftCapColliderSize;
        goto label_7;
        label_3:
        label_4:
        val_16 = -1073689239;
        UnityEngine.Rect val_3 = SafeGet<UnityEngine.Rect>(aSource:  475486768, aDefault:  new UnityEngine.Rect() {m_XMin = this._innerLeftCaps, m_YMin = 2.515206E+35f}, aIndex:  null);
        val_19 = this._innerLeftCapColliderSize;
        label_7:
        float val_4 = this.SafeGet<System.Single>(aSource:  val_19, aDefault:  val_3.m_XMin, aIndex:  1065353216);
        float val_5 = width;
        if(val_1 != true)
        {
                float val_6 = this.GetBodyMaxHeight();
            float val_8 = -1f;
            val_8 = 475486768 + val_8;
            val_8 = val_8 * 475486768;
            val_20 = val_8 + val_8;
        }
        else
        {
                float val_7 = width;
            val_20 = 475486768 * 475474720;
        }
        
        val_20 = val_20 * aUnitsPerUV.x;
        return (float)val_20;
    }
    public float GetRightCapSize(bool aInner, UnityEngine.Vector2 aUnitsPerUV, int aId = -1)
    {
        var val_8;
        var val_9;
        var val_10;
        UnityEngine.Rect val_11;
        var val_12;
        var val_13;
        var val_14;
        UnityEngine.Rect val_15;
        var val_16;
        System.Single[] val_19;
        var val_20;
        if(aId == 1)
        {
                aId = aId + 1;
        }
        
        if(aInner == false)
        {
            goto label_2;
        }
        
        bool val_1 = this.HasInnerRight();
        if(val_1 == false)
        {
            goto label_2;
        }
        
        if(val_1 == true)
        {
            goto label_3;
        }
        
        val_8 = 1152921509377708096;
        val_9 = 1152921509377708092;
        val_10 = 1152921509377708088;
        val_11 = this._legacyInnerRightCap;
        goto label_4;
        label_2:
        if(true == 0)
        {
                val_12 = 1152921509377708060;
            val_13 = 1152921509377708056;
            val_14 = 1152921509377708052;
            val_15 = this._legacyRightCap;
        }
        else
        {
            
        }
        
        UnityEngine.Rect val_2 = SafeGet<UnityEngine.Rect>(aSource:  475893680, aDefault:  new UnityEngine.Rect() {m_XMin = this._rightCaps, m_YMin = 2.515206E+35f}, aIndex:  null);
        val_19 = this._rightCapColliderSize;
        goto label_7;
        label_3:
        label_4:
        val_16 = -1073689239;
        UnityEngine.Rect val_3 = SafeGet<UnityEngine.Rect>(aSource:  475893680, aDefault:  new UnityEngine.Rect() {m_XMin = this._innerRightCaps, m_YMin = 2.515206E+35f}, aIndex:  null);
        val_19 = this._innerRightCapColliderSize;
        label_7:
        float val_4 = this.SafeGet<System.Single>(aSource:  val_19, aDefault:  val_3.m_XMin, aIndex:  1065353216);
        float val_5 = width;
        if(val_1 != true)
        {
                float val_6 = this.GetBodyMaxHeight();
            float val_8 = -1f;
            val_8 = 475893680 + val_8;
            val_8 = val_8 * 475893680;
            val_20 = val_8 + val_8;
        }
        else
        {
                float val_7 = width;
            val_20 = 475893680 * 475881632;
        }
        
        val_20 = val_20 * aUnitsPerUV.x;
        return (float)val_20;
    }
    public UnityEngine.Rect GetLeftCap(bool aInner, UnityEngine.Vector2 aUnitsPerUV, out Ferr2D_CapColliderType aColliderType, out float aColliderCapSize, out float aCapOffset, int aId = -1)
    {
        int val_1;
        int val_39;
        float val_40;
        float val_41;
        float val_42;
        float val_45;
        var val_46;
        var val_47;
        float val_48;
        float val_49;
        int val_50;
        float val_51;
        float val_52;
        float val_53;
        var val_54;
        var val_55;
        if(val_1 == 1)
        {
                val_1 = val_1 + 1;
        }
        
        aCapOffset = 1f;
        aColliderCapSize = 0f;
        mem2[0] = 0f;
        if(aUnitsPerUV.x != 0f)
        {
                if((aInner + 76) != 0)
        {
                0f = mem[aInner + 76 + 12];
            0f = aInner + 76 + 12;
        }
        
            if(0f == 0)
        {
                val_39 = aInner + 72;
            val_40 = aInner + 68;
            val_41 = aInner + 64;
            val_42 = aInner + 60;
        }
        else
        {
                val_39 = (aInner + 76) + 28;
            val_40 = (aInner + 76) + 24;
            val_41 = (aInner + 76) + 20;
            val_42 = (aInner + 76) + 16;
        }
        
            UnityEngine.Rect val_2 = SafeGet<UnityEngine.Rect>(aSource:  aInner, aDefault:  new UnityEngine.Rect() {m_XMin = aInner + 76, m_YMin = val_42, m_Width = val_41, m_Height = val_40}, aIndex:  val_39);
            float val_3 = width;
            val_45 = this;
            if(0f == 0)
        {
                float val_4 = aInner.GetBodyMaxHeight();
            val_46 = aInner;
            val_47 = val_46 + val_46;
        }
        else
        {
                val_47 = 476153272;
        }
        
            float val_6 = aInner.SafeGet<System.Single>(aSource:  aInner + 84, aDefault:  width, aIndex:  1065353216);
            aCapOffset = aInner;
            float val_7 = width;
            float val_20 = -1f;
            val_47 = val_47 * aUnitsPerUV.y;
            val_20 = aCapOffset + val_20;
            if(0f == 0)
        {
                val_48 = val_20;
        }
        
            val_20 = val_47 * val_48;
            aCapOffset = val_20;
            float val_8 = aInner.SafeGet<System.Single>(aSource:  aInner + 92, aDefault:  val_20, aIndex:  0);
            mem2[0] = aInner + 20;
            aColliderCapSize = aInner.SafeGet<System.Int32>(aSource:  aInner + 88, aDefault:  0, aIndex:  val_1);
            float val_10 = width;
            if(0f != 0)
        {
                return new UnityEngine.Rect() {m_XMin = val_49, m_YMin = val_12.m_YMin, m_Width = val_48, m_Height = val_12.m_Height};
        }
        
            float val_11 = height;
            if(0f != 0)
        {
                return new UnityEngine.Rect() {m_XMin = val_49, m_YMin = val_12.m_YMin, m_Width = val_48, m_Height = val_12.m_Height};
        }
        
        }
        
        if((aInner + 40 + 12) == 0)
        {
                val_50 = aInner + 36;
            val_51 = aInner + 32;
            val_52 = aInner + 28;
            val_53 = aInner + 24;
        }
        else
        {
                val_50 = (aInner + 40) + 28;
            val_51 = (aInner + 40) + 24;
            val_52 = (aInner + 40) + 20;
            val_53 = (aInner + 40) + 16;
        }
        
        val_45 = mem[(aInner + 40 + 20)];
        val_45 = val_52;
        UnityEngine.Rect val_12 = SafeGet<UnityEngine.Rect>(aSource:  aInner, aDefault:  new UnityEngine.Rect() {m_XMin = aInner + 40, m_YMin = val_53, m_Width = val_45, m_Height = val_51}, aIndex:  val_50);
        float val_13 = width;
        if((aInner + 40 + 12) == 0)
        {
                float val_14 = aInner.GetBodyMaxHeight();
            val_54 = aInner;
            val_55 = val_54 + val_54;
        }
        else
        {
                val_55 = 476153272;
        }
        
        float val_16 = aInner.SafeGet<System.Single>(aSource:  aInner + 48, aDefault:  width, aIndex:  1065353216);
        aCapOffset = aInner;
        float val_17 = width;
        float val_21 = -1f;
        val_55 = val_55 * aUnitsPerUV.y;
        val_21 = aCapOffset + val_21;
        if((aInner + 40 + 12) == 0)
        {
                val_48 = val_21;
        }
        
        val_21 = val_55 * val_48;
        aCapOffset = val_21;
        float val_18 = aInner.SafeGet<System.Single>(aSource:  aInner + 56, aDefault:  val_21, aIndex:  0);
        val_49 = aInner;
        mem2[0] = aInner + 20;
        aColliderCapSize = aInner.SafeGet<System.Int32>(aSource:  aInner + 52, aDefault:  0, aIndex:  val_1);
        return new UnityEngine.Rect() {m_XMin = val_49, m_YMin = val_12.m_YMin, m_Width = val_48, m_Height = val_12.m_Height};
    }
    public UnityEngine.Rect GetRightCap(bool aInner, UnityEngine.Vector2 aUnitsPerUV, out Ferr2D_CapColliderType aColliderType, out float aColliderCapSize, out float aCapOffset, int aId = -1)
    {
        int val_1;
        int val_39;
        float val_40;
        float val_41;
        float val_42;
        float val_45;
        var val_46;
        var val_47;
        float val_48;
        float val_49;
        int val_50;
        float val_51;
        float val_52;
        float val_53;
        var val_54;
        var val_55;
        if(val_1 == 1)
        {
                val_1 = val_1 + 1;
        }
        
        aCapOffset = 1f;
        aColliderCapSize = 0f;
        mem2[0] = 0f;
        if(aUnitsPerUV.x != 0f)
        {
                if((aInner + 148) != 0)
        {
                0f = mem[aInner + 148 + 12];
            0f = aInner + 148 + 12;
        }
        
            if(0f == 0)
        {
                val_39 = aInner + 144;
            val_40 = aInner + 140;
            val_41 = aInner + 136;
            val_42 = aInner + 132;
        }
        else
        {
                val_39 = (aInner + 148) + 28;
            val_40 = (aInner + 148) + 24;
            val_41 = (aInner + 148) + 20;
            val_42 = (aInner + 148) + 16;
        }
        
            UnityEngine.Rect val_2 = SafeGet<UnityEngine.Rect>(aSource:  aInner, aDefault:  new UnityEngine.Rect() {m_XMin = aInner + 148, m_YMin = val_42, m_Width = val_41, m_Height = val_40}, aIndex:  val_39);
            float val_3 = width;
            val_45 = this;
            if(0f == 0)
        {
                float val_4 = aInner.GetBodyMaxHeight();
            val_46 = aInner;
            val_47 = val_46 + val_46;
        }
        else
        {
                val_47 = 476289656;
        }
        
            float val_6 = aInner.SafeGet<System.Single>(aSource:  aInner + 156, aDefault:  width, aIndex:  1065353216);
            aCapOffset = aInner;
            float val_7 = width;
            float val_20 = -1f;
            val_47 = val_47 * aUnitsPerUV.y;
            val_20 = aCapOffset + val_20;
            if(0f == 0)
        {
                val_48 = val_20;
        }
        
            val_20 = val_47 * val_48;
            aCapOffset = val_20;
            float val_8 = aInner.SafeGet<System.Single>(aSource:  aInner + 164, aDefault:  val_20, aIndex:  0);
            mem2[0] = aInner + 20;
            aColliderCapSize = aInner.SafeGet<System.Int32>(aSource:  aInner + 160, aDefault:  0, aIndex:  val_1);
            float val_10 = width;
            if(0f != 0)
        {
                return new UnityEngine.Rect() {m_XMin = val_49, m_YMin = val_12.m_YMin, m_Width = val_48, m_Height = val_12.m_Height};
        }
        
            float val_11 = height;
            if(0f != 0)
        {
                return new UnityEngine.Rect() {m_XMin = val_49, m_YMin = val_12.m_YMin, m_Width = val_48, m_Height = val_12.m_Height};
        }
        
        }
        
        if((aInner + 112 + 12) == 0)
        {
                val_50 = aInner + 108;
            val_51 = aInner + 104;
            val_52 = aInner + 100;
            val_53 = aInner + 96;
        }
        else
        {
                val_50 = (aInner + 112) + 28;
            val_51 = (aInner + 112) + 24;
            val_52 = (aInner + 112) + 20;
            val_53 = (aInner + 112) + 16;
        }
        
        val_45 = mem[(aInner + 112 + 20)];
        val_45 = val_52;
        UnityEngine.Rect val_12 = SafeGet<UnityEngine.Rect>(aSource:  aInner, aDefault:  new UnityEngine.Rect() {m_XMin = aInner + 112, m_YMin = val_53, m_Width = val_45, m_Height = val_51}, aIndex:  val_50);
        float val_13 = width;
        if((aInner + 112 + 12) == 0)
        {
                float val_14 = aInner.GetBodyMaxHeight();
            val_54 = aInner;
            val_55 = val_54 + val_54;
        }
        else
        {
                val_55 = 476289656;
        }
        
        float val_16 = aInner.SafeGet<System.Single>(aSource:  aInner + 120, aDefault:  width, aIndex:  1065353216);
        aCapOffset = aInner;
        float val_17 = width;
        float val_21 = -1f;
        val_55 = val_55 * aUnitsPerUV.y;
        val_21 = aCapOffset + val_21;
        if((aInner + 112 + 12) == 0)
        {
                val_48 = val_21;
        }
        
        val_21 = val_55 * val_48;
        aCapOffset = val_21;
        float val_18 = aInner.SafeGet<System.Single>(aSource:  aInner + 128, aDefault:  val_21, aIndex:  0);
        val_49 = aInner;
        mem2[0] = aInner + 20;
        aColliderCapSize = aInner.SafeGet<System.Int32>(aSource:  aInner + 124, aDefault:  0, aIndex:  val_1);
        return new UnityEngine.Rect() {m_XMin = val_49, m_YMin = val_12.m_YMin, m_Width = val_48, m_Height = val_12.m_Height};
    }
    private T SafeGet<T>(T[] aSource, T aDefault, int aIndex)
    {
        if(aSource == null)
        {
                return (int)aDefault;
        }
        
        if(aSource <= aIndex)
        {
                return (int)aDefault;
        }
        
        aDefault = aSource[aIndex];
        return (int)aDefault;
    }
    private void SafeSet<T>(ref T[] aSource, T aValue, int aIndex)
    {
        T[] val_3 = aSource;
        if(val_3 != null)
        {
            goto label_0;
        }
        
        aSource = __RuntimeMethodHiddenParam + 24;
        val_3 = aSource;
        if(val_3 == null)
        {
            goto label_2;
        }
        
        label_0:
        if((mem[__RuntimeMethodHiddenParam + 24 + 12]) <= aIndex)
        {
                int val_1 = aIndex + 1;
        }
        
        T[] val_2 = aSource + (aIndex << 2);
        mem2[0] = aValue;
        return;
        label_2:
    }
    public float GetBodyWeight(int aBodyId)
    {
        if(this._bodyWeights == null)
        {
                return (float)S0;
        }
        
        if(this <= aBodyId)
        {
                return (float)S0;
        }
        
        if(this == aBodyId)
        {
                this._bodyWeights[aBodyId] = 1f;
        }
        
        return this._bodyWeights[aBodyId];
    }
    public int GetRandomBodyId(float aRandValue01)
    {
        float val_3;
        var val_4;
        var val_5;
        val_3 = 0f;
        val_4 = 0;
        goto label_0;
        label_2:
        float val_1 = this.GetBodyWeight(aBodyId:  0);
        val_4 = 1;
        val_3 = val_3 + 476991152;
        label_0:
        if(val_4 < this)
        {
            goto label_2;
        }
        
        val_3 = val_3 * R1;
        float val_3 = 0f;
        val_5 = 0;
        goto label_3;
        label_6:
        float val_2 = this.GetBodyWeight(aBodyId:  0);
        val_3 = val_3 + 476991152;
        if(val_4 <= this)
        {
                return 0;
        }
        
        val_5 = 1;
        label_3:
        if(val_5 < this)
        {
            goto label_6;
        }
        
        return 0;
    }
    public UnityEngine.Rect GetBody(int aBodyId)
    {
        var val_1 = (aBodyId + 168) + (R2 << 4);
        val_1 = val_1 + 16;
        return new UnityEngine.Rect();
    }
    public float GetYOffset(bool aInvert, UnityEngine.Vector2 aUnitsPerUV)
    {
        float val_1 = this.GetBodyMaxHeight();
        uint val_2 = 477288880;
        val_2 = this._yOffsetPercent * val_2;
        if(aInvert == true)
        {
                this._yOffset = -this._yOffset;
        }
        
        return (float)-this._yOffset;
    }
    public float GetYOffsetCollider(bool aInvert, UnityEngine.Vector2 aUnitsPerUV)
    {
        float val_1 = this.GetBodyMaxHeight();
        uint val_2 = 477400880;
        val_2 = val_2 * aUnitsPerUV.y;
        if(aInvert == false)
        {
                return (float)this._yOffset;
        }
        
        return (float)this._yOffset;
    }
    public float GetBodyMaxHeight()
    {
        float val_3;
        var val_4;
        var val_5;
        val_3 = 0f;
        val_4 = 0;
        val_5 = 16;
        goto label_0;
        label_7:
        float val_1 = this._bodies[val_5].height;
        var val_3 = this._bodies[val_5];
        if(this > val_4)
        {
                val_3 = this._bodies[val_5];
        }
        
        val_5 = 32;
        val_4 = 1;
        label_0:
        if(val_4 < this._bodies[val_5])
        {
            goto label_7;
        }
        
        return (float)this._bodies[val_5].height;
    }
    public Ferr2DT_TerrainDirection get_applyTo()
    {
    
    }
    public void set_applyTo(Ferr2DT_TerrainDirection value)
    {
        this._applyTo = value;
    }
    public float get_zOffset()
    {
        return (float)S0;
    }
    public void set_zOffset(float value)
    {
        this._zOffset = ;
    }
    public float get_yOffset()
    {
        return (float)S0;
    }
    public void set_yOffset(float value)
    {
        this._yOffset = ;
    }
    public float get_capOffset()
    {
        return (float)S0;
    }
    public void set_capOffset(float value)
    {
        this._capOffset = ;
    }
    public UnityEngine.Rect get_leftCap()
    {
        if((R1 + 40 + 12) == 0)
        {
                var val_1 = R1 + 24;
            return new UnityEngine.Rect();
        }
        
        var val_2 = (R1 + 40) + 16;
        return new UnityEngine.Rect();
    }
    public void set_leftCap(UnityEngine.Rect value)
    {
        UnityEngine.Rect[] val_1 = this._leftCaps;
        if(true == 0)
        {
                this._leftCaps = 536882297;
            val_1 = this._leftCaps;
            if(val_1 == null)
        {
                val_1 = 0;
        }
        
        }
        
        mem[16] = value.m_XMin;
        mem[20] = value.m_YMin;
        mem[24] = value.m_Width;
        mem[28] = value.m_Height;
    }
    public UnityEngine.Rect get_innerLeftCap()
    {
        if((R1 + 76 + 12) == 0)
        {
                var val_1 = R1 + 60;
            return new UnityEngine.Rect();
        }
        
        var val_2 = (R1 + 76) + 16;
        return new UnityEngine.Rect();
    }
    public void set_innerLeftCap(UnityEngine.Rect value)
    {
        UnityEngine.Rect[] val_1 = this._innerLeftCaps;
        if(true == 0)
        {
                this._innerLeftCaps = 536882297;
            val_1 = this._innerLeftCaps;
            if(val_1 == null)
        {
                val_1 = 0;
        }
        
        }
        
        mem[16] = value.m_XMin;
        mem[20] = value.m_YMin;
        mem[24] = value.m_Width;
        mem[28] = value.m_Height;
    }
    public UnityEngine.Rect get_rightCap()
    {
        if((R1 + 112 + 12) == 0)
        {
                var val_1 = R1 + 96;
            return new UnityEngine.Rect();
        }
        
        var val_2 = (R1 + 112) + 16;
        return new UnityEngine.Rect();
    }
    public void set_rightCap(UnityEngine.Rect value)
    {
        UnityEngine.Rect[] val_1 = this._rightCaps;
        if(true == 0)
        {
                this._rightCaps = 536882297;
            val_1 = this._rightCaps;
            if(val_1 == null)
        {
                val_1 = 0;
        }
        
        }
        
        mem[16] = value.m_XMin;
        mem[20] = value.m_YMin;
        mem[24] = value.m_Width;
        mem[28] = value.m_Height;
    }
    public UnityEngine.Rect get_innerRightCap()
    {
        if((R1 + 148 + 12) == 0)
        {
                var val_1 = R1 + 132;
            return new UnityEngine.Rect();
        }
        
        var val_2 = (R1 + 148) + 16;
        return new UnityEngine.Rect();
    }
    public void set_innerRightCap(UnityEngine.Rect value)
    {
        UnityEngine.Rect[] val_1 = this._innerRightCaps;
        if(true == 0)
        {
                this._innerRightCaps = 536882297;
            val_1 = this._innerRightCaps;
            if(val_1 == null)
        {
                val_1 = 0;
        }
        
        }
        
        mem[16] = value.m_XMin;
        mem[20] = value.m_YMin;
        mem[24] = value.m_Width;
        mem[28] = value.m_Height;
    }
    public UnityEngine.Rect[] get_body()
    {
    
    }
    public void set_body(UnityEngine.Rect[] value)
    {
        this._bodies = value;
    }
    public Ferr2DT_SegmentDescription()
    {
        this._colliderThickness = 1f;
        UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
        var val_2 = 536882297 + 16;
        this._bodies = 536882297;
        mem[1152921509382135096] = 0;
    }

}
