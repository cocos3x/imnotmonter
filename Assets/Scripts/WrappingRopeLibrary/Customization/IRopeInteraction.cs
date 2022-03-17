using UnityEngine;

namespace WrappingRopeLibrary.Customization
{
    public interface IRopeInteraction
    {
        // Methods
        public abstract UnityEngine.Vector3 GetPointVelocity(UnityEngine.Vector3 worldPoint); // 0
        public abstract void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position, UnityEngine.ForceMode mode); // 0
    
    }

}
