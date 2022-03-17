using UnityEngine;

namespace CutTheRope.Script
{
    public class RopeCutter : MonoBehaviour
    {
        // Fields
        public bool cancut;
        private UnityEngine.RaycastHit2D hit;
        
        // Methods
        private void Update()
        {
        
        }
        public RopeCutter()
        {
            this.cancut = true;
        }
    
    }

}
