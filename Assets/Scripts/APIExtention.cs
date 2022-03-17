using UnityEngine;
public static class APIExtention
{
    // Methods
    public static string CorrectString(string input)
    {
        if((System.String.IsNullOrEmpty(value:  input)) != false)
        {
                return;
        }
        
        if(input != null)
        {
                return input.Replace(oldValue:  -1610612583, newValue:  mem[536894675]);
        }
        
        return input.Replace(oldValue:  -1610612583, newValue:  mem[536894675]);
    }
    public static void Shuffle<T>(System.Collections.Generic.IList<T> list)
    {
        var val_8;
        var val_9;
        System.Collections.Generic.IList<T> val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_8 = __RuntimeMethodHiddenParam;
        var val_8 = 0;
        val_9 = 0;
        val_8 = val_8 + 1;
        val_9 = (uint)val_8 & 65535;
        val_11 = list;
        if(list < 2)
        {
                return;
        }
        
        do
        {
            System.Collections.Generic.IList<T> val_2 = list - 1;
            int val_3 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  val_2);
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_12 = list;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_13 = list;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_14 = list;
            val_8 = val_8;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_15 = list;
            val_10 = val_2;
        }
        while(list > 2);
    
    }

}
