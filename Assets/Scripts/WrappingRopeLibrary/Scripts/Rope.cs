using UnityEngine;

namespace WrappingRopeLibrary.Scripts
{
    public class Rope : RopeBase
    {
        // Methods
        private void FixedUpdate()
        {
            this.MainUpdate();
        }
        protected bool CheckAndUpdateByChanges()
        {
            var val_6 = 0;
            if(R6 == 0)
            {
                    return (bool)val_6;
            }
            
            val_6 = 0;
            if(R6 == 0)
            {
                    return (bool)val_6;
            }
            
            if(R6 == 0)
            {
                    if(this.TryInitPieceSystem() == true)
            {
                    val_6 = 1;
            }
            
                return (bool)val_6;
            }
            
            val_6 = 1;
            return (bool)val_6;
        }
        public Rope()
        {
        
        }
    
    }

}
