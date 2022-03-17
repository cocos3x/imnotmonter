using UnityEngine;

namespace WrappingRopeLibrary.Scripts
{
    public class RopeBase : MonoBehaviour, ISerializationCallbackReceiver
    {
        // Fields
        private WrappingRopeLibrary.Enums.BodyType _body;
        private UnityEngine.Material _material;
        private UnityEngine.GameObject _frontEnd;
        private UnityEngine.GameObject _backEnd;
        public float Threshold;
        public float WrapDistance;
        private UnityEngine.GameObject _pieceInstance;
        private UnityEngine.GameObject BendInstance;
        private float _width;
        public WrappingRopeLibrary.Enums.Axis ExtendAxis;
        public WrappingRopeLibrary.Enums.TexturingMode TexturingMode;
        public WrappingRopeLibrary.Enums.UVLocation UVLocation;
        public float Tiling;
        private WrappingRopeLibrary.Enums.AnchoringMode _anchoringMode;
        public float ElasticModulus;
        private bool _isDestroyed;
        private string _ignoreLayer;
        private UnityEngine.LayerMask IgnoreLayer;
        public int MaxPieceCount;
        public bool NotBendOnObject;
        private WrappingRopeLibrary.Scripts.Piece _frontPiece;
        private WrappingRopeLibrary.Scripts.Piece _backPiece;
        private UnityEngine.Vector3 _pieceInstanceSize;
        private UnityEngine.Vector3 _pieceInstanceRatio;
        private float _bendInstanceRatio;
        private System.Collections.Generic.List<UnityEngine.Vector3> _initProfile;
        private UnityEngine.Vector3[] _workProfile;
        private UnityEngine.Vector3[] _baseProfile;
        private UnityEngine.Renderer _rend;
        private UnityEngine.MeshFilter _meshFilter;
        private UnityEngine.Mesh _mesh;
        private UnityEngine.Material _workMaterial;
        protected float _initialLength;
        private WrappingRopeLibrary.Model.MeshConfigurator MeshConfiguration;
        private System.Collections.Generic.List<UnityEngine.Vector3> _triangulationPath1;
        private System.Collections.Generic.List<UnityEngine.Vector3> _triangulationPath2;
        private WrappingRopeLibrary.Events.ObjectWrapEventHandler ObjectWrap;
        private bool _deserialize;
        private UnityEngine.Vector3 _prevVect;
        private UnityEngine.Quaternion _rotation;
        private UnityEngine.Quaternion _rotation2;
        
        // Properties
        public WrappingRopeLibrary.Enums.BodyType Body { get; }
        public UnityEngine.Material Material { get; }
        public UnityEngine.GameObject FrontEnd { get; }
        public UnityEngine.GameObject BackEnd { get; }
        public float Width { get; set; }
        public WrappingRopeLibrary.Enums.AnchoringMode AnchoringMode { get; set; }
        public WrappingRopeLibrary.Scripts.Piece FrontPiece { get; set; }
        public WrappingRopeLibrary.Scripts.Piece BackPiece { get; set; }
        public UnityEngine.Vector3 PieceInstanceRatio { get; set; }
        public float BendInstanceRatio { get; set; }
        public int BendCrossectionsNumber { get; }
        
        // Methods
        public WrappingRopeLibrary.Enums.BodyType get_Body()
        {
        
        }
        public UnityEngine.Material get_Material()
        {
        
        }
        public UnityEngine.GameObject get_FrontEnd()
        {
        
        }
        public UnityEngine.GameObject get_BackEnd()
        {
        
        }
        public float get_Width()
        {
            return (float)S0;
        }
        public void set_Width(float value)
        {
            this._width = ;
            this.RefreshWidthDependencies(value:  value);
        }
        private void RefreshWidthDependencies(float value)
        {
            this.SetPieceInstanceRatio();
            this.SetBendInstanceRatio();
            this.SetProfileWidth(width:  value);
        }
        private void SetProfileWidth(float width)
        {
            if(this.AllowProcedural() == false)
            {
                    return;
            }
            
            T[] val_2 = this._initProfile.ToArray();
            WrappingRopeLibrary.Utils.Geometry.ScalePoly(target:  this._workProfile, source:  this._initProfile, scale:  width);
        }
        public WrappingRopeLibrary.Enums.AnchoringMode get_AnchoringMode()
        {
        
        }
        public void set_AnchoringMode(WrappingRopeLibrary.Enums.AnchoringMode value)
        {
            if(this._anchoringMode != value)
            {
                    this._anchoringMode = value;
            }
            
            if(value == 0)
            {
                    return;
            }
            
            float val_1 = this.GetRopeLength();
            this._initialLength = this;
        }
        public WrappingRopeLibrary.Scripts.Piece get_FrontPiece()
        {
        
        }
        internal void set_FrontPiece(WrappingRopeLibrary.Scripts.Piece value)
        {
            this._frontPiece = value;
        }
        public WrappingRopeLibrary.Scripts.Piece get_BackPiece()
        {
        
        }
        internal void set_BackPiece(WrappingRopeLibrary.Scripts.Piece value)
        {
            this._backPiece = value;
        }
        public UnityEngine.Vector3 get_PieceInstanceRatio()
        {
            mem[1152921509813521848] = R1 + 120;
            this = R1 + 112;
            return new UnityEngine.Vector3();
        }
        private void set_PieceInstanceRatio(UnityEngine.Vector3 value)
        {
        
        }
        public float get_BendInstanceRatio()
        {
            return (float)S0;
        }
        private void set_BendInstanceRatio(float value)
        {
            this._bendInstanceRatio = ;
        }
        public int get_BendCrossectionsNumber()
        {
            if(this.MeshConfiguration != 0)
            {
                    return (int)this.MeshConfiguration.BendCrossectionsNumber;
            }
            
            return (int)this.MeshConfiguration.BendCrossectionsNumber;
        }
        public void add_ObjectWrap(WrappingRopeLibrary.Events.ObjectWrapEventHandler value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.ObjectWrap, b:  value);
            if(this.ObjectWrap == 0)
            {
                goto label_1;
            }
            
