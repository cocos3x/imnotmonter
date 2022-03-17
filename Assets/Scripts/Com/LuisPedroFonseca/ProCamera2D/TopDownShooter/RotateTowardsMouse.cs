using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class RotateTowardsMouse : MonoBehaviour
    {
        // Fields
        public float Ease;
        private UnityEngine.Transform _transform;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.transform;
            this._transform = this;
        }
        private void Update()
        {
            float val_2;
            float val_3;
            float val_6;
            float val_9;
            UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
            UnityEngine.Camera val_4 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_5 = localPosition;
            UnityEngine.Vector3 val_7 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_2, z = val_3});
            var val_12 = val_2;
            var val_13 = val_3;
            val_12 = val_2 - val_12;
            val_13 = val_3 - val_13;
            UnityEngine.Quaternion val_8 = rotation;
            float val_14 = -57.29578f;
            val_14 = val_13 * val_14;
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Euler(x:  val_14, y:  val_8.y, z:  val_8.z);
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = 15.70095f, y = R6, z = R7, w = SL}, b:  new UnityEngine.Quaternion() {x = val_9}, t:  this.Ease);
            this._transform.rotation = new UnityEngine.Quaternion() {x = val_2, y = val_3, z = val_6, w = val_9};
        }
        public RotateTowardsMouse()
        {
            this.Ease = 0.15f;
        }
    
    }

}
