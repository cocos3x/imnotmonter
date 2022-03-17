using UnityEngine;
public class SettingPopup : BaseUIMenu
{
    // Fields
    private UnityEngine.UI.Button resumeButton;
    private UnityEngine.UI.Button homeButton;
    private UnityEngine.UI.Button restoreIAPBtn;
    private UnityEngine.UI.Button closeBtn;
    private UnityEngine.UI.Button outsideCloseButton;
    private UnityEngine.UI.Toggle soundToggle;
    private UnityEngine.UI.Toggle musicToggle;
    private UnityEngine.UI.Toggle vibrateToggle;
    private TMPro.TextMeshProUGUI versionText;
    private UnityEngine.RectTransform content;
    private bool checkSetData;
    public static bool isSelectModeSetting;
    private bool isCloseing;
    
    // Methods
    private void Start()
    {
        536896275 = new UnityEngine.Events.UnityAction(object:  841024528, method:  new IntPtr(1610682137));
        this.resumeButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  841024528, method:  new IntPtr(1610682139));
        this.closeBtn.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  841024528, method:  new IntPtr(1610682141));
        this.outsideCloseButton.m_OnClick.AddListener(call:  536896275);
        536880141 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  841024528, method:  new IntPtr(1610682143));
        this.soundToggle.onValueChanged.AddListener(call:  536880141);
        536880141 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  841024528, method:  new IntPtr(1610682145));
        this.musicToggle.onValueChanged.AddListener(call:  536880141);
        536880141 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  841024528, method:  new IntPtr(1610682147));
        this.vibrateToggle.onValueChanged.AddListener(call:  536880141);
        536896275 = new UnityEngine.Events.UnityAction(object:  841024528, method:  new IntPtr(1610682149));
        this.homeButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  841024528, method:  new IntPtr(1610682151));
        this.restoreIAPBtn.m_OnClick.AddListener(call:  536896275);
    }
    private void OnEnable()
    {
        var val_21;
        this.checkSetData = false;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        this.soundToggle.isOn = -1073708883.SoundFX;
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        this.musicToggle.isOn = -1073708883.Music;
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        this.vibrateToggle.isOn = -1073708883.Vibrate;
        UnityEngine.UI.Toggle val_7 = this.musicToggle.GetComponentInChildren<UnityEngine.UI.Toggle>();
        this.musicToggle.enabled = this.musicToggle >> 5;
        UnityEngine.UI.Toggle val_9 = this.soundToggle.GetComponentInChildren<UnityEngine.UI.Toggle>();
        this.soundToggle.enabled = this.soundToggle >> 5;
        UnityEngine.UI.Toggle val_11 = this.vibrateToggle.GetComponentInChildren<UnityEngine.UI.Toggle>();
        this.vibrateToggle.enabled = this.vibrateToggle >> 5;
        UnityEngine.SceneManagement.Scene val_13 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        string val_14 = val_13.m_Handle.name;
        UnityEngine.GameObject val_16 = this.homeButton.gameObject;
        if((System.String.op_Equality(a:  841247380, b:  -1610607723)) != false)
        {
                this.homeButton.SetActive(value:  false);
            UnityEngine.GameObject val_17 = this.resumeButton.gameObject;
            this.resumeButton.SetActive(value:  false);
            UnityEngine.GameObject val_18 = this.restoreIAPBtn.gameObject;
            val_21 = 1;
        }
        else
        {
                this.homeButton.SetActive(value:  true);
            UnityEngine.GameObject val_19 = this.resumeButton.gameObject;
            this.resumeButton.SetActive(value:  true);
            UnityEngine.GameObject val_20 = this.restoreIAPBtn.gameObject;
            val_21 = 0;
        }
        
        this.restoreIAPBtn.SetActive(value:  false);
        this.isCloseing = false;
        this.UpdateVersion();
    }
    private void IosCheckPopup()
    {
    
    }
    private void SetHomeButton()
    {
        this.homeButton.interactable = false;
        UnityEngine.UI.Image val_1 = this.homeButton.image;
        UnityEngine.Color32 val_2 = new UnityEngine.Color32(r:  100, g:  100, b:  100, a:  255);
        UnityEngine.Color val_3 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 120, g = 229, b = 40, a = 50});
        UnityEngine.Transform val_8 = this.homeButton.transform;
        UnityEngine.Transform val_9 = this.homeButton.GetChild(index:  0);
        UnityEngine.Transform val_10 = this.homeButton.GetComponent<UnityEngine.Transform>();
        UnityEngine.Color32 val_11 = new UnityEngine.Color32(r:  100, g:  100, b:  100, a:  255);
        UnityEngine.Color val_12 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 120, g = 229, b = 40, a = 50});
        if(this.homeButton != 0)
        {
                return;
        }
    
    }
    public void CloseClick()
    {
        if(this.isCloseing == true)
        {
                return;
        }
        
        this.isCloseing = true;
        goto typeof(SettingPopup).__il2cppRuntimeField_E4;
    }
    private void CloseEvent()
    {
        goto typeof(SettingPopup).__il2cppRuntimeField_E4;
    }
    public void HomeClick()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneHome();
        this.homeButton.interactable = false;
    }
    public void ToggleVibrate()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if(this.vibrateToggle.m_IsOn == true)
        {
                this.vibrateToggle.m_IsOn = 1;
        }
        
        -1073708883.Vibrate = true;
        UnityEngine.UI.Toggle val_2 = this.vibrateToggle.GetComponentInChildren<UnityEngine.UI.Toggle>();
        this.vibrateToggle.enabled = this.vibrateToggle >> 5;
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        if(this.vibrateToggle.m_IsOn == false)
        {
                22807444 = 22807440;
        }
        
        536874379.Add(key:  536897859, value:  -1610597445);
        -1073700879.TrackEvent(eventName:  -1610598519, parameters:  536874379);
    }
    public void ToggleSound()
    {
        UnityEngine.UI.Toggle val_1 = this.soundToggle.GetComponentInChildren<UnityEngine.UI.Toggle>();
        this.soundToggle.enabled = this.soundToggle >> 5;
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        if(this.soundToggle.m_IsOn == true)
        {
                this.soundToggle.m_IsOn = 1;
        }
        
        -1073708883.SoundFX = true;
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073701113.SetSoundFX(value:  -1073708883.SoundFX);
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        if(this.soundToggle.m_IsOn == false)
        {
                22805720 = 22805716;
        }
        
        536874379.Add(key:  536897859, value:  -1610598307);
        -1073700879.TrackEvent(eventName:  -1610598519, parameters:  536874379);
    }
    public void ToggleMusic()
    {
        UnityEngine.UI.Toggle val_1 = this.musicToggle.GetComponentInChildren<UnityEngine.UI.Toggle>();
        this.musicToggle.enabled = this.musicToggle >> 5;
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        if(this.musicToggle.m_IsOn == true)
        {
                this.musicToggle.m_IsOn = 1;
        }
        
        -1073708883.Music = true;
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073701113.SetMusic(value:  -1073708883.Music);
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        if(this.musicToggle.m_IsOn == false)
        {
                22804012 = 22804008;
        }
        
        536874379.Add(key:  536897859, value:  -1610599161);
        -1073700879.TrackEvent(eventName:  -1610598519, parameters:  536874379);
    }
    private void UpdateVersion()
    {
        string val_1 = UnityEngine.Application.version;
        string val_2 = -1610602875(-1610602875) + null;
        this.versionText.text = -1610602875;
    }
    private void RestoreIAPClick()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701017.RestorePurchases();
    }
    public SettingPopup()
    {
    
    }
    private void <Start>b__12_0()
    {
        if(this.isCloseing == true)
        {
                return;
        }
        
        this.isCloseing = true;
        goto typeof(SettingPopup).__il2cppRuntimeField_E4;
    }
    private void <Start>b__12_1()
    {
        if(this.isCloseing == true)
        {
                return;
        }
        
        this.isCloseing = true;
        goto typeof(SettingPopup).__il2cppRuntimeField_E4;
    }
    private void <Start>b__12_2()
    {
        if(this.isCloseing == true)
        {
                return;
        }
        
        this.isCloseing = true;
        goto typeof(SettingPopup).__il2cppRuntimeField_E4;
    }
    private void <Start>b__12_3(bool <p0>)
    {
        this.ToggleSound();
    }
    private void <Start>b__12_4(bool <p0>)
    {
        this.ToggleMusic();
    }
    private void <Start>b__12_5(bool <p0>)
    {
        this.ToggleVibrate();
    }
    private void <Start>b__12_6()
    {
        this.HomeClick();
    }
    private void <Start>b__12_7()
    {
        this.RestoreIAPClick();
    }

}
