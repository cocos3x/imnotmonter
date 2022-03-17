using UnityEngine;

namespace WrappingRopeLibrary.Model
{
    [Serializable]
    public class WrapPoint
    {
        // Fields
        private UnityEngine.Vector3 origin;
        private UnityEngine.Vector3 localShift;
        private UnityEngine.Vector3 positionInWorldSpace;
        public UnityEngine.GameObject Parent;
        
        // Properties
        public UnityEngine.Vector3 Origin { get; set; }
        public UnityEngine.Vector3 LocalShift { get; set; }
        public UnityEngine.Vector3 PositionInWorldSpace { get; set; }
        
        // Methods
        public UnityEngine.Vector3 get_Origin()
        {
            this.origin = R1 + 16;
            this = R1 + 8;
            return new UnityEngine.Vector3();
        }
        public void set_Origin(UnityEngine.Vector3 value)
        {
        
        }
        public UnityEngine.Vector3 get_LocalShift()
        {
            this.origin = R1 + 28;
            this = R1 + 20;
            return new UnityEngine.Vector3();
        }
        public void set_LocalShift(UnityEngine.Vector3 value)
        {
        
        }
        public UnityEngine.Vector3 get_PositionInWorldSpace()
        {
            this.origin = R1 + 40;
            this = R1 + 32;
            return new UnityEngine.Vector3();
        }
        public void set_PositionInWorldSpace(UnityEngine.Vector3 value)
        {
        
        }
        public void SetPointInWorldSpace(UnityEngine.Transform transform, float wrapDistance)
        {
            float val_2;
            float val_5;
            float val_7;
            if(<0)
            {
                    R2 = 981668463;
            }
            
            UnityEngine.Quaternion val_1 = rotation;
            UnityEngine.Vector3 val_3 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 1.14364E-06f}, point:  new UnityEngine.Vector3() {x = val_2, y = this.localShift, z = ???});
            UnityEngine.Vector3 val_6 = normalized;
            R2 = R2 * val_5;
            UnityEngine.Vector3 val_9 = TransformPoint(position:  new UnityEngine.Vector3() {x = transform, y = this.origin, z = this.localShift});
            UnityEngine.Vector3 val_10 = val_5;
            float val_11 = val_7;
            val_10 = R2 + val_10;
            mem[1152921509801078392] = 0;
            val_11 = (R2 * val_7) + val_11;
            this.positionInWorldSpace = val_10;
            mem[1152921509801078388] = val_11;
        }
        public void SetPointInWorldSpace(float wrapDistance)
        {
            if(this.Parent == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = this.Parent.transform;
            this.SetPointInWorldSpace(transform:  this.Parent, wrapDistance:  wrapDistance);
        }
        public WrapPoint()
        {
        
        }
    
    }

}
