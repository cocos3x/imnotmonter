using UnityEngine;
public class Ferr2DT_TerrainMaterial : MonoBehaviour, IFerr2DTMaterial
{
    // Fields
    private UnityEngine.Material _fillMaterial;
    private UnityEngine.Material _edgeMaterial;
    private Ferr2DT_SegmentDescription[] descriptors;
    private bool isPixel;
    
    // Properties
    public UnityEngine.Material fillMaterial { get; set; }
    public UnityEngine.Material edgeMaterial { get; set; }
    public int descriptorCount { get; }
    
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
        if(this.descriptors != null)
        {
                return (int)this;
        }
        
        return (int)this;
    }
    public Ferr2DT_TerrainMaterial()
    {
        var val_2;
        this.descriptors = 536881931;
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
        val_3 = this.descriptors;
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
        val_3 = this.descriptors;
        if(val_3 != null)
        {
            
        }
        else
        {
                val_3 = 0;
        }
        
        if(val_1 >= 23000375)
        {
            goto label_7;
        }
        
        label_3:
        if(0 != aDirection)
        {
            goto label_10;
        }
        
        val_5 = this.descriptors[1];
        return;
        label_7:
        if(this != 0)
        {
                val_5 = this.descriptors[0];
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
        
            Ferr2DT_SegmentDescription val_1 = this.descriptors[val_2];
            val_2 = val_2 + 1;
        }
        while(this.descriptors[0x0][0]._applyTo != aDirection);
        
        return true;
    }
    public void Set(Ferr2DT_TerrainDirection aDirection, bool aActive)
    {
        Ferr2DT_SegmentDescription val_4;
        Ferr2DT_SegmentDescription val_5;
        val_4 = aActive;
        val_5 = this.descriptors[aDirection];
        if(val_4 != false)
        {
                if(this.descriptors[aDirection][0]._applyTo == aDirection)
        {
                return;
        }
        
            val_5 = this.descriptors;
            Ferr2DT_SegmentDescription val_1 = 536886779;
            val_4 = val_1;
            val_1 = new Ferr2DT_SegmentDescription();
            val_5[aDirection] = val_4;
            Ferr2DT_SegmentDescription val_3 = this.descriptors[aDirection];
            this.descriptors[aDirection][0]._applyTo = aDirection;
            return;
        }
        
        if(this.descriptors[aDirection][0]._applyTo == 0)
        {
                return;
        }
        
        Ferr2DT_SegmentDescription val_2 = 536886779;
        val_2 = new Ferr2DT_SegmentDescription();
        this.descriptors[aDirection] = val_2;
    }
    public UnityEngine.Rect ToUV(UnityEngine.Rect aNativeRect)
    {
        var val_10 = 23000377;
        if((aNativeRect.m_XMin + 16) == 0)
        {
                return new UnityEngine.Rect() {m_XMin = val_8, m_Width = 482354464};
        }
        
        float val_3 = aNativeRect.m_YMin.x;
        float val_4 = aNativeRect.m_YMin.height;
        float val_5 = aNativeRect.m_YMin.y;
        float val_10 = 1f;
        val_10 = val_10 - 482354464;
        float val_6 = val_10 - 482354464;
        float val_7 = aNativeRect.m_YMin.width;
        float val_8 = aNativeRect.m_YMin.height;
        this = new UnityEngine.Rect(x:  val_8, y:  null, width:  482354464, height:  null);
        return new UnityEngine.Rect() {m_XMin = val_8, m_Width = 482354464};
    }
    public UnityEngine.Rect ToScreen(UnityEngine.Rect aNativeRect)
    {
        UnityEngine.Material val_1;
        bool val_2 = UnityEngine.Object.op_Equality(x:  aNativeRect.m_XMin + 16, y:  0);
        mem[1152921509384292792] = aNativeRect.m_Height;
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
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        UnityEngine.Rect val_18;
        float val_19;
        var val_20;
        var val_21;
        var val_22;
        UnityEngine.Rect val_23;
        if(this.isPixel == false)
        {
                return;
        }
        
        val_13 = 0;
        goto label_1;
        label_33:
        val_14 = 0;
        goto label_2;
        label_17:
        Ferr2DT_SegmentDescription val_9 = this.descriptors[val_13];
        UnityEngine.Rect val_13 = this.descriptors[0x0][0]._bodies[val_14];
        UnityEngine.Rect val_1 = ToNative(aPixelRect:  new UnityEngine.Rect() {m_XMin = 1.350907E-21f, m_YMin = this.descriptors[0x0][0]._bodies[0], m_Width = this.descriptors[0x0][0]._bodies[val_14], m_Height = this.descriptors[0x0][0]._bodies[val_14]});
        var val_2 = (R6 + 168) + 16;
        val_14 = 1;
        label_2:
        Ferr2DT_SegmentDescription val_14 = this.descriptors[val_13];
        Ferr2DT_SegmentDescription val_15 = this.descriptors[val_13];
        if(val_14 < this.descriptors[0x0][0]._bodies)
        {
            goto label_17;
        }
        
        Ferr2DT_SegmentDescription val_16 = this.descriptors[val_13];
        if(this.descriptors[val_13] == null)
        {
                val_15 = val_16 + 36;
            val_16 = val_16 + 32;
            val_17 = val_16 + 28;
            val_18 = this.descriptors[0x0][0]._legacyLeftCap;
        }
        else
        {
            
        }
        
        UnityEngine.Rect val_3 = ToNative(aPixelRect:  new UnityEngine.Rect() {m_XMin = 1.350907E-21f, m_YMin = 2.515206E+35f, m_Width = 2.515206E+35f});
        val_19 = val_6;
        if(val_15 == 0)
        {
                val_19 = val_19;
        }
        
        val_15.leftCap = new UnityEngine.Rect() {m_XMin = val_4, m_YMin = val_5, m_Width = val_19, m_Height = val_7};
        Ferr2DT_SegmentDescription val_17 = this.descriptors[val_13];
        Ferr2DT_SegmentDescription val_18 = this.descriptors[val_13];
        if(this.descriptors[val_13] == null)
        {
                val_20 = val_18 + 108;
            val_21 = val_18 + 104;
            val_22 = val_18 + 100;
            val_23 = this.descriptors[0x0][0]._legacyRightCap;
        }
        else
        {
            
        }
        
        UnityEngine.Rect val_8 = ToNative(aPixelRect:  new UnityEngine.Rect() {m_XMin = 1.350907E-21f, m_YMin = 2.515206E+35f, m_Width = 2.515206E+35f});
        val_17.rightCap = new UnityEngine.Rect() {m_XMin = val_4, m_YMin = val_5, m_Width = val_6, m_Height = val_7};
        val_13 = 1;
        label_1:
        if(val_13 < val_17)
        {
            goto label_33;
        }
        
        this.isPixel = false;
    }
    public UnityEngine.Rect ToNative(UnityEngine.Rect aPixelRect)
    {
        UnityEngine.Object val_12 = mem[aPixelRect.m_XMin + 16];
        val_12 = aPixelRect.m_XMin + 16;
        if(val_12 == 0)
        {
                return new UnityEngine.Rect() {m_XMin = val_12, m_Width = val_13};
        }
        
        float val_3 = aPixelRect.m_YMin.x;
        UnityEngine.Texture val_4 = aPixelRect.m_XMin + 16.mainTexture;
        float val_5 = aPixelRect.m_YMin.y;
        UnityEngine.Texture val_6 = aPixelRect.m_XMin + 16.mainTexture;
        float val_7 = aPixelRect.m_YMin.width;
        UnityEngine.Texture val_8 = aPixelRect.m_XMin + 16.mainTexture;
        float val_9 = aPixelRect.m_YMin.height;
        val_12 = 0;
        UnityEngine.Texture val_10 = aPixelRect.m_XMin + 16.mainTexture;
        float val_12 = (float)aPixelRect.m_XMin + 16;
        float val_13 = (float)aPixelRect.m_XMin + 16;
        float val_14 = (float)aPixelRect.m_XMin + 16;
        float val_15 = (float)aPixelRect.m_XMin + 16;
        val_12 = aPixelRect.m_YMin / val_12;
        val_13 = aPixelRect.m_YMin / val_13;
        val_14 = 483670808 / val_14;
        val_15 = 483670808 / val_15;
        this = new UnityEngine.Rect(x:  val_12, y:  null, width:  val_13, height:  null);
        return new UnityEngine.Rect() {m_XMin = val_12, m_Width = val_13};
    }
    public UnityEngine.Rect ToPixels(UnityEngine.Rect aNativeRect)
    {
        UnityEngine.Object val_12 = mem[aNativeRect.m_XMin + 16];
        val_12 = aNativeRect.m_XMin + 16;
        if(val_12 == 0)
        {
                return new UnityEngine.Rect() {m_XMin = val_15, m_Width = val_13};
        }
        
        float val_3 = aNativeRect.m_YMin.x;
        UnityEngine.Texture val_4 = aNativeRect.m_XMin + 16.mainTexture;
        float val_5 = aNativeRect.m_YMin.y;
        UnityEngine.Texture val_6 = aNativeRect.m_XMin + 16.mainTexture;
        float val_7 = aNativeRect.m_YMin.width;
        UnityEngine.Texture val_8 = aNativeRect.m_XMin + 16.mainTexture;
        float val_9 = aNativeRect.m_YMin.height;
        val_12 = 0;
        UnityEngine.Texture val_10 = aNativeRect.m_XMin + 16.mainTexture;
        float val_12 = (float)aNativeRect.m_XMin + 16;
        float val_13 = (float)aNativeRect.m_XMin + 16;
        float val_14 = (float)aNativeRect.m_XMin + 16;
        val_12 = aNativeRect.m_YMin * val_12;
        val_13 = aNativeRect.m_YMin * val_13;
        val_14 = 483782808 * val_14;
        float val_15 = (float)aNativeRect.m_XMin + 16;
        val_15 = 483782808 * val_15;
        this = new UnityEngine.Rect(x:  val_15, y:  null, width:  val_13, height:  null);
        return new UnityEngine.Rect() {m_XMin = val_15, m_Width = val_13};
    }
    public void Add()
    {
        System.Array.Resize<ClipInfos>(array: ref  T[] val_1 = 483943748, newSize:  22752889);
        Ferr2DT_SegmentDescription val_2 = 536886779;
        val_2 = new Ferr2DT_SegmentDescription();
        val_2 = val_2 - 1;
        mem[536886787] = val_2;
        this.descriptors[val_2 - 1] = val_2;
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
        var val_2 = 23000382 + (val_7 << 2);
        val_1 = val_1 - 1;
        mem2[0] = (23000382 + (aDirection) << 2) + 20;
        val_7 = val_1 + 1;
        val_8 = val_8 + 4;
        label_2:
        val_9 = mem[this.descriptors];
        if(mem[this.descriptors] == 0)
        {
                val_9 = mem[this.descriptors];
        }
        
        var val_5 = mem[this.descriptors] + 12;
        val_5 = val_5 - 1;
        if(val_7 < val_5)
        {
            goto label_9;
        }
        
        System.Array.Resize<ClipInfos>(array: ref  this.descriptors, newSize:  (mem[this.descriptors] + 12) - 1);
        return;
        label_1:
        this.Set(aDirection:  val_7, aActive:  false);
    }
    public Ferr2DT_Material CreateNewFormatMaterial()
    {
        float val_6;
        float val_7;
        float val_8;
        float val_9;
        float val_10;
        float val_11;
        float val_12;
        float val_13;
        float val_14;
        float val_15;
        float val_16;
        bool val_17;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        TMPro.TMP_FontAsset val_1 = UnityEngine.ScriptableObject.CreateInstance<TMPro.TMP_FontAsset>();
        mem[3221279367] = this._edgeMaterial;
        mem[3221279363] = this._fillMaterial;
        var val_5 = 0;
        do
        {
            if((this.Has(aDirection:  0)) != false)
        {
                if((-1073687945) != 0)
        {
                -1073687945.Set(aDirection:  0, aActive:  true);
        }
        else
        {
                -1073687945.Set(aDirection:  0, aActive:  true);
        }
        
            Ferr2DT_SegmentDescription val_3 = -1073687945.GetDescriptor(aDirection:  0);
            Ferr2DT_SegmentDescription val_4 = this.GetDescriptor(aDirection:  0);
            if((-1073687945) != 0)
        {
                mem[3221279359] = ???;
        }
        else
        {
                mem[8] = ???;
        }
        
            mem[3221279519] = ???;
            mem[3221279371] = this.descriptors;
            val_6 = 1152921509386080376;
            val_7 = 1152921509386080372;
            val_8 = 1152921509386080368;
            val_9 = 1152921509386080364;
            -1073687945.innerLeftCap = new UnityEngine.Rect() {};
            if( != 0)
        {
                -1073687945 = mem[(0 + 24) + 12];
            -1073687945 = (0 + 24) + 12;
        }
        
            if((-1073687945) == 0)
        {
                val_10 = 1152921509386080448;
            val_11 = 1152921509386080444;
            val_12 = 1152921509386080440;
            val_13 = 1152921509386080436;
        }
        else
        {
                val_10 =  + 28;
            val_11 =  + 24;
            val_12 =  + 20;
            val_13 =  + 16;
        }
        
            -1073687945.innerRightCap = new UnityEngine.Rect() {m_XMin = val_13, m_YMin = val_12, m_Width = val_11, m_Height = val_10};
            if(val_11 != 0)
        {
                -1073687945 = mem[((0 + 24) + 24) + 12];
            -1073687945 = ((0 + 24) + 24) + 12;
        }
        
            if((-1073687945) == 0)
        {
                val_14 = 1152921509386080340;
            val_15 = 1152921509386080336;
            val_16 = 1152921509386080332;
            val_17 = this.isPixel;
        }
        else
        {
                val_14 = val_11 + 28;
            val_15 = val_11 + 24;
            val_16 = val_11 + 20;
            val_17 = val_11 + 16;
        }
        
            -1073687945.leftCap = new UnityEngine.Rect() {m_XMin = val_17, m_YMin = val_16, m_Width = val_15, m_Height = val_14};
            if(val_15 != 0)
        {
                -1073687945 = mem[(((0 + 24) + 24) + 24) + 12];
            -1073687945 = (((0 + 24) + 24) + 24) + 12;
        }
        
            if((-1073687945) == 0)
        {
                val_18 = 1152921509386080412;
            val_19 = 1152921509386080408;
            val_20 = 1152921509386080404;
            val_21 = 1152921509386080400;
        }
        else
        {
                val_18 = val_15 + 28;
            val_19 = val_15 + 24;
            val_20 = val_15 + 20;
            val_21 = val_15 + 16;
        }
        
            -1073687945.rightCap = new UnityEngine.Rect() {m_XMin = val_21, m_YMin = val_20, m_Width = val_19, m_Height = val_18};
            mem[3221279367] = this._edgeMaterial;
            mem[3221279363] = this._fillMaterial;
        }
        
            val_5 = val_5 + 1;
        }
        while(val_5 != 4);
    
    }
    private string IFerr2DTMaterial.get_name()
    {
        return this.name;
    }

}
