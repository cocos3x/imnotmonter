using UnityEngine;

namespace WrappingRopeLibrary.Utils
{
    internal class GameObjectWraper
    {
        // Fields
        private UnityEngine.GameObject _gameObject;
        private WrappingRopeLibrary.Scripts.Piece _piece;
        private WrappingRopeLibrary.Model.PieceInfo _pieceInfo;
        private WrappingRopeLibrary.Model.HitInfo _hitInfo;
        private int[] _triangles;
        private UnityEngine.Vector3[] _vertices;
        private float _frontToHitToBackRelation1;
        private float _frontToHitToBackRelation2;
        private UnityEngine.Vector3 _hipPoint1;
        private UnityEngine.Vector3 _hipPoint2;
        private float _sqrTreshold;
        
        // Methods
        internal GameObjectWraper(WrappingRopeLibrary.Model.PieceInfo pieceInfo, WrappingRopeLibrary.Model.HitInfo hitInfo1, WrappingRopeLibrary.Model.HitInfo hitInfo2)
        {
            WrappingRopeLibrary.Model.PieceInfo val_12;
            val_1 = new System.Object();
            this._gameObject = hitInfo1.<GameObject>k__BackingField;
            this._piece = pieceInfo.<Piece>k__BackingField;
            this._pieceInfo = pieceInfo;
            this._hitInfo = val_1;
            val_12 = this._pieceInfo;
            if(this._pieceInfo == 0)
            {
                    val_12 = this._pieceInfo;
            }
            
            UnityEngine.Vector3 val_12 = pieceInfo.<BackBandPoint>k__BackingField;
            float val_13 = mem[pieceInfo + 24];
            float val_14 = mem[pieceInfo + 28];
            val_12 = (this._pieceInfo.<FrontBandPoint>k__BackingField) - val_12;
            val_13 = S20 - val_13;
            val_14 = S18 - val_14;
            float val_2 = val_12.magnitude;
            UnityEngine.Vector3 val_15 = hitInfo1.<Point>k__BackingField;
            float val_16 = mem[hitInfo1 + 28];
            float val_17 = mem[hitInfo1 + 32];
            val_15 = (pieceInfo.<FrontBandPoint>k__BackingField) - val_15;
            val_16 = (mem[pieceInfo + 12]) - val_16;
            val_17 = (mem[pieceInfo + 16]) - val_17;
            float val_3 = val_15.magnitude;
            uint val_18 = 881081144;
            val_18 = val_18 / 881081144;
            this._frontToHitToBackRelation1 = val_18;
            UnityEngine.Vector3 val_19 = hitInfo2.<Point>k__BackingField;
            val_19 = (this._pieceInfo.<FrontBandPoint>k__BackingField) - val_19;
            val_16 = S8 - val_16;
            val_17 = S10 - val_17;
            float val_4 = val_19.magnitude;
            uint val_20 = 881081144;
            val_20 = val_20 / 881081144;
            this._frontToHitToBackRelation2 = val_20;
            float val_5 = this._piece.Threshold;
            float val_6 = this._piece.Threshold;
            float val_21 = this._piece;
            val_21 = this._piece * val_21;
            this._sqrTreshold = val_21;
            Weight val_7 = this._gameObject.GetComponent<Weight>();
            UnityEngine.Mesh val_8 = this._gameObject.sharedMesh;
            if(this._gameObject != 0)
            {
                    System.Int32[] val_9 = this._gameObject.triangles;
                this._triangles = this._gameObject;
            }
            else
            {
                    System.Int32[] val_10 = 0.triangles;
                this._triangles = 0;
            }
            
            UnityEngine.Vector3[] val_11 = this._gameObject.vertices;
            this._vertices = this._gameObject;
        }
        internal System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> GetWrapPoints()
        {
            float val_6;
            UnityEngine.Vector3[] val_7;
            float val_8;
            float val_9;
            float val_11;
            float val_12;
            float val_13;
            var val_28;
            536878545 = new System.Collections.Generic.List<Page>();
            536878545 = new System.Collections.Generic.List<Page>();
            UnityEngine.Vector3[] val_3 = this.GetLocalPiecePoints(pieceInfo:  this._pieceInfo);
            UnityEngine.Plane val_5 = GetPiecePlane(cantDefineWrapSide: out  bool val_4 = true, localPiecePoints:  881320127);
            if(0 != 0)
            {
                    return;
            }
            
            val_8 = val_8;
            UnityEngine.Plane val_10 = val_8.GetCrossPlane(sourcePlane:  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = 2.534348E-07f, y = val_8, z = val_9}, m_Distance = val_6}, localPiecePoints:  val_7);
            536899151 = new GameObjectWraper.WrapPathFinder(gameObject:  this._gameObject, pieceInfo:  this._pieceInfo, hitInfo:  this._hitInfo, localPiecePoints:  this, piecePlane:  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = val_8, y = this, z = val_6}, m_Distance = val_7}, crossPlane:  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_13}, m_Distance = val_11}, triangles:  this._triangles, vertices:  this._vertices, sqrTreshold:  null);
            System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> val_15 = 536899151.GetWrapPath();
            if(mem[536899163] == 0)
            {
                    return;
            }
            
            if((this.IsBadPath(pathPoints:  536899151)) == true)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_17 = val_8.normal;
            if(mem[536899163] == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.Vector3 val_18 = val_8.GetPointInWorldSpace(localShift:  new UnityEngine.Vector3() {x = 2.534348E-07f, y = val_8, z = val_9}, pathPoint:  val_6);
            val_8 = val_9;
            UnityEngine.Vector3 val_19 = val_8.normal;
            if(mem[536899163] == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_20 = mem[536899163] - 1;
            val_20 = mem[536899159] + (val_20 << 2);
            UnityEngine.Vector3 val_21 = val_8.GetPointInWorldSpace(localShift:  new UnityEngine.Vector3() {x = 2.534348E-07f, y = val_8, z = val_9}, pathPoint:  val_6);
            WrappingRopeLibrary.Model.PieceInfo val_22 = 536891715;
            val_22 = new WrappingRopeLibrary.Model.PieceInfo();
            if(val_22 != 0)
            {
                    mem[536891723] = val_6 + 12 + 20 + 32;
                mem[536891727] = val_6 + 12 + 20 + 36;
                mem[536891731] = val_6 + 12 + 20 + 40;
            }
            else
            {
                    mem[8] = val_6 + 12 + 20 + 32;
                mem[12] = val_6 + 12 + 20 + 36;
                mem[16] = val_6 + 12 + 20 + 40;
            }
            
            mem[536891735] = val_8;
            mem[536891739] = val_8;
            val_8 = val_22;
            mem[536891743] = val_6;
            WrappingRopeLibrary.Model.PieceInfo val_23 = 536891715;
            val_23 = new WrappingRopeLibrary.Model.PieceInfo();
            mem[536891723] = val_8;
            mem[536891727] = val_9;
            mem[536891731] = val_6;
            var val_24 = (val_6 + 12 + 24) + 32;
            var val_25 = val_23 + 20;
            val_28 = val_6 + 16;
            if((val_6 + 16) == 0)
            {
                    val_28 = mem[val_6 + 16];
                val_28 = val_6 + 16;
            }
            
            System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> val_26 = val_6 + 16 + 20.ResolveNewPieceCollisionAndGetAdditionPathPoints(pieceInfo:  536891715, thirdPoint:  new UnityEngine.Vector3() {x = val_6 + 16 + 8, y = val_6 + 16 + 12, z = val_6 + 16 + 16});
            System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> val_27 = val_6 + 16 + 20.ResolveNewPieceCollisionAndGetAdditionPathPoints(pieceInfo:  536891715, thirdPoint:  new UnityEngine.Vector3() {x = val_6 + 16 + 20, y = val_6 + 16 + 24, z = val_6 + 16 + 28});
            536899151.InsertRange(index:  0, collection:  val_6 + 16 + 20);
            536899151.InsertRange(index:  mem[536899163], collection:  val_6 + 16 + 20);
            536873369 = new System.Action<SdkConfiguration>(object:  val_6 + 16 + 20, method:  new IntPtr(1610682671));
            536899151.ForEach(action:  536873369);
        }
        private bool IsBadPath(System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> pathPoints)
        {
            float val_4;
            float val_5;
            float val_6;
            WrappingRopeLibrary.Scripts.Piece val_10;
            var val_11;
            val_10 = this._piece.FrontPiece;
            val_11 = 0;
            bool val_1 = UnityEngine.Object.op_Equality(x:  val_10, y:  0);
            if(val_1 == true)
            {
                    return true;
            }
            
            if(val_1 < true)
            {
                    return true;
            }
            
            UnityEngine.Transform val_2 = this._gameObject.transform;
            UnityEngine.Vector3 val_3 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this._gameObject, y = this._piece.FrontPiece.FrontBandPoint.positionInWorldSpace, z = SB});
            UnityEngine.Transform val_7 = this._gameObject.transform;
            UnityEngine.Vector3 val_8 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this._gameObject, y = this._piece.FrontPiece.BackBandPoint.positionInWorldSpace, z = this._gameObject});
            float val_12 = val_4;
            float val_11 = val_5;
            float val_10 = val_6;
            if(881550908 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_6 - val_10;
            val_11 = val_5 - val_11;
            val_12 = val_4 - val_12;
            if(0 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10;
            float val_13 = static_value_0028000B;
            float val_14 = static_value_0028000F;
            float val_15 = -1.084397E-19f;
            val_13 = 0f - val_13;
            val_14 = (3.761582E-37f) - val_14;
            val_15 = (2.353859E-38f) - val_15;
            float val_9 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15}, to:  new UnityEngine.Vector3() {x = val_12, y = val_11, z = val_10});
            if(2621443 < 0)
            {
                    val_11 = 1;
            }
            
            return true;
        }
        private System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> GetWrapPointsInWorldCoordinates(System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> pathPoints, UnityEngine.Vector3 localShift)
        {
            536878545 = new System.Collections.Generic.List<Page>();
            List.Enumerator<T> val_2 = GetEnumerator();
            label_5:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            536897093 = new WrappingRopeLibrary.Model.WrapPoint();
            UnityEngine.Vector3 val_6 = GetPointInWorldSpace(localShift:  new UnityEngine.Vector3() {x = 2.641086E-07f, y = localShift.x, z = localShift.y}, pathPoint:  localShift.z);
            val_5.PositionInWorldSpace = new UnityEngine.Vector3() {x = R8, y = SB, z = SL};
            536878545.Add(item:  536897093);
            goto label_5;
            label_2:
            Dispose();
        }
        private UnityEngine.Vector3 GetPointInWorldSpace(UnityEngine.Vector3 localShift, WrappingRopeLibrary.Model.WrapPoint pathPoint)
        {
            float val_6;
            UnityEngine.GameObject val_8;
            float val_9;
            float val_11;
            float val_14;
            float val_1 = localShift.x + 12.WrapDistance;
            if((localShift.x + 12) < 0)
            {
                    val_14 = 0.001f;
            }
            else
            {
                    float val_2 = localShift.x + 12.WrapDistance;
                val_14 = localShift.x + 12;
            }
            
            UnityEngine.Transform val_3 = localShift.x + 8.transform;
            UnityEngine.Quaternion val_5 = rotation;
            UnityEngine.Vector3 val_7 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 2.671816E-07f}, point:  new UnityEngine.Vector3() {x = val_6, y = localShift.y, z = localShift.z});
            UnityEngine.Vector3 val_10 = normalized;
            var val_15 = val_11;
            var val_14 = val_8;
            UnityEngine.Transform val_12 = localShift.x + 8.transform;
            val_14 = val_14 * val_14;
            val_15 = val_14 * val_15;
            val_14 = val_14 * val_9;
            UnityEngine.Vector3 val_13 = TransformPoint(position:  new UnityEngine.Vector3() {x = localShift.x + 8, y = val_4 + 8, z = val_4 + 12});
            WrappingRopeLibrary.Utils.GameObjectWraper val_16 = val_9;
            float val_17 = val_11;
            UnityEngine.GameObject val_18 = val_8;
            val_16 = val_14 + val_16;
            val_17 = val_15 + val_17;
            val_18 = val_14 + val_18;
            this = val_16;
            mem[1152921509783642196] = val_17;
            this._gameObject = val_18;
            return new UnityEngine.Vector3() {x = val_16, y = val_13.y, z = val_17};
        }
        private System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> ResolveNewPieceCollisionAndGetAdditionPathPoints(WrappingRopeLibrary.Model.PieceInfo pieceInfo, UnityEngine.Vector3 thirdPoint)
        {
            float val_13;
            UnityEngine.Vector3 val_14;
            float val_15;
            float val_16;
            float val_17;
            System.Int32[] val_18;
            var val_19;
            float val_20;
            float val_21;
            float val_22;
            float val_23;
            float val_24;
            UnityEngine.GameObject val_25;
            float val_26;
            UnityEngine.Vector3 val_27;
            float val_28;
            float val_29;
            float val_30;
            WrappingRopeLibrary.Model.PieceInfo val_31;
            var val_32;
            System.Collections.Generic.List<Page> val_33;
            if(pieceInfo != 0)
            {
                    val_13 = pieceInfo;
                val_14 = pieceInfo.<FrontBandPoint>k__BackingField;
                var val_1 = (pieceInfo + 8) + 20;
                val_15 = pieceInfo + 8;
                val_16 = pieceInfo + 8;
                val_17 = mem[pieceInfo + 8 + 8];
                val_17 = pieceInfo + 8 + 8;
                val_18 = (pieceInfo + 8) + 16;
                val_19 = mem[pieceInfo + 8 + 4];
                val_19 = pieceInfo + 8 + 4;
                val_20 = mem[pieceInfo + 8 + 12];
                val_20 = pieceInfo + 8 + 12;
                val_21 = mem[pieceInfo + 8 + 16];
                val_21 = pieceInfo + 8 + 16;
                val_22 = val_17;
                val_23 = mem[pieceInfo + 8 + 20];
                val_23 = pieceInfo + 8 + 20;
                val_24 = val_19;
            }
            else
            {
                    val_13 = 1.121039E-44f;
                val_16 = 1.681558E-44f;
                val_15 = 2.242078E-44f;
                val_17 = 3.673424E-39f;
                val_19 = 0;
                val_18 = 24;
                val_23 = 7.286752E-44f;
                val_20 = 1.401298E-45f;
                val_21 = 0f;
                val_14 = 0;
                val_22 = 3.673424E-39f;
                val_24 = 0f;
            }
            
            val_24 = val_21 - val_24;
            val_22 = val_23 - val_22;
            val_13 = val_20 - val_13;
            UnityEngine.Ray val_2 = new UnityEngine.Ray(origin:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 3.673424E-39f}, direction:  new UnityEngine.Vector3() {x = val_13, y = val_24, z = val_22});
            val_25 = mem[1152921509783762392];
            if(pieceInfo != 0)
            {
                    val_27 = pieceInfo.<BackBandPoint>k__BackingField;
                val_28 = 7.286752E-44f;
            }
            else
            {
                    val_26 = 0f;
                val_28 = 7.286752E-44f;
                val_27 = 1.401298E-45f;
            }
            
            float val_12 = 0f;
            val_16 = val_26 - val_16;
            val_12 = val_27 - val_12;
            val_15 = val_28 - val_15;
            float val_3 = val_12.magnitude;
            val_29 = val_12;
            if((WrappingRopeLibrary.Utils.Geometry.TryRaycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_29, y = val_16, z = val_15}, m_Direction = new UnityEngine.Vector3() {x = val_2.m_Direction.x, y = val_30, z = val_2.m_Direction.z}}, gameObject:  val_25, maxDistance:  val_3, hitInfo: out  val_12)) != false)
            {
                    val_31 = pieceInfo;
                UnityEngine.Vector3[] val_6 = this.GetLocalPiecePoints(pieceInfo:  val_31);
                val_30 = this;
                val_32 = mem[1152921509783762396];
                if(val_32 <= 1)
            {
                    val_31 = 0;
                val_32 = mem[1152921509783762396];
            }
            
                if(val_32 <= 3)
            {
                    val_31 = 0;
            }
            
                UnityEngine.Plane val_7 = WrappingRopeLibrary.Utils.Geometry.GetPlane(v1:  new UnityEngine.Vector3() {x = 2.705974E-07f, y = R4, z = R7}, v2:  new UnityEngine.Vector3() {x = R8}, v3:  new UnityEngine.Vector3() {y = thirdPoint.x, z = thirdPoint.y});
                val_29 = val_16;
                UnityEngine.Plane val_8 = val_12.GetCrossPlane(sourcePlane:  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = 2.709407E-07f, y = val_12, z = val_29}, m_Distance = val_15}, localPiecePoints:  val_2.m_Direction.x);
                val_25 = val_2.m_Direction.x;
                val_18 = mem[1152921509783762408];
                val_16 = mem[1152921509783762412];
                536899151 = new GameObjectWraper.WrapPathFinder(gameObject:  mem[1152921509783762392], pieceInfo:  pieceInfo, hitInfo:  val_2.m_Direction.x, localPiecePoints:  this, piecePlane:  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = val_12, y = val_29, z = val_15}, m_Distance = val_2.m_Direction.x}, crossPlane:  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = val_12, y = val_16, z = val_15}, m_Distance = val_25}, triangles:  val_18, vertices:  val_16, sqrTreshold:  val_3);
                System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> val_10 = 536899151.GetWrapPath();
                val_33 = 536899151;
                return;
            }
            
            val_33 = 536878545;
            val_33 = new System.Collections.Generic.List<Page>();
        }
        private void DrawBasePlanes(UnityEngine.Vector3 origin, UnityEngine.Vector3 piecePlaneNormal, UnityEngine.Vector3 crossPlaneNormal)
        {
            float val_2;
            float val_5;
            float val_6;
            float val_7;
            UnityEngine.Color val_1 = UnityEngine.Color.green;
            UnityEngine.Color val_3 = UnityEngine.Color.red;
            WrappingRopeLibrary.Helpers.DebugDraw.DrawPlane(position:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, normal:  new UnityEngine.Vector3() {x = piecePlaneNormal.x, y = piecePlaneNormal.y, z = piecePlaneNormal.z}, color:  new UnityEngine.Color() {r = val_2, g = ???, b = ???, a = ???}, normalColor:  new UnityEngine.Color() {r = ???});
            UnityEngine.Color val_4 = UnityEngine.Color.magenta;
            UnityEngine.Color val_8 = UnityEngine.Color.yellow;
            WrappingRopeLibrary.Helpers.DebugDraw.DrawPlane(position:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, normal:  new UnityEngine.Vector3() {x = crossPlaneNormal.x, y = crossPlaneNormal.y, z = crossPlaneNormal.z}, color:  new UnityEngine.Color() {r = val_2, g = val_5, b = val_6, a = val_7}, normalColor:  new UnityEngine.Color() {r = ???, g = ???, b = ???, a = ???});
        }
        private UnityEngine.Plane GetPiecePlane(out bool cantDefineWrapSide, UnityEngine.Vector3[] localPiecePoints)
        {
            float val_4;
            float val_7;
            float val_9;
            var val_10;
            var val_11;
            val_7 = 1152921509784063360;
            var val_7 = R3;
            mem2[0] = 0f;
            if((cantDefineWrapSide.GetThirdPoint(thirdPoint: ref  new UnityEngine.Vector3() {x = 2.782431E-07f, y = localPiecePoints})) != false)
            {
                    UnityEngine.Transform val_2 = mem[1152921509784063368].transform;
                val_9 = mem[1152921509784063368];
                UnityEngine.Vector3 val_3 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_9, y = 0f, z = 0f});
                val_10 = mem[R3 + 12];
                val_10 = R3 + 12;
                if(val_10 <= 1)
            {
                    val_9 = 0;
                val_10 = mem[R3 + 12];
                val_10 = R3 + 12;
            }
            
                val_7 = mem[R3 + 32];
                val_7 = R3 + 32;
                if(val_10 <= 3)
            {
                    val_9 = 0;
            }
            
                val_7 = val_7 + 52;
                UnityEngine.Plane val_6 = WrappingRopeLibrary.Utils.Geometry.GetPlane(v1:  new UnityEngine.Vector3() {x = 2.782426E-07f, y = R3 + 28, z = val_7}, v2:  new UnityEngine.Vector3() {x = R3 + 36, y = mem[(R3 + 52) + (0)], z = mem[(R3 + 52) + (4)]}, v3:  new UnityEngine.Vector3() {x = mem[(R3 + 52) + (8)], y = val_4, z = 0f});
                return new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = 1.401298E-45f, y = 2.782431E-07f, z = localPiecePoints}};
            }
            
            val_11 = 1;
            mem2[0] = val_11;
            return new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = 1.401298E-45f, y = 2.782431E-07f, z = localPiecePoints}};
        }
        private UnityEngine.Vector3[] GetLocalPiecePoints(WrappingRopeLibrary.Model.PieceInfo pieceInfo)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_12;
            UnityEngine.Transform val_1 = this._gameObject.transform;
            UnityEngine.Vector3 val_2 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this._gameObject, y = pieceInfo.<PrevFrontBandPoint>k__BackingField, z = SB});
            UnityEngine.Transform val_6 = this._gameObject.transform;
            UnityEngine.Vector3 val_7 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this._gameObject, y = pieceInfo.<BackBandPoint>k__BackingField, z = pieceInfo.<PrevFrontBandPoint>k__BackingField});
            UnityEngine.Transform val_8 = this._gameObject.transform;
            UnityEngine.Vector3 val_9 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this._gameObject, y = pieceInfo.<PrevBackBandPoint>k__BackingField, z = pieceInfo.<PrevFrontBandPoint>k__BackingField});
            UnityEngine.Transform val_10 = this._gameObject.transform;
            UnityEngine.Vector3 val_11 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this._gameObject, y = pieceInfo.<FrontBandPoint>k__BackingField, z = pieceInfo.<PrevFrontBandPoint>k__BackingField});
            val_12 = mem[536882609];
            if(val_12 == 0)
            {
                    val_12 = mem[536882609];
            }
            
            mem[536882613] = val_3;
            mem[536882617] = val_4;
            mem[536882621] = val_5;
            if(val_12 <= 1)
            {
                    val_12 = mem[536882609];
            }
            
            mem[536882625] = val_3;
            mem[536882629] = val_4;
            mem[536882633] = val_5;
            if(val_12 <= 2)
            {
                    val_12 = mem[536882609];
            }
            
            mem[536882637] = val_3;
            mem[536882641] = val_4;
            mem[536882645] = val_5;
            var val_12 = 536882597 + 52;
        }
        private UnityEngine.Vector3 GetPieceVelocityInHitPoint(float relation)
        {
            WrappingRopeLibrary.Utils.GameObjectWraper val_2;
            float val_3;
            UnityEngine.GameObject val_4;
            var val_8;
            float val_20;
            var val_22;
            var val_23;
            var val_24;
            UnityEngine.Vector3 val_1 = DefineFrontBandPointVelocity();
            WrappingRopeLibrary.Utils.GameObjectWraper val_18 = val_2;
            float val_19 = val_3;
            UnityEngine.GameObject val_20 = val_4;
            UnityEngine.Vector3 val_5 = DefineBackBandPointVelocity();
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            val_22 = val_2;
            val_23 = val_3;
            val_24 = val_4;
            var val_7 = (R1 + 12) + 72;
            if(val_8 != false)
            {
                    var val_17 = R1 + 12 + 20 + 40;
                var val_9 = (R1 + 12) + 72;
                UnityEngine.Vector3 val_10 = Value;
                val_17 = val_17 - val_4;
                float val_11 = UnityEngine.Time.fixedDeltaTime;
                float val_12 = (R1 + 12 + 20 + 36) - val_3;
                val_20 = 0;
                val_24 = val_17 / val_20;
                val_23 = val_12 / val_20;
                val_22 = ((R1 + 12 + 20 + 32) - val_2) / val_20;
            }
            
            val_18 = val_18 + val_22;
            val_19 = val_19 + val_23;
            val_20 = val_20 + val_24;
            float val_14 = UnityEngine.Mathf.Clamp01(value:  val_20);
            val_12 = val_3 - val_19;
            float val_16 = val_4 - val_20;
            this = val_18;
            mem[1152921509784337204] = val_19;
            this._gameObject = val_20;
            return new UnityEngine.Vector3() {x = val_2 - val_18, y = val_10.y, z = val_12};
        }
        private bool GetThirdPoint(ref UnityEngine.Vector3 thirdPoint)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            UnityEngine.Vector3 val_28;
            var val_29;
            var val_30;
            UnityEngine.Rigidbody val_31;
            UnityEngine.Vector3 val_32;
            var val_33;
            var val_34;
            val_19 = 1152921509784526064;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_20 = val_2;
            val_21 = val_3;
            val_22 = val_4;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            val_24 = val_2;
            val_25 = val_3;
            val_26 = val_4;
            Weight val_6 = this._gameObject.GetComponent<Weight>();
            if(this._gameObject == 0)
            {
                goto label_2;
            }
            
            val_27 = this._gameObject;
            val_28 = this._hipPoint1;
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_29 = val_27;
            val_30 = 22712192;
            val_28 = val_28;
            goto label_6;
            label_2:
            if((this._hitInfo.<Rigidbody>k__BackingField) == 0)
            {
                goto label_15;
            }
            
            UnityEngine.Vector3 val_8 = GetPointVelocity(worldPoint:  new UnityEngine.Vector3() {x = this._hitInfo.<Rigidbody>k__BackingField, y = this._hipPoint1, z = R6});
            val_20 = val_2;
            val_21 = val_3;
            val_22 = val_4;
            val_31 = this._hitInfo.<Rigidbody>k__BackingField;
            val_32 = this._hipPoint2;
            UnityEngine.Vector3 val_9 = GetPointVelocity(worldPoint:  new UnityEngine.Vector3() {x = val_31, y = val_32, z = R6});
            val_24 = val_2;
            val_25 = val_3;
            val_26 = val_4;
            goto label_15;
            label_6:
            val_20 = val_2;
            val_21 = val_3;
            val_22 = val_4;
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_33 = val_27;
            val_24 = val_2;
            val_25 = val_3;
            val_26 = val_4;
            val_19 = val_19;
            label_15:
            UnityEngine.Vector3 val_12 = GetPieceVelocityInHitPoint(relation:  val_5.x);
            UnityEngine.Vector3 val_13 = GetPieceVelocityInHitPoint(relation:  val_12.x);
            float val_14 = val_21 - val_3;
            float val_15 = val_20 - val_2;
            float val_16 = val_22 - val_4;
            val_34 = 0;
            val_14 = val_25 + val_14;
            val_15 = val_24 + val_15;
            val_16 = val_26 + val_16;
            val_14 = val_14 - val_3;
            val_15 = val_15 - val_2;
            val_16 = val_16 - val_4;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
            if((val_15.Equals(other:  new UnityEngine.Vector3())) == true)
            {
                    return (bool)val_34;
            }
            
            float val_21 = val_15;
            float val_22 = val_14;
            val_21 = (this._hitInfo.<Point>k__BackingField) + val_21;
            val_34 = 1;
            float val_23 = val_16;
            val_22 = val_3 + val_22;
            val_23 = val_4 + val_23;
            thirdPoint.x = val_21;
            mem[1152921509784526068] = val_22;
            mem[1152921509784526072] = val_23;
            return (bool)val_34;
        }
        private UnityEngine.Plane GetCrossPlane(UnityEngine.Plane sourcePlane, UnityEngine.Vector3[] localPiecePoints)
        {
            var val_1;
            var val_5;
            var val_6;
            UnityEngine.Vector3[] val_7;
            val_5 = mem[val_1 + 12];
            val_5 = val_1 + 12;
            if(val_5 <= 1)
            {
                    val_6 = 0;
                val_5 = mem[val_1 + 12];
                val_5 = val_1 + 12;
            }
            
            var val_2 = val_1 + 28;
            val_7 = localPiecePoints;
            if(val_5 <= 3)
            {
                    val_6 = 0;
                val_7 = localPiecePoints;
            }
            
            var val_3 = val_1 + 52;
            UnityEngine.Plane val_4 = GetCrossPlane(sourcePlane:  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = mem[(val_1 + 52) + (4)], y = sourcePlane.m_Normal.y, z = sourcePlane.m_Normal.z}, m_Distance = sourcePlane.m_Distance}, p1:  new UnityEngine.Vector3() {x = val_7, y = mem[(val_1 + 28) + (0)], z = mem[(val_1 + 28) + (4)]}, p2:  new UnityEngine.Vector3() {x = mem[(val_1 + 28) + (8)], y = mem[(val_1 + 52) + (0)], z = mem[(val_1 + 52) + (4)]});
            return new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = 2.972424E-07f, y = val_4.m_Normal.y, z = val_4.m_Normal.z}, m_Distance = val_4.m_Distance};
        }
        private UnityEngine.Plane GetCrossPlane(UnityEngine.Plane sourcePlane, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)
        {
            var val_2;
            var val_3;
            var val_4;
            float val_6;
            UnityEngine.Vector3 val_1 = normal;
            float val_8 = p1.y;
            float val_9 = p1.z;
            val_8 = val_2 + val_8;
            float val_5 = val_4 + p2.x;
            val_9 = val_3 + val_9;
            UnityEngine.Plane val_7 = WrappingRopeLibrary.Utils.Geometry.GetPlane(v1:  new UnityEngine.Vector3() {x = 3.011307E-07f, y = p2.y, z = p2.z}, v2:  new UnityEngine.Vector3() {x = val_6, y = p1.y, z = p1.z}, v3:  new UnityEngine.Vector3() {x = p2.x, y = val_8, z = val_9});
            return new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = val_7.m_Normal.x, y = val_7.m_Normal.y, z = val_7.m_Normal.z}, m_Distance = val_7.m_Distance};
        }
        private void <GetWrapPoints>b__12_0(WrappingRopeLibrary.Model.WrapPoint point)
        {
            UnityEngine.Transform val_1 = this._gameObject.transform;
            point.SetPointInWorldSpace(transform:  this._gameObject, wrapDistance:  this._piece.WrapDistance);
        }
    
    }

}
