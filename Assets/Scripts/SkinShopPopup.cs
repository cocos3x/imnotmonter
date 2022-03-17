using UnityEngine;
public class SkinShopPopup : BaseUIMenu
{
    // Fields
    private UnityEngine.GameObject conTentHuggy;
    private UnityEngine.GameObject contentCharacter;
    private UnityEngine.GameObject homeMenu2;
    private UnityEngine.UI.Toggle charPageToggle;
    private UnityEngine.UI.Toggle huggyPageToggle;
    private TMPro.TextMeshProUGUI txtchar;
    private TMPro.TextMeshProUGUI txtHuggy;
    private UnityEngine.Color32 colorblack;
    private int tab;
    public static bool showWin;
    
    // Methods
    private void OnEnable()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701127.HideBanner();
        if(mem[536894073] == 0)
        {
                return;
        }
        
        this.homeMenu2.SetActive(value:  true);
    }
    public void Close()
    {
        var val_19;
        var val_20;
        val_19 = this;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701127.ShowBanner(position:  1, bannerPlaceID:  0);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
            goto label_2;
        }
        
        WinPopup val_3 = AFramework.SingletonUI<WinPopup>.I;
        -1073700789.ActiveContent(active:  true);
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_20 = 0;
        -1073700957.ActiveChild(active:  true);
        goto label_9;
        label_2:
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
            goto label_6;
        }
        
        WinPopup val_6 = AFramework.SingletonUI<WinPopup>.I;
        -1073700789.ActiveContent(active:  true);
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_20 = 0;
        -1073700989.ActiveChild(active:  true);
        goto label_9;
        label_6:
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
            goto label_10;
        }
        
        WinPopup val_9 = AFramework.SingletonUI<WinPopup>.I;
        -1073700789.ActiveContent(active:  true);
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_20 = 0;
        -1073700997.ActiveChild(active:  true);
        label_9:
        WinPopup val_11 = AFramework.SingletonUI<WinPopup>.I;
        -1073700805.ShowMainSkin(IsShowPlayer:  true, playerSit:  true, _callBack:  0);
        this.ChangeToggle();
        goto typeof(SkinShopPopup).__il2cppRuntimeField_E4;
        label_10:
        WinPopup val_12 = AFramework.SingletonUI<WinPopup>.I;
        -1073700805.ShowMainSkin(IsShowPlayer:  true, playerSit:  true, _callBack:  0);
        R4.ChangeToggle();
        WinPopup val_13 = AFramework.SingletonUI<WinPopup>.I;
        -1073700805.ShowSelectedSkin();
        WinPopup val_14 = AFramework.SingletonUI<WinPopup>.I;
        -1073700805.ShowHuggySelectedSkin();
        WinPopup val_15 = AFramework.SingletonUI<WinPopup>.I;
        -1073700811.ShowDeco(value:  true);
        var val_16 = FP - 16;
    }
    private void ChangeToggle()
    {
        this.charPageToggle.isOn = true;
        this.huggyPageToggle.isOn = false;
        this.ChangePop();
    }
    public void ChangePop()
    {
        float val_4;
        float val_5;
        float val_6;
        float val_7;
        float val_10;
        TMPro.TextMeshProUGUI val_11;
        WinPopup val_1 = AFramework.SingletonUI<WinPopup>.I;
        if(this.charPageToggle.m_IsOn == true)
        {
                this.charPageToggle.m_IsOn = 1;
        }
        
        -1073700805.ShowMainSkin(IsShowPlayer:  true, playerSit:  false, _callBack:  0);
        if(this.charPageToggle.m_IsOn == true)
        {
                this.charPageToggle.m_IsOn = 1;
        }
        
        this.contentCharacter.SetActive(value:  true);
        this.conTentHuggy.SetActive(value:  this.contentCharacter >> 5);
        if(this.charPageToggle.m_IsOn != false)
        {
                this.tab = 0;
            UnityEngine.Color val_3 = UnityEngine.Color.white;
            val_10 = val_5;
            this.txtchar.color = new UnityEngine.Color() {r = val_4, g = val_10, b = val_6, a = val_7};
            val_11 = this.txtHuggy;
        }
        else
        {
                this.tab = 1;
            UnityEngine.Color val_8 = UnityEngine.Color.white;
            val_10 = val_5;
            this.txtHuggy.color = new UnityEngine.Color() {r = val_4, g = val_10, b = val_6, a = val_7};
            val_11 = this.txtchar;
        }
        
        UnityEngine.Color val_9 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 252, g = 184, b = 79, a = 50});
        val_11.color = new UnityEngine.Color() {r = val_4, g = val_5, b = val_6, a = val_7};
    }
    public SkinShopPopup()
    {
    
    }

}
