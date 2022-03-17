using UnityEngine;

namespace Ferr
{
    [Serializable]
    public class SVGLine : ISVGElement
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.Vector2> _points;
        private bool _closed;
        
        // Properties
        public UnityEngine.Rect Bounds { get; }
        public UnityEngine.Vector2 Start { get; }
        public UnityEngine.Vector2 End { get; }
        public bool Closed { get; set; }
        public int Count { get; }
        
        // Methods
        public UnityEngine.Rect get_Bounds()
        {
            float val_2;
            float val_3;
            var val_9;
            if((R1 + 8 + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = 0;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            UnityEngine.Rect val_4 = new UnityEngine.Rect(position:  new UnityEngine.Vector2() {x = R1 + 8 + 8 + 16, y = R1 + 8 + 8 + 20}, size:  new UnityEngine.Vector2() {x = val_2, y = val_3});
            goto label_3;
            label_11:
            if((R1 + 8 + 12) <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_9 = R1 + 8 + 8;
            val_9 = val_9 + 16;
            float val_5 = val_4.m_XMin.xMin;
            if((R1 + 8 + 12) > val_9)
            {
                    val_4.m_XMin.xMin = 1265371840;
            }
            
            float val_6 = val_4.m_XMin.xMax;
            if((R1 + 8 + 12) < 0)
            {
                    val_4.m_XMin.xMax = 1265371840;
            }
            
            float val_7 = val_4.m_XMin.yMin;
            if((R1 + 8 + 12) > val_9)
            {
                    val_4.m_XMin.yMin = 1265371840;
            }
            
            float val_8 = val_4.m_XMin.yMax;
            if((R1 + 8 + 12) < 0)
            {
                    val_4.m_XMin.yMax = 1265371840;
            }
            
            val_9 = 1;
            label_3:
            if(val_9 < (R1 + 8 + 12))
            {
                goto label_11;
            }
            
            return new UnityEngine.Rect() {m_XMin = 1265371840, m_YMin = val_1.y};
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
            
                val_1 = (R1 + 8 + 8) + 4294967288;
            }
            
            val_1 = val_1 + 16;
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
        public int get_Count()
        {
            if(this._points != 0)
            {
                    return (int)true;
            }
            
            return (int)true;
        }
        public SVGLine(bool aClosed = False)
        {
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            this._points = 536878507;
            this._closed = aClosed;
        }
        public SVGLine(System.Collections.Generic.List<UnityEngine.Vector2> aPoints, bool aClosed = False)
        {
            System.Collections.Generic.List<UnityEngine.Vector2> val_2 = aPoints;
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            this._points = 536878507;
            val_2 = new System.Object();
            this._closed = aClosed;
            this._points.AddRange(collection:  val_2);
        }
        public void Add(UnityEngine.Vector2 aPt)
        {
            this._points.Add(item:  new UnityEngine.Vector2() {x = aPt.x, y = aPt.y});
        }
        public void Clear()
        {
            this._points.Clear();
        }
        public System.Collections.Generic.List<UnityEngine.Vector2> GetPoints(int aResolution)
        {
        
        }
        public Ferr.ISVGElement Reverse()
        {
            var val_3;
            Ferr.SVGLine val_1 = 536893227;
            val_1 = new Ferr.SVGLine(aClosed:  this._closed);
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(collection:  this._points);
            if(val_1 != 0)
            {
                    val_3 = val_1;
                mem[536893235] = 536878507;
            }
            else
            {
                    val_3 = 8;
                mem[8] = 536878507;
            }
            
            val_3.Reverse();
        }
        private int WrapI(int i)
        {
            int val_2;
            System.Collections.Generic.List<UnityEngine.Vector2> val_3;
            val_2 = i;
            if(val_2 >= 0)
            {
                goto label_1;
            }
            
            val_3 = this._points;
            if(this._points != 0)
            {
                goto label_2;
            }
            
            val_3 = this._points;
            if(val_3 == 0)
            {
                goto label_3;
            }
            
            label_2:
            int val_3 = UnityEngine.Mathf.Abs(value:  val_2);
            val_3 = val_3 + 1;
            label_1:
            if(this._closed == false)
            {
                    return UnityEngine.Mathf.Clamp(value:  val_2, min:  0, max:  0 - 1);
            }
            
            return 0;
            label_3:
        }
        public string ToSVGElement()
        {
            var val_11;
            if(true == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_1 = (3.673424E-39f) * 100f;
            float val_2 = (1.401298E-45f) * (-100f);
            string val_3 = System.String.Format(format:  -1610610531, arg0:  536893745, arg1:  536893745);
            val_11 = -1610610531;
            if((SL - 1) >= 1)
            {
                    var val_13 = 1;
                do
            {
                int val_5 = this.WrapI(i:  1);
                if(val_5 <= val_5)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_11 = val_11 + (val_5 << 3);
                float val_12 = (0 + (val_5) << 3) + 16;
                val_12 = val_12 * 100f;
                float val_6 = ((0 + (val_5) << 3) + 20) * (-100f);
                string val_7 = System.String.Format(format:  -1610606557, arg0:  536893745, arg1:  536893745);
                string val_8 = -1610610531(-1610610531) + -1610606557(-1610606557);
                val_13 = val_13 + 1;
                val_11 = val_11;
            }
            while(SL != val_13);
            
            }
            
            if(this._closed != false)
            {
                    string val_9 = -1610610531(-1610610531) + -1610597163(-1610597163);
                val_11 = val_11;
            }
            
            string val_10 = -1610610531(-1610610531) + -1610612089(-1610612089);
        }
    
    }

}
