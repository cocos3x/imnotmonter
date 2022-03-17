using UnityEngine;

namespace Ferr
{
    public class RecolorTree
    {
        // Fields
        private static Ferr.RecolorTree.SortX sortX;
        private static Ferr.RecolorTree.SortY sortY;
        private static Ferr.RecolorTree.SortZ sortZ;
        private Ferr.RecolorTree.TreeNode root;
        private Ferr.RecolorTree.TreeSettings settings;
        
        // Methods
        public RecolorTree(UnityEngine.Mesh aMesh, System.Nullable<UnityEngine.Matrix4x4> aTransform, bool aX = True, bool aY = True, bool aZ = True)
        {
            var val_2;
            var val_3;
            var val_4;
            Ferr.RecolorTree val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            bool val_30;
            var val_31;
            var val_32;
            val_25 = this;
            UnityEngine.Mesh val_1 = aMesh;
            val_1 = new System.Object();
            val_26 = val_2;
            val_27 = val_4;
            if(val_1 != 0)
            {
                goto label_3;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            var val_7 = 536882597 + 16;
            val_28 = 536881823;
            UnityEngine.Color val_8 = UnityEngine.Color.white;
            val_25 = val_25;
            val_29 = val_2;
            val_26 = val_3;
            val_27 = val_4;
            var val_9 = val_28 + 16;
            val_30 = aTransform.HasValue;
            val_31 = 536882597;
            goto label_8;
            label_3:
            if(val_1 != 0)
            {
                    UnityEngine.Vector3[] val_23 = val_1.vertices;
                val_29 = val_1;
            }
            else
            {
                    UnityEngine.Vector3[] val_24 = 0.vertices;
                val_29 = 0;
            }
            
            UnityEngine.Color[] val_25 = val_1.colors;
            if(val_1 != 0)
            {
                    val_28 = val_1;
                goto label_11;
            }
            
            val_28 = 536881823;
            val_32 = 0;
            goto label_13;
            label_16:
            UnityEngine.Color val_26 = UnityEngine.Color.white;
            val_32 = 1;
            label_13:
            if(val_32 < mem[536881835])
            {
                goto label_16;
            }
            
            val_25 = val_25;
            val_26 = val_2;
            val_27 = val_4;
            label_11:
            val_30 = aTransform.HasValue;
            val_31 = val_29;
            label_8:
            this.Create(aPoints:  null, aColors:  536881823, aTransform:  new System.Nullable<UnityEngine.Matrix4x4>() {HasValue = val_30}, aX:  aX, aY:  aY, aZ:  aZ);
        }
        public RecolorTree(UnityEngine.Vector3[] aPoints, UnityEngine.Color[] aColors, System.Nullable<UnityEngine.Matrix4x4> aTransform, bool aX = True, bool aY = True, bool aZ = True)
        {
            this.Create(aPoints:  aPoints, aColors:  aColors, aTransform:  new System.Nullable<UnityEngine.Matrix4x4>() {HasValue = aTransform.HasValue}, aX:  aX, aY:  aY, aZ:  aZ);
        }
        public RecolorTree(System.Collections.Generic.List<UnityEngine.Vector3> aPoints, System.Collections.Generic.List<UnityEngine.Color> aColors, System.Nullable<UnityEngine.Matrix4x4> aTransform, bool aX = True, bool aY = True, bool aZ = True)
        {
            val_1 = new System.Object();
            this.Create(aPoints:  aPoints, aColors:  System.Collections.Generic.List<UnityEngine.Color> val_1 = aColors, aTransform:  new System.Nullable<UnityEngine.Matrix4x4>() {HasValue = aTransform.HasValue}, aX:  aX, aY:  aY, aZ:  aZ);
        }
        public Ferr.RecolorTree.TreePoint Get(UnityEngine.Vector3 aAt)
        {
            this.root.GetNearest(aSettings:  this.settings, aDepth:  0, aPt:  new UnityEngine.Vector3() {x = aAt.x, y = aAt.y, z = aAt.z}, aClosest: ref  0, aClosestDist: ref  0);
        }
        public void Recolor(ref UnityEngine.Mesh aMesh, System.Nullable<UnityEngine.Matrix4x4> aTransform)
        {
            UnityEngine.Mesh val_19 = aMesh;
            if(val_19 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3[] val_2 = aMesh.vertices;
            val_19;
            UnityEngine.Color[] val_18 = this.Recolor(aAt:  aMesh, aTransform:  new System.Nullable<UnityEngine.Matrix4x4>() {HasValue = aTransform.HasValue});
            aMesh.colors = 1231591264;
        }
        public void Recolor(UnityEngine.Vector3[] aPoints, ref UnityEngine.Color[] aColors, System.Nullable<UnityEngine.Matrix4x4> aTransform)
        {
            var val_1;
            var val_11;
            var val_12;
            var val_14;
            var val_15;
            val_11 = aPoints;
            if(aColors != (aColors + 12))
            {
                    UnityEngine.Debug.LogError(message:  -1610610143);
            }
            
            if(val_1 != false)
            {
                    if((-1610610143) < 1)
            {
                    return;
            }
            
                do
            {
                UnityEngine.Matrix4x4 val_2 = Value;
                val_12 = val_2.m13 + 88;
                mem2[0] = val_2.m02 + 8;
                mem2[0] = 0;
                float val_3 = val_2.m13 + 24;
                float val_4 = val_2.m13 + 24;
                var val_8 = val_2.m13 + 8;
                val_8 = val_8 + 20;
                val_14 = val_2.m32 + 8;
                var val_9 = val_2.m13 + 20;
                val_15 = val_2.m02 + 12;
                val_2.m22 = val_2.m22 + 1;
                var val_5 = (val_2.m13 + 16) + val_9;
                val_9 = val_9 + 16;
            }
            while(val_2.m22 < (val_2.m12 + 12));
            
                return;
            }
            
            if((-1610610143) < 1)
            {
                    return;
            }
            
            var val_10 = 16;
            do
            {
                val_15 = mem[aColors];
                val_15 = aColors;
                TreePoint val_6 = this.Get(aAt:  new UnityEngine.Vector3() {x = mem[aPoints[0x10] + (0)], y = mem[aPoints[0x10] + (4)], z = mem[aPoints[0x10] + (8)]});
                var val_7 = val_15 + val_10;
                val_10 = val_10 + 16;
                val_14 = 0 + 1;
            }
            while(val_14 < val_11);
        
        }
        public UnityEngine.Color[] Recolor(UnityEngine.Vector3[] aAt, System.Nullable<UnityEngine.Matrix4x4> aTransform)
        {
            var val_1;
            var val_10;
            var val_11;
            if(val_1 != false)
            {
                    if(536881823 < 1)
            {
                    return;
            }
            
                do
            {
                UnityEngine.Matrix4x4 val_2 = Value;
                val_10 = val_2.m13 + 88;
                mem2[0] = val_2.m12 + 8;
                mem2[0] = 0;
                float val_3 = val_2.m13 + 24;
                float val_4 = val_2.m13 + 24;
                var val_7 = val_2.m13 + 12;
                val_11 = val_7;
                val_7 = val_11 + 20;
                val_2.m12 = val_2.m12 + 12;
                val_2.m22 = val_2.m22 + 1;
                float val_5 = val_2.m32 + 8;
            }
            while(val_2.m22 < (val_2.m13 + 16 + 12));
            
                return;
            }
            
            if(536881823 < 1)
            {
                    return;
            }
            
            do
            {
                TreePoint val_6 = this.Get(aAt:  new UnityEngine.Vector3() {x = mem[aAt[0x10] + (0)], y = mem[aAt[0x10] + (4)], z = mem[aAt[0x10] + (8)]});
                val_10 = 0 + 1;
            }
            while(val_10 < (aAt + 12));
        
        }
        public System.Collections.Generic.List<UnityEngine.Color> Recolor(System.Collections.Generic.List<UnityEngine.Vector3> aAt, System.Nullable<UnityEngine.Matrix4x4> aTransform)
        {
            var val_2;
            System.Collections.Generic.List<UnityEngine.Vector3> val_11;
            var val_12;
            var val_13;
            var val_14;
            float val_15;
            val_11 = aAt;
            536877805 = new System.Collections.Generic.List<UnityEngine.Color>(capacity:  22975141);
            if(val_2 != false)
            {
                    if(536877805 < 1)
            {
                    return;
            }
            
                do
            {
                UnityEngine.Matrix4x4 val_3 = Value;
                val_13 = mem[val_3.m13 + 16];
                val_13 = val_3.m13 + 16;
                var val_9 = val_3.m13 + 16 + 8;
                val_9 = val_9 + val_3.m22;
                mem2[0] = (val_3.m13 + 16 + 8 + val_3.m22) + 24;
                mem2[0] = 0;
                float val_4 = val_3.m13 + 24;
                float val_5 = val_3.m13 + 24;
                val_11 = mem[val_3.m13 + 12 + 20];
                val_11 = val_3.m13 + 12 + 20;
                mem2[0] = val_3.m13 + 12 + 28;
                mem2[0] = val_3.m13 + 12 + 32;
                mem2[0] = -1073715421;
                val_14 = val_3.m02 + 1;
                val_15 = val_3.m22 + 12;
                float val_6 = val_3.m32 + 8;
                val_12 = val_3.m13 + 88;
            }
            while(val_14 < (val_3.m13 + 16 + 12));
            
                return;
            }
            
            if(536877805 < 1)
            {
                    return;
            }
            
            var val_11 = 0;
            var val_12 = 0;
            val_15 = 4.021045E-38f;
            do
            {
                if(536877805 <= val_12)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_10 = val_10 + val_11;
                var val_7 = val_10 + 16;
                TreePoint val_8 = this.Get(aAt:  new UnityEngine.Vector3() {x = mem[((0 + 0) + 16) + (0)], y = mem[((0 + 0) + 16) + (4)], z = mem[((0 + 0) + 16) + (8)]});
                val_1.set_Item(index:  0, value:  new UnityEngine.Color() {r = R7, g = R8, b = ???, a = mem[1152921510133905200]});
                val_11 = val_11;
                val_11 = val_11 + 12;
                val_12 = val_12 + 1;
            }
            while(val_12 < (aAt + 12));
        
        }
        public void Recolor(System.Collections.Generic.List<UnityEngine.Vector3> aPoints, ref System.Collections.Generic.List<UnityEngine.Color> aColors, System.Nullable<UnityEngine.Matrix4x4> aTransform)
        {
            var val_1;
            System.Collections.Generic.List<UnityEngine.Vector3> val_9;
            var val_10;
            float val_11;
            var val_12;
            var val_13;
            var val_14;
            val_9 = aPoints;
            if(val_1 == false)
            {
                goto label_1;
            }
            
            val_12 = 0;
            val_13 = 0;
            goto label_2;
            label_7:
            UnityEngine.Matrix4x4 val_2 = Value;
            val_9 = mem[val_2.m13 + 12];
            val_9 = val_2.m13 + 12;
            mem2[0] = val_2.m01;
            var val_8 = val_2.m13 + 12 + 8;
            mem2[0] = val_2.m22;
            val_8 = val_8 + val_2.m22;
            mem2[0] = (val_2.m13 + 12 + 8 + val_2.m22) + 24;
            mem2[0] = 0;
            float val_3 = val_2.m13 + 32;
            val_11 = val_2.m31;
            var val_4 = (val_2.m13 + 8) + 20;
            mem2[0] = val_2.m13 + 8 + 32;
            mem2[0] = -1073715519;
            float val_5 = val_2.m32 + 8;
            val_10 = val_2.m32 - 92;
            val_12 = (val_2.m13 + 28) + 12;
            val_13 = (val_2.m13 + 24) + 1;
            label_2:
            if(val_13 < (val_2.m13 + 12 + 12))
            {
                goto label_7;
            }
            
            return;
            label_1:
            val_14 = 0;
            val_12 = 0;
            goto label_9;
            label_14:
            val_10 = mem[aColors];
            val_10 = aColors;
            if(val_1 <= val_12)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + val_14;
            var val_6 = val_9 + 16;
            TreePoint val_7 = this.Get(aAt:  new UnityEngine.Vector3() {x = mem[((0 + val_14) + 16) + (0)], y = mem[((0 + val_14) + 16) + (4)], z = mem[((0 + val_14) + 16) + (8)]});
            val_11 = mem[1152921510134029416];
            val_10.Add(item:  new UnityEngine.Color() {r = mem[1152921510134029412], g = val_11, b = mem[1152921510134029420], a = mem[1152921510134029424]});
            val_9 = val_9;
            val_14 = 12;
            val_12 = 1;
            label_9:
            if(val_12 < (aPoints + 12))
            {
                goto label_14;
            }
        
        }
        public void DrawTree()
        {
            float val_3;
            float val_4;
            float val_5;
            536900719 = new RecolorTree.TreeSettings(aUseX:  true, aUseY:  true, aUseZ:  true);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.root.Draw(aSettings:  536900719, aDepth:  0, aPt:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_5});
        }
        private void Create(UnityEngine.Vector3[] aPoints, UnityEngine.Color[] aColors, System.Nullable<UnityEngine.Matrix4x4> aTransform, bool aX, bool aY, bool aZ)
        {
            var val_2;
            var val_15;
            var val_16;
            System.Collections.Generic.List<SingleRange> val_17;
            var val_18;
            var val_20;
            val_15 = aColors;
            val_16 = aPoints;
            if( != 1232517080)
            {
                    UnityEngine.Debug.LogError(message:  -1610610143);
            }
            
            val_17 = 536878649;
            val_18 = -1073710251;
            val_17 = new System.Collections.Generic.List<SingleRange>(capacity:  0);
            if(val_17 >= 1)
            {
                    val_20 = 0;
                do
            {
                if(val_2 != false)
            {
                    UnityEngine.Matrix4x4 val_3 = Value;
                float val_4 = val_3.m32 - 92;
                val_15 = val_3.m31;
                mem2[0] = 0;
                float val_5 = val_3.m13 + 48;
                mem2[0] = val_3.m22;
                float val_6 = val_3.m13 + 48;
            }
            
                mem2[0] = mem[(val_3.m13 + 48) + (8)];
                mem2[0] = mem[(val_3.m13 + 48) + (4)];
                mem2[0] = mem[(val_3.m13 + 48) + (0)];
                val_15 = (val_15 + (val_3.m02 << 4)) + 16;
                mem2[0] = 0;
                val_17 = mem[val_3.m13 + 24];
                val_17 = val_3.m13 + 24;
                val_18 = -1073710249;
                val_3.m12 = val_3.m12 + 12;
                val_3.m02 = val_3.m02 + 1;
                float val_8 = val_3.m32 + 8;
            }
            while(val_3.m02 < (val_3.m13 + 28 + 12));
            
            }
            
            float val_9 = val_3.m32 + 76;
            mem2[0] = 0;
            mem2[0] = 536900719;
            mem2[0] = 0;
            var val_10 = (val_3.m13 + 20 + 12) - 4;
            mem2[0] = 536900711;
            float val_11 = val_3.m32 - 28;
            var val_12 = ((val_3.m32 - 28) + (36)) + 4;
        }
        private void Create(System.Collections.Generic.List<UnityEngine.Vector3> aPoints, System.Collections.Generic.List<UnityEngine.Color> aColors, System.Nullable<UnityEngine.Matrix4x4> aTransform, bool aX, bool aY, bool aZ)
        {
            var val_2;
            var val_13;
            var val_14;
            System.Collections.Generic.List<SingleRange> val_15;
            var val_16;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            val_13 = aColors;
            val_14 = aPoints;
            if(22975145 != 1232711000)
            {
                    UnityEngine.Debug.LogError(message:  -1610610143);
            }
            
            val_15 = 536878649;
            val_16 = -1073710251;
            val_15 = new System.Collections.Generic.List<SingleRange>(capacity:  R6);
            if(val_15 >= 1)
            {
                    val_18 = 0;
                val_19 = 0;
                do
            {
                if(val_15 <= val_19)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_11 = val_11 + val_18;
                val_20 = mem[(0 + val_18) + 16];
                val_20 = (0 + val_18) + 16;
                val_21 = mem[(0 + val_18) + 20];
                val_21 = (0 + val_18) + 20;
                if(val_2 != false)
            {
                    UnityEngine.Matrix4x4 val_3 = Value;
                float val_4 = val_3.m32 - 92;
                mem2[0] = val_3.m13 + 36;
                mem2[0] = 0;
                val_13 = mem[val_3.m13 + 32];
                val_13 = val_3.m13 + 32;
                val_20 = mem[val_3.m13 + 48];
                val_20 = val_3.m13 + 48;
                val_21 = mem[val_3.m13 + 52];
                val_21 = val_3.m13 + 52;
                mem2[0] = val_3.m13 + 56;
            }
            
                mem2[0] = val_21;
                mem2[0] = val_20;
                var val_12 = val_3.m13 + 32 + 8;
                val_12 = val_12 + (val_3.m22 << 4);
                var val_5 = val_12 + 16;
                mem2[0] = 0;
                val_15 = mem[val_3.m13 + 24];
                val_15 = val_3.m13 + 24;
                val_16 = -1073710249;
                val_3.m02 = val_3.m02 + 12;
                val_3.m22 = val_3.m22 + 1;
                float val_6 = val_3.m32 + 8;
            }
            while(val_3.m22 < (val_3.m13 + 28 + 12));
            
            }
            
            float val_7 = val_3.m32 + 76;
            mem2[0] = 0;
            mem2[0] = 536900719;
            mem2[0] = 0;
            var val_8 = (val_3.m13 + 20 + 12) - 4;
            mem2[0] = 536900711;
            float val_9 = val_3.m32 - 28;
            var val_10 = ((val_3.m32 - 28) + (36)) + 4;
        }
        private static RecolorTree()
        {
            RecolorTree.SortX val_1 = 536900699;
            val_1 = new RecolorTree.SortX();
            mem2[0] = val_1;
            RecolorTree.SortY val_2 = 536900703;
            val_2 = new RecolorTree.SortY();
            mem2[0] = val_2;
            RecolorTree.SortZ val_3 = 536900707;
            val_3 = new RecolorTree.SortZ();
            mem2[0] = val_3;
        }
    
    }

}
