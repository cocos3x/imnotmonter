using UnityEngine;
public class ItemSelectModeController : MonoBehaviour
{
    // Fields
    private ModeGameType modeGameType;
    private UnityEngine.UI.Button button;
    private UnityEngine.GameObject lockObject;
    private TMPro.TextMeshProUGUI infoLockText;
    private TMPro.TextMeshProUGUI comingsoonDetails;
    private UnityEngine.GameObject unlockedObject;
    private TMPro.TextMeshProUGUI winCountText;
    private TMPro.TextMeshProUGUI loseCountText;
    private UnityEngine.UI.Image fillProgressImage;
    private TMPro.TextMeshProUGUI progressValueText;
    
    // Methods
    private void Start()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  820126224, method:  new IntPtr(1610681841));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  820126224, eventID:  31, callback:  536873423);
    }
    private void OnEnable()
    {
        this.CheckUnlockMode();
    }
    public void CheckUnlockMode()
    {
        var val_11;
        TMPro.TextMeshProUGUI val_12;
        var val_13;
        if(this.modeGameType == 2)
        {
            goto label_1;
        }
        
        if(this.modeGameType == 1)
        {
            goto label_2;
        }
        
        if(this.modeGameType != 0)
        {
            goto label_22;
        }
        
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        val_11 = -1073708883.PinPullUnlocked;
        if(val_11 == true)
        {
            goto label_13;
        }
        
        this.lockObject.SetActive(value:  true);
        this.unlockedObject.SetActive(value:  false);
        val_12 = this.infoLockText;
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_13 = 22712448;
        goto label_17;
        label_1:
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        val_11 = -1073708883.CutRescuelUnlocked;
        if(val_11 == true)
        {
            goto label_13;
        }
        
        this.lockObject.SetActive(value:  true);
        this.unlockedObject.SetActive(value:  false);
        val_12 = this.infoLockText;
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_13 = 22712448;
        goto label_17;
        label_2:
        object val_7 = AFramework.ManualSingletonMono<System.Object>.I;
        val_11 = -1073708883.RopeRescuelUnlocked;
        if(val_11 == false)
        {
            goto label_20;
        }
        
        label_13:
        this.lockObject.SetActive(value:  false);
        this.unlockedObject.SetActive(value:  true);
        goto label_22;
        label_20:
        this.lockObject.SetActive(value:  true);
        this.unlockedObject.SetActive(value:  false);
        val_12 = this.infoLockText;
        WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_13 = 22712448;
        label_17:
        string val_10 = System.String.Format(format:  -1610603189, arg0:  536888987);
        val_11 = -1610603189;
        val_12.text = -1610603189;
        label_22:
        this.UpdateProgress();
    }
    private void UpdateProgress()
    {
        var val_9;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if(this.modeGameType == 0)
        {
            goto label_2;
        }
        
        if(this.modeGameType == 2)
        {
            goto label_3;
        }
        
        if(this.modeGameType != 1)
        {
            goto label_4;
        }
        
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_9 = mem[mem[3221266299] + 12];
        val_9 = mem[3221266299] + 12;
        goto label_10;
        label_2:
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_9 = mem[mem[3221266299] + 8];
        val_9 = mem[3221266299] + 8;
        goto label_10;
        label_3:
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_9 = mem[mem[3221266299] + 16];
        val_9 = mem[3221266299] + 16;
        label_10:
        label_4:
        string val_6 = -1073708883.Diamond.ToString();
        string val_7 = val_9.ToString();
        string val_8 = 820548500 + -1610611739(-1610611739) + 820548496;
        this.progressValueText.text = 820548500;
    }
    public ItemSelectModeController()
    {
    
    }
    private void <Start>b__10_0(UnityEngine.Component sender, object param)
    {
        this.CheckUnlockMode();
    }

}
