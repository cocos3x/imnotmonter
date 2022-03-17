using UnityEngine;
public class WinPopup : SingletonUI<WinPopup>
{
    // Fields
    public static bool canShowChest;
    private UnityEngine.RectTransform arrowTrans;
    private UnityEngine.RectTransform min;
    private UnityEngine.RectTransform max;
    private UnityEngine.UI.Button backHomeButton;
    private UnityEngine.UI.Button btnAdsChest;
    private UnityEngine.UI.Button btnFreeChest;
    private UnityEngine.UI.Button btnLoseChest;
    private bool canMove;
    private bool canshowLosetit;
    private string characterMode;
    private UnityEngine.Transform chestEndPos;
    private UnityEngine.Transform chestStartPos;
    private UnityEngine.Transform chestStartPosAds;
    private TMPro.TextMeshProUGUI coinChestTxt;
    private UnityEngine.Transform coinHolder;
    private UnityEngine.Transform coinStartPos;
    private UnityEngine.Transform coinTargetPos;
    private TMPro.TextMeshProUGUI coinTxt;
    private int coinWin;
    private UnityEngine.Transform coinX2StartPos;
    private UnityEngine.GameObject content;
    private UnityEngine.GameObject effectTextWin;
    private UnityEngine.GameObject freeChestReward;
    private UnityEngine.Transform freeChestRewardEnd;
    private UnityEngine.Transform freeChestRewardStart;
    private UnityEngine.UI.Button getRewardSkinBtn;
    private int idMove;
    private int idSkinReward;
    private UnityEngine.GameObject lightEff;
    private UnityEngine.UI.Button nextLevelButton;
    private UnityEngine.UI.Button noThankRewardBtn;
    private UnityEngine.GameObject objChest;
    private UnityEngine.GameObject objProgress;
    private UnityEngine.GameObject rewardSkinPopup;
    private UnityEngine.GameObject imgTapeReward;
    private Spine.Unity.SkeletonGraphic skeletonChestAds;
    private Spine.Unity.SkeletonGraphic skeletonChestFree;
    private Spine.Unity.SkeletonGraphic skeletonSkin;
    private Spine.Unity.SkeletonGraphic skeletonSkinReward;
    private UnityEngine.UI.Button skinBtn;
    private UnityEngine.GameObject skinNotifi;
    private UnityEngine.UI.Image skinProgressLine;
    private UnityEngine.UI.Button SpinBtn;
    private TMPro.TextMeshProUGUI tapChestTxt;
    private UnityEngine.GameObject tapeReward;
    private UnityEngine.Transform tapeStartPos;
    private UnityEngine.Transform tapeTargetPos;
    private float timeMove;
    private TMPro.TextMeshProUGUI txt_ValueProgressSkin;
    private Spine.Unity.SkeletonGraphic victoryTextSkeleton;
    private bool watchedAds;
    private UnityEngine.UI.Button x2RewardBtn;
    private TMPro.TextMeshProUGUI x2RewardTxt;
    private readonly int[] coinFreeValues;
    private readonly int[] tapFreeValues;
    
