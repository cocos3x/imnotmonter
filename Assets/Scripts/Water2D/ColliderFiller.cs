using UnityEngine;

namespace Water2D
{
    public class ColliderFiller : MonoBehaviour
    {
        // Fields
        public UnityEngine.Collider2D collider;
        public Water2D.Water2D_Spawner water2D_Spawner;
        public float radius;
        public int circleDetailPoints;
        public bool autoRefresh;
        private UnityEngine.Vector3[] pointsInside;
        private UnityEngine.Vector3[] pointsOutside;
        public bool Masked;
        private UnityEngine.Collider2D _lastCollider;
        
        // Properties
        public UnityEngine.Vector3[] PointsInside { get; }
        public UnityEngine.Vector3[] PointsOutside { get; }
        public int InsidePointsCount { get; }
        public int OutsidePointsCount { get; }
        public float Radius { get; }
        
        // Methods
        public UnityEngine.Vector3[] get_PointsInside()
        {
        
        }
        public UnityEngine.Vector3[] get_PointsOutside()
        {
        
        }
        public int get_InsidePointsCount()
        {
            if(this.pointsInside == null)
            {
                    this.pointsInside = 0;
            }
            
            return (int)this.pointsInside;
        }
        public int get_OutsidePointsCount()
        {
            if(this.pointsOutside == null)
            {
                    this.pointsOutside = 0;
            }
            
            return (int)this.pointsOutside;
        }
        public float get_Radius()
        {
            Water2D.Water2D_Spawner val_2;
            float val_3;
            if(this.water2D_Spawner == 0)
            {
                goto label_3;
            }
            
            val_2 = this.water2D_Spawner;
            if(this.water2D_Spawner != 0)
            {
                goto label_4;
            }
            
            val_2 = this.water2D_Spawner;
            if(val_2 == 0)
            {
                goto label_5;
            }
            
            label_4:
            val_3 = this.water2D_Spawner.ColliderSize * this.water2D_Spawner.size;
            return val_3;
            label_3:
            val_3 = this.radius;
            return val_3;
            label_5:
        }
        private void Update()
        {
            if(this._lastCollider == this.collider)
            {
                    return;
            }
            
            this._lastCollider = this.collider;
            this.Refresh();
            this.Fill();
        }
        public void Refresh()
        {
            float val_9;
            float val_10;
            Water2D.Water2D_Spawner val_11;
            if(this.collider == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = this.collider.transform;
            UnityEngine.Vector3 val_3 = position;
            val_10 = this.radius;
            if((UnityEngine.Object.op_Implicit(exists:  this.water2D_Spawner)) == false)
            {
                goto label_8;
            }
            
            val_11 = this.water2D_Spawner;
            if(this.water2D_Spawner != 0)
            {
                goto label_9;
            }
            
            val_11 = this.water2D_Spawner;
            if(val_11 == 0)
            {
                goto label_10;
            }
            
            label_9:
            val_9 = this.water2D_Spawner.size;
            val_10 = this.water2D_Spawner.ColliderSize * val_9;
            label_8:
            this.GetPointsInCollider(collider:  this.collider, r:  val_9, _pointsInside: out  val_10, _pointsOutside: out  UnityEngine.Vector3[] val_7 = 925693492, zPos:  val_3.y, masked:  false);
            this.pointsInside = 0;
            this.pointsOutside = 0;
            this.water2D_Spawner.DropsUsed = this.pointsOutside;
            return;
            label_10:
        }
        public void Fill()
        {
            var val_7;
            var val_8;
            var val_9;
            if(this.water2D_Spawner != 0)
            {
                goto label_3;
            }
            
            val_7 = -1610602579;
            goto label_6;
            label_3:
            this.water2D_Spawner.SetupParticles();
            val_8 = 4;
            val_9 = 0;
            goto label_8;
            label_28:
            if(SB >= this.water2D_Spawner)
            {
                goto label_11;
            }
            
            UnityEngine.GameObject val_8 = this.water2D_Spawner.WaterDropsObjects[0];
            UnityEngine.Transform val_2 = val_8.transform;
            val_8.position = new UnityEngine.Vector3() {x = this.pointsInside[val_9], y = this.pointsInside[val_9], z = this.pointsInside[val_9]};
            UnityEngine.GameObject val_12 = this.water2D_Spawner.WaterDropsObjects[0];
            Weight val_3 = val_12.GetComponent<Weight>();
            if((UnityEngine.Object.op_Implicit(exists:  val_12)) != false)
            {
                    val_12.Active = true;
            }
            
            val_8 = val_8 + 1;
            val_9 = 12;
            label_8:
            if((val_8 - 4) < val_12)
            {
                goto label_28;
            }
            
            return;
            label_11:
            string val_6 = this.water2D_Spawner.ToString();
            string val_7 = -1610605315(-1610605315) + 926120872 + -1610612375(-1610612375);
            val_7 = -1610605315;
            label_6:
            UnityEngine.Debug.LogError(message:  -1610605315);
        }
        public void Clear()
        {
            var val_5;
            var val_6;
            if(this.water2D_Spawner == 0)
            {
                    UnityEngine.Debug.LogError(message:  -1610602579);
                return;
            }
            
            val_5 = 4;
            val_6 = 0;
            goto label_6;
            label_23:
            UnityEngine.GameObject val_6 = this.water2D_Spawner.WaterDropsObjects[0];
            UnityEngine.Transform val_2 = val_6.transform;
            val_6.position = new UnityEngine.Vector3() {x = this.pointsInside[val_6], y = this.pointsInside[val_6], z = this.pointsInside[val_6]};
            UnityEngine.GameObject val_10 = this.water2D_Spawner.WaterDropsObjects[0];
            Weight val_3 = val_10.GetComponent<Weight>();
            if((UnityEngine.Object.op_Implicit(exists:  val_10)) != false)
            {
                    val_10.Active = true;
            }
            
            val_5 = val_5 + 1;
            val_6 = val_6 + 12;
            label_6:
            if((val_5 - 4) < this.pointsInside)
            {
                goto label_23;
            }
            
            this.water2D_Spawner.Restore();
        }
        private void GetPointsInCollider(UnityEngine.Collider2D collider, float r, out UnityEngine.Vector3[] _pointsInside, out UnityEngine.Vector3[] _pointsOutside, float zPos = 0, bool masked = False)
        {
            var val_1;
            float val_13;
            var val_14;
            UnityEngine.Vector3[] val_15;
            var val_16;
            var val_17;
            var val_18;
            bool val_19;
            var val_20;
            var val_21;
            val_13 = 1152921509828805200;
            val_14 = 22974488;
            ColliderFiller.<>c__DisplayClass23_0 val_3 = 536898289;
            val_3 = new ColliderFiller.<>c__DisplayClass23_0();
            mem[536898305] = val_1;
            if(collider != 0)
            {
                goto label_4;
            }
            
            val_15 = 0;
            UnityEngine.Debug.LogError(message:  -1610609285);
            _pointsOutside = val_15;
            mem2[0] = val_15;
            val_16 = masked;
            goto label_7;
            label_4:
            System.Collections.Generic.List<UnityEngine.Vector3> val_5 = 536878517;
            val_5 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            mem[536898309] = val_5;
            System.Collections.Generic.List<UnityEngine.Vector3> val_6 = 536878517;
            val_6 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            mem[536898313] = val_6;
            if(collider != 0)
            {
                    mem[536898297] = 0;
                mem[536898298] = 0;
                val_17 = 0;
            }
            else
            {
                    val_17 = 0;
                mem[536898297] = val_17;
            }
            
            val_18 = 0;
            mem[536898301] = val_18;
            mem[536898299] = val_17;
            if(0 == 0)
            {
                goto label_10;
            }
            
            val_19 = masked;
            val_20 = 1152921509828809248;
            val_13 = val_13;
            if(collider != 0)
            {
                    if(null != 536884305)
            {
                    val_18 = 0;
            }
            
            }
            
            val_21 = val_18;
            UnityEngine.Vector2[] val_8 = Water2D.ColliderFiller.GetBoxPoints(box:  0);
            goto label_19;
            label_10:
            if((val_3 + 9) == 0)
            {
                goto label_13;
            }
            
            if(collider == 0)
            {
                goto label_14;
            }
            
            if(null != 536884813)
            {
                    val_21 = 0;
            }
            
            goto label_15;
            label_13:
            val_19 = masked;
            val_20 = 1152921509828809248;
            val_13 = val_13;
            if(mem[536898299] == 0)
            {
                goto label_16;
            }
            
            if(collider == 0)
            {
                goto label_17;
            }
            
            if(null != 536891957)
            {
                    val_21 = 0;
            }
            
            goto label_18;
            label_14:
            val_21 = 0;
            label_15:
            val_19 = masked;
            val_20 = 1152921509828809248;
            val_13 = val_13;
            UnityEngine.Vector2[] val_9 = Water2D.ColliderFiller.GetCirclePoints(circle:  0, count:  mem[1152921509828769128]);
            goto label_19;
            label_17:
            val_21 = 0;
            label_18:
            UnityEngine.Vector2[] val_10 = Water2D.ColliderFiller.GetPolygonPoints(polygon:  0);
            label_19:
            mem[536898301] = val_21;
            label_16:
            536873361 = new System.Action<UnityEngine.Vector3>(object:  536898289, method:  new IntPtr(1610683313));
            536873361.FillByGrid(collider:  collider, r:  r, action:  926990928, zPos:  zPos);
            val_15 = mem[536898309];
            val_14 = 22739780;
            T[] val_12 = val_15.ToArray();
            _pointsOutside = val_15;
            T[] val_13 = mem[536898313].ToArray();
            mem2[0] = mem[536898313];
            val_16 = val_19;
            label_7:
        }
        private void FillByGrid(UnityEngine.Collider2D collider, float r, System.Action<UnityEngine.Vector3> action, float zPos = 0)
        {
            float val_3;
            float val_5;
            float val_7;
            var val_12;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_14 = collider;
            val_15 = 22974489;
            val_17 = 0;
            UnityEngine.Bounds val_1 = bounds;
            UnityEngine.Vector3 val_2 = size;
            UnityEngine.Vector3 val_4 = size;
            UnityEngine.Vector3 val_6 = size;
            var val_16 = val_3;
            var val_15 = val_5;
            var val_14 = val_7;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            System.Action<UnityEngine.Vector3> val_9 = action + action;
            if(((int)val_5 / val_9) < 1)
            {
                    return;
            }
            
            val_15 = (int)val_3 / val_9;
            val_14 = val_14 * 0.5f;
            val_15 = val_15 * 0.5f;
            val_16 = val_16 * 0.5f;
            do
            {
                if(val_15 >= 1)
            {
                    do
            {
                UnityEngine.Vector3 val_13 = center;
                if(val_1.m_Extents.y != 0f)
            {
                    float val_17 = val_5;
                float val_18 = val_7;
                float val_19 = val_3;
                val_17 = action + val_17;
                val_18 = val_18 + val_12;
                val_17 = val_17 - val_15;
                val_18 = val_18 - val_14;
                val_19 = action + val_19;
                val_19 = val_19 - val_16;
                val_1.m_Extents.y.Invoke(obj:  new UnityEngine.Vector3() {x = val_19, y = val_17, z = val_18});
            }
            
                val_16 = 0 + 1;
            }
            while(val_15 != val_16);
            
            }
            
                val_17 = val_17 + 1;
            }
            while(val_17 != ((int)val_5 / val_9));
        
        }
        public static UnityEngine.Vector2[] GetBoxPoints(UnityEngine.BoxCollider2D box)
        {
            var val_4;
            float val_6;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            if(box != 0)
            {
                    UnityEngine.Transform val_1 = box.transform;
                val_27 = box;
                val_28 = box;
            }
            else
            {
                    val_28 = 0;
                UnityEngine.Transform val_2 = 0.transform;
                val_27 = 0;
            }
            
            UnityEngine.Vector2 val_3 = size;
            UnityEngine.Vector2 val_5 = size;
            float val_27 = val_6;
            val_27 = val_27 * 0.5f;
            UnityEngine.Vector3 val_8 = TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_4 * (-0.5f), z = val_27});
            mem[536882601] = val_4;
            mem[536882605] = val_6;
            if(box != 0)
            {
                    UnityEngine.Transform val_9 = val_28.transform;
                val_29 = val_28;
            }
            else
            {
                    UnityEngine.Transform val_10 = val_28.transform;
                val_29 = val_28;
            }
            
