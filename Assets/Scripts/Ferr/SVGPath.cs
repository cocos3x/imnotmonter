using UnityEngine;

namespace Ferr
{
    [Serializable]
    public class SVGPath : ISVGElement
    {
        // Fields
        private System.Collections.Generic.List<Ferr.SVGPath.Point> _points;
        private bool _closed;
        
        // Properties
        public UnityEngine.Rect Bounds { get; }
        public UnityEngine.Vector2 Start { get; }
        public UnityEngine.Vector2 End { get; }
        public bool Closed { get; set; }
        
        // Methods
        public UnityEngine.Rect get_Bounds()
        {
            float val_2;
            float val_3;
            float val_9;
            var val_10;
            if((R1 + 8 + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = mem[R1 + 8 + 8 + 16 + 8];
            val_9 = R1 + 8 + 8 + 16 + 8;
            val_10 = 0;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            UnityEngine.Rect val_4 = new UnityEngine.Rect(position:  new UnityEngine.Vector2() {x = val_9, y = R1 + 8 + 8 + 16 + 12}, size:  new UnityEngine.Vector2() {x = val_2, y = val_3});
            goto label_4;
            label_13:
            if((R1 + 8 + 12) <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_9 = R1 + 8 + 8;
            val_9 = val_9 + 0;
            val_9 = mem[(R1 + 8 + 8 + 0) + 16 + 12];
            val_9 = (R1 + 8 + 8 + 0) + 16 + 12;
            float val_5 = val_4.m_XMin.xMin;
            if(((R1 + 8 + 8 + 0) + 16) > 0)
            {
                    val_4.m_XMin.xMin = 1267150136;
            }
            
            float val_6 = val_4.m_XMin.xMax;
            if(((R1 + 8 + 8 + 0) + 16) < 0)
            {
                    val_4.m_XMin.xMax = 1267150136;
            }
            
            float val_7 = val_4.m_XMin.yMin;
            if(((R1 + 8 + 8 + 0) + 16) > 0)
            {
                    val_4.m_XMin.yMin = 1267150136;
            }
            
            float val_8 = val_4.m_XMin.yMax;
            if(((R1 + 8 + 8 + 0) + 16) < 0)
            {
                    val_4.m_XMin.yMax = 1267150136;
            }
            
            val_10 = 1;
            label_4:
            if(val_10 < (R1 + 8 + 12))
            {
                goto label_13;
            }
            
            return new UnityEngine.Rect() {m_XMin = 1267150136, m_YMin = val_1.y};
        }
        public UnityEngine.Vector2 get_Start()
        {
            if((R1 + 8 + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((R1 + 8 + 8 + 16) != 0)
            {
                    return new UnityEngine.Vector2();
            }
            
            return new UnityEngine.Vector2();
        }
        public UnityEngine.Vector2 get_End()
        {
            var val_1;
            var val_2;
            var val_3;
            if((R1 + 12) != 0)
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
            
                val_1 = (R1 + 8 + 8) + 4294967292;
            }
            
            if(((R1 + 8 + 8 + 4294967292) + 16) != 0)
            {
                    return new UnityEngine.Vector2();
            }
            
            return new UnityEngine.Vector2();
        }
        public bool get_Closed()
        {
            return (bool)this._closed;
        }
        public void set_Closed(bool value)
        {
            this._closed = value;
        }
        public SVGPath(bool aClosed = False)
        {
            536878657 = new System.Collections.Generic.List<Page>();
            this._points = 536878657;
            this._closed = aClosed;
        }
        public void Add(UnityEngine.Vector2 aPt, Ferr.SVGPath.PointType aType = 2, UnityEngine.Vector2 aControlPointPrev, UnityEngine.Vector2 aControlPointNext)
        {
            SVGPath.Point val_1 = 536900847;
            val_1 = new SVGPath.Point();
            if(val_1 != 0)
            {
                    mem[536900879] = aType;
                mem[536900867] = aControlPointNext.y;
            }
            else
            {
                    mem[8] = aPt.x;
                mem[12] = aPt.y;
                mem[32] = aType;
                mem[16] = aControlPointNext.x;
                mem[20] = aControlPointNext.y;
            }
            
            mem[536900871] = aControlPointPrev.x;
            mem[536900875] = aControlPointPrev.y;
            mem[1152921510169652568].Add(item:  536900847);
        }
        public void AddRange(System.Collections.Generic.List<UnityEngine.Vector2> aPoints)
        {
            var val_1;
            var val_2;
            val_1 = 16;
            val_2 = 0;
            goto label_1;
            label_4:
            if(true <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.Add(aPt:  new UnityEngine.Vector2() {x = 3.673424E-39f, y = 1.401298E-45f}, aType:  2, aControlPointPrev:  new UnityEngine.Vector2() {x = 0f, y = 0f}, aControlPointNext:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_1 = 24;
            val_2 = 1;
            label_1:
            if(val_2 < this)
            {
                goto label_4;
            }
        
        }
        public void Clear()
        {
            this._points.Clear();
        }
        public System.Collections.Generic.List<UnityEngine.Vector2> GetPoints(int aStepsPerUnit)
        {
            float val_6;
            float val_7;
            Ferr.SVGPath val_12;
            var val_13;
            bool val_14;
            System.Collections.Generic.List<Point> val_15;
            float val_16;
            var val_17;
            val_12 = this;
            val_13 = aStepsPerUnit;
            System.Collections.Generic.List<UnityEngine.Vector2> val_1 = 536878507;
            val_1 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            if(val_1 < 2)
            {
                    return;
            }
            
            val_14 = this._closed;
            val_15 = this._points;
            if(this._points == 0)
            {
                    val_15 = this._points;
            }
            
            bool val_2 = val_14 - 1;
            if(val_1 >= 1)
            {
                    do
            {
                if(val_1 <= 0)
            {
                    var val_13 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_13 = val_13 + 0;
                int val_3 = 0 + 1;
                int val_4 = this.WrapI(i:  val_3);
                if(val_4 <= val_4)
            {
                    var val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_14 = val_14 + (val_4 << 2);
                val_16 = mem[(0 + (val_4) << 2) + 16 + 12];
                val_16 = (0 + (val_4) << 2) + 16 + 12;
                UnityEngine.Vector2 val_5 = GetControl(aIndex:  1268211152, aNext:  false);
                val_14 = val_7;
                UnityEngine.Vector2 val_9 = GetControl(aIndex:  1268211152, aNext:  this.WrapI(i:  val_3));
                float val_10 = this.BezierLength(p1:  new UnityEngine.Vector2() {x = val_6, y = (0 + 0) + 16 + 12}, c1:  new UnityEngine.Vector2() {x = val_6, y = val_14}, c2:  new UnityEngine.Vector2() {x = val_6, y = val_7}, p2:  new UnityEngine.Vector2() {x = (0 + (val_4) << 2) + 16 + 8, y = val_16});
                uint val_15 = 1268211152;
                val_15 = val_15 * (float)val_13;
                val_17 = val_1;
                if((int)val_15 >= 1)
            {
                    var val_17 = 0;
                do
            {
                float val_16 = 0f;
                val_16 = val_16 / (float)(int)val_15;
                UnityEngine.Vector2 val_11 = val_14.BezierPoint(p1:  new UnityEngine.Vector2() {x = val_6, y = val_6}, c1:  new UnityEngine.Vector2() {x = (0 + 0) + 16 + 12, y = val_6}, c2:  new UnityEngine.Vector2() {x = val_14, y = val_6}, p2:  new UnityEngine.Vector2() {x = val_7, y = (0 + (val_4) << 2) + 16 + 8}, aPercent:  val_16);
                val_14 = val_14;
                val_16 = (0 + (val_4) << 2) + 16 + 8;
                if(val_17 == 0)
            {
                    val_17 = val_1;
            }
            
                val_17.Add(item:  new UnityEngine.Vector2() {x = val_14, y = val_16});
                val_17 = val_17 + 1;
            }
            while((int)val_15 != val_17);
            
            }
            
                val_12 = val_12;
                val_13 = val_3;
                val_15 = this._points;
            }
            while(val_13 != val_1);
            
            }
            
            int val_12 = this.WrapI(i:  val_1);
            if(val_12 <= val_12)
            {
                    var val_18 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_18 = val_18 + (val_12 << 2);
            val_1.Add(item:  new UnityEngine.Vector2() {x = (0 + (val_12) << 2) + 16 + 8, y = (0 + (val_12) << 2) + 16 + 12});
        }
        public Ferr.ISVGElement Reverse()
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            Ferr.SVGPath val_1 = 536893229;
            val_3 = val_1;
            val_1 = new Ferr.SVGPath(aClosed:  this._closed);
            536878657 = new System.Collections.Generic.List<Point>(collection:  this._points);
            if(val_3 != 0)
            {
                    val_4 = val_3;
                mem[536893237] = 536878657;
            }
            else
            {
                    val_4 = 8;
                mem[8] = 536878657;
            }
            
            val_4.Reverse();
            val_6 = 4;
            goto label_4;
            label_23:
            if(mem[536878669] <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(mem[536878669] <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(mem[536878669] <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = mem[mem[536878665] + 16 + 24];
            val_5 = mem[536878665] + 16 + 24;
            val_3 = val_3;
            mem2[0] = val_5;
            mem2[0] = mem[536878665] + 16 + 28;
            val_4 = val_4;
            if(mem[536878669] <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = 5;
            mem2[0] = mem[536878665] + 16 + 16;
            mem2[0] = mem[536878665] + 16 + 20;
            label_4:
            if((val_6 - 4) < mem[536878669])
            {
                goto label_23;
            }
        
        }
        public System.Collections.Generic.List<Ferr.ISVGElement> RenderDashed(float aStepResolution, UnityEngine.AnimationCurve aDashStrength, UnityEngine.Vector2 aGapSize, UnityEngine.Vector2 aDashSize)
        {
            float val_7;
            float val_8;
            Ferr.SVGPath val_26;
            System.Collections.Generic.List<Page> val_27;
            float val_28;
            float val_29;
            bool val_30;
            float val_31;
            val_26 = this;
            val_27 = 536877957;
            val_27 = new System.Collections.Generic.List<Page>();
            536893227 = new Ferr.SVGLine(aClosed:  false);
            if(536893227 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_28 = static_value_0028000B;
            val_29 = static_value_0028000F;
            val_30 = this._closed;
            bool val_3 = val_30 - 1;
            if(0 < 1)
            {
                goto label_5;
            }
            
            float val_31 = 0f;
            label_27:
            if(val_26 <= 0)
            {
                    var val_27 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_27 = val_27 + 0;
            int val_4 = 0 + 1;
            int val_5 = this.WrapI(i:  val_4);
            if(val_5 <= val_5)
            {
                    var val_28 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_28 = val_28 + (val_5 << 2);
            val_26 = mem[(0 + (val_5) << 2) + 16 + 8];
            val_26 = (0 + (val_5) << 2) + 16 + 8;
            UnityEngine.Vector2 val_6 = GetControl(aIndex:  1268472016, aNext:  false);
            UnityEngine.Vector2 val_10 = GetControl(aIndex:  1268472016, aNext:  this.WrapI(i:  val_4));
            float val_11 = this.BezierLength(p1:  new UnityEngine.Vector2() {x = (0 + 0) + 16 + 8, y = (0 + 0) + 16 + 12}, c1:  new UnityEngine.Vector2() {x = val_7, y = val_8}, c2:  new UnityEngine.Vector2() {x = val_7, y = val_8}, p2:  new UnityEngine.Vector2() {x = val_26, y = (0 + (val_5) << 2) + 16 + 12});
            val_30 = val_26;
            float val_12 = aGapSize.x.Evaluate(time:  0f);
            val_31 = aGapSize.x;
            if(val_31 == 0f)
            {
                    val_31 = aGapSize.x;
            }
            
            float val_29 = (float)this.WrapI(i:  val_4);
            val_29 = val_29 / (-1f);
            float val_14 = val_31.Evaluate(time:  val_29);
            if(((int)1268472016 / aDashStrength) < 1)
            {
                goto label_14;
            }
            
            var val_35 = 0;
            label_26:
            val_26 = val_28;
            float val_16 = 0f / ((float)(int)1268472016 / aDashStrength);
            val_30 = aGapSize.x;
            UnityEngine.Vector2 val_18 = BezierPoint(p1:  new UnityEngine.Vector2() {x = val_31, y = (0 + 0) + 16 + 8}, c1:  new UnityEngine.Vector2() {x = (0 + 0) + 16 + 12, y = val_7}, c2:  new UnityEngine.Vector2() {x = val_8, y = val_7}, p2:  new UnityEngine.Vector2() {x = val_8, y = val_26}, aPercent:  UnityEngine.Mathf.Lerp(a:  0f, b:  val_10.y, t:  0f));
            val_28 = val_7;
            float val_30 = val_29;
            val_29 = val_8;
            val_30 = val_29 - val_30;
            float val_19 = val_28 - val_26;
            float val_20 = val_19.magnitude;
            val_31 = val_31 + 1268459912;
            float val_32 = val_30;
            if((((int)1268472016 / aDashStrength) >= 0) || (((int)1268472016 / aDashStrength) < 1))
            {
                goto label_16;
            }
            
            val_32 = 1f - val_32;
            if((1 & 1) != 0)
            {
                goto label_17;
            }
            
            float val_21 = UnityEngine.Mathf.Lerp(a:  val_32, b:  val_18.y, t:  val_19);
            float val_33 = aGapSize.y;
            val_33 = val_31 + val_33;
            val_2.Add(aPt:  new UnityEngine.Vector2() {x = val_28, y = val_29});
            goto label_21;
            label_16:
            if(1 != 1)
            {
                goto label_20;
            }
            
            goto label_21;
            label_17:
            float val_23 = UnityEngine.Mathf.Lerp(a:  val_32, b:  val_18.y, t:  val_19);
            val_30 = aDashSize.y;
            var val_34 = val_30;
            if(val_2.Count >= 2)
            {
                    val_27.Add(item:  536893227);
            }
            
            val_34 = val_31 + val_34;
            536893227 = new Ferr.SVGLine(aClosed:  false);
            label_20:
            val_25.Add(aPt:  new UnityEngine.Vector2() {x = val_28, y = val_29});
            label_21:
            val_35 = val_35 + 1;
            if(val_19 != val_35)
            {
                goto label_26;
            }
            
            label_14:
            val_27 = val_4;
            if(val_27 != 0)
            {
                goto label_27;
            }
            
            label_5:
            if(val_25.Count < 2)
            {
                    return;
            }
            
            val_27.Add(item:  536893227);
        }
        private UnityEngine.Vector2 GetControl(int aIndex, bool aNext)
        {
            float val_5;
            float val_6;
            var val_16;
            int val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_25;
            val_16 = R3;
            val_17 = aNext;
            if((aIndex + 8 + 12) <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_16 = aIndex + 8 + 8;
            val_16 = val_16 + (val_17 << 2);
            if(((aIndex + 8 + 8 + (aNext) << 2) + 16) == 0)
            {
                goto label_3;
            }
            
            val_18 = mem[(aIndex + 8 + 8 + (aNext) << 2) + 16 + 32];
            val_18 = (aIndex + 8 + 8 + (aNext) << 2) + 16 + 32;
            if(val_18 == 0)
            {
                goto label_4;
            }
            
            if(val_18 != 1)
            {
                goto label_5;
            }
            
            val_19 = mem[(aIndex + 8 + 8 + (aNext) << 2) + 16 + 8];
            val_19 = (aIndex + 8 + 8 + (aNext) << 2) + 16 + 8;
            val_20 = mem[(aIndex + 8 + 8 + (aNext) << 2) + 16 + 12];
            val_20 = (aIndex + 8 + 8 + (aNext) << 2) + 16 + 12;
            goto label_6;
            label_3:
            val_21 = 32;
            if(22965384 == 0)
            {
                goto label_7;
            }
            
            if(22965384 != 1)
            {
                goto label_8;
            }
            
            val_19 = mem[(aIndex + 8 + 8 + (aNext) << 2) + 16 + 8];
            val_19 = (aIndex + 8 + 8 + (aNext) << 2) + 16 + 8;
            val_20 = mem[(aIndex + 8 + 8 + (aNext) << 2) + 16 + 12];
            val_20 = (aIndex + 8 + 8 + (aNext) << 2) + 16 + 12;
            label_6:
            if(val_16 != 0)
            {
                    val_22 = ((aIndex + 8 + 8 + (aNext) << 2) + 16 + 24) ^ 2147483648;
                val_23 = ((aIndex + 8 + 8 + (aNext) << 2) + 16 + 28) ^ 2147483648;
            }
            
            goto label_21;
            label_4:
            val_19 = mem[(aIndex + 8 + 8 + (aNext) << 2) + 16 + 8];
            val_19 = (aIndex + 8 + 8 + (aNext) << 2) + 16 + 8;
            val_20 = mem[(aIndex + 8 + 8 + (aNext) << 2) + 16 + 12];
            val_20 = (aIndex + 8 + 8 + (aNext) << 2) + 16 + 12;
            goto label_10;
            label_7:
            val_19 = mem[(aIndex + 8 + 8 + (aNext) << 2) + 16 + 8];
            val_19 = (aIndex + 8 + 8 + (aNext) << 2) + 16 + 8;
            val_20 = mem[(aIndex + 8 + 8 + (aNext) << 2) + 16 + 12];
            val_20 = (aIndex + 8 + 8 + (aNext) << 2) + 16 + 12;
            label_10:
            if(val_16 != 0)
            {
                    ((aIndex + 8 + 8 + (aNext) << 2) + 16) + 24 = ((aIndex + 8 + 8 + (aNext) << 2) + 16) + 16;
            }
            
            goto label_21;
            label_8:
            val_18 = 22965384;
            label_5:
            if(val_18 == 3)
            {
                    int val_3 = aIndex.WrapI(i:  val_17 + 1);
                if((aIndex + 8 + 12) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_17 = aIndex + 8 + 8;
                val_17 = val_17 + (val_3 << 2);
                float val_18 = (aIndex + 8 + 8 + (aNext) << 2) + 16 + 8;
                float val_19 = (aIndex + 8 + 8 + (aNext) << 2) + 16 + 12;
                val_18 = ((aIndex + 8 + 8 + (val_3) << 2) + 16 + 8) - val_18;
                val_19 = ((aIndex + 8 + 8 + (val_3) << 2) + 16 + 12) - val_19;
                UnityEngine.Vector2 val_4 = normalized;
                val_21 = val_6;
                val_16 = (aIndex + 8 + 8 + (aNext) << 2) + 16;
                mem2[0] = val_5;
                mem2[0] = val_21;
                int val_8 = aIndex.WrapI(i:  val_17 - 1);
                if((aIndex + 8 + 12) <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_20 = aIndex + 8 + 8;
                val_20 = val_20 + (val_8 << 2);
                float val_21 = ((aIndex + 8 + 8 + (aNext) << 2) + 16) + 8;
                float val_22 = ((aIndex + 8 + 8 + (aNext) << 2) + 16 + 8) + 4;
                val_21 = ((aIndex + 8 + 8 + (val_8) << 2) + 16 + 8) - val_21;
                val_22 = ((aIndex + 8 + 8 + (val_8) << 2) + 16 + 12) - val_22;
                UnityEngine.Vector2 val_10 = normalized;
                mem2[0] = val_5;
                mem2[0] = val_6;
            }
            else
            {
                    UnityEngine.Vector2 val_11 = GetPointNormal(aIndex:  aIndex);
                float val_24 = val_5;
                float val_25 = val_6;
                float val_12 = aIndex.GetSegLength(aIndex:  val_17);
                float val_14 = aIndex.GetSegLength(aIndex:  val_17 - 1);
                int val_23 = aIndex;
                val_23 = aIndex + val_23;
                val_23 = val_23 * 0.125f;
                val_24 = val_24 * val_23;
                val_25 = val_25 * val_23;
                if(((aIndex + 8 + 8 + (aNext) << 2) + 16) != 0)
            {
                    val_19 = mem[(aIndex + 8 + 8 + (aNext) << 2) + 16 + 8];
                val_19 = (aIndex + 8 + 8 + (aNext) << 2) + 16 + 8;
                val_20 = mem[(aIndex + 8 + 8 + (aNext) << 2) + 16 + 12];
                val_20 = (aIndex + 8 + 8 + (aNext) << 2) + 16 + 12;
                var val_15 = ((aIndex + 8 + 8 + (aNext) << 2) + 16) + 24;
                mem2[0] = val_25;
                mem2[0] = aIndex;
                mem2[0] = -val_25;
                mem2[0] = val_24;
                val_25 = ((aIndex + 8 + 8 + (aNext) << 2) + 16) + 16;
            }
            else
            {
                    mem2[0] = val_25;
                mem2[0] = aIndex;
                mem[24] = -val_25;
                mem[28] = val_24;
                val_19 = mem[(aIndex + 8 + 8 + (aNext) << 2) + 16 + 8];
                val_19 = (aIndex + 8 + 8 + (aNext) << 2) + 16 + 8;
                val_20 = mem[(aIndex + 8 + 8 + (aNext) << 2) + 16 + 12];
                val_20 = (aIndex + 8 + 8 + (aNext) << 2) + 16 + 12;
                val_25 = ((aIndex + 8 + 8 + (aNext) << 2) + 16) + 16;
            }
            
                if(val_16 != 0)
            {
                    24 = val_25;
            }
            
            }
            
            label_21:
            Ferr.SVGPath val_26 = mem[((aIndex + 8 + 8 + (aNext) << 2) + 16 + 16) + (0)];
            float val_27 = mem[((aIndex + 8 + 8 + (aNext) << 2) + 16 + 16) + (4)];
            val_26 = val_19 + val_26;
            val_27 = val_20 + val_27;
            this = val_26;
            mem[1152921510170410580] = val_27;
            return new UnityEngine.Vector2() {x = val_26, y = val_11.y};
        }
        private int WrapI(int i)
        {
            int val_3;
            System.Collections.Generic.List<Point> val_4;
            val_3 = i;
            if(val_3 > 1)
            {
                goto label_1;
            }
            
            if(this._closed == false)
            {
                goto label_7;
            }
            
            val_4 = this._points;
            if(this._points != 0)
            {
                goto label_3;
            }
            
            val_4 = this._points;
            if(val_4 == 0)
            {
                goto label_4;
            }
            
            label_3:
            int val_4 = UnityEngine.Mathf.Abs(value:  val_3);
            val_4 = val_4 + 1;
            label_1:
            label_7:
            if((this._closed >> 5) == false)
            {
                    return 0;
            }
            
            return UnityEngine.Mathf.Clamp(value:  val_3, min:  0, max:  0 - 1);
            label_4:
        }
        private float GetSegLength(int aIndex)
        {
            int val_1 = this.WrapI(i:  aIndex);
            if(val_1 <= val_1)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + (val_1 << 2);
            int val_3 = this.WrapI(i:  aIndex + 1);
            if(val_3 <= val_3)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (val_3 << 2);
            return (float)UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = (0 + (val_1) << 2) + 16 + 8, y = (0 + (val_1) << 2) + 16 + 12}, b:  new UnityEngine.Vector2() {x = (0 + (val_3) << 2) + 16 + 8, y = (0 + (val_3) << 2) + 16 + 12});
        }
        private UnityEngine.Vector2 GetPointNormal(int aIndex)
        {
            int val_5 = R2;
            int val_1 = aIndex.WrapI(i:  val_5);
            val_5 = val_1 + 1;
            int val_2 = aIndex.WrapI(i:  val_5);
            if((aIndex + 8 + 12) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_6 = aIndex + 8 + 8;
            val_6 = val_6 + (val_2 << 2);
            if((aIndex + 8 + 12) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = aIndex + 8 + 8;
            val_7 = val_7 + (val_1 << 2);
            var val_8 = (aIndex + 8 + 8 + (val_1) << 2) + 16 + 12;
            float val_9 = (aIndex + 8 + 8 + (val_1) << 2) + 16 + 8;
            val_8 = ((aIndex + 8 + 8 + (val_2) << 2) + 16 + 12) - val_8;
            val_9 = ((aIndex + 8 + 8 + (val_2) << 2) + 16 + 8) - val_9;
            if((aIndex + 8 + 12) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_10 = aIndex + 8 + 8;
            val_10 = val_10 + (val_1 << 2);
            int val_4 = aIndex.WrapI(i:  val_1 - 1);
            if((aIndex + 8 + 12) <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_11 = aIndex + 8 + 8;
            val_11 = val_11 + (val_4 << 2);
            var val_12 = (aIndex + 8 + 8 + (val_4) << 2) + 16 + 12;
            float val_13 = (aIndex + 8 + 8 + (val_4) << 2) + 16 + 8;
            val_12 = ((aIndex + 8 + 8 + (val_1) << 2) + 16 + 12) - val_12;
            val_13 = ((aIndex + 8 + 8 + (val_1) << 2) + 16 + 8) - val_13;
            -val_8.Normalize();
            -val_12.Normalize();
            float val_14 = -val_12;
            float val_15 = val_13;
            val_14 = (-val_8) + val_14;
            val_15 = val_9 + val_15;
            val_14 = val_14 * 0.5f;
            val_15 = val_15 * 0.5f;
            val_14.Normalize();
            return new UnityEngine.Vector2() {x = val_14};
        }
        protected UnityEngine.Vector2 BezierPoint(UnityEngine.Vector2 p1, UnityEngine.Vector2 c1, UnityEngine.Vector2 c2, UnityEngine.Vector2 p2, float aPercent)
        {
            var val_1;
            float val_5;
            float val_6 = 1f;
            var val_8 = val_1;
            float val_7 = 3f;
            float val_2 = val_8 * val_8;
            val_6 = val_6 - val_8;
            float val_3 = val_6 * val_6;
            float val_4 = val_3 * val_7;
            val_7 = val_6 * val_7;
            val_6 = val_6 * val_3;
            val_4 = val_4 * val_8;
            val_7 = val_2 * val_7;
            val_8 = val_2 * val_8;
            val_3 = val_4 * c2.x;
            val_4 = val_4 * c1.y;
            mem[1152921510170899540] = val_3;
            this = val_4;
            return new UnityEngine.Vector2() {x = val_5};
        }
        protected float BezierLength(UnityEngine.Vector2 p1, UnityEngine.Vector2 c1, UnityEngine.Vector2 c2, UnityEngine.Vector2 p2)
        {
            float val_2;
            float val_3;
            float val_6 = 0f;
            var val_5 = 1;
            do
            {
                UnityEngine.Vector2 val_1 = BezierPoint(p1:  new UnityEngine.Vector2() {x = p1.x, y = p1.x}, c1:  new UnityEngine.Vector2() {x = p1.y, y = c1.x}, c2:  new UnityEngine.Vector2() {x = c1.y, y = c2.x}, p2:  new UnityEngine.Vector2() {x = c2.y, y = p2.x}, aPercent:  0.3333333f);
                float val_4 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = p1.x, y = p1.y}, b:  new UnityEngine.Vector2() {x = val_2, y = val_3});
                val_5 = val_5 + 1;
                val_6 = val_6 + p1.x;
            }
            while(val_5 != 4);
            
            return (float)p1.x;
        }
        protected float BezierLengthSlow(UnityEngine.Vector2 p1, UnityEngine.Vector2 c1, UnityEngine.Vector2 c2, UnityEngine.Vector2 p2, int count = 200)
        {
            float val_3;
            float val_4;
            float val_6;
            if(count >= 2)
            {
                    var val_7 = 1;
                do
            {
                float val_6 = 1f;
                val_6 = val_6 / ((float)count + (-1f));
                UnityEngine.Vector2 val_2 = BezierPoint(p1:  new UnityEngine.Vector2() {x = p1.x, y = p1.x}, c1:  new UnityEngine.Vector2() {x = p1.y, y = c1.x}, c2:  new UnityEngine.Vector2() {x = c1.y, y = c2.x}, p2:  new UnityEngine.Vector2() {x = c2.y, y = p2.x}, aPercent:  val_6);
                float val_5 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = p1.x, y = p1.y}, b:  new UnityEngine.Vector2() {x = val_3, y = val_4});
                val_7 = val_7 + 1;
                val_6 = 0f + p1.x;
            }
            while(count != val_7);
            
                return (float)S0;
            }
            
            val_6 = 0f;
            return (float)S0;
        }
        public string ToSVGElement()
        {
            var val_6;
            bool val_18;
            var val_19;
            var val_20;
            int val_21;
            var val_22;
            if(true == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_1 = static_value_0028000B * 100f;
            val_18 = this._closed;
            val_20 = 536893745;
            float val_2 = static_value_0028000F * (-100f);
            val_21 = 0;
            string val_3 = System.String.Format(format:  -1610610531, arg0:  536893745, arg1:  536893745);
            val_22 = -1610610531;
            bool val_4 = val_18 - 1;
            if(val_4 >= true)
            {
                    do
            {
                UnityEngine.Vector2 val_5 = val_1.GetControl(aIndex:  1269433552, aNext:  false);
                val_21 = val_21 + 1;
                UnityEngine.Vector2 val_8 = val_1.GetControl(aIndex:  1269433552, aNext:  this.WrapI(i:  val_21));
                float val_19 = val_1;
                int val_9 = this.WrapI(i:  val_21);
                if(val_9 <= val_9)
            {
                    var val_18 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                float val_10 = val_1 * 100f;
                val_18 = val_18 + (val_9 << 2);
                val_20 = 22715124;
                val_18 = 536893745;
                mem[536882227] = val_18;
                float val_11 = val_6 * (-100f);
                val_19 = val_19 * 100f;
                mem[536882231] = 536893745;
                mem[536882235] = 536893745;
                float val_12 = val_6 * (-100f);
                float val_13 = ((0 + (val_9) << 2) + 16 + 8) * 100f;
                mem[536882239] = 536893745;
                mem[536882243] = 536893745;
                float val_14 = ((0 + (val_9) << 2) + 16 + 12) * (-100f);
                val_19 = 536893745;
                mem[536882247] = val_19;
                string val_15 = System.String.Format(format:  -1610608969, args:  536882211);
                string val_16 = -1610610531(-1610610531) + -1610608969(-1610608969);
                val_22 = val_22;
            }
            while(val_4 != val_21);
            
            }
            
            string val_17 = -1610610531(-1610610531) + -1610612089(-1610612089);
        }
    
    }

}
