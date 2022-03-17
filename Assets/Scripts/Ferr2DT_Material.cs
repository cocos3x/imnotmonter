using UnityEngine;
public class Ferr2DT_Material : ScriptableObject, IFerr2DTMaterial
{
    // Fields
    private UnityEngine.Material _fillMaterial;
    private UnityEngine.Material _edgeMaterial;
    private Ferr2DT_SegmentDescription[] _descriptors;
    private bool isPixel;
    private bool _isPerfect;
    
    // Properties
    public UnityEngine.Material fillMaterial { get; set; }
    public UnityEngine.Material edgeMaterial { get; set; }
    public int descriptorCount { get; }
    public bool IsPerfect { get; }
    
    // Methods
    public UnityEngine.Material get_fillMaterial()
    {
    
    }
    public void set_fillMaterial(UnityEngine.Material value)
    {
        this._fillMaterial = value;
    }
    public UnityEngine.Material get_edgeMaterial()
    {
    
    }
    public void set_edgeMaterial(UnityEngine.Material value)
    {
        this._edgeMaterial = value;
    }
    public int get_descriptorCount()
    {
        if(this._descriptors != null)
        {
                return (int)this;
        }
        
        return (int)this;
    }
    public bool get_IsPerfect()
    {
        return (bool)this._isPerfect;
    }
    public Ferr2DT_Material()
    {
        var val_2;
        this._descriptors = 536881931;
        this.isPixel = true;
        val_2 = 0;
        goto label_1;
        label_7:
        Ferr2DT_SegmentDescription val_1 = 536886779;
        val_1 = new Ferr2DT_SegmentDescription();
        mem[536881947] = val_1;
        val_2 = 1;
        label_1:
        if(val_2 < mem[536881943])
        {
            goto label_7;
        }
    
    }
    public Ferr2DT_SegmentDescription GetDescriptor(Ferr2DT_TerrainDirection aDirection)
    {
        var val_2;
        Ferr2DT_SegmentDescription[] val_3;
        Ferr2DT_SegmentDescription val_5;
        this.ConvertToPercentage();
        val_2 = 4;
        goto label_1;
        label_10:
        val_2 = 5;
        label_1:
        val_3 = this._descriptors;
        var val_1 = val_2 - 4;
        if(val_3 == null)
        {
            goto label_2;
        }
        
        if(val_1 < this)
        {
            goto label_3;
        }
        
        goto label_7;
        label_2:
        val_3 = this._descriptors;
        if(val_3 != null)
        {
            
        }
        else
        {
                val_3 = 0;
        }
        
        if(val_1 >= 22968921)
        {
            goto label_7;
        }
        
        label_3:
        if(0 != aDirection)
        {
            goto label_10;
        }
        
        val_5 = this._descriptors[1];
        return;
        label_7:
        if(this != 0)
        {
                val_5 = this._descriptors[0];
            return;
        }
        
        Ferr2DT_SegmentDescription val_2 = 536886779;
        val_5 = val_2;
        val_2 = new Ferr2DT_SegmentDescription();
    }
    public bool Has(Ferr2DT_TerrainDirection aDirection)
    {
        var val_2 = 0;
        do
        {
            if(val_2 >= this)
        {
                return false;
        }
        
            Ferr2DT_SegmentDescription val_1 = this._descriptors[val_2];
            val_2 = val_2 + 1;
        }
        while(this._descriptors[0x0][0]._applyTo != aDirection);
        
        return true;
    }
    public void Set(Ferr2DT_TerrainDirection aDirection, bool aActive)
    {
        Ferr2DT_SegmentDescription val_4;
        Ferr2DT_SegmentDescription val_5;
        val_4 = aActive;
        val_5 = this._descriptors[aDirection];
        if(val_4 != false)
        {
                if(this._descriptors[aDirection][0]._applyTo == aDirection)
        {
                return;
        }
        
            val_5 = this._descriptors;
            Ferr2DT_SegmentDescription val_1 = 536886779;
            val_4 = val_1;
            val_1 = new Ferr2DT_SegmentDescription();
            val_5[aDirection] = val_4;
            Ferr2DT_SegmentDescription val_3 = this._descriptors[aDirection];
            this._descriptors[aDirection][0]._applyTo = aDirection;
            return;
        }
        
        if(this._descriptors[aDirection][0]._applyTo == 0)
        {
                return;
        }
        
        Ferr2DT_SegmentDescription val_2 = 536886779;
        val_2 = new Ferr2DT_SegmentDescription();
        this._descriptors[aDirection] = val_2;
    }
    public UnityEngine.Rect ToUV(UnityEngine.Rect aNativeRect)
    {
        var val_10 = 22968923;
        if((aNativeRect.m_XMin + 16) == 0)
        {
                return new UnityEngine.Rect() {m_XMin = val_8, m_Width = 449502016};
        }
        
        float val_3 = aNativeRect.m_YMin.x;
        float val_4 = aNativeRect.m_YMin.height;
        float val_5 = aNativeRect.m_YMin.y;
        float val_10 = 1f;
        val_10 = val_10 - 449502016;
        float val_6 = val_10 - 449502016;
        float val_7 = aNativeRect.m_YMin.width;
        float val_8 = aNativeRect.m_YMin.height;
        this = new UnityEngine.Rect(x:  val_8, y:  null, width:  449502016, height:  null);
        return new UnityEngine.Rect() {m_XMin = val_8, m_Width = 449502016};
    }
    public UnityEngine.Rect ToScreen(UnityEngine.Rect aNativeRect)
    {
        UnityEngine.Material val_1;
        bool val_2 = UnityEngine.Object.op_Equality(x:  aNativeRect.m_XMin + 16, y:  0);
        mem[1152921509351440344] = aNativeRect.m_Height;
        this._fillMaterial = val_1;
        return new UnityEngine.Rect();
    }
    public UnityEngine.Rect GetBody(Ferr2DT_TerrainDirection aDirection, int aBodyID)
    {
        Ferr2DT_TerrainDirection val_2 = aDirection;
        Ferr2DT_SegmentDescription val_1 = val_2.GetDescriptor(aDirection:  aBodyID);
        val_2 = val_2 + (R3 << 4);
        val_2 = val_2 + 16;
        return new UnityEngine.Rect();
    }
    private void ConvertToPercentage()
    {
        float val_4;
        float val_5;
        float val_6;
        float val_7;
        var val_11;
        var val_12;
        float val_13;
        Ferr2DT_SegmentDescription val_14;
        if(this.isPixel == false)
        {
                return;
        }
        
        val_11 = 0;
        goto label_1;
        label_29:
        val_12 = 0;
        goto label_2;
        label_17:
        Ferr2DT_SegmentDescription val_11 = this._descriptors[val_11];
        UnityEngine.Rect val_15 = this._descriptors[0x0][0]._bodies[val_12];
        UnityEngine.Rect val_1 = ToNative(aPixelRect:  new UnityEngine.Rect() {m_XMin = 8.839655E-23f, m_YMin = this._descriptors[0x0][0]._bodies[0], m_Width = this._descriptors[0x0][0]._bodies[val_12], m_Height = this._descriptors[0x0][0]._bodies[val_12]});
        var val_2 = (R6 + 168) + 16;
        val_12 = 1;
        label_2:
        Ferr2DT_SegmentDescription val_16 = this._descriptors[val_11];
        Ferr2DT_SegmentDescription val_17 = this._descriptors[val_11];
        if(val_12 < this._descriptors[0x0][0]._bodies)
        {
            goto label_17;
        }
        
        Ferr2DT_SegmentDescription val_18 = this._descriptors[val_11];
        UnityEngine.Rect val_3 = leftCap;
        UnityEngine.Rect val_8 = ToNative(aPixelRect:  new UnityEngine.Rect() {m_XMin = 8.839655E-23f, m_YMin = val_5, m_Width = val_6, m_Height = val_7});
        val_13 = val_7;
        if(val_17 == 0)
        {
                val_13 = val_13;
        }
        
        val_17.leftCap = new UnityEngine.Rect() {m_XMin = val_5, m_YMin = val_6, m_Width = val_13, m_Height = val_4};
        Ferr2DT_SegmentDescription val_19 = this._descriptors[val_11];
        Ferr2DT_SegmentDescription val_20 = this._descriptors[val_11];
        UnityEngine.Rect val_9 = rightCap;
        UnityEngine.Rect val_10 = ToNative(aPixelRect:  new UnityEngine.Rect() {m_XMin = 8.839655E-23f, m_YMin = val_5, m_Width = val_6, m_Height = val_7});
        val_14 = val_19;
        if(val_14 == 0)
        {
                val_14 = val_19;
        }
        
        val_14.rightCap = new UnityEngine.Rect() {m_XMin = val_5, m_YMin = val_6, m_Width = val_7, m_Height = val_4};
        val_11 = 1;
        label_1:
        if(val_11 < val_14)
        {
            goto label_29;
        }
        
        this.isPixel = false;
    }
    public UnityEngine.Rect ToNative(UnityEngine.Rect aPixelRect)
    {
        var val_17;
        UnityEngine.Object val_18;
        float val_19;
        float val_20;
        val_17 = 22713552;
        val_18 = mem[aPixelRect.m_XMin + 16];
        val_18 = aPixelRect.m_XMin + 16;
        if(val_18 == 0)
        {
                return new UnityEngine.Rect() {m_XMin = val_17, m_Width = val_13};
        }
        
        UnityEngine.Texture val_3 = aPixelRect.m_XMin + 16.mainTexture;
        if((aPixelRect.m_XMin + 16) == 0)
        {
                val_19 = 1f;
        }
        else
        {
                UnityEngine.Texture val_5 = aPixelRect.m_XMin + 16.mainTexture;
            val_19 = (float)aPixelRect.m_XMin + 16;
        }
        
        UnityEngine.Texture val_6 = aPixelRect.m_XMin + 16.mainTexture;
        val_18 = aPixelRect.m_XMin + 16;
        val_17 = 0;
        if(val_18 == 0)
        {
                val_20 = 1f;
        }
        else
        {
                UnityEngine.Texture val_8 = aPixelRect.m_XMin + 16.mainTexture;
            val_20 = (float)aPixelRect.m_XMin + 16;
        }
        
        float val_9 = aPixelRect.m_YMin.x;
        float val_10 = aPixelRect.m_YMin.y;
        float val_11 = aPixelRect.m_YMin.width;
        float val_12 = aPixelRect.m_YMin.height;
        float val_13 = 450670920 / val_19;
        float val_14 = 450670920 / val_20;
        float val_15 = 450670920 / val_19;
        uint val_17 = 450670920;
        val_17 = val_17 / val_20;
        this = new UnityEngine.Rect(x:  val_17, y:  null, width:  val_13, height:  null);
        return new UnityEngine.Rect() {m_XMin = val_17, m_Width = val_13};
    }
    public UnityEngine.Rect ToPixels(UnityEngine.Rect aNativeRect)
    {
        var val_16;
        UnityEngine.Object val_17;
        float val_18;
        float val_19;
        val_16 = 22713552;
        val_17 = mem[aNativeRect.m_XMin + 16];
        val_17 = aNativeRect.m_XMin + 16;
        if(val_17 == 0)
        {
                return new UnityEngine.Rect() {m_XMin = val_17, m_Width = val_16};
        }
        
        UnityEngine.Texture val_3 = aNativeRect.m_XMin + 16.mainTexture;
        if((aNativeRect.m_XMin + 16) == 0)
        {
                val_18 = 1f;
        }
        else
        {
                UnityEngine.Texture val_5 = aNativeRect.m_XMin + 16.mainTexture;
            val_18 = (float)aNativeRect.m_XMin + 16;
        }
        
        UnityEngine.Texture val_6 = aNativeRect.m_XMin + 16.mainTexture;
        val_16 = 0;
        if((aNativeRect.m_XMin + 16) == 0)
        {
                val_19 = 1f;
        }
        else
        {
                UnityEngine.Texture val_8 = aNativeRect.m_XMin + 16.mainTexture;
            val_19 = (float)aNativeRect.m_XMin + 16;
        }
        
        float val_9 = aNativeRect.m_YMin.x;
        float val_10 = aNativeRect.m_YMin.y;
        float val_11 = aNativeRect.m_YMin.width;
        val_17 = ;
        float val_12 = aNativeRect.m_YMin.height;
        uint val_16 = 450782920;
        float val_13 = val_18 * 450782920;
        float val_14 = val_19 * 450782920;
        val_16 = val_18 * val_16;
        uint val_17 = 450782920;
        val_17 = val_19 * val_17;
        this = new UnityEngine.Rect(x:  val_17, y:  null, width:  val_16, height:  null);
        return new UnityEngine.Rect() {m_XMin = val_17, m_Width = val_16};
    }
    public void Add()
    {
        System.Array.Resize<ClipInfos>(array: ref  T[] val_1 = 450943844, newSize:  22752889);
        Ferr2DT_SegmentDescription val_2 = 536886779;
        val_2 = new Ferr2DT_SegmentDescription();
        val_2 = val_2 - 1;
        mem[536886787] = val_2;
        this._descriptors[val_2 - 1] = val_2;
    }
    public void Remove(Ferr2DT_TerrainDirection aDirection)
    {
        Ferr2DT_TerrainDirection val_7;
        var val_8;
        var val_9;
        val_7 = aDirection;
        if(val_7 < 4)
        {
            goto label_1;
        }
        
        val_8 = 16 + (val_7 << 2);
        goto label_2;
        label_9:
        Ferr2DT_TerrainDirection val_1 = val_7 + 1;
        var val_2 = 22968928 + (val_7 << 2);
        val_1 = val_1 - 1;
        mem2[0] = (22968928 + (aDirection) << 2) + 20;
        val_7 = val_1 + 1;
        val_8 = val_8 + 4;
        label_2:
        val_9 = mem[this._descriptors];
        if(mem[this._descriptors] == 0)
        {
                val_9 = mem[this._descriptors];
        }
        
        var val_5 = mem[this._descriptors] + 12;
        val_5 = val_5 - 1;
        if(val_7 < val_5)
        {
            goto label_9;
        }
        
        System.Array.Resize<ClipInfos>(array: ref  this._descriptors, newSize:  (mem[this._descriptors] + 12) - 1);
        return;
        label_1:
        this.Set(aDirection:  val_7, aActive:  false);
    }
    private string IFerr2DTMaterial.get_name()
    {
        return this.name;
    }

}
