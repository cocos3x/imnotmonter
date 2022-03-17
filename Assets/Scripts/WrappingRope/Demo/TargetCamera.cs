using UnityEngine;

namespace WrappingRope.Demo
{
    public class TargetCamera : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform target;
        
        // Methods
        private void Update()
        {
            UnityEngine.Transform val_1 = this.transform;
            this.target.LookAt(target:  this.target);
        }
        public TargetCamera()
        {
        
        }
    
    }

}