    // Methods
    private void Start()
    {
        536896275 = new UnityEngine.Events.UnityAction(object:  792245136, method:  new IntPtr(1610681371));
        this.nextLevelButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  792245136, method:  new IntPtr(1610681373));
        this.x2RewardBtn.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  792245136, method:  new IntPtr(1610681375));
        this.backHomeButton.m_OnClick.AddListener(call:  536896275);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  792245136, method:  new IntPtr(1610681377));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  792245136, eventID:  24, callback:  536873423);
        536896275 = new UnityEngine.Events.UnityAction(object:  792245136, method:  new IntPtr(1610681379));
        this.SpinBtn.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  792245136, method:  new IntPtr(1610681381));
        this.skinBtn.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  792245136, method:  new IntPtr(1610681383));
        this.getRewardSkinBtn.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  792245136, method:  new IntPtr(1610681385));
        this.noThankRewardBtn.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  792245136, method:  new IntPtr(1610681387));
        this.btnFreeChest.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  792245136, method:  new IntPtr(1610681389));
        this.btnAdsChest.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  792245136, method:  new IntPtr(1610681391));
        this.btnLoseChest.m_OnClick.AddListener(call:  536896275);
    }
    private System.Collections.IEnumerator ShowVictoryText()
    {
        536902517 = new WinPopup.<ShowVictoryText>d__55(<>1__state:  0);
        mem[536902533] = this;
    }
    private void OnEnable()
    {
        float val_110;
        float val_112;
        var val_117;
        var val_118;
        var val_119;
        var val_120;
        var val_121;
        var val_122;
        var val_123;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        mem[3221258461] = 1;
        this.watchedAds = false;
        this.canMove = false;
        this.objProgress.SetActive(value:  false);
        this.CheckMode();
        string val_2 = this.coinWin.ToString();
        string val_3 = -1610611917(-1610611917) + this.coinWin;
        this.coinTxt.text = -1610611917;
        System.Collections.IEnumerator val_4 = this.ShowVictoryText();
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  792587920);
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        System.Collections.Generic.List<System.Int32> val_7 = -1073708883.ListSkinUnlocked;
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        if(mem[3221258425] < mem[3221258425])
        {
            goto label_7;
        }
        
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        System.Collections.Generic.List<System.Int32> val_10 = -1073708883.ListHuggyUnlocked;
        object val_11 = AFramework.ManualSingletonMono<System.Object>.I;
        if(mem[3221258425] >= mem[3221258429])
        {
            goto label_11;
        }
        
        label_7:
        UnityEngine.GameObject val_13 = this.skinNotifi.gameObject;
        if((UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  100)) > 70)
        {
            goto label_14;
        }
        
        val_117 = 1;
        goto label_15;
        label_11:
        UnityEngine.GameObject val_14 = this.skinNotifi.gameObject;
        label_14:
        val_117 = 0;
        label_15:
        this.skinNotifi.SetActive(value:  false);
        WorldTimeAPI val_15 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610602639, volume:  null);
        if(((SingletonMonoBehaviour<TransitionFX>.Exists()) == false) || ((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) == false))
        {
            goto label_20;
        }
        
        object val_18 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_20 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CurrentLevelPinPull) <= (-1073708883.LevelPinPullUnlocked))
        {
            goto label_38;
        }
        
        object val_22 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_23 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.LevelPinPullUnlocked = -1073708883.CurrentLevelPinPull;
        WorldTimeAPI val_25 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266339] + 8) == 0)
        {
            goto label_28;
        }
        
        object val_26 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IsOldUser) == false)
        {
            goto label_38;
        }
        
        label_28:
        WorldTimeAPI val_28 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266315] + 24 + 12) == 0)
        {
            goto label_38;
        }
        
        WorldTimeAPI val_29 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        var val_113 = 0;
        val_118 = (mem[3221266315] + 24) + 16;
        label_41:
        if(val_113 >= (mem[3221266315] + 24 + 12))
        {
            goto label_38;
        }
        
        object val_30 = AFramework.ManualSingletonMono<System.Object>.I;
        val_113 = val_113 + 1;
        if((-1073708883.CurrentLevelPinPull) != ((mem[3221266315] + 24 + 16) + 0))
        {
            goto label_41;
        }
        
        mem2[0] = 1;
        label_38:
        object val_32 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_119 = -1073708883.CurrentLevelPinPull;
        }
        else
        {
                val_119 = -1073708883.CurrentLevelPinPull;
        }
        
        -1073708883.CurrentLevelPinPull = val_119 + 1;
        label_20:
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
            goto label_80;
        }
        
        object val_37 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_39 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CurrentLevelRope) <= (-1073708883.LevelRopeUnlocked))
        {
            goto label_62;
        }
        
        object val_41 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_42 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.LevelRopeUnlocked = -1073708883.CurrentLevelRope;
        WorldTimeAPI val_44 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266339] + 8) == 0)
        {
            goto label_52;
        }
        
        object val_45 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IsOldUser) == false)
        {
            goto label_62;
        }
        
        label_52:
        WorldTimeAPI val_47 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266315] + 20 + 12) == 0)
        {
            goto label_62;
        }
        
        WorldTimeAPI val_48 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        var val_114 = 0;
        val_118 = (mem[3221266315] + 20) + 16;
        label_65:
        if(val_114 >= (mem[3221266315] + 20 + 12))
        {
            goto label_62;
        }
        
        object val_49 = AFramework.ManualSingletonMono<System.Object>.I;
        val_114 = val_114 + 1;
        if((-1073708883.CurrentLevelRope) != ((mem[3221266315] + 20 + 16) + 0))
        {
            goto label_65;
        }
        
        mem2[0] = 1;
        label_62:
        WorldTimeAPI val_51 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266339] + 8) == 0)
        {
            goto label_70;
        }
        
        object val_52 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IsOldUser) == true)
        {
            goto label_70;
        }
        
        WorldTimeAPI val_54 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_55 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_57 = (mem[3221266339] + 12) + ((-1073708883.CurrentLevel) << 2);
        if(((mem[3221266339] + 12 + (val_56) << 2) + 16) != 0)
        {
                object val_58 = AFramework.ManualSingletonMono<System.Object>.I;
            if((-1073708883) != 0)
        {
                val_120 = -1073708883.CurrentLevelRope;
        }
        else
        {
                val_120 = -1073708883.CurrentLevelRope;
        }
        
            -1073708883.CurrentLevelRope = val_120 + 1;
        }
        
        object val_62 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_63 = -1073708883.CurrentLevelRope;
        val_63 = val_63 - 4294967290;
        if(val_63 != 0)
        {
            goto label_80;
        }
        
        label_70:
        object val_64 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_121 = -1073708883.CurrentLevelRope;
        }
        else
        {
                val_121 = -1073708883.CurrentLevelRope;
        }
        
        -1073708883.CurrentLevelRope = val_121 + 1;
        label_80:
        if(((SingletonMonoBehaviour<TransitionFX>.Exists()) == false) || ((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) == false))
        {
            goto label_84;
        }
        
        object val_70 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_72 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CurrentLevelCutRope) <= (-1073708883.LevelCutRopeUnlocked))
        {
            goto label_102;
        }
        
        object val_74 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_75 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.LevelCutRopeUnlocked = -1073708883.CurrentLevelCutRope;
        WorldTimeAPI val_77 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266339] + 8) == 0)
        {
            goto label_92;
        }
        
        object val_78 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IsOldUser) == false)
        {
            goto label_102;
        }
        
        label_92:
        WorldTimeAPI val_80 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266315] + 20 + 12) == 0)
        {
            goto label_102;
        }
        
        WorldTimeAPI val_81 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        var val_115 = 0;
        val_118 = (mem[3221266315] + 20) + 16;
        label_105:
        if(val_115 >= (mem[3221266315] + 20 + 12))
        {
            goto label_102;
        }
        
        object val_82 = AFramework.ManualSingletonMono<System.Object>.I;
        val_115 = val_115 + 1;
        if((-1073708883.CurrentLevelCutRope) != ((mem[3221266315] + 20 + 16) + 0))
        {
            goto label_105;
        }
        
        mem2[0] = 1;
        label_102:
        object val_84 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_122 = -1073708883.CurrentLevelCutRope;
        }
        else
        {
                val_122 = -1073708883.CurrentLevelCutRope;
        }
        
        -1073708883.CurrentLevelCutRope = val_122 + 1;
        label_84:
        this.canshowLosetit = true;
        UnityEngine.GameObject val_88 = this.nextLevelButton.gameObject;
        this.nextLevelButton.SetActive(value:  false);
        this.x2RewardBtn.interactable = true;
        object val_89 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_123 = -1073708883.CurrentLevel;
        }
        else
        {
                val_123 = -1073708883.CurrentLevel;
        }
        
        -1073708883.CurrentLevel = val_123 + 1;
        WorldTimeAPI val_93 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266339] + 8) == 0)
        {
            goto label_130;
        }
        
        object val_94 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IsOldUser) == true)
        {
            goto label_130;
        }
        
        object val_96 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_98 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CurrentLevel) <= (-1073708883.CurrentLevelUnlocked))
        {
            goto label_130;
        }
        
        object val_100 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_101 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.CurrentLevelUnlocked = -1073708883.CurrentLevel;
        WorldTimeAPI val_103 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266315] + 28 + 12) == 0)
        {
            goto label_130;
        }
        
        WorldTimeAPI val_104 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        var val_116 = 0;
        val_118 = (mem[3221266315] + 20) + 16;
        label_133:
        if(val_116 >= (mem[3221266315] + 20 + 12))
        {
            goto label_130;
        }
        
        object val_105 = AFramework.ManualSingletonMono<System.Object>.I;
        val_116 = val_116 + 1;
        if((-1073708883.CurrentLevel) != ((mem[3221266315] + 20 + 16) + 0))
        {
            goto label_133;
        }
        
        mem2[0] = 1;
        label_130:
        System.Collections.IEnumerator val_107 = this.CoinMoves();
        UnityEngine.Coroutine val_108 = this.StartCoroutine(routine:  792587920);
        this.AddTracking();
        this.idMove = 1;
        UnityEngine.Vector2 val_109 = anchoredPosition;
        UnityEngine.Vector2 val_111 = anchoredPosition;
        this.arrowTrans.anchoredPosition = new UnityEngine.Vector2() {x = val_110, y = val_112};
        this.MoveArrow();
        this.Invoke(methodName:  -1610604573, time:  val_111.x);
        this.Invoke(methodName:  -1610604585, time:  val_111.x);
    }
    private void CheckDailyReward()
    {
        var val_16;
        var val_21;
        var val_22;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266339] + 8) == 0)
        {
            goto label_3;
        }
        
        val_21 = 22740800;
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IsOldUser) == false)
        {
            goto label_5;
        }
        
        label_3:
        val_21 = 22740800;
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_22 = mem[3221266267];
        if((-1073708883.LevelPinPullUnlocked) >= (mem[3221266267] + 20))
        {
            goto label_9;
        }
        
        object val_7 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_8 = -1073708883.LevelRopeUnlocked;
        goto label_11;
        label_5:
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        label_11:
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_22 = -1073701053;
        if((-1073708883.CurrentLevel) < (mem[3221266267] + 20))
        {
                return;
        }
        
        label_9:
        object val_12 = AFramework.ManualSingletonMono<System.Object>.I;
        System.DateTime val_14 = System.DateTime.Now;
        if(val_21.DayClamReward == val_16.DayOfYear)
        {
                return;
        }
        
        object val_18 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IndexOfDayDaily) > 6)
        {
                return;
        }
        
        AFramework.UI.BaseUIMenu val_20 = AFramework.UI.CanvasManager.Push(identifier:  -1610605297, initParams:  null);
        this.content.SetActive(value:  false);
    }
    private void Update()
    {
        if(this.canMove == true)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.arrowTrans)) == false)
        {
                return;
        }
        
        int val_2 = this.ValueCoinGet();
        val_2 = val_2 * this.coinWin;
        string val_3 = val_2.ToString();
        string val_4 = -1610611917(-1610611917) + 792853140;
        this.x2RewardTxt.text = -1610611917;
    }
    private void MoveArrow()
    {
        float val_3;
        float val_5;
        var val_14;
        UnityEngine.RectTransform val_15;
        DG.Tweening.Tweener val_16;
        DG.Tweening.TweenCallback val_17;
        var val_18;
        if(this.canMove == true)
        {
                return;
        }
        
        int val_1 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.arrowTrans, complete:  false);
        if(this.idMove != 0)
        {
                val_14 = 0;
            UnityEngine.Vector2 val_2 = anchoredPosition;
            val_15 = this.arrowTrans;
            UnityEngine.Vector2 val_4 = anchoredPosition;
            DG.Tweening.Tweener val_6 = DG.Tweening.DOTweenModuleUI.DOAnchorPos(target:  this.arrowTrans, endValue:  new UnityEngine.Vector2() {x = val_3, y = val_5}, duration:  val_4.x, snapping:  this.timeMove);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.arrowTrans, ease:  1);
            val_16 = this.arrowTrans;
            val_17 = 536895905;
            val_18 = 22770096;
        }
        else
        {
                val_14 = 0;
            UnityEngine.Vector2 val_8 = anchoredPosition;
            val_15 = this.arrowTrans;
            UnityEngine.Vector2 val_9 = anchoredPosition;
            DG.Tweening.Tweener val_10 = DG.Tweening.DOTweenModuleUI.DOAnchorPos(target:  this.arrowTrans, endValue:  new UnityEngine.Vector2() {x = val_3, y = val_5}, duration:  val_9.x, snapping:  this.timeMove);
            DG.Tweening.Tweener val_11 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.arrowTrans, ease:  1);
            val_16 = this.arrowTrans;
            val_17 = 536895905;
            val_18 = 22770092;
        }
        
        val_17 = new DG.Tweening.TweenCallback(object:  793009936, method:  new IntPtr(1610681397));
        DG.Tweening.Tweener val_13 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  val_16, action:  536895905);
    }
    public override void Init(object[] initParams)
    {
        this.Init(initParams:  initParams);
    }
    private void OpenHome()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536873261 = new System.Action<System.Boolean>(object:  793332240, method:  new IntPtr(1610681401));
        -1073701127.ShowFull(onClosed:  536873261, interPlaceID:  5);
    }
    private void AddTracking()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CurrentLevelUnlocked) == (-1073708883.CurrentLevel))
        {
                WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            if((mem[3221266339] + 8) != 0)
        {
                object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
            if((-1073708883.IsOldUser) != true)
        {
                WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
            string val_11 = -1073708883.CurrentLevel.ToString();
            string val_12 = -1610606559(-1610606559) + 793432212;
            -1073700879.TrackEvent(eventName:  -1610606559);
        }
        
        }
        
        }
        
        WorldTimeAPI val_13 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266339] + 8) != 0)
        {
                object val_14 = AFramework.ManualSingletonMono<System.Object>.I;
            if((-1073708883.IsOldUser) == false)
        {
                return;
        }
        
        }
        
        object val_16 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_17 = -1073708883.GameMode;
        if(val_17 == 2)
        {
            goto label_17;
        }
        
        if(val_17 == 1)
        {
            goto label_18;
        }
        
        if(val_17 != 0)
        {
                return;
        }
        
        object val_18 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_20 = AFramework.ManualSingletonMono<System.Object>.I;
        if(((-1073708883.LevelRopePlayed) + 1) == (-1073708883.CurrentLevelRope))
        {
                WorldTimeAPI val_23 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            object val_24 = AFramework.ManualSingletonMono<System.Object>.I;
            string val_26 = -1073708883.LevelRopePlayed.ToString();
            string val_27 = -1610605109(-1610605109) + 793432208;
            -1073700879.TrackEvent(eventName:  -1610605109);
        }
        
        object val_28 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_29 = -1073708883.CurrentLevelRope;
        goto label_30;
        label_17:
        WorldTimeAPI val_30 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_31 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_33 = -1073708883.LevelCutRopePlayed.ToString();
        string val_34 = -1610609735(-1610609735) + 793432208;
        -1073700879.TrackEvent(eventName:  -1610609735);
        object val_35 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_36 = -1073708883.CurrentLevelCutRope;
        goto label_30;
        label_18:
        WorldTimeAPI val_37 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_38 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_40 = -1073708883.LevelPinPullPlayed.ToString();
        string val_41 = -1610605493(-1610605493) + 793432208;
        -1073700879.TrackEvent(eventName:  -1610605493);
        object val_42 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_43 = -1073708883.CurrentLevelPinPull;
        label_30:
        val_43 = val_43 - 4294967290;
        if(val_43 != 0)
        {
                return;
        }
        
        WorldTimeAPI val_44 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701127.RequestReview();
    }
    private void CheckMode()
    {
        var val_20;
        var val_21;
        var val_22;
        int val_23;
        var val_24;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.GameMode) == 0)
        {
            goto label_2;
        }
        
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.GameMode) != 1)
        {
            goto label_4;
        }
        
        val_20 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_20 = 536884781;
        }
        
        this.characterMode = mem[536884873] + 28;
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_6 = -1073708883.PinPullCoinReward;
        goto label_26;
        label_2:
        UnityEngine.GameObject val_7 = this.tapeReward.gameObject;
        this.tapeReward.SetActive(value:  false);
        val_22 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_22 = 536884781;
        }
        
        this.characterMode = mem[536884873] + 24;
        WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        LevelRopeType val_9 = -1073700979.GetLevelMode();
        val_23 = -1073700979;
        object val_10 = AFramework.ManualSingletonMono<System.Object>.I;
        if(val_23 != 2)
        {
            goto label_15;
        }
        
        if((-1073708883.RopeTapeBonusReward) >= 1)
        {
                UnityEngine.GameObject val_12 = this.tapeReward.gameObject;
            this.tapeReward.SetActive(value:  true);
        }
        
        val_23 = this.coinWin;
        object val_13 = AFramework.ManualSingletonMono<System.Object>.I;
        val_21 = (-1073708883.RopeCoinBonusReward) + val_23;
        goto label_26;
        label_4:
        object val_15 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.GameMode) != 2)
        {
                return;
        }
        
        val_24 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_24 = 536884781;
        }
        
        this.characterMode = mem[536884873] + 28;
        object val_17 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_18 = -1073708883.CutRopeCoinReward;
        goto label_26;
        label_15:
        label_26:
        this.coinWin = -1073708883.RopeCoinReward;
    }
    private void ShowLoseIt()
    {
        if(this.canshowLosetit == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_1 = this.nextLevelButton.gameObject;
        this.nextLevelButton.SetActive(value:  true);
        UnityEngine.GameObject val_2 = this.x2RewardBtn.gameObject;
        this.x2RewardBtn.SetActive(value:  true);
        UnityEngine.GameObject val_3 = this.backHomeButton.gameObject;
        this.backHomeButton.SetActive(value:  true);
    }
    private int ValueCoinGet()
    {
        var val_14;
        UnityEngine.Vector2 val_1 = anchoredPosition;
        UnityEngine.Vector2 val_3 = anchoredPosition;
        if(this.arrowTrans <= 0)
        {
                UnityEngine.Vector2 val_4 = anchoredPosition;
            val_14 = 2;
            if(this.arrowTrans <= 0)
        {
                return (int)val_14;
        }
        
        }
        
        UnityEngine.Vector2 val_5 = anchoredPosition;
        if(this.arrowTrans >= 0)
        {
                UnityEngine.Vector2 val_6 = anchoredPosition;
            val_14 = 3;
            if(this.arrowTrans <= 0)
        {
                return (int)val_14;
        }
        
        }
        
        UnityEngine.Vector2 val_7 = anchoredPosition;
        if(this.arrowTrans >= 0)
        {
                UnityEngine.Vector2 val_8 = anchoredPosition;
            val_14 = 5;
            if(this.arrowTrans <= 0)
        {
                return (int)val_14;
        }
        
        }
        
        UnityEngine.Vector2 val_9 = anchoredPosition;
        if(this.arrowTrans >= 0)
        {
                UnityEngine.Vector2 val_10 = anchoredPosition;
            val_14 = 3;
            if(this.arrowTrans <= 0)
        {
                return (int)val_14;
        }
        
        }
        
        UnityEngine.Vector2 val_11 = anchoredPosition;
        val_14 = 2;
        if(this.arrowTrans < 0)
        {
                return (int)val_14;
        }
        
        UnityEngine.Vector2 val_12 = anchoredPosition;
        UnityEngine.Vector2 val_13 = anchoredPosition;
        return (int)val_14;
    }
    private void NextLevelButtonClick()
    {
        var val_94;
        var val_95;
        System.Action<System.Boolean> val_96;
        var val_97;
        var val_98;
        var val_99;
        var val_100;
        val_94 = this;
        val_95 = 22740800;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.RopeTapeBonusReward = 0;
        if(mem[536887881] == 0)
        {
            goto label_2;
        }
        
        if(this.watchedAds == false)
        {
            goto label_3;
        }
        
        label_93:
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneHome();
        goto typeof(WinPopup).__il2cppRuntimeField_E4;
        label_2:
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266339] + 8) == 0)
        {
            goto label_7;
        }
        
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        if(R7.IsOldUser == false)
        {
            goto label_9;
        }
        
        label_7:
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        if(R7.GameMode != 0)
        {
            goto label_67;
        }
        
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_96 = mem[3221266267];
        if(R7.CurrentLevelRope > (mem[3221266267] + 16))
        {
                if((R4 + 228) == 0)
        {
            goto label_16;
        }
        
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
            goto label_25;
        }
        
        object val_12 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_14 = AFramework.ManualSingletonMono<System.Object>.I;
        val_96 = R7;
        if(R7.LevelRopeUnlocked < val_96.NumberRopeLevel)
        {
            goto label_20;
        }
        
        object val_16 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_18 = AFramework.ManualSingletonMono<System.Object>.I;
        val_96 = R7;
        if(R7.CurrentLevelRope >= val_96.NumberRopeLevel)
        {
            goto label_23;
        }
        
        label_20:
        WorldTimeAPI val_20 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700957.SpawLevel();
        goto label_25;
        label_3:
        WorldTimeAPI val_21 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        label_110:
        536873261 = new System.Action<System.Boolean>(object:  794031504, method:  new IntPtr(1610681403));
        -1073701127.ShowFull(onClosed:  536873261, interPlaceID:  3);
        return;
        label_9:
        object val_23 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_25 = AFramework.ManualSingletonMono<System.Object>.I;
        if(R7.CurrentLevel == R7.NumberMixLevel)
        {
            goto label_93;
        }
        
        WorldTimeAPI val_27 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_97 = mem[mem[3221266339] + 12];
        val_97 = mem[3221266339] + 12;
        object val_28 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_30 = val_97 + (R7.CurrentLevel << 2);
        if(((mem[3221266339] + 12 + (val_29) << 2) + 16) == 0)
        {
            goto label_35;
        }
        
        WorldTimeAPI val_31 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_97 = mem[mem[3221266339] + 12];
        val_97 = mem[3221266339] + 12;
        object val_32 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_34 = val_97 + (R7.CurrentLevel << 2);
        if(((mem[3221266339] + 12 + (val_33) << 2) + 16) != 1)
        {
            goto label_41;
        }
        
        if((R4 + 228) != 0)
        {
            goto label_48;
        }
        
        object val_35 = AFramework.ManualSingletonMono<System.Object>.I;
        WorldTimeAPI val_37 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_97 = mem[3221266267];
        if(R7.CurrentLevel <= (mem[3221266267] + 16))
        {
            goto label_48;
        }
        
        WorldTimeAPI val_38 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        goto label_110;
        label_35:
        if((R4 + 228) != 0)
        {
            goto label_48;
        }
        
        object val_39 = AFramework.ManualSingletonMono<System.Object>.I;
        WorldTimeAPI val_41 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_97 = mem[3221266267];
        if(R7.CurrentLevel >= (mem[3221266267] + 16))
        {
            goto label_52;
        }
        
        label_48:
        WorldTimeAPI val_42 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneRopeRescue();
        return;
        label_41:
        WorldTimeAPI val_43 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_98 = mem[mem[3221266339] + 12];
        val_98 = mem[3221266339] + 12;
        object val_44 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_46 = val_98 + (R7.CurrentLevel << 2);
        if(((mem[3221266339] + 12 + (val_45) << 2) + 16) != 2)
        {
            goto label_59;
        }
        
        if((R4 + 228) != 0)
        {
            goto label_64;
        }
        
        object val_47 = AFramework.ManualSingletonMono<System.Object>.I;
        WorldTimeAPI val_49 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_98 = mem[3221266267];
        if(R7.CurrentLevel <= (mem[3221266267] + 16))
        {
            goto label_64;
        }
        
        WorldTimeAPI val_50 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        goto label_110;
        label_16:
        WorldTimeAPI val_51 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_96 = 536873261;
        val_96 = new System.Action<System.Boolean>(object:  R4, method:  new IntPtr(1610681413));
        -1073701127.ShowFull(onClosed:  536873261, interPlaceID:  3);
        goto label_67;
        label_23:
        WorldTimeAPI val_53 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneHome();
        label_25:
        label_67:
        object val_54 = AFramework.ManualSingletonMono<System.Object>.I;
        if(R7.GameMode != 1)
        {
            goto label_82;
        }
        
        if((R4 + 228) == 0)
        {
            goto label_71;
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
            goto label_80;
        }
        
        object val_57 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_59 = AFramework.ManualSingletonMono<System.Object>.I;
        val_96 = R7;
        if(R7.LevelPinPullUnlocked < val_96.NumberPinpullLevel)
        {
            goto label_75;
        }
        
        object val_61 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_63 = AFramework.ManualSingletonMono<System.Object>.I;
        val_96 = R7;
        if(R7.CurrentLevelPinPull >= val_96.NumberPinpullLevel)
        {
            goto label_78;
        }
        
        label_75:
        WorldTimeAPI val_65 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701037.SpawnNextLevel();
        goto label_80;
        label_71:
        WorldTimeAPI val_66 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_96 = 536873261;
        val_96 = new System.Action<System.Boolean>(object:  R4, method:  new IntPtr(1610681415));
        -1073701127.ShowFull(onClosed:  536873261, interPlaceID:  3);
        goto label_82;
        label_78:
        WorldTimeAPI val_68 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneHome();
        label_80:
        label_82:
        object val_69 = AFramework.ManualSingletonMono<System.Object>.I;
        if(R7.GameMode != 2)
        {
                return;
        }
        
        if((R4 + 228) == 0)
        {
            goto label_86;
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
            goto typeof(WinPopup).__il2cppRuntimeField_E4;
        }
        
        object val_72 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_74 = AFramework.ManualSingletonMono<System.Object>.I;
        if(R7.LevelCutRopeUnlocked < R7.NumberCutRopeLevel)
        {
            goto label_90;
        }
        
        object val_76 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_78 = AFramework.ManualSingletonMono<System.Object>.I;
        if(R7.CurrentLevelCutRope >= R7.NumberCutRopeLevel)
        {
            goto label_93;
        }
        
        label_90:
        WorldTimeAPI val_80 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701079.SpawnNextLevel();
        goto typeof(WinPopup).__il2cppRuntimeField_E4;
        label_86:
        WorldTimeAPI val_81 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        goto label_110;
        label_59:
        WorldTimeAPI val_82 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_99 = mem[mem[3221266339] + 12];
        val_99 = mem[3221266339] + 12;
        object val_83 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_85 = val_99 + (R7.CurrentLevel << 2);
        if(((mem[3221266339] + 12 + (val_84) << 2) + 16) != 3)
        {
                return;
        }
        
        if((R4 + 228) != 0)
        {
            goto label_107;
        }
        
        object val_86 = AFramework.ManualSingletonMono<System.Object>.I;
        WorldTimeAPI val_88 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_100 = mem[3221266267];
        if(R7.CurrentLevel <= (mem[3221266267] + 16))
        {
            goto label_107;
        }
        
        WorldTimeAPI val_89 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        goto label_110;
        label_64:
        WorldTimeAPI val_90 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadScenePinPull();
        return;
        label_52:
        WorldTimeAPI val_91 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        goto label_110;
        label_107:
        WorldTimeAPI val_92 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneCutRescue();
    }
    private void GetX2RewardClick()
    {
        this.canMove = true;
        int val_1 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.arrowTrans, complete:  false);
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536873261 = new System.Action<System.Boolean>(object:  794147600, method:  new IntPtr(1610681419));
        -1073701127.ShowReward(callBack:  536873261, rewardPlaceID:  9);
    }
    private System.Collections.IEnumerator CoinMoves()
    {
        536902509 = new WinPopup.<CoinMoves>d__68(<>1__state:  0);
        mem[536902525] = this;
    }
    private System.Collections.IEnumerator CoinMovesX2()
    {
        536902511 = new WinPopup.<CoinMovesX2>d__69(<>1__state:  0);
        mem[536902527] = this;
    }
    private int GetIdSkinReward(bool checkFirst = True)
    {
        var val_1;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        goto label_0;
        label_46:
        if((val_1 + 12) >= 1)
        {
            goto label_2;
        }
        
        if((checkFirst & true) != 0)
        {
            goto label_3;
        }
        
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        System.Collections.Generic.List<System.Int32> val_3 = -1073708883.ListSkinProgressHasShow;
        -1073708883.Clear();
        label_0:
        var val_21 = 4526434;
        val_21 = 18473824 + val_21;
        536877987 = new System.Collections.Generic.List<System.Int32>();
        System.Collections.Generic.List<System.Int32> val_5 = 536877987;
        val_1 = val_5;
        val_5 = new System.Collections.Generic.List<System.Int32>();
        val_20 = 4;
        goto label_7;
        label_44:
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((-1073708883.CheckSkinUnlock(id:  mem[3221266291] + 8 + 16)) != true)
        {
                object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
            System.Collections.Generic.List<System.Int32> val_10 = -1073708883.ListSkinProgressHasShow;
            WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            if((-1073708883.Contains(item:  mem[3221266291] + 8 + 16)) != true)
        {
                WorldTimeAPI val_13 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            if((mem[3221266291] + 16 + 16) == 0)
        {
                WorldTimeAPI val_14 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            536877987.Add(item:  mem[3221266291] + 8 + 16);
        }
        
            WorldTimeAPI val_15 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            if((mem[3221266291] + 16 + 16) == 1)
        {
                WorldTimeAPI val_16 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_1.Add(item:  mem[3221266291] + 8 + 16);
        }
        
        }
        
        }
        
        val_20 = 5;
        label_7:
        WorldTimeAPI val_17 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((val_20 - 4) < (mem[3221266291] + 8 + 12))
        {
            goto label_44;
        }
        
        if(mem[536877999] < 1)
        {
            goto label_46;
        }
        
        val_21 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  mem[536877999]);
        if(mem[536877999] <= val_21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_22 = 536877987;
        goto label_48;
        label_2:
        val_21 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  val_1 + 12);
        if((val_1 + 12) <= val_21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_22 = val_1;
        label_48:
        var val_22 = val_1 + 8;
        val_22 = val_22 + (val_21 << 2);
        val_23 = mem[(val_1 + 8 + (val_20) << 2) + 16];
        val_23 = (val_1 + 8 + (val_20) << 2) + 16;
        return (int)val_23;
        label_3:
        val_23 = 0;
        return (int)val_23;
    }
    private System.Collections.IEnumerator SetSkinReward(int id)
    {
        WinPopup.<SetSkinReward>d__71 val_1 = 536902515;
        val_1 = new WinPopup.<SetSkinReward>d__71(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536902531] = this;
        }
        else
        {
                mem[16] = this;
        }
        
        mem[536902535] = id;
    }
    private void GetRewardSkin()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536873261 = new System.Action<System.Boolean>(object:  794711696, method:  new IntPtr(1610681423));
        -1073701127.ShowReward(callBack:  536873261, rewardPlaceID:  12);
    }
    private void NoThanksGetReward()
    {
        var val_10;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.ValueProgressSkinCharater = null;
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_10 = -1073708883.IndexGetSkinProgress;
        }
        else
        {
                val_10 = -1073708883.IndexGetSkinProgress;
        }
        
        -1073708883.IndexGetSkinProgress = val_10 + 1;
        this.objProgress.SetActive(value:  false);
        this.rewardSkinPopup.SetActive(value:  false);
        this.canshowLosetit = true;
        this.ShowLoseIt();
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IndexGetSkinProgress) != 1)
        {
                return;
        }
        
        WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266307] + 12) == 0)
        {
                return;
        }
        
        WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneHome();
    }
    private void ShowProgress()
    {
        536902503 = new WinPopup.<>c__DisplayClass74_0();
        mem[536902515] = this;
        if(mem[536897137] != 0)
        {
                return;
        }
        
        this.objProgress.SetActive(value:  true);
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        float val_3 = -1073708883.ValueProgressSkinCharater;
        mem[536902519] = 3221258413 / 100f;
        this.skinProgressLine.fillAmount = 3221258413;
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        float val_6 = -1073708883.ValueProgressSkinCharater;
        string val_7 = -1073708883.ToString();
        string val_8 = 794956420 + -1610612147(-1610612147);
        this.txt_ValueProgressSkin.text = 794956420;
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        float val_10 = -1073708883.ValueProgressSkinCharater;
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_12 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_14 = (mem[3221266307] + 8) + ((-1073708883.IndexGetSkinProgress) << 2);
        float val_22 = (float)(mem[3221266307] + 8 + (val_13) << 2) + 16;
        val_22 = 3221258413 + val_22;
        -1073708883.ValueProgressSkinCharater = val_22;
        mem[536902511] = mem[536902519];
        object val_15 = AFramework.ManualSingletonMono<System.Object>.I;
        float val_16 = -1073708883.ValueProgressSkinCharater;
        uint val_23 = 3221258413;
        val_23 = val_23 / 100f;
        mem[536902519] = val_23;
        DG.Tweening.Tweener val_17 = DG.Tweening.DOTweenModuleUI.DOFillAmount(target:  this.skinProgressLine, endValue:  val_23, duration:  null);
        536895905 = new DG.Tweening.TweenCallback(object:  536902503, method:  new IntPtr(1610681507));
        DG.Tweening.Tweener val_19 = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Tweener>(t:  this.skinProgressLine, action:  536895905);
        536895905 = new DG.Tweening.TweenCallback(object:  536902503, method:  new IntPtr(1610681509));
        DG.Tweening.Tweener val_21 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.skinProgressLine, action:  536895905);
    }
    private void OnGachaClick()
    {
        AFramework.UI.BaseUIMenu val_1 = AFramework.UI.CanvasManager.Push(identifier:  -1610605293, initParams:  null);
    }
    private void OnSkinClick()
    {
        this.ActiveContent(active:  false);
        mem2[0] = 1;
        AFramework.UI.BaseUIMenu val_1 = AFramework.UI.CanvasManager.Push(identifier:  -1610605277, initParams:  null);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073700957.ActiveChild(active:  false);
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073700989.ActiveChild(active:  false);
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700997.ActiveChild(active:  false);
    }
    public void ActiveContent(bool active)
    {
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Transform val_2 = this.GetChild(index:  0);
        UnityEngine.GameObject val_3 = this.gameObject;
        this.SetActive(value:  active);
    }
    private void ShowBtnNoThank()
    {
        UnityEngine.GameObject val_1 = this.noThankRewardBtn.gameObject;
        this.noThankRewardBtn.SetActive(value:  true);
    }
    private void ShowChest()
    {
        float val_28;
        float val_29;
        if(mem[536897137] == 0)
        {
                return;
        }
        
        this.canshowLosetit = false;
        mem2[0] = false;
        UnityEngine.GameObject val_1 = this.nextLevelButton.gameObject;
        this.nextLevelButton.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.x2RewardBtn.gameObject;
        this.x2RewardBtn.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.skeletonSkin.gameObject;
        this.skeletonSkin.SetActive(value:  false);
        UnityEngine.GameObject val_4 = this.objChest.gameObject;
        this.objChest.SetActive(value:  true);
        UnityEngine.GameObject val_5 = this.btnAdsChest.gameObject;
        this.btnAdsChest.SetActive(value:  false);
        UnityEngine.GameObject val_6 = this.btnLoseChest.gameObject;
        this.btnLoseChest.SetActive(value:  false);
        UnityEngine.GameObject val_7 = this.skeletonChestFree.gameObject;
        this.skeletonChestFree.SetActive(value:  true);
        UnityEngine.GameObject val_8 = this.skeletonChestAds.gameObject;
        this.skeletonChestAds.SetActive(value:  false);
        UnityEngine.Transform val_9 = this.skeletonChestFree.transform;
        UnityEngine.Vector3 val_10 = position;
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.skeletonChestFree, endValue:  new UnityEngine.Vector3(), duration:  val_10.x, snapping:  false);
        UnityEngine.Transform val_12 = this.skeletonChestAds.transform;
        UnityEngine.Vector3 val_13 = position;
        DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.skeletonChestAds, endValue:  new UnityEngine.Vector3(), duration:  val_13.x, snapping:  false);
        UnityEngine.GameObject val_15 = this.lightEff.gameObject;
        this.lightEff.SetActive(value:  false);
        WorldTimeAPI val_16 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609355, volume:  val_13.x);
        UnityEngine.Transform val_17 = this.skeletonChestFree.transform;
        UnityEngine.Vector3 val_18 = position;
        DG.Tweening.Sequence val_19 = DG.Tweening.ShortcutExtensions.DOJump(target:  this.skeletonChestFree, endValue:  new UnityEngine.Vector3(), jumpPower:  val_18.x, numJumps:  1084227584, duration:  val_18.y, snapping:  true);
        DG.Tweening.Tweener val_20 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.skeletonChestFree, ease:  1);
        536895905 = new DG.Tweening.TweenCallback(object:  795626768, method:  new IntPtr(1610681425));
        DG.Tweening.Tweener val_22 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.skeletonChestFree, action:  536895905);
        UnityEngine.Transform val_23 = this.freeChestReward.transform;
        UnityEngine.Vector3 val_24 = position;
        DG.Tweening.Tweener val_25 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.freeChestReward, endValue:  new UnityEngine.Vector3(), duration:  val_24.x, snapping:  false);
        UnityEngine.Transform val_26 = this.freeChestReward.transform;
        UnityEngine.Vector2 val_27 = UnityEngine.Vector2.zero;
        DG.Tweening.Tweener val_30 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.freeChestReward, endValue:  new UnityEngine.Vector3() {x = val_28, y = val_29, z = 0f}, duration:  val_27.x);
    }
    private void OpenChestFree()
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        536902505 = new WinPopup.<>c__DisplayClass82_0();
        mem[536902513] = this;
        if(this.coinFreeValues != null)
        {
                val_13 = this.coinFreeValues;
            val_14 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  795902608);
        }
        else
        {
                val_13 = 12;
            val_14 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  0);
        }
        
        mem[536902517] = this.coinFreeValues[val_14];
        if(this.tapFreeValues != null)
        {
                val_15 = this.tapFreeValues;
            val_16 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  0);
        }
        else
        {
                val_15 = 12;
            val_16 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  0);
        }
        
        mem[536902521] = this.tapFreeValues[val_16];
        string val_6 = mem[536902517].ToString();
        string val_7 = -1610611917(-1610611917) + mem[536902517];
        this.coinChestTxt.text = -1610611917;
        string val_8 = mem[536902521].ToString();
        string val_9 = -1610611917(-1610611917) + mem[536902521];
        this.tapChestTxt.text = -1610611917;
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609349, volume:  null);
        UnityEngine.GameObject val_11 = this.btnFreeChest.gameObject;
        this.btnFreeChest.SetActive(value:  false);
        536882991 = new System.Action(object:  536902505, method:  new IntPtr(1610681513));
        MixSkinManager.SetAnimation(ske:  this.skeletonChestFree, name:  -1610598929, loop:  false, timeScale:  null, _callBack:  1065353216);
    }
    private void OpenChestAds()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536873261 = new System.Action<System.Boolean>(object:  796104720, method:  new IntPtr(1610681427));
        -1073701127.ShowReward(callBack:  536873261, rewardPlaceID:  14);
    }
    private void PrepareChestAds()
    {
        UnityEngine.GameObject val_1 = this.freeChestReward.gameObject;
        this.freeChestReward.SetActive(value:  false);
        536882991 = new System.Action(object:  796224912, method:  new IntPtr(1610681429));
        MixSkinManager.SetAnimation(ske:  this.skeletonChestFree, name:  -1610600011, loop:  true, timeScale:  null, _callBack:  1065353216);
    }
    private void ActiveLoseItChest()
    {
        UnityEngine.GameObject val_1 = this.btnLoseChest.gameObject;
        this.btnLoseChest.SetActive(value:  true);
    }
    private int GetLockedSkinID()
    {
        var val_10;
        536877987 = new System.Collections.Generic.List<System.Int32>();
        val_10 = 4;
        goto label_1;
        label_13:
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        System.Collections.Generic.List<System.Int32> val_4 = -1073708883.ListSkinProgress;
        if(mem[3221258425] <= 23000269)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((-1073708883.CheckSkinUnlock(id:  mem[3221258421] + 16)) != true)
        {
                object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
            System.Collections.Generic.List<System.Int32> val_7 = -1073708883.ListSkinProgress;
            if(mem[3221258425] <= 23000269)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            536877987.Add(item:  mem[3221258421] + 16);
        }
        
        val_10 = 5;
        label_1:
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        System.Collections.Generic.List<System.Int32> val_10 = -1073708883.ListSkinProgress;
        if((val_10 - 4) < mem[3221258425])
        {
            goto label_13;
        }
        
        if(mem[536877999] < 1)
        {
                return 0;
        }
        
        return Berry.Utils.Utils.GetRandom<System.Int32>(collection:  536877987);
    }
    private System.Collections.IEnumerator SetSkinChest(int id)
    {
        WinPopup.<SetSkinChest>d__87 val_1 = 536902513;
        val_1 = new WinPopup.<SetSkinChest>d__87(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536902529] = this;
        }
        else
        {
                mem[16] = this;
        }
        
        mem[536902533] = id;
    }
    private void LoseChest()
    {
        this.objChest.SetActive(value:  false);
        this.canshowLosetit = true;
        this.ShowLoseIt();
    }
    public WinPopup()
    {
        this.canshowLosetit = true;
        this.characterMode = -1610612735;
        this.idMove = true;
        this.coinWin = 100;
        this.timeMove = 1.2f;
        this.coinFreeValues = 536882065;
        this.tapFreeValues = 536882065;
    }
    private void <Start>b__54_0()
    {
        this.NextLevelButtonClick();
    }
    private void <Start>b__54_1()
    {
        this.GetX2RewardClick();
    }
    private void <Start>b__54_2()
    {
        this.OpenHome();
    }
    private void <Start>b__54_3(UnityEngine.Component o, object sender)
    {
        this.content.SetActive(value:  true);
    }
    private void <Start>b__54_4()
    {
        this.OnGachaClick();
    }
    private void <Start>b__54_5()
    {
        this.OnSkinClick();
    }
    private void <Start>b__54_6()
    {
        this.GetRewardSkin();
    }
    private void <Start>b__54_7()
    {
        this.NoThanksGetReward();
    }
    private void <Start>b__54_8()
    {
        this.OpenChestFree();
    }
    private void <Start>b__54_9()
    {
        this.OpenChestAds();
    }
    private void <Start>b__54_10()
    {
        this.LoseChest();
    }
    private bool <ShowVictoryText>b__55_0()
    {
        if((mem[536891408] & true) != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.victoryTextSkeleton);
        }
        
        if(mem[536891337] != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.victoryTextSkeleton);
        }
        
        return UnityEngine.Object.op_Implicit(exists:  this.victoryTextSkeleton);
    }
    private void <ShowVictoryText>b__55_1()
    {
        MixSkinManager.SetAnimation(ske:  this.victoryTextSkeleton, name:  -1610600013, loop:  true, timeScale:  null, _callBack:  1065353216);
    }
    private void <MoveArrow>b__59_0()
    {
        this.idMove = 1;
        this.MoveArrow();
    }
    private void <MoveArrow>b__59_1()
    {
        this.idMove = 0;
        this.MoveArrow();
    }
    private void <OpenHome>b__61_0(bool success)
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneHome();
        this.backHomeButton.interactable = false;
    }
    private void <NextLevelButtonClick>b__66_0(bool success)
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneHome();
        goto typeof(WinPopup).__il2cppRuntimeField_E4;
    }
    private void <NextLevelButtonClick>b__66_1(bool success)
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneRopeRescue();
        goto typeof(WinPopup).__il2cppRuntimeField_E4;
    }
    private void <NextLevelButtonClick>b__66_2(bool success)
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneRopeRescue();
        goto typeof(WinPopup).__il2cppRuntimeField_E4;
    }
    private void <NextLevelButtonClick>b__66_3(bool success)
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadScenePinPull();
        goto typeof(WinPopup).__il2cppRuntimeField_E4;
    }
    private void <NextLevelButtonClick>b__66_4(bool success)
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneCutRescue();
        goto typeof(WinPopup).__il2cppRuntimeField_E4;
    }
    private void <NextLevelButtonClick>b__66_5(bool success)
    {
        var val_12;
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
            goto typeof(WinPopup).__il2cppRuntimeField_E4;
        }
        
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        val_12 = -1073708883;
        if((-1073708883.LevelRopeUnlocked) < val_12.NumberRopeLevel)
        {
            goto label_4;
        }
        
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        val_12 = -1073708883;
        if((-1073708883.CurrentLevelRope) >= val_12.NumberRopeLevel)
        {
            goto label_7;
        }
        
        label_4:
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700957.SpawLevel();
        goto typeof(WinPopup).__il2cppRuntimeField_E4;
        label_7:
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneHome();
        goto typeof(WinPopup).__il2cppRuntimeField_E4;
    }
    private void <NextLevelButtonClick>b__66_6(bool success)
    {
        var val_12;
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
            goto typeof(WinPopup).__il2cppRuntimeField_E4;
        }
        
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        val_12 = -1073708883;
        if((-1073708883.LevelPinPullUnlocked) < val_12.NumberPinpullLevel)
        {
            goto label_4;
        }
        
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        val_12 = -1073708883;
        if((-1073708883.CurrentLevelPinPull) >= val_12.NumberPinpullLevel)
        {
            goto label_7;
        }
        
        label_4:
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701037.SpawnNextLevel();
        goto typeof(WinPopup).__il2cppRuntimeField_E4;
        label_7:
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneHome();
        goto typeof(WinPopup).__il2cppRuntimeField_E4;
    }
    private void <NextLevelButtonClick>b__66_7(bool success)
    {
        var val_12;
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
            goto typeof(WinPopup).__il2cppRuntimeField_E4;
        }
        
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        val_12 = -1073708883;
        if((-1073708883.LevelCutRopeUnlocked) < val_12.NumberCutRopeLevel)
        {
            goto label_4;
        }
        
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        val_12 = -1073708883;
        if((-1073708883.CurrentLevelCutRope) >= val_12.NumberCutRopeLevel)
        {
            goto label_7;
        }
        
        label_4:
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701079.SpawnNextLevel();
        goto typeof(WinPopup).__il2cppRuntimeField_E4;
        label_7:
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneHome();
        goto typeof(WinPopup).__il2cppRuntimeField_E4;
    }
    private void <GetX2RewardClick>b__67_0(bool success)
    {
        if(success != false)
        {
                this.watchedAds = true;
            this.x2RewardBtn.interactable = false;
            System.Collections.IEnumerator val_1 = this.CoinMovesX2();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  799670928);
            UnityEngine.GameObject val_3 = this.nextLevelButton.gameObject;
            this.nextLevelButton.SetActive(value:  false);
            this.canshowLosetit = false;
            this.CancelInvoke(methodName:  -1610604577);
            UnityEngine.GameObject val_4 = this.nextLevelButton.gameObject;
            this.nextLevelButton.SetActive(value:  false);
            return;
        }
        
        this.canMove = false;
    }
    private bool <SetSkinReward>b__71_0()
    {
        if((mem[536891408] & true) != 0)
        {
                return UnityEngine.Object.op_Inequality(x:  this.skeletonSkinReward, y:  0);
        }
        
        if(mem[536891337] != 0)
        {
                return UnityEngine.Object.op_Inequality(x:  this.skeletonSkinReward, y:  0);
        }
        
        return UnityEngine.Object.op_Inequality(x:  this.skeletonSkinReward, y:  0);
    }
    private void <GetRewardSkin>b__72_0(bool ss)
    {
        var val_19;
        if(ss == false)
        {
                return;
        }
        
        this.watchedAds = true;
        if(this.idSkinReward == 1)
        {
            goto label_2;
        }
        
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.UnlockSkin(id:  this.idSkinReward);
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.SkinSelectedID = this.idSkinReward;
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700885.Show(mess:  -1610602433, callBack:  0);
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.ValueProgressSkinCharater = null;
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_7;
        }
        
        val_19 = -1073708883.IndexGetSkinProgress;
        goto label_8;
        label_2:
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700885.Show(mess:  -1610602431, callBack:  0);
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.ValueProgressSkinCharater = null;
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_11;
        }
        
        val_19 = -1073708883.IndexGetSkinProgress;
        goto label_12;
        label_7:
        val_19 = -1073708883.IndexGetSkinProgress;
        label_8:
        -1073708883.IndexGetSkinProgress = val_19 + 1;
        GameTool.EventDispatcherExtension.PostEvent(sender:  799931792, eventID:  10);
        this.objProgress.SetActive(value:  false);
        this.rewardSkinPopup.SetActive(value:  false);
        object val_13 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IndexGetSkinProgress) != 1)
        {
            goto label_21;
        }
        
        WorldTimeAPI val_15 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266307] + 12) == 0)
        {
            goto label_21;
        }
        
        WorldTimeAPI val_16 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneHome();
        goto label_21;
        label_11:
        val_19 = -1073708883.IndexGetSkinProgress;
        label_12:
        -1073708883.IndexGetSkinProgress = val_19 + 1;
        this.objProgress.SetActive(value:  false);
        this.rewardSkinPopup.SetActive(value:  false);
        label_21:
        this.canshowLosetit = true;
        this.ShowLoseIt();
    }
    private void <ShowChest>b__79_0()
    {
        UnityEngine.GameObject val_1 = this.btnFreeChest.gameObject;
        this.btnFreeChest.SetActive(value:  true);
        UnityEngine.GameObject val_2 = this.lightEff.gameObject;
        this.lightEff.SetActive(value:  true);
    }
    private void <OpenChestAds>b__83_0(bool succes)
    {
        Spine.Unity.SkeletonGraphic val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_15 = 23000286;
        if(succes == false)
        {
                return;
        }
        
        536902507 = new WinPopup.<>c__DisplayClass83_0();
        mem[536902523] = this;
        this.watchedAds = true;
        if(this.coinFreeValues != null)
        {
                val_16 = this.coinFreeValues;
            val_17 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  800282768);
        }
        else
        {
                val_16 = 12;
            val_17 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  0);
        }
        
        mem[536902515] = this.coinFreeValues[val_17];
        if(this.tapFreeValues != null)
        {
                val_18 = this.tapFreeValues;
            val_19 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  0);
        }
        else
        {
                val_18 = 12;
            val_19 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  0);
        }
        
        int val_17 = mem[536902515];
        mem[536902519] = this.tapFreeValues[val_19];
        val_17 = val_17 << 1;
        string val_6 = val_17.ToString();
        string val_7 = -1610611917(-1610611917) + 800270732;
        this.coinChestTxt.text = -1610611917;
        int val_18 = mem[536902519];
        val_18 = val_18 << 1;
        string val_8 = val_18.ToString();
        string val_9 = -1610611917(-1610611917) + 800270732;
        this.tapChestTxt.text = -1610611917;
        UnityEngine.GameObject val_10 = this.btnAdsChest.gameObject;
        this.btnAdsChest.SetActive(value:  false);
        UnityEngine.GameObject val_11 = this.btnLoseChest.gameObject;
        this.btnLoseChest.SetActive(value:  false);
        WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609349, volume:  null);
        val_15 = this.skeletonChestAds;
        if((UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  2)) == 1)
        {
                val_20 = 22775876;
        }
        else
        {
                val_20 = 22775880;
        }
        
        536882991 = new System.Action(object:  536902507, method:  new IntPtr(1610681519));
        MixSkinManager.SetAnimation(ske:  val_15, name:  -1610598929, loop:  false, timeScale:  null, _callBack:  1065353216);
        this.Invoke(methodName:  -1610606567, time:  null);
    }
    private void <PrepareChestAds>b__84_0()
    {
        float val_6;
        float val_7;
        UnityEngine.Transform val_1 = this.freeChestReward.transform;
        UnityEngine.Vector3 val_2 = position;
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.freeChestReward, endValue:  new UnityEngine.Vector3(), duration:  val_2.x, snapping:  false);
        UnityEngine.Transform val_4 = this.freeChestReward.transform;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
        DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.freeChestReward, endValue:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = 0f}, duration:  val_5.x);
        UnityEngine.GameObject val_9 = this.skeletonChestFree.gameObject;
        this.skeletonChestFree.SetActive(value:  false);
        UnityEngine.GameObject val_10 = this.lightEff.gameObject;
        this.lightEff.SetActive(value:  false);
        UnityEngine.GameObject val_11 = this.skeletonChestAds.gameObject;
        this.skeletonChestAds.SetActive(value:  true);
        WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609355, volume:  val_5.x);
        UnityEngine.Transform val_13 = this.skeletonChestAds.transform;
        UnityEngine.Vector3 val_14 = position;
        DG.Tweening.Sequence val_15 = DG.Tweening.ShortcutExtensions.DOJump(target:  this.skeletonChestAds, endValue:  new UnityEngine.Vector3(), jumpPower:  val_14.x, numJumps:  1084227584, duration:  val_14.y, snapping:  true);
        DG.Tweening.Tweener val_16 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.skeletonChestAds, ease:  1);
        536895905 = new DG.Tweening.TweenCallback(object:  800521744, method:  new IntPtr(1610681431));
        DG.Tweening.Tweener val_18 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.skeletonChestAds, action:  536895905);
    }
    private void <PrepareChestAds>b__84_1()
    {
        MixSkinManager.SetAnimation(ske:  this.skeletonChestAds, name:  -1610600011, loop:  true, timeScale:  null, _callBack:  1065353216);
        UnityEngine.GameObject val_1 = this.btnAdsChest.gameObject;
        this.btnAdsChest.SetActive(value:  true);
        UnityEngine.GameObject val_2 = this.lightEff.gameObject;
        this.lightEff.SetActive(value:  true);
        this.Invoke(methodName:  -1610610345, time:  null);
    }
    private bool <SetSkinChest>b__87_0()
    {
        if((mem[536891408] & true) != 0)
        {
                return UnityEngine.Object.op_Inequality(x:  this.skeletonSkin, y:  0);
        }
        
        if(mem[536891337] != 0)
        {
                return UnityEngine.Object.op_Inequality(x:  this.skeletonSkin, y:  0);
        }
        
        return UnityEngine.Object.op_Inequality(x:  this.skeletonSkin, y:  0);
    }

}
