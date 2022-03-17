using UnityEngine;
public class LevelProgressDataRope : SingletonMonoBehaviour<LevelProgressDataRope>
{
    // Fields
    public LevelRopeData data;
    
    // Properties
    public static int levelIndex { get; set; }
    public bool IsStepEnd { get; }
    
    // Methods
    public static int get_levelIndex()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1610599435, defaultValue:  0);
    }
    public static void set_levelIndex(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1610599435, value:  value);
    }
    public bool get_IsStepEnd()
    {
        return true;
    }
    public LevelRopeType GetLevelMode()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_3 = -1073708883.CurrentLevelRope;
        val_3 = val_3 - 1;
        if(this.data.listLevelRope[val_3] != 0)
        {
                return;
        }
    
    }
    public LevelProgressDataRope()
    {
    
    }

}
