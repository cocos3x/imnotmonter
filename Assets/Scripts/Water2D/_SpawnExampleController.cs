using UnityEngine;

namespace Water2D
{
    public class _SpawnExampleController : MonoBehaviour
    {
        // Methods
        private void Start()
        {
            if(mem[536896983] == 0)
            {
                    536896891 = 536896983;
            }
            
            mem2[0] = 1;
            mem[536896983].Spawn(count:  mem[536896983] + 292);
        }
        private void Update()
        {
        
        }
        public _SpawnExampleController()
        {
        
        }
    
    }

}
