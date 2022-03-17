using UnityEngine;

namespace Vectrosity
{
    [Serializable]
    public class VectorLine
    {
        // Fields
        private UnityEngine.Vector3[] m_lineVertices;
        private UnityEngine.Vector2[] m_lineUVs;
        private UnityEngine.Color32[] m_lineColors;
        private System.Collections.Generic.List<int> m_lineTriangles;
        private int m_vertexCount;
        private UnityEngine.GameObject m_go;
        private UnityEngine.RectTransform m_rectTransform;
        private Vectrosity.IVectorObject m_vectorObject;
        private UnityEngine.Color32 m_color;
        private Vectrosity.CanvasState m_canvasState;
        private bool m_is2D;
        private System.Collections.Generic.List<UnityEngine.Vector2> m_points2;
        private System.Collections.Generic.List<UnityEngine.Vector3> m_points3;
        private int m_pointsCount;
        private UnityEngine.Vector3[] m_screenPoints;
        private float[] m_lineWidths;
        private float m_lineWidth;
        private float m_maxWeldDistance;
        private float[] m_distances;
        private string m_name;
        private UnityEngine.Material m_material;
        private UnityEngine.Texture m_originalTexture;
        private UnityEngine.Texture m_texture;
        private bool m_active;
        private Vectrosity.LineType m_lineType;
        private float m_capLength;
        private bool m_smoothWidth;
        private bool m_smoothColor;
        private Vectrosity.Joins m_joins;
        private bool m_isAutoDrawing;
        private int m_drawStart;
        private int m_drawEnd;
        private int m_endPointsUpdate;
        private bool m_useNormals;
        private bool m_useTangents;
        private bool m_normalsCalculated;
        private bool m_tangentsCalculated;
        private Vectrosity.EndCap m_capType;
        private string m_endCap;
        private bool m_useCapColors;
        private UnityEngine.Color32 m_frontColor;
        private UnityEngine.Color32 m_backColor;
        private int m_frontEndCapIndex;
        private int m_backEndCapIndex;
        private float m_lineUVBottom;
        private float m_lineUVTop;
        private float m_frontCapUVBottom;
        private float m_frontCapUVTop;
        private float m_backCapUVBottom;
        private float m_backCapUVTop;
        private bool m_continuousTexture;
        private UnityEngine.Transform m_drawTransform;
        private bool m_viewportDraw;
        private float m_textureScale;
        private bool m_useTextureScale;
        private float m_textureOffset;
        private bool m_useMatrix;
        private UnityEngine.Matrix4x4 m_matrix;
        private bool m_collider;
        private bool m_trigger;
        private UnityEngine.PhysicsMaterial2D m_physicsMaterial;
        private bool m_alignOddWidthToPixels;
        private static UnityEngine.Vector3 v3zero;
        private static UnityEngine.Canvas m_canvas;
        private static UnityEngine.Transform camTransform;
        private static UnityEngine.Camera cam3D;
        private static UnityEngine.Vector3 oldPosition;
        private static UnityEngine.Vector3 oldRotation;
        private static bool lineManagerCreated;
        private static Vectrosity.LineManager m_lineManager;
        private static System.Collections.Generic.Dictionary<string, Vectrosity.CapInfo> capDictionary;
        private static int endianDiff1;
        private static int endianDiff2;
        private static byte[] byteBlock;
        private static string[] functionNames;
        
        // Properties
        public UnityEngine.Vector3[] lineVertices { get; }
        public UnityEngine.Vector2[] lineUVs { get; }
        public UnityEngine.Color32[] lineColors { get; }
        public System.Collections.Generic.List<int> lineTriangles { get; }
        public UnityEngine.RectTransform rectTransform { get; }
        public UnityEngine.Color32 color { get; set; }
        public bool is2D { get; }
        public System.Collections.Generic.List<UnityEngine.Vector2> points2 { get; set; }
        public System.Collections.Generic.List<UnityEngine.Vector3> points3 { get; set; }
        private int pointsCount { get; }
        public float lineWidth { get; set; }
        public float maxWeldDistance { get; set; }
        public string name { get; set; }
        public UnityEngine.Material material { get; set; }
        public UnityEngine.Texture texture { get; set; }
        public int layer { get; set; }
        public bool active { get; set; }
        public Vectrosity.LineType lineType { get; set; }
        public float capLength { get; set; }
        public bool smoothWidth { get; set; }
        public bool smoothColor { get; set; }
        public Vectrosity.Joins joins { get; set; }
        public bool isAutoDrawing { get; }
        public int drawStart { get; set; }
        public int drawEnd { get; set; }
        public int endPointsUpdate { get; set; }
        public string endCap { get; set; }
        public bool continuousTexture { get; set; }
        public UnityEngine.Transform drawTransform { get; set; }
        public bool useViewportCoords { get; set; }
        public float textureScale { get; set; }
        public float textureOffset { get; set; }
        public UnityEngine.Matrix4x4 matrix { get; set; }
        public int drawDepth { get; set; }
        public bool collider { get; set; }
        public bool trigger { get; set; }
        public UnityEngine.PhysicsMaterial2D physicsMaterial { get; set; }
        public bool alignOddWidthToPixels { get; set; }
        public static UnityEngine.Canvas canvas { get; }
        public static UnityEngine.Vector3 camTransformPosition { get; }
        public static bool camTransformExists { get; }
        public static Vectrosity.LineManager lineManager { get; }
        
        // Methods
        public static string Version()
        {
        
        }
        public UnityEngine.Vector3[] get_lineVertices()
        {
        
        }
        public UnityEngine.Vector2[] get_lineUVs()
        {
        
        }
        public UnityEngine.Color32[] get_lineColors()
        {
        
        }
        public System.Collections.Generic.List<int> get_lineTriangles()
        {
        
        }
        public UnityEngine.RectTransform get_rectTransform()
        {
            if(this.m_go != 0)
            {
                    0 = this.m_rectTransform;
            }
        
        }
        public UnityEngine.Color32 get_color()
        {
            return new UnityEngine.Color32() {r = this.m_color, g = this.m_color, b = this.m_color, a = this.m_color};
        }
        public void set_color(UnityEngine.Color32 value)
        {
            this.m_color = value;
            this.SetColor(color:  new UnityEngine.Color32() {r = value.r, g = value.g, b = value.b, a = value.a}, startIndex:  0, endIndex:  this.pointsCount);
        }
        public bool get_is2D()
        {
            return (bool)this.m_is2D;
        }
        public System.Collections.Generic.List<UnityEngine.Vector2> get_points2()
        {
            System.Collections.Generic.List<UnityEngine.Vector2> val_2;
            if(this.m_is2D != false)
            {
                    val_2 = this.m_points2;
                return;
            }
            
            val_2 = 0;
            string val_1 = -1610606655(-1610606655) + this.m_name + -1610612209(-1610612209);
            UnityEngine.Debug.LogError(message:  -1610606655);
        }
        public void set_points2(System.Collections.Generic.List<UnityEngine.Vector2> value)
        {
            var val_3;
            var val_4;
            val_3 = this;
            val_4 = 22978989;
            if(value != 0)
            {
                    this.m_points2 = value;
            }
            
            string val_1 = -1610606631(-1610606631) + R4 + 84(R4 + 84) + -1610612215(-1610612215);
            UnityEngine.Debug.LogError(message:  -1610606631);
        }
        public System.Collections.Generic.List<UnityEngine.Vector3> get_points3()
        {
            System.Collections.Generic.List<UnityEngine.Vector3> val_2;
            if(this.m_is2D != false)
            {
                    val_2 = 0;
                string val_1 = -1610606655(-1610606655) + this.m_name + -1610612211(-1610612211);
                UnityEngine.Debug.LogError(message:  -1610606655);
                return;
            }
            
            val_2 = this.m_points3;
        }
        public void set_points3(System.Collections.Generic.List<UnityEngine.Vector3> value)
        {
            var val_3;
            var val_4;
            val_3 = this;
            val_4 = 22978991;
            if(value != 0)
            {
                    this.m_points3 = value;
            }
            
            string val_1 = -1610606631(-1610606631) + R4 + 84(R4 + 84) + -1610612215(-1610612215);
            UnityEngine.Debug.LogError(message:  -1610606631);
        }
        private int get_pointsCount()
        {
            if(this.m_is2D == true)
            {
                    this = this.m_points2;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector2> val_1 = this + 12;
            return (int)null;
        }
        public float get_lineWidth()
        {
            return (float)S0;
        }
        public void set_lineWidth(float value)
        {
            var val_3;
            var val_4;
            this.m_lineWidth = ;
            val_3 = 0;
            val_4 = 16;
            goto label_0;
            label_4:
            val_4 = 20;
            val_3 = 1;
            mem2[0] = R1 * 0.5f;
            label_0:
            if(val_3 < this.m_lineWidths[val_4])
            {
                goto label_4;
            }
            
            float val_2 = R1 + R1;
            val_2 = val_2 * val_2;
            this.m_maxWeldDistance = val_2;
        }
        public float get_maxWeldDistance()
        {
            if(<_TYPE_MAX_)
            {
                    this = S2;
                return (float)this.m_maxWeldDistance;
            }
        
        }
        public void set_maxWeldDistance(float value)
        {
            float val_1 = R1;
            val_1 = val_1 * val_1;
            this.m_maxWeldDistance = val_1;
        }
        public string get_name()
        {
        
        }
        public void set_name(string value)
        {
            UnityEngine.GameObject val_3;
            var val_4;
            this.m_name = value;
            val_3 = this.m_go;
            if(val_3 != 0)
            {
                    val_3 = this.m_go;
                val_3.name = value;
            }
            
            if(this.m_vectorObject == 0)
            {
                    return;
            }
            
            val_3 = 0;
            val_3 = val_3 + 1;
            val_4 = this.m_vectorObject;
            goto mem[(1152921504869146624 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public UnityEngine.Material get_material()
        {
        
        }
        public void set_material(UnityEngine.Material value)
        {
            var val_1;
            if(this.m_vectorObject != 0)
            {
                    var val_1 = 0;
                val_1 = val_1 + 1;
                val_1 = this.m_vectorObject;
            }
            
            this.m_material = value;
        }
        public UnityEngine.Texture get_texture()
        {
        
        }
        public void set_texture(UnityEngine.Texture value)
        {
            var val_1;
            var val_2;
            val_1 = 22978995;
            if(this.m_capType != 4)
            {
                goto label_1;
            }
            
            if(this.m_vectorObject == 0)
            {
                goto label_2;
            }
            
            var val_1 = 0;
            val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = (uint)val_1 & 65535;
            val_2 = this.m_vectorObject;
            goto label_6;
            label_1:
            this.m_originalTexture = value;
            goto label_7;
            label_6:
            label_2:
            this.m_texture = value;
            label_7:
        }
        public int get_layer()
        {
            if(this.m_go == 0)
            {
                    return 0;
            }
            
            if(this.m_go != 0)
            {
                    return this.m_go.layer;
            }
            
            return this.m_go.layer;
        }
        public void set_layer(int value)
        {
            if(this.m_go == 0)
            {
                    return;
            }
            
            this.m_go.layer = UnityEngine.Mathf.Clamp(value:  value, min:  0, max:  31);
        }
        public bool get_active()
        {
            return (bool)this.m_active;
        }
        public void set_active(bool value)
        {
            var val_2;
            var val_3;
            val_2 = this;
            this.m_active = value;
            if(this.m_vectorObject == 0)
            {
                    return;
            }
            
            val_2 = 0;
            val_2 = val_2 + 1;
            val_3 = this.m_vectorObject;
            goto mem[(1152921504869146624 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public Vectrosity.LineType get_lineType()
        {
        
        }
        public void set_lineType(Vectrosity.LineType value)
        {
            if(this.m_lineType == value)
            {
                    return;
            }
            
            this.m_lineType = value;
            if(value != 0)
            {
                    if(value != 1)
            {
                    if(value == 2)
            {
                    this.m_lineType = 2;
                this.m_joins = this.m_lineType;
            }
            
            }
            else
            {
                    if(this.m_joins == 0)
            {
                    this.m_joins = 2;
                this.m_joins = this.m_joins;
            }
            
                this.drawStart = this.m_drawStart;
                this.drawEnd = this.m_drawEnd;
            }
            
                if(this.m_points2 != 0)
            {
                    if(this.m_points2 >= 16384)
            {
                goto label_6;
            }
            
            }
            
                if((this.m_points3 != 0) && (this.m_points3 >= 16384))
            {
                    label_6:
                this.Resize(newCount:  16383);
            }
            
            }
            
            if(this.m_collider != false)
            {
                    Weight val_1 = this.m_go.GetComponent<Weight>();
                22978999 = 22713552;
                if(this.m_go != 0)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  this.m_go);
            }
            
                this.AddColliderIfNeeded();
            }
            
            this.ResetLine();
        }
        public float get_capLength()
        {
            return (float)S0;
        }
        public void set_capLength(float value)
        {
            if(this.m_lineType == 2)
            {
                    UnityEngine.Debug.LogError(message:  -1610606639);
                return;
            }
            
            this.m_capLength = R1;
        }
        public bool get_smoothWidth()
        {
            return (bool)this.m_smoothWidth;
        }
        public void set_smoothWidth(bool value)
        {
            Vectrosity.LineType val_2 = this.m_lineType;
            val_2 = val_2 - 2;
            if()
            {
                    val_2 = 1;
            }
            
            this.m_smoothWidth = 1 & value;
        }
        public bool get_smoothColor()
        {
            return (bool)this.m_smoothColor;
        }
        public void set_smoothColor(bool value)
        {
            bool val_5;
            Vectrosity.LineType val_4 = this.m_lineType;
            val_4 = val_4 - 2;
            if()
            {
                    val_4 = 1;
            }
            
            val_5 = 1 & value;
            this.m_smoothColor = val_5;
            if(this.m_smoothColor == true)
            {
                    this.m_smoothColor = 1;
            }
            
            if(1 ^ val_5 != true)
            {
                    return;
            }
            
            int val_2 = this.GetSegmentNumber();
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                UnityEngine.Color32 val_3 = this.GetColor(index:  0);
                this.SetColor(color:  new UnityEngine.Color32() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a}, startIndex:  0, endIndex:  0);
                val_5 = 0 + 1;
            }
            while(val_2 != val_5);
        
        }
        public Vectrosity.Joins get_joins()
        {
        
        }
        public void set_joins(Vectrosity.Joins value)
        {
            if(this.m_lineType == 2)
            {
                    return;
            }
            
            if(value == 0)
            {
                    return;
            }
            
            if(value != 0)
            {
                    value = 1;
            }
            
            if(this.m_joins != 0)
            {
                    this.m_joins = 1;
            }
            
            if(1 != 1)
            {
                    this.m_joins = value;
                this.ClearTriangles();
                this.SetupTriangles(startVert:  0);
            }
            
            this.m_joins = value;
            if(value != 1)
            {
                    return;
            }
            
            if(this.m_canvasState != 2)
            {
                    if(this.m_canvasState != 1)
            {
                    return;
            }
            
                R4.Draw();
                return;
            }
            
            this.Draw3D();
        }
        public bool get_isAutoDrawing()
        {
            return (bool)this.m_isAutoDrawing;
        }
        public int get_drawStart()
        {
            return (int)this.m_drawStart;
        }
        public void set_drawStart(int value)
        {
            if(this.m_lineType == 1)
            {
                    value = value + (value & 1);
            }
            
            this.m_drawStart = UnityEngine.Mathf.Clamp(value:  value, min:  0, max:  this.pointsCount - 1);
        }
        public int get_drawEnd()
        {
            return (int)this.m_drawEnd;
        }
        public void set_drawEnd(int value)
        {
            int val_4 = value;
            if(value != 0)
            {
                    if(this.m_lineType == 1)
            {
                    this.m_lineType = 1;
                this.m_lineType = this.m_lineType & (~val_4);
                val_4 = this.m_lineType + val_4;
            }
            
            }
            
            this.m_drawEnd = UnityEngine.Mathf.Clamp(value:  val_4, min:  0, max:  this.pointsCount - 1);
        }
        public int get_endPointsUpdate()
        {
            if(this.m_lineType != 1)
            {
                    return (int)this.m_endPointsUpdate;
            }
            
            if(this.m_endPointsUpdate != 0)
            {
                    this.m_endPointsUpdate = this.m_endPointsUpdate + 1;
            }
            
            return (int)this.m_endPointsUpdate;
        }
        public void set_endPointsUpdate(int value)
        {
            if(value >= 2)
            {
                    if(this.m_lineType == 1)
            {
                    this.m_lineType = value & 1;
                this.m_lineType = value + this.m_lineType;
            }
            
            }
            
            this.m_endPointsUpdate = UnityEngine.Mathf.Max(a:  0, b:  value = this.m_lineType - 1);
        }
        public string get_endCap()
        {
        
        }
        public void set_endCap(string value)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            if(this.m_lineType != 2)
            {
                goto label_1;
            }
            
            label_25:
            UnityEngine.Debug.LogError(message:  -1610606637);
            return;
            label_1:
            if((System.String.op_Equality(a:  this.m_endCap, b:  value)) != false)
            {
                    return;
            }
            
            if(value != null)
            {
                    if((System.String.op_Equality(a:  value, b:  -1610612735)) == false)
            {
                goto label_6;
            }
            
            }
            
            this.RemoveEndCap();
            return;
            label_6:
            val_7 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_7 = 536896697;
            }
            
            val_8 = mem[mem[536896789] + 56];
            val_8 = mem[536896789] + 56;
            if(val_8 != 0)
            {
                    if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_8 = mem[mem[536896789] + 56];
                val_8 = mem[536896789] + 56;
                if(val_8 == 0)
            {
                    val_8 = 0;
            }
            
            }
            
                if((val_8.ContainsKey(key:  value)) != false)
            {
                    if(this.m_capType != 4)
            {
                    this.m_capType = this;
                this.RemoveEndCap();
            }
            
                this.m_endCap = value;
                val_9 = 536896697;
                if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_9 = 536896697;
            }
            
                UnityEngine.Purchasing.IStoreExtension val_4 = mem[536896789] + 56.Item[value];
                this.m_capType = mem[536896789] + 56 + 8;
                if((mem[536896789] + 56 + 8) == 4)
            {
                    return;
            }
            
                val_10 = 536896697;
                if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_10 = 536896697;
            }
            
                UnityEngine.Purchasing.IStoreExtension val_5 = mem[536896789] + 56.Item[value];
                this.SetupEndCap(uvHeights:  mem[536896789] + 56 + 40);
                return;
            }
            
            }
            
            string val_6 = -1610608525(-1610608525) + value + -1610612225(-1610612225);
            if(((mem[536885944] & true) != 0) || (mem[536885873] != 0))
            {
                goto label_25;
            }
            
            goto label_25;
        }
        public bool get_continuousTexture()
        {
            return (bool)this.m_continuousTexture;
        }
        public void set_continuousTexture(bool value)
        {
            this.m_continuousTexture = value;
            if(value == true)
            {
                    return;
            }
            
            this.ResetTextureScale();
        }
        public UnityEngine.Transform get_drawTransform()
        {
        
        }
        public void set_drawTransform(UnityEngine.Transform value)
        {
            this.m_drawTransform = value;
        }
        public bool get_useViewportCoords()
        {
            return (bool)this.m_viewportDraw;
        }
        public void set_useViewportCoords(bool value)
        {
            if(this.m_is2D != false)
            {
                    this.m_viewportDraw = value;
                return;
            }
            
            UnityEngine.Debug.LogError(message:  -1610606647);
        }
        public float get_textureScale()
        {
            return (float)S0;
        }
        public void set_textureScale(float value)
        {
            this.m_textureScale = ;
            this.m_useTextureScale = false;
            this.ResetTextureScale();
        }
        public float get_textureOffset()
        {
            return (float)S0;
        }
        public void set_textureOffset(float value)
        {
            this.m_textureOffset = ;
            this.SetTextureScale();
        }
        public UnityEngine.Matrix4x4 get_matrix()
        {
            var val_1 = R1 + 220;
            return new UnityEngine.Matrix4x4() {m00 = 1.475666E-25f, m10 = (R1 + 220) + (20) + (20), m20 = mem[(R1 + 220) + (20) + (20) + (0)], m30 = mem[(R1 + 220) + (20) + (20) + (4)], m03 = mem[(R1 + 220) + (20) + (20) + (16)], m13 = 1.474182E-25f, m23 = mem[(R1 + 220) + (20) + (20) + (20)]};
        }
        public void set_matrix(UnityEngine.Matrix4x4 value)
        {
            this.m_matrix = value;
            mem[1152921509274608624] = value.m10;
            mem[1152921509274608628] = value.m20;
            mem[1152921509274608632] = value.m30;
            mem[1152921509274608636] = value.m01;
            mem[1152921509274608640] = value.m11;
            mem[1152921509274608644] = value.m21;
            mem[1152921509274608660] = value.m22;
            mem[1152921509274608664] = value.m32;
            mem[1152921509274608668] = value.m03;
            mem[1152921509274608672] = value.m13;
            mem[1152921509274608676] = value.m23;
            mem[1152921509274608680] = value.m33;
            UnityEngine.Matrix4x4 val_1 = UnityEngine.Matrix4x4.identity;
            float val_2 = val_1.m32 - 80;
            mem2[0] = val_1.m32 + -96;
            float val_3 = val_1.m32 - 64;
            float val_4 = val_1.m32 - 48;
            mem2[0] = val_1.m32 + -92;
            mem2[0] = val_1.m32 + -88;
            mem2[0] = val_1.m32 + -84;
            mem2[0] = mem[(val_1.m32 - 48) + (0)];
            mem2[0] = 0;
            float val_5 = val_1.m13 + 64;
            mem2[0] = mem[(val_1.m32 - 48) + (8)];
            float val_6 = val_1.m32 - 108;
            mem2[0] = mem[(val_1.m32 - 48) + (12)];
            mem2[0] = mem[(val_1.m32 - 48) + (4)];
            float val_7 = val_1.m13 + 80;
            mem2[0] = val_1.m32 + 44;
            mem2[0] = val_1.m32 + 48;
            mem2[0] = val_1.m32 + 52;
            mem2[0] = val_1.m32 + 56;
            mem2[0] = val_1.m32 + -112;
            mem2[0] = val_1.m32 + -116;
            mem2[0] = val_1.m13 + 120;
            mem2[0] = val_1.m13 + 116;
            mem2[0] = val_1.m32 + 12;
            mem2[0] = val_1.m32 + 16;
            mem2[0] = val_1.m32 + 20;
            mem2[0] = val_1.m32 + 24;
            mem2[0] = val_1.m32 + 28;
            mem2[0] = val_1.m32 + 32;
            mem2[0] = val_1.m32 + 36;
            mem2[0] = val_1.m32 + 40;
            mem2[0] = mem[(val_1.m32 - 108) + (0)];
            float val_8 = val_1.m32 - 28;
        }
        public int get_drawDepth()
        {
            if(this.m_canvasState == 2)
            {
                    UnityEngine.Debug.LogError(message:  -1610602685);
                return 0;
            }
            
            UnityEngine.Transform val_1 = this.m_go.transform;
            if(this.m_go != 0)
            {
                    return this.m_go.GetSiblingIndex();
            }
            
            return this.m_go.GetSiblingIndex();
        }
        public void set_drawDepth(int value)
        {
            if(this.m_canvasState == 2)
            {
                    UnityEngine.Debug.LogError(message:  -1610602685);
                return;
            }
            
            UnityEngine.Transform val_1 = this.m_go.transform;
            this.m_go.SetSiblingIndex(index:  value);
        }
        public bool get_collider()
        {
            return (bool)this.m_collider;
        }
        public void set_collider(bool value)
        {
            this.m_collider = value;
            this.AddColliderIfNeeded();
            Weight val_1 = this.m_go.GetComponent<Weight>();
            this.m_go.enabled = value;
        }
        public bool get_trigger()
        {
            return (bool)this.m_trigger;
        }
        public void set_trigger(bool value)
        {
            this.m_trigger = value;
            Weight val_1 = this.m_go.GetComponent<Weight>();
            if(this.m_go == 0)
            {
                    return;
            }
            
            Weight val_3 = this.m_go.GetComponent<Weight>();
            this.m_go.isTrigger = value;
        }
        public UnityEngine.PhysicsMaterial2D get_physicsMaterial()
        {
        
        }
        public void set_physicsMaterial(UnityEngine.PhysicsMaterial2D value)
        {
            this.AddColliderIfNeeded();
            this.m_physicsMaterial = value;
            Weight val_1 = this.m_go.GetComponent<Weight>();
            this.m_go.sharedMaterial = value;
        }
        public bool get_alignOddWidthToPixels()
        {
            return (bool)this.m_alignOddWidthToPixels;
        }
        public void set_alignOddWidthToPixels(bool value)
        {
            if(value == true)
            {
                    value = 1056964608;
            }
            
            this.m_rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = 0.5f, y = 0.5f};
            this.m_alignOddWidthToPixels = value;
        }
        public static UnityEngine.Canvas get_canvas()
        {
            var val_3;
            var val_4;
            val_3 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_3 = 536896697;
            }
            
            if((mem[536896789] + 12) == 0)
            {
                    UnityEngine.GameObject val_2 = Vectrosity.VectorLine.SetupVectorCanvas();
            }
            
            val_4 = 536896697;
            if((mem[536896884] & true) != 0)
            {
                    return;
            }
            
            if(mem[536896813] != 0)
            {
                    return;
            }
            
            val_4 = 536896697;
        }
        public static UnityEngine.Vector3 get_camTransformPosition()
        {
            float val_2;
            var val_3;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    536896697 = 536896697;
            }
            
            UnityEngine.Vector3 val_1 = position;
            mem[8] = val_3;
            mem2[0] = val_2;
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        public static bool get_camTransformExists()
        {
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    536896697 = 536896697;
            }
            
            if((mem[536891408] & true) != 0)
            {
                    return UnityEngine.Object.op_Inequality(x:  mem[536896789] + 16, y:  0);
            }
            
            if(mem[536891337] != 0)
            {
                    return UnityEngine.Object.op_Inequality(x:  mem[536896789] + 16, y:  0);
            }
            
            return UnityEngine.Object.op_Inequality(x:  mem[536896789] + 16, y:  0);
        }
        public static Vectrosity.LineManager get_lineManager()
        {
            var val_4;
            var val_5;
            val_4 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_4 = 536896697;
            }
            
            val_5 = mem[536896789];
            if((mem[536896789] + 48) == 0)
            {
                    if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_5 = mem[536896789] + 48;
            }
            
                mem2[0] = 1;
                536887303 = new UnityEngine.GameObject(name:  -1610606643);
                SynchronizationContextBehavoir val_2 = 536887303.AddComponent<SynchronizationContextBehavoir>();
                mem2[0] = 536887303;
                mem[536896789] + 52.enabled = false;
                UnityEngine.Object.DontDestroyOnLoad(target:  mem[536896789] + 52);
                val_4 = 536896697;
            }
            
            if((mem[536896884] & true) != 0)
            {
                    return;
            }
            
            if(mem[536896813] != 0)
            {
                    return;
            }
            
            val_4 = 536896697;
        }
        private void AddColliderIfNeeded()
        {
            var val_7;
            var val_8;
            Weight val_1 = this.m_go.GetComponent<Weight>();
            if(this.m_go != 0)
            {
                    return;
            }
            
            if(this.m_lineType != 0)
            {
                    val_7 = 536895945;
                val_8 = 22702128;
            }
            else
            {
                    val_7 = 536895945;
                val_8 = 22701624;
            }
            
            System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073757113)});
            UnityEngine.Component val_4 = this.m_go.AddComponent(componentType:  1073757113);
            Weight val_5 = this.m_go.GetComponent<Weight>();
            if(this.m_trigger == true)
            {
                    this.m_trigger = 1;
            }
            
            this.m_go.isTrigger = true;
            Weight val_6 = this.m_go.GetComponent<Weight>();
            this.m_go.sharedMaterial = this.m_physicsMaterial;
        }
        public VectorLine(string name, System.Collections.Generic.List<UnityEngine.Vector3> points, float width)
        {
            this.m_capType = 4;
            this.m_active = true;
            this.m_frontEndCapIndex = 0;
            this.m_backEndCapIndex = 0;
            val_1 = new System.Object();
            this.m_points3 = val_1;
            this.SetupLine(lineName:  name, texture:  0, width:  width, lineType:  R3, joins:  true, use2D:  true);
        }
        public VectorLine(string name, System.Collections.Generic.List<UnityEngine.Vector3> points, UnityEngine.Texture texture, float width)
        {
            Vectrosity.LineType val_2;
            this.m_capType = 4;
            this.m_active = true;
            this.m_frontEndCapIndex = 0;
            this.m_backEndCapIndex = 0;
            val_1 = new System.Object();
            this.m_points3 = val_1;
            this.SetupLine(lineName:  name, texture:  texture, width:  width, lineType:  val_2, joins:  true, use2D:  true);
        }
        public VectorLine(string name, System.Collections.Generic.List<UnityEngine.Vector3> points, float width, Vectrosity.LineType lineType)
        {
            Vectrosity.Joins val_2;
            this.m_capType = 4;
            this.m_active = true;
            this.m_frontEndCapIndex = 0;
            this.m_backEndCapIndex = 0;
            val_1 = new System.Object();
            this.m_points3 = val_1;
            this.SetupLine(lineName:  name, texture:  0, width:  width, lineType:  lineType, joins:  val_2, use2D:  true);
        }
        public VectorLine(string name, System.Collections.Generic.List<UnityEngine.Vector3> points, UnityEngine.Texture texture, float width, Vectrosity.LineType lineType)
        {
            Vectrosity.Joins val_2;
            this.m_capType = 4;
            this.m_active = true;
            this.m_frontEndCapIndex = 0;
            this.m_backEndCapIndex = 0;
            val_1 = new System.Object();
            this.m_points3 = val_1;
            this.SetupLine(lineName:  name, texture:  texture, width:  width, lineType:  lineType, joins:  val_2, use2D:  true);
        }
        public VectorLine(string name, System.Collections.Generic.List<UnityEngine.Vector3> points, float width, Vectrosity.LineType lineType, Vectrosity.Joins joins)
        {
            bool val_2;
            this.m_capType = 4;
            this.m_active = true;
            this.m_frontEndCapIndex = 0;
            this.m_backEndCapIndex = 0;
            val_1 = new System.Object();
            this.m_points3 = val_1;
            this.SetupLine(lineName:  name, texture:  0, width:  width, lineType:  lineType, joins:  joins, use2D:  val_2);
        }
        public VectorLine(string name, System.Collections.Generic.List<UnityEngine.Vector3> points, UnityEngine.Texture texture, float width, Vectrosity.LineType lineType, Vectrosity.Joins joins)
        {
            bool val_2;
            this.m_capType = 4;
            this.m_active = true;
            this.m_frontEndCapIndex = 0;
            this.m_backEndCapIndex = 0;
            val_1 = new System.Object();
            this.m_points3 = val_1;
            this.SetupLine(lineName:  name, texture:  texture, width:  width, lineType:  lineType, joins:  joins, use2D:  val_2);
        }
        public VectorLine(string name, System.Collections.Generic.List<UnityEngine.Vector2> points, float width)
        {
            this.m_capType = 4;
            this.m_active = true;
            this.m_frontEndCapIndex = 0;
            this.m_backEndCapIndex = 0;
            val_1 = new System.Object();
            this.m_points2 = val_1;
            this.SetupLine(lineName:  name, texture:  0, width:  width, lineType:  R3, joins:  true, use2D:  true);
        }
        public VectorLine(string name, System.Collections.Generic.List<UnityEngine.Vector2> points, UnityEngine.Texture texture, float width)
        {
            Vectrosity.LineType val_2;
            this.m_capType = 4;
            this.m_active = true;
            this.m_frontEndCapIndex = 0;
            UnityEngine.Texture val_1 = texture;
            this.m_backEndCapIndex = 0;
            val_1 = new System.Object();
            this.m_points2 = points;
            this.SetupLine(lineName:  name, texture:  val_1, width:  width, lineType:  val_2, joins:  true, use2D:  true);
        }
        public VectorLine(string name, System.Collections.Generic.List<UnityEngine.Vector2> points, float width, Vectrosity.LineType lineType)
        {
            Vectrosity.Joins val_2;
            this.m_capType = 4;
            this.m_active = true;
            this.m_frontEndCapIndex = 0;
            this.m_backEndCapIndex = 0;
            val_1 = new System.Object();
            this.m_points2 = val_1;
            this.SetupLine(lineName:  name, texture:  0, width:  width, lineType:  lineType, joins:  val_2, use2D:  true);
        }
        public VectorLine(string name, System.Collections.Generic.List<UnityEngine.Vector2> points, UnityEngine.Texture texture, float width, Vectrosity.LineType lineType)
        {
            Vectrosity.Joins val_2;
            this.m_capType = 4;
            this.m_active = true;
            this.m_frontEndCapIndex = 0;
            this.m_backEndCapIndex = 0;
            val_1 = new System.Object();
            this.m_points2 = val_1;
            this.SetupLine(lineName:  name, texture:  texture, width:  width, lineType:  lineType, joins:  val_2, use2D:  true);
        }
        public VectorLine(string name, System.Collections.Generic.List<UnityEngine.Vector2> points, float width, Vectrosity.LineType lineType, Vectrosity.Joins joins)
        {
            bool val_2;
            this.m_capType = 4;
            this.m_active = true;
            this.m_frontEndCapIndex = 0;
            this.m_backEndCapIndex = 0;
            val_1 = new System.Object();
            this.m_points2 = val_1;
            this.SetupLine(lineName:  name, texture:  0, width:  width, lineType:  lineType, joins:  joins, use2D:  val_2);
        }
        public VectorLine(string name, System.Collections.Generic.List<UnityEngine.Vector2> points, UnityEngine.Texture texture, float width, Vectrosity.LineType lineType, Vectrosity.Joins joins)
        {
            bool val_2;
            this.m_capType = 4;
            this.m_active = true;
            this.m_frontEndCapIndex = 0;
            this.m_backEndCapIndex = 0;
            val_1 = new System.Object();
            this.m_points2 = val_1;
            this.SetupLine(lineName:  name, texture:  texture, width:  width, lineType:  lineType, joins:  joins, use2D:  val_2);
        }
        protected void SetupLine(string lineName, UnityEngine.Texture texture, float width, Vectrosity.LineType lineType, Vectrosity.Joins joins, bool use2D)
        {
            bool val_1;
            float val_7;
            float val_8;
            var val_24;
            string val_25;
            var val_26;
            var val_27;
            var val_28;
            int val_29;
            var val_30;
            val_24 = this;
            val_25 = lineName;
            val_26 = 22979013;
            this.m_lineType = joins;
            this.m_is2D = val_1;
            if(use2D == true)
            {
                goto label_1;
            }
            
            if((use2D == true) || (joins == 0))
            {
                goto label_5;
            }
            
            val_27 = -1610612241;
            val_28 = 22796972;
            goto label_6;
            label_1:
            if(joins != 2)
            {
                goto label_5;
            }
            
            val_27 = -1610612241;
            val_28 = 22796968;
            goto label_6;
            label_5:
            if(val_1 == 0)
            {
                goto label_7;
            }
            
            if(this.m_points2 == 0)
            {
                goto label_14;
            }
            
            int val_2 = this.m_points2.Capacity;
            if(val_2 >= 1)
            {
                    if(val_2 == 0)
            {
                goto label_11;
            }
            
            }
            
            if(this.m_points2 != 0)
            {
                goto label_13;
            }
            
            goto label_13;
            label_7:
            if(this.m_points3 == 0)
            {
                goto label_14;
            }
            
            int val_3 = this.m_points3.Capacity;
            if(val_3 >= 1)
            {
                    if(val_3 == 0)
            {
                goto label_17;
            }
            
            }
            
            if(this.m_points3 != 0)
            {
                goto label_19;
            }
            
            goto label_19;
            label_14:
            val_27 = -1610612241;
            val_28 = 22796984;
            label_6:
            string val_4 = -1610602673(-1610602673) + val_25 + -1610612241(-1610612241);
            UnityEngine.Debug.LogError(message:  -1610602673);
            return;
            label_11:
            int val_5 = this.m_points2.Capacity;
            val_29 = val_5;
            label_13:
            val_30 = val_24;
            this.m_pointsCount = val_29;
            val_24 = val_29 - val_5;
            if(val_24 < 1)
            {
                goto label_30;
            }
            
            val_25 = 4.022026E-38f;
            do
            {
                val_29 = this.m_points2;
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
                val_29.Add(item:  new UnityEngine.Vector2() {x = val_7, y = val_8});
                val_24 = val_24 - 1;
            }
            while(val_29 != 0);
            
            goto label_30;
            label_17:
            int val_9 = this.m_points3.Capacity;
            val_29 = val_9;
            label_19:
            val_30 = val_24;
            this.m_pointsCount = val_29;
            int val_10 = val_29 - val_9;
            if(val_10 >= 1)
            {
                    val_24 = 22739752;
                do
            {
                val_29 = this.m_points3;
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
                val_29.Add(item:  new UnityEngine.Vector3() {x = R5, y = R8, z = SB});
                val_10 = val_10 - 1;
            }
            while(val_29 != 0);
            
            }
            
            label_30:
            if(this.SetVertexCount() == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_13 = 536887303;
            val_13 = new UnityEngine.GameObject(name:  this.m_name);
            this.m_go = val_13;
            this.m_canvasState = 0;
            this.layer = UnityEngine.LayerMask.NameToLayer(layerName:  -1610603225);
            SynchronizationContextBehavoir val_15 = this.m_go.AddComponent<SynchronizationContextBehavoir>();
            this.m_rectTransform = this.m_go;
            Vectrosity.VectorLine.SetupTransform(rectTransform:  this.m_rectTransform);
            this.m_texture = texture;
            val_26 = 22708680;
            this.m_lineVertices = 536882597;
            this.m_lineUVs = 536882585;
            this.m_lineColors = 536881829;
            val_29 = 0f;
            this.m_lineUVBottom = val_29;
            this.m_lineUVTop = 1f;
            this.SetUVs(startIndex:  0, endIndex:  this.GetSegmentNumber());
            536877987 = new System.Collections.Generic.List<System.Int32>();
            this.m_lineTriangles = 536877987;
            this.name = val_25;
            UnityEngine.Color val_18 = UnityEngine.Color.white;
            UnityEngine.Color32 val_19 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
            this.m_color = val_19;
            this.SetColor(color:  new UnityEngine.Color32() {r = val_19.r, g = val_19.g, b = val_19.b, a = val_19.a}, startIndex:  0, endIndex:  this.pointsCount);
            Vectrosity.LineType val_21 = lineType + lineType;
            this.m_joins = val_25;
            val_21 = val_21 * val_21;
            this.m_maxWeldDistance = val_21;
            this.m_lineWidths = 536882357;
            this.m_lineWidths[0] = lineType * 0.5f;
            this.m_lineWidth = lineType;
            if(this.m_is2D != true)
            {
                    this.m_screenPoints = 536882597;
            }
            
            int val_23 = this.m_pointsCount;
            this.m_drawStart = 0;
            val_23 = val_23 - 1;
            this.m_drawEnd = val_23;
            this.SetupTriangles(startVert:  0);
        }
        private void SetupTriangles(int startVert)
        {
            var val_28;
            var val_29;
            var val_30;
            System.Collections.Generic.List<System.Int32> val_31;
            System.Collections.Generic.List<System.Int32> val_32;
            var val_33;
            var val_34;
            Vectrosity.IVectorObject val_35;
            System.Collections.Generic.List<System.Int32> val_37;
            int val_38;
            var val_39;
            int val_21 = startVert;
            if(this.pointsCount < 1)
            {
                goto label_1;
            }
            
            if(this.m_lineType == 0)
            {
                goto label_2;
            }
            
            if(this.m_lineType != 2)
            {
                goto label_3;
            }
            
            int val_2 = this.pointsCount;
            val_28 = this.pointsCount << 2;
            val_29 = val_2 + (val_2 << 1);
            goto label_4;
            label_1:
            val_28 = 0;
            val_30 = 0;
            goto label_6;
            label_2:
            int val_4 = this.pointsCount;
            val_4 = val_4 - 1;
            if(this.m_joins == 0)
            {
                    6 = 12;
            }
            
            val_30 = val_4 * 12;
            val_28 = 3 + (this.pointsCount << 2);
            goto label_6;
            label_3:
            int val_6 = this.pointsCount;
            val_28 = this.pointsCount << 1;
            int val_8 = val_6 + (val_6 >> 31);
            val_8 = val_8 >> 1;
            val_29 = val_8 + (val_8 << 1);
            label_4:
            val_30 = val_29 << 1;
            label_6:
            val_31 = this.m_lineTriangles;
            if(this.m_capType != 4)
            {
                    val_32 = val_30 + 12;
            }
            
            if(this.m_capType <= val_32)
            {
                goto label_8;
            }
            
            if(val_31 == 0)
            {
                goto label_9;
            }
            
            goto label_10;
            label_8:
            if(this.m_joins == 0)
            {
                goto label_11;
            }
            
            if(val_28 <= val_21)
            {
                goto label_20;
            }
            
            val_31 = 22737108;
            do
            {
                val_31.Add(item:  val_21);
                val_21 = val_21 + 1;
                val_31.Add(item:  val_21);
                val_21 = val_21 + 2;
                val_31.Add(item:  val_21);
                val_21 = val_21 - 2;
                val_31.Add(item:  val_21);
                val_21 = val_21 + 1;
                val_31.Add(item:  val_21);
                val_32 = val_31;
                val_32.Add(item:  val_21 + 1);
                val_21 = val_21 + 2;
            }
            while(val_21 < val_28);
            
            goto label_20;
            label_9:
            val_33 = 0;
            label_10:
            val_34 = -1073714293;
            val_31.RemoveRange(index:  val_32, count:  val_33 - val_32);
            if(this.m_joins == 0)
            {
                goto label_21;
            }
            
            val_35 = this.m_vectorObject;
            if(val_35 == 0)
            {
                    return;
            }
            
            val_31 = 0;
            val_32 = 0;
            val_31 = val_31 + 1;
            val_32 = (uint)val_31 & 65535;
            goto label_51;
            label_11:
            if(val_21 < 4)
            {
                goto label_27;
            }
            
            val_37 = val_31;
            if(val_37 == 0)
            {
                goto label_28;
            }
            
            val_38 = val_31 - 6;
            goto label_30;
            label_21:
            this.SetLastFillTriangles();
            return;
            label_28:
            val_37 = val_31;
            val_38 = val_31 - 6;
            if(val_37 == 0)
            {
                    val_38 = val_38;
                val_37 = 0;
            }
            
            label_30:
            val_37.set_Item(index:  val_38, value:  val_21 - 3);
            val_31.set_Item(index:  val_31 - 5, value:  val_21);
            int val_13 = val_21 + 3;
            val_31.set_Item(index:  val_31 - 4, value:  val_13);
            val_31.set_Item(index:  val_31 - 3, value:  val_21 - 2);
            val_31.set_Item(index:  val_31 - 2, value:  val_21);
            val_32 = val_31;
            val_34 = -1073714247;
            val_32.set_Item(index:  val_31 - 1, value:  val_13);
            label_27:
            if(val_28 > val_21)
            {
                    val_31 = 22737108;
                do
            {
                val_31.Add(item:  val_21);
                val_21 = val_21 + 1;
                val_31.Add(item:  val_21);
                val_21 = val_21 + 2;
                val_31.Add(item:  val_21);
                val_21 = val_21 - 2;
                val_31.Add(item:  val_21);
                val_21 = val_21 + 1;
                val_31.Add(item:  val_21);
                val_21 = val_21 + 1;
                val_31.Add(item:  val_21);
                val_21 = val_21 - 2;
                val_31.Add(item:  val_21);
                val_21 = val_21 + 3;
                val_31.Add(item:  val_21);
                val_21 = val_21 + 3;
                val_31.Add(item:  val_21);
                val_21 = val_21 - 5;
                val_31.Add(item:  val_21);
                val_21 = val_21 + 2;
                val_31.Add(item:  val_21);
                val_32 = val_31;
                val_32.Add(item:  val_21 + 3);
            }
            while(val_21 < val_28);
            
            }
            
            this.SetLastFillTriangles();
            label_20:
            val_35 = this.m_vectorObject;
            if(val_35 == 0)
            {
                    return;
            }
            
            val_31 = 0;
            val_32 = 0;
            val_31 = val_31 + 1;
            val_32 = (uint)val_31 & 65535;
            label_51:
            val_39 = val_35;
            goto mem[(1152921504869146624 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private void SetLastFillTriangles()
        {
            float val_25;
            var val_26;
            int val_27;
            int val_28;
            var val_29;
            int val_30;
            var val_31;
            var val_32;
            if(this.pointsCount < 2)
            {
                    return;
            }
            
            int val_2 = this.pointsCount;
            val_2 = val_2 + (val_2 << 1);
            int val_22 = 12;
            val_22 = val_22 + (val_2 << 2);
            if(this.m_capType == 4)
            {
                    val_22 = val_2 << 2;
            }
            
            int val_3 = val_22 - 12;
            if(this.m_is2D == false)
            {
                goto label_2;
            }
            
            if(val_2 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.Collections.Generic.List<UnityEngine.Vector2> val_4 = this.points2;
            UnityEngine.Vector2[] val_23 = this.m_lineUVs;
            val_23 = val_23 - 1;
            if(this <= val_23)
            {
                    var val_24 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            uint val_25 = 1;
            val_24 = val_24 + (val_23 << 3);
            var val_26 = (0 + ((this.m_lineUVs - 1)) << 3) + 16;
            val_25 = val_25 - ((0 + ((this.m_lineUVs - 1)) << 3) + 20);
            val_26 = 2621443 - val_26;
            val_25 = val_25 * val_25;
            if(this < 0)
            {
                goto label_8;
            }
            
            if(this.m_is2D == true)
            {
                goto label_15;
            }
            
            label_2:
            if(this.m_is2D != true)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_25 = 0f;
            System.Collections.Generic.List<UnityEngine.Vector3> val_5 = this.points3;
            UnityEngine.Vector2[] val_27 = this.m_lineUVs;
            val_27 = val_27 - 1;
            if(this <= val_27)
            {
                    var val_28 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_28 = val_28 + ((val_27[val_27 << 1]) << 2);
            bool val_6 = UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = 3.673424E-39f, y = 1.401298E-45f, z = 0f}, rhs:  new UnityEngine.Vector3() {x = (0 + ((this.m_lineUVs - 1)[((this.m_lineUVs - 1)) << 1]) << 2) + 16, y = (0 + ((this.m_lineUVs - 1)[((this.m_lineUVs - 1)) << 1]) << 2) + 20, z = (0 + ((this.m_lineUVs - 1)[((this.m_lineUVs - 1)) << 1]) << 2) + 24});
            if(val_6 == false)
            {
                goto label_15;
            }
            
            label_8:
            int val_7 = val_3 - 4;
            if(val_6 <= val_7)
            {
                    var val_29 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_26 = 0;
            val_29 = val_29 + (val_7 << 2);
            if(((0 + (((((val_2 + (val_2) << 1) << 2) - 12) - 4)) << 2) + 16) != 3)
            {
                    int val_8 = val_3 - 1;
                if(((0 + (((((val_2 + (val_2) << 1) << 2) - 12) - 4)) << 2) + 16) <= val_8)
            {
                    var val_30 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_30 = val_30 + (val_8 << 2);
                var val_9 = ((0 + (((((val_2 + (val_2) << 1) << 2) - 12) - 1)) << 2) + 16) - 3;
                if(((0 + (((((val_2 + (val_2) << 1) << 2) - 12) - 4)) << 2) + 16) != val_8)
            {
                    val_26 = 1;
            }
            
            }
            
            val_27 = this.m_vertexCount;
            val_25 = 4.021323E-38f;
            this.m_lineTriangles.set_Item(index:  val_3 - 6, value:  val_27 - 3);
            this.m_lineTriangles.set_Item(index:  val_3 - 5, value:  0);
            this.m_lineTriangles.set_Item(index:  val_7, value:  3);
            val_28 = this.m_vertexCount;
            this.m_lineTriangles.set_Item(index:  val_3 - 3, value:  val_28 - 2);
            this.m_lineTriangles.set_Item(index:  val_3 - 2, value:  0);
            val_29 = -1073714247;
            val_30 = val_3 - 1;
            val_31 = 3;
            goto label_27;
            label_15:
            int val_16 = val_3 - 4;
            if(this.m_is2D <= val_16)
            {
                    var val_31 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_26 = 0;
            val_31 = val_31 + (val_16 << 2);
            if(((0 + (((((val_2 + (val_2) << 1) << 2) - 12) - 4)) << 2) + 16) == 3)
            {
                    int val_17 = val_3 - 1;
                if(((0 + (((((val_2 + (val_2) << 1) << 2) - 12) - 4)) << 2) + 16) <= val_17)
            {
                    var val_32 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_32 = val_32 + (val_17 << 2);
                var val_33 = (0 + (((((val_2 + (val_2) << 1) << 2) - 12) - 1)) << 2) + 16;
                val_33 = val_33 - 3;
                val_26 = val_33 >> 5;
            }
            
            val_22 = val_3 - 6;
            val_27 = 22737168;
            this.m_lineTriangles.set_Item(index:  val_22, value:  0);
            this.m_lineTriangles.set_Item(index:  val_3 - 5, value:  0);
            val_28 = this.m_lineTriangles;
            val_28.set_Item(index:  val_16, value:  0);
            this.m_lineTriangles.set_Item(index:  val_3 - 3, value:  0);
            this.m_lineTriangles.set_Item(index:  val_3 - 2, value:  0);
            val_29 = -1073714247;
            val_30 = val_3 - 1;
            val_31 = 0;
            label_27:
            this.m_lineTriangles.set_Item(index:  val_30, value:  0);
            if(val_26 != 0)
            {
                    this = this.m_vectorObject;
            }
            
            if(this == 0)
            {
                    return;
            }
            
            val_27 = 0;
            val_28 = 0;
            val_27 = val_27 + 1;
            val_28 = (uint)val_27 & 65535;
            val_32 = this;
            goto mem[(1152921504869146624 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private void SetupEndCap(float[] uvHeights)
        {
            int val_18;
            int val_19;
            float val_20;
            UnityEngine.Color32 val_21;
            var val_24;
            var val_25;
            var val_26;
            string val_27;
            var val_28;
            val_18 = this.m_vertexCount;
            val_19 = val_18 + 8;
            if(val_19 >= 65535)
            {
                goto label_1;
            }
            
            this.ResizeMeshArrays(newCount:  val_19);
            if(this.m_joins == 0)
            {
                goto label_2;
            }
            
            if(val_18 > (-2147483639))
            {
                goto label_14;
            }
            
            int val_22 = val_18;
            val_20 = 4.021312E-38f;
            do
            {
                this.m_lineTriangles.Insert(index:  0, item:  val_22);
                int val_1 = 0 + 1;
                val_22 = val_22 + 1;
                this.m_lineTriangles.Insert(index:  val_1, item:  val_22);
                val_1 = val_1 + 1;
                val_22 = val_22 + 2;
                this.m_lineTriangles.Insert(index:  val_1, item:  val_22);
                val_1 = val_1 + 1;
                int val_2 = val_22 - 2;
                this.m_lineTriangles.Insert(index:  val_1, item:  val_2);
                int val_3 = val_1 + 1;
                int val_4 = val_2 + 1;
                this.m_lineTriangles.Insert(index:  val_3, item:  val_4);
                this.m_lineTriangles.Insert(index:  val_3 + 1, item:  val_4 + 1);
                val_21 = val_3 + 2;
                val_19 = val_19;
            }
            while((val_4 + 2) < val_19);
            
            goto label_14;
            label_1:
            string val_8 = -1610602675(-1610602675) + this.m_name + -1610612193(-1610612193);
            UnityEngine.Debug.LogError(message:  -1610602675);
            return;
            label_2:
            if(val_18 <= (-2147483639))
            {
                    int val_23 = val_18;
                val_20 = 4.021312E-38f;
                do
            {
                this.m_lineTriangles.Insert(index:  0, item:  val_23);
                int val_9 = 0 + 1;
                val_23 = val_23 + 1;
                this.m_lineTriangles.Insert(index:  val_9, item:  val_23);
                val_9 = val_9 + 1;
                val_23 = val_23 + 2;
                this.m_lineTriangles.Insert(index:  val_9, item:  val_23);
                val_9 = val_9 + 1;
                int val_10 = val_23 - 2;
                this.m_lineTriangles.Insert(index:  val_9, item:  val_10);
                int val_11 = val_9 + 1;
                int val_12 = val_10 + 1;
                this.m_lineTriangles.Insert(index:  val_11, item:  val_12);
                this.m_lineTriangles.Insert(index:  val_11 + 1, item:  val_12 + 1);
                val_21 = val_11 + 2;
                val_19 = val_19;
            }
            while((val_12 + 2) < val_19);
            
            }
            
            label_14:
            if(val_19 > 11)
            {
                    0 = val_18 - 4;
            }
            
            if(val_18 <= (-2147483643))
            {
                    val_20 = val_18 + 4;
                do
            {
                this.m_lineColors[val_18] = this.m_lineColors[0];
                val_21 = this.m_lineColors[0];
                val_18 = (val_18 + 4) - 3;
                this.m_lineColors[val_18] = val_21;
            }
            while(val_18 < val_20);
            
            }
            
            this.m_lineUVBottom = uvHeights + 16;
            this.m_lineUVTop = uvHeights + 20;
            this.m_backCapUVBottom = uvHeights + 24;
            this.m_backCapUVTop = uvHeights + 28;
            this.m_frontCapUVBottom = uvHeights + 32;
            this.m_frontCapUVTop = uvHeights + 36;
            this.SetUVs(startIndex:  0, endIndex:  this.GetSegmentNumber());
            this.SetEndCapUVs();
            if(this.m_vectorObject != 0)
            {
                    val_18 = 22712368;
                val_21 = 0;
                val_21 = val_21 + 1;
                val_24 = this.m_vectorObject;
                val_21 = 0;
                val_21 = val_21 + 1;
                val_25 = this.m_vectorObject;
            }
            
            this.SetEndCapColors();
            mem[1152921509279366636] = this.m_texture;
            val_26 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_26 = 536896697;
            }
            
            val_27 = this.m_endCap;
            UnityEngine.Purchasing.IStoreExtension val_20 = mem[536896789] + 56.Item[val_27];
            this.m_texture = mem[536896789] + 56 + 12;
            if(this.m_vectorObject == 0)
            {
                    return;
            }
            
            val_21 = 0;
            val_27 = 0;
            val_21 = val_21 + 1;
            val_27 = (uint)val_21 & 65535;
            val_28 = this.m_vectorObject;
            goto mem[(1152921504869146624 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private void ResetLine()
        {
            var val_5;
            bool val_1 = this.SetVertexCount();
            this.m_lineVertices = 536882597;
            this.m_lineUVs = 536882585;
            this.m_lineColors = 536881829;
            if(this.m_is2D != true)
            {
                    this.m_screenPoints = 536882597;
            }
            
            this.SetUVs(startIndex:  0, endIndex:  this.GetSegmentNumber());
            this.SetColor(color:  new UnityEngine.Color32() {r = this.m_color, g = this.m_color, b = this.m_color, a = this.m_color}, startIndex:  0, endIndex:  this.pointsCount);
            this.SetupWidths(max:  this.GetSegmentNumber());
            this.ClearTriangles();
            this.SetupTriangles(startVert:  0);
            if(this.m_vectorObject != 0)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                val_5 = this.m_vectorObject;
            }
            
            if(this.m_canvasState != 2)
            {
                    if(this.m_canvasState != 1)
            {
                    return;
            }
            
                this.Draw();
                return;
            }
            
            this.Draw3D();
        }
        private void SetEndCapUVs()
        {
            var val_2;
            float val_3;
            UnityEngine.Vector2[] val_4;
            int val_5;
            float val_6;
            int val_2 = this.m_vertexCount;
            val_2 = val_2 + 3;
            this.m_lineUVs[val_2] = 0;
            this.m_lineUVs[this.m_vertexCount] = 1065353216;
            int val_3 = this.m_vertexCount;
            val_3 = val_3 + 1;
            this.m_lineUVs[val_3] = 1065353216;
            int val_4 = this.m_vertexCount;
            val_4 = val_4 + 2;
            this.m_lineUVs[val_4] = 0;
            val_2 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_2 = 536896697;
            }
            
            UnityEngine.Purchasing.IStoreExtension val_1 = mem[536896789] + 56.Item[this.m_endCap];
            int val_5 = this.m_vertexCount;
            if((mem[536896789] + 56 + 8) == 2)
            {
                    val_5 = val_5 + 7;
                this.m_lineUVs[val_5] = 0;
                this.m_lineUVs[val_5] = this.m_frontCapUVBottom;
                int val_6 = this.m_vertexCount;
                val_6 = val_6 + 4;
                this.m_lineUVs[val_6] = 1065353216;
                int val_7 = this.m_vertexCount;
                val_3 = this.m_frontCapUVTop;
                val_7 = val_7 + 5;
                this.m_lineUVs[val_7] = 1065353216;
                val_4 = this.m_lineUVs;
                val_5 = this.m_vertexCount;
                val_6 = this.m_frontCapUVTop;
            }
            else
            {
                    val_5 = val_5 + 7;
                this.m_lineUVs[val_5] = 0;
                this.m_lineUVs[val_5] = this.m_backCapUVTop;
                int val_8 = this.m_vertexCount;
                val_8 = val_8 + 4;
                this.m_lineUVs[val_8] = 1065353216;
                int val_9 = this.m_vertexCount;
                val_3 = this.m_backCapUVBottom;
                val_9 = val_9 + 5;
                this.m_lineUVs[val_9] = 1065353216;
                val_4 = this.m_lineUVs;
                val_5 = this.m_vertexCount;
                val_6 = this.m_backCapUVBottom;
            }
            
            val_5 = val_5 + 6;
            val_4[val_5] = 0;
            mem2[0] = val_6;
        }
        private void RemoveEndCap()
        {
            string val_3;
            var val_4;
            if(this.m_capType == 4)
            {
                    return;
            }
            
            val_3 = 0;
            this.m_endCap = val_3;
            this.m_capType = 4;
            this.ResizeMeshArrays(newCount:  this.m_vertexCount);
            this.m_lineTriangles.RemoveRange(index:  0, count:  12);
            this.m_lineUVBottom = val_3;
            this.m_lineUVTop = 1f;
            this.SetUVs(startIndex:  0, endIndex:  this.GetSegmentNumber());
            if(this.m_useTextureScale == true)
            {
                    this.m_useTextureScale = this;
                this.SetTextureScale();
            }
            
            this.texture = this.m_originalTexture;
            val_3 = 0;
            val_3 = val_3 + 1;
            val_4 = this.m_vectorObject;
            if(this.m_collider == false)
            {
                    return;
            }
            
            Vectrosity.CanvasState val_3 = this.m_canvasState;
            val_3 = val_3 - 1;
            this.SetCollider(convertToWorldSpace:  val_3 >> 5);
        }
        private static void SetupTransform(UnityEngine.RectTransform rectTransform)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            rectTransform.offsetMin = new UnityEngine.Vector2() {x = R5, y = R6};
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            rectTransform.offsetMax = new UnityEngine.Vector2() {x = R5, y = R6};
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            rectTransform.anchorMin = new UnityEngine.Vector2() {x = R5, y = R6};
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
            rectTransform.anchorMax = new UnityEngine.Vector2() {x = R5, y = R6};
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
            rectTransform.pivot = new UnityEngine.Vector2() {x = R5, y = R6};
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
            rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = R5, y = R6};
        }
        private void ResizeMeshArrays(int newCount)
        {
            System.Array.Resize<UnityEngine.Vector3>(array: ref  this.m_lineVertices, newSize:  newCount);
            System.Array.Resize<UnityEngine.Vector2>(array: ref  this.m_lineUVs, newSize:  newCount);
            System.Array.Resize<UnityEngine.Color32>(array: ref  this.m_lineColors, newSize:  newCount);
        }
        public void Resize(int newCount)
        {
            float val_7;
            System.Collections.Generic.List<UnityEngine.Vector2> val_8;
            var val_9;
            var val_10;
            if(newCount <= 1)
            {
                goto label_1;
            }
            
            if(this.pointsCount == newCount)
            {
                    return;
            }
            
            if(this.m_is2D == false)
            {
                goto label_3;
            }
            
            if(this.m_pointsCount >= newCount)
            {
                goto label_4;
            }
            
            if((newCount - this.m_pointsCount) < 1)
            {
                goto label_19;
            }
            
            val_7 = 4.022026E-38f;
            do
            {
                val_8 = this.m_points2;
                UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
                val_8.Add(item:  new UnityEngine.Vector2() {x = R4, y = R5});
                int val_7 = this.m_pointsCount;
                val_9 = 0 + 1;
                val_7 = newCount - val_7;
            }
            while(val_9 < val_7);
            
            goto label_19;
            label_1:
            UnityEngine.Debug.LogError(message:  -1610602735);
            return;
            label_3:
            if(this.m_pointsCount >= newCount)
            {
                goto label_11;
            }
            
            if((newCount - this.m_pointsCount) < 1)
            {
                goto label_19;
            }
            
            do
            {
                val_7 = this.m_points3;
                val_10 = 536896697;
                if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_10 = 536896697;
            }
            
                val_8 = mem[mem[536896789]];
                val_8 = mem[536896789];
                val_7.Add(item:  new UnityEngine.Vector3() {x = val_8, y = mem[536896789] + 4, z = mem[536896789] + 8});
                int val_8 = this.m_pointsCount;
                val_9 = 0 + 1;
                val_8 = newCount - val_8;
            }
            while(val_9 < val_8);
            
            goto label_19;
            label_4:
            this.m_points2.RemoveRange(index:  newCount, count:  this.m_pointsCount - newCount);
            goto label_19;
            label_11:
            this.m_points3.RemoveRange(index:  newCount, count:  this.m_pointsCount - newCount);
            label_19:
            this.Resize();
        }
        private void Resize()
        {
            int val_17;
            int val_18;
            int val_19;
            System.Single[] val_20;
            int val_21;
            int val_22;
            var val_23;
            if(this.m_lineType != 0)
            {
                    if(this.m_lineType != 2)
            {
                    this.m_pointsCount = this.m_pointsCount + (this.m_pointsCount >> 31);
            }
            
                if(this.m_lineType != 2)
            {
                    val_17 = this.m_pointsCount >> 1;
                val_18 = this.m_pointsCount;
            }
            
            }
            else
            {
                    val_17 = UnityEngine.Mathf.Max(a:  0, b:  this.m_pointsCount - 1);
                val_18 = this.m_pointsCount;
            }
            
            val_18 = val_18 - 1;
            if(this.m_lineType != 0)
            {
                    this.m_drawEnd - val_18 = 1;
            }
            
            if(this.m_drawEnd > 0)
            {
                    0 = 1;
            }
            
            if(this.SetVertexCount() == false)
            {
                    return;
            }
            
            this.m_pointsCount = this.pointsCount;
            if(this.m_capType != 4)
            {
                    val_19 = R7 - 8;
            }
            
            if(val_19 < this.m_vertexCount)
            {
                    if(val_19 == 0)
            {
                    val_19 = 4;
            }
            
                do
            {
            
            }
            while(4 < this.m_pointsCount);
            
                val_19 = UnityEngine.Mathf.Min(a:  4, b:  16383);
                if(this.m_capType == 4)
            {
                    8 + (val_19 << 2) = val_19 << 2;
            }
            
                this.ResizeMeshArrays(newCount:  8 + (val_19 << 2));
                if(this.m_is2D != true)
            {
                    UnityEngine.Vector3[] val_9 = this.m_screenPoints;
                System.Array.Resize<UnityEngine.Vector3>(array: ref  val_9, newSize:  val_19 << 2);
            }
            
            }
            
            val_20 = this.m_lineWidths;
            if(val_9 >= 2)
            {
                    if(this.m_lineType != 0)
            {
                    if(this.m_lineType != 2)
            {
                    this.m_lineType = val_19 + (val_19 >> 31);
                val_19 = this.m_lineType >> 1;
            }
            
            }
            else
            {
                    val_19 = val_19 - 1;
            }
            
                val_20 = this.m_lineWidths;
                if(val_19 > this.m_lineType)
            {
                    this.ResizeLineWidths(newSize:  val_19);
            }
            
            }
            
            int val_11 = this.m_pointsCount - 1;
            if((1 & 1) == 0)
            {
                    this.m_drawEnd = val_11;
            }
            
            int val_18 = this.m_pointsCount;
            val_21 = 0;
            val_18 = val_18 - 1;
            this.m_drawStart = UnityEngine.Mathf.Clamp(value:  this.m_drawStart, min:  0, max:  val_11);
            val_22 = this.m_pointsCount;
            this.m_drawEnd = UnityEngine.Mathf.Clamp(value:  this.m_drawEnd, min:  0, max:  val_18);
            if(val_22 > val_17)
            {
                    val_20 = this.m_color;
                val_21 = this.GetSegmentNumber();
                this.SetColor(color:  new UnityEngine.Color32() {r = val_20, g = val_20, b = val_20, a = val_20}, startIndex:  val_17, endIndex:  val_21);
                this.SetUVs(startIndex:  val_17, endIndex:  this.GetSegmentNumber());
                val_22 = this.m_pointsCount;
            }
            
            if(val_22 < this.m_pointsCount)
            {
                    this.ZeroVertices(startIndex:  val_22, endIndex:  this.m_pointsCount);
            }
            
            if(this.m_capType != 4)
            {
                    this.SetEndCapUVs();
                this.SetEndCapColors();
            }
            
            this.SetupTriangles(startVert:  val_17 << 2);
            if(this.m_vectorObject == 0)
            {
                    return;
            }
            
            val_19 = 0;
            val_20 = 0;
            val_19 = val_19 + 1;
            val_20 = (uint)val_19 & 65535;
            val_23 = this.m_vectorObject;
            goto mem[(1152921504869146624 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private void ResizeLineWidths(int newSize)
        {
            Vectrosity.VectorLine val_3;
            var val_4;
            var val_5;
            System.Single[] val_6;
            val_3 = this;
            val_4 = val_3;
            if(true >= newSize)
            {
                goto label_2;
            }
            
            val_5 = 4;
            goto label_3;
            label_10:
            val_6 = this.m_lineWidths;
            if(val_6 != null)
            {
                
            }
            else
            {
                    val_6 = 0;
            }
            
            if(val_3 >= (R8 + 12))
            {
                goto label_6;
            }
            
            label_11:
            var val_6 = 2621443;
            mem[536882373] = val_6;
            val_5 = 5;
            label_3:
            if(this.m_lineWidths == null)
            {
                goto label_10;
            }
            
            if((val_5 - 4) < val_6)
            {
                goto label_11;
            }
            
            label_6:
            if(2621443 < newSize)
            {
                    var val_3 = (536882357 + 10485772) + 16;
                do
            {
                var val_5 = mem[1152921509281675736];
                val_5 = val_5 * 0.5f;
                val_6 = val_6 + 1;
            }
            while(newSize != val_6);
            
            }
            
            this.m_lineWidths = 536882357;
            label_2:
            var val_4 = FP - 48;
            val_4 = val_4 + 4;
        }
        private void SetUVs(int startIndex, int endIndex)
        {
            var val_5;
            UnityEngine.Vector2[] val_6;
            var val_7;
            val_5 = endIndex;
            int val_5 = startIndex;
            val_6 = 22979024;
            if(val_5 < val_5)
            {
                    val_5 = val_5 - val_5;
                val_5 = val_5 << 2;
                do
            {
                this.m_lineUVs[val_5] = 0;
                int val_1 = val_5 + 1;
                this.m_lineUVs[val_5] = 1065353216;
                this.m_lineUVs[val_5] = this.m_lineUVTop;
                int val_2 = val_5 + 2;
                this.m_lineUVs[val_5] = 1065353216;
                this.m_lineUVs[val_5] = this.m_lineUVBottom;
                val_6 = this.m_lineUVs;
                val_5 = val_5 - 1;
                val_5 = val_5 + 4;
                val_6[val_5] = 0;
                val_6[val_5] = this.m_lineUVBottom;
            }
            while(this.m_lineUVs[val_5] != (val_5 + 3));
            
            }
            
            if(this.m_vectorObject == 0)
            {
                    return;
            }
            
            val_6 = 0;
            val_5 = 0;
            val_6 = val_6 + 1;
            val_5 = (uint)val_6 & 65535;
            val_7 = this.m_vectorObject;
            goto mem[(1152921504869146624 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private bool SetVertexCount()
        {
            var val_7;
            this.m_vertexCount = UnityEngine.Mathf.Max(a:  0, b:  this.GetSegmentNumber() << 2);
            if(this.m_lineType == 1)
            {
                    if(this.pointsCount != 1)
            {
                    this.m_vertexCount = this.m_vertexCount + 4;
                this.m_vertexCount = this.m_vertexCount;
            }
            
            }
            
            val_7 = 1;
            if(this.m_vertexCount <= 65534)
            {
                    return (bool)val_7;
            }
            
            val_7 = 0;
            string val_5 = -1610602675(-1610602675) + this.m_name + -1610612191(-1610612191);
            UnityEngine.Debug.LogError(message:  -1610602675);
            return (bool)val_7;
        }
        private int MaxPoints()
        {
            return 16383;
        }
        public void AddNormals()
        {
            this.m_normalsCalculated = false;
            this.m_useNormals = true;
        }
        public void AddTangents()
        {
            if(this.m_useNormals != true)
            {
                    this.m_normalsCalculated = false;
                this.m_useNormals = true;
            }
            
            this.m_tangentsCalculated = false;
            this.m_useTangents = true;
        }
        public UnityEngine.Vector4[] CalculateTangents(UnityEngine.Vector3[] normals)
        {
            var val_34;
            Vectrosity.VectorLine val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            float val_27;
            UnityEngine.Vector3[] val_28;
            var val_29;
            float val_30;
            val_22 = this;
            if(this.m_useNormals != true)
            {
                    val_23 = 0;
                val_23 = val_23 + 1;
                val_24 = this.m_vectorObject;
                this.m_normalsCalculated = true;
                this.m_useNormals = true;
            }
            
            val_23 = 0;
            val_23 = val_23 + 1;
            val_25 = this.m_vectorObject;
            if(536882597 >= 1)
            {
                    do
            {
                if(536882597 <= 0)
            {
                    var val_37 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_37 = val_37 + 0;
                var val_3 = 0 + 1;
                if(val_37 <= val_3)
            {
                    var val_38 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_38 = val_38 + 0;
                val_26 = mem[(0 + 0) + 20];
                val_26 = (0 + 0) + 20;
                var val_4 = val_3 + 1;
                if(val_38 <= val_4)
            {
                    var val_39 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_39 = val_39 + 0;
                var val_5 = ((0 + 0) + 16) + (((0 + 0) + 16) << 1);
                UnityEngine.Vector3 val_40 = this.m_lineVertices[val_5 << 2];
                UnityEngine.Vector3 val_41 = this.m_lineVertices[val_5 << 2];
                UnityEngine.Vector3 val_42 = this.m_lineVertices[val_5 << 2];
                var val_6 = val_26 + (val_26 << 1);
                UnityEngine.Vector3 val_44 = this.m_lineVertices[val_6 << 2];
                var val_7 = ((0 + 0) + 24) + (((0 + 0) + 24) << 1);
                UnityEngine.Vector3 val_46 = this.m_lineVertices[val_7 << 2];
                UnityEngine.Vector3 val_47 = this.m_lineVertices[val_7 << 2];
                val_27 = (0 + 0) + 24;
                val_23 = 536882597;
                var val_55 = this.m_lineUVs[(0 + 0) + 16];
                var val_54 = this.m_lineUVs[(0 + 0) + 16];
                UnityEngine.Vector2 val_8 = this.m_lineUVs[val_26] - val_55;
                UnityEngine.Vector2 val_9 = this.m_lineUVs[val_27] - val_54;
                UnityEngine.Vector2 val_10 = this.m_lineUVs[val_27] - val_55;
                val_54 = this.m_lineUVs - val_54;
                UnityEngine.Vector3 val_11 = (this.m_lineVertices[val_7 << 2]) - val_42;
                val_47 = val_47 - val_41;
                val_41 = val_44 - val_41;
                val_55 = val_8 * val_9;
                val_46 = val_46 - val_40;
                val_42 = (this.m_lineVertices[val_6 << 2]) - val_42;
                val_40 = (this.m_lineVertices[val_6 << 2]) - val_40;
                UnityEngine.Vector3 val_12 = val_42 * val_9;
                val_44 = val_41 * val_9;
                UnityEngine.Vector3 val_13 = val_40 * val_9;
                float val_14 = 1f / val_55;
                val_12 = val_12 * val_14;
                val_44 = val_44 * val_14;
                val_13 = val_13 * val_14;
                val_22 = val_22;
                var val_15 = 536882597 + (val_5 << 2);
                float val_56 = (536882597 + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 16;
                float val_57 = (536882597 + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 20;
                float val_58 = (536882597 + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 24;
                val_56 = val_13 + val_56;
                val_57 = val_44 + val_57;
                val_58 = val_12 + val_58;
                mem2[0] = val_56;
                mem2[0] = val_57;
                mem2[0] = val_58;
                var val_16 = 536882597 + (val_6 << 2);
                val_11 = val_11 * val_8;
                val_47 = val_47 * val_8;
                float val_59 = (536882597 + (((0 + 0) + 20 + ((0 + 0) + 20) << 1)) << 2) + 16;
                val_46 = val_46 * val_8;
                float val_60 = (536882597 + (((0 + 0) + 20 + ((0 + 0) + 20) << 1)) << 2) + 20;
                float val_61 = (536882597 + (((0 + 0) + 20 + ((0 + 0) + 20) << 1)) << 2) + 24;
                val_59 = val_13 + val_59;
                val_60 = val_44 + val_60;
                val_61 = val_12 + val_61;
                mem2[0] = val_59;
                mem2[0] = val_60;
                mem2[0] = val_61;
                var val_17 = 536882597 + (val_7 << 2);
                float val_62 = (536882597 + (((0 + 0) + 24 + ((0 + 0) + 24) << 1)) << 2) + 16;
                float val_63 = (536882597 + (((0 + 0) + 24 + ((0 + 0) + 24) << 1)) << 2) + 20;
                float val_64 = (536882597 + (((0 + 0) + 24 + ((0 + 0) + 24) << 1)) << 2) + 24;
                val_62 = val_13 + val_62;
                val_63 = val_44 + val_63;
                val_64 = val_12 + val_64;
                mem2[0] = val_62;
                mem2[0] = val_63;
                mem2[0] = val_64;
                UnityEngine.Vector3 val_18 = val_11 * val_14;
                UnityEngine.Vector3 val_19 = val_47 * val_14;
                UnityEngine.Vector3 val_20 = val_46 * val_14;
                var val_21 = val_23 + (val_5 << 2);
                float val_65 = (val_23 + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 16;
                float val_66 = (val_23 + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 20;
                float val_67 = (val_23 + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 24;
                val_65 = val_20 + val_65;
                val_66 = val_19 + val_66;
                val_67 = val_18 + val_67;
                mem2[0] = val_65;
                mem2[0] = val_66;
                mem2[0] = val_67;
                var val_22 = val_23 + (val_6 << 2);
                float val_68 = (val_23 + (((0 + 0) + 20 + ((0 + 0) + 20) << 1)) << 2) + 16;
                float val_69 = (val_23 + (((0 + 0) + 20 + ((0 + 0) + 20) << 1)) << 2) + 20;
                float val_70 = (val_23 + (((0 + 0) + 20 + ((0 + 0) + 20) << 1)) << 2) + 24;
                val_68 = val_20 + val_68;
                val_69 = val_19 + val_69;
                val_70 = val_18 + val_70;
                mem2[0] = val_68;
                mem2[0] = val_69;
                mem2[0] = val_70;
                var val_23 = val_23 + (val_7 << 2);
                float val_71 = (val_23 + (((0 + 0) + 24 + ((0 + 0) + 24) << 1)) << 2) + 16;
                float val_72 = (val_23 + (((0 + 0) + 24 + ((0 + 0) + 24) << 1)) << 2) + 20;
                float val_73 = (val_23 + (((0 + 0) + 24 + ((0 + 0) + 24) << 1)) << 2) + 24;
                val_71 = val_20 + val_71;
                val_72 = val_19 + val_72;
                val_73 = val_18 + val_73;
                mem2[0] = val_71;
                mem2[0] = val_72;
                mem2[0] = val_73;
            }
            while((val_4 + 1) < 536882597);
            
            }
            
            val_28 = normals;
            if(mem[1152921509283003048] < 1)
            {
                    return;
            }
            
            do
            {
                UnityEngine.Vector3[] val_26 = (val_28 + 0) + 16;
                var val_27 = 536882597 + 0;
                float val_28 = (mem[((normals + 0) + 16) + (4)]) * ((536882597 + 0) + 20);
                UnityEngine.Vector3 val_29 = normalized;
                UnityEngine.Vector4 val_30 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = 2.977437E-25f});
                val_29 = 536882615;
                if(val_29 == 0)
            {
                    val_29 = 536882615;
            }
            
                var val_31 = 536882643 - 12;
                UnityEngine.Vector3 val_32 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 2.977437E-25f, y = mem[((normals + 0) + 16) + (0)], z = mem[((normals + 0) + 16) + (4)]}, rhs:  new UnityEngine.Vector3() {x = mem[((normals + 0) + 16) + (8)], y = (536882597 + 0) + 16, z = (536882597 + 0) + 20});
                var val_74 = val_34;
                val_28 = normals;
                var val_36 = 536882597 + 0;
                val_74 = val_74 * ((536882597 + 0) + 20);
                val_30 = 1f;
                if(mem[536882627] < 0)
            {
                    val_30 = -1f;
                if(mem[536882627] <= 0)
            {
                    val_30 = -1f;
            }
            
            }
            
                mem[536882643] = val_30;
                val_26 = 0 + 12;
                val_23 = 0 + 1;
                val_22 = 536882643 + 16;
            }
            while(val_23 < mem[1152921509283003048]);
        
        }
        public static UnityEngine.GameObject SetupVectorCanvas()
        {
            var val_7;
            var val_8;
            var val_9;
            UnityEngine.GameObject val_1 = UnityEngine.GameObject.Find(name:  -1610602789);
            val_7 = -1610602789;
            if((-1610602789) != 0)
            {
                    val_8 = val_7;
                Weight val_3 = val_8.GetComponent<Weight>();
            }
            else
            {
                    UnityEngine.GameObject val_4 = 536887303;
                val_7 = val_4;
                val_4 = new UnityEngine.GameObject(name:  -1610602789);
                int val_5 = UnityEngine.LayerMask.NameToLayer(layerName:  -1610603225);
                if(val_7 != 0)
            {
                    val_7.layer = val_5;
            }
            else
            {
                    val_7.layer = val_5;
            }
            
                val_8 = val_7;
                SynchronizationContextBehavoir val_6 = val_8.AddComponent<SynchronizationContextBehavoir>();
            }
            
            if(val_8 != 0)
            {
                    val_8.renderMode = 0;
            }
            else
            {
                    val_8.renderMode = 0;
            }
            
            val_8.sortingOrder = 1;
            val_9 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_9 = 536896697;
            }
            
            mem2[0] = val_8;
        }
        public static void SetCanvasCamera(UnityEngine.Camera cam)
        {
            var val_3;
            var val_4;
            val_3 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_3 = 536896697;
            }
            
            if((mem[536896789] + 12) == 0)
            {
                    UnityEngine.GameObject val_2 = Vectrosity.VectorLine.SetupVectorCanvas();
            }
            
            val_4 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_4 = 536896697;
            }
            
            mem[536896789] + 12.renderMode = 1;
            mem[536896789] + 12.worldCamera = cam;
        }
        public void SetCanvas(UnityEngine.GameObject canvasObject)
        {
            this.SetCanvas(canvasObject:  canvasObject, worldPositionStays:  true);
        }
        public void SetCanvas(UnityEngine.GameObject canvasObject, bool worldPositionStays)
        {
            Weight val_1 = canvasObject.GetComponent<Weight>();
            if(canvasObject == 0)
            {
                    UnityEngine.Debug.LogError(message:  -1610602721);
                return;
            }
            
            this.SetCanvas(canvas:  canvasObject, worldPositionStays:  worldPositionStays);
        }
        public void SetCanvas(UnityEngine.Canvas canvas)
        {
            this.SetCanvas(canvas:  canvas, worldPositionStays:  true);
        }
        public void SetCanvas(UnityEngine.Canvas canvas, bool worldPositionStays)
        {
            var val_5;
            if(this.m_canvasState != 2)
            {
                goto label_1;
            }
            
            val_5 = 22796876;
            goto label_10;
            label_1:
            if(canvas != 0)
            {
                goto label_7;
            }
            
            val_5 = 22796884;
            goto label_10;
            label_7:
            UnityEngine.RenderMode val_2 = canvas.renderMode;
            if(canvas != 2)
            {
                goto label_12;
            }
            
            val_5 = 22796880;
            label_10:
            UnityEngine.Debug.LogError(message:  -1610602725);
            return;
            label_12:
            UnityEngine.Transform val_3 = this.m_go.transform;
            UnityEngine.Transform val_4 = canvas.transform;
            this.m_go.SetParent(parent:  canvas, worldPositionStays:  worldPositionStays);
        }
        public void SetMask(UnityEngine.GameObject maskObject)
        {
            this.SetMask(maskObject:  maskObject, worldPositionStays:  true);
        }
        public void SetMask(UnityEngine.GameObject maskObject, bool worldPositionStays)
        {
            Weight val_1 = maskObject.GetComponent<Weight>();
            if(maskObject == 0)
            {
                    UnityEngine.Debug.LogError(message:  -1610602693);
                return;
            }
            
            this.SetMask(mask:  maskObject, worldPositionStays:  worldPositionStays);
        }
        public void SetMask(UnityEngine.UI.Mask mask)
        {
            this.SetMask(mask:  mask, worldPositionStays:  true);
        }
        public void SetMask(UnityEngine.UI.Mask mask, bool worldPositionStays)
        {
            var val_4;
            if(this.m_canvasState != 2)
            {
                goto label_1;
            }
            
            val_4 = 22796936;
            goto label_4;
            label_1:
            if(mask != 0)
            {
                goto label_7;
            }
            
            val_4 = 22796940;
            label_4:
            UnityEngine.Debug.LogError(message:  -1610602695);
            return;
            label_7:
            UnityEngine.Transform val_2 = this.m_go.transform;
            UnityEngine.Transform val_3 = mask.transform;
            this.m_go.SetParent(parent:  mask, worldPositionStays:  worldPositionStays);
        }
        private bool CheckCamera3D()
        {
            var val_3;
            var val_4;
            val_3 = 1;
            if(this.m_is2D == true)
            {
                    return (bool)val_3;
            }
            
            val_4 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_4 = 536896697;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  mem[536896789] + 20)) == true)
            {
                    return (bool)val_3;
            }
            
            Vectrosity.VectorLine.SetCamera3D();
            if((UnityEngine.Object.op_Implicit(exists:  mem[536896789] + 20)) == true)
            {
                    return (bool)val_3;
            }
            
            val_3 = 0;
            UnityEngine.Debug.LogError(message:  -1610606073);
            return (bool)val_3;
        }
        public static void SetCamera3D()
        {
            UnityEngine.Camera val_1 = UnityEngine.Camera.main;
            if(0 == 0)
            {
                    UnityEngine.Debug.LogError(message:  -1610602729);
                return;
            }
            
            UnityEngine.Camera val_3 = UnityEngine.Camera.main;
            Vectrosity.VectorLine.SetCamera3D(camera:  0);
        }
        public static void SetCamera3D(UnityEngine.GameObject cameraObject)
        {
            Weight val_1 = cameraObject.GetComponent<Weight>();
            if(cameraObject == 0)
            {
                    UnityEngine.Debug.LogError(message:  -1610602731);
                return;
            }
            
            Vectrosity.VectorLine.SetCamera3D(camera:  cameraObject);
        }
        public static void SetCamera3D(UnityEngine.Camera camera)
        {
            float val_3;
            float val_4;
            float val_5;
            var val_9;
            UnityEngine.Transform val_1 = camera.transform;
            val_9 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_9 = 536896697;
            }
            
            mem2[0] = camera;
            mem2[0] = camera;
            UnityEngine.Vector3 val_2 = position;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            float val_9 = val_3;
            float val_10 = val_4;
            float val_11 = val_5;
            val_9 = val_3 + val_9;
            val_10 = val_4 + val_10;
            val_11 = val_5 + val_11;
            mem2[0] = val_9;
            mem2[0] = val_10;
            mem2[0] = val_11;
            UnityEngine.Vector3 val_7 = eulerAngles;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            float val_12 = val_3;
            float val_13 = val_4;
            float val_14 = val_5;
            val_12 = val_3 + val_12;
            val_13 = val_4 + val_13;
            val_14 = val_5 + val_14;
            mem2[0] = val_12;
            mem2[0] = val_13;
            mem2[0] = val_14;
        }
        public static bool CameraHasMoved()
        {
            float val_3;
            float val_4;
            float val_5;
            var val_10;
            var val_11;
            var val_12;
            var val_14;
            var val_15;
            val_10 = 22716504;
            val_11 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_11 = 536896697;
            }
            
            var val_1 = mem[536896789] + 24;
            val_12 = mem[mem[536896789] + 16];
            val_12 = mem[536896789] + 16;
            UnityEngine.Vector3 val_2 = position;
            val_14 = 1;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = mem[(mem[536896789] + 24) + (0)], y = mem[(mem[536896789] + 24) + (4)], z = mem[(mem[536896789] + 24) + (8)]}, rhs:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_3})) == true)
            {
                    return (bool)UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = mem[(mem[536896789] + 36) + (0)], y = mem[(mem[536896789] + 36) + (4)], z = mem[(mem[536896789] + 36) + (8)]}, rhs:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_3});
            }
            
            val_15 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_15 = 536896697;
            }
            
            var val_7 = mem[536896789] + 36;
            val_12 = mem[mem[536896789] + 16];
            val_12 = mem[536896789] + 16;
            val_10 = 0;
            UnityEngine.Vector3 val_8 = eulerAngles;
            return (bool)UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = mem[(mem[536896789] + 36) + (0)], y = mem[(mem[536896789] + 36) + (4)], z = mem[(mem[536896789] + 36) + (8)]}, rhs:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_3});
        }
        public static void UpdateCameraInfo()
        {
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    536896697 = 536896697;
            }
            
            UnityEngine.Vector3 val_1 = position;
            var val_2 = mem[536896789] + 24;
            UnityEngine.Vector3 val_3 = eulerAngles;
            var val_4 = mem[536896789];
            val_4 = val_4 + 36;
        }
        public int GetSegmentNumber()
        {
            if(this.m_lineType == 2)
            {
                    return this.pointsCount;
            }
            
            int val_1 = this.pointsCount;
            if(this.m_lineType != 0)
            {
                    val_1 = val_1 + (val_1 >> 31);
                val_1 = val_1 >> 1;
                return (int)val_1;
            }
            
            if(val_1 == 0)
            {
                    return 0;
            }
            
            int val_2 = this.pointsCount;
            val_2 = val_2 - 1;
            return (int)val_2;
        }
        private void SetEndCapColors()
        {
            int val_9;
            UnityEngine.Color32[] val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            if(true < 4)
            {
                    return;
            }
            
            if(this.m_capType < 3)
            {
                goto label_3;
            }
            
            val_9 = this.m_vertexCount;
            val_10 = this.m_lineColors;
            goto label_4;
            label_3:
            val_9 = this.m_vertexCount;
            val_10 = this.m_lineColors;
            if(this.m_lineType == 0)
            {
                    1 = 2;
            }
            
            int val_1 = this.m_drawStart << 2;
            var val_9 = 3;
            label_11:
            var val_8 = val_9;
            val_11 = mem[this.m_lineColors];
            val_8 = val_9 + val_8;
            val_12 = val_8 + 4;
            if(this.m_useCapColors == false)
            {
                goto label_5;
            }
            
            val_13 = mem[1152921509285477928];
            if(val_11 != 0)
            {
                goto label_7;
            }
            
            goto label_7;
            label_5:
            var val_2 = val_11 + (val_1 << 2);
            val_13 = mem[(mem[this.m_lineColors] + ((this.m_drawStart << 2)) << 2) + 16];
            val_13 = (mem[this.m_lineColors] + ((this.m_drawStart << 2)) << 2) + 16;
            label_7:
            var val_3 = val_11 + (val_12 << 2);
            val_1 = val_1 + 1;
            val_9 = val_9 + 1;
            mem2[0] = val_13;
            if((mem[this.m_lineColors] + 12) != val_12)
            {
                goto label_11;
            }
            
            if(this.m_capType < 1)
            {
                goto label_12;
            }
            
            label_4:
            int val_4 = this.pointsCount;
            if(mem[1152921509285477904] == val_4)
            {
                    0 = 0;
            }
            
            if(mem[1152921509285477904] < val_4)
            {
                    0 = 1;
            }
            
            0 = 0 + mem[1152921509285477904];
            var val_12 = 0;
            if(this.m_lineType == 0)
            {
                    2 = 4;
            }
            
            0 = 0 * 4;
            0 = 0 - 8;
            if(0 <= 4)
            {
                    0 = 3;
            }
            
            label_19:
            var val_10 = val_9;
            val_12 = mem[this.m_lineColors];
            val_10 = val_12 + val_10;
            val_11 = val_10 + 4;
            if(this.m_useCapColors == false)
            {
                goto label_13;
            }
            
            val_13 = mem[1152921509285477932];
            if(val_12 != 0)
            {
                goto label_15;
            }
            
            goto label_15;
            label_13:
            var val_5 = 7 + val_12;
            var val_11 = 44;
            val_11 = val_12 + val_11;
            val_13 = mem[(mem[this.m_lineColors] + 44) + 0];
            val_13 = (mem[this.m_lineColors] + 44) + 0;
            label_15:
            var val_6 = val_12 + (val_11 << 2);
            val_12 = val_12 + 1;
            mem2[0] = val_13;
            if(val_12 != 4)
            {
                goto label_19;
            }
            
            label_12:
            if(mem[1152921509285477812] == 0)
            {
                    return;
            }
            
            var val_13 = mem[1152921509285477812];
            if((mem[1152921509285477812] + 178) == 0)
            {
                goto label_21;
            }
            
            val_13 = 0;
            label_23:
            val_11 = 0;
            if((mem[1152921509285477812] + 88 + 0) == 536888839)
            {
                goto label_22;
            }
            
            val_13 = val_13 + 1;
            val_11 = (uint)val_13 & 65535;
            if(val_11 < (mem[1152921509285477812] + 178))
            {
                goto label_23;
            }
            
            label_21:
            val_14 = mem[1152921509285477812];
            goto ((mem[1152921509285477812] + ((mem[1152921509285477812] + 88 + 0) + 4) << 3) + 212);
            label_22:
            var val_7 = (mem[1152921509285477812] + 88) + 0;
            val_13 = val_13 + (((mem[1152921509285477812] + 88 + 0) + 4) << 3);
            val_14 = val_13 + 212;
            goto ((mem[1152921509285477812] + ((mem[1152921509285477812] + 88 + 0) + 4) << 3) + 212);
        }
        public void SetEndCapColor(UnityEngine.Color32 color)
        {
            this.SetEndCapColor(frontColor:  new UnityEngine.Color32() {r = color.r, g = color.g, b = color.b, a = color.a}, backColor:  new UnityEngine.Color32() {r = color.r, g = color.g, b = color.b, a = color.a});
        }
        public void SetEndCapColor(UnityEngine.Color32 frontColor, UnityEngine.Color32 backColor)
        {
            if(this.m_capType == 4)
            {
                    string val_1 = -1610602707(-1610602707) + this.m_name + -1610612235(-1610612235);
                UnityEngine.Debug.LogError(message:  -1610602707);
                return;
            }
            
            this.m_useCapColors = true;
            this.m_frontColor = frontColor;
            this.m_backColor = backColor;
            this.SetEndCapColors();
        }
        public void SetEndCapIndex(Vectrosity.EndCap endCap, int index)
        {
            var val_3;
            if(this.m_capType != 4)
            {
                goto label_1;
            }
            
            string val_1 = -1610602703(-1610602703) + this.m_name + -1610612235(-1610612235);
            val_3 = -1610602703;
            goto label_4;
            label_1:
            if(endCap != 0)
            {
                goto label_5;
            }
            
            int val_2 = index & (~(index >> 31));
            if(endCap == 0)
            {
                goto label_6;
            }
            
            if(endCap == 3)
            {
                    this.m_backEndCapIndex = val_2;
            }
            
            return;
            label_5:
            val_3 = -1610602705;
            label_4:
            UnityEngine.Debug.LogError(message:  -1610602705);
            return;
            label_6:
            this.m_frontEndCapIndex = val_2;
        }
        public void SetColor(UnityEngine.Color32 color)
        {
            this.SetColor(color:  new UnityEngine.Color32() {r = color.r, g = color.g, b = color.b, a = color.a}, startIndex:  0, endIndex:  this.pointsCount);
        }
        public void SetColor(UnityEngine.Color32 color, int index)
        {
            this.SetColor(color:  new UnityEngine.Color32() {r = color.r, g = color.g, b = color.b, a = color.a}, startIndex:  index, endIndex:  index);
        }
        public void SetColor(UnityEngine.Color32 color, int startIndex, int endIndex)
        {
            UnityEngine.Color32[] val_12;
            int val_13;
            var val_14;
            var val_15;
            val_12 = startIndex;
            int val_1 = this.pointsCount;
            if(val_1 != this.m_pointsCount)
            {
                    val_1 = this;
                this.Resize();
            }
            
            int val_2 = this.GetSegmentNumber();
            val_13 = val_2 << 2;
            int val_4 = UnityEngine.Mathf.Clamp(value:  val_12 << 2, min:  0, max:  val_13);
            int val_10 = 4;
            val_10 = val_10 + (endIndex << 2);
            val_14 = 0;
            int val_5 = UnityEngine.Mathf.Clamp(value:  val_10, min:  0, max:  val_13);
            if(this.m_smoothColor == false)
            {
                goto label_1;
            }
            
            if(val_4 == 0)
            {
                    this.m_lineColors[0] = color;
                val_13 = this.m_lineColors;
                val_13[3] = color;
            }
            
            if(val_4 >= val_5)
            {
                goto label_19;
            }
            
            do
            {
                int val_6 = val_4 + 1;
                this.m_lineColors[val_4] = color;
                int val_7 = val_4 + 2;
                val_13 = val_4 + 4;
                this.m_lineColors[val_4] = color;
                if(val_13 < this.m_vertexCount)
            {
                    this.m_lineColors[val_4] = color;
                int val_8 = val_4 + 7;
                this.m_lineColors[val_4] = color;
            }
            
                val_12 = val_13;
            }
            while(val_13 < val_5);
            
            goto label_19;
            label_1:
            if(val_4 < val_5)
            {
                    do
            {
                val_12 = this.m_lineColors;
                val_13 = val_4 + 1;
                val_12[val_4] = color;
            }
            while(val_5 != val_13);
            
            }
            
            label_19:
            if(this.m_capType == 4)
            {
                goto label_25;
            }
            
            if(val_4 < 1)
            {
                goto label_24;
            }
            
            int val_11 = val_2;
            val_11 = val_11 - 1;
            if(val_5 < val_11)
            {
                goto label_25;
            }
            
            label_24:
            this.SetEndCapColors();
            label_25:
            if(this.m_vectorObject == 0)
            {
                    return;
            }
            
            val_12 = 0;
            val_13 = 0;
            val_12 = val_12 + 1;
            val_13 = (uint)val_12 & 65535;
            val_15 = this.m_vectorObject;
            goto mem[(1152921504869146624 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void SetColors(System.Collections.Generic.List<UnityEngine.Color32> lineColors)
        {
            Vectrosity.VectorLine val_21;
            var val_23;
            var val_24;
            var val_25;
            UnityEngine.Color32 val_26;
            UnityEngine.Color32 val_27;
            var val_28;
            var val_29;
            val_21 = this;
            if(lineColors == 0)
            {
                goto label_1;
            }
            
            int val_1 = this.pointsCount;
            if(val_1 != this.m_pointsCount)
            {
                    val_1 = val_21;
                this.Resize();
            }
            
            if(this.m_lineType != 2)
            {
                goto label_2;
            }
            
            if(R6 == this.pointsCount)
            {
                goto label_3;
            }
            
            string val_3 = -1610602717(-1610602717) + this.m_name + -1610612217(-1610612217);
            val_23 = -1610602717;
            goto label_6;
            label_1:
            val_23 = -1610602715;
            label_6:
            UnityEngine.Debug.LogError(message:  -1610602715);
            return;
            label_2:
            if((this.WrongArrayLength(arrayLength:  R6, functionName:  0)) == true)
            {
                    return;
            }
            
            label_3:
            Vectrosity.LineType val_18 = this.m_lineType;
            int val_5 = this.m_drawStart + (this.m_drawStart >> 31);
            if(val_18 == 1)
            {
                    val_24 = val_5 >> 1;
                val_5 = this.m_drawEnd + (this.m_drawEnd >> 31);
                this.m_drawEnd = this.m_drawEnd & 1;
                this.m_drawEnd = this.m_drawEnd + (val_5 >> 1);
            }
            
            if(val_18 == 1)
            {
                    return;
            }
            
            val_18 = val_18 - 2;
            val_25 = val_24 << 2;
            val_18 = val_18 >> 5;
            val_26 = this.m_drawEnd + val_18;
            if(this.m_smoothColor == false)
            {
                goto label_11;
            }
            
            if(val_18 <= val_24)
            {
                    var val_19 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_19 = val_19 + (val_24 << 2);
            this.m_lineColors[val_25] = (0 + (((this.m_drawStart + (this.m_drawStart) >> 31) >> 1)) << 2) + 16;
            if(val_21 <= val_24)
            {
                    var val_20 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_20 = val_20 + (val_24 << 2);
            this.m_lineColors[val_25 | 3] = (0 + (((this.m_drawStart + (this.m_drawStart) >> 31) >> 1)) << 2) + 16;
            if(val_21 <= val_24)
            {
                    var val_21 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_21 = val_21 + (val_24 << 2);
            this.m_lineColors[val_25 | 2] = (0 + (((this.m_drawStart + (this.m_drawStart) >> 31) >> 1)) << 2) + 16;
            if(val_21 <= val_24)
            {
                    var val_22 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_22 = val_22 + (val_24 << 2);
            val_27 = mem[(0 + (((this.m_drawStart + (this.m_drawStart) >> 31) >> 1)) << 2) + 16];
            val_27 = (0 + (((this.m_drawStart + (this.m_drawStart) >> 31) >> 1)) << 2) + 16;
            val_21 = val_21;
            this.m_lineColors[val_25 | 1] = val_27;
            if((val_24 + 1) >= val_26)
            {
                goto label_39;
            }
            
            int val_10 = val_26 - 1;
            do
            {
                if(val_10 <= val_24)
            {
                    var val_23 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_27 = val_25 + 4;
                val_23 = val_23 + val_25;
                this.m_lineColors[val_25] = (0 + (((this.m_drawStart + (this.m_drawStart) >> 31) >> 1) << 2)) + 16;
                if(val_21 <= val_24)
            {
                    var val_24 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_24 = val_24 + val_25;
                val_26 = mem[(0 + (((this.m_drawStart + (this.m_drawStart) >> 31) >> 1) << 2)) + 16];
                val_26 = (0 + (((this.m_drawStart + (this.m_drawStart) >> 31) >> 1) << 2)) + 16;
                int val_11 = val_25 + 7;
                val_24 = val_24 + 1;
                this.m_lineColors[val_25] = val_26;
                if(val_21 <= val_24)
            {
                    var val_25 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_25 = val_25 + val_25;
                int val_12 = val_25 + 6;
                this.m_lineColors[val_25] = (0 + (((this.m_drawStart + (this.m_drawStart) >> 31) >> 1) << 2)) + 20;
                if(val_21 <= val_24)
            {
                    var val_26 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_26 = val_26 + val_25;
                int val_13 = val_25 + 5;
                val_25 = val_27;
                this.m_lineColors[val_25] = (0 + (((this.m_drawStart + (this.m_drawStart) >> 31) >> 1) << 2)) + 20;
                val_21 = val_21;
            }
            while(val_10 != val_24);
            
            goto label_39;
            label_11:
            if(val_24 < val_26)
            {
                    do
            {
                if(val_18 <= val_24)
            {
                    var val_27 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_27 = val_27 + val_25;
                this.m_lineColors[val_25] = (0 + (((this.m_drawStart + (this.m_drawStart) >> 31) >> 1) << 2)) + 16;
                if(this.m_lineColors[val_25] <= val_24)
            {
                    var val_28 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_28 = val_28 + val_25;
                int val_14 = val_25 + 1;
                this.m_lineColors[val_25] = (0 + (((this.m_drawStart + (this.m_drawStart) >> 31) >> 1) << 2)) + 16;
                if(this.m_lineColors[val_25] <= val_24)
            {
                    var val_29 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_29 = val_29 + val_25;
                int val_15 = val_25 + 2;
                this.m_lineColors[val_25] = (0 + (((this.m_drawStart + (this.m_drawStart) >> 31) >> 1) << 2)) + 16;
                if(this.m_lineColors[val_25] <= val_24)
            {
                    var val_30 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_30 = val_30 + val_25;
                val_27 = mem[(0 + (((this.m_drawStart + (this.m_drawStart) >> 31) >> 1) << 2)) + 16];
                val_27 = (0 + (((this.m_drawStart + (this.m_drawStart) >> 31) >> 1) << 2)) + 16;
                int val_16 = val_25 + 3;
                val_24 = val_24 + 1;
                val_25 = val_25 + 4;
                this.m_lineColors[val_25] = val_27;
            }
            while(val_26 != val_24);
            
            }
            
            label_39:
            if(this.m_capType != 4)
            {
                    this.m_capType = val_21;
                this.SetEndCapColors();
            }
            
            if(this.m_vectorObject == 0)
            {
                    return;
            }
            
            val_25 = 0;
            val_28 = 0;
            val_25 = val_25 + 1;
            val_28 = (uint)val_25 & 65535;
            val_29 = this.m_vectorObject;
            goto mem[(1152921504869146624 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private void SetSegmentStartEnd(out int start, out int end)
        {
            if(this.m_lineType == 1)
            {
                    this.m_drawStart = (this.m_drawStart + (this.m_drawStart >> 31)) >> 1;
            }
            
            start = this.m_drawStart;
            end = this.m_drawEnd;
            if(this.m_lineType != 1)
            {
                    return;
            }
            
            int val_2 = this.m_drawEnd;
            val_2 = val_2 + (val_2 >> 31);
            val_2 = val_2 >> 1;
            end = val_2;
            if(this.m_drawEnd != 1)
            {
                    this.m_drawEnd = val_2 + 1;
                end = this.m_drawEnd;
            }
        
        }
        public UnityEngine.Color32 GetColor(int index)
        {
            UnityEngine.Color32 val_6;
            int val_6 = index;
            int val_1 = this.pointsCount;
            if(val_1 != this.m_pointsCount)
            {
                    val_1 = this;
                this.Resize();
            }
            
            if(this.m_vertexCount == 0)
            {
                goto label_1;
            }
            
            val_6 = 2 | (val_6 << 2);
            if((val_6 < 0) || (val_6 >= this.m_vertexCount))
            {
                goto label_3;
            }
            
            val_6 = this.m_lineColors[val_6];
            return new UnityEngine.Color32() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
            label_1:
            val_6 = this.m_color;
            return new UnityEngine.Color32() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
            label_3:
            string val_2 = index.ToString();
            string val_3 = -1610602779(-1610602779) + 385765076 + -1610612309(-1610612309);
            UnityEngine.Debug.LogError(message:  -1610602779);
            UnityEngine.Color val_4 = UnityEngine.Color.clear;
            UnityEngine.Color32 val_5 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
            return new UnityEngine.Color32() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
        }
        private void SetupWidths(int max)
        {
            System.Single[] val_1;
            if(max < 2)
            {
                    return;
            }
            
            val_1 = this.m_lineWidths;
            if(this != 1)
            {
                    val_1 = this.m_lineWidths;
                if(this == max)
            {
                    return;
            }
            
            }
            
            this.ResizeLineWidths(newSize:  max);
        }
        public void SetWidth(float width)
        {
            this.m_lineWidth = ;
            int val_1 = this.pointsCount;
            this.SetWidth(width:  width, startIndex:  R1, endIndex:  0);
        }
        public void SetWidth(float width, int index)
        {
            this.SetWidth(width:  width, startIndex:  index, endIndex:  0);
        }
        public void SetWidth(float width, int startIndex, int endIndex)
        {
            int val_8;
            int val_9;
            val_8 = R3;
            int val_1 = this.pointsCount;
            if(val_1 != this.m_pointsCount)
            {
                    val_1 = this;
                this.Resize();
            }
            
            int val_2 = this.GetSegmentNumber();
            this.SetupWidths(max:  val_2);
            val_9 = val_2 - 1;
            int val_8 = UnityEngine.Mathf.Clamp(value:  endIndex, min:  0, max:  UnityEngine.Mathf.Max(a:  val_9, b:  0));
            int val_6 = UnityEngine.Mathf.Clamp(value:  val_8, min:  0, max:  UnityEngine.Mathf.Max(a:  val_9, b:  0));
            if(val_8 > val_6)
            {
                    return;
            }
            
            val_8 = val_6;
            val_9 = 16 + (val_8 << 2);
            do
            {
                val_8 = val_8 + 1;
                val_9 = val_9 + 4;
                mem2[0] = startIndex * 0.5f;
            }
            while(val_8 <= val_8);
        
        }
        public void SetWidths(System.Collections.Generic.List<float> lineWidths)
        {
            this.SetWidths(lineWidthsFloat:  lineWidths, lineWidthsInt:  0, arrayLength:  0, doFloat:  true);
        }
        public void SetWidths(System.Collections.Generic.List<int> lineWidths)
        {
            this.SetWidths(lineWidthsFloat:  0, lineWidthsInt:  lineWidths, arrayLength:  0, doFloat:  false);
        }
        private void SetWidths(System.Collections.Generic.List<float> lineWidthsFloat, System.Collections.Generic.List<int> lineWidthsInt, int arrayLength, bool doFloat)
        {
            var val_6;
            System.Single[] val_7;
            var val_8;
            val_6 = lineWidthsInt;
            val_7 = lineWidthsFloat;
            if(val_7 == 0)
            {
                    if(doFloat == true)
            {
                goto label_3;
            }
            
            }
            
            if(doFloat == false)
            {
                goto label_3;
            }
            
            int val_1 = this.pointsCount;
            if(val_1 != this.m_pointsCount)
            {
                    val_1 = this;
                this.Resize();
            }
            
            if(this.m_lineType != 2)
            {
                goto label_4;
            }
            
            if(this.pointsCount == arrayLength)
            {
                goto label_5;
            }
            
            string val_3 = -1610602689(-1610602689) + this.m_name + -1610612241(-1610612241);
            val_8 = -1610602689;
            goto label_8;
            label_3:
            val_8 = -1610602687;
            label_8:
            UnityEngine.Debug.LogError(message:  -1610602687);
            return;
            label_4:
            bool val_4 = this.WrongArrayLength(arrayLength:  arrayLength, functionName:  1);
            if(val_4 == true)
            {
                    return;
            }
            
            label_5:
            if(val_4 != arrayLength)
            {
                    System.Array.Resize<System.Single>(array: ref  T[] val_5 = 386888852, newSize:  arrayLength);
            }
            
            if(doFloat != false)
            {
                    if(arrayLength < 1)
            {
                    return;
            }
            
                var val_9 = 0;
                do
            {
                if(1152921509288703124 <= val_9)
            {
                    float val_7 = 0f;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_7 = val_7 + 16;
                float val_8 = val_7;
                val_8 = val_8 * 0.5f;
                val_9 = val_9 + 1;
                val_6 = 16 + 4;
                mem2[0] = val_8;
            }
            while(arrayLength != val_9);
            
                return;
            }
            
            if(arrayLength < 1)
            {
                    return;
            }
            
            var val_11 = 0;
            do
            {
                val_7 = this.m_lineWidths;
                if(1152921509288703124 <= val_11)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_10 = val_10 + 0;
                val_11 = val_11 + 1;
                val_7[val_11] = ((float)(0 + 0) + 16) * 0.5f;
            }
            while(val_11 != arrayLength);
        
        }
        public float GetWidth(int index)
        {
            System.Single[] val_6;
            float val_7;
            val_6 = 22979048;
            int val_1 = this.pointsCount;
            if(val_1 != this.m_pointsCount)
            {
                    val_1 = this;
                this.Resize();
            }
            
            int val_2 = this.GetSegmentNumber();
            if(val_2 <= index)
            {
                    string val_3 = index.ToString();
                string val_4 = val_2.ToString();
                string val_5 = -1610602773(-1610602773) + 387115732 + -1610612307(-1610612307) + 387115728;
                UnityEngine.Debug.LogError(message:  -1610602773);
                val_7 = 0f;
                return val_7;
            }
            
            val_6 = this.m_lineWidths;
            if(val_2 > index)
            {
                    val_7 = this.m_lineWidths[index] + this.m_lineWidths[index];
                return val_7;
            }
            
            val_7 = this.m_lineWidth;
            return val_7;
        }
        public static Vectrosity.VectorLine SetLine(UnityEngine.Color color, UnityEngine.Vector2[] points)
        {
            Vectrosity.VectorLine val_1 = Vectrosity.VectorLine.SetLine(color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, time:  null, points:  0);
        }
        public static Vectrosity.VectorLine SetLine(UnityEngine.Color color, float time, UnityEngine.Vector2[] points)
        {
            System.Collections.Generic.IEnumerable<T> val_1;
            System.Collections.Generic.List<UnityEngine.Vector2> val_9;
            Vectrosity.VectorLine val_10;
            val_9 = 22979050;
            if((val_1 + 12) > 1)
            {
                    val_9 = 536878507;
                val_9 = new System.Collections.Generic.List<UnityEngine.Vector2>(collection:  val_1);
                val_10 = 536896697;
                val_10 = new Vectrosity.VectorLine(name:  -1610606657, points:  536878507, texture:  0, width:  time, lineType:  1065353216, joins:  0);
                UnityEngine.Color32 val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a});
                mem[536896737] = val_4.r;
                mem[536896738] = val_4.g;
                mem[536896739] = val_4.b;
                mem[536896740] = val_4.a;
                this.SetColor(color:  new UnityEngine.Color32() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a}, startIndex:  0, endIndex:  this.pointsCount);
                if(val_10 > 0)
            {
                    Vectrosity.LineManager val_6 = Vectrosity.VectorLine.lineManager;
                System.Collections.IEnumerator val_7 = 536896697.DisableLine(vectorLine:  536896697, time:  time, remove:  points);
                UnityEngine.Coroutine val_8 = 536896697.StartCoroutine(routine:  536896697);
            }
            
                this.Draw();
                return;
            }
            
            val_10 = 0;
            UnityEngine.Debug.LogError(message:  -1610602701);
        }
        public static Vectrosity.VectorLine SetLine(UnityEngine.Color color, UnityEngine.Vector3[] points)
        {
            Vectrosity.VectorLine val_1 = Vectrosity.VectorLine.SetLine(color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, time:  null, points:  0);
        }
        public static Vectrosity.VectorLine SetLine(UnityEngine.Color color, float time, UnityEngine.Vector3[] points)
        {
            System.Collections.Generic.IEnumerable<T> val_1;
            System.Collections.Generic.List<UnityEngine.Vector3> val_9;
            Vectrosity.VectorLine val_10;
            val_9 = 22979052;
            if((val_1 + 12) > 1)
            {
                    val_9 = 536878517;
                val_9 = new System.Collections.Generic.List<UnityEngine.Vector3>(collection:  val_1);
                val_10 = 536896697;
                val_10 = new Vectrosity.VectorLine(name:  -1610604637, points:  536878517, texture:  0, width:  time, lineType:  1065353216, joins:  0);
                UnityEngine.Color32 val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a});
                mem[536896737] = val_4.r;
                mem[536896738] = val_4.g;
                mem[536896739] = val_4.b;
                mem[536896740] = val_4.a;
                this.SetColor(color:  new UnityEngine.Color32() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a}, startIndex:  0, endIndex:  this.pointsCount);
                if(val_10 > 0)
            {
                    Vectrosity.LineManager val_6 = Vectrosity.VectorLine.lineManager;
                System.Collections.IEnumerator val_7 = 536896697.DisableLine(vectorLine:  536896697, time:  time, remove:  points);
                UnityEngine.Coroutine val_8 = 536896697.StartCoroutine(routine:  536896697);
            }
            
                this.Draw();
                return;
            }
            
            val_10 = 0;
            UnityEngine.Debug.LogError(message:  -1610602701);
        }
        public static Vectrosity.VectorLine SetLine3D(UnityEngine.Color color, UnityEngine.Vector3[] points)
        {
            Vectrosity.VectorLine val_1 = Vectrosity.VectorLine.SetLine3D(color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, time:  null, points:  0);
        }
        public static Vectrosity.VectorLine SetLine3D(UnityEngine.Color color, float time, UnityEngine.Vector3[] points)
        {
            System.Collections.Generic.IEnumerable<T> val_1;
            Vectrosity.VectorLine val_7;
            if((val_1 + 12) <= 1)
            {
                    val_7 = 0;
                UnityEngine.Debug.LogError(message:  -1610602699);
                return;
            }
            
            536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>(collection:  val_1);
            val_7 = 536896697;
            val_7 = new Vectrosity.VectorLine(name:  -1610604635, points:  536878517, texture:  0, width:  time, lineType:  1065353216, joins:  0);
            UnityEngine.Color32 val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a});
            if(val_7 != 0)
            {
                    mem[536896737] = val_4.r;
                mem[536896738] = val_4.g;
                mem[536896739] = val_4.b;
                mem[536896740] = val_4.a;
                this.SetColor(color:  new UnityEngine.Color32() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a}, startIndex:  0, endIndex:  this.pointsCount);
            }
            else
            {
                    mem[40] = val_4.r;
                mem[41] = val_4.g;
                mem[42] = val_4.b;
                mem[43] = val_4.a;
                this.SetColor(color:  new UnityEngine.Color32() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a}, startIndex:  0, endIndex:  this.pointsCount);
            }
            
            this.Draw3DAuto(time:  time);
        }
        public static Vectrosity.VectorLine SetRay(UnityEngine.Color color, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction)
        {
            float val_2;
            float val_3;
            float val_4;
            float val_5;
            val_2 = color.a;
            val_2 = val_2;
            val_3 = direction.z;
            val_4 = direction.y;
            val_5 = direction.x;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_2 = val_2;
                val_5 = direction.x;
                val_4 = direction.y;
                val_3 = direction.z;
            }
            
            Vectrosity.VectorLine val_1 = Vectrosity.VectorLine.SetRay(color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = val_2}, time:  null, origin:  new UnityEngine.Vector3() {x = 0f, y = origin.x, z = origin.y}, direction:  new UnityEngine.Vector3() {x = origin.z, y = val_5, z = val_4});
        }
        public static Vectrosity.VectorLine SetRay(UnityEngine.Color color, float time, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction)
        {
            float val_1;
            var val_2 = 536882597 + 16;
            UnityEngine.Ray val_3 = new UnityEngine.Ray(origin:  new UnityEngine.Vector3() {x = origin.y, y = origin.z, z = direction.x}, direction:  new UnityEngine.Vector3() {x = direction.y, y = direction.z, z = val_1});
            UnityEngine.Vector3 val_5 = GetPoint(distance:  direction.y.magnitude);
            var val_6 = 536882597 + 28;
            536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>(collection:  536882597);
            536896697 = new Vectrosity.VectorLine(name:  -1610604633, points:  536878517, texture:  0, width:  val_5.x, lineType:  1065353216, joins:  0);
            UnityEngine.Color32 val_9 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a});
            mem[536896737] = val_9.r;
            mem[536896738] = val_9.g;
            mem[536896739] = val_9.b;
            mem[536896740] = val_9.a;
            this.SetColor(color:  new UnityEngine.Color32() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a}, startIndex:  0, endIndex:  this.pointsCount);
            if(536896697 > 0)
            {
                    Vectrosity.LineManager val_11 = Vectrosity.VectorLine.lineManager;
                System.Collections.IEnumerator val_12 = 536896697.DisableLine(vectorLine:  536896697, time:  val_5.x, remove:  origin.x);
                UnityEngine.Coroutine val_13 = 536896697.StartCoroutine(routine:  536896697);
            }
            
            this.Draw();
        }
        public static Vectrosity.VectorLine SetRay3D(UnityEngine.Color color, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction)
        {
            float val_2;
            float val_3;
            float val_4;
            float val_5;
            val_2 = color.a;
            val_2 = val_2;
            val_3 = direction.z;
            val_4 = direction.y;
            val_5 = direction.x;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_2 = val_2;
                val_5 = direction.x;
                val_4 = direction.y;
                val_3 = direction.z;
            }
            
            Vectrosity.VectorLine val_1 = Vectrosity.VectorLine.SetRay3D(color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = val_2}, time:  null, origin:  new UnityEngine.Vector3() {x = 0f, y = origin.x, z = origin.y}, direction:  new UnityEngine.Vector3() {x = origin.z, y = val_5, z = val_4});
        }
        public static Vectrosity.VectorLine SetRay3D(UnityEngine.Color color, float time, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction)
        {
            float val_1;
            var val_2 = 536882597 + 16;
            UnityEngine.Ray val_3 = new UnityEngine.Ray(origin:  new UnityEngine.Vector3() {x = origin.y, y = origin.z, z = direction.x}, direction:  new UnityEngine.Vector3() {x = direction.y, y = direction.z, z = val_1});
            UnityEngine.Vector3 val_5 = GetPoint(distance:  direction.y.magnitude);
            var val_6 = 536882597 + 28;
            536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>(collection:  536882597);
            536896697 = new Vectrosity.VectorLine(name:  -1610604631, points:  536878517, texture:  0, width:  val_5.x, lineType:  1065353216, joins:  0);
            UnityEngine.Color32 val_9 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a});
            if(536896697 != 0)
            {
                    mem[536896737] = val_9.r;
                mem[536896738] = val_9.g;
                mem[536896739] = val_9.b;
                mem[536896740] = val_9.a;
                this.SetColor(color:  new UnityEngine.Color32() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a}, startIndex:  0, endIndex:  this.pointsCount);
            }
            else
            {
                    mem[40] = val_9.r;
                mem[41] = val_9.g;
                mem[42] = val_9.b;
                mem[43] = val_9.a;
                this.SetColor(color:  new UnityEngine.Color32() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a}, startIndex:  0, endIndex:  this.pointsCount);
            }
            
            this.Draw3DAuto(time:  val_5.x);
        }
        private void CheckNormals()
        {
            Vectrosity.IVectorObject val_3;
            var val_4;
            var val_5;
            var val_6;
            if((this.m_useNormals != false) && (this.m_normalsCalculated != true))
            {
                    val_3 = this.m_vectorObject;
                var val_2 = 0;
                val_2 = val_2 + 1;
                val_5 = val_3;
                this.m_normalsCalculated = true;
            }
            
            if(this.m_useTangents == false)
            {
                    return;
            }
            
            if(this.m_tangentsCalculated == true)
            {
                    return;
            }
            
            if((R4 + 36 + 178) == 0)
            {
                goto label_10;
            }
            
            var val_3 = 0;
            label_12:
            val_4 = 0;
            val_3 = mem[R4 + 36 + 88 + 0];
            val_3 = R4 + 36 + 88 + 0;
            if(val_3 == 536888839)
            {
                goto label_11;
            }
            
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            if(val_3 < (R4 + 36 + 178))
            {
                goto label_12;
            }
            
            label_10:
            val_6 = R4 + 36;
            goto label_13;
            label_11:
            var val_1 = (R4 + 36 + 88) + 0;
            var val_4 = (R4 + 36 + 88 + 0) + 4;
            val_4 = (R4 + 36) + (val_4 << 3);
            val_6 = val_4 + 236;
            label_13:
            mem2[0] = 1;
        }
        private void CheckLine(bool draw3D)
        {
            if(this.m_capType != 4)
            {
                    this.m_capType = this;
                this.DrawEndCap(draw3D:  draw3D);
            }
            
            if(this.m_continuousTexture == true)
            {
                    this.m_continuousTexture = this;
                this.SetContinuousTexture();
            }
            
            if(this.m_joins != 0)
            {
                    return;
            }
            
            R4.SetLastFillTriangles();
        }
        private void DrawEndCap(bool draw3D)
        {
            var val_7;
            var val_8;
            var val_9;
            Vectrosity.VectorLine val_141;
            bool val_142;
            var val_143;
            bool val_144;
            System.Collections.Generic.List<System.Int32> val_145;
            var val_146;
            var val_147;
            var val_148;
            float val_149;
            var val_150;
            var val_151;
            var val_152;
            var val_154;
            var val_155;
            var val_156;
            var val_157;
            var val_158;
            var val_159;
            val_141 = this;
            val_142 = draw3D;
            if(this.m_capType < 3)
            {
                goto label_1;
            }
            
            goto label_2;
            label_1:
            int val_152 = this.m_frontEndCapIndex;
            if(val_152 != 1)
            {
                    Vectrosity.LineType val_151 = this.m_lineType;
                val_151 = val_151 - 1;
                val_151 = val_151 >> 5;
                val_151 = val_152 & val_151;
                val_152 = val_152 + val_151;
                int val_1 = UnityEngine.Mathf.Clamp(value:  val_152, min:  this.m_drawStart, max:  this.m_drawEnd);
            }
            
            int val_2 = this.m_drawStart << 2;
            if(val_152 >= 2)
            {
                    0 = this.m_drawStart;
            }
            
            if(this.m_lineType == 1)
            {
                    this.m_lineType = val_2 + (val_2 >> 31);
            }
            
            if(this.m_lineType == 1)
            {
                    val_2 = this.m_lineType >> 1;
                this.m_lineType = 0 + (0 >> 31);
            }
            
            if(this.m_lineType == 1)
            {
                    0 = this.m_lineType >> 1;
            }
            
            if(val_142 != false)
            {
                    int val_3 = val_2 + (val_2 << 1);
                int val_4 = val_2 + 1;
                UnityEngine.Vector3 val_156 = this.m_screenPoints[(val_4 + (val_4 << 1)) << 2];
                UnityEngine.Vector3 val_157 = this.m_screenPoints[(val_4 + (val_4 << 1)) << 2];
                UnityEngine.Vector3 val_158 = this.m_screenPoints[(val_4 + (val_4 << 1)) << 2];
                val_156 = (this.m_screenPoints[val_3 << 2]) - val_156;
                val_157 = (this.m_screenPoints[val_3 << 2]) - val_157;
                val_158 = (this.m_screenPoints[val_3 << 2]) - val_158;
                UnityEngine.Vector3 val_6 = normalized;
                var val_161 = val_8;
                var val_160 = val_9;
                float val_159 = this.m_lineWidths[0];
                UnityEngine.Purchasing.IStoreExtension val_10 = mem[536896789] + 56.Item[this.m_endCap];
                val_160 = val_160 * val_159;
                val_161 = val_161 * val_159;
                val_159 = val_160 + val_160;
                UnityEngine.Purchasing.IStoreExtension val_14 = mem[536896789] + 56.Item[this.m_endCap];
                float val_15 = val_159 * (mem[536896789] + 56 + 16);
                float val_16 = (val_161 + val_161) * (mem[536896789] + 56 + 16);
                float val_17 = ((val_7 * val_159) + (val_7 * val_159)) * (mem[536896789] + 56 + 16);
                var val_162 = mem[536896789] + 56 + 24;
                float val_18 = val_15 * val_162;
                float val_19 = val_16 * val_162;
                val_162 = val_17 * val_162;
                UnityEngine.Vector3 val_163 = this.m_screenPoints[val_3 << 2];
                UnityEngine.Vector3 val_164 = this.m_screenPoints[val_3 << 2];
                UnityEngine.Vector3 val_165 = this.m_screenPoints[val_3 << 2];
                val_163 = val_17 + val_163;
                val_164 = val_16 + val_164;
                val_165 = val_15 + val_165;
                val_163 = val_162 + val_163;
                val_164 = val_19 + val_164;
                val_165 = val_18 + val_165;
                UnityEngine.Vector3 val_20 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_163, z = val_164});
                int val_166 = val_2;
                val_166 = val_166 + 3;
                int val_167 = val_166;
                val_167 = val_167 + (val_167 << 1);
                UnityEngine.Vector3 val_168 = this.m_screenPoints[val_167 << 2];
                UnityEngine.Vector3 val_169 = this.m_screenPoints[val_167 << 2];
                UnityEngine.Vector3 val_170 = this.m_screenPoints[val_167 << 2];
                val_168 = val_17 + val_168;
                val_169 = val_16 + val_169;
                val_170 = val_15 + val_170;
                val_168 = val_162 + val_168;
                val_169 = val_19 + val_169;
                val_170 = val_18 + val_170;
                UnityEngine.Vector3 val_22 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_168, z = val_169});
                int val_23 = this.m_vertexCount + 3;
                UnityEngine.Vector3 val_171 = this.m_screenPoints[val_3 << 2];
                UnityEngine.Vector3 val_172 = this.m_screenPoints[val_3 << 2];
                UnityEngine.Vector3 val_173 = this.m_screenPoints[val_3 << 2];
                val_171 = val_162 + val_171;
                val_172 = val_19 + val_172;
                val_173 = val_18 + val_173;
                UnityEngine.Vector3 val_25 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_171, z = val_172});
                UnityEngine.Vector3 val_174 = this.m_screenPoints[val_167 << 2];
                UnityEngine.Vector3 val_175 = this.m_screenPoints[val_167 << 2];
                UnityEngine.Vector3 val_176 = this.m_screenPoints[val_167 << 2];
                val_174 = val_162 + val_174;
                val_175 = val_19 + val_175;
                val_176 = val_18 + val_176;
                UnityEngine.Vector3 val_26 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_174, z = val_175});
            }
            else
            {
                    int val_27 = val_2 + (val_2 << 1);
                int val_28 = val_2 + 1;
                int val_29 = val_28 + (val_28 << 1);
                val_29 = this.m_lineVertices + (val_29 << 2);
                float val_180 = (this.m_lineVertices + ((((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + 1) + (((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + 1)) << 1)) << 2) + 16;
                float val_181 = (this.m_lineVertices + ((((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + 1) + (((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + 1)) << 1)) << 2) + 20;
                float val_182 = (this.m_lineVertices + ((((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + 1) + (((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + 1)) << 1)) << 2) + 24;
                val_180 = (this.m_lineVertices[val_27 << 2]) - val_180;
                val_181 = (this.m_lineVertices[val_27 << 2]) - val_181;
                val_182 = (this.m_lineVertices[val_27 << 2]) - val_182;
                UnityEngine.Vector3 val_30 = normalized;
                var val_185 = val_8;
                var val_184 = val_9;
                float val_183 = this.m_lineWidths[0];
                UnityEngine.Purchasing.IStoreExtension val_31 = mem[536896789] + 56.Item[this.m_endCap];
                val_184 = val_184 * val_183;
                var val_186 = mem[536896789] + 56 + 16;
                val_185 = val_185 * val_183;
                val_183 = val_184 + val_184;
                UnityEngine.Purchasing.IStoreExtension val_35 = mem[536896789] + 56.Item[this.m_endCap];
                float val_36 = val_183 * val_186;
                float val_37 = (val_185 + val_185) * val_186;
                var val_187 = mem[536896789] + 56 + 24;
                float val_38 = ((val_7 * val_183) + (val_7 * val_183)) * val_186;
                val_186 = val_36 * val_187;
                float val_39 = val_37 * val_187;
                val_187 = val_38 * val_187;
                UnityEngine.Vector3 val_188 = this.m_lineVertices[val_27 << 2];
                UnityEngine.Vector3 val_189 = this.m_lineVertices[val_27 << 2];
                UnityEngine.Vector3 val_190 = this.m_lineVertices[val_27 << 2];
                val_188 = val_38 + val_188;
                val_189 = val_37 + val_189;
                val_190 = val_36 + val_190;
                this.m_lineVertices[(this.m_vertexCount + (this.m_vertexCount << 1)) << 2] = val_187 + val_188;
                this.m_lineVertices[(this.m_vertexCount + (this.m_vertexCount << 1)) << 2] = val_39 + val_189;
                this.m_lineVertices[(this.m_vertexCount + (this.m_vertexCount << 1)) << 2] = val_186 + val_190;
                int val_191 = this.m_vertexCount;
                int val_44 = val_2 + 3;
                int val_45 = val_44 + (val_44 << 1);
                val_191 = val_191 + 3;
                var val_46 = this.m_lineVertices + (val_45 << 2);
                var val_192 = (this.m_lineVertices + ((((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + 3) + (((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + 3)) << 1)) << 2) + 16;
                var val_193 = (this.m_lineVertices + ((((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + 3) + (((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + 3)) << 1)) << 2) + 20;
                var val_194 = (this.m_lineVertices + ((((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + 3) + (((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + 3)) << 1)) << 2) + 24;
                val_192 = val_38 + val_192;
                val_193 = val_37 + val_193;
                val_194 = val_36 + val_194;
                val_37 = val_39 + val_193;
                var val_49 = val_191 + (val_191 << 1);
                val_49 = this.m_lineVertices + (val_49 << 2);
                mem2[0] = val_187 + val_192;
                mem2[0] = val_37;
                mem2[0] = val_186 + val_194;
                var val_50 = this.m_lineVertices + (val_27 << 2);
                float val_195 = (this.m_lineVertices + (((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + ((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1)) << 1)) << 2) + 16;
                float val_196 = (this.m_lineVertices + (((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + ((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1)) << 1)) << 2) + 20;
                float val_197 = (this.m_lineVertices + (((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + ((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1)) << 1)) << 2) + 24;
                val_195 = val_187 + val_195;
                val_196 = val_39 + val_196;
                val_197 = val_186 + val_197;
                mem2[0] = val_195;
                mem2[0] = val_196;
                mem2[0] = val_197;
                var val_51 = this.m_lineVertices + (val_45 << 2);
                float val_198 = (this.m_lineVertices + ((((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + 3) + (((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + 3)) << 1)) << 2) + 16;
                float val_199 = (this.m_lineVertices + ((((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + 3) + (((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + 3)) << 1)) << 2) + 20;
                float val_200 = (this.m_lineVertices + ((((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + 3) + (((((this.m_drawStart << 2) + ((this.m_drawStart << 2)) >> 31) >> 1) + 3)) << 1)) << 2) + 24;
                val_198 = val_187 + val_198;
                val_199 = val_39 + val_199;
                val_200 = val_186 + val_200;
                mem2[0] = val_198;
                mem2[0] = val_199;
                mem2[0] = val_200;
            }
            
            int val_52 = val_2 + 3;
            int val_53 = val_52 + (val_52 << 1);
            var val_54 = this.m_vertexCount + 2;
            val_53 = this.m_lineVertices + (val_53 << 2);
            val_2 = val_53 + 16;
            var val_55 = val_54 + (val_54 << 1);
            val_55 = this.m_lineVertices + (val_55 << 2);
            val_55 = val_55 + 16;
            int val_56 = val_2 + (val_2 << 1);
            var val_57 = this.m_vertexCount + 1;
            val_56 = this.m_lineVertices + (val_56 << 2);
            var val_58 = val_56 + 16;
            var val_59 = val_57 + (val_57 << 1);
            val_59 = this.m_lineVertices + (val_59 << 2);
            val_59 = val_59 + 16;
            val_144 = val_142;
            UnityEngine.Purchasing.IStoreExtension val_60 = mem[536896789] + 56.Item[this.m_endCap];
            if((mem[536896789] + 56) != 0)
            {
                    val_143 = val_144;
                UnityEngine.Purchasing.IStoreExtension val_61 = mem[536896789] + 56.Item[this.m_endCap];
                var val_62 = this.m_vertexCount + 1;
                var val_63 = val_62 + (val_62 << 1);
                val_63 = this.m_lineVertices + (val_63 << 2);
                var val_64 = this.m_vertexCount + 2;
                var val_65 = val_64 + (val_64 << 1);
                val_65 = this.m_lineVertices + (val_65 << 2);
                float val_201 = (this.m_lineVertices + (((this.m_vertexCount + 2) + ((this.m_vertexCount + 2)) << 1)) << 2) + 16;
                float val_202 = (this.m_lineVertices + (((this.m_vertexCount + 2) + ((this.m_vertexCount + 2)) << 1)) << 2) + 20;
                val_201 = ((this.m_lineVertices + (((this.m_vertexCount + 1) + ((this.m_vertexCount + 1)) << 1)) << 2) + 16) + val_201;
                val_202 = ((this.m_lineVertices + (((this.m_vertexCount + 1) + ((this.m_vertexCount + 1)) << 1)) << 2) + 20) + val_202;
                val_201 = val_201 * 0.5f;
                val_202 = val_202 * 0.5f;
                float val_66 = ((this.m_lineVertices + (((this.m_vertexCount + 1) + ((this.m_vertexCount + 1)) << 1)) << 2) + 24) + ((this.m_lineVertices + (((this.m_vertexCount + 2) + ((this.m_vertexCount + 2)) << 1)) << 2) + 24);
                val_66 = val_66 * 0.5f;
                this.ScaleCapVertices(offset:  this.m_vertexCount, scale:  val_66, center:  new UnityEngine.Vector3() {x = mem[536896789] + 56 + 32, y = val_201, z = val_202});
                val_144 = val_143;
            }
            
            val_145 = this.m_lineTriangles;
            val_146 = 22737168;
            val_145.set_Item(index:  0, value:  this.m_vertexCount);
            this.m_lineTriangles.set_Item(index:  1, value:  this.m_vertexCount + 1);
            this.m_lineTriangles.set_Item(index:  2, value:  this.m_vertexCount + 3);
            this.m_lineTriangles.set_Item(index:  3, value:  this.m_vertexCount + 1);
            this.m_lineTriangles.set_Item(index:  4, value:  this.m_vertexCount + 2);
            this.m_lineTriangles.set_Item(index:  5, value:  this.m_vertexCount + 3);
            if(this.m_capType < 1)
            {
                goto label_87;
            }
            
            label_2:
            int val_72 = this.pointsCount;
            if(this.m_drawEnd < val_72)
            {
                    0 = 1;
            }
            
            if(this.m_drawEnd == val_72)
            {
                    0 = 0;
            }
            
            int val_204 = this.m_backEndCapIndex;
            int val_73 = 0 + this.m_drawEnd;
            val_147 = val_73;
            if(val_204 != 1)
            {
                    Vectrosity.LineType val_203 = this.m_lineType;
                val_203 = val_203 - 1;
                val_203 = val_203 >> 5;
                val_203 = val_204 & val_203;
                val_204 = val_204 + val_203;
                int val_74 = UnityEngine.Mathf.Clamp(value:  val_204, min:  this.m_drawStart, max:  val_73);
                val_147 = val_74;
            }
            
            val_148 = 0;
            if(val_74 >= 2)
            {
                    if((val_73 - 1) < 0)
            {
                    val_148 = 0;
            }
            
            }
            
            int val_76 = val_147 << 2;
            if(this.m_lineType == 1)
            {
                    this.m_lineType = val_76 + (val_76 >> 31);
                val_148 = 0;
                val_76 = this.m_lineType >> 1;
            }
            
            if(val_76 <= 4)
            {
                    val_149 = 4;
            }
            
            if(val_144 != false)
            {
                    var val_77 = val_149 - 2;
                var val_78 = val_77 + (val_77 << 1);
                var val_79 = val_149 - 1;
                UnityEngine.Vector3 val_208 = this.m_screenPoints[(val_79 + (val_79 << 1)) << 2];
                UnityEngine.Vector3 val_209 = this.m_screenPoints[(val_79 + (val_79 << 1)) << 2];
                UnityEngine.Vector3 val_210 = this.m_screenPoints[(val_79 + (val_79 << 1)) << 2];
                val_208 = (this.m_screenPoints[val_78 << 2]) - val_208;
                val_209 = (this.m_screenPoints[val_78 << 2]) - val_209;
                val_210 = (this.m_screenPoints[val_78 << 2]) - val_210;
                UnityEngine.Vector3 val_81 = normalized;
                var val_213 = val_8;
                var val_212 = val_9;
                float val_211 = this.m_lineWidths[val_148];
                val_150 = 536896697;
                if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_150 = 536896697;
            }
            
                UnityEngine.Purchasing.IStoreExtension val_82 = mem[536896789] + 56.Item[this.m_endCap];
                val_212 = val_212 * val_211;
                val_213 = val_213 * val_211;
                val_211 = val_212 + val_212;
                UnityEngine.Purchasing.IStoreExtension val_86 = mem[536896789] + 56.Item[this.m_endCap];
                float val_87 = val_211 * (mem[536896789] + 56 + 20);
                float val_88 = (val_213 + val_213) * (mem[536896789] + 56 + 20);
                float val_89 = ((val_7 * val_211) + (val_7 * val_211)) * (mem[536896789] + 56 + 20);
                var val_214 = mem[536896789] + 56 + 28;
                float val_90 = val_87 * val_214;
                float val_91 = val_88 * val_214;
                val_214 = val_89 * val_214;
                UnityEngine.Vector3 val_215 = this.m_screenPoints[val_78 << 2];
                UnityEngine.Vector3 val_216 = this.m_screenPoints[val_78 << 2];
                UnityEngine.Vector3 val_217 = this.m_screenPoints[val_78 << 2];
                val_215 = val_89 + val_215;
                val_216 = val_88 + val_216;
                val_217 = val_87 + val_217;
                val_215 = val_214 + val_215;
                val_216 = val_91 + val_216;
                val_217 = val_90 + val_217;
                UnityEngine.Vector3 val_92 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_215, z = val_216});
                int val_93 = this.m_vertexCount + 6;
                var val_95 = val_149 - 3;
                var val_96 = val_95 + (val_95 << 1);
                UnityEngine.Vector3 val_218 = this.m_screenPoints[val_96 << 2];
                UnityEngine.Vector3 val_219 = this.m_screenPoints[val_96 << 2];
                UnityEngine.Vector3 val_220 = this.m_screenPoints[val_96 << 2];
                val_218 = val_89 + val_218;
                val_219 = val_88 + val_219;
                val_220 = val_87 + val_220;
                val_218 = val_214 + val_218;
                val_219 = val_91 + val_219;
                val_220 = val_90 + val_220;
                UnityEngine.Vector3 val_97 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_218, z = val_219});
                int val_98 = this.m_vertexCount + 5;
                UnityEngine.Vector3 val_221 = this.m_screenPoints[val_96 << 2];
                UnityEngine.Vector3 val_222 = this.m_screenPoints[val_96 << 2];
                UnityEngine.Vector3 val_223 = this.m_screenPoints[val_96 << 2];
                val_221 = val_214 + val_221;
                val_222 = val_91 + val_222;
                val_223 = val_90 + val_223;
                UnityEngine.Vector3 val_100 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_221, z = val_222});
                val_149 = val_149;
                UnityEngine.Vector3 val_224 = this.m_screenPoints[val_78 << 2];
                UnityEngine.Vector3 val_225 = this.m_screenPoints[val_78 << 2];
                UnityEngine.Vector3 val_226 = this.m_screenPoints[val_78 << 2];
                val_224 = val_214 + val_224;
                val_225 = val_91 + val_225;
                val_226 = val_90 + val_226;
                UnityEngine.Vector3 val_101 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_224, z = val_225});
            }
            else
            {
                    var val_102 = val_149 - 2;
                var val_103 = val_102 + (val_102 << 1);
                var val_104 = val_149 - 1;
                var val_105 = val_104 + (val_104 << 1);
                val_105 = this.m_lineVertices + (val_105 << 2);
                float val_230 = (this.m_lineVertices + (((val_149 - 1) + ((val_149 - 1)) << 1)) << 2) + 16;
                float val_231 = (this.m_lineVertices + (((val_149 - 1) + ((val_149 - 1)) << 1)) << 2) + 20;
                float val_232 = (this.m_lineVertices + (((val_149 - 1) + ((val_149 - 1)) << 1)) << 2) + 24;
                val_230 = (this.m_lineVertices[val_103 << 2]) - val_230;
                val_231 = (this.m_lineVertices[val_103 << 2]) - val_231;
                val_232 = (this.m_lineVertices[val_103 << 2]) - val_232;
                UnityEngine.Vector3 val_106 = normalized;
                var val_235 = val_8;
                var val_234 = val_9;
                float val_233 = this.m_lineWidths[val_148];
                val_152 = 536896697;
                if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_152 = 536896697;
            }
            
                UnityEngine.Purchasing.IStoreExtension val_107 = mem[536896789] + 56.Item[this.m_endCap];
                val_234 = val_234 * val_233;
                var val_236 = mem[536896789] + 56 + 20;
                val_235 = val_235 * val_233;
                val_233 = val_234 + val_234;
                UnityEngine.Purchasing.IStoreExtension val_111 = mem[536896789] + 56.Item[this.m_endCap];
                float val_112 = val_233 * val_236;
                float val_113 = (val_235 + val_235) * val_236;
                var val_237 = mem[536896789] + 56 + 28;
                float val_114 = ((val_7 * val_233) + (val_7 * val_233)) * val_236;
                int val_238 = this.m_vertexCount;
                val_236 = val_112 * val_237;
                float val_115 = val_113 * val_237;
                val_237 = val_114 * val_237;
                val_238 = val_238 + 6;
                UnityEngine.Vector3 val_239 = this.m_lineVertices[val_103 << 2];
                UnityEngine.Vector3 val_240 = this.m_lineVertices[val_103 << 2];
                UnityEngine.Vector3 val_241 = this.m_lineVertices[val_103 << 2];
                val_239 = val_114 + val_239;
                val_240 = val_113 + val_240;
                val_241 = val_112 + val_241;
                this.m_lineVertices[(val_238 + (val_238 << 1)) << 2] = val_237 + val_239;
                this.m_lineVertices[(val_238 + (val_238 << 1)) << 2] = val_115 + val_240;
                this.m_lineVertices[(val_238 + (val_238 << 1)) << 2] = val_236 + val_241;
                val_154 = mem[this.m_lineVertices + 12];
                val_154 = this.m_lineVertices + 12;
                var val_120 = val_149 - 3;
                if(val_154 <= val_120)
            {
                    val_154 = mem[this.m_lineVertices + 12];
                val_154 = this.m_lineVertices + 12;
            }
            
                var val_121 = val_120 + (val_120 << 1);
                val_151 = this.m_vertexCount + 5;
                var val_122 = this.m_lineVertices + (val_121 << 2);
                var val_242 = (this.m_lineVertices + (((val_149 - 3) + ((val_149 - 3)) << 1)) << 2) + 16;
                var val_243 = (this.m_lineVertices + (((val_149 - 3) + ((val_149 - 3)) << 1)) << 2) + 20;
                var val_244 = (this.m_lineVertices + (((val_149 - 3) + ((val_149 - 3)) << 1)) << 2) + 24;
                val_242 = val_114 + val_242;
                val_243 = val_113 + val_243;
                val_244 = val_112 + val_244;
                val_113 = val_115 + val_243;
                var val_125 = val_151 + (val_151 << 1);
                val_125 = this.m_lineVertices + (val_125 << 2);
                mem2[0] = val_237 + val_242;
                mem2[0] = val_113;
                mem2[0] = val_236 + val_244;
                var val_126 = this.m_lineVertices + (val_121 << 2);
                float val_245 = (this.m_lineVertices + (((val_149 - 3) + ((val_149 - 3)) << 1)) << 2) + 16;
                float val_246 = (this.m_lineVertices + (((val_149 - 3) + ((val_149 - 3)) << 1)) << 2) + 20;
                float val_247 = (this.m_lineVertices + (((val_149 - 3) + ((val_149 - 3)) << 1)) << 2) + 24;
                val_245 = val_237 + val_245;
                val_246 = val_115 + val_246;
                val_247 = val_236 + val_247;
                mem2[0] = val_245;
                mem2[0] = val_246;
                mem2[0] = val_247;
                var val_248 = val_103;
                val_248 = this.m_lineVertices + (val_248 << 2);
                float val_249 = (this.m_lineVertices + (((val_149 - 2) + ((val_149 - 2)) << 1)) << 2) + 16;
                float val_250 = (this.m_lineVertices + (((val_149 - 2) + ((val_149 - 2)) << 1)) << 2) + 20;
                float val_251 = (this.m_lineVertices + (((val_149 - 2) + ((val_149 - 2)) << 1)) << 2) + 24;
                val_249 = val_237 + val_249;
                val_250 = val_115 + val_250;
                val_251 = val_236 + val_251;
                mem2[0] = val_249;
                mem2[0] = val_250;
                mem2[0] = val_251;
            }
            
            val_155 = mem[this.m_lineVertices + 12];
            val_155 = this.m_lineVertices + 12;
            var val_127 = val_149 - 3;
            if(val_155 <= val_127)
            {
                    val_155 = mem[this.m_lineVertices + 12];
                val_155 = this.m_lineVertices + 12;
            }
            
            var val_128 = val_127 + (val_127 << 1);
            var val_129 = this.m_vertexCount + 4;
            val_128 = this.m_lineVertices + (val_128 << 2);
            val_149 = val_128 + 16;
            var val_130 = val_129 + (val_129 << 1);
            val_130 = this.m_lineVertices + (val_130 << 2);
            val_130 = val_130 + 16;
            val_156 = mem[this.m_vertexCount];
            val_156 = this.m_vertexCount;
            val_157 = mem[this.m_lineVertices + 12];
            val_157 = this.m_lineVertices + 12;
            var val_131 = val_149 - 2;
            if(val_157 <= val_131)
            {
                    val_157 = mem[this.m_lineVertices + 12];
                val_157 = this.m_lineVertices + 12;
            }
            
            var val_132 = val_131 + (val_131 << 1);
            var val_133 = val_156 + 7;
            val_132 = this.m_lineVertices + (val_132 << 2);
            var val_134 = val_132 + 16;
            val_141 = val_141;
            var val_135 = val_133 + (val_133 << 1);
            val_135 = this.m_lineVertices + (val_135 << 2);
            val_135 = val_135 + 16;
            val_158 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_158 = 536896697;
            }
            
            val_146 = 22725744;
            UnityEngine.Purchasing.IStoreExtension val_136 = mem[536896789] + 56.Item[this.m_endCap];
            if((mem[536896789] + 56) != 0)
            {
                    val_159 = 536896697;
                val_156 = mem[this.m_vertexCount];
                val_156 = this.m_vertexCount;
                if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_159 = 536896697;
            }
            
                UnityEngine.Purchasing.IStoreExtension val_137 = mem[536896789] + 56.Item[this.m_endCap];
                var val_138 = this.m_vertexCount + 4;
                val_146 = mem[this.m_vertexCount];
                val_146 = this.m_vertexCount;
                var val_139 = val_138 + (val_138 << 1);
                val_139 = this.m_lineVertices + (val_139 << 2);
                var val_140 = val_146 + 7;
                var val_141 = val_140 + (val_140 << 1);
                val_141 = this.m_lineVertices + (val_141 << 2);
                float val_252 = (this.m_lineVertices + (((this.m_vertexCount + 7) + ((this.m_vertexCount + 7)) << 1)) << 2) + 16;
                float val_253 = (this.m_lineVertices + (((this.m_vertexCount + 7) + ((this.m_vertexCount + 7)) << 1)) << 2) + 20;
                val_252 = ((this.m_lineVertices + (((this.m_vertexCount + 4) + ((this.m_vertexCount + 4)) << 1)) << 2) + 16) + val_252;
                val_253 = ((this.m_lineVertices + (((this.m_vertexCount + 4) + ((this.m_vertexCount + 4)) << 1)) << 2) + 20) + val_253;
                val_252 = val_252 * 0.5f;
                val_253 = val_253 * 0.5f;
                float val_143 = ((this.m_lineVertices + (((this.m_vertexCount + 4) + ((this.m_vertexCount + 4)) << 1)) << 2) + 24) + ((this.m_lineVertices + (((this.m_vertexCount + 7) + ((this.m_vertexCount + 7)) << 1)) << 2) + 24);
                val_143 = val_143 * 0.5f;
                this.ScaleCapVertices(offset:  val_156 + 4, scale:  val_143, center:  new UnityEngine.Vector3() {x = mem[536896789] + 56 + 36, y = val_252, z = val_253});
            }
            
            val_145 = 22737168;
            val_145.set_Item(index:  6, value:  this.m_vertexCount + 4);
            val_145.set_Item(index:  7, value:  this.m_vertexCount + 5);
            val_145.set_Item(index:  8, value:  this.m_vertexCount + 7);
            val_145.set_Item(index:  9, value:  this.m_vertexCount + 5);
            val_145.set_Item(index:  10, value:  this.m_vertexCount + 6);
            val_145.set_Item(index:  11, value:  this.m_vertexCount + 7);
            label_87:
            if(this.m_drawStart <= 0)
            {
                    if(this.m_drawEnd >= this.pointsCount)
            {
                    return;
            }
            
            }
            
            this.SetEndCapColors();
        }
        private void ScaleCapVertices(int offset, float scale, UnityEngine.Vector3 center)
        {
            float val_1;
            UnityEngine.Vector3 val_9 = this.m_lineVertices[(offset + (offset << 1)) << 2];
            UnityEngine.Vector3 val_10 = this.m_lineVertices[(offset + (offset << 1)) << 2];
            UnityEngine.Vector3 val_11 = this.m_lineVertices[(offset + (offset << 1)) << 2];
            val_9 = val_9 - center.y;
            val_10 = val_10 - center.z;
            val_11 = val_11 - val_1;
            mem2[0] = center.y;
            mem2[0] = center.z;
            mem2[0] = val_1;
            int val_3 = offset + 1;
            UnityEngine.Vector3 val_12 = this.m_lineVertices[(val_3 + (val_3 << 1)) << 2];
            UnityEngine.Vector3 val_13 = this.m_lineVertices[(val_3 + (val_3 << 1)) << 2];
            UnityEngine.Vector3 val_14 = this.m_lineVertices[(val_3 + (val_3 << 1)) << 2];
            val_12 = val_12 - center.y;
            val_13 = val_13 - center.z;
            val_14 = val_14 - val_1;
            mem2[0] = center.y;
            mem2[0] = center.z;
            mem2[0] = val_1;
            int val_5 = offset + 2;
            UnityEngine.Vector3 val_15 = this.m_lineVertices[(val_5 + (val_5 << 1)) << 2];
            UnityEngine.Vector3 val_16 = this.m_lineVertices[(val_5 + (val_5 << 1)) << 2];
            UnityEngine.Vector3 val_17 = this.m_lineVertices[(val_5 + (val_5 << 1)) << 2];
            val_15 = val_15 - center.y;
            val_16 = val_16 - center.z;
            val_17 = val_17 - val_1;
            mem2[0] = center.y;
            mem2[0] = center.z;
            mem2[0] = val_1;
            int val_7 = offset + 3;
            UnityEngine.Vector3 val_18 = this.m_lineVertices[(val_7 + (val_7 << 1)) << 2];
            UnityEngine.Vector3 val_19 = this.m_lineVertices[(val_7 + (val_7 << 1)) << 2];
            UnityEngine.Vector3 val_20 = this.m_lineVertices[(val_7 + (val_7 << 1)) << 2];
            val_18 = val_18 - center.y;
            val_19 = val_19 - center.z;
            val_20 = val_20 - val_1;
            mem2[0] = center.y;
            mem2[0] = center.z;
            mem2[0] = val_1;
        }
        private void SetContinuousTexture()
        {
            var val_4;
            var val_5;
            var val_6;
            System.Single[] val_7;
            var val_8;
            var val_9;
            var val_10;
            val_4 = this;
            val_5 = val_4;
            this.SetDistances();
            val_6 = this.m_distances;
            if(this.m_distances != null)
            {
                goto label_1;
            }
            
            val_7 = this.m_distances;
            if(val_7 == null)
            {
                goto label_2;
            }
            
            label_1:
            var val_1 = R8 - 1;
            if(val_1 >= 1)
            {
                    do
            {
                this.m_lineUVs[0] = 0f;
                this.m_lineUVs[0] = 0f;
                float val_3 = val_7[val_1] / this.m_distances[0];
                val_3 = 1f / val_3;
                var val_4 = (0 + 3) - 2;
                this.m_lineUVs[0] = val_3;
                val_4 = val_4 + 1;
                val_8 = 1 + 1;
                var val_5 = val_4 + 2;
                val_9 = 0 + 32;
                this.m_lineUVs[0] = val_3;
            }
            while(R8 != val_8);
            
            }
            
            if(this.m_vectorObject == 0)
            {
                    return;
            }
            
            val_8 = 0;
            val_9 = 0;
            val_8 = val_8 + 1;
            val_9 = (uint)val_8 & 65535;
            val_10 = this.m_vectorObject;
            val_5 = this.m_vectorObject;
            goto mem[(1152921504869146624 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
            label_2:
        }
        private bool UseMatrix(out UnityEngine.Matrix4x4 thisMatrix)
        {
            var val_8;
            UnityEngine.Transform val_9;
            var val_15;
            var val_16;
            val_8 = 1152921509294297296;
            val_9 = this.m_drawTransform;
            if(val_9 == 0)
            {
                goto label_3;
            }
            
            UnityEngine.Matrix4x4 val_2 = localToWorldMatrix;
            val_15 = val_2.m13 + 64;
            val_16 = 1;
            goto label_5;
            label_3:
            if(this.m_useMatrix == false)
            {
                goto label_6;
            }
            
            val_16 = 1;
            goto label_7;
            label_6:
            UnityEngine.Matrix4x4 val_3 = UnityEngine.Matrix4x4.identity;
            val_15 = val_3.m13 + 64;
            label_5:
            label_7:
            float val_4 = val_3.m32 - 24;
            return (bool)val_3.m12;
        }
        private bool CheckPointCount()
        {
            int val_3;
            var val_4;
            val_3 = 1;
            if(this.m_lineType == 2)
            {
                    2 = 1;
            }
            
            if(this.pointsCount >= 1)
            {
                    return (bool)val_3;
            }
            
            this.ClearTriangles();
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_4 = this.m_vectorObject;
            this.m_pointsCount = this.pointsCount;
            val_3 = 0;
            this.m_drawEnd = val_3;
            return (bool)val_3;
        }
        private void ClearTriangles()
        {
            var val_1;
            if(this.m_capType == 4)
            {
                    this.m_lineTriangles.Clear();
                return;
            }
            
            if(this.m_lineTriangles != 0)
            {
                
            }
            else
            {
                    val_1 = 0;
            }
            
            this.m_lineTriangles.RemoveRange(index:  12, count:  val_1 - 12);
        }
        private void SetupDrawStartEnd(out int start, out int end, bool clearVertices)
        {
            start = 0;
            int val_4 = this.m_pointsCount;
            val_4 = val_4 - 1;
            end = val_4;
            if(this.m_drawStart >= 1)
            {
                    start = this.m_drawStart;
                if(this.m_lineType == 1)
            {
                    int val_1 = this.pointsCount;
                val_1 = val_1 - 1;
                if(this.m_drawStart == val_1)
            {
                    val_1 = start;
                val_1 = val_1 + 1;
                start = val_1;
            }
            
            }
            
                if(clearVertices != false)
            {
                    this.ZeroVertices(startIndex:  0, endIndex:  start);
            }
            
            }
            
            int val_5 = this.m_pointsCount;
            val_5 = val_5 - 1;
            if(this.m_drawEnd < val_5)
            {
                    int val_2 = this.m_drawEnd & (~(this.m_drawEnd >> 31));
                end = val_2;
                if(clearVertices != false)
            {
                    this.ZeroVertices(startIndex:  val_2, endIndex:  this.m_pointsCount);
            }
            
            }
            
            if(this.m_endPointsUpdate < 1)
            {
                    return;
            }
            
            int val_6 = end;
            val_6 = val_6 - this.m_endPointsUpdate;
            start = UnityEngine.Mathf.Max(a:  0, b:  val_6);
        }
        private void ZeroVertices(int startIndex, int endIndex)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_15;
            val_10 = endIndex;
            int val_9 = startIndex;
            if(this.m_lineType == 1)
            {
                    val_11 = val_9 << 1;
                if(val_11 >= (val_10 << 1))
            {
                    return;
            }
            
                val_9 = 20 + ((val_9 + (val_9 << 1)) << 3);
                do
            {
                val_12 = 536896697;
                if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_12 = 536896697;
            }
            
                mem2[0] = mem[mem[536896789] + (4)];
                mem2[0] = mem[536896789];
                mem2[0] = mem[mem[536896789] + (8)];
                int val_3 = val_11 + 1;
                val_9 = val_9 + 24;
                val_11 = val_11 + 2;
            }
            while(val_11 < (val_10 << 1));
            
                return;
            }
            
            endIndex = val_10 << 2;
            if(this.m_vertexCount < (val_10 << 2))
            {
                    endIndex = 3 + (val_10 << 2);
            }
            
            if(endIndex <= (val_9 << 2))
            {
                    return;
            }
            
            int val_5 = val_9 << 2;
            val_9 = 32 + ((val_9 + (val_9 << 1)) << 4);
            do
            {
                val_15 = 536896697;
                if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_15 = 536896697;
            }
            
                this.m_lineVertices[val_9] = this.m_lineVertices[val_9] - 16;
                int val_6 = val_5 + 1;
                mem2[0] = mem[mem[536896789] + (4)];
                mem2[0] = mem[536896789];
                mem2[0] = mem[mem[536896789] + (8)];
                int val_7 = val_5 + 2;
                int val_8 = val_5 + 3;
                val_9 = val_9 + 48;
                val_10 = val_5 + 4;
            }
            while(val_10 < endIndex);
        
        }
        private void SetupCanvasState(Vectrosity.CanvasState wantedState)
        {
            UnityEngine.GameObject val_34;
            UnityEngine.Material val_35;
            var val_36;
            UnityEngine.Material val_37;
            UnityEngine.Texture val_38;
            var val_39;
            var val_40;
            var val_41;
            Vectrosity.IVectorObject val_42;
            var val_43;
            val_34 = this.m_go;
            var val_34 = mem[536891407];
            val_34 = val_34 & 512;
            if(wantedState != 1)
            {
                goto label_1;
            }
            
            if(val_34 == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = this.m_go.transform;
            if(this.m_go != 0)
            {
                goto label_48;
            }
            
            goto label_48;
            label_1:
            if(val_34 == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_4 = this.m_go.transform;
            this.m_go.SetParent(p:  0);
            this.m_canvasState = 2;
            Weight val_5 = this.m_go.GetComponent<Weight>();
            if(this.m_go != 0)
            {
                    Weight val_7 = this.m_go.GetComponent<Weight>();
                UnityEngine.Object.DestroyImmediate(obj:  this.m_go);
                Weight val_8 = this.m_go.GetComponent<Weight>();
                UnityEngine.Object.DestroyImmediate(obj:  this.m_go);
            }
            
            Weight val_9 = this.m_go.GetComponent<Weight>();
            this.m_vectorObject = this.m_go;
            if(this.m_vectorObject == 0)
            {
                    SynchronizationContextBehavoir val_10 = this.m_go.AddComponent<SynchronizationContextBehavoir>();
                mem[1152921509295501428] = this.m_go;
            }
            
            val_35 = this.m_material;
            val_36 = 0;
            val_37 = 1;
            if(val_35 == 0)
            {
                    UnityEngine.Object val_12 = UnityEngine.Resources.Load(path:  -1610608809);
                if((-1610608809) != 0)
            {
                    val_35 = mem[mem[2684358487] + 180];
                val_35 = mem[2684358487] + 180;
                if(val_35 >= mem[536890441])
            {
                    var val_35 = mem[2684358487] + 100;
                val_35 = val_35 + (mem[536890441] << 2);
                if(((mem[2684358487] + 100 + (mem[536890441]) << 2) + -4) != 536890261)
            {
                    -1610608809 = 0;
            }
            
                val_36 = -1610608809;
            }
            
            }
            
                val_37 = 0;
                if(0 == 0)
            {
                    UnityEngine.Debug.LogError(message:  -1610606101);
                return;
            }
            
                UnityEngine.Material val_14 = 536890261;
                val_14 = new UnityEngine.Material(source:  0);
                this.m_material = val_14;
            }
            
            val_34 = this.m_vectorObject;
            val_38 = this.m_texture;
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_39 = val_34;
            return;
            label_48:
            UnityEngine.Transform val_16 = this.m_go.parent;
            if(this.m_go == 0)
            {
                goto label_42;
            }
            
            UnityEngine.Transform val_18 = this.m_go.GetComponent<UnityEngine.Transform>();
            if(this.m_go != 0)
            {
                goto label_46;
            }
            
            if(this.m_go != 0)
            {
                goto label_48;
            }
            
            goto label_48;
            label_42:
            val_40 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_40 = 536896697;
            }
            
            if((mem[536896789] + 12) == 0)
            {
                    UnityEngine.GameObject val_21 = Vectrosity.VectorLine.SetupVectorCanvas();
            }
            
            UnityEngine.Transform val_22 = this.m_go.transform;
            val_41 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_41 = 536896697;
            }
            
            UnityEngine.Transform val_23 = mem[536896789] + 12.transform;
            this.m_go.SetParent(parent:  mem[536896789] + 12, worldPositionStays:  true);
            label_46:
            this.m_canvasState = 1;
            Weight val_24 = this.m_go.GetComponent<Weight>();
            if(this.m_go != 0)
            {
                    Weight val_26 = this.m_go.GetComponent<Weight>();
                UnityEngine.Object.DestroyImmediate(obj:  this.m_go);
                Weight val_27 = this.m_go.GetComponent<Weight>();
                UnityEngine.Object.DestroyImmediate(obj:  this.m_go);
                Weight val_28 = this.m_go.GetComponent<Weight>();
                UnityEngine.Object.DestroyImmediate(obj:  this.m_go);
            }
            
            Weight val_29 = this.m_go.GetComponent<Weight>();
            if(this.m_go == 0)
            {
                    val_42 = this.m_go;
                SynchronizationContextBehavoir val_31 = val_42.AddComponent<SynchronizationContextBehavoir>();
            }
            else
            {
                    val_42 = this.m_go;
                Weight val_32 = val_42.GetComponent<Weight>();
            }
            
            this.m_vectorObject = val_42;
            val_34 = this.m_vectorObject;
            val_37 = this.m_material;
            val_38 = this.m_texture;
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_43 = val_34;
        }
        public void Draw()
        {
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
            float val_17;
            float val_18;
            float val_19;
            var val_21;
            if(this.m_active == false)
            {
                    return;
            }
            
            if(this.m_canvasState != 1)
            {
                    this.SetupCanvasState(wantedState:  1);
            }
            
            if(this.m_vectorObject == 0)
            {
                    Weight val_1 = this.m_go.GetComponent<Weight>();
                this.m_vectorObject = this.m_go;
            }
            
            bool val_2 = this.CheckPointCount();
            if(val_2 == true)
            {
                    val_2 = this.m_lineWidths;
            }
            
            if(val_2 == null)
            {
                    return;
            }
            
            int val_3 = this.pointsCount;
            if(val_3 != this.m_pointsCount)
            {
                    val_3 = this;
                this.Resize();
            }
            
            if(this.m_lineType == 2)
            {
                    this.DrawPoints();
                return;
            }
            
            bool val_4 = this.UseMatrix(thisMatrix: out  new UnityEngine.Matrix4x4() {m00 = 8.109052E-25f, m10 = 8.109052E-25f});
            this.SetupDrawStartEnd(start: out  int val_5 = 393934468, end: out  int val_6 = 393934464, clearVertices:  true);
            if(this.m_is2D != false)
            {
                    this.Line2D(start:  0, end:  0, thisMatrix:  new UnityEngine.Matrix4x4() {m00 = val_13, m01 = val_19, m11 = val_18, m21 = val_17, m31 = val_16, m02 = val_15, m12 = val_14, m22 = val_12, m32 = val_11, m03 = val_10, m13 = val_9, m23 = val_8, m33 = val_7}, useTransformMatrix:  val_4);
            }
            else
            {
                    this.Line3D(start:  0, end:  0, thisMatrix:  new UnityEngine.Matrix4x4() {m00 = val_13, m01 = val_19, m11 = val_18, m21 = val_17, m31 = val_16, m02 = val_15, m12 = val_14, m22 = val_12, m32 = val_11, m03 = val_10, m13 = val_9, m23 = val_8, m33 = val_7}, useTransformMatrix:  val_4);
            }
            
            this.CheckNormals();
            this.CheckLine(draw3D:  false);
            if(this.m_useTextureScale == true)
            {
                    this.m_useTextureScale = this;
                this.SetTextureScale();
            }
            
            if((mem[this.m_go] + 178) == 0)
            {
                goto label_11;
            }
            
            var val_21 = 0;
            label_13:
            if((mem[this.m_go] + 88 + 0) == 536888839)
            {
                goto label_12;
            }
            
            val_21 = val_21 + 1;
            if(((uint)val_21 & 65535) < (mem[this.m_go] + 178))
            {
                goto label_13;
            }
            
            label_11:
            val_21 = this.m_vectorObject;
            goto label_14;
            label_12:
            var val_20 = (mem[this.m_go] + 88) + 0;
            var val_22 = (mem[this.m_go] + 88 + 0) + 4;
            val_22 = mem[this.m_go] + (val_22 << 3);
            val_21 = val_22 + 196;
            label_14:
            if(this.m_collider == true)
            {
                    this.m_collider = this;
                ((mem[this.m_go] + ((mem[this.m_go] + 88 + 0) + 4) << 3) + 196) + 4 = 1;
                this.SetCollider(convertToWorldSpace:  true);
            }
        
        }
        private void Line2D(int start, int end, UnityEngine.Matrix4x4 thisMatrix, bool useTransformMatrix)
        {
            var val_6;
            var val_7;
            float val_76;
            int val_77;
            int val_78;
            int val_79;
            Vectrosity.VectorLine val_80;
            int val_81;
            float val_82;
            var val_83;
            var val_84;
            float val_85;
            float val_86;
            var val_87;
            var val_88;
            var val_89;
            int val_90;
            var val_91;
            float val_92;
            int val_93;
            var val_94;
            val_76 = 22979068;
            val_77 = end;
            val_78 = 0;
            if((mem[1152921509295926164] + 12) >= 2)
            {
                    val_78 = (start + (start >> 31)) >> 1;
            }
            
            if(mem[1152921509295926200] != 0)
            {
                    val_79 = 1;
            }
            else
            {
                    val_79 = 2;
            }
            
            val_79 = start << val_79;
            if(mem[1152921509295926208] != false)
            {
                    if((mem[1152921509295926164] + 12) > 1)
            {
                    0 = 1;
            }
            
            }
            
            val_80 = this;
            if(start >= val_77)
            {
                goto label_10;
            }
            
            val_81 = start;
            val_82 = 16 + (val_81 << 3);
            int val_4 = val_77 - 1;
            label_72:
            if(useTransformMatrix != false)
            {
                    if((mem[1152921509295926148] + 12) <= val_81)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Vector3 val_5 = MultiplyPoint3x4(point:  new UnityEngine.Vector3() {x = 8.190524E-25f, y = mem[1152921509295926148] + 8 + (16 + (start) << 3), z = mem[1152921509295926148] + 8 + (16 + (start) << 3) + 4});
                val_83 = val_6;
                val_84 = val_7;
                if((mem[1152921509295926148] + 12) <= (val_81 + 1))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_69 = mem[1152921509295926148] + 8;
                val_69 = val_69 + val_82;
                UnityEngine.Vector3 val_9 = MultiplyPoint3x4(point:  new UnityEngine.Vector3() {x = 8.190524E-25f, y = (mem[1152921509295926148] + 8 + (16 + (start) << 3)) + 8, z = mem[1152921509295926148] + 8 + (16 + (start) << 3) + 4});
                val_85 = val_6;
                val_86 = val_7;
            }
            else
            {
                    if((mem[1152921509295926148] + 12) <= val_81)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((mem[1152921509295926148] + 12) <= val_81)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_70 = mem[1152921509295926148] + 8;
                val_70 = val_70 + val_82;
                val_84 = mem[(mem[1152921509295926148] + 8 + (16 + (start) << 3)) + 4];
                val_84 = (mem[1152921509295926148] + 8 + (16 + (start) << 3)) + 4;
                int val_10 = val_81 + 1;
                if((mem[1152921509295926148] + 12) <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_71 = mem[1152921509295926148] + 8;
                val_71 = val_71 + val_82;
                if((mem[1152921509295926148] + 12) <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_72 = mem[1152921509295926148] + 8;
                val_85 = (mem[1152921509295926148] + 8 + (16 + (start) << 3)) + 8;
                val_80 = val_80;
                val_81 = val_81;
                val_72 = val_72 + val_82;
                val_83 = mem[1152921509295926148] + 8 + (16 + (start) << 3);
                val_86 = mem[(mem[1152921509295926148] + 8 + (16 + (start) << 3)) + 12];
                val_86 = (mem[1152921509295926148] + 8 + (16 + (start) << 3)) + 12;
            }
            
            if(mem[1152921509295926296] != false)
            {
                    float val_74 = val_85;
                float val_73 = val_86;
                var val_75 = val_84;
                var val_76 = val_83;
                val_73 = (float)UnityEngine.Screen.height * val_73;
                val_74 = (float)UnityEngine.Screen.width * val_74;
                val_75 = (float)UnityEngine.Screen.height * val_75;
                val_76 = (float)UnityEngine.Screen.width * val_76;
                val_86 = val_73;
                val_85 = val_74;
                val_84 = val_75;
                val_83 = val_76;
            }
            
            float val_77 = val_85;
            if((mem[1152921509295926296] == true) || (mem[1152921509295926296] == true))
            {
                goto label_26;
            }
            
            this.SkipQuad(idx: ref  int val_11 = 394099712, widthIdx: ref  int val_12 = 394099708, widthIdxAdd: ref  int val_13 = 394099704);
            val_77 = end;
            goto label_27;
            label_26:
            if(mem[1152921509295926296] == true)
            {
                goto label_28;
            }
            
            var val_78 = val_86;
            val_77 = val_83 - val_77;
            float val_14 = val_78 - val_84;
            val_78 = val_14 * val_14;
            if(mem[536890411] >= _TYPE_MAX_)
            {
                    val_87 = val_78;
            }
            
            float val_15 = 1f / val_87;
            var val_16 = mem[1152921509295926164] + (val_78 << 2);
            float val_79 = (mem[1152921509295926164] + (((start + (start) >> 31) >> 1)) << 2) + 16;
            float val_17 = val_15 * val_79;
            val_88 = val_14 * val_17;
            val_79 = val_83 - val_88;
            int val_18 = val_79 + (val_79 << 1);
            var val_19 = mem[1152921509295926104] + (val_18 << 2);
            mem2[0] = val_79;
            val_89 = val_77 * val_17;
            var val_21 = mem[1152921509295926104] + (val_18 << 2);
            mem2[0] = val_84 - val_89;
            int val_22 = val_79 + 3;
            int val_24 = val_22 + (val_22 << 1);
            var val_25 = mem[1152921509295926104] + (val_24 << 2);
            mem2[0] = val_88 + val_83;
            var val_27 = mem[1152921509295926104] + (val_24 << 2);
            mem2[0] = val_89 + val_84;
            if(val_81 >= val_4)
            {
                    0 = 1;
            }
            
            if(val_81 != val_4)
            {
                goto label_42;
            }
            
            int val_80 = val_78;
            val_80 = val_80 + 1;
            val_90 = val_79;
            var val_28 = mem[1152921509295926164] + (val_80 << 2);
            var val_81 = (mem[1152921509295926164] + ((((start + (start) >> 31) >> 1) + 1)) << 2) + 16;
            val_81 = val_15 * val_81;
            val_89 = val_77 * val_81;
            val_88 = val_14 * val_81;
            goto label_45;
            label_28:
            var val_83 = val_86;
            float val_30 = val_83 - val_84;
            float val_31 = val_30 * val_30;
            if(mem[536890411] >= _TYPE_MAX_)
            {
                    val_91 = val_31;
            }
            
            float val_32 = 1f / val_91;
            var val_82 = mem[1152921509295926204];
            float val_33 = (val_77 - val_83) * val_32;
            float val_34 = val_30 * val_32;
            var val_35 = mem[1152921509295926164] + (val_78 << 2);
            val_33 = val_82 * val_33;
            float val_36 = val_83 - val_33;
            val_88 = val_34 * ((mem[1152921509295926164] + (((start + (start) >> 31) >> 1)) << 2) + 16);
            val_31 = val_36 - val_88;
            int val_37 = val_79 + (val_79 << 1);
            val_82 = val_82 * val_34;
            var val_38 = mem[1152921509295926104] + (val_37 << 2);
            mem2[0] = val_31;
            float val_39 = val_84 - val_82;
            val_89 = ((mem[1152921509295926164] + (((start + (start) >> 31) >> 1)) << 2) + 16) * val_83;
            var val_41 = mem[1152921509295926104] + (val_37 << 2);
            mem2[0] = val_39 - val_89;
            int val_42 = val_79 + 3;
            int val_44 = val_42 + (val_42 << 1);
            var val_45 = mem[1152921509295926104] + (val_44 << 2);
            mem2[0] = val_36 + val_88;
            val_83 = val_82 + val_83;
            val_77 = val_33 + val_77;
            var val_46 = mem[1152921509295926104] + (val_44 << 2);
            val_92 = val_77;
            mem2[0] = val_39 + val_89;
            if(val_81 >= val_4)
            {
                    0 = 1;
            }
            
            if(val_81 != val_4)
            {
                goto label_59;
            }
            
            val_90 = val_79;
            var val_49 = mem[1152921509295926164] + ((val_78 + 1) << 2);
            val_92 = val_92;
            val_89 = ((mem[1152921509295926164] + ((((start + (start) >> 31) >> 1) + 1)) << 2) + 16) * val_83;
            val_88 = val_34 * ((mem[1152921509295926164] + ((((start + (start) >> 31) >> 1) + 1)) << 2) + 16);
            goto label_62;
            label_42:
            val_90 = val_79;
            label_45:
            val_92 = val_92;
            val_93 = val_79;
            goto label_63;
            label_59:
            val_90 = val_79;
            label_62:
            val_93 = val_83;
            label_63:
            int val_50 = val_90 + 2;
            val_90 = val_50 + (val_50 << 1);
            var val_52 = mem[1152921509295926104] + (val_90 << 2);
            val_80 = this;
            mem2[0] = val_88 + val_92;
            var val_54 = mem[1152921509295926104] + (val_90 << 2);
            val_77 = end;
            mem2[0] = val_89 + val_93;
            int val_55 = val_90 + 1;
            int val_57 = val_55 + (val_55 << 1);
            var val_58 = mem[1152921509295926104] + (val_57 << 2);
            mem2[0] = val_92 - val_88;
            var val_60 = mem[1152921509295926104] + (val_57 << 2);
            mem2[0] = val_93 - val_89;
            int val_84 = 1;
            val_84 = val_84 + val_78;
            int val_61 = val_90 + 4;
            val_82 = val_82;
            label_27:
            val_94 = val_82 + 0;
            val_76 = val_81 + 1;
            if(val_76 < val_77)
            {
                goto label_72;
            }
            
            label_10:
            if(mem[1152921509295926212] == 1)
            {
                    if(mem[1152921509295926200] != 0)
            {
                    int val_62 = val_77 & 1;
                if((mem[1152921509295926148] + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_62 = val_77 + val_62;
                val_77 = mem[1152921509295926148];
                var val_85 = mem[1152921509295926156];
                val_76 = mem[mem[1152921509295926148] + 8 + 16];
                val_76 = mem[1152921509295926148] + 8 + 16;
                val_85 = val_85 - 1;
                val_62 = val_62 - 1;
                if((mem[1152921509295926148] + 12) <= val_85)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_86 = mem[1152921509295926148] + 8;
                val_86 = val_86 + (val_85 << 3);
                val_80 = this;
                this.WeldJoinsDiscrete(start:  start + 1, end:  val_62, connectFirstAndLast:  this.Approximately(p1:  new UnityEngine.Vector2() {x = val_76, y = 8.196494E-25f}, p2:  new UnityEngine.Vector2() {x = (mem[1152921509295926148] + 8 + ((mem[1152921509295926156] - 1)) << 3) + 16, y = (mem[1152921509295926148] + 8 + ((mem[1152921509295926156] - 1)) << 3) + 20}));
            }
            else
            {
                    if((mem[1152921509295926148] + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_87 = mem[1152921509295926156];
                val_76 = mem[mem[1152921509295926148] + 8 + 16];
                val_76 = mem[1152921509295926148] + 8 + 16;
                val_87 = val_87 - 1;
                val_94 = start << 2;
                val_77 = (val_57 >> 5) << 2;
                if((mem[1152921509295926148] + 12) <= val_87)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_88 = mem[1152921509295926148] + 8;
                val_88 = val_88 + (val_87 << 3);
                val_80 = this;
                this.WeldJoins(start:  val_77 + val_94, end:  end << 2, connectFirstAndLast:  this.Approximately(p1:  new UnityEngine.Vector2() {x = val_76, y = 8.196494E-25f}, p2:  new UnityEngine.Vector2() {x = (mem[1152921509295926148] + 8 + ((mem[1152921509295926156] - 1)) << 3) + 16, y = mem[1152921509295926148]}));
            }
            
            }
            
            this.CheckDrawStartFill(start:  start);
        }
        private void Line3D(int start, int end, UnityEngine.Matrix4x4 thisMatrix, bool useTransformMatrix)
        {
            float val_5;
            float val_6;
            float val_7;
            int val_93;
            Vectrosity.VectorLine val_94;
            float val_95;
            float val_96;
            float val_97;
            var val_98;
            Vectrosity.VectorLine val_99;
            var val_100;
            float val_101;
            var val_102;
            var val_103;
            var val_104;
            int val_105;
            float val_106;
            float val_107;
            var val_108;
            var val_109;
            var val_110;
            var val_111;
            float val_112;
            bool val_113;
            bool val_114;
            float val_115;
            float val_116;
            float val_117;
            val_93 = start;
            val_94 = this;
            val_95 = 22979069;
            val_96 = thisMatrix.m32;
            val_97 = thisMatrix.m03;
            if(this.CheckCamera3D() == false)
            {
                    return;
            }
            
            val_95 = 22716504;
            if(0 >= 2)
            {
                    float val_23 = 1.401298E-45f;
            }
            
            int val_2 = val_93 << 1;
            if(this.m_lineType == 0)
            {
                    int val_3 = val_93 << 2;
            }
            
            UnityEngine.Vector3 val_4 = forward;
            val_94 = val_5;
            UnityEngine.Vector3 val_8 = position;
            val_98 = 0;
            UnityEngine.Vector3 val_9 = forward;
            float val_10 = mem[536896789] + 20.nearClipPlane;
            UnityEngine.Plane val_11 = new UnityEngine.Plane(inNormal:  new UnityEngine.Vector3() {x = val_94, y = val_6, z = val_7}, inPoint:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_7});
            UnityEngine.Ray val_12 = new UnityEngine.Ray(origin:  new UnityEngine.Vector3() {x = mem[mem[536896789] + (0)], y = mem[mem[536896789] + (4)], z = mem[mem[536896789] + (8)]}, direction:  new UnityEngine.Vector3() {x = mem[mem[536896789] + (0)], y = mem[mem[536896789] + (4)], z = mem[mem[536896789] + (8)]});
            val_99 = val_94;
            val_97 = end;
            if(mem[1152921509296079168] != false)
            {
                    if(mem[1152921509296079168] > true)
            {
                    val_98 = 1;
            }
            
            }
            
            if(val_97 <= val_93)
            {
                goto label_15;
            }
            
            int val_14 = val_97 - (1.401298E-45f);
            float val_16 = 20 + ((val_93 + (val_93 << 1)) << 2);
            label_80:
            if(useTransformMatrix != false)
            {
                    if((mem[1152921509296079112] + 12) <= val_93)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Vector3 val_17 = MultiplyPoint3x4(point:  new UnityEngine.Vector3() {x = 8.265907E-25f, y = mem[1152921509296079112] + 8 + (20 + ((start + (start) << 1)) << 2) + -4, z = mem[1152921509296079112] + 8 + (20 + ((start + (start) << 1)) << 2)});
                val_100 = 22716504;
                if((mem[1152921509296079112] + 12) <= (val_93 + 1))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_86 = mem[1152921509296079112] + 8;
                val_86 = val_86 + val_16;
                UnityEngine.Vector3 val_19 = MultiplyPoint3x4(point:  new UnityEngine.Vector3() {x = 8.265907E-25f, y = (mem[1152921509296079112] + 8 + (20 + ((start + (start) << 1)) << 2)) + 8, z = (mem[1152921509296079112] + 8 + (20 + ((start + (start) << 1)) << 2)) + 12});
                val_101 = val_5;
                val_102 = val_7;
            }
            else
            {
                    if((mem[1152921509296079112] + 12) <= val_93)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_87 = mem[1152921509296079112] + 8;
                val_87 = val_87 + val_16;
                val_100 = 22716504;
                if((mem[1152921509296079112] + 12) <= (val_93 + 1))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_88 = mem[1152921509296079112] + 8;
                val_88 = val_88 + val_16;
                val_101 = mem[(mem[1152921509296079112] + 8 + (20 + ((start + (start) << 1)) << 2)) + 8];
                val_101 = (mem[1152921509296079112] + 8 + (20 + ((start + (start) << 1)) << 2)) + 8;
                val_102 = mem[(mem[1152921509296079112] + 8 + (20 + ((start + (start) << 1)) << 2)) + 16];
                val_102 = (mem[1152921509296079112] + 8 + (20 + ((start + (start) << 1)) << 2)) + 16;
            }
            
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_103 = 536896697;
            }
            
            UnityEngine.Vector3 val_21 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = (mem[1152921509296079112] + 8 + (20 + ((start + (start) << 1)) << 2)) + -4, z = 0f});
            UnityEngine.Vector3 val_22 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_101, z = 0f});
            val_94 = 0;
            val_99 = val_94;
            if((mem[536896789] + 20) == 0)
            {
                    if((mem[536896789] + 20) == 0)
            {
                goto label_30;
            }
            
            }
            
            bool val_24 = this.IntersectAndDoSkip(pos1: ref  new UnityEngine.Vector3() {x = 8.265902E-25f, y = 8.265925E-25f, z = 8.265917E-25f}, pos2: ref  new UnityEngine.Vector3() {x = val_101, y = (float)UnityEngine.Screen.height, z = val_12.m_Origin.x}, p1: ref  new UnityEngine.Vector3() {x = val_11.m_Normal.x, z = val_93}, p2: ref  new UnityEngine.Vector3() {x = mem[536896789] + 8, y = val_14, z = 1.401298E-45f}, screenHeight: ref  val_23, ray: ref  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {y = 0f, z = 1.401298E-45f}, m_Direction = new UnityEngine.Vector3() {x = end, y = val_94}}, cameraPlane: ref  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = val_93, y = val_16}});
            if(val_24 == false)
            {
                goto label_31;
            }
            
            label_30:
            this.SkipQuad(idx: ref  int val_25 = 394252604, widthIdx: ref  int val_26 = 394252612, widthIdxAdd: ref  int val_27 = 394252608);
            val_97 = end;
            val_104 = val_16;
            val_105 = val_93;
            goto label_32;
            label_31:
            if(val_24 == true)
            {
                goto label_33;
            }
            
            val_106 = val_5;
            val_107 = 0f;
            float val_28 = val_5 - val_106;
            int val_29 = val_107 - val_3;
            float val_30 = val_28 * val_28;
            if(mem[536890411] >= _TYPE_MAX_)
            {
                    val_108 = val_30;
            }
            
            val_105 = val_93;
            float val_31 = 1f / val_108;
            val_108 = val_31 * this.m_lineWidths[val_93];
            float val_90 = this.m_lineWidths[val_93];
            val_109 = val_29 * val_108;
            val_30 = val_5 - val_109;
            int val_32 = val_3 + (val_3 << 1);
            val_90 = val_31 * val_90;
            var val_33 = mem[1152921509296079064] + (val_32 << 2);
            mem2[0] = val_30;
            val_110 = val_28 * val_90;
            var val_35 = mem[1152921509296079064] + (val_32 << 2);
            mem2[0] = val_3 - val_110;
            int val_36 = val_3 + 3;
            int val_38 = val_36 + (val_36 << 1);
            val_99 = val_94;
            var val_39 = mem[1152921509296079064] + (val_38 << 2);
            mem2[0] = val_109 + val_5;
            val_94 = 0;
            var val_41 = mem[1152921509296079064] + (val_38 << 2);
            mem2[0] = val_110 + val_3;
            if(val_105 >= val_14)
            {
                    0 = 1;
            }
            
            if(val_105 != val_14)
            {
                goto label_54;
            }
            
            int val_42 = val_93 + 1;
            float val_91 = this.m_lineWidths[val_42];
            val_91 = val_31 * val_91;
            val_109 = val_29 * val_91;
            float val_92 = this.m_lineWidths[val_42];
            val_92 = val_31 * val_92;
            val_110 = val_28 * val_92;
            goto label_54;
            label_33:
            int val_44 = 0 - val_3;
            if(mem[536890411] >= _TYPE_MAX_)
            {
                    val_111 = val_44 * val_44;
            }
            
            float val_46 = 1f / val_111;
            val_105 = val_93;
            float val_93 = mem[536896789] + 8;
            val_111 = (val_5 - val_5) * val_46;
            val_93 = val_46 * val_93;
            val_44 = val_44 * val_46;
            val_111 = val_111 * mem[1152921509296079164];
            val_93 = val_93 * mem[1152921509296079164];
            int val_47 = val_44 * mem[1152921509296079164];
            float val_94 = val_7;
            float val_48 = val_5 - val_111;
            val_94 = val_94 - val_93;
            int val_49 = val_3 - val_47;
            val_93 = val_93 + val_7;
            val_106 = val_111 + val_5;
            val_107 = val_47 + 0;
            float val_95 = this.m_lineWidths[val_93];
            val_109 = val_44 * val_95;
            float val_51 = val_49 + (val_49 << 1);
            var val_52 = mem[1152921509296079064] + (val_51 << 2);
            mem2[0] = val_48 - val_109;
            val_110 = val_95 * val_46;
            var val_54 = mem[1152921509296079064] + (val_51 << 2);
            mem2[0] = val_49 - val_110;
            float val_55 = val_49 + 3;
            float val_57 = val_55 + (val_55 << 1);
            var val_58 = mem[1152921509296079064] + (val_57 << 2);
            mem2[0] = val_48 + val_109;
            var val_60 = mem[1152921509296079064] + (val_57 << 2);
            mem2[0] = val_49 + val_110;
            if(val_105 >= val_14)
            {
                    0 = 1;
            }
            
            if(val_105 == val_14)
            {
                    float val_96 = this.m_lineWidths[val_93 + 1];
                val_110 = val_96 * val_46;
                val_109 = val_44 * val_96;
                val_112 = val_96 * (mem[536896789] + 8);
            }
            else
            {
                    val_112 = val_95 * (mem[536896789] + 8);
            }
            
            label_54:
            float val_64 = val_49 + 2;
            float val_66 = val_64 + (val_64 << 1);
            var val_67 = mem[1152921509296079064] + (val_66 << 2);
            mem2[0] = val_109 + val_106;
            var val_69 = mem[1152921509296079064] + (val_66 << 2);
            mem2[0] = val_110 + val_107;
            float val_70 = val_49 + 1;
            float val_72 = val_70 + (val_70 << 1);
            var val_73 = mem[1152921509296079064] + (val_72 << 2);
            mem2[0] = val_106 - val_109;
            var val_75 = mem[1152921509296079064] + (val_72 << 2);
            val_97 = end;
            val_104 = val_16;
            mem2[0] = val_107 - val_110;
            int val_97 = val_23;
            val_97 = val_97 + val_93;
            float val_98 = val_49;
            val_98 = val_98 + 4;
            label_32:
            val_104 = val_104 + 0f;
            val_93 = val_105 + (1.401298E-45f);
            if(val_93 < val_97)
            {
                goto label_80;
            }
            
            label_15:
            val_96 = val_93;
            if(((val_97 - val_96) < 2) || (mem[1152921509296079172] != 1))
            {
                goto label_93;
            }
            
            if(this.m_lineType == 0)
            {
                goto label_83;
            }
            
            int val_77 = val_97 & 1;
            val_113 = 0;
            val_77 = val_97 + val_77;
            int val_78 = val_77 - 1;
            if(val_96 == 0)
            {
                goto label_84;
            }
            
            val_97 = val_96 + 1;
            goto label_88;
            label_83:
            val_114 = 0;
            if(val_96 == 0)
            {
                goto label_86;
            }
            
            val_94 = val_96 << 2;
            goto label_94;
            label_84:
            var val_99 = mem[1152921509296079116];
            val_97 = 1;
            val_99 = val_99 - 1;
            if(val_78 == val_99)
            {
                    if((mem[1152921509296079112] + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_95 = mem[1152921509296079116];
                val_93 = mem[mem[1152921509296079112] + 8 + 16];
                val_93 = mem[1152921509296079112] + 8 + 16;
                val_115 = mem[mem[1152921509296079112] + 8 + 20];
                val_115 = mem[1152921509296079112] + 8 + 20;
                val_94 = mem[mem[1152921509296079112] + 8 + 24];
                val_94 = mem[1152921509296079112] + 8 + 24;
                if(mem[1152921509296079112] == 0)
            {
                    val_115 = val_115;
            }
            
                var val_80 = val_95 - 1;
                if((mem[1152921509296079112] + 12) <= val_80)
            {
                    val_95 = val_115;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_115 = val_95;
            }
            
                var val_100 = mem[1152921509296079112] + 8;
                val_100 = val_100 + ((val_80 + (val_80 << 1)) << 2);
                val_99 = val_94;
                val_96 = val_93;
                val_113 = this.Approximately(p1:  new UnityEngine.Vector3() {x = val_93, y = val_115, z = val_94}, p2:  new UnityEngine.Vector3() {x = (mem[1152921509296079112] + 8 + (((mem[1152921509296079116] - 1) + ((mem[1152921509296079116] - 1)) << 1)) << 2) + 16, y = (mem[1152921509296079112] + 8 + (((mem[1152921509296079116] - 1) + ((mem[1152921509296079116] - 1)) << 1)) << 2) + 20, z = (mem[1152921509296079112] + 8 + (((mem[1152921509296079116] - 1) + ((mem[1152921509296079116] - 1)) << 1)) << 2) + 24});
            }
            
            label_88:
            this.WeldJoinsDiscrete(start:  1, end:  val_78, connectFirstAndLast:  val_113);
            goto label_93;
            label_86:
            var val_101 = mem[1152921509296079116];
            val_94 = 4;
            val_101 = val_101 - 1;
            if(val_101 == val_97)
            {
                    if((mem[1152921509296079112] + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_97 = mem[1152921509296079112];
                val_95 = mem[1152921509296079116];
                val_93 = mem[mem[1152921509296079112] + 8 + 16];
                val_93 = mem[1152921509296079112] + 8 + 16;
                val_116 = mem[mem[1152921509296079112] + 8 + 20];
                val_116 = mem[1152921509296079112] + 8 + 20;
                val_117 = mem[mem[1152921509296079112] + 8 + 24];
                val_117 = mem[1152921509296079112] + 8 + 24;
                if(val_97 == 0)
            {
                    val_116 = val_116;
            }
            
                var val_83 = val_95 - 1;
                if((mem[1152921509296079112] + 12) <= val_83)
            {
                    val_95 = val_117;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_116 = val_116;
                val_117 = val_95;
            }
            
                var val_102 = mem[1152921509296079112] + 8;
                val_102 = val_102 + ((val_83 + (val_83 << 1)) << 2);
                val_99 = val_94;
                val_96 = val_93;
                val_114 = this.Approximately(p1:  new UnityEngine.Vector3() {x = val_93, y = val_116, z = val_117}, p2:  new UnityEngine.Vector3() {x = (mem[1152921509296079112] + 8 + (((mem[1152921509296079116] - 1) + ((mem[1152921509296079116] - 1)) << 1)) << 2) + 16, y = (mem[1152921509296079112] + 8 + (((mem[1152921509296079116] - 1) + ((mem[1152921509296079116] - 1)) << 1)) << 2) + 20, z = (mem[1152921509296079112] + 8 + (((mem[1152921509296079116] - 1) + ((mem[1152921509296079116] - 1)) << 1)) << 2) + 24});
            }
            
            label_94:
            this.WeldJoins(start:  4, end:  val_97 << 2, connectFirstAndLast:  val_114);
            label_93:
            this.CheckDrawStartFill(start:  val_96);
        }
        private void CheckDrawStartFill(int start)
        {
            if(this.m_joins != 0)
            {
                    return;
            }
            
            if(this.m_drawStart < 1)
            {
                    return;
            }
            
            int val_1 = start << 2;
            if(this.m_drawStart <= val_1)
            {
                    return;
            }
            
            int val_2 = val_1 - 3;
            if(val_2 < 0)
            {
                    return;
            }
            
            int val_3 = val_1 + (val_1 << 1);
            int val_4 = val_1 - 1;
            this.m_lineVertices[(val_4 + (val_4 << 1)) << 2] = this.m_lineVertices[val_3 << 2];
            this.m_lineVertices[(val_4 + (val_4 << 1)) << 2] = this.m_lineVertices[val_3 << 2];
            this.m_lineVertices[(val_4 + (val_4 << 1)) << 2] = this.m_lineVertices[val_3 << 2];
            int val_6 = val_1 - 2;
            this.m_lineVertices[(val_6 + (val_6 << 1)) << 2] = this.m_lineVertices[val_3 << 2];
            this.m_lineVertices[(val_6 + (val_6 << 1)) << 2] = this.m_lineVertices[val_3 << 2];
            this.m_lineVertices[(val_6 + (val_6 << 1)) << 2] = this.m_lineVertices[val_3 << 2];
            this.m_lineVertices[(val_2 + (val_2 << 1)) << 2] = this.m_lineVertices[val_3 << 2];
            this.m_lineVertices[(val_2 + (val_2 << 1)) << 2] = this.m_lineVertices[val_3 << 2];
            this.m_lineVertices[(val_2 + (val_2 << 1)) << 2] = this.m_lineVertices[val_3 << 2];
        }
        public void Draw3D()
        {
            float val_9;
            float val_10;
            float val_11;
            Vectrosity.VectorLine val_75;
            var val_76;
            int val_77;
            var val_78;
            var val_79;
            var val_80;
            var val_81;
            var val_82;
            var val_83;
            var val_84;
            var val_85;
            var val_86;
            int val_87;
            bool val_88;
            var val_89;
            bool val_90;
            var val_91;
            float val_92;
            float val_93;
            float val_94;
            var val_95;
            val_75 = this;
            if(this.m_active == false)
            {
                    return;
            }
            
            if(this.m_is2D != false)
            {
                    string val_1 = -1610602781(-1610602781) + this.m_name + -1610612233(-1610612233);
                UnityEngine.Debug.LogError(message:  -1610602781);
                return;
            }
            
            if(this.m_canvasState != 2)
            {
                    this.SetupCanvasState(wantedState:  2);
            }
            
            bool val_2 = this.CheckPointCount();
            if(val_2 == true)
            {
                    val_2 = this.m_lineWidths;
            }
            
            if(val_2 == null)
            {
                    return;
            }
            
            int val_3 = this.pointsCount;
            if(val_3 != this.m_pointsCount)
            {
                    val_3 = val_75;
                this.Resize();
            }
            
            if(this.CheckCamera3D() == false)
            {
                    return;
            }
            
            if(this.m_lineType == 2)
            {
                    this.DrawPoints3D();
                return;
            }
            
            this.SetupDrawStartEnd(start: out  int val_5 = 394960000, end: out  int val_6 = 394959996, clearVertices:  true);
            bool val_7 = this.UseMatrix(thisMatrix: out  new UnityEngine.Matrix4x4() {m00 = 8.957476E-25f, m10 = 8.957543E-25f, m20 = 1.401298E-45f});
            if(this.m_smoothWidth != false)
            {
                    if(0 > 1)
            {
                    0 = 1;
            }
            
            }
            
            if(this.m_lineType != 0)
            {
                
            }
            
            UnityEngine.Vector3 val_8 = forward;
            UnityEngine.Vector3 val_12 = position;
            val_76 = 0;
            UnityEngine.Vector3 val_13 = forward;
            float val_14 = mem[536896789] + 20.nearClipPlane;
            UnityEngine.Plane val_15 = new UnityEngine.Plane(inNormal:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_11}, inPoint:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_11});
            UnityEngine.Ray val_16 = new UnityEngine.Ray(origin:  new UnityEngine.Vector3() {x = mem[mem[536896789] + (0)], y = mem[mem[536896789] + (4)], z = mem[mem[536896789] + (8)]}, direction:  new UnityEngine.Vector3() {x = mem[mem[536896789] + (0)], y = mem[mem[536896789] + (4)], z = mem[mem[536896789] + (8)]});
            val_77 = 0;
            if(val_77 <= 0)
            {
                goto label_23;
            }
            
            goto label_106;
            label_64:
            val_78 = 1179403647;
            val_79 = 0;
            goto label_25;
            label_95:
            val_80 = 1179403647;
            val_81 = 0;
            goto label_26;
            label_106:
            if(val_7 != false)
            {
                    if(0f <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Vector3 val_18 = MultiplyPoint3x4(point:  new UnityEngine.Vector3() {x = 8.957476E-25f, y = 3.673424E-39f, z = 1.401298E-45f});
                if(val_11 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Vector3 val_19 = MultiplyPoint3x4(point:  new UnityEngine.Vector3() {x = 8.957476E-25f, y = 7.286752E-44f, z = 4.085283E-38f});
            }
            else
            {
                    if(0f <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(0 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            }
            
            UnityEngine.Vector3 val_20 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = 3.673424E-39f, z = 0f});
            UnityEngine.Vector3 val_21 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = 7.286752E-44f, z = 0f});
            val_75 = val_75;
            if((mem[536896789] + 20) == 0)
            {
                    if((mem[536896789] + 20) == 0)
            {
                goto label_41;
            }
            
            }
            
            if((this.IntersectAndDoSkip(pos1: ref  new UnityEngine.Vector3() {x = 8.957516E-25f, y = 8.9575E-25f, z = 8.957484E-25f}, pos2: ref  new UnityEngine.Vector3() {x = 7.286752E-44f, y = (float)UnityEngine.Screen.height, z = val_16.m_Origin.x}, p1: ref  new UnityEngine.Vector3() {x = val_15.m_Normal.x, z = 0f}, p2: ref  new UnityEngine.Vector3() {x = 0f, y = 1.401298E-45f, z = 1.401298E-45f}, screenHeight: ref  float val_22 = null, ray: ref  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {y = val_75, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = val_7, z = 1.401298E-45f}}, cameraPlane: ref  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = 2.802597E-44f, y = 0f}})) == false)
            {
                goto label_42;
            }
            
            label_41:
            this.SkipQuad3D(idx: ref  int val_24 = 394959924, widthIdx: ref  int val_25 = 394959992, widthIdxAdd: ref  int val_26 = 394959920);
            goto label_43;
            label_42:
            float val_27 = val_9 - val_9;
            float val_29 = val_27 * val_27;
            if(mem[536890411] >= _TYPE_MAX_)
            {
                    val_82 = val_29;
            }
            
            float val_30 = (0 - 0) / val_82;
            val_83 = val_30 * val_2[0];
            val_82 = val_27 / val_82;
            float val_31 = 0f + 0;
            val_31 = mem[1152921509296786448] + (val_31 << 2);
            val_29 = val_9 - val_83;
            mem2[0] = val_29;
            val_84 = val_82 * val_2[0];
            float val_33 = 0f + 0;
            val_33 = mem[1152921509296786448] + (val_33 << 2);
            mem2[0] = 0 - val_84;
            float val_35 = 0f + 0;
            val_35 = mem[1152921509296786448] + (val_35 << 2);
            mem2[0] = val_11 - (mem[536896789] + 8);
            float val_80 = 0f;
            val_80 = val_80 + 3;
            float val_37 = val_80 + (val_80 << 1);
            val_37 = mem[1152921509296786448] + (val_37 << 2);
            mem2[0] = val_9 + val_83;
            float val_81 = 0f;
            val_81 = val_81 + 3;
            float val_39 = val_81 + (val_81 << 1);
            val_39 = mem[1152921509296786448] + (val_39 << 2);
            mem2[0] = 0 + val_84;
            float val_82 = 0f;
            val_82 = val_82 + 3;
            float val_41 = val_82 + (val_82 << 1);
            val_41 = mem[1152921509296786448] + (val_41 << 2);
            mem2[0] = (mem[536896789] + 8) + val_11;
            val_78 = 536896697;
            if((mem[536896884] & true) == 0)
            {
                    if(mem[536896813] == 0)
            {
                goto label_64;
            }
            
            }
            
            val_79 = 0f;
            label_25:
            float val_42 = val_79 + 0;
            val_42 = mem[1152921509296786448] + (val_42 << 2);
            UnityEngine.Vector3 val_43 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = (mem[1152921509296786448] + ((val_79 + 0)) << 2) + 16, z = (mem[1152921509296786448] + ((val_79 + 0)) << 2) + 20});
            float val_44 = 0f + 0;
            val_44 = mem[1152921509296786392] + (val_44 << 2);
            val_44 = val_44 + 16;
            float val_83 = 0f;
            val_83 = val_83 + 3;
            float val_45 = val_83 + (val_83 << 1);
            var val_47 = (mem[1152921509296786448] + (val_45 << 2)) + 16;
            UnityEngine.Vector3 val_48 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = mem[((mem[1152921509296786448] + (((0f + 3) + ((0f + 3)) << 1)) << 2) + 16) + (0)], z = mem[((mem[1152921509296786448] + (((0f + 3) + ((0f + 3)) << 1)) << 2) + 16) + (4)]});
            var val_49 = mem[1152921509296786392] + (val_45 << 2);
            mem2[0] = val_9;
            mem2[0] = val_10;
            mem2[0] = val_11;
            if((1.401298E-45f) == 0)
            {
                goto label_75;
            }
            
            val_85 = 22716504;
            if(0 >= 0f)
            {
                goto label_81;
            }
            
            var val_50 = 0 + 1;
            val_83 = val_30 * val_2[val_50];
            val_84 = val_82 * val_2[val_50];
            goto label_81;
            label_75:
            val_85 = 22716504;
            label_81:
            float val_86 = 0f;
            val_86 = val_86 + 2;
            float val_52 = val_86 + (val_86 << 1);
            val_52 = mem[1152921509296786448] + (val_52 << 2);
            mem2[0] = val_9 + val_83;
            float val_87 = 0f;
            val_87 = val_87 + 2;
            float val_54 = val_87 + (val_87 << 1);
            val_54 = mem[1152921509296786448] + (val_54 << 2);
            mem2[0] = 0 + val_84;
            float val_88 = 0f;
            val_88 = val_88 + 2;
            float val_56 = val_88 + (val_88 << 1);
            val_56 = mem[1152921509296786448] + (val_56 << 2);
            mem2[0] = (mem[536896789] + 8) + val_11;
            float val_89 = 0f;
            val_89 = val_89 + 1;
            float val_58 = val_89 + (val_89 << 1);
            val_58 = mem[1152921509296786448] + (val_58 << 2);
            mem2[0] = val_9 - val_83;
            float val_90 = 0f;
            val_90 = val_90 + 1;
            float val_60 = val_90 + (val_90 << 1);
            val_60 = mem[1152921509296786448] + (val_60 << 2);
            mem2[0] = 0 - val_84;
            float val_91 = 0f;
            val_91 = val_91 + 1;
            float val_62 = val_91 + (val_91 << 1);
            val_62 = mem[1152921509296786448] + (val_62 << 2);
            mem2[0] = val_11 - (mem[536896789] + 8);
            if((mem[536896884] & true) == 0)
            {
                    if(mem[536896813] == 0)
            {
                goto label_95;
            }
            
            }
            
            val_81 = 0f;
            label_26:
            val_81 = val_81 + 2;
            float val_63 = val_81 + (val_81 << 1);
            val_63 = mem[1152921509296786448] + (val_63 << 2);
            UnityEngine.Vector3 val_64 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = (mem[1152921509296786448] + (((val_81 + 2) + ((val_81 + 2)) << 1)) << 2) + 16, z = (mem[1152921509296786448] + (((val_81 + 2) + ((val_81 + 2)) << 1)) << 2) + 20});
            float val_65 = 0f + 2;
            float val_66 = val_65 + (val_65 << 1);
            val_66 = mem[1152921509296786392] + (val_66 << 2);
            val_66 = val_66 + 16;
            float val_92 = 0f;
            val_92 = val_92 + 1;
            float val_67 = val_92 + (val_92 << 1);
            var val_69 = (mem[1152921509296786448] + (val_67 << 2)) + 16;
            UnityEngine.Vector3 val_70 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = mem[((mem[1152921509296786448] + (((0f + 1) + ((0f + 1)) << 1)) << 2) + 16) + (0)], z = mem[((mem[1152921509296786448] + (((0f + 1) + ((0f + 1)) << 1)) << 2) + 16) + (4)]});
            val_86 = mem[1152921509296786392];
            if(val_86 == 0)
            {
                    val_86 = mem[1152921509296786392];
            }
            
            if((mem[1152921509296786392] + 12) <= val_92)
            {
                    val_86 = mem[1152921509296786392];
            }
            
            var val_71 = val_86 + (val_67 << 2);
            val_71 = val_71 + 16;
            label_43:
            float val_93 = 2.802597E-44f;
            val_93 = val_93 + 0f;
            val_77 = val_77;
            if(1 < val_77)
            {
                goto label_106;
            }
            
            label_23:
            int val_94 = 0;
            val_94 = val_77 - val_94;
            if((val_94 < 2) || (mem[1152921509296786500] != 1))
            {
                goto label_119;
            }
            
            if(this.m_lineType == 0)
            {
                goto label_109;
            }
            
            if((val_77 & 1) != 0)
            {
                    val_77 = val_77 - 1;
            }
            
            val_88 = 0;
            if(0 == 0)
            {
                goto label_110;
            }
            
            val_89 = 1;
            goto label_114;
            label_109:
            val_90 = 0;
            if(0 == 0)
            {
                goto label_112;
            }
            
            val_91 = 0;
            goto label_120;
            label_110:
            int val_95 = this.m_pointsCount;
            val_89 = 1;
            val_95 = val_95 - 1;
            if(val_77 == val_95)
            {
                    if(val_95 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                int val_96 = this.m_pointsCount;
                val_96 = val_96 - 1;
                if(0 <= val_96)
            {
                    var val_97 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_97 = val_97 + ((val_96 + (val_96 << 1)) << 2);
                val_87 = val_77;
                val_88 = this.Approximately(p1:  new UnityEngine.Vector3() {x = 3.673424E-39f, y = 1.401298E-45f, z = 0f}, p2:  new UnityEngine.Vector3() {x = (0 + (((this.m_pointsCount - 1) + ((this.m_pointsCount - 1)) << 1)) << 2) + 16, y = (0 + (((this.m_pointsCount - 1) + ((this.m_pointsCount - 1)) << 1)) << 2) + 20, z = (0 + (((this.m_pointsCount - 1) + ((this.m_pointsCount - 1)) << 1)) << 2) + 24});
            }
            
            label_114:
            this.WeldJoinsDiscrete3D(start:  1, end:  val_87, connectFirstAndLast:  val_88);
            goto label_119;
            label_112:
            int val_98 = this.m_pointsCount;
            val_91 = 4;
            val_98 = val_98 - 1;
            if(0 == val_98)
            {
                    if(val_98 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_74 = 0 + 16;
                int val_99 = this.m_pointsCount;
                if(this.m_points3 == 0)
            {
                    val_92 = mem[(0 + 16) + (0)];
            }
            
                val_99 = val_99 - 1;
                if(0 <= val_99)
            {
                    var val_100 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_92 = val_92;
                val_94 = mem[(0 + 16) + (4)];
                val_93 = mem[(0 + 16) + (8)];
            }
            
                val_100 = val_100 + ((val_99 + (val_99 << 1)) << 2);
                val_90 = this.Approximately(p1:  new UnityEngine.Vector3() {x = val_92, y = val_94, z = val_93}, p2:  new UnityEngine.Vector3() {x = (0 + (((this.m_pointsCount - 1) + ((this.m_pointsCount - 1)) << 1)) << 2) + 16, y = (0 + (((this.m_pointsCount - 1) + ((this.m_pointsCount - 1)) << 1)) << 2) + 20, z = (0 + (((this.m_pointsCount - 1) + ((this.m_pointsCount - 1)) << 1)) << 2) + 24});
            }
            
            label_120:
            this.WeldJoins3D(start:  4, end:  0, connectFirstAndLast:  val_90);
            label_119:
            this.CheckDrawStartFill(start:  0);
            this.CheckLine(draw3D:  true);
            if(mem[1152921509296786592] == true)
            {
                    mem[1152921509296786592] = val_75;
                this.SetTextureScale();
            }
            
            if(mem[1152921509296786420] == 0)
            {
                goto label_125;
            }
            
            var val_102 = mem[1152921509296786420];
            if((mem[1152921509296786420] + 178) == 0)
            {
                goto label_126;
            }
            
            var val_101 = 0;
            label_128:
            if((mem[1152921509296786420] + 88 + 0) == 536888839)
            {
                goto label_127;
            }
            
            val_101 = val_101 + 1;
            if(((uint)val_101 & 65535) < (mem[1152921509296786420] + 178))
            {
                goto label_128;
            }
            
            label_126:
            val_95 = mem[1152921509296786420];
            goto label_129;
            label_127:
            var val_77 = (mem[1152921509296786420] + 88) + 0;
            val_102 = val_102 + (((mem[1152921509296786420] + 88 + 0) + 4) << 3);
            val_95 = val_102 + 196;
            label_129:
            label_125:
            this.CheckNormals();
            if(mem[1152921509296786668] == true)
            {
                    mem[1152921509296786668] = val_75;
                ((mem[1152921509296786420] + ((mem[1152921509296786420] + 88 + 0) + 4) << 3) + 196) + 4 = 0;
                this.SetCollider(convertToWorldSpace:  false);
            }
        
        }
        private bool IntersectAndDoSkip(ref UnityEngine.Vector3 pos1, ref UnityEngine.Vector3 pos2, ref UnityEngine.Vector3 p1, ref UnityEngine.Vector3 p2, ref float screenHeight, ref UnityEngine.Ray ray, ref UnityEngine.Plane cameraPlane)
        {
            float val_2;
            float val_3;
            float val_4;
            float val_6;
            float val_7;
            float val_13;
            float val_14;
            var val_15;
            var val_16;
            var val_17;
            float val_18;
            var val_19;
            var val_20;
            bool val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            bool val_27;
            val_13 = 9.352151E-25f;
            val_14 = 9.348018E-25f;
            val_15 = 1152921509297166064;
            val_16 = p1.x;
            val_17 = pos2.z;
            val_18 = pos2.x;
            val_19 = 1;
            val_20 = 536896697;
            val_21 = mem[536896884];
            if((val_21 & true) == 0)
            {
                    val_21 = mem[536896813];
                if(val_21 == 0)
            {
                    val_20 = 536896697;
                val_22 = val_17;
                val_23 = val_16;
            }
            
            }
            
            UnityEngine.Vector3 val_1 = PlaneIntersectionPoint(ray: ref  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_21, y = 9.364552E-25f, z = 9.368686E-25f}, m_Direction = new UnityEngine.Vector3() {x = val_18, y = val_13}}, plane: ref  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {z = val_14}}, p1: ref  new UnityEngine.Vector3(), p2: ref  new UnityEngine.Vector3());
            UnityEngine.Vector3 val_5 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_2, z = val_3});
            val_2 = val_6;
            val_4 = val_7;
            mem[1152921509297166072] = val_4;
            pos1.x = val_2;
            UnityEngine.Vector3 val_8 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 16, y = val_14, z = SB});
            if((mem[536896789] + 16) < 0)
            {
                    if((mem[536896789] + 16) > 0)
            {
                    return (bool)val_19;
            }
            
            }
            
            val_14 = val_14;
            val_18 = pos2.x;
            val_13 = val_13;
            val_24 = p1.x;
            val_25 = pos2.z;
            if((mem[536896789] + 16) > 0)
            {
                    if((mem[536896789] + 16) < 0)
            {
                    return (bool)val_19;
            }
            
            }
            
            if((mem[536896789] + 16) < 0)
            {
                    val_26 = 536896697;
                val_27 = mem[536896884];
                if((val_27 & true) == 0)
            {
                    val_27 = mem[536896813];
                if(val_27 == 0)
            {
                    val_26 = 536896697;
                val_25 = val_25;
                val_24 = val_24;
            }
            
            }
            
                UnityEngine.Vector3 val_10 = val_2.PlaneIntersectionPoint(ray: ref  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_27, y = 9.364552E-25f, z = 9.368686E-25f}, m_Direction = new UnityEngine.Vector3() {x = val_13, y = val_18}}, plane: ref  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {y = val_13, z = val_14}}, p1: ref  new UnityEngine.Vector3(), p2: ref  new UnityEngine.Vector3() {x = val_2, z = val_4});
                val_13 = 0;
                UnityEngine.Vector3 val_11 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_2, z = val_3});
                val_2 = val_6;
                val_4 = val_7;
                mem[1152921509297170264] = val_4;
                pos1.y = val_2;
                val_18 = mem[mem[536896789] + 16];
                val_18 = mem[536896789] + 16;
                UnityEngine.Vector3 val_12 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_18, y = pos2.x, z = R5});
                if(val_18 < 0)
            {
                    val_19 = 1;
                if(val_18 > 0)
            {
                    return (bool)val_19;
            }
            
            }
            
                if(val_18 > 0)
            {
                    if(val_18 >= 0)
            {
                    val_19 = 0;
            }
            
                return (bool)val_19;
            }
            
            }
            
            val_19 = 0;
            return (bool)val_19;
        }
        private UnityEngine.Vector3 PlaneIntersectionPoint(ref UnityEngine.Ray ray, ref UnityEngine.Plane plane, ref UnityEngine.Vector3 p1, ref UnityEngine.Vector3 p2)
        {
            Vectrosity.VectorLine val_4;
            UnityEngine.Vector3[] val_5;
            ray.m_Origin.y.origin = new UnityEngine.Vector3() {x = ray.m_Direction.x};
            float val_6 = ray.m_Direction.x;
            float val_7 = mem[1152921509297452916];
            val_6 = ray.m_Direction.y - val_6;
            float val_8 = mem[1152921509297452920];
            val_7 = mem[1152921509297457044] - val_7;
            val_8 = mem[1152921509297457048] - val_8;
            ray.m_Origin.y.direction = new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_8};
            bool val_2 = ray.m_Origin.z.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = ray.m_Origin.y}, m_Direction = new UnityEngine.Vector3() {x = mem[1152921509297444668], y = mem[1152921509297444672], z = mem[1152921509297444676]}}, enter: out  0f);
            UnityEngine.Vector3 val_3 = GetPoint(distance:  val_6);
            this.m_lineVertices = val_5;
            this = val_4;
            return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        private void DrawPoints()
        {
            float val_9;
            float val_10;
            var val_33;
            System.Single[] val_34;
            System.Single[] val_35;
            float val_36;
            System.Single[] val_37;
            float val_38;
            float val_39;
            float val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            float val_45;
            var val_46;
            var val_47;
            float val_48;
            float val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            float val_56;
            var val_57;
            var val_58;
            float val_59;
            var val_60;
            if(this.CheckCamera3D() == false)
            {
                    return;
            }
            
            bool val_2 = this.UseMatrix(thisMatrix: out  new UnityEngine.Matrix4x4() {m00 = 1.067557E-24f, m10 = 1.067557E-24f, m23 = 0f, m33 = 0f});
            this.SetupDrawStartEnd(start: out  int val_3 = 396702276, end: out  int val_4 = 396702272, clearVertices:  true);
            val_33 = 0f;
            var val_55 = UnityEngine.Screen.height;
            val_34 = this.m_lineWidths;
            if(this.m_lineWidths == null)
            {
                    val_34 = this.m_lineWidths;
            }
            
            if(0 > 1)
            {
                    0 = 1;
            }
            
            val_35 = this.m_lineWidths;
            val_36 = val_34[0];
            val_37 = this.m_lineWidths;
            val_38 = val_35[0];
            val_39 = -val_37[0];
            val_40 = this.m_lineWidths[0];
            if(this.m_is2D == false)
            {
                goto label_11;
            }
            
            if(val_33 > 0f)
            {
                goto label_43;
            }
            
            var val_7 = 16 + 0;
            val_41 = 0;
            do
            {
                if(val_2 != false)
            {
                    if(16 <= val_33)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Vector3 val_8 = MultiplyPoint3x4(point:  new UnityEngine.Vector3() {x = 1.067557E-24f, y = 0 + (16 + 0), z = 0 + (16 + 0) + 4});
                val_42 = val_9;
                val_43 = val_33;
                val_44 = val_10;
            }
            else
            {
                    if(16 <= val_33)
            {
                    var val_53 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_53 = val_53 + val_7;
                val_42 = mem[(0 + (16 + 0))];
                val_42 = val_53;
                val_43 = val_33;
                if(val_53 <= val_33)
            {
                    var val_54 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_54 = val_54 + val_7;
                val_44 = mem[(0 + (16 + 0)) + 4];
                val_44 = (0 + (16 + 0)) + 4;
            }
            
                val_55 = val_44 * (float)val_55;
                if(this.m_viewportDraw == true)
            {
                    val_44 = val_55;
                val_42 = val_42 * (float)UnityEngine.Screen.width;
            }
            
                if(0 >= 2)
            {
                    val_45 = this.m_lineWidths[val_43];
                val_46 = val_45;
                val_47 = val_45;
                val_43 = val_43 + 1;
                float val_56 = this.m_lineWidths[val_43];
                val_48 = -val_56;
            }
            
                val_56 = val_42 + val_48;
                this.m_lineVertices[(0 + 0) << 2] = val_56;
                this.m_lineVertices[(0 + 0) << 2] = val_44 + val_45;
                var val_57 = 0;
                val_57 = val_57 + 3;
                this.m_lineVertices[(val_57 + (val_57 << 1)) << 2] = val_42 - val_46;
                var val_58 = 0;
                val_58 = val_58 + 3;
                this.m_lineVertices[(val_58 + (val_58 << 1)) << 2] = val_44 - val_47;
                var val_59 = 0;
                val_59 = val_59 + 1;
                this.m_lineVertices[(val_59 + (val_59 << 1)) << 2] = val_42 + val_46;
                var val_60 = 0;
                val_60 = val_60 + 1;
                this.m_lineVertices[(val_60 + (val_60 << 1)) << 2] = val_44 + val_47;
                var val_61 = 0;
                val_61 = val_61 + 2;
                this.m_lineVertices[(val_61 + (val_61 << 1)) << 2] = val_42 - val_48;
                val_35 = this.m_lineVertices;
                var val_62 = 0;
                val_62 = val_62 + 2;
                val_7 = val_7 + 8;
                val_37 = val_33 + 1;
                val_35[(val_62 + (val_62 << 1)) << 2] = val_44 - val_45;
            }
            while(val_37 <= 0f);
            
            goto label_43;
            label_11:
            if(val_33 <= 0f)
            {
                    val_49 = (val_33 + 0) << 2;
                do
            {
                val_50 = 536896697;
                var val_63 = mem[536896883];
                val_63 = val_63 & 512;
                if(val_2 != false)
            {
                    if((val_63 != 0) && (mem[536896813] == 0))
            {
                    val_51 = 536896697;
            }
            
                if(mem[536896789] <= val_33)
            {
                    var val_64 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_64 = val_64 + val_49;
                UnityEngine.Vector3 val_28 = MultiplyPoint3x4(point:  new UnityEngine.Vector3() {x = 1.067557E-24f, y = (0 + ((val_33 + 0) << 2)) + 16, z = (0 + ((val_33 + 0) << 2)) + 20});
                val_35 = val_10;
                UnityEngine.Vector3 val_30 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_9, z = val_35});
                val_52 = val_33;
                val_37 = 0f;
                val_49 = val_49;
                val_53 = val_9;
                val_54 = val_10;
            }
            else
            {
                    if((val_63 != 0) && (mem[536896813] == 0))
            {
                    val_55 = 536896697;
            }
            
                if(mem[536896789] <= val_33)
            {
                    var val_65 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_65 = val_65 + val_49;
                val_35 = mem[(0 + ((val_33 + 0) << 2)) + 16];
                val_35 = (0 + ((val_33 + 0) << 2)) + 16;
                UnityEngine.Vector3 val_31 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_35, z = (0 + ((val_33 + 0) << 2)) + 20});
                val_53 = val_9;
                val_54 = val_10;
                val_37 = 0f;
            }
            
                if((mem[536896789] + 20) < 0)
            {
                    this.SkipQuad(idx: ref  int val_32 = 396702268, widthIdx: ref  int val_33 = 396702260, widthIdxAdd: ref  int val_34 = 396702264);
            }
            else
            {
                    if(0 >= 2)
            {
                    val_35 = this.m_lineWidths;
                val_56 = val_35[val_43];
                val_57 = val_56;
                val_58 = val_56;
                float val_66 = this.m_lineWidths[val_43];
                var val_35 = val_43 + 1;
                val_59 = -val_66;
            }
            
                val_66 = val_53 + val_59;
                this.m_lineVertices[(4 + 8) << 2] = val_66;
                this.m_lineVertices[(4 + 8) << 2] = val_54 + val_56;
                var val_67 = 4;
                val_67 = val_67 + 3;
                this.m_lineVertices[(val_67 + (val_67 << 1)) << 2] = val_53 - val_57;
                var val_68 = 4;
                val_68 = val_68 + 3;
                this.m_lineVertices[(val_68 + (val_68 << 1)) << 2] = val_54 - val_58;
                var val_69 = 4;
                val_69 = val_69 + 1;
                this.m_lineVertices[(val_69 + (val_69 << 1)) << 2] = val_53 + val_57;
                var val_70 = 4;
                val_70 = val_70 + 1;
                this.m_lineVertices[(val_70 + (val_70 << 1)) << 2] = val_54 + val_58;
                var val_71 = 4;
                val_71 = val_71 + 2;
                this.m_lineVertices[(val_71 + (val_71 << 1)) << 2] = val_53 - val_59;
                var val_72 = 4;
                val_72 = val_72 + 2;
                this.m_lineVertices[(val_72 + (val_72 << 1)) << 2] = val_54 - val_56;
            }
            
                val_43 = val_33 + 1;
                val_41 = val_49 + 12;
            }
            while(val_43 <= val_37);
            
            }
            
            label_43:
            this.CheckNormals();
            val_37 = 0;
            val_35 = 0;
            val_37 = val_37 + 1;
            val_35 = (uint)val_37 & 65535;
            val_60 = this.m_vectorObject;
        }
        private void DrawPoints3D()
        {
            float val_6;
            float val_7;
            UnityEngine.Vector3 val_8;
            Vectrosity.VectorLine val_26;
            bool val_27;
            float val_28;
            var val_29;
            var val_31;
            var val_32;
            float val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            float val_38;
            float val_39;
            var val_40;
            var val_41;
            val_26 = this;
            if(this.m_active == false)
            {
                    return;
            }
            
            val_27 = this.UseMatrix(thisMatrix: out  new UnityEngine.Matrix4x4() {m00 = 1.186845E-24f, m10 = 1.186845E-24f});
            this.SetupDrawStartEnd(start: out  int val_2 = 397912004, end: out  int val_3 = 397912000, clearVertices:  true);
            val_28 = 0f;
            val_29 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_29 = 536896697;
            }
            
            if(val_28 > 0)
            {
                goto label_6;
            }
            
            val_31 = 16 + ((val_28 + 0) << 2);
            goto label_7;
            label_40:
            val_31 = val_31 + 12;
            val_29 = 536896697;
            label_7:
            var val_35 = mem[536896883];
            val_35 = val_35 & 512;
            if(val_27 != false)
            {
                    if((val_35 != 0) && (mem[536896813] == 0))
            {
                    val_32 = 536896697;
            }
            
                val_33 = mem[mem[536896789] + 20];
                val_33 = mem[536896789] + 20;
                if(mem[536896789] <= val_28)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Vector3 val_5 = MultiplyPoint3x4(point:  new UnityEngine.Vector3() {x = 1.186845E-24f, y = 0 + ((16 + ((val_28 + 0)) << 2) + 12), z = 0 + ((16 + ((val_28 + 0)) << 2) + 12) + 4});
                UnityEngine.Vector3 val_9 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_33, y = val_6, z = val_7});
                val_26 = val_26;
            }
            else
            {
                    if((val_35 != 0) && (mem[536896813] == 0))
            {
                    val_34 = 536896697;
            }
            
                val_33 = mem[mem[536896789] + 20];
                val_33 = mem[536896789] + 20;
                if(mem[536896789] <= val_28)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Vector3 val_10 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_33, y = 0 + ((16 + ((val_28 + 0)) << 2) + 12), z = 0 + ((16 + ((val_28 + 0)) << 2) + 12) + 4});
            }
            
            val_27 = val_27;
            if(val_33 < 0)
            {
                    this.SkipQuad(idx: ref  int val_11 = 397911992, widthIdx: ref  int val_12 = 397911996, widthIdxAdd: ref  int val_13 = 397911988);
            }
            else
            {
                    float val_36 = this.m_lineWidths[val_28];
                val_35 = 536896697;
                float val_37 = this.m_lineWidths[val_28];
                if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_35 = 536896697;
            }
            
                float val_14 = (mem[536896789] + 8) + val_8;
                float val_15 = val_7 + val_36;
                val_36 = 0;
                if((mem[536896789] + 20) == 0)
            {
                    val_36 = 0;
            }
            
                UnityEngine.Vector3 val_17 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_6 - val_37, z = val_15});
                if(this.m_lineVertices == null)
            {
                    val_37 = R1;
            }
            
                if( <= 0)
            {
                    val_37 = val_37;
            }
            
                float val_20 = val_7 - val_36;
                val_38 = val_8 - (mem[536896789] + 8);
                if((mem[536896789] + 20) == 0)
            {
                    val_38 = val_38;
            }
            
                UnityEngine.Vector3 val_22 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_6 - val_36, z = val_20});
                var val_23 = 0 + 3;
                this.m_lineVertices[(val_23 + (val_23 << 1)) << 2] = val_6;
                this.m_lineVertices[(val_23 + (val_23 << 1)) << 2] = val_7;
                this.m_lineVertices[(val_23 + (val_23 << 1)) << 2] = val_8;
                UnityEngine.Vector3 val_26 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_6 + val_36, z = val_15});
                var val_27 = 0 + 1;
                this.m_lineVertices[(val_27 + (val_27 << 1)) << 2] = val_6;
                this.m_lineVertices[(val_27 + (val_27 << 1)) << 2] = val_7;
                this.m_lineVertices[(val_27 + (val_27 << 1)) << 2] = val_8;
                val_26 = val_26;
                UnityEngine.Vector3 val_30 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_6 + val_37, z = val_20});
                val_33 = val_8;
                var val_31 = 0f + 2;
                val_27 = val_27;
                this.m_lineVertices[(val_31 + (val_31 << 1)) << 2] = val_6;
                this.m_lineVertices[(val_31 + (val_31 << 1)) << 2] = val_7;
                this.m_lineVertices[(val_31 + (val_31 << 1)) << 2] = val_33;
                var val_33 = 0f + 4;
                val_39 = val_28;
            }
            
            val_40 = val_39 + 1;
            if(val_40 <= 0)
            {
                goto label_40;
            }
            
            label_6:
            this.CheckNormals();
            var val_38 = mem[1152921509299738420];
            if((mem[1152921509299738420] + 178) == 0)
            {
                goto label_42;
            }
            
            val_33 = 0;
            label_44:
            val_27 = 0;
            if((mem[1152921509299738420] + 88 + 0) == 536888839)
            {
                goto label_43;
            }
            
            val_33 = val_33 + 1;
            val_27 = (uint)val_33 & 65535;
            if(val_27 < (mem[1152921509299738420] + 178))
            {
                goto label_44;
            }
            
            label_42:
            val_41 = mem[1152921509299738420];
            return;
            label_43:
            var val_34 = (mem[1152921509299738420] + 88) + 0;
            val_38 = val_38 + (((mem[1152921509299738420] + 88 + 0) + 4) << 3);
            val_41 = val_38 + 196;
        }
        private void SkipQuad(ref int idx, ref int widthIdx, ref int widthIdxAdd)
        {
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    536896697 = 536896697;
            }
            
            this.m_lineVertices[(idx + (idx << 1)) << 2] = new UnityEngine.Vector3();
            this.m_lineVertices[(idx + (idx << 1)) << 2] = new UnityEngine.Vector3();
            this.m_lineVertices[(idx + (idx << 1)) << 2] = mem[536896789] + 8;
            int val_5 = idx;
            val_5 = val_5 + 1;
            int val_6 = idx;
            val_6 = val_6 + 2;
            this.m_lineVertices[(val_6 + (val_6 << 1)) << 2] = mem[536896789];
            this.m_lineVertices[(val_6 + (val_6 << 1)) << 2] = new UnityEngine.Vector3();
            this.m_lineVertices[(val_6 + (val_6 << 1)) << 2] = new UnityEngine.Vector3();
            int val_7 = idx;
            val_7 = val_7 + 3;
            this.m_lineVertices[(val_7 + (val_7 << 1)) << 2] = mem[536896789];
            this.m_lineVertices[(val_7 + (val_7 << 1)) << 2] = new UnityEngine.Vector3();
            this.m_lineVertices[(val_7 + (val_7 << 1)) << 2] = new UnityEngine.Vector3();
            int val_8 = idx;
            val_8 = val_8 + 4;
            idx = val_8;
            int val_9 = widthIdx;
            val_9 = widthIdxAdd + val_9;
            mem2[0] = val_9;
        }
        private void SkipQuad3D(ref int idx, ref int widthIdx, ref int widthIdxAdd)
        {
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    536896697 = 536896697;
            }
            
            this.m_lineVertices[(idx + (idx << 1)) << 2] = mem[536896789];
            this.m_lineVertices[(idx + (idx << 1)) << 2] = mem[536896789] + 4;
            this.m_lineVertices[(idx + (idx << 1)) << 2] = mem[536896789] + 8;
            int val_9 = idx;
            val_9 = val_9 + 1;
            int val_10 = idx;
            val_10 = val_10 + 2;
            this.m_lineVertices[(val_10 + (val_10 << 1)) << 2] = mem[536896789];
            this.m_lineVertices[(val_10 + (val_10 << 1)) << 2] = mem[536896789] + 4;
            this.m_lineVertices[(val_10 + (val_10 << 1)) << 2] = mem[536896789] + 8;
            int val_11 = idx;
            val_11 = val_11 + 3;
            this.m_lineVertices[(val_11 + (val_11 << 1)) << 2] = new UnityEngine.Vector3();
            this.m_lineVertices[(val_11 + (val_11 << 1)) << 2] = new UnityEngine.Vector3();
            this.m_lineVertices[(val_11 + (val_11 << 1)) << 2] = mem[536896789] + 8;
            this.m_screenPoints[(idx + (idx << 1)) << 2] = mem[536896789];
            this.m_screenPoints[(idx + (idx << 1)) << 2] = new UnityEngine.Vector3();
            this.m_screenPoints[(idx + (idx << 1)) << 2] = new UnityEngine.Vector3();
            int val_12 = idx;
            val_12 = val_12 + 1;
            this.m_screenPoints[(val_12 + (val_12 << 1)) << 2] = new UnityEngine.Vector3();
            this.m_screenPoints[(val_12 + (val_12 << 1)) << 2] = new UnityEngine.Vector3();
            this.m_screenPoints[(val_12 + (val_12 << 1)) << 2] = mem[536896789] + 8;
            int val_13 = idx;
            val_13 = val_13 + 2;
            this.m_screenPoints[(val_13 + (val_13 << 1)) << 2] = new UnityEngine.Vector3();
            this.m_screenPoints[(val_13 + (val_13 << 1)) << 2] = new UnityEngine.Vector3();
            this.m_screenPoints[(val_13 + (val_13 << 1)) << 2] = mem[536896789] + 8;
            int val_14 = idx;
            val_14 = val_14 + 3;
            this.m_screenPoints[(val_14 + (val_14 << 1)) << 2] = new UnityEngine.Vector3();
            this.m_screenPoints[(val_14 + (val_14 << 1)) << 2] = new UnityEngine.Vector3();
            this.m_screenPoints[(val_14 + (val_14 << 1)) << 2] = mem[536896789] + 8;
            int val_15 = idx;
            val_15 = val_15 + 4;
            idx = val_15;
            int val_16 = widthIdx;
            val_16 = widthIdxAdd + val_16;
            mem2[0] = val_16;
        }
        private void WeldJoins(int start, int end, bool connectFirstAndLast)
        {
            int val_12 = start;
            if(connectFirstAndLast == false)
            {
                goto label_1;
            }
            
            this.SetIntersectionPoint(p1:  this.m_vertexCount - 4, p2:  this.m_vertexCount - 3, p3:  0, p4:  1);
            this.SetIntersectionPoint(p1:  this.m_vertexCount - 1, p2:  this.m_vertexCount - 2, p3:  3, p4:  2);
            goto label_1;
            label_2:
            this.SetIntersectionPoint(p1:  val_12 - 4, p2:  val_12 - 3, p3:  val_12 = start, p4:  val_12 + 1);
            this.SetIntersectionPoint(p1:  val_12 - 1, p2:  val_12 - 2, p3:  val_12 + 3, p4:  val_12 + 2);
            val_12 = val_12 + 4;
            label_1:
            if(val_12 < end)
            {
                goto label_2;
            }
        
        }
        private void WeldJoinsDiscrete(int start, int end, bool connectFirstAndLast)
        {
            Vectrosity.VectorLine val_24;
            int val_25;
            var val_26;
            int val_27;
            var val_28;
            val_24 = this;
            val_25 = end;
            val_26 = start;
            if(connectFirstAndLast != false)
            {
                    this.SetIntersectionPoint(p1:  this.m_vertexCount - 4, p2:  this.m_vertexCount - 3, p3:  0, p4:  1);
                this.SetIntersectionPoint(p1:  this.m_vertexCount - 1, p2:  this.m_vertexCount - 2, p3:  3, p4:  2);
            }
            
            int val_5 = val_26 + 1;
            val_5 = val_5 + (val_5 >> 31);
            val_27 = 3 & (val_5 << 1);
            if(this.m_is2D != false)
            {
                    if(val_26 >= val_25)
            {
                    return;
            }
            
                var val_6 = 16 + (val_26 << 3);
                do
            {
                if(16 <= val_26)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_28 = mem[0 + (16 + (start) << 3)];
                val_28 = 0 + (16 + (start) << 3);
                val_26 = val_26 + 1;
                if((0 + (16 + (start) << 3)) <= val_26)
            {
                    var val_23 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_24 = 0 + (16 + (start) << 3) + 4;
                val_24 = val_24;
                val_23 = val_23 + val_6;
                var val_25 = (0 + (16 + (start) << 3)) + 8;
                val_24 = val_24 - ((0 + (16 + (start) << 3)) + 12);
                val_25 = val_28 - val_25;
                val_24 = val_24 * val_24;
                if((0 + (16 + (start) << 3)) < 0)
            {
                    val_5 = val_27 - 3;
                this.SetIntersectionPoint(p1:  val_27 - 4, p2:  val_5, p3:  val_27, p4:  val_27 + 1);
                this.SetIntersectionPoint(p1:  val_27 - 1, p2:  val_27 - 2, p3:  val_27 + 3, p4:  val_27 + 2);
            }
            
                val_26 = val_26 + 1;
                val_6 = val_6 + 16;
                val_27 = val_27 + 4;
            }
            while(val_26 < val_25);
            
                return;
            }
            
            if(val_26 >= val_25)
            {
                    return;
            }
            
            int val_13 = val_26 + (val_26 << 1);
            var val_14 = 20 + (val_13 << 2);
            do
            {
                if(val_13 <= val_26)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_26 = val_26 + 1;
                if((0 + (20 + ((start + (start) << 1)) << 2)) <= val_26)
            {
                    var val_26 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_26 = val_26 + val_14;
                val_24 = val_24;
                if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = 0 + (20 + ((start + (start) << 1)) << 2) + -4, y = 0 + (20 + ((start + (start) << 1)) << 2), z = 0 + (20 + ((start + (start) << 1)) << 2) + 4}, rhs:  new UnityEngine.Vector3() {x = (0 + (20 + ((start + (start) << 1)) << 2)) + 8, y = (0 + (20 + ((start + (start) << 1)) << 2)) + 12, z = (0 + (20 + ((start + (start) << 1)) << 2)) + 16})) != false)
            {
                    this.SetIntersectionPoint(p1:  val_27 - 4, p2:  val_27 - 3, p3:  val_27, p4:  val_27 + 1);
                this.SetIntersectionPoint(p1:  val_27 - 1, p2:  val_27 - 2, p3:  val_27 + 3, p4:  val_27 + 2);
            }
            
                val_25 = val_25;
                val_26 = val_26 + 1;
                val_28 = val_14 + 24;
                val_27 = val_27 + 4;
            }
            while(val_26 < val_25);
        
        }
        private void SetIntersectionPoint(int p1, int p2, int p3, int p4)
        {
            var val_20;
            int val_21;
            var val_22;
            UnityEngine.Vector3 val_19 = this.m_lineVertices[(p1 + (p1 << 1)) << 2];
            UnityEngine.Vector3 val_20 = this.m_lineVertices[(p1 + (p1 << 1)) << 2];
            UnityEngine.Vector3 val_21 = this.m_lineVertices[(p1 + (p1 << 1)) << 2];
            val_20 = p2 + (p2 << 1);
            UnityEngine.Vector3 val_22 = this.m_lineVertices[val_20 << 2];
            UnityEngine.Vector3 val_23 = this.m_lineVertices[val_20 << 2];
            UnityEngine.Vector3 val_24 = this.m_lineVertices[val_20 << 2];
            int val_2 = p3 + (p3 << 1);
            val_21 = p4;
            val_22 = val_2;
            UnityEngine.Vector3 val_25 = this.m_lineVertices[val_2 << 2];
            UnityEngine.Vector3 val_26 = this.m_lineVertices[val_2 << 2];
            if((this.m_lineVertices[val_2 << 2]) == val_21)
            {
                    return;
            }
            
            if((this.m_lineVertices[val_2 << 2]) == val_21)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = (this.m_lineVertices[(val_21 + (val_21 << 1)) << 2]) - val_26;
            UnityEngine.Vector3 val_6 = (this.m_lineVertices[(val_21 + (val_21 << 1)) << 2]) - val_25;
            UnityEngine.Vector3 val_7 = val_23 - val_20;
            if(((this.m_lineVertices[val_2 << 2]) > val_21) && ((this.m_lineVertices[val_2 << 2]) < 0))
            {
                    float val_30 = System.Math.Abs(val_22 - val_25);
                if((this.m_lineVertices[val_2 << 2]) >= 0)
            {
                    return;
            }
            
                float val_31 = System.Math.Abs(val_23 - val_26);
                if((this.m_lineVertices[val_2 << 2]) >= 0)
            {
                    return;
            }
            
                float val_32 = 0.5f;
                UnityEngine.Vector3 val_11 = val_23 + val_26;
                UnityEngine.Vector3 val_12 = val_22 + val_25;
                val_11 = val_11 * val_32;
                val_12 = val_12 * val_32;
                val_32 = ((this.m_lineVertices[val_2 << 2]) + val_24) * val_32;
                this.m_lineVertices[val_20 << 2] = val_12;
                this.m_lineVertices[val_20 << 2] = val_11;
                this.m_lineVertices[val_20 << 2] = val_32;
                val_21 = val_22;
                return;
            }
            
            UnityEngine.Vector3 val_15 = val_19 - val_25;
            val_6 = (val_20 - val_26) * val_6;
            val_4 = val_6 / ((val_22 - val_19) * val_4);
            float val_33 = val_24;
            val_33 = val_21 - val_33;
            UnityEngine.Vector3 val_16 = val_20 - val_23;
            float val_18 = val_19 - val_22.sqrMagnitude;
            if((this.m_lineVertices[val_2 << 2]) > val_21)
            {
                    return;
            }
            
            this.m_lineVertices[val_20 << 2] = val_19;
            this.m_lineVertices[val_20 << 2] = val_20;
            this.m_lineVertices[val_20 << 2] = val_21;
            this.m_lineVertices[val_22 << 2] = val_19;
            this.m_lineVertices[val_22 << 2] = val_20;
            this.m_lineVertices[val_22 << 2] = val_21;
        }
        private void WeldJoins3D(int start, int end, bool connectFirstAndLast)
        {
            int val_12;
            if(connectFirstAndLast != false)
            {
                    this.SetIntersectionPoint3D(p1:  this.m_vertexCount - 4, p2:  this.m_vertexCount - 3, p3:  0, p4:  1);
                this.SetIntersectionPoint3D(p1:  this.m_vertexCount - 1, p2:  this.m_vertexCount - 2, p3:  3, p4:  2);
            }
            
            if(this.m_drawStart >= 1)
            {
                    val_12 = start + 4;
            }
            
            goto label_1;
            label_2:
            this.SetIntersectionPoint3D(p1:  val_12 - 4, p2:  val_12 - 3, p3:  val_12, p4:  val_12 + 1);
            this.SetIntersectionPoint3D(p1:  val_12 - 1, p2:  val_12 - 2, p3:  val_12 + 3, p4:  val_12 + 2);
            val_12 = val_12 + 4;
            label_1:
            if(val_12 < end)
            {
                goto label_2;
            }
        
        }
        private void WeldJoinsDiscrete3D(int start, int end, bool connectFirstAndLast)
        {
            var val_17;
            var val_18;
            val_17 = start;
            val_18 = 22979077;
            if(connectFirstAndLast != false)
            {
                    this.SetIntersectionPoint3D(p1:  this.m_vertexCount - 4, p2:  this.m_vertexCount - 3, p3:  0, p4:  1);
                this.SetIntersectionPoint3D(p1:  this.m_vertexCount - 1, p2:  this.m_vertexCount - 2, p3:  3, p4:  2);
            }
            
            if(val_17 >= end)
            {
                    return;
            }
            
            var val_6 = 20 + ((val_17 + (val_17 << 1)) << 2);
            int val_7 = val_17 + 1;
            val_7 = val_7 + (val_7 >> 31);
            int val_8 = 3 & (val_7 << 1);
            do
            {
                if(val_7 <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_17 = val_17 + 1;
                if((0 + (20 + ((start + (start) << 1)) << 2)) <= val_17)
            {
                    var val_17 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_17 = val_17 + val_6;
                if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = 0 + (20 + ((start + (start) << 1)) << 2) + -4, y = 0 + (20 + ((start + (start) << 1)) << 2), z = 0 + (20 + ((start + (start) << 1)) << 2) + 4}, rhs:  new UnityEngine.Vector3() {x = (0 + (20 + ((start + (start) << 1)) << 2)) + 8, y = (0 + (20 + ((start + (start) << 1)) << 2)) + 12, z = (0 + (20 + ((start + (start) << 1)) << 2)) + 16})) != false)
            {
                    this.SetIntersectionPoint3D(p1:  val_8 - 4, p2:  val_8 - 3, p3:  val_8, p4:  val_8 + 1);
                this.SetIntersectionPoint3D(p1:  val_8 - 1, p2:  val_8 - 2, p3:  val_8 + 3, p4:  val_8 + 2);
            }
            
                val_17 = val_17 + 1;
                val_6 = val_6 + 24;
                val_18 = val_8 + 4;
            }
            while(val_17 < end);
        
        }
        private void SetIntersectionPoint3D(int p1, int p2, int p3, int p4)
        {
            UnityEngine.Vector3[] val_21;
            UnityEngine.Vector3 val_22;
            int val_23;
            var val_25;
            float val_26;
            UnityEngine.Vector3[] val_30;
            var val_31;
            UnityEngine.Vector3 val_32;
            val_21 = this;
            UnityEngine.Vector3 val_21 = this.m_screenPoints[(p1 + (p1 << 1)) << 2];
            UnityEngine.Vector3 val_22 = this.m_screenPoints[(p1 + (p1 << 1)) << 2];
            int val_2 = p2 + (p2 << 1);
            val_22 = this.m_screenPoints[val_2 << 2];
            UnityEngine.Vector3 val_24 = this.m_screenPoints[val_2 << 2];
            UnityEngine.Vector3 val_25 = this.m_screenPoints[val_2 << 2];
            int val_3 = p3 + (p3 << 1);
            val_23 = p4;
            UnityEngine.Vector3 val_26 = this.m_screenPoints[val_3 << 2];
            UnityEngine.Vector3 val_27 = this.m_screenPoints[val_3 << 2];
            if((this.m_screenPoints[val_3 << 2]) == val_23)
            {
                    return;
            }
            
            if((this.m_screenPoints[val_3 << 2]) == val_23)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = (this.m_screenPoints[(val_23 + (val_23 << 1)) << 2]) - val_27;
            UnityEngine.Vector3 val_7 = (this.m_screenPoints[(val_23 + (val_23 << 1)) << 2]) - val_26;
            UnityEngine.Vector3 val_8 = val_25 - val_22;
            if(((this.m_screenPoints[val_3 << 2]) <= val_23) || ((this.m_screenPoints[val_3 << 2]) >= 0))
            {
                goto label_12;
            }
            
            float val_31 = System.Math.Abs(val_24 - val_26);
            if((this.m_screenPoints[val_3 << 2]) >= 0)
            {
                    return;
            }
            
            float val_32 = System.Math.Abs(val_25 - val_27);
            if((this.m_screenPoints[val_3 << 2]) >= 0)
            {
                    return;
            }
            
            val_25 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_25 = 536896697;
            }
            
            var val_33 = val_22;
            float val_34 = 0.5f;
            UnityEngine.Vector3 val_12 = val_25 + val_27;
            UnityEngine.Vector3 val_13 = val_24 + val_26;
            val_33 = (this.m_screenPoints[val_3 << 2]) + val_33;
            val_12 = val_12 * val_34;
            val_13 = val_13 * val_34;
            val_34 = val_33 * val_34;
            val_26 = val_12;
            if((mem[536896789] + 20) == 0)
            {
                    val_23 = val_26;
                val_26 = val_23;
            }
            
            UnityEngine.Vector3 val_14 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_13, z = val_26});
            val_30 = this.m_lineVertices;
            if(val_30 == null)
            {
                    val_30 = this.m_lineVertices;
            }
            
            if((this.m_lineVertices + 12) > p2)
            {
                goto label_26;
            }
            
            val_30 = this.m_lineVertices;
            goto label_26;
            label_12:
            UnityEngine.Vector3 val_16 = val_21 - val_26;
            val_7 = (val_22 - val_27) * val_7;
            val_5 = val_7 / ((val_24 - val_21) * val_5);
            float val_35 = val_22;
            val_35 = (this.m_screenPoints[(p1 + (p1 << 1)) << 2]) - val_35;
            UnityEngine.Vector3 val_17 = val_22 - val_25;
            float val_19 = val_21 - val_24.sqrMagnitude;
            if((this.m_screenPoints[val_3 << 2]) > val_23)
            {
                    return;
            }
            
            val_23 = this.m_lineVertices;
            val_31 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_31 = 536896697;
            }
            
            val_32 = val_22;
            if((mem[536896789] + 20) == 0)
            {
                    val_32 = val_32;
            }
            
            UnityEngine.Vector3 val_20 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = val_21, z = val_32});
            val_30 = val_23;
            if(val_23 == null)
            {
                    val_30 = val_23;
            }
            
            if(400646380 <= p2)
            {
                    val_30 = val_23;
            }
            
            label_26:
            val_30[val_2 << 2] = new UnityEngine.Vector3();
            val_30[val_2 << 2] = new UnityEngine.Vector3();
            val_30[val_2 << 2] = new UnityEngine.Vector3();
            val_21 = this.m_lineVertices;
            val_22 = val_21[val_2 << 2];
            val_21[val_3 << 2] = val_21[val_2 << 2];
            val_21[val_3 << 2] = val_21[val_2 << 2];
            val_21[val_3 << 2] = val_22;
        }
        public static void LineManagerCheckDistance()
        {
            Vectrosity.LineManager val_1 = Vectrosity.VectorLine.lineManager;
            536896697.StartCheckDistance();
        }
        public static void LineManagerDisable()
        {
            Vectrosity.LineManager val_1 = Vectrosity.VectorLine.lineManager;
            536896697.DisableIfUnused();
        }
        public static void LineManagerEnable()
        {
            Vectrosity.LineManager val_1 = Vectrosity.VectorLine.lineManager;
            536896697.EnableIfUsed();
        }
        public void Draw3DAuto()
        {
            this.Draw3DAuto(time:  null);
        }
        public void Draw3DAuto(float time)
        {
            Vectrosity.LineManager val_1 = Vectrosity.VectorLine.lineManager;
            536896697.AddLine(vectorLine:  401480592, thisTransform:  this.m_drawTransform, time:  0f);
            this.m_isAutoDrawing = true;
            this.Draw3D();
        }
        public void StopDrawing3DAuto()
        {
            Vectrosity.LineManager val_1 = Vectrosity.VectorLine.lineManager;
            536896697.RemoveLine(vectorLine:  401596688);
            this.m_isAutoDrawing = false;
        }
        private void SetTextureScale()
        {
            var val_45;
            var val_49;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
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
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            int val_1 = this.pointsCount;
            if(val_1 != mem[1152921509303523020])
            {
                    val_1 = this;
                this.Resize();
            }
            
            this.SetupDrawStartEnd(start: out  int val_2 = 401696576, end: out  int val_3 = 401696572, clearVertices:  false);
            if(mem[1152921509303523064] == 1)
            {
                    1 = 2;
            }
            
            var val_52 = mem[1152921509303523164];
            var val_51 = mem[1152921509303523028] + 12;
            val_51 = val_51 - 1;
            if(mem[1152921509303523028] != 0)
            {
                    val_51 = 1;
            }
            
            if(mem[1152921509303523156] != 0)
            {
                    UnityEngine.Matrix4x4 val_5 = localToWorldMatrix;
            }
            else
            {
                    UnityEngine.Matrix4x4 val_6 = UnityEngine.Matrix4x4.identity;
            }
            
            val_52 = 1f / val_52;
            float val_7 = val_6.m13 + 56;
            float val_8 = val_6.m13 + 56;
            float val_9 = val_6.m13 + 56;
            float val_77 = val_6.m13 + 52 + 212;
            if((val_6.m13 + 52 + 48) == 0)
            {
                goto label_7;
            }
            
            mem2[0] = val_6.m32 + -108;
            if((val_6.m32 + -108) < 1)
            {
                goto label_56;
            }
            
            var val_53 = val_6.m13 + 28;
            val_53 = val_53 << 3;
            mem2[0] = val_53;
            var val_54 = val_6.m13 + 24;
            val_54 = val_54 << 2;
            mem2[0] = val_54;
            mem2[0] = 0;
            mem2[0] = 0;
            label_53:
            val_57 = mem[val_6.m13 + 52];
            val_57 = val_6.m13 + 52;
            mem2[0] = 16;
            if((val_6.m13 + 52 + 200) == 0)
            {
                goto label_10;
            }
            
            if((val_6.m13 + 20) == 0)
            {
                goto label_11;
            }
            
            var val_55 = val_6.m13 + 52 + 52 + 8;
            val_55 = val_55 + 16;
            var val_56 = val_6.m13 + 52 + 52 + 8;
            val_56 = val_56 + 16;
            float val_11 = val_6.m32 - 176;
            float val_57 = 0f;
            float val_58 = 0f;
            mem2[0] = 0;
            mem2[0] = 0;
            float val_12 = val_6.m13 + 56;
            val_57 = val_55 * val_57;
            val_58 = val_58 * ((val_6.m13 + 52 + 52 + 8 + 16) + 4);
            mem2[0] = val_6.m13 + 56;
            mem2[0] = val_6.m13 + 60;
            var val_13 = 0 + 1;
            var val_59 = val_6.m13 + 52 + 52 + 8;
            val_59 = val_59 + 16;
            var val_60 = val_6.m13 + 52 + 52 + 8;
            val_60 = val_60 + (val_6.m13 + 40);
            float val_14 = val_6.m32 - 176;
            float val_61 = 0f;
            float val_62 = 0f;
            mem2[0] = 0;
            mem2[0] = 0;
            float val_15 = val_6.m13 + 56;
            val_61 = ((val_6.m13 + 52 + 52 + 8 + 16) + 8) * val_61;
            val_62 = val_62 * ((val_6.m13 + 52 + 52 + 8 + val_6.m13 + 40) + 12);
            val_58 = mem[val_6.m13 + 56];
            val_58 = val_6.m13 + 56;
            val_59 = mem[val_6.m13 + 60];
            val_59 = val_6.m13 + 60;
            goto label_32;
            label_10:
            if((val_6.m13 + 20) == 0)
            {
                goto label_20;
            }
            
            float val_16 = val_6.m32 - 176;
            mem2[0] = 0;
            mem2[0] = 0;
            float val_17 = val_6.m13 + 56;
            mem2[0] = val_6.m13 + 56;
            mem2[0] = val_6.m13 + 60;
            var val_18 = 0 + 1;
            var val_63 = val_6.m13 + 52 + 52 + 8;
            float val_19 = val_6.m32 - 176;
            val_63 = val_63 + 16;
            mem2[0] = 0;
            mem2[0] = 0;
            float val_20 = val_6.m13 + 56;
            val_58 = mem[val_6.m13 + 56];
            val_58 = val_6.m13 + 56;
            val_59 = mem[val_6.m13 + 60];
            val_59 = val_6.m13 + 60;
            goto label_24;
            label_11:
            float val_64 = val_6.m13 + 52 + 52 + 8;
            val_64 = val_64 + 16;
            float val_67 = val_64;
            var val_65 = val_6.m13 + 52 + 52 + 8;
            val_65 = val_65 + 16;
            float val_68 = (val_6.m13 + 52 + 52 + 8 + 16) + 4;
            var val_21 = 0 + 1;
            var val_66 = val_6.m13 + 52 + 52 + 8;
            val_66 = val_66 + 16;
            val_67 = val_67 * 0f;
            val_68 = 0f * val_68;
            mem2[0] = val_67;
            mem2[0] = val_68;
            var val_69 = val_6.m13 + 52 + 52 + 8;
            val_69 = val_69 + (val_6.m13 + 40);
            float val_70 = 0f;
            float val_71 = 0f;
            val_70 = ((val_6.m13 + 52 + 52 + 8 + 16) + 8) * val_70;
            val_71 = val_71 * ((val_6.m13 + 52 + 52 + 8 + val_6.m13 + 40) + 12);
            val_58 = val_70;
            val_59 = val_71;
            goto label_32;
            label_20:
            mem2[0] = val_6.m13 + 52 + 52 + 8 + 16;
            var val_72 = val_6.m13 + 52 + 52 + 8;
            val_72 = val_72 + 16;
            mem2[0] = (val_6.m13 + 52 + 52 + 8 + 16) + 4;
            var val_22 = 0 + 1;
            var val_73 = val_6.m13 + 52 + 52 + 8;
            val_73 = val_73 + (val_6.m13 + 40);
            val_58 = mem[(val_6.m13 + 52 + 52 + 8 + val_6.m13 + 40) + 8];
            val_58 = (val_6.m13 + 52 + 52 + 8 + val_6.m13 + 40) + 8;
            var val_74 = val_6.m13 + 52 + 52 + 8;
            val_74 = val_74 + (val_6.m13 + 40);
            val_59 = mem[(val_6.m13 + 52 + 52 + 8 + val_6.m13 + 40) + 12];
            val_59 = (val_6.m13 + 52 + 52 + 8 + val_6.m13 + 40) + 12;
            label_32:
            val_57 = mem[val_6.m13 + 52];
            val_57 = val_6.m13 + 52;
            label_24:
            var val_75 = val_59;
            val_75 = val_75 - (val_6.m13 + 32);
            float val_23 = val_58 - (val_6.m13 + 36);
            var val_76 = (val_6.m13 + 52 + 68) + 16;
            if(mem[536890411] >= _TYPE_MAX_)
            {
                    val_60 = val_75 * val_75;
            }
            
            var val_26 = (val_6.m13 + 52 + 12) + 0;
            mem2[0] = val_77;
            val_60 = ((val_6.m13 + 52 + 108) + (val_6.m13 + 52 + 108)) + val_60;
            val_76 = val_76 + val_76;
            var val_27 = (val_6.m13 + 44) + 3;
            val_76 = val_76 / val_60;
            var val_28 = (val_6.m13 + 52 + 12) + 0;
            mem2[0] = val_77;
            val_76 = val_52 / val_76;
            val_27 = val_27 - 1;
            val_77 = val_77 + val_76;
            var val_29 = (val_6.m13 + 52 + 12) + 0;
            mem2[0] = val_77;
            val_54 = mem[val_6.m13 + 52 + 12];
            val_54 = val_6.m13 + 52 + 12;
            val_27 = val_27 - 1;
            var val_30 = val_54 + 0;
            mem2[0] = val_77;
            val_56 = 0 + 32;
            val_45 = (val_6.m13 + 40) + (val_6.m13 + 12);
            var val_78 = val_6.m13 + 48;
            val_55 = 16 + (val_6.m13 + 8);
            val_49 = 0 + (val_6.m13 + 28);
            val_78 = val_78 + (val_6.m13 + 24);
            mem2[0] = val_78;
            mem2[0] = val_27 + 3;
            if(val_49 < (val_6.m13 + 16))
            {
                goto label_53;
            }
            
            goto label_56;
            label_7:
            if((val_6.m13 + 52) == 0)
            {
                goto label_89;
            }
            
            mem2[0] = val_6.m32 + -108;
            if((val_6.m32 + -108) >= 1)
            {
                    var val_79 = val_6.m13 + 24;
                val_61 = 16;
                val_79 = val_79 << 2;
                mem2[0] = val_79;
                var val_80 = val_6.m13 + 28;
                val_80 = val_80 + (val_80 << 1);
                val_80 = val_80 << 2;
                mem2[0] = val_80;
                mem2[0] = 0;
                do
            {
                mem2[0] = 20;
                val_62 = 536896697;
                mem2[0] = 0;
                var val_81 = mem[536896883];
                val_81 = val_81 & 512;
                if((val_6.m13 + 20) != 0)
            {
                    if((val_81 != 0) && (mem[536896813] == 0))
            {
                    val_63 = 536896697;
            }
            
                mem2[0] = val_61;
                float val_32 = val_6.m13 + 56;
                float val_33 = val_6.m32 - 176;
                val_64 = 0;
                if((mem[536896789] + 20) == 0)
            {
                    val_64 = 0;
            }
            
                mem2[0] = val_64;
                mem2[0] = val_6.m13 + 64;
                val_65 = mem[val_6.m13 + 56];
                val_65 = val_6.m13 + 56;
                val_66 = mem[val_6.m13 + 60];
                val_66 = val_6.m13 + 60;
                var val_34 = 0 + 1;
                var val_82 = val_6.m13 + 52 + 56 + 8;
                float val_35 = val_6.m13 + 56;
                float val_36 = val_6.m32 - 176;
                val_82 = val_82 + (val_6.m13 + 44);
                mem2[0] = (val_6.m13 + 52 + 56 + 8 + val_6.m13 + 44) + 16;
                mem2[0] = 0;
                mem2[0] = 0;
                mem2[0] = val_6.m13 + 64;
                val_67 = mem[val_6.m13 + 56];
                val_67 = val_6.m13 + 56;
                val_68 = mem[val_6.m13 + 60];
                val_68 = val_6.m13 + 60;
                val_61 = mem[val_6.m13 + 12];
                val_61 = val_6.m13 + 12;
            }
            else
            {
                    if((val_81 != 0) && (mem[536896813] == 0))
            {
                    val_69 = 536896697;
            }
            
                mem2[0] = 0;
                float val_37 = val_6.m13 + 56;
                mem2[0] = val_6.m13 + 52 + 56 + 8 + 20 + 4;
                val_65 = mem[val_6.m13 + 56];
                val_65 = val_6.m13 + 56;
                val_66 = mem[val_6.m13 + 60];
                val_66 = val_6.m13 + 60;
                var val_38 = 0 + 1;
                var val_83 = val_6.m13 + 52 + 56 + 8;
                val_83 = val_83 + (val_6.m13 + 44);
                mem2[0] = 0;
                float val_39 = val_6.m13 + 56;
                mem2[0] = (val_6.m13 + 52 + 56 + 8 + val_6.m13 + 44) + 16;
                val_67 = mem[val_6.m13 + 56];
                val_67 = val_6.m13 + 56;
                val_68 = mem[val_6.m13 + 60];
                val_68 = val_6.m13 + 60;
            }
            
                val_68 = val_66 - val_68;
                float val_40 = val_65 - val_67;
                var val_84 = (val_6.m13 + 52 + 68) + val_61;
                if(mem[536890411] >= _TYPE_MAX_)
            {
                    val_70 = val_68 * val_68;
            }
            
                var val_43 = (val_6.m13 + 52 + 12) + 0;
                mem2[0] = val_77;
                val_84 = val_84 + val_84;
                var val_44 = (val_6.m13 + 48) + 3;
                val_84 = val_84 / val_70;
                var val_45 = (val_6.m13 + 52 + 12) + 0;
                mem2[0] = val_77;
                val_84 = val_52 / val_84;
                val_44 = val_44 - 1;
                val_77 = val_77 + val_84;
                var val_46 = (val_6.m13 + 52 + 12) + 0;
                mem2[0] = val_77;
                val_44 = val_44 - 1;
                var val_47 = (val_6.m13 + 52 + 12) + 0;
                mem2[0] = val_77;
                val_56 = 0 + 32;
                val_54 = (val_6.m13 + 44) + (val_6.m13 + 16);
                val_45 = val_61 + (val_6.m13 + 32);
                val_49 = 0 + (val_6.m13 + 28);
                val_55 = (val_6.m13 + 40) + (val_6.m13 + 24);
                mem2[0] = val_44 + 3;
            }
            while(val_49 < (val_6.m13 + 36));
            
            }
            
            label_56:
            if((val_6.m13 + 52 + 36) == 0)
            {
                goto label_89;
            }
            
            var val_85 = val_6.m13 + 52 + 36;
            if((val_6.m13 + 52 + 36 + 178) == 0)
            {
                goto label_90;
            }
            
            val_55 = 0;
            label_92:
            val_54 = 0;
            if((val_6.m13 + 52 + 36 + 88 + 0) == 536888839)
            {
                goto label_91;
            }
            
            val_55 = val_55 + 1;
            val_54 = (uint)val_55 & 65535;
            if(val_54 < (val_6.m13 + 52 + 36 + 178))
            {
                goto label_92;
            }
            
            label_90:
            val_71 = val_6.m13 + 52 + 36;
            goto label_93;
            label_91:
            var val_49 = (val_6.m13 + 52 + 36 + 88) + 0;
            val_85 = val_85 + (((val_6.m13 + 52 + 36 + 88 + 0) + 4) << 3);
            val_71 = val_85 + 204;
            label_93:
            label_89:
            float val_50 = val_6.m32 - 96;
            val_50 = val_50 + 4;
        }
        private void ResetTextureScale()
        {
            UnityEngine.Vector2[] val_2;
            var val_3;
            var val_4;
            if(this.m_vertexCount >= 1)
            {
                    var val_2 = 0;
                do
            {
                this.m_lineUVs[0] = 0;
                val_2 = val_2 + 3;
                this.m_lineUVs[0] = 0;
                val_2 = val_2 - 1;
                this.m_lineUVs[0] = 1065353216;
                val_2 = this.m_lineUVs;
                val_2 = val_2 - 1;
                val_2 = val_2 + 3;
                val_3 = 0 + 32;
                val_2[0] = 1065353216;
            }
            while(val_2 < this.m_vertexCount);
            
            }
            
            if(this.m_vectorObject == 0)
            {
                    return;
            }
            
            val_3 = 0;
            val_2 = 0;
            val_3 = val_3 + 1;
            val_2 = (uint)val_3 & 65535;
            val_4 = this.m_vectorObject;
            goto mem[(1152921504869146624 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private void SetCollider(bool convertToWorldSpace)
        {
            float val_5;
            var val_55;
            bool val_56;
            float val_57;
            var val_58;
            var val_59;
            var val_60;
            int val_61;
            var val_62;
            UnityEngine.Vector2[] val_63;
            var val_64;
            val_55 = this;
            val_56 = convertToWorldSpace;
            val_57 = 4.015532E-38f;
            val_58 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_58 = 536896697;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  mem[536896789] + 20)) == true)
            {
                goto label_5;
            }
            
            Vectrosity.VectorLine.SetCamera3D();
            if((UnityEngine.Object.op_Implicit(exists:  mem[536896789] + 20)) == false)
            {
                goto label_10;
            }
            
            label_5:
            val_59 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_59 = 536896697;
            }
            
            UnityEngine.Transform val_3 = mem[536896789] + 20.transform;
            UnityEngine.Quaternion val_4 = rotation;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
            if((UnityEngine.Quaternion.op_Inequality(lhs:  new UnityEngine.Quaternion() {x = R4, y = R6, z = R7, w = val_5}, rhs:  new UnityEngine.Quaternion())) != false)
            {
                    UnityEngine.Debug.LogWarning(message:  -1610603769);
            }
            
            val_60 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_60 = 536896697;
            }
            
            val_57 = 0;
            UnityEngine.Transform val_8 = mem[536896789] + 20.transform;
            UnityEngine.Vector3 val_9 = position;
            val_61 = 0;
            if(this.m_capType != 4)
            {
                    val_57 = 0;
                if(this.m_capType <= 2)
            {
                    val_57 = (mem[536896789] + 20) >> 5;
                if(this.m_capType < 1)
            {
                goto label_64;
            }
            
            }
            
                int val_11 = this.pointsCount;
                val_11 = val_11 - 1;
                val_11 = this.m_drawEnd - val_11;
                val_61 = val_11 >> 5;
            }
            
            label_64:
            if(this.m_lineType == 0)
            {
                goto label_25;
            }
            
            val_62 = this.m_drawEnd;
            val_56 = 0;
            System.Type val_12 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073762869)});
            UnityEngine.Component val_13 = this.m_go.GetComponent(type:  1073762869);
            if(this.m_go != 0)
            {
                    if(null != 536891957)
            {
                    this.m_go = 0;
            }
            
                val_56 = this.m_go;
            }
            
            val_63 = 536882585;
            int val_51 = this.m_drawStart;
            val_51 = 1 - val_51;
            val_51 = val_51 + val_62;
            val_51 = val_51 + (val_51 >> 31);
            val_51 = val_57 + (val_51 >> 1);
            val_56.pathCount = val_51 + val_61;
            int val_15 = val_62 + 1;
            val_15 = val_15 + (val_15 >> 31);
            var val_16 = 3 & (val_15 << 1);
            if(val_56 == false)
            {
                goto label_31;
            }
            
            if(val_57 != 0)
            {
                    this.SetPathWorldVerticesDiscrete(i: ref  int val_17 = 402236028, v3: ref  new UnityEngine.Vector3() {x = 1.613227E-24f, y = 1.613225E-24f, z = 1.085711E-19f}, pIdx: ref  val_56, path:  null, collider:  null);
            }
            
            int val_52 = this.m_drawStart;
            val_52 = val_52 + (val_52 >> 31);
            val_52 = 3 & (val_52 << 1);
            if(val_52 < val_16)
            {
                    do
            {
                this.SetPathWorldVerticesDiscrete(i: ref  int val_19 = 402236028, v3: ref  new UnityEngine.Vector3() {x = 1.613227E-24f, y = 1.613225E-24f, z = 1.085711E-19f}, pIdx: ref  val_56, path:  null, collider:  null);
                var val_53 = val_52;
                val_53 = val_53 + 4;
            }
            while(val_53 < val_16);
            
            }
            
            if(val_61 == 0)
            {
                    return;
            }
            
            int val_54 = this.m_vertexCount;
            val_54 = val_54 + 4;
            this.SetPathWorldVerticesDiscrete(i: ref  int val_21 = 402236028, v3: ref  new UnityEngine.Vector3() {x = 1.613227E-24f, y = 1.613225E-24f, z = 1.085711E-19f}, pIdx: ref  val_56, path:  null, collider:  null);
            return;
            label_25:
            val_62 = 0;
            System.Type val_23 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073757113)});
            UnityEngine.Component val_24 = this.m_go.GetComponent(type:  1073757113);
            if(this.m_go != 0)
            {
                    if(null != 536886201)
            {
                    this.m_go = 0;
            }
            
                val_62 = this.m_go;
            }
            
            int val_25 = this.m_drawEnd - this.m_drawStart;
            int val_27 = 536882585;
            val_25 = 1 | (val_25 << 2);
            if(val_57 != 0)
            {
                    val_25 = val_25 + 4;
            }
            
            if(val_61 != 0)
            {
                    val_25 = val_25 + 4;
            }
            
            val_63 = 536882585;
            float val_55 = mem[536882597];
            val_55 = val_55 - 2;
            if(val_56 == false)
            {
                goto label_42;
            }
            
            if(val_57 != 0)
            {
                    this.SetPathWorldVerticesContinuous(i: ref  int val_26 = 402236028, v3: ref  new UnityEngine.Vector3() {x = 1.613227E-24f, y = 1.613226E-24f, z = 1.613226E-24f}, startIdx: ref  val_27, endIdx: ref  int val_28 = 0, path:  null);
            }
            
            int val_29 = this.m_drawStart << 2;
            if(val_29 < (this.m_drawEnd << 2))
            {
                    val_61 = this.m_drawEnd << 2;
                do
            {
                this.SetPathWorldVerticesContinuous(i: ref  int val_30 = 402236028, v3: ref  new UnityEngine.Vector3() {x = 1.613227E-24f, y = 1.613226E-24f, z = val_55}, startIdx: ref  val_27, endIdx: ref  int val_31 = 0, path:  null);
                int val_56 = val_29;
                val_56 = val_56 + 4;
            }
            while(val_56 < val_61);
            
            }
            
            if(val_61 == 0)
            {
                goto label_59;
            }
            
            int val_57 = this.m_vertexCount;
            val_57 = val_57 + 4;
            this.SetPathWorldVerticesContinuous(i: ref  int val_32 = 402236028, v3: ref  new UnityEngine.Vector3() {x = 1.613227E-24f, y = 1.613226E-24f, z = 1.613226E-24f}, startIdx: ref  val_27, endIdx: ref  int val_33 = 0, path:  null);
            goto label_59;
            label_10:
            UnityEngine.Debug.LogError(message:  -1610606073);
            return;
            label_31:
            if(val_57 != 0)
            {
                    this.SetPathVerticesDiscrete(i: ref  int val_34 = 402236028, pIdx: ref  int val_35 = 402236016, path:  536882585, collider:  val_56);
            }
            
            int val_58 = this.m_drawStart;
            val_58 = val_58 + (val_58 >> 31);
            val_58 = 3 & (val_58 << 1);
            if(val_58 < val_16)
            {
                    do
            {
                this.SetPathVerticesDiscrete(i: ref  int val_36 = 402236028, pIdx: ref  int val_37 = 402236016, path:  536882585, collider:  val_56);
                var val_59 = val_58;
                val_59 = val_59 + 4;
            }
            while(val_59 < val_16);
            
            }
            
            if(val_61 == 0)
            {
                    return;
            }
            
            int val_60 = this.m_vertexCount;
            val_60 = val_60 + 4;
            this.SetPathVerticesDiscrete(i: ref  int val_38 = 402236028, pIdx: ref  int val_39 = 402236016, path:  536882585, collider:  val_56);
            return;
            label_42:
            if(val_57 != 0)
            {
                    this.SetPathVerticesContinuous(i: ref  int val_40 = 402236028, startIdx: ref  int val_41 = 402236024, endIdx: ref  int val_42 = 402236020, path:  val_63);
            }
            
            int val_43 = this.m_drawStart << 2;
            if(val_43 < (this.m_drawEnd << 2))
            {
                    do
            {
                this.SetPathVerticesContinuous(i: ref  int val_45 = 402236028, startIdx: ref  int val_46 = 402236024, endIdx: ref  int val_47 = 402236020, path:  val_63);
                int val_61 = val_43;
                val_61 = val_61 + 4;
            }
            while(val_61 < (this.m_drawEnd << 2));
            
            }
            
            if(val_57 != 0)
            {
                    int val_62 = this.m_vertexCount;
                val_62 = val_62 + 4;
                this.SetPathVerticesContinuous(i: ref  int val_48 = 402236028, startIdx: ref  int val_49 = 402236024, endIdx: ref  int val_50 = 402236020, path:  val_63);
            }
            
            label_59:
            val_55 = val_62;
            val_64 = mem[536882597];
            if(val_64 == 0)
            {
                    val_64 = mem[536882597];
            }
            
            val_56 = val_64 - 1;
            val_64 = val_63 + (val_56 << 3);
            mem2[0] = mem[536882601];
            val_55.points = 536882585;
        }
        private void SetPathVerticesContinuous(ref int i, ref int startIdx, ref int endIdx, UnityEngine.Vector2[] path)
        {
            UnityEngine.Vector2[] val_9 = path;
            if(val_9 == null)
            {
                    val_9 = path;
            }
            
            if(this.m_lineVertices == null)
            {
                    val_9 = path;
            }
            
            if(this <= i)
            {
                    val_9 = path;
            }
            
            if(this <= startIdx)
            {
                    val_9 = path;
            }
            
            val_9[startIdx << 3] = this.m_lineVertices[(i + (i << 1)) << 2];
            if(this.m_lineVertices == null)
            {
                    val_9 = path;
            }
            
            if((val_9[startIdx << 3]) <= i)
            {
                    val_9 = path;
            }
            
            if((val_9[startIdx << 3]) <= startIdx)
            {
                    val_9 = path;
            }
            
            val_9[startIdx << 3] = this.m_lineVertices[(i + (i << 1)) << 2];
            int val_12 = startIdx;
            int val_11 = i;
            if(this.m_lineVertices == null)
            {
                    val_9 = path;
            }
            
            val_11 = val_11 + 1;
            if((val_9[startIdx << 3]) <= val_11)
            {
                    val_9 = path;
            }
            
            val_12 = val_12 + 1;
            if((val_9[startIdx << 3]) <= val_12)
            {
                    val_9 = path;
            }
            
            val_9[val_12 << 3] = this.m_lineVertices[(val_11 + (val_11 << 1)) << 2];
            int val_14 = i;
            int val_15 = startIdx;
            if(this.m_lineVertices == null)
            {
                    val_9 = path;
            }
            
            val_14 = val_14 + 1;
            if((val_9[val_12 << 3]) <= val_14)
            {
                    val_9 = path;
            }
            
            val_15 = val_15 + 1;
            if((val_9[val_12 << 3]) <= val_15)
            {
                    val_9 = path;
            }
            
            val_9[val_15 << 3] = this.m_lineVertices[(val_14 + (val_14 << 1)) << 2];
            int val_17 = i;
            if(this.m_lineVertices == null)
            {
                    val_9 = path;
            }
            
            val_17 = val_17 + 3;
            if((val_9[val_15 << 3]) <= val_17)
            {
                    val_9 = path;
            }
            
            if((val_9[val_15 << 3]) <= endIdx)
            {
                    val_9 = path;
            }
            
            val_9[endIdx << 3] = this.m_lineVertices[(val_17 + (val_17 << 1)) << 2];
            int val_19 = i;
            if(this.m_lineVertices == null)
            {
                    val_9 = path;
            }
            
            val_19 = val_19 + 3;
            if((val_9[endIdx << 3]) <= val_19)
            {
                    val_9 = path;
            }
            
            if((val_9[endIdx << 3]) <= endIdx)
            {
                    val_9 = path;
            }
            
            val_9[endIdx << 3] = this.m_lineVertices[(val_19 + (val_19 << 1)) << 2];
            int val_21 = i;
            int val_22 = endIdx;
            if(this.m_lineVertices == null)
            {
                    val_9 = path;
            }
            
            val_21 = val_21 + 2;
            if((val_9[endIdx << 3]) <= val_21)
            {
                    val_9 = path;
            }
            
            val_22 = val_22 - 1;
            if((val_9[endIdx << 3]) <= val_22)
            {
                    val_9 = path;
            }
            
            val_9[val_22 << 3] = this.m_lineVertices[(val_21 + (val_21 << 1)) << 2];
            int val_24 = i;
            int val_25 = endIdx;
            if(this.m_lineVertices == null)
            {
                    val_9 = path;
            }
            
            val_24 = val_24 + 2;
            if((val_9[val_22 << 3]) <= val_24)
            {
                    val_9 = path;
            }
            
            val_25 = val_25 - 1;
            if((val_9[val_22 << 3]) <= val_25)
            {
                    val_9 = path;
            }
            
            val_9[val_25 << 3] = this.m_lineVertices[(val_24 + (val_24 << 1)) << 2];
            int val_27 = startIdx;
            val_27 = val_27 + 2;
            startIdx = val_27;
            int val_28 = endIdx;
            val_28 = val_28 - 2;
            endIdx = val_28;
        }
        private void SetPathWorldVerticesContinuous(ref int i, ref UnityEngine.Vector3 v3, ref int startIdx, ref int endIdx, UnityEngine.Vector2[] path)
        {
            var val_4;
            var val_5;
            UnityEngine.Vector3 val_19;
            var val_20;
            v3.x = this.m_lineVertices[(i + (i << 1)) << 2];
            val_19 = this.m_lineVertices[(i + (i << 1)) << 2];
            mem[1152921509305157428] = val_19;
            val_20 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_19 = mem[1152921509305157428];
                val_20 = 536896697;
            }
            
            UnityEngine.Vector3 val_3 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = v3.x, z = val_19});
            var val_20 = startIdx;
            val_20 = val_20 + (v3.y << 3);
            mem2[0] = val_4;
            int val_21 = i;
            val_21 = val_21 + 1;
            v3.x = this.m_lineVertices[(val_21 + (val_21 << 1)) << 2];
            int val_23 = i;
            val_23 = val_23 + 1;
            UnityEngine.Vector3 val_24 = this.m_lineVertices[(val_23 + (val_23 << 1)) << 2];
            mem[1152921509305157428] = val_24;
            UnityEngine.Vector3 val_8 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = v3.x, z = val_24});
            var val_10 = startIdx + ((v3.y + 1) << 3);
            mem2[0] = val_4;
            mem2[0] = val_5;
            int val_25 = i;
            val_25 = val_25 + 3;
            v3.x = this.m_lineVertices[(val_25 + (val_25 << 1)) << 2];
            int val_27 = i;
            val_27 = val_27 + 3;
            UnityEngine.Vector3 val_28 = this.m_lineVertices[(val_27 + (val_27 << 1)) << 2];
            mem[1152921509305157428] = val_28;
            UnityEngine.Vector3 val_13 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = v3.x, z = val_28});
            var val_14 = startIdx + (v3.z << 3);
            mem2[0] = val_4;
            mem2[0] = val_5;
            int val_29 = i;
            val_29 = val_29 + 2;
            v3.x = this.m_lineVertices[(val_29 + (val_29 << 1)) << 2];
            int val_31 = i;
            val_31 = val_31 + 2;
            UnityEngine.Vector3 val_32 = this.m_lineVertices[(val_31 + (val_31 << 1)) << 2];
            mem[1152921509305157428] = val_32;
            UnityEngine.Vector3 val_17 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = v3.x, z = val_32});
            var val_33 = startIdx;
            val_33 = val_33 + ((v3.z - 1) << 3);
            mem2[0] = val_4;
            float val_34 = v3.y;
            val_34 = val_34 + 2;
            mem2[0] = val_34;
            float val_35 = v3.z;
            val_35 = val_35 - 2;
            v3.z = val_35;
        }
        private void SetPathVerticesDiscrete(ref int i, ref int pIdx, UnityEngine.Vector2[] path, UnityEngine.PolygonCollider2D collider)
        {
            path[0] = this.m_lineVertices[(i + (i << 1)) << 2];
            path[1] = this.m_lineVertices[(i + (i << 1)) << 2];
            int val_12 = i;
            val_12 = val_12 + 3;
            path[2] = this.m_lineVertices[(val_12 + (val_12 << 1)) << 2];
            int val_14 = i;
            val_14 = val_14 + 3;
            path[3] = this.m_lineVertices[(val_14 + (val_14 << 1)) << 2];
            int val_16 = i;
            val_16 = val_16 + 2;
            path[4] = this.m_lineVertices[(val_16 + (val_16 << 1)) << 2];
            int val_18 = i;
            val_18 = val_18 + 2;
            path[5] = this.m_lineVertices[(val_18 + (val_18 << 1)) << 2];
            int val_20 = i;
            val_20 = val_20 + 1;
            path[6] = this.m_lineVertices[(val_20 + (val_20 << 1)) << 2];
            int val_22 = i;
            val_22 = val_22 + 1;
            path[7] = this.m_lineVertices[(val_22 + (val_22 << 1)) << 2];
            pIdx = pIdx + 1;
            collider.SetPath(index:  pIdx, points:  path);
        }
        private void SetPathWorldVerticesDiscrete(ref int i, ref UnityEngine.Vector3 v3, ref int pIdx, UnityEngine.Vector2[] path, UnityEngine.PolygonCollider2D collider)
        {
            var val_4;
            var val_5;
            UnityEngine.Vector3 val_22;
            var val_23;
            v3.x = this.m_lineVertices[(i + (i << 1)) << 2];
            val_22 = this.m_lineVertices[(i + (i << 1)) << 2];
            mem[1152921509306339284] = val_22;
            val_23 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_22 = mem[1152921509306339284];
                val_23 = 536896697;
            }
            
            UnityEngine.Vector3 val_3 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = v3.x, z = val_22});
            mem[1152921509306347424] = val_4;
            mem[1152921509306347428] = val_5;
            int val_6 = i + 3;
            v3.x = this.m_lineVertices[(val_6 + (val_6 << 1)) << 2];
            int val_8 = i + 3;
            UnityEngine.Vector3 val_24 = this.m_lineVertices[(val_8 + (val_8 << 1)) << 2];
            mem[1152921509306339284] = val_24;
            UnityEngine.Vector3 val_10 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = v3.x, z = val_24});
            mem[1152921509306347432] = val_4;
            mem[1152921509306347436] = val_5;
            int val_11 = i + 2;
            v3.x = this.m_lineVertices[(val_11 + (val_11 << 1)) << 2];
            int val_13 = i + 2;
            UnityEngine.Vector3 val_26 = this.m_lineVertices[(val_13 + (val_13 << 1)) << 2];
            mem[1152921509306339284] = val_26;
            UnityEngine.Vector3 val_15 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = v3.x, z = val_26});
            mem[1152921509306347440] = val_4;
            mem[1152921509306347444] = val_5;
            int val_16 = i + 1;
            v3.x = this.m_lineVertices[(val_16 + (val_16 << 1)) << 2];
            int val_18 = i + 1;
            UnityEngine.Vector3 val_28 = this.m_lineVertices[(val_18 + (val_18 << 1)) << 2];
            mem[1152921509306339284] = val_28;
            UnityEngine.Vector3 val_20 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = mem[536896789] + 20, y = v3.x, z = val_28});
            mem[1152921509306347448] = val_4;
            mem2[0] = v3.y + 1;
            pIdx.SetPath(index:  v3.y, points:  404533136);
        }
        public static System.Collections.Generic.List<UnityEngine.Vector3> BytesToVector3List(byte[] lineBytes)
        {
            System.Collections.Generic.List<UnityEngine.Vector3> val_7;
            bool val_8 = true;
            var val_2 = (R1 >> 1) + ((R1) >> 31);
            val_2 = val_2 + (val_2 << 1);
            val_8 = val_8 - (val_2 << 2);
            if(val_8 != 0)
            {
                    val_7 = 0;
                UnityEngine.Debug.LogError(message:  -1610602783);
                return;
            }
            
            Vectrosity.VectorLine.SetupByteBlock();
            val_7 = 536878517;
            val_7 = new System.Collections.Generic.List<UnityEngine.Vector3>(capacity:  268439258);
            if(val_7 < 1)
            {
                    return;
            }
            
            int val_9 = 0;
            do
            {
                float val_4 = Vectrosity.VectorLine.ConvertToFloat(bytes:  lineBytes, i:  0);
                float val_6 = Vectrosity.VectorLine.ConvertToFloat(bytes:  lineBytes, i:  val_9 + 4);
                val_9 = val_9 + 8;
                float val_7 = Vectrosity.VectorLine.ConvertToFloat(bytes:  lineBytes, i:  val_9);
                val_7.Add(item:  new UnityEngine.Vector3() {x = lineBytes, y = lineBytes, z = lineBytes});
                val_9 = val_9 + 4;
            }
            while(val_9 < val_7);
        
        }
        public static System.Collections.Generic.List<UnityEngine.Vector2> BytesToVector2List(byte[] lineBytes)
        {
            System.Collections.Generic.List<UnityEngine.Vector2> val_4;
            if((true & 7) == 0)
            {
                    val_4 = 0;
                UnityEngine.Debug.LogError(message:  -1610602785);
                return;
            }
            
            Vectrosity.VectorLine.SetupByteBlock();
            val_4 = 536878507;
            val_4 = new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  67109813);
            if(val_4 < 1)
            {
                    return;
            }
            
            int val_4 = 0;
            do
            {
                float val_2 = Vectrosity.VectorLine.ConvertToFloat(bytes:  lineBytes, i:  0);
                val_4 = val_4 + 4;
                float val_3 = Vectrosity.VectorLine.ConvertToFloat(bytes:  lineBytes, i:  val_4);
                val_4.Add(item:  new UnityEngine.Vector2() {x = lineBytes, y = lineBytes});
                val_4 = val_4 + 4;
            }
            while(val_4 < val_4);
        
        }
        private static void SetupByteBlock()
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_2 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_2 = 536896697;
            }
            
            if((mem[536896789] + 68) == 0)
            {
                    val_3 = 536896697;
                if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_3 = 536896697;
            }
            
                mem2[0] = 536881741;
            }
            
            val_4 = 536884165;
            if(((mem[536884352] & true) == 0) && (mem[536884281] == 0))
            {
                    val_4 = 536884165;
            }
            
            val_5 = 536896697;
            var val_1 = mem[536896883] & 512;
            if(mem[536884257] != 0)
            {
                    val_6 = 0;
                if((val_1 != 0) && (mem[536896813] == 0))
            {
                    val_5 = 536896697;
            }
            
                val_7 = 0;
            }
            else
            {
                    val_7 = 1;
                val_6 = 3;
                if((val_1 != 0) && (mem[536896813] == 0))
            {
                    val_5 = 536896697;
            }
            
            }
            
            mem2[0] = val_6;
            mem2[0] = val_7;
        }
        private static float ConvertToFloat(byte[] bytes, int i)
        {
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    536896697 = 536896697;
            }
            
            var val_1 = (mem[536896789] + 68) + (mem[536896789] + 60);
            mem2[0] = bytes[i];
            var val_11 = mem[536896789] + 64;
            val_11 = val_11 + 1;
            var val_3 = (mem[536896789] + 68) + val_11;
            mem2[0] = bytes[i + 1];
            var val_13 = mem[536896789] + 64;
            val_13 = 2 - val_13;
            var val_5 = (mem[536896789] + 68) + val_13;
            mem2[0] = bytes[i + 2];
            var val_8 = (mem[536896789] + 68) + (3 - (mem[536896789] + 60));
            mem2[0] = bytes[i + 3];
            if((mem[536884352] & true) != 0)
            {
                    return System.BitConverter.ToSingle(value:  mem[536896789] + 68, startIndex:  0);
            }
            
            if(mem[536884281] != 0)
            {
                    return System.BitConverter.ToSingle(value:  mem[536896789] + 68, startIndex:  0);
            }
            
            return System.BitConverter.ToSingle(value:  mem[536896789] + 68, startIndex:  0);
        }
        public static void Destroy(ref Vectrosity.VectorLine line)
        {
            Vectrosity.VectorLine.DestroyLine(line: ref  Vectrosity.VectorLine val_1 = 405441152);
        }
        public static void Destroy(Vectrosity.VectorLine[] lines)
        {
            var val_2;
            val_2 = 0;
            goto label_1;
            label_6:
            Vectrosity.VectorLine.DestroyLine(line: ref  lines[16]);
            val_2 = 1;
            label_1:
            if(val_2 < 0)
            {
                goto label_6;
            }
        
        }
        public static void Destroy(System.Collections.Generic.List<Vectrosity.VectorLine> lines)
        {
            var val_3 = 0;
            goto label_1;
            label_6:
            if(true <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_1 = R1 + 0;
            Vectrosity.VectorLine.DestroyLine(line: ref  Vectrosity.VectorLine val_2 = 405702964);
            val_3 = 1;
            label_1:
            if(val_3 < )
            {
                goto label_6;
            }
        
        }
        private static void DestroyLine(ref Vectrosity.VectorLine line)
        {
            var val_2;
            if(line == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  line.m_go);
            if(line.m_vectorObject == 0)
            {
                goto label_5;
            }
            
            if((mem[line.m_vectorObject] + 178) == 0)
            {
                goto label_8;
            }
            
            var val_2 = 0;
            label_10:
            if((mem[line.m_vectorObject] + 88 + 0) == 536888839)
            {
                goto label_9;
            }
            
            val_2 = val_2 + 1;
            if(((uint)val_2 & 65535) < (mem[line.m_vectorObject] + 178))
            {
                goto label_10;
            }
            
            label_8:
            val_2 = line.m_vectorObject;
            goto label_11;
            label_9:
            var val_1 = (mem[line.m_vectorObject] + 88) + 0;
            var val_3 = (mem[line.m_vectorObject] + 88 + 0) + 4;
            val_3 = mem[line.m_vectorObject] + (val_3 << 3);
            val_2 = val_3 + 292;
            label_11:
            label_5:
            if(line.m_isAutoDrawing != false)
            {
                    line.StopDrawing3DAuto();
            }
            
            line = 0;
        }
        public static void Destroy(ref Vectrosity.VectorLine line, UnityEngine.GameObject go)
        {
            Vectrosity.VectorLine.Destroy(line: ref  Vectrosity.VectorLine val_1 = 405991232);
            if(go == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  go);
        }
        public void SetDistances()
        {
            Vectrosity.LineType val_15;
            bool val_16;
            var val_17;
            bool val_18;
            var val_19;
            bool val_20;
            var val_21;
            bool val_22;
            var val_23;
            val_15 = this.m_lineType;
            if(val_15 == 2)
            {
                    return;
            }
            
            if(mem[1152921509307897792] == 0)
            {
                goto label_2;
            }
            
            int val_1 = this.pointsCount;
            if(val_15 == 1)
            {
                    val_1 = val_1 + (val_1 >> 31);
                val_1 = 1 + (val_1 >> 1);
            }
            
            if((mem[1152921509307897792] + 12) == val_1)
            {
                goto label_3;
            }
            
            val_15 = val_15;
            label_2:
            int val_2 = this.pointsCount;
            if(val_15 == 1)
            {
                    val_2 = val_2 + (val_2 >> 31);
                val_2 = 1;
                val_2 = val_2 + (val_2 >> 1);
            }
            
            mem[1152921509307897792] = 536882357;
            label_3:
            int val_4 = this.pointsCount - 1;
            if(mem[1152921509307897760] == false)
            {
                goto label_4;
            }
            
            if(val_15 != 1)
            {
                goto label_5;
            }
            
            if(val_4 < 1)
            {
                    return;
            }
            
            var val_29 = 20;
            var val_28 = 16;
            do
            {
                if((mem[1152921509307897764] + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_5 = 0 + 1;
                if((mem[1152921509307897764] + 12) <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_25 = mem[1152921509307897764] + 8;
                var val_26 = mem[1152921509307897764] + 8 + 16 + 4;
                val_25 = val_25 + val_28;
                val_16 = mem[536890482];
                if((val_16 & true) == 0)
            {
                    val_16 = mem[536890411];
            }
            
                val_26 = (val_26 - ((mem[1152921509307897764] + 8 + 16) + 12)) * (val_26 - ((mem[1152921509307897764] + 8 + 16) + 12));
                var val_27 = 1;
                if(val_16 >= _TYPE_MAX_)
            {
                    val_17 = val_16;
            }
            
                double val_8 = D8 + val_17;
                var val_9 = mem[1152921509307897792] + val_29;
                val_27 = val_27 + 1;
                val_28 = val_28 + 16;
                mem2[0] = (mem[1152921509307897764] + 8 + 16) - ((mem[1152921509307897764] + 8 + 16) + 8);
                val_29 = val_29 + 4;
            }
            while((val_5 + 1) < val_4);
            
            return;
            label_4:
            if(val_15 != 1)
            {
                goto label_18;
            }
            
            if(val_4 < 1)
            {
                    return;
            }
            
            var val_35 = 1;
            var val_37 = 20;
            var val_36 = 0;
            do
            {
                if((mem[1152921509307897768] + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_30 = mem[1152921509307897768] + 8;
                val_30 = val_30 + val_36;
                float val_32 = (mem[1152921509307897768] + 8 + 0) + 16;
                var val_33 = (mem[1152921509307897768] + 8 + 0) + 20;
                var val_34 = (mem[1152921509307897768] + 8 + 0) + 24;
                var val_11 = 0 + 1;
                if((mem[1152921509307897768] + 12) <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_31 = mem[1152921509307897768] + 8;
                val_31 = val_31 + val_36;
                val_32 = val_32 - ((mem[1152921509307897768] + 8 + 0) + 28);
                val_33 = val_33 - ((mem[1152921509307897768] + 8 + 0) + 32);
                val_34 = val_34 - ((mem[1152921509307897768] + 8 + 0) + 36);
                val_18 = mem[536890482];
                if((val_18 & true) == 0)
            {
                    val_18 = mem[536890411];
            }
            
                float val_12 = val_33 * val_33;
                if(val_18 >= _TYPE_MAX_)
            {
                    val_19 = val_18;
            }
            
                double val_13 = D8 + val_19;
                var val_14 = mem[1152921509307897792] + val_37;
                val_35 = val_35 + 1;
                val_36 = val_36 + 24;
                mem2[0] = val_32;
                val_37 = val_37 + 4;
            }
            while((val_11 + 1) < val_4);
            
            return;
            label_5:
            if(val_4 < 1)
            {
                    return;
            }
            
            var val_42 = 1;
            var val_41 = 16;
            var val_40 = 20;
            do
            {
                if((mem[1152921509307897764] + 12) <= (val_42 - 1))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((mem[1152921509307897764] + 12) <= val_42)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_38 = mem[1152921509307897764] + 8;
                var val_39 = mem[1152921509307897764] + 8 + 16 + 4;
                val_38 = val_38 + val_41;
                val_20 = mem[536890482];
                if((val_20 & true) == 0)
            {
                    val_20 = mem[536890411];
            }
            
                val_39 = (val_39 - ((mem[1152921509307897764] + 8 + 16) + 12)) * (val_39 - ((mem[1152921509307897764] + 8 + 16) + 12));
                if(val_20 >= _TYPE_MAX_)
            {
                    val_21 = val_20;
            }
            
                double val_19 = D8 + val_21;
                var val_20 = mem[1152921509307897792] + val_40;
                val_40 = val_40 + 4;
                val_41 = val_41 + 8;
                val_42 = val_42 + 1;
                mem2[0] = (mem[1152921509307897764] + 8 + 16) - ((mem[1152921509307897764] + 8 + 16) + 8);
            }
            while(1 != val_42);
            
            return;
            label_18:
            if(val_4 < 1)
            {
                    return;
            }
            
            var val_50 = 1;
            var val_49 = 0;
            var val_48 = 20;
            do
            {
                if((mem[1152921509307897768] + 12) <= (val_50 - 1))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_43 = mem[1152921509307897768] + 8;
                val_43 = val_43 + val_49;
                float val_45 = (mem[1152921509307897768] + 8 + 0) + 16;
                var val_46 = (mem[1152921509307897768] + 8 + 0) + 20;
                var val_47 = (mem[1152921509307897768] + 8 + 0) + 24;
                if((mem[1152921509307897768] + 12) <= val_50)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_44 = mem[1152921509307897768] + 8;
                val_44 = val_44 + val_49;
                val_45 = val_45 - ((mem[1152921509307897768] + 8 + 0) + 28);
                val_46 = val_46 - ((mem[1152921509307897768] + 8 + 0) + 32);
                val_47 = val_47 - ((mem[1152921509307897768] + 8 + 0) + 36);
                val_22 = mem[536890482];
                if((val_22 & true) == 0)
            {
                    val_22 = mem[536890411];
            }
            
                float val_22 = val_46 * val_46;
                if(val_22 >= _TYPE_MAX_)
            {
                    val_23 = val_22;
            }
            
                double val_23 = D8 + val_23;
                var val_24 = mem[1152921509307897792] + val_48;
                val_48 = val_48 + 4;
                val_49 = val_49 + 12;
                val_50 = val_50 + 1;
                mem2[0] = val_45;
            }
            while(1 != val_50);
        
        }
        public float GetLength()
        {
            if(this.m_distances == null)
            {
                goto label_0;
            }
            
            int val_1 = this.pointsCount;
            if(this.m_lineType == 1)
            {
                    val_1 = val_1 + (val_1 >> 31);
                val_1 = 1 + (val_1 >> 1);
            }
            
            if(R5 == val_1)
            {
                goto label_1;
            }
            
            label_0:
            this.SetDistances();
            label_1:
            float val_2 = this.m_distances[1152921509308091631];
            return (float)S0;
        }
        public UnityEngine.Vector2 GetPoint01(float distance)
        {
            UnityEngine.Vector2 val_4 = GetPoint(distance:  UnityEngine.Mathf.Lerp(a:  R1.GetLength(), b:  null, t:  null), index: out  R1);
            return new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        }
        public UnityEngine.Vector2 GetPoint01(float distance, out int index)
        {
            UnityEngine.Vector2 val_4 = GetPoint(distance:  UnityEngine.Mathf.Lerp(a:  index.GetLength(), b:  null, t:  null), index: out  int val_3 = 406615200);
            return new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        }
        public UnityEngine.Vector2 GetPoint(float distance)
        {
            UnityEngine.Vector2 val_2 = GetPoint(distance:  distance, index: out  int val_1 = 0);
            return new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        }
        public UnityEngine.Vector2 GetPoint(float distance, out int index)
        {
            int val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            float val_32;
            var val_33;
            Vectrosity.VectorLine val_34;
            val_22 = R3;
            val_23 = R2;
            val_24 = 1152921509308661504;
            if(mem[1152921509308661552] == false)
            {
                goto label_1;
            }
            
            int val_1 = val_22;
            index.SetDistanceIndex(i: out  val_1, distance:  distance);
            var val_19 = val_22;
            val_19 = val_19 - 1;
            if(mem[1152921509308661608] != 1)
            {
                goto label_3;
            }
            
            if((mem[1152921509308661556] + 12) <= (val_19 << 1))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_20 = mem[1152921509308661556] + 8;
            val_20 = val_20 + ((val_19 << 1) << 3);
            var val_3 = 0 + (val_22 << 1);
            if((mem[1152921509308661556] + 12) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_21 = mem[1152921509308661556] + 8;
            val_21 = val_21 + (val_3 << 3);
            var val_22 = val_22;
            val_25 = mem[(mem[1152921509308661556] + 8 + ((0 + (R3) << 1)) << 3) + 20];
            val_25 = (mem[1152921509308661556] + 8 + ((0 + (R3) << 1)) << 3) + 20;
            val_22 = val_22 - 1;
            var val_4 = mem[1152921509308661584] + (val_22 << 2);
            val_26 = mem[(mem[1152921509308661584] + ((R3 - 1)) << 2) + 16];
            val_26 = (mem[1152921509308661584] + ((R3 - 1)) << 2) + 16;
            val_27 = (mem[1152921509308661556] + 8 + (((R3 - 1) << 1)) << 3) + 16;
            val_28 = val_1;
            val_29 = val_23;
            val_30 = (mem[1152921509308661556] + 8 + ((0 + (R3) << 1)) << 3) + 16;
            val_31 = (mem[1152921509308661584] + (val_22 << 2)) + 16;
            goto label_11;
            label_1:
            UnityEngine.Debug.LogError(message:  -1610602777);
            mem2[0] = 0;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
            return new UnityEngine.Vector2() {x = val_32};
            label_3:
            if((mem[1152921509308661556] + 12) <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_23 = mem[1152921509308661556] + 8;
            val_23 = val_23 + (val_19 << 3);
            if((mem[1152921509308661556] + 12) <= val_22)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_24 = mem[1152921509308661556] + 8;
            val_24 = val_24 + (val_22 << 3);
            val_25 = mem[(mem[1152921509308661556] + 8 + (R3) << 3) + 20];
            val_25 = (mem[1152921509308661556] + 8 + (R3) << 3) + 20;
            var val_10 = mem[1152921509308661584] + ((val_22 - 1) << 2);
            val_26 = mem[(mem[1152921509308661584] + ((R3 - 1)) << 2) + 16];
            val_26 = (mem[1152921509308661584] + ((R3 - 1)) << 2) + 16;
            val_29 = val_23;
            val_30 = (mem[1152921509308661556] + 8 + (R3) << 3) + 16;
            val_27 = (mem[1152921509308661556] + 8 + ((R3 - 1)) << 3) + 16;
            val_31 = (mem[1152921509308661584] + (val_22 << 2)) + 16;
            val_28 = (mem[1152921509308661556] + 8 + ((R3 - 1)) << 3) + 20;
            label_11:
            float val_13 = UnityEngine.Mathf.Clamp01(value:  UnityEngine.Mathf.InverseLerp(a:  distance, b:  null, value:  null));
            var val_25 = val_25;
            val_25 = val_25 - val_28;
            val_32 = val_30 - val_27;
            val_23 = val_27;
            val_33 = val_28;
            if((UnityEngine.Object.op_Implicit(exists:  mem[1152921509308661700])) != false)
            {
                    UnityEngine.Matrix4x4 val_15 = localToWorldMatrix;
                float val_16 = val_15.m13 + 96;
                mem2[0] = 0;
                mem2[0] = 0;
                float val_17 = val_15.m13 + 32;
                float val_18 = val_15.m13 + 28;
                val_22 = mem[val_15.m13 + 24];
                val_22 = val_15.m13 + 24;
            }
            else
            {
                    val_34 = this;
            }
            
            var val_26 = val_22;
            val_26 = val_26 - 1;
            mem2[0] = val_26;
            return new UnityEngine.Vector2() {x = val_32};
        }
        public UnityEngine.Vector3 GetPoint3D01(float distance)
        {
            Vectrosity.VectorLine val_5;
            UnityEngine.Vector3[] val_6;
            UnityEngine.Vector3 val_4 = GetPoint3D(distance:  UnityEngine.Mathf.Lerp(a:  R1.GetLength(), b:  null, t:  null), index: out  R1);
            this.m_lineVertices = val_6;
            this = val_5;
            return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public UnityEngine.Vector3 GetPoint3D01(float distance, out int index)
        {
            Vectrosity.VectorLine val_5;
            UnityEngine.Vector3[] val_6;
            UnityEngine.Vector3 val_4 = GetPoint3D(distance:  UnityEngine.Mathf.Lerp(a:  index.GetLength(), b:  null, t:  null), index: out  int val_3 = 407079264);
            this.m_lineVertices = val_6;
            this = val_5;
            return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public UnityEngine.Vector3 GetPoint3D(float distance)
        {
            Vectrosity.VectorLine val_3;
            UnityEngine.Vector3[] val_4;
            UnityEngine.Vector3 val_2 = GetPoint3D(distance:  distance, index: out  int val_1 = 0);
            this.m_lineVertices = val_4;
            this = val_3;
            return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public UnityEngine.Vector3 GetPoint3D(float distance, out int index)
        {
            Vectrosity.VectorLine val_2;
            UnityEngine.Vector3[] val_3;
            int val_26;
            float val_27;
            var val_28;
            float val_29;
            float val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            val_26 = R3;
            val_27 = R2;
            val_28 = 1152921509309125568;
            if(mem[1152921509309125616] != false)
            {
                    UnityEngine.Debug.LogError(message:  -1610602775);
                mem2[0] = 0;
                UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
                this.m_lineVertices = val_3;
                this = val_2;
            }
            else
            {
                    index.SetDistanceIndex(i: out  val_26, distance:  distance);
                var val_5 = val_26 - 1;
                if(mem[1152921509309125672] == 1)
            {
                    var val_6 = val_5 << 1;
                if((mem[1152921509309125624] + 12) <= (val_5 << 1))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_21 = mem[1152921509309125624] + 8;
                val_21 = val_21 + ((val_6 + (val_6 << 1)) << 2);
                var val_22 = val_26;
                val_31 = mem[(mem[1152921509309125624] + 8 + ((((R3 - 1) << 1) + (((R3 - 1) << 1)) << 1)) << 2) + 16];
                val_31 = (mem[1152921509309125624] + 8 + ((((R3 - 1) << 1) + (((R3 - 1) << 1)) << 1)) << 2) + 16;
                val_32 = mem[(mem[1152921509309125624] + 8 + ((((R3 - 1) << 1) + (((R3 - 1) << 1)) << 1)) << 2) + 20];
                val_32 = (mem[1152921509309125624] + 8 + ((((R3 - 1) << 1) + (((R3 - 1) << 1)) << 1)) << 2) + 20;
                val_33 = mem[(mem[1152921509309125624] + 8 + ((((R3 - 1) << 1) + (((R3 - 1) << 1)) << 1)) << 2) + 24];
                val_33 = (mem[1152921509309125624] + 8 + ((((R3 - 1) << 1) + (((R3 - 1) << 1)) << 1)) << 2) + 24;
                val_27 = val_27;
                val_22 = 0 + (val_22 << 1);
                if((mem[1152921509309125624] + 12) <= val_22)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_34 = mem[R3];
                val_34 = val_26;
                val_35 = val_22 + (val_22 << 1);
                val_36 = mem[1152921509309125648];
                val_37 = mem[mem[1152921509309125624] + 8];
                val_37 = mem[1152921509309125624] + 8;
            }
            else
            {
                    if((mem[1152921509309125624] + 12) <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_23 = mem[1152921509309125624] + 8;
                val_23 = val_23 + ((val_5 + (val_5 << 1)) << 2);
                val_31 = mem[(mem[1152921509309125624] + 8 + (((R3 - 1) + ((R3 - 1)) << 1)) << 2) + 16];
                val_31 = (mem[1152921509309125624] + 8 + (((R3 - 1) + ((R3 - 1)) << 1)) << 2) + 16;
                val_32 = mem[(mem[1152921509309125624] + 8 + (((R3 - 1) + ((R3 - 1)) << 1)) << 2) + 20];
                val_32 = (mem[1152921509309125624] + 8 + (((R3 - 1) + ((R3 - 1)) << 1)) << 2) + 20;
                val_33 = mem[(mem[1152921509309125624] + 8 + (((R3 - 1) + ((R3 - 1)) << 1)) << 2) + 24];
                val_33 = (mem[1152921509309125624] + 8 + (((R3 - 1) + ((R3 - 1)) << 1)) << 2) + 24;
                if((mem[1152921509309125624] + 12) <= val_26)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_34 = mem[R3];
                val_34 = val_26;
                val_35 = val_26 + (val_26 << 1);
                val_36 = mem[1152921509309125648];
                val_37 = mem[mem[1152921509309125624] + 8];
                val_37 = mem[1152921509309125624] + 8;
            }
            
                val_37 = val_37 + (val_35 << 2);
                var val_10 = val_36 + ((val_34 - 1) << 2);
                val_38 = mem[1152921509309125648];
                var val_11 = val_38 + (val_26 << 2);
                float val_13 = UnityEngine.Mathf.Clamp01(value:  UnityEngine.Mathf.InverseLerp(a:  distance, b:  null, value:  null));
                float val_14 = ((mem[1152921509309125624] + 8 + ((R3 + (R3) << 1)) << 2) + 20) - val_32;
                float val_15 = ((mem[1152921509309125624] + 8 + ((R3 + (R3) << 1)) << 2) + 16) - val_31;
                val_30 = ((mem[1152921509309125624] + 8 + ((R3 + (R3) << 1)) << 2) + 24) - val_33;
                val_29 = (mem[1152921509309125648] + ((R3 - 1)) << 2) + 16;
                val_26 = val_31;
                val_39 = val_32;
                val_40 = val_33;
                if((UnityEngine.Object.op_Implicit(exists:  mem[1152921509309125764])) != false)
            {
                    UnityEngine.Matrix4x4 val_17 = localToWorldMatrix;
                float val_18 = val_17.m13 + 88;
                mem2[0] = 0;
                float val_19 = val_17.m13 + 24;
                mem2[0] = val_17.m02;
                val_26 = mem[val_17.m13 + 24];
                val_26 = val_17.m13 + 24;
                val_39 = mem[val_17.m13 + 28];
                val_39 = val_17.m13 + 28;
                val_40 = mem[val_17.m13 + 32];
                val_40 = val_17.m13 + 32;
            }
            
                var val_24 = val_17.m13 + 16;
                val_24 = val_24 - 1;
                mem2[0] = val_24;
                mem2[0] = val_26;
            }
            
            float val_20 = val_17.m32 - 88;
            val_20 = val_20 + 4;
            return new UnityEngine.Vector3() {x = val_29, z = val_30};
        }
        private void SetDistanceIndex(out int i, float distance)
        {
            int val_3;
            if(this.m_distances == null)
            {
                    this.m_distances = this;
                this.SetDistances();
            }
            
            int val_1 = this.m_drawStart + 1;
            i = val_1;
            if(this.m_lineType == 1)
            {
                    this.m_drawStart = this.m_drawStart + 2;
                this.m_drawStart = this.m_drawStart + (this.m_drawStart >> 31);
                val_1 = this.m_drawStart >> 1;
                i = val_1;
            }
            
            if(val_1 >= this.m_drawStart)
            {
                    this.m_drawStart = this.m_drawStart - 1;
                i = this.m_drawStart;
            }
            
            val_3 = i;
            if(this.m_lineType == 1)
            {
                    this.m_lineType = this.m_drawEnd + 1;
                this.m_lineType = this.m_lineType + (this.m_lineType >> 31);
                this.m_drawEnd = this.m_lineType >> 1;
            }
            
            goto label_3;
            label_7:
            if(i >= this.m_drawEnd)
            {
                    return;
            }
            
            val_3 = i + 1;
            i = val_3;
            label_3:
            float val_2 = this.m_distances[val_3];
            if(i < 0)
            {
                goto label_7;
            }
        
        }
        public static void SetEndCap(string name, Vectrosity.EndCap capType)
        {
            Vectrosity.VectorLine.SetEndCap(name:  name, capType:  capType, offsetFront:  null, offsetBack:  null, scaleFront:  null, scaleBack:  null, textures:  null);
        }
        public static void SetEndCap(string name, Vectrosity.EndCap capType, UnityEngine.Texture2D[] textures)
        {
            Vectrosity.VectorLine.SetEndCap(name:  name, capType:  capType, offsetFront:  null, offsetBack:  null, scaleFront:  null, scaleBack:  null, textures:  null);
        }
        public static void SetEndCap(string name, Vectrosity.EndCap capType, float offset, UnityEngine.Texture2D[] textures)
        {
            Vectrosity.VectorLine.SetEndCap(name:  name, capType:  capType, offsetFront:  offset, offsetBack:  null, scaleFront:  null, scaleBack:  null, textures:  textures);
        }
        public static void SetEndCap(string name, Vectrosity.EndCap capType, float offsetFront, float offsetBack, UnityEngine.Texture2D[] textures)
        {
            Vectrosity.VectorLine.SetEndCap(name:  name, capType:  capType, offsetFront:  offsetFront, offsetBack:  offsetBack, scaleFront:  null, scaleBack:  null, textures:  textures);
        }
        public static void SetEndCap(string name, Vectrosity.EndCap capType, float offsetFront, float offsetBack, float scaleFront, float scaleBack, UnityEngine.Texture2D[] textures)
        {
            float val_47;
            float val_48;
            var val_49;
            int val_50;
            UnityEngine.Color32[] val_51;
            var val_52;
            if((mem[536896789] + 56) == 0)
            {
                    536874337 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
                mem2[0] = 536874337;
            }
            
            if(name != null)
            {
                    if((System.String.op_Equality(a:  name, b:  -1610612735)) == false)
            {
                goto label_7;
            }
            
            }
            
            if(((mem[536885944] & true) != 0) || (mem[536885873] != 0))
            {
                goto label_10;
            }
            
            goto label_10;
            label_7:
            if((mem[536896789] + 56.ContainsKey(key:  name)) == true)
            {
                goto label_18;
            }
            
            if(capType == 4)
            {
                    Vectrosity.VectorLine.RemoveEndCap(name:  name);
                return;
            }
            
            Vectrosity.EndCap val_7 = capType & (~1);
            if(capType != 0)
            {
                goto label_19;
            }
            
            if((val_1 + 12) > 1)
            {
                goto label_23;
            }
            
            goto label_67;
            label_19:
            label_23:
            if((val_1 + 16) != 0)
            {
                    if((val_1 + 20) != 0)
            {
                goto label_31;
            }
            
            }
            
            label_48:
            label_67:
            label_18:
            string val_10 = -1610602713(-1610602713) + name + -1610612205(-1610612205);
            label_10:
            UnityEngine.Debug.LogError(message:  -1610602713);
            return;
            label_31:
            if(((val_1 + 16) != (val_1 + 16)) || ((val_1 + 20) != (val_1 + 16)))
            {
                goto label_67;
            }
            
            if(capType != 1)
            {
                goto label_44;
            }
            
            if((val_1 + 12) <= 2)
            {
                goto label_67;
            }
            
            if((val_1 + 24) == 0)
            {
                goto label_48;
            }
            
            if((val_1 + 24) != (val_1 + 16))
            {
                goto label_67;
            }
            
            label_44:
            if((val_1 + 12) == 3)
            {
                    0 = mem[val_1 + 24];
                0 = val_1 + 24;
            }
            
            if(capType == 0)
            {
                goto label_57;
            }
            
            if(capType != 3)
            {
                goto label_58;
            }
            
            UnityEngine.Color32[] val_12 = Vectrosity.VectorLine.GetRotatedPixels(tex:  val_1 + 20);
            UnityEngine.Color32[] val_14 = Vectrosity.VectorLine.GetRowPixels(texPixels:  val_1 + 20, numberOfRows:  4, row:  (val_1 + 20) - 1, w:  val_1 + 16);
            val_47 = 0f;
            val_48 = ((float)val_1 + 20) / ((float)val_1 + 20);
            goto label_117;
            label_57:
            UnityEngine.Color32[] val_15 = Vectrosity.VectorLine.GetRotatedPixels(tex:  val_1 + 20);
            UnityEngine.Color32[] val_16 = Vectrosity.VectorLine.GetRowPixels(texPixels:  val_1 + 20, numberOfRows:  4, row:  0, w:  val_1 + 16);
            val_48 = 0f;
            val_47 = ((float)val_1 + 20) / ((float)val_1 + 20);
            label_117:
            float val_43 = val_1 + 16;
            label_118:
            label_110:
            var val_45 = 0;
            UnityEngine.Color32[] val_17 = val_1 + 16.GetPixels32();
            val_43 = val_43 << 2;
            UnityEngine.Color val_18 = UnityEngine.Color.clear;
            var val_44 = 4;
            val_44 = val_44 + (val_1 + 20);
            UnityEngine.Color32 val_19 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
            val_49 = 536881829;
            if(val_43 >= 1)
            {
                    do
            {
                if(val_49 == 0)
            {
                    val_49 = 536881829;
            }
            
                mem[536881845] = val_19.r;
                mem[536881846] = val_19.g;
                mem[536881847] = val_19.b;
                mem[536881848] = val_19.a;
                val_45 = val_45 + 1;
            }
            while(val_43 != val_45);
            
            }
            
            int val_21 = (val_44 + (val_1 + 16)) + 16;
            UnityEngine.Color32[] val_22 = Vectrosity.VectorLine.GetRowPixels(texPixels:  val_1 + 20, numberOfRows:  4, row:  3, w:  val_1 + 16);
            UnityEngine.Color32[] val_23 = Vectrosity.VectorLine.GetRowPixels(texPixels:  val_1 + 20, numberOfRows:  4, row:  0, w:  val_1 + 16);
            int val_24 = val_1 + 16.mipmapCount;
            if(val_24 > 1)
            {
                    0 = 1;
            }
            
            536895327 = new UnityEngine.Texture2D(width:  val_1 + 16, height:  val_21, textureFormat:  5, mipChain:  true);
            string val_26 = val_1 + 16.name;
            string val_27 = val_1 + 16(val_1 + 16) + -1610612373(-1610612373);
            536895327.name = val_1 + 16;
            UnityEngine.TextureWrapMode val_28 = val_1 + 16.wrapMode;
            536895327.wrapMode = val_1 + 16;
            UnityEngine.FilterMode val_29 = val_1 + 16.filterMode;
            536895327.filterMode = val_1 + 16;
            float val_46 = 1f;
            float val_47 = (float)val_21;
            val_46 = val_46 / val_47;
            536895327.SetPixels32(x:  0, y:  0, blockWidth:  val_1 + 16, blockHeight:  4, colors:  536881829);
            val_47 = val_46 * 4f;
            mem[536882373] = val_47;
            int val_48 = val_1 + 16;
            536895327.SetPixels32(x:  0, y:  4, blockWidth:  val_1 + 16, blockHeight:  val_1 + 16, colors:  val_1 + 16);
            val_48 = val_48 + 4;
            mem[536882377] = val_46 * (float)val_48;
            536895327.SetPixels32(x:  0, y:  val_48, blockWidth:  val_1 + 16, blockHeight:  4, colors:  536881829);
            int val_31 = val_48 + 8;
            mem[536882381] = val_46 * (float)val_31;
            1.087358E-19f.SetPixels32(x:  0, y:  val_31, blockWidth:  val_1 + 16, blockHeight:  4, colors:  val_1 + 20);
            val_31 = val_31 + 4;
            mem[536882385] = val_46 * (float)val_31;
            if((1.087358E-19f) != 0)
            {
                    val_50 = val_1 + 16;
                1.087358E-19f.SetPixels32(x:  0, y:  val_31, blockWidth:  val_50, blockHeight:  4, colors:  val_1 + 20);
            }
            else
            {
                    val_50 = val_1 + 16;
                1.087358E-19f.SetPixels32(x:  0, y:  val_31, blockWidth:  val_50, blockHeight:  4, colors:  val_1 + 20);
            }
            
            1.087358E-19f.SetPixels32(x:  0, y:  val_31 + 4, blockWidth:  val_50, blockHeight:  4, colors:  val_1 + 20);
            val_31 = val_31 + 8;
            val_51 = val_1 + 20;
            mem[536882389] = val_46 * (float)val_31;
            if((1.087358E-19f) == 0)
            {
                    val_51 = val_51;
            }
            
            1.087358E-19f.SetPixels32(x:  0, y:  val_31, blockWidth:  val_1 + 16, blockHeight:  val_1 + 20, colors:  val_51);
            mem[536882393] = val_46 * ((float)val_31 + (val_1 + 20));
            if(val_24 > 1)
            {
                    0 = 1;
            }
            
            536895327.Apply(updateMipmaps:  true, makeNoLongerReadable:  true);
            536884645 = new Vectrosity.CapInfo(capType:  capType, texture:  536895327, ratio1:  (float)val_31 + (val_1 + 20), ratio2:  val_18.g, offset1:  val_18.b, offset2:  val_18.a, scale1:  null, scale2:  null, uvHeights:  val_47);
            mem[536896789] + 56.Add(key:  name, value:  536884645);
            return;
            label_58:
            if(capType != 1)
            {
                goto label_103;
            }
            
            UnityEngine.Color32[] val_39 = Vectrosity.VectorLine.GetRotatedPixels(tex:  val_1 + 20);
            UnityEngine.Color32[] val_40 = Vectrosity.VectorLine.GetRotatedPixels(tex:  536895327);
            val_52 = 536895327;
            if(val_52 == 0)
            {
                    val_52 = 536895327;
            }
            
            float val_49 = (float)val_1 + 20;
            val_49 = ((float)val_1 + 20) / val_49;
            goto label_110;
            label_103:
            if(capType != 2)
            {
                goto label_118;
            }
            
            UnityEngine.Color32[] val_41 = Vectrosity.VectorLine.GetRotatedPixels(tex:  val_1 + 20);
            UnityEngine.Color32[] val_42 = Vectrosity.VectorLine.GetRowPixels(texPixels:  val_1 + 20, numberOfRows:  4, row:  0, w:  val_1 + 16);
            if(536881829 != 0)
            {
                goto label_117;
            }
            
            goto label_117;
        }
        private static UnityEngine.Color32[] GetRowPixels(UnityEngine.Color32[] texPixels, int numberOfRows, int row, int w)
        {
            var val_2;
            int val_3;
            val_2 = row;
            val_3 = 22979106;
            int val_2 = numberOfRows;
            numberOfRows = w * val_2;
            if(val_2 < 1)
            {
                    return;
            }
            
            val_3 = w * val_2;
            val_2 = 0;
            var val_1 = 0;
            do
            {
                System.Array.Copy(sourceArray:  texPixels, sourceIndex:  val_3, destinationArray:  536881829, destinationIndex:  0, length:  w);
                val_1 = val_1 + w;
                val_2 = val_2 - 1;
            }
            while(val_2 != 1);
        
        }
        private static UnityEngine.Color32[] GetRotatedPixels(UnityEngine.Texture2D tex)
        {
            UnityEngine.Texture2D val_6 = tex;
            UnityEngine.Color32[] val_1 = val_6.GetPixels32();
            int val_2 = val_6.width;
            int val_3 = val_6.height;
            if(val_3 < 1)
            {
                    return;
            }
            
            var val_4 = 536881829 + 16;
            do
            {
                int val_5 = val_6.width;
                if(val_2 >= 1)
            {
                    val_5 = val_5 - 1;
                int val_8 = 4;
                int val_9 = val_2;
                do
            {
                var val_6 = val_8 - 4;
                val_8 = val_8 + 1;
                val_9 = val_9 - 1;
                mem2[0] = val_6;
                int val_7 = SB - val_3;
            }
            while(mem[536881841] != SB);
            
            }
            
                int val_10 = 4;
                val_6 = val_6;
                val_10 = val_10 + val_2;
            }
            while(1 != val_3);
        
        }
        public static void RemoveEndCap(string name)
        {
            var val_5;
            var val_6;
            val_5 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_5 = 536896697;
            }
            
            if((mem[536896789] + 56.ContainsKey(key:  name)) != false)
            {
                    val_6 = 536896697;
                if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_6 = 536896697;
            }
            
                UnityEngine.Purchasing.IStoreExtension val_2 = mem[536896789] + 56.Item[name];
                UnityEngine.Object.Destroy(obj:  mem[536896789] + 56 + 12);
                bool val_3 = mem[536896789] + 56.Remove(key:  name);
                return;
            }
            
            string val_4 = -1610602677(-1610602677) + name + -1610612227(-1610612227);
            UnityEngine.Debug.LogError(message:  -1610602677);
        }
        public bool Selected(UnityEngine.Vector2 p)
        {
            if(((mem[536896884] & true) != 0) || (mem[536896813] != 0))
            {
                    return (bool)this.Selected(p:  new UnityEngine.Vector2() {x = p.x, y = p.y}, extraDistance:  0, extraLength:  0, index: out  0, cam:  mem[536896789] + 20);
            }
            
            536896697 = 536896697;
            return (bool)this.Selected(p:  new UnityEngine.Vector2() {x = p.x, y = p.y}, extraDistance:  0, extraLength:  0, index: out  0, cam:  mem[536896789] + 20);
        }
        public bool Selected(UnityEngine.Vector2 p, out int index)
        {
            if(((mem[536896884] & true) != 0) || (mem[536896813] != 0))
            {
                    return (bool)this.Selected(p:  new UnityEngine.Vector2() {x = p.x, y = p.y}, extraDistance:  0, extraLength:  0, index: out  1152921509311151888, cam:  mem[536896789] + 20);
            }
            
            536896697 = 536896697;
            return (bool)this.Selected(p:  new UnityEngine.Vector2() {x = p.x, y = p.y}, extraDistance:  0, extraLength:  0, index: out  1152921509311151888, cam:  mem[536896789] + 20);
        }
        public bool Selected(UnityEngine.Vector2 p, int extraDistance, out int index)
        {
            if(((mem[536896884] & true) != 0) || (mem[536896813] != 0))
            {
                    return (bool)this.Selected(p:  new UnityEngine.Vector2() {x = p.x, y = p.y}, extraDistance:  extraDistance, extraLength:  0, index: out  index, cam:  mem[536896789] + 20);
            }
            
            536896697 = 536896697;
            return (bool)this.Selected(p:  new UnityEngine.Vector2() {x = p.x, y = p.y}, extraDistance:  extraDistance, extraLength:  0, index: out  index, cam:  mem[536896789] + 20);
        }
        public bool Selected(UnityEngine.Vector2 p, int extraDistance, int extraLength, out int index)
        {
            if(((mem[536896884] & true) != 0) || (mem[536896813] != 0))
            {
                    return (bool)this.Selected(p:  new UnityEngine.Vector2() {x = p.x, y = p.y}, extraDistance:  extraDistance, extraLength:  extraLength, index: out  index, cam:  mem[536896789] + 20);
            }
            
            536896697 = 536896697;
            return (bool)this.Selected(p:  new UnityEngine.Vector2() {x = p.x, y = p.y}, extraDistance:  extraDistance, extraLength:  extraLength, index: out  index, cam:  mem[536896789] + 20);
        }
        public bool Selected(UnityEngine.Vector2 p, UnityEngine.Camera cam)
        {
            return (bool)this.Selected(p:  new UnityEngine.Vector2() {x = p.x, y = p.y}, extraDistance:  0, extraLength:  0, index: out  0, cam:  cam);
        }
        public bool Selected(UnityEngine.Vector2 p, out int index, UnityEngine.Camera cam)
        {
            return (bool)this.Selected(p:  new UnityEngine.Vector2() {x = p.x, y = p.y}, extraDistance:  0, extraLength:  0, index: out  int val_1 = index, cam:  cam);
        }
        public bool Selected(UnityEngine.Vector2 p, int extraDistance, out int index, UnityEngine.Camera cam)
        {
            return (bool)this.Selected(p:  new UnityEngine.Vector2() {x = p.x, y = p.y}, extraDistance:  extraDistance, extraLength:  0, index: out  index, cam:  cam);
        }
        public bool Selected(UnityEngine.Vector2 p, int extraDistance, int extraLength, out int index, UnityEngine.Camera cam)
        {
            Vectrosity.VectorLine val_84;
            float val_85;
            var val_86;
            UnityEngine.Camera val_87;
            var val_88;
            var val_89;
            var val_90;
            var val_91;
            var val_98;
            var val_99;
            var val_100;
            var val_101;
            var val_102;
            float val_103;
            var val_104;
            var val_105;
            var val_106;
            var val_107;
            var val_108;
            var val_109;
            var val_110;
            var val_111;
            var val_112;
            var val_113;
            var val_114;
            var val_115;
            val_84 = this;
            val_85 = p.x;
            val_87 = cam;
            val_88 = index;
            if(val_87 != 0)
            {
                goto label_3;
            }
            
            val_89 = 22716504;
            Vectrosity.VectorLine.SetCamera3D();
            if((UnityEngine.Object.op_Implicit(exists:  mem[536896789] + 20)) == false)
            {
                goto label_8;
            }
            
            val_90 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_90 = 536896697;
            }
            
            val_84 = val_84;
            val_87 = mem[mem[536896789] + 20];
            val_87 = mem[536896789] + 20;
            label_3:
            val_91 = mem[1152921509311861028];
            if(mem[1152921509311861028] == 0)
            {
                    val_91 = mem[1152921509311861028];
            }
            
            if(mem[1152921509311861064] == 1)
            {
                    mem[1152921509311861084] = (mem[1152921509311861084] + (mem[1152921509311861084] >> 31)) >> 1;
            }
            
            if((mem[1152921509311861028] + 12) != 1)
            {
                    mem[1152921509311861084] = mem[1152921509311861084] - 1;
            }
            
            var val_78 = mem[1152921509311861028] + 12;
            val_78 = val_78 - 1;
            if(val_91 == 0)
            {
                    mem[1152921509311861084] = val_78;
            }
            
            if(val_91 != 0)
            {
                    val_78 = 1;
            }
            
            if(mem[1152921509311861156] != 0)
            {
                    UnityEngine.Matrix4x4 val_5 = localToWorldMatrix;
            }
            else
            {
                    UnityEngine.Matrix4x4 val_6 = UnityEngine.Matrix4x4.identity;
            }
            
            val_89 = mem[val_6.m13 + 44];
            val_89 = val_6.m13 + 44;
            if((val_6.m13 + 44 + 104) != 2)
            {
                goto label_18;
            }
            
            var val_81 = val_6.m13 + 44 + 124;
            if((val_6.m13 + 32) == val_89)
            {
                    val_6.m13 + 32 = (val_6.m13 + 32) - 1;
            }
            
            val_98 = 0;
            if((val_6.m13 + 44 + 48) == 0)
            {
                goto label_19;
            }
            
            if(val_81 > (val_6.m13 + 32))
            {
                goto label_65;
            }
            
            mem2[0] = val_6.m13 + 32;
            var val_7 = 16 + (val_81 << 3);
            var val_79 = val_6.m13 + 16;
            float val_8 = val_6.m12 + (val_6.m13 + 40);
            val_86 = (val_6.m13 + 40) << 2;
            var val_9 = 16 + (val_8 << 2);
            do
            {
                val_89 = mem[val_6.m13 + 44];
                val_89 = val_6.m13 + 44;
                val_85 = mem[val_6.m13 + 44 + 52];
                val_85 = val_6.m13 + 44 + 52;
                if((val_6.m13 + 36) != 0)
            {
                    float val_11 = val_6.m32 - 168;
                mem2[0] = 0;
                mem2[0] = 0;
                float val_12 = val_6.m13 + 48;
                val_99 = mem[val_6.m13 + 48];
                val_99 = val_6.m13 + 48;
                val_100 = mem[val_6.m13 + 52];
                val_100 = val_6.m13 + 52;
            }
            else
            {
                    val_99 = mem[val_6.m13 + 44 + 52 + 8 + (16 + (val_6.m13 + 44 + 124) << 3)];
                val_99 = val_6.m13 + 44 + 52 + 8 + (16 + (val_6.m13 + 44 + 124) << 3);
                val_100 = mem[val_6.m13 + 44 + 52 + 8 + (16 + (val_6.m13 + 44 + 124) << 3) + 4];
                val_100 = val_6.m13 + 44 + 52 + 8 + (16 + (val_6.m13 + 44 + 124) << 3) + 4;
            }
            
                val_79 = ((val_6.m13 + 44 + 68) + val_9) + (float)val_79;
                var val_80 = val_99;
                val_99 = val_80 - val_79;
                if((val_6.m13 + 44 + 200) <= 0)
            {
                    val_80 = val_79 + val_80;
                if((val_6.m13 + 44 + 200) >= 0)
            {
                    float val_13 = val_100 - val_79;
                if((val_6.m13 + 44 + 200) <= 0)
            {
                    val_79 = val_79 + val_100;
                if((val_6.m13 + 44 + 200) >= 0)
            {
                goto label_112;
            }
            
            }
            
            }
            
            }
            
                val_9 = val_9 + val_86;
                val_7 = val_7 + 8;
                val_81 = val_81 + 1;
                val_8 = val_8 + (val_6.m13 + 40);
            }
            while(val_81 <= (val_6.m13 + 32));
            
            goto label_98;
            label_18:
            float val_14 = val_6.m13 + 48;
            if((val_6.m13 + 44 + 104) == 1)
            {
                    1 = 2;
            }
            
            mem2[0] = 2;
            if((val_6.m13 + 44 + 104) != 1)
            {
                goto label_34;
            }
            
            val_88 = mem[val_6.m32 + 12];
            val_88 = val_6.m32 + 12;
            val_86 = mem[val_6.m13 + 32];
            val_86 = val_6.m13 + 32;
            goto label_35;
            label_8:
            val_101 = 0;
            UnityEngine.Debug.LogError(message:  -1610602733);
            val_98 = 0;
            goto label_111;
            label_34:
            val_88 = mem[val_6.m32 + 12];
            val_88 = val_6.m32 + 12;
            if((val_6.m13 + 44 + 128) == val_89)
            {
                    val_86 = (val_6.m13 + 32) - 1;
            }
            
            label_35:
            mem2[0] = val_86;
            if((val_6.m13 + 44 + 48) == 0)
            {
                goto label_39;
            }
            
            val_102 = mem[val_6.m13 + 44 + 124];
            val_102 = val_6.m13 + 44 + 124;
            val_98 = 0;
            if(val_102 >= val_86)
            {
                goto label_83;
            }
            
            var val_15 = 16 + (val_102 << 3);
            float val_16 = val_6.m12 + (val_6.m13 + 40);
            mem2[0] = val_16;
            var val_82 = val_6.m13 + 20;
            val_82 = val_82 << 3;
            mem2[0] = val_82;
            mem2[0] = (val_6.m13 + 40) << 2;
            label_63:
            mem2[0] = 16 + (val_16 << 2);
            if((val_6.m13 + 36) != 0)
            {
                    float val_19 = val_6.m32 - 168;
                mem2[0] = 0;
                mem2[0] = 0;
                float val_20 = val_6.m13 + 48;
                val_103 = mem[val_6.m13 + 48];
                val_103 = val_6.m13 + 48;
                val_85 = mem[val_6.m13 + 52];
                val_85 = val_6.m13 + 52;
                var val_21 = val_102 + 1;
                var val_83 = val_6.m13 + 44 + 52 + 8;
                float val_22 = val_6.m32 - 168;
                val_83 = val_83 + val_15;
                mem2[0] = 0;
                mem2[0] = 0;
                float val_23 = val_6.m13 + 48;
                val_104 = mem[val_6.m13 + 48];
                val_104 = val_6.m13 + 48;
                val_105 = mem[val_6.m13 + 52];
                val_105 = val_6.m13 + 52;
            }
            else
            {
                    val_103 = mem[val_6.m13 + 44 + 52 + 8 + (16 + (val_6.m13 + 44 + 124) << 3)];
                val_103 = val_6.m13 + 44 + 52 + 8 + (16 + (val_6.m13 + 44 + 124) << 3);
                var val_84 = val_6.m13 + 44 + 52 + 8;
                val_84 = val_84 + val_15;
                val_85 = mem[(val_6.m13 + 44 + 52 + 8 + (16 + (val_6.m13 + 44 + 124) << 3)) + 4];
                val_85 = (val_6.m13 + 44 + 52 + 8 + (16 + (val_6.m13 + 44 + 124) << 3)) + 4;
                var val_24 = val_102 + 1;
                var val_85 = val_6.m13 + 44 + 52 + 8;
                val_85 = val_85 + val_15;
                val_104 = mem[(val_6.m13 + 44 + 52 + 8 + (16 + (val_6.m13 + 44 + 124) << 3)) + 8];
                val_104 = (val_6.m13 + 44 + 52 + 8 + (16 + (val_6.m13 + 44 + 124) << 3)) + 8;
                var val_86 = val_6.m13 + 44 + 52 + 8;
                val_86 = mem[val_6.m13 + 32];
                val_86 = val_6.m13 + 32;
                val_86 = val_86 + val_15;
                val_105 = mem[(val_6.m13 + 44 + 52 + 8 + (16 + (val_6.m13 + 44 + 124) << 3)) + 12];
                val_105 = (val_6.m13 + 44 + 52 + 8 + (16 + (val_6.m13 + 44 + 124) << 3)) + 12;
            }
            
            float val_25 = val_6.m13 + 176;
            if((val_6.m13 + 44 + 200) != 0)
            {
                    var val_88 = val_104;
                var val_87 = val_105;
                float val_89 = val_85;
                float val_90 = val_103;
                val_87 = 0f * val_87;
                val_88 = 0f * val_88;
                val_89 = 0f * val_89;
                val_90 = 0f * val_90;
                val_105 = val_87;
                val_104 = val_88;
                val_85 = val_89;
                val_103 = val_90;
            }
            
            if((val_6.m32 + 8) >= 1)
            {
                    float val_26 = val_6.m13 + 48;
                float val_93 = val_85;
                float val_94 = val_103;
                mem2[0] = val_93 - val_105;
                mem2[0] = val_94 - val_104;
                var val_91 = val_6.m13 + 48;
                var val_92 = val_6.m13 + 52;
                val_91 = val_91 * ((float)val_6.m32 + 8);
                val_92 = val_92 * ((float)val_6.m32 + 8);
                val_92 = val_92 + val_93;
                val_91 = val_91 + val_94;
                val_104 = val_104 - val_91;
                val_105 = val_105 - val_92;
                val_85 = val_92;
                val_103 = val_91;
            }
            
            val_93 = val_105 - val_85;
            val_94 = val_104 - val_103;
            float val_32 = (val_6.m13 + 8) - val_103;
            mem2[0] = val_93;
            mem2[0] = val_94;
            var val_95 = val_25;
            val_95 = (((val_6.m13 + 24) - val_85) * val_93) / val_95;
            if(((val_6.m32 + 8) < 0) || ((val_6.m32 + 8) > 1))
            {
                goto label_57;
            }
            
            mem2[0] = (val_6.m13 + 8) - val_103;
            mem2[0] = (val_6.m13 + 24) - val_85;
            val_85 = val_25;
            var val_96 = (val_6.m13 + 44 + 68) + (val_6.m13 + 24);
            val_96 = val_96 + ((float)val_6.m13 + 16);
            val_96 = (((val_6.m13 + 44 + 68) + (val_6.m13 + 24)) + ((float)val_6.m13 + 16)) * val_96;
            if((val_6.m13 + 44 + 68 + 12) <= (val_6.m13 + 28))
            {
                goto label_62;
            }
            
            label_57:
            var val_97 = val_6.m13 + 24;
            val_15 = val_15 + (val_6.m13 + 16);
            var val_98 = val_6.m13 + 28;
            val_97 = val_97 + (val_6.m13 + 12);
            val_89 = mem[val_6.m13 + 44];
            val_89 = val_6.m13 + 44;
            val_98 = val_98 + (val_6.m13 + 40);
            mem2[0] = val_98;
            val_102 = val_102 + (val_6.m13 + 20);
            if(val_102 < val_86)
            {
                goto label_63;
            }
            
            goto label_98;
            label_19:
            if(val_81 > (val_6.m13 + 32))
            {
                goto label_65;
            }
            
            mem2[0] = val_6.m13 + 32;
            var val_40 = 16 + ((val_81 + (val_81 << 1)) << 2);
            float val_41 = val_6.m12 + (val_6.m13 + 40);
            var val_42 = 16 + (val_41 << 2);
            mem2[0] = (val_6.m13 + 40) << 2;
            do
            {
                var val_99 = (val_6.m13 + 44 + 68) + val_42;
                val_99 = val_99 + ((float)val_6.m13 + 16);
                if((val_6.m13 + 36) != 0)
            {
                    float val_45 = val_6.m13 + 48;
                float val_46 = val_6.m32 - 168;
                float val_47 = val_6.m13 + 48;
                val_106 = 0;
                if((val_6.m13 + 28) == 0)
            {
                    mem2[0] = mem[(val_6.m13 + 48) + (0)];
                mem2[0] = mem[(val_6.m13 + 48) + (4)];
                val_106 = 0;
            }
            
                mem2[0] = val_106;
                mem2[0] = mem[(val_6.m13 + 48) + (8)];
                val_107 = mem[val_6.m13 + 48];
                val_107 = val_6.m13 + 48;
                val_85 = 0;
            }
            else
            {
                    if((val_6.m13 + 28) == 0)
            {
                    mem2[0] = val_6.m13 + 44 + 56 + 8 + (16 + ((val_6.m13 + 44 + 124 + (val_6.m13 + 44 + 124) << 1)) << 2);
            }
            
                float val_48 = val_6.m13 + 48;
                mem2[0] = mem[val_6.m13 + 44 + 56 + 8 + (16 + ((val_6.m13 + 44 + 124 + (val_6.m13 + 44 + 124) << 1)) << 2) + (8)];
                val_85 = 0;
                mem2[0] = val_85;
                val_107 = mem[val_6.m13 + 48];
                val_107 = val_6.m13 + 48;
            }
            
                var val_100 = val_6.m13 + 52;
                float val_49 = val_107 - val_99;
                val_89 = mem[val_6.m13 + 44];
                val_89 = val_6.m13 + 44;
                if((val_6.m13 + 28) <= 0)
            {
                    val_107 = val_99 + val_107;
                if((val_6.m13 + 28) >= 0)
            {
                    float val_50 = val_100 - val_99;
                if((val_6.m13 + 28) <= 0)
            {
                    val_100 = val_99 + val_100;
                if((val_6.m13 + 28) >= 0)
            {
                goto label_112;
            }
            
            }
            
            }
            
            }
            
                val_40 = val_40 + 12;
                val_81 = val_81 + 1;
                val_86 = val_42 + (val_6.m13 + 24);
                val_41 = val_41 + (val_6.m13 + 40);
            }
            while(val_81 <= (val_6.m13 + 32));
            
            goto label_98;
            label_39:
            val_102 = mem[val_6.m13 + 44 + 124];
            val_102 = val_6.m13 + 44 + 124;
            val_98 = 0;
            if(val_102 >= val_86)
            {
                goto label_83;
            }
            
            float val_53 = val_6.m12 + (val_6.m13 + 40);
            mem2[0] = (val_6.m13 + 40) << 2;
            var val_55 = 20 + ((val_102 + (val_102 << 1)) << 2);
            var val_101 = val_6.m13 + 20;
            val_85 = mem[val_6.m13 + 28];
            val_85 = val_6.m13 + 28;
            val_101 = val_101 + (val_101 << 1);
            val_101 = val_101 << 2;
            mem2[0] = val_101;
            label_97:
            mem2[0] = 16 + (val_53 << 2);
            mem2[0] = val_53;
            if((val_6.m13 + 36) != 0)
            {
                    float val_57 = val_6.m32 - 168;
                mem2[0] = val_6.m13 + 44 + 56 + 8 + (20 + ((val_6.m13 + 44 + 124 + (val_6.m13 + 44 + 124) << 1)) << 2) + 4;
                mem2[0] = 0;
                mem2[0] = 0;
                mem2[0] = val_6.m13 + 56;
                var val_58 = val_102 + 1;
                var val_102 = val_6.m13 + 44 + 56 + 8;
                float val_59 = val_6.m32 - 168;
                val_102 = val_102 + val_55;
                mem2[0] = (val_6.m13 + 44 + 56 + 8 + (20 + ((val_6.m13 + 44 + 124 + (val_6.m13 + 44 + 124) << 1)) << 2)) + 16;
                mem2[0] = 0;
                val_108 = mem[val_6.m13 + 48];
                val_108 = val_6.m13 + 48;
                val_109 = mem[val_6.m13 + 52];
                val_109 = val_6.m13 + 52;
                val_110 = mem[val_6.m13 + 56];
                val_110 = val_6.m13 + 56;
                val_85 = mem[val_6.m13 + 28];
                val_85 = val_6.m13 + 28;
            }
            else
            {
                    mem2[0] = 0;
                mem2[0] = val_6.m13 + 44 + 56 + 8 + (20 + ((val_6.m13 + 44 + 124 + (val_6.m13 + 44 + 124) << 1)) << 2) + 4;
                float val_107 = val_6.m13 + 48;
                var val_60 = val_102 + 1;
                var val_103 = val_6.m13 + 44 + 56 + 8;
                val_103 = val_103 + val_55;
                val_108 = mem[(val_6.m13 + 44 + 56 + 8 + (20 + ((val_6.m13 + 44 + 124 + (val_6.m13 + 44 + 124) << 1)) << 2)) + 8];
                val_108 = (val_6.m13 + 44 + 56 + 8 + (20 + ((val_6.m13 + 44 + 124 + (val_6.m13 + 44 + 124) << 1)) << 2)) + 8;
                val_109 = mem[(val_6.m13 + 44 + 56 + 8 + (20 + ((val_6.m13 + 44 + 124 + (val_6.m13 + 44 + 124) << 1)) << 2)) + 12];
                val_109 = (val_6.m13 + 44 + 56 + 8 + (20 + ((val_6.m13 + 44 + 124 + (val_6.m13 + 44 + 124) << 1)) << 2)) + 12;
                val_110 = mem[(val_6.m13 + 44 + 56 + 8 + (20 + ((val_6.m13 + 44 + 124 + (val_6.m13 + 44 + 124) << 1)) << 2)) + 16];
                val_110 = (val_6.m13 + 44 + 56 + 8 + (20 + ((val_6.m13 + 44 + 124 + (val_6.m13 + 44 + 124) << 1)) << 2)) + 16;
            }
            
            mem2[0] = 0;
            mem2[0] = val_110;
            val_89 = mem[val_6.m13 + 44];
            val_89 = val_6.m13 + 44;
            var val_105 = val_6.m13 + 16;
            var val_104 = val_6.m13 + 24;
            if(val_85 >= 0)
            {
                goto label_96;
            }
            
            label_109:
            val_86 = val_55 + (val_6.m13 + 8);
            val_104 = val_104 + (val_6.m13 + 12);
            val_105 = val_105 + (val_6.m13 + 40);
            val_102 = val_102 + (val_6.m13 + 20);
            if(val_102 < (val_6.m13 + 32))
            {
                goto label_97;
            }
            
            goto label_98;
            label_96:
            if(((int)D16 & 1) == 0)
            {
                    if((int)D16 != 1)
            {
                goto label_109;
            }
            
            }
            
            if((val_6.m32 + 8) >= 1)
            {
                    val_112 = val_6.m13 + 176;
                mem2[0] = S27 - S29;
                mem2[0] = S26 - val_107;
                var val_106 = val_6.m13 + 52;
                val_106 = val_106 * ((float)val_6.m32 + 8);
                float val_63 = (val_6.m13 + 48) * ((float)val_6.m32 + 8);
                val_113 = S29 - val_106;
                val_114 = val_106 + S27;
                val_111 = val_107 - val_63;
                float val_64 = val_63 + S26;
            }
            else
            {
                    val_113 = S29;
                val_112 = val_6.m13 + 176;
                val_114 = S27;
            }
            
            float val_65 = val_113 - val_114;
            val_107 = val_107 - S26;
            float val_67 = (val_6.m13 + 8) - S26;
            mem2[0] = val_65;
            mem2[0] = val_107;
            var val_108 = val_112;
            val_108 = (((val_6.m13 + 24) - val_114) * val_65) / val_108;
            if(((val_6.m32 + 8) < 0) || ((val_6.m32 + 8) > 1))
            {
                goto label_109;
            }
            
            float val_69 = val_6.m13 + 176;
            mem2[0] = (val_6.m13 + 8) - S26;
            mem2[0] = (val_6.m13 + 24) - val_114;
            float val_75 = val_6.m13 + 48;
            var val_109 = (val_6.m13 + 44 + 68) + (val_6.m13 + 24);
            val_109 = val_109 + ((float)val_6.m13 + 16);
            val_109 = (((val_6.m13 + 44 + 68) + (val_6.m13 + 24)) + ((float)val_6.m13 + 16)) * val_109;
            if((val_6.m13 + 44 + 68 + 12) > val_105)
            {
                goto label_109;
            }
            
            val_115 = mem[val_6.m13 + 44 + 104];
            val_115 = val_6.m13 + 44 + 104;
            goto label_110;
            label_98:
            val_98 = 0;
            label_65:
            val_101 = 0;
            label_112:
            val_88 = mem[val_6.m32 + 12];
            val_88 = val_6.m32 + 12;
            goto label_111;
            label_83:
            val_101 = 0;
            label_111:
            mem2[0] = val_101;
            float val_76 = val_6.m32 - 96;
            val_76 = val_76 + 4;
            return (bool)val_98;
            label_62:
            val_115 = mem[val_6.m13 + 44 + 104];
            val_115 = val_6.m13 + 44 + 104;
            label_110:
            if(val_115 == 1)
            {
                    val_102 = (val_102 + (val_102 >> 31)) >> 1;
            }
            
            goto label_112;
        }
        private bool Approximately(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2)
        {
            bool val_1 = this.Approximately(a:  null, b:  null);
            if(val_1 == false)
            {
                    return false;
            }
            
            return val_1.Approximately(a:  null, b:  null);
        }
        private bool Approximately(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)
        {
            bool val_1 = this.Approximately(a:  null, b:  null);
            if(val_1 == false)
            {
                    return false;
            }
            
            bool val_2 = val_1.Approximately(a:  null, b:  null);
            if(val_2 == false)
            {
                    return false;
            }
            
            return val_2.Approximately(a:  null, b:  null);
        }
        private bool Approximately(float a, float b)
        {
            var val_2;
            var val_6;
            float val_7;
            var val_8;
            var val_9;
            var val_10;
            float val_11;
            var val_12;
            var val_13;
            float val_1 = R1 * 100f;
            var val_8 = R2;
            if()
            {
                goto label_0;
            }
            
            if()
            {
                goto label_1;
            }
            
            val_6 = val_2;
            val_7 = -1f;
            goto label_2;
            label_0:
            if()
            {
                goto label_3;
            }
            
            val_6 = val_2;
            val_7 = 1f;
            label_2:
            float val_3 = S22 + val_7;
            if((R1 & 1) != 0)
            {
                    val_8 = S22;
            }
            
            goto label_4;
            label_1:
            float val_6 = -0.5f;
            val_6 = val_1 + val_6;
            val_9 = val_6;
            goto label_5;
            label_3:
            float val_7 = 0.5f;
            val_7 = val_1 + val_7;
            val_9 = val_7;
            label_5:
            val_8 = val_9;
            label_4:
            val_8 = val_8 * 100f;
            if()
            {
                goto label_6;
            }
            
            if()
            {
                goto label_7;
            }
            
            val_10 = val_2;
            val_11 = -1f;
            goto label_8;
            label_6:
            if()
            {
                goto label_9;
            }
            
            val_10 = val_2;
            val_11 = 1f;
            label_8:
            float val_4 = S22 + val_11;
            if((R1 & 1) != 0)
            {
                    val_12 = S22;
            }
            
            goto label_10;
            label_7:
            float val_9 = -0.5f;
            val_9 = val_8 + val_9;
            val_13 = val_9;
            goto label_11;
            label_9:
            float val_10 = 0.5f;
            val_10 = val_8 + val_10;
            val_13 = val_10;
            label_11:
            val_12 = val_13;
            label_10:
            val_10 = val_12 / 100f;
            float val_5 = val_8 / 100f;
            if()
            {
                    0 = 1;
            }
            
            return true;
        }
        private bool WrongArrayLength(int arrayLength, Vectrosity.VectorLine.FunctionName functionName)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            int val_13;
            var val_14;
            val_9 = functionName;
            val_10 = 0;
            int val_1 = this.pointsCount;
            if(this.m_lineType != 0)
            {
                    val_1 = val_1 + (val_1 >> 31);
                if(arrayLength == (val_1 >> 1))
            {
                    return (bool)val_10;
            }
            
                val_11 = 536882401;
                val_12 = 536896697;
                if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_12 = 536896697;
            }
            
                var val_2 = (mem[536896789] + 72) + (val_9 << 2);
                mem[536882417] = (mem[536896789] + 72 + (functionName) << 2) + 16;
                mem[536882421] = -1610612337;
                mem[536882425] = this.m_name;
                val_9 = -1610612221;
                mem[536882429] = val_9;
                int val_3 = this.pointsCount;
                val_3 = val_3 + (val_3 >> 31);
                val_13 = val_3 >> 1;
            }
            else
            {
                    val_1 = val_1 - 1;
                if(val_1 == arrayLength)
            {
                    return (bool)val_10;
            }
            
                val_11 = 536882401;
                val_14 = 536896697;
                if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_14 = 536896697;
            }
            
                var val_4 = (mem[536896789] + 72) + (val_9 << 2);
                mem[536882417] = (mem[536896789] + 72 + (functionName) << 2) + 16;
                mem[536882421] = -1610612339;
                mem[536882425] = this.m_name;
                val_9 = -1610612219;
                mem[536882429] = val_9;
                val_13 = this.pointsCount - 1;
            }
            
            string val_6 = val_13.ToString();
            mem[536882433] = ;
            mem[536882437] = -1610611859;
            string val_7 = arrayLength.ToString();
            mem[536882441] = ;
            string val_8 = +536882401;
            UnityEngine.Debug.LogError(message:  536882401);
            val_10 = 1;
            return (bool)val_10;
        }
        private bool CheckArrayLength(Vectrosity.VectorLine.FunctionName functionName, int segments, int index)
        {
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            val_19 = index;
            if(segments <= 0)
            {
                goto label_1;
            }
            
            if(val_19 <= 1)
            {
                goto label_2;
            }
            
            if(this.m_lineType != 2)
            {
                goto label_3;
            }
            
            val_20 = 1;
            if((val_19 + segments) <= this.pointsCount)
            {
                    return (bool)val_20;
            }
            
            if(val_19 == 0)
            {
                goto label_5;
            }
            
            val_19 = 536882401;
            mem[536882417] = -1610602683;
            val_21 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_21 = 536896697;
            }
            
            var val_3 = (mem[536896789] + 72) + (functionName << 2);
            mem[536882421] = (mem[536896789] + 72 + (functionName) << 2) + 16;
            mem[536882425] = -1610612277;
            string val_4 = index.ToString();
            mem[536882429] = ;
            mem[536882433] = -1610612269;
            mem[536882437] = this.m_name;
            val_22 = -1610612241;
            mem[536882441] = val_22;
            goto label_105;
            label_1:
            val_23 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_23 = 536896697;
            }
            
            var val_5 = (mem[536896789] + 72) + (functionName << 2);
            val_20 = 0;
            val_24 = -1610602787;
            string val_6 = -1610602787(-1610602787) + (mem[536896789] + 72 + (functionName) << 2) + 16((mem[536896789] + 72 + (functionName) << 2) + 16) + -1610612329(-1610612329);
            goto label_37;
            label_2:
            val_19 = 536882401;
            mem[536882417] = -1610602787;
            val_25 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_25 = 536896697;
            }
            
            var val_7 = (mem[536896789] + 72) + (functionName << 2);
            mem[536882421] = (mem[536896789] + 72 + (functionName) << 2) + 16;
            mem[536882425] = -1610610735;
            mem[536882429] = this.m_name;
            val_26 = 22777904;
            goto label_55;
            label_3:
            int val_8 = this.pointsCount;
            if(this.m_lineType == 0)
            {
                goto label_56;
            }
            
            val_20 = 1;
            if((val_19 + (segments << 1)) <= val_8)
            {
                    return (bool)val_20;
            }
            
            val_27 = 536882401;
            if(val_19 != 0)
            {
                goto label_58;
            }
            
            val_19 = val_27;
            mem[536882417] = -1610602787;
            val_28 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_28 = 536896697;
            }
            
            var val_10 = (mem[536896789] + 72) + (functionName << 2);
            mem[536882421] = (mem[536896789] + 72 + (functionName) << 2) + 16;
            val_29 = 22780888;
            goto label_117;
            label_56:
            int val_11 = val_19 + segments;
            val_20 = 1;
            val_11 = val_11 + 1;
            if(val_11 <= val_8)
            {
                    return (bool)val_20;
            }
            
            val_27 = 536882401;
            if(val_19 == 0)
            {
                goto label_72;
            }
            
            label_58:
            val_19 = val_27;
            mem[536882417] = -1610602683;
            val_30 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_30 = 536896697;
            }
            
            var val_12 = (mem[536896789] + 72) + (functionName << 2);
            mem[536882421] = (mem[536896789] + 72 + (functionName) << 2) + 16;
            mem[536882425] = -1610612277;
            string val_13 = index.ToString();
            mem[536882429] = ;
            mem[536882433] = -1610612271;
            string val_15 = this.pointsCount.ToString();
            mem[536882437] = ;
            mem[536882441] = -1610611945;
            mem[536882445] = this.m_name;
            val_22 = -1610612241;
            mem[536882449] = val_22;
            goto label_105;
            label_5:
            val_19 = 536882401;
            mem[536882417] = -1610602787;
            val_31 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_31 = 536896697;
            }
            
            var val_16 = (mem[536896789] + 72) + (functionName << 2);
            mem[536882421] = (mem[536896789] + 72 + (functionName) << 2) + 16;
            val_29 = 22780892;
            goto label_117;
            label_72:
            val_19 = val_27;
            mem[536882417] = -1610602787;
            val_32 = 536896697;
            if(((mem[536896884] & true) == 0) && (mem[536896813] == 0))
            {
                    val_32 = 536896697;
            }
            
            var val_17 = (mem[536896789] + 72) + (functionName << 2);
            mem[536882421] = (mem[536896789] + 72 + (functionName) << 2) + 16;
            val_29 = 22780884;
            label_117:
            mem[536882425] = -1610610733;
            mem[536882429] = this.m_name;
            val_26 = 22777868;
            label_55:
            val_22 = -1610612241;
            mem[536882433] = val_22;
            label_105:
            val_24 = val_19;
            val_20 = 0;
            string val_18 = +536882401;
            label_37:
            UnityEngine.Debug.LogError(message:  536882401);
            return (bool)val_20;
        }
        public void MakeRect(UnityEngine.Rect rect)
        {
            float val_1 = rect.m_XMin.x;
            float val_2 = rect.m_XMin.y;
            float val_3 = rect.m_XMin.x;
            float val_4 = rect.m_XMin.width;
            float val_5 = rect.m_XMin.y;
            float val_6 = rect.m_XMin.height;
            uint val_8 = 410796704;
            val_8 = 410796704 + val_8;
            this.MakeRect(bottomLeft:  new UnityEngine.Vector3() {x = 3.260387E-24f, y = 3.260387E-24f, z = 0f}, topRight:  new UnityEngine.Vector3() {x = 410796704 + 410796704, y = val_8, z = 0f}, index:  0f);
        }
        public void MakeRect(UnityEngine.Rect rect, int index)
        {
            float val_1 = rect.m_XMin.x;
            float val_2 = rect.m_XMin.y;
            float val_3 = rect.m_XMin.x;
            float val_4 = rect.m_XMin.width;
            float val_5 = rect.m_XMin.y;
            float val_6 = rect.m_XMin.height;
            uint val_8 = 410908704;
            val_8 = 410908704 + val_8;
            this.MakeRect(bottomLeft:  new UnityEngine.Vector3() {x = 3.282475E-24f, y = 3.282475E-24f, z = 0f}, topRight:  new UnityEngine.Vector3() {x = 410908704 + 410908704, y = val_8, z = 0f}, index:  index);
        }
        public void MakeRect(UnityEngine.Vector3 bottomLeft, UnityEngine.Vector3 topRight)
        {
            this.MakeRect(bottomLeft:  new UnityEngine.Vector3() {x = bottomLeft.x, y = bottomLeft.y, z = bottomLeft.z}, topRight:  new UnityEngine.Vector3() {x = topRight.x, y = topRight.y, z = topRight.z}, index:  0);
        }
        public void MakeRect(UnityEngine.Vector3 bottomLeft, UnityEngine.Vector3 topRight, int index)
        {
            float val_29;
            float val_30;
            var val_31;
            var val_32;
            float val_33;
            int val_34;
            float val_35;
            float val_36;
            var val_37;
            System.Collections.Generic.List<UnityEngine.Vector3> val_38;
            var val_39;
            float val_40;
            int val_41;
            val_29 = bottomLeft.z;
            val_30 = bottomLeft.x;
            int val_1 = this.pointsCount;
            if(this.m_lineType != 1)
            {
                goto label_1;
            }
            
            if((index + 8) <= val_1)
            {
                goto label_2;
            }
            
            if(index != 0)
            {
                goto label_3;
            }
            
            val_31 = -1610612241;
            val_32 = 22796812;
            goto label_4;
            label_1:
            if((index + 5) <= val_1)
            {
                goto label_5;
            }
            
            if(index == 0)
            {
                goto label_6;
            }
            
            label_3:
            mem[536882417] = -1610609711;
            string val_4 = index.ToString();
            mem[536882421] = ;
            val_33 = -1610612267;
            mem[536882425] = val_33;
            mem[536882429] = this.m_name;
            mem[536882433] = -1610612241;
            string val_5 = +536882401;
            UnityEngine.Debug.LogError(message:  536882401);
            return;
            label_2:
            if(this.m_is2D == false)
            {
                goto label_26;
            }
            
            this.m_points2.set_Item(index:  index, value:  new UnityEngine.Vector2() {x = val_30, y = bottomLeft.y});
            this.m_points2.set_Item(index:  index + 1, value:  new UnityEngine.Vector2() {x = topRight.x, y = bottomLeft.y});
            this.m_points2.set_Item(index:  index + 2, value:  new UnityEngine.Vector2() {x = topRight.x, y = bottomLeft.y});
            val_29 = topRight.y;
            this.m_points2.set_Item(index:  index + 3, value:  new UnityEngine.Vector2() {x = topRight.x, y = val_29});
            this.m_points2.set_Item(index:  index + 4, value:  new UnityEngine.Vector2() {x = topRight.x, y = val_29});
            this.m_points2.set_Item(index:  index + 5, value:  new UnityEngine.Vector2() {x = val_30, y = val_29});
            this.m_points2.set_Item(index:  index + 6, value:  new UnityEngine.Vector2() {x = val_30, y = val_29});
            val_33 = 22739736;
            val_34 = index + 7;
            val_35 = val_30;
            val_36 = bottomLeft.y;
            goto label_35;
            label_5:
            if(this.m_is2D == false)
            {
                goto label_36;
            }
            
            val_29 = bottomLeft.y;
            this.m_points2.set_Item(index:  index, value:  new UnityEngine.Vector2() {x = val_30, y = val_29});
            this.m_points2.set_Item(index:  index + 1, value:  new UnityEngine.Vector2() {x = topRight.x, y = val_29});
            val_30 = 22739736;
            val_33 = topRight.y;
            this.m_points2.set_Item(index:  index + 2, value:  new UnityEngine.Vector2() {x = topRight.x, y = val_33});
            this.m_points2.set_Item(index:  index + 3, value:  new UnityEngine.Vector2() {x = val_30, y = val_33});
            val_34 = index + 4;
            val_35 = val_30;
            val_36 = val_29;
            label_35:
            this.m_points2.set_Item(index:  val_34, value:  new UnityEngine.Vector2() {x = val_35, y = val_36});
            return;
            label_6:
            val_31 = -1610612241;
            val_32 = 22796808;
            label_4:
            string val_15 = -1610602761(-1610602761) + this.m_name + -1610612241(-1610612241);
            UnityEngine.Debug.LogError(message:  -1610602761);
            return;
            label_26:
            this.m_points3.set_Item(index:  index, value:  new UnityEngine.Vector3() {x = val_30, y = bottomLeft.y, z = val_29});
            this.m_points3.set_Item(index:  index + 1, value:  new UnityEngine.Vector3() {x = topRight.x, y = bottomLeft.y, z = val_29});
            this.m_points3.set_Item(index:  index + 2, value:  new UnityEngine.Vector3() {x = topRight.x, y = bottomLeft.y, z = val_29});
            val_29 = topRight.z;
            val_30 = topRight.y;
            this.m_points3.set_Item(index:  index + 3, value:  new UnityEngine.Vector3() {x = topRight.x, y = val_30, z = val_29});
            val_37 = 4.02206E-38f;
            if(this.m_points3 == 0)
            {
                    val_37 = val_37;
            }
            
            this.m_points3.set_Item(index:  index + 4, value:  new UnityEngine.Vector3() {x = topRight.x, y = val_30, z = val_29});
            this.m_points3.set_Item(index:  index + 5, value:  new UnityEngine.Vector3() {x = val_30, y = val_30, z = val_29});
            this.m_points3.set_Item(index:  index + 6, value:  new UnityEngine.Vector3() {x = val_30, y = val_30, z = val_29});
            val_33 = val_37;
            val_38 = this.m_points3;
            val_39 = -1073711317;
            val_40 = val_30;
            val_41 = index + 7;
            goto label_53;
            label_36:
            this.m_points3.set_Item(index:  index, value:  new UnityEngine.Vector3() {x = val_30, y = bottomLeft.y, z = val_29});
            this.m_points3.set_Item(index:  index + 1, value:  new UnityEngine.Vector3() {x = topRight.x, y = bottomLeft.y, z = val_29});
            val_29 = 4.02206E-38f;
            val_33 = topRight.y;
            this.m_points3.set_Item(index:  index + 2, value:  new UnityEngine.Vector3() {x = topRight.x, y = val_33, z = topRight.z});
            val_30 = val_30;
            this.m_points3.set_Item(index:  index + 3, value:  new UnityEngine.Vector3() {x = val_30, y = val_33, z = topRight.z});
            val_38 = this.m_points3;
            val_40 = val_30;
            val_39 = -1073711317;
            val_41 = index + 4;
            label_53:
            val_38.set_Item(index:  val_41, value:  new UnityEngine.Vector3() {x = val_40, y = bottomLeft.y, z = val_29});
        }
        public void MakeRoundedRect(UnityEngine.Rect rect, float cornerRadius, int cornerSegments)
        {
            int val_8;
            float val_1 = rect.m_XMin.x;
            float val_2 = rect.m_XMin.y;
            float val_3 = rect.m_XMin.x;
            float val_4 = rect.m_XMin.width;
            float val_5 = rect.m_XMin.y;
            float val_6 = rect.m_XMin.height;
            uint val_9 = 411482272;
            val_9 = 411482272 + val_9;
            this.MakeRoundedRect(bottomLeft:  new UnityEngine.Vector3() {x = 3.482461E-24f, y = 3.482461E-24f, z = 0f}, topRight:  new UnityEngine.Vector3() {x = 411482272 + 411482272, y = val_9, z = 0f}, cornerRadius:  cornerSegments, cornerSegments:  cornerSegments, index:  val_8);
        }
        public void MakeRoundedRect(UnityEngine.Rect rect, float cornerRadius, int cornerSegments, int index)
        {
            float val_1 = rect.m_XMin.x;
            float val_2 = rect.m_XMin.y;
            float val_3 = rect.m_XMin.x;
            float val_4 = rect.m_XMin.width;
            float val_5 = rect.m_XMin.y;
            float val_6 = rect.m_XMin.height;
            uint val_9 = 411594272;
            val_9 = val_9 + 411594272;
            this.MakeRoundedRect(bottomLeft:  new UnityEngine.Vector3() {x = 3.526637E-24f, y = 3.526637E-24f, z = 0f}, topRight:  new UnityEngine.Vector3() {x = 411594272 + 411594272, y = val_9, z = 0f}, cornerRadius:  cornerSegments, cornerSegments:  cornerSegments, index:  index);
        }
        public void MakeRoundedRect(UnityEngine.Vector3 bottomLeft, UnityEngine.Vector3 topRight, float cornerRadius, int cornerSegments)
        {
            int val_1;
            this.MakeRoundedRect(bottomLeft:  new UnityEngine.Vector3() {x = bottomLeft.x, y = bottomLeft.y, z = bottomLeft.z}, topRight:  new UnityEngine.Vector3() {x = topRight.x, y = topRight.y, z = topRight.z}, cornerRadius:  cornerSegments, cornerSegments:  cornerSegments, index:  val_1);
        }
        public void MakeRoundedRect(UnityEngine.Vector3 bottomLeft, UnityEngine.Vector3 topRight, float cornerRadius, int cornerSegments, int index)
        {
            int val_1;
            float val_8;
            float val_9;
            var val_44;
            int val_45;
            float val_46;
            var val_47;
            var val_48;
            float val_49;
            float val_50;
            var val_51;
            float val_52;
            int val_53;
            float val_54;
            float val_55;
            int val_56;
            val_44 = bottomLeft.y;
            val_45 = index;
            val_46 = topRight.y;
            val_45 = val_45;
            val_44 = val_44;
            val_46 = val_46;
            if(val_45 <= 0)
            {
                goto label_1;
            }
            
            if(val_1 <= 1)
            {
                goto label_2;
            }
            
            if((mem[1152921509313644640] == true) || (mem[1152921509313644640] == false))
            {
                goto label_4;
            }
            
            val_47 = 22796816;
            goto label_10;
            label_1:
            val_47 = 22796820;
            goto label_10;
            label_2:
            val_47 = 22796824;
            label_10:
            UnityEngine.Debug.LogError(message:  -1610602753);
            return;
            label_4:
            var val_38 = 5;
            val_38 = val_38 + (val_45 << 2);
            val_48 = val_45;
            if(mem[1152921509313644696] == 1)
            {
                    val_38 = 8 + (val_45 << 3);
            }
            
            int val_2 = val_38 + val_1;
            int val_3 = this.pointsCount;
            if(val_3 < val_2)
            {
                    this.Resize(newCount:  val_2);
            }
            
            if(val_3 > val_2)
            {
                    this.Exchange(v1: ref  new UnityEngine.Vector3() {x = 3.614988E-24f, y = 3.614983E-24f, z = 0f}, v2: ref  new UnityEngine.Vector3(), i:  0);
                val_49 = val_46;
            }
            else
            {
                    val_49 = val_46;
            }
            
            var val_48 = val_48;
            if(val_3 > val_2)
            {
                    this.Exchange(v1: ref  new UnityEngine.Vector3() {x = 3.614988E-24f, y = 3.614983E-24f, z = 1.401298E-45f}, v2: ref  new UnityEngine.Vector3(), i:  0);
                val_49 = val_46;
                val_50 = bottomLeft.y;
            }
            
            float val_39 = bottomLeft.x;
            val_50 = val_50 + cornerSegments;
            float val_40 = bottomLeft.z;
            val_49 = val_49 - cornerSegments;
            val_39 = val_39 + cornerSegments;
            val_40 = val_40 + 0f;
            float val_41 = topRight.x;
            val_41 = val_41 - cornerSegments;
            this.MakeCircle(origin:  new UnityEngine.Vector3() {x = val_39, y = val_50, z = val_40}, radius:  val_49, segments:  cornerSegments, index:  val_48 << 2);
            var val_42 = mem[1152921509313644696];
            val_42 = val_42 - 1;
            if(val_42 == 1)
            {
                    val_48 + 1 = val_48 << 1;
            }
            
            val_42 = val_42 >> 5;
            int val_6 = val_48 << val_42;
            if(mem[1152921509313644640] == false)
            {
                goto label_17;
            }
            
            float val_43 = val_50;
            val_43 = val_49 - val_43;
            this.CopyAndAddPoints(cornerPointCount:  val_48 + 1, originalCount:  val_6, sectionNumber:  3, add:  new UnityEngine.Vector2() {x = 0f, y = val_43}, index:  val_1);
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
            this.CopyAndAddPoints(cornerPointCount:  val_48 + 1, originalCount:  val_6, sectionNumber:  2, add:  new UnityEngine.Vector2() {x = val_9, y = val_8}, index:  val_1);
            float val_44 = val_39;
            val_44 = val_41 - val_44;
            this.CopyAndAddPoints(cornerPointCount:  val_48 + 1, originalCount:  val_6, sectionNumber:  1, add:  new UnityEngine.Vector2() {x = val_44, y = 0f}, index:  val_1);
            float val_45 = val_39;
            float val_46 = val_50;
            val_45 = val_41 - val_45;
            val_46 = val_49 - val_46;
            this.CopyAndAddPoints(cornerPointCount:  val_48 + 1, originalCount:  val_6, sectionNumber:  0, add:  new UnityEngine.Vector2() {x = val_45, y = val_46}, index:  val_1);
            val_51 = mem[1152921509313644644];
            if(mem[1152921509313644696] != 1)
            {
                goto label_19;
            }
            
            if((mem[1152921509313644644] + 12) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_47 = mem[1152921509313644644] + 8;
            val_47 = val_47 + (val_1 << 3);
            val_48 = 22739736;
            val_51.set_Item(index:  (val_1 + ((val_48 + 1) << 2)) + 7, value:  new UnityEngine.Vector2() {x = (mem[1152921509313644644] + 8 + (val_1) << 3) + 16, y = 0f});
            int val_13 = val_1 + ((val_48 + 1) + ((val_48 + 1) << 1));
            val_48 = val_13 + 6;
            if((mem[1152921509313644644] + 12) <= val_48)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_49 = mem[1152921509313644644] + 8;
            val_49 = val_49 + (val_48 << 3);
            mem[1152921509313644644].set_Item(index:  val_13 + 5, value:  new UnityEngine.Vector2() {x = (mem[1152921509313644644] + 8 + (((val_1 + ((index << 1) + ((index << 1)) << 1)) + 6)) << 3) + 16, y = 0f});
            var val_16 = (val_1 + ((val_48 + 1) << 1)) + 4;
            if((mem[1152921509313644644] + 12) <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_50 = mem[1152921509313644644] + 8;
            val_50 = val_50 + (val_16 << 3);
            mem[1152921509313644644].set_Item(index:  (val_1 + ((val_48 + 1) << 1)) + 3, value:  new UnityEngine.Vector2() {x = (mem[1152921509313644644] + 8 + (((val_1 + ((index << 1)) << 1) + 4)) << 3) + 16, y = 0f});
            int val_20 = (val_48 + 1) + val_1;
            val_51 = val_20 + 2;
            if((mem[1152921509313644644] + 12) <= val_51)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_51 = mem[1152921509313644644] + 8;
            val_51 = val_51 + (val_51 << 3);
            val_52 = mem[(mem[1152921509313644644] + 8 + ((((index << 1) + val_1) + 2)) << 3) + 16];
            val_52 = (mem[1152921509313644644] + 8 + ((((index << 1) + val_1) + 2)) << 3) + 16;
            val_53 = val_20 + 1;
            goto label_27;
            label_17:
            UnityEngine.Vector2 val_21 = UnityEngine.Vector2.zero;
            this.CopyAndAddPoints(cornerPointCount:  val_48 + 1, originalCount:  val_6, sectionNumber:  3, add:  new UnityEngine.Vector2() {x = val_9, y = val_8}, index:  val_1);
            float val_52 = val_50;
            val_52 = val_49 - val_52;
            this.CopyAndAddPoints(cornerPointCount:  val_48 + 1, originalCount:  val_6, sectionNumber:  2, add:  new UnityEngine.Vector2() {x = 0f, y = val_52}, index:  val_1);
            float val_53 = val_39;
            float val_54 = val_50;
            val_53 = val_41 - val_53;
            val_54 = val_49 - val_54;
            this.CopyAndAddPoints(cornerPointCount:  val_48 + 1, originalCount:  val_6, sectionNumber:  1, add:  new UnityEngine.Vector2() {x = val_53, y = val_54}, index:  val_1);
            float val_55 = val_39;
            val_55 = val_41 - val_55;
            this.CopyAndAddPoints(cornerPointCount:  val_48 + 1, originalCount:  val_6, sectionNumber:  0, add:  new UnityEngine.Vector2() {x = val_55, y = 0f}, index:  val_1);
            val_51 = mem[1152921509313644648];
            if(mem[1152921509313644696] != 1)
            {
                goto label_29;
            }
            
            if((mem[1152921509313644648] + 12) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_48 = 22739796;
            var val_56 = mem[1152921509313644648] + 8;
            val_56 = val_56 + ((val_1 + (val_1 << 1)) << 2);
            val_51.set_Item(index:  (val_1 + ((val_48 + 1) << 2)) + 7, value:  new UnityEngine.Vector3() {x = (mem[1152921509313644648] + 8 + ((val_1 + (val_1) << 1)) << 2) + 16, y = (mem[1152921509313644648] + 8 + ((val_1 + (val_1) << 1)) << 2) + 20, z = (mem[1152921509313644648] + 8 + ((val_1 + (val_1) << 1)) << 2) + 24});
            int val_26 = val_1 + ((val_48 + 1) + ((val_48 + 1) << 1));
            val_48 = val_26 + 6;
            if((mem[1152921509313644648] + 12) <= val_48)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_57 = mem[1152921509313644648] + 8;
            val_57 = val_57 + ((val_48 + (val_48 << 1)) << 2);
            mem[1152921509313644648].set_Item(index:  val_26 + 5, value:  new UnityEngine.Vector3() {x = (mem[1152921509313644648] + 8 + ((((val_1 + ((index << 1) + ((index << 1)) << 1)) + 6) + (((val_1 + ((index << 1) + ((index << 1)) << 1)) + 6)) << 1)) << 2) + 16, y = (mem[1152921509313644648] + 8 + ((((val_1 + ((index << 1) + ((index << 1)) << 1)) + 6) + (((val_1 + ((index << 1) + ((index << 1)) << 1)) + 6)) << 1)) << 2) + 20, z = (mem[1152921509313644648] + 8 + ((((val_1 + ((index << 1) + ((index << 1)) << 1)) + 6) + (((val_1 + ((index << 1) + ((index << 1)) << 1)) + 6)) << 1)) << 2) + 24});
            var val_30 = (val_1 + ((val_48 + 1) << 1)) + 4;
            if((mem[1152921509313644648] + 12) <= val_30)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_58 = mem[1152921509313644648] + 8;
            val_58 = val_58 + ((val_30 + (val_30 << 1)) << 2);
            mem[1152921509313644648].set_Item(index:  (val_1 + ((val_48 + 1) << 1)) + 3, value:  new UnityEngine.Vector3() {x = (mem[1152921509313644648] + 8 + ((((val_1 + ((index << 1)) << 1) + 4) + (((val_1 + ((index << 1)) << 1) + 4)) << 1)) << 2) + 16, y = (mem[1152921509313644648] + 8 + ((((val_1 + ((index << 1)) << 1) + 4) + (((val_1 + ((index << 1)) << 1) + 4)) << 1)) << 2) + 20, z = (mem[1152921509313644648] + 8 + ((((val_1 + ((index << 1)) << 1) + 4) + (((val_1 + ((index << 1)) << 1) + 4)) << 1)) << 2) + 24});
            int val_35 = (val_48 + 1) + val_1;
            val_51 = val_35 + 2;
            if((mem[1152921509313644648] + 12) <= val_51)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_59 = mem[1152921509313644648] + 8;
            val_59 = val_59 + ((val_51 + (val_51 << 1)) << 2);
            val_54 = mem[(mem[1152921509313644648] + 8 + (((((index << 1) + val_1) + 2) + ((((index << 1) + val_1) + 2)) << 1)) << 2) + 16];
            val_54 = (mem[1152921509313644648] + 8 + (((((index << 1) + val_1) + 2) + ((((index << 1) + val_1) + 2)) << 1)) << 2) + 16;
            val_55 = mem[(mem[1152921509313644648] + 8 + (((((index << 1) + val_1) + 2) + ((((index << 1) + val_1) + 2)) << 1)) << 2) + 20];
            val_55 = (mem[1152921509313644648] + 8 + (((((index << 1) + val_1) + 2) + ((((index << 1) + val_1) + 2)) << 1)) << 2) + 20;
            val_56 = val_35 + 1;
            goto label_37;
            label_19:
            if((mem[1152921509313644644] + 12) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_60 = mem[1152921509313644644] + 8;
            val_60 = val_60 + (val_1 << 3);
            val_52 = mem[(mem[1152921509313644644] + 8 + (val_1) << 3) + 16];
            val_52 = (mem[1152921509313644644] + 8 + (val_1) << 3) + 16;
            val_53 = val_1 + ((val_48 + 1) << 2);
            label_27:
            val_51.set_Item(index:  val_53, value:  new UnityEngine.Vector2() {x = val_52, y = 0f});
            return;
            label_29:
            if((mem[1152921509313644648] + 12) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_61 = mem[1152921509313644648] + 8;
            val_61 = val_61 + ((val_1 + (val_1 << 1)) << 2);
            val_54 = mem[(mem[1152921509313644648] + 8 + ((val_1 + (val_1) << 1)) << 2) + 16];
            val_54 = (mem[1152921509313644648] + 8 + ((val_1 + (val_1) << 1)) << 2) + 16;
            val_55 = mem[(mem[1152921509313644648] + 8 + ((val_1 + (val_1) << 1)) << 2) + 20];
            val_55 = (mem[1152921509313644648] + 8 + ((val_1 + (val_1) << 1)) << 2) + 20;
            val_56 = val_1 + ((val_48 + 1) << 2);
            label_37:
            val_51.set_Item(index:  val_56, value:  new UnityEngine.Vector3() {x = val_54, y = val_55, z = (mem[1152921509313644648] + 8 + ((val_1 + (val_1) << 1)) << 2) + 24});
        }
        private void CopyAndAddPoints(int cornerPointCount, int originalCount, int sectionNumber, UnityEngine.Vector2 add, int index)
        {
            int val_24;
            var val_25;
            int val_26;
            var val_27;
            float val_28;
            float val_29;
            int val_30;
            float val_31;
            float val_32;
            int val_33;
            val_24 = sectionNumber;
            val_25 = originalCount;
            val_26 = cornerPointCount;
            Vectrosity.LineType val_20 = this.m_lineType;
            int val_1 = val_26 - 1;
            val_20 = val_20 - 1;
            val_27 = val_20 >> 5;
            if(val_1 < 0)
            {
                goto label_1;
            }
            
            int val_2 = index + val_26;
            var val_5 = IP - 1;
            int val_6 = (val_24 + 1) - 1;
            var val_7 = 8 + ((IP) << 3);
            var val_9 = 12 + ((IP + ((IP) << 1)) << 2);
            int val_10 = (val_26 + 2) - 1;
            label_16:
            if((val_27 & 1) != 0)
            {
                goto label_2;
            }
            
            if(this.m_is2D == false)
            {
                goto label_3;
            }
            
            val_26 = this.m_points2;
            if(val_27 <= (val_5 + 0))
            {
                    var val_21 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_21 = val_21 + val_7;
            var val_22 = val_21;
            var val_23 = (0 + (8 + (IP) << 3)) + 4;
            val_22 = add.x + val_22;
            val_23 = add.y + val_23;
            val_28 = val_22;
            val_29 = val_23;
            val_30 = val_10;
            goto label_6;
            label_2:
            if(this.m_is2D == false)
            {
                goto label_7;
            }
            
            val_26 = this.m_points2;
            if(val_27 <= (val_5 + 0))
            {
                    float val_24 = 0f;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_24 = val_24 + val_7;
            float val_25 = val_24;
            float val_26 = (0 + (8 + (IP) << 3)) + 4;
            val_25 = add.x + val_25;
            val_26 = add.y + val_26;
            val_28 = val_25;
            val_29 = val_26;
            val_30 = val_6;
            label_6:
            val_26.set_Item(index:  val_30 + 0, value:  new UnityEngine.Vector2() {x = val_28, y = val_29});
            goto label_10;
            label_3:
            val_26 = this.m_points3;
            if(val_27 <= (val_5 + 0))
            {
                    var val_27 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_27 = val_27 + val_9;
            var val_28 = (0 + (12 + ((IP + (IP) << 1)) << 2)) + -8;
            var val_29 = (0 + (12 + ((IP + (IP) << 1)) << 2)) + -4;
            val_28 = val_28 + add.x;
            val_29 = val_29 + add.y;
            val_31 = val_28;
            val_29 = val_29;
            val_32 = val_27 + 0f;
            val_33 = val_10;
            goto label_13;
            label_7:
            val_26 = this.m_points3;
            if(val_27 <= (val_5 + 0))
            {
                    var val_30 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_30 = val_30 + val_9;
            float val_31 = (0 + (12 + ((IP + (IP) << 1)) << 2)) + -8;
            float val_32 = (0 + (12 + ((IP + (IP) << 1)) << 2)) + -4;
            val_31 = val_31 + add.x;
            val_32 = val_32 + add.y;
            val_31 = val_31;
            val_32 = val_30 + 0f;
            val_29 = val_32;
            val_33 = val_6;
            label_13:
            val_26.set_Item(index:  val_33 + 0, value:  new UnityEngine.Vector3() {x = val_31, y = val_29, z = val_32});
            label_10:
            Vectrosity.LineType val_33 = this.m_lineType;
            val_25 = 0 - 1;
            val_24 = val_7 - 8;
            val_33 = val_33 - 1;
            val_9 = val_9 - 12;
            val_27 = val_33 >> 5;
            if((val_1 + val_25) > 1)
            {
                goto label_16;
            }
            
            label_1:
            if(val_27 == 0)
            {
                    return;
            }
            
            int val_18 = val_24 + 1;
            val_18 = val_18 * val_26;
            bool val_36 = this.m_is2D;
            val_18 = val_18 + (val_24 << 1);
            int val_35 = index;
            int val_19 = val_18 + val_35;
            if(val_36 != false)
            {
                    val_25 = val_19 - 1;
                if(val_18 <= val_25)
            {
                    var val_34 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_34 = val_34 + (val_25 << 3);
                this.m_points2.set_Item(index:  val_19, value:  new UnityEngine.Vector2() {x = (0 + ((((((sectionNumber + 1) * cornerPointCount) + (sectionNumber) << 1) + index) - 1)) << 3) + 16, y = val_29});
                return;
            }
            
            val_25 = val_19 - 1;
            if(val_18 <= val_25)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_35 = val_25 + (val_25 << 1);
            val_36 = val_36 + (val_35 << 2);
            this.m_points3.set_Item(index:  val_19, value:  new UnityEngine.Vector3() {x = (this.m_is2D + (((((((sectionNumber + 1) * cornerPointCount) + (sectionNumber) << 1) + index) - 1) + ((((((sectionNumber + 1) * cornerPointCount) + (sectionNumber) << 1) + index) - 1)) << 1)) << 2) + 16, y = (this.m_is2D + (((((((sectionNumber + 1) * cornerPointCount) + (sectionNumber) << 1) + index) - 1) + ((((((sectionNumber + 1) * cornerPointCount) + (sectionNumber) << 1) + index) - 1)) << 1)) << 2) + 20, z = (this.m_is2D + (((((((sectionNumber + 1) * cornerPointCount) + (sectionNumber) << 1) + index) - 1) + ((((((sectionNumber + 1) * cornerPointCount) + (sectionNumber) << 1) + index) - 1)) << 1)) << 2) + 24});
        }
        private void Exchange(ref UnityEngine.Vector3 v1, ref UnityEngine.Vector3 v2, int i)
        {
            float val_1 = v1.Item[412184368];
            float val_2 = v1.y.Item[412184368];
            v1.set_Item(index:  412184368, value:  val_2);
            v1.y.set_Item(index:  412184368, value:  val_2);
        }
        public void MakeCircle(UnityEngine.Vector3 origin, float radius)
        {
            float val_3;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            int val_2 = this.GetSegmentNumber();
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3(), xRadius:  val_3, yRadius:  val_1.y, startDegrees:  val_1.z, endDegrees:  null, segments:  val_3, pointRotation:  null, index:  val_3);
        }
        public void MakeCircle(UnityEngine.Vector3 origin, float radius, int segments)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3(), xRadius:  segments, yRadius:  val_1.y, startDegrees:  val_1.z, endDegrees:  null, segments:  segments, pointRotation:  null, index:  segments);
        }
        public void MakeCircle(UnityEngine.Vector3 origin, float radius, int segments, float pointRotation)
        {
            float val_2;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3(), xRadius:  segments, yRadius:  val_1.y, startDegrees:  val_2, endDegrees:  null, segments:  segments, pointRotation:  null, index:  segments);
        }
        public void MakeCircle(UnityEngine.Vector3 origin, float radius, int segments, int index)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3(), xRadius:  segments, yRadius:  val_1.y, startDegrees:  val_1.z, endDegrees:  null, segments:  segments, pointRotation:  null, index:  segments);
        }
        public void MakeCircle(UnityEngine.Vector3 origin, float radius, int segments, float pointRotation, int index)
        {
            float val_2;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3(), xRadius:  val_2, yRadius:  val_1.y, startDegrees:  segments, endDegrees:  null, segments:  segments, pointRotation:  null, index:  segments);
        }
        public void MakeCircle(UnityEngine.Vector3 origin, UnityEngine.Vector3 upVector, float radius)
        {
            float val_2;
            int val_1 = this.GetSegmentNumber();
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3() {x = upVector.x, y = upVector.y, z = upVector.z}, xRadius:  val_2, yRadius:  null, startDegrees:  null, endDegrees:  null, segments:  val_2, pointRotation:  null, index:  val_2);
        }
        public void MakeCircle(UnityEngine.Vector3 origin, UnityEngine.Vector3 upVector, float radius, int segments)
        {
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3() {x = upVector.x, y = upVector.y, z = upVector.z}, xRadius:  segments, yRadius:  null, startDegrees:  null, endDegrees:  null, segments:  segments, pointRotation:  null, index:  segments);
        }
        public void MakeCircle(UnityEngine.Vector3 origin, UnityEngine.Vector3 upVector, float radius, int segments, float pointRotation)
        {
            float val_1;
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3() {x = upVector.x, y = upVector.y, z = upVector.z}, xRadius:  segments, yRadius:  pointRotation, startDegrees:  val_1, endDegrees:  null, segments:  segments, pointRotation:  null, index:  segments);
        }
        public void MakeCircle(UnityEngine.Vector3 origin, UnityEngine.Vector3 upVector, float radius, int segments, int index)
        {
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3() {x = upVector.x, y = upVector.y, z = upVector.z}, xRadius:  segments, yRadius:  null, startDegrees:  null, endDegrees:  null, segments:  segments, pointRotation:  null, index:  segments);
        }
        public void MakeCircle(UnityEngine.Vector3 origin, UnityEngine.Vector3 upVector, float radius, int segments, float pointRotation, int index)
        {
            float val_1;
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3() {x = upVector.x, y = upVector.y, z = upVector.z}, xRadius:  segments, yRadius:  pointRotation, startDegrees:  val_1, endDegrees:  null, segments:  segments, pointRotation:  null, index:  segments);
        }
        public void MakeEllipse(UnityEngine.Vector3 origin, float xRadius, float yRadius)
        {
            float val_3;
            float val_4;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            int val_2 = this.GetSegmentNumber();
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3(), xRadius:  val_3, yRadius:  val_1.y, startDegrees:  val_4, endDegrees:  null, segments:  val_3, pointRotation:  null, index:  val_4);
        }
        public void MakeEllipse(UnityEngine.Vector3 origin, float xRadius, float yRadius, int segments)
        {
            float val_2;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3(), xRadius:  val_2, yRadius:  val_1.y, startDegrees:  segments, endDegrees:  null, segments:  segments, pointRotation:  null, index:  val_2);
        }
        public void MakeEllipse(UnityEngine.Vector3 origin, float xRadius, float yRadius, int segments, int index)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3(), xRadius:  index, yRadius:  val_1.y, startDegrees:  segments, endDegrees:  null, segments:  segments, pointRotation:  null, index:  index);
        }
        public void MakeEllipse(UnityEngine.Vector3 origin, float xRadius, float yRadius, int segments, float pointRotation)
        {
            float val_2;
            float val_3;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3(), xRadius:  val_2, yRadius:  val_1.y, startDegrees:  segments, endDegrees:  null, segments:  segments, pointRotation:  val_3, index:  val_2);
        }
        public void MakeEllipse(UnityEngine.Vector3 origin, UnityEngine.Vector3 upVector, float xRadius, float yRadius)
        {
            float val_2;
            float val_3;
            int val_1 = this.GetSegmentNumber();
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3() {x = upVector.x, y = upVector.y, z = upVector.z}, xRadius:  val_2, yRadius:  yRadius, startDegrees:  val_3, endDegrees:  null, segments:  val_2, pointRotation:  null, index:  val_3);
        }
        public void MakeEllipse(UnityEngine.Vector3 origin, UnityEngine.Vector3 upVector, float xRadius, float yRadius, int segments)
        {
            float val_1;
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3() {x = upVector.x, y = upVector.y, z = upVector.z}, xRadius:  segments, yRadius:  yRadius, startDegrees:  val_1, endDegrees:  null, segments:  segments, pointRotation:  null, index:  val_1);
        }
        public void MakeEllipse(UnityEngine.Vector3 origin, UnityEngine.Vector3 upVector, float xRadius, float yRadius, int segments, int index)
        {
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3() {x = upVector.x, y = upVector.y, z = upVector.z}, xRadius:  index, yRadius:  yRadius, startDegrees:  segments, endDegrees:  null, segments:  segments, pointRotation:  null, index:  index);
        }
        public void MakeEllipse(UnityEngine.Vector3 origin, UnityEngine.Vector3 upVector, float xRadius, float yRadius, int segments, float pointRotation)
        {
            float val_1;
            float val_2;
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3() {x = upVector.x, y = upVector.y, z = upVector.z}, xRadius:  val_1, yRadius:  yRadius, startDegrees:  segments, endDegrees:  null, segments:  segments, pointRotation:  val_2, index:  val_1);
        }
        public void MakeEllipse(UnityEngine.Vector3 origin, UnityEngine.Vector3 upVector, float xRadius, float yRadius, int segments, float pointRotation, int index)
        {
            float val_1;
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3() {x = upVector.x, y = upVector.y, z = upVector.z}, xRadius:  index, yRadius:  yRadius, startDegrees:  segments, endDegrees:  null, segments:  segments, pointRotation:  val_1, index:  index);
        }
        public void MakeArc(UnityEngine.Vector3 origin, float xRadius, float yRadius, float startDegrees, float endDegrees)
        {
            float val_3;
            float val_4;
            float val_5;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            int val_2 = this.GetSegmentNumber();
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3(), xRadius:  val_3, yRadius:  val_1.y, startDegrees:  val_4, endDegrees:  endDegrees, segments:  val_4, pointRotation:  val_5, index:  val_3);
        }
        public void MakeArc(UnityEngine.Vector3 origin, float xRadius, float yRadius, float startDegrees, float endDegrees, int segments)
        {
            float val_2;
            float val_3;
            float val_4;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3(), xRadius:  val_2, yRadius:  val_1.y, startDegrees:  val_3, endDegrees:  endDegrees, segments:  segments, pointRotation:  val_4, index:  val_4);
        }
        public void MakeArc(UnityEngine.Vector3 origin, float xRadius, float yRadius, float startDegrees, float endDegrees, int segments, int index)
        {
            float val_2;
            float val_3;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3(), xRadius:  val_2, yRadius:  val_1.y, startDegrees:  val_3, endDegrees:  endDegrees, segments:  segments, pointRotation:  index, index:  index);
        }
        public void MakeArc(UnityEngine.Vector3 origin, UnityEngine.Vector3 upVector, float xRadius, float yRadius, float startDegrees, float endDegrees)
        {
            float val_2;
            float val_3;
            float val_4;
            int val_1 = this.GetSegmentNumber();
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3() {x = upVector.x, y = upVector.y, z = upVector.z}, xRadius:  val_2, yRadius:  yRadius, startDegrees:  val_3, endDegrees:  endDegrees, segments:  val_3, pointRotation:  val_4, index:  val_2);
        }
        public void MakeArc(UnityEngine.Vector3 origin, UnityEngine.Vector3 upVector, float xRadius, float yRadius, float startDegrees, float endDegrees, int segments)
        {
            float val_1;
            float val_2;
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3() {x = upVector.x, y = upVector.y, z = upVector.z}, xRadius:  val_1, yRadius:  yRadius, startDegrees:  val_2, endDegrees:  endDegrees, segments:  segments, pointRotation:  segments, index:  val_2);
        }
        public void MakeArc(UnityEngine.Vector3 origin, UnityEngine.Vector3 upVector, float xRadius, float yRadius, float startDegrees, float endDegrees, int segments, int index)
        {
            float val_1;
            float val_2;
            this.MakeEllipse(origin:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, upVector:  new UnityEngine.Vector3() {x = upVector.x, y = upVector.y, z = upVector.z}, xRadius:  val_1, yRadius:  yRadius, startDegrees:  val_2, endDegrees:  endDegrees, segments:  segments, pointRotation:  index, index:  index);
        }
        private void MakeEllipse(UnityEngine.Vector3 origin, UnityEngine.Vector3 upVector, float xRadius, float yRadius, float startDegrees, float endDegrees, int segments, float pointRotation, int index)
        {
            int val_1;
            int val_2;
            float val_4;
            var val_5;
            var val_8;
            var val_25;
            float val_26;
            float val_27;
            Vectrosity.LineType val_28;
            float val_29;
            var val_30;
            var val_31;
            if(val_1 <= 2)
            {
                goto label_1;
            }
            
            bool val_3 = this.CheckArrayLength(functionName:  4, segments:  val_1, index:  val_2);
            if(val_3 == false)
            {
                    return;
            }
            
            float val_7 = UnityEngine.Mathf.Repeat(t:  UnityEngine.Mathf.Repeat(t:  val_4, length:  yRadius), length:  yRadius);
            val_25 = val_5;
            if(val_3 == true)
            {
                goto label_3;
            }
            
            val_26 = 360f;
            val_27 = -val_8;
            goto label_4;
            label_1:
            UnityEngine.Debug.LogError(message:  -1610602763);
            return;
            label_3:
            if(val_3 > false)
            {
                    10283200 = 10283204;
            }
            
            float val_23 = 0f;
            val_23 = val_23 - val_4;
            val_26 = val_25 + val_23;
            val_27 = val_4;
            label_4:
            val_28 = this.m_lineType;
            val_29 = upVector.x;
            val_26 = val_26 / (float)val_1;
            float val_9 = val_27 * 0.01745329f;
            float val_10 = val_26 * 0.01745329f;
            if(val_28 != 1)
            {
                goto label_7;
            }
            
            if(this.m_is2D == false)
            {
                goto label_8;
            }
            
            var val_11 = val_1 << 1;
            if(val_11 < 1)
            {
                    return;
            }
            
            var val_24 = 0;
            do
            {
                int val_14 = val_2 + val_24;
                this.m_points2.set_Item(index:  val_14, value:  new UnityEngine.Vector2() {x = 0.5f + origin.x, y = 0.5f + origin.y});
                val_9 = val_10 + val_9;
                this.m_points2.set_Item(index:  val_14 + 1, value:  new UnityEngine.Vector2() {x = 0.5f + origin.x, y = 0.5f + origin.y});
                val_24 = val_24 + 2;
            }
            while(val_24 < val_11);
            
            return;
            label_7:
            val_30 = 0;
            if(val_28 != 1)
            {
                    0 = 1;
            }
            
            val_31 = 1 + val_1;
            if(this.m_is2D != false)
            {
                    if(val_31 >= 1)
            {
                    int val_25 = val_2;
                do
            {
                val_29 = 0.5f + origin.y;
                this.m_points2.set_Item(index:  val_25, value:  new UnityEngine.Vector2() {x = 0.5f + origin.x, y = val_29});
                val_9 = val_10 + val_9;
                val_25 = val_25 + 1;
                val_31 = val_31 - 1;
            }
            while(this.m_points2 != 0);
            
                val_31 = val_31;
                val_28 = this.m_lineType;
                val_30 = val_31;
            }
            
                if(this.m_points2 != 0)
            {
                    return;
            }
            
                if(val_28 == 2)
            {
                    return;
            }
            
                var val_21 = (val_30 - val_31) + val_2;
                if(val_25 <= val_21)
            {
                    var val_26 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_26 = val_26 + (val_21 << 3);
                this.m_points2.set_Item(index:  val_30 + val_2, value:  new UnityEngine.Vector2() {x = (0 + ((((1 + val_1) - (1 + val_1)) + val_2)) << 3) + 16, y = val_29});
            }
        
        }
        public void MakeCurve(UnityEngine.Vector2[] curvePoints)
        {
            this.MakeCurve(curvePoints:  curvePoints, segments:  this.GetSegmentNumber(), index:  0);
        }
        public void MakeCurve(UnityEngine.Vector2[] curvePoints, int segments)
        {
            this.MakeCurve(curvePoints:  curvePoints, segments:  segments, index:  0);
        }
        public void MakeCurve(UnityEngine.Vector2[] curvePoints, int segments, int index)
        {
            if(true == 4)
            {
                    this.MakeCurve(anchor1:  new UnityEngine.Vector3() {x = curvePoints[0], y = curvePoints[1], z = 0f}, control1:  new UnityEngine.Vector3() {x = mem[curvePoints[0x18] + (0)], y = mem[curvePoints[0x18] + (4)], z = 0f}, anchor2:  new UnityEngine.Vector3() {x = mem[curvePoints[0x18] + (8)], y = mem[curvePoints[0x18] + (12)], z = 0f}, control2:  new UnityEngine.Vector3() {x = mem[curvePoints[0x18] + (16)], y = curvePoints[7], z = 0f}, segments:  segments, index:  index);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  -1610602765);
        }
        public void MakeCurve(UnityEngine.Vector3[] curvePoints)
        {
            this.MakeCurve(curvePoints:  curvePoints, segments:  this.GetSegmentNumber(), index:  0);
        }
        public void MakeCurve(UnityEngine.Vector3[] curvePoints, int segments)
        {
            this.MakeCurve(curvePoints:  curvePoints, segments:  segments, index:  0);
        }
        public void MakeCurve(UnityEngine.Vector3[] curvePoints, int segments, int index)
        {
            if(true == 4)
            {
                    this.MakeCurve(anchor1:  new UnityEngine.Vector3() {x = curvePoints[0], y = curvePoints[1], z = curvePoints[2]}, control1:  new UnityEngine.Vector3() {x = mem[curvePoints[0x1C] + (0)], y = mem[curvePoints[0x1C] + (4)], z = mem[curvePoints[0x1C] + (8)]}, anchor2:  new UnityEngine.Vector3() {x = mem[curvePoints[0x28] + (0)], y = mem[curvePoints[0x28] + (4)], z = mem[curvePoints[0x28] + (8)]}, control2:  new UnityEngine.Vector3() {x = curvePoints[9], y = curvePoints[10], z = curvePoints[11]}, segments:  segments, index:  index);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  -1610602765);
        }
        public void MakeCurve(UnityEngine.Vector3 anchor1, UnityEngine.Vector3 control1, UnityEngine.Vector3 anchor2, UnityEngine.Vector3 control2)
        {
            this.MakeCurve(anchor1:  new UnityEngine.Vector3() {x = anchor1.x, y = anchor1.y, z = anchor1.z}, control1:  new UnityEngine.Vector3() {x = control1.x, y = control1.y, z = control1.z}, anchor2:  new UnityEngine.Vector3() {x = anchor2.x, y = anchor2.y, z = anchor2.z}, control2:  new UnityEngine.Vector3() {x = control2.x, y = control2.y, z = control2.z}, segments:  this.GetSegmentNumber(), index:  0);
        }
        public void MakeCurve(UnityEngine.Vector3 anchor1, UnityEngine.Vector3 control1, UnityEngine.Vector3 anchor2, UnityEngine.Vector3 control2, int segments)
        {
            this.MakeCurve(anchor1:  new UnityEngine.Vector3() {x = anchor1.x, y = anchor1.y, z = anchor1.z}, control1:  new UnityEngine.Vector3() {x = control1.x, y = control1.y, z = control1.z}, anchor2:  new UnityEngine.Vector3() {x = anchor2.x, y = anchor2.y, z = anchor2.z}, control2:  new UnityEngine.Vector3() {x = control2.x, y = control2.y, z = control2.z}, segments:  segments, index:  0);
        }
        public void MakeCurve(UnityEngine.Vector3 anchor1, UnityEngine.Vector3 control1, UnityEngine.Vector3 anchor2, UnityEngine.Vector3 control2, int segments, int index)
        {
            float val_3;
            float val_4;
            float val_12;
            float val_15;
            float val_16;
            int val_17;
            float val_18;
            float val_19;
            System.Collections.Generic.List<UnityEngine.Vector2> val_20;
            float val_22;
            var val_23;
            float val_24;
            val_15 = anchor1.y;
            val_16 = 22979122;
            val_17 = index;
            val_18 = anchor2.x;
            val_19 = anchor2.y;
            if((this.CheckArrayLength(functionName:  2, segments:  segments, index:  val_17)) == false)
            {
                    return;
            }
            
            if(this.m_lineType == 1)
            {
                goto label_2;
            }
            
            if(this.m_lineType != 2)
            {
                    segments = segments;
                segments = segments + 1;
            }
            
            if(this.m_is2D == false)
            {
                goto label_3;
            }
            
            if(segments < 1)
            {
                    return;
            }
            
            do
            {
                val_18 = this.m_points2;
                float val_15 = 0f;
                val_15 = val_15 / (float)segments;
                UnityEngine.Vector2 val_2 = Vectrosity.VectorLine.GetBezierPoint(anchor1: ref  new UnityEngine.Vector2() {x = 5.496497E-24f, y = 5.496524E-24f}, control1: ref  new UnityEngine.Vector2() {x = 5.496518E-24f, y = 5.496521E-24f}, anchor2: ref  new UnityEngine.Vector2() {x = control2.x, y = val_15}, control2: ref  new UnityEngine.Vector2(), t:  val_15);
                val_16 = val_3;
                val_15 = val_4;
                val_18.set_Item(index:  val_17 + 0, value:  new UnityEngine.Vector2() {x = val_16, y = val_15});
                val_19 = 0 + 1;
            }
            while(segments != val_19);
            
            return;
            label_2:
            if(this.m_is2D == false)
            {
                goto label_10;
            }
            
            if(segments < 1)
            {
                    return;
            }
            
            do
            {
                float val_16 = 0f;
                val_16 = val_16 / (float)segments;
                UnityEngine.Vector2 val_6 = Vectrosity.VectorLine.GetBezierPoint(anchor1: ref  new UnityEngine.Vector2() {x = 5.496497E-24f, y = 5.496511E-24f}, control1: ref  new UnityEngine.Vector2() {x = 5.496505E-24f, y = 5.496508E-24f}, anchor2: ref  new UnityEngine.Vector2() {x = control2.x, y = val_16}, control2: ref  new UnityEngine.Vector2(), t:  val_16);
                val_20 = this.m_points2;
                if(val_20 == 0)
            {
                    val_20 = this.m_points2;
            }
            
                val_20.set_Item(index:  val_17, value:  new UnityEngine.Vector2() {x = val_3, y = val_4});
                val_15 = 0 + 1;
                float val_17 = (float)val_15;
                val_17 = val_17 / (float)segments;
                UnityEngine.Vector2 val_7 = Vectrosity.VectorLine.GetBezierPoint(anchor1: ref  new UnityEngine.Vector2() {x = 5.496497E-24f, y = 5.496511E-24f}, control1: ref  new UnityEngine.Vector2() {x = 5.496505E-24f, y = 5.496508E-24f}, anchor2: ref  new UnityEngine.Vector2() {x = control2.x, y = val_17}, control2: ref  new UnityEngine.Vector2(), t:  val_17);
                val_18.set_Item(index:  val_17 + 1, value:  new UnityEngine.Vector2() {x = val_3, y = val_4});
                val_17 = val_17 + 2;
            }
            while(segments != val_15);
            
            return;
            label_3:
            if(this.m_points2 < 1)
            {
                    return;
            }
            
            do
            {
                val_18 = this.m_points3;
                float val_18 = 0f;
                val_18 = val_18 / (float)segments;
                UnityEngine.Vector3 val_9 = Vectrosity.VectorLine.GetBezierPoint3D(anchor1: ref  new UnityEngine.Vector3() {x = 5.496497E-24f, y = 5.496538E-24f, z = 5.496534E-24f}, control1: ref  new UnityEngine.Vector3() {x = 5.496529E-24f, y = anchor1.x, z = val_18}, anchor2: ref  new UnityEngine.Vector3(), control2: ref  new UnityEngine.Vector3() {x = this, y = this.m_points2}, t:  val_18);
                val_17 = val_17;
                val_18.set_Item(index:  val_17 + 0, value:  new UnityEngine.Vector3() {x = R8, y = SB, z = ???});
                val_19 = 0 + 1;
            }
            while(this.m_points2 != val_19);
            
            return;
            label_10:
            if(segments < 1)
            {
                    return;
            }
            
            do
            {
                float val_19 = 0f;
                val_19 = val_19 / (float)segments;
                UnityEngine.Vector3 val_11 = Vectrosity.VectorLine.GetBezierPoint3D(anchor1: ref  new UnityEngine.Vector3() {x = 5.496497E-24f, y = 5.496538E-24f, z = 5.496534E-24f}, control1: ref  new UnityEngine.Vector3() {x = 5.496529E-24f, y = anchor1.x, z = val_19}, anchor2: ref  new UnityEngine.Vector3(), control2: ref  new UnityEngine.Vector3() {x = this, y = val_17}, t:  val_19);
                val_22 = val_3;
                val_23 = this.m_points3;
                val_24 = val_4;
                if(this.m_points3 == 0)
            {
                    val_24 = val_24;
                val_23 = this.m_points3;
                val_22 = val_22;
            }
            
                int val_21 = val_17;
                val_23.set_Item(index:  val_21, value:  new UnityEngine.Vector3() {x = val_22, y = val_24, z = val_12});
                val_15 = 0 + 1;
                float val_20 = (float)val_15;
                val_20 = val_20 / (float)segments;
                UnityEngine.Vector3 val_13 = Vectrosity.VectorLine.GetBezierPoint3D(anchor1: ref  new UnityEngine.Vector3() {x = 5.496497E-24f, y = 5.496538E-24f, z = 5.496534E-24f}, control1: ref  new UnityEngine.Vector3() {x = 5.496529E-24f, y = anchor1.x, z = val_20}, anchor2: ref  new UnityEngine.Vector3() {y = val_24, z = val_22}, control2: ref  new UnityEngine.Vector3() {x = this, y = val_17}, t:  val_20);
                val_18.set_Item(index:  val_21 + 1, value:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_12});
                val_21 = val_21 + 2;
                val_17 = val_21;
            }
            while(segments != val_15);
        
        }
        private static UnityEngine.Vector2 GetBezierPoint(ref UnityEngine.Vector2 anchor1, ref UnityEngine.Vector2 control1, ref UnityEngine.Vector2 anchor2, ref UnityEngine.Vector2 control2, float t)
        {
            float val_11 = mem[1152921509318616100];
            var val_9 = mem[1152921509318620180];
            float val_12 = anchor1.y;
            float val_1 = val_9 - val_11;
            float val_10 = control1.x;
            float val_2 = val_10 - val_12;
            val_9 = mem[1152921509318628340] - val_9;
            val_1 = val_1 * 3f;
            val_2 = val_2 * 3f;
            val_10 = anchor2.x - val_10;
            float val_6 = (mem[1152921509318624260] - val_11) - val_1;
            float val_7 = (control1.y - val_12) - val_2;
            float val_8 = (anchor2.y * anchor2.y) * anchor2.y;
            val_6 = val_6 - val_1;
            val_7 = val_7 - val_2;
            val_6 = val_8 * val_6;
            val_7 = val_8 * val_7;
            val_11 = val_11 + val_6;
            val_12 = val_12 + val_7;
            anchor1.x = val_12;
            mem[1152921509318612020] = val_11;
            return new UnityEngine.Vector2() {x = val_12, y = val_2};
        }
        private static UnityEngine.Vector3 GetBezierPoint3D(ref UnityEngine.Vector3 anchor1, ref UnityEngine.Vector3 control1, ref UnityEngine.Vector3 anchor2, ref UnityEngine.Vector3 control2, float t)
        {
            float val_18 = mem[1152921509318810116];
            var val_14 = mem[1152921509318814228];
            float val_17 = anchor1.y;
            float val_1 = val_14 - val_18;
            float val_16 = anchor1.z;
            float val_19 = mem[1152921509318810120];
            var val_15 = mem[1152921509318814232];
            val_1 = val_1 * 3f;
            val_14 = mem[1152921509318822452] - val_14;
            val_15 = mem[1152921509318822456] - val_15;
            float val_5 = (val_16 - val_17) * 3f;
            float val_6 = (val_15 - val_19) * 3f;
            val_16 = control1.y - val_16;
            float val_10 = (mem[1152921509318818340] - val_18) - val_1;
            float val_11 = (control1.x - val_17) - val_5;
            val_10 = val_10 - val_1;
            float val_12 = (mem[1152921509318818344] - val_19) - val_6;
            float val_13 = (control1.z * control1.z) * control1.z;
            val_11 = val_11 - val_5;
            val_12 = val_12 - val_6;
            val_10 = val_13 * val_10;
            val_11 = val_13 * val_11;
            val_12 = val_13 * val_12;
            val_17 = val_17 + val_11;
            val_18 = val_18 + val_10;
            val_19 = val_19 + val_12;
            anchor1.x = val_17;
            mem[1152921509318806004] = val_18;
            mem[1152921509318806008] = val_19;
            return new UnityEngine.Vector3() {x = val_17, y = val_6, z = val_18};
        }
        public void MakeSpline(UnityEngine.Vector2[] splinePoints)
        {
            this.MakeSpline(splinePoints2:  splinePoints, splinePoints3:  null, segments:  this.GetSegmentNumber(), index:  0, loop:  false);
        }
        public void MakeSpline(UnityEngine.Vector2[] splinePoints, bool loop)
        {
            this.MakeSpline(splinePoints2:  splinePoints, splinePoints3:  null, segments:  this.GetSegmentNumber(), index:  0, loop:  loop);
        }
        public void MakeSpline(UnityEngine.Vector2[] splinePoints, int segments)
        {
            this.MakeSpline(splinePoints2:  splinePoints, splinePoints3:  null, segments:  segments, index:  0, loop:  false);
        }
        public void MakeSpline(UnityEngine.Vector2[] splinePoints, int segments, bool loop)
        {
            this.MakeSpline(splinePoints2:  splinePoints, splinePoints3:  null, segments:  segments, index:  0, loop:  loop);
        }
        public void MakeSpline(UnityEngine.Vector2[] splinePoints, int segments, int index)
        {
            this.MakeSpline(splinePoints2:  splinePoints, splinePoints3:  null, segments:  segments, index:  index, loop:  false);
        }
        public void MakeSpline(UnityEngine.Vector2[] splinePoints, int segments, int index, bool loop)
        {
            this.MakeSpline(splinePoints2:  splinePoints, splinePoints3:  null, segments:  segments, index:  index, loop:  loop);
        }
        public void MakeSpline(UnityEngine.Vector3[] splinePoints)
        {
            this.MakeSpline(splinePoints2:  null, splinePoints3:  splinePoints, segments:  this.GetSegmentNumber(), index:  0, loop:  false);
        }
        public void MakeSpline(UnityEngine.Vector3[] splinePoints, bool loop)
        {
            this.MakeSpline(splinePoints2:  null, splinePoints3:  splinePoints, segments:  this.GetSegmentNumber(), index:  0, loop:  loop);
        }
        public void MakeSpline(UnityEngine.Vector3[] splinePoints, int segments)
        {
            this.MakeSpline(splinePoints2:  null, splinePoints3:  splinePoints, segments:  segments, index:  0, loop:  false);
        }
        public void MakeSpline(UnityEngine.Vector3[] splinePoints, int segments, bool loop)
        {
            this.MakeSpline(splinePoints2:  null, splinePoints3:  splinePoints, segments:  segments, index:  0, loop:  loop);
        }
        public void MakeSpline(UnityEngine.Vector3[] splinePoints, int segments, int index)
        {
            this.MakeSpline(splinePoints2:  null, splinePoints3:  splinePoints, segments:  segments, index:  index, loop:  false);
        }
        public void MakeSpline(UnityEngine.Vector3[] splinePoints, int segments, int index, bool loop)
        {
            this.MakeSpline(splinePoints2:  null, splinePoints3:  splinePoints, segments:  segments, index:  index, loop:  loop);
        }
        private void MakeSpline(UnityEngine.Vector2[] splinePoints2, UnityEngine.Vector3[] splinePoints3, int segments, int index, bool loop)
        {
            Vectrosity.VectorLine val_46;
            int val_47;
            int val_48;
            UnityEngine.Vector3[] val_49;
            float val_50;
            System.Collections.Generic.List<UnityEngine.Vector2> val_51;
            var val_52;
            bool val_54;
            var val_55;
            int val_56;
            var val_57;
            var val_58;
            var val_59;
            UnityEngine.Vector3[] val_60;
            var val_61;
            var val_62;
            val_46 = this;
            val_47 = segments;
            val_48 = index;
            if(splinePoints2 != null)
            {
                    val_49 = splinePoints2 + 12;
            }
            else
            {
                    val_49 = splinePoints3 + 12;
            }
            
            UnityEngine.Vector3[] val_40 = val_49;
            if(val_40 <= 1)
            {
                goto label_4;
            }
            
            if(splinePoints2 != null)
            {
                    if(this.m_is2D == false)
            {
                goto label_6;
            }
            
            }
            
            if(splinePoints3 != null)
            {
                    splinePoints3 = this.m_is2D;
            }
            
            if(splinePoints3 == true)
            {
                goto label_7;
            }
            
            if((this.CheckArrayLength(functionName:  3, segments:  val_47, index:  val_48)) == false)
            {
                    return;
            }
            
            val_50 = (float)val_47;
            bool val_2 = loop ^ 1;
            val_40 = val_40 - val_2;
            if(val_40 <= null)
            {
                goto label_9;
            }
            
            int val_3 = val_48 + (val_47 << 1);
            int val_4 = val_48 + 1;
            float val_43 = 0f;
            UnityEngine.Vector3[] val_5 = val_40 - 1;
            val_50 = 1f / val_50;
            float val_6 = val_50 * (float)val_40;
            label_68:
            if(0 != 0)
            {
                    0 = 0 - 1;
            }
            
            if(val_2 == true)
            {
                    val_5 = 0;
            }
            
            if(0 != 0)
            {
                    val_5 = 0;
            }
            
            val_51 = 1;
            if(loop != false)
            {
                    if(2 <= val_5)
            {
                    val_40 = 2;
            }
            
                if(val_2 == false)
            {
                    val_40 = 2 - val_40;
            }
            
                if(2 <= val_5)
            {
                    val_40 = val_40;
            }
            
                val_47 = val_40;
                if(0 >= val_5)
            {
                    val_52 = val_51 - val_40;
            }
            
            }
            else
            {
                    val_52 = val_51;
                if(2 > val_5)
            {
                    val_47 = val_40;
            }
            
            }
            
            val_54 = this.m_is2D;
            if(this.m_lineType != 1)
            {
                goto label_12;
            }
            
            if(val_54 == false)
            {
                goto label_13;
            }
            
            if(val_54 > false)
            {
                goto label_58;
            }
            
            UnityEngine.Vector2[] val_41 = splinePoints2;
            val_41 = val_41 + 16;
            val_41 = val_41 + (val_5 << 3);
            do
            {
                val_51 = this.m_points2;
                val_55 = mem[splinePoints2 + 12];
                val_55 = splinePoints2 + 12;
                if(val_55 <= val_5)
            {
                    val_55 = mem[splinePoints2 + 12];
                val_55 = splinePoints2 + 12;
            }
            
                if(val_55 <= 0)
            {
                    val_55 = mem[splinePoints2 + 12];
                val_55 = splinePoints2 + 12;
            }
            
                if(val_55 <= val_52)
            {
                    val_55 = mem[splinePoints2 + 12];
                val_55 = splinePoints2 + 12;
            }
            
                int val_10 = val_48 + 1;
                UnityEngine.Vector2 val_11 = Vectrosity.VectorLine.GetSplinePoint(p0: ref  new UnityEngine.Vector2() {x = 6.628347E-24f, y = val_41}, p1: ref  new UnityEngine.Vector2() {x = val_41 + 0, y = val_41 + 8}, p2: ref  new UnityEngine.Vector2() {x = val_41 + (val_47 << 3), y = val_43}, p3: ref  new UnityEngine.Vector2() {y = val_48}, t:  val_50);
                val_56 = val_4;
                val_51.set_Item(index:  val_48, value:  new UnityEngine.Vector2() {x = splinePoints3, y = val_56});
                if((val_10 > val_4) && (val_10 < val_5))
            {
                    val_46 = val_46;
                val_51 = val_51;
                if(val_5 <= val_48)
            {
                    var val_42 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_42 = val_42 + (val_48 << 3);
                val_51.set_Item(index:  val_10, value:  new UnityEngine.Vector2() {x = (0 + (index) << 3) + 16, y = val_56});
                val_47 = val_47;
                val_48 = val_48 + 2;
            }
            else
            {
                    val_48 = val_10;
                val_47 = val_47;
                val_46 = val_46;
            }
            
                val_43 = val_6 + val_43;
            }
            while(val_10 <= val_4);
            
            goto label_58;
            label_12:
            if(val_54 == false)
            {
                goto label_30;
            }
            
            if(val_54 > false)
            {
                goto label_58;
            }
            
            UnityEngine.Vector2[] val_44 = splinePoints2;
            val_44 = val_44 + 16;
            val_40 = val_44 + (val_5 << 3);
            do
            {
                val_56 = this.m_points2;
                val_57 = mem[splinePoints2 + 12];
                val_57 = splinePoints2 + 12;
                if(val_57 <= val_5)
            {
                    val_57 = mem[splinePoints2 + 12];
                val_57 = splinePoints2 + 12;
            }
            
                if(val_57 <= 0)
            {
                    val_57 = mem[splinePoints2 + 12];
                val_57 = splinePoints2 + 12;
            }
            
                if(val_57 <= val_52)
            {
                    val_57 = mem[splinePoints2 + 12];
                val_57 = splinePoints2 + 12;
            }
            
                UnityEngine.Vector2 val_16 = Vectrosity.VectorLine.GetSplinePoint(p0: ref  new UnityEngine.Vector2() {x = 6.628347E-24f, y = val_40}, p1: ref  new UnityEngine.Vector2() {x = val_44 + 0, y = val_44 + 8}, p2: ref  new UnityEngine.Vector2() {x = val_44 + (val_47 << 3), y = val_43}, p3: ref  new UnityEngine.Vector2() {y = val_48}, t:  val_50);
                val_48 = val_48 + 1;
                val_56.set_Item(index:  val_48, value:  new UnityEngine.Vector2() {x = splinePoints3, y = val_4});
                val_43 = val_6 + val_43;
                val_47 = val_47;
                val_46 = val_46;
                val_51 = val_48;
            }
            while(val_56 <= 0);
            
            goto label_58;
            label_13:
            if(val_54 > false)
            {
                goto label_58;
            }
            
            UnityEngine.Vector3[] val_17 = val_47 + (val_47 << 1);
            UnityEngine.Vector3[] val_18 = splinePoints3 + 16;
            val_17 = val_18 + (val_17 << 2);
            UnityEngine.Vector3[] val_19 = val_52 + 2;
            val_19 = val_18 + (val_19 << 2);
            UnityEngine.Vector3[] val_45 = val_5;
            val_45 = val_45 + (val_45 << 1);
            val_45 = val_18 + (val_45 << 2);
            do
            {
                val_51 = this.m_points3;
                val_58 = mem[splinePoints3 + 12];
                val_58 = splinePoints3 + 12;
                if(val_58 <= val_5)
            {
                    val_58 = mem[splinePoints3 + 12];
                val_58 = splinePoints3 + 12;
            }
            
                if(val_58 <= 0)
            {
                    val_58 = mem[splinePoints3 + 12];
                val_58 = splinePoints3 + 12;
            }
            
                if(val_58 <= val_52)
            {
                    val_58 = mem[splinePoints3 + 12];
                val_58 = splinePoints3 + 12;
            }
            
                int val_21 = val_48 + 1;
                UnityEngine.Vector3 val_22 = Vectrosity.VectorLine.GetSplinePoint3D(p0: ref  new UnityEngine.Vector3() {x = 6.628347E-24f, y = val_45, z = val_18 + 0}, p1: ref  new UnityEngine.Vector3() {x = val_19, y = val_17, z = val_43}, p2: ref  new UnityEngine.Vector3() {y = val_48, z = val_47}, p3: ref  new UnityEngine.Vector3() {x = val_40, y = val_2, z = val_5}, t:  val_50);
                val_56 = splinePoints3;
                int val_46 = val_48;
                val_51.set_Item(index:  val_46, value:  new UnityEngine.Vector3() {x = val_56, y = val_4, z = splinePoints2});
                if((val_21 > val_4) && (val_21 < val_5))
            {
                    val_46 = val_46;
                val_51 = val_51;
                if(val_5 <= val_48)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_46 = val_46 + ((val_48 + (val_48 << 1)) << 2);
                val_51.set_Item(index:  val_21, value:  new UnityEngine.Vector3() {x = (index + ((index + (index) << 1)) << 2) + 16, y = (index + ((index + (index) << 1)) << 2) + 20, z = (index + ((index + (index) << 1)) << 2) + 24});
                val_48 = val_48 + 2;
                val_47 = val_47;
            }
            else
            {
                    val_48 = val_21;
                val_47 = val_47;
                val_46 = val_46;
            }
            
                val_43 = val_6 + val_43;
            }
            while(val_21 <= val_4);
            
            goto label_58;
            label_30:
            if(val_54 <= false)
            {
                    UnityEngine.Vector3[] val_25 = val_47 + (val_47 << 1);
                UnityEngine.Vector3[] val_26 = splinePoints3 + 16;
                val_25 = val_26 + (val_25 << 2);
                UnityEngine.Vector3[] val_27 = val_52 + 2;
                val_27 = val_26 + (val_27 << 2);
                UnityEngine.Vector3[] val_47 = val_5;
                val_47 = val_47 + (val_47 << 1);
                val_47 = val_26 + (val_47 << 2);
                do
            {
                val_59 = mem[splinePoints3 + 12];
                val_59 = splinePoints3 + 12;
                if(val_59 <= val_5)
            {
                    val_59 = mem[splinePoints3 + 12];
                val_59 = splinePoints3 + 12;
            }
            
                if(val_59 <= 0)
            {
                    val_59 = mem[splinePoints3 + 12];
                val_59 = splinePoints3 + 12;
            }
            
                if(val_59 <= val_52)
            {
                    val_59 = mem[splinePoints3 + 12];
                val_59 = splinePoints3 + 12;
            }
            
                UnityEngine.Vector3 val_29 = Vectrosity.VectorLine.GetSplinePoint3D(p0: ref  new UnityEngine.Vector3() {x = 6.628347E-24f, y = val_47, z = val_26 + 0}, p1: ref  new UnityEngine.Vector3() {x = val_27, y = val_25, z = val_43}, p2: ref  new UnityEngine.Vector3() {y = val_48, z = val_47}, p3: ref  new UnityEngine.Vector3() {x = val_40, y = val_2, z = val_5}, t:  val_50);
                val_56 = val_4;
                val_48 = val_48 + 1;
                this.m_points3.set_Item(index:  val_48, value:  new UnityEngine.Vector3() {x = splinePoints3, y = val_56, z = splinePoints2});
                val_43 = val_6 + val_43;
                val_47 = val_47;
                val_46 = val_46;
                val_51 = val_48;
            }
            while(this.m_points3 <= 0);
            
            }
            
            label_58:
            val_43 = val_43 + (-1f);
            val_60 = val_5;
            if(val_51 != val_40)
            {
                goto label_68;
            }
            
            goto label_69;
            label_4:
            label_77:
            UnityEngine.Debug.LogError(message:  -1610602751);
            return;
            label_6:
            if(((mem[536885944] & true) != 0) || (mem[536885873] != 0))
            {
                goto label_77;
            }
            
            goto label_77;
            label_7:
            if(((mem[536885944] & true) != 0) || (mem[536885873] != 0))
            {
                goto label_77;
            }
            
            goto label_77;
            label_9:
            val_60 = 0f;
            val_47 = 0;
            label_69:
            if(this.m_lineType == 1)
            {
                    val_47 = val_48 + (val_47 << 1);
            }
            
            if(this.m_lineType != 1)
            {
                    val_47 = val_48 + val_47;
                val_47 = val_47 + 1;
            }
            
            if(val_48 >= val_47)
            {
                    return;
            }
            
            if(this.m_is2D != false)
            {
                    val_61 = mem[splinePoints2 + 12];
                val_61 = splinePoints2 + 12;
                if(val_61 <= 0)
            {
                    val_61 = mem[splinePoints2 + 12];
                val_61 = splinePoints2 + 12;
            }
            
                if(val_61 <= val_60)
            {
                    val_61 = mem[splinePoints2 + 12];
                val_61 = splinePoints2 + 12;
            }
            
                val_56 = 0f;
                if(val_61 <= val_56)
            {
                    val_61 = mem[splinePoints2 + 12];
                val_61 = splinePoints2 + 12;
            }
            
                val_60 = (splinePoints2 + 0) + 16;
                val_51 = (splinePoints2 + 0) + 16;
                UnityEngine.Vector2[] val_34 = splinePoints2 + 0;
                val_34 = val_34 + 16;
                UnityEngine.Vector2 val_35 = Vectrosity.VectorLine.GetSplinePoint(p0: ref  new UnityEngine.Vector2() {x = 6.628347E-24f, y = val_60}, p1: ref  new UnityEngine.Vector2() {x = val_51, y = (splinePoints2 + 0) + 16}, p2: ref  new UnityEngine.Vector2() {x = val_34, y = 1f}, p3: ref  new UnityEngine.Vector2() {y = val_48}, t:  val_50);
                val_47 = this.m_points2;
                val_47.set_Item(index:  val_48, value:  new UnityEngine.Vector2() {x = splinePoints3, y = val_4});
                return;
            }
            
            val_56 = this.m_points3;
            val_62 = mem[splinePoints3 + 12];
            val_62 = splinePoints3 + 12;
            if(val_62 <= 0)
            {
                    val_62 = mem[splinePoints3 + 12];
                val_62 = splinePoints3 + 12;
            }
            
            float val_48 = val_60;
            float val_36 = 0 + 0;
            if(val_62 <= val_60)
            {
                    val_62 = mem[splinePoints3 + 12];
                val_62 = splinePoints3 + 12;
            }
            
            UnityEngine.Vector3[] val_50 = splinePoints3;
            val_48 = val_50 + ((val_48 + 0) << 2);
            val_36 = val_50 + (val_36 << 2);
            if(val_62 <= 0)
            {
                    val_62 = mem[splinePoints3 + 12];
                val_62 = splinePoints3 + 12;
            }
            
            var val_49 = 0;
            val_36 = val_36 + 16;
            val_48 = val_48 + 16;
            val_49 = val_49 + 0;
            val_49 = val_50 + (val_49 << 2);
            val_50 = val_49 + 16;
            UnityEngine.Vector3[] val_38 = val_47 + 0;
            val_38 = splinePoints3 + (val_38 << 2);
            val_38 = val_38 + 16;
            UnityEngine.Vector3 val_39 = Vectrosity.VectorLine.GetSplinePoint3D(p0: ref  new UnityEngine.Vector3() {x = 6.628347E-24f, y = val_36, z = val_48}, p1: ref  new UnityEngine.Vector3() {x = val_50, y = val_38, z = 1f}, p2: ref  new UnityEngine.Vector3() {y = val_48, z = val_47}, p3: ref  new UnityEngine.Vector3() {x = val_40, y = val_2, z = val_5}, t:  val_50);
            val_56.set_Item(index:  val_48, value:  new UnityEngine.Vector3() {x = splinePoints3, y = val_47, z = val_51});
        }
        private static UnityEngine.Vector2 GetSplinePoint(ref UnityEngine.Vector2 p0, ref UnityEngine.Vector2 p1, ref UnityEngine.Vector2 p2, ref UnityEngine.Vector2 p3, float t)
        {
            UnityEngine.Vector4 val_1 = UnityEngine.Vector4.zero;
            UnityEngine.Vector4 val_2 = UnityEngine.Vector4.zero;
            float val_30 = p0.y;
            val_30 = p1.x - val_30;
            float val_3 = val_30 * val_30;
            val_2.x = val_2.x + val_2.y;
            float val_31 = p1.x;
            val_31 = p1.y - val_31;
            float val_4 = val_31 * val_31;
            val_2.x = val_2.x + val_2.y;
            float val_32 = p1.y;
            val_32 = p2.x - val_32;
            float val_5 = val_32 * val_32;
            val_2.x = val_2.x + val_2.y;
            if(mem[536896813] < 0)
            {
                    val_2.x = 1f;
            }
            
            if(mem[536896813] < 0)
            {
                    val_2.x = 1f;
            }
            
            if(mem[536896813] < 0)
            {
                    val_2.x = 1f;
            }
            
            var val_33 = mem[1152921509321557796];
            float val_6 = p1.x - p0.y;
            float val_34 = 2f;
            var val_36 = mem[1152921509321565956];
            float val_7 = p1.y - p0.y;
            val_33 = val_36 - val_33;
            float val_9 = p1.y - p1.x;
            float val_10 = val_36 - mem[1152921509321561876];
            val_6 = val_6 / val_2.x;
            val_7 = val_7 / val_34;
            val_34 = val_33 / val_34;
            float val_35 = 2f;
            val_9 = val_9 / val_2.x;
            val_10 = val_10 / val_2.x;
            val_35 = (mem[1152921509321570036] - mem[1152921509321561876]) / val_35;
            val_6 = val_6 - val_7;
            val_34 = ((mem[1152921509321561876] - val_33) / val_2.x) - val_34;
            float val_17 = (mem[1152921509321570036] - val_36) / val_2.x;
            float val_18 = (p2.x - p1.y) / val_2.x;
            val_6 = val_9 + val_6;
            val_34 = val_10 + val_34;
            val_9 = val_9 - ((p2.x - p1.x) / val_35);
            val_10 = val_10 - val_35;
            val_6 = val_2.x * val_6;
            val_34 = val_2.x * val_34;
            val_36 = val_36 + val_36;
            val_18 = val_18 + val_9;
            val_17 = val_17 + val_10;
            float val_24 = val_6 + val_6;
            float val_25 = val_34 + val_34;
            float val_26 = (p1.x + p1.x) - (p1.y + p1.y);
            val_36 = (mem[1152921509321561876] + mem[1152921509321561876]) - val_36;
            val_18 = val_2.x * val_18;
            val_17 = val_2.x * val_17;
            val_24 = (p1.y * 3f) - val_24;
            val_25 = (val_36 * 3f) - val_25;
            val_26 = val_26 + val_6;
            val_36 = val_36 + val_34;
            val_24 = val_24 - val_18;
            float val_28 = val_25 - val_17;
            val_18 = val_26 + val_18;
            float val_29 = (p2.y * p2.y) * p2.y;
            val_17 = val_36 + val_17;
            p0.x = p1.x;
            mem[1152921509321553716] = mem[1152921509321561876];
            return new UnityEngine.Vector2() {x = mem[1152921509321561876], y = val_26};
        }
        private static UnityEngine.Vector3 GetSplinePoint3D(ref UnityEngine.Vector3 p0, ref UnityEngine.Vector3 p1, ref UnityEngine.Vector3 p2, ref UnityEngine.Vector3 p3, float t)
        {
            UnityEngine.Vector4 val_1 = UnityEngine.Vector4.zero;
            UnityEngine.Vector4 val_2 = UnityEngine.Vector4.zero;
            UnityEngine.Vector4 val_3 = UnityEngine.Vector4.zero;
            var val_43 = mem[1152921509321751812];
            float val_44 = p0.y;
            val_43 = mem[1152921509321755924] - val_43;
            val_44 = p0.z - val_44;
            double val_4 = val_43 * val_43;
            var val_45 = mem[1152921509321755924];
            float val_46 = p0.z;
            val_45 = mem[1152921509321760036] - val_45;
            val_46 = p1.x - val_46;
            double val_6 = val_45 * val_45;
            var val_47 = mem[1152921509321760036];
            float val_48 = p1.x;
            val_47 = mem[1152921509321764148] - val_47;
            val_48 = p1.y - val_48;
            double val_8 = val_47 * val_47;
            if(mem[536896813] < 0)
            {
                    p1.x + val_3.w = 1f;
            }
            
            float val_52 = p1.x;
            if(mem[536896813] < 0)
            {
                    p0.z + val_3.w = 1f;
            }
            
            if(mem[536896813] < 0)
            {
                    p1.y + val_3.w = 1f;
            }
            
            var val_49 = mem[1152921509321751812];
            float val_10 = p0.z - p0.y;
            var val_53 = mem[1152921509321760036];
            float val_11 = val_52 - p0.y;
            float val_51 = 2f;
            float val_12 = val_53 - val_49;
            var val_50 = mem[1152921509321751816];
            val_49 = mem[1152921509321755924] - val_49;
            var val_54 = mem[1152921509321760040];
            float val_13 = val_52 - p0.z;
            val_10 = val_10 / (p0.z + val_3.w);
            val_11 = val_11 / val_51;
            val_12 = val_12 / val_51;
            val_49 = val_49 / (p0.z + val_3.w);
            val_50 = mem[1152921509321755928] - val_50;
            float val_15 = val_53 - mem[1152921509321755924];
            val_51 = (val_54 - val_50) / val_51;
            val_50 = val_50 / (p0.z + val_3.w);
            val_11 = val_10 - val_11;
            float val_17 = mem[1152921509321764148] - val_53;
            float val_19 = mem[1152921509321764152] - mem[1152921509321755928];
            val_13 = val_13 / (p1.x + val_3.w);
            val_49 = val_49 - val_12;
            float val_20 = mem[1152921509321764152] - val_54;
            val_15 = val_15 / (p1.x + val_3.w);
            float val_22 = (val_54 - mem[1152921509321755928]) / (p1.x + val_3.w);
            val_19 = val_19 / 2f;
            val_51 = val_50 - val_51;
            val_17 = val_17 / (p1.y + val_3.w);
            float val_26 = (p1.y - val_52) / (p1.y + val_3.w);
            val_20 = val_20 / (p1.y + val_3.w);
            val_11 = val_13 + val_11;
            val_49 = val_15 + val_49;
            val_51 = val_22 + val_51;
            val_15 = val_15 - ((mem[1152921509321764148] - mem[1152921509321755924]) / 2f);
            val_13 = val_13 - ((p1.y - p0.z) / 2f);
            val_19 = val_22 - val_19;
            val_11 = (p1.x + val_3.w) * val_11;
            val_49 = (p1.x + val_3.w) * val_49;
            val_51 = (p1.x + val_3.w) * val_51;
            val_17 = val_17 + val_15;
            val_52 = val_52 + val_52;
            val_53 = val_53 + val_53;
            val_54 = val_54 + val_54;
            val_26 = val_26 + val_13;
            val_20 = val_20 + val_19;
            float val_33 = val_11 + val_11;
            float val_34 = val_49 + val_49;
            val_53 = (mem[1152921509321755924] + mem[1152921509321755924]) - val_53;
            val_54 = (mem[1152921509321755928] + mem[1152921509321755928]) - val_54;
            val_52 = (p0.z + p0.z) - val_52;
            val_26 = (p1.x + val_3.w) * val_26;
            val_33 = (val_52 * 3f) - val_33;
            val_17 = (p1.x + val_3.w) * val_17;
            val_34 = (val_53 * 3f) - val_34;
            val_20 = (p1.x + val_3.w) * val_20;
            val_53 = val_53 + val_49;
            float val_38 = val_54 + val_51;
            val_33 = val_33 - val_26;
            float val_40 = val_34 - val_17;
            float val_41 = ((val_54 * 3f) - (val_51 + val_51)) - val_20;
            val_53 = val_53 + val_17;
            val_26 = (val_52 + val_11) + val_26;
            val_38 = val_38 + val_20;
            float val_42 = (p1.z * p1.z) * p1.z;
            p0.x = p0.z;
            mem[1152921509321747700] = mem[1152921509321755924];
            mem[1152921509321747704] = mem[1152921509321755928];
            return new UnityEngine.Vector3() {x = mem[1152921509321755924], y = val_17, z = mem[1152921509321755928]};
        }
        private static float VectorDistanceSquared(ref UnityEngine.Vector2 p, ref UnityEngine.Vector2 q)
        {
            float val_3 = p.x;
            val_3 = p.y - val_3;
            float val_1 = val_3 * val_3;
            return (float)S0 + S1;
        }
        private static float VectorDistanceSquared(ref UnityEngine.Vector3 p, ref UnityEngine.Vector3 q)
        {
            var val_3 = mem[1152921509322077588];
            float val_4 = p.x;
            val_3 = mem[1152921509322081636] - val_3;
            val_4 = p.y - val_4;
            double val_1 = val_3 * val_3;
            return (float)p.y + S3;
        }
        private static void InitNonuniformCatmullRom(float x0, float x1, float x2, float x3, float dt0, float dt1, float dt2, ref UnityEngine.Vector4 p)
        {
            float val_1;
            float val_2;
            var val_3;
            uint val_15 = 420415984;
            float val_20 = val_1;
            float val_17 = val_2;
            uint val_18 = 420424176;
            uint val_19 = 420420080;
            float val_6 = val_17 + val_20;
            val_15 = val_19 - val_15;
            mem2[0] = p.y;
            uint val_16 = 420428272;
            val_16 = val_16 - val_18;
            val_6 = (val_18 - val_15) / val_6;
            val_17 = val_15 / val_17;
            float val_10 = (val_18 - val_19) / val_20;
            val_17 = val_17 - val_6;
            val_16 = val_16 / val_3;
            val_17 = val_10 + val_17;
            val_10 = val_10 - ((val_16 - val_19) / (val_20 + val_3));
            float val_12 = val_18 + val_18;
            val_17 = val_17 * val_20;
            val_18 = val_18 * 3f;
            val_10 = val_16 + val_10;
            val_12 = (val_19 + val_19) - val_12;
            mem2[0] = val_17;
            val_19 = val_17 + val_17;
            val_20 = val_10 * val_20;
            float val_14 = val_12 + val_17;
            val_18 = val_18 - val_19;
            val_14 = val_14 + val_20;
            val_20 = val_18 - val_20;
            mem2[0] = val_20;
            mem2[0] = val_14;
        }
        private static float EvalCubicPoly(ref UnityEngine.Vector4 p, float t)
        {
            uint val_2 = 420564608;
            val_2 = (val_2 * val_2) * val_2;
            return (float)val_2;
        }
        public void MakeText(string text, UnityEngine.Vector3 startPos, float size)
        {
            float val_1;
            this.MakeText(text:  text, startPos:  new UnityEngine.Vector3() {x = startPos.x, y = startPos.y, z = startPos.z}, size:  val_1, charSpacing:  null, lineSpacing:  null, uppercaseOnly:  val_1);
        }
        public void MakeText(string text, UnityEngine.Vector3 startPos, float size, bool uppercaseOnly)
        {
            this.MakeText(text:  text, startPos:  new UnityEngine.Vector3() {x = startPos.x, y = startPos.y, z = startPos.z}, size:  uppercaseOnly, charSpacing:  null, lineSpacing:  null, uppercaseOnly:  uppercaseOnly);
        }
        public void MakeText(string text, UnityEngine.Vector3 startPos, float size, float charSpacing, float lineSpacing)
        {
            float val_1;
            float val_2;
            this.MakeText(text:  text, startPos:  new UnityEngine.Vector3() {x = startPos.x, y = startPos.y, z = startPos.z}, size:  val_1, charSpacing:  charSpacing, lineSpacing:  val_2, uppercaseOnly:  val_1);
        }
        public void MakeText(string text, UnityEngine.Vector3 startPos, float size, float charSpacing, float lineSpacing, bool uppercaseOnly)
        {
            var val_1;
            var val_2;
            var val_3;
            Vectrosity.VectorLine val_29;
            float val_30;
            float val_31;
            string val_32;
            var val_33;
            float val_34;
            var val_35;
            var val_36;
            var val_37;
            val_29 = this;
            val_30 = startPos.y;
            val_31 = startPos.x;
            val_32 = text;
            val_33 = 0;
            if(this.m_lineType != 1)
            {
                goto label_1;
            }
            
            var val_29 = val_1;
            val_29 = 0;
            val_29 = val_29 ^ 1;
            val_34 = startPos.z;
            goto label_2;
            label_13:
            int val_5 = System.Convert.ToInt32(value:  val_32.Chars[0]);
            if(val_5 > 256)
            {
                goto label_5;
            }
            
            if(val_29 == 0)
            {
                    val_5 = val_5 - 32;
            }
            
            if((val_5 - 97) > 25)
            {
                    val_5 = val_5;
            }
            
            UnityEngine.Vector2[][] val_7 = Vectrosity.VectorChar.data;
            int val_8 = val_5 + (val_5 << 2);
            if(((val_5 + (val_5) << 2) + 16) != 0)
            {
                    UnityEngine.Vector2[][] val_9 = Vectrosity.VectorChar.data;
                var val_10 = ((val_5 + (val_5) << 2) + 16) + (val_5 << 2);
                val_29 = (((val_5 + (val_5) << 2) + 16 + (val_5) << 2) + 16 + 12) + val_29;
            }
            
            val_32 = val_32;
            val_35 = 1;
            label_2:
            if(val_35 < (text + 8))
            {
                goto label_13;
            }
            
            if(val_29 != this.pointsCount)
            {
                    this.Resize(newCount:  val_29);
            }
            
            float val_30 = val_34;
            val_36 = 0;
            val_30 = val_30 + 0f;
            uint val_31 = 0;
            uint val_36 = 0;
            goto label_15;
            label_45:
            int val_13 = System.Convert.ToInt32(value:  val_32.Chars[0]);
            if(val_13 == 32)
            {
                goto label_23;
            }
            
            if(val_13 != 10)
            {
                goto label_19;
            }
            
            val_31 = val_31 - val_2;
            goto label_20;
            label_19:
            if(val_29 == 0)
            {
                    val_13 = val_13 - 32;
            }
            
            if((val_13 - 97) > 25)
            {
                    val_30 = val_13;
            }
            
            UnityEngine.Vector2[][] val_15 = Vectrosity.VectorChar.data;
            int val_16 = val_13 + (val_30 << 2);
            if(((val_13 + (val_13) << 2) + 16) == 0)
            {
                goto label_23;
            }
            
            UnityEngine.Vector2[][] val_17 = Vectrosity.VectorChar.data;
            var val_18 = ((val_13 + (val_13) << 2) + 16) + (val_30 << 2);
            val_32 = val_32;
            if(mem[1152921509322839840] == false)
            {
                goto label_27;
            }
            
            if((((val_13 + (val_13) << 2) + 16 + (val_13) << 2) + 16 + 12) < 1)
            {
                goto label_37;
            }
            
            var val_34 = 16;
            do
            {
                val_31 = mem[1152921509322839844];
                UnityEngine.Vector2[][] val_19 = Vectrosity.VectorChar.data;
                bool val_20 = mem[1152921509322839840] + (val_30 << 2);
                val_34 = 0 + 0;
                var val_32 = ((mem[1152921509322839840] + (val_13) << 2) + 16 + 16) + 4;
                var val_33 = ((mem[1152921509322839840] + (val_13) << 2) + 16) + val_34;
                val_32 = val_31 + val_32;
                val_33 = val_36 + val_33;
                val_31.set_Item(index:  val_34, value:  new UnityEngine.Vector2() {x = val_31, y = val_30});
                val_29 = 0 + 1;
                val_34 = val_34 + 8;
            }
            while((((val_13 + (val_13) << 2) + 16 + (val_13) << 2) + 16 + 12) != val_29);
            
            val_32 = val_32;
            var val_35 = 0;
            val_35 = val_35 + (((val_13 + (val_13) << 2) + 16 + (val_13) << 2) + 16 + 12);
            goto label_35;
            label_23:
            val_36 = val_36 + val_3;
            label_20:
            val_32 = val_32;
            goto label_36;
            label_27:
            if((((val_13 + (val_13) << 2) + 16 + (val_13) << 2) + 16 + 12) < 1)
            {
                goto label_37;
            }
            
            do
            {
                val_29 = mem[1152921509322839848];
                UnityEngine.Vector2[][] val_22 = Vectrosity.VectorChar.data;
                Vectrosity.VectorLine val_23 = val_29 + (val_30 << 2);
                var val_37 = ((this + (val_13) << 2) + 16 + 16) + 4;
                var val_38 = ((this + (val_13) << 2) + 16) + 16;
                val_37 = val_31 + val_37;
                val_38 = val_36 + val_38;
                val_29.set_Item(index:  val_35 + 0, value:  new UnityEngine.Vector3() {x = val_31, y = val_30, z = val_30});
                val_31 = 0 + 1;
                val_34 = 16 + 8;
            }
            while((((val_13 + (val_13) << 2) + 16 + (val_13) << 2) + 16 + 12) != val_31);
            
            var val_39 = val_35;
            val_32 = val_32;
            val_39 = val_39 + (((val_13 + (val_13) << 2) + 16 + (val_13) << 2) + 16 + 12);
            label_35:
            label_37:
            val_36 = val_36 + val_3;
            label_36:
            val_36 = val_36 + 1;
            label_15:
            if(val_36 < (text + 8))
            {
                goto label_45;
            }
            
            return;
            label_1:
            val_37 = -1610602745;
            goto label_49;
            label_5:
            string val_27 = val_32.Chars[0].ToString();
            string val_28 = -1610602743(-1610602743) + 421013478 + -1610612081(-1610612081);
            val_37 = -1610602743;
            label_49:
            UnityEngine.Debug.LogError(message:  -1610602743);
        }
        public void MakeWireframe(UnityEngine.Mesh mesh)
        {
            var val_14;
            Vectrosity.VectorLine val_13;
            var val_14;
            float val_15;
            System.Collections.Generic.List<UnityEngine.Vector3> val_16;
            UnityEngine.Mesh val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            float val_22;
            float val_23;
            var val_24;
            Vectrosity.VectorLine val_25;
            int val_26;
            val_13 = this;
            val_13 = val_13;
            if(mem[1152921509322964184] != 1)
            {
                goto label_1;
            }
            
            if(mem[1152921509322964128] == false)
            {
                goto label_2;
            }
            
            string val_1 = -1610602741(-1610602741) + mem[1152921509322964164] + -1610612233(-1610612233);
            val_14 = -1610602741;
            goto label_5;
            label_1:
            label_13:
            val_14 = -1610602737;
            label_5:
            UnityEngine.Debug.LogError(message:  -1610602737);
            return;
            label_2:
            if(mesh != 0)
            {
                goto label_10;
            }
            
            if(((mem[536885944] & true) != 0) || (mem[536885873] != 0))
            {
                goto label_13;
            }
            
            goto label_13;
            label_10:
            UnityEngine.Vector3[] val_3 = mesh.vertices;
            val_15 = mesh;
            536874525 = new System.Collections.Generic.Dictionary<Vectrosity.Vector3Pair, System.Boolean>();
            val_16 = 536878517;
            val_16 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            val_17 = mesh;
            val_18 = 0;
            goto label_15;
            label_31:
            if(val_17 != 0)
            {
                    val_19 = -1073711421;
                System.Int32[] val_6 = mesh.GetIndices(submesh:  -1073711421);
                val_20 = mesh;
            }
            else
            {
                    val_19 = -1073711421;
                System.Int32[] val_7 = 0.GetIndices(submesh:  -1073711421);
                val_20 = 0;
            }
            
            val_21 = 0;
            UnityEngine.MeshTopology val_8 = mesh.GetTopology(submesh:  -1073711421);
            if(mesh == 0)
            {
                    4 = 3;
            }
            
            goto label_18;
            label_27:
            var val_16 = val_21;
            label_19:
            var val_10 = val_16 + 0;
            var val_11 = ((val_20 + 16) + 0) + (((val_20 + 16) + 0) << 1);
            val_22 = 0 + 1;
            val_11 = R6 + (val_11 << 2);
            val_23 = mem[(R6 + (((val_20 + 16) + 0 + ((val_20 + 16) + 0) << 1)) << 2) + 16];
            val_23 = (R6 + (((val_20 + 16) + 0 + ((val_20 + 16) + 0) << 1)) << 2) + 16;
            val_16 = 3 + val_16;
            var val_12 = val_20 + (val_16 << 2);
            var val_13 = ((val_20 + ((3 + val_21)) << 2) + 16) + (((val_20 + ((3 + val_21)) << 2) + 16) << 1);
            val_24 = R6;
            val_13 = R6 + (val_13 << 2);
            val_16 = val_16;
            Vectrosity.VectorLine.CheckPairPoints(pairs:  536874525, p1:  new UnityEngine.Vector3() {x = val_23, y = (R6 + (((val_20 + 16) + 0 + ((val_20 + 16) + 0) << 1)) << 2) + 20, z = (R6 + (((val_20 + 16) + 0 + ((val_20 + 16) + 0) << 1)) << 2) + 24}, p2:  new UnityEngine.Vector3() {x = (R6 + (((val_20 + ((3 + val_21)) << 2) + 16 + ((val_20 + ((3 + val_21)) << 2) + 16) << 1)) << 2) + 16, y = (R6 + (((val_20 + ((3 + val_21)) << 2) + 16 + ((val_20 + ((3 + val_21)) << 2) + 16) << 1)) << 2) + 20, z = (R6 + (((val_20 + ((3 + val_21)) << 2) + 16 + ((val_20 + ((3 + val_21)) << 2) + 16) << 1)) << 2) + 24}, linePoints:  val_16);
            if(val_22 < 3)
            {
                goto label_27;
            }
            
            val_15 = val_24;
            var val_17 = val_20 + 16;
            val_17 = val_17 + 0;
            val_20 = val_20;
            val_21 = 3;
            label_18:
            if(val_21 < 0)
            {
                goto label_19;
            }
            
            val_17 = mesh;
            val_18 = val_14 + 1;
            label_15:
            val_14 = val_18;
            if(val_17 == 0)
            {
                    val_17 = mesh;
            }
            
            if(val_14 < val_17.subMeshCount)
            {
                goto label_31;
            }
            
            val_25 = val_13;
            val_26 = mem[536878529];
            if(val_26 != mem[1152921509322964140])
            {
                    this.Resize(newCount:  val_26);
                val_25 = val_13;
                val_26 = mem[1152921509322964140];
            }
            
            if(val_26 < 1)
            {
                    return;
            }
            
            var val_19 = 0;
            val_22 = 4.02206E-38f;
            do
            {
                if(mem[536878529] <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_18 = mem[536878525];
                val_18 = val_18 + 0;
                val_15 = mem[(mem[536878525] + 0) + 16];
                val_15 = (mem[536878525] + 0) + 16;
                val_23 = mem[(mem[536878525] + 0) + 20];
                val_23 = (mem[536878525] + 0) + 20;
                mem[1152921509322964136].set_Item(index:  0, value:  new UnityEngine.Vector3() {x = val_15, y = val_23, z = (mem[536878525] + 0) + 24});
                val_24 = 0 + 12;
                val_16 = val_16;
                val_19 = val_19 + 1;
            }
            while(val_19 < mem[1152921509322964140]);
        
        }
        private static void CheckPairPoints(System.Collections.Generic.Dictionary<Vectrosity.Vector3Pair, bool> pairs, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, System.Collections.Generic.List<UnityEngine.Vector3> linePoints)
        {
            System.Collections.Generic.List<UnityEngine.Vector3> val_3;
            float val_4;
            val_3 = pairs;
            val_4 = 22726648;
            if((val_3.ContainsKey(key:  new Vectrosity.Vector3Pair() {p1 = new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z}, p2 = new UnityEngine.Vector3() {x = p2.x, y = p2.y, z = p2.z}})) == true)
            {
                    return;
            }
            
            if((val_3.ContainsKey(key:  new Vectrosity.Vector3Pair() {p1 = new UnityEngine.Vector3() {x = p2.x, y = p2.y, z = p2.z}, p2 = new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z}})) == true)
            {
                    return;
            }
            
            if(val_3 != 0)
            {
                    val_4 = p2.x;
                val_3.set_Item(key:  new Vectrosity.Vector3Pair() {p1 = new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z}, p2 = new UnityEngine.Vector3() {x = val_4, y = p2.y, z = p2.z}}, value:  true);
            }
            else
            {
                    val_4 = p2.x;
                0.set_Item(key:  new Vectrosity.Vector3Pair() {p1 = new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z}, p2 = new UnityEngine.Vector3() {x = val_4, y = p2.y, z = p2.z}}, value:  true);
            }
            
            val_3.set_Item(key:  new Vectrosity.Vector3Pair() {p1 = new UnityEngine.Vector3() {x = val_4, y = p2.y, z = p2.z}, p2 = new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z}}, value:  true);
            val_3 = linePoints;
            if(val_3 != 0)
            {
                    val_3.Add(item:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z});
            }
            else
            {
                    0.Add(item:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z});
            }
            
            val_3.Add(item:  new UnityEngine.Vector3() {x = val_4, y = p2.y, z = p2.z});
        }
        public void MakeCube(UnityEngine.Vector3 position, float xSize, float ySize, float zSize)
        {
            float val_1;
            float val_2;
            this.MakeCube(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, xSize:  val_1, ySize:  ySize, zSize:  val_2, index:  val_1);
        }
        public void MakeCube(UnityEngine.Vector3 position, float xSize, float ySize, float zSize, int index)
        {
            int val_1;
            var val_2;
            var val_3;
            var val_38;
            var val_39;
            float val_40;
            var val_38 = val_2;
            var val_39 = val_3;
            val_38 = position.y;
            if(this.m_lineType != 1)
            {
                goto label_1;
            }
            
            if(this.m_is2D == false)
            {
                goto label_2;
            }
            
            label_53:
            string val_4 = -1610602771(-1610602771) + this.m_name + -1610612233(-1610612233);
            val_39 = -1610602771;
            goto label_5;
            label_1:
            val_39 = -1610602769;
            label_5:
            UnityEngine.Debug.LogError(message:  -1610602769);
            return;
            label_2:
            if((val_1 + 24) > this.pointsCount)
            {
                    if(val_1 == 0)
            {
                goto label_53;
            }
            
                mem[536882417] = -1610609713;
                string val_7 = ToString();
                mem[536882421] = ;
                val_40 = -1610612265;
                mem[536882425] = val_40;
                mem[536882429] = this.m_name;
                mem[536882433] = -1610612241;
                string val_8 = +536882401;
                UnityEngine.Debug.LogError(message:  536882401);
                return;
            }
            
            float val_40 = 0.5f;
            int val_9 = index * val_40;
            val_38 = val_38 * val_40;
            val_39 = val_39 * val_40;
            float val_10 = position.x - val_9;
            val_40 = position.z - val_38;
            float val_11 = val_39 + val_38;
            this.m_points3.set_Item(index:  val_1, value:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_40});
            int val_12 = val_9 + position.x;
            this.m_points3.set_Item(index:  val_1 + 1, value:  new UnityEngine.Vector3() {x = val_12, y = val_11, z = val_40});
            this.m_points3.set_Item(index:  val_1 + 2, value:  new UnityEngine.Vector3() {x = val_12, y = val_11, z = val_40});
            float val_15 = val_38 + position.z;
            this.m_points3.set_Item(index:  val_1 + 3, value:  new UnityEngine.Vector3() {x = val_12, y = val_11, z = val_15});
            this.m_points3.set_Item(index:  val_1 + 4, value:  new UnityEngine.Vector3() {x = val_12, y = val_11, z = val_15});
            this.m_points3.set_Item(index:  val_1 + 5, value:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_15});
            this.m_points3.set_Item(index:  val_1 + 6, value:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_15});
            this.m_points3.set_Item(index:  val_1 + 7, value:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_40});
            float val_21 = val_38 - val_39;
            this.m_points3.set_Item(index:  val_1 + 8, value:  new UnityEngine.Vector3() {x = val_10, y = val_21, z = val_40});
            this.m_points3.set_Item(index:  val_1 + 9, value:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_40});
            this.m_points3.set_Item(index:  val_1 + 10, value:  new UnityEngine.Vector3() {x = val_12, y = val_21, z = val_40});
            this.m_points3.set_Item(index:  val_1 + 11, value:  new UnityEngine.Vector3() {x = val_12, y = val_11, z = val_40});
            this.m_points3.set_Item(index:  val_1 + 12, value:  new UnityEngine.Vector3() {x = val_10, y = val_21, z = val_15});
            this.m_points3.set_Item(index:  val_1 + 13, value:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_15});
            this.m_points3.set_Item(index:  val_1 + 14, value:  new UnityEngine.Vector3() {x = val_12, y = val_21, z = val_15});
            this.m_points3.set_Item(index:  val_1 + 15, value:  new UnityEngine.Vector3() {x = val_12, y = val_11, z = val_15});
            val_38 = 22739796;
            this.m_points3.set_Item(index:  val_1 + 16, value:  new UnityEngine.Vector3() {x = val_10, y = val_21, z = val_40});
            this.m_points3.set_Item(index:  val_1 + 17, value:  new UnityEngine.Vector3() {x = val_12, y = val_21, z = val_40});
            this.m_points3.set_Item(index:  val_1 + 18, value:  new UnityEngine.Vector3() {x = val_12, y = val_21, z = val_40});
            this.m_points3.set_Item(index:  val_1 + 19, value:  new UnityEngine.Vector3() {x = val_12, y = val_21, z = val_15});
            this.m_points3.set_Item(index:  val_1 + 20, value:  new UnityEngine.Vector3() {x = val_12, y = val_21, z = val_15});
            val_40 = val_10;
            this.m_points3.set_Item(index:  val_1 + 21, value:  new UnityEngine.Vector3() {x = val_40, y = val_21, z = val_15});
            this.m_points3.set_Item(index:  val_1 + 22, value:  new UnityEngine.Vector3() {x = val_40, y = val_21, z = val_15});
            this.m_points3.set_Item(index:  val_1 + 23, value:  new UnityEngine.Vector3() {x = val_40, y = val_21, z = val_40});
        }
        private static VectorLine()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            mem2[0] = 0;
            mem[536882417] = -1610602719;
            mem[536882421] = -1610602691;
            mem[536882425] = -1610606481;
            mem[536882429] = -1610606477;
            mem[536882433] = -1610606479;
            mem2[0] = 536882401;
        }
    
    }

}
