using UnityEngine;
public class LevelNote : MonoBehaviour
{
    // Fields
    private UnityEngine.Sprite[] levelIcon;
    private UnityEngine.Sprite[] levelIconRescuse;
    private UnityEngine.Sprite[] levelIconBoss;
    private UnityEngine.Sprite[] levelIconBonus;
    private UnityEngine.Sprite rescueIcon;
    private UnityEngine.Sprite[] bossIcon;
    private UnityEngine.Sprite bonusIcon;
    private UnityEngine.UI.Image bgIconImage;
    private UnityEngine.UI.Image showIconRescuseImage;
    private UnityEngine.UI.Image showIconBossImage;
    private UnityEngine.UI.Image showIconBonusImage;
    private UnityEngine.UI.Image showIconLotteryImage;
    private UnityEngine.Animator animator;
    private LevelRopeType myLevelType;
    private LevelPinPullType myLevelPullType;
    public int indexLevel;
    private bool isLevelLottery;
    
    // Methods
    public void UpdatePinPullImage(LevelPinPullType levelType, int levelState, int level)
    {
        UnityEngine.UI.Image val_13;
        LevelPinPullType val_14;
        var val_15;
        var val_16;
        val_13 = levelState;
        val_14 = levelType;
        this.myLevelPullType = val_14;
        this.indexLevel = level;
        UnityEngine.GameObject val_1 = this.showIconBossImage.gameObject;
        this.showIconBossImage.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.showIconBonusImage.gameObject;
        this.showIconBonusImage.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.showIconLotteryImage.gameObject;
        this.showIconLotteryImage.SetActive(value:  false);
        UnityEngine.GameObject val_4 = this.showIconRescuseImage.gameObject;
        this.showIconRescuseImage.SetActive(value:  false);
        if(val_13 == 1)
        {
                val_15 = 22790292;
        }
        else
        {
                val_15 = 22790304;
        }
        
        this.animator.Play(stateName:  -1610606017, layer:  0, normalizedTime:  null);
        this.isLevelLottery = false;
        if(val_14 != 1)
        {
                if(val_14 != 0)
        {
                return;
        }
        
            val_14 = this.bgIconImage;
            val_14.sprite = this.levelIcon[val_13];
            object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
            object val_7 = AFramework.ManualSingletonMono<System.Object>.I;
            val_13 = -1073708883;
            if((-1073708883.CurrentLevelPinPull) <= val_13.LevelPinPullUnlocked)
        {
                return;
        }
        
            val_13 = 22742128;
            WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            if((mem[3221266315] + 24 + 12) == 0)
        {
                return;
        }
        
            WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_14 = 0;
            val_13 = (mem[3221266315] + 24) + 16;
            do
        {
            if(val_14 >= (mem[3221266315] + 24 + 12))
        {
                return;
        }
        
            val_14 = val_14 + 1;
        }
        while(((mem[3221266315] + 24 + 16) + 0) != level);
        
            UnityEngine.GameObject val_11 = this.showIconLotteryImage.gameObject;
            val_14 = true;
            val_13 = 0;
            this.showIconLotteryImage.SetActive(value:  true);
            this.isLevelLottery = val_14;
            val_16 = -1610606021;
        }
        else
        {
                this.bgIconImage.sprite = this.levelIconRescuse[val_13];
            val_13 = this.showIconRescuseImage;
            val_14 = 0;
            val_13.sprite = this.rescueIcon;
            val_16 = -1610606023;
        }
        
        this.animator.Play(stateName:  -1610606023, layer:  0, normalizedTime:  null);
    }
    public void UpdateRopeImage(LevelRopeType levelType, int levelState, int level)
    {
        int val_17;
        var val_18;
        LevelRopeType val_19;
        var val_20;
        UnityEngine.Sprite[] val_21;
        UnityEngine.UI.Image val_22;
        UnityEngine.UI.Image val_23;
        val_17 = level;
        val_18 = levelState;
        val_19 = levelType;
        this.indexLevel = val_17;
        this.myLevelType = val_19;
        UnityEngine.GameObject val_1 = this.showIconRescuseImage.gameObject;
        this.showIconRescuseImage.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.showIconBossImage.gameObject;
        this.showIconBossImage.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.showIconBonusImage.gameObject;
        this.showIconBonusImage.SetActive(value:  false);
        if(val_18 == 1)
        {
                val_20 = 22790292;
        }
        else
        {
                val_20 = 22790304;
        }
        
        this.animator.Play(stateName:  -1610606017, layer:  0, normalizedTime:  null);
        this.isLevelLottery = false;
        if(val_19 == 2)
        {
            goto label_10;
        }
        
        if(val_19 == 1)
        {
            goto label_11;
        }
        
        if(val_19 != 0)
        {
                return;
        }
        
        this.bgIconImage.enabled = true;
        val_19 = this.bgIconImage;
        val_19.sprite = this.levelIcon[val_18];
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        val_18 = -1073708883;
        if((-1073708883.CurrentLevelRope) <= val_18.LevelRopeUnlocked)
        {
                return;
        }
        
        val_18 = 22742128;
        WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266315] + 20 + 12) == 0)
        {
                return;
        }
        
        WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_19 = 0;
        val_18 = (mem[3221266315] + 20) + 16;
        do
        {
            if(val_19 >= (mem[3221266315] + 20 + 12))
        {
                return;
        }
        
            val_19 = val_19 + 1;
        }
        while(((mem[3221266315] + 20 + 16) + 0) != val_17);
        
        this.bgIconImage.enabled = false;
        UnityEngine.GameObject val_10 = this.showIconLotteryImage.gameObject;
        val_19 = true;
        val_18 = 0;
        this.showIconLotteryImage.SetActive(value:  true);
        this.isLevelLottery = val_19;
        this.animator.Play(stateName:  -1610606021, layer:  0, normalizedTime:  null);
        return;
        label_10:
        this.bgIconImage.enabled = true;
        val_21 = this.levelIconBonus;
        this.bgIconImage.sprite = val_21[val_18];
        val_22 = this.showIconBonusImage;
        val_22.sprite = this.bonusIcon;
        val_23 = this.showIconBonusImage;
        goto label_39;
        label_11:
        this.bgIconImage.enabled = false;
        val_21 = this.bossIcon;
        val_17 = this.showIconBossImage;
        object val_11 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_12 = -1073708883.CurrentLevelRope;
        val_12 = val_12 - 1;
        val_12 = (val_12 >> 2) + (val_12 >> 31);
        val_22 = val_21[UnityEngine.Mathf.Clamp(value:  val_12, min:  0, max:  0)];
        val_17.sprite = val_22;
        val_23 = this.showIconBossImage;
        label_39:
        UnityEngine.GameObject val_15 = val_23.gameObject;
        val_23.SetActive(value:  true);
    }
    public void ShowAnimCheck()
    {
        if(this.isLevelLottery == true)
        {
                return;
        }
        
        int val_1 = this.indexLevel;
        val_1 = val_1 - 4294967290;
        if(val_1 == 0)
        {
                return;
        }
        
        this.animator.Play(stateName:  -1610606019, layer:  0, normalizedTime:  null);
    }
    private void ActiveNote()
    {
        var val_25;
        bool val_26;
        var val_27;
        UnityEngine.UI.Image val_28;
        UnityEngine.UI.Image val_29;
        UnityEngine.Sprite[] val_30;
        val_25 = 22740800;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.GameMode) == 0)
        {
            goto label_2;
        }
        
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.GameMode) != 1)
        {
                return;
        }
        
        if(this.myLevelPullType == 1)
        {
            goto label_5;
        }
        
        if(this.myLevelPullType != 0)
        {
                return;
        }
        
        this.bgIconImage.sprite = this.levelIcon[1];
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_7 = AFramework.ManualSingletonMono<System.Object>.I;
        val_26 = -1073708883;
        if((-1073708883.CurrentLevelPinPull) <= val_26.LevelPinPullUnlocked)
        {
                return;
        }
        
        val_26 = 22742128;
        WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266315] + 24 + 12) == 0)
        {
                return;
        }
        
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_27 = 0;
        val_26 = (mem[3221266315] + 24) + 16;
        do
        {
            if(val_27 >= (mem[3221266315] + 24 + 12))
        {
                return;
        }
        
            val_27 = val_27 + 1;
        }
        while(this.indexLevel != ((mem[3221266315] + 24 + 16) + 0));
        
        UnityEngine.GameObject val_11 = this.showIconLotteryImage.gameObject;
        val_26 = true;
        this.showIconLotteryImage.SetActive(value:  true);
        this.isLevelLottery = val_26;
        return;
        label_2:
        if(this.myLevelType == 2)
        {
            goto label_26;
        }
        
        if(this.myLevelType == 1)
        {
            goto label_27;
        }
        
        if(this.myLevelType != 0)
        {
                return;
        }
        
        this.bgIconImage.enabled = true;
        this.bgIconImage.sprite = this.levelIcon[1];
        object val_12 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_14 = AFramework.ManualSingletonMono<System.Object>.I;
        val_26 = -1073708883;
        if((-1073708883.CurrentLevelRope) <= val_26.LevelRopeUnlocked)
        {
                return;
        }
        
        val_26 = 22742128;
        WorldTimeAPI val_16 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266315] + 20 + 12) == 0)
        {
                return;
        }
        
        WorldTimeAPI val_17 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_27 = 0;
        val_26 = (mem[3221266315] + 20) + 16;
        do
        {
            if(val_27 >= (mem[3221266315] + 20 + 12))
        {
                return;
        }
        
            val_27 = val_27 + 1;
        }
        while(this.indexLevel != ((mem[3221266315] + 20 + 16) + 0));
        
        this.bgIconImage.enabled = false;
        return;
        label_5:
        this.bgIconImage.sprite = this.levelIconRescuse[1];
        this.showIconRescuseImage.sprite = this.rescueIcon;
        return;
        label_26:
        this.bgIconImage.enabled = true;
        this.bgIconImage.sprite = this.levelIconBonus[1];
        val_28 = this.showIconBonusImage;
        val_28.sprite = this.bonusIcon;
        val_29 = this.showIconBonusImage;
        goto label_56;
        label_27:
        this.bgIconImage.enabled = false;
        object val_18 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_19 = -1073708883.CurrentLevelRope;
        val_30 = this.bossIcon;
        val_19 = val_19 - 1;
        val_19 = (val_19 >> 2) + (val_19 >> 31);
        val_28 = this.bossIcon[UnityEngine.Mathf.Clamp(value:  val_19, min:  0, max:  0)];
        this.showIconBossImage.sprite = val_28;
        val_29 = this.showIconBossImage;
        label_56:
        UnityEngine.GameObject val_22 = val_29.gameObject;
        val_29.SetActive(value:  true);
    }
    public LevelNote()
    {
    
    }

}
