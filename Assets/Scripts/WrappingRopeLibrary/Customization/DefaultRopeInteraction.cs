using UnityEngine;

namespace WrappingRopeLibrary.Customization
{
    public class DefaultRopeInteraction : MonoBehaviour, IRopeInteraction
    {
        // Fields
        private UnityEngine.Quaternion _prevRotation;
        private UnityEngine.Vector3 _prevPosition;
        
        // Methods
        private void Start()
        {
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Quaternion val_2 = rotation;
            UnityEngine.Transform val_3 = this.transform;
            UnityEngine.Vector3 val_4 = position;
        }
        private void Update()
        {
        
        }
        private void FixedUpdate()
        {
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = position;
            UnityEngine.Transform val_3 = this.transform;
            UnityEngine.Quaternion val_4 = rotation;
        }
        public UnityEngine.Vector3 GetPointVelocity(UnityEngine.Vector3 point)
        {
            float val_4;
            float val_5;
            float val_6;
            float val_7;
            var val_12;
            UnityEngine.Transform val_1 = point.x.transform;
            UnityEngine.Quaternion val_2 = rotation;
            float val_3 = point.x + 12;
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = 6.632832E-06f, y = mem[(point.x + 12) + (0)], z = mem[(point.x + 12) + (4)], w = mem[(point.x + 12) + (8)]});
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = 6.632832E-06f, y = val_4, z = val_5, w = val_6}, rhs:  new UnityEngine.Quaternion() {x = val_7});
            UnityEngine.Transform val_10 = point.x.transform;
            UnityEngine.Vector3 val_11 = position;
            float val_13 = val_6 - val_12;
            float val_14 = val_5 - point.z;
            float val_15 = val_4 - point.y;
            UnityEngine.Vector3 val_16 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 6.632832E-06f, y = val_4, z = val_5, w = val_6}, point:  new UnityEngine.Vector3() {x = val_7, y = val_15, z = val_14});
            val_15 = val_15 - val_4;
            val_14 = val_14 - val_5;
            val_13 = val_13 - val_6;
            UnityEngine.Transform val_17 = point.x.transform;
            UnityEngine.Vector3 val_18 = position;
            var val_21 = val_4;
            float val_22 = val_5;
            val_21 = val_15 + val_21;
            var val_23 = val_6;
            WrappingRopeLibrary.Customization.DefaultRopeInteraction val_24 = point.x + 28;
            val_14 = val_14 + val_22;
            val_13 = val_13 + val_23;
            float val_20 = UnityEngine.Time.fixedDeltaTime;
            val_22 = val_14 - (point.x + 32);
            val_23 = val_13 - (point.x + 36);
            uint val_25 = 0;
            val_24 = (val_21 - val_24) / val_25;
            val_22 = val_22 / val_25;
            val_25 = val_23 / val_25;
            this = val_24;
            mem[1152921509822381748] = val_22;
            mem[1152921509822381752] = val_25;
            return new UnityEngine.Vector3() {y = val_18.y, z = val_22};
        }
        public virtual void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position, UnityEngine.ForceMode mode)
        {
        
        }
        public DefaultRopeInteraction()
        {
        
        }
    
    }

}
