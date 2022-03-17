using UnityEngine;

namespace WrappingRope.Demo
{
    public class CharacterRopeInteraction : DefaultRopeInteraction
    {
        // Fields
        public WrappingRope.Demo.Man1Controller _manController;
        public float _strengthOfForce;
        
        // Methods
        public override void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position, UnityEngine.ForceMode mode)
        {
            float val_2;
            float val_3;
            val_2 = force.y;
            val_3 = force.x;
            if(this._manController == 0)
            {
                    return;
            }
            
            float val_4 = this._strengthOfForce;
            float val_2 = val_3;
            float val_3 = val_2;
            val_2 = val_4 * val_2;
            val_3 = val_4 * val_3;
            val_4 = val_4 * force.z;
            val_2 = val_3;
            val_3 = val_4;
            this._manController.AddForce(force:  new UnityEngine.Vector3() {x = val_2, y = val_2, z = val_3});
        }
        public CharacterRopeInteraction()
        {
        
        }
    
    }

}
