using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    [Serializable]
    public class ConstantShakePreset : ScriptableObject
    {
        // Fields
        public float Intensity;
        public System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.ConstantShakeLayer> Layers;
        
        // Methods
        public ConstantShakePreset()
        {
            this.Intensity = 0.3f;
        }
    
    }

}
