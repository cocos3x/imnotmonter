using UnityEngine;
public class LevelNode : MonoBehaviour
{
    // Fields
    private UnityEngine.Animator animator;
    private UnityEngine.UI.Image bgIconImage;
    private UnityEngine.UI.Image iconBoss;
    public int indexLevel;
    private UnityEngine.Sprite[] levelIcon;
    private System.Collections.Generic.List<UnityEngine.Sprite> ListIconBoss;
    private UnityEngine.GameObject mode1;
    private UnityEngine.GameObject mode2;
    private UnityEngine.GameObject mode3;
    private UnityEngine.GameObject boss;
    
    // Methods
    public void ShowAnimCheck()
    {
        int val_1 = this.indexLevel;
        if(val_1 != 0)
        {
                val_1 = val_1 - 4294967290;
            if(val_1 == 0)
        {
                return;
        }
        
        }
        
        this.animator.Play(stateName:  -1610606019, layer:  0, normalizedTime:  null);
    }
    public void UpdateImage(int levelType, int levelState, int level)
    {
        var val_4;
        this.indexLevel = level;
        if(levelState != 0)
        {
                val_4 = 22790304;
        }
        else
        {
                val_4 = 22790292;
        }
        
        this.animator.Play(stateName:  -1610606023, layer:  0, normalizedTime:  null);
        this.bgIconImage.sprite = this.levelIcon[levelState];
        if(levelType > 3)
        {
                return;
        }
        
        var val_1 = 18255552 + (18255552 + (levelType) << 2);
        if(levelType == 3)
        {
                18255552 = 18255552;
            18255552 = 18255552 & (this >> (18255552 + (levelType) << 2));
            18255552 = 18255552 * (18255552 + (levelType) << 2);
            18255552 = 18255552 & ((IP) << 4);
        }
        
        this.boss.SetActive(value:  true);
        this.mode1.SetActive(value:  false);
        this.mode2.SetActive(value:  false);
        this.mode3.SetActive(value:  false);
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_3 = -1073708883.CurrentLevel;
        if(0 <= 429496729)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + 1717986916;
        this.iconBoss.sprite = (0 + 1717986916) + 16;
    }
    private void ActiveNote()
    {
        this.bgIconImage.enabled = true;
        this.bgIconImage.sprite = this.levelIcon[1];
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        var val_4 = 0;
        var val_2 = (mem[3221266315] + 20) + 16;
        do
        {
            if(val_4 >= (mem[3221266315] + 20 + 12))
        {
                return;
        }
        
            val_4 = val_4 + 1;
        }
        while(this.indexLevel != ((mem[3221266315] + 20 + 16) + 0));
        
        this.bgIconImage.enabled = false;
    }
    public LevelNode()
    {
    
    }

}
