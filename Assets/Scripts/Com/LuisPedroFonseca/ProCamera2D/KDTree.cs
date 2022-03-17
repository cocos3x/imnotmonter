using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class KDTree
    {
        // Fields
        public Com.LuisPedroFonseca.ProCamera2D.KDTree[] lr;
        public UnityEngine.Vector3 pivot;
        public int pivotIndex;
        public int axis;
        private const int numDims = 3;
        
        // Methods
        public KDTree()
        {
            this.lr = 536882129;
        }
        public static Com.LuisPedroFonseca.ProCamera2D.KDTree MakeFromPoints(UnityEngine.Vector3[] points)
        {
            var val_4;
            System.Int32[] val_5;
            if(points != null)
            {
                    val_4 = points;
                System.Int32[] val_1 = Com.LuisPedroFonseca.ProCamera2D.KDTree.Iota(num:  points);
                val_5 = points;
            }
            else
            {
                    val_4 = 12;
                System.Int32[] val_2 = Com.LuisPedroFonseca.ProCamera2D.KDTree.Iota(num:  0);
                val_5 = 0;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.KDTree val_4 = Com.LuisPedroFonseca.ProCamera2D.KDTree.MakeFromPointsInner(depth:  0, stIndex:  0, enIndex:  val_4 - 1, points:  points, inds:  val_5);
        }
        private static Com.LuisPedroFonseca.ProCamera2D.KDTree MakeFromPointsInner(int depth, int stIndex, int enIndex, UnityEngine.Vector3[] points, int[] inds)
        {
            UnityEngine.Vector3[] val_7;
            int val_8;
            int val_9;
            int val_10;
            int val_11;
            UnityEngine.Vector3 val_12;
            val_7 = points;
            val_8 = enIndex;
            val_9 = stIndex;
            Com.LuisPedroFonseca.ProCamera2D.KDTree val_1 = 536889413;
            val_1 = new Com.LuisPedroFonseca.ProCamera2D.KDTree();
            if(val_1 != 0)
            {
                    val_10 = depth - 4294967298;
                mem[536889441] = val_10;
            }
            else
            {
                    mem[28] = depth - 4294967298;
                val_7 = val_7;
                val_9 = val_9;
                val_10 = mem[28];
            }
            
            int val_9 = val_9;
            int val_3 = Com.LuisPedroFonseca.ProCamera2D.KDTree.FindPivotIndex(points:  val_7, inds:  inds, stIndex:  val_9, enIndex:  val_8, axis:  val_10);
            val_11 = inds[val_3];
            if(val_1 != 0)
            {
                    mem[536889437] = val_11;
            }
            else
            {
                    mem[24] = val_11;
                val_11 = mem[24];
            }
            
            inds[val_3] = val_11 + (val_11 << 1);
            val_12 = val_7[inds[val_3]];
            mem[536889425] = val_12;
            val_9 = val_3 - 1;
            mem[536889429] = val_7[inds[val_3]];
            mem[536889433] = val_7[inds[val_3]];
            if(val_9 >= val_9)
            {
                    val_12 = depth + 1;
                mem2[0] = val_12;
                val_8 = val_8;
            }
            
            if((val_3 + 1) > val_8)
            {
                    return;
            }
            
            val_12 = mem[536889421];
            mem2[0] = depth + 1;
        }
        private static void SwapElements(int[] arr, int a, int b)
        {
            mem2[0] = arr[b];
            mem2[0] = arr[a];
        }
        private static int FindSplitPoint(UnityEngine.Vector3[] points, int[] inds, int stIndex, int enIndex, int axis)
        {
            var val_7;
            var val_8;
            val_7 = stIndex;
            int val_7 = inds[val_7];
            inds[val_7] = val_7 + (val_7 << 1);
            float val_1 = points[inds[val_7]][16].Item[axis];
            var val_8 = points[inds[val_7]][16];
            int val_9 = inds[enIndex];
            float val_3 = points[val_9 + (val_9 << 1)][16].Item[axis];
            var val_10 = points[val_9 + (val_9 << 1)][16];
            int val_4 = enIndex + val_7;
            val_4 = val_4 + (val_4 >> 31);
            int val_5 = val_4 >> 1;
            int val_11 = inds[val_5];
            val_4 = val_11 + (val_11 << 1);
            float val_6 = points[val_4][16].Item[axis];
            var val_12 = points[val_4][16];
            if(val_4 <= val_11)
            {
                goto label_8;
            }
            
            if(val_4 > val_11)
            {
                goto label_11;
            }
            
            if(val_4 <= val_11)
            {
                    enIndex = val_5;
            }
            
            val_8 = enIndex;
            return (int)val_8;
            label_8:
            if(val_4 <= val_11)
            {
                    if(val_4 <= val_11)
            {
                    enIndex = val_5;
            }
            
                val_7 = enIndex;
            }
            
            label_11:
            val_8 = val_7;
            return (int)val_8;
        }
        public static int FindPivotIndex(UnityEngine.Vector3[] points, int[] inds, int stIndex, int enIndex, int axis)
        {
            int val_10;
            int val_11;
            int val_12;
            int val_12 = enIndex;
            val_10 = stIndex;
            val_11 = Com.LuisPedroFonseca.ProCamera2D.KDTree.FindSplitPoint(points:  points, inds:  inds, stIndex:  stIndex, enIndex:  enIndex, axis:  axis);
            int val_7 = inds[val_11];
            inds[val_11] = val_7 + (val_7 << 1);
            UnityEngine.Vector3 val_9 = points[inds[val_11]];
            Com.LuisPedroFonseca.ProCamera2D.KDTree.SwapElements(arr:  inds, a:  val_10, b:  val_11);
            val_12 = val_10 + 1;
            if(val_12 > val_12)
            {
                goto label_11;
            }
            
            label_10:
            val_10 = val_12 + 4;
            label_8:
            val_12 = val_10 - 4;
            UnityEngine.Vector3 val_11 = points[inds];
            float val_2 = points[inds].Item[axis];
            float val_3 = points[inds[val_11]].Item[axis];
            if(inds > null)
            {
                goto label_7;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.KDTree.SwapElements(arr:  inds, a:  val_10 - 5, b:  val_12);
            int val_5 = val_10 + 1;
            val_10 = val_5;
            if((val_10 - 3) <= val_12)
            {
                goto label_8;
            }
            
            goto label_9;
            label_7:
            Com.LuisPedroFonseca.ProCamera2D.KDTree.SwapElements(arr:  inds, a:  val_12, b:  val_12);
            val_12 = val_12 - 1;
            if(val_12 <= val_12)
            {
                goto label_10;
            }
            
            val_12 = val_10 - 4;
            goto label_11;
            label_9:
            val_12 = val_5 - 4;
            label_11:
            val_5 = val_12 - 1;
            return (int)val_5;
        }
        public static int[] Iota(int num)
        {
            if(num < 1)
            {
                    return;
            }
            
            var val_1 = 0;
            do
            {
                mem[536882081] = val_1;
                val_1 = val_1 + 1;
            }
            while(num != val_1);
        
        }
        public int FindNearest(UnityEngine.Vector3 pt)
        {
            this.Search(pt:  new UnityEngine.Vector3() {x = pt.x, y = pt.y, z = pt.z}, bestSqSoFar: ref  1E+09f, bestIndex: ref  0);
            return 0;
        }
        private void Search(UnityEngine.Vector3 pt, ref float bestSqSoFar, ref int bestIndex)
        {
            float val_5;
            float val_6;
            Com.LuisPedroFonseca.ProCamera2D.KDTree val_7;
            float val_6 = pt.y;
            UnityEngine.Vector3 val_5 = this.pivot;
            val_5 = val_5 - pt.x;
            val_6 = S4 - val_6;
            float val_1 = S6 - pt.z;
            float val_2 = val_5.sqrMagnitude;
            if(<0)
            {
                    0 = bestIndex;
                bestSqSoFar = 986389872;
                bestIndex = this.pivotIndex;
            }
            
            float val_3 = pt.x.Item[this.axis];
            uint val_7 = 986389884;
            float val_4 = this.pivot.Item[this.axis];
            UnityEngine.Vector3 val_11 = this.pivot;
            val_7 = val_7 - val_11;
            if()
            {
                    0 = 1;
            }
            
            if(this.lr[1] != 0)
            {
                    val_5 = pt.x;
                val_6 = pt.y;
            }
            
            if(this.lr[1] <= 0)
            {
                    val_7 = 1;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.KDTree val_10 = this.lr[1];
            if(val_10 == 0)
            {
                    return;
            }
            
            val_11 = val_7 * val_7;
            if(val_10 <= 0)
            {
                    return;
            }
            
            val_5 = pt.x;
            val_7 = this.lr[1];
            val_6 = pt.z;
        }
        private float DistFromSplitPlane(UnityEngine.Vector3 pt, UnityEngine.Vector3 planePt, int axis)
        {
            float val_1 = pt.x.Item[axis];
            float val_2 = planePt.x.Item[axis];
            uint val_3 = 986673832;
            val_3 = 986673844 - val_3;
            return (float)val_3;
        }
        public string Dump(int level)
        {
            string val_7;
            string val_1 = this.pivotIndex.ToString();
            string val_2 = this.pivotIndex.PadLeft(totalWidth:  level);
            string val_3 = this.pivotIndex + -1610612685(-1610612685);
            val_7 = this.pivotIndex;
            if(this.lr[0] != 0)
            {
                    int val_4 = level + 2;
                string val_5 = val_7 + this.lr[0];
                val_7 = val_7;
            }
            
            if(this.lr[1] == 0)
            {
                    return;
            }
            
            int val_6 = level + 2;
            return val_7 + this.lr[1];
        }
    
    }

}
