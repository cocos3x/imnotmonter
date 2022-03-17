using UnityEngine;

namespace Ferr
{
    [Serializable]
    public struct PathDMPoint
    {
        // Fields
        public float distance;
        public float percent;
        public int index;
        
        // Methods
        public PathDMPoint(int aIndex, float aDistance, float aPercent)
        {
            this.index = aIndex;
        }
    
    }

}
