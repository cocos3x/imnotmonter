using UnityEngine;
internal class GameObjectWraper.WrapPathFinder
{
    // Fields
    private UnityEngine.GameObject _gameObject;
    private WrappingRopeLibrary.Model.PieceInfo _pieceInfo;
    private WrappingRopeLibrary.Model.HitInfo _hitInfo;
    private UnityEngine.Vector3[] _localPiecePoints;
    private UnityEngine.Plane _piecePlane;
    private UnityEngine.Plane _crossPlane;
    private int[] _triangles;
    private UnityEngine.Vector3[] _vertices;
    private float _sqrTreshold;
    private System.Collections.Generic.List<WrappingRopeLibrary.Model.Edge[]> _edgeCache;
    
    // Methods
    internal GameObjectWraper.WrapPathFinder(UnityEngine.GameObject gameObject, WrappingRopeLibrary.Model.PieceInfo pieceInfo, WrappingRopeLibrary.Model.HitInfo hitInfo, UnityEngine.Vector3[] localPiecePoints, UnityEngine.Plane piecePlane, UnityEngine.Plane crossPlane, int[] triangles, UnityEngine.Vector3[] vertices, float sqrTreshold)
    {
        float val_1;
        this._localPiecePoints = 536882597;
        536877677 = new System.Collections.Generic.List<Page>();
        this._edgeCache = 536877677;
        val_3 = new System.Object();
        this._gameObject = gameObject;
        this._pieceInfo = val_3;
        this._hitInfo = hitInfo;
        mem[1152921509780263332] = localPiecePoints;
        this._piecePlane = piecePlane;
        mem[1152921509780263340] = piecePlane.m_Normal.y;
        mem[1152921509780263344] = piecePlane.m_Normal.z;
        mem[1152921509780263348] = piecePlane.m_Distance;
        this._crossPlane = crossPlane;
        mem[1152921509780263356] = crossPlane.m_Normal.y;
        mem[1152921509780263360] = crossPlane.m_Normal.z;
        mem[1152921509780263364] = crossPlane.m_Distance;
        this._triangles = triangles;
        this._vertices = vertices;
        mem[1152921509780263376] = val_1;
    }
    internal System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> GetWrapPath()
    {
        bool val_2 = this.TryFindCrossPointsInMeshCoords(crossPoints: out  System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> val_1 = 878671900, checkTreshold:  false);
        System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> val_3 = this.GetWrapPathFromCrossPoints(crossPoints:  0);
    }
    private int FindEdgeGroupIndexByTriangleIndex(int triangleindex)
    {
        536902635 = new GameObjectWraper.WrapPathFinder.<>c__DisplayClass12_0();
        mem[536902643] = triangleindex;
        536879209 = new System.Predicate<Page>(object:  536902635, method:  new IntPtr(1610682703));
        WrappingRopeLibrary.Model.Edge[] val_3 = this._edgeCache.Find(match:  536879209);
        if(this._edgeCache == 0)
        {
                return 0;
        }
        
        if(this._edgeCache != 0)
        {
                return this._edgeCache.IndexOf(item:  this._edgeCache);
        }
        
        return this._edgeCache.IndexOf(item:  this._edgeCache);
    }
    private System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> FindCrossPointsInMeshCoordsForHill(int startEdgeGroupIndex, out bool isCrosspointOutOfTreshold, bool checkTreshold = True)
    {
        var val_8;
        536878545 = new System.Collections.Generic.List<Page>();
        if((startEdgeGroupIndex + 1) > 536878545)
        {
                isCrosspointOutOfTreshold = false;
            return;
        }
        
        if(536878545 <= startEdgeGroupIndex)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8 + (startEdgeGroupIndex << 2);
        val_8 = mem[(0 + (startEdgeGroupIndex) << 2) + 16 + 16];
        val_8 = (0 + (startEdgeGroupIndex) << 2) + 16 + 16;
        if(val_8 == 0)
        {
            goto label_8;
        }
        
        var val_3 = val_8 + 8;
        var val_4 = val_8 + 20;
        if((this.IsCrossPointInWorkSpace(vertex1:  new UnityEngine.Vector3() {x = mem[((0 + (startEdgeGroupIndex) << 2) + 16 + 16 + 8) + (0)], y = mem[((0 + (startEdgeGroupIndex) << 2) + 16 + 16 + 8) + (4)], z = mem[((0 + (startEdgeGroupIndex) << 2) + 16 + 16 + 8) + (8)]}, vertex2:  new UnityEngine.Vector3() {x = mem[((0 + (startEdgeGroupIndex) << 2) + 16 + 16 + 20) + (0)], y = mem[((0 + (startEdgeGroupIndex) << 2) + 16 + 16 + 20) + (4)], z = mem[((0 + (startEdgeGroupIndex) << 2) + 16 + 16 + 20) + (8)]})) == true)
        {
            goto label_11;
        }
        
        val_8 = mem[(0 + (startEdgeGroupIndex) << 2) + 16 + 20];
        val_8 = (0 + (startEdgeGroupIndex) << 2) + 16 + 20;
        goto label_11;
        label_8:
        val_8 = 0;
        label_11:
        this.FindCrossPointsForEdgesRecursively(edge:  0, crossPoints: ref  System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> val_6 = 878924488, isCrosspointOutOfTreshold: out  bool val_7 = true, checkTreshold:  checkTreshold);
    }
    private bool CheckRaycastHit(UnityEngine.Vector3 startPoint, UnityEngine.Vector3 stopPoint, out int triangleIndex, out UnityEngine.Vector3 hitPoint)
    {
        float val_5;
        float val_6;
        float val_7;
        var val_11;
        float val_13 = stopPoint.x;
        float val_11 = stopPoint.y;
        float val_12 = stopPoint.z;
        val_11 = val_11 - startPoint.y;
        val_12 = val_12 - startPoint.z;
        val_13 = val_13 - startPoint.x;
        float val_9 = val_13;
        UnityEngine.Vector3 val_1 = normalized;
        0f.origin = new UnityEngine.Vector3() {x = startPoint.x, y = startPoint.y, z = startPoint.z};
        0f.direction = new UnityEngine.Vector3() {x = val_9, y = val_11, z = val_12};
        val_11 = 0f;
        if(val_11 != 0)
        {
                triangleIndex = 0;
        }
        else
        {
                val_11 = 0f;
            triangleIndex = 0;
            if(val_11 == 0)
        {
                val_11 = 0;
        }
        
        }
        
        mem[1152921509780927432] = 22965384;
        hitPoint.x = 0f;
        mem[1152921509780927428] = 0f;
        return (bool)WrappingRopeLibrary.Utils.Geometry.TryRaycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = val_5, z = val_6}, m_Direction = new UnityEngine.Vector3() {x = val_7, y = 0f, z = 0f}}, gameObject:  mem[1152921509780891352], maxDistance:  val_9.magnitude, hitInfo: out  val_9);
    }
    private bool TryFindCrossPointsInMeshCoords(out System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> crossPoints, bool checkTreshold = True)
    {
        int val_8;
        var val_9;
        536878545 = new System.Collections.Generic.List<Page>();
        crossPoints = 536878545;
        this.FillEdgesCache(triangleIndex:  this._hitInfo.<TriangleIndex>k__BackingField, startEdgeGroupIndex: out  int val_2 = 879213752);
        val_8 = 0;
        label_8:
        System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> val_4 = this.FindCrossPointsInMeshCoordsForHill(startEdgeGroupIndex:  0, isCrosspointOutOfTreshold: out  bool val_3 = true, checkTreshold:  checkTreshold);
        crossPoints.AddRange(collection:  879225792);
        if(0 != 0)
        {
            goto label_5;
        }
        
        if((this.CheckRaycastHit(startPoint:  new UnityEngine.Vector3() {x = this._hitInfo.<Point>k__BackingField, y = 0f, z = 0f}, stopPoint:  new UnityEngine.Vector3() {x = mem[this._pieceInfo.<BackBandPoint>k__BackingField + (0)], y = mem[this._pieceInfo.<BackBandPoint>k__BackingField + (4)], z = mem[this._pieceInfo.<BackBandPoint>k__BackingField + (8)]}, triangleIndex: out  0, hitPoint: out  new UnityEngine.Vector3() {x = this._hitInfo.<Point>k__BackingField, z = checkTreshold})) == false)
        {
            goto label_7;
        }
        
        int val_7 = this.FindEdgeGroupIndexByTriangleIndex(triangleindex:  0);
        val_8 = val_7;
        if(val_7 > 1)
        {
            goto label_8;
        }
        
        label_7:
        val_9 = 1;
        return (bool)val_9;
        label_5:
        crossPoints.Clear();
        val_9 = 0;
        return (bool)val_9;
    }
    private void FindCrossPointsForEdgesRecursively(WrappingRopeLibrary.Model.Edge edge, ref System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> crossPoints, out bool isCrosspointOutOfTreshold, bool checkTreshold = True)
    {
        WrappingRopeLibrary.Model.Edge val_6 = edge;
        isCrosspointOutOfTreshold = false;
        if(val_6 == 0)
        {
                return;
        }
        
        if((this.AddEdgeCrossPoint(vertex1:  new UnityEngine.Vector3() {x = mem[edge.<Vertex1>k__BackingField + (0)], y = mem[edge.<Vertex1>k__BackingField + (4)], z = mem[edge.<Vertex1>k__BackingField + (8)]}, vertex2:  new UnityEngine.Vector3() {x = mem[edge.<Vertex2>k__BackingField + (0)], y = mem[edge.<Vertex2>k__BackingField + (4)], z = mem[edge.<Vertex2>k__BackingField + (8)]}, crossPoints: ref  System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> val_1 = crossPoints, isCrosspointOutOfTreshold: out  true, checkTreshold:  checkTreshold)) == false)
        {
                return;
        }
        
        WrappingRopeLibrary.Model.Edge val_5 = this.FindNextEdgeInNaibourEdgeGroup(edge:  val_6 = edge, edgeGroupIndex: out  int val_4 = 879358312);
        if(this == 0)
        {
                return;
        }
        
        val_6 = this;
        if(isCrosspointOutOfTreshold != checkTreshold)
        {
                return;
        }
        
        if((mem[crossPoints + 12]) < 61)
        {
                return;
        }
        
        isCrosspointOutOfTreshold = true;
        val_1.Clear();
    }
    private void FillEdgesCache(int triangleIndex, out int startEdgeGroupIndex)
    {
        GameObjectWraper.WrapPathFinder val_16;
        var val_17;
        var val_18;
        UnityEngine.Vector3 val_19;
        UnityEngine.Vector3 val_20;
        UnityEngine.Vector3 val_21;
        var val_22;
        UnityEngine.Vector3 val_23;
        float val_24;
        float val_25;
        float val_26;
        var val_27;
        val_16 = this;
        val_17 = 0;
        this._edgeCache.Clear();
        val_18 = 0;
        mem2[0] = val_17;
        int val_1 = triangleIndex + (triangleIndex << 1);
        goto label_2;
        label_52:
        int val_19 = this._triangles[val_18];
        this._triangles[val_18] = val_19 + (val_19 << 1);
        UnityEngine.Vector3 val_20 = this._vertices[this._triangles[val_18] << 2];
        val_19 = this._vertices[this._triangles[val_18] << 2];
        UnityEngine.Vector3 val_21 = this._vertices[this._triangles[val_18] << 2];
        int val_22 = this._triangles[val_18];
        this._triangles[val_18] = val_22 + (val_22 << 1);
        UnityEngine.Vector3 val_23 = this._vertices[this._triangles[val_18] << 2];
        UnityEngine.Vector3 val_24 = this._vertices[this._triangles[val_18] << 2];
        UnityEngine.Vector3 val_25 = this._vertices[this._triangles[val_18] << 2];
        var val_2 = val_18 + 2;
        int val_26 = this._triangles[val_18];
        val_20 = val_21;
        this._triangles[val_18] = val_26 + (val_26 << 1);
        val_21 = 0;
        UnityEngine.Vector3 val_27 = this._vertices[this._triangles[val_18] << 2];
        UnityEngine.Vector3 val_28 = this._vertices[this._triangles[val_18] << 2];
        UnityEngine.Vector3 val_29 = this._vertices[this._triangles[val_18] << 2];
        if(((this._crossPlane.GetSide(point:  new UnityEngine.Vector3() {x = val_20, y = val_20, z = val_19})) == true) || ((this._crossPlane.GetSide(point:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25})) == true))
        {
            goto label_16;
        }
        
        bool val_5 = this._crossPlane.GetSide(point:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29});
        if(val_5 == false)
        {
            goto label_17;
        }
        
        label_16:
        val_22 = 0;
        if((this._piecePlane.SameSide(inPt0:  new UnityEngine.Vector3() {x = val_20, y = val_20, z = val_19}, inPt1:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25})) != true)
        {
                WrappingRopeLibrary.Model.Edge val_7 = 536886199;
            val_7 = new WrappingRopeLibrary.Model.Edge();
            if(val_7 != 0)
        {
                mem[536886207] = val_21;
            mem[536886211] = val_20;
            mem[536886215] = val_19;
            mem[536886219] = val_23;
            mem[536886223] = val_24;
            mem[536886227] = val_25;
        }
        else
        {
                mem[8] = val_21;
            mem[12] = val_20;
            mem[16] = val_19;
            mem[20] = val_23;
            mem[24] = val_24;
            mem[28] = val_25;
        }
        
            mem[536886231] = 1431655766;
            mem[536881913] = val_7;
            val_23 = val_21;
        }
        
        if((this._piecePlane.SameSide(inPt0:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25}, inPt1:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29})) != true)
        {
                WrappingRopeLibrary.Model.Edge val_9 = 536886199;
            val_9 = new WrappingRopeLibrary.Model.Edge();
            if(val_9 != 0)
        {
                mem[536886207] = val_23;
            mem[536886211] = val_24;
            mem[536886215] = val_25;
            mem[536886219] = val_27;
            mem[536886223] = val_28;
            mem[536886227] = val_29;
        }
        else
        {
                mem[8] = val_23;
            mem[12] = val_24;
            mem[16] = val_25;
            mem[20] = val_27;
            mem[24] = val_28;
            mem[28] = val_29;
        }
        
            mem[536886231] = 1431655766;
            var val_30 = 1;
            var val_10 = 536881897 + 4;
            mem2[0] = val_9;
            val_23 = val_21;
            val_30 = val_30 + 1;
            val_22 = 0;
        }
        
        if((this._piecePlane.SameSide(inPt0:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29}, inPt1:  new UnityEngine.Vector3() {x = val_23, y = val_20, z = val_19})) != false)
        {
                val_24 = val_19;
            val_19 = val_23;
            val_25 = val_29;
        }
        else
        {
                WrappingRopeLibrary.Model.Edge val_12 = 536886199;
            val_12 = new WrappingRopeLibrary.Model.Edge();
            if(val_12 != 0)
        {
                val_25 = val_29;
            mem[536886207] = val_27;
            mem[536886211] = val_28;
            mem[536886215] = val_29;
            mem[536886219] = val_21;
            mem[536886223] = val_20;
            mem[536886227] = val_19;
        }
        else
        {
                mem[8] = val_27;
            mem[12] = val_28;
            val_25 = val_29;
            mem[16] = val_29;
            mem[20] = val_21;
            mem[24] = val_20;
            mem[28] = val_19;
        }
        
            var val_31 = val_30;
            mem[536886231] = 1431655766;
            val_24 = val_19;
            var val_13 = 536881897 + (val_31 << 2);
            val_19 = val_23;
            mem2[0] = val_12;
            val_23 = val_21;
            val_31 = val_31 + 1;
        }
        
        val_21 = val_20;
        val_17 = 1;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_23, y = val_21, z = val_24}, rhs:  new UnityEngine.Vector3() {x = val_19, y = val_24, z = val_25})) != false)
        {
                val_16 = val_16;
        }
        else
        {
                val_21 = val_27;
            val_16 = val_16;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_23, y = val_21, z = val_24}, rhs:  new UnityEngine.Vector3() {x = val_21, y = val_28, z = val_25})) != true)
        {
                val_17 = UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_21, y = val_28, z = val_25}, rhs:  new UnityEngine.Vector3() {x = val_19, y = val_24, z = val_25});
        }
        
        }
        
        val_26 = val_18;
        if(val_1 != 0)
        {
            goto label_42;
        }
        
        val_21 = this._edgeCache;
        mem2[0] = val_1;
        if(val_31 < 1)
        {
            goto label_42;
        }
        
        val_27 = 536881897;
        if((val_17 == false) || (mem[536881909] != 0))
        {
            goto label_46;
        }
        
        goto label_46;
        label_42:
        val_27 = 536881897;
        label_46:
        if((val_31 < 1) || (val_17 == true))
        {
            goto label_50;
        }
        
        this._edgeCache.Add(item:  536881897);
        goto label_50;
        label_17:
        val_26 = val_18;
        label_50:
        val_18 = val_26 + 3;
        label_2:
        if(val_18 < val_5)
        {
            goto label_52;
        }
        
        if(mem[536881913] == 0)
        {
                return;
        }
        
        WrappingRopeLibrary.Model.Edge val_18 = this.FindNextEdgeInNaibourEdgeGroup(edge:  536886199, edgeGroupIndex: out  int val_17 = 879748632);
        mem2[0] = val_17;
    }
    private WrappingRopeLibrary.Model.Edge FindNextEdgeInNaibourEdgeGroup(WrappingRopeLibrary.Model.Edge edge, out int edgeGroupIndex)
    {
        var val_2;
        var val_14;
        var val_15;
        var val_16;
        UnityEngine.Vector3 val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        mem2[0] = 0;
        List.Enumerator<T> val_1 = GetEnumerator();
        val_14;
        goto label_2;
        label_37:
        if((edge.Equals(obj:  val_2 + 16)) == true)
        {
            goto label_33;
        }
        
        val_15 = val_2;
        if((edge.Equals(obj:  val_2 + 20)) == true)
        {
            goto label_33;
        }
        
        val_16 = mem[val_2 + 16];
        val_16 = val_2 + 16;
        if(val_16 == 0)
        {
            goto label_19;
        }
        
        val_17 = edge.<Vertex1>k__BackingField;
        if((val_2 + 12) == 0)
        {
                val_17 = val_17;
            val_18 = 0;
            val_19 = public System.Boolean System.Object::Equals(object obj);
            val_16 = mem[val_2 + 16];
            val_16 = val_2 + 16;
            if(val_16 == 0)
        {
                val_16 = 0;
            val_17 = val_17;
            val_18 = 0;
            val_19 = public System.Boolean System.Object::Equals(object obj);
        }
        
        }
        
        bool val_5 = UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_17, y = 0f, z = 1.9605E-38f}, rhs:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 3.673424E-39f});
        if(val_5 == false)
        {
            goto label_13;
        }
        
        bool val_6 = UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = edge.<Vertex2>k__BackingField, y = 3.673424E-39f, z = val_5}, rhs:  new UnityEngine.Vector3() {x = val_2 + 16 + 20, y = val_2 + 16 + 24, z = val_2 + 16 + 28});
        if(val_6 == true)
        {
            goto label_22;
        }
        
        label_13:
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = edge.<Vertex1>k__BackingField, y = 3.673424E-39f, z = val_6}, rhs:  new UnityEngine.Vector3() {x = val_2 + 16 + 20, y = val_2 + 16 + 24, z = val_2 + 16 + 28})) == false)
        {
            goto label_19;
        }
        
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = edge.<Vertex2>k__BackingField, y = 2.289704E-07f, z = 3.673424E-39f}, rhs:  new UnityEngine.Vector3() {x = val_2 + 16 + 8, y = val_2 + 16 + 12, z = val_2 + 16 + 16})) == true)
        {
            goto label_22;
        }
        
        label_19:
        val_20 = mem[val_2 + 20];
        val_20 = val_2 + 20;
        if(val_20 == 0)
        {
            goto label_33;
        }
        
        if((val_2 + 12) <= 1)
        {
                val_20 = mem[val_2 + 20];
            val_20 = val_2 + 20;
            if(val_20 == 0)
        {
                val_20 = 0;
        }
        
        }
        
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = edge.<Vertex1>k__BackingField, y = 3.673424E-39f, z = val_2 + 12}, rhs:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 3.673424E-39f})) != false)
        {
                if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = edge.<Vertex2>k__BackingField, y = edge.<Vertex1>k__BackingField, z = 3.673424E-39f}, rhs:  new UnityEngine.Vector3() {x = val_2 + 20 + 20, y = val_2 + 20 + 24, z = val_2 + 20 + 28})) == true)
        {
            goto label_36;
        }
        
        }
        
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = edge.<Vertex1>k__BackingField, y = edge.<Vertex1>k__BackingField, z = 3.673424E-39f}, rhs:  new UnityEngine.Vector3() {x = val_2 + 20 + 20, y = val_2 + 20 + 24, z = val_2 + 20 + 28})) == false)
        {
            goto label_33;
        }
        
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = edge.<Vertex2>k__BackingField, y = 2.289704E-07f, z = 3.673424E-39f}, rhs:  new UnityEngine.Vector3() {x = val_2 + 20 + 8, y = val_2 + 20 + 12, z = val_2 + 20 + 16})) == true)
        {
            goto label_36;
        }
        
        label_33:
        int val_15 = edgeGroupIndex;
        val_15 = val_15 + 1;
        mem2[0] = val_15;
        label_2:
        if(MoveNext() == true)
        {
            goto label_37;
        }
        
        val_21 = 0;
        val_22 = 0;
        goto label_38;
        label_22:
        if((val_2 + 12) > 1)
        {
            goto label_42;
        }
        
        goto label_42;
        label_36:
        if((val_2 + 12) != 0)
        {
                val_15 = val_2 + 16;
        }
        else
        {
                val_15 = val_2 + 16;
        }
        
        label_42:
        val_22 = mem[val_2 + 16];
        val_22 = val_15;
        val_21 = 2;
        label_38:
        Dispose();
        if(((val_21 + 2) & 3) != 0)
        {
                0 = val_22;
        }
    
    }
    private bool AddEdgeCrossPoint(UnityEngine.Vector3 vertex1, UnityEngine.Vector3 vertex2, ref System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> crossPoints, out bool isCrosspointOutOfTreshold, bool checkTreshold)
    {
        float val_8;
        float val_9;
        float val_10;
        float val_15;
        float val_16;
        float val_17;
        float val_18;
        bool val_19;
        float val_20;
        UnityEngine.Plane val_21;
        var val_22;
        val_15 = vertex1.z;
        val_16 = vertex1.y;
        val_17 = vertex2.y;
        val_18 = vertex2.x;
        val_18 = vertex2.x;
        val_17 = vertex2.y;
        val_19 = false;
        isCrosspointOutOfTreshold = val_19;
        val_20 = val_17;
        val_21 = this._piecePlane;
        if((val_21.SameSide(inPt0:  new UnityEngine.Vector3() {x = vertex1.x, y = val_16, z = val_15}, inPt1:  new UnityEngine.Vector3() {x = val_18, y = val_17, z = vertex2.z})) == true)
        {
                return (bool)val_19;
        }
        
        val_19 = 0;
        if((GetSide(point:  new UnityEngine.Vector3() {x = vertex1.x, y = val_16, z = val_15})) != true)
        {
                if((GetSide(point:  new UnityEngine.Vector3() {x = vertex2.x, y = val_20, z = vertex2.z})) == false)
        {
                return (bool)val_19;
        }
        
        }
        
        float val_16 = vertex1.x;
        float val_15 = val_16;
        val_19 = 0;
        val_15 = val_20 - val_15;
        val_16 = vertex2.x - val_16;
        float val_17 = val_15;
        val_17 = vertex2.z - val_17;
        UnityEngine.Ray val_4 = new UnityEngine.Ray(origin:  new UnityEngine.Vector3() {x = vertex1.x, y = val_16, z = val_15}, direction:  new UnityEngine.Vector3() {x = val_16, y = val_15, z = val_17});
        bool val_6 = val_21.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_4.m_Origin.x, y = val_4.m_Origin.y, z = val_4.m_Origin.z}, m_Direction = new UnityEngine.Vector3() {x = val_4.m_Direction.x, y = val_4.m_Direction.y, z = val_4.m_Direction.z}}, enter: out  val_19);
        UnityEngine.Vector3 val_7 = GetPoint(distance:  val_16);
        val_20 = val_8;
        val_15 = val_9;
        val_16 = val_10;
        if((GetSide(point:  new UnityEngine.Vector3() {x = val_20, y = val_15, z = val_16})) == false)
        {
                return (bool)val_19;
        }
        
        536897093 = new WrappingRopeLibrary.Model.WrapPoint();
        mem[536897101] = val_20;
        mem[536897105] = val_15;
        mem[536897109] = val_16;
        UnityEngine.Vector3 val_13 = normal;
        mem[536897113] = val_8;
        mem[536897117] = val_9;
        mem[536897121] = val_10;
        mem[536897137] = mem[1152921509782097688];
        val_21 = checkTreshold;
        crossPoints.Add(item:  536897093);
        val_22 = 0;
        val_19 = 1;
        isCrosspointOutOfTreshold = this.IsPointOutOfTreshold(point:  new UnityEngine.Vector3() {x = val_20, y = val_15, z = val_16});
        return (bool)val_19;
    }
    private bool IsCrossPointInWorkSpace(UnityEngine.Vector3 vertex1, UnityEngine.Vector3 vertex2)
    {
        UnityEngine.Plane val_9;
        float val_10;
        float val_11;
        val_9 = this;
        val_10 = vertex1.x;
        val_11 = 0f;
        if((this._piecePlane.SameSide(inPt0:  new UnityEngine.Vector3() {x = val_10, y = vertex1.y, z = vertex1.z}, inPt1:  new UnityEngine.Vector3() {x = vertex2.x, y = vertex2.y, z = vertex2.z})) == true)
        {
                return (bool)val_11;
        }
        
        val_9 = this._crossPlane;
        val_11 = 0;
        if((val_9.GetSide(point:  new UnityEngine.Vector3() {x = val_10, y = vertex1.y, z = vertex1.z})) != true)
        {
                if((val_9.GetSide(point:  new UnityEngine.Vector3() {x = vertex2.x, y = vertex2.y, z = vertex2.z})) == false)
        {
                return (bool)val_11;
        }
        
        }
        
        float val_9 = val_10;
        float val_10 = vertex1.y;
        val_9 = vertex2.x - val_9;
        float val_11 = vertex1.z;
        val_10 = vertex2.y - val_10;
        val_11 = vertex2.z - val_11;
        UnityEngine.Ray val_4 = new UnityEngine.Ray(origin:  new UnityEngine.Vector3() {x = val_10, y = vertex1.y, z = vertex1.z}, direction:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_11});
        val_10 = val_4.m_Direction.y;
        bool val_6 = this._piecePlane.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_4.m_Origin.x, y = val_4.m_Origin.y, z = val_4.m_Origin.z}, m_Direction = new UnityEngine.Vector3() {x = val_4.m_Direction.x, y = val_10, z = val_4.m_Direction.z}}, enter: out  val_11);
        UnityEngine.Vector3 val_7 = GetPoint(distance:  val_9);
        val_11 = val_9.GetSide(point:  new UnityEngine.Vector3());
        return (bool)val_11;
    }
    private bool IsPointOutOfTreshold(UnityEngine.Vector3 point)
    {
        float val_5;
        float val_6;
        float val_7;
        if(this._pieceInfo == 0)
        {
                this._pieceInfo = this._pieceInfo;
        }
        
        UnityEngine.Vector3 val_10 = this._pieceInfo.<FrontBandPoint>k__BackingField;
        float val_1 = S20 - S26;
        val_10 = val_10 - (this._pieceInfo.<BackBandPoint>k__BackingField);
        UnityEngine.Transform val_3 = this._gameObject.transform;
        UnityEngine.Vector3 val_4 = TransformPoint(position:  new UnityEngine.Vector3() {x = this._gameObject, y = point.x, z = point.y});
        float val_11 = val_5;
        float val_12 = val_6;
        float val_13 = val_7;
        val_11 = val_11 - (this._pieceInfo.<BackBandPoint>k__BackingField);
        val_12 = val_12 - val_4.z;
        val_13 = val_13 - S4;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.Project(vector:  new UnityEngine.Vector3() {x = 2.343833E-07f, y = val_11, z = val_12}, onNormal:  new UnityEngine.Vector3() {x = val_13, y = val_10, z = S18 - S24});
        float val_14 = val_5;
        float val_15 = val_6;
        float val_16 = val_7;
        val_14 = val_11 - val_14;
        val_15 = val_12 - val_15;
        val_16 = val_13 - val_16;
        float val_9 = val_14.sqrMagnitude;
        if(this._pieceInfo > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    private System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> GetWrapPathFromCrossPoints(System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> crossPoints)
    {
        536878545 = new System.Collections.Generic.List<Page>();
        if(536878545 <= 3)
        {
                -1073711189 = 0;
        }
        
        this.DefineWrapPatchPoint(sourcePlane:  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = this._piecePlane, y = SL, z = SB}, m_Distance = 4.094631E-38f}, sourcePoint:  new UnityEngine.Vector3() {x = mem[this._localPiecePoints[0x34] + (0)], y = mem[this._localPiecePoints[0x34] + (4)], z = mem[this._localPiecePoints[0x34] + (8)]}, crossPoints:  crossPoints, pathPoints: ref  536878545);
    }
    private void DefineWrapPatchPoint(UnityEngine.Plane sourcePlane, UnityEngine.Vector3 sourcePoint, System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> crossPoints, ref System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> pathPoints)
    {
        var val_3;
        var val_4;
        var val_5;
        var val_17;
        var val_26;
        var val_27;
        float val_28;
        System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> val_29;
        var val_30;
        System.Collections.Generic.List<WrappingRopeLibrary.Model.WrapPoint> val_31;
        float val_32;
        var val_33;
        var val_34;
        GameObjectWraper.WrapPathFinder.<>c__DisplayClass23_0 val_1 = 536902637;
        val_26 = val_1;
        val_1 = new GameObjectWraper.WrapPathFinder.<>c__DisplayClass23_0();
        UnityEngine.Vector3 val_2 = normal;
        float val_6 = val_5 + sourcePoint.z;
        float val_7 = val_4 + sourcePoint.y;
        val_28 = val_3 + sourcePoint.x;
        if(val_7 <= (1.401298E-45f))
        {
                val_27 = 0;
        }
        
        val_29 = crossPoints;
        UnityEngine.Plane val_9 = WrappingRopeLibrary.Utils.Geometry.GetPlane(v1:  new UnityEngine.Vector3() {x = 2.40788E-07f, y = sourcePoint.x, z = sourcePoint.y}, v2:  new UnityEngine.Vector3() {x = sourcePoint.z, y = mem[this._localPiecePoints[0x1C] + (0)], z = mem[this._localPiecePoints[0x1C] + (4)]}, v3:  new UnityEngine.Vector3() {x = mem[this._localPiecePoints[0x1C] + (8)], y = val_28, z = val_7});
        var val_10 = val_26 + 8;
        536875587 = new System.Func<MessageTypeSubscribers, System.Boolean>(object:  536902637, method:  new IntPtr(1610682707));
        if((System.Linq.Enumerable.All<WrappingRopeLibrary.Model.WrapPoint>(source:  val_29, predicate:  536875587)) == true)
        {
                return;
        }
        
        536878545 = new System.Collections.Generic.List<Page>();
        if(val_29 != 0)
        {
            
        }
        else
        {
                val_30 = 0;
        }
        
        List.Enumerator<T> val_14 = GetEnumerator();
        label_14:
        if(MoveNext() == false)
        {
            goto label_7;
        }
        
        536902641 = new GameObjectWraper.WrapPathFinder.<>c__DisplayClass23_1();
        mem[536902653] = val_26;
        mem[536902649] = val_17;
        var val_18 = mem[536902649] + 8;
        UnityEngine.Plane val_19 = WrappingRopeLibrary.Utils.Geometry.GetPlane(v1:  new UnityEngine.Vector3() {x = 2.40788E-07f, y = sourcePoint.x, z = sourcePoint.y}, v2:  new UnityEngine.Vector3() {x = sourcePoint.z, y = mem[(val_17 + 8) + (0)], z = mem[(val_17 + 8) + (4)]}, v3:  new UnityEngine.Vector3() {x = mem[(val_17 + 8) + (8)], y = val_28, z = val_7});
        val_29 = crossPoints;
        var val_20 = mem[536902653] + 8;
        536879267 = new System.Predicate<Page>(object:  536902641, method:  new IntPtr(1610682711));
        System.Collections.Generic.List<T> val_22 = val_29.FindAll(match:  536879267);
        val_31 = val_29;
        if(val_30 <= val_29)
        {
            goto label_14;
        }
        
        val_30 = val_29;
        if(val_29 != 0)
        {
            goto label_14;
        }
        
        val_32 = mem[536902649];
        val_33 = val_32;
        goto label_15;
        label_7:
        val_31 = val_31;
        val_32 = 0;
        val_33 = 0;
        label_15:
        Dispose();
        val_28 = pathPoints;
        if(val_33 == 0)
        {
            goto label_16;
        }
        
        if(val_31 != 0)
        {
            goto label_17;
        }
        
        val_28 = pathPoints;
        if((-1073728093) != 1)
        {
            goto label_27;
        }
        
        Dispose();
        val_32 = 0;
        val_31 = val_31;
        label_16:
        if((crossPoints + 12) == 0)
        {
                return;
        }
        
        label_17:
        if((crossPoints + 12) >= 1)
        {
                crossPoints + 12 = mem[crossPoints + 8];
            crossPoints + 12 = crossPoints + 8;
            val_32 = mem[crossPoints + 8 + 16];
            val_32 = crossPoints + 8 + 16;
            0 = val_32;
        }
        
        if(val_29 != 0)
        {
                val_34 = val_29.IndexOf(item:  0);
        }
        else
        {
                val_34 = val_29.IndexOf(item:  0);
        }
        
        val_29.RemoveRange(index:  0, count:  val_34 + 1);
        val_28.Add(item:  0);
        var val_27 = 0 + 8;
        return;
        label_27:
    }

}
