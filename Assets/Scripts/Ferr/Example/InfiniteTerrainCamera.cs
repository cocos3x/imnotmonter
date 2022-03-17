using UnityEngine;

namespace Ferr.Example
{
    public class InfiniteTerrainCamera : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform _targetObject;
        private float _maxXOffset;
        private float _maxSpeed;
        private float _maxDistance;
        private float _screenWidth;
        private float _xPosition;
        
        // Methods
        private void Start()
        {
            float val_3;
            float val_8;
            UnityEngine.Transform val_1 = this._targetObject.transform;
            UnityEngine.Vector3 val_2 = position;
            UnityEngine.Transform val_4 = this._targetObject.transform;
            UnityEngine.Vector3 val_5 = position;
            float val_9 = val_3;
            val_9 = val_3 - val_9;
            float val_6 = val_9 & (~2147483648);
            UnityEngine.Vector2 val_7 = Ferr.Example.InfiniteTerrainCamera.GetViewSizeAtDistance(aDist:  val_9);
            this._screenWidth = val_8;
        }
        private void FixedUpdate()
        {
            float val_3;
            float val_8;
            float val_19;
            float val_23;
            UnityEngine.Transform val_1 = this._targetObject.transform;
            UnityEngine.Vector3 val_2 = position;
            val_23 = this._xPosition;
            if(this._targetObject < 0)
            {
                    UnityEngine.Transform val_4 = this._targetObject.transform;
                this._targetObject.position = new UnityEngine.Vector3() {x = 0f, y = 9f, z = 0f};
                UnityEngine.Transform val_5 = this._targetObject.transform;
                UnityEngine.Transform val_6 = this.transform;
                UnityEngine.Vector3 val_7 = position;
                this.position = new UnityEngine.Vector3() {x = 0f, y = 9f, z = val_8};
                val_23 = 0f;
                this._xPosition = 0f;
            }
            
            float val_22 = this._maxDistance;
            val_22 = val_23 / val_22;
            float val_9 = UnityEngine.Mathf.Min(a:  val_22, b:  val_7.y);
            float val_10 = 1065353216 * this._maxSpeed;
            float val_11 = UnityEngine.Time.deltaTime;
            this._xPosition = val_23;
            UnityEngine.Transform val_12 = this._targetObject.transform;
            UnityEngine.Vector3 val_13 = position;
            float val_23 = this._maxXOffset;
            val_23 = this._xPosition + val_23;
            if(this._targetObject > 0)
            {
                    UnityEngine.Transform val_14 = this._targetObject.transform;
                UnityEngine.Vector3 val_15 = position;
                float val_24 = val_3;
                val_24 = val_24 - this._maxXOffset;
                this._xPosition = val_24;
            }
            
            UnityEngine.Transform val_16 = this._targetObject.transform;
            UnityEngine.Transform val_17 = this._targetObject.transform;
            UnityEngine.Vector3 val_18 = position;
            UnityEngine.Transform val_20 = this.transform;
            UnityEngine.Vector3 val_21 = position;
            this.position = new UnityEngine.Vector3() {x = this._xPosition, y = val_19, z = val_8};
        }
        private float GetSpeed()
        {
            float val_2 = this._maxDistance;
            val_2 = this._xPosition / val_2;
            float val_1 = UnityEngine.Mathf.Min(a:  val_2, b:  null);
            uint val_3 = 1065353216;
            val_3 = val_3 * this._maxSpeed;
            return (float)val_3;
        }
        public static UnityEngine.Vector2 GetViewSizeAtDistance(float aDist)
        {
            float val_7 = R1;
            UnityEngine.Camera val_1 = UnityEngine.Camera.main;
            float val_2 = 0.fieldOfView;
            float val_6 = 0.5f;
            val_6 = 0 * val_6;
            val_6 = val_6 * 0.01745329f;
            val_7 = (val_7 + val_7) * val_6;
            UnityEngine.Camera val_4 = UnityEngine.Camera.main;
            float val_5 = 0.aspect;
            uint val_8 = 0;
            val_8 = val_7 * val_8;
            mem2[0] = val_8;
            mem[4] = val_7;
            return new UnityEngine.Vector2();
        }
        public InfiniteTerrainCamera()
        {
            this._maxSpeed = 2f;
            this._maxDistance = 100f;
        }
    
    }

}
