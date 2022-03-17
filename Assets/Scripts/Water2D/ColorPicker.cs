using UnityEngine;

namespace Water2D
{
    public class ColorPicker : MonoBehaviour
    {
        // Fields
        public Water2D.Water2D_Spawner W2D;
        public float Delay;
        public UnityEngine.Color[] Colors;
        private float delta;
        
        // Methods
        private void Update()
        {
            float val_3;
            if()
            {
                    float val_1 = UnityEngine.Time.deltaTime;
                val_3 = this.delta + 0;
            }
            else
            {
                    if(this.Colors == null)
            {
                    return;
            }
            
                val_3 = this.delta * 0f;
            }
            
            this.delta = val_3;
        }
        public ColorPicker()
        {
        
        }
    
    }

}
