using UnityEngine;

namespace EpicToonFX
{
    public class ETFXRotation : MonoBehaviour
    {
        // Fields
        public UnityEngine.Vector3 rotateVector;
        public EpicToonFX.ETFXRotation.spaceEnum rotateSpace;
        
        // Methods
        private void Start()
        {
        
        }
        private void Update()
        {
            ETFXRotation.spaceEnum val_9;
            float val_10;
            float val_11;
            float val_12;
            val_9 = this.rotateSpace;
            if(val_9 == 0)
            {
                    UnityEngine.Transform val_1 = this.transform;
                float val_2 = UnityEngine.Time.deltaTime;
                uint val_9 = 0;
                val_9 = this.rotateVector * val_9;
                val_10 = S20 * val_9;
                val_11 = S18 * val_9;
                val_12 = val_9;
                this.Rotate(eulers:  new UnityEngine.Vector3() {x = val_12, y = val_11, z = val_10});
                val_9 = this.rotateSpace;
            }
            
            if(val_9 != 1)
            {
                    return;
            }
            
            val_10 = 0;
            UnityEngine.Transform val_5 = this.transform;
            float val_6 = UnityEngine.Time.deltaTime;
            uint val_10 = 0;
            val_10 = this.rotateVector * val_10;
            val_12 = S18 * val_10;
            val_11 = val_10;
            this.Rotate(eulers:  new UnityEngine.Vector3() {x = val_11, y = val_12, z = S20 * val_10}, relativeTo:  val_10);
        }
        public ETFXRotation()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        }
    
    }

}
