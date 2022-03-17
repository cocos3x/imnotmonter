using UnityEngine;

namespace Ferr
{
    [Serializable]
    public class Path2D : ISVGElement
    {
        // Fields
        protected System.Collections.Generic.List<UnityEngine.Vector2> _points;
        protected System.Collections.Generic.List<Ferr.PointControl> _pointControls;
        protected bool _closed;
        protected float _splitDistance;
        private System.Collections.Generic.List<int> _mapToSmooth;
        private System.Collections.Generic.List<UnityEngine.Vector2> _smoothPoints;
        private Ferr.PathDistanceMask _distanceMask;
        private bool _controlsDirty;
        
        // Properties
        public UnityEngine.Vector2 Item { get; set; }
        public int Count { get; }
        public UnityEngine.Rect Bounds { get; }
        public UnityEngine.Vector2 Start { get; }
        public UnityEngine.Vector2 End { get; }
        public float TotalLength { get; }
        public float SmoothSplitDistance { get; set; }
        public bool Closed { get; set; }
        protected System.Collections.Generic.List<UnityEngine.Vector2> SmoothPoints { get; }
        protected System.Collections.Generic.List<Ferr.PointControl> PointControls { get; }
        public Ferr.PathDistanceMask DistanceMask { get; }
        
        // Methods
        public UnityEngine.Vector2 get_Item(int aIndex)
        {
            int val_1 = Ferr.PathUtil.WrapIndex(aIndex:  R2, aCount:  aIndex + 12 + 12, aClosed:  aIndex + 16);
            if((aIndex + 8 + 12) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = aIndex + 8 + 8;
            val_2 = val_2 + (val_1 << 3);
            return new UnityEngine.Vector2();
        }
        public void set_Item(int aIndex, UnityEngine.Vector2 value)
        {
            this._points.set_Item(index:  Ferr.PathUtil.WrapIndex(aIndex:  aIndex, aCount:  aIndex, aClosed:  this._closed), value:  new UnityEngine.Vector2() {x = value.x, y = value.y});
            goto typeof(Ferr.Path2D).__il2cppRuntimeField_154;
        }
        public int get_Count()
        {
            if(this._points != 0)
            {
                    return (int)true;
            }
            
            return (int)true;
        }
        public UnityEngine.Rect get_Bounds()
        {
            UnityEngine.Rect val_1 = Ferr.PathUtil.GetBounds(aPoints:  1242080400, aPadding:  new UnityEngine.Vector4() {x = R1 + 8, y = 0f, z = 0f, w = 0f});
            return new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_Height};
        }
        public UnityEngine.Vector2 get_Start()
        {
            if((R1 + 8 + 12) != 0)
            {
                    return new UnityEngine.Vector2();
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            return new UnityEngine.Vector2();
        }
        public UnityEngine.Vector2 get_End()
        {
            var val_1;
            var val_2;
            var val_3;
            if((R1 + 16) != 0)
            {
                    if((R1 + 8 + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = mem[R1 + 8 + 8];
                val_1 = R1 + 8 + 8;
            }
            else
            {
                    if((R1 + 8) != 0)
            {
                    val_2 = mem[R1 + 8 + 12];
                val_2 = R1 + 8 + 12;
                val_3 = val_2;
            }
            else
            {
                    val_3 = 0;
                val_2 = 0;
            }
            
                if(val_2 <= (-1))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = (R1 + 8 + 8) + 4294967288;
            }
            
            val_1 = val_1 + 16;
            return new UnityEngine.Vector2();
        }
        public float get_TotalLength()
        {
            if(this._distanceMask != 0)
            {
                    return this._distanceMask.GetTotalDistance();
            }
            
            return this._distanceMask.GetTotalDistance();
        }
        public float get_SmoothSplitDistance()
        {
            return (float)S0;
        }
        public void set_SmoothSplitDistance(float value)
        {
            this._splitDistance = R1;
        }
        public bool get_Closed()
        {
            return (bool)this._closed;
        }
        public void set_Closed(bool value)
        {
            if(this._closed == true)
            {
                    this._closed = 1;
            }
            
            bool val_1 = 1 ^ value;
            this._closed = value;
        }
        protected System.Collections.Generic.List<UnityEngine.Vector2> get_SmoothPoints()
        {
        
        }
        protected System.Collections.Generic.List<Ferr.PointControl> get_PointControls()
        {
        
        }
        public Ferr.PathDistanceMask get_DistanceMask()
        {
        
        }
        public Path2D()
        {
            this._controlsDirty = true;
            this._splitDistance = 1f;
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            this._points = 536878507;
            536878163 = new System.Collections.Generic.List<Page>();
            this._pointControls = 536878163;
            goto typeof(Ferr.Path2D).__il2cppRuntimeField_154;
        }
        public Path2D(System.Collections.Generic.List<UnityEngine.Vector2> aPoints)
        {
            float val_3;
            float val_4;
            System.Collections.Generic.List<UnityEngine.Vector2> val_7;
            var val_8;
            val_7 = aPoints;
            this._controlsDirty = true;
            this._splitDistance = 1f;
            this._points = val_7;
            536878163 = new System.Collections.Generic.List<Page>();
            mem[1152921510145287580] = 536878163;
            val_8 = 0;
            goto label_1;
            label_4:
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            val_7 = val_3;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
            536891893 = new Ferr.PointControl(aType:  2, aRadius:  val_5.x, aControlPrev:  new UnityEngine.Vector2() {x = 1f, y = val_7}, aControlNext:  new UnityEngine.Vector2() {x = val_4, y = val_3});
            mem[1152921510145287580].Add(item:  536891893);
            val_8 = 1;
            label_1:
            if(val_8 < (aPoints + 12))
            {
                goto label_4;
            }
        
        }
        public Path2D(Ferr.Path2D aCopyPath)
        {
            System.Collections.Generic.List<SingleRange> val_4;
            var val_5;
            this._controlsDirty = true;
            this._splitDistance = 1f;
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(collection:  aCopyPath._points);
            this._points = 536878507;
            val_4 = 536878163;
            val_4 = new System.Collections.Generic.List<SingleRange>(capacity:  aCopyPath._points);
            var val_4 = val_4;
            this._pointControls = val_4;
            val_5 = 0;
            goto label_4;
            label_9:
            val_4 = this._pointControls;
            if(1152921510145424156 <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            536891893 = new Ferr.PointControl(aCopy:  (val_4 + 0) + 16);
            val_4.Add(item:  536891893);
            val_5 = 1;
            label_4:
            if(val_5 < val_4)
            {
                goto label_9;
            }
            
            this.CopySettings(aCopyPath:  aCopyPath);
        }
        public void CopySettings(Ferr.Path2D aCopyPath)
        {
            if(aCopyPath != 0)
            {
                    this._closed = aCopyPath._closed;
            }
            else
            {
                    this._closed = true;
            }
            
            this._splitDistance = aCopyPath._splitDistance;
            goto typeof(Ferr.Path2D).__il2cppRuntimeField_154;
        }
        public virtual int Add(UnityEngine.Vector2 aPt, Ferr.PointType aType = 2, float aRadius = 1, UnityEngine.Vector2 aControlPointPrev, UnityEngine.Vector2 aControlPointNext)
        {
            536891893 = new Ferr.PointControl(aType:  aType, aRadius:  aRadius, aControlPrev:  new UnityEngine.Vector2() {x = aControlPointPrev.x, y = aControlPointPrev.y}, aControlNext:  new UnityEngine.Vector2() {x = aControlPointNext.x, y = aControlPointNext.y});
            return (int)this;
        }
        public virtual int Add(UnityEngine.Vector2 aPt, Ferr.PointControl aControls)
        {
            this._points.Add(item:  new UnityEngine.Vector2() {x = aPt.x, y = aPt.y});
            this._pointControls.Add(item:  aControls);
            if(this._points != 0)
            {
                    return (int)1152921510145813391;
            }
            
            return (int)1152921510145813391;
        }
        public void Add(Ferr.Path2D aPath)
        {
            var val_8;
            var val_9;
            val_8 = 0;
            goto label_1;
            label_5:
            if(aPath != 0)
            {
                    Ferr.PointControl val_1 = aPath.GetControls(aRawIndex:  0);
                val_9 = aPath;
            }
            else
            {
                    Ferr.PointControl val_2 = this.GetControls(aRawIndex:  0);
                val_9 = 0;
            }
            
            UnityEngine.Vector2 val_3 = Item[aPath];
            536891893 = new Ferr.PointControl(aCopy:  0);
            val_8 = 1;
            label_1:
            if(val_8 < aPath.Count)
            {
                goto label_5;
            }
        
        }
        public virtual void Insert(int aRawIndex, UnityEngine.Vector2 aPt, Ferr.PointType aType = 2, float aRadius = 1, UnityEngine.Vector2 aControlPointPrev, UnityEngine.Vector2 aControlPointNext)
        {
            536891893 = new Ferr.PointControl(aType:  aType, aRadius:  aRadius, aControlPrev:  new UnityEngine.Vector2() {x = aControlPointPrev.x, y = aControlPointPrev.y}, aControlNext:  new UnityEngine.Vector2() {x = aControlPointNext.x, y = aControlPointNext.y});
        }
        public virtual void Insert(int aRawIndex, UnityEngine.Vector2 aPt, Ferr.PointControl aControls)
        {
            this._points.Insert(index:  aRawIndex, item:  new UnityEngine.Vector2() {x = aPt.x, y = aPt.y});
            this._pointControls.Insert(index:  aRawIndex, item:  aControls);
            goto typeof(Ferr.Path2D).__il2cppRuntimeField_154;
        }
        public virtual void RemoveAt(int aRawIndex)
        {
            this._points.RemoveAt(index:  aRawIndex);
            this._pointControls.RemoveAt(index:  aRawIndex);
            goto typeof(Ferr.Path2D).__il2cppRuntimeField_154;
        }
        public virtual void Clear()
        {
            this._pointControls.Clear();
            this._points.Clear();
            if(this._smoothPoints != 0)
            {
                    this._smoothPoints.Clear();
            }
            
            if(this._distanceMask != 0)
            {
                    this._distanceMask.Clear();
            }
            
            this._controlsDirty = true;
        }
        public UnityEngine.Vector2 Get(int aRawIndex)
        {
            if((aRawIndex + 8 + 12) <= R2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_1 = aRawIndex + 8 + 8;
            val_1 = val_1 + (R2 << 3);
            return new UnityEngine.Vector2();
        }
        public Ferr.PointControl GetControls(int aRawIndex)
        {
            if(this <= aRawIndex)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (aRawIndex << 2);
        }
        public System.Collections.Generic.List<Ferr.PointControl> GetControls()
        {
        
        }
        public UnityEngine.Vector2 Get(int aRawIndex, float aPercent)
        {
            UnityEngine.Vector2 val_1 = GetPointAtPercent(aSmoothPoints:  aRawIndex + 32, aRawIndex:  aRawIndex + 28, aPercent:  aPercent);
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        public virtual void Set(int aIndex, UnityEngine.Vector2 aValue)
        {
            this._points.set_Item(index:  aIndex, value:  new UnityEngine.Vector2() {x = aValue.x, y = aValue.y});
            goto typeof(Ferr.Path2D).__il2cppRuntimeField_154;
        }
        public float GetInteriorAngle(int aRawIndex)
        {
            return Ferr.PathUtil.GetInteriorAngle(i:  aRawIndex, aPath:  this._points, aClosed:  this._closed);
        }
        public UnityEngine.Vector2 GetNormal(int aIndex, float aPercent = 0)
        {
            Ferr.Path2D val_3;
            var val_4;
            var val_5 = 22999416;
            UnityEngine.Vector2 val_1 = Ferr.PathUtil.GetPointNormal(i:  1245470352, aPath:  R2, aClosed:  aIndex + 8);
            this = val_3;
            mem[1152921510147296660] = val_4;
            return new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        }
        public UnityEngine.Vector2 GetSegmentNormal(int aRawIndex)
        {
            UnityEngine.Vector2 val_1 = Ferr.PathUtil.GetSegmentNormal(i:  1245582360, aPath:  R2, aClosed:  aRawIndex + 8);
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        public UnityEngine.Vector2 GetTangent(int aRawIndex, float aPercent = 0)
        {
            UnityEngine.Vector2 val_1 = Ferr.PathUtil.GetPointTangent(i:  1245694360, aPath:  R2, aClosed:  aRawIndex + 8);
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        public System.Collections.Generic.List<UnityEngine.Vector2> GetSubPathDistance(float aStart, float aLength)
        {
            float val_12;
            float val_13;
            float val_18;
            System.Collections.Generic.List<UnityEngine.Vector2> val_20;
            float val_21;
            float val_2 = UnityEngine.Mathf.Clamp(value:  this._distanceMask.GetTotalDistance(), min:  aLength, max:  null);
            float val_3 = R1 + R2;
            val_18 = R1;
            float val_4 = UnityEngine.Mathf.Clamp(value:  val_3, min:  aLength, max:  null);
            if(this._closed == true)
            {
                    this._closed = 1;
            }
            
            val_20 = this._distanceMask.GetRawPointIndexAtDistance(aDistance:  val_4, aPercent: out  val_18, aWrap:  true);
            if(this._closed == true)
            {
                    val_21 = 1;
            }
            
            float val_7 = val_3;
            int val_8 = this._distanceMask.GetRawPointIndexAtDistance(aDistance:  val_4, aPercent: out  val_7, aWrap:  false);
            int val_9 = val_8 - val_20;
            val_7 = val_9 + 2;
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  val_7);
            if(this._closed != false)
            {
                    UnityEngine.Vector2 val_11 = Ferr.PathUtil.GetBezierPoint(i:  1245830904, aPercent:  val_4, aPath:  val_20, aControls:  0, aClosed:  this._points);
                val_21 = val_12;
                val_18 = val_13;
                536878507.Add(item:  new UnityEngine.Vector2() {x = val_21, y = val_18});
            }
            
            if(val_9 >= 1)
            {
                    val_21 = this._smoothPoints;
                int val_14 = val_20 + 1;
                System.Collections.Generic.List<T> val_16 = val_21.GetRange(index:  val_14, count:  val_8 - val_14);
                val_20 = val_21;
                536878507.AddRange(collection:  val_20);
            }
            
            if(536878507 == 0)
            {
                    return;
            }
            
            val_20 = this._points;
            UnityEngine.Vector2 val_17 = Ferr.PathUtil.GetBezierPoint(i:  1245830904, aPercent:  val_11.x, aPath:  val_8, aControls:  0, aClosed:  val_20);
            val_21 = val_13;
            536878507.Add(item:  new UnityEngine.Vector2() {x = val_12, y = val_21});
        }
        public int GetClosestSegment(UnityEngine.Vector2 aPoint)
        {
            var val_3;
            int val_1 = Ferr.PathUtil.GetClosestSegment(aPath:  this._smoothPoints, aPoint:  new UnityEngine.Vector2() {x = aPoint.x, y = aPoint.y}, aClosed:  this._closed);
            if(val_1 != 1)
            {
                    if(this <= val_1)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = val_3 + ((val_1 + (val_1 << 1)) << 2);
                val_3 = mem[(0 + ((val_1 + (val_1) << 1)) << 2) + 24];
                val_3 = (0 + ((val_1 + (val_1) << 1)) << 2) + 24;
                return (int)val_3;
            }
            
            val_3 = 0;
            return (int)val_3;
        }
        public int GetClosestControlPoint(UnityEngine.Vector2 aPoint)
        {
            return (int)Ferr.PathUtil.GetClosestPoint(aPoints:  this._points, aPoint:  new UnityEngine.Vector2() {x = aPoint.x, y = aPoint.y}, aIgnore:  0);
        }
        public float GetDistanceFromPath(UnityEngine.Vector2 aPoint)
        {
            return (float)Ferr.PathUtil.GetDistanceFromPath(aPath:  this._smoothPoints, aPoint:  new UnityEngine.Vector2() {x = aPoint.x, y = aPoint.y}, aClosed:  this._closed);
        }
        public System.Collections.Generic.List<UnityEngine.Vector2> GetSubPathRaw(int aStart, int aLength)
        {
            if(this._points != 0)
            {
                    return this._points.GetRange(index:  aStart, count:  aLength);
            }
            
            return this._points.GetRange(index:  aStart, count:  aLength);
        }
        public System.Collections.Generic.List<UnityEngine.Vector2> GetPathRaw()
        {
        
        }
        public System.Collections.Generic.List<UnityEngine.Vector2> GetPathRawCopy()
        {
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(collection:  this._points);
        }
        public bool Contains(UnityEngine.Vector2 aPoint)
        {
            return Ferr.PathUtil.IsInPoly(aPoly:  this._smoothPoints, aPoint:  new UnityEngine.Vector2() {x = aPoint.x, y = aPoint.y});
        }
        public bool IsClockwise()
        {
            return Ferr.PathUtil.IsClockwise(aPoly:  this._points);
        }
        public virtual void ReverseSelf()
        {
            Ferr.Path2D val_3;
            System.Collections.Generic.List<UnityEngine.Vector2> val_4;
            System.Collections.Generic.List<Page> val_5;
            var val_6;
            var val_7;
            var val_8;
            val_3 = this;
            val_4 = 536878507;
            val_4 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            val_5 = 536878163;
            val_5 = new System.Collections.Generic.List<Page>();
            if(1152921510148767639 >= 0)
            {
                    var val_3 = 8 + 1385692352;
                do
            {
                if((this._pointControls + 12) <= 1152921510148767639)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = mem[this._pointControls + 8 + 692846188];
                val_3 = this._pointControls + 8 + 692846188;
                if(val_3 != 0)
            {
                    val_6 = val_3;
                val_7 = mem[this._pointControls + 8 + 692846188 + 20];
                val_7 = this._pointControls + 8 + 692846188 + 20;
                val_8 = mem[this._pointControls + 8 + 692846188 + 20 + 4];
                val_8 = this._pointControls + 8 + 692846188 + 20 + 4;
            }
            else
            {
                    val_6 = 20;
                val_8 = 0;
                val_7 = 1;
            }
            
                mem2[0] = val_7;
                mem2[0] = val_8;
                if((this._pointControls + 12) <= 1152921510148767639)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                mem[20] = this._pointControls + 8 + 692846188 + 12;
                mem2[0] = this._pointControls + 8 + 692846188 + 16;
                val_4 = val_4;
                if((this._points + 12) <= 1152921510148767639)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4.Add(item:  new UnityEngine.Vector2() {x = this._points + 8 + (8 + 1385692352), y = this._points + 8 + (8 + 1385692352) + 4});
                val_5 = val_5;
                val_5.Add(item:  val_3);
                val_3 = val_3 - 8;
            }
            while(1152921510148767638 > 1);
            
            }
            
            this._points = val_4;
            this._pointControls = val_5;
        }
        public int GetSegment(UnityEngine.Vector2 aClosestTo)
        {
            return (int)Ferr.PathUtil.GetClosestSegment(aPath:  this._points, aPoint:  new UnityEngine.Vector2() {x = aClosestTo.x, y = aClosestTo.y}, aClosed:  this._closed);
        }
        public System.Collections.Generic.List<UnityEngine.Vector2> GetFinalPath()
        {
        
        }
        public System.Collections.Generic.List<UnityEngine.Vector2> GetFinalPathCopy()
        {
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(collection:  this._smoothPoints);
        }
        public System.Collections.Generic.List<UnityEngine.Vector2> GetFinalNormalsCopy()
        {
            return Ferr.PathUtil.GetNormals(aPath:  this._smoothPoints, aClosed:  this._closed);
        }
        public System.Collections.Generic.List<UnityEngine.Vector2> GetFinalTangentsCopy()
        {
            System.Collections.Generic.List<UnityEngine.Vector2> val_1 = Ferr.PathUtil.GetNormals(aPath:  this._smoothPoints, aClosed:  this._closed);
            return Ferr.PathUtil.NormalsToTangents(aNormals:  this._smoothPoints);
        }
        public float GetDistanceAt(int aRawIndex)
        {
            if(this <= aRawIndex)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + (aRawIndex << 2);
            if(val_2 <= ((0 + (aRawIndex) << 2) + 16))
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + ((((0 + (aRawIndex) << 2) + 16) + (((0 + (aRawIndex) << 2) + 16) << 1)) << 2);
            return (float)S0;
        }
        public float GetDistanceBetween(int aStartIndex, int aEndIndex)
        {
            var val_4;
            float val_1 = this.GetDistanceAt(aRawIndex:  aStartIndex);
            float val_2 = this.GetDistanceAt(aRawIndex:  aEndIndex);
            if(<0)
            {
                    float val_3 = this._distanceMask.GetTotalDistance();
                Ferr.PathDistanceMask val_4 = this._distanceMask;
                val_4 = 1247802896 + val_4;
            }
            
            val_4 = val_4 - 1247802896;
            return (float)val_4;
        }
        public int GetSegmentAtDistance(float aDist)
        {
            var val_3;
            if(this._closed == true)
            {
                    this._closed = 1;
            }
            
            Ferr.PathDMPoint val_1 = GetDataAtDistance(aDistance:  aDist, aWrap:  this._distanceMask);
            if(this._closed >= false)
            {
                    return Ferr.PathUtil.WrapIndex(aIndex:  val_3 + 1, aCount:  val_1.percent, aClosed:  this._closed);
            }
            
            return (int)val_3;
        }
        public UnityEngine.Vector2 GetPointAtDistance(float aDist)
        {
            if((R1 + 16) != 0)
            {
                    R1 + 16 = 1;
            }
            
            UnityEngine.Vector2 val_1 = GetPointAtDistance(aPoints:  R1 + 32, aDistance:  aDist, aClosed:  R1 + 28);
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        public UnityEngine.Vector2 GetNormalAtDistance(float aDist)
        {
            if((R1 + 16) != 0)
            {
                    R1 + 16 = 1;
            }
            
            UnityEngine.Vector2 val_3 = Ferr.PathUtil.GetSegmentNormal(i:  1248147328, aPath:  R1 + 32.GetSmoothPointIndexAtDistance(aDistance:  aDist, aPercent: out  R2, aWrap:  true), aClosed:  R1 + 28);
            return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
        public UnityEngine.Vector2 GetTangentAtDistance(float aDist)
        {
            if((R1 + 16) != 0)
            {
                    R1 + 16 = 1;
            }
            
            UnityEngine.Vector2 val_3 = Ferr.PathUtil.GetSegmentTangent(i:  1248259328, aPath:  R1 + 32.GetSmoothPointIndexAtDistance(aDistance:  aDist, aPercent: out  R2, aWrap:  true), aClosed:  R1 + 28);
            return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
        public void RemoveDuplicates()
        {
            var val_1;
            var val_2;
            var val_3;
            System.Collections.Generic.List<Ferr.PointControl> val_4;
            val_1 = 0;
            goto label_1;
            label_15:
            val_2 = 0;
            goto label_2;
            label_13:
            val_3 = val_1;
            if(val_1 != val_2)
            {
                    if(val_3 <= val_1)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                val_4 = mem[(0 + 0) + 16];
                val_4 = (0 + 0) + 16;
                if(val_1 <= val_2)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_3 = R7;
                val_2 = val_2 + 0;
                var val_4 = (0 + 0) + 16;
                val_3 = val_3 - ((0 + 0) + 20);
                val_4 = val_4 - val_4;
                val_3 = val_3 * val_3;
                if(val_1 < 0)
            {
                    this._points.RemoveAt(index:  0);
                val_4 = this._pointControls;
                val_4.RemoveAt(index:  0);
                val_3 = -1;
            }
            else
            {
                    val_3 = val_2;
            }
            
            }
            
            val_2 = val_3 + 1;
            label_2:
            if(val_2 < val_3)
            {
                goto label_13;
            }
            
            val_1 = 1;
            label_1:
            if(val_1 < val_3)
            {
                goto label_15;
            }
        
        }
        public bool SelfIntersecting()
        {
            var val_3;
            var val_4;
            bool val_5;
            var val_6;
            bool val_7;
            var val_8;
            bool val_1 = this._closed - 1;
            val_3 = 0;
            goto label_2;
            label_13:
            val_4 = 0;
            goto label_3;
            label_11:
            if(val_3 == val_4)
            {
                goto label_4;
            }
            
            if(true <= val_3)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            val_5 = mem[(0 + 0) + 16];
            val_5 = (0 + 0) + 16;
            if(val_5 <= val_4)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = (0 + 0) + 20;
            val_6 = val_6 + 16;
            var val_8 = val_6;
            val_7 = val_7 - ((0 + 16) + 4);
            val_8 = val_5 - val_8;
            val_7 = val_7 * val_7;
            if(val_5 < 0)
            {
                goto label_9;
            }
            
            label_4:
            val_4 = 1;
            label_3:
            if(val_4 < val_6)
            {
                goto label_11;
            }
            
            val_3 = 1;
            label_2:
            if(val_3 < val_6)
            {
                goto label_13;
            }
            
            if(true < 1)
            {
                    return (bool)val_8;
            }
            
            label_29:
            val_5 = val_1;
            val_6 = 16;
            label_28:
            val_7 = 0;
            var val_3 = val_7 + 1;
            if((0 == val_7) || (val_1 == 0))
            {
                goto label_18;
            }
            
            if(val_3 <= 0)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + 0;
            if(((0 + 0) + 20) <= val_5)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + (val_5 << 3);
            if(((0 + ((this._closed - 1)) << 3) + 20) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = 1;
            val_7 = val_1;
            if(true <= val_7)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_11 = val_11 + (val_7 << 3);
            val_5 = val_1;
            if((Ferr.PathUtil.LineSegmentIntersection(aLine1Start:  new UnityEngine.Vector2() {x = (0 + 0) + 16, y = (0 + 0) + 20}, aLine1End:  new UnityEngine.Vector2() {x = (0 + ((this._closed - 1)) << 3) + 16, y = (0 + ((this._closed - 1)) << 3) + 20}, aLine2Start:  new UnityEngine.Vector2() {x = 3.673424E-39f, y = 1.401298E-45f}, aLine2End:  new UnityEngine.Vector2() {x = (0 + ((this._closed - 1)) << 3) + 16, y = (0 + ((this._closed - 1)) << 3) + 16})) == true)
            {
                goto label_27;
            }
            
            label_18:
            val_6 = val_6 + 8;
            if(val_3 < ((0 + 0) + 20))
            {
                goto label_28;
            }
            
            val_8 = 0;
            if((0 + 1) < ((0 + 0) + 20))
            {
                goto label_29;
            }
            
            return (bool)val_8;
            label_9:
            UnityEngine.Debug.Log(message:  -1610608651);
            label_27:
            val_8 = 1;
            return (bool)val_8;
        }
        public int GetSmoothIndex(int aRawIndex)
        {
            if(true > aRawIndex)
            {
                    if(true <= aRawIndex)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + (aRawIndex << 2);
                return (int)(0 + (aRawIndex) << 2) + 16;
            }
            
            if(this._smoothPoints != 0)
            {
                    return (int)1152921510150573199;
            }
            
            return (int)1152921510150573199;
        }
        public Ferr.Path2D BoolAdd(Ferr.Path2D aOther)
        {
            float val_17;
            float val_18;
            float val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            if(this._closed != false)
            {
                    if(aOther._closed != false)
            {
                    if(this.SelfIntersecting() != true)
            {
                    if(aOther.SelfIntersecting() == false)
            {
                goto label_5;
            }
            
            }
            
            }
            
                if(this._closed == true)
            {
                    this._closed = aOther._closed;
                goto label_6;
            }
            
            }
            
            UnityEngine.Debug.LogWarning(message:  -1610605395);
            label_6:
            if(this.SelfIntersecting() != false)
            {
                    UnityEngine.Debug.LogWarning(message:  -1610603487);
            }
            
            if(aOther.SelfIntersecting() != false)
            {
                    UnityEngine.Debug.LogWarning(message:  -1610605551);
            }
            
            536891591 = new Ferr.Path2D();
            mem[536891607] = 1;
            return;
            label_5:
            bool val_6 = Ferr.PathUtil.IsClockwise(aPoly:  this._points);
            val_21 = 0f;
            if((Ferr.PathUtil.IsClockwise(aPoly:  aOther._points)) == true)
            {
                goto label_20;
            }
            
            goto label_20;
            label_25:
            if(aOther <= val_21)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_8 = Ferr.PathUtil.IsInPoly(aPoly:  aOther._smoothPoints, aPoint:  new UnityEngine.Vector2() {x = 3.673424E-39f, y = 1.401298E-45f});
            if(val_8 == false)
            {
                goto label_23;
            }
            
            val_21 = 1;
            label_20:
            if(val_21 < val_8)
            {
                goto label_25;
            }
            
            goto label_27;
            label_23:
            if(val_21 == 1)
            {
                goto label_27;
            }
            
            if(val_8 <= val_21)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            Ferr.Path2D val_9 = 536891591;
            val_9 = new Ferr.Path2D();
            mem[536891607] = 1;
            var val_22 = mem[536891591] + 276;
            var val_21 = val_9;
            val_21 = val_21 + val_22;
            val_22 = val_21 << 1;
            label_48:
            float val_10 = 2686451937 - 2686451937;
            float val_11 = 2684356065 - 2684356065;
            val_10 = val_10 * val_10;
            if(aOther._points < 0)
            {
                    if(this.Count >= 2)
            {
                    return;
            }
            
            }
            
            if(this._points != 0)
            {
                    val_23 = val_22;
            }
            else
            {
                    val_23 = 0;
                val_22 = 0;
            }
            
            if(val_22 <= val_23)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_24 = 0;
            var val_23 = this._points + 8;
            val_23 = val_23 + 0;
            goto label_44;
            label_46:
            if((-1.355282E-19f) == 0)
            {
                    val_24 = 2686451938;
            }
            else
            {
                    if(val_21 <= (-1.355282E-19f))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_24 = 2686451938;
                System.Collections.Generic.List<UnityEngine.Vector2> val_13 = aOther._points + 16779016;
                if(val_21 <= val_21)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_25 = mem[aOther._points + 8];
                val_25 = aOther._points + 8;
            }
            
                var val_14 = val_25 + 0;
                if((Ferr.PathUtil.LineSegmentIntersection(aLine1Start:  new UnityEngine.Vector2() {x = -1.084397E-19f, y = -1.355282E-19f}, aLine1End:  new UnityEngine.Vector2() {x = (this._points + 8 + 0) + 16, y = (this._points + 8 + 0) + 20}, aLine2Start:  new UnityEngine.Vector2() {x = 0f, y = 0f}, aLine2End:  new UnityEngine.Vector2() {x = (aOther._points + 8 + 0) + 16, y = val_21})) != false)
            {
                    UnityEngine.Vector2 val_16 = Ferr.PathUtil.LineIntersectionPoint(aLine1Pt1:  new UnityEngine.Vector2() {x = 3944638f, y = -1.084397E-19f}, aLine1Pt2:  new UnityEngine.Vector2() {x = -1.355282E-19f, y = (this._points + 8 + 0) + 16}, aLine2Pt1:  new UnityEngine.Vector2() {x = (this._points + 8 + 0) + 20, y = 0f}, aLine2Pt2:  new UnityEngine.Vector2() {x = 0f, y = (aOther._points + 8 + 0) + 16});
                float val_24 = val_17;
                float val_25 = val_18;
                val_24 = 2684356065 - val_24;
                val_25 = 2686451937 - val_25;
                float val_19 = val_24.sqrMagnitude;
            }
            
            }
            
            label_44:
            if(val_24 < (aOther._points + 12))
            {
                goto label_46;
            }
            
            var val_26 = val_22;
            val_26 = val_26 - 1;
            if(val_9 != 0)
            {
                    this._points = aOther._points;
                aOther._points = this._points;
            }
            
            if(val_9 == 0)
            {
                    val_21 = 0;
            }
            
            if(val_26 >= 1)
            {
                goto label_48;
            }
            
            return;
            label_27:
            536891591 = new Ferr.Path2D(aCopyPath:  aOther);
        }
        public virtual void SetDirty()
        {
            if(this._smoothPoints != 0)
            {
                    this._smoothPoints.Clear();
            }
            
            if(this._mapToSmooth != 0)
            {
                    this._mapToSmooth.Clear();
            }
            
            if(this._distanceMask != 0)
            {
                    this._distanceMask.Clear();
            }
            
            this._controlsDirty = true;
        }
        protected virtual void EnsureControlsClean()
        {
            if(this._controlsDirty == false)
            {
                    return;
            }
            
            this.UpdateControls();
        }
        protected virtual void EnsureSmoothClean()
        {
            float val_6;
            Ferr.Path2D val_20;
            var val_21;
            System.Collections.Generic.List<Ferr.PointControl> val_22;
            System.Collections.Generic.List<UnityEngine.Vector2> val_23;
            var val_25;
            int val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            val_20 = this;
            val_21 = val_20;
            if(this._smoothPoints != 0)
            {
                    if(R1 >= 1)
            {
                    return;
            }
            
            }
            else
            {
                    536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>();
                this._smoothPoints = 536878507;
            }
            
            0.Clear();
            if(this._mapToSmooth == 0)
            {
                    536877987 = new System.Collections.Generic.List<System.Int32>();
                mem2[0] = 536877987;
            }
            
            0.Clear();
            val_22 = this._pointControls;
            if(val_20 < 1)
            {
                goto label_8;
            }
            
            label_71:
            val_23 = this._closed - 1;
            this._mapToSmooth.Add(item:  mem[536878519]);
            if(this._mapToSmooth <= 0)
            {
                    var val_21 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_21 = val_21 + 0;
            if(((0 + 0) + 16) <= val_23)
            {
                    var val_22 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_22 = val_22 + (val_23 << 3);
            if(((0 + ((this._closed - 1)) << 3) + 16) <= 0)
            {
                    var val_23 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_23 = val_23 + 0;
            if(((0 + 0) + 16 + 28) == 5)
            {
                    if(((0 + 0) + 16 + 28) <= 0)
            {
                    var val_24 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_24 = val_24 + 0;
                if(this._closed == true)
            {
                    this._closed = 1;
            }
            
                UnityEngine.Vector2 val_5 = Ferr.PathUtil.GetRoundedCornerEnd(aCornerId:  1249346408, aPath:  0, aControls:  this._points, aClosed:  val_22, aRadius:  (0 + 0) + 16 + 8, aGetBeginning:  true);
            }
            
            if(this._smoothPoints <= val_23)
            {
                    var val_25 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_25 = val_25 + (val_23 << 2);
            if(((0 + ((this._closed - 1)) << 2) + 16 + 28) == 5)
            {
                    if(((0 + ((this._closed - 1)) << 2) + 16 + 28) <= val_23)
            {
                    var val_26 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_26 = val_26 + (val_23 << 2);
                if(this._closed == true)
            {
                    this._closed = 1;
            }
            
                UnityEngine.Vector2 val_7 = Ferr.PathUtil.GetRoundedCornerEnd(aCornerId:  1249346408, aPath:  val_23, aControls:  this._points, aClosed:  val_22, aRadius:  (0 + ((this._closed - 1)) << 2) + 16 + 8, aGetBeginning:  true);
            }
            
            if(this._smoothPoints <= 0)
            {
                    var val_27 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_27 = val_27 + 0;
            if(((0 + 0) + 16 + 28) != 4)
            {
                goto label_29;
            }
            
            if(((0 + 0) + 16 + 28) <= val_23)
            {
                    var val_28 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_28 = val_28 + (val_23 << 2);
            if(((0 + ((this._closed - 1)) << 2) + 16 + 28) == 4)
            {
                goto label_40;
            }
            
            if(((0 + ((this._closed - 1)) << 2) + 16 + 28) <= val_23)
            {
                    var val_29 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_29 = val_29 + (val_23 << 2);
            if(((0 + ((this._closed - 1)) << 2) + 16 + 28) == 5)
            {
                goto label_40;
            }
            
            label_29:
            if(this._closed == true)
            {
                goto label_42;
            }
            
            if(this._closed <= 0)
            {
                    var val_30 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_30 = val_30 + 0;
            var val_31 = (0 + 0) + 16 + 28;
            if(val_31 != 5)
            {
                goto label_42;
            }
            
            if(0 == 0)
            {
                goto label_40;
            }
            
            val_31 = val_31 - 1;
            if(0 != val_31)
            {
                goto label_42;
            }
            
            label_40:
            if(val_31 <= 0)
            {
                    var val_32 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_32 = val_32 + 0;
            this._smoothPoints.Add(item:  new UnityEngine.Vector2() {x = (0 + 0) + 16, y = (0 + 0) + 20});
            goto label_68;
            label_42:
            if(this._closed <= 0)
            {
                    var val_33 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_33 = val_33 + 0;
            if(((0 + 0) + 16 + 28) != 5)
            {
                goto label_49;
            }
            
            if((this._pointControls + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_34 = this._pointControls + 8;
            val_6 = this._smoothPoints + 12;
            val_34 = val_34 + 0;
            if(this._closed == true)
            {
                    this._closed = 1;
            }
            
            float val_35 = mem[1152921510151172772];
            val_35 = val_35 * 0.75f;
            Ferr.PathUtil.AddRoundCorners(aCornerId:  0, aPath:  this._points, aControls:  val_22, aClosed:  true, aTo: ref  this._smoothPoints, aRadius:  val_35, aSegmentSize:  val_7.y);
            if(this._mapToSmooth != 0)
            {
                    val_25 = mem[this._mapToSmooth + 12];
                val_25 = this._mapToSmooth + 12;
                val_26 = val_25;
            }
            else
            {
                    val_26 = 0;
                val_25 = 0;
            }
            
            var val_36 = val_6;
            val_26 = val_26 - 1;
            if(val_25 <= val_26)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_37 = this._mapToSmooth + 8;
            val_36 = mem[536878519] - val_36;
            val_37 = val_37 + (val_26 << 2);
            this._mapToSmooth.set_Item(index:  val_26, value:  ((this._mapToSmooth + 8 + ((val_26 - 1)) << 2) + 16) + ((val_36 + (val_36 >> 31)) >> 1));
            if((this._pointControls + 12) <= val_23)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_38 = this._pointControls + 8;
            val_38 = val_38 + (val_23 << 2);
            if(((this._pointControls + 8 + ((this._closed - 1)) << 2) + 16 + 28) == 5)
            {
                goto label_68;
            }
            
            if((this._pointControls + 12) <= val_23)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_39 = this._pointControls + 8;
            val_39 = val_39 + (val_23 << 2);
            if(((this._pointControls + 8 + ((this._closed - 1)) << 2) + 16 + 28) == 4)
            {
                goto label_68;
            }
            
            label_49:
            if((this._pointControls + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_40 = this._pointControls + 8;
            val_40 = val_40 + 0;
            float val_11 = this._smoothPoints + ((this._pointControls + 8 + 0) + 16 + 16);
            float val_12 = val_6 + ((this._pointControls + 8 + 0) + 16 + 12);
            if((this._pointControls + 12) <= val_23)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_41 = this._pointControls + 8;
            val_41 = val_41 + (val_23 << 2);
            float val_13 = this._smoothPoints + ((this._pointControls + 8 + ((this._closed - 1)) << 2) + 16 + 24);
            float val_14 = val_6 + ((this._pointControls + 8 + ((this._closed - 1)) << 2) + 16 + 20);
            val_6 = val_12;
            float val_15 = Ferr.PathUtil.BezierLength(p1:  new UnityEngine.Vector2() {x = val_6, y = this._smoothPoints}, c1:  new UnityEngine.Vector2() {x = val_12, y = val_11}, c2:  new UnityEngine.Vector2() {x = val_14, y = val_13}, p2:  new UnityEngine.Vector2() {x = val_6, y = this._smoothPoints});
            var val_42 = val_6;
            val_42 = val_42 / mem[1152921510151172772];
            int val_16 = UnityEngine.Mathf.Max(a:  1, b:  (int)val_42);
            if(val_16 >= 1)
            {
                    var val_44 = 0;
                do
            {
                val_23 = val_11;
                float val_43 = 0f;
                val_43 = val_43 / (float)val_16;
                UnityEngine.Vector2 val_17 = Ferr.PathUtil.BezierPoint(p1:  new UnityEngine.Vector2() {x = 4055258f, y = val_13}, c1:  new UnityEngine.Vector2() {x = this._smoothPoints, y = val_6}, c2:  new UnityEngine.Vector2() {x = val_11, y = val_14}, p2:  new UnityEngine.Vector2() {x = val_13, y = val_6}, aPercent:  val_43);
                this._smoothPoints.Add(item:  new UnityEngine.Vector2() {x = val_6, y = this._smoothPoints});
                val_44 = val_44 + 1;
            }
            while(val_16 != val_44);
            
            }
            
            label_68:
            val_27 = 0 + 1;
            val_20 = val_20;
            val_21 = this._smoothPoints;
            val_22 = val_22;
            if(val_27 != val_20)
            {
                goto label_71;
            }
            
            label_8:
            if(((this._pointControls + 12) < 1) || ((this._pointControls + 8 + 16 + 28) != 5))
            {
                goto label_75;
            }
            
            if((this._mapToSmooth + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_22 = mem[this._mapToSmooth + 8 + 16];
            val_22 = this._mapToSmooth + 8 + 16;
            if(val_21 != 0)
            {
                    System.Collections.Generic.List<T> val_18 = val_21.GetRange(index:  0, count:  val_22);
                val_28 = val_21;
            }
            else
            {
                    System.Collections.Generic.List<T> val_19 = 0.GetRange(index:  0, count:  val_22);
                val_28 = 0;
            }
            
            val_21.AddRange(collection:  0);
            val_29 = 0;
            val_21.RemoveRange(index:  0, count:  val_22);
            val_27 = 22737168;
            goto label_81;
            label_85:
            if((this._mapToSmooth + 12) <= val_29)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_45 = this._mapToSmooth + 8;
            val_45 = val_45 + 0;
            this._mapToSmooth.set_Item(index:  0, value:  ((this._mapToSmooth + 8 + 0) + 16) - val_22);
            val_29 = 1;
            label_81:
            if(val_29 < (this._mapToSmooth + 12))
            {
                goto label_85;
            }
            
            label_75:
            if(this._closed != true)
            {
                    return;
            }
            
            if(this._closed < true)
            {
                    return;
            }
            
            this._mapToSmooth.Add(item:  this._smoothPoints + 12);
            if(this._points != 0)
            {
                    val_31 = this._mapToSmooth;
            }
            else
            {
                    val_21 = 12;
                val_31 = 0;
                val_30 = 0;
            }
            
            if(val_30 <= (-1))
            {
                    var val_46 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_46 = val_46 + 4294967288;
            val_22 = mem[(0 + 4294967288) + 16];
            val_22 = (0 + 4294967288) + 16;
            this._smoothPoints.Add(item:  new UnityEngine.Vector2() {x = val_22, y = (0 + 4294967288) + 20});
        }
        protected virtual void EnsureMaskClean()
        {
            if((this._distanceMask != 0) && (this._distanceMask > 0))
            {
                    return;
            }
            
            Ferr.PathDistanceMask val_1 = 536891611;
            val_1 = new Ferr.PathDistanceMask(aPath:  this._smoothPoints, aMapping:  this._mapToSmooth, aClosed:  this._closed);
            this._distanceMask = val_1;
        }
        protected void UpdateControls()
        {
            var val_22 = 4;
            label_12:
            System.Collections.Generic.List<UnityEngine.Vector2> val_1 = val_22 - 4;
            if(val_1 >= true)
            {
                goto label_2;
            }
            
            if(true <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_17 = -1810889493;
            val_17 = val_17 - 1;
            if(val_17 <= 4)
            {
                    var val_2 = 18066176 + (18066176 + ((-1810889493 - 1)) << 2);
                if(val_17 == 4)
            {
                    18066176 + ((-1810889493 - 1)) << 2 = (18066176 + ((-1810889493 - 1)) << 2) & ((18066176 + ((-1810889493 - 1)) << 2) >> (18066176 + ((-1810889493 - 1)) << 2));
                18066176 + ((-1810889493 - 1)) << 2 = (18066176 + ((-1810889493 - 1)) << 2) & (((IP) << (32-as. 
                
            
            
            
            
            
               
            )) | ((IP) << as. 
                
            
            
            
            
            
               
            ));
                18066176 + ((-1810889493 - 1)) << 2 = (18066176 + ((-1810889493 - 1)) << 2) & 703821376;
                18066176 + ((-1810889493 - 1)) << 2 = (18066176 + ((-1810889493 - 1)) << 2) & (this << (18066176 + ((-1810889493 - 1)) << 2));
                18066176 + ((-1810889493 - 1)) << 2 = (18066176 + ((-1810889493 - 1)) << 2) & (this << (18066176 + ((-1810889493 - 1)) << 2));
            }
            
                UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
            }
            
            val_22 = val_22 + 1;
            goto label_12;
            label_2:
            this._controlsDirty = false;
        }
        public Ferr.ISVGElement Reverse()
        {
            var val_3;
            var val_4;
            var val_5;
            float val_6;
            var val_7;
            bool val_8;
            val_3 = this;
            Ferr.Path2D val_1 = 536891591;
            val_4 = val_1;
            val_1 = new Ferr.Path2D();
            if(1152921510151680783 < 0)
            {
                goto label_2;
            }
            
            var val_2 = 8 + 1408997504;
            do
            {
                if(val_3 <= 1152921510151680783)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                Ferr.PointControl val_3 = 536891893;
                val_3 = new Ferr.PointControl(aCopy:  mem[704498772]);
                if(val_3 != 0)
            {
                    val_5 = val_3;
                val_6 = mem[536891913];
                val_7 = mem[536891917];
            }
            else
            {
                    val_5 = 20;
                val_7 = 0;
                val_6 = 1.401298E-45f;
            }
            
                mem[536891905] = val_6;
                val_3 = val_3;
                mem[536891909] = val_7;
                if(24 <= 1152921510151680783)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                mem[20] = mem[704498764] + 12;
                mem[536891917] = mem[704498764] + 16;
                if((mem[704498764] + 12) <= 1152921510151680783)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                mem[536891599].Add(item:  new UnityEngine.Vector2() {x = 0 + (8 + 1408997504), y = 0 + (8 + 1408997504) + 4});
                val_4 = val_4;
                mem[536891603].Add(item:  536891893);
                val_2 = val_2 - 8;
            }
            while(1152921510151680782 > 1);
            
            val_8 = this._closed;
            goto label_16;
            label_2:
            val_8 = this._closed;
            if(val_4 == 0)
            {
                goto label_17;
            }
            
            label_16:
            mem[536891607] = val_8;
            label_18:
            mem[536891611] = this._splitDistance;
            return;
            label_17:
            mem[16] = val_8;
            goto label_18;
        }
        public System.Collections.Generic.List<UnityEngine.Vector2> GetPoints(int aResolution)
        {
        
        }
        public string ToSVGElement()
        {
            var val_11;
            if(R8 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_10 = 3.673424E-39f;
            val_10 = val_10 * 100f;
            float val_1 = (1.401298E-45f) * (-100f);
            string val_2 = System.String.Format(format:  -1610610531, arg0:  536893745, arg1:  536893745);
            val_11 = -1610610531;
            if((R8 - 1) >= 1)
            {
                    var val_13 = 1;
                do
            {
                int val_4 = Ferr.PathUtil.WrapIndex(aIndex:  1, aCount:  536893745, aClosed:  this._closed);
                if(val_4 <= val_4)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_11 = val_11 + (val_4 << 3);
                float val_12 = (0 + (val_4) << 3) + 16;
                val_12 = val_12 * 100f;
                float val_5 = ((0 + (val_4) << 3) + 20) * (-100f);
                string val_6 = System.String.Format(format:  -1610606557, arg0:  536893745, arg1:  536893745);
                string val_7 = -1610610531(-1610610531) + -1610606557(-1610606557);
                val_13 = val_13 + 1;
                val_11 = val_11;
            }
            while(R8 != val_13);
            
            }
            
            if(this._closed != false)
            {
                    string val_8 = -1610610531(-1610610531) + -1610597163(-1610597163);
                val_11 = val_11;
            }
            
            string val_9 = -1610610531(-1610610531) + -1610612089(-1610612089);
        }
        public void GizmoDraw(float aNormSize = 0.4, float aTanSize = 0.4, bool aShowIndex = False)
        {
            float val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_6 = this;
            val_7 = R3;
            val_8 = R2;
            Ferr.PathUtil.GizmoDraw(aPath:  this._smoothPoints, aVertSize:  aNormSize, aClosed:  true, aDrawLine:  this._closed, aArrowSize:  aTanSize);
            Ferr.PathUtil.GizmoDraw(aPath:  this._points, aVertSize:  aNormSize, aClosed:  true, aDrawLine:  this._closed, aArrowSize:  aTanSize);
            if(val_7 != 0)
            {
                    var val_6 = 0;
                do
            {
                val_6 = val_6 + 1;
            }
            while(val_6 < this._points);
            
            }
            
            if(val_6 == this._points)
            {
                goto label_4;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector2> val_1 = Ferr.PathUtil.GetNormals(aPath:  this._smoothPoints, aClosed:  this._closed);
            val_9 = this._smoothPoints;
            val_8 = 16;
            val_10 = 0;
            goto label_5;
            label_10:
            if(this._smoothPoints <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = 2621443;
            if(16 <= val_10)
            {
                    float val_7 = 0f;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + val_8;
            float val_8 = val_7;
            val_8 = val_8 * aShowIndex;
            UnityEngine.Gizmos.DrawRay(from:  new UnityEngine.Vector3() {x = 3.673424E-39f, y = 1.401298E-45f, z = 0f}, direction:  new UnityEngine.Vector3() {x = val_8, y = ((0 + val_8) + 4) * aShowIndex, z = 0f});
            val_8 = 24;
            val_10 = 1;
            label_5:
            if(val_10 < val_7)
            {
                goto label_10;
            }
            
            label_4:
            if(val_10 == val_7)
            {
                    return;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector2> val_3 = this.GetFinalTangentsCopy();
            val_9 = val_6;
            val_6 = 0f;
            val_11 = 0;
            goto label_12;
            label_17:
            if(val_6 <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = 2621443;
            val_7 = 1;
            if(this._pointControls <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.Collections.Generic.List<UnityEngine.Vector2> val_9 = this._points;
            val_9 = val_9 + 16;
            UnityEngine.Gizmos.DrawRay(from:  new UnityEngine.Vector3() {x = 3.673424E-39f, y = 1.401298E-45f, z = 0f}, direction:  new UnityEngine.Vector3() {x = 1152921504682139648 * val_8, y = ((0 + val_8) + 4) * val_8, z = val_6});
            val_11 = 1;
            label_12:
            if(val_11 < val_8)
            {
                goto label_17;
            }
        
        }
        public void DistanceGizmoDraw(float aNormSize = 0.4, float aTanSize = 0.4)
        {
            float val_6;
            float val_7;
            var val_14;
            var val_15;
            float val_16;
            float val_17;
            val_14 = R2;
            val_15 = R1;
            if(true < 1)
            {
                    return;
            }
            
            float val_1 = this.TotalLength;
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            val_16 = 1250404624;
            if(((int)val_16 / this._splitDistance) >= 0)
            {
                    var val_15 = 16;
                var val_14 = 0;
                do
            {
                float val_13 = 0f;
                val_13 = (val_16 / ((float)(int)val_16 / this._splitDistance)) * val_13;
                val_14 = val_13;
                UnityEngine.Vector2 val_5 = GetPointAtDistance(aDist:  val_13);
                val_17 = val_6;
                if(536878507 == 0)
            {
                    val_17 = val_17;
            }
            
                536878507.Add(item:  new UnityEngine.Vector2() {x = val_17, y = val_7});
                UnityEngine.Vector2 val_8 = GetNormalAtDistance(aDist:  val_5.x);
                UnityEngine.Vector2 val_9 = GetTangentAtDistance(aDist:  val_8.x);
                if(mem[536878519] <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Gizmos.DrawRay(from:  new UnityEngine.Vector3() {x = mem[536878515] + 16, y = mem[536878515] + 16 + 4, z = 0f}, direction:  new UnityEngine.Vector3() {x = val_6 * val_15, y = val_7 * val_15, z = 0f});
                if(mem[536878519] <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_16 = val_7 * val_14;
                UnityEngine.Gizmos.DrawRay(from:  new UnityEngine.Vector3() {x = mem[536878515] + 16, y = mem[536878515] + 16 + 4, z = 0f}, direction:  new UnityEngine.Vector3() {x = val_6 * val_14, y = val_16, z = 0f});
                val_14 = val_14 + 1;
                val_15 = val_15 + 8;
            }
            while(val_14 <= ((int)val_16 / this._splitDistance));
            
            }
            
            val_15 = 15820;
            val_15 = 1036831949;
            Ferr.PathUtil.GizmoDraw(aPath:  536878507, aVertSize:  val_16, aClosed:  true, aDrawLine:  this._closed, aArrowSize:  val_9.y);
            Ferr.PathUtil.GizmoDraw(aPath:  this._points, aVertSize:  val_16, aClosed:  true, aDrawLine:  this._closed, aArrowSize:  val_9.y);
        }
        public override string ToString()
        {
            int val_1 = this.Count;
            float val_2 = this.TotalLength;
            if(this._closed == false)
            {
                    22778404 = 22776880;
            }
            
            string val_3 = System.String.Format(format:  -1610612171, arg0:  536888987, arg1:  536893745, arg2:  -1610612735);
        }
        public static Ferr.Path2D CreateRect(UnityEngine.Rect aRect)
        {
            536891591 = new Ferr.Path2D();
            mem[536891607] = 1;
            float val_2 = aRect.m_XMin.xMin;
            float val_3 = aRect.m_XMin.yMin;
            float val_4 = aRect.m_XMin.xMax;
            float val_5 = aRect.m_XMin.yMin;
            float val_6 = aRect.m_XMin.xMax;
            float val_7 = aRect.m_XMin.yMax;
            float val_8 = aRect.m_XMin.xMin;
            float val_9 = aRect.m_XMin.yMax;
        }
        public static Ferr.Path2D CreateStrip(System.Collections.Generic.List<UnityEngine.Vector2> aPoints, float aWidth)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_10;
            Ferr.Path2D val_1 = 536891591;
            val_1 = new Ferr.Path2D();
            mem[536891607] = 1;
            val_6 = 0;
            val_8 = 0;
            goto label_3;
            label_6:
            if(val_8 >= R1)
            {
                goto label_4;
            }
            
            label_7:
            if(1 <= val_8)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + 16;
            UnityEngine.Vector2 val_2 = Ferr.PathUtil.GetPointNormal(i:  1250740864, aPath:  0, aClosed:  aPoints);
            val_8 = 1;
            label_3:
            if(aPoints == 0)
            {
                goto label_6;
            }
            
            if(val_8 < val_1)
            {
                goto label_7;
            }
            
            label_4:
            val_10 = 536891590;
            if(val_10 < 0)
            {
                    return;
            }
            
            var val_5 = 8 + 165432;
            val_7 = 0;
            val_6 = 1065353216;
            do
            {
                if(val_1 <= val_10)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_8 = val_8 + val_5;
                UnityEngine.Vector2 val_6 = Ferr.PathUtil.GetPointNormal(i:  1250740864, aPath:  536891590, aClosed:  aPoints);
                val_10 = val_10 - 1;
                val_5 = val_5 - 8;
            }
            while(val_10 > 1);
        
        }
    
    }

}
