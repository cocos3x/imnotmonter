using UnityEngine;

namespace Ferr
{
    public class RenderUtility
    {
        // Fields
        private static System.Collections.Generic.List<int> mReservedLayers;
        private static UnityEngine.Camera mCamera;
        
        // Methods
        public static int GetFreeLayer()
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = 16;
            do
            {
                string val_1 = UnityEngine.LayerMask.LayerToName(layer:  16);
                if((System.String.op_Equality(a:  16, b:  -1610612735)) != false)
            {
                    val_5 = 536892843;
                if(((mem[536893030] & true) == 0) && (mem[536892959] == 0))
            {
                    val_5 = 536892843;
            }
            
                val_6 = mem[mem[536892935]];
                val_6 = mem[536892935];
                if(val_6 == 0)
            {
                    return (int)val_4;
            }
            
                if(((mem[536893030] & true) == 0) && (mem[536892959] == 0))
            {
                    val_6 = mem[mem[536892935]];
                val_6 = mem[536892935];
                if(val_6 == 0)
            {
                    val_6 = 0;
            }
            
            }
            
                if((val_6.Contains(item:  16)) == false)
            {
                    return (int)val_4;
            }
            
            }
            
                var val_4 = val_4 + 1;
            }
            while(val_4 < 31);
            
            UnityEngine.Debug.LogError(message:  -1610608199);
            val_4 = 0;
            return (int)val_4;
        }
        public static void ReserveLayer(int aLayerID)
        {
            var val_2;
            var val_3;
            val_2 = 536892843;
            if(((mem[536893030] & true) == 0) && (mem[536892959] == 0))
            {
                    val_2 = 536892843;
            }
            
            if(mem[536892935] == 0)
            {
                    536877987 = new System.Collections.Generic.List<System.Int32>();
                val_3 = 536892843;
                if(((mem[536893030] & true) == 0) && (mem[536892959] == 0))
            {
                    val_3 = 536892843;
            }
            
                mem2[0] = 536877987;
                val_2 = 536892843;
            }
            
            if(((mem[536893030] & true) == 0) && (mem[536892959] == 0))
            {
                    val_2 = 536892843;
            }
            
            mem[536892935].Add(item:  aLayerID);
        }
        public static UnityEngine.Camera CreateRenderCamera()
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = 536892843;
            if(((mem[536893030] & true) == 0) && (mem[536892959] == 0))
            {
                    val_5 = 536892843;
            }
            
            if((mem[536892935] + 4) == 0)
            {
                    536887303 = new UnityEngine.GameObject(name:  -1610608201);
                SynchronizationContextBehavoir val_3 = 536887303.AddComponent<SynchronizationContextBehavoir>();
                val_6 = 536892843;
                if(((mem[536893030] & true) == 0) && (mem[536892959] == 0))
            {
                    val_6 = 536892843;
            }
            
                mem2[0] = 536887303;
                UnityEngine.GameObject val_4 = mem[536892935] + 4.gameObject;
                mem[536892935] + 4.hideFlags = 61;
                mem[536892935] + 4.enabled = false;
            }
            
            val_7 = 536892843;
            if((mem[536893030] & true) != 0)
            {
                    return;
            }
            
            if(mem[536892959] != 0)
            {
                    return;
            }
            
            val_7 = 536892843;
        }
        public RenderUtility()
        {
        
        }
        private static RenderUtility()
        {
        
        }
    
    }

}
