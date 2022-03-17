using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class PoolMember : MonoBehaviour
    {
        // Fields
        public Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.Pool pool;
        
        // Methods
        private void OnDisable()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            this.pool.nextThing = 1098257840;
        }
        public PoolMember()
        {
        
        }
    
    }

}
