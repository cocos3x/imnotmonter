using UnityEngine;

namespace Crystal
{
    public class SafeAreaDemo : MonoBehaviour
    {
        // Fields
        private UnityEngine.KeyCode KeySafeArea;
        private Crystal.SafeArea.SimDevice[] Sims;
        private int SimIdx;
        
        // Methods
        private void Awake()
        {
            SimDevice[] val_4;
            var val_5;
            if(UnityEngine.Application.isEditor != true)
            {
                    UnityEngine.Object.Destroy(obj:  1428820624);
            }
            
            val_4 = 0;
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073771769)});
            val_5 = 1073771769;
            System.Array val_3 = System.Enum.GetValues(enumType:  1073771769);
            if(val_5 != 0)
            {
                    val_5 = val_5;
                val_4 = val_5;
                if(val_5 == 0)
            {
                    val_4 = 0;
            }
            
            }
            
            this.Sims = val_4;
        }
        private void Update()
        {
            if((UnityEngine.Input.GetKeyDown(key:  this.KeySafeArea)) == false)
            {
                    return;
            }
            
            R4.ToggleSafeArea();
        }
        private void ToggleSafeArea()
        {
            var val_2;
            int val_1 = this.SimIdx + 1;
            this.SimIdx = val_1;
            if(val_1 >= this.SimIdx)
            {
                    this.Sims = 0;
                this.SimIdx = this.Sims;
            }
            
            if(val_1 < this.SimIdx)
            {
                    this.Sims = this.SimIdx;
            }
            
            val_2 = 536893231;
            if(((mem[536893418] & true) == 0) && (mem[536893347] == 0))
            {
                    val_2 = 536893231;
            }
            
            mem2[0] = this.Sims[this.Sims];
            SimDevice val_3 = this.Sims[this.SimIdx];
            mem[536882227] = 536900857;
            mem[536882231] = 536889429;
            UnityEngine.Debug.LogFormat(format:  -1610604247, args:  536882211);
        }
        public SafeAreaDemo()
        {
            this.KeySafeArea = 97;
        }
    
    }

}
