using UnityEngine;

namespace WrappingRopeLibrary.Scripts
{
    public class Piece : MonoBehaviour
    {
        // Fields
        public WrappingRopeLibrary.Scripts.Piece FrontPiece;
        public WrappingRopeLibrary.Scripts.Piece BackPiece;
        public WrappingRopeLibrary.Model.WrapPoint FrontBandPoint;
        public WrappingRopeLibrary.Model.WrapPoint BackBandPoint;
        internal UnityEngine.Vector3 PrevFrontBandPoint;
        internal UnityEngine.Vector3 PrevBackBandPoint;
        protected WrappingRopeLibrary.Scripts.RopeBase _rope;
        protected System.Guid PieceUid;
        private System.Nullable<UnityEngine.Vector3> <LastWrapPointPosition>k__BackingField;
        private float _length;
        private UnityEngine.GameObject _bendPointInstance;
        protected System.Collections.Generic.List<WrappingRopeLibrary.Scripts.Piece.NodeArray> _sections;
        protected float _backSectionDistance;
        protected float _maxDistance;
        public int SharedNodeIndex;
        private UnityEngine.Material _workMaterial;
        private UnityEngine.Material _material;
        public bool DontReorganizeWhenDestroy;
        private bool <IsCurrentlyBanded>k__BackingField;
        protected UnityEngine.Vector3[] _baseProfile;
        protected UnityEngine.Vector3[] _helpProfile;
        protected UnityEngine.Vector3 _kneePoint;
        protected UnityEngine.Vector3 _frontBound;
        protected UnityEngine.Vector3 _backBound;
        protected float _frontExtend;
        protected float _backExtend;
        public System.Nullable<int> SharedVertexIndex;
        public System.Nullable<int> SharedUvLeamVertexIndex;
        private bool _isDestroyed;
        
        // Properties
        internal float Threshold { get; }
        internal float WrapDistance { get; }
        internal System.Nullable<UnityEngine.Vector3> LastWrapPointPosition { get; set; }
        public float Length { get; }
        internal bool IsCurrentlyBanded { get; set; }
        
        // Methods
        internal float get_Threshold()
        {
            if(this._rope != 0)
            {
                    return (float)S0;
            }
            
            return (float)S0;
        }
        internal float get_WrapDistance()
        {
            if(this._rope != 0)
            {
                    return (float)S0;
            }
            
            return (float)S0;
        }
        internal System.Nullable<UnityEngine.Vector3> get_LastWrapPointPosition()
        {
            var val_1 = R1 + 72;
            return (System.Nullable<UnityEngine.Vector3>)this;
        }
        internal void set_LastWrapPointPosition(System.Nullable<UnityEngine.Vector3> value)
        {
        
        }
        public float get_Length()
        {
            return (float)S0;
        }
        private void Awake()
        {
            this.DontReorganizeWhenDestroy = false;
        }
        public void Init(WrappingRopeLibrary.Model.WrapPoint fBP, WrappingRopeLibrary.Model.WrapPoint bBP, WrappingRopeLibrary.Scripts.Piece fP, WrappingRopeLibrary.Scripts.Piece bP, WrappingRopeLibrary.Scripts.RopeBase rope, int layer, bool resetPrevBandPoints = True)
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            this.layer = layer;
            this.FrontBandPoint = fBP;
            this.BackBandPoint = bBP;
            this.FrontPiece = fP;
            this.BackPiece = bP;
            this._rope = rope;
            if(fP != 0)
            {
                    UnityEngine.GameObject val_3 = this._rope.GetBendInstance();
                this._bendPointInstance = this._rope;
            }
            
            System.Guid val_4 = System.Guid.NewGuid();
            UnityEngine.GameObject val_5 = this.gameObject;
            string val_6 = System.String.Format(format:  -1610605369, arg0:  536887587);
            this.name = -1610605369;
            if(fP != 0)
            {
                    fP.BackPiece = this;
            }
            