            val_2 = this.ObjectWrap;
            if(null == 536891283)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.ObjectWrap != 1152921509814098396)
            {
                goto label_3;
            }
        
        }
        public void remove_ObjectWrap(WrappingRopeLibrary.Events.ObjectWrapEventHandler value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.ObjectWrap, value:  value);
            if(this.ObjectWrap == 0)
            {
                goto label_1;
            }
            
            val_2 = this.ObjectWrap;
            if(null == 536891283)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.ObjectWrap != 1152921509814226780)
            {
                goto label_3;
            }
        
        }
        private void Awake()
        {
        
        }
        private void OnEnable()
        {
            var val_9;
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            this.hideFlags = 2;
            if(this._deserialize != false)
            {
                    this.RebuildPieceAndBandPointRelations();
                this._deserialize = false;
            }
            
            if(this.AllowProcedural() != false)
            {
                    if(this._baseProfile != null)
            {
                    val_9 = this._baseProfile >> 5;
            }
            else
            {
                    val_9 = 1;
            }
            
                this.InitProfile(resetBaseProfile:  true);
            }
            
            if(this._baseProfile < 0)
            {
                    this = 4719;
                this.WrapDistance = 0.0005f;
            }
            
            if(this._baseProfile < 0)
            {
                    0.0005f = 4719;
                this._width = 0.001f;
            }
            
            if(this._baseProfile < 0)
            {
                    0.001f = 49807;
                this.Threshold = 0.03f;
            }
            
            this.CheckAndCorrectIgnoreLayerName();
            this.SetPieceInstanceRatio();
            this.SetBendInstanceRatio();
            if(this._frontEnd != 0)
            {
                    if(this._backEnd != 0)
            {
                    bool val_5 = UnityEngine.Object.op_Equality(x:  this._frontPiece, y:  0);
                if(val_5 == true)
            {
                    val_5 = this;
                bool val_6 = this.TryInitPieceSystem();
            }
            
            }
            
            }
            
            if(this._anchoringMode == 0)
            {
                    return;
            }
            
            float val_7 = this.GetRopeLength();
            this._initialLength = this;
        }
        private void Start()
        {
            this.RebuildPieceAndBandPointRelations();
        }
        protected void RebuildPieceAndBandPointRelations()
        {
            WrappingRopeLibrary.Scripts.Piece val_3 = this._frontPiece;
            if(val_3 != 0)
            {
                goto label_3;
            }
            
            return;
            label_9:
            this._frontPiece.BackBandPoint = this._frontPiece.BackPiece.FrontBandPoint;
            val_3 = this._frontPiece + 24 + -8;
            label_3:
            if((this._frontPiece + 24 + -8 + 16) != 0)
            {
                goto label_9;
            }
        
        }
        private void InitProcedural(bool resetBaseProfile)
        {
            this.InitProfile(resetBaseProfile:  resetBaseProfile);
        }
        private void InitProfile(bool resetBaseProfile)
        {
            UnityEngine.Vector3[] val_20;
            float val_21;
            System.Collections.Generic.List<UnityEngine.Vector3> val_22;
            var val_23;
            object val_24;
            System.Func<UnityEngine.Vector3, UnityEngine.Vector2> val_25;
            var val_26;
            var val_27;
            var val_28;
            val_20 = this;
            536900819 = new RopeBase.<>c__DisplayClass74_0();
            if(536900819 > 2)
            {
                    System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<UnityEngine.Vector3>(source:  this.MeshConfiguration.Profile);
                this._initProfile = this.MeshConfiguration.Profile;
                val_21 = 4.012917E-38f;
                536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>();
                mem[536900827] = 536878517;
                536873361 = new System.Action<UnityEngine.Vector3>(object:  536900819, method:  new IntPtr(1610683197));
                this._initProfile.ForEach(action:  536873361);
                T[] val_5 = mem[536900827].ToArray();
                this._workProfile = mem[536900827];
                WrappingRopeLibrary.Utils.Geometry.ScalePoly(target:  536878517, source:  536878517, scale:  null);
                if(resetBaseProfile != false)
            {
                    UnityEngine.Vector3 val_6 = UnityEngine.Vector3.forward;
                UnityEngine.Quaternion val_7 = new UnityEngine.Quaternion(x:  val_6.x, y:  val_6.y, z:  val_6.z, w:  null);
                UnityEngine.Vector3[] val_8 = this.GetWorkProfileClone();
                this._baseProfile = val_20;
            }
            
                WrappingRopeLibrary.Utils.Triangulator val_9 = 536895837;
                val_9 = new WrappingRopeLibrary.Utils.Triangulator();
                val_22 = this.MeshConfiguration.Profile;
                val_23 = 536900815;
                if(((mem[536901002] & true) == 0) && (mem[536900931] == 0))
            {
                    val_23 = 536900815;
            }
            
                val_24 = mem[536900907];
                val_25 = mem[mem[536900907] + 4];
                val_25 = mem[536900907] + 4;
                if(val_25 == 0)
            {
                    if(((mem[536901002] & true) == 0) && (mem[536900931] == 0))
            {
                    val_24 = mem[536900907];
            }
            
                val_25 = 536875583;
                val_25 = new System.Func<UnityEngine.Vector3, UnityEngine.Vector2>(object:  val_24, method:  new IntPtr(1610683203));
                mem2[0] = val_25;
            }
            
                System.Collections.Generic.IEnumerable<TResult> val_11 = System.Linq.Enumerable.Select<UnityEngine.Vector3, UnityEngine.Vector2>(source:  val_22, selector:  536875583);
                System.Collections.Generic.List<TSource> val_12 = System.Linq.Enumerable.ToList<UnityEngine.Vector2>(source:  val_22);
                System.Collections.Generic.List<UnityEngine.Vector3> val_13 = val_9.GetTriangulationIndexes(rawPoints:  val_22);
                this._triangulationPath1 = val_9;
                536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>(capacity:  mem[536895849]);
                this._triangulationPath2 = 536878517;
                val_26 = mem[536895849] - 1;
                if(val_26 < 0)
            {
                    return;
            }
            
                var val_15 = 0 - mem[536895849];
                do
            {
                if(mem[536895837] != 0)
            {
                    val_27 = mem[mem[536895837] + 12];
                val_27 = mem[536895837] + 12;
                val_28 = val_27;
            }
            else
            {
                    val_28 = 0;
                val_27 = 0;
            }
            
                var val_16 = val_28 + val_15;
                if(val_27 <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_19 = mem[536895837] + 8;
                val_19 = val_19 + ((val_16 + (val_16 << 1)) << 2);
                val_20 = mem[(mem[536895837] + 8 + (((val_28 + (0 - mem[536895849])) + ((val_28 + (0 - mem[536895849]))) << 1)) << 2) + 16];
                val_20 = (mem[536895837] + 8 + (((val_28 + (0 - mem[536895849])) + ((val_28 + (0 - mem[536895849]))) << 1)) << 2) + 16;
                val_22 = mem[(mem[536895837] + 8 + (((val_28 + (0 - mem[536895849])) + ((val_28 + (0 - mem[536895849]))) << 1)) << 2) + 20];
                val_22 = (mem[536895837] + 8 + (((val_28 + (0 - mem[536895849])) + ((val_28 + (0 - mem[536895849]))) << 1)) << 2) + 20;
                this._triangulationPath2.Add(item:  new UnityEngine.Vector3() {x = val_20, y = (mem[536895837] + 8 + (((val_28 + (0 - mem[536895849])) + ((val_28 + (0 - mem[536895849]))) << 1)) << 2) + 24, z = val_22});
                val_26 = val_26 - 1;
                val_21 = val_15 + 1;
            }
            while(val_26 > 1);
            
                return;
            }
            
            22709184 = new System.ApplicationException(message:  22790504);
        }
        protected bool TryInitPieceSystem()
        {
            var val_8;
            UnityEngine.GameObject val_1 = this.GetPieceInstance(bodyType:  this._body);
            val_8 = 0;
            if(913397040 == 0)
            {
                    return (bool)val_8;
            }
            
            Weight val_3 = this.GetComponent<Weight>();
            this.SetPieceInstanceRatio();
            this._frontPiece = this;
            this._backPiece = this;
            WrappingRopeLibrary.Model.WrapPoint val_4 = this._backPiece.GetWrapPointByGameObject(gameObject:  this._frontEnd);
            WrappingRopeLibrary.Model.WrapPoint val_5 = this._backPiece.GetWrapPointByGameObject(gameObject:  this._backEnd);
            val_8 = 1;
            this.Init(fBP:  913397136, bBP:  913397136, fP:  0, bP:  0, rope:  this, layer:  this.GetIgnoreLayerForPiece(), resetPrevBandPoints:  true);
            if(this.AllowProcedural() == false)
            {
                    return (bool)val_8;
            }
            
            val_8 = 1;
            this.InitProfile(resetBaseProfile:  true);
            return (bool)val_8;
        }
        private WrappingRopeLibrary.Model.WrapPoint GetWrapPointByGameObject(UnityEngine.GameObject gameObject)
        {
            float val_6;
            float val_7;
            var val_8;
            var val_13;
            WrappingRopeLibrary.Model.WrapPoint val_1 = 536897093;
            val_1 = new WrappingRopeLibrary.Model.WrapPoint();
            if(gameObject != 0)
            {
                    UnityEngine.Transform val_2 = gameObject.transform;
                val_13 = gameObject;
            }
            else
            {
                    UnityEngine.Transform val_3 = 0.transform;
                val_13 = 0;
            }
            
            UnityEngine.Transform val_4 = gameObject.transform;
            UnityEngine.Vector3 val_5 = position;
            UnityEngine.Vector3 val_9 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_6, z = val_7});
            var val_10 = val_1 + 8;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
            if(val_1 != 0)
            {
                    mem[536897113] = val_6;
                mem[536897117] = val_7;
                mem[536897121] = val_8;
            }
            else
            {
                    mem[20] = val_6;
                mem[24] = val_7;
                mem[28] = val_8;
            }
            
            mem[536897137] = gameObject;
            UnityEngine.Transform val_12 = gameObject.transform;
            UnityEngine.Vector3 val_13 = position;
            val_1.PositionInWorldSpace = new UnityEngine.Vector3();
        }
        private void SetPieceInstanceRatio()
        {
            var val_3 = this;
            if(this._pieceInstance != 0)
            {
                    if(this._body != 1)
            {
                    return;
            }
            
            }
            
            mem2[0] = 1065353216;
            mem2[0] = 1065353216;
            mem2[0] = 1065353216;
        }
        private void SetBendInstanceRatio()
        {
            float val_5;
            var val_8;
            UnityEngine.GameObject val_9;
            float val_10;
            val_8 = this;
            val_9 = this.BendInstance;
            val_10 = 1f;
            if(val_9 != 0)
            {
                    if(this.AllowProcedural() != true)
            {
                    Weight val_3 = this.BendInstance.GetComponent<Weight>();
                val_9 = this.BendInstance;
                UnityEngine.Bounds val_4 = bounds;
                mem2[0] = val_5;
                UnityEngine.Vector3 val_6 = size;
                val_10 = (val_4.m_Extents.y + 44) / val_5;
            }
            
            }
            
            mem2[0] = val_10;
        }
        public void OnAfterDeserialize()
        {
            this._deserialize = true;
        }
        private UnityEngine.GameObject GetPieceInstance(WrappingRopeLibrary.Enums.BodyType bodyType)
        {
            var val_9;
            UnityEngine.GameObject val_10;
            if((bodyType == 1) && (this.AllowProcedural() != false))
            {
                    UnityEngine.GameObject val_2 = 536887303;
                val_9 = val_2;
                val_2 = new UnityEngine.GameObject();
            }
            else
            {
                    val_10 = this._pieceInstance;
                val_9 = 0;
                if(val_10 == 0)
            {
                    return;
            }
            
                DropdownItem val_4 = UnityEngine.Object.Instantiate<DropdownItem>(original:  this._pieceInstance);
                val_9 = this._pieceInstance;
            }
            
            if(val_9 != 0)
            {
                    SynchronizationContextBehavoir val_5 = val_9.AddComponent<SynchronizationContextBehavoir>();
            }
            else
            {
                    SynchronizationContextBehavoir val_6 = 0.AddComponent<SynchronizationContextBehavoir>();
            }
            
            UnityEngine.Transform val_7 = val_9.transform;
            val_10 = val_9;
            UnityEngine.Transform val_8 = this.transform;
            val_10.parent = 914022576;
        }
        internal UnityEngine.GameObject GetPieceInstance()
        {
            return this.GetPieceInstance(bodyType:  this._body);
        }
        internal UnityEngine.GameObject GetBendInstance()
        {
            if(this.BendInstance == 0)
            {
                    return;
            }
            
            DropdownItem val_2 = UnityEngine.Object.Instantiate<DropdownItem>(original:  this.BendInstance);
            0 = this.BendInstance;
        }
        protected int GetPiecesCount()
        {
            var val_2 = 0;
            do
            {
                val_2 = val_2 + 1;
            }
            while(this._frontPiece.BackPiece != 0);
            
            return (int)val_2;
        }
        protected float GetRopeLength()
        {
            WrappingRopeLibrary.Scripts.Piece val_2;
            float val_3;
            bool val_4;
            val_2 = this._frontPiece;
            val_3 = 0f;
            goto label_1;
            label_6:
            if(this != 0)
            {
                    val_4 = this.NotBendOnObject;
            }
            else
            {
                    val_4 = 0f;
            }
            
            val_3 = val_3 + val_4;
            val_2 = this._material;
            label_1:
            if(mem[this._material] != 0)
            {
                goto label_6;
            }
            
            return (float)S0;
        }
        private void LateUpdate()
        {
            if(this._body != 1)
            {
                    return;
            }
            
            if((R4 + 92) == 0)
            {
                    return;
            }
            
            R4.UpdateProceduralRope();
        }
        private void UpdateProceduralRope()
        {
            this.UpdateBaseProfile();
            float val_1 = this.GetRopeLength();
            do
            {
                if(this._frontPiece != 0)
            {
                    this._frontPiece.LocateSections(ropeLength:  val_1, lengthBefore: ref  float val_2 = 3.999296E-06f);
            }
            else
            {
                    0.LocateSections(ropeLength:  val_1, lengthBefore: ref  float val_3 = 3.999296E-06f);
            }
            
            }
            while(this._frontPiece.BackPiece != 0);
        
        }
        public bool AllowProcedural()
        {
            UnityEngine.MeshFilter val_3;
            var val_4;
            val_3 = this._meshFilter;
            val_4 = 0;
            if(val_3 == 0)
            {
                    return true;
            }
            
            val_3 = this._rend;
            val_4 = 0;
            bool val_2 = UnityEngine.Object.op_Inequality(x:  val_3, y:  0);
            if(val_2 == false)
            {
                    return true;
            }
            
            if(val_2 > true)
            {
                    val_4 = 1;
            }
            
            return true;
        }
        internal void UpdateBaseProfile()
        {
            float val_4;
            UnityEngine.Vector3 val_5 = this._frontPiece.BackBandPoint.positionInWorldSpace;
            val_5 = val_5 - this._frontPiece.FrontBandPoint.positionInWorldSpace;
            float val_1 = S18 - S2;
            float val_2 = S20 - S4;
            this._rotation2.SetFromToRotation(fromDirection:  new UnityEngine.Vector3() {x = this._prevVect, y = R6, z = R7}, toDirection:  new UnityEngine.Vector3() {x = val_5, y = val_1, z = val_2});
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = 4.155285E-06f, y = mem[this._rotation2 + (0)], z = mem[this._rotation2 + (4)], w = mem[this._rotation2 + (8)]}, rhs:  new UnityEngine.Quaternion() {x = this._rotation2, y = this._rotation, z = ???, w = ???});
            mem[1152921509816933756] = val_4;
            WrappingRopeLibrary.Utils.Geometry.RotatePoly(target:  this._baseProfile, source:  this._workProfile, rotation:  new UnityEngine.Quaternion() {z = ???, w = val_4});
            this._prevVect = val_5;
            mem[1152921509816933736] = val_1;
            mem[1152921509816933740] = val_2;
        }
        internal UnityEngine.Vector3[] GetBaseProfile()
        {
        
        }
        internal UnityEngine.Vector3[] GetWorkProfileClone()
        {
            var val_3;
            if(this.AllowProcedural() == false)
            {
                goto label_1;
            }
            
            536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            val_3 = 0;
            goto label_2;
            label_7:
            536878517.Add(item:  new UnityEngine.Vector3() {x = this._workProfile[0], y = this._workProfile[0], z = this._workProfile[0]});
            val_3 = 1;
            label_2:
            if(val_3 < 536878517)
            {
                goto label_7;
            }
            
            if(536878517 != 0)
            {
                    return 536878517.ToArray();
            }
            
            return 536878517.ToArray();
            label_1:
        }
        protected void MainUpdate()
        {
            if(this._frontPiece == 0)
            {
                    return;
            }
            
            R4.RelocateWrapPoints();
            R4.RelocatePieces(piece:  R4 + 92, resetBackPointPosition:  false);
            R4.MergeRope(piece:  R4 + 92);
            if(R4.GetPiecesCount() < (R4 + 84))
            {
                    R4.BandRope(sourcePiece:  R4 + 92);
            }
            
            R4.AnchoreRope();
            R4.ProcessElastic();
            R4.RelocatePieces(piece:  R4 + 92, resetBackPointPosition:  true);
        }
        protected void RelocateWrapPoints()
        {
            WrappingRopeLibrary.Scripts.Piece val_4;
            WrappingRopeLibrary.Model.WrapPoint val_5;
            if(this._frontPiece == 0)
            {
                    return;
            }
            
            val_4 = this._frontPiece;
            val_5 = this._frontPiece.FrontBandPoint;
            val_5.SetPointInWorldSpace(wrapDistance:  null);
            goto label_6;
            label_16:
            val_5 = this._frontPiece.BackBandPoint;
            if(this._frontPiece.BackPiece == 0)
            {
                    if(val_5 != 0)
            {
                goto label_12;
            }
            
            }
            
            label_12:
            val_5.SetPointInWorldSpace(wrapDistance:  null);
            val_4 = this._frontPiece.BackPiece;
            label_6:
            if(val_4 != 0)
            {
                goto label_16;
            }
        
        }
        private void RelocatePieces(WrappingRopeLibrary.Scripts.Piece piece, bool resetBackPointPosition)
        {
            do
            {
                if(piece != 0)
            {
                    piece.Relocate(resetPrevBandPoints:  resetBackPointPosition);
            }
            else
            {
                    0.Relocate(resetPrevBandPoints:  resetBackPointPosition);
            }
            
            }
            while(piece.BackPiece != 0);
        
        }
        public void CutRope(float length, WrappingRopeLibrary.Enums.Direction dir)
        {
            if(this._anchoringMode != 0)
            {
                    if(this._anchoringMode >= 0)
            {
                    dir = this._initialLength - dir;
                this._initialLength = dir;
                return;
            }
            
                return;
            }
            
            if(this._anchoringMode < 0)
            {
                    return;
            }
            
            this.CutRopeNotAnchoring(length:  dir, dir:  dir);
        }
        public void CutRopeNotAnchoring(float length, WrappingRopeLibrary.Enums.Direction dir = 1)
        {
            WrappingRopeLibrary.Scripts.Piece val_22;
            UnityEngine.Vector3 val_23;
            val_22 = this;
            val_23 = R2;
            UnityEngine.Debug.LogWarning(message:  -1610606131);
        }
        protected void AnchoreRope()
        {
            float val_1 = this.GetRopeLength();
            if(this._anchoringMode == 0)
            {
                    return;
            }
            
            uint val_2 = 916691120;
            if(this._anchoringMode < 0)
            {
                    return;
            }
            
            val_2 = val_2 - this._initialLength;
            R4.HoldLength(difLength:  val_2);
            R4.ProcessPendulum();
        }
        protected void GetPendulumInfo(out WrappingRopeLibrary.Scripts.Piece piece, out UnityEngine.Vector3 pieceDirection, out UnityEngine.Rigidbody weight, out UnityEngine.Vector3 weightVelocity)
        {
            float val_9;
            var val_10;
            UnityEngine.GameObject val_11;
            if(this._anchoringMode == 2)
            {
                    UnityEngine.Vector3 val_11 = this._frontPiece.FrontBandPoint.positionInWorldSpace;
                val_11 = this._frontPiece.BackBandPoint.positionInWorldSpace - val_11;
                pieceDirection.x = val_11;
                mem[1152921509818751508] = S20 - S2;
                mem[1152921509818751512] = S18 - S4;
                val_11 = this._frontEnd;
                Weight val_3 = val_11.GetComponent<Weight>();
                pieceDirection.y = val_11;
                piece = this._frontPiece;
                UnityEngine.Vector3 val_4 = DefineFrontBandPointVelocity();
            }
            else
            {
                    UnityEngine.Vector3 val_12 = this._backPiece.BackBandPoint.positionInWorldSpace;
                val_12 = this._backPiece.FrontBandPoint.positionInWorldSpace - val_12;
                pieceDirection.x = val_12;
                mem[1152921509818751508] = S20 - S2;
                mem[1152921509818751512] = S18 - S4;
                val_11 = this._backEnd;
                Weight val_7 = val_11.GetComponent<Weight>();
                pieceDirection.y = val_11;
                piece = this._backPiece;
                UnityEngine.Vector3 val_8 = DefineBackBandPointVelocity();
            }
            
            mem[1152921509818759640] = val_10;
            pieceDirection.z = val_9;
        }
        protected void HoldLength(float difLength)
        {
            if(this._anchoringMode != 1)
            {
                    this._anchoringMode = 0;
            }
            
            if(this._anchoringMode == 1)
            {
                    this._anchoringMode = 1;
            }
            
            this.CutRopeNotAnchoring(length:  difLength, dir:  null);
        }
        protected void ProcessPendulum()
        {
            float val_9;
            float val_10;
            float val_17;
            this.GetPendulumInfo(piece: out  WrappingRopeLibrary.Scripts.Piece val_1 = 917215248, pieceDirection: out  new UnityEngine.Vector3() {x = 5.113903E-06f, y = 5.113901E-06f, z = 0f}, weight: out  UnityEngine.Rigidbody val_2 = null, weightVelocity: out  new UnityEngine.Vector3());
            if(0 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Physics.gravity;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.Project(vector:  new UnityEngine.Vector3() {x = 5.113874E-06f, y = R0 ^ 2147483648, z = R2 ^ 2147483648}, onNormal:  new UnityEngine.Vector3() {x = R3 ^ 2147483648, y = 0f, z = 0f});
            float val_11 = val_10.magnitude;
            UnityEngine.Vector3 val_12 = velocity;
            0f.AddForce(force:  new UnityEngine.Vector3() {x = R0 ^ 2147483648, y = R1 ^ 2147483648, z = R2 ^ 2147483648}, mode:  2);
            UnityEngine.Vector3 val_16 = normalized;
            float val_21 = val_10;
            float val_22 = val_17;
            float val_23 = val_9;
            val_21 = 917215224 * val_21;
            val_22 = 917215224 * val_22;
            val_23 = 917215224 * val_23;
            0f.AddForce(force:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23}, mode:  5);
            float val_18 = 0f.magnitude;
            float val_19 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            if((0f > 0) && (0f < 0))
            {
                    UnityEngine.Vector3 val_20 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 5.113874E-06f, y = 0f, z = 0f}, rhs:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3.OrthoNormalize(normal: ref  new UnityEngine.Vector3() {x = 5.113903E-06f, y = 5.113881E-06f, z = 5.113896E-06f}, tangent: ref  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, binormal: ref  new UnityEngine.Vector3() {x = 0f, y = 0f});
            }
            else
            {
                    0f.Normalize();
            }
            
            float val_24 = 0f;
            float val_25 = 0f;
            float val_26 = 0f;
            val_24 = 917215240 * val_24;
            val_25 = 917215240 * val_25;
            val_26 = 917215240 * val_26;
            0f.AddForce(force:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26}, mode:  2);
        }
        protected void ProcessElastic()
        {
            var val_4;
            float val_5;
            var val_6;
            UnityEngine.Object val_20;
            var val_21;
            float val_22;
            var val_23;
            var val_24;
            var val_25;
            float val_26;
            val_20 = 1152921509819153676;
            val_21 = 22713552;
            goto label_35;
            label_38:
            val_20 = SB;
            if((SB + 16) == 0)
            {
                    return;
            }
            
            Weight val_2 = SB + 24 + 44.GetComponent<Weight>();
            if((SB + 24 + 44) == 0)
            {
                goto label_9;
            }
            
            val_22 = SB + 24 + 44;
            float val_18 = SB + 24 + 32;
            float val_19 = SB + 24 + 36;
            float val_20 = SB + 24 + 40;
            val_18 = (SB + 20 + 32) - val_18;
            val_19 = (SB + 20 + 36) - val_19;
            val_20 = (SB + 20 + 40) - val_20;
            UnityEngine.Vector3 val_3 = normalized;
            var val_27 = val_5;
            float val_21 = SB + 16 + 20 + 32;
            float val_22 = SB + 16 + 20 + 36;
            float val_23 = SB + 16 + 20 + 40;
            val_21 = (SB + 16 + 24 + 32) - val_21;
            val_22 = (SB + 16 + 24 + 36) - val_22;
            val_23 = (SB + 16 + 24 + 40) - val_23;
            UnityEngine.Vector3 val_7 = normalized;
            var val_24 = val_4;
            var val_25 = val_5;
            var val_26 = val_6;
            val_24 = val_4 + val_24;
            val_25 = val_27 + val_25;
            val_26 = val_6 + val_26;
            val_27 = val_25 * mem[1152921509819153652];
            float val_9 = val_26 * mem[1152921509819153652];
            var val_39 = val_22;
            val_23 = val_27;
            val_24 = val_24 * mem[1152921509819153652];
            if((SB + 24 + 44 + 178) == 0)
            {
                goto label_17;
            }
            
            var val_28 = 0;
            label_19:
            if((SB + 24 + 44 + 88 + 0) == 536888665)
            {
                goto label_18;
            }
            
            val_28 = val_28 + 1;
            if(((uint)val_28 & 65535) < (SB + 24 + 44 + 178))
            {
                goto label_19;
            }
            
            label_17:
            val_25 = val_22;
            val_24 = val_24;
            val_23 = val_23;
            goto label_20;
            label_9:
            Weight val_10 = SB + 24 + 44.GetComponent<Weight>();
            if((SB + 24 + 44) == 0)
            {
                goto label_25;
            }
            
            float val_29 = SB + 24 + 32;
            float val_30 = SB + 24 + 36;
            float val_31 = SB + 24 + 40;
            val_29 = (SB + 20 + 32) - val_29;
            val_30 = (SB + 20 + 36) - val_30;
            val_31 = (SB + 20 + 40) - val_31;
            UnityEngine.Vector3 val_12 = normalized;
            float val_38 = val_5;
            float val_32 = SB + 16 + 20 + 32;
            float val_33 = SB + 16 + 20 + 36;
            float val_34 = SB + 16 + 20 + 40;
            val_32 = (SB + 16 + 24 + 32) - val_32;
            val_33 = (SB + 16 + 24 + 36) - val_33;
            val_34 = (SB + 16 + 24 + 40) - val_34;
            UnityEngine.Vector3 val_13 = normalized;
            var val_35 = val_4;
            var val_36 = val_5;
            var val_37 = val_6;
            val_35 = val_4 + val_35;
            val_36 = val_38 + val_36;
            val_37 = val_6 + val_37;
            val_38 = val_36 * mem[1152921509819153652];
            val_26 = val_37 * mem[1152921509819153652];
            val_22 = mem[SB + 24 + 36];
            val_22 = SB + 24 + 36;
            if((SB + 24 + 44) == 0)
            {
                    val_26 = val_26;
            }
            
            SB + 24 + 44.AddForceAtPosition(force:  new UnityEngine.Vector3() {x = val_35 * mem[1152921509819153652], y = val_38, z = val_26}, position:  new UnityEngine.Vector3() {x = SB + 24 + 32, y = val_22, z = SB + 24 + 40}, mode:  1);
            goto label_34;
            label_18:
            var val_16 = (SB + 24 + 44 + 88) + 0;
            val_39 = val_39 + (((SB + 24 + 44 + 88 + 0) + 4) << 3);
            val_25 = val_39 + 196;
            label_20:
            label_34:
            val_21 = 22713552;
            val_20 = SB + 16;
            label_25:
            label_35:
            if(val_20 != 0)
            {
                goto label_38;
            }
        
        }
        private void MergeRope(WrappingRopeLibrary.Scripts.Piece piece)
        {
            WrappingRopeLibrary.Scripts.Piece val_6;
            label_9:
            val_6 = piece.BackPiece;
            if(val_6 == 0)
            {
                    return;
            }
            
            if((piece.<IsCurrentlyBanded>k__BackingField) == false)
            {
                goto label_5;
            }
            
            label_18:
            piece.<IsCurrentlyBanded>k__BackingField = false;
            val_6 = piece.BackPiece;
            if(val_6 == 0)
            {
                    return;
            }
            
            goto label_9;
            label_5:
            if((piece.<IsCurrentlyBanded>k__BackingField.IsMoveEndsOfKnee(piece:  piece)) != true)
            {
                    if(piece.BackBandPoint.Parent != 0)
            {
                goto label_18;
            }
            
            }
            
            if((this.CheckKnee(endPoint1:  piece.FrontBandPoint, bendPoint:  piece.BackBandPoint, endPoint2:  piece.BackPiece.BackBandPoint)) == true)
            {
                goto label_18;
            }
            
            this.MergePieces(piece1:  piece, piece2:  piece.BackPiece);
            goto label_18;
        }
        private bool IsMoveEndsOfKnee(WrappingRopeLibrary.Scripts.Piece piece)
        {
            float val_4;
            float val_5;
            float val_6;
            var val_18;
            UnityEngine.GameObject val_19;
            UnityEngine.GameObject val_20;
            var val_21;
            val_18 = 0;
            if(piece.FrontBandPoint.Parent != piece.BackBandPoint.Parent)
            {
                    UnityEngine.Vector3 val_2 = DefineBackBandPointVelocity();
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
                val_21 = 1;
                if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7}, rhs:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_4})) == true)
            {
                    return (bool)val_21;
            }
            
                UnityEngine.Vector3 val_8 = DefineFrontBandPointVelocity();
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
                if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = R6, y = R7, z = R8}, rhs:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_4})) == true)
            {
                    return (bool)val_21;
            }
            
            }
            
            val_19 = piece.BackBandPoint.Parent;
            val_20 = piece.BackPiece.BackBandPoint.Parent;
            val_21 = 0;
            if(val_19 == val_20)
            {
                    return (bool)val_21;
            }
            
            val_18 = 0;
            UnityEngine.Vector3 val_12 = DefineBackBandPointVelocity();
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
            val_21 = 1;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7}, rhs:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_4})) == true)
            {
                    return (bool)val_21;
            }
            
            val_20 = 0;
            UnityEngine.Vector3 val_15 = DefineBackBandPointVelocity();
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
            val_21 = UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = R4, y = R5, z = R6}, rhs:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_4});
            return (bool)val_21;
        }
        private void MergePieces(WrappingRopeLibrary.Scripts.Piece piece1, WrappingRopeLibrary.Scripts.Piece piece2)
        {
            if(piece2.BackPiece == 0)
            {
                    this._backPiece = piece1;
            }
            
            UnityEngine.GameObject val_2 = piece2.gameObject;
            UnityEngine.Object.DestroyImmediate(obj:  piece2);
            piece1.Relocate(resetPrevBandPoints:  false);
        }
        private bool CheckKnee(WrappingRopeLibrary.Model.WrapPoint endPoint1, WrappingRopeLibrary.Model.WrapPoint bendPoint, WrappingRopeLibrary.Model.WrapPoint endPoint2)
        {
            float val_5;
            float val_6;
            float val_7;
            float val_36;
            var val_37;
            bool val_38;
            var val_39;
            float val_40;
            UnityEngine.GameObject val_41;
            var val_42;
            val_36 = endPoint2;
            val_37 = 0;
            if(bendPoint.Parent == 0)
            {
                    return (bool)val_37;
            }
            
            UnityEngine.Vector3 val_36 = bendPoint.positionInWorldSpace;
            val_36 = (endPoint1 + 32) - val_36;
            float val_2 = (endPoint1 + 36) - S2;
            float val_3 = (endPoint1 + 40) - S4;
            UnityEngine.Vector3 val_4 = normalized;
            UnityEngine.Vector3 val_37 = bendPoint.positionInWorldSpace;
            val_37 = endPoint2.positionInWorldSpace - val_37;
            val_4.z = (endPoint1 + 36) - val_4.z;
            val_3 = (endPoint1 + 40) - val_3;
            UnityEngine.Vector3 val_8 = normalized;
            float val_48 = val_5;
            float val_47 = val_6;
            float val_46 = val_7;
            float val_9 = val_6 + val_47;
            float val_10 = val_5 + val_48;
            float val_11 = val_7 + val_46;
            UnityEngine.Vector3 val_12 = normalized;
            float val_44 = val_5;
            float val_38 = endPoint1 + 32;
            float val_39 = endPoint1 + 36;
            float val_40 = endPoint1 + 40;
            val_38 = endPoint2.positionInWorldSpace - val_38;
            val_39 = (endPoint1 + 36) - val_39;
            val_40 = (endPoint1 + 40) - val_40;
            float val_34 = val_38;
            float val_42 = 0f;
            float val_13 = this.WrapDistance + 0.03f;
            float val_41 = val_44;
            float val_43 = val_7;
            val_41 = val_41 * val_13;
            val_42 = val_13 * val_42;
            val_43 = val_13 * val_43;
            float val_14 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_41, z = val_43}, to:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_7});
            val_38 = mem[536890482];
            if((val_38 & true) == 0)
            {
                    val_38 = mem[536890411];
            }
            
            val_44 = val_44 * (6.98487350263574E-315);
            val_44 = val_44 / 0;
            double val_45 = 1;
            if(val_38 >= _TYPE_MAX_)
            {
                    val_39 = val_38;
            }
            
            val_45 = val_45 / val_39;
            val_46 = val_46 * val_14;
            val_47 = val_47 * val_14;
            val_48 = val_48 * val_14;
            float val_21 = val_48;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
            if((val_21.Equals(other:  new UnityEngine.Vector3())) == true)
            {
                goto label_11;
            }
            
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.Normalize(value:  new UnityEngine.Vector3() {x = 5.4747E-06f, y = val_21, z = val_47});
            UnityEngine.Vector3 val_49 = bendPoint.positionInWorldSpace;
            val_49 = val_47 + val_49;
            UnityEngine.Vector3 val_50 = bendPoint.positionInWorldSpace;
            val_50 = val_46 + val_50;
            UnityEngine.Vector3 val_51 = bendPoint.positionInWorldSpace;
            val_51 = val_48 + val_51;
            val_5 = 0;
            UnityEngine.Ray val_18 = new UnityEngine.Ray(origin:  new UnityEngine.Vector3() {x = val_51, y = val_49, z = val_50}, direction:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_7});
            UnityEngine.GameObject val_19 = bendPoint.Parent.gameObject;
            val_41 = bendPoint.Parent;
            val_42 = 0;
            float val_20 = val_21.magnitude;
            if((WrappingRopeLibrary.Utils.Geometry.TryRaycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_18.m_Origin.x, y = val_18.m_Origin.y, z = val_40}, m_Direction = new UnityEngine.Vector3() {x = val_18.m_Direction.x, y = val_36, z = val_18.m_Direction.z}}, gameObject:  val_41, maxDistance:  918008696, hitInfo: out  val_21)) == true)
            {
                goto label_13;
            }
            
            label_11:
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.zero;
            if((val_44.Equals(other:  new UnityEngine.Vector3() {x = val_18.m_Origin.x, y = val_18.m_Origin.y, z = val_18.m_Origin.z})) == true)
            {
                goto label_16;
            }
            
            val_5 = 0;
            UnityEngine.Ray val_25 = new UnityEngine.Ray(origin:  new UnityEngine.Vector3() {x = bendPoint.positionInWorldSpace, y = bendPoint.positionInWorldSpace, z = bendPoint.positionInWorldSpace}, direction:  new UnityEngine.Vector3() {x = val_44, y = 0f, z = val_7});
            UnityEngine.GameObject val_26 = bendPoint.Parent.gameObject;
            val_41 = bendPoint.Parent;
            val_42 = 0;
            float val_27 = val_44.magnitude;
            uint val_52 = 918008728;
            val_52 = val_52 * 1.2f;
            if((WrappingRopeLibrary.Utils.Geometry.TryRaycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_25.m_Origin.x, y = val_25.m_Origin.y, z = val_25.m_Origin.z}, m_Direction = new UnityEngine.Vector3() {x = val_25.m_Direction.x, y = val_36, z = val_25.m_Direction.z}}, gameObject:  val_41, maxDistance:  val_52, hitInfo: out  val_52)) == false)
            {
                goto label_16;
            }
            
            label_13:
            val_37 = 1;
            return (bool)val_37;
            label_16:
            val_41 = mem[endPoint1 + 32];
            val_41 = endPoint1 + 32;
            UnityEngine.Vector3 val_30 = val_25.m_Origin.x.normalized;
            val_5 = 0;
            UnityEngine.Ray val_31 = new UnityEngine.Ray(origin:  new UnityEngine.Vector3() {x = val_41, y = endPoint1 + 36, z = endPoint1 + 40}, direction:  new UnityEngine.Vector3() {x = val_25.m_Origin.x, y = val_25.m_Origin.y, z = val_25.m_Origin.z});
            UnityEngine.GameObject val_32 = bendPoint.Parent.gameObject;
            val_42 = 0;
            float val_33 = val_34.magnitude;
            if((WrappingRopeLibrary.Utils.Geometry.TryRaycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_31.m_Origin.x, y = val_31.m_Origin.y, z = val_31.m_Origin.z}, m_Direction = new UnityEngine.Vector3() {x = val_31.m_Direction.x, y = val_36, z = val_31.m_Direction.z}}, gameObject:  bendPoint.Parent, maxDistance:  918008712, hitInfo: out  val_34)) == true)
            {
                    val_37 = 1;
            }
            
            return (bool)val_37;
        }
        private void BandRope(WrappingRopeLibrary.Scripts.Piece sourcePiece)
        {
            AdjustmentRule val_15;
            WrappingRopeLibrary.Scripts.RopeBase val_26;
            WrappingRopeLibrary.Scripts.Piece val_27;
            UnityEngine.Vector3 val_28;
            var val_29;
            float val_31;
            var val_32;
            WrappingRopeLibrary.Scripts.Piece val_33;
            var val_34;
            object val_35;
            System.Func<WrappingRopeLibrary.Model.WrapPoint, UnityEngine.Vector3> val_36;
            System.Exception val_37;
            val_26 = this;
            val_27 = sourcePiece.BackPiece;
            536891715 = new WrappingRopeLibrary.Model.PieceInfo(piece:  sourcePiece);
            if((this.TryGetIntersect(pieceInfo: ref  WrappingRopeLibrary.Model.PieceInfo val_2 = 918169888, hitInfo1: out  WrappingRopeLibrary.Model.HitInfo val_3 = 918169896, hitInfo2: out  WrappingRopeLibrary.Model.HitInfo val_4 = 918169892)) == false)
            {
                goto label_51;
            }
            
            val_28 = 0;
            536887317 = new WrappingRopeLibrary.Utils.GameObjectWraper(pieceInfo:  536891715, hitInfo1:  0, hitInfo2:  0);
            System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> val_7 = 536887317.GetWrapPoints();
            val_29 = mem[536887329];
            if(val_29 < 1)
            {
                goto label_57;
            }
            
            if(sourcePiece.FrontBandPoint == 0)
            {
                    val_29 = mem[536887329];
            }
            
            val_28 = sourcePiece.FrontBandPoint.positionInWorldSpace;
            if(val_29 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_26 = val_26;
            val_27 = val_27;
            val_31 = 1.086322E-19f;
            if((this.IsIntersection(startPoint:  new UnityEngine.Vector3() {x = val_28, y = 0f, z = SB}, stopPoint:  new UnityEngine.Vector3() {x = mem[536887325] + 16 + 32, y = mem[536887325] + 16 + 36, z = mem[536887325] + 16 + 40}, gameObject:  2097204)) == true)
            {
                goto label_51;
            }
            
            if(mem[536887329] == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_9 = mem[536887329] - 1;
            val_9 = mem[536887325] + (val_9 << 2);
            val_31 = mem[(mem[536887325] + ((mem[536887329] - 1)) << 2) + 16 + 32];
            val_31 = (mem[536887325] + ((mem[536887329] - 1)) << 2) + 16 + 32;
            if((this.IsIntersection(startPoint:  new UnityEngine.Vector3() {x = sourcePiece.BackBandPoint.positionInWorldSpace, y = SB, z = val_28}, stopPoint:  new UnityEngine.Vector3() {x = val_31, y = (mem[536887325] + ((mem[536887329] - 1)) << 2) + 16 + 36, z = (mem[536887325] + ((mem[536887329] - 1)) << 2) + 16 + 40}, gameObject:  2097204)) == false)
            {
                goto label_16;
            }
            
            label_57:
            val_26 = val_26;
            label_106:
            val_27 = val_27;
            label_51:
            if(sourcePiece != 0)
            {
                
            }
            
            sourcePiece.PrevFrontBandPoint = sourcePiece.PrevFrontBandPoint;
            mem2[0] = sourcePiece.PrevFrontBandPoint;
            mem2[0] = sourcePiece.PrevFrontBandPoint;
            if(val_27 == 0)
            {
                    return;
            }
            
            return;
            label_16:
            if(mem[536887329] >= 2)
            {
                    sourcePiece.BackBandPoint.positionInWorldSpace = mem[536887329] - 1;
            }
            
            if(sourcePiece.BackBandPoint.positionInWorldSpace >= 1)
            {
                goto label_23;
            }
            
            label_59:
            536878545 = new System.Collections.Generic.List<Page>();
            List.Enumerator<T> val_13 = GetEnumerator();
            label_30:
            bool val_14 = MoveNext();
            if(val_14 == false)
            {
                goto label_25;
            }
            
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_15 + 32, y = val_15 + 36, z = val_15 + 40}, rhs:  new UnityEngine.Vector3() {x = sourcePiece.FrontBandPoint.positionInWorldSpace, y = val_14, z = -2.003274f})) == false)
            {
                goto label_30;
            }
            
            536878545.Add(item:  val_15);
            goto label_30;
            label_25:
            Dispose();
            val_32 = 0;
            if(1 != 0)
            {
                    if((1152921509819984120 + ((1 - 1)) << 2) == 363)
            {
                    val_32 = 0;
            }
            
            }
            
            val_33 = sourcePiece;
            if(mem[536878557] < 1)
            {
                goto label_49;
            }
            
            val_34 = 536900815;
            if(((mem[536901002] & true) == 0) && (mem[536900931] == 0))
            {
                    val_34 = 536900815;
            }
            
            val_35 = mem[536900907];
            val_36 = mem[mem[536900907] + 8];
            val_36 = mem[536900907] + 8;
            if(val_36 == 0)
            {
                    if(((mem[536901002] & true) == 0) && (mem[536900931] == 0))
            {
                    val_35 = mem[536900907];
            }
            
                val_36 = 536875589;
                val_36 = new System.Func<WrappingRopeLibrary.Model.WrapPoint, UnityEngine.Vector3>(object:  val_35, method:  new IntPtr(1610683205));
                mem2[0] = val_36;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_19 = System.Linq.Enumerable.Select<WrappingRopeLibrary.Model.WrapPoint, UnityEngine.Vector3>(source:  536878545, selector:  536875589);
            TSource[] val_20 = System.Linq.Enumerable.ToArray<UnityEngine.Vector3>(source:  536878545);
            this.OnObjectWrapping(gameObject:  2097204, wrapPoints:  536878545, cancel: out  bool val_21 = true);
            val_33 = sourcePiece;
            if(0 != 0)
            {
                goto label_49;
            }
            
            List.Enumerator<T> val_22 = GetEnumerator();
            val_33 = sourcePiece;
            goto label_43;
            label_47:
            val_33.Knee(point:  val_15);
            val_33 = mem[sourcePiece + 16];
            val_33 = sourcePiece + 16;
            label_43:
            if(MoveNext() == true)
            {
                goto label_47;
            }
            
            var val_24 = (1 - 1) + 1;
            Dispose();
            if(val_24 != 0)
            {
                    var val_25 = val_24 - 1;
            }
            
            label_49:
            if(val_33 != 0)
            {
                goto label_51;
            }
            
            goto label_51;
            label_23:
            label_58:
            if(mem[536887329] <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_30 = mem[536887325];
            val_30 = val_30 + 0;
            var val_26 = 0 + 1;
            if(mem[536887329] <= val_26)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_31 = mem[536887325];
            val_31 = val_31 + 0;
            var val_27 = ((mem[536887325] + 0) + 20) + 32;
            if((this.IsIntersection(startPoint:  new UnityEngine.Vector3() {x = (mem[536887325] + 0) + 16 + 32, y = (mem[536887325] + 0) + 16 + 36, z = (mem[536887325] + 0) + 16 + 40}, stopPoint:  new UnityEngine.Vector3() {x = mem[((mem[536887325] + 0) + 20 + 32) + (0)], y = mem[((mem[536887325] + 0) + 20 + 32) + (4)], z = mem[((mem[536887325] + 0) + 20 + 32) + (8)]}, gameObject:  2097204)) == true)
            {
                goto label_57;
            }
            
            var val_29 = mem[536887329] - 1;
            if(val_26 < val_29)
            {
                goto label_58;
            }
            
            goto label_59;
            label_107:
            val_37 = mem[536887329];
            if(val_29 != 1)
            {
                goto label_102;
            }
            
            if(22710780 == 0)
            {
                goto label_103;
            }
            
            UnityEngine.Debug.LogException(exception:  null);
            goto label_106;
            label_103:
            mem[4] = ;
            goto label_107;
            label_102:
        }
        private void OnObjectWrapping(UnityEngine.GameObject gameObject, UnityEngine.Vector3[] wrapPoints, out bool cancel)
        {
            536891281 = new WrappingRopeLibrary.Events.ObjectWrapEventArgs(target:  gameObject, wrapPoints:  wrapPoints);
            if(this.ObjectWrap != 0)
            {
                    this.ObjectWrap.Invoke(sender:  918363504, args:  536891281);
            }
            
            cancel = mem[536891289];
        }
        private bool IsIntersection(UnityEngine.Vector3 startPoint, UnityEngine.Vector3 stopPoint, UnityEngine.GameObject gameObject)
        {
            float val_2;
            float val_3;
            float val_4;
            float val_10 = stopPoint.x;
            float val_8 = stopPoint.y;
            float val_9 = stopPoint.z;
            val_8 = val_8 - startPoint.y;
            val_9 = val_9 - startPoint.z;
            val_10 = val_10 - startPoint.x;
            float val_6 = val_10;
            0.origin = new UnityEngine.Vector3() {x = startPoint.x, y = startPoint.y, z = startPoint.z};
            UnityEngine.Vector3 val_1 = normalized;
            0.direction = new UnityEngine.Vector3();
            return (bool)WrappingRopeLibrary.Utils.Geometry.TryRaycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = val_2, z = val_3}, m_Direction = new UnityEngine.Vector3() {x = val_4, y = 0f, z = 0f}}, gameObject:  gameObject, maxDistance:  val_6.magnitude, hitInfo: out  val_6);
        }
        private void KneePiece(WrappingRopeLibrary.Scripts.Piece piece, WrappingRopeLibrary.Model.WrapPoint point, UnityEngine.GameObject gameObject)
        {
            piece.Knee(point:  point);
        }
        private bool TryGetIntersect(ref WrappingRopeLibrary.Model.PieceInfo pieceInfo, out WrappingRopeLibrary.Model.HitInfo hitInfo1, out WrappingRopeLibrary.Model.HitInfo hitInfo2)
        {
            var val_4;
            UnityEngine.Vector3 val_6;
            var val_7;
            var val_8;
            var val_14;
            WrappingRopeLibrary.Scripts.RopeBase val_51;
            float val_52;
            var val_53;
            UnityEngine.GameObject val_54;
            var val_55;
            WrappingRopeLibrary.Model.HitInfo val_56;
            UnityEngine.GameObject val_57;
            WrappingRopeLibrary.Scripts.RopeBase val_58;
            var val_59;
            float val_63;
            var val_64;
            var val_65;
            var val_69;
            float val_70;
            var val_71;
            var val_72;
            float val_73;
            WrappingRopeLibrary.Scripts.RopeBase val_74;
            var val_75;
            var val_76;
            var val_77;
            var val_78;
            val_51 = this;
            val_52 = 1152921509820639728;
            WrappingRopeLibrary.Model.HitInfo val_1 = 536887777;
            val_1 = new WrappingRopeLibrary.Model.HitInfo();
            mem2[0] = val_1;
            WrappingRopeLibrary.Model.HitInfo val_2 = 536887777;
            val_2 = new WrappingRopeLibrary.Model.HitInfo();
            mem2[0] = val_2;
            if(this.NotBendOnObject != false)
            {
                    val_54 = mem[pieceInfo.<Piece>k__BackingField.BackBandPoint + 44];
                val_54 = pieceInfo.<Piece>k__BackingField.BackBandPoint.Parent;
                val_55 = 0;
                if(val_54 == (pieceInfo.<Piece>k__BackingField.FrontBandPoint.Parent))
            {
                    return (bool)val_55;
            }
            
            }
            
            if(val_4 != false)
            {
                    if(pieceInfo == 0)
            {
                    if(pieceInfo == 0)
            {
                goto label_209;
            }
            
            }
            
                UnityEngine.Vector3 val_5 = Value;
                val_54 = val_6;
                PrevFrontBandPoint = val_54;
                mem2[0] = val_7;
                mem2[0] = val_8;
                UnityEngine.Vector3 val_9 = Value;
                val_52 = val_52;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector3[]> val_11 = this.GetPieceMoveStages(pieceInfo:  pieceInfo);
            List.Enumerator<T> val_12 = GetEnumerator();
            val_56 = hitInfo1;
            label_111:
            if(MoveNext() == false)
            {
                goto label_21;
            }
            
            val_57 = mem[pieceInfo.<Piece>k__BackingField.FrontBandPoint + 44];
            val_57 = pieceInfo.<Piece>k__BackingField.FrontBandPoint.Parent;
            if((pieceInfo.<Piece>k__BackingField.BackBandPoint.Parent) == val_57)
            {
                goto label_53;
            }
            
            val_58 = val_51;
            if(val_58 == 0)
            {
                    val_58 = val_51;
            }
            
            if(1 != mem[1152921509820607740])
            {
                goto label_53;
            }
            
            if((pieceInfo.<Piece>k__BackingField.BackPiece) == 0)
            {
                goto label_37;
            }
            
            val_59 = mem[val_14 + 12];
            val_59 = val_14 + 12;
            if(val_59 == 0)
            {
                    val_59 = mem[val_14 + 12];
                val_59 = val_14 + 12;
            }
            
            if(val_59 <= 1)
            {
                    val_59 = mem[val_14 + 12];
                val_59 = val_14 + 12;
            }
            
            float val_51 = val_14 + 16;
            float val_53 = val_14 + 20;
            float val_52 = val_14 + 24;
            val_51 = (val_14 + 28) - val_51;
            val_52 = (val_14 + 36) - val_52;
            val_53 = (val_14 + 32) - val_53;
            val_6 = 0;
            val_4 = 0;
            UnityEngine.Ray val_17 = new UnityEngine.Ray(origin:  new UnityEngine.Vector3() {x = val_14 + 16, y = val_14 + 20, z = val_14 + 24}, direction:  new UnityEngine.Vector3() {x = val_51, y = val_53, z = val_52});
            val_52 = val_52;
            if((val_14 + 12) >= 2)
            {
                    var val_18 = val_14 + 28;
            }
            else
            {
                    var val_19 = val_14 + 28;
            }
            
            float val_55 = mem[(val_14 + 28) + (0)];
            float val_54 = val_14 + 20;
            val_54 = (mem[(val_14 + 28) + (4)]) - val_54;
            val_55 = val_55 - (val_14 + 16);
            float val_20 = (mem[(val_14 + 28) + (8)]) - (val_14 + 24);
            float val_22 = val_55;
            float val_21 = val_22.magnitude;
            val_63 = val_17.m_Direction.z;
            val_64 = hitInfo1;
            if((WrappingRopeLibrary.Utils.Geometry.TryRaycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_17.m_Origin.x, y = val_17.m_Origin.y, z = val_17.m_Origin.z}, m_Direction = new UnityEngine.Vector3() {x = val_17.m_Direction.x, y = val_17.m_Direction.y, z = val_63}}, gameObject:  pieceInfo.<Piece>k__BackingField.BackBandPoint.Parent, maxDistance:  918781368, hitInfo: out  val_22)) == true)
            {
                goto label_114;
            }
            
            label_37:
            if((pieceInfo.<Piece>k__BackingField.FrontPiece) == 0)
            {
                goto label_53;
            }
            
            val_65 = mem[val_14 + 12];
            val_65 = val_14 + 12;
            if(val_65 == 0)
            {
                    val_65 = mem[val_14 + 12];
                val_65 = val_14 + 12;
            }
            
            var val_25 = val_14 + 16;
            if(val_65 <= 1)
            {
                    val_65 = mem[val_14 + 12];
                val_65 = val_14 + 12;
            }
            
            float val_56 = val_14 + 16;
            float val_58 = val_14 + 20;
            float val_57 = val_14 + 24;
            val_56 = (val_14 + 28) - val_56;
            val_57 = (val_14 + 36) - val_57;
            val_58 = (val_14 + 32) - val_58;
            val_6 = 0;
            val_4 = 0;
            UnityEngine.Ray val_26 = new UnityEngine.Ray(origin:  new UnityEngine.Vector3() {x = mem[(val_14 + 16) + (0)], y = mem[(val_14 + 16) + (4)], z = mem[(val_14 + 16) + (8)]}, direction:  new UnityEngine.Vector3() {x = val_56, y = val_58, z = val_57});
            if((val_14 + 12) < 2)
            {
                goto label_61;
            }
            
            var val_27 = val_14 + 28;
            goto label_112;
            label_53:
            label_113:
            val_69 = mem[val_14 + 12];
            val_69 = val_14 + 12;
            if(val_69 == 0)
            {
                    val_69 = mem[val_14 + 12];
                val_69 = val_14 + 12;
            }
            
            var val_28 = val_14 + 16;
            if(val_69 <= 1)
            {
                    val_69 = mem[val_14 + 12];
                val_69 = val_14 + 12;
            }
            
            float val_59 = val_14 + 16;
            float val_61 = val_14 + 20;
            float val_60 = val_14 + 24;
            val_59 = (val_14 + 28) - val_59;
            val_60 = (val_14 + 36) - val_60;
            val_61 = (val_14 + 32) - val_61;
            val_6 = 0;
            val_4 = 0;
            UnityEngine.Ray val_29 = new UnityEngine.Ray(origin:  new UnityEngine.Vector3() {x = mem[(val_14 + 16) + (0)], y = mem[(val_14 + 16) + (4)], z = mem[(val_14 + 16) + (8)]}, direction:  new UnityEngine.Vector3() {x = val_59, y = val_61, z = val_60});
            if((val_14 + 12) >= 2)
            {
                    val_70 = mem[val_14 + 28];
                val_70 = val_14 + 28;
                val_71 = mem[val_14 + 32];
                val_71 = val_14 + 32;
                val_72 = mem[val_14 + 36];
                val_72 = val_14 + 36;
            }
            else
            {
                    val_70 = mem[val_14 + 28];
                val_70 = val_14 + 28;
                val_71 = mem[val_14 + 32];
                val_71 = val_14 + 32;
                val_72 = mem[val_14 + 36];
                val_72 = val_14 + 36;
            }
            
            float val_63 = val_70;
            float val_62 = val_14 + 20;
            val_62 = val_71 - val_62;
            val_63 = val_63 - (val_14 + 16);
            float val_30 = val_72 - (val_14 + 24);
            float val_31 = val_63.magnitude;
            UnityEngine.LayerMask val_32 = UnityEngine.LayerMask.op_Implicit(intVal:  ~(UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.IgnoreLayer})));
            if((WrappingRopeLibrary.Utils.Geometry.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_29.m_Origin.x, y = val_29.m_Origin.y, z = val_29.m_Origin.z}, m_Direction = new UnityEngine.Vector3() {x = val_29.m_Direction.x, y = val_73, z = val_29.m_Direction.z}}, hitInfo: out  val_56, maxDistance:  918781368, layerMask:  new UnityEngine.LayerMask() {m_Mask = 918781368})) == false)
            {
                goto label_98;
            }
            
            label_114:
            val_74 = val_51;
            if(val_74 == 0)
            {
                    val_74 = val_51;
            }
            
            if(1 == mem[1152921509820607740])
            {
                goto label_91;
            }
            
            if((pieceInfo.<Piece>k__BackingField.BackBandPoint.Parent) == 0)
            {
                goto label_78;
            }
            
            val_73 = mem[pieceInfo.<Piece>k__BackingField.BackBandPoint + 44];
            val_73 = pieceInfo.<Piece>k__BackingField.BackBandPoint.Parent;
            if((hitInfo1 + 40) == val_73)
            {
                goto label_98;
            }
            
            label_78:
            if((pieceInfo.<Piece>k__BackingField.FrontBandPoint.Parent) == 0)
            {
                goto label_91;
            }
            
            val_73 = mem[pieceInfo.<Piece>k__BackingField.FrontBandPoint + 44];
            val_73 = pieceInfo.<Piece>k__BackingField.FrontBandPoint.Parent;
            if((hitInfo1 + 40) == val_73)
            {
                goto label_98;
            }
            
            label_91:
            val_75 = mem[val_14 + 12];
            val_75 = val_14 + 12;
            if(val_75 <= 1)
            {
                    val_75 = mem[val_14 + 12];
                val_75 = val_14 + 12;
            }
            
            var val_38 = val_14 + 28;
            if(val_75 == 0)
            {
                    val_75 = mem[val_14 + 12];
                val_75 = val_14 + 12;
            }
            
            float val_64 = val_14 + 28;
            float val_66 = val_14 + 32;
            float val_65 = val_14 + 36;
            val_64 = (val_14 + 16) - val_64;
            val_65 = (val_14 + 24) - val_65;
            val_66 = (val_14 + 20) - val_66;
            val_6 = 0;
            val_4 = 0;
            val_51 = 0;
            UnityEngine.Ray val_39 = new UnityEngine.Ray(origin:  new UnityEngine.Vector3() {x = mem[(val_14 + 28) + (0)], y = mem[(val_14 + 28) + (4)], z = mem[(val_14 + 28) + (8)]}, direction:  new UnityEngine.Vector3() {x = val_64, y = val_66, z = val_65});
            val_76 = mem[val_14 + 12];
            val_76 = val_14 + 12;
            if(val_76 == 0)
            {
                    val_76 = mem[val_14 + 12];
                val_76 = val_14 + 12;
            }
            
            float val_67 = val_14 + 28;
            float val_68 = val_14 + 32;
            float val_69 = val_14 + 36;
            val_67 = (val_14 + 16) - val_67;
            val_68 = (val_14 + 20) - val_68;
            val_69 = (val_14 + 24) - val_69;
            float val_41 = val_67;
            float val_40 = val_41.magnitude;
            val_54 = val_39.m_Direction.z;
            val_53 = hitInfo1;
            if((WrappingRopeLibrary.Utils.Geometry.TryRaycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_39.m_Origin.x, y = val_39.m_Origin.y, z = val_39.m_Origin.z}, m_Direction = new UnityEngine.Vector3() {x = val_39.m_Direction.x, y = val_39.m_Direction.y, z = val_54}}, gameObject:  hitInfo1 + 40, maxDistance:  918781368, hitInfo: out  val_41)) == true)
            {
                goto label_105;
            }
            
            if((pieceInfo.<Piece>k__BackingField.BackPiece) == 0)
            {
                goto label_110;
            }
            
            label_98:
            var val_70 = 1;
            val_70 = val_70 + 1;
            goto label_111;
            label_61:
            var val_44 = val_14 + 28;
            label_112:
            float val_72 = mem[(val_14 + 28) + (0)];
            float val_71 = val_14 + 20;
            val_71 = (mem[(val_14 + 28) + (4)]) - val_71;
            val_72 = val_72 - (val_14 + 16);
            float val_45 = (mem[(val_14 + 28) + (8)]) - (val_14 + 24);
            float val_47 = val_72;
            float val_46 = val_47.magnitude;
            if((WrappingRopeLibrary.Utils.Geometry.TryRaycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_39.m_Origin.x, y = val_39.m_Origin.y, z = val_39.m_Origin.z}, m_Direction = new UnityEngine.Vector3() {x = val_39.m_Direction.x, y = val_39.m_Direction.y, z = val_39.m_Direction.z}}, gameObject:  pieceInfo.<Piece>k__BackingField.FrontBandPoint.Parent, maxDistance:  918781368, hitInfo: out  val_47)) == false)
            {
                goto label_113;
            }
            
            goto label_114;
            label_21:
            val_77 = 2;
            goto label_115;
            label_105:
            var val_49 = val_14 + 16;
            val_54 = mem[val_14 + 28];
            val_54 = val_14 + 28;
            <BackBandPoint>k__BackingField = val_54;
            mem2[0] = val_14 + 32;
            mem2[0] = val_14 + 36;
            val_78 = 1;
            val_77 = 4;
            goto label_120;
            label_110:
            val_77 = 4;
            label_115:
            val_78 = 0;
            label_120:
            Dispose();
            var val_50 = val_77 - 4;
            val_50 = val_50 >> 5;
            val_55 = val_50 & val_78;
            return (bool)val_55;
            label_209:
            if( == 1)
            {
                    Dispose();
                if(mem[pieceInfo] == 0)
            {
                    return (bool)val_55;
            }
            
                return (bool)val_55;
            }
        
        }
        private System.Collections.Generic.List<UnityEngine.Vector3[]> GetPieceMoveStages(WrappingRopeLibrary.Model.PieceInfo pieceInfo)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_30;
            UnityEngine.Vector3 val_31;
            float val_32;
            float val_33;
            UnityEngine.Vector3 val_34;
            var val_35;
            float val_36;
            var val_37;
            float val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            val_30 = this;
            536877683 = new System.Collections.Generic.List<Page>();
            if(pieceInfo != 0)
            {
                    WrappingRopeLibrary.Model.PieceInfo val_2 = pieceInfo + 40;
                WrappingRopeLibrary.Model.PieceInfo val_3 = pieceInfo + 36;
                val_31 = pieceInfo.<PrevFrontBandPoint>k__BackingField;
            }
            else
            {
                    val_33 = 2.938809E-39f;
                val_32 = 6.018898E-36f;
                val_31 = 4.085283E-38f;
            }
            
            UnityEngine.Vector3 val_17 = pieceInfo.<FrontBandPoint>k__BackingField;
            val_17 = val_31 - val_17;
            float val_4 = val_32 - S2;
            float val_5 = val_33 - S4;
            float val_6 = val_17.sqrMagnitude;
            if(pieceInfo != 0)
            {
                    val_34 = pieceInfo.<PrevBackBandPoint>k__BackingField;
                val_35 = pieceInfo + 52;
                val_37 = pieceInfo + 48;
            }
            else
            {
                    val_37 = 48;
                val_35 = 52;
                val_38 = 8.407791E-45f;
                val_36 = 2.571435E-39f;
                val_34 = 3.673431E-39f;
            }
            
            UnityEngine.Vector3 val_18 = pieceInfo.<BackBandPoint>k__BackingField;
            val_18 = val_34 - val_18;
            val_4 = val_36 - val_4;
            val_5 = val_38 - val_5;
            float val_7 = val_18.sqrMagnitude;
            float val_19 = this.Threshold;
            val_19 = val_19 * val_19;
            if(pieceInfo > 0)
            {
                    var val_20 = mem[536890481];
                val_20 = val_20 & 512;
                if(pieceInfo > 0)
            {
                    if(mem[536890411] >= _TYPE_MAX_)
            {
                    val_39 = 918909592;
            }
            
                UnityEngine.Vector3 val_21 = pieceInfo.<FrontBandPoint>k__BackingField;
                val_21 = (pieceInfo.<PrevFrontBandPoint>k__BackingField) - val_21;
                float val_23 = 2.938809E-39f;
                val_4 = (6.018898E-36f) - val_4;
                val_5 = val_23 - val_5;
                UnityEngine.Vector3 val_8 = normalized;
                val_40 = val_39 / this.Threshold;
                UnityEngine.Vector3 val_22 = pieceInfo.<BackBandPoint>k__BackingField;
                val_22 = (pieceInfo.<PrevBackBandPoint>k__BackingField) - val_22;
                val_23 = val_37 - val_23;
                val_41 = val_22 / val_40;
                val_42 = (val_35 - S12) / val_40;
                val_43 = val_23 / val_40;
                val_44 = val_12 * this.Threshold;
                val_45 = val_11 * this.Threshold;
                val_46 = val_10 * this.Threshold;
            }
            else
            {
                    if(mem[536890411] >= _TYPE_MAX_)
            {
                    val_47 = 918909592;
            }
            
                UnityEngine.Vector3 val_24 = pieceInfo.<BackBandPoint>k__BackingField;
                val_24 = (pieceInfo.<PrevBackBandPoint>k__BackingField) - val_24;
                float val_26 = 8.407791E-45f;
                val_4 = (2.571435E-39f) - val_4;
                val_5 = val_26 - val_5;
                UnityEngine.Vector3 val_13 = normalized;
                val_40 = val_47 / this.Threshold;
                UnityEngine.Vector3 val_25 = pieceInfo.<FrontBandPoint>k__BackingField;
                val_25 = (pieceInfo.<PrevFrontBandPoint>k__BackingField) - val_25;
                val_26 = (6.018898E-36f) - val_26;
                val_44 = ((2.938809E-39f) - S12) / val_40;
                val_46 = val_25 / val_40;
                val_45 = val_26 / val_40;
                val_42 = val_12 * this.Threshold;
                val_43 = val_11 * this.Threshold;
                val_41 = val_10 * this.Threshold;
            }
            
                var val_33 = (int)val_40;
                if((val_33 + 1) >= 2)
            {
                    UnityEngine.Vector3 val_29 = pieceInfo.<PrevFrontBandPoint>k__BackingField;
                UnityEngine.Vector3 val_32 = pieceInfo.<PrevBackBandPoint>k__BackingField;
                float val_28 = 6.018898E-36f;
                float val_31 = 2.571435E-39f;
                float val_30 = 8.407791E-45f;
                float val_27 = 2.938809E-39f;
                val_30 = 22708680;
                do
            {
                val_27 = val_27 - val_44;
                val_48 = mem[536882609];
                val_28 = val_28 - val_45;
                val_29 = val_29 - val_46;
                if(val_48 == 0)
            {
                    val_48 = mem[536882609];
            }
            
                val_30 = val_30 - val_42;
                val_31 = val_31 - val_43;
                mem[536882613] = val_29;
                val_32 = val_32 - val_41;
                mem[536882617] = val_28;
                mem[536882621] = val_27;
                mem[536882625] = val_32;
                mem[536882629] = val_31;
                mem[536882633] = val_30;
                536877683.Add(item:  536882597);
                val_33 = val_33 - 1;
            }
            while(536877683 != 0);
            
            }
            
            }
            
            val_49 = mem[536882609];
            if(val_49 == 0)
            {
                    val_49 = mem[536882609];
            }
            
            var val_16 = 536882597 + 16;
            mem[536882625] = pieceInfo.<BackBandPoint>k__BackingField;
            mem[536882629] = val_37;
            mem[536882633] = pieceInfo;
            536877683.Add(item:  536882597);
        }
        protected int GetActionLayer()
        {
            return (int)~(UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.IgnoreLayer}));
        }
        private int GetIgnoreLayerForPiece()
        {
            var val_4;
            mem[536882081] = this.IgnoreLayer.value;
            val_4 = 0;
            536884161 = new System.Collections.BitArray(values:  536882065);
            goto label_3;
            label_6:
            if(val_2.Item[0] == true)
            {
                    return 0;
            }
            
            val_4 = 1;
            label_3:
            if(val_4 < mem[536884173])
            {
                goto label_6;
            }
            
            return 0;
        }
        private void CheckAndCorrectIgnoreLayerName()
        {
            var val_6 = this;
            if(this.IgnoreLayer.value != 0)
            {
                    if(this.IgnoreLayer.value != 1)
            {
                    return;
            }
            
            }
            
            UnityEngine.LayerMask val_4 = UnityEngine.LayerMask.op_Implicit(intVal:  R4.GetAndCorrectLayerFormString());
            mem2[0] = val_4.m_Mask;
        }
        private int GetAndCorrectLayerFormString()
        {
            var val_6;
            if((System.String.IsNullOrEmpty(value:  this._ignoreLayer)) == false)
            {
                goto label_1;
            }
            
            val_6 = 22787356;
            goto label_4;
            label_1:
            if((System.String.op_Equality(a:  this._ignoreLayer, b:  -1610608815)) == false)
            {
                goto label_3;
            }
            
            val_6 = 22787348;
            goto label_4;
            label_3:
            if((UnityEngine.LayerMask.NameToLayer(layerName:  this._ignoreLayer)) != 1)
            {
                goto label_5;
            }
            
            val_6 = 22787352;
            label_4:
            string val_4 = System.String.Format(format:  -1610597045, arg0:  -1610607495);
            UnityEngine.Debug.LogWarning(message:  -1610597045);
            this._ignoreLayer = -1610607499;
            label_5:
            int val_5 = UnityEngine.LayerMask.NameToLayer(layerName:  -1610607499);
            val_5 = val_5 & 31;
            val_5 = 1 << val_5;
            return (int)val_5;
        }
        private void OnDestroy()
        {
            if(UnityEngine.Application.isEditor != false)
            {
                    this.DestroyRopeInEditor();
                return;
            }
            
            this.DestroyRope();
        }
        protected void DestroyRope()
        {
            var val_8;
            WrappingRopeLibrary.Scripts.Piece val_9;
            UnityEngine.Object val_10;
            if(this._isDestroyed == true)
            {
                    return;
            }
            
            val_8 = this;
            val_9 = this._frontPiece;
            if(val_9 == 0)
            {
                    return;
            }
            
            this._frontPiece.FrontBandPoint = 0;
            do
            {
                UnityEngine.GameObject val_2 = val_9.gameObject;
                val_10 = val_9;
                if(val_10 != 0)
            {
                    UnityEngine.GameObject val_4 = val_9.gameObject;
                val_10 = val_9;
                UnityEngine.Object.Destroy(obj:  val_10);
            }
            
                val_9 = this._frontPiece.BackPiece;
            }
            while(val_9 != 0);
            
            this._frontPiece = 0;
            if(this._backPiece == 0)
            {
                    return;
            }
            
            this._backPiece.BackBandPoint = 0;
        }
        protected void DestroyRopeInEditor()
        {
            var val_8;
            WrappingRopeLibrary.Scripts.Piece val_9;
            WrappingRopeLibrary.Scripts.Piece val_10;
            if(this._isDestroyed == true)
            {
                    return;
            }
            
            val_8 = this;
            val_9 = this._frontPiece;
            if(val_9 == 0)
            {
                goto label_6;
            }
            
            this._frontPiece.FrontBandPoint = 0;
            goto label_6;
            label_18:
            if(val_9 != 0)
            {
                    this._frontPiece.DontReorganizeWhenDestroy = true;
            }
            else
            {
                    mem[120] = 1;
            }
            
            UnityEngine.GameObject val_2 = val_9.gameObject;
            if(val_9 != 0)
            {
                    UnityEngine.GameObject val_4 = val_9.gameObject;
                UnityEngine.Object.DestroyImmediate(obj:  val_9);
            }
            
            val_9 = this._frontPiece.BackPiece;
            label_6:
            val_10 = 0;
            if(val_9 != 0)
            {
                goto label_18;
            }
            
            this._frontPiece = val_10;
            if(this._backPiece == 0)
            {
                    return;
            }
            
            this._backPiece.BackBandPoint = 0;
        }
        private void OnApplicationQuit()
        {
            this.OnDestroy();
            this._isDestroyed = true;
        }
        public void OnBeforeSerialize()
        {
        
        }
        public RopeBase()
        {
            this.MaxPieceCount = 200;
            this.Tiling = 1f;
            536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this._initProfile = 536878517;
            UnityEngine.Quaternion val_2 = new UnityEngine.Quaternion(x:  null, y:  null, z:  null, w:  null);
        }
    
    }

}
