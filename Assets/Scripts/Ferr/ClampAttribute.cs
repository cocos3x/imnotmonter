using UnityEngine;

namespace Ferr
{
    public class ClampAttribute : PropertyAttribute
    {
        // Fields
        public float mMin;
        public float mMax;
        
        // Methods
        public ClampAttribute(float aMin, float aMax)
        {
            this.mMin = R1;
            this.mMax = R2;
        }
    
    }

}
