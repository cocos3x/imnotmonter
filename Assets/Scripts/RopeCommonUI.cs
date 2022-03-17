using UnityEngine;
public class RopeCommonUI : MonoBehaviour
{
    // Methods
    private void Start()
    {
        AFramework.UI.BaseUIMenu val_1 = AFramework.UI.CanvasManager.Init(dataPath:  -1610605257, defaultMenuIdentifier:  -1610606483);
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        mem[3221258461] = 1;
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.ShowCompletedStory = true;
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.ShowCompletedStory) != false)
        {
                WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073700957.SpawLevelStart();
            return;
        }
        
        AFramework.UI.BaseUIMenu val_7 = AFramework.UI.CanvasManager.Push(identifier:  -1610605273, initParams:  null);
    }
    public RopeCommonUI()
    {
    
    }

}
