using UnityEngine;
public class RopeResuceMenu : BaseUIMenu
{
    // Fields
    private UnityEngine.Animator animator;
    private UnityEngine.UI.Button backHomeButton;
    private TMPro.TextMeshProUGUI levelNameText;
    private UnityEngine.UI.Button replayButton;
    private UnityEngine.UI.Button skipButton;
    private int time;
    
    // Methods
    private void Start()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  739583632, method:  new IntPtr(1610680625));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  739583632, eventID:  32, callback:  536873423);
    }
    private string FormatTime(float value)
    {
        int val_4 = (int)R1;
        val_4 = val_4 + 59;
        if(val_4 <= 118)
        {
                val_4 = (val_4 + 3758096340) - 1;
        }
        
        if(val_4 <= 8)
        {
                WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610601165, volume:  (int)R1);
        }
        
        string val_3 = System.String.Format(format:  -1610597105, arg0:  536888987, arg1:  536888987);
    }
    public void CloseClick()
    {
        goto typeof(RopeResuceMenu).__il2cppRuntimeField_E4;
    }
    private void ResetButton()
    {
        this.skipButton.interactable = true;
        this.replayButton.interactable = true;
        this.backHomeButton.interactable = true;
    }
    private void BackHome()
    {
        this.backHomeButton.interactable = false;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneHome();
    }
    private void ReplayLevel()
    {
        this.replayButton.interactable = false;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700957.SpawLevel();
    }
    private void SkipLevel()
    {
        var val_6;
        this.skipButton.interactable = false;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_6 = -1073708883.CurrentLevelRope;
        }
        else
        {
                val_6 = -1073708883.CurrentLevelRope;
        }
        
        -1073708883.CurrentLevelRope = val_6 + 1;
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700957.SpawLevel();
    }
    private void HideMenuElements()
    {
        this.replayButton.interactable = false;
        this.backHomeButton.interactable = false;
        this.skipButton.interactable = false;
    }
    private void ShowMenuElements()
    {
        this.replayButton.interactable = true;
        this.backHomeButton.interactable = true;
        this.skipButton.interactable = true;
    }
    public RopeResuceMenu()
    {
    
    }
    private void <Start>b__6_0(UnityEngine.Component sender, object param)
    {
        goto typeof(RopeResuceMenu).__il2cppRuntimeField_E4;
    }

}
