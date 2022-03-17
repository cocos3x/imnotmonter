using UnityEngine;
public class HomeMenu : SingletonUI<HomeMenu>
{
    // Fields
    public Spine.Unity.SkeletonGraphic character;
    public Spine.Unity.SkeletonGraphic huggy;
    private UnityEngine.RectTransform rectChar;
    private UnityEngine.RectTransform rectHuggy;
    private UnityEngine.GameObject handRed;
    private UnityEngine.GameObject handBlue;
    private string currentAnimationState;
    private int indexShowCharacterMain;
    private float posCache;
    public static bool isShowLottery;
    private string linkAnimMode;
    private DG.Tweening.Tweener characterTweener;
    private DG.Tweening.Tweener huggyTweener;
    
    // Methods
    public override void Init(object[] initParams)
    {
        this.Init(initParams:  initParams);
    }
    private void Start()
    {
        var val_9;
        UnityEngine.GameObject val_1 = this.huggy.gameObject;
        this.huggy.SetActive(value:  false);
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        string val_3 = val_2.m_Handle.name;
        if((System.String.op_Equality(a:  812694044, b:  -1610607723)) == false)
        {
                return;
        }
        
        if(mem[536887881] == 0)
        {
            goto label_6;
        }
        
        mem2[0] = 0;
        val_9 = 22791764;
        goto label_17;
        label_6:
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266339] + 8) == 0)
        {
            goto label_12;
        }
        
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IsOldUser) == false)
        {
            goto label_14;
        }
        
        label_12:
        val_9 = 22791776;
        goto label_17;
        label_14:
        val_9 = 22791756;
        label_17:
        AFramework.UI.BaseUIMenu val_8 = AFramework.UI.CanvasManager.Push(identifier:  -1610605291, initParams:  null);
    }
    private void OnEnable()
    {
        var val_3;
        var val_4;
        val_3 = 536884619;
        if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
        {
                val_3 = 536884619;
        }
        
        536873257 = new System.Action<SdkConfiguration>(object:  812822160, method:  new IntPtr(1610681703));
        System.Delegate val_2 = System.Delegate.Combine(a:  mem[536884711] + 28, b:  536873257);
        val_4 = mem[536884711] + 28;
        if(val_4 != 0)
        {
                if(val_4 == 536873257)
        {
            goto label_4;
        }
        
        }
        
        val_4 = 0;
        label_4:
        mem2[0] = val_4;
    }
    private void OnDisable()
    {
        var val_3;
        var val_4;
        val_3 = 536884619;
        if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
        {
                val_3 = 536884619;
        }
        
        536873257 = new System.Action<SdkConfiguration>(object:  812934160, method:  new IntPtr(1610681703));
        System.Delegate val_2 = System.Delegate.Remove(source:  mem[536884711] + 28, value:  536873257);
        val_4 = mem[536884711] + 28;
        if(val_4 != 0)
        {
                if(val_4 == 536873257)
        {
            goto label_4;
        }
        
        }
        
        val_4 = 0;
        label_4:
        mem2[0] = val_4;
    }
    private void CheckPushedPopup(AFramework.UI.BaseUIMenu baseUI)
    {
        if((this.CheckInfoBaseUI(globalUIInfo:  -1610605291, baseUI:  baseUI)) != true)
        {
                if((this.CheckInfoBaseUI(globalUIInfo:  -1610605277, baseUI:  baseUI)) != true)
        {
                if((this.CheckInfoBaseUI(globalUIInfo:  -1610605293, baseUI:  baseUI)) == false)
        {
            goto label_3;
        }
        
        }
        
        }
        
        UnityEngine.GameObject val_4 = this.character.gameObject;
        this.character.SetActive(value:  true);
        AFramework.UI.BaseUIMenu val_11 = baseUI;
        val_11 = (this.CheckInfoBaseUI(globalUIInfo:  -1610605293, baseUI:  val_11)) ^ 1;
        this.CheckMode(isHome:  this.character.CheckInfoBaseUI(globalUIInfo:  -1610605291, baseUI:  baseUI), changePos:  val_11);
        return;
        label_3:
        if((this.CheckInfoBaseUI(globalUIInfo:  -1610605279, baseUI:  baseUI)) == true)
        {
                return;
        }
        
        if((this.CheckInfoBaseUI(globalUIInfo:  -1610605297, baseUI:  baseUI)) == true)
        {
                return;
        }
        
        if((this.CheckInfoBaseUI(globalUIInfo:  -1610605285, baseUI:  baseUI)) != false)
        {
                return;
        }
        
        UnityEngine.GameObject val_10 = this.character.gameObject;
        this.character.SetActive(value:  false);
    }
    private bool CheckInfoBaseUI(string globalUIInfo, AFramework.UI.BaseUIMenu baseUI)
    {
        string val_1 = baseUI.name;
        mem[536881809] = 47;
        System.String[] val_2 = globalUIInfo.Split(separator:  536881793);
        string val_3 = 22778344 + -1610612003(-1610612003);
        return System.String.op_Equality(a:  baseUI, b:  22778344);
    }
    private void CheckMode(bool isHome, bool changePos)
    {
        var val_5;
        var val_6;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_2 = -1073708883.GameMode;
        if(val_2 != 1)
        {
            goto label_2;
        }
        
        this.handRed.SetActive(value:  false);
        this.handBlue.SetActive(value:  false);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(methodName:  -1610604627);
        val_5 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_5 = 536884781;
        }
        
        label_12:
        this.linkAnimMode = mem[536884873] + 28;
        this.SetAnimSit(value:  isHome, changePos:  changePos);
        return;
        label_2:
        if(val_2 != 0)
        {
                return;
        }
        
        this.handRed.SetActive(value:  true);
        this.handBlue.SetActive(value:  true);
        UnityEngine.Coroutine val_4 = this.StartCoroutine(methodName:  -1610604627);
        val_6 = 536884781;
        if(((mem[536884968] & true) != 0) || (mem[536884897] != 0))
        {
            goto label_12;
        }
        
        val_6 = 536884781;
        goto label_12;
    }
    private System.Collections.IEnumerator SetSkin()
    {
        536899289 = new HomeMenu.<SetSkin>d__18(<>1__state:  0);
        mem[536899305] = this;
    }
    private void SetAnimation(string name, bool loop, float timeScale = 1, System.Action _callBack)
    {
        var val_1;
        AnimationState.TrackEntryDelegate val_7;
        HomeMenu.<>c__DisplayClass19_0 val_2 = 536899285;
        val_2 = new HomeMenu.<>c__DisplayClass19_0();
        val_7 = val_2;
        mem[536899293] = val_1;
        if((System.String.op_Equality(a:  name, b:  this.currentAnimationState)) != false)
        {
                return;
        }
        
        Spine.AnimationState val_4 = this.character.AnimationState;
        Spine.TrackEntry val_5 = this.character.SetAnimation(trackIndex:  0, animationName:  name, loop:  loop);
        mem2[0] = _callBack;
        if(mem[536899293] != 0)
        {
                val_7 = 536897929;
            val_7 = new AnimationState.TrackEntryDelegate(object:  536899285, method:  new IntPtr(1610681747));
            this.character.add_Complete(value:  536897929);
        }
        
        this.currentAnimationState = name;
    }
    public void ShowSkinSlect(int skinid)
    {
        Spine.Skeleton val_1 = this.character.Skeleton;
        string val_2 = skinid.ToString();
        this.character.SetSkin(skinName:  813712916);
        Spine.Skeleton val_3 = this.character.Skeleton;
        this.character.SetSlotsToSetupPose();
        this.character.LateUpdate();
    }
    public void ShowHuggySkinSlect(int skinid)
    {
        Spine.Skeleton val_1 = this.huggy.Skeleton;
        string val_2 = skinid.ToString();
        this.huggy.SetSkin(skinName:  813849492);
        Spine.Skeleton val_3 = this.huggy.Skeleton;
        this.huggy.SetSlotsToSetupPose();
        this.huggy.LateUpdate();
    }
    public void ShowSelectedSkin()
    {
        Spine.Skeleton val_1 = this.character.Skeleton;
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_4 = -1073708883.SkinSelectedID.ToString();
        this.character.SetSkin(skinName:  813986068);
        Spine.Skeleton val_5 = this.character.Skeleton;
        this.character.SetSlotsToSetupPose();
        this.character.LateUpdate();
    }
    public void ShowHuggySelectedSkin()
    {
        Spine.Skeleton val_1 = this.huggy.Skeleton;
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_4 = -1073708883.SkinHuggySelectedID.ToString();
        this.huggy.SetSkin(skinName:  814122644);
        Spine.Skeleton val_5 = this.huggy.Skeleton;
        this.huggy.SetSlotsToSetupPose();
        this.huggy.LateUpdate();
    }
    public void ShowMainSkin(bool IsShowPlayer, bool playerSit, System.Action _callBack)
    {
        float val_13;
        HomeMenu val_27;
        System.Action val_28;
        float val_29;
        DG.Tweening.TweenCallback val_30;
        var val_31;
        int val_32;
        var val_33;
        var val_34;
        val_27 = this;
        val_28 = _callBack;
        val_29 = playerSit;
        val_30 = IsShowPlayer;
        HomeMenu.<>c__DisplayClass26_0 val_1 = 536899287;
        val_31 = val_1;
        val_1 = new HomeMenu.<>c__DisplayClass26_0();
        if(val_31 != 0)
        {
                mem[536899295] = val_28;
        }
        else
        {
                mem[8] = val_28;
        }
        
        mem[536899299] = val_27;
        val_32 = this.indexShowCharacterMain;
        if(val_30 == false)
        {
            goto label_3;
        }
        
        if(val_32 == 0)
        {
            goto label_4;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.characterTweener, complete:  false);
        DG.Tweening.TweenExtensions.Kill(t:  this.huggyTweener, complete:  false);
        this.indexShowCharacterMain = 0;
        if(val_29 == true)
        {
                3278569472 = 3281911808;
        }
        
        this.rectChar.anchoredPosition = new UnityEngine.Vector2() {x = this.posCache ^ 2147483648, y = -316f};
        UnityEngine.GameObject val_3 = this.rectChar.gameObject;
        this.rectChar.SetActive(value:  true);
        this.rectHuggy.localScale = new UnityEngine.Vector3() {x = 1.2f, y = 1.2f, z = 1.2f};
        DG.Tweening.Tweener val_4 = DG.Tweening.DOTweenModuleUI.DOAnchorPosX(target:  this.rectChar, endValue:  0f = 3274964992, duration:  null, snapping:  false);
        DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.rectChar, ease:  1);
        536895905 = new DG.Tweening.TweenCallback(object:  536899287, method:  new IntPtr(1610681751));
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.rectChar, action:  536895905);
        this.characterTweener = this.rectChar;
        DG.Tweening.Tweener val_8 = DG.Tweening.DOTweenModuleUI.DOAnchorPosX(target:  this.rectHuggy, endValue:  0f, duration:  null, snapping:  this.posCache);
        DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.rectHuggy, ease:  1);
        536895905 = new DG.Tweening.TweenCallback(object:  536899287, method:  new IntPtr(1610681753));
        DG.Tweening.Tweener val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.rectHuggy, action:  536895905);
        this.huggyTweener = this.rectHuggy;
        val_32 = 1152921509716110172;
        label_3:
        if(val_32 == 1)
        {
            goto label_15;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  R4 + 72, complete:  false);
        val_34 = R4;
        DG.Tweening.TweenExtensions.Kill(t:  R4 + 76, complete:  false);
        mem2[0] = 1;
        UnityEngine.Vector2 val_12 = anchoredPosition;
        R4 + 76 + -32.anchoredPosition = new UnityEngine.Vector2() {x = (R4 + 76 + -12) ^ 2147483648, y = val_13};
        UnityEngine.GameObject val_15 = R4 + 44.gameObject;
        R4 + 44.SetActive(value:  true);
        DG.Tweening.Tweener val_16 = DG.Tweening.DOTweenModuleUI.DOAnchorPosX(target:  R4 + 44, endValue:  val_12.x, duration:  val_12.y, snapping:  false);
        DG.Tweening.Tweener val_17 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  R4 + 44, ease:  1);
        val_29 = 4.015415E-38f;
        536895905 = new DG.Tweening.TweenCallback(object:  R5, method:  new IntPtr(1610681755));
        val_33 = 22768396;
        DG.Tweening.Tweener val_19 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  R4 + 44, action:  536895905);
        mem2[0] = R4 + 44;
        DG.Tweening.Tweener val_20 = DG.Tweening.DOTweenModuleUI.DOAnchorPosX(target:  R4 + 40, endValue:  val_12.x, duration:  val_12.y, snapping:  R4 + 64);
        DG.Tweening.Tweener val_21 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  R4 + 40, ease:  1);
        val_28 = R4 + 40;
        val_30 = 536895905;
        val_30 = new DG.Tweening.TweenCallback(object:  R5, method:  new IntPtr(1610681757));
        DG.Tweening.Tweener val_23 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  val_28, action:  536895905);
        mem2[0] = val_28;
        goto label_15;
        label_4:
        if(val_29 != false)
        {
                this.SetAnimSit(value:  true, changePos:  false);
            this.rectChar.anchoredPosition = new UnityEngine.Vector2() {x = -180f, y = -316f};
            return;
        }
        
        label_15:
        var val_24 = FP - 40;
        val_24 = val_24 + 4;
    }
    public void MoveCharAndHuggyInGacha()
    {
        DG.Tweening.TweenExtensions.Kill(t:  this.characterTweener, complete:  false);
        DG.Tweening.TweenExtensions.Kill(t:  this.huggyTweener, complete:  false);
        UnityEngine.GameObject val_1 = this.rectChar.gameObject;
        this.rectChar.SetActive(value:  true);
        UnityEngine.GameObject val_2 = this.rectHuggy.gameObject;
        this.rectHuggy.SetActive(value:  true);
        this.indexShowCharacterMain = 1;
        this.SetAnimSit(value:  false, changePos:  false);
        DG.Tweening.Tweener val_3 = DG.Tweening.DOTweenModuleUI.DOAnchorPos(target:  this.rectChar, endValue:  new UnityEngine.Vector2() {x = -400f, y = -345f}, duration:  null, snapping:  true);
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.rectChar, ease:  1);
        this.characterTweener = this.rectChar;
        this.rectHuggy.localScale = new UnityEngine.Vector3() {x = -1.2f, y = 1.2f, z = 1.2f};
        DG.Tweening.Tweener val_5 = DG.Tweening.DOTweenModuleUI.DOAnchorPos(target:  this.rectHuggy, endValue:  new UnityEngine.Vector2() {x = 400f, y = -345f}, duration:  null, snapping:  true);
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.rectHuggy, ease:  1);
        this.huggyTweener = this.rectHuggy;
    }
    private void SetAnimSit(bool value, bool changePos = False)
    {
        var val_3;
        var val_4;
        UnityEngine.GameObject val_5;
        var val_6;
        var val_7;
        var val_8;
        val_3 = 22999557;
        if(value != false)
        {
                val_4 = 536884781;
            if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_4 = 536884781;
        }
        
            string val_1 = mem[536884873] + 28(mem[536884873] + 28) + mem[536884873] + 4(mem[536884873] + 4);
            this.SetAnimation(name:  mem[536884873] + 28, loop:  true, timeScale:  null, _callBack:  1065353216);
            this.handRed.SetActive(value:  false);
            val_5 = this.handBlue;
            val_5.SetActive(value:  false);
            if(changePos == false)
        {
                return;
        }
        
            val_6 = 49972;
            val_6 = 3274964992;
            val_7 = 50078;
            val_7 = 3281911808;
        }
        else
        {
                val_5 = this.linkAnimMode;
            val_8 = 536884781;
            if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_8 = 536884781;
        }
        
            val_3 = 0;
            string val_2 = val_5 + mem[536884873];
            this.SetAnimation(name:  val_5, loop:  true, timeScale:  null, _callBack:  1065353216);
            if(changePos == false)
        {
                return;
        }
        
            val_7 = 50027;
            val_7 = 3278569472;
            val_6 = 0;
        }
        
        this.rectChar.anchoredPosition = new UnityEngine.Vector2() {x = 0f, y = -235f};
    }
    public HomeMenu()
    {
        this.posCache = 1184f;
        this.linkAnimMode = -1610612735;
    }
    private bool <SetSkin>b__18_0()
    {
        if((mem[536891408] & true) != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.character);
        }
        
        if(mem[536891337] != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.character);
        }
        
        return UnityEngine.Object.op_Implicit(exists:  this.character);
    }
    private bool <SetSkin>b__18_1()
    {
        if((mem[536891408] & true) != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.huggy);
        }
        
        if(mem[536891337] != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.huggy);
        }
        
        return UnityEngine.Object.op_Implicit(exists:  this.huggy);
    }

}
