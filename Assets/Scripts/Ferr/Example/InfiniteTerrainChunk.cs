using UnityEngine;

namespace Ferr.Example
{
    public class InfiniteTerrainChunk : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform _rightHook;
        private UnityEngine.Transform _leftHook;
        
        // Properties
        public UnityEngine.Vector3 RightHook { get; }
        public UnityEngine.Vector3 LeftHook { get; }
        
        // Methods
        public UnityEngine.Vector3 get_RightHook()
        {
            Ferr.Example.InfiniteTerrainChunk val_4;
            var val_5;
            if((R1 + 12) != 0)
            {
                    R1 = mem[R1 + 12];
                R1 = R1 + 12;
            }
            
            UnityEngine.Transform val_2 = R1.transform;
            UnityEngine.Vector3 val_3 = position;
            mem[1152921510177050968] = val_5;
            this = val_4;
            return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public UnityEngine.Vector3 get_LeftHook()
        {
            Ferr.Example.InfiniteTerrainChunk val_4;
            var val_5;
            if((R1 + 16) != 0)
            {
                    R1 = mem[R1 + 16];
                R1 = R1 + 16;
            }
            
            UnityEngine.Transform val_2 = R1.transform;
            UnityEngine.Vector3 val_3 = position;
            mem[1152921510177162968] = val_5;
            this = val_4;
            return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public void ConnectTo(UnityEngine.Vector3 aToHook, Ferr.Example.Side aToHookSide)
        {
            float val_4;
            float val_5;
            float val_6;
            float val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_12 = aToHook.z;
            if(aToHookSide != 1)
            {
                    if(aToHookSide != 0)
            {
                    return;
            }
            
                UnityEngine.Transform val_1 = this.transform;
                val_13 = this;
                UnityEngine.Transform val_2 = this.transform;
                val_14 = 0;
                UnityEngine.Vector3 val_3 = position;
                val_15 = val_4;
                val_16 = val_5;
                val_17 = val_6;
                UnityEngine.Vector3 val_7 = RightHook;
            }
            else
            {
                    UnityEngine.Transform val_8 = this.transform;
                val_13 = this;
                UnityEngine.Transform val_9 = this.transform;
                val_14 = 0;
                UnityEngine.Vector3 val_10 = position;
                val_15 = val_4;
                val_16 = val_5;
                val_17 = val_6;
                UnityEngine.Vector3 val_11 = LeftHook;
            }
            
            float val_12 = val_4;
            float val_13 = val_5;
            float val_14 = val_6;
            val_12 = val_15 - val_12;
            val_13 = val_16 - val_13;
            val_14 = val_17 - val_14;
            val_12 = val_12 + aToHook.x;
            val_13 = val_13 + aToHook.y;
            val_14 = val_14 + val_12;
            val_12 = val_12;
            this.position = new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14};
        }
        private void OnDrawGizmos()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.green;
            UnityEngine.Gizmos.color = new UnityEngine.Color();
            UnityEngine.Vector3 val_2 = RightHook;
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3(), radius:  val_2.x);
            UnityEngine.Color val_3 = UnityEngine.Color.blue;
            UnityEngine.Gizmos.color = new UnityEngine.Color();
            UnityEngine.Vector3 val_4 = LeftHook;
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3(), radius:  val_4.x);
        }
        public InfiniteTerrainChunk()
        {
        
        }
    
    }

}
