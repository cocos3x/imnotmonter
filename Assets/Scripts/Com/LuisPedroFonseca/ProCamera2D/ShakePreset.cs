using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    [Serializable]
    public class ShakePreset : ScriptableObject
    {
        // Fields
        public UnityEngine.Vector3 Strength;
        public float Duration;
        public int Vibrato;
        public float Randomness;
        public float Smoothness;
        public bool UseRandomInitialAngle;
        public float InitialAngle;
        public UnityEngine.Vector3 Rotation;
        public bool IgnoreTimeScale;
        
        // Methods
        public ShakePreset()
        {
            this.Strength = 1092616192;
            mem[1152921509891433632] = 1092616192;
            mem[1152921509891433636] = 0;
            this.Duration = 0.5f;
            this.Vibrato = 10;
            this.Randomness = 0.1f;
            this.Smoothness = 0.1f;
            this.UseRandomInitialAngle = true;
        }
    
    }

}
