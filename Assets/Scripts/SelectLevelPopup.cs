using UnityEngine;
public class SelectLevelPopup : BaseUIMenu
{
    // Fields
    private AnimToolUI.AnimUIManager animUIManager;
    private UnityEngine.GameObject scrollView;
    private UnityEngine.GameObject content;
    private UnityEngine.GameObject fakeContent;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.GameObject[] pageDots;
    private int pageCount;
    private int levelCount;
    
    // Methods
    public override void Init(object[] initParams)
    {
        this.Init(initParams:  initParams);
    }
    private void Start()
    {
        536896275 = new UnityEngine.Events.UnityAction(object:  837569168, method:  new IntPtr(1610682075));
        this.closeButton.m_OnClick.AddListener(call:  536896275);
    }
    private void OnEnable()
    {
        this.ResetContentChild();
        this.CheckLevelCount();
    }
    public void CloseClick()
    {
        var val_3;
        this.animUIManager.CloseAnim();
        536882991 = new System.Action(object:  837813648, method:  new IntPtr(1610682067));
        System.Delegate val_2 = System.Delegate.Combine(a:  this.animUIManager.OnClose, b:  536882991);
        val_3 = this.animUIManager.OnClose;
        if(val_3 != 0)
        {
                if(null == 536882991)
        {
            goto label_5;
        }
        
        }
        
        val_3 = 0;
        label_5:
        mem2[0] = val_3;
    }
    private void CloseEvent()
    {
        var val_5;
        536882991 = new System.Action(object:  837946128, method:  new IntPtr(1610682067));
        System.Delegate val_2 = System.Delegate.Remove(source:  this.animUIManager.OnClose, value:  536882991);
        val_5 = this.animUIManager.OnClose;
        if(val_5 != 0)
        {
                if(null == 536882991)
        {
            goto label_4;
        }
        
        }
        
        val_5 = 0;
        label_4:
        mem2[0] = val_5;
        WinPopup val_3 = AFramework.SingletonUI<WinPopup>.I;
        -1073700811.ShowDeco(value:  true);
        AFramework.UI.BaseUIMenu val_4 = AFramework.UI.CanvasManager.Push(identifier:  -1610605291, initParams:  null);
    }
    private void ResetContentChild()
    {
        goto label_0;
        label_14:
        UnityEngine.Transform val_1 = this.fakeContent.transform;
        if(this.fakeContent.childCount < 1)
        {
                return;
        }
        
        UnityEngine.Transform val_3 = this.fakeContent.transform;
        UnityEngine.Transform val_4 = this.fakeContent.GetChild(index:  0);
        UnityEngine.GameObject val_5 = this.fakeContent.gameObject;
        this.fakeContent.SetActive(value:  true);
        UnityEngine.Transform val_6 = this.fakeContent.transform;
        UnityEngine.Transform val_7 = this.fakeContent.GetChild(index:  0);
        UnityEngine.Transform val_8 = this.content.transform;
        this.fakeContent.SetParent(p:  this.content);
        label_0:
        UnityEngine.Transform val_9 = this.fakeContent.transform;
        if(this.fakeContent.childCount >= 1)
        {
            goto label_14;
        }
    
    }
    private void CheckLevelCount()
    {
        float val_20;
        float val_21;
        float val_22;
        float val_32;
        var val_34;
        var val_35;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266339] + 8) == 0)
        {
            goto label_3;
        }
        
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IsOldUser) == false)
        {
            goto label_5;
        }
        
        label_3:
        val_32 = 22740800;
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.GameMode) == 0)
        {
            goto label_8;
        }
        
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.GameMode) != 1)
        {
            goto label_10;
        }
        
        int val_9 = -1073708883.NumberPinpullLevel;
        goto label_14;
        label_5:
        object val_10 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_11 = -1073708883.NumberMixLevel;
        goto label_14;
        label_8:
        int val_12 = -1073708883.NumberRopeLevel;
        goto label_14;
        label_10:
        if((-1073708883.GameMode) != 2)
        {
            goto label_44;
        }
        
        object val_14 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_15 = -1073708883.NumberCutRopeLevel;
        label_14:
        this.levelCount = val_15;
        label_44:
        val_34 = 0;
        val_15 = val_15 - 4294967280;
        if(val_15 != 0)
        {
                214748364 = 214748365;
        }
        
        this.pageCount = 214748364;
        goto label_17;
        label_25:
        UnityEngine.Transform val_16 = this.content.transform;
        UnityEngine.Transform val_17 = this.content.GetChild(index:  0);
        UnityEngine.Transform val_18 = this.content.GetComponent<UnityEngine.Transform>();
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
        val_32 = val_20;
        this.content.localScale = new UnityEngine.Vector3() {x = val_32, y = val_21, z = val_22};
        if(val_34 >= this.pageCount)
        {
            goto label_22;
        }
        
        val_34 = 1;
        label_17:
        UnityEngine.Transform val_23 = this.content.transform;
        if(val_34 < this.content.childCount)
        {
            goto label_25;
        }
        
        val_35 = 0;
        goto label_26;
        label_31:
        val_32 = this.pageCount;
        UnityEngine.GameObject val_32 = this.pageDots[val_35];
        if(val_35 >= val_32)
        {
                0 = 0;
        }
        
        if(val_35 < val_32)
        {
                0 = 1;
        }
        
        val_32.SetActive(value:  true);
        val_35 = 1;
        label_26:
        if(val_35 < val_32)
        {
            goto label_31;
        }
        
        Weight val_25 = this.scrollView.GetComponent<Weight>();
        this.scrollView.UpdateContent();
        return;
        label_22:
        UnityEngine.Transform val_26 = this.content.transform;
        UnityEngine.Transform val_27 = this.content.GetChild(index:  0);
        UnityEngine.GameObject val_28 = this.content.gameObject;
        this.content.SetActive(value:  false);
        UnityEngine.Transform val_29 = this.content.transform;
        UnityEngine.Transform val_30 = this.content.GetChild(index:  0);
        UnityEngine.Transform val_31 = this.fakeContent.transform;
        this.content.SetParent(p:  this.fakeContent);
    }
    public SelectLevelPopup()
    {
    
    }
    private void <Start>b__9_0()
    {
        this.CloseClick();
    }

}
