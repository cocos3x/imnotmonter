using UnityEngine;

namespace WrappingRopeLibrary.Utils
{
    public class Triangulator
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.Vector2> _rawPoints;
        private System.Collections.Generic.List<UnityEngine.Vector3> m_TriPointList;
        private int Pointcount;
        private WrappingRopeLibrary.Utils.Triangulator.PolyPoint[] PolyPointList;
        
        // Methods
        public System.Collections.Generic.List<UnityEngine.Vector3> GetTriangulationIndexes(System.Collections.Generic.List<UnityEngine.Vector2> rawPoints)
        {
            this._rawPoints = rawPoints;
            int val_2 = mem[rawPoints + 12];
            this.Pointcount = val_2;
            val_2 = val_2 + 1;
            this.PolyPointList = 536882729;
            536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.m_TriPointList = 536878517;
            this.FillLists();
            this.Triangulate();
        }
        private void FillLists()
        {
            PolyPoint[] val_5;
            var val_6;
            PolyPoint[] val_9;
            PolyPoint val_10;
            this.PolyPointList[0] = 1;
            this.PolyPointList[0] = 0;
            this.PolyPointList[0] = 0;
            this.PolyPointList[0] = 0;
            this.PolyPointList[0] = 0;
            this.PolyPointList[0] = 0;
            PolyPoint val_8 = 0;
            this.PolyPointList[0] = val_8;
            val_5 = this.PolyPointList;
            val_6 = 0;
            if(this.Pointcount < 1)
            {
                goto label_16;
            }
            
            var val_10 = 68;
            label_54:
            val_8 = val_8 + 1;
            PolyPoint[] val_1 = val_5[val_10] - 12;
            val_5[val_10] = val_5[val_10] - 24;
            if(val_8 != 0)
            {
                    mem2[0] = val_8;
            }
            else
            {
                    this.PolyPointList[1] = this.Pointcount;
            }
            
            int val_9 = this.Pointcount;
            val_9 = val_9 + 1;
            mem2[0] = val_9;
            if((this.isReflective(P:  val_8)) == false)
            {
                goto label_28;
            }
            
            mem2[0] = 0;
            if(0 == 1)
            {
                goto label_30;
            }
            
            goto label_32;
            label_28:
            mem2[0] = 0;
            mem2[0] = 0;
            this.PolyPointList[2] = 1;
            mem2[0] = 0;
            if(0 == 1)
            {
                goto label_40;
            }
            
            goto label_42;
            label_30:
            label_32:
            mem2[0] = val_8;
            mem2[0] = 0;
            mem2[0] = 0;
            val_9 = this.PolyPointList;
            if(this.PolyPointList[val_10] > val_8)
            {
                goto label_50;
            }
            
            goto label_50;
            label_40:
            label_42:
            mem2[0] = val_8;
            val_9 = this.PolyPointList;
            label_50:
            val_10 = val_10 + 28;
            mem2[0] = 0;
            val_5 = this.PolyPointList;
            val_6 = val_9[val_10] >> 5;
            if((val_8 + 2) <= this.Pointcount)
            {
                goto label_54;
            }
            
            label_16:
            val_10 = val_5[0];
            goto label_57;
            label_61:
            if((this.isCleanEar(Ear:  val_10)) != true)
            {
                    this.RemoveEar(Ear:  val_10);
            }
            
            val_5 = this.PolyPointList;
            val_10 = val_5[((val_10 << 3) - val_10) << 2];
            label_57:
            if(val_10 != 1)
            {
                goto label_61;
            }
        
        }
        private void Triangulate()
        {
            goto label_19;
            label_22:
            var val_1 = 0 - (-2147483648);
            PolyPoint val_9 = this.PolyPointList[val_1 << 2];
            PolyPoint val_10 = this.PolyPointList[val_1 << 2];
            this.m_TriPointList.Add(item:  new UnityEngine.Vector3() {x = (float)val_9, y = -2.147484E+09f, z = (float)val_10});
            this.RemoveEar(Ear:  -2147483648);
            this.RemoveP(P:  -2147483648);
            if((this.isReflective(P:  val_9)) == true)
            {
                goto label_12;
            }
            
            PolyPoint val_11 = this.PolyPointList[((val_9 << 3) - val_9) << 2];
            if((this.isCleanEar(Ear:  val_9)) == false)
            {
                goto label_10;
            }
            
            if(val_11 != 0)
            {
                goto label_12;
            }
            
            this.AddEar(Ear:  val_9);
            goto label_12;
            label_10:
            if(val_11 != 0)
            {
                    val_11 = this;
                this.RemoveEar(Ear:  0 = val_9);
            }
            
            label_12:
            if((this.isReflective(P:  val_10)) == true)
            {
                goto label_19;
            }
            
            PolyPoint val_12 = this.PolyPointList[((val_10 << 3) - val_10) << 2];
            if((this.isCleanEar(Ear:  val_10)) == false)
            {
                goto label_16;
            }
            
            if(val_12 != 0)
            {
                goto label_19;
            }
            
            this.AddEar(Ear:  val_10);
            goto label_19;
            label_16:
            if(val_12 != 0)
            {
                    this.RemoveEar(Ear:  val_10);
            }
            
            label_19:
            if(this.Pointcount > 3)
            {
                goto label_22;
            }
            
            PolyPoint val_13 = this.PolyPointList[0];
            PolyPoint val_8 = (val_13 << 3) - val_13;
            this.m_TriPointList.Add(item:  new UnityEngine.Vector3() {x = (float)this.PolyPointList[val_8 << 2], y = (float)val_13, z = (float)this.PolyPointList[val_8 << 2]});
        }
        private bool isCleanEar(int Ear)
        {
            var val_11;
            var val_12;
            PolyPoint val_13;
            var val_14;
            PolyPoint[] val_11 = this.PolyPointList;
            int val_1 = (Ear << 3) - Ear;
            val_11 = (val_11[val_1 << 2]) - 1;
            if((val_11[val_1 << 2]) <= val_11)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + (val_11 << 3);
            val_11 = mem[(0 + ((this.PolyPointList[(((Ear) << 3 - Ear)) << 2][0] - 1)) << 3) + 20];
            val_11 = (0 + ((this.PolyPointList[(((Ear) << 3 - Ear)) << 2][0] - 1)) << 3) + 20;
            int val_2 = Ear - 1;
            if(((0 + ((this.PolyPointList[(((Ear) << 3 - Ear)) << 2][0] - 1)) << 3) + 16) <= val_2)
            {
                    var val_13 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = val_13 + (val_2 << 3);
            var val_19 = (0 + ((Ear - 1)) << 3) + 16;
            var val_17 = (0 + ((Ear - 1)) << 3) + 20;
            PolyPoint val_14 = this.PolyPointList[val_1 << 2];
            val_14 = val_14 - 1;
            if((this.PolyPointList[val_1 << 2]) <= val_14)
            {
                    var val_15 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_15 = val_15 + (val_14 << 3);
            val_12 = mem[(0 + ((this.PolyPointList[(((Ear) << 3 - Ear)) << 2][0] - 1)) << 3) + 16];
            val_12 = (0 + ((this.PolyPointList[(((Ear) << 3 - Ear)) << 2][0] - 1)) << 3) + 16;
            if(val_15 <= val_2)
            {
                    var val_16 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_16 = val_16 + (val_2 << 3);
            var val_20 = (0 + ((Ear - 1)) << 3) + 16;
            var val_18 = (0 + ((Ear - 1)) << 3) + 20;
            val_13 = this.PolyPointList[0];
            val_14 = 1;
            if(val_13 == 1)
            {
                    return (bool)val_14;
            }
            
            var val_21 = val_11;
            val_17 = val_21 - val_17;
            val_18 = ((0 + ((this.PolyPointList[(((Ear) << 3 - Ear)) << 2][0] - 1)) << 3) + 20) - val_18;
            val_19 = ((0 + ((this.PolyPointList[(((Ear) << 3 - Ear)) << 2][0] - 1)) << 3) + 16) - val_19;
            val_20 = val_12 - val_20;
            float val_3 = val_17 * val_17;
            float val_4 = val_18 * val_18;
            float val_5 = val_17 * val_18;
            val_21 = val_3 * val_4;
            float val_6 = 1f / val_21;
            label_24:
            val_11 = val_13 - 1;
            if(((0 + ((this.PolyPointList[(((Ear) << 3 - Ear)) << 2][0] - 1)) << 3) + 16) <= val_11)
            {
                    var val_22 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_22 = val_22 + (val_11 << 3);
            val_12 = mem[(0 + ((this.PolyPointList[0] - 1)) << 3) + 16];
            val_12 = (0 + ((this.PolyPointList[0] - 1)) << 3) + 16;
            if(val_22 <= val_2)
            {
                    var val_23 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_23 = val_23 + (val_2 << 3);
            var val_24 = (0 + ((Ear - 1)) << 3) + 20;
            var val_25 = (0 + ((Ear - 1)) << 3) + 16;
            val_24 = Ear - val_24;
            val_25 = val_12 - val_25;
            float val_7 = val_18 * val_24;
            val_24 = val_17 * val_24;
            float val_8 = val_3 * val_7;
            val_8 = val_6 * val_8;
            if(val_22 > val_2)
            {
                    val_24 = val_4 * val_24;
            }
            
            if(val_22 > val_2)
            {
                    val_7 = val_6 * val_24;
            }
            
            if(val_22 <= val_2)
            {
                goto label_20;
            }
            
            val_7 = val_7 + val_8;
            if(val_22 < 0)
            {
                goto label_21;
            }
            
            label_20:
            val_13 = this.PolyPointList[((val_13 << 3) - val_13) << 2];
            if(val_13 != 1)
            {
                goto label_24;
            }
            
            val_14 = 1;
            return (bool)val_14;
            label_21:
            val_14 = 0;
            return (bool)val_14;
        }
        private bool isReflective(int P)
        {
            int val_1 = (P << 3) - P;
            PolyPoint val_5 = this.PolyPointList[val_1 << 2];
            val_5 = val_5 - 1;
            if((this.PolyPointList[val_1 << 2]) <= val_5)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (val_5 << 3);
            int val_2 = P - 1;
            if(((0 + ((this.PolyPointList[(((P) << 3 - P)) << 2][0] - 1)) << 3) + 16) <= val_2)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + (val_2 << 3);
            float val_10 = (0 + ((P - 1)) << 3) + 16;
            float val_9 = (0 + ((P - 1)) << 3) + 20;
            PolyPoint val_8 = this.PolyPointList[val_1 << 2];
            val_8 = val_8 - 1;
            if(((0 + ((this.PolyPointList[(((P) << 3 - P)) << 2][0] - 1)) << 3) + 16) <= val_8)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = 0 - val_9;
            val_10 = ((0 + ((this.PolyPointList[(((P) << 3 - P)) << 2][0] - 1)) << 3) + 16) - val_10;
            val_11 = val_11 + (val_8 << 3);
            if(val_11 <= val_2)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            int val_14 = P;
            val_12 = val_12 + (val_2 << 3);
            float val_13 = (0 + ((P - 1)) << 3) + 16;
            val_13 = ((0 + ((this.PolyPointList[(((P) << 3 - P)) << 2][0] - 1)) << 3) + 16) - val_13;
            val_14 = val_14 - ((0 + ((P - 1)) << 3) + 20);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 4.73139E-07f, y = val_10, z = val_9}, rhs:  new UnityEngine.Vector3() {x = 0f, y = val_13, z = val_14});
            if(val_11 < 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        private void RemoveEar(int Ear)
        {
            int val_1 = (Ear << 3) - Ear;
            PolyPoint val_4 = this.PolyPointList[val_1 << 2];
            PolyPoint val_5 = this.PolyPointList[val_1 << 2];
            this.PolyPointList[val_1 << 2] = 0;
            if(val_4 != 1)
            {
                
            }
            else
            {
                
            }
            
            mem2[0] = val_5;
            if(val_5 == 1)
            {
                    return;
            }
            
            this.PolyPointList[((val_5 << 3) - val_5) << 2] = val_4;
        }
        private void AddEar(int Ear)
        {
            PolyPoint val_3 = this.PolyPointList[0];
            this.PolyPointList[0] = Ear;
            int val_1 = (Ear << 3) - Ear;
            this.PolyPointList[val_1 << 2] = 0;
            this.PolyPointList[val_1 << 2] = val_3;
            this.PolyPointList[val_1 << 2] = 1;
            if(val_3 == 1)
            {
                    return;
            }
            
            this.PolyPointList[((val_3 << 3) - val_3) << 2] = Ear;
        }
        private void RemoverReflective(int P)
        {
            int val_1 = (P << 3) - P;
            PolyPoint val_4 = this.PolyPointList[val_1 << 2];
            PolyPoint val_5 = this.PolyPointList[val_1 << 2];
            if(val_4 != 1)
            {
                
            }
            else
            {
                
            }
            
            mem2[0] = val_5;
            if(val_5 == 1)
            {
                    return;
            }
            
            this.PolyPointList[((val_5 << 3) - val_5) << 2] = val_4;
        }
        private void AddReflective(int P)
        {
            PolyPoint val_3 = this.PolyPointList[0];
            this.PolyPointList[0] = P;
            int val_1 = (P << 3) - P;
            this.PolyPointList[val_1 << 2] = 0;
            this.PolyPointList[val_1 << 2] = val_3;
            if(val_3 == 1)
            {
                    return;
            }
            
            this.PolyPointList[((val_3 << 3) - val_3) << 2] = P;
        }
        private void RemoveP(int P)
        {
            int val_1 = (P << 3) - P;
            PolyPoint val_3 = this.PolyPointList[val_1 << 2];
            PolyPoint val_4 = this.PolyPointList[val_1 << 2];
            this.PolyPointList[val_1 << 2] = (val_4 << 3) - val_4;
            this.PolyPointList[(this.PolyPointList[val_1 << 2]) << 2] = val_3;
            this.PolyPointList[((val_3 << 3) - val_3) << 2] = val_4;
            if(this.PolyPointList[0] == P)
            {
                    this.PolyPointList[0] = val_3;
            }
            
            int val_6 = this.Pointcount;
            val_6 = val_6 - 1;
            this.Pointcount = val_6;
        }
        public Triangulator()
        {
        
        }
    
    }

}
