using UnityEngine;
public class Ferr2DT_PathTerrain : MonoBehaviour, Ferr2D_IPath, IBlendPaintable
{
    // Fields
    private const int cIntConvert = 1000;
    public float fillY;
    public float fillZ;
    public UnityEngine.Vector2 invertFillBorder;
    public bool splitCorners;
    public float pixelsPerUnit;
    public Ferr2DT_ColorType vertexColorType;
    public UnityEngine.Color vertexColor;
    public UnityEngine.Gradient vertexGradient;
    public float vertexGradientAngle;
    public float vertexGradientDistance;
    public bool createTangents;
    public UnityEngine.Vector2 uvOffset;
    public float slantAmount;
    public bool fillSplit;
    public float fillSplitDistance;
    public bool usedByEffector;
    public bool isTrigger;
    public float depth;
    public UnityEngine.PhysicMaterial physicsMaterial;
    public UnityEngine.PhysicsMaterial2D physicsMaterial2D;
    private Ferr2D_SectionMode edgeMode;
    private Ferr2D_SectionMode fillMode;
    private bool useSkirt;
    private Ferr2D_ColliderMode colliderMode;
    private bool fillCollider;
    private Ferr2DPath pathData;
    private Ferr2DT_TerrainMaterial terrainMaterial;
    private UnityEngine.Object terrainMaterialInterface;
    private Ferr2D_DynamicMesh dMesh;
    private Ferr.RecolorTree recolorTree;
    private UnityEngine.Vector2 unitsPerUV;
    private bool checkedLegacy;
    private bool isLegacy;
    public Ferr2DT_FillMode fill;
    public bool smoothPath;
    public int splitCount;
    public float splitDist;
    public bool splitMiddle;
    public bool randomByWorldCoordinates;
    public bool createCollider;
    public bool create3DCollider;
    public bool sharpCorners;
    public float sharpCornerDistance;
    public bool smoothSphereCollisions;
    public float[] surfaceOffset;
    public bool useEdgeCollider;
    public float colliderThickness;
    public bool collidersLeft;
    public bool collidersRight;
    public bool collidersTop;
    public bool collidersBottom;
    public System.Collections.Generic.List<Ferr2DT_TerrainDirection> directionOverrides;
    public System.Collections.Generic.List<Ferr2DT_PathTerrain.CutOverrides> cutOverrides;
    public System.Collections.Generic.List<float> vertScales;
    private Ferr2D_Path legacyPath;
    
    // Properties
    public Ferr2D_SectionMode FillMode { get; set; }
    public Ferr2D_SectionMode EdgeMode { get; set; }
    public Ferr2D_ColliderMode ColliderMode { get; set; }
    private Ferr2D_DynamicMesh DMesh { get; }
    public IFerr2DTMaterial TerrainMaterial { get; set; }
    public UnityEngine.Mesh MeshData { get; }
    public UnityEngine.MeshFilter MeshFilter { get; }
    public bool IsLegacy { get; }
    public bool CheckedLegacy { get; set; }
    public UnityEngine.Vector2 UnitsPerUV { get; }
    public Ferr2DPath PathData { get; }
    public Ferr2D_Path Path { get; }
    
