using UnityEngine;

namespace TMPro.Examples
{
    public class ObjectSpin : MonoBehaviour
    {
        // Fields
        public float SpinSpeed;
        public int RotationRange;
        private UnityEngine.Transform m_transform;
        private float m_time;
        private UnityEngine.Vector3 m_prevPOS;
        private UnityEngine.Vector3 m_initial_Rotation;
        private UnityEngine.Vector3 m_initial_Position;
        private UnityEngine.Color32 m_lightColor;
        private int frames;
        public TMPro.Examples.ObjectSpin.MotionType Motion;
        
        // Methods
        private void Awake()
        {
            float val_9;
            float val_10;
            float val_11;
            float val_12;
            UnityEngine.Transform val_1 = this.transform;
            this.m_transform = this;
            UnityEngine.Quaternion val_2 = rotation;
            UnityEngine.Vector3 val_3 = eulerAngles;
            UnityEngine.Vector3 val_4 = position;
            UnityEngine.Transform val_5 = this.m_transform.GetComponent<UnityEngine.Transform>();
            if(948141296 != 0)
            {
                    UnityEngine.Color val_7 = color;
            }
            else
            {
                    UnityEngine.Color val_8 = UnityEngine.Color.black;
            }
            
            UnityEngine.Color32 val_13 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_9, g = val_10, b = val_11, a = val_12});
            this.m_lightColor = val_13;
        }
        private void Update()
        {
            float val_3;
            UnityEngine.Transform val_9;
            float val_10;
            float val_11;
            if(this.Motion == 0)
            {
                goto label_0;
            }
            
            float val_1 = UnityEngine.Time.deltaTime;
            this.m_time = this.m_time;
            if(this.Motion != 1)
            {
                goto label_1;
            }
            
            val_9 = this.m_transform;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(x:  (float)this.RotationRange, y:  null, z:  null);
            val_9.rotation = new UnityEngine.Quaternion() {x = R4, y = R6, z = R7, w = val_3};
            return;
            label_0:
            float val_4 = UnityEngine.Time.deltaTime;
            this.m_transform.Rotate(xAngle:  this.SpinSpeed * 0, yAngle:  null, zAngle:  null);
            return;
            label_1:
            float val_9 = 0.95f;
            val_9 = this.m_time * val_9;
            float val_10 = 10f;
            val_10 = S8 + val_10;
            val_10 = S6 + 0f;
            val_9 = val_10;
            val_11 = this.m_initial_Position;
            this.m_transform.position = new UnityEngine.Vector3() {x = val_11, y = val_10, z = val_9};
            UnityEngine.Vector3 val_7 = position;
            this.frames = this.frames + 1;
        }
        public ObjectSpin()
        {
            this.SpinSpeed = 5f;
            this.RotationRange = 15;
        }
    
    }

}