            if(bP != 0)
            {
                    bP.FrontPiece = this;
            }
            
            this.SaveBandPointPositions();
            this.Relocate(resetPrevBandPoints:  resetPrevBandPoints);
            this.InitMeshProfilesAndSections();
        }
        public void InitMeshProfilesAndSections()
        {
            UnityEngine.Vector3[] val_1 = this._rope.GetWorkProfileClone();
            this._baseProfile = this._rope;
            UnityEngine.Vector3[] val_2 = this._rope.GetWorkProfileClone();
            this._helpProfile = this._rope;
            this.CreateSections();
        }
        protected void CreateSections()
        {
            var val_7;
            System.Collections.Generic.List<WrappingRopeLibrary.Model.Node> val_8;
            var val_9;
            536878637 = new System.Collections.Generic.List<Page>();
            mem[1152921509806400944] = 536878637;
            val_7 = 0;
            goto label_1;
            label_9:
            val_8 = 536878109;
            val_8 = new System.Collections.Generic.List<WrappingRopeLibrary.Model.Node>();
            val_9 = 0;
            goto label_2;
            label_5:
            WrappingRopeLibrary.Model.Node val_3 = new WrappingRopeLibrary.Model.Node(normalsCount:  6);
            val_8 = val_8;
            val_8.Add(item:  new WrappingRopeLibrary.Model.Node() {_vertex = new UnityEngine.Vector3() {x = val_3._vertex.x, y = val_3._vertex.y, z = val_3._vertex.z}, _uv = new UnityEngine.Vector2() {x = val_3._uv.x, y = val_3._uv.y}, _normalCount = val_3._normalCount, Normals = val_3.Normals, <VertexIndex>k__BackingField = val_3.<VertexIndex>k__BackingField, <UvLeamVertexIndex>k__BackingField = val_3.<UvLeamVertexIndex>k__BackingField, _averageNormal = new UnityEngine.Vector3() {x = val_3._averageNormal.x, y = val_3._averageNormal.y, z = val_3._averageNormal.z}});
            val_9 = 1;
            label_2:
            if(val_9 < (mem[1152921509806400972] + 12))
            {
                goto label_5;
            }
            
            T[] val_4 = val_8.ToArray();
            536900291 = new Piece.NodeArray(array:  536878109);
            mem[536878637].Add(item:  536900291);
            val_7 = 1;
            label_1:
            int val_6 = mem[1152921509806400900].BendCrossectionsNumber;
            val_6 = val_6 + 2;
            if(val_7 < val_6)
            {
                goto label_9;
            }
        
        }
        public void Init(WrappingRopeLibrary.Model.WrapPoint fBP, WrappingRopeLibrary.Model.WrapPoint bBP, WrappingRopeLibrary.Scripts.Piece fP, WrappingRopeLibrary.Scripts.Piece bP, WrappingRopeLibrary.Scripts.RopeBase rope, UnityEngine.Vector3 pfBP, UnityEngine.Vector3 pbBP, int layer, bool resetPrevBandPoints = True)
        {
            this.Init(fBP:  fBP, bBP:  bBP, fP:  fP, bP:  bP, rope:  rope, layer:  layer, resetPrevBandPoints:  resetPrevBandPoints);
            this.PrevBackBandPoint = pbBP;
            mem[1152921509806533372] = pbBP.y;
            mem[1152921509806533376] = 0;
        }
        private void SaveBandPointPositions()
        {
            if(this.BackBandPoint == 0)
            {
                    if(this.BackBandPoint == 0)
            {
                goto label_1;
            }
            
            }
            
            label_1:
            if(this.FrontBandPoint != 0)
            {
                    return;
            }
            
            if(this.FrontBandPoint == 0)
            {
                    return;
            }
        
        }
        internal bool get_IsCurrentlyBanded()
        {
            return (bool)this.<IsCurrentlyBanded>k__BackingField;
        }
        internal void set_IsCurrentlyBanded(bool value)
        {
            this.<IsCurrentlyBanded>k__BackingField = value;
        }
        public void Relocate(bool resetPrevBandPoints = True)
        {
            UnityEngine.Vector3 val_4 = this.FrontBandPoint.positionInWorldSpace;
            val_4 = this.BackBandPoint.positionInWorldSpace - val_4;
            float val_1 = S20 - S2;
            float val_2 = S18 - S4;
            float val_3 = val_4.magnitude;
            this._length = ;
        }
        private void Update()
        {
            this.RefreshPosition();
        }
        internal void RefreshPosition()
        {
            float val_9;
            float val_10;
            float val_11;
            float val_15;
            float val_34;
            float val_35;
            float val_36;
            float val_37;
            float val_38;
            float val_39;
            float val_40;
            float val_41;
            float val_42;
            var val_43;
            WrappingRopeLibrary.Scripts.RopeBase val_44;
            var val_45;
            UnityEngine.Vector3 val_46;
            WrappingRopeLibrary.Scripts.RopeBase val_47;
            var val_48;
            WrappingRopeLibrary.Scripts.RopeBase val_49;
            var val_50;
            float val_51;
            float val_52;
            WrappingRopeLibrary.Scripts.RopeBase val_53;
            float val_54;
            if(this.FrontPiece == 0)
            {
                    val_34 = 0f;
            }
            else
            {
                    val_34 = this._rope.WrapDistance;
            }
            
            this.FrontBandPoint.SetPointInWorldSpace(wrapDistance:  null);
            if(this.BackPiece == 0)
            {
                    val_35 = 0f;
            }
            else
            {
                    val_35 = this._rope.WrapDistance;
            }
            
            this.BackBandPoint.SetPointInWorldSpace(wrapDistance:  null);
            this.Relocate(resetPrevBandPoints:  false);
            UnityEngine.Vector3 val_34 = this.BackBandPoint.positionInWorldSpace;
            UnityEngine.Transform val_3 = this.transform;
            val_34 = this.FrontBandPoint.positionInWorldSpace - val_34;
            UnityEngine.Vector3 val_35 = this.BackBandPoint.positionInWorldSpace;
            val_36 = S20 - S26;
            val_35 = this.FrontBandPoint.positionInWorldSpace + val_35;
            float val_6 = S18 + S2;
            float val_7 = S20 + S4;
            val_37 = S18 - S24;
            val_35 = val_35 * 0.5f;
            val_6 = val_6 * 0.5f;
            val_7 = val_7 * 0.5f;
            val_38 = val_35;
            val_39 = val_6;
            val_40 = val_7;
            this.position = new UnityEngine.Vector3() {x = val_38, y = val_39, z = val_40};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            val_41 = val_11;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_34, y = val_37, z = val_36}, rhs:  new UnityEngine.Vector3() {x = val_41, y = val_10, z = val_9})) == true)
            {
                    return;
            }
            
            val_39 = val_37;
            val_37 = this;
            if(this._rope.ExtendAxis == 2)
            {
                goto label_20;
            }
            
            if(this._rope.ExtendAxis == 1)
            {
                goto label_21;
            }
            
            if(this._rope.ExtendAxis != 0)
            {
                goto label_22;
            }
            
            val_38 = 0;
            UnityEngine.Transform val_13 = this.transform;
            UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = 1.855099E-06f, y = val_34, z = val_39});
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.down;
            UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.AngleAxis(angle:  val_16.x, axis:  new UnityEngine.Vector3() {x = 1.855099E-06f, y = 90f, z = val_11});
            UnityEngine.Quaternion val_18 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = 1.855099E-06f, y = val_11, z = val_10, w = val_9}, rhs:  new UnityEngine.Quaternion() {x = val_15});
            val_42 = val_10;
            val_41 = val_9;
            this.rotation = new UnityEngine.Quaternion() {x = val_11, y = val_42, z = val_41, w = val_15};
            val_43 = 0;
            UnityEngine.Transform val_19 = this.transform;
            val_44 = this._rope;
            val_36 = val_37;
            if(val_44 == 0)
            {
                goto label_24;
            }
            
            val_45 = mem[1152921509807336488];
            val_46 = this._rope._pieceInstanceRatio;
            goto label_25;
            label_21:
            val_38 = 0f;
            UnityEngine.Transform val_20 = this.transform;
            UnityEngine.Quaternion val_21 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = 1.855099E-06f, y = val_34, z = val_39}, upwards:  new UnityEngine.Vector3() {x = val_36, y = val_38, z = 1f});
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.right;
            UnityEngine.Quaternion val_23 = UnityEngine.Quaternion.AngleAxis(angle:  val_22.x, axis:  new UnityEngine.Vector3() {x = 1.855099E-06f, y = 90f, z = val_11});
            UnityEngine.Quaternion val_24 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = 1.855099E-06f, y = val_11, z = val_10, w = val_9}, rhs:  new UnityEngine.Quaternion() {x = val_15});
            val_42 = val_10;
            val_41 = val_9;
            this.rotation = new UnityEngine.Quaternion() {x = val_11, y = val_42, z = val_41, w = val_15};
            val_43 = 0;
            UnityEngine.Transform val_25 = this.transform;
            val_47 = this._rope;
            val_48 = val_37;
            if(val_47 == 0)
            {
                goto label_27;
            }
            
            val_36 = this._rope._pieceInstanceRatio;
            goto label_28;
            label_20:
            val_38 = 0;
            UnityEngine.Transform val_26 = this.transform;
            UnityEngine.Quaternion val_27 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = 1.855099E-06f, y = val_34, z = val_39});
            val_42 = R7;
            val_41 = R8;
            this.rotation = new UnityEngine.Quaternion() {x = R4, y = val_42, z = val_41, w = val_15};
            val_43 = 0;
            UnityEngine.Transform val_28 = this.transform;
            val_49 = this._rope;
            val_48 = val_37;
            if(val_49 == 0)
            {
                goto label_30;
            }
            
            val_36 = this._rope._pieceInstanceRatio;
            goto label_31;
            label_27:
            val_36 = this._rope._pieceInstanceRatio;
            val_47 = this._rope;
            if(val_47 == 0)
            {
                goto label_32;
            }
            
            label_28:
            label_53:
            var val_36 = mem[1152921509807336488];
            val_36 = val_24.z * val_36;
            val_50 = val_36;
            goto label_33;
            label_30:
            val_36 = this._rope._pieceInstanceRatio;
            val_49 = this._rope;
            if(val_49 == 0)
            {
                goto label_34;
            }
            
            label_31:
            label_55:
            var val_37 = mem[1152921509807336488];
            val_37 = val_27.z * val_37;
            val_39 = val_37;
            label_33:
            val_51 = val_36;
            val_52 = val_49;
            val_41 = val_39;
            goto label_36;
            label_24:
            val_46 = this._rope._pieceInstanceRatio;
            val_44 = this._rope;
            val_45 = mem[1152921509807336488];
            if(val_44 == 0)
            {
                goto label_37;
            }
            
            label_25:
            label_59:
            val_39 = val_46 * val_45;
            val_51 = val_39;
            val_52 = val_44;
            val_41 = val_10;
            label_36:
            this.localScale = new UnityEngine.Vector3() {x = val_51, y = val_52, z = val_41};
            label_22:
            val_40 = 22713552;
            if(this.FrontPiece == 0)
            {
                goto label_44;
            }
            
            val_42 = 0;
            if(mem[1152921509807336492] == 0)
            {
                goto label_44;
            }
            
            val_43 = 0;
            UnityEngine.Transform val_32 = mem[1152921509807336492].transform;
            val_53 = this._rope;
            if(val_53 == 0)
            {
                goto label_46;
            }
            
            val_54 = this._rope._bendInstanceRatio;
            goto label_47;
            label_46:
            val_54 = this._rope._bendInstanceRatio;
            val_53 = this._rope;
            if(val_53 == 0)
            {
                goto label_48;
            }
            
            label_47:
            label_57:
            mem[1152921509807336492].localScale = new UnityEngine.Vector3() {x = val_54, y = this._rope._bendInstanceRatio, z = this._rope._bendInstanceRatio};
            UnityEngine.Transform val_33 = mem[1152921509807336492].transform;
            val_40 = this.FrontBandPoint;
            val_38 = this.FrontBandPoint.positionInWorldSpace;
            mem[1152921509807336492].position = new UnityEngine.Vector3() {x = val_38, y = this._rope._bendInstanceRatio, z = val_54};
            label_44:
            this.SetBaseProfile();
            return;
            label_32:
            if(this._rope != 0)
            {
                goto label_53;
            }
            
            goto label_58;
            label_34:
            if(this._rope != 0)
            {
                goto label_55;
            }
            
            goto label_58;
            label_48:
            if(this._rope != 0)
            {
                goto label_57;
            }
            
            goto label_58;
            label_37:
            if(this._rope != 0)
            {
                goto label_59;
            }
            
            label_58:
        }
        internal void Knee(WrappingRopeLibrary.Model.WrapPoint point)
        {
            WrappingRopeLibrary.Scripts.RopeBase val_8;
            UnityEngine.GameObject val_1 = this._rope.GetPieceInstance();
            Weight val_2 = this._rope.GetComponent<Weight>();
            if(this._rope == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_4 = this.gameObject;
            this._rope.Init(fBP:  point, bBP:  this.BackBandPoint, fP:  905707856, bP:  this.BackPiece, rope:  this._rope, layer:  this.layer, resetPrevBandPoints:  false);
            this._rope.Threshold = point.positionInWorldSpace;
            this._rope.WrapDistance = ;
            this._rope._pieceInstance = 0;
            this._rope.BendInstance = this.PrevBackBandPoint;
            this._rope._width = this.PrevBackBandPoint;
            this._rope.ExtendAxis = 0;
            this.BackBandPoint = point;
            mem2[0] = true;
            this.<IsCurrentlyBanded>k__BackingField = true;
            val_8 = this._rope;
            if(val_8 != 0)
            {
                    val_8 = this._rope._material;
                if(val_8 == 0)
            {
                    val_8 = this._rope;
                this._rope._backPiece = this._rope;
            }
            
            }
            
            this.Relocate(resetPrevBandPoints:  false);
        }
        internal UnityEngine.Vector3 DefineBackBandPointVelocity()
        {
            float val_2 = UnityEngine.Time.fixedDeltaTime;
            float val_3 = (R1 + 24 + 36) - (R1 + 44);
            uint val_6 = 0;
            val_3 = val_3 / val_6;
            val_6 = ((R1 + 24 + 40) - (R1 + 48)) / val_6;
            this = ((R1 + 24 + 32) - (R1 + 40)) / val_6;
            mem[1152921509807662804] = val_3;
            mem[1152921509807662808] = val_6;
            return new UnityEngine.Vector3() {z = val_3};
        }
        internal UnityEngine.Vector3 DefineFrontBandPointVelocity()
        {
            float val_2 = UnityEngine.Time.fixedDeltaTime;
            float val_3 = (R1 + 20 + 36) - (R1 + 32);
            uint val_6 = 0;
            val_3 = val_3 / val_6;
            val_6 = ((R1 + 20 + 40) - (R1 + 36)) / val_6;
            this = ((R1 + 20 + 32) - (R1 + 28)) / val_6;
            mem[1152921509807774804] = val_3;
            mem[1152921509807774808] = val_6;
            return new UnityEngine.Vector3() {z = val_3};
        }
        internal void TransformTexture(UnityEngine.Vector2 scale, UnityEngine.Vector2 translate)
        {
        
        }
        protected void SetBaseProfile()
        {
            if(this.FrontPiece != 0)
            {
                    return;
            }
            
            System.Array.Copy(sourceArray:  R4 + 52 + 136, destinationArray:  R4 + 124, length:  R4 + 124 + 12);
        }
        internal void LocateSections(float ropeLength, ref float lengthBefore)
        {
            this.SetBaseProfile();
            this.SetKneeSections();
            float val_1 = this._length;
            val_1 = R2 + val_1;
            mem2[0] = val_1;
        }
        internal System.Collections.Generic.List<WrappingRopeLibrary.Model.Node[]> GetSections()
        {
            WrappingRopeLibrary.Scripts.Piece val_4;
            var val_5;
            var val_6;
            536877681 = new System.Collections.Generic.List<Page>();
            val_4 = this.BackPiece;
            val_5 = 0;
            bool val_2 = UnityEngine.Object.op_Equality(x:  val_4, y:  0);
            val_6 = 2;
            if(val_2 != true)
            {
                    if(this._sections < 1)
            {
                    return;
            }
            
            }
            
            do
            {
                if(val_2 <= val_5)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4 = val_4 + 0;
                WrappingRopeLibrary.Model.Node[] val_3 = Piece.NodeArray.op_Implicit(nodeArray:  (0 + 0) + 16);
                val_4 = (0 + 0) + 16;
                536877681.Add(item:  val_4);
                val_5 = val_5 + 1;
            }
            while(this._sections != val_5);
        
        }
        protected void LocateMainSections(float ropeLength, float lengthBefore)
        {
        
        }
        private WrappingRopeLibrary.Scripts.Piece.MaxIndex GetMaxIndex(System.Collections.Generic.List<float> list)
        {
            float val_2;
            float val_5;
            var val_6;
            var val_7;
            if(true == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = 3.673424E-39f;
            List.Enumerator<T> val_1 = GetEnumerator();
            val_6 = 0;
            val_7 = 0;
            goto label_3;
            label_4:
            if(true > 0)
            {
                    val_5 = val_2;
                val_7 = val_6;
            }
            
            val_6 = 1;
            label_3:
            if(MoveNext() == true)
            {
                goto label_4;
            }
            
            Dispose();
            Piece.MaxIndex val_4 = 536900289;
            val_4 = new Piece.MaxIndex();
            if(val_4 != 0)
            {
                    mem[536900297] = val_7;
            }
            else
            {
                    mem[8] = val_7;
            }
            
            mem[536900301] = val_5;
        }
        protected void TranslateProfileToSection(WrappingRopeLibrary.Model.Node[] section, UnityEngine.Vector3[] profile, UnityEngine.Vector3 direction, float extend)
        {
            var val_6;
            var val_7;
            UnityEngine.Vector3[] val_9;
            var val_12;
            val_9 = profile;
            val_12 = 0;
            goto label_0;
            label_8:
            mem2[0] = 1152921504993032688 + direction.x;
            mem2[0] = S2 + direction.y;
            mem2[0] = S4 + direction.z;
            UnityEngine.Vector2 val_5 = WrappingRopeLibrary.Utils.UVMappper.GetUv(uvLocation:  906855200, cross:  0f, extend:  null);
            mem2[0] = val_6;
            mem2[0] = val_7;
            section[32] - 16.ResetNormals();
            val_9 = profile;
            val_12 = 1;
            label_0:
            if(val_12 < (profile + 12))
            {
                goto label_8;
            }
        
        }
        protected void SetKneeSections()
        {
            bool val_1 = UnityEngine.Object.op_Equality(x:  this.FrontPiece, y:  0);
            if(val_1 == true)
            {
                    return;
            }
            
            goto label_4;
            label_10:
            val_1 = val_1 - 1;
            float val_3 = (float)val_1;
            val_3 = 1f / val_3;
            if(val_1 <= 2)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 8;
            WrappingRopeLibrary.Model.Node[] val_2 = Piece.NodeArray.op_Implicit(nodeArray:  (0 + 8) + 16);
            this.SetMiddleSection(targetSection:  (0 + 8) + 16, amount:  2);
            label_4:
            if(this._sections < 0)
            {
                goto label_10;
            }
        
        }
        protected void SetMiddleSection(WrappingRopeLibrary.Model.Node[] targetSection, float amount)
        {
            float val_2;
            float val_3;
            float val_4;
            WrappingRopeLibrary.Scripts.Piece val_8;
            float val_9;
            var val_15 = 0;
            label_13:
            if(val_15 >= 0)
            {
                    return;
            }
            
            val_8 = this.FrontPiece;
            if(val_8 == 0)
            {
                goto label_2;
            }
            
            val_9 = this._frontExtend;
            goto label_3;
            label_2:
            val_9 = this._frontExtend;
            if(this.FrontPiece == 0)
            {
                goto label_4;
            }
            
            val_8 = this.FrontPiece;
            label_3:
            float val_8 = this.FrontPiece._backExtend;
            label_15:
            val_8 = val_9 - val_8;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.Slerp(a:  new UnityEngine.Vector3() {x = 2.19688E-06f, y = this.FrontPiece._frontBound, z = 2.19962E-06f}, b:  new UnityEngine.Vector3() {x = this.FrontPiece, y = mem[this.FrontPiece._backBound + (0)], z = mem[this.FrontPiece._backBound + (4)]}, t:  val_8);
            float val_11 = val_2;
            float val_12 = val_3;
            float val_13 = val_4;
            var val_9 = 0;
            val_9 = mem[1152921509809069488] + val_9;
            UnityEngine.Vector3 val_10 = this.FrontPiece._kneePoint;
            val_10 = ((mem[1152921509809069488] + 0) + 16) + val_10;
            val_1.z = ((mem[1152921509809069488] + 0) + 20) + val_1.z;
            val_11 = val_11 + val_10;
            val_12 = val_12 + val_1.z;
            val_13 = val_13 + (((mem[1152921509809069488] + 0) + 24) + S4);
            mem2[0] = val_11;
            mem2[0] = val_12;
            mem2[0] = val_13;
            float val_14 = (float)val_10;
            val_14 = 0f / val_14;
            UnityEngine.Vector2 val_6 = WrappingRopeLibrary.Utils.UVMappper.GetUv(uvLocation:  907243036, cross:  val_14, extend:  val_1.y);
            targetSection[32] - 16.ResetNormals();
            val_15 = val_15 + 1;
            goto label_13;
            label_4:
            if(this.FrontPiece == 0)
            {
                goto label_14;
            }
            
            goto label_15;
            label_14:
        }
        protected void DestroyBendPointInstance()
        {
            var val_2 = mem[536891407];
            val_2 = val_2 & 512;
            if(UnityEngine.Application.isEditor != false)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  this._bendPointInstance);
                return;
            }
            
            UnityEngine.Object.Destroy(obj:  this._bendPointInstance);
        }
        private void OnDestroy()
        {
            this.DistroyPiece();
        }
        protected void DistroyPiece()
        {
            if(this._isDestroyed == true)
            {
                    return;
            }
            
            if((R4 + 12) == 0)
            {
                    if((R4 + 16) != 0)
            {
                    R4 + 16.DestroyBendPointInstance();
            }
            
            }
            
            R4.DestroyBendPointInstance();
            if((R4 + 120) == 0)
            {
                    R4 + 120 = R4;
                R4 + 120.Reorganize();
            }
            
            mem2[0] = 1;
        }
        protected void Reorganize()
        {
            WrappingRopeLibrary.Scripts.Piece val_9;
            WrappingRopeLibrary.Scripts.Piece val_10;
            WrappingRopeLibrary.Scripts.RopeBase val_11;
            if(this.FrontPiece == 0)
            {
                    if(this.BackPiece == 0)
            {
                    return;
            }
            
                this.BackPiece.FrontBandPoint = this.FrontBandPoint;
                val_9 = this.BackPiece;
                System.Nullable<UnityEngine.Vector3> val_3 = new System.Nullable<UnityEngine.Vector3>(value:  new UnityEngine.Vector3() {x = mem[this.BackBandPoint.positionInWorldSpace + (0)], y = mem[this.BackBandPoint.positionInWorldSpace + (4)], z = mem[this.BackBandPoint.positionInWorldSpace + (8)]});
                this.BackPiece.FrontPiece = 0;
                if(this._rope == 0)
            {
                    return;
            }
            
                val_10 = this.BackPiece;
                val_11 = this._rope;
                this._rope._frontPiece = val_10;
                return;
            }
            
            this.FrontPiece.BackBandPoint = this.BackBandPoint;
            val_9 = this.FrontPiece;
            System.Nullable<UnityEngine.Vector3> val_5 = new System.Nullable<UnityEngine.Vector3>(value:  new UnityEngine.Vector3() {x = mem[this.FrontBandPoint.positionInWorldSpace + (0)], y = mem[this.FrontBandPoint.positionInWorldSpace + (4)], z = mem[this.FrontBandPoint.positionInWorldSpace + (8)]});
            if(this.BackPiece != 0)
            {
                    val_9 = this.BackPiece;
                this.FrontPiece.BackPiece = val_9;
                val_10 = this.FrontPiece;
                val_11 = this.BackPiece;
                this.BackPiece.FrontPiece = val_10;
                return;
            }
            
            this.FrontPiece.BackPiece = 0;
            val_10 = this.FrontPiece;
            val_11 = this._rope;
            this._rope._backPiece = val_10;
        }
        public void RefreshBendPointInstance(WrappingRopeLibrary.Enums.BodyType body)
        {
            if(this._rope == 0)
            {
                    if(this.FrontPiece != 0)
            {
                    return;
            }
            
            }
            
            bool val_3 = UnityEngine.Object.op_Inequality(x:  this._bendPointInstance, y:  0);
            if(val_3 == true)
            {
                    val_3 = this;
                this.DestroyBendPointInstance();
            }
            
            if(body != 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_4 = R4 + 52.GetBendInstance();
            mem2[0] = R4 + 52;
        }
        public override string ToString()
        {
            string val_1 = System.String.Format(format:  -1610605367, arg0:  536887587);
        }
        private void OnEnable()
        {
            536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  908317616, method:  new IntPtr(1610683023));
            GameTool.EventDispatcherExtension.RegisterListener(sender:  908317616, eventID:  25, callback:  536873423);
            536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  908317616, method:  new IntPtr(1610683025));
            GameTool.EventDispatcherExtension.RegisterListener(sender:  908317616, eventID:  5, callback:  536873423);
        }
        private void OnDisable()
        {
            536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  908429616, method:  new IntPtr(1610683027));
            GameTool.EventDispatcherExtension.RemoveListener(sender:  908429616, eventID:  25, callback:  536873423);
            536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  908429616, method:  new IntPtr(1610683029));
            GameTool.EventDispatcherExtension.RemoveListener(sender:  908429616, eventID:  5, callback:  536873423);
        }
        private void HideCollider()
        {
        
        }
        public Piece()
        {
        
        }
        private void <OnEnable>b__70_0(UnityEngine.Component Comparer, object param)
        {
        
        }
        private void <OnEnable>b__70_1(UnityEngine.Component Comparer, object param)
        {
        
        }
        private void <OnDisable>b__71_0(UnityEngine.Component Comparer, object param)
        {
        
        }
        private void <OnDisable>b__71_1(UnityEngine.Component Comparer, object param)
        {
        
        }
    
    }

}