    // Methods
    public Ferr2D_SectionMode get_FillMode()
    {
    
    }
    public void set_FillMode(Ferr2D_SectionMode value)
    {
        this.fillMode = value;
    }
    public Ferr2D_SectionMode get_EdgeMode()
    {
    
    }
    public void set_EdgeMode(Ferr2D_SectionMode value)
    {
        this.edgeMode = value;
    }
    public Ferr2D_ColliderMode get_ColliderMode()
    {
    
    }
    public void set_ColliderMode(Ferr2D_ColliderMode value)
    {
        this.colliderMode = value;
    }
    private Ferr2D_DynamicMesh get_DMesh()
    {
        if(this.dMesh != 0)
        {
                return;
        }
        
        Ferr2D_DynamicMesh val_1 = 536886805;
        val_1 = new Ferr2D_DynamicMesh();
        mem2[0] = val_1;
    }
    public IFerr2DTMaterial get_TerrainMaterial()
    {
        Ferr2DT_TerrainMaterial val_2 = 0;
        if(this.terrainMaterialInterface != 0)
        {
                if(this.terrainMaterialInterface == 0)
        {
                return;
        }
        
            val_2 = this.terrainMaterialInterface;
            if(this.terrainMaterialInterface != 0)
        {
                return;
        }
        
            val_2 = 0;
            return;
        }
        
        this.terrainMaterialInterface = this.terrainMaterial;
        val_2 = this.terrainMaterial;
    }
    public void set_TerrainMaterial(IFerr2DTMaterial value)
    {
        this.SetMaterial(aMaterial:  value);
    }
    public UnityEngine.Mesh get_MeshData()
    {
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        if(this != 0)
        {
                return this.sharedMesh;
        }
        
        return this.sharedMesh;
    }
    public UnityEngine.MeshFilter get_MeshFilter()
    {
        return this.GetComponent<UnityEngine.Transform>();
    }
    public bool get_IsLegacy()
    {
        bool val_3;
        if(this.checkedLegacy != false)
        {
                val_3 = this.isLegacy;
        }
        else
        {
                UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            bool val_2 = UnityEngine.Object.op_Inequality(x:  455991856, y:  0);
            this.isLegacy = val_2;
            this.checkedLegacy = true;
        }
        
        if(val_2 == true)
        {
                val_2 = 1;
        }
        
        return true;
    }
    public bool get_CheckedLegacy()
    {
        return (bool)this.checkedLegacy;
    }
    public void set_CheckedLegacy(bool value)
    {
        this.checkedLegacy = value;
    }
    public UnityEngine.Vector2 get_UnitsPerUV()
    {
        Ferr2DT_PathTerrain val_9;
        float val_10;
        UnityEngine.Object val_11;
        var val_12;
        UnityEngine.Object val_13;
        val_9 = this;
        var val_1 = R1 + 148;
        IFerr2DTMaterial val_2 = R1.TerrainMaterial;
        var val_9 = R1;
        if((R1 + 178) == 0)
        {
            goto label_3;
        }
        
        val_11 = 0;
        label_5:
        if((R1 + 88 + 0) == 536888251)
        {
            goto label_4;
        }
        
        val_11 = val_11 + 1;
        if(((uint)val_11 & 65535) < (R1 + 178))
        {
            goto label_5;
        }
        
        label_3:
        val_12 = R1;
        goto label_6;
        label_4:
        var val_3 = (R1 + 88) + 0;
        val_9 = val_9 + (((R1 + 88 + 0) + 4) << 3);
        val_12 = val_9 + 212;
        label_6:
        val_13 = R1;
        val_9 = val_9;
        if(val_13 == 0)
        {
            goto label_13;
        }
        
        UnityEngine.Texture val_5 = val_13.mainTexture;
        val_11 = val_13;
        if(val_11 == 0)
        {
            goto label_13;
        }
        
        UnityEngine.Texture val_7 = val_13.mainTexture;
        val_11 = val_13;
        float val_10 = (float)val_11;
        val_10 = val_10 / (R1 + 32);
        mem2[0] = val_10;
        UnityEngine.Texture val_8 = val_13.mainTexture;
        val_13 = val_13;
        val_10 = (float)val_13 / (R1 + 32);
        goto label_18;
        label_13:
        val_10 = 32f / (R1 + 32);
        mem2[0] = val_10;
        label_18:
        mem2[0] = val_10;
        return new UnityEngine.Vector2() {x = val_10};
    }
    public Ferr2DPath get_PathData()
    {
    
    }
    private void Awake()
    {
        var val_8;
        if(this.IsLegacy != false)
        {
                this.LegacyAwake();
            return;
        }
        
        if(this.colliderMode != 0)
        {
                UnityEngine.Transform val_2 = this.GetComponent<UnityEngine.Transform>();
            if(456564144 == 0)
        {
                UnityEngine.Transform val_4 = this.GetComponent<UnityEngine.Transform>();
            bool val_5 = UnityEngine.Object.op_Equality(x:  456564144, y:  0);
            if(val_5 == true)
        {
                val_5 = this;
            this.RecreateCollider();
        }
        
        }
        
        }
        
        val_8 = 0;
        goto label_8;
        label_13:
        UnityEngine.Camera[] val_6 = UnityEngine.Camera.allCameras;
        var val_7 = 0 + 0;
        (0 + 0) + 16.transparencySortMode = 2;
        val_8 = 1;
        label_8:
        UnityEngine.Camera[] val_8 = UnityEngine.Camera.allCameras;
        if(val_8 < 0)
        {
            goto label_13;
        }
    
    }
    public void Build(bool aFullBuild = True)
    {
        Ferr2DPath val_23;
        var val_24;
        var val_25;
        val_23 = 22968936;
        if(this.IsLegacy != false)
        {
                this.LegacyBuild(aFullBuild:  aFullBuild);
            return;
        }
        
        IFerr2DTMaterial val_2 = this.TerrainMaterial;
        if(this == 0)
        {
            goto label_3;
        }
        
        val_23 = this.pathData;
        if(val_23.Count <= 1)
        {
            goto label_5;
        }
        
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        this.unitsPerUV = new UnityEngine.Vector2();
        mem[1152921509358511048] = ???;
        this.MarkColorSave();
        Ferr2D_DynamicMesh val_5 = this.DMesh;
        this.Clear();
        if(this.edgeMode != 2)
        {
                this.edgeMode = this;
            this.AddEdge();
        }
        
        Ferr2D_DynamicMesh val_6 = this.DMesh;
        System.Int32[] val_7 = this.GetCurrentTriangleList(aStart:  0);
        if(this.fillMode != 2)
        {
                this.AddFill(aAddSkirt:  this.useSkirt, aSteinerPoints:  this.fillSplit, aSimplify:  aFullBuild ^ 1);
        }
        
        Ferr2D_DynamicMesh val_9 = this.DMesh;
        System.Int32[] val_10 = this.GetCurrentTriangleList(aStart:  this.fillY);
        UnityEngine.Transform val_11 = this.GetComponent<UnityEngine.Transform>();
        UnityEngine.Mesh val_12 = this.GetMesh();
        this.sharedMesh = 456696624;
        Ferr2D_DynamicMesh val_13 = this.DMesh;
        val_24 = this;
        if(this.createTangents == true)
        {
                this.createTangents = 1;
        }
        
        this.Build(aMesh: ref  UnityEngine.Mesh val_15 = 456684588, aCalculateTangents:  1 & aFullBuild);
        this.CreateVertColors();
        if(this.fillY == 0f)
        {
            goto label_13;
        }
        
        if(this.fillY == 0f)
        {
            goto label_15;
        }
        
        this.subMeshCount = 2;
        this.SetTriangles(triangles:  456696624, submesh:  1);
        goto label_18;
        label_3:
        UnityEngine.Debug.LogWarning(message:  -1610609557);
        return;
        label_5:
        UnityEngine.Transform val_16 = this.GetComponent<UnityEngine.Transform>();
        this.sharedMesh = 0;
        return;
        label_13:
        if(this != 0)
        {
            goto label_26;
        }
        
        goto label_26;
        label_15:
        if(this.fillY == 0f)
        {
            goto label_26;
        }
        
        this.subMeshCount = 1;
        val_25 = this;
        goto label_29;
        label_26:
        if(this.fillY == 0f)
        {
            goto label_30;
        }
        
        this.subMeshCount = 1;
        label_18:
        val_25 = this;
        label_29:
        this.SetTriangles(triangles:  456696624, submesh:  0);
        label_30:
        if(this.fillY != 0f)
        {
                this.fillY = 1;
        }
        
        if(this.fillY != 0f)
        {
                this.fillY = 1;
        }
        
        this.AddMaterials(aHasFill:  true, aHasEdge:  true);
        UnityEngine.Transform val_17 = this.GetComponent<UnityEngine.Transform>();
        val_23 = 1;
        if(456696624 == 0)
        {
                UnityEngine.Transform val_19 = this.GetComponent<UnityEngine.Transform>();
            val_24 = this;
            if(456696624 == 0)
        {
                UnityEngine.Transform val_21 = this.GetComponent<UnityEngine.Transform>();
            val_23 = UnityEngine.Object.op_Inequality(x:  456696624, y:  0);
        }
        
        }
        
        if(this.colliderMode != 0)
        {
                this.colliderMode = 1;
        }
        
        if(aFullBuild == false)
        {
                return;
        }
        
        this.recolorTree = 0;
    }
    private UnityEngine.Mesh GetMesh()
    {
        var val_11;
        var val_12;
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        val_11 = this;
        string val_2 = this.GetMeshName();
        if(val_11 != 0)
        {
                UnityEngine.Mesh val_3 = this.sharedMesh;
            val_12 = val_11;
        }
        else
        {
                UnityEngine.Mesh val_4 = this.sharedMesh;
            val_12 = val_11;
        }
        
        UnityEngine.Mesh val_5 = this.sharedMesh;
        if(456825008 == 0)
        {
            goto label_5;
        }
        
        UnityEngine.Mesh val_7 = this.sharedMesh;
        val_11 = val_11;
        string val_8 = this.name;
        if((System.String.op_Inequality(a:  456825008, b:  456825008)) == false)
        {
            goto label_8;
        }
        
        label_5:
        UnityEngine.Mesh val_10 = 536890419;
        val_12 = val_10;
        val_10 = new UnityEngine.Mesh();
        label_8:
        val_12.name = 456825008;
    }
    private bool IsPrefab()
    {
        return false;
    }
    public string GetMeshName()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        string val_2 = this.name;
        UnityEngine.GameObject val_3 = this.gameObject;
        int val_4 = this.GetInstanceID();
        string val_5 = System.String.Format(format:  -1610596971, arg0:  457049008, arg1:  536888987);
    }
    private void AddEdge()
    {
        var val_5;
        object val_6;
        System.Action<SdkConfiguration> val_7;
        object val_8;
        var val_9;
        System.Collections.Generic.List<EdgeSegment> val_1 = Ferr2DT_PathTerrain.EdgeSegment.CreateEdgeSegments(aPath:  this.pathData, aSplitCorners:  this.splitCorners);
        if(this.edgeMode == 1)
        {
                val_5 = 536898979;
            if(((mem[536899166] & true) == 0) && (mem[536899095] == 0))
        {
                val_5 = 536898979;
        }
        
            val_6 = mem[536899071];
            val_7 = mem[mem[536899071] + 4];
            val_7 = mem[536899071] + 4;
            if(val_7 == 0)
        {
                if(((mem[536899166] & true) == 0) && (mem[536899095] == 0))
        {
                val_6 = mem[536899071];
        }
        
            val_8 = mem[mem[536899071]];
            val_8 = val_6;
            val_7 = 536873371;
            val_7 = new System.Action<SdkConfiguration>(object:  val_8, method:  new IntPtr(1610676291));
            mem2[0] = val_7;
        }
        
            this.pathData.ForEach(action:  536873371);
        }
        
        536873807 = new System.Comparison<AdjustmentRule>(object:  457169200, method:  new IntPtr(1610676259));
        this.pathData.Sort(comparison:  536873807);
        val_9 = 0;
        goto label_9;
        label_12:
        if(val_9 >= val_8)
        {
            goto label_10;
        }
        
        label_13:
        if(this.pathData <= val_9)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + 0;
        this.AddSegment(aSegment:  (0 + 0) + 16);
        val_9 = 1;
        label_9:
        if(this.pathData == 0)
        {
            goto label_12;
        }
        
        if(val_9 < this)
        {
            goto label_13;
        }
        
        label_10:
        T[] val_4 = this.pathData.ToArray();
    }
    private void AddSegment(Ferr2DT_PathTerrain.EdgeSegment aSegment)
    {
        var val_6;
        Ferr2D_CapColliderType val_7;
        var val_28;
        Ferr2DT_TerrainDirection val_29;
        int val_30;
        var val_31;
        var val_32;
        float val_33;
        Ferr2D_CapColliderType val_34;
        UnityEngine.Vector2 val_36;
        UnityEngine.Vector2 val_37;
        float val_38;
        float val_39;
        float val_40;
        int val_41;
        float val_42;
        float val_43;
        float val_44;
        val_28 = this;
        IFerr2DTMaterial val_1 = this.TerrainMaterial;
        val_29 = aSegment.direction;
        val_30 = 0;
        val_30 = val_30 + 1;
        val_31 = val_28;
        UnityEngine.Rect val_3 = GetBody(aBodyId:  457309872);
        float val_4 = 0f.height;
        if(val_28 == 0)
        {
                return;
        }
        
        if(aSegment.closed != false)
        {
                this.AddBody(aSegment:  aSegment, aStartOffset:  457297792, aEndOffset:  val_3.m_YMin);
            return;
        }
        
        UnityEngine.Vector2 val_5 = UnitsPerUV;
        float val_8 = aSegment.path.GetInteriorAngle(aRawIndex:  aSegment.end);
        if(aSegment.path > 0)
        {
                val_32 = 1;
        }
        
        float val_9 = aSegment.path.GetInteriorAngle(aRawIndex:  aSegment.start);
        if(aSegment.path > 0)
        {
                val_28 = 1;
        }
        
        if(this.edgeMode == 1)
        {
                if(this.edgeMode <= 1)
        {
                val_28 = 1;
        }
        
            if(this.edgeMode <= 1)
        {
                val_32 = 1;
        }
        
        }
        
        val_33 = val_6;
        val_34 = val_7;
        if(val_28 == 0)
        {
                val_34 = val_7;
            val_33 = val_6;
        }
        
        UnityEngine.Rect val_13 = GetLeftCap(aInner:  true, aUnitsPerUV:  new UnityEngine.Vector2() {x = 1.401298E-45f, y = val_33}, aColliderType: out  val_34, aColliderCapSize: out  0f, aCapOffset: out  0f, aId:  457297820);
        if(val_28 != 0)
        {
                UnityEngine.Rect val_17 = GetRightCap(aInner:  true, aUnitsPerUV:  new UnityEngine.Vector2() {x = 1.401298E-45f, y = val_33}, aColliderType: out  val_34, aColliderCapSize: out  0f, aCapOffset: out  0f, aId:  0f);
            val_36 = this.invertFillBorder;
            val_37 = this.invertFillBorder;
            val_38 = 0f;
            val_39 = val_36;
        }
        else
        {
                UnityEngine.Rect val_21 = GetRightCap(aInner:  false, aUnitsPerUV:  new UnityEngine.Vector2() {x = 1.401298E-45f, y = val_33}, aColliderType: out  val_34, aColliderCapSize: out  0f, aCapOffset: out  0f, aId:  0f);
            val_37 = 20;
            val_38 = 0f;
            val_39 = 1.401298E-45f;
            val_36 = 1.401298E-45f;
        }
        
        val_29 = 1;
        val_36 = val_36 + 0f;
        float val_23 = (val_38 + val_39) ^ 2147483648;
        float val_24 = val_36 ^ 2147483648;
        this.AddBody(aSegment:  aSegment, aStartOffset:  val_36, aEndOffset:  val_21.m_YMin);
        if(val_28 != 0)
        {
                val_40 = 0f;
            val_41 = aSegment.start;
        }
        else
        {
                val_41 = aSegment.start;
            val_42 = 1.401298E-45f;
            val_40 = 0f;
        }
        
        float val_25 = val_40 + val_42;
        val_25 = aSegment.startDistance - val_25;
        this.AddCap(aSegment:  aSegment, aInner:  true, aDistance:  this.fillY, aCornerVert:  val_25, aZ:  val_21.m_YMin);
        if(val_28 != 0)
        {
                val_43 = 0f;
            val_30 = aSegment.end;
            val_44 = 1.401298E-45f;
        }
        else
        {
                val_30 = aSegment.end;
            val_44 = 1.401298E-45f;
            val_43 = 0f;
        }
        
        float val_26 = val_43 + val_44;
        val_26 = (aSegment.startDistance + aSegment.length) + val_26;
        this.AddCap(aSegment:  aSegment, aInner:  true, aDistance:  this.fillY, aCornerVert:  val_26, aZ:  val_21.m_YMin);
    }
    private void AddBody(Ferr2DT_PathTerrain.EdgeSegment aSegment, float aStartOffset, float aEndOffset)
    {
        float val_26;
        float val_29;
        var val_30;
        float val_31;
        float val_32;
        int val_33;
        Ferr2DT_PathTerrain val_34;
        System.Collections.Generic.List<System.Int32> val_35;
        Ferr2DT_PathTerrain val_36;
        float val_37;
        float val_38;
        var val_39;
        if(aSegment != 0)
        {
                val_29 = aSegment.startDistance;
        }
        else
        {
                val_29 = 7.286752E-44f;
        }
        
        float val_29 = aSegment.length;
        UnityEngine.Vector2 val_1 = 0f.UnitsPerUV;
        System.Collections.Generic.List<UnityEngine.Vector2> val_2 = aSegment.path.GetFinalPath();
        IFerr2DTMaterial val_3 = this.TerrainMaterial;
        var val_27 = 0;
        val_27 = val_27 + 1;
        val_30 = this;
        var val_28 = R3;
        val_31 = 0f;
        val_32 = 0f;
        val_33 = 0;
        val_28 = R2 + val_28;
        val_29 = val_29 + R2;
        System.Collections.Generic.List<System.Int32> val_9 = this.CreateLineList(aSegment:  aSegment, aScale: out  float val_8 = 1.621432E-22f, aIncludeSource:  0);
        val_34 = this;
        val_29 = val_29 - val_28;
        aSegment.Sample(aDistance:  this.GetYOffset(aInvert:  (mem[1152921509359269020] - 1) >> 5, aUnitsPerUV:  new UnityEngine.Vector2() {x = 0f, y = 0f}), aSmoothIndex: out  val_29, aSmoothPercent: out  float val_11 = 1.621426E-22f, aPoint: out  new UnityEngine.Vector2() {x = 1.621427E-22f, y = this}, aNormal: out  new UnityEngine.Vector2() {x = this, y = 0f}, aData: out  new Ferr2D_PointData() {directionOverride = val_33});
        val_35 = 1;
        goto label_13;
        label_27:
        IFerr2DTMaterial val_12 = this.TerrainMaterial;
        if(mem[1152921509359268924] <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_30 = mem[1152921509359268920];
        val_30 = val_30 + 0;
        UnityEngine.Rect val_13 = 0f.GetBody(aBodyId:  aSegment);
        Ferr2DT_PathTerrain val_32 = this;
        if(this.createCollider == false)
        {
            goto label_17;
        }
        
        var val_31 = 0;
        label_19:
        if((this.fillSplitDistance + 0) == 536888251)
        {
            goto label_18;
        }
        
        val_31 = val_31 + 1;
        if(((uint)val_31 & 65535) < this.createCollider)
        {
            goto label_19;
        }
        
        label_17:
        val_36 = this;
        goto label_20;
        label_18:
        float val_14 = this.fillSplitDistance + 0;
        val_32 = val_32 + (((this.fillSplitDistance + 0) + 4) << 3);
        val_36 = val_32 + 284;
        label_20:
        float val_15 = width;
        float val_16 = height;
        uint val_33 = 457442448;
        if(mem[1152921509359269020] == 1)
        {
                float val_17 = yMin;
            float val_18 = yMax;
            yMin = val_18;
            yMax = val_18;
            float val_19 = xMin;
            float val_20 = xMax;
            xMin = val_20;
            xMax = val_20;
        }
        
        val_33 = val_33 * 0;
        uint val_34 = 457442448;
        if(val_34 != 0)
        {
                val_37 = 1f;
            val_38 = (float)mem[1152921509359268924];
            val_39 = val_37 / val_38;
        }
        else
        {
                val_37 = 1f;
            val_39 = val_37 / (float)mem[1152921509359268924];
            val_38 = (float)mem[1152921509359268924];
        }
        
        float val_22 = val_33 * 0.5f;
        val_34 = val_34 * 0;
        aSegment.Sample(aDistance:  val_38, aSmoothIndex: out  val_29, aSmoothPercent: out  float val_25 = 1.621425E-22f, aPoint: out  new UnityEngine.Vector2() {x = 1.621426E-22f, y = 0f}, aNormal: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, aData: out  new Ferr2D_PointData());
        val_26 = val_26;
        val_32 = 0f;
        this.AddSegment(aSegment:  aSegment, aSmoothCount:  aSegment.path, aSegmentSize:  new UnityEngine.Vector2() {x = val_34, y = val_22}, aUVs:  new UnityEngine.Rect() {m_XMin = val_26, m_YMin = val_22, m_Width = val_34, m_Height = val_34}, aYOffset:  mem[1152921509359268924], aZ:  val_13.m_YMin, aStartDistance:  val_37, aSegmentLength:  val_13.m_Height, aCurrSmoothIndex:  457454640, aCurrPt:  new UnityEngine.Vector2() {x = mem[1152921509359268924], y = val_29}, aCurrN:  new UnityEngine.Vector2() {x = val_29 * (1f / val_38), y = 0f}, aCurrData:  new Ferr2D_PointData() {directionOverride = this, cutOverrides = val_35, scale = this}, aNextSmoothIndex:  aSegment, aNextPt:  new UnityEngine.Vector2() {x = 0f, y = 0f}, aNextN:  new UnityEngine.Vector2() {x = 0f, y = 0f}, aNextData:  new Ferr2D_PointData() {directionOverride = val_33, cutOverrides = val_31, scale = val_32});
        val_34 = val_34;
        val_35 = 2;
        label_13:
        if(val_35 <= mem[1152921509359268924])
        {
            goto label_27;
        }
    
    }
    private void AddCap(Ferr2DT_PathTerrain.EdgeSegment aSegment, bool aInner, float aDistance, int aCornerVert, float aZ)
    {
        float val_4;
        float val_5;
        var val_7;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        float val_38;
        float val_43;
        var val_44;
        float val_45;
        var val_46;
        Ferr2DT_PathTerrain val_47;
        var val_48;
        IFerr2DTMaterial val_1 = this.TerrainMaterial;
        UnityEngine.Vector2 val_3 = UnitsPerUV;
        bool val_40 = mem[1152921509359401500];
        val_40 = (val_40 - 1) >> 5;
        float val_8 = this.GetYOffset(aInvert:  val_40, aUnitsPerUV:  new UnityEngine.Vector2() {x = val_4, y = val_5});
        var val_41 = aSegment + 12;
        val_41 = val_41 - val_7;
        val_41 = val_41 >> 5;
        if(val_40 == val_41)
        {
            goto label_9;
        }
        
        if(aInner == false)
        {
            goto label_12;
        }
        
        UnityEngine.Rect val_9 = innerRightCap;
        float val_10 = width;
        if(this <= 0)
        {
            goto label_12;
        }
        
        UnityEngine.Rect val_11 = innerRightCap;
        goto label_21;
        label_9:
        if(aInner == false)
        {
            goto label_17;
        }
        
        UnityEngine.Rect val_12 = innerLeftCap;
        float val_13 = width;
        if(this <= 0)
        {
            goto label_17;
        }
        
        UnityEngine.Rect val_14 = innerLeftCap;
        goto label_19;
        label_12:
        UnityEngine.Rect val_15 = rightCap;
        goto label_21;
        label_17:
        UnityEngine.Rect val_16 = leftCap;
        label_19:
        label_21:
        IFerr2DTMaterial val_17 = this.TerrainMaterial;
        val_43 = val_18;
        val_44 = this;
        val_45 = val_19;
        val_46 = val_20;
        Ferr2DT_PathTerrain val_43 = this;
        if(this.createCollider == false)
        {
            goto label_24;
        }
        
        var val_42 = 0;
        label_26:
        if((this.fillSplitDistance + 0) == 536888251)
        {
            goto label_25;
        }
        
        val_42 = val_42 + 1;
        if(((uint)val_42 & 65535) < this.createCollider)
        {
            goto label_26;
        }
        
        label_24:
        val_47 = val_44;
        goto label_27;
        label_25:
        float val_22 = this.fillSplitDistance + 0;
        val_43 = val_43 + (((this.fillSplitDistance + 0) + 4) << 3);
        val_47 = val_43 + 284;
        label_27:
        float val_23 = width;
        float val_24 = height;
        val_48 = ;
        float val_25 = width;
        if((this.fillSplitDistance + 0) <= 536888251)
        {
                return;
        }
        
        uint val_44 = 457575016;
        if(val_40 == 1)
        {
                float val_26 = yMin;
            float val_27 = yMax;
            yMin = val_27;
            yMax = val_27;
            float val_28 = xMin;
            float val_29 = xMax;
            xMin = val_29;
            xMax = val_29;
        }
        
        val_44 = val_44 * val_5;
        float val_30 = 457575016 * val_4;
        int val_31 = aCornerVert - val_30;
        if((aSegment + 12) == val_7)
        {
                aCornerVert = val_31;
        }
        
        aSegment.Sample(aDistance:  val_31, aSmoothIndex: out  aCornerVert, aSmoothPercent: out  float val_34 = 1.638153E-22f, aPoint: out  new UnityEngine.Vector2() {x = 1.638153E-22f, y = 0f}, aNormal: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, aData: out  new Ferr2D_PointData());
        aSegment.Sample(aDistance:  val_30 + aCornerVert = aCornerVert, aSmoothIndex: out  val_30 + aCornerVert, aSmoothPercent: out  float val_37 = 1.638148E-22f, aPoint: out  new UnityEngine.Vector2() {x = 1.638148E-22f, y = 0f}, aNormal: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, aData: out  new Ferr2D_PointData());
        System.Collections.Generic.List<UnityEngine.Vector2> val_39 = aSegment + 24.GetFinalPath();
        val_48 = 0f;
        val_46 = 0f;
        val_45 = 0f;
        val_44 = 0f;
        val_43 = 0f;
        this.AddSegment(aSegment:  aSegment, aSmoothCount:  aSegment + 24 + 12, aSegmentSize:  new UnityEngine.Vector2() {x = val_30, y = val_44 * 0.5f}, aUVs:  new UnityEngine.Rect() {m_XMin = val_21, m_YMin = val_18, m_Width = val_19, m_Height = val_20}, aYOffset:  val_30 + aCornerVert, aZ:  val_16.m_YMin, aStartDistance:  val_16.m_Width, aSegmentLength:  val_16.m_Height, aCurrSmoothIndex:  457587120, aCurrPt:  new UnityEngine.Vector2() {x = val_38, y = aCornerVert}, aCurrN:  new UnityEngine.Vector2() {x = val_30, y = 0f}, aCurrData:  new Ferr2D_PointData() {cutOverrides = val_45, scale = 0f}, aNextSmoothIndex:  0, aNextPt:  new UnityEngine.Vector2() {x = 0f, y = 0f}, aNextN:  new UnityEngine.Vector2() {x = 0f, y = 0f}, aNextData:  new Ferr2D_PointData() {directionOverride = 0f, cutOverrides = 0f, scale = 0f});
    }
    private void AddSegment(Ferr2DT_PathTerrain.EdgeSegment aSegment, int aSmoothCount, UnityEngine.Vector2 aSegmentSize, UnityEngine.Rect aUVs, float aYOffset, float aZ, float aStartDistance, float aSegmentLength, int aCurrSmoothIndex, UnityEngine.Vector2 aCurrPt, UnityEngine.Vector2 aCurrN, Ferr2D_PointData aCurrData, int aNextSmoothIndex, UnityEngine.Vector2 aNextPt, UnityEngine.Vector2 aNextN, Ferr2D_PointData aNextData)
    {
        var val_44;
        int val_66;
        int val_67;
        int val_68;
        float val_1 = aUVs.m_XMin.yMax;
        float val_3 = UnityEngine.Mathf.Lerp(a:  aUVs.m_XMin.yMin, b:  aZ, t:  aStartDistance);
        Ferr2D_DynamicMesh val_4 = this.DMesh;
        float val_66 = aSegmentSize.y;
        float val_5 = val_66 + aCurrSmoothIndex;
        float val_6 = val_5 * aNextSmoothIndex;
        float val_7 = val_5 * aCurrData.scale;
        float val_8 = aUVs.m_XMin.xMax;
        float val_9 = aUVs.m_XMin.yMax;
        float val_10 = this.slantAmount + aCurrPt.x;
        int val_11 = this.AddVertex(aVert:  new UnityEngine.Vector2() {x = aCurrData.directionOverride, y = aCurrData.cutOverrides}, aZ:  val_10, aUV:  new UnityEngine.Vector2() {x = val_10});
        Ferr2D_DynamicMesh val_12 = this.DMesh;
        int val_13 = aNextSmoothIndex * aCurrSmoothIndex;
        float val_14 = aCurrData.scale * aCurrSmoothIndex;
        int val_16 = this.AddVertex(aVert:  new UnityEngine.Vector2() {x = aCurrData.directionOverride, y = aCurrData.cutOverrides}, aZ:  aUVs.m_XMin.xMax, aUV:  new UnityEngine.Vector2() {x = aCurrPt.x});
        Ferr2D_DynamicMesh val_17 = this.DMesh;
        val_66 = aCurrSmoothIndex - val_66;
        int val_18 = val_66 * aNextSmoothIndex;
        float val_20 = aUVs.m_XMin.xMax;
        float val_21 = aUVs.m_XMin.yMin;
        float val_22 = aCurrPt.x - this.slantAmount;
        val_66 = this.AddVertex(aVert:  new UnityEngine.Vector2() {x = aCurrData.directionOverride, y = aCurrData.cutOverrides}, aZ:  val_22, aUV:  new UnityEngine.Vector2() {x = val_22});
        float val_67 = aNextN.y;
        val_67 = val_67 + 1;
        float val_68 = aCurrN.y;
        val_68 = val_68 + 1;
        if(aSmoothCount == aSmoothCount)
        {
                val_67 = val_16;
            val_68 = val_11;
        }
        else
        {
                do
        {
            Ferr.PathDistanceMask val_24 = aSegment + 24.DistanceMask;
            Ferr.PathDistanceMask val_25 = aSegment + 24.DistanceMask;
            if((aSegment + 24 + 12) <= aSmoothCount)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_69 = aSegment + 24 + 8;
            val_69 = val_69 + ((aSmoothCount + (aSmoothCount << 1)) << 2);
            float val_27 = aSegment + 24.DistanceBetweenDistances(aStartDistance:  val_22, aEndDistance:  aZ);
            var val_70 = aSegment + 24;
            val_70 = val_70 / aCurrN.x;
            float val_28 = aUVs.m_XMin.xMax;
            float val_30 = UnityEngine.Mathf.Lerp(a:  aUVs.m_XMin.xMin, b:  aZ, t:  val_66 * aCurrData.scale);
            aSegment.SampleSmoothVert(aSmoothIndex:  aSmoothCount, aPoint: out  new UnityEngine.Vector2() {x = 1.653846E-22f, y = 1.653845E-22f}, aNormal: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, aData: out  new Ferr2D_PointData() {scale = aSmoothCount});
            Ferr2D_DynamicMesh val_31 = this.DMesh;
            float val_71 = 0f;
            float val_72 = 0f;
            val_71 = val_5 * val_71;
            val_72 = val_5 * val_72;
            float val_32 = aUVs.m_XMin.yMax;
            float val_33 = this.slantAmount + aCurrPt.x;
            Ferr2D_DynamicMesh val_35 = this.DMesh;
            float val_73 = 0f;
            float val_74 = 0f;
            val_73 = val_73 * aCurrSmoothIndex;
            val_74 = val_74 * aCurrSmoothIndex;
            int val_36 = this.AddVertex(aVert:  new UnityEngine.Vector2() {x = 0f, y = 0f}, aZ:  val_73, aUV:  new UnityEngine.Vector2() {x = aCurrPt.x});
            Ferr2D_DynamicMesh val_37 = this.DMesh;
            float val_75 = 0f;
            float val_76 = 0f;
            val_75 = val_66 * val_75;
            val_76 = val_66 * val_76;
            float val_38 = aUVs.m_XMin.yMin;
            float val_39 = aCurrPt.x - this.slantAmount;
            val_66 = this.AddVertex(aVert:  new UnityEngine.Vector2() {x = 0f, y = 0f}, aZ:  val_39, aUV:  new UnityEngine.Vector2() {x = val_39});
            Ferr2D_DynamicMesh val_41 = this.DMesh;
            val_68 = this.AddVertex(aVert:  new UnityEngine.Vector2() {x = 0f, y = 0f}, aZ:  val_33, aUV:  new UnityEngine.Vector2() {x = val_33});
            this.AddFace(aV1:  val_16, aV2:  val_11, aV3:  val_68, aV4:  val_36);
            Ferr2D_DynamicMesh val_42 = this.DMesh;
            this.AddFace(aV1:  val_66, aV2:  val_16, aV3:  val_36, aV4:  val_66);
            int val_77 = aSmoothCount;
            val_77 = val_77 + 1;
            val_67 = val_36;
        }
        while(aSmoothCount != aSmoothCount);
        
        }
        
        Ferr2D_DynamicMesh val_43 = this.DMesh;
        float val_45 = val_5 * aNextData.scale;
        float val_47 = val_5 * val_44;
        float val_48 = aUVs.m_XMin.xMin;
        float val_49 = aUVs.m_XMin.yMax;
        float val_50 = this.slantAmount + aCurrPt.x;
        Ferr2D_DynamicMesh val_52 = this.DMesh;
        int val_53 = val_44 * aCurrSmoothIndex;
        float val_54 = aNextData.scale * aCurrSmoothIndex;
        int val_56 = this.AddVertex(aVert:  new UnityEngine.Vector2() {x = aNextData.directionOverride, y = aNextData.cutOverrides}, aZ:  aUVs.m_XMin.xMin, aUV:  new UnityEngine.Vector2() {x = aCurrPt.x});
        Ferr2D_DynamicMesh val_57 = this.DMesh;
        int val_58 = val_66 * val_44;
        int val_59 = val_66 * aNextData.scale;
        float val_60 = aUVs.m_XMin.xMin;
        float val_61 = aUVs.m_XMin.yMin;
        float val_62 = aCurrPt.x - this.slantAmount;
        Ferr2D_DynamicMesh val_64 = this.DMesh;
        this.AddFace(aV1:  val_67, aV2:  val_68, aV3:  this.AddVertex(aVert:  new UnityEngine.Vector2() {x = aNextData.directionOverride, y = aNextData.cutOverrides}, aZ:  val_50, aUV:  new UnityEngine.Vector2() {x = val_50}), aV4:  val_56);
        Ferr2D_DynamicMesh val_65 = this.DMesh;
        this.AddFace(aV1:  val_66, aV2:  val_67, aV3:  val_56, aV4:  this.AddVertex(aVert:  new UnityEngine.Vector2() {x = aNextData.directionOverride, y = aNextData.cutOverrides}, aZ:  val_62, aUV:  new UnityEngine.Vector2() {x = val_62}));
    }
    public System.Collections.Generic.List<int> CreateLineList(Ferr2DT_PathTerrain.EdgeSegment aSegment, out float aScale, System.Collections.Generic.List<int> aIncludeSource)
    {
        float val_2;
        float val_3;
        var val_24;
        Ferr2DT_PathTerrain val_25;
        int val_26;
        var val_27;
        Ferr2DPath val_28;
        var val_30;
        var val_31;
        var val_32;
        Random.State val_1 = UnityEngine.Random.state;
        UnityEngine.Vector2 val_6 = Item[this.pathData];
        UnityEngine.Vector2 val_7 = Item[this.pathData];
        float val_24 = 500f;
        val_24 = val_3 * val_24;
        UnityEngine.Random.InitState(seed:  (int)val_24);
        IFerr2DTMaterial val_8 = this.TerrainMaterial;
        var val_25 = 0;
        val_25 = val_25 + 1;
        val_24 = this;
        val_25 = this;
        UnityEngine.Vector2 val_10 = UnitsPerUV;
        float val_13 = aSegment.GetOffsetLength(aDesc:  457868400, aInvert:  (mem[1152921509359682780] - 1) >> 5, aUpUV:  new UnityEngine.Vector2() {x = val_2, y = val_3});
        536877987 = new System.Collections.Generic.List<System.Int32>();
        if(aSegment != 0)
        {
                val_26 = aSegment.start;
        }
        else
        {
                val_26 = 0;
        }
        
        Ferr2D_PointData val_15 = GetData(aRawIndex:  aSegment.path);
        if(aSegment.path > 0)
        {
            goto label_13;
        }
        
        goto label_14;
        label_13:
        val_27 = 0;
        int val_17 = this.GetRandomBodyId(aRandValue01:  UnityEngine.Random.value);
        if(aSegment != 0)
        {
                val_28 = aSegment.path;
        }
        else
        {
                val_28 = aSegment.path;
        }
        
        int val_19 = val_28.GetSegmentAtDistance(aDist:  0 + aSegment.startDistance);
        val_30 = val_3;
        if(val_19 != 0)
        {
                Ferr2D_PointData val_20 = GetData(aRawIndex:  aSegment.path);
            val_30 = val_3;
            val_27 = 0;
            val_26 = val_19;
        }
        
        if(val_30 == 0)
        {
            goto label_30;
        }
        
        if(val_30 == 0)
        {
                val_30 = val_30;
        }
        
        if(val_27 >= (val_3 + 12))
        {
            goto label_30;
        }
        
        if((val_3 + 12) <= val_27)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_30 = val_30;
        }
        
        var val_26 = val_3 + 8;
        val_26 = val_26 + 0;
        val_31 = mem[(val_3 + 8 + 0) + 16];
        val_31 = (val_3 + 8 + 0) + 16;
        if(val_31 < 1)
        {
            goto label_25;
        }
        
        if((val_3 + 12) <= val_27)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            var val_27 = val_3 + 8;
            val_27 = val_27 + 0;
            val_31 = mem[(val_3 + 8 + 0) + 16];
            val_31 = (val_3 + 8 + 0) + 16;
        }
        
        val_25 = val_25;
        if(val_31 > this.BodyCount)
        {
            goto label_30;
        }
        
        val_32 = val_30;
        if((val_3 + 12) <= val_27)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_32 = val_30;
        }
        
        var val_28 = val_3 + 8;
        val_28 = val_28 + 0;
        var val_29 = (val_3 + 8 + 0) + 16;
        val_29 = val_29 - 1;
        goto label_30;
        label_25:
        val_25 = val_25;
        label_30:
        IFerr2DTMaterial val_22 = this.TerrainMaterial;
        UnityEngine.Rect val_23 = GetBody(aBodyId:  457868400);
        if(this.createCollider == false)
        {
            goto label_36;
        }
        
        var val_30 = 0;
        label_35:
        if((this.fillSplitDistance + 0) == 536888251)
        {
            goto label_34;
        }
        
        val_30 = val_30 + 1;
        if(((uint)val_30 & 65535) < this.createCollider)
        {
            goto label_35;
        }
        
        goto label_36;
    }
    public static Ferr2DT_TerrainDirection GetSegmentDirection(Ferr2DPath aPath, int aIndex)
    {
        var val_2;
        var val_4;
        Ferr2D_PointData val_1 = GetData(aRawIndex:  aPath);
        if(val_2 != 100)
        {
                return;
        }
        
        UnityEngine.Vector2 val_3 = GetSegmentNormal(aRawIndex:  aPath);
        float val_5 = System.Math.Abs(val_2);
        float val_6 = System.Math.Abs(val_4);
        if(aPath > 0)
        {
                if(aPath >= 0)
        {
                1 = 2;
        }
        
            return;
        }
        
        if(aPath >= 0)
        {
                3 = 0;
        }
    
    }
    public static Ferr2DT_TerrainDirection Invert(Ferr2DT_TerrainDirection aDirection)
    {
        if(aDirection <= 3)
        {
                aDirection = 3 - aDirection;
        }
    
    }
    private void AddFill(bool aAddSkirt, bool aSteinerPoints, bool aSimplify)
    {
        Ferr2DT_PathTerrain val_43;
        bool val_44;
        float val_45;
        long val_46;
        System.Collections.Generic.List<Page> val_47;
        var val_48;
        object val_49;
        System.Converter<UnityEngine.Vector2, ClipperLibFerr.IntPoint> val_50;
        System.Collections.Generic.List<Page> val_51;
        var val_52;
        var val_53;
        long val_56;
        var val_57;
        var val_58;
        val_43 = this;
        val_44 = aSteinerPoints;
        System.Collections.Generic.List<UnityEngine.Vector2> val_1 = this.pathData.GetFinalPath();
        val_45 = this.pathData;
        val_46 = 0;
        UnityEngine.Rect val_2 = Ferr.PathUtil.GetBounds(aPoints:  458257784, aPadding:  new UnityEngine.Vector4() {x = val_45, y = 0f, z = 0f, w = 0f});
        if(aSimplify != false)
        {
                System.Collections.Generic.List<UnityEngine.Vector2> val_3 = Ferr.PathUtil.SimplifyPath(aPath:  val_45, aTolerance:  val_2.m_XMin);
            val_45 = val_45;
        }
        
        val_48 = 536898979;
        if(((mem[536899166] & true) == 0) && (mem[536899095] == 0))
        {
                val_48 = 536898979;
        }
        
        val_49 = mem[536899071];
        val_50 = mem[mem[536899071] + 8];
        val_50 = mem[536899071] + 8;
        if(val_50 == 0)
        {
                if(((mem[536899166] & true) == 0) && (mem[536899095] == 0))
        {
                val_49 = mem[536899071];
        }
        
            val_50 = 536873939;
            val_46 = -1073736329;
            val_50 = new System.Converter<UnityEngine.Vector2, ClipperLibFerr.IntPoint>(object:  val_49, method:  new IntPtr(1610676293));
            mem2[0] = val_50;
        }
        
        System.Collections.Generic.List<TOutput> val_5 = val_45.ConvertAll<ClipperLibFerr.IntPoint>(converter:  536873939);
        val_51 = 536877661;
        val_51 = new System.Collections.Generic.List<Page>();
        if(this.fillMode == 1)
        {
                if(this.fillMode == 1)
        {
                float val_7 = width;
            val_52 = 458257784;
        }
        
            if(this.fillMode == 1)
        {
                float val_8 = height;
            val_53 = 458257784;
        }
        
            536878005 = new System.Collections.Generic.List<ClipperLibFerr.IntPoint>();
            float val_10 = xMin;
            float val_11 = yMin;
            float val_12 = 458257784 - val_52;
            val_12 = val_12 * 1000f;
            uint val_47 = 458257784;
            ClipperLibFerr.IntPoint val_13;
            val_47 = val_47 - val_53;
            val_47 = val_47 * 1000f;
            val_13 = new ClipperLibFerr.IntPoint(x:  null, y:  null);
            536878005.Add(item:  new ClipperLibFerr.IntPoint() {Y = val_13.X});
            float val_14 = xMax;
            float val_15 = yMin;
            float val_16 = val_52 + 458257784;
            val_16 = val_16 * 1000f;
            uint val_48 = 458257784;
            val_48 = val_48 - val_53;
            val_48 = val_48 * 1000f;
            ClipperLibFerr.IntPoint val_17 = new ClipperLibFerr.IntPoint(x:  null, y:  null);
            val_44;
            536878005.Add(item:  new ClipperLibFerr.IntPoint() {Y = val_17.X});
            float val_18 = xMax;
            float val_19 = yMax;
            float val_20 = val_52 + 458257784;
            val_20 = val_20 * 1000f;
            uint val_49 = 458257784;
            val_49 = val_53 + val_49;
            val_49 = val_49 * 1000f;
            ClipperLibFerr.IntPoint val_21 = new ClipperLibFerr.IntPoint(x:  null, y:  null);
            536878005.Add(item:  new ClipperLibFerr.IntPoint() {Y = val_21.X});
            float val_22 = xMin;
            float val_23 = yMax;
            float val_24 = 458257784 - val_52;
            val_24 = val_24 * 1000f;
            uint val_50 = 458257784;
            val_50 = val_53 + val_50;
            val_50 = val_50 * 1000f;
            ClipperLibFerr.IntPoint val_25 = new ClipperLibFerr.IntPoint(x:  null, y:  null);
            val_46 = val_25.X;
            536878005.Add(item:  new ClipperLibFerr.IntPoint() {Y = val_46});
            float val_26 = xMin;
            uint val_51 = 458257784;
            val_51 = val_51 - val_52;
            xMin = val_51;
            float val_27 = xMax;
            uint val_52 = 458257784;
            val_52 = val_52 + val_52;
            xMax = val_52;
            float val_28 = yMin;
            uint val_53 = 458257784;
            val_53 = val_53 - val_53;
            yMin = val_53;
            float val_29 = yMax;
            uint val_54 = 458257784;
            val_54 = val_53 + val_54;
            yMax = val_54;
            val_51 = val_51;
            val_51.Add(item:  536878005);
            val_43 = val_43;
        }
        
        if(aAddSkirt != false)
        {
                if(aAddSkirt != true)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_31 = 536878005 + ((0 - 1) << 3);
            ClipperLibFerr.IntPoint val_33;
            float val_32 = ((536878005 + ((0 - 1)) << 3) + 16) * 1000f;
            float val_55 = mem[1152921509360084156];
            val_55 = val_55 * 1000f;
            val_33 = new ClipperLibFerr.IntPoint(x:  null, y:  null);
            val_45.Add(item:  new ClipperLibFerr.IntPoint() {X = val_33.Y, Y = val_33.X});
            val_47 = (536878005 + ((0 - 1)) << 3) + 16;
            float val_34 = UnityEngine.Mathf.Lerp(a:  val_55, b:  val_2.m_YMin, t:  val_2.m_Width);
            var val_56 = val_47;
            val_56 = val_56 * 1000f;
            float val_57 = mem[1152921509360084156];
            val_57 = val_57 * 1000f;
            ClipperLibFerr.IntPoint val_35 = new ClipperLibFerr.IntPoint(x:  null, y:  null);
            val_45.Add(item:  new ClipperLibFerr.IntPoint() {X = val_35.Y, Y = val_35.X});
            float val_36 = UnityEngine.Mathf.Lerp(a:  val_57, b:  val_2.m_YMin, t:  val_2.m_Width);
            var val_58 = val_47;
            val_58 = val_58 * 1000f;
            var val_59 = mem[1152921509360084156];
            val_59 = val_59 * 1000f;
            ClipperLibFerr.IntPoint val_37 = new ClipperLibFerr.IntPoint(x:  null, y:  null);
            val_45.Add(item:  new ClipperLibFerr.IntPoint() {X = val_37.Y, Y = val_37.X});
            float val_38 = mem[536878021] * 1000f;
            var val_60 = mem[1152921509360084156];
            val_60 = val_60 * 1000f;
            ClipperLibFerr.IntPoint val_39 = new ClipperLibFerr.IntPoint(x:  null, y:  null);
            val_45.Add(item:  new ClipperLibFerr.IntPoint() {X = val_39.Y, Y = val_39.X});
            val_51 = val_51;
        }
        
        val_51.Add(item:  val_45);
        System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> val_40 = ClipperLibFerr.Clipper.SimplifyPolygons(polys:  536877661, fillType:  0);
        val_56 = val_51;
        if(mem[536877673] < 1)
        {
                return;
        }
        
        val_47 = 536877661;
        val_47 = new System.Collections.Generic.List<Page>();
        536877661 = new System.Collections.Generic.List<Page>();
        if(mem[536877673] >= 1)
        {
                do
        {
            if(mem[536877673] <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(mem[536877673] <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if((ClipperLibFerr.Clipper.Orientation(poly:  mem[536877669] + 16)) != false)
        {
                val_57 = -1073716321;
        }
        else
        {
                val_57 = -1073716321;
        }
        
            val_42.Add(item:  mem[536877669] + 16);
            var val_44 = 4 + 1;
        }
        while((4 - 3) < mem[536877673]);
        
        }
        
        System.Collections.Generic.List<FerrPoly2Tri.Polygon> val_46 = this.CreateHoles(aHoles:  536877661);
        val_43 = val_43;
        val_58 = 0;
        val_44 = val_44;
        goto label_37;
        label_40:
        if(val_43 <= val_58)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_61 = mem[536877669];
        val_56 = val_33.Y;
        val_61 = val_61 + 0;
        this.TriangulatePoints(aPolygon:  (mem[536877669] + 0) + 16, aHoles:  458269872, aBounds:  new UnityEngine.Rect() {m_XMin = val_33.X, m_YMin = val_33.X, m_Width = val_56, m_Height = val_33.Y}, aSteinerPoints:  val_44);
        val_58 = 1;
        label_37:
        if(val_58 < mem[536877673])
        {
            goto label_40;
        }
    
    }
    private System.Collections.Generic.List<FerrPoly2Tri.Polygon> CreateHoles(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> aHoles)
    {
        var val_6;
        var val_7;
        UnityEngine.Vector2 val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        Ferr2DT_PathTerrain val_32;
        var val_33;
        System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> val_34;
        var val_35;
        var val_36;
        var val_37;
        float val_38;
        System.Collections.Generic.List<Page> val_1 = 536878171;
        val_1 = new System.Collections.Generic.List<Page>();
        Ferr2D_DynamicMesh val_2 = this.DMesh;
        IFerr2DTMaterial val_4 = this.TerrainMaterial;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.one;
        val_26 = this.uvOffset;
        UnityEngine.Transform val_8 = this.transform;
        UnityEngine.Vector3 val_9 = position;
        var val_29 = val_6;
        UnityEngine.Transform val_10 = this.transform;
        UnityEngine.Vector3 val_11 = position;
        var val_30 = val_7;
        var val_26 = 0;
        val_26 = val_26 + 1;
        val_27 = this;
        val_28 = this;
        val_29 = 22713552;
        val_30 = 0;
        if(458394160 != 0)
        {
                val_28 = 0;
            val_28 = val_28 + 1;
            val_31 = this;
            UnityEngine.Texture val_15 = this.mainTexture;
            val_30 = this;
        }
        
        val_32 = this;
        if(458394160 != 0)
        {
                var val_27 = mem[1152921509360208464];
            var val_28 = mem[1152921509360208464];
            val_27 = val_27 / (4.583942E+08f);
            val_28 = val_28 / (4.583942E+08f);
        }
        
        val_29 = val_29 + val_26;
        val_30 = val_30 + 458382104;
        val_33 = 0;
        val_34 = aHoles;
        val_35 = val_1;
        goto label_23;
        label_34:
        if(val_30 <= val_33)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_31 = aHoles + 8;
        val_31 = val_31 + 0;
        val_28 = mem[(aHoles + 8 + 0) + 16];
        val_28 = (aHoles + 8 + 0) + 16;
        val_26 = 536878175;
        val_26 = new System.Collections.Generic.List<SingleRange>(capacity:  (aHoles + 8 + 0) + 16 + 12);
        val_36 = mem[(aHoles + 8 + 0) + 16 + 12];
        val_36 = (aHoles + 8 + 0) + 16 + 12;
        if(val_36 >= 1)
        {
                var val_34 = 0;
            do
        {
            if(val_36 <= val_34)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_36 = mem[(aHoles + 8 + 0) + 16 + 12];
            val_36 = (aHoles + 8 + 0) + 16 + 12;
        }
        
            val_37 = mem[(aHoles + 8 + 0) + 16 + 8];
            val_37 = (aHoles + 8 + 0) + 16 + 8;
            float val_18 = ((aHoles + 8 + 0) + 16 + 8 + 16) / 1000f;
            if(val_36 <= val_34)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_37 = mem[(aHoles + 8 + 0) + 16 + 8];
            val_37 = (aHoles + 8 + 0) + 16 + 8;
        }
        
            var val_19 = val_37 + 16;
            float val_33 = ((aHoles + 8 + 0) + 16 + 8 + 16) + 8;
            float val_20 = val_33 / 1000f;
            int val_32 = this.VertCount;
            val_32 = val_32 + val_34;
            536891967 = new FerrPoly2Tri.PolygonPoint(x:  null, y:  null, aId:  (aHoles + 8 + 0) + 16 + 8 + 16 + 4);
            val_26.Add(item:  536891967);
            Ferr2D_DynamicMesh val_22 = this.DMesh;
            val_33 = val_30 + val_20;
            UnityEngine.Vector2 val_23 = val_29 + val_18;
            val_38 = val_20;
            val_33 = val_28 * val_33;
            val_23 = val_27 * val_23;
            if(val_32 == 0)
        {
                val_38 = val_38;
        }
        
            int val_24 = this.AddVertex(aPos:  new UnityEngine.Vector3() {x = val_18, y = val_38, z = mem[1152921509360208448]}, aUV:  new UnityEngine.Vector3() {x = val_23, y = val_33, z = 0f});
            val_28 = val_28;
            val_29 = 16 + 16;
            val_32 = this;
            val_34 = val_34 + 1;
            val_26 = 1.085141E-19f;
        }
        while(val_34 < ((aHoles + 8 + 0) + 16 + 12));
        
        }
        
        536891953 = new FerrPoly2Tri.Polygon(points:  536878175);
        val_35 = val_1;
        val_35.Add(item:  536891953);
        val_34 = aHoles;
        val_33 = 1;
        label_23:
        if(val_33 < (aHoles + 12))
        {
            goto label_34;
        }
    
    }
    private void TriangulatePoints(System.Collections.Generic.List<ClipperLibFerr.IntPoint> aPolygon, System.Collections.Generic.List<FerrPoly2Tri.Polygon> aHoles, UnityEngine.Rect aBounds, bool aSteinerPoints)
    {
        var val_5;
        var val_6;
        float val_42;
        var val_43;
        System.Collections.Generic.List<ClipperLibFerr.IntPoint> val_44;
        var val_45;
        Ferr2DT_PathTerrain val_46;
        var val_47;
        float val_48;
        float val_49;
        float val_52;
        float val_53;
        bool val_54;
        int val_55;
        var val_56;
        var val_57;
        float val_58;
        float val_59;
        var val_60;
        var val_61;
        Ferr2D_DynamicMesh val_1 = this.DMesh;
        IFerr2DTMaterial val_3 = this.TerrainMaterial;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.one;
        UnityEngine.Transform val_7 = this.transform;
        UnityEngine.Vector3 val_8 = position;
        var val_44 = val_5;
        UnityEngine.Transform val_9 = this.transform;
        UnityEngine.Vector3 val_10 = position;
        var val_45 = val_6;
        var val_42 = 0;
        val_42 = val_42 + 1;
        val_43 = this;
        val_44 = aPolygon;
        val_45 = 0;
        val_46 = this;
        if(458518448 != 0)
        {
                var val_43 = 0;
            val_43 = val_43 + 1;
            val_47 = this;
            val_46 = this;
            UnityEngine.Texture val_14 = this.mainTexture;
            val_45 = this;
        }
        
        if(458518448 != 0)
        {
                val_48 = mem[1152921509360332752] / (4.585185E+08f);
            val_49 = mem[1152921509360332752] / (4.585185E+08f);
        }
        else
        {
                val_49 = val_49;
            val_48 = val_48;
        }
        
        val_44 = val_44 + this.uvOffset;
        val_45 = val_45 + val_6;
        536878175 = new System.Collections.Generic.List<SingleRange>(capacity:  458518448);
        if(this >= 1)
        {
                var val_48 = 16;
            var val_49 = 0;
            do
        {
            if(this <= val_49)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            float val_17 = mem[1152921509360332736] / 1000f;
            if(this <= val_49)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            uint val_47 = 458518464;
            float val_18 = val_47 / 1000f;
            int val_46 = this.VertCount;
            val_46 = val_46 + val_49;
            536891967 = new FerrPoly2Tri.PolygonPoint(x:  null, y:  null, aId:  this.invertFillBorder);
            val_16.Add(item:  536891967);
            Ferr2D_DynamicMesh val_20 = this.DMesh;
            val_47 = val_45 + val_18;
            UnityEngine.Vector2 val_21 = val_44 + val_17;
            val_52 = val_18;
            val_53 = val_17;
            val_47 = val_49 * val_47;
            val_21 = val_48 * val_21;
            if(this == 0)
        {
                val_52 = val_52;
            val_53 = val_53;
        }
        
            val_42 = mem[1152921509360332736];
            int val_22 = this.AddVertex(aPos:  new UnityEngine.Vector3() {x = val_53, y = val_52, z = val_42}, aUV:  new UnityEngine.Vector3() {x = val_21, y = val_47, z = 0f});
            val_48 = val_48 + 16;
            val_49 = val_49 + 1;
        }
        while(val_49 < (aPolygon + 12));
        
        }
        
        val_54 = aSteinerPoints;
        val_55 = 0;
        536891953 = new FerrPoly2Tri.Polygon(points:  536878175);
        goto label_31;
        label_36:
        if(val_55 == 0)
        {
                if(536891953 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_23.AddHole(poly:  aHoles + 8 + 16);
        }
        
        val_55 = 1;
        label_31:
        if(val_55 < (aHoles + 12))
        {
            goto label_36;
        }
        
        if(val_54 != false)
        {
                if(mem[1152921509360332848] < 0)
        {
                val_56 = mem[mem[1152921509360332848] + 20];
            val_56 = mem[1152921509360332848] + 20;
        }
        
            float val_24 = aBounds.m_XMin.xMin;
            float val_25 = 458506392 / val_56;
            float val_26 = aBounds.m_XMin.xMax;
            val_55 = ;
            float val_27 = aBounds.m_XMin.yMin;
            uint val_50 = 458506392;
            val_50 = val_50 / val_56;
            float val_28 = 458506392 + (-0.01f);
            float val_29 = aBounds.m_XMin.yMax;
            uint val_52 = 1008981770;
            if(mem[1152921509360332848] < 0)
        {
                float val_30 = 458506392 + 0.01f;
            val_54 = 22716056;
            do
        {
            if(mem[1152921509360332848] < 0)
        {
                UnityEngine.Vector2 val_31 = val_44 + val_52;
            uint val_51 = 3156465418;
            val_31 = val_31 * val_48;
            do
        {
            Ferr2D_DynamicMesh val_32 = this.DMesh;
            int val_33 = this.VertCount;
            FerrPoly2Tri.TriangulationPoint val_34 = 536895819;
            val_55 = val_34;
            val_34 = new FerrPoly2Tri.TriangulationPoint(x:  null, y:  null, aId:  0);
            if((val_23.IsPointInside(p:  536895819)) != false)
        {
                val_23.AddSteinerPoint(point:  536895819);
            Ferr2D_DynamicMesh val_36 = this.DMesh;
            float val_37 = val_45 + val_51;
            val_55 = 3156465418;
            val_37 = val_37 * val_49;
            int val_38 = this.AddVertex(aPos:  new UnityEngine.Vector3() {x = 0.01f, y = -0.01f, z = mem[1152921509360332736]}, aUV:  new UnityEngine.Vector3() {x = val_31, y = val_37, z = 0f});
        }
        
            val_51 = val_56 + val_51;
        }
        while(this < 0);
        
        }
        
            val_52 = val_56 + val_52;
        }
        while(this < 0);
        
        }
        
        }
        
        FerrPoly2Tri.P2T.Triangulate(p:  536891953);
        val_57 = 0;
        val_58 = 4.012532E-38f;
        val_59 = 4.012633E-38f;
        goto label_53;
        label_75:
        var val_54 = mem[536891989];
        if((mem[536891989] + 178) == 0)
        {
            goto label_55;
        }
        
        var val_53 = 0;
        label_57:
        val_54 = 0;
        if((mem[536891989] + 88 + 0) == 536877027)
        {
            goto label_56;
        }
        
        val_53 = val_53 + 1;
        val_54 = (uint)val_53 & 65535;
        if(val_54 < (mem[536891989] + 178))
        {
            goto label_57;
        }
        
        label_55:
        val_60 = mem[536891989];
        goto label_58;
        label_56:
        var val_39 = (mem[536891989] + 88) + 0;
        val_54 = val_54 + (((mem[536891989] + 88 + 0) + 4) << 3);
        val_60 = val_54 + 188;
        label_58:
        val_55 = mem[536891989];
        if((((mem[536891989] + 8 + 28) != 1) && ((mem[536891989] + 12 + 28) != 1)) && ((mem[536891989] + 16 + 28) != 1))
        {
                Ferr2D_DynamicMesh val_40 = this.DMesh;
            val_54 = mem[mem[536891989] + 16 + 28];
            val_54 = mem[536891989] + 16 + 28;
            val_55 = mem[mem[536891989] + 8 + 28];
            val_55 = mem[536891989] + 8 + 28;
            this.AddFace(aV1:  val_54, aV2:  mem[536891989] + 12 + 28, aV3:  val_55);
            val_58 = 4.012532E-38f;
            val_59 = 4.012633E-38f;
        }
        
        val_57 = 1;
        label_53:
        var val_55 = mem[536891989];
        if((mem[536891989] + 178) == 0)
        {
            goto label_71;
        }
        
        val_55 = 0;
        label_73:
        val_54 = 0;
        if((mem[536891989] + 88 + 0) == val_58)
        {
            goto label_72;
        }
        
        val_55 = val_55 + 1;
        val_54 = (uint)val_55 & 65535;
        if(val_54 < (mem[536891989] + 178))
        {
            goto label_73;
        }
        
        label_71:
        val_61 = mem[536891989];
        goto label_74;
        label_72:
        var val_41 = (mem[536891989] + 88) + 0;
        val_55 = val_55 + (((mem[536891989] + 88 + 0) + 4) << 3);
        val_61 = val_55 + 188;
        label_74:
        if(val_57 < mem[536891989])
        {
            goto label_75;
        }
    
    }
    public void MarkColorSave()
    {
        bool val_3;
        bool val_4;
        bool val_5;
        bool val_6;
        if(this.vertexColorType != 3)
        {
                return;
        }
        
        if(this.recolorTree != 0)
        {
                return;
        }
        
        UnityEngine.MeshFilter val_1 = this.MeshFilter;
        UnityEngine.Mesh val_2 = this.sharedMesh;
        536892547 = new Ferr.RecolorTree(aMesh:  458646832, aTransform:  new System.Nullable<UnityEngine.Matrix4x4>() {HasValue = val_3}, aX:  val_4, aY:  val_5, aZ:  val_6);
        this.recolorTree = 536892547;
    }
    public void ClearColorSave()
    {
        this.recolorTree = 0;
    }
    private void CreateVertColors()
    {
        UnityEngine.MeshFilter val_1 = this.MeshFilter;
        UnityEngine.Mesh val_2 = this.sharedMesh;
        if(this.vertexColorType <= 3)
        {
                var val_3 = 3714312 + (3714312 + (this.vertexColorType) << 2);
            if(this.vertexColorType == 3)
        {
                3714312 + (this.vertexColorType) << 2 = (3714312 + (this.vertexColorType) << 2) & ((3714312 + (this.vertexColorType) << 2) << (3714312 + (this.vertexColorType) << 2));
            3714312 + (this.vertexColorType) << 2 = (3714312 + (this.vertexColorType) << 2) & ((IP) >> 32);
            3714312 + (this.vertexColorType) << 2 = (3714312 + (this.vertexColorType) << 2) & 0;
            3714312 + (this.vertexColorType) << 2 = R8 * (3714312 + (this.vertexColorType) << 2);
        }
        
            Ferr2DT_PathTerrain.ColorVertsSolid(aMesh:  458887216, aColor:  new UnityEngine.Color() {r = mem[this.vertexColor + (0)], g = mem[this.vertexColor + (4)], b = mem[this.vertexColor + (8)], a = 3714312 + (this.vertexColorType) << 2});
        }
        
        var val_5 = FP - 16;
    }
    private static void ColorVertsSolid(UnityEngine.Mesh aMesh, UnityEngine.Color aColor)
    {
        int val_1 = aMesh.vertexCount;
        goto label_2;
        label_5:
        0 = 1;
        mem[536881839] = aColor.r;
        mem[536881843] = aColor.g;
        mem[536881847] = aColor.b;
        mem[536881851] = aColor.a;
        label_2:
        if(0 < mem[536881835])
        {
            goto label_5;
        }
        
        aMesh.colors = 536881823;
    }
    private static void ColorVertsGradient(UnityEngine.Mesh aMesh, UnityEngine.Gradient aGradient, float aGradientAngle)
    {
        float val_5;
        float val_9;
        UnityEngine.Mesh val_18;
        UnityEngine.Gradient val_19;
        var val_20;
        var val_21;
        var val_22;
        val_18 = aMesh;
        val_19 = aGradient;
        if(val_19 == 0)
        {
            goto label_1;
        }
        
        int val_1 = val_18.vertexCount;
        if(val_18 == 0)
        {
            goto label_3;
        }
        
        UnityEngine.Vector3[] val_2 = val_18.vertices;
        goto label_4;
        label_1:
        UnityEngine.Debug.LogError(message:  -1610607873);
        return;
        label_3:
        UnityEngine.Vector3[] val_3 = 0.vertices;
        label_4:
        UnityEngine.Bounds val_4 = bounds;
        mem2[0] = val_5;
        UnityEngine.Vector3 val_6 = center;
        UnityEngine.Bounds val_7 = bounds;
        mem2[0] = val_5;
        UnityEngine.Vector3 val_8 = center;
        UnityEngine.Bounds val_10 = bounds;
        mem2[0] = val_10.m_Extents.y;
        UnityEngine.Vector3 val_11 = extents;
        float val_13 = val_5.magnitude;
        float val_18 = 0.01745329f;
        float val_19 = 3.141593f;
        val_18 = val_4.m_Extents.y * val_18;
        val_19 = val_18 + val_19;
        val_18 = 0;
        val_19 = val_9;
        val_20 = 536881839;
        val_21 = 0;
        var val_21 = 16;
        goto label_10;
        label_15:
        UnityEngine.Vector2 val_15 = Ferr2D_Path.GetClosetPointOnLine(aStart:  new UnityEngine.Vector2() {x = 1.833623E-22f, y = val_5}, aEnd:  new UnityEngine.Vector2() {x = val_19, y = val_5}, aPoint:  new UnityEngine.Vector2() {x = val_9}, aClamp:  true);
        float val_16 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_5, y = val_9}, b:  new UnityEngine.Vector2() {x = val_5, y = val_19});
        float val_20 = val_5;
        val_20 = val_20 / (459123712 + 459123712);
        UnityEngine.Color val_17 = Evaluate(time:  val_20);
        val_22 = 536881823;
        if(val_22 == 0)
        {
                val_22 = 536881823;
        }
        
        val_21 = 0;
        val_21 = val_21 + 12;
        val_18 = 1;
        label_10:
        if(val_21 == 0)
        {
                val_21 = 0;
        }
        
        if(val_18 < 0)
        {
            goto label_15;
        }
        
        val_18.colors = 536881823;
    }
    private static void ColorVertsDistanceGradient(UnityEngine.Mesh aMesh, System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed, UnityEngine.Gradient aGradient, float aGradientMaxDistance)
    {
        var val_1;
        var val_8;
        var val_9;
        var val_10;
        if(aGradient == 0)
        {
            goto label_1;
        }
        
        int val_2 = aMesh.vertexCount;
        UnityEngine.Vector3[] val_3 = aMesh.vertices;
        val_8 = aMesh + 16;
        val_9 = 536881823 + 16;
        val_10 = 0;
        goto label_4;
        label_9:
        float val_4 = Ferr.PathUtil.GetDistanceFromPath(aPath:  aPath, aPoint:  new UnityEngine.Vector2() {x = mem[(aMesh + 16) + (0)], y = mem[(aMesh + 16) + (4)]}, aClosed:  aClosed);
        System.Collections.Generic.List<UnityEngine.Vector2> val_7 = aPath;
        val_7 = val_7 / val_1;
        UnityEngine.Color val_6 = Evaluate(time:  UnityEngine.Mathf.Clamp01(value:  val_7));
        val_8 = val_8 + 12;
        val_10 = 1;
        label_4:
        if(val_10 < mem[536881835])
        {
            goto label_9;
        }
        
        aMesh.colors = 536881823;
        return;
        label_1:
        UnityEngine.Debug.LogError(message:  -1610607875);
    }
    private static void ColorVertsRecolor(UnityEngine.Mesh aMesh, Ferr.RecolorTree aRecolorTree)
    {
        bool val_2;
        if(aRecolorTree != 0)
        {
                UnityEngine.Vector3[] val_1 = aMesh.vertices;
            UnityEngine.Color[] val_19 = aRecolorTree.Recolor(aAt:  aMesh, aTransform:  new System.Nullable<UnityEngine.Matrix4x4>() {HasValue = val_2});
            aMesh.colors = aRecolorTree;
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -1610609281);
    }
    public void RecreateCollider()
    {
        if(this.IsLegacy != false)
        {
                this.LegacyRecreateCollider();
            return;
        }
        
        if(this.colliderMode == 1)
        {
            goto label_1;
        }
        
        if(this.colliderMode == 2)
        {
            goto label_2;
        }
        
        if(this.colliderMode != 3)
        {
                return;
        }
        
        R4.CreateCollider3D();
        return;
        label_1:
        this.CreatePolyCollider2D();
        return;
        label_2:
        this.CreateEdgeCollider2D();
    }
    private void CreateEdgeCollider2D()
    {
        Ferr2DT_PathTerrain.ComponentPool<UnityEngine.PolygonCollider2D, UnityEngine.PhysicsMaterial2D> val_7;
        var val_8;
        float val_9;
        var val_10;
        float val_11;
        var val_12;
        536878147 = new System.Collections.Generic.List<Page>();
        System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> val_2 = this.GetColliderVerts(aPhysicsMaterials2D:  536878147, aPhysicsMaterials3D:  0);
        UnityEngine.GameObject val_3 = this.gameObject;
        val_7 = 536873817;
        val_7 = new Ferr2DT_PathTerrain.ComponentPool<UnityEngine.PolygonCollider2D, UnityEngine.PhysicsMaterial2D>(aFrom:  459641136, aMapTo:  536878147, aConsolidate:  false);
        val_8 = 4;
        goto label_1;
        label_21:
        if(mem[536878159] <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = this.fillY;
        if(val_9 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_9 = this.fillY;
        }
        
        val_10 = mem[536878155] + 16;
        if(val_9 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_10 = 2621443;
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        mem[536878155] + 16.Add(item:  new UnityEngine.Vector2() {x = mem[43461877], y = mem[43461881]});
        if(this.fillY <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = 1.084578E-19f;
        T[] val_5 = 2621443.ToArray();
        mem[536878155] + 16.points = 2621443;
        val_11 = this.fillY;
        if(val_11 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_11 = this.fillY;
        }
        
        val_12 = -1610611231;
        if(val_11 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_12 = 2621443;
        }
        
        -1610611231.RemoveAt(index:  static_value_0028000F - 1);
        if((mem[536873829] + 12) <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        mem[536878155] + 16.sharedMaterial = mem[536873829] + 8 + 16;
        val_8 = 5;
        label_1:
        if((val_8 - 4) < this.fillY)
        {
            goto label_21;
        }
        
        this.Set2DColliderSettings<UnityEngine.PolygonCollider2D>(aColliders:  mem[536873825]);
    }
    private void CreatePolyCollider2D()
    {
        System.Collections.Generic.List<Page> val_13;
        var val_14;
        var val_15;
        val_13 = 536878147;
        val_13 = new System.Collections.Generic.List<Page>();
        System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> val_2 = this.GetColliderVerts(aPhysicsMaterials2D:  536878147, aPhysicsMaterials3D:  0);
        UnityEngine.GameObject val_3 = this.gameObject;
        536873821 = new Ferr2DT_PathTerrain.ComponentPool<UnityEngine.PolygonCollider2D, UnityEngine.PhysicsMaterial2D>(aFrom:  459753136, aMapTo:  536878147, aConsolidate:  true);
        val_14 = 4;
        goto label_1;
        label_12:
        if((mem[536873829] + 12) <= this)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        mem[536873829] + 8 + 16.pathCount = 0;
        if((mem[536873829] + 12) <= this)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((mem[536873833] + 12) <= this)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        mem[536873829] + 8 + 16.sharedMaterial = mem[536873833] + 8 + 16;
        val_14 = 5;
        val_13 = val_13;
        label_1:
        if((val_14 - 4) < (mem[536873829] + 12))
        {
            goto label_12;
        }
        
        val_15 = 4;
        goto label_13;
        label_23:
        if(mem[536878159] <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.PolygonCollider2D val_6 = 536873821.Get(aFromData:  mem[536878155] + 16);
        if(536873821 != 0)
        {
                536873821.pathCount = 536873821.pathCount + 1;
        }
        else
        {
                536873821.pathCount = 536873821.pathCount + 1;
        }
        
        if(this.fillY <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        T[] val_12 = 2621443.ToArray();
        536873821.SetPath(index:  536873821.pathCount - 1, points:  2621443);
        val_15 = 5;
        label_13:
        if(1 < this.fillY)
        {
            goto label_23;
        }
        
        this.Set2DColliderSettings<UnityEngine.PolygonCollider2D>(aColliders:  mem[536873829]);
    }
    private void Set2DColliderSettings<T>(System.Collections.Generic.List<T> aColliders)
    {
        goto label_0;
        label_6:
        if(this.isTrigger == true)
        {
                this.isTrigger = 1;
        }
        
        aColliders.isTrigger = true;
        if(this.usedByEffector == true)
        {
                this.usedByEffector = 1;
        }
        
        aColliders.usedByEffector = true;
        0 = 1;
        label_0:
        if(0 < aColliders)
        {
            goto label_6;
        }
    
    }
    private void CreateCollider3D()
    {
        Ferr2DT_PathTerrain val_19;
        Ferr2DT_PathTerrain.ComponentPool<UnityEngine.PolygonCollider2D, UnityEngine.PhysicsMaterial2D> val_20;
        Ferr2DT_PathTerrain val_21;
        var val_22;
        var val_23;
        val_19 = this;
        536878143 = new System.Collections.Generic.List<Page>();
        System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> val_2 = this.GetColliderVerts(aPhysicsMaterials2D:  0, aPhysicsMaterials3D:  536878143);
        UnityEngine.GameObject val_3 = this.gameObject;
        val_20 = 536873819;
        val_21 = val_19;
        val_20 = new Ferr2DT_PathTerrain.ComponentPool<UnityEngine.PolygonCollider2D, UnityEngine.PhysicsMaterial2D>(aFrom:  459989424, aMapTo:  536878143, aConsolidate:  false);
        val_22 = 0;
        goto label_1;
        label_42:
        536886805 = new Ferr2D_DynamicMesh();
        if((mem[536873827] + 12) <= val_22)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_19 = mem[536873827] + 8;
        val_19 = val_19 + 0;
        if(this.fillMode != 1)
        {
            goto label_5;
        }
        
        val_23 = 0;
        goto label_6;
        label_13:
        if(this.fillY <= val_22)
        {
                var val_20 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_20 = val_20 + 0;
        if(((0 + 0) + 16 + 12) <= val_23)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        int val_6 = val_5.AddVertex(aVert:  new UnityEngine.Vector3() {x = (0 + 0) + 16 + 8 + 16, y = (0 + 0) + 16 + 8 + 16 + 4, z = 0f});
        val_23 = 1;
        label_6:
        if(this.fillY <= val_22)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_21 = mem[1152921509361803704];
        val_21 = val_21 + 0;
        if(val_23 < ((mem[1152921509361803704] + 0) + 16 + 12))
        {
            goto label_13;
        }
        
        goto label_17;
        label_5:
        if(this.fillY <= val_22)
        {
                var val_22 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_22 = val_22 + 0;
        var val_7 = ((0 + 0) + 16 + 12) - 1;
        if(val_7 >= 0)
        {
                var val_8 = 8 + (((0 + 0) + 16 + 12) << 3);
            do
        {
            if(this.fillY <= val_22)
        {
                var val_23 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_23 = val_23 + 0;
            if(((0 + 0) + 16 + 12) <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            int val_9 = val_5.AddVertex(aVert:  new UnityEngine.Vector3() {x = (0 + 0) + 16 + 8 + (8 + ((0 + 0) + 16 + 12) << 3), y = (0 + 0) + 16 + 8 + (8 + ((0 + 0) + 16 + 12) << 3) + 4, z = 0f});
            val_7 = val_7 - 1;
            val_8 = val_8 - 8;
        }
        while(val_7 > 1);
        
        }
        
        label_17:
        val_19 = val_19;
        val_5.ExtrudeZ(aDist:  null, aInverted:  this.depth);
        val_20 = val_20;
        if((mem[536873831] + 12) <= val_22)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_24 = mem[536873831] + 8;
        val_24 = val_24 + 0;
        (mem[536873827] + 8 + 0) + 16.sharedMaterial = (mem[536873831] + 8 + 0) + 16;
        if(((mem[536873827] + 8 + 0) + 16) != 0)
        {
                if(this.isTrigger == true)
        {
                this.isTrigger = 1;
        }
        
            (mem[536873827] + 8 + 0) + 16.isTrigger = true;
        }
        else
        {
                if(this.isTrigger == true)
        {
                this.isTrigger = 1;
        }
        
            (mem[536873827] + 8 + 0) + 16.isTrigger = true;
        }
        
        UnityEngine.Mesh val_10 = (mem[536873827] + 8 + 0) + 16.sharedMesh;
        UnityEngine.GameObject val_11 = this.gameObject;
        int val_12 = this.GetInstanceID();
        string val_13 = System.String.Format(format:  -1610608197, arg0:  536888987);
        val_21 = val_21;
        if(((mem[536873827] + 8 + 0) + 16) == 0)
        {
            goto label_33;
        }
        
        string val_15 = (mem[536873827] + 8 + 0) + 16.name;
        if((System.String.op_Inequality(a:  (mem[536873827] + 8 + 0) + 16, b:  -1610608197)) == false)
        {
            goto label_35;
        }
        
        label_33:
        536890419 = new UnityEngine.Mesh();
        (mem[536873827] + 8 + 0) + 16.sharedMesh = 536890419;
        val_17.name = -1610608197;
        val_21 = val_21;
        label_35:
        (mem[536873827] + 8 + 0) + 16.sharedMesh = 0;
        val_5.Build(aMesh: ref  UnityEngine.Mesh val_18 = 459977380, aCalculateTangents:  false);
        (mem[536873827] + 8 + 0) + 16.sharedMesh = 536890419;
        val_22 = 1;
        label_1:
        if(val_22 < this.fillY)
        {
            goto label_42;
        }
    
    }
    public System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> GetColliderVerts(System.Collections.Generic.List<UnityEngine.PhysicsMaterial2D> aPhysicsMaterials2D, System.Collections.Generic.List<UnityEngine.PhysicMaterial> aPhysicsMaterials3D)
    {
        UnityEngine.Vector2 val_5;
        float val_6;
        Ferr2DT_PathTerrain val_54;
        Ferr2DT_PathTerrain val_55;
        var val_56;
        Ferr2DPath val_57;
        var val_58;
        var val_59;
        var val_60;
        if(this.IsLegacy == false)
        {
            goto label_1;
        }
        
        System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> val_2 = this.LegacyGetColliderVerts();
        goto label_9;
        label_1:
        IFerr2DTMaterial val_3 = this.TerrainMaterial;
        if(this == 0)
        {
            goto label_3;
        }
        
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        this.unitsPerUV = val_5;
        mem[1152921509361952712] = val_6;
        536877671 = new System.Collections.Generic.List<Page>();
        UnityEngine.Vector2 val_8 = UnitsPerUV;
        if(this.edgeMode != 2)
        {
                if(this.fillCollider == false)
        {
            goto label_5;
        }
        
        }
        
        System.Collections.Generic.List<UnityEngine.Vector2> val_9 = this.CreateFillCollider();
        536877671.Add(item:  460138288);
        if(aPhysicsMaterials2D != 0)
        {
                aPhysicsMaterials2D.Add(item:  this.physicsMaterial2D);
        }
        
        if(aPhysicsMaterials3D != 0)
        {
                aPhysicsMaterials3D.Add(item:  this.physicsMaterial);
        }
        
        if(this.edgeMode == 2)
        {
            goto label_9;
        }
        
        label_5:
        System.Collections.Generic.List<UnityEngine.Vector2> val_10 = this.pathData.GetFinalPath();
        System.Collections.Generic.List<EdgeSegment> val_11 = Ferr2DT_PathTerrain.EdgeSegment.CreateEdgeSegments(aPath:  this.pathData, aSplitCorners:  this.splitCorners);
        goto label_12;
        label_30:
        if((this.fillSplitDistance + 0) == 536888251)
        {
            goto label_29;
        }
        
         =  + 1;
        if(((uint) & 65535) < this.createCollider)
        {
            goto label_30;
        }
        
        val_54 = ;
        goto label_31;
        label_29:
        float val_27 = this.fillSplitDistance + 0;
         =  + (((this.fillSplitDistance + 0) + 4) << 3);
        val_54 =  + 284;
        label_31:
        IFerr2DTMaterial val_28 = this.TerrainMaterial;
        Ferr2DT_PathTerrain val_59 = this;
        if(this.createCollider == false)
        {
            goto label_33;
        }
        
        var val_58 = 0;
        label_35:
        if((this.fillSplitDistance + 0) == 536888251)
        {
            goto label_34;
        }
        
        val_58 = val_58 + 1;
        if(((uint)val_58 & 65535) < this.createCollider)
        {
            goto label_35;
        }
        
        label_33:
        val_55 = this;
        goto label_36;
        label_34:
        float val_29 = this.fillSplitDistance + 0;
        val_59 = val_59 + (((this.fillSplitDistance + 0) + 4) << 3);
        val_55 = val_59 + 284;
        label_36:
        if(0f == 1)
        {
                0f + 0f = 0;
        }
        
        if(0f == 1)
        {
                0f + 0f = 0;
        }
        
        if(225 != 0)
        {
                225 = 0;
            0f + 0f = 0;
        }
        
        val_56 = 22739676;
        if(225 != 0)
        {
                0f + 0f = 0;
        }
        
        float val_32 = 0f.width;
        if(225 == 1)
        {
                225 = 0;
        }
        
        float val_33 = 0f.width;
        if(225 == 1)
        {
                225 = 0;
        }
        
        536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        System.Collections.Generic.List<UnityEngine.Vector2> val_35 = 536878507;
        System.Collections.Generic.List<UnityEngine.Vector2> val_47 = 536878507;
        val_35 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        float val_60 = -7.271112E-27f;
        val_60 = val_60 - (0f + 0f);
        2621443.Sample(aDistance:  val_60, aSmoothIndex: out  val_60, aSmoothPercent: out  float val_37 = 1.960151E-22f, aPoint: out  new UnityEngine.Vector2() {x = 1.96015E-22f, y = 0f}, aNormal: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, aData: out  new Ferr2D_PointData() {scale = 0f});
        536878507.Add(item:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        float val_61 = 0f;
        float val_62 = 0f;
        val_61 = val_61 * 0f;
        val_62 = val_62 * 0f;
        val_35.Add(item:  new UnityEngine.Vector2() {x = val_61, y = val_62});
        float val_63 = -7.271112E-27f;
        val_63 = val_63 + static_value_00280023;
        val_63 = (0f + 0f) + val_63;
        2621443.Sample(aDistance:  val_63, aSmoothIndex: out  val_63, aSmoothPercent: out  float val_39 = 1.96015E-22f, aPoint: out  new UnityEngine.Vector2() {x = 1.96015E-22f, y = 0f}, aNormal: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, aData: out  new Ferr2D_PointData() {scale = 0f});
        if(val_35 <= 0)
        {
                0f = 1;
        }
        
        int val_41 = Ferr.PathUtil.WrapIndex(aIndex:  0f + 1, aCount:  this.pathData, aClosed:  true);
        if(this.pathData != val_41)
        {
                do
        {
            2621443.SampleSmoothVert(aSmoothIndex:  this.pathData, aPoint: out  new UnityEngine.Vector2() {x = 1.960145E-22f, y = 1.960144E-22f}, aNormal: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, aData: out  new Ferr2D_PointData() {directionOverride = 0f});
            536878507.Add(item:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            float val_64 = 0f;
            float val_65 = 0f;
            val_64 = val_64 * 0f;
            val_65 = val_65 * 0f;
            val_35.Add(item:  new UnityEngine.Vector2() {x = val_64, y = val_65});
            Ferr2DPath val_42 = this.pathData + 1;
            val_56 = 22739676;
        }
        while(this.pathData != val_41);
        
        }
        
        536878507.Add(item:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        float val_66 = 0f;
        float val_67 = 0f;
        val_66 = val_66 * 0f;
        val_67 = val_67 * 0f;
         =  * 460138288;
        val_35.Add(item:  new UnityEngine.Vector2() {x = val_66, y = val_67});
         =  * val_6;
        val_57 = this.pathData;
        int val_43 = mem[536878519] - 1;
        if(val_43 >= 0)
        {
                float val_44 = 460138288 - ;
            var val_45 = 8 + (mem[536878519] << 3);
            int val_77 = val_43;
            do
        {
            if(mem[536878519] <= val_77)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            float val_69 = mem[536878515];
            val_69 = val_69 + val_45;
            if(mem[536878519] <= val_77)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_70 = mem[536878515];
            val_70 = val_70 + val_45;
            if(mem[536878519] <= val_77)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_71 = mem[536878515];
            val_71 = val_71 + val_45;
            if(mem[536878519] <= val_77)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_72 = mem[536878515];
            val_72 = val_72 + val_45;
            536878507.Add(item:  new UnityEngine.Vector2() {x = val_69, y = (mem[536878515] + (8 + (mem[536878519]) << 3)) + 4});
            if(mem[536878519] <= val_77)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            float val_73 = mem[536878515];
            val_73 = val_73 + val_45;
            if(mem[536878519] <= val_77)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_74 = mem[536878515];
            val_74 = val_74 + val_45;
            if(mem[536878519] <= val_77)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_75 = mem[536878515];
            val_75 = val_75 + val_45;
            if(mem[536878519] <= val_77)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_76 = mem[536878515];
            val_76 = val_76 + val_45;
            536878507.set_Item(index:  val_77, value:  new UnityEngine.Vector2() {x = val_73, y = (mem[536878515] + (8 + (mem[536878519]) << 3)) + 4});
            val_77 = val_77 - 1;
            val_45 = val_45 - 8;
        }
        while(val_77 > 1);
        
        }
        
        if((225 == 0) && (225 != 0))
        {
                if(225 == 1)
        {
                if(mem[536878519] <= val_43)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_78 = mem[536878515];
            val_78 = val_78 + (val_43 << 3);
            (mem[536878515] + ((mem[536878519] - 1)) << 3) + 16.AddCircleColliderCap(aRightSide:  false, aPoints: ref  System.Collections.Generic.List<UnityEngine.Vector2> val_46 = 460126116, aNormal:  new UnityEngine.Vector2() {x = (mem[536878515] + ((mem[536878519] - 1)) << 3) + 16, y = (mem[536878515] + ((mem[536878519] - 1)) << 3) + 20}, aPt:  new UnityEngine.Vector2() {x = 0f, y = 0f}, aWidth:  0f, aYOffset:  val_25.m_YMin, aThickness:  val_67);
        }
        else
        {
                if(val_57 != 0)
        {
                val_58 = mem[this.pathData + 12];
            val_58 = this.pathData + 12;
            val_59 = val_58;
        }
        else
        {
                val_59 = mem[this.pathData + 12];
            val_59 = this.pathData + 12;
            val_58 = mem[this.pathData + 12];
            val_58 = this.pathData + 12;
        }
        
            var val_79 = 0;
            val_79 = val_79 + 1;
            if(val_58 <= val_59)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_57 = this.pathData;
            var val_80 = this.pathData + 8;
            val_80 = val_80 + (val_59 << 2);
            if((((this.pathData + 8 + (this.pathData + 12) << 2) + 16) != 2621443) && (((this.pathData + 8 + (this.pathData + 12) << 2) + 16 + 12) == (-1610611231)))
        {
                var val_82 = 225;
            if(0 == 2)
        {
                bool val_81 = true;
            val_81 =  ^ val_81;
            this.AddConnectedColliderCap(aRightSide:  false, aInner:  val_81, aSharp:  true, aToSeg:  (this.pathData + 8 + (this.pathData + 12) << 2) + 16, aPoints: ref  val_47, aNormals:  val_35);
        }
        else
        {
                if((-4) < 2)
        {
                val_82 = val_82 - 5;
            bool val_83 = true;
            val_83 =  ^ val_83;
            this.AddIntersectionColliderCap(aRightSide:  false, aInner:  val_83, aOnlyBottom:  val_82 >> 5, aToSeg:  (this.pathData + 8 + (this.pathData + 12) << 2) + 16, aPoints: ref  val_47, aNormals:  val_35);
        }
        else
        {
                if(val_82 == 6)
        {
                this.AddIntersectionEdgeColliderCap(aRightSide:  false, aInner:   ^ true, aToSeg:  (this.pathData + 8 + (this.pathData + 12) << 2) + 16, aPoints: ref  val_47, aNormals:  val_35);
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        if((225 == 0) && (225 != 0))
        {
                if(225 == 1)
        {
                if(mem[536878519] == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            mem[536878515] + 16.AddCircleColliderCap(aRightSide:  true, aPoints: ref  System.Collections.Generic.List<UnityEngine.Vector2> val_50 = 460126116, aNormal:  new UnityEngine.Vector2() {x = mem[536878515] + 16, y = mem[536878515] + 20}, aPt:  new UnityEngine.Vector2() {x = 0f, y = 0f}, aWidth:  0f, aYOffset:  val_25.m_YMin, aThickness:  val_67);
        }
        else
        {
                if(val_57 != 0)
        {
                val_60 = Ferr.PathUtil.WrapIndex(aIndex:  0 - 1, aCount:  this.pathData + 12, aClosed:  true);
        }
        else
        {
                val_60 = Ferr.PathUtil.WrapIndex(aIndex:  0 - 1, aCount:  this.pathData + 12, aClosed:  true);
        }
        
            if((this.pathData + 12) <= val_60)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_84 = this.pathData + 8;
            val_84 = val_84 + (val_60 << 2);
            if(((this.pathData + 8 + (val_54) << 2) + 16) != 2621443)
        {
                var val_86 = 225;
            if(0 == 2)
        {
                bool val_85 = true;
            val_85 =  ^ val_85;
            this.AddConnectedColliderCap(aRightSide:  true, aInner:  val_85, aSharp:  true, aToSeg:  (this.pathData + 8 + (val_54) << 2) + 16, aPoints: ref  val_47, aNormals:  val_35);
        }
        else
        {
                if((-4) < 2)
        {
                val_86 = val_86 - 5;
            bool val_87 = true;
            val_87 =  ^ val_87;
            this.AddIntersectionColliderCap(aRightSide:  true, aInner:  val_87, aOnlyBottom:  val_86 >> 5, aToSeg:  (this.pathData + 8 + (val_54) << 2) + 16, aPoints: ref  val_47, aNormals:  val_35);
        }
        
        }
        
        }
        
        }
        
        }
    
    }
    private System.Collections.Generic.List<UnityEngine.Vector2> CreateFillCollider()
    {
        var val_22;
        var val_23;
        float val_26;
        var val_27;
        var val_28;
        float val_29;
        float val_30;
        val_22 = this;
        System.Collections.Generic.List<UnityEngine.Vector2> val_1 = this.pathData.GetFinalPathCopy();
        UnityEngine.Rect val_2 = Ferr.PathUtil.GetBounds(aPoints:  460279184, aPadding:  new UnityEngine.Vector4() {x = this.pathData, y = 0f, z = 0f, w = 0f});
        if(this.useSkirt != false)
        {
                if(this.pathData == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(this.pathData == 0)
        {
                var val_22 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_22 = val_22 + ((this.pathData - 1) << 3);
            val_23 = 22739676;
            val_26 = mem[(0 + ((this.pathData - 1)) << 3) + 16];
            val_26 = (0 + ((this.pathData - 1)) << 3) + 16;
            this.pathData.Add(item:  new UnityEngine.Vector2() {x = val_26, y = this.fillY});
            this.pathData.Add(item:  new UnityEngine.Vector2() {x = val_26, y = this.fillY});
            float val_5 = UnityEngine.Mathf.Lerp(a:  UnityEngine.Mathf.Lerp(a:  val_2.m_XMin, b:  val_2.m_YMin, t:  val_2.m_Width), b:  val_2.m_YMin, t:  val_2.m_Width);
            this.pathData.Add(item:  new UnityEngine.Vector2() {x = val_26, y = this.fillY});
            this.pathData.Add(item:  new UnityEngine.Vector2() {x = 3.673424E-39f, y = this.fillY});
        }
        
        if(this.fillMode != 1)
        {
                return;
        }
        
        val_27 = 0;
        val_28 = 0;
        goto label_7;
        label_12:
        if(this.fillMode <= val_27)
        {
                var val_23 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_23 = val_23 + 16;
        if(this.fillMode < 0)
        {
                val_28 = val_27;
            if(val_23 <= val_27)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_28 = val_27;
        }
        
        }
        
        val_27 = 1;
        label_7:
        if(val_27 < 16)
        {
            goto label_12;
        }
        
        if(val_27 == 16)
        {
                float val_6 = width;
            val_29 = 460279200;
        }
        
        if(val_27 == 16)
        {
                float val_7 = height;
            val_30 = 460279200;
        }
        
        val_23 = 536882585;
        if(536882585 <= val_28)
        {
                var val_24 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_24 = val_24 + 0;
        val_22 = mem[(0 + 0) + 16];
        val_22 = (0 + 0) + 16;
        mem[536882601] = val_22;
        float val_8 = xMax;
        uint val_25 = 460279200;
        float val_9 = yMax;
        val_25 = val_29 + val_25;
        mem[536882609] = val_25;
        mem[536882613] = val_30 + 460279200;
        float val_11 = xMax;
        uint val_26 = 460279200;
        float val_12 = yMin;
        val_26 = val_29 + val_26;
        mem[536882617] = val_26;
        mem[536882621] = 460279200 - val_30;
        float val_14 = xMin;
        uint val_27 = 460279200;
        float val_15 = yMin;
        val_27 = val_27 - val_29;
        mem[536882625] = val_27;
        mem[536882629] = 460279200 - val_30;
        float val_17 = xMin;
        uint val_28 = 460279200;
        float val_18 = yMax;
        val_28 = val_28 - val_29;
        mem[536882633] = val_28;
        mem[536882637] = val_30 + 460279200;
        float val_20 = xMax;
        float val_21 = yMax;
        val_29 = val_29 + 460279200;
        val_30 = val_30 + 460279200;
        mem[536882641] = val_29;
        mem[536882645] = val_30;
        this.pathData.InsertRange(index:  0, collection:  536882585);
    }
    private int Trim(bool aRightSide, ref System.Collections.Generic.List<UnityEngine.Vector2> aPoints, UnityEngine.Vector2[] aPts, UnityEngine.Vector2[] aNormals)
    {
        bool val_9 = aRightSide;
        var val_9 = mem[aPoints + 12];
        val_9 = val_9 + (val_9 >> 31);
        int val_1 = val_9 >> 1;
        if(aPts == null)
        {
                return val_1;
        }
        
        if(val_9 == false)
        {
                return (int)this._TrimArray(aPoints: ref  System.Collections.Generic.List<UnityEngine.Vector2> val_7 = 460521200, aStart:  val_1, aPts:  aPts, aNormals:  aNormals);
        }
        
        int val_3 = this._TrimArray(aPoints: ref  System.Collections.Generic.List<UnityEngine.Vector2> val_2 = 460521200, aStart:  0, aPts:  aPts, aNormals:  aNormals);
        val_9 = aPoints;
        int val_6 = this._TrimArray(aPoints: ref  System.Collections.Generic.List<UnityEngine.Vector2> val_5 = 460521200, aStart:  (mem[aPoints + 12]) - 1, aPts:  aPts, aNormals:  aNormals);
        return val_1;
    }
    private int _TrimArray(ref System.Collections.Generic.List<UnityEngine.Vector2> aPoints, int aStart, UnityEngine.Vector2[] aPts, UnityEngine.Vector2[] aNormals)
    {
        int val_5;
        var val_6;
        var val_7;
        float val_8;
        val_5 = aStart;
        val_6 = 22968960;
        if(val_5 >= 0)
        {
                if((mem[aPoints + 12]) >= val_5)
        {
            goto label_3;
        }
        
        }
        
        label_20:
        val_7 = val_5;
        return (int)val_7;
        label_3:
        val_6 = 0;
        val_8 = 4.022034E-38f;
        goto label_5;
        label_11:
        aPoints.RemoveAt(index:  val_5);
        val_6 = 1;
        label_5:
        if((mem[aPoints + 12]) <= val_5)
        {
            goto label_8;
        }
        
        if((mem[aPoints + 12]) <= val_5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_4 = mem[aPoints + 8];
        val_4 = val_4 + (val_5 << 3);
        if(((mem[aPoints + 8] + (aStart) << 3) + 16._TrimCheckPlanes(aPoint:  new UnityEngine.Vector2() {x = (mem[aPoints + 8] + (aStart) << 3) + 16, y = (mem[aPoints + 8] + (aStart) << 3) + 20}, aPts:  aPts, aNormals:  aNormals)) == true)
        {
            goto label_11;
        }
        
        label_8:
        int val_2 = val_5 - 1;
        if(val_2 < 1)
        {
            goto label_12;
        }
        
        val_8 = 8 + (val_5 << 3);
        val_5 = val_2;
        label_19:
        if(val_5 >= (mem[aPoints + 12]))
        {
            goto label_17;
        }
        
        if((mem[aPoints + 12]) <= val_5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((aNormals._TrimCheckPlanes(aPoint:  new UnityEngine.Vector2() {x = mem[aPoints + 8] + (8 + (aStart) << 3), y = mem[aPoints + 8] + (8 + (aStart) << 3) + 4}, aPts:  aPts, aNormals:  aNormals)) == false)
        {
            goto label_17;
        }
        
        aPoints.RemoveAt(index:  val_5);
        val_5 = val_5 - 1;
        val_8 = val_8 - 8;
        if(val_5 >= 1)
        {
            goto label_19;
        }
        
        goto label_20;
        label_12:
        val_5 = val_2;
        label_17:
        if(val_6 != 1)
        {
                val_7 = val_5;
        }
        
        return (int)val_7;
    }
    private bool _TrimCheckPlanes(UnityEngine.Vector2 aPoint, UnityEngine.Vector2[] aPts, UnityEngine.Vector2[] aNormals)
    {
        var val_6;
        var val_4 = 0;
        label_5:
        if(val_4 >= this)
        {
            goto label_1;
        }
        
        float val_2 = aPoint.x - 1152921504993028592;
        float val_3 = (aPoint.y - S22) * S2;
        val_4 = val_4 + 1;
        if(this >= 0)
        {
            goto label_5;
        }
        
        val_6 = 0;
        return (bool)val_6;
        label_1:
        val_6 = 1;
        return (bool)val_6;
    }
    private void CalcCapData(bool aRightSide, bool aInner, Ferr2DT_PathTerrain.EdgeSegment aAdjSeg, System.Collections.Generic.List<UnityEngine.Vector2> aPoints, System.Collections.Generic.List<UnityEngine.Vector2> aNormals, out UnityEngine.Vector2 adjTop, out UnityEngine.Vector2 adjBot, out UnityEngine.Vector2 adjDir, out UnityEngine.Vector2 currTop, out UnityEngine.Vector2 currBot, out UnityEngine.Vector2 currDir)
    {
        float val_2;
        float val_3;
        var val_25;
        var val_26;
        var val_27;
        float val_28;
        var val_29;
        float val_30;
        var val_31;
        var val_32;
        UnityEngine.Vector2 val_1 = UnitsPerUV;
        IFerr2DTMaterial val_4 = this.TerrainMaterial;
        if(aAdjSeg.direction < 4)
        {
                aAdjSeg.direction = 3 - aAdjSeg.direction;
        }
        
        if(this.edgeMode != 1)
        {
                aAdjSeg.direction = aAdjSeg.direction;
        }
        
        var val_24 = 0;
        val_24 = val_24 + 1;
        val_25 = this;
        Ferr2D_SectionMode val_7 = (this.edgeMode - 1) >> 5;
        Ferr2D_SectionMode val_8 = val_7 ^ aInner;
        if(aRightSide != false)
        {
                float val_9 = this.GetLeftCapOffset(aInner:  val_8, aUnitsPerUV:  new UnityEngine.Vector2() {x = val_2, y = val_3}, aId:  0);
            val_26 = 461276144;
            val_27 = this;
            float val_10 = this.GetLeftCapSize(aInner:  val_8, aUnitsPerUV:  new UnityEngine.Vector2() {x = val_2, y = val_3}, aId:  0);
        }
        else
        {
                float val_11 = this.GetRightCapOffset(aInner:  val_8, aUnitsPerUV:  new UnityEngine.Vector2() {x = val_2, y = val_3}, aId:  0);
            val_26 = 461276144;
            val_27 = this;
            float val_12 = this.GetRightCapSize(aInner:  val_8, aUnitsPerUV:  new UnityEngine.Vector2() {x = val_2, y = val_3}, aId:  0);
        }
        
        float val_13 = val_26 + 461276144;
        float val_14 = this.GetYOffsetCollider(aInvert:  val_7, aUnitsPerUV:  new UnityEngine.Vector2() {x = val_2, y = val_3});
        float val_25 = aAdjSeg.startDistance;
        if(aRightSide != false)
        {
                val_25 = val_25 + aAdjSeg.length;
            val_28 = val_13 + val_25;
        }
        else
        {
                val_28 = val_25 - val_13;
        }
        
        val_29 = adjTop.y;
        aAdjSeg.Sample(aDistance:  val_28, aPoint: out  new UnityEngine.Vector2() {x = val_28, y = 2.103781E-22f}, aNormal: out  new UnityEngine.Vector2() {x = 2.10378E-22f, y = 0f}, aData: out  new Ferr2D_PointData() {cutOverrides = aInner, scale = val_2});
        float val_15 = 0f * 0f;
        float val_16 = 0f * 0f;
        adjTop.x = 0;
        mem[1152921509363134708] = 0;
        if(this != 0)
        {
                val_30 = this.sharpCornerDistance;
        }
        else
        {
                val_30 = 4.315999E-43f;
        }
        
        float val_17 = this.GetBodyMaxHeight();
        uint val_26 = 461276144;
        val_26 = val_30 * val_26;
        mem[1152921509363138852] = 0f;
        adjTop.y = 0f;
        if(aRightSide == false)
        {
            goto label_18;
        }
        
        UnityEngine.Vector2 val_18 = Ferr.Extensions.VectorExtensions.Rot90CCW(aVec:  new UnityEngine.Vector2() {x = 2.103777E-22f, y = 0f});
        if(val_2 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Vector2 val_19 = Ferr.Extensions.VectorExtensions.Rot90CW(aVec:  new UnityEngine.Vector2() {x = 2.103777E-22f, y = 3.673424E-39f});
        val_31 = val_3;
        if(val_2 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_32 = (aPoints + 8 + 4) - 1;
        if((aPoints + 8 + 4) != 0)
        {
            goto label_29;
        }
        
        goto label_24;
        label_18:
        val_29 = adjBot.y;
        UnityEngine.Vector2 val_20 = Ferr.Extensions.VectorExtensions.Rot90CW(aVec:  new UnityEngine.Vector2() {x = 2.103777E-22f, y = 0f});
        var val_21 = val_2 + (val_2 >> 31);
        var val_22 = 0 + (val_21 >> 1);
        if(0 <= val_22)
        {
                var val_27 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_32 = val_21 >> 1;
        val_27 = val_27 + (val_22 << 3);
        UnityEngine.Vector2 val_23 = Ferr.Extensions.VectorExtensions.Rot90CCW(aVec:  new UnityEngine.Vector2() {x = 2.103777E-22f, y = (0 + ((0 + ((int)(val_2 + (val_2) >> 31)) >> 1)) << 3) + 16});
        val_31 = val_3;
        if(val_2 <= val_22)
        {
                var val_28 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_28 = val_28 + (val_22 << 3);
        if((aPoints + 8 + 4) > val_32)
        {
            goto label_29;
        }
        
        label_24:
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        label_29:
        var val_29 = aPoints + 8;
        val_29 = val_29 + (val_32 << 3);
    }
    private void AddConnectedColliderCap(bool aRightSide, bool aInner, bool aSharp, Ferr2DT_PathTerrain.EdgeSegment aToSeg, ref System.Collections.Generic.List<UnityEngine.Vector2> aPoints, System.Collections.Generic.List<UnityEngine.Vector2> aNormals)
    {
        float val_11;
        float val_12;
        int val_22;
        bool val_23;
        Ferr2D_SectionMode val_24;
        bool val_25;
        System.Collections.Generic.List<UnityEngine.Vector2> val_26;
        var val_27;
        int val_28;
        int val_29;
        float val_30;
        float val_31;
        float val_32;
        float val_33;
        int val_34;
        float val_35;
        float val_36;
        var val_37;
        var val_38;
        int val_39;
        int val_40;
        float val_41;
        float val_42;
        int val_43;
        float val_44;
        val_22 = this;
        val_23 = aRightSide;
        IFerr2DTMaterial val_1 = this.TerrainMaterial;
        val_24 = this.edgeMode;
        val_25 = val_22;
        if(aToSeg.direction < 4)
        {
                aToSeg.direction = 3 - aToSeg.direction;
        }
        
        if(val_24 != 1)
        {
                aToSeg.direction = aToSeg.direction;
        }
        
        val_24 = 0;
        val_24 = val_24 + 1;
        val_27 = val_25;
        if(val_25 <= 0)
        {
                return;
        }
        
        val_25 = val_23;
        this.CalcCapData(aRightSide:  val_25, aInner:  aInner, aAdjSeg:  aToSeg, aPoints:  aPoints, aNormals:  aNormals, adjTop: out  new UnityEngine.Vector2() {x = 2.141134E-22f, y = 0f}, adjBot: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, adjDir: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, currTop: out  new UnityEngine.Vector2(), currBot: out  new UnityEngine.Vector2() {x = aSharp, y = aInner}, currDir: out  new UnityEngine.Vector2());
        float val_3 = 0f * 0f;
        if(val_25 < 0)
        {
                int val_5 = this.Trim(aRightSide:  val_25, aPoints: ref  System.Collections.Generic.List<UnityEngine.Vector2> val_4 = 461514880, aPts:  null, aNormals:  0);
            return;
        }
        
        if(val_25 <= 0)
        {
            goto label_11;
        }
        
        mem[536882601] = 0f;
        mem[536882605] = 0f;
        mem[536882601] = 0f;
        mem[536882605] = 0f;
        val_28 = (this.Trim(aRightSide:  val_25, aPoints: ref  System.Collections.Generic.List<UnityEngine.Vector2> val_6 = 461514880, aPts:  536882585, aNormals:  536882585)) + 1;
        if(val_25 == false)
        {
            goto label_16;
        }
        
        val_22 = 0f;
        val_26 = 0f;
        val_24 = 0f;
        val_29 = mem[aPoints + 12];
        goto label_18;
        label_11:
        mem[536882601] = 0f;
        mem[536882605] = 0f;
        if(0f == 0)
        {
            goto label_21;
        }
        
        val_30 = 0f;
        val_31 = 0f;
        val_32 = 0f - val_30;
        val_33 = 0f - val_31;
        goto label_22;
        label_16:
        val_26 = 0f;
        val_22 = 0f;
        val_24 = 0f;
        val_29 = val_28;
        label_18:
        val_23 = 4.022032E-38f;
        aPoints.Insert(index:  val_29, item:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        if(val_25 == false)
        {
            goto label_24;
        }
        
        val_28 = mem[aPoints + 12];
        goto label_37;
        label_21:
        val_30 = 0f;
        val_31 = 0f;
        val_32 = val_30 - 0f;
        val_33 = val_31 - 0f;
        label_22:
        mem[536882601] = val_32;
        mem[536882605] = val_33;
        val_34 = (this.Trim(aRightSide:  val_25, aPoints: ref  System.Collections.Generic.List<UnityEngine.Vector2> val_8 = 461514880, aPts:  536882585, aNormals:  536882585)) + 1;
        val_22 = val_34;
        if(val_25 != false)
        {
                val_34 = mem[aPoints + 12];
        }
        
        val_35 = 0f;
        val_36 = 0f;
        if(0f != 0)
        {
                if(aSharp == false)
        {
            goto label_32;
        }
        
        }
        
        uint val_16 = 0;
        val_16 = 0f + val_16;
        uint val_17 = 0;
        uint val_18 = 0;
        val_17 = 0f + val_17;
        val_18 = 0f + val_18;
        uint val_19 = 0;
        val_19 = 0f + val_19;
        UnityEngine.Vector2 val_10 = Ferr.PathUtil.LineIntersectionPoint(aLine1Pt1:  new UnityEngine.Vector2() {x = 2.141121E-22f, y = 0f}, aLine1Pt2:  new UnityEngine.Vector2() {x = 0f}, aLine2Pt1:  new UnityEngine.Vector2() {y = 0f}, aLine2Pt2:  new UnityEngine.Vector2() {x = 0f});
        val_35 = val_11;
        val_36 = val_12;
        label_32:
        aPoints.Insert(index:  val_34, item:  new UnityEngine.Vector2() {x = val_35, y = val_36});
        if(val_25 == false)
        {
            goto label_34;
        }
        
        val_37 = 0f;
        val_38 = 0f;
        val_39 = mem[aPoints + 12];
        goto label_36;
        label_24:
        label_37:
        val_40 = val_28;
        val_41 = 0f;
        val_42 = val_22;
        goto label_38;
        label_34:
        val_37 = 0f;
        val_38 = 0f;
        val_39 = val_22;
        label_36:
        val_23 = 0;
        aPoints.Insert(index:  val_39, item:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        if(val_25 != false)
        {
                val_43 = mem[aPoints + 12];
        }
        else
        {
                val_43 = val_22;
            if(aPoints == 0)
        {
                val_43 = val_22;
        }
        
        }
        
        aPoints.Insert(index:  val_43, item:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        val_26 = aPoints;
        if(val_25 != false)
        {
                val_22 = mem[aPoints + 12];
        }
        
        val_44 = 0f;
        val_24 = 0f;
        if(0f == 0)
        {
                0f = aSharp;
        }
        
        if(0f != false)
        {
                uint val_20 = 0;
            uint val_21 = 0;
            val_20 = 0f + val_20;
            val_21 = 0f + val_21;
            float val_14 = 0f + val_31;
            UnityEngine.Vector2 val_15 = Ferr.PathUtil.LineIntersectionPoint(aLine1Pt1:  new UnityEngine.Vector2() {x = 2.141121E-22f, y = 0f}, aLine1Pt2:  new UnityEngine.Vector2() {x = 0f}, aLine2Pt1:  new UnityEngine.Vector2(), aLine2Pt2:  new UnityEngine.Vector2() {x = val_23, y = 0f + val_30});
            val_44 = val_11;
            val_24 = val_12;
        }
        
        val_40 = val_22;
        val_41 = val_44;
        val_42 = val_24;
        label_38:
        val_26.Insert(index:  val_40, item:  new UnityEngine.Vector2() {x = val_41, y = val_42});
    }
    private void AddIntersectionColliderCap(bool aRightSide, bool aInner, bool aOnlyBottom, Ferr2DT_PathTerrain.EdgeSegment aToSeg, ref System.Collections.Generic.List<UnityEngine.Vector2> aPoints, System.Collections.Generic.List<UnityEngine.Vector2> aNormals)
    {
        float val_4;
        float val_5;
        bool val_12;
        EdgeSegment val_13;
        bool val_14;
        Ferr2D_SectionMode val_15;
        bool val_16;
        var val_17;
        float val_18;
        System.Collections.Generic.List<UnityEngine.Vector2> val_19;
        int val_20;
        val_12 = aInner;
        val_13 = aToSeg;
        val_14 = aRightSide;
        IFerr2DTMaterial val_1 = this.TerrainMaterial;
        val_15 = this.edgeMode;
        val_16 = this;
        if(aToSeg.direction < 4)
        {
                aToSeg.direction = 3 - aToSeg.direction;
        }
        
        if(val_15 != 1)
        {
                aToSeg.direction = aToSeg.direction;
        }
        
        val_15 = 0;
        val_15 = val_15 + 1;
        val_17 = val_16;
        if(val_16 <= 0)
        {
                return;
        }
        
        val_16 = val_14;
        this.CalcCapData(aRightSide:  val_14, aInner:  val_12, aAdjSeg:  aToSeg, aPoints:  aPoints, aNormals:  aNormals, adjTop: out  new UnityEngine.Vector2() {x = 2.179722E-22f, y = 2.17972E-22f}, adjBot: out  new UnityEngine.Vector2() {x = 2.179718E-22f, y = 2.179714E-22f}, adjDir: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, currTop: out  new UnityEngine.Vector2(), currBot: out  new UnityEngine.Vector2() {x = aOnlyBottom, y = this}, currDir: out  new UnityEngine.Vector2());
        val_14 = 0f;
        val_18 = 0f;
        if(aOnlyBottom != false)
        {
                if(val_12 == false)
        {
            goto label_10;
        }
        
        }
        
        float val_11 = 0f;
        val_11 = val_11 + 0;
        uint val_12 = 0;
        val_12 = 0f + val_12;
        uint val_13 = 0;
        val_13 = 0f + val_13;
        uint val_14 = 0;
        val_14 = 0f + val_14;
        UnityEngine.Vector2 val_3 = Ferr.PathUtil.LineIntersectionPoint(aLine1Pt1:  new UnityEngine.Vector2() {x = 2.17971E-22f, y = 0f}, aLine1Pt2:  new UnityEngine.Vector2() {x = 0f, y = val_11}, aLine2Pt1:  new UnityEngine.Vector2() {y = 0f}, aLine2Pt2:  new UnityEngine.Vector2() {x = 0f});
        val_14 = val_4;
        val_18 = val_5;
        label_10:
        val_15 = 0f;
        val_13 = 0f;
        if(aOnlyBottom != true)
        {
                float val_15 = 0f;
            val_15 = val_15 + 0;
            uint val_16 = 0;
            val_16 = 0f + val_16;
            uint val_17 = 0;
            val_17 = 0f + val_17;
            uint val_18 = 0;
            val_18 = 0f + val_18;
            UnityEngine.Vector2 val_6 = Ferr.PathUtil.LineIntersectionPoint(aLine1Pt1:  new UnityEngine.Vector2() {x = 2.17971E-22f, y = 0f}, aLine1Pt2:  new UnityEngine.Vector2() {x = 0f, y = val_15}, aLine2Pt1:  new UnityEngine.Vector2() {y = 0f}, aLine2Pt2:  new UnityEngine.Vector2() {x = 0f});
            val_15 = val_4;
            val_13 = val_5;
        }
        
        float val_19 = val_15;
        var val_20 = val_13;
        val_19 = val_14 - val_19;
        val_20 = val_18 - val_20;
        if(val_16 != false)
        {
                UnityEngine.Vector2 val_7 = Ferr.Extensions.VectorExtensions.Rot90CW(aVec:  new UnityEngine.Vector2() {x = 2.17971E-22f, y = val_19});
        }
        else
        {
                UnityEngine.Vector2 val_8 = Ferr.Extensions.VectorExtensions.Rot90CCW(aVec:  new UnityEngine.Vector2() {x = 2.17971E-22f, y = val_19});
        }
        
        float val_21 = 0f;
        val_21 = 0f * val_21;
        val_12 = val_5;
        if(val_16 > false)
        {
                return;
        }
        
        if(val_16 < false)
        {
                return;
        }
        
        mem[536882601] = val_14;
        mem[536882605] = val_18;
        mem[536882601] = val_4;
        mem[536882605] = val_12;
        val_12 = aPoints;
        if(val_16 != false)
        {
                aPoints.Insert(index:  mem[aPoints + 12], item:  new UnityEngine.Vector2() {x = val_15, y = val_13});
            val_19 = aPoints;
            val_20 = mem[aPoints + 12];
        }
        else
        {
                val_20 = (this.Trim(aRightSide:  val_16, aPoints: ref  System.Collections.Generic.List<UnityEngine.Vector2> val_9 = 461667744, aPts:  536882585, aNormals:  536882585)) + 1;
            aPoints.Insert(index:  val_20, item:  new UnityEngine.Vector2() {x = val_15, y = val_13});
            val_19 = aPoints;
            if(val_19 == 0)
        {
                val_19 = 0;
        }
        
        }
        
        val_19.Insert(index:  val_20, item:  new UnityEngine.Vector2() {x = val_14, y = val_18});
    }
    private void AddIntersectionEdgeColliderCap(bool aRightSide, bool aInner, Ferr2DT_PathTerrain.EdgeSegment aToSeg, ref System.Collections.Generic.List<UnityEngine.Vector2> aPoints, System.Collections.Generic.List<UnityEngine.Vector2> aNormals)
    {
        float val_5;
        float val_6;
        EdgeSegment val_30;
        bool val_31;
        Ferr2D_SectionMode val_32;
        float val_33;
        float val_34;
        var val_35;
        float val_36;
        float val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        float val_44;
        var val_45;
        var val_46;
        var val_47;
        System.Collections.Generic.List<UnityEngine.Vector2> val_48;
        int val_49;
        int val_50;
        int val_51;
        int val_52;
        float val_53;
        float val_54;
        val_30 = aToSeg;
        val_31 = aRightSide;
        IFerr2DTMaterial val_1 = this.TerrainMaterial;
        val_32 = this.edgeMode;
        val_33 = this;
        if(aToSeg.direction < 4)
        {
                aToSeg.direction = 3 - aToSeg.direction;
        }
        
        if(val_32 != 1)
        {
                val_34 = aToSeg.direction;
        }
        
        val_32 = 0;
        val_32 = val_32 + 1;
        val_35 = val_33;
        if(val_33 == 0)
        {
                return;
        }
        
        this.CalcCapData(aRightSide:  val_31, aInner:  aInner, aAdjSeg:  val_30, aPoints:  aPoints, aNormals:  aNormals, adjTop: out  new UnityEngine.Vector2() {x = 2.218294E-22f, y = 2.218292E-22f}, adjBot: out  new UnityEngine.Vector2() {x = 2.218306E-22f, y = 2.218302E-22f}, adjDir: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, currTop: out  new UnityEngine.Vector2(), currBot: out  new UnityEngine.Vector2(), currDir: out  new UnityEngine.Vector2());
        if(val_31 != false)
        {
                UnityEngine.Vector2 val_3 = Ferr.Extensions.VectorExtensions.Rot90CW(aVec:  new UnityEngine.Vector2() {x = 2.218298E-22f, y = 0f});
        }
        else
        {
                UnityEngine.Vector2 val_4 = Ferr.Extensions.VectorExtensions.Rot90CCW(aVec:  new UnityEngine.Vector2() {x = 2.218298E-22f, y = 0f});
        }
        
        val_30 = 0f;
        if(aInner != false)
        {
                val_36 = 0f;
            val_37 = 0f;
            float val_7 = val_36 + 0;
            float val_8 = val_37 + 0;
            UnityEngine.Vector2 val_9 = Ferr.PathUtil.LineIntersectionPoint(aLine1Pt1:  new UnityEngine.Vector2() {x = 2.218298E-22f, y = 0f}, aLine1Pt2:  new UnityEngine.Vector2() {x = 0f, y = 0f}, aLine2Pt1:  new UnityEngine.Vector2() {x = 0f, y = 0f}, aLine2Pt2:  new UnityEngine.Vector2() {x = 0f, y = val_7});
            val_38 = 0;
            val_39 = 0;
            val_40 = 0;
            val_41 = 0;
            float val_11 = val_41 + val_38;
            val_31 = val_31;
            UnityEngine.Vector2 val_12 = Ferr.PathUtil.LineIntersectionPoint(aLine1Pt1:  new UnityEngine.Vector2() {x = 2.218298E-22f, y = 0f}, aLine1Pt2:  new UnityEngine.Vector2() {x = 0f, y = val_11}, aLine2Pt1:  new UnityEngine.Vector2() {x = val_40 + val_39, y = 0f}, aLine2Pt2:  new UnityEngine.Vector2() {x = 0f, y = val_7});
            uint val_30 = 0;
            val_30 = val_6;
            val_30 = val_37 + val_30;
            uint val_31 = 0;
            val_31 = val_36 + val_31;
            UnityEngine.Vector2 val_13 = Ferr.PathUtil.LineIntersectionPoint(aLine1Pt1:  new UnityEngine.Vector2() {x = 2.218298E-22f, y = 0f}, aLine1Pt2:  new UnityEngine.Vector2() {x = 0f}, aLine2Pt1:  new UnityEngine.Vector2() {y = 0f}, aLine2Pt2:  new UnityEngine.Vector2() {x = val_30, y = val_11});
            val_42 = 0;
            val_34 = val_6;
            val_43 = 0;
        }
        else
        {
                val_36 = 0f;
            val_37 = 0f;
            float val_14 = val_36 + 0;
            float val_15 = val_37 + 0;
            UnityEngine.Vector2 val_16 = Ferr.PathUtil.LineIntersectionPoint(aLine1Pt1:  new UnityEngine.Vector2() {x = 2.218298E-22f, y = 0f}, aLine1Pt2:  new UnityEngine.Vector2() {x = 0f, y = 0f}, aLine2Pt1:  new UnityEngine.Vector2() {x = 0f, y = 0f}, aLine2Pt2:  new UnityEngine.Vector2() {x = 0f, y = val_14});
            val_43 = 0;
            val_42 = 0;
            val_40 = 0;
            val_34 = val_6;
            val_41 = 0;
            float val_18 = val_41 + val_43;
            UnityEngine.Vector2 val_19 = Ferr.PathUtil.LineIntersectionPoint(aLine1Pt1:  new UnityEngine.Vector2() {x = 2.218298E-22f, y = 0f}, aLine1Pt2:  new UnityEngine.Vector2() {x = 0f, y = val_18}, aLine2Pt1:  new UnityEngine.Vector2() {x = val_40 + val_42, y = 0f}, aLine2Pt2:  new UnityEngine.Vector2() {x = 0f, y = val_14});
            uint val_32 = 0;
            val_32 = val_37 + val_32;
            val_31 = val_31;
            uint val_33 = 0;
            val_33 = val_36 + val_33;
            UnityEngine.Vector2 val_20 = Ferr.PathUtil.LineIntersectionPoint(aLine1Pt1:  new UnityEngine.Vector2() {x = 2.218298E-22f, y = 0f}, aLine1Pt2:  new UnityEngine.Vector2() {x = 0f}, aLine2Pt1:  new UnityEngine.Vector2() {y = 0f}, aLine2Pt2:  new UnityEngine.Vector2() {x = 0f, y = val_18});
            val_39 = 0;
            val_38 = 0;
        }
        
        val_32 = val_5;
        float val_21 = val_34 - val_39;
        var val_34 = val_32;
        float val_22 = val_34 - val_42;
        float val_23 = val_34 - val_43;
        val_34 = val_34 - val_38;
        float val_24 = val_36 * val_41;
        val_21 = val_6 * val_21;
        val_23 = val_5 * val_23;
        if(aInner >= false)
        {
                0 = 1;
        }
        
        if(aInner >= false)
        {
                0 = 1;
        }
        
        if(aInner == false)
        {
                val_33 = val_34;
            val_5 = val_32;
        }
        
        if(aInner > false)
        {
                return;
        }
        
        if(aInner < false)
        {
                return;
        }
        
        if(aInner != false)
        {
                val_44 = val_5;
            val_45 = val_33;
            val_46 = val_5;
            val_47 = val_6;
        }
        else
        {
                val_44 = val_5;
            val_45 = val_6;
            val_46 = val_5;
            val_47 = val_33;
        }
        
        val_44 = val_46 - val_44;
        float val_25 = val_47 - val_45;
        val_30 = val_5;
        if(val_31 != false)
        {
                UnityEngine.Vector2 val_26 = Ferr.Extensions.VectorExtensions.Rot90CW(aVec:  new UnityEngine.Vector2() {x = 2.218298E-22f, y = val_44});
        }
        else
        {
                UnityEngine.Vector2 val_27 = Ferr.Extensions.VectorExtensions.Rot90CCW(aVec:  new UnityEngine.Vector2() {x = 2.218298E-22f, y = val_44});
        }
        
        mem[536882601] = val_30;
        mem[536882605] = val_33;
        mem[536882601] = val_5;
        mem[536882605] = val_6;
        val_34 = (this.Trim(aRightSide:  val_31, aPoints: ref  System.Collections.Generic.List<UnityEngine.Vector2> val_28 = 461820608, aPts:  536882585, aNormals:  536882585)) + 1;
        val_32 = aPoints;
        if(aInner == false)
        {
            goto label_23;
        }
        
        if(val_31 == false)
        {
            goto label_24;
        }
        
        val_32.Insert(index:  mem[aPoints + 12], item:  new UnityEngine.Vector2() {x = val_30, y = val_33});
        val_48 = aPoints;
        val_49 = mem[aPoints + 12];
        goto label_32;
        label_23:
        if(val_31 == false)
        {
            goto label_28;
        }
        
        val_50 = mem[aPoints + 12];
        goto label_36;
        label_24:
        val_32.Insert(index:  val_34, item:  new UnityEngine.Vector2() {x = val_30, y = val_33});
        val_48 = aPoints;
        val_49 = val_34;
        if(val_48 == 0)
        {
                val_48 = 0;
            val_49 = val_34;
        }
        
        label_32:
        val_48.Insert(index:  val_49, item:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        if(val_31 == false)
        {
            goto label_33;
        }
        
        val_34 = mem[aPoints + 12];
        goto label_40;
        label_28:
        val_50 = val_34;
        if(val_32 == 0)
        {
                val_50 = val_34;
        }
        
        label_36:
        val_32.Insert(index:  val_50, item:  new UnityEngine.Vector2() {x = val_5, y = val_6});
        if(val_31 == false)
        {
            goto label_37;
        }
        
        val_51 = mem[aPoints + 12];
        val_32 = 22739696;
        goto label_42;
        label_33:
        label_40:
        val_52 = val_34;
        val_53 = val_5;
        val_54 = val_6;
        goto label_41;
        label_37:
        val_51 = val_34;
        val_32 = 22739696;
        if(aPoints == 0)
        {
                val_51 = val_34;
        }
        
        label_42:
        aPoints.Insert(index:  val_51, item:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        if(val_31 != false)
        {
                val_34 = mem[aPoints + 12];
        }
        
        val_52 = val_34;
        val_53 = val_30;
        val_54 = val_33;
        label_41:
        aPoints.Insert(index:  val_52, item:  new UnityEngine.Vector2() {x = val_53, y = val_54});
    }
    private void AddCircleColliderCap(bool aRightSide, ref System.Collections.Generic.List<UnityEngine.Vector2> aPoints, UnityEngine.Vector2 aNormal, UnityEngine.Vector2 aPt, float aWidth, float aYOffset, float aThickness)
    {
        var val_1;
        var val_2;
        var val_3;
        int val_8;
        var val_7 = val_1;
        var val_9 = val_3;
        var val_8 = mem[aPoints + 12];
        float val_4 = aNormal.x * val_7;
        val_7 = aNormal.y * val_7;
        val_8 = val_8 + (val_8 >> 31);
        val_8 = val_8 >> 1;
        var val_11 = 1;
        val_9 = val_9 * aNormal.x;
        do
        {
            float val_6 = 1119092736 + 180f;
            if(aRightSide == true)
        {
                1119092736 = val_6;
        }
        
            val_6 = 1119092736 * 0.01745329f;
            float val_10 = val_6;
            1119092736 = val_10 * aNormal.y;
            val_10 = val_10 * aNormal.x;
            1119092736 = 1119092736 * val_2;
            val_10 = val_10 * val_2;
            1119092736 = 1119092736 * 0.5f;
            val_10 = val_10 * 0.5f;
            1119092736 = (val_9 * aNormal.y) + 1119092736;
            val_10 = val_9 + val_10;
            1119092736 = 1119092736 + aPt.y;
            val_10 = val_10 + aPt.x;
            if(aRightSide != false)
        {
                aPoints.Add(item:  new UnityEngine.Vector2() {x = val_10, y = 1119092736});
        }
        else
        {
                aPoints.Insert(index:  val_8, item:  new UnityEngine.Vector2() {x = val_10, y = 1119092736});
            val_8 = val_8 + 1;
        }
        
            val_11 = val_11 + 1;
        }
        while(val_11 != 8);
    
    }
    private void AddMaterials(bool aHasFill, bool aHasEdge)
    {
        var val_10;
        Ferr2DT_PathTerrain val_11;
        var val_12;
        Ferr2DT_PathTerrain val_13;
        var val_14;
        var val_15;
        var val_16;
        val_10 = 22968966;
        if(aHasEdge == true)
        {
            goto label_1;
        }
        
        if(aHasEdge == false)
        {
            goto label_2;
        }
        
        val_12 = 536882161;
        IFerr2DTMaterial val_1 = this.TerrainMaterial;
        val_13 = this;
        val_10 = 0;
        val_10 = val_10 + 1;
        val_14 = val_13;
        goto label_34;
        label_1:
        val_12 = 536882161;
        IFerr2DTMaterial val_2 = this.TerrainMaterial;
        val_10 = 0;
        val_10 = val_10 + 1;
        val_15 = this;
        goto label_12;
        label_2:
        if(aHasFill == false)
        {
            goto label_13;
        }
        
        val_12 = 536882161;
        IFerr2DTMaterial val_3 = this.TerrainMaterial;
        val_13 = this;
        val_10 = 0;
        val_10 = val_10 + 1;
        val_14 = val_13;
        goto label_34;
        label_13:
        val_12 = 536882161;
        goto label_19;
        label_12:
        mem[536882177] = this;
        IFerr2DTMaterial val_5 = this.TerrainMaterial;
        val_10 = 0;
        val_10 = val_10 + 1;
        val_16 = this;
        val_11 = this;
        mem[536882181] = val_11;
        goto label_33;
        label_34:
        val_11 = val_13;
        mem[536882177] = val_11;
        label_33:
        label_19:
        UnityEngine.Transform val_9 = this.GetComponent<UnityEngine.Transform>();
        this.sharedMaterials = 536882161;
    }
    public void SetMaterial(IFerr2DTMaterial aMaterial)
    {
        UnityEngine.Object val_2;
        if(this.IsLegacy != false)
        {
                this.ForceMaterial(aMaterial:  aMaterial, aForceUpdate:  false, aRecreate:  true);
            return;
        }
        
        val_2 = 0;
        this.terrainMaterialInterface = ;
    }
    public int AddPoint(UnityEngine.Vector2 aPt, int aAtIndex = -1, Ferr.PointType aType = 4)
    {
        int val_6 = aAtIndex;
        if(this.IsLegacy != false)
        {
                return (int)this.LegacyAddPoint(aPt:  new UnityEngine.Vector2() {x = aPt.x, y = aPt.y}, aAtIndex:  val_6 = aAtIndex);
        }
        
        if(val_6 != 1)
        {
                Ferr2D_PointData val_3 = new Ferr2D_PointData(aScale:  null, aDirectionOverride:  1065353216);
            this.pathData.Insert(aIndex:  val_6, aPt:  new UnityEngine.Vector2() {x = aPt.x, y = aPt.y}, aData:  new Ferr2D_PointData() {directionOverride = val_3.directionOverride, cutOverrides = val_3.cutOverrides, scale = val_3.scale}, aType:  aType, aRadius:  null, aControlPointPrev:  new UnityEngine.Vector2() {x = 1f, y = 0f}, aControlPointNext:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            return (int)val_6;
        }
        
        Ferr2D_PointData val_4 = new Ferr2D_PointData(aScale:  null, aDirectionOverride:  1065353216);
        val_6 = this.pathData.Add(aPt:  new UnityEngine.Vector2() {x = aPt.x, y = aPt.y}, aData:  new Ferr2D_PointData() {directionOverride = val_4.directionOverride, cutOverrides = val_4.cutOverrides, scale = val_4.scale}, aType:  aType, aRadius:  null, aControlPointPrev:  new UnityEngine.Vector2() {x = 1f, y = 0f}, aControlPointNext:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        return (int)val_6;
    }
    public int AddAutoPoint(UnityEngine.Vector2 aPt, Ferr.PointType aType = 4)
    {
        Ferr2DPath val_5;
        if(this.IsLegacy != false)
        {
                return this.LegacyAddAutoPoint(aPt:  new UnityEngine.Vector2() {x = aPt.x, y = aPt.y});
        }
        
        val_5 = this.pathData;
        if(this.pathData != 0)
        {
            goto label_1;
        }
        
        val_5 = this.pathData;
        if(val_5 == 0)
        {
            goto label_2;
        }
        
        label_1:
        aType = (Ferr.PathUtil.GetClosestSegment(aPath:  val_5, aPoint:  new UnityEngine.Vector2() {x = aPt.x, y = aPt.y}, aClosed:  aType)) + 1;
        if(aType == this.pathData.Count)
        {
                aType = 0;
        }
        
        return (int)this.AddPoint(aPt:  new UnityEngine.Vector2() {x = aPt.x, y = aPt.y}, aAtIndex:  0, aType:  aType);
        label_2:
    }
    public void RemovePoint(int aPtIndex)
    {
        if(this.IsLegacy != false)
        {
                this.LegacyRemovePoint(aPtIndex:  aPtIndex);
            return;
        }
        
        if(this.pathData == 0)
        {
            
        }
    
    }
    public void ClearPoints()
    {
        if(this.IsLegacy != false)
        {
                this.LegacyClearPoints();
            return;
        }
        
        if(this.pathData == 0)
        {
            
        }
    
    }
    public void OnPainterSelected(Ferr.IBlendPaintType aType)
    {
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        if(462786928 == 0)
        {
                UnityEngine.GameObject val_3 = this.gameObject;
            SynchronizationContextBehavoir val_4 = this.AddComponent<SynchronizationContextBehavoir>();
            if(this != 0)
        {
                this.size = new UnityEngine.Vector3() {x = 100000f, y = 100000f, z = 0f};
        }
        else
        {
                this.size = new UnityEngine.Vector3() {x = 100000f, y = 100000f, z = 0f};
        }
        
            this.hideFlags = 63;
        }
        
        this.vertexColorType = 3;
    }
    public void OnPainterUnselected(Ferr.IBlendPaintType aType)
    {
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        if(462907120 == 0)
        {
                return;
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  R4);
    }
    public Ferr2D_Path get_Path()
    {
        if(this.legacyPath != 0)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = this.GetComponent<UnityEngine.Transform>();
        this.legacyPath = this;
    }
    public void LegacyUpgrade()
    {
        Ferr2DT_PathTerrain val_21;
        Ferr2DT_PathTerrain val_22;
        Ferr2DPath val_23;
        var val_24;
        var val_25;
        Ferr2DPath val_26;
        var val_27;
        var val_28;
        val_21 = this;
        if(this.IsLegacy == false)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = this.GetComponent<UnityEngine.Transform>();
        val_22 = val_21;
        this.MatchOverrides();
        Ferr2DPath val_3 = 536886753;
        val_3 = new Ferr2DPath();
        this.pathData = val_3;
        if(this.fillY != 0f)
        {
                this.fillY = 1;
        }
        
        this.pathData.Closed = true;
        val_23 = 0;
        val_24 = 16;
        goto label_4;
        label_24:
        Ferr2D_Path val_4 = this.Path;
        Ferr2D_Path val_6 = this.Path;
        int val_7 = Ferr.PathUtil.WrapIndex(aIndex:  0, aCount:  this.Count, aClosed:  this.fillY);
        if(this.smoothPath != false)
        {
                Ferr2D_Path val_8 = this.Path;
            Ferr2D_Path val_9 = this.Path;
            Ferr2DT_TerrainDirection val_12 = Ferr2D_Path.GetDirection(aSegment:  this.fillZ, i:  val_7, aInvert:  (this.fill - 3) >> 5, aClosed:  this.fillY, aOverrides:  this.directionOverrides);
            Ferr2D_Path val_13 = this.Path;
            Ferr2D_Path val_14 = this.Path;
            val_25 = 0;
            Ferr2DT_TerrainDirection val_17 = Ferr2D_Path.GetDirection(aSegment:  this.fillZ, i:  this.pathData, aInvert:  (this.fill - 3) >> 5, aClosed:  this.fillY, aOverrides:  this.directionOverrides);
            val_26 = this.pathData;
            if(this.fillZ == this.fillZ)
        {
                4 = 2;
        }
        
        }
        else
        {
                val_26 = this.pathData;
            val_25 = 0;
        }
        
        if((this.vertScales + 12) <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_21 = this.vertScales + 8;
        val_21 = val_21 + (val_7 << 2);
        if((this.directionOverrides + 12) <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_22 = this.directionOverrides + 8;
        val_22 = val_22 + (val_7 << 2);
        if((this.cutOverrides + 12) <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_23 = this.cutOverrides + 8;
        val_23 = val_23 + (val_7 << 2);
        if((this.fillZ + 12) <= this.pathData)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        int val_18 = val_26.Add(aPt:  new UnityEngine.Vector2() {x = this.fillZ + 8 + val_24, y = this.fillZ + 8 + val_24 + 4}, aData:  new Ferr2D_PointData() {directionOverride = (this.directionOverrides + 8 + (val_7) << 2) + 16, cutOverrides = (this.cutOverrides + 8 + (val_7) << 2) + 16 + 8, scale = (this.vertScales + 8 + (val_7) << 2) + 16}, aType:  4, aRadius:  null, aControlPointPrev:  new UnityEngine.Vector2() {x = 1f, y = 0f}, aControlPointNext:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        val_23 = this.pathData;
        val_24 = val_24 + 8;
        val_21 = val_21;
        val_22 = val_22;
        label_4:
        if((val_23 + 1) < (this.fillZ + 12))
        {
            goto label_24;
        }
        
        this.directionOverrides = 0;
        this.cutOverrides = 0;
        this.vertScales = 0;
        if(mem[1152921509364974242] == false)
        {
            goto label_27;
        }
        
        if(mem[1152921509364974260] == false)
        {
            goto label_28;
        }
        
        val_27 = 2;
        goto label_29;
        label_27:
        mem[1152921509364974184] = 0;
        goto label_30;
        label_28:
        if(mem[1152921509364974243] == false)
        {
                mem[1152921509364974243] = 1;
        }
        
        if(mem[1152921509364974243] == true)
        {
                val_27 = 3;
        }
        
        label_29:
        mem[1152921509364974184] = val_27;
        label_30:
        if(this.fill <= 5)
        {
                var val_20 = 3757832 + (3757832 + (this.fill) << 2);
            if(this.fill == 5)
        {
                3757832 + (this.fill) << 2 = (3757832 + (this.fill) << 2) & (val_21 << (3757832 + (this.fill) << 2));
            3757832 + (this.fill) << 2 = (3757832 + (this.fill) << 2) & ((3757832 + (this.fill) << 2) >> 32);
            3757832 + (this.fill) << 2 = (3757832 + (this.fill) << 2) & ((IP) >> 32);
            3757832 + (this.fill) << 2 = (3757832 + (this.fill) << 2) & (val_21 >> (3757832 + (this.fill) << 2));
            3757832 + (this.fill) << 2 = (3757832 + (this.fill) << 2) & 0;
            3757832 + (this.fill) << 2 = (3757832 + (this.fill) << 2) & (val_21 >> (3757832 + (this.fill) << 2));
        }
        
            val_28 = 0;
            mem[1152921509364974172] = ;
            mem[1152921509364974176] = ;
        }
        
        mem[1152921509364974221] = 0;
        UnityEngine.Object.Destroy(obj:  463159792);
        this.Build(aFullBuild:  true);
    }
    private void LegacyAwake()
    {
        var val_7;
        if(this.createCollider != false)
        {
                UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            if(463288176 == 0)
        {
                UnityEngine.Transform val_3 = this.GetComponent<UnityEngine.Transform>();
            bool val_4 = UnityEngine.Object.op_Equality(x:  463288176, y:  0);
            if(val_4 == true)
        {
                val_4 = this;
            this.RecreateCollider();
        }
        
        }
        
        }
        
        val_7 = 0;
        goto label_7;
        label_12:
        UnityEngine.Camera[] val_5 = UnityEngine.Camera.allCameras;
        var val_6 = 0 + 0;
        (0 + 0) + 16.transparencySortMode = 2;
        val_7 = 1;
        label_7:
        UnityEngine.Camera[] val_7 = UnityEngine.Camera.allCameras;
        if(val_7 < 0)
        {
            goto label_12;
        }
    
    }
    private void LegacyBuild(bool aFullBuild)
    {
        Ferr2DT_FillMode val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        IFerr2DTMaterial val_1 = this.TerrainMaterial;
        if(this == 0)
        {
            goto label_1;
        }
        
        Ferr2D_Path val_2 = this.Path;
        if(this.Count <= 1)
        {
            goto label_3;
        }
        
        this.MarkColorSave();
        this.MatchOverrides();
        IFerr2DTMaterial val_4 = this.TerrainMaterial;
        this.ForceMaterial(aMaterial:  463412464, aForceUpdate:  true, aRecreate:  false);
        Ferr2D_DynamicMesh val_5 = this.DMesh;
        this.Clear();
        Ferr2DT_FillMode val_27 = this.fill;
        val_27 = val_27 & (~1);
        if(val_27 != 4)
        {
                val_27 = this;
            this.LegacyAddEdge();
        }
        
        Ferr2D_DynamicMesh val_6 = this.DMesh;
        System.Int32[] val_7 = this.GetCurrentTriangleList(aStart:  0);
        val_27 = this.fill;
        if((val_27 | 4) != 5)
        {
            goto label_6;
        }
        
        IFerr2DTMaterial val_9 = this.TerrainMaterial;
        var val_28 = 0;
        val_28 = val_28 + 1;
        val_28 = this;
        goto label_11;
        label_1:
        UnityEngine.Debug.LogWarning(message:  -1610609557);
        return;
        label_3:
        UnityEngine.Transform val_10 = this.GetComponent<UnityEngine.Transform>();
        this.sharedMesh = 0;
        return;
        label_11:
        if(463412464 == 0)
        {
            goto label_19;
        }
        
        val_29 = 1;
        goto label_20;
        label_19:
        val_27 = this.fill;
        label_6:
        if((val_27 > 4) || ((25 & (1 << val_27)) != 0))
        {
            goto label_30;
        }
        
        IFerr2DTMaterial val_12 = this.TerrainMaterial;
        var val_29 = 0;
        val_29 = val_29 + 1;
        val_30 = this;
        if(463412464 == 0)
        {
            goto label_30;
        }
        
        val_29 = 0;
        label_20:
        this.LegacyAddFill(aSkirt:  false, aFullBuild:  aFullBuild);
        label_30:
        Ferr2D_DynamicMesh val_14 = this.DMesh;
        System.Int32[] val_15 = this.GetCurrentTriangleList(aStart:  this.fillY);
        val_31 = this;
        UnityEngine.Transform val_16 = this.GetComponent<UnityEngine.Transform>();
        UnityEngine.Mesh val_17 = this.GetMesh();
        this.sharedMesh = 463412464;
        Ferr2D_DynamicMesh val_18 = this.DMesh;
        if(this.createTangents == true)
        {
                this.createTangents = 1;
        }
        
        this.Build(aMesh: ref  UnityEngine.Mesh val_20 = 463400428, aCalculateTangents:  1 & aFullBuild);
        this.LegacyCreateVertColors();
        if(this.fillY == 0f)
        {
            goto label_35;
        }
        
        if(this.fillY == 0f)
        {
            goto label_37;
        }
        
        this.subMeshCount = 2;
        this.SetTriangles(triangles:  463412464, submesh:  1);
        goto label_40;
        label_35:
        if(val_31 != 0)
        {
            goto label_43;
        }
        
        goto label_43;
        label_37:
        if(this.fillY == 0f)
        {
            goto label_43;
        }
        
        this.subMeshCount = 1;
        val_32 = this;
        goto label_46;
        label_43:
        if(this.fillY == 0f)
        {
            goto label_47;
        }
        
        this.subMeshCount = 1;
        label_40:
        val_32 = val_31;
        label_46:
        this.SetTriangles(triangles:  463412464, submesh:  0);
        label_47:
        UnityEngine.Transform val_21 = this.GetComponent<UnityEngine.Transform>();
        val_33 = 1;
        if(463412464 == 0)
        {
                UnityEngine.Transform val_23 = this.GetComponent<UnityEngine.Transform>();
            val_31 = this;
            if(463412464 == 0)
        {
                UnityEngine.Transform val_25 = this.GetComponent<UnityEngine.Transform>();
            val_33 = UnityEngine.Object.op_Inequality(x:  463412464, y:  0);
        }
        
        }
        
        if(val_33 != this.createCollider)
        {
                this.createCollider = this;
            this.RecreateCollider();
        }
        
        if(aFullBuild == false)
        {
                return;
        }
        
        this.recolorTree = 0;
    }
    private void LegacyCreateVertColors()
    {
        UnityEngine.MeshFilter val_1 = this.MeshFilter;
        UnityEngine.Mesh val_2 = this.sharedMesh;
        if(this.vertexColorType <= 3)
        {
                var val_3 = 3765916 + (3765916 + (this.vertexColorType) << 2);
            if(this.vertexColorType == 3)
        {
                3765916 + (this.vertexColorType) << 2 = (3765916 + (this.vertexColorType) << 2) & ((3765916 + (this.vertexColorType) << 2) << (3765916 + (this.vertexColorType) << 2));
            3765916 + (this.vertexColorType) << 2 = (3765916 + (this.vertexColorType) << 2) & ((IP) >> 32);
            3765916 + (this.vertexColorType) << 2 = (3765916 + (this.vertexColorType) << 2) & 0;
            3765916 + (this.vertexColorType) << 2 = IP * (3765916 + (this.vertexColorType) << 2);
        }
        
            Ferr2DT_PathTerrain.ColorVertsSolid(aMesh:  463544944, aColor:  new UnityEngine.Color() {r = mem[this.vertexColor + (0)], g = mem[this.vertexColor + (4)], b = mem[this.vertexColor + (8)], a = 3765916 + (this.vertexColorType) << 2});
        }
        
        var val_6 = FP - 16;
    }
    private int LegacyAddPoint(UnityEngine.Vector2 aPt, int aAtIndex = -1)
    {
        int val_5;
        float val_6;
        System.Collections.Generic.List<CutOverrides> val_7;
        val_5 = aAtIndex;
        val_6 = aPt.x;
        this.MatchOverrides();
        Ferr2D_Path val_1 = this.Path;
        if(val_5 != 1)
        {
                this.fillZ.Insert(index:  val_5, item:  new UnityEngine.Vector2() {x = val_6, y = aPt.y});
            this.directionOverrides.Insert(index:  val_5, item:  100);
            val_7 = this.cutOverrides;
            Ferr2DT_PathTerrain.CutOverrides val_2 = 536898987;
            val_6 = val_2;
            val_2 = new Ferr2DT_PathTerrain.CutOverrides();
            val_7.Insert(index:  val_5, item:  536898987);
            this.vertScales.Insert(index:  val_5, item:  null);
            return (int)val_5;
        }
        
        this.Add(aPoint:  new UnityEngine.Vector2() {x = val_6, y = aPt.y});
        this.directionOverrides.Add(item:  100);
        Ferr2DT_PathTerrain.CutOverrides val_3 = 536898987;
        val_7 = val_3;
        val_3 = new Ferr2DT_PathTerrain.CutOverrides();
        this.cutOverrides.Add(item:  536898987);
        this.vertScales.Add(item:  null);
        Ferr2D_Path val_4 = this.Path;
        val_5 = mem[this.fillZ + 12];
        val_5 = this.fillZ + 12;
        return (int)val_5;
    }
    private int LegacyAddAutoPoint(UnityEngine.Vector2 aPt)
    {
        Ferr2D_Path val_1 = this.Path;
        int val_5 = this.GetClosestSeg(aPoint:  new UnityEngine.Vector2() {x = aPt.x, y = aPt.y});
        Ferr2D_Path val_3 = this.Path;
        val_5 = val_5 + 1;
        if(val_5 == (this.fillZ + 12))
        {
                val_5 = 0;
        }
        
        return (int)this.LegacyAddPoint(aPt:  new UnityEngine.Vector2() {x = aPt.x, y = aPt.y}, aAtIndex:  0);
    }
    private void LegacyRemovePoint(int aPtIndex)
    {
        if(aPtIndex >= 0)
        {
                Ferr2D_Path val_1 = this.Path;
            if((this.fillZ + 12) > aPtIndex)
        {
                Ferr2D_Path val_2 = this.Path;
            this.fillZ.RemoveAt(index:  aPtIndex);
            this.directionOverrides.RemoveAt(index:  aPtIndex);
            this.cutOverrides.RemoveAt(index:  aPtIndex);
            this.vertScales.RemoveAt(index:  aPtIndex);
            return;
        }
        
        }
        
        22709204 = new System.ArgumentOutOfRangeException();
    }
    private void LegacyClearPoints()
    {
        Ferr2D_Path val_1 = this.Path;
        this.fillZ.Clear();
        this.directionOverrides.Clear();
        this.cutOverrides.Clear();
        this.vertScales.Clear();
    }
    private void LegacyAddEdge()
    {
        Ferr2DT_PathTerrain val_31;
        System.Collections.Generic.List<CutOverrides> val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        Ferr2DT_PathTerrain val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        bool val_46;
        var val_47;
        val_31 = this;
        Ferr2DT_PathTerrain.<>c__DisplayClass142_0 val_1 = 536898983;
        val_32 = val_1;
        val_1 = new Ferr2DT_PathTerrain.<>c__DisplayClass142_0();
        mem[536898995] = val_31;
        536877657 = new System.Collections.Generic.List<Page>();
        mem[536898999] = 536877657;
        536877873 = new System.Collections.Generic.List<UnityEngine.RuntimePlatform>();
        mem[536898991] = 536877873;
        System.Collections.Generic.List<System.Int32> val_4 = 536877987;
        val_4 = new System.Collections.Generic.List<System.Int32>();
        Ferr2D_Path val_5 = this.Path;
        System.Collections.Generic.List<UnityEngine.Vector2> val_6 = this.GetVertsRaw();
        System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> val_7 = this.GetSegments(aPath:  464215536, aSegDirections: out  mem[536898991]);
        mem[536877657] = val_31;
        if(mem[536877885] < mem[1152921509366029820])
        {
                if(this.directionOverrides != 0)
        {
                val_34 = mem[1152921509366029820];
        }
        else
        {
                val_35 = 12;
            val_34 = 0;
            val_33 = 0;
        }
        
            if(val_33 <= (-1))
        {
                var val_31 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_31 = val_31 + 4294967292;
            mem[536898991].Add(item:  (0 + 4294967292) + 16);
        }
        
        val_36 = 0;
        goto label_12;
        label_15:
        val_4.Add(item:  0);
        val_36 = 1;
        label_12:
        if(val_36 < mem[1152921509366029820])
        {
            goto label_15;
        }
        
        536875631 = new System.Func<System.Int32, System.Int32, System.Int32>(object:  536898983, method:  new IntPtr(1610676297));
        536877361 = new Ferr.LambdaComparer<System.Int32>(comparerFunc:  536875631);
        val_4.Sort(comparer:  536877361);
        val_37 = 0;
        val_38 = mem[536898999];
        goto label_17;
        label_83:
        if(val_4 <= val_37)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_32 = mem[536877995];
        val_32 = val_32 + 0;
        if(mem[1152921509366029820] <= ((mem[536877995] + 0) + 16))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_33 = mem[1152921509366029816];
        val_33 = val_33 + (((mem[536877995] + 0) + 16) << 2);
        if(mem[536877999] <= val_37)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_34 = mem[536877995];
        val_34 = val_34 + 0;
        val_39 = mem[(mem[536877995] + 0) + 16];
        val_39 = (mem[536877995] + 0) + 16;
        if((val_39 - 1) < 0)
        {
            goto label_22;
        }
        
        if(mem[536877999] <= val_37)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            var val_35 = mem[536877995];
            val_35 = val_35 + 0;
            val_39 = mem[(mem[536877995] + 0) + 16];
            val_39 = (mem[536877995] + 0) + 16;
        }
        
        if(mem[536877657] != 0)
        {
            goto label_24;
        }
        
        goto label_25;
        label_22:
        if(mem[536877657] == 0)
        {
            goto label_26;
        }
        
        val_39 = mem[1152921509366029820];
        val_40 = val_39;
        goto label_27;
        label_26:
        val_39 = mem[1152921509366029820];
        label_25:
        label_24:
        val_40 = mem[1152921509366029820];
        label_27:
        val_39 = val_39 - 1;
        if(val_40 <= val_39)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_36 = mem[1152921509366029816];
        val_36 = val_36 + (val_39 << 2);
        val_41 = mem[536877657];
        if(mem[536877999] <= val_37)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_41 = mem[536877657];
        }
        
        var val_37 = mem[536877995];
        val_37 = val_37 + 0;
        var val_11 = ((mem[536877995] + 0) + 16) + 1;
        if(mem[1152921509366029820] <= mem[1152921509366029820])
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_38 = mem[1152921509366029816];
        val_38 = val_38 + (mem[1152921509366029820] << 2);
        if(((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(((mem[1152921509366029816] + ((mem[1152921509366029820] - 1)) << 2) + 16) != 0)
        {
                val_42 = mem[(mem[1152921509366029816] + ((mem[1152921509366029820] - 1)) << 2) + 16 + 12];
            val_42 = (mem[1152921509366029816] + ((mem[1152921509366029820] - 1)) << 2) + 16 + 12;
            val_43 = val_42;
        }
        else
        {
                val_43 = 0;
            val_42 = 0;
        }
        
        if(val_42 <= (-2))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_39 = (mem[1152921509366029816] + ((mem[1152921509366029820] - 1)) << 2) + 16 + 8;
        val_39 = val_39 + 4294967288;
        if(((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 12) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        Ferr2D_Path val_12 = this.Path;
        if((mem[1152921509366029824] + 12) <= (((mem[1152921509366029816] + ((mem[1152921509366029820] - 1)) << 2) + 16 + 8 + 4294967288) + 16))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_40 = mem[1152921509366029824] + 8;
        val_40 = val_40 + ((((mem[1152921509366029816] + ((mem[1152921509366029820] - 1)) << 2) + 16 + 8 + 4294967288) + 16) << 3);
        Ferr2D_Path val_13 = this.Path;
        if((mem[1152921509366029824] + 12) <= ((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + 16))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_41 = mem[1152921509366029824] + 8;
        val_41 = val_41 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + 16) << 3);
        var val_44 = (mem[1152921509366029824] + 8 + ((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + 16) << 3) + 16;
        var val_43 = (mem[1152921509366029824] + 8 + ((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + 16) << 3) + 20;
        Ferr2D_Path val_14 = this.Path;
        if((mem[1152921509366029824] + 12) <= ((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + 20))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_42 = mem[1152921509366029824] + 8;
        val_42 = val_42 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + 20) << 3);
        Ferr2D_Path val_15 = this.Path;
        val_43 = ((mem[1152921509366029824] + 8 + (((mem[1152921509366029816] + ((mem[1152921509366029820] - 1)) << 2) + 16 + 8 + 4294967288) + 16) << 3) + 20) - val_43;
        val_44 = ((mem[1152921509366029824] + 8 + (((mem[1152921509366029816] + ((mem[1152921509366029820] - 1)) << 2) + 16 + 8 + 4294967288) + 16) << 3) + 16) - val_44;
        if((mem[1152921509366029824] + 12) <= ((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + 16))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_45 = mem[1152921509366029824] + 8;
        var val_46 = (mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + 20;
        val_45 = val_45 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + 16) << 3);
        var val_47 = (mem[1152921509366029824] + 8 + ((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + 16) << 3) + 16;
        val_46 = val_46 - ((mem[1152921509366029824] + 8 + ((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + 16) << 3) + 20);
        val_47 = ((mem[1152921509366029824] + 8 + ((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + 20) << 3) + 16) - val_47;
        float val_16 = val_44 * val_46;
        val_46 = val_43 * val_46;
        val_44 = mem[(mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 12];
        val_44 = (mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 12;
        if(val_44 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_44 = mem[(mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 12];
            val_44 = (mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 12;
        }
        
        val_45 = mem[(mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8];
        val_45 = (mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8;
        var val_19 = val_45 + ((val_44 - 1) << 2);
        if(val_44 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_45 = mem[(mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8];
            val_45 = (mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8;
        }
        
        var val_20 = val_45 + ((val_44 - 2) << 2);
        if(((mem[1152921509366029816] + (mem[1152921509366029820]) << 2) + 16 + 12) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        Ferr2D_Path val_21 = this.Path;
        if((mem[1152921509366029824] + 12) <= (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 12 - 2)) << 2) + 16))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_48 = mem[1152921509366029824] + 8;
        val_48 = val_48 + ((((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 12 - 2)) << 2) + 16) << 3);
        Ferr2D_Path val_22 = this.Path;
        if((mem[1152921509366029824] + 12) <= (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 12 - 1)) << 2) + 16))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_49 = mem[1152921509366029824] + 8;
        val_49 = val_49 + ((((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 12 - 1)) << 2) + 16) << 3);
        var val_52 = (mem[1152921509366029824] + 8 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 12 - 1)) << 2) + 16) < + 16;
        var val_51 = (mem[1152921509366029824] + 8 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 12 - 1)) << 2) + 16) < + 20;
        Ferr2D_Path val_23 = this.Path;
        if((mem[1152921509366029824] + 12) <= ((mem[1152921509366029816] + (mem[1152921509366029820]) << 2) + 16 + 8 + 20))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_50 = mem[1152921509366029824] + 8;
        val_50 = val_50 + (((mem[1152921509366029816] + (mem[1152921509366029820]) << 2) + 16 + 8 + 20) << 3);
        Ferr2D_Path val_24 = this.Path;
        val_51 = ((mem[1152921509366029824] + 8 + (((mem[1152921509366029816] + ((mem[1152921509366029820] - 1)) << 2) + 16 + 8 + 4294967288) + 16) << 3) + 20) - val_51;
        val_52 = ((mem[1152921509366029824] + 8 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 12 - 2)) << 2) + 16) < + 16) - val_52;
        if((mem[1152921509366029824] + 12) <= (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 12 - 1)) << 2) + 16))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_53 = mem[1152921509366029824] + 8;
        var val_54 = ((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 12 - 2)) << 2) + 16;
        val_53 = val_53 + ((((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 12 - 1)) << 2) + 16) << 3);
        var val_55 = (mem[1152921509366029824] + 8 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 12 - 1)) << 2) + 16) < + 16;
        val_54 = val_54 - ((mem[1152921509366029824] + 8 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 8 + (((mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16 + 12 - 1)) << 2) + 16) < + 20);
        val_55 = ((mem[1152921509366029824] + 8 + ((mem[1152921509366029816] + (mem[1152921509366029820]) << 2) + 16 + 8 + 20) << 3) + 16) - val_55;
        float val_25 = val_52 * val_54;
        val_54 = val_51 * val_54;
        Ferr2D_Path val_26 = this.Path;
        if(mem[536877999] <= val_37)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_56 = mem[536877995];
        val_56 = val_56 + 0;
        if(mem[1152921509366029820] <= ((mem[536877995] + 0) + 16))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_57 = mem[1152921509366029816];
        val_57 = val_57 + (((mem[536877995] + 0) + 16) << 2);
        System.Collections.Generic.List<T> val_27 = Ferr2D_Path.IndicesToList<UnityEngine.Vector2>(aData:  mem[1152921509366029824], aIndices:  (mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16);
        if(mem[536877999] <= val_37)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_58 = mem[536877995];
        val_58 = val_58 + 0;
        if(mem[1152921509366029820] <= ((mem[536877995] + 0) + 16))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_59 = mem[1152921509366029816];
        val_59 = val_59 + (((mem[536877995] + 0) + 16) << 2);
        System.Collections.Generic.List<T> val_28 = Ferr2D_Path.IndicesToList<System.Single>(aData:  mem[1152921509366030024], aIndices:  (mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16);
        if(mem[536877999] <= val_37)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_60 = mem[536877995];
        val_60 = val_60 + 0;
        if(mem[1152921509366029820] <= ((mem[536877995] + 0) + 16))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_61 = mem[1152921509366029816];
        val_61 = val_61 + (((mem[536877995] + 0) + 16) << 2);
        System.Collections.Generic.List<T> val_29 = Ferr2D_Path.IndicesToList<CutOverrides>(aData:  mem[1152921509366030020], aIndices:  (mem[1152921509366029816] + ((mem[536877995] + 0) + 16) << 2) + 16);
        val_32 = mem[1152921509366030020];
        val_46 = 0;
        val_47 = mem[536877999];
        if(val_47 <= 1)
        {
                Ferr2D_Path val_30 = this.Path;
            val_47 = mem[536877999];
            val_46 = mem[1152921509366029820];
        }
        
        if(val_47 <= val_37)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_62 = mem[536877995];
        val_62 = val_62 + 0;
        val_35 = mem[(mem[536877995] + 0) + 16];
        val_35 = (mem[536877995] + 0) + 16;
        if((mem[536877873] + 12) <= val_35)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(mem[1152921509366029972] == true)
        {
                mem[1152921509366029972] = 1;
        }
        
        if(val_46 == true)
        {
                val_46 = 1;
        }
        
        var val_63 = mem[536877873] + 8;
        val_63 = val_63 + (val_35 << 2);
        val_31 = val_31;
        if(val_46 < 0)
        {
                0 = 1;
        }
        
        if(val_46 < 0)
        {
                0 = 1;
        }
        
        this.LegacyAddSegment(aSegment:  mem[1152921509366029824], aLeftInner:  true, aRightInner:  true, aScale:  mem[1152921509366030024], aCutOverrides:  val_32, aClosed:  true, aSmooth:  true, aDir:  (mem[536877873] + 8 + ((mem[536877995] + 0) + 16) << 2) + 16);
        val_38 = mem[536898999];
        val_37 = 1;
        label_17:
        if(val_37 < mem[536877999])
        {
            goto label_83;
        }
    
    }
    private void LegacyAddSegment(System.Collections.Generic.List<UnityEngine.Vector2> aSegment, bool aLeftInner, bool aRightInner, System.Collections.Generic.List<float> aScale, System.Collections.Generic.List<Ferr2DT_PathTerrain.CutOverrides> aCutOverrides, bool aClosed, bool aSmooth, Ferr2DT_TerrainDirection aDir = 100)
    {
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        Ferr2DT_PathTerrain val_14;
        var val_15;
        var val_16;
        var val_18;
        bool val_21;
        var val_22;
        val_14 = this;
        if(aDir == 100)
        {
                Ferr2DT_SegmentDescription val_1 = this.GetDescription(aSegment:  aSegment);
        }
        else
        {
                IFerr2DTMaterial val_2 = this.TerrainMaterial;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_15 = val_14;
            val_14 = val_14;
        }
        
        Random.State val_3 = UnityEngine.Random.state;
        IFerr2DTMaterial val_8 = this.TerrainMaterial;
        var val_18 = 0;
        val_18 = val_18 + 1;
        val_16 = this;
        float val_10 = width;
        float val_25 = mem[1152921509366162436];
        if(this == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 != 0)
        {
                val_18 = 1;
        }
        else
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_18 = 1;
        }
        
        float val_19 = 10000f;
        val_19 = 1 * val_19;
        UnityEngine.Random.InitState(seed:  (int)val_19);
        if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        float val_20 = 3.673424E-39f;
        float val_21 = 1.401298E-45f;
        val_20 = 0 - val_20;
        val_21 = 52 - val_21;
        if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_12 = 0 + ((0 - 2) << 3);
        if(0 == 0)
        {
                var val_22 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_22 = val_22 + ((0 - 1) << 3);
        float val_24 = (0 + ((0 - 2)) << 3) + 20;
        float val_23 = (0 + ((0 - 1)) << 3) + 16;
        val_23 = ((0 + ((0 - 2)) << 3) + 16) - val_23;
        val_24 = val_24 - ((0 + ((0 - 1)) << 3) + 20);
        val_20.Normalize();
        val_23.Normalize();
        if(464335944 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_21 = aClosed;
        val_25 = 464335928 * val_25;
        aSegment.set_Item(index:  0, value:  new UnityEngine.Vector2() {x = 3.673424E-39f, y = 2.865419E-22f});
        System.Collections.Generic.List<UnityEngine.Vector2> val_14 = aSegment - 1;
        if(aSegment == 0)
        {
                var val_26 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_26 = val_26 + (val_14 << 3);
        aSegment.set_Item(index:  val_14, value:  new UnityEngine.Vector2() {x = (0 + ((aSegment - 1)) << 3) + 16, y = (0 + ((aSegment - 1)) << 3) + 20});
        val_22 = 0;
        this.LegacyCreateBody(aDesc:  464348016, aSegment:  aSegment, aSegmentScale:  aScale, aCutOverrides:  aCutOverrides, aBodyWidth:  val_23, aTextureSlices:  val_25, aClosed:  UnityEngine.Mathf.Max(a:  2, b:  this.splitCount + 2));
        if(val_21 != true)
        {
                val_21 = aSmooth;
            if(this == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            this.LegacyAddCap(aSegment:  aSegment, aDesc:  464348016, aInner:  aLeftInner, aDir:  3.673424E-39f, aScale:  null, aSmooth:  false);
            if(this == 0)
        {
                var val_27 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_27 = val_27 + 1857392060;
            this.LegacyAddCap(aSegment:  aSegment, aDesc:  464348016, aInner:  aRightInner, aDir:  (0 + 1857392060) + 16, aScale:  null, aSmooth:  false);
            val_22 = 0;
        }
        
        UnityEngine.Random.state = new Random.State() {s0 = val_4, s1 = val_5, s2 = val_6, s3 = val_7};
    }
    private void LegacyCreateBody(Ferr2DT_SegmentDescription aDesc, System.Collections.Generic.List<UnityEngine.Vector2> aSegment, System.Collections.Generic.List<float> aSegmentScale, System.Collections.Generic.List<Ferr2DT_PathTerrain.CutOverrides> aCutOverrides, float aBodyWidth, int aTextureSlices, bool aClosed)
    {
        bool val_11;
        int val_27;
        float val_28;
        Ferr2DT_PathTerrain val_26;
        int val_27;
        Ferr2DT_SegmentDescription val_28;
        var val_29;
        System.Collections.Generic.List<UnityEngine.Vector2> val_30;
        Ferr2DT_PathTerrain val_31;
        System.Collections.Generic.List<CutOverrides> val_32;
        float val_33;
        var val_34;
        Ferr2DT_SegmentDescription val_35;
        float val_1 = Ferr2D_Path.GetSegmentLength(aPath:  aSegment, aClosed:  false);
        float val_31 = 0.5f;
        System.Collections.Generic.List<UnityEngine.Vector2> val_2 = aSegment / aTextureSlices;
        val_2 = val_2 + val_31;
        int val_3 = UnityEngine.Mathf.FloorToInt(f:  val_2);
        int val_4 = UnityEngine.Mathf.Max(a:  1, b:  val_3);
        Ferr2D_DynamicMesh val_5 = this.DMesh;
        val_26 = this;
        if(this == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_27 = 0;
        val_28 = aDesc;
        UnityEngine.Rect val_6 = aSegment.LegacyPickBody(aDesc:  464492784, aCutOverrides:  val_28, aStartPos:  new UnityEngine.Vector2() {x = aCutOverrides, y = 3.673424E-39f}, aCurrIndex:  val_3, aCurrCut:  val_27);
        float val_7 = aSegment.height;
        val_29 = ;
        val_30 = aSegment;
        val_31 = this;
        if(mem[1152921509366307216] == 3)
        {
                aDesc + 16 = -(aDesc + 16);
        }
        
        if(val_4 < 1)
        {
                return;
        }
        
        uint val_30 = 464480656;
        val_32 = val_28;
        val_30 = val_30 * val_31;
        val_29 = 0;
        val_33 = val_4;
        val_34 = 0;
        val_31 = val_30 * mem[1152921509366307208];
        float val_9 = 1f / (float)val_33;
        do
        {
            if(aClosed >= true)
        {
                float val_10 = 0f / (float)val_33;
            var val_34 = 0;
            do
        {
            Ferr2D_Path.PathGlobalPercentToLocal(aPath:  val_30, aPercent:  val_10, aLocalPoint: out  val_10, aLocalPercent: out  float val_14 = 2.901966E-22f, aPathLength:  val_6.m_YMin, aClosed:  true);
            val_29 = 0f;
            val_35 = val_32;
            if((val_29 - val_29) >= 1)
        {
                float val_16 = val_29 + 1;
            var val_33 = 0;
            do
        {
            int val_17 = val_16 + val_33;
            float val_18 = Ferr2D_Path.GetSegmentLengthToIndex(aPath:  val_30, aIndex:  val_17);
            float val_32 = val_30;
            val_32 = val_32 / aSegment;
            if(val_34 != 0)
        {
                val_34 = 1;
        }
        
            val_32 = val_32 * (float)val_33;
            val_33 = (float)(int)val_32;
            val_32 = val_32 - val_33;
            val_30 = aSegment;
            this.LegacyAddVertexColumn(aDesc:  aDesc, aSegment:  val_30, aSegmentScale:  aSegmentScale, aClosed:  val_11, mesh:  this, body:  new UnityEngine.Rect() {m_XMin = aSegment, m_YMin = val_16, m_Width = aDesc, m_Height = aSegmentScale}, d:  val_32, yOff:  val_6.m_YMin, aConnectFace:  val_31, slicePercent:  val_33, ptLocal:  aDesc + 16, pctLocal:  val_6.m_Height, p1: ref  1, p2: ref  val_32, p3: ref  val_17);
            val_29 = 0f;
            int val_25 = 0;
            val_33 = val_33 + 1;
        }
        while(val_33 < (val_29 - val_29));
        
            val_35 = aDesc;
        }
        
            val_31 = this;
            if(val_34 != 0)
        {
                val_34 = 1;
        }
        
            this.LegacyAddVertexColumn(aDesc:  val_35, aSegment:  val_30, aSegmentScale:  aSegmentScale, aClosed:  val_11, mesh:  this, body:  new UnityEngine.Rect() {m_XMin = aSegment, m_YMin = 0f, m_Width = aDesc, m_Height = aSegmentScale}, d:  0f, yOff:  val_6.m_YMin, aConnectFace:  val_31, slicePercent:  val_33, ptLocal:  aDesc + 16, pctLocal:  val_6.m_Height, p1: ref  1, p2: ref  0f / ((float)aClosed - 1), p3: ref  val_25);
            val_34 = val_34 + 1;
        }
        while(val_34 != aClosed);
        
            val_32 = val_35;
            val_26 = val_26;
            val_34 = 0;
        }
        
            val_28 = val_34 + 1;
            UnityEngine.Vector3 val_26 = GetVert(aIndex:  464492784);
            UnityEngine.Rect val_29 = LegacyPickBody(aDesc:  464492784, aCutOverrides:  val_32, aStartPos:  new UnityEngine.Vector2() {x = aCutOverrides, y = val_28}, aCurrIndex:  val_27, aCurrCut:  val_25);
        }
        while(1 != val_4);
    
    }
    private UnityEngine.Rect LegacyPickBody(Ferr2DT_SegmentDescription aDesc, System.Collections.Generic.List<Ferr2DT_PathTerrain.CutOverrides> aCutOverrides, UnityEngine.Vector2 aStartPos, int aCurrIndex, int aCurrCut)
    {
        var val_1;
        var val_7;
        var val_8;
        val_7 = aStartPos.x;
        if((aStartPos.x + 12) <= aCurrCut)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = aStartPos.x + 8;
        val_7 = val_7 + (aCurrCut << 2);
        if(((aStartPos.x + 8 + (aCurrCut) << 2) + 16 + 8) == 0)
        {
            goto label_16;
        }
        
        if((aStartPos.x + 12) <= aCurrCut)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_8 = aStartPos.x + 8;
        val_8 = val_8 + (aCurrCut << 2);
        if(((aStartPos.x + 8 + (aCurrCut) << 2) + 16 + 8 + 12) <= val_1)
        {
            goto label_16;
        }
        
        if((aStartPos.x + 12) <= aCurrCut)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_9 = aStartPos.x + 8;
        val_9 = val_9 + (aCurrCut << 2);
        if(((aStartPos.x + 8 + (aCurrCut) << 2) + 16 + 8 + 12) <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_10 = (aStartPos.x + 8 + (aCurrCut) << 2) + 16 + 8 + 8;
        val_10 = val_10 + (val_1 << 2);
        val_7 = mem[((aStartPos.x + 8 + (aCurrCut) << 2) + 16 + 8 + 8 + (val_1) << 2) + 16];
        val_7 = ((aStartPos.x + 8 + (aCurrCut) << 2) + 16 + 8 + 8 + (val_1) << 2) + 16;
        if(val_7 == 0)
        {
            goto label_16;
        }
        
        val_7 = val_7 - 1;
        if(val_7 >= ((aStartPos.x + 8 + (aCurrCut) << 2) + 16 + 12))
        {
            goto label_16;
        }
        
        UnityEngine.Rect val_2 = LegacyGetRandomBodyRect(aInitialPos:  new UnityEngine.Vector2() {x = aDesc, y = aStartPos.y}, aDesc:  aCurrIndex);
        IFerr2DTMaterial val_3 = aDesc.TerrainMaterial;
        System.Collections.Generic.List<CutOverrides> val_4 = aCutOverrides + (val_7 << 4);
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_8 = aDesc;
        goto label_23;
        label_16:
        UnityEngine.Rect val_5 = LegacyGetRandomBodyRect(aInitialPos:  new UnityEngine.Vector2() {x = aDesc, y = aStartPos.y}, aDesc:  aCurrIndex);
        return new UnityEngine.Rect() {m_XMin = val_5.m_XMin, m_YMin = val_5.m_YMin, m_Width = val_5.m_Width, m_Height = val_5.m_Height};
        label_23:
        return new UnityEngine.Rect() {m_XMin = val_5.m_XMin, m_YMin = val_5.m_YMin, m_Width = val_5.m_Width, m_Height = val_5.m_Height};
    }
    private UnityEngine.Rect LegacyGetRandomBodyRect(UnityEngine.Vector2 aInitialPos, Ferr2DT_SegmentDescription aDesc)
    {
        var val_1;
        var val_11;
        var val_12;
        var val_13;
        if((aInitialPos.x + 177) != 0)
        {
                Random.State val_2 = UnityEngine.Random.state;
            Ferr2DT_SegmentDescription val_11 = aDesc;
            val_11 = aInitialPos.y + val_11;
            UnityEngine.Random.InitState(seed:  (int)val_11);
        }
        
        IFerr2DTMaterial val_7 = aInitialPos.x.TerrainMaterial;
        if(val_1 != 0)
        {
                val_11 = mem[val_1 + 168];
            val_11 = val_1 + 168;
            val_12 = val_11;
        }
        else
        {
                val_12 = 264;
            val_11 = 264;
        }
        
        var val_9 = val_12 + ((UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  1685382482)) << 4);
        float val_13 = aInitialPos.x;
        if((aInitialPos.x + 178) == 0)
        {
            goto label_9;
        }
        
        var val_12 = 0;
        label_11:
        if((aInitialPos.x + 88 + 0) == 536888251)
        {
            goto label_10;
        }
        
        val_12 = val_12 + 1;
        if(((uint)val_12 & 65535) < (aInitialPos.x + 178))
        {
            goto label_11;
        }
        
        label_9:
        val_13 = aInitialPos.x;
        goto label_12;
        label_10:
        var val_10 = (aInitialPos.x + 88) + 0;
        val_13 = val_13 + (((aInitialPos.x + 88 + 0) + 4) << 3);
        val_13 = val_13 + 284;
        label_12:
        if((aInitialPos.x + 177) == 0)
        {
                return new UnityEngine.Rect();
        }
        
        UnityEngine.Random.state = new Random.State();
        return new UnityEngine.Rect();
    }
    private void LegacyAddVertexColumn(Ferr2DT_SegmentDescription aDesc, System.Collections.Generic.List<UnityEngine.Vector2> aSegment, System.Collections.Generic.List<float> aSegmentScale, bool aClosed, Ferr2D_DynamicMesh mesh, UnityEngine.Rect body, float d, float yOff, bool aConnectFace, float slicePercent, int ptLocal, float pctLocal, ref int p1, ref int p2, ref int p3)
    {
        var val_4;
        float val_5;
        int val_37;
        int val_38;
        int val_39;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        Ferr2DT_PathTerrain val_51;
        bool val_52;
        float val_53;
        var val_58;
        var val_59;
        int val_60;
        if(this.smoothPath != false)
        {
                UnityEngine.Vector2 val_2 = Ferr2D_Path.HermiteGetPt(aSegment:  464886512, i:  aSegment, aPercentage:  d, aClosed:  true, aTension:  yOff, aBias:  slicePercent);
        }
        else
        {
                UnityEngine.Vector2 val_3 = Ferr2D_Path.LinearGetPt(aPath:  464886512, aIndex:  aSegment, aPercent:  d, aClosed:  true);
        }
        
        if(this.smoothPath != false)
        {
                UnityEngine.Vector2 val_6 = Ferr2D_Path.HermiteGetNormal(aSegment:  464886512, i:  aSegment, aPercentage:  val_3.x, aClosed:  true, aTension:  val_3.y, aBias:  slicePercent);
        }
        else
        {
                UnityEngine.Vector2 val_7 = Ferr2D_Path.LinearGetNormal(aPath:  464886512, aIndex:  aSegment, aPercent:  val_3.x, aClosed:  true);
        }
        
        if(val_5 <= p3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_8 = aClosed + 1859820928;
        if(aClosed != false)
        {
                if(val_5 <= val_5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_47 = aClosed + (val_5 << 2);
        }
        else
        {
                int val_9 = val_5 - 1;
            int val_10 = UnityEngine.Mathf.Min(a:  464955233, b:  val_9);
            if(val_10 <= val_10)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_47 = 0 + (val_10 << 2);
        }
        
        val_9 = val_47 + 16;
        float val_11 = UnityEngine.Mathf.Lerp(a:  val_7.x, b:  val_7.y, t:  slicePercent);
        val_48 = (aClosed + 1859820928) + 16;
        if(this.smoothPath != false)
        {
                val_49 = val_5;
            val_50 = val_4;
            val_51 = this;
        }
        else
        {
                val_5.Normalize();
            UnityEngine.Vector2 val_12 = Ferr2D_Path.GetSegmentNormal(i:  464886512, aPath:  464955232, aClosed:  aSegment);
            val_4 = val_4;
            val_5 = val_5;
            float val_13 = val_5.sqrMagnitude;
            float val_14 = val_5.sqrMagnitude;
            val_51 = this;
            if(mem[536890411] >= _TYPE_MAX_)
        {
                float val_41 = 464886512 * 464886504;
        }
        
            if(mem[536890411] >= 0)
        {
                float val_40 = val_4;
            val_40 = val_4 * val_40;
            val_41 = val_40 / val_41;
            float val_16 = UnityEngine.Mathf.Clamp(value:  val_41, min:  val_12.y, max:  val_5);
            val_52 = mem[536890482];
            if((val_52 & true) == 0)
        {
                val_52 = mem[536890411];
        }
        
            val_16 = val_16 * 57.29578f;
            val_53 = val_16 * 0.01745329f;
        }
        else
        {
                val_53 = 0f;
        }
        
            uint val_42 = 0;
            val_49 = val_5;
            val_50 = val_4;
            float val_43 = 1f;
            val_42 = val_42 & (~2147483648);
            val_43 = val_43 / val_42;
            val_48 = val_48 * val_43;
        }
        
        bool val_44 = aConnectFace;
        var val_45 = mem[1152921509366712912];
        float val_17 = body.m_XMin.x;
        float val_19 = UnityEngine.Mathf.Lerp(a:  body.m_XMin.xMax, b:  val_12.y, t:  val_42);
        val_48 = val_48 * val_44;
        val_44 = val_48 + ptLocal;
        if(mem[1152921509366712992] == 3)
        {
                float val_20 = body.m_XMin.yMax;
        }
        
        val_45 = aDesc._zOffset - val_45;
        float val_23 = body.m_XMin.x;
        float val_25 = UnityEngine.Mathf.Lerp(a:  body.m_XMin.xMax, b:  val_12.y, t:  val_42);
        val_48 = val_48 - ptLocal;
        if(mem[1152921509366712992] == 3)
        {
                float val_26 = body.m_XMin.y;
        }
        
        float val_28 = mem[1152921509366712912] + aDesc._zOffset;
        val_58 = p1;
        int val_29 = mesh.AddVertex(aX:  body.m_XMin.yMax, aY:  val_12.y, aZ:  val_42, aU:  pctLocal, aV:  null);
        if(mem[1152921509366713008] != false)
        {
                float val_30 = body.m_XMin.x;
            float val_32 = UnityEngine.Mathf.Lerp(a:  body.m_XMin.xMax, b:  val_12.y, t:  val_42);
            float val_33 = body.m_XMin.y;
            val_59 = mesh;
            val_58 = p1;
            val_60 = mesh.AddVertex(aX:  UnityEngine.Mathf.Lerp(a:  body.m_XMin.yMax, b:  val_12.y, t:  val_42), aY:  val_12.y, aZ:  val_42, aU:  pctLocal, aV:  null);
        }
        else
        {
                val_59 = mesh;
            val_60 = 0;
        }
        
        if(val_58 == 0)
        {
            goto label_36;
        }
        
        if(mem[1152921509366713008] == false)
        {
            goto label_32;
        }
        
        if(val_59 == 0)
        {
            goto label_33;
        }
        
        val_59.AddFace(aV1:  val_29, aV2:  val_38, aV3:  val_37, aV4:  val_60);
        goto label_34;
        label_32:
        val_59.AddFace(aV1:  val_29, aV2:  val_38, aV3:  val_39, aV4:  mesh.AddVertex(aX:  body.m_XMin.y, aY:  val_12.y, aZ:  val_42, aU:  pctLocal, aV:  null));
        goto label_36;
    }
    private void LegacyAddCap(System.Collections.Generic.List<UnityEngine.Vector2> aSegment, Ferr2DT_SegmentDescription aDesc, bool aInner, float aDir, float aScale, bool aSmooth)
    {
        var val_4;
        var val_5;
        var val_6;
        var val_46;
        Ferr2DT_PathTerrain val_84;
        Ferr2DT_PathTerrain val_85;
        Ferr2DT_PathTerrain val_86;
        Ferr2DT_PathTerrain val_87;
        Ferr2DT_PathTerrain val_88;
        Ferr2DT_PathTerrain val_89;
        Ferr2DT_SegmentDescription val_90;
        float val_94;
        var val_96;
        float val_97;
        var val_98;
        Ferr2DT_PathTerrain val_99;
        var val_100;
        int val_101;
        int val_102;
        int val_103;
        IFerr2DTMaterial val_1 = this.TerrainMaterial;
        Ferr2D_DynamicMesh val_2 = this.DMesh;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        if(aSegment < 0)
        {
                if(val_4 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_7 = val_5 + 24;
        }
        else
        {
                bool val_8 = val_4 - 1;
            if(val_4 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_9 = val_5 + (val_8 << 3);
            if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            float val_10 = val_5 + 4294967280;
            val_10 = val_10 + 16;
        }
        
        float val_84 = val_10;
        float val_85 = ((val_5 + 4294967280) + 16) + 4;
        val_84 = ((val_5 + ((val_4 - 1)) << 3) + 16) - val_84;
        val_85 = 465047568 - val_85;
        val_84.Normalize();
        if(val_6 != 0)
        {
                UnityEngine.Vector2 val_11 = Ferr2D_Path.HermiteGetNormal(aSegment:  465035400, i:  aSegment, aPercentage:  val_84, aClosed:  val_8, aTension:  val_3.y, aBias:  val_85);
        }
        else
        {
                UnityEngine.Vector2 val_12 = Ferr2D_Path.GetNormal(aSegment:  465035400, i:  aSegment, aClosed:  val_8);
        }
        
        var val_97 = val_4;
        var val_98 = val_5;
        if(465035400 <= val_8)
        {
                var val_86 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_86 = val_86 + (val_8 << 3);
        if(mem[1152921509366862000] == 3)
        {
                aDesc + 16 = -(aDesc + 16);
        }
        
        if(mem[1152921509366862000] >= 0)
        {
            goto label_12;
        }
        
        if(mem[1152921509366862000] != 3)
        {
            goto label_13;
        }
        
        if(aInner == true)
        {
            goto label_15;
        }
        
        UnityEngine.Rect val_13 = innerRightCap;
        float val_14 = width;
        if(aInner <= false)
        {
            goto label_15;
        }
        
        UnityEngine.Rect val_15 = innerRightCap;
        Ferr2DT_PathTerrain val_91 = this;
        if(this.createCollider == false)
        {
            goto label_20;
        }
        
        label_19:
        if((this.fillSplitDistance + 0) == 536888251)
        {
            goto label_18;
        }
        
        if(1 < this.createCollider)
        {
            goto label_19;
        }
        
        goto label_20;
        label_12:
        if(mem[1152921509366862000] != 3)
        {
            goto label_21;
        }
        
        if(val_4 != 0)
        {
            goto label_23;
        }
        
        UnityEngine.Rect val_18 = innerLeftCap;
        float val_19 = width;
        if(val_4 <= 0)
        {
            goto label_23;
        }
        
        UnityEngine.Rect val_20 = innerLeftCap;
        val_84 = this;
        if(val_84 == 0)
        {
                val_84 = this;
        }
        
        Ferr2DT_PathTerrain val_92 = this;
        if(this.createCollider == false)
        {
            goto label_25;
        }
        
        label_27:
        if((this.fillSplitDistance + 0) == 536888251)
        {
            goto label_26;
        }
        
        if(1 < this.createCollider)
        {
            goto label_27;
        }
        
        label_25:
        val_85 = val_84;
        val_84 = this;
        goto label_28;
        label_13:
        if(val_4 == 0)
        {
            goto label_30;
        }
        
        UnityEngine.Rect val_21 = innerLeftCap;
        float val_22 = width;
        if(val_4 <= 0)
        {
            goto label_30;
        }
        
        UnityEngine.Rect val_23 = innerLeftCap;
        val_86 = this;
        if(val_86 == 0)
        {
                val_86 = this;
        }
        
        Ferr2DT_PathTerrain val_93 = this;
        if(this.createCollider == false)
        {
            goto label_32;
        }
        
        label_34:
        if((this.fillSplitDistance + 0) == 536888251)
        {
            goto label_33;
        }
        
        if(1 < this.createCollider)
        {
            goto label_34;
        }
        
        label_32:
        val_87 = val_86;
        val_86 = this;
        goto label_35;
        label_21:
        if(val_4 == 0)
        {
            goto label_37;
        }
        
        UnityEngine.Rect val_24 = innerRightCap;
        float val_25 = width;
        if(val_4 <= 0)
        {
            goto label_37;
        }
        
        UnityEngine.Rect val_26 = innerRightCap;
        val_88 = this;
        if(val_88 == 0)
        {
                val_88 = this;
        }
        
        Ferr2DT_PathTerrain val_94 = this;
        if(this.createCollider == false)
        {
            goto label_39;
        }
        
        label_41:
        if((this.fillSplitDistance + 0) == 536888251)
        {
            goto label_40;
        }
        
        if(1 < this.createCollider)
        {
            goto label_41;
        }
        
        label_39:
        val_89 = val_88;
        val_88 = this;
        goto label_42;
        label_15:
        UnityEngine.Rect val_27 = rightCap;
        Ferr2DT_PathTerrain val_87 = this;
        if(this.createCollider == false)
        {
            goto label_47;
        }
        
        label_46:
        if((this.fillSplitDistance + 0) == 536888251)
        {
            goto label_45;
        }
        
        if(1 < this.createCollider)
        {
            goto label_46;
        }
        
        goto label_47;
        label_23:
        UnityEngine.Rect val_28 = leftCap;
        Ferr2DT_PathTerrain val_88 = this;
        if(this.createCollider == false)
        {
            goto label_52;
        }
        
        label_51:
        if((this.fillSplitDistance + 0) == 536888251)
        {
            goto label_50;
        }
        
        if(1 < this.createCollider)
        {
            goto label_51;
        }
        
        goto label_52;
        label_30:
        UnityEngine.Rect val_29 = leftCap;
        Ferr2DT_PathTerrain val_89 = this;
        if(this.createCollider == false)
        {
            goto label_57;
        }
        
        label_56:
        if((this.fillSplitDistance + 0) == 536888251)
        {
            goto label_55;
        }
        
        if(1 < this.createCollider)
        {
            goto label_56;
        }
        
        goto label_57;
        label_37:
        UnityEngine.Rect val_30 = rightCap;
        Ferr2DT_PathTerrain val_90 = this;
        if(this.createCollider == false)
        {
            goto label_62;
        }
        
        label_61:
        if((this.fillSplitDistance + 0) == 536888251)
        {
            goto label_60;
        }
        
        if(1 < this.createCollider)
        {
            goto label_61;
        }
        
        goto label_62;
        label_45:
        float val_31 = this.fillSplitDistance + 0;
        val_87 = val_87 + (((this.fillSplitDistance + 0) + 4) << 3);
        val_87 = val_87 + 284;
        label_47:
        goto label_66;
        label_50:
        float val_32 = this.fillSplitDistance + 0;
        val_88 = val_88 + (((this.fillSplitDistance + 0) + 4) << 3);
        val_88 = val_88 + 284;
        label_52:
        goto label_66;
        label_55:
        float val_33 = this.fillSplitDistance + 0;
        val_89 = val_89 + (((this.fillSplitDistance + 0) + 4) << 3);
        val_89 = val_89 + 284;
        label_57:
        goto label_66;
        label_60:
        float val_34 = this.fillSplitDistance + 0;
        val_90 = val_90 + (((this.fillSplitDistance + 0) + 4) << 3);
        val_90 = val_90 + 284;
        label_62:
        goto label_66;
        label_18:
        float val_35 = this.fillSplitDistance + 0;
        val_91 = val_91 + (((this.fillSplitDistance + 0) + 4) << 3);
        val_91 = val_91 + 284;
        label_20:
        goto label_69;
        label_26:
        float val_36 = this.fillSplitDistance + 0;
        val_92 = val_92 + (((this.fillSplitDistance + 0) + 4) << 3);
        val_85 = val_92 + 284;
        label_28:
        goto label_69;
        label_33:
        float val_37 = this.fillSplitDistance + 0;
        val_93 = val_93 + (((this.fillSplitDistance + 0) + 4) << 3);
        val_87 = val_93 + 284;
        label_35:
        goto label_69;
        label_40:
        float val_38 = this.fillSplitDistance + 0;
        val_94 = val_94 + (((this.fillSplitDistance + 0) + 4) << 3);
        val_89 = val_94 + 284;
        label_42:
        label_69:
        label_66:
        val_90 = aDesc;
        float val_39 = width;
        var val_96 = mem[1152921509366861988];
        float val_40 = height;
        var val_95 = mem[1152921509366861992];
        if(mem[1152921509366862000] == 3)
        {
                float val_41 = xMax;
        }
        else
        {
                float val_42 = x;
        }
        
        if(mem[1152921509366862000] == 3)
        {
                float val_44 = x;
        }
        else
        {
                float val_45 = xMax;
        }
        
        val_95 = (465035432 * 0.5f) * val_95;
        if(mem[1152921509366862000] == 3)
        {
                float val_47 = yMax;
        }
        else
        {
                float val_48 = y;
        }
        
        val_96 = 465035432 * val_96;
        val_94;
        float val_49 = val_95 * val_46;
        if(mem[1152921509366862000] == 3)
        {
                float val_50 = y;
        }
        else
        {
                float val_51 = yMax;
        }
        
        float val_52 = (aDesc + 16) + val_49;
        float val_53 = val_98 * val_52;
        float val_54 = val_97 * val_52;
        if(mem[1152921509366862000] >= 3)
        {
                465035432 = 465035432;
            465035432 = 465035432;
        }
        
        float val_57 = (aDesc + 12) - mem[1152921509366861920];
        val_96 = 0;
        int val_58 = this.AddVertex(aVert:  new UnityEngine.Vector2() {x = val_54 + ((0 + ((val_4 - 1)) << 3) + 16), y = val_53 + (???)}, aZ:  val_57, aUV:  new UnityEngine.Vector2() {x = val_57, y = 465035432});
        val_97 = 465035432;
        if(this == 0)
        {
                val_97 = val_97;
            val_90 = val_90;
            val_94 = val_94;
            val_96 = 0;
        }
        
        float val_61 = (aDesc + 12) - mem[1152921509366861920];
        int val_62 = this.AddVertex(aVert:  new UnityEngine.Vector2() {x = val_54 + ((0 + ((val_4 - 1)) << 3) + 16), y = val_53 + (???)}, aZ:  val_61, aUV:  new UnityEngine.Vector2() {x = val_61, y = val_97});
        if(mem[1152921509366862016] != false)
        {
                float val_63 = val_97 * (aDesc + 16);
            float val_64 = val_98 * (aDesc + 16);
            float val_65 = y;
            float val_66 = height;
            float val_67 = val_64 + (???);
            int val_69 = this.AddVertex(aVert:  new UnityEngine.Vector2() {x = val_63 + ((0 + ((val_4 - 1)) << 3) + 16), y = val_67}, aZ:  val_67, aUV:  new UnityEngine.Vector2() {x = aDesc + 12, y = 3.041999E-22f});
            if(mem[1152921509366862016] != false)
        {
                float val_71 = y;
            float val_72 = height;
            int val_74 = this.AddVertex(aVert:  new UnityEngine.Vector2() {x = val_63 + ((0 + ((val_4 - 1)) << 3) + 16), y = val_64 + (???)}, aZ:  465035432, aUV:  new UnityEngine.Vector2() {x = aDesc + 12, y = 3.041999E-22f});
        }
        else
        {
                val_98 = 0;
        }
        
        }
        
        float val_75 = val_49 - (aDesc + 16);
        val_99 = this;
        val_97 = val_97 * val_75;
        val_98 = val_98 * val_75;
        val_75 = (???) - val_98;
        float val_77 = mem[1152921509366861920] + (aDesc + 12);
        int val_78 = this.AddVertex(aVert:  new UnityEngine.Vector2() {x = ((0 + ((val_4 - 1)) << 3) + 16) - val_97, y = val_75}, aZ:  val_77, aUV:  new UnityEngine.Vector2() {x = val_77, y = 3.041999E-22f});
        float val_81 = mem[1152921509366861920] + (aDesc + 12);
        bool val_99 = mem[1152921509366862016];
        if((val_99 == false) || (val_99 >= 0))
        {
            goto label_90;
        }
        
        if(this == 0)
        {
            goto label_91;
        }
        
        val_100 = 0;
        this.AddFace(aV1:  val_58, aV2:  val_62, aV3:  0, aV4:  0);
        goto label_92;
        label_90:
        val_99 = val_99 >> 5;
        if(val_99 < false)
        {
                0 = 1;
        }
        
        bool val_83 = val_99 | 1;
        if(val_83 == false)
        {
            goto label_94;
        }
        
        val_101 = val_78;
        if(val_83 >= 0)
        {
            goto label_95;
        }
        
        val_102 = val_58;
        val_103 = val_62;
        goto label_99;
        label_94:
        val_99 = 0;
        this.AddFace(aV1:  val_62, aV2:  val_58, aV3:  0, aV4:  0);
        val_102 = val_98;
        val_103 = 0;
        goto label_98;
        label_91:
        val_100 = 0;
        0.AddFace(aV1:  val_58, aV2:  val_62, aV3:  0, aV4:  0);
        label_92:
        val_101 = val_78;
        val_102 = val_100;
        val_103 = val_98;
        goto label_99;
        label_95:
        val_102 = val_62;
        val_103 = val_58;
        label_98:
        val_101 = this.AddVertex(aVert:  new UnityEngine.Vector2() {x = ((0 + ((val_4 - 1)) << 3) + 16) - val_97, y = (???) - val_98}, aZ:  val_81, aUV:  new UnityEngine.Vector2() {x = val_81, y = 3.041999E-22f});
        label_99:
        this.AddFace(aV1:  val_102, aV2:  val_103, aV3:  val_101, aV4:  val_101);
    }
    private void LegacyAddFill(bool aSkirt, bool aFullBuild)
    {
        var val_7;
        var val_10;
        var val_41;
        var val_43;
        Ferr2DT_PathTerrain val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        float val_56;
        float val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        IFerr2DTMaterial val_1 = this.TerrainMaterial;
        val_50 = this;
        var val_52 = 0;
        val_52 = val_52 + 1;
        val_51 = val_50;
        val_52 = 256;
        if((UnityEngine.Object.op_Implicit(exists:  465167760)) != true)
        {
                var val_53 = 0;
            val_53 = val_53 + 1;
            val_53 = val_50;
            UnityEngine.Texture val_5 = this.mainTexture;
            val_52 = val_50;
        }
        
        var val_54 = 0;
        val_54 = val_54 + 1;
        val_54 = val_50;
        var val_55 = 0;
        val_55 = val_55 + 1;
        val_55 = val_50;
        float val_12 = width;
        float val_14 = (4.651677E+08f) / mem[1152921509366982064];
        val_14 = 465155696 * val_14;
        val_56 = mem[1152921509366982204];
        val_14 = val_14 / ((float)UnityEngine.Mathf.Max(a:  1, b:  mem[1152921509366982200]));
        val_14 = val_56 * val_14;
        System.Collections.Generic.List<UnityEngine.Vector2> val_15 = this.GetSegmentsCombined(aSplitDist:  val_14);
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.one;
        var val_56 = 0;
        val_56 = val_56 + 1;
        val_58 = val_50;
        if(465167760 != 0)
        {
                var val_57 = 0;
            val_57 = val_57 + 1;
            val_59 = val_50;
            UnityEngine.Texture val_20 = this.mainTexture;
            if(465167760 != 0)
        {
                var val_58 = 0;
            val_58 = val_58 + 1;
            val_60 = val_50;
            UnityEngine.Texture val_23 = this.mainTexture;
            var val_59 = 0;
            val_59 = val_59 + 1;
            val_61 = val_50;
            UnityEngine.Texture val_25 = this.mainTexture;
            val_57 = (4.651677E+08f) / mem[1152921509366982064];
            val_56 = (4.651677E+08f) / mem[1152921509366982064];
        }
        
        }
        
        if(aSkirt != false)
        {
                if(mem[1152921509366982044] == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(this != 0)
        {
                val_62 = mem[1152921509366982044];
            val_63 = val_62;
        }
        else
        {
                val_63 = 0;
            val_62 = 0;
        }
        
            if(val_62 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_60 = mem[1152921509366982040];
            val_60 = val_60 + 4294967288;
            this.Add(item:  new UnityEngine.Vector2() {x = (mem[1152921509366982040] + 4294967288) + 16, y = mem[1152921509366982044]});
            this.Add(item:  new UnityEngine.Vector2() {x = (mem[1152921509366982040] + 4294967288) + 16, y = mem[1152921509366982044]});
            val_50 = this;
            float val_27 = UnityEngine.Mathf.Lerp(a:  UnityEngine.Mathf.Lerp(a:  val_57, b:  val_16.y, t:  val_56), b:  val_16.y, t:  val_56);
            this.Add(item:  new UnityEngine.Vector2() {x = (mem[1152921509366982040] + 4294967288) + 16, y = mem[1152921509366982044]});
            this.Add(item:  new UnityEngine.Vector2() {x = mem[1152921509366982040] + 16, y = mem[1152921509366982044]});
        }
        
        Ferr2D_DynamicMesh val_28 = this.DMesh;
        int val_29 = this.VertCount;
        var val_61 = mem[1152921509366982192];
        if(mem[1152921509366982116] == true)
        {
                mem[1152921509366982116] = aFullBuild;
        }
        
        val_61 = val_61 - 3;
        System.Collections.Generic.List<System.Int32> val_32 = Ferr2D_Triangulator.GetIndices(aPoints: ref  System.Collections.Generic.List<UnityEngine.Vector2> val_31 = 465155716, aTreatAsPath:  true, aInvert:  val_61 >> 5, aInvertBorderSize:  new UnityEngine.Vector2() {x = mem[1152921509366982052], y = mem[1152921509366982056]}, aVertGridSpacing:  0f = mem[1152921509366982120]);
        val_64 = 16;
        val_65 = 0;
        goto label_68;
        label_81:
        Ferr2D_DynamicMesh val_33 = this.DMesh;
        val_50 = this;
        if(mem[1152921509366982044] <= val_65)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_62 = mem[1152921509366982040];
        val_62 = val_62 + val_64;
        if(mem[1152921509366982044] <= val_65)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_63 = mem[1152921509366982040];
        val_63 = val_63 + val_64;
        if(mem[1152921509366982044] <= val_65)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_64 = mem[1152921509366982040];
        val_64 = val_64 + val_64;
        UnityEngine.Transform val_34 = this.transform;
        UnityEngine.Vector3 val_35 = position;
        if(mem[1152921509366982044] <= val_65)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_65 = mem[1152921509366982040];
        val_65 = val_65 + val_64;
        UnityEngine.Transform val_36 = this.transform;
        UnityEngine.Vector3 val_37 = position;
        float val_38 = mem[1152921509366982108] + ((mem[1152921509366982040] + val_64) + 4);
        float val_39 = mem[1152921509366982104] + val_64;
        val_38 = val_38 + val_10;
        val_39 = val_39 + val_7;
        val_38 = val_38 / val_56;
        val_39 = val_39 / val_57;
        int val_40 = this.AddVertex(aX:  val_38, aY:  val_37.y, aZ:  val_39, aU:  null, aV:  mem[1152921509366982064]);
        val_64 = 24;
        val_65 = 1;
        label_68:
        if(val_65 < mem[1152921509366982044])
        {
            goto label_81;
        }
        
        var val_66 = 0;
        label_88:
        if(val_66 >= val_41)
        {
                return;
        }
        
        Ferr2D_DynamicMesh val_42 = this.DMesh;
        val_66 = val_41;
        if(val_66 <= val_66)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_66 = val_41;
        }
        
        val_67 = val_43;
        var val_44 = val_67 + 0;
        if(val_66 <= (val_66 + 1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_67 = val_43;
            val_66 = val_41;
        }
        
        var val_46 = val_67 + 0;
        if(val_66 <= (val_66 + 2))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_67 = val_43;
        }
        
        var val_48 = val_67 + 0;
        this.AddFace(aV1:  ((val_43 + 0) + 16) + val_29, aV2:  ((val_43 + 0) + 20) + val_29, aV3:  ((val_43 + 0) + 24) + val_29);
        val_66 = val_66 + 3;
        goto label_88;
    }
    public void LegacyRecreateCollider()
    {
        if(this.createCollider == false)
        {
                return;
        }
        
        if(this.create3DCollider != false)
        {
                this.LegacyRecreateCollider3D();
            return;
        }
        
        this.LegacyRecreateCollider2D();
    }
    private void LegacyRecreateCollider3D()
    {
        Ferr2DT_PathTerrain val_22;
        var val_23;
        var val_24;
        float val_25;
        float val_26;
        Ferr2DT_PathTerrain val_27;
        var val_28;
        Ferr2DT_PathTerrain val_29;
        val_22 = this;
        536886805 = new Ferr2D_DynamicMesh();
        System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> val_2 = this.GetColliderVerts(aPhysicsMaterials2D:  0, aPhysicsMaterials3D:  0);
        val_23 = 0;
        goto label_1;
        label_19:
        val_24 = 0;
        goto label_2;
        label_17:
        Ferr2D_Path val_3 = this.Path;
        if((this.fillY != 0f) && (val_24 == (this.fillY - 1)))
        {
                if(this.fillY <= val_23)
        {
                var val_22 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_22 = val_22 + 0;
            if(((0 + 0) + 16 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_25 = (0 + 0) + 16 + 8 + 16;
            val_26 = (0 + 0) + 16 + 8 + 20;
        }
        else
        {
                if(this.fillY <= val_23)
        {
                var val_23 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_23 = val_23 + 0;
            if(((0 + 0) + 16 + 12) <= val_24)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_25 = (0 + 0) + 16 + 8 + 16;
            val_26 = (0 + 0) + 16 + 8 + 16 + 4;
        }
        
        int val_5 = val_1.AddVertex(aVert:  new UnityEngine.Vector3() {x = val_25, y = val_26, z = 0f});
        val_22 = val_22;
        val_24 = 1;
        label_2:
        if(this.fillY <= val_23)
        {
                var val_24 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_24 = val_24 + 0;
        if(val_24 < ((0 + 0) + 16 + 12))
        {
            goto label_17;
        }
        
        val_23 = 1;
        label_1:
        if(val_23 < this.fillY)
        {
            goto label_19;
        }
        
        var val_7 = (mem[1152921509367206192] - 3) >> 5;
        val_1.ExtrudeZ(aDist:  null, aInverted:  mem[1152921509367206128]);
        if(mem[1152921509367206238] != true)
        {
                val_1.RemoveFaces(aFacing:  new UnityEngine.Vector3() {x = 0f, y = 1f, z = 0f}, aDegreesTolerance:  null);
        }
        
        if(mem[1152921509367206236] != true)
        {
                val_1.RemoveFaces(aFacing:  new UnityEngine.Vector3() {x = -1f, y = 0f, z = 0f}, aDegreesTolerance:  null);
        }
        
        if(mem[1152921509367206237] != true)
        {
                val_1.RemoveFaces(aFacing:  new UnityEngine.Vector3() {x = 1f, y = 0f, z = 0f}, aDegreesTolerance:  null);
        }
        
        if(mem[1152921509367206239] != true)
        {
                val_1.RemoveFaces(aFacing:  new UnityEngine.Vector3() {x = 0f, y = -1f, z = 0f}, aDegreesTolerance:  null);
        }
        
        UnityEngine.Transform val_8 = this.GetComponent<UnityEngine.Transform>();
        val_27 = val_22;
        if(465391760 == 0)
        {
                UnityEngine.GameObject val_10 = this.gameObject;
            SynchronizationContextBehavoir val_11 = this.AddComponent<SynchronizationContextBehavoir>();
            val_27 = val_22;
        }
        
        if(mem[1152921509367206132] != 0)
        {
                this.sharedMaterial = mem[1152921509367206132];
        }
        
        if(val_27 != 0)
        {
                if(mem[1152921509367206125] == true)
        {
                mem[1152921509367206125] = 1;
        }
        
            this.isTrigger = true;
        }
        else
        {
                if(mem[1152921509367206125] == true)
        {
                mem[1152921509367206125] = 1;
        }
        
            0.isTrigger = true;
        }
        
        UnityEngine.Mesh val_13 = this.sharedMesh;
        val_28 = val_27;
        UnityEngine.GameObject val_14 = this.gameObject;
        int val_15 = this.GetInstanceID();
        string val_16 = System.String.Format(format:  -1610608197, arg0:  536888987);
        val_29 = val_22;
        if(465391760 == 0)
        {
            goto label_42;
        }
        
        string val_18 = this.name;
        if((System.String.op_Inequality(a:  465391760, b:  -1610608197)) == false)
        {
            goto label_44;
        }
        
        label_42:
        UnityEngine.Mesh val_20 = 536890419;
        val_28 = val_20;
        val_20 = new UnityEngine.Mesh();
        this.sharedMesh = 536890419;
        val_28.name = -1610608197;
        val_29 = val_22;
        label_44:
        this.sharedMesh = 0;
        if(mem[1152921509367206100] == true)
        {
                mem[1152921509367206100] = 1;
        }
        
        val_1.Build(aMesh: ref  UnityEngine.Mesh val_21 = 465379716, aCalculateTangents:  true);
        this.sharedMesh = 536890419;
    }
    private void LegacyRecreateCollider2D()
    {
        var val_13;
        var val_14;
        bool val_55;
        System.Collections.Generic.List<Point> val_56;
        var val_57;
        float val_58;
        float val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        536877803 = new System.Collections.Generic.List<SingleRange>(capacity:  1);
        val_55 = 0;
        System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> val_2 = this.GetColliderVerts(aPhysicsMaterials2D:  0, aPhysicsMaterials3D:  0);
        if(this.collidersBottom == true)
        {
                this.collidersBottom = this.collidersLeft;
        }
        
        if(this.collidersBottom != false)
        {
                if(this.collidersRight == true)
        {
                val_55 = this.collidersTop;
        }
        
        }
        
        if(this.useEdgeCollider == false)
        {
            goto label_2;
        }
        
        T[] val_3 = this.GetComponents<UnityEngine.PolygonCollider2D>();
        val_56 = 536877853;
        val_56 = new System.Collections.Generic.List<Point>(collection:  465507856);
        float val_5 = this.fillY - this.fillY;
        if(val_5 < (1.401298E-45f))
        {
            goto label_5;
        }
        
        do
        {
            if(mem[536877865] == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.Object.Destroy(obj:  mem[536877861] + 16);
            val_56.RemoveAt(index:  0);
            val_5 = val_5 - 1;
        }
        while(mem[536891337] != 0);
        
        goto label_33;
        label_2:
        UnityEngine.Transform val_6 = this.GetComponent<UnityEngine.Transform>();
        val_57 = this;
        if(465507856 == 0)
        {
                UnityEngine.GameObject val_8 = this.gameObject;
            SynchronizationContextBehavoir val_9 = this.AddComponent<SynchronizationContextBehavoir>();
            val_57 = this;
        }
        
        536877803.Add(item:  465507856);
        this.pathCount = this.fillY;
        if((val_55 == false) || (this.fillY >= (2.802597E-45f)))
        {
            goto label_20;
        }
        
        if(this.fill != 3)
        {
            goto label_21;
        }
        
        if(this.fillY == 0f)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Rect val_10 = Ferr2D_Path.GetBounds(aFrom:  465495784);
        this.pathCount = 2;
        if(this.fillY == 0f)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        T[] val_11 = 2621443.ToArray();
        this.SetPath(index:  0, points:  2621443);
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.zero;
        var val_54 = val_13;
        var val_55 = val_14;
        val_54 = S18 - val_54;
        val_55 = this.invertFillBorder - val_55;
        float val_15 = val_54 * val_54;
        float val_16 = xMin;
        uint val_56 = 465495800;
        if(val_57 < 0)
        {
            goto label_27;
        }
        
        float val_17 = yMax;
        val_56 = val_56 - this.invertFillBorder;
        mem[536882601] = val_56;
        mem[536882605] = 465495800 - S22;
        float val_19 = xMax;
        UnityEngine.Vector2 val_57 = this.invertFillBorder;
        float val_20 = yMax;
        val_57 = 465495800 + val_57;
        mem[536882609] = val_57;
        mem[536882613] = 465495800 - val_54;
        float val_22 = xMax;
        UnityEngine.Vector2 val_58 = this.invertFillBorder;
        float val_23 = yMin;
        val_58 = 465495800 + val_58;
        mem[536882617] = val_58;
        mem[536882621] = 465495800 + val_54;
        float val_25 = xMin;
        float val_26 = yMin;
        val_58 = 465495800 - this.invertFillBorder;
        val_59 = 465495800 + val_54;
        goto label_32;
        label_5:
        var val_59 = 0;
        if((UnityEngine.Mathf.Abs(value:  val_5)) >= 1)
        {
                do
        {
            UnityEngine.GameObject val_28 = this.gameObject;
            SynchronizationContextBehavoir val_29 = this.AddComponent<SynchronizationContextBehavoir>();
            val_56.Add(item:  465507856);
            val_59 = val_59 + 1;
        }
        while(val_59 < (UnityEngine.Mathf.Abs(value:  val_5)));
        
        }
        
        label_33:
        val_60 = 4;
        goto label_37;
        label_45:
        if(mem[536877865] <= this)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(this.fillY <= this)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        T[] val_31 = 2621443.ToArray();
        mem[536877861] + 16.points = 2621443;
        536877803.Add(item:  mem[536877861] + 16);
        val_60 = 5;
        label_37:
        if(1 < this.fillY)
        {
            goto label_45;
        }
        
        label_74:
        val_61 = 4;
        goto label_46;
        label_54:
        if(this.fillY <= val_60)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(mem[1152921509367322221] == true)
        {
                mem[1152921509367322221] = 1;
        }
        
        mem[536877811] + 16.isTrigger = true;
        if(mem[536877815] <= val_60)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        mem[536877811] + 16.sharedMaterial = mem[1152921509367322232];
        if(mem[536877815] <= val_60)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(mem[1152921509367322220] == true)
        {
                val_56 = 1;
        }
        
        mem[536877811] + 16.usedByEffector = true;
        val_61 = 5;
        label_46:
        if((val_61 - 4) < mem[536877815])
        {
            goto label_54;
        }
        
        return;
        label_20:
        if(this.fillY < (1.401298E-45f))
        {
            goto label_74;
        }
        
        var val_61 = 0;
        do
        {
            if(this.fillY <= val_61)
        {
                UnityEngine.Vector2[] val_60 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_60 = val_60 + 0;
            System.Collections.Generic.List<UnityEngine.Vector2> val_33 = val_60.LegacyExpandColliderPath(aList:  (0 + 0) + 16, aAmount:  null);
            T[] val_34 = val_60.ToArray();
            this.SetPath(index:  0, points:  val_60);
            val_61 = val_61 + 1;
        }
        while(val_61 < this.fillY);
        
        goto label_74;
        label_21:
        if((this.fillY < (1.401298E-45f)) || ((this.fillY + 16 + 12) < 1))
        {
            goto label_74;
        }
        
        if(this.fillY == 0f)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        T[] val_35 = 2621443.ToArray();
        val_62 = 0;
        val_63 = 2621443;
        goto label_67;
        label_27:
        float val_36 = width;
        float val_37 = yMax;
        float val_38 = height;
        val_56 = val_56 - 465495800;
        mem[536882601] = val_56;
        mem[536882605] = 465495800 + 465495800;
        float val_40 = xMax;
        uint val_62 = 465495800;
        float val_41 = width;
        float val_42 = yMax;
        float val_43 = height;
        val_62 = val_62 + 465495800;
        mem[536882609] = val_62;
        mem[536882613] = 465495800 + 465495800;
        float val_45 = xMax;
        uint val_63 = 465495800;
        float val_46 = width;
        float val_47 = yMin;
        float val_48 = height;
        val_63 = val_63 + 465495800;
        mem[536882617] = val_63;
        mem[536882621] = 465495800 - 465495800;
        float val_50 = xMin;
        float val_51 = width;
        float val_52 = yMin;
        float val_53 = height;
        val_58 = 465495800 - 465495800;
        val_59 = 465495800 - 465495800;
        label_32:
        mem[536882625] = val_58;
        mem[536882629] = val_59;
        val_62 = 1;
        val_63 = 536882585;
        label_67:
        this.SetPath(index:  1, points:  536882585);
        goto label_74;
    }
    private System.Collections.Generic.List<UnityEngine.Vector2> LegacyExpandColliderPath(System.Collections.Generic.List<UnityEngine.Vector2> aList, float aAmount)
    {
        var val_4;
        bool val_1 = true - 1;
        if(val_1 < 0)
        {
                return;
        }
        
        var val_2 = 8 + 8;
        do
        {
            UnityEngine.Vector2 val_3 = Ferr2D_Path.GetNormal(aSegment:  465616000, i:  aList, aClosed:  val_1);
            R2 = val_4;
            if( <= val_1)
        {
                float val_6 = 0f;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_6 = val_6 + val_2;
            aList.Add(item:  new UnityEngine.Vector2() {x = val_6, y = (0 + (8 + 8)) + 4});
            val_1 = val_1 - 1;
            val_2 = val_2 - 8;
        }
        while(val_1 > 1);
    
    }
    public System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> LegacyGetColliderVerts()
    {
        var val_30;
        System.Collections.Generic.List<Page> val_31;
        var val_32;
        System.Collections.Generic.List<CutOverrides> val_33;
        Ferr2DT_PathTerrain val_34;
        Ferr2DT_PathTerrain val_35;
        System.Collections.Generic.List<UnityEngine.Vector2> val_36;
        var val_37;
        Ferr2DT_PathTerrain val_38;
        IFerr2DTMaterial val_1 = this.TerrainMaterial;
        if(this != 0)
        {
                Ferr2D_Path val_2 = this.Path;
            System.Collections.Generic.List<UnityEngine.Vector2> val_3 = this.GetVertsRaw();
            Ferr2DT_FillMode val_31 = this.fill;
            val_31 = val_31 | 4;
            if(val_31 == 5)
        {
                float val_32 = this.fillY;
            if(val_32 >= (1.401298E-45f))
        {
                val_32 = (R7 + 16) + (val_32 << 3);
            this.Add(item:  new UnityEngine.Vector2() {x = (R7 + 16 + (this.fillY) << 3) + -8, y = this.fillY});
            this.Add(item:  new UnityEngine.Vector2() {x = R7 + 16, y = this.fillY});
            this.Add(item:  new UnityEngine.Vector2() {x = R7 + 16, y = R7 + 16 + 4});
        }
        
        }
        
            IFerr2DTMaterial val_4 = this.TerrainMaterial;
            IFerr2DTMaterial val_5 = this.TerrainMaterial;
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_30 = this;
        }
        else
        {
                val_31 = 536877671;
            val_31 = new System.Collections.Generic.List<Page>();
            return;
        }
        
        var val_34 = 0;
        val_34 = val_34 + 1;
        val_32 = this;
        float val_10 = width;
        IFerr2DTMaterial val_11 = this.TerrainMaterial;
        Ferr2DT_PathTerrain val_36 = this;
        if(this.createCollider == false)
        {
            goto label_18;
        }
        
        var val_35 = 0;
        label_20:
        if((this.fillSplitDistance + 0) == 536888251)
        {
            goto label_19;
        }
        
        val_35 = val_35 + 1;
        if(((uint)val_35 & 65535) < this.createCollider)
        {
            goto label_20;
        }
        
        label_18:
        val_33 = this;
        goto label_21;
        label_19:
        float val_12 = this.fillSplitDistance + 0;
        val_36 = val_36 + (((this.fillSplitDistance + 0) + 4) << 3);
        val_33 = (this + ((this.fillSplitDistance + 0) + 4) << 3).cutOverrides;
        label_21:
        uint val_38 = 465740272;
        UnityEngine.Texture val_13 = this.mainTexture;
        536877873 = new System.Collections.Generic.List<UnityEngine.RuntimePlatform>();
        536877671 = new System.Collections.Generic.List<Page>();
        val_34 = this;
        System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> val_18 = this.GetSegments(aPath:  465752336, aSegDirections: out  System.Collections.Generic.List<Ferr2DT_TerrainDirection> val_17 = 465740268);
        val_35 = this;
        val_36 = 536878507;
        val_36 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        val_37 = 4;
        val_31 = 536877671;
        float val_37 = 4.657523E+08f;
        val_38 = this;
        val_37 = val_37 / mem[1152921509367566640];
        val_37 = val_38 * val_37;
        val_37 = val_37 / ((float)UnityEngine.Mathf.Max(a:  1, b:  mem[1152921509367566776]));
        val_38 = mem[1152921509367566780] * val_37;
        goto label_24;
        label_51:
        val_36 = 536877873;
        if(mem[536877885] <= 536877671)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((mem[536877881] + 16) == 3)
        {
                mem[536877881] + 16 = mem[1152921509367566815];
        }
        
        if((mem[536877881] + 16) == false)
        {
            goto label_36;
        }
        
        val_36 = 536877873;
        if(mem[536877885] <= 536877671)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((mem[536877881] + 16) == 1)
        {
                mem[536877881] + 16 = mem[1152921509367566812];
        }
        
        if((mem[536877881] + 16) == false)
        {
            goto label_36;
        }
        
        val_36 = 536877873;
        if(mem[536877885] <= 536877671)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((mem[536877881] + 16) == 0)
        {
                mem[536877881] + 16 = mem[1152921509367566814];
        }
        
        if((mem[536877881] + 16) == false)
        {
            goto label_36;
        }
        
        val_36 = 536877873;
        if(mem[536877885] <= 536877671)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((mem[536877881] + 16) == 2)
        {
                mem[536877881] + 16 = mem[1152921509367566813];
        }
        
        if((mem[536877881] + 16) == false)
        {
            goto label_36;
        }
        
        System.Collections.Generic.List<System.Single> val_21 = 0;
        if(val_32 <= (1.085076E-19f))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        Ferr2D_Path.IndicesToPath(aPath:  465752336, aScales:  mem[1152921509367566824], aIndices:  mem[1152921509367566616] + 16, aNewPath: out  System.Collections.Generic.List<UnityEngine.Vector2> val_20 = 465740264, aNewScales: out  val_21);
        if((mem[1152921509367566772] != false) && (0 >= 3))
        {
                Ferr2D_Path.SmoothSegment(aSegment:  0, aScales:  0, aSplitDistance:  val_37, aClosed:  val_38, aNewSegment: out  System.Collections.Generic.List<UnityEngine.Vector2> val_22 = 0, aNewScales: out  0);
        }
        
        val_36 = val_21;
        if(0 <= 536877671)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.Collections.Generic.List<UnityEngine.Vector2> val_24 = this.LegacyOffsetColliderVerts(aSegment:  0, aSegmentScales:  0, aDir:  2621443);
        val_31 = 536877671;
        val_38 = this;
        val_34 = this;
        val_35 = val_35;
        if((mem[536878519] >= 1) && (mem[1152921509367566788] != false))
        {
                this.LegacyMergeCorner(aPrevList: ref  System.Collections.Generic.List<UnityEngine.Vector2> val_25 = 465740264, aNextList: ref  System.Collections.Generic.List<UnityEngine.Vector2> val_26 = 465740264);
        }
        
        val_36.AddRange(collection:  465752336);
        goto label_48;
        label_36:
        val_35 = val_35;
        if(mem[536878519] >= 1)
        {
                val_36 = 536878507;
            val_36 = new System.Collections.Generic.List<UnityEngine.Vector2>(collection:  536878507);
            val_31.Add(item:  536878507);
            val_36.Clear();
            val_35 = val_35;
        }
        
        label_48:
        val_37 = 5;
        label_24:
        if((val_37 - 4) < val_32)
        {
            goto label_51;
        }
        
        if(mem[1152921509367566788] != false)
        {
                this.LegacyMergeCorner(aPrevList: ref  System.Collections.Generic.List<UnityEngine.Vector2> val_29 = 465740264, aNextList: ref  System.Collections.Generic.List<UnityEngine.Vector2> val_30 = 465740264);
        }
        
        if(mem[536878519] < 1)
        {
                return;
        }
        
        val_31.Add(item:  536878507);
    }
    private System.Collections.Generic.List<UnityEngine.Vector2> LegacyOffsetColliderVerts(System.Collections.Generic.List<UnityEngine.Vector2> aSegment, System.Collections.Generic.List<float> aSegmentScales, Ferr2DT_TerrainDirection aDir)
    {
        float val_6;
        float val_7;
        float val_17;
        float val_18;
        Ferr2DT_PathTerrain val_19;
        var val_20;
        bool val_21;
        System.Collections.Generic.List<UnityEngine.Vector2> val_1 = 536878507;
        val_1 = new System.Collections.Generic.List<UnityEngine.Vector2>(collection:  aSegment);
        System.Collections.Generic.List<UnityEngine.Vector2> val_2 = val_1 - 1;
        if(val_2 < 0)
        {
            goto label_2;
        }
        
        var val_17 = 12;
        val_17 = val_17 + (val_1 << 2);
        if(mem[1152921509367699252] != false)
        {
                UnityEngine.Vector2 val_4 = Ferr2D_Path.HermiteGetNormal(aSegment:  465872768, i:  aSegment, aPercentage:  null, aClosed:  val_2, aTension:  null, aBias:  null);
        }
        else
        {
                UnityEngine.Vector2 val_5 = Ferr2D_Path.GetNormal(aSegment:  465872768, i:  aSegment, aClosed:  val_2);
        }
        
        UnityEngine.Vector2 val_8 = Ferr2D_Path.GetSegmentNormal(i:  465872768, aPath:  val_2, aClosed:  aSegment);
        val_17 = 1f;
        if(val_2 < 465872768)
        {
                if(465872768 <= val_2)
        {
                var val_18 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_18 = val_18 + val_17;
            val_17 = mem[(0 + (12 + (536878507..ctor(collection:  aSegment)) << 2))];
            val_17 = val_18;
        }
        
        val_18 = 1f;
        val_19 = this;
        if(mem[1152921509367699252] != true)
        {
                val_7 = -val_7;
            val_6 = -val_6;
            float val_9 = val_6.sqrMagnitude;
            float val_10 = val_6.sqrMagnitude;
            if(mem[536890411] >= _TYPE_MAX_)
        {
                float val_20 = 465872768 * 465872760;
        }
        
            val_20 = 0;
            if(mem[536890411] >= 0)
        {
                float val_19 = val_7;
            val_19 = val_7 * val_19;
            val_20 = val_19 / val_20;
            float val_12 = UnityEngine.Mathf.Clamp(value:  val_20, min:  val_8.y, max:  val_6);
            val_21 = mem[536890482];
            if((val_21 & true) == 0)
        {
                val_21 = mem[536890411];
        }
        
            val_20 = val_12 * 57.29578f;
        }
        
            val_12 = val_20 * 0.01745329f;
            var val_21 = val_12;
            val_21 = val_21 & (~2147483648);
            val_19 = this;
            val_18 = 1f / val_21;
        }
        
        val_17 = val_17 * val_18;
        if(mem[1152921509367699248] != 2)
        {
            goto label_16;
        }
        
        if((aSegment + 12) <= val_2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_22 = mem[1152921509367699280] + 16;
        float val_13 = (mem[1152921509367699280] + 16) * val_6;
        val_22 = val_22 * val_7;
        if(val_1 == 0)
        {
            goto label_23;
        }
        
        val_1.Add(item:  new UnityEngine.Vector2() {x = aSegment + 8 + (8 + (536878507..ctor(collection:  aSegment)) << 3), y = aSegment + 8 + (8 + (536878507..ctor(collection:  aSegment)) << 3) + 4});
        goto label_24;
        label_16:
        var val_14 = mem[1152921509367699280] + (aDir << 2);
        if(mem[536878519] <= val_2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        float val_15 = val_6 * ((mem[1152921509367699280] + (aDir) << 2) + 16);
        float val_23 = mem[536878515];
        float val_16 = val_7 * ((mem[1152921509367699280] + (aDir) << 2) + 16);
        val_23 = val_23 + (8 + (val_1 << 3));
        val_1.set_Item(index:  val_2, value:  new UnityEngine.Vector2() {x = val_23, y = (mem[536878515] + (8 + (536878507..ctor(collection:  aSegment)) << 3)) + 4});
        goto label_29;
    }
    private void LegacyMergeCorner(ref System.Collections.Generic.List<UnityEngine.Vector2> aPrevList, ref System.Collections.Generic.List<UnityEngine.Vector2> aNextList)
    {
        float val_2;
        float val_3;
        int val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        float val_12;
        float val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        float val_21;
        float val_22;
        val_7 = this;
        if((mem[aNextList + 12]) < 2)
        {
                return;
        }
        
        if((mem[aPrevList + 12]) < 2)
        {
                return;
        }
        
        if(aPrevList != 0)
        {
                val_8 = mem[aPrevList + 12];
            val_9 = val_8;
        }
        else
        {
                val_9 = 0;
            val_8 = 0;
        }
        
        if(val_8 <= (-2))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = mem[aPrevList + 8];
        val_7 = val_7 + 4294967280;
        if(aPrevList != 0)
        {
                val_10 = mem[aPrevList + 12];
            val_11 = val_10;
        }
        else
        {
                val_11 = 0;
            val_10 = 0;
        }
        
        if(val_10 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_8 = mem[aPrevList + 8];
        val_8 = val_8 + 4294967288;
        if((mem[aNextList + 12]) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((mem[aNextList + 12]) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Vector2 val_1 = Ferr2D_Path.LineIntersectionPoint(ps1:  new UnityEngine.Vector2() {x = 3.286769E-22f, y = (mem[aPrevList + 8] + 4294967280) + 16}, pe1:  new UnityEngine.Vector2() {x = (mem[aPrevList + 8] + 4294967280) + 20, y = (mem[aPrevList + 8] + 4294967288) + 16}, ps2:  new UnityEngine.Vector2() {x = ???, y = mem[aNextList + 8] + 16}, pe2:  new UnityEngine.Vector2() {x = aPrevList, y = mem[aNextList + 8] + 24});
        val_12 = val_2;
        val_13 = val_3;
        if(aPrevList != 0)
        {
                val_14 = mem[aPrevList + 12];
            val_15 = val_14;
        }
        else
        {
                val_15 = 0;
            val_14 = 0;
        }
        
        if(val_14 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_9 = mem[aPrevList + 8];
        val_9 = val_9 + 4294967288;
        float val_10 = (mem[aPrevList + 8] + 4294967288) + 16;
        float val_11 = (mem[aPrevList + 8] + 4294967288) + 20;
        val_10 = val_12 - val_10;
        val_11 = val_13 - val_11;
        float val_4 = val_10.sqrMagnitude;
        if((mem[aNextList + 12]) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        float val_12 = mem[aNextList + 8] + 16;
        float val_13 = mem[aNextList + 8] + 20;
        val_12 = val_12 - val_12;
        val_13 = val_13 - val_13;
        float val_5 = val_12.sqrMagnitude;
        float val_6 = this.sharpCornerDistance * this.sharpCornerDistance;
        if(aPrevList != 0)
        {
                val_16 = aPrevList;
            val_17 = mem[aPrevList + 12];
        }
        else
        {
                val_16 = 12;
            val_17 = 0;
        }
        
        val_7 = val_17 - 1;
        if(aPrevList <= 0)
        {
            goto label_22;
        }
        
        if(val_16 <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_14 = mem[aPrevList + 8];
        val_14 = val_14 + (val_7 << 3);
        float val_15 = (mem[aPrevList + 8] + ((val_17 - 1)) << 3) + 16;
        float val_16 = (mem[aPrevList + 8] + ((val_17 - 1)) << 3) + 20;
        val_15 = val_12 - val_15;
        val_16 = val_13 - val_16;
        val_15.Normalize();
        if(aPrevList == 0)
        {
            goto label_24;
        }
        
        val_18 = mem[aPrevList + 12];
        val_19 = val_18;
        goto label_25;
        label_22:
        aPrevList.set_Item(index:  val_7, value:  new UnityEngine.Vector2() {x = val_12, y = val_13});
        goto label_26;
        label_24:
        val_19 = 0;
        val_18 = 0;
        label_25:
        val_16 = -1;
        if(val_18 <= val_16)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_17 = mem[aPrevList + 8];
        val_17 = val_17 + 4294967288;
        val_7 = (mem[aPrevList + 8] + 4294967288) + 20;
        aPrevList.set_Item(index:  -1, value:  new UnityEngine.Vector2() {x = (mem[aPrevList + 8] + 4294967288) + 16, y = val_7});
        val_12 = val_12;
        val_13 = val_13;
        label_26:
        if(aNextList > 0)
        {
                if((mem[aNextList + 12]) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            float val_18 = mem[aNextList + 8] + 16;
            float val_19 = mem[aNextList + 8] + 20;
            val_18 = val_12 - val_18;
            val_19 = val_13 - val_19;
            val_18.Normalize();
            if((mem[aNextList + 12]) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_20 = 0;
            val_21 = mem[aNextList + 8] + 16;
            val_22 = mem[aNextList + 8] + 20;
        }
        else
        {
                val_20 = 0;
            val_21 = val_12;
            val_22 = val_13;
        }
        
        aNextList.set_Item(index:  0, value:  new UnityEngine.Vector2() {x = val_21, y = val_22});
    }
    public void MatchOverrides()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        if(this.directionOverrides == 0)
        {
                536877873 = new System.Collections.Generic.List<UnityEngine.RuntimePlatform>();
            this.directionOverrides = 536877873;
        }
        
        if(this.vertScales == 0)
        {
                536878291 = new System.Collections.Generic.List<System.Single>();
            this.vertScales = 536878291;
        }
        
        if(this.cutOverrides == 0)
        {
                536878613 = new System.Collections.Generic.List<Page>();
            mem2[0] = 536878613;
        }
        
        Ferr2D_Path val_4 = this.Path;
        if(this.directionOverrides != 0)
        {
            goto label_5;
        }
        
        goto label_5;
        label_9:
        this.directionOverrides.Add(item:  100);
        val_10 = 1152921509367967825;
        label_5:
        if(val_10 < (this.fillZ + 12))
        {
            goto label_9;
        }
        
        val_11 = mem[this.cutOverrides + 12];
        val_11 = this.cutOverrides + 12;
        goto label_11;
        label_14:
        536898987 = new Ferr2DT_PathTerrain.CutOverrides();
        this.cutOverrides.Add(item:  536898987);
        val_11 = val_11 + 1;
        label_11:
        if(val_11 < (this.fillZ + 12))
        {
            goto label_14;
        }
        
        val_12 = mem[this.vertScales + 12];
        val_12 = this.vertScales + 12;
        goto label_16;
        label_19:
        this.vertScales.Add(item:  null);
        val_12 = val_12 + 1;
        label_16:
        if(val_12 < (this.fillZ + 12))
        {
            goto label_19;
        }
        
        if(mem[536877885] <= (this.fillZ + 12))
        {
                return;
        }
        
        if((this.fillZ + 12) < 1)
        {
                return;
        }
        
        int val_6 = mem[536877885] - (this.fillZ + 12);
        if(this.directionOverrides != 0)
        {
                val_13 = mem[536877885];
        }
        else
        {
                val_13 = 0;
        }
        
        this.directionOverrides.RemoveRange(index:  val_13 + (~val_6), count:  val_6);
        if(this.vertScales != 0)
        {
                val_14 = mem[this.vertScales + 12];
            val_14 = this.vertScales + 12;
        }
        else
        {
                val_14 = 0;
        }
        
        this.vertScales.RemoveRange(index:  val_14 + (~val_6), count:  val_6);
        if(this.cutOverrides != 0)
        {
                val_15 = mem[this.cutOverrides + 12];
            val_15 = this.cutOverrides + 12;
        }
        else
        {
                val_15 = 0;
        }
        
        this.cutOverrides.RemoveRange(index:  val_15 + (~val_6), count:  val_6);
    }
    public void ForceMaterial(IFerr2DTMaterial aMaterial, bool aForceUpdate, bool aRecreate = True)
    {
        bool val_14;
        var val_15;
        var val_16;
        var val_17;
        UnityEngine.Object val_18;
        float val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        IFerr2DTMaterial val_24;
        var val_25;
        val_14 = aRecreate;
        val_15 = this;
        val_16 = 536891221;
        if(((mem[536891408] & true) == 0) && (mem[536891337] == 0))
        {
                val_16 = 536891221;
        }
        
        val_17 = 0;
        if(aMaterial != 0)
        {
                val_17 = aMaterial;
            val_17 = 0;
        }
        
        val_18 = 0;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.terrainMaterialInterface, y:  0);
        if(aForceUpdate == false)
        {
                return;
        }
        
        if(aMaterial != 0)
        {
                val_18 = aMaterial;
            val_18 = 0;
        }
        
        this.terrainMaterialInterface = val_18;
        if(this.fill > 5)
        {
            goto label_10;
        }
        
        if((11 & (1 << this.fill)) != 0)
        {
            goto label_11;
        }
        
        val_20 = 536882161;
        val_19 = 4.014226E-38f;
        var val_14 = 0;
        val_18 = 0;
        val_14 = val_14 + 1;
        val_18 = (uint)val_14 & 65535;
        val_21 = aMaterial;
        goto label_16;
        label_11:
        if((48 & (1 << this.fill)) != 0)
        {
            goto label_17;
        }
        
        val_20 = 536882161;
        val_18 = 0;
        val_18 = val_18 + 1;
        val_22 = aMaterial;
        goto label_43;
        label_10:
        val_20 = 0;
        goto label_23;
        label_17:
        val_20 = 536882161;
        val_18 = 0;
        val_18 = val_18 + 1;
        val_22 = aMaterial;
        goto label_43;
        label_16:
        mem[536882177] = aMaterial;
        val_18 = 0;
        val_18 = val_18 + 1;
        val_23 = aMaterial;
        val_24 = aMaterial;
        mem[536882181] = val_24;
        goto label_42;
        label_43:
        val_24 = aMaterial;
        mem[536882177] = val_24;
        label_42:
        label_23:
        UnityEngine.Transform val_6 = this.GetComponent<UnityEngine.Transform>();
        this.sharedMaterials = 536882161;
        IFerr2DTMaterial val_7 = this.TerrainMaterial;
        val_14 = val_14;
        val_18 = 0;
        val_18 = val_18 + 1;
        val_25 = this;
        val_15 = this;
        if(466294224 != 0)
        {
                UnityEngine.Texture val_10 = this.mainTexture;
            if(466294224 != 0)
        {
                UnityEngine.Texture val_12 = this.mainTexture;
            float val_15 = 4.662942E+08f;
            val_15 = val_15 / this.pixelsPerUnit;
            this.unitsPerUV = val_15;
            UnityEngine.Texture val_13 = this.mainTexture;
            float val_16 = 4.662942E+08f;
            val_16 = val_16 / this.pixelsPerUnit;
            mem[1152921509368108648] = val_16;
        }
        
        }
        
        if(val_14 == false)
        {
                return;
        }
        
        this.Build(aFullBuild:  true);
    }
    public Ferr2DT_SegmentDescription GetDescription(System.Collections.Generic.List<UnityEngine.Vector2> aSegment)
    {
        var val_5;
        var val_6;
        val_5 = 22968995;
        Ferr2DT_FillMode val_5 = this.fill;
        val_5 = val_5 - 3;
        Ferr2DT_TerrainDirection val_2 = Ferr2D_Path.GetDirection(aSegment:  aSegment, i:  0, aInvert:  val_5 >> 5, aClosed:  false, aOverrides:  0);
        IFerr2DTMaterial val_3 = this.TerrainMaterial;
        var val_6 = 0;
        val_5 = 0;
        val_6 = val_6 + 1;
        val_5 = (uint)val_6 & 65535;
        val_6 = this;
        goto mem[(1152921504871489536 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
    }
    public Ferr2DT_SegmentDescription GetDescription(System.Collections.Generic.List<int> aSegment)
    {
        var val_6;
        var val_7;
        Ferr2D_Path val_1 = this.Path;
        val_6 = this;
        Ferr2DT_FillMode val_6 = this.fill;
        val_6 = val_6 - 3;
        Ferr2DT_TerrainDirection val_3 = Ferr2D_Path.GetDirection(aPath:  this.fillZ, aSegment:  aSegment, i:  0, aInvert:  val_6 >> 5, aClosed:  false, aOverrides:  0);
        IFerr2DTMaterial val_4 = this.TerrainMaterial;
        val_6 = 0;
        val_6 = val_6 + 1;
        val_7 = this;
        goto mem[(1152921504871489536 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
    }
    public System.Collections.Generic.List<System.Collections.Generic.List<int>> GetSegments(System.Collections.Generic.List<UnityEngine.Vector2> aPath, out System.Collections.Generic.List<Ferr2DT_TerrainDirection> aSegDirections)
    {
        System.Collections.Generic.List<UnityEngine.Vector2> val_13;
        Ferr2DT_FillMode val_14;
        var val_15;
        var val_16;
        var val_17;
        val_13 = aPath;
        536877657 = new System.Collections.Generic.List<Page>();
        if(this.splitCorners == false)
        {
            goto label_1;
        }
        
        val_14 = this.fill;
        UnityEngine.Transform val_2 = this.GetComponent<UnityEngine.Transform>();
        System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> val_6 = Ferr2D_Path.GetSegments(aPath:  val_13, aSegDirections: out  System.Collections.Generic.List<Ferr2DT_TerrainDirection> val_5 = 466735872, aOverrides:  this.directionOverrides, aInvert:  (val_14 - 3) >> 5, aClosed:  this.fillY);
        goto label_3;
        label_1:
        536877873 = new System.Collections.Generic.List<UnityEngine.RuntimePlatform>();
        aSegDirections = 536877873;
        val_15 = 0;
        aSegDirections.Add(item:  0);
        536877987 = new System.Collections.Generic.List<System.Int32>();
        val_14 = 22737108;
        goto label_5;
        label_8:
        536877987.Add(item:  0);
        val_15 = 1;
        label_5:
        if(val_15 < 536877987)
        {
            goto label_8;
        }
        
        536877657.Add(item:  536877987);
        label_3:
        Ferr2D_Path val_9 = this.Path;
        if(this.fillY == 0f)
        {
                return;
        }
        
        Ferr2DT_FillMode val_14 = this.fill;
        val_14 = val_14 - 3;
        val_14 = val_14 >> 5;
        bool val_12 = Ferr2D_Path.CloseEnds(aPath:  val_13, aSegmentList: ref  System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> val_10 = 466687736, aSegmentDirections: ref  System.Collections.Generic.List<Ferr2DT_TerrainDirection> val_11 = 466735872, aCorners:  this.splitCorners, aInverted:  val_14);
        if(val_13 != 0)
        {
                val_16 = mem[aPath + 12];
            val_16 = aPath + 12;
            val_17 = val_16;
        }
        else
        {
                val_14 = 12;
            val_17 = 0;
            val_16 = 0;
        }
        
        val_13 = -1;
        if(val_16 <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_15 = aPath + 8;
        val_15 = val_15 + 4294967292;
        if(((aPath + 8 + 4294967292) + 16 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(((aPath + 8 + 4294967292) + 16 + 8) <= ((aPath + 8 + 4294967292) + 16 + 8 + 16))
        {
                var val_16 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_16 = val_16 + (((aPath + 8 + 4294967292) + 16 + 8 + 16) << 2);
        if(((0 + ((aPath + 8 + 4294967292) + 16 + 8 + 16) << 2) + 16) == 100)
        {
                return;
        }
        
        if(aSegDirections != 0)
        {
                val_13 = mem[536877885];
        }
        else
        {
                val_13 = 0;
        }
        
        aSegDirections.set_Item(index:  val_13 - 1, value:  (0 + ((aPath + 8 + 4294967292) + 16 + 8 + 16) << 2) + 16);
    }
    private System.Collections.Generic.List<UnityEngine.Vector2> GetSegmentsCombined(float aSplitDist)
    {
        var val_10;
        System.Collections.Generic.List<T> val_11;
        Ferr2D_Path val_1 = this.Path;
        536877873 = new System.Collections.Generic.List<UnityEngine.RuntimePlatform>();
        536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        System.Collections.Generic.List<UnityEngine.Vector2> val_4 = this.GetVertsRaw();
        System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> val_6 = this.GetSegments(aPath:  466836272, aSegDirections: out  System.Collections.Generic.List<Ferr2DT_TerrainDirection> val_5 = 466824232);
        val_10 = 4;
        goto label_2;
        label_14:
        if(this.smoothPath != false)
        {
                if(this <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        }
        
        if(this.fillY <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_11 = this.fillZ;
        System.Collections.Generic.List<T> val_7 = Ferr2D_Path.IndicesToList<UnityEngine.Vector2>(aData:  val_11, aIndices:  2621443);
        536878507.AddRange(collection:  null);
        val_10 = 5;
        label_2:
        if(1 < this.fillY)
        {
            goto label_14;
        }
    
    }
    public Ferr2DT_PathTerrain()
    {
        this.fillZ = 0.05f;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.invertFillBorder = new UnityEngine.Vector2();
        mem[1152921509368762568] = ???;
        this.splitCorners = true;
        this.pixelsPerUnit = 64f;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.vertexGradientAngle = 90f;
        this.vertexGradientDistance = 4f;
        this.fillSplitDistance = 4f;
        this.depth = 4f;
        this.colliderMode = true;
        Ferr2DPath val_3 = 536886753;
        val_3 = new Ferr2DPath();
        this.pathData = val_3;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        this.unitsPerUV = new UnityEngine.Vector2();
        mem[1152921509368762696] = ???;
        this.splitCount = 4;
        this.splitDist = 1f;
        this.splitMiddle = true;
        this.createCollider = true;
        this.sharpCornerDistance = 2f;
        this.surfaceOffset = 536882357;
        this.colliderThickness = 0.1f;
        this.collidersLeft = true;
        this.collidersRight = true;
        this.collidersTop = true;
        this.collidersBottom = true;
    }
    private int <AddEdge>b__66_1(Ferr2DT_PathTerrain.EdgeSegment a, Ferr2DT_PathTerrain.EdgeSegment b)
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = b;
        IFerr2DTMaterial val_1 = this.TerrainMaterial;
        var val_6 = 0;
        val_6 = val_6 + 1;
        val_7 = this;
        val_8 = this;
        IFerr2DTMaterial val_3 = this.TerrainMaterial;
        val_6 = 0;
        val_8 = 0;
        val_6 = val_6 + 1;
        val_8 = (uint)val_6 & 65535;
        val_9 = this;
        return (int)this.fillY.CompareTo(value:  null);
    }

}
