using UnityEngine;

namespace Ferr
{
    [Serializable]
    public class Path2D<T> : Path2D
    {
        // Fields
        protected System.Collections.Generic.List<T> _data;
        
        // Methods
        public Path2D<T>()
        {
            mem[1152921510152683320] = __RuntimeMethodHiddenParam + 12 + 96;
        }
        public Path2D<T>(System.Collections.Generic.List<UnityEngine.Vector2> aPoints)
        {
            var val_1 = __RuntimeMethodHiddenParam + 12 + 96;
            mem[1152921510152799416] = val_1;
            if(1152921510152799416 < 1)
            {
                    return;
            }
            
            var val_1 = 0;
            do
            {
                val_1 = mem[1152921510152799416];
                val_1 = val_1 + 1;
            }
            while(val_1 < val_1);
        
        }
        public Path2D<T>(System.Collections.Generic.List<UnityEngine.Vector2> aPoints, System.Collections.Generic.List<T> aData)
        {
            mem[1152921510152923704] = aData;
        }
        public Path2D<T>(Ferr.Path2D<T> aOther)
        {
            Ferr.Path2D<T> val_1 = aOther;
            val_1 = new Ferr.Path2D();
            if(val_1 != 0)
            {
                    mem[1152921510153047968] = val_1;
            }
            else
            {
                    mem[1152921510153047968] = 3;
            }
            
            mem[1152921510153047992] = __RuntimeMethodHiddenParam + 12 + 96;
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(collection:  __RuntimeMethodHiddenParam + 12 + 96);
            mem[1152921510153047960] = 536878507;
            536878163 = new System.Collections.Generic.List<Point>(collection:  __RuntimeMethodHiddenParam + 12 + 96);
            mem[1152921510153047964] = 536878163;
            mem[1152921510153047972] = 1152921510153047964;
        }
        public int Add(UnityEngine.Vector2 aPt, T aData, Ferr.PointControl aControl)
        {
            536891893 = new Ferr.PointControl(aCopy:  aControl);
            return (int)this.Add(aPt:  new UnityEngine.Vector2() {x = aPt.x, y = aPt.y}, aControls:  536891893);
        }
        public int Add(UnityEngine.Vector2 aPt, T aData, Ferr.PointType aType = 2, float aRadius = 1, UnityEngine.Vector2 aControlPointPrev, UnityEngine.Vector2 aControlPointNext)
        {
            return (int)this.Add(aPt:  new UnityEngine.Vector2() {x = aPt.x, y = aPt.y}, aType:  aType, aRadius:  aRadius, aControlPointPrev:  new UnityEngine.Vector2() {x = aControlPointPrev.x, y = aControlPointPrev.y}, aControlPointNext:  new UnityEngine.Vector2() {x = aControlPointNext.x, y = aControlPointNext.y});
        }
        public override int Add(UnityEngine.Vector2 aPt, Ferr.PointType aType = 2, float aRadius = 1, UnityEngine.Vector2 aControlPointPrev, UnityEngine.Vector2 aControlPointNext)
        {
            return (int)this.Add(aPt:  new UnityEngine.Vector2() {x = aPt.x, y = aPt.y}, aType:  aType, aRadius:  aRadius, aControlPointPrev:  new UnityEngine.Vector2() {x = aControlPointPrev.x, y = aControlPointPrev.y}, aControlPointNext:  new UnityEngine.Vector2() {x = aControlPointNext.x, y = aControlPointNext.y});
        }
        public void Insert(int aIndex, UnityEngine.Vector2 aPt, T aData, Ferr.PointControl aControl)
        {
            if(R4 == 0)
            {
                    aData.scale = aData.scale;
            }
            
            this.Insert(aRawIndex:  aIndex, aPt:  new UnityEngine.Vector2() {x = aPt.x, y = aPt.y}, aControls:  aControl);
        }
        public void Insert(int aIndex, UnityEngine.Vector2 aPt, T aData, Ferr.PointType aType = 2, float aRadius = 1, UnityEngine.Vector2 aControlPointPrev, UnityEngine.Vector2 aControlPointNext)
        {
            if(R4 == 0)
            {
                    aData.scale = aData.scale;
            }
            
            this.Insert(aRawIndex:  aIndex, aPt:  new UnityEngine.Vector2() {x = aPt.x, y = aPt.y}, aType:  aType, aRadius:  aRadius, aControlPointPrev:  new UnityEngine.Vector2() {x = aControlPointPrev.x, y = aControlPointPrev.y}, aControlPointNext:  new UnityEngine.Vector2() {x = aControlPointNext.x, y = aControlPointNext.y});
        }
        public override void Insert(int aIndex, UnityEngine.Vector2 aPt, Ferr.PointType aType = 2, float aRadius = 1, UnityEngine.Vector2 aControlPointPrev, UnityEngine.Vector2 aControlPointNext)
        {
            this.Insert(aRawIndex:  aIndex, aPt:  new UnityEngine.Vector2() {x = aPt.x, y = aPt.y}, aType:  aType, aRadius:  aRadius, aControlPointPrev:  new UnityEngine.Vector2() {x = aControlPointPrev.x, y = aControlPointPrev.y}, aControlPointNext:  new UnityEngine.Vector2() {x = aControlPointNext.x, y = aControlPointNext.y});
        }
        public override void RemoveAt(int aIndex)
        {
            this.RemoveAt(aRawIndex:  aIndex);
        }
        public override void Clear()
        {
            this.Clear();
        }
        public void SetData(int aIndex, T aData)
        {
            this.SetDirty();
        }
        public T GetData(int aRawIndex)
        {
            Ferr.Path2D<T> val_1;
            int val_2;
            mem[1152921510154221208] = val_2;
            this = val_1;
            return new Ferr2D_PointData() {directionOverride = val_2, cutOverrides = aRawIndex + 40, scale = __RuntimeMethodHiddenParam};
        }
        public T GetData(int aRawIndex, float aPercent)
        {
            Ferr.Path2D<T> val_5;
            int val_6;
            var val_16;
            System.Collections.Generic.List<System.Int32> val_17;
            float val_18;
            val_16 = mem[aRawIndex + 40];
            val_16 = aRawIndex + 40;
            val_17 = val_16;
            val_18 = __RuntimeMethodHiddenParam;
            mem[1152921510154333208] = val_6;
            this = val_5;
            return new Ferr2D_PointData() {directionOverride = val_6};
        }
        public T GetDataAtDistance(float aDist)
        {
            var val_6;
            float val_10;
            var val_11;
            System.Collections.Generic.List<System.Int32> val_12;
            float val_13;
            int val_14;
            System.Collections.Generic.List<System.Int32> val_18;
            var val_19;
            int val_20;
            var val_21;
            int val_22;
            Ferr.Path2D<T> val_23;
            var val_24;
            int val_25;
            val_18 = R2;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = R3 + 12 + 96 + 52});
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = R3 + 12 + 96 + 56});
            if((R3 + 12 + 96 + 52) == 0)
            {
                goto label_4;
            }
            
            val_19 = 0;
            Ferr.PathDistanceMask val_3 = __RuntimeMethodHiddenParam.DistanceMask;
            if((__RuntimeMethodHiddenParam + 16) != 0)
            {
                    __RuntimeMethodHiddenParam + 16 = 1;
            }
            
            Ferr.PathDMPoint val_4 = GetDataAtDistance(aDistance:  aDist, aWrap:  __RuntimeMethodHiddenParam);
            int val_9 = Ferr.PathUtil.WrapIndex(aIndex:  val_6 + 1, aCount:  __RuntimeMethodHiddenParam.Count, aClosed:  __RuntimeMethodHiddenParam + 16);
            val_6 = val_11;
            val_11 = val_6;
            val_10 = val_10;
            val_20 = R3 + 12 + 96 + 44;
            val_18 = val_12;
            val_21 = 536886815;
            if((R3 + 12 + 96 + 44 + 32) == mem[536886847])
            {
                goto label_11;
            }
            
            val_22 = 0;
            goto label_12;
            label_4:
            val_19 = 0;
            Ferr.PathDistanceMask val_15 = __RuntimeMethodHiddenParam.DistanceMask;
            if((__RuntimeMethodHiddenParam + 16) != 0)
            {
                    __RuntimeMethodHiddenParam + 16 = 1;
            }
            
            Ferr.PathDMPoint val_16 = val_10.GetDataAtDistance(aDistance:  aDist, aWrap:  __RuntimeMethodHiddenParam);
            val_21 = val_6;
            val_23 = __RuntimeMethodHiddenParam + 40;
            val_24 = val_21;
            val_25 = val_6;
            mem[1152921510154445208] = val_25;
            this = val_10;
            return new Ferr2D_PointData() {directionOverride = val_25, cutOverrides = 1252630928, scale = val_17.scale};
            label_11:
            Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            val_22 = val_20;
            label_12:
            Ferr2D_PointData val_17 = Lerp(aWith:  new Ferr2D_PointData() {directionOverride = val_22, cutOverrides = val_18, scale = val_13}, aLerp:  aDist);
            val_23 = this;
            val_25 = val_14;
            mem[1152921510154445208] = val_25;
            this = val_12;
            return new Ferr2D_PointData() {directionOverride = val_25, cutOverrides = 1252630928, scale = val_17.scale};
        }
        public System.Collections.Generic.List<T> GetData()
        {
        
        }
        public System.Collections.Generic.List<T> GetDataCopy()
        {
            if((__RuntimeMethodHiddenParam + 12 + 96 + 186) != 1)
            {
                    return;
            }
        
        }
        public void GetSubPathRaw(int aStart, int aLength, out System.Collections.Generic.List<UnityEngine.Vector2> aPath, out System.Collections.Generic.List<T> aData)
        {
            System.Collections.Generic.List<T> val_1 = static_value_015E98F1.GetRange(index:  aStart, count:  aLength);
            aPath = 22976753;
            aData = 1152921510154821296;
        }
        public Ferr.Path2D<T> GetSubPath(int aStart, int aLength)
        {
            var val_2;
            var val_4;
            int val_5;
            var val_6;
            var val_7;
            val_4 = this;
            val_5 = aStart;
            val_6 = 22976754;
            bool val_3 = static_value_015E98FE;
            aStart = aLength + val_5;
            val_3 = aStart - val_3;
            if(val_3 > 0)
            {
                    aLength = aLength - val_3;
            }
            
            System.Collections.Generic.List<T> val_1 = static_value_015E98F2.GetRange(index:  val_5, count:  aLength);
            val_7 = val_6;
            var val_4 = 0;
            var val_5 = 16;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            static_value_015E98F2.Add(item:  new UnityEngine.Vector2() {x = static_value_015E98FA + 16, y = static_value_015E98FA + 16 + 4});
            val_5 = val_2;
            val_4 = val_4 + 1;
            val_5 = val_5 + 8;
            mem2[0] = __RuntimeMethodHiddenParam;
        }
        public override void ReverseSelf()
        {
            this.ReverseSelf();
        }
    
    }

}
