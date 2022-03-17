using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class MinMaxSliderAttribute : PropertyAttribute
    {
        // Fields
        public readonly float max;
        public readonly float min;
        
        // Methods
        public MinMaxSliderAttribute(float min, float max)
        {
            this.max = R2;
            this.min = R1;
        }
    
    }

}
