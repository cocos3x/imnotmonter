using UnityEngine;
public class StartContent : SingletonMonoBehaviour<StartContent>
{
    // Fields
    private UnityEngine.UI.Button settingBtn;
    private UnityEngine.UI.Button noAdsButton;
    private UnityEngine.UI.Button spinButton;
    private UnityEngine.UI.Button skinButton;
    private UnityEngine.UI.Button selectModeButton;
    private UnityEngine.UI.Button decoButton;
    private HomePopupController homePopup;
    private UnityEngine.GameObject[] listNotifi;
    private UnityEngine.GameObject[] selectModeButtonReferences;
    
    // Methods
    private void Start()
    {
        var val_10;
        UnityEngine.Events.UnityAction val_11;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.RopeTapeBonusReward = 0;
        this.CheckNoAds();
        val_10 = 22716284;
        536896275 = new UnityEngine.Events.UnityAction(object:  850979344, method:  new IntPtr(1610682275));
        this.settingBtn.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  850979344, method:  new IntPtr(1610682277));
        this.spinButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  850979344, method:  new IntPtr(1610682279));
        this.skinButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  850979344, method:  new IntPtr(1610682281));
        this.selectModeButton.m_OnClick.AddListener(call:  536896275);
        val_11 = 536896275;
        val_11 = new UnityEngine.Events.UnityAction(object:  850979344, method:  new IntPtr(1610682283));
        this.decoButton.m_OnClick.AddListener(call:  536896275);
        this.CheckNotifi();
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266339] + 8) == 0)
        {
                return;
        }
        
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        val_11 = 0;
        if((-1073708883.IsOldUser) == true)
        {
                return;
        }
        
        goto label_17;
        label_21:
        1152921506690760672.SetActive(value:  false);
        val_11 = 1;
        label_17:
        if(val_11 < 1152921506690760672)
        {
            goto label_21;
        }
    
    }
    private void CheckNotifi()
    {
        goto label_1;
        label_5:
        1152921506690760672.SetActive(value:  false);
        0 = 1;
        label_1:
        if(0 < 1152921506690760672)
        {
            goto label_5;
        }
        
        if((UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  100)) <= 80)
        {
                this.listNotifi[0].SetActive(value:  true);
        }
        
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        System.Collections.Generic.List<System.Int32> val_3 = -1073708883.ListSkinUnlocked;
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        if(mem[3221258425] < mem[3221258425])
        {
            goto label_13;
        }
        
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        System.Collections.Generic.List<System.Int32> val_6 = -1073708883.ListHuggyUnlocked;
        object val_7 = AFramework.ManualSingletonMono<System.Object>.I;
        if(mem[3221258425] >= mem[3221258429])
        {
            goto label_18;
        }
        
        label_13:
        if((UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  2)) == 0)
        {
                this.listNotifi[1].SetActive(value:  true);
        }
        
        label_18:
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IsUnlockAllDeco()) == true)
        {
                return;
        }
        
        if((UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  2)) != 0)
        {
                return;
        }
        
        this.listNotifi[2].SetActive(value:  true);
    }
    private void OnEnable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  851600656, method:  new IntPtr(1610682285));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  851600656, eventID:  13, callback:  536873423);
    }
    private void OnDisable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  851712656, method:  new IntPtr(1610682287));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  851712656, eventID:  13, callback:  536873423);
    }
    private void OnSettingClick()
    {
        mem2[0] = 1;
        AFramework.UI.BaseUIMenu val_1 = AFramework.UI.CanvasManager.Push(identifier:  -1610605279, initParams:  null);
    }
    private void OnSelectModeClick()
    {
        this.homePopup.CloseClick();
        AFramework.UI.BaseUIMenu val_1 = AFramework.UI.CanvasManager.Push(identifier:  -1610605281, initParams:  null);
    }
    private void OnSpinClick()
    {
        WinPopup val_1 = AFramework.SingletonUI<WinPopup>.I;
        -1073700811.ShowDeco(value:  false);
        AFramework.UI.BaseUIMenu val_2 = AFramework.UI.CanvasManager.Push(identifier:  -1610605275, initParams:  null);
    }
    private void OnGachaClick()
    {
        this.listNotifi[0].SetActive(value:  false);
        this.homePopup.CloseClick();
        WinPopup val_1 = AFramework.SingletonUI<WinPopup>.I;
        -1073700811.ShowDeco(value:  false);
        AFramework.UI.BaseUIMenu val_2 = AFramework.UI.CanvasManager.Push(identifier:  -1610605293, initParams:  null);
    }
    private void OnSkinClick()
    {
        this.listNotifi[1].SetActive(value:  false);
        WinPopup val_1 = AFramework.SingletonUI<WinPopup>.I;
        -1073700811.ShowDeco(value:  false);
        this.homePopup.CloseClick();
        AFramework.UI.BaseUIMenu val_2 = AFramework.UI.CanvasManager.Push(identifier:  -1610605277, initParams:  null);
    }
    private void OnDecorClick()
    {
        this.listNotifi[2].SetActive(value:  false);
        this.homePopup.CloseClick();
        WinPopup val_1 = AFramework.SingletonUI<WinPopup>.I;
        -1073700811.ShowButtonPoints(value:  true);
        AFramework.UI.BaseUIMenu val_2 = AFramework.UI.CanvasManager.Push(identifier:  -1610605295, initParams:  null);
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701127.HideBanner();
        GameTool.EventDispatcherExtension.PostEvent(sender:  852618128, eventID:  36, param:  536885819);
    }
    private void CheckNoAds()
    {
        UnityEngine.GameObject val_1 = this.noAdsButton.gameObject;
        this.noAdsButton.SetActive(value:  API.IsRemoveAds ^ 1);
    }
    public void StartPlay()
    {
        GameTool.EventDispatcherExtension.PostEvent(sender:  852895376, eventID:  0);
    }
    public void HideHome()
    {
        this.listNotifi[2].SetActive(value:  false);
        this.homePopup.CloseClick();
    }
    public StartContent()
    {
    
    }
    private void <Start>b__9_0()
    {
        this.OnSettingClick();
    }
    private void <Start>b__9_1()
    {
        this.OnGachaClick();
    }
    private void <Start>b__9_2()
    {
        this.OnSkinClick();
    }
    private void <Start>b__9_3()
    {
        this.OnSelectModeClick();
    }
    private void <Start>b__9_4()
    {
        this.OnDecorClick();
    }
    private void <OnEnable>b__11_0(UnityEngine.Component sender, object param)
    {
        this.CheckNoAds();
    }
    private void <OnDisable>b__12_0(UnityEngine.Component sender, object param)
    {
        this.CheckNoAds();
    }

}
