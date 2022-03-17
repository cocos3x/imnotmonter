using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class ObjectRotate : MonoBehaviour
    {
        // Fields
        public UnityEngine.Vector3 Rotation;
        private UnityEngine.Transform _transform;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.transform;
            this._transform = this;
        }
        private void LateUpdate()
        {
            mem[this.Rotation + (12)].Rotate(eulers:  new UnityEngine.Vector3() {x = mem[this.Rotation + (0)], y = mem[this.Rotation + (4)], z = mem[this.Rotation + (8)]});
        }
        public ObjectRotate()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        }
    
    }

}
