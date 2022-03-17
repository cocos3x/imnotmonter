using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public interface IPositionDeltaChanger
    {
        // Properties
        public abstract int PDCOrder { get; set; }
        
        // Methods
        public abstract UnityEngine.Vector3 AdjustDelta(float deltaTime, UnityEngine.Vector3 originalDelta); // 0
        public abstract int get_PDCOrder(); // 0
        public abstract void set_PDCOrder(int value); // 0
    
    }

}
