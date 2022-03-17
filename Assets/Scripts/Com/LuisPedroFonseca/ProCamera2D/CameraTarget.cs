using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    [Serializable]
    public class CameraTarget
    {
        // Fields
        public UnityEngine.Transform TargetTransform;
        public float TargetInfluenceH;
        public float TargetInfluenceV;
        public UnityEngine.Vector2 TargetOffset;
        private UnityEngine.Vector3 _targetPosition;
        
        // Properties
        set; }
        public UnityEngine.Vector3 TargetPosition { get; }
        
        // Methods
        public void set_TargetInfluence(float value)
        {
            this.TargetInfluenceH = ;
            this.TargetInfluenceV = ;
        }
        public UnityEngine.Vector3 get_TargetPosition()
        {
            if((R1 + 8) != 0)
            {
                    UnityEngine.Vector3 val_2 = position;
                var val_3 = R1 + 28;
                return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            }
            
            this.TargetTransform = R1 + 36;
            this = R1 + 28;
            return new UnityEngine.Vector3();
        }
        public CameraTarget()
        {
            this.TargetInfluenceH = 1f;
            this.TargetInfluenceV = 1f;
        }
    
    }

}
