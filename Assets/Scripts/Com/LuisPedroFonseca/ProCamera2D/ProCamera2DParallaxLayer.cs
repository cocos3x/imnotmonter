using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    [Serializable]
    public class ProCamera2DParallaxLayer
    {
        // Fields
        public UnityEngine.Camera ParallaxCamera;
        public float Speed;
        public float SpeedX;
        public float SpeedY;
        public UnityEngine.LayerMask LayerMask;
        public UnityEngine.Transform CameraTransform;
        
        // Methods
        public ProCamera2DParallaxLayer()
        {
            this.Speed = 1f;
            this.SpeedX = 1f;
            this.SpeedY = 1f;
        }
    
    }

}
