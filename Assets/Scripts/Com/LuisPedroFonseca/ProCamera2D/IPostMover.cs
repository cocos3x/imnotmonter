using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public interface IPostMover
    {
        // Properties
        public abstract int PMOrder { get; set; }
        
        // Methods
        public abstract void PostMove(float deltaTime); // 0
        public abstract int get_PMOrder(); // 0
        public abstract void set_PMOrder(int value); // 0
    
    }

}
