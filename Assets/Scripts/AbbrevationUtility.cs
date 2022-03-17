using UnityEngine;
public static class AbbrevationUtility
{
    // Fields
    private static readonly System.Collections.Generic.SortedDictionary<int, string> abbrevations;
    
    // Methods
    public static string AbbreviateNumber(float number)
    {
        var val_3;
        string val_4;
        var val_9;
        var val_10;
        val_9 = 536882979;
        if(((mem[536883166] & true) == 0) && (mem[536883095] == 0))
        {
                val_9 = 536882979;
        }
        
        var val_9 = mem[536883071];
        val_9 = val_9.Count - 1;
        label_7:
        if(val_9 <= 1)
        {
            goto label_4;
        }
        
        val_10 = 536882979;
        if(((mem[536883166] & true) == 0) && (mem[536883095] == 0))
        {
                val_10 = 536882979;
        }
        
        System.Collections.Generic.KeyValuePair<System.Int32, System.String> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.Int32, System.String>>(source:  575230088, index:  mem[536883071]);
        val_9 = val_9 - 1;
        float val_11 = (float)val_3;
        float val_10 = System.Math.Abs(0);
        if(mem[536883095] < 0)
        {
            goto label_7;
        }
        
        val_11 = 0 / val_11;
        string val_6 = UnityEngine.Mathf.FloorToInt(f:  val_11).ToString();
        string val_7 = 575230096 + val_4;
        return;
        label_4:
        string val_8 = 0.ToString();
    }
    public static string AbbrevationTimeHMS(float time)
    {
        float val_6 = 3600f;
        val_6 = 0 / val_6;
        float val_7 = 60f;
        float val_2 = ((float)UnityEngine.Mathf.FloorToInt(f:  val_6)) * val_7;
        val_7 = 0 / val_7;
        int val_4 = UnityEngine.Mathf.FloorToInt(f:  UnityEngine.Mathf.FloorToInt(f:  val_7));
        string val_5 = System.String.Format(format:  -1610597101, arg0:  536893745, arg1:  536893745, arg2:  536893745);
    }
    private static AbbrevationUtility()
    {
        536879547 = new System.Collections.Generic.SortedDictionary<System.Int32, System.String>();
        if(536879547 != 0)
        {
                536879547.Add(key:  1000000, value:  -1610606555);
        }
        else
        {
                536879547.Add(key:  1000000, value:  -1610606555);
        }
        
        536879547.Add(key:  1000000000, value:  -1610610009);
        mem2[0] = 536879547;
    }

}
