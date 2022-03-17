using UnityEngine;
public class ItemSelectLevelController : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image frameAvatarImage;
    private UnityEngine.UI.Button playBtn;
    public UnityEngine.Sprite frameGraySprite;
    public UnityEngine.Sprite frameBlackSprite;
    public UnityEngine.Sprite frameBlueSprite;
    public UnityEngine.Sprite frameGreenSprite;
    private UnityEngine.GameObject iconLock;
    public int level;
    private TMPro.TextMeshProUGUI levelText;
    private int currMode;
    private int currLevelMode;
    
    // Methods
    private void Start()
    {
        this.Init();
    }
    private void OnEnable()
    {
        this.CheckMode();
        this.Init();
    }
    private void OnDisable()
    {
        this.playBtn.m_OnClick.RemoveAllListeners();
    }
    private void CheckMode()
    {
        Button.ButtonClickedEvent val_15;
        UnityEngine.Events.UnityAction val_16;
        var val_17;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        this.currMode = -1073708883.GameMode;
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266339] + 8) == 0)
        {
            goto label_4;
        }
        
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IsOldUser) == false)
        {
            goto label_6;
        }
        
        label_4:
        if(this.currMode == 2)
        {
            goto label_7;
        }
        
        if(this.currMode == 1)
        {
            goto label_8;
        }
        
        if(this.currMode != 0)
        {
                return;
        }
        
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_7 = -1073708883.LevelRopeUnlocked;
        val_7 = val_7 + 1;
        this.currLevelMode = val_7;
        val_15 = this.playBtn.m_OnClick;
        val_16 = 536896275;
        val_17 = 22761740;
        goto label_18;
        label_6:
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_9 = -1073708883.CurrentLevelUnlocked;
        val_9 = val_9 + 1;
        this.currLevelMode = val_9;
        val_15 = this.playBtn.m_OnClick;
        val_16 = 536896275;
        val_17 = 22761736;
        goto label_18;
        label_7:
        object val_10 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_11 = -1073708883.LevelCutRopeUnlocked;
        val_11 = val_11 + 1;
        this.currLevelMode = val_11;
        val_15 = this.playBtn.m_OnClick;
        val_16 = 536896275;
        val_17 = 22761748;
        goto label_18;
        label_8:
        object val_12 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_13 = -1073708883.LevelPinPullUnlocked;
        val_13 = val_13 + 1;
        this.currLevelMode = val_13;
        val_15 = this.playBtn.m_OnClick;
        val_16 = 536896275;
        val_17 = 22761744;
        label_18:
        val_16 = new UnityEngine.Events.UnityAction(object:  818875152, method:  new IntPtr(1610681827));
        val_15.AddListener(call:  536896275);
    }
    public void LoadPlayGame(int mode)
    {
        UnityEngine.UI.Button val_22;
        var val_23;
        int val_24;
        int val_25;
        val_22 = this.playBtn;
        val_22.interactable = false;
        if(mode == 2)
        {
            goto label_2;
        }
        
        if(mode == 1)
        {
            goto label_3;
        }
        
        if(mode != 0)
        {
                return;
        }
        
        val_23 = 22740800;
        val_24 = this.level;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_2 = -1073708883.LevelRopeUnlocked;
        val_2 = val_2 + 1;
        if(val_24 > val_2)
        {
                return;
        }
        
        int val_22 = this.level;
        val_22 = val_22 - 4294967290;
        if(val_22 == 5)
        {
                return;
        }
        
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.CurrentLevelRope = this.level;
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CurrentLevelRope) > (-1073708883.NumberRopeLevel))
        {
            goto label_17;
        }
        
        WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneRopeRescue();
        return;
        label_2:
        val_24 = 22740800;
        val_22 = this.level;
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_10 = -1073708883.LevelCutRopeUnlocked;
        val_10 = val_10 + 1;
        if(val_22 > val_10)
        {
                return;
        }
        
        object val_11 = AFramework.ManualSingletonMono<System.Object>.I;
        val_25 = this.level;
        -1073708883.CurrentLevelCutRope = val_25;
        object val_12 = AFramework.ManualSingletonMono<System.Object>.I;
        if(this.level > (-1073708883.NumberCutRopeLevel))
        {
            goto label_17;
        }
        
        WorldTimeAPI val_14 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneCutRescue();
        return;
        label_3:
        val_24 = 22740800;
        val_22 = this.level;
        object val_15 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_16 = -1073708883.LevelPinPullUnlocked;
        val_16 = val_16 + 1;
        if(val_22 > val_16)
        {
                return;
        }
        
        object val_17 = AFramework.ManualSingletonMono<System.Object>.I;
        val_25 = this.level;
        -1073708883.CurrentLevelPinPull = val_25;
        object val_18 = AFramework.ManualSingletonMono<System.Object>.I;
        if(this.level <= (-1073708883.NumberPinpullLevel))
        {
            goto label_23;
        }
        
        label_17:
        WorldTimeAPI val_20 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700885.Show(mess:  -1610609269, callBack:  0);
        return;
        label_23:
        WorldTimeAPI val_21 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadScenePinPull();
    }
    public void LoadPlayMixLevel()
    {
        var val_27;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_2 = -1073708883.CurrentLevelUnlocked;
        val_2 = val_2 + 1;
        if(this.level > val_2)
        {
                return;
        }
        
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        if(this.level > (-1073708883.NumberMixLevel))
        {
                WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073700885.Show(mess:  -1610609267, callBack:  0);
            return;
        }
        
        this.playBtn.interactable = false;
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.CurrentLevel = this.level - 1;
        WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_27 = mem[mem[3221266339] + 12];
        val_27 = mem[3221266339] + 12;
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_11 = val_27 + ((-1073708883.CurrentLevel) << 2);
        if(((mem[3221266339] + 12 + (val_10) << 2) + 16) == 0)
        {
            goto label_13;
        }
        
        WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_27 = mem[mem[3221266339] + 12];
        val_27 = mem[3221266339] + 12;
        object val_13 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_15 = val_27 + ((-1073708883.CurrentLevel) << 2);
        if(((mem[3221266339] + 12 + (val_14) << 2) + 16) != 1)
        {
            goto label_19;
        }
        
        label_13:
        WorldTimeAPI val_16 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneRopeRescue();
        return;
        label_19:
        WorldTimeAPI val_17 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_18 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_20 = (mem[3221266339] + 12) + ((-1073708883.CurrentLevel) << 2);
        if(((mem[3221266339] + 12 + (val_19) << 2) + 16) == 2)
        {
                WorldTimeAPI val_21 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073700919.LoadScenePinPull();
            return;
        }
        
        WorldTimeAPI val_22 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_23 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_25 = (mem[3221266339] + 12) + ((-1073708883.CurrentLevel) << 2);
        if(((mem[3221266339] + 12 + (val_24) << 2) + 16) != 3)
        {
                return;
        }
        
        WorldTimeAPI val_26 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneCutRescue();
    }
    private void Init()
    {
        UnityEngine.UI.Image val_10;
        UnityEngine.Sprite val_11;
        var val_12;
        string val_1 = this.level.ToString();
        this.levelText.text = this.level;
        UnityEngine.GameObject val_2 = this.levelText.gameObject;
        this.levelText.SetActive(value:  true);
        this.iconLock.SetActive(value:  false);
        if(this.level < this.currLevelMode)
        {
                val_10 = this.frameAvatarImage;
            val_11 = this.frameBlueSprite;
            sprite = val_11;
            UnityEngine.GameObject val_3 = this.levelText.gameObject;
            this.levelText.SetActive(value:  true);
            this.iconLock.SetActive(value:  false);
            WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_12 = mem[3221266339];
            if((mem[3221266339] + 8) != 0)
        {
                object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
            val_12 = -1073708883;
            bool val_6 = val_12.IsOldUser;
            if(val_6 == false)
        {
                return;
        }
        
        }
        
            int val_11 = this.level;
            var val_10 = 4294967295;
            val_10 = val_11 - val_10;
            if(val_6 == true)
        {
                return;
        }
        
            val_11 = val_11 - 4294967290;
            if(val_11 == 0)
        {
                return;
        }
        
            object val_7 = AFramework.ManualSingletonMono<System.Object>.I;
            if((-1073708883.GameMode) != 0)
        {
                return;
        }
        
            R4 + 12.sprite = R4 + 24;
            UnityEngine.GameObject val_9 = R4 + 44.gameObject;
            R4 + 44.SetActive(value:  false);
            R4 + 36.SetActive(value:  true);
        }
    
    }
    public void SortLevelIndex()
    {
        var val_13;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Transform val_2 = this.parent;
        UnityEngine.Transform val_3 = this.GetChild(index:  0);
        UnityEngine.Transform val_4 = this.GetComponent<UnityEngine.Transform>();
        val_13 = 0;
        goto label_5;
        label_12:
        UnityEngine.Transform val_5 = this.transform;
        UnityEngine.Transform val_6 = this.parent;
        UnityEngine.Transform val_7 = this.GetChild(index:  0);
        UnityEngine.Transform val_8 = this.GetComponent<UnityEngine.Transform>();
        val_13 = 1;
        this.level = this.level + val_13;
        label_5:
        UnityEngine.Transform val_10 = this.transform;
        UnityEngine.Transform val_11 = this.parent;
        if(val_13 < this.childCount)
        {
            goto label_12;
        }
    
    }
    public ItemSelectLevelController()
    {
    
    }
    private void <CheckMode>b__14_0()
    {
        this.LoadPlayMixLevel();
    }
    private void <CheckMode>b__14_1()
    {
        this.LoadPlayGame(mode:  this.currMode);
    }
    private void <CheckMode>b__14_2()
    {
        this.LoadPlayGame(mode:  this.currMode);
    }
    private void <CheckMode>b__14_3()
    {
        this.LoadPlayGame(mode:  this.currMode);
    }

}
