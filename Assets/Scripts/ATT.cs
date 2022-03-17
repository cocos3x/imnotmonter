using UnityEngine;
public static class ATT
{
    // Fields
    private static bool isChecked;
    private static bool _isOSready;
    
    // Methods
    public static bool IsOSReady()
    {
        var val_1;
        var val_2;
        val_1 = 536882973;
        if(((mem[536883160] & true) == 0) && (mem[536883089] == 0))
        {
                val_1 = 536882973;
        }
        
        val_2 = mem[536883065];
        if(val_2 == 0)
        {
                if(((mem[536883160] & true) == 0) && (mem[536883089] == 0))
        {
                val_2 = mem[536883065];
        }
        
            mem2[0] = 1;
            val_1 = 536882973;
        }
        
        if((mem[536883160] & true) != 0)
        {
                return (bool)mem[536883065] + 1;
        }
        
        if(mem[536883089] != 0)
        {
                return (bool)mem[536883065] + 1;
        }
        
        val_1 = 536882973;
        return (bool)mem[536883065] + 1;
    }
    public static System.Collections.IEnumerator CRRequestATTracking()
    {
        536897803 = new ATT.<CRRequestATTracking>d__3(<>1__state:  0);
    }
    public static void AppsFlyerWait(int seconds)
    {
    
    }
    private static ATT()
    {
    
    }

}