            UnityEngine.Vector2 val_11 = size;
            UnityEngine.Vector2 val_12 = size;
            float val_28 = val_6;
            val_28 = val_28 * 0.5f;
            UnityEngine.Vector3 val_14 = TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_4 * 0.5f, z = val_28});
            mem[536882609] = val_4;
            mem[536882613] = val_6;
            if(box != 0)
            {
                    UnityEngine.Transform val_15 = val_28.transform;
                val_30 = val_28;
            }
            else
            {
                    UnityEngine.Transform val_16 = val_28.transform;
                val_30 = val_28;
            }
            
            UnityEngine.Vector2 val_17 = size;
            UnityEngine.Vector2 val_18 = size;
            float val_29 = val_6;
            val_29 = val_29 * (-0.5f);
            UnityEngine.Vector3 val_20 = TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_4 * 0.5f, z = val_29});
            mem[536882617] = val_4;
            mem[536882621] = val_6;
            if(box != 0)
            {
                    UnityEngine.Transform val_21 = val_28.transform;
                val_31 = val_28;
            }
            else
            {
                    UnityEngine.Transform val_22 = val_28.transform;
                val_31 = val_28;
            }
            
            UnityEngine.Vector2 val_23 = size;
            UnityEngine.Vector2 val_24 = size;
            float val_30 = val_6;
            val_30 = val_30 * (-0.5f);
            UnityEngine.Vector3 val_26 = TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_4 * (-0.5f), z = val_30});
            mem[536882625] = val_4;
        }
        public static UnityEngine.Vector2[] GetCirclePoints(UnityEngine.CircleCollider2D circle, int count)
        {
            var val_6;
            var val_7;
            if(count < 1)
            {
                    return;
            }
            
            var val_11 = 0;
            do
            {
                float val_9 = 0f;
                val_9 = val_9 * 3.141593f;
                val_9 = val_9 + val_9;
                float val_1 = val_9 / (float)count;
                UnityEngine.Transform val_2 = circle.transform;
                float val_3 = circle.radius;
                UnityEngine.CircleCollider2D val_10 = circle;
                val_10 = val_1 * val_10;
                UnityEngine.Vector3 val_5 = TransformPoint(position:  new UnityEngine.Vector3() {x = circle, y = val_10, z = val_1 * val_10});
                var val_8 = 536882585 + 0;
                val_11 = val_11 + 1;
                mem2[0] = val_6;
                mem2[0] = val_7;
            }
            while(count != val_11);
        
        }
        public static UnityEngine.Vector2[] GetPolygonPoints(UnityEngine.PolygonCollider2D polygon)
        {
            var val_6;
            var val_7;
            float val_8;
            UnityEngine.Vector2[] val_1 = polygon.points;
            if(SB < 1)
            {
                    return;
            }
            
            var val_9 = 0;
            do
            {
                if(polygon != 0)
            {
                    UnityEngine.Transform val_2 = polygon.transform;
                val_8 = polygon;
            }
            else
            {
                    UnityEngine.Transform val_3 = polygon.transform;
                val_8 = polygon;
            }
            
                UnityEngine.Vector2[] val_4 = polygon.points;
                UnityEngine.Vector3 val_5 = TransformPoint(position:  new UnityEngine.Vector3() {x = val_8, y = UnityEngine.PolygonCollider2D.__il2cppRuntimeField_byval_arg, z = polygon});
                var val_8 = 536882585 + 0;
                val_9 = val_9 + 1;
                mem2[0] = val_6;
                mem2[0] = val_7;
            }
            while(val_9 != SB);
        
        }
        public static bool IsPointInPolygon(UnityEngine.Vector2 point, UnityEngine.Vector2[] polygon, bool masked = False)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_6 = masked;
            val_7 = polygon;
            if(polygon != null)
            {
                    val_8 = val_7;
                val_10 = point.x;
            }
            else
            {
                    val_8 = 12;
                val_10 = 0;
                val_9 = 0;
            }
            
            if(val_10 < 1)
            {
                    return true;
            }
            
            var val_7 = 0;
            do
            {
                val_7 = val_7 + 1;
                val_11 = 0;
                if(val_8 > val_7)
            {
                    0 = 1;
            }
            
                if(val_8 > val_7)
            {
                    0 = 1;
            }
            
                if(1 != 1)
            {
                    float val_1 = point.y - S2;
                val_1 = ((val_7[-8]) - 1152921504993028592) * val_1;
                float val_4 = point.x - 1152921504993028592;
                val_1 = val_1 / (0 - S2);
                if(1 < 0)
            {
                    val_11 = 1;
            }
            
            }
            
                val_6 = 1 - val_6;
                if(1 != 1)
            {
                    val_6 = 1;
            }
            
            }
            while(val_10 != val_7);
            
            return true;
        }
        public ColliderFiller()
        {
            this.radius = 1f;
            this.circleDetailPoints = 10;
        }
    
    }

}
