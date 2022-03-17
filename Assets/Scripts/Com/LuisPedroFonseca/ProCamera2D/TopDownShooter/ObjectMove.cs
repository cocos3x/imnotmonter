using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class ObjectMove : MonoBehaviour
    {
        // Fields
        public float Amplitude;
        public float Frequency;
        private UnityEngine.Transform _transform;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.transform;
            this._transform = this;
        }
        private void LateUpdate()
        {
            float val_2;
            float val_3;
            float val_5;
            UnityEngine.Vector3 val_1 = position;
            float val_6 = UnityEngine.Time.time;
            uint val_11 = 0;
            val_11 = (this.Frequency * 6.283185f) * val_11;
            float val_7 = UnityEngine.Time.time;
            float val_8 = UnityEngine.Time.deltaTime;
            uint val_12 = 0;
            val_12 = 0 - val_12;
            val_12 = (this.Frequency * 6.283185f) * val_12;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
            var val_13 = val_11;
            val_13 = val_13 - val_12;
            val_13 = this.Amplitude * val_13;
            this._transform.position = new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_5};
        }
        public ObjectMove()
        {
            this.Amplitude = 1f;
            this.Frequency = 1f;
        }
    
    }

}
