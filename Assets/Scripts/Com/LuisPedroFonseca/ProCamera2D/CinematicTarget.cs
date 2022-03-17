using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    [Serializable]
    public class CinematicTarget
    {
        // Fields
        public UnityEngine.Transform TargetTransform;
        public float EaseInDuration;
        public float HoldDuration;
        public float Zoom;
        public Com.LuisPedroFonseca.ProCamera2D.EaseType EaseType;
        public string SendMessageName;
        public string SendMessageParam;
        
        // Methods
        public CinematicTarget()
        {
            this.EaseInDuration = 1f;
            this.HoldDuration = 1f;
            this.Zoom = 1f;
            this.EaseType = 1;
        }
    
    }

}
