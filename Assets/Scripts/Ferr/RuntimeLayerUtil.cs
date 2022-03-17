using UnityEngine;

namespace Ferr
{
    public static class RuntimeLayerUtil
    {
        // Fields
        private static System.Collections.Generic.List<int> mReservedLayers;
        
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
                    val_5 = 536893127;
                if(((mem[536893314] & true) == 0) && (mem[536893243] == 0))
            {
                    val_5 = 536893127;
            }
            
                val_6 = mem[mem[536893219]];
                val_6 = mem[536893219];
                if(val_6 == 0)
            {
                    return (int)val_4;
            }
            
                if(((mem[536893314] & true) == 0) && (mem[536893243] == 0))
            {
                    val_6 = mem[mem[536893219]];
                val_6 = mem[536893219];
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
            val_2 = 536893127;
            if(((mem[536893314] & true) == 0) && (mem[536893243] == 0))
            {
                    val_2 = 536893127;
            }
            
            if(mem[536893219] == 0)
            {
                    536877987 = new System.Collections.Generic.List<System.Int32>();
                val_3 = 536893127;
                if(((mem[536893314] & true) == 0) && (mem[536893243] == 0))
            {
                    val_3 = 536893127;
            }
            
                mem2[0] = 536877987;
                val_2 = 536893127;
            }
            
            if(((mem[536893314] & true) == 0) && (mem[536893243] == 0))
            {
                    val_2 = 536893127;
            }
            
            mem[536893219].Add(item:  aLayerID);
        }
        private static RuntimeLayerUtil()
        {
        
        }
    
    }

}
