using UnityEngine;
public class PieceController : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image iconImage;
    private UnityEngine.UI.Image bgImage;
    private TMPro.TextMeshProUGUI labelText;
    private TMPro.TextMeshProUGUI amountText;
    private UnityEngine.Sprite coinIconSprite;
    private UnityEngine.Sprite diamondIconSprite;
    private UnityEngine.Sprite[] listBgSprites;
    private UnityEngine.Sprite[] listSkinSprites;
    private ItemSpinInfo itemSpin;
    
    // Methods
    public void Setup(ItemSpinInfo item)
    {
        this.itemSpin = item;
        this.UpdateDisplay();
    }
    public void UpdateDisplay()
    {
        string val_11;
        UnityEngine.UI.Image val_12;
        UnityEngine.Sprite val_13;
        this.amountText.text = -1610612735;
        UnityEngine.RectTransform val_1 = this.iconImage.rectTransform;
        this.iconImage.sizeDelta = new UnityEngine.Vector2() {x = 100f, y = 100f};
        string val_2 = this.itemSpin.rewardValue.ToString();
        val_11 = this.itemSpin.rewardValue;
        this.labelText.text = val_11;
        if(this.itemSpin.itemType == 0)
        {
            goto label_7;
        }
        
        if(this.itemSpin.itemType == 2)
        {
            goto label_8;
        }
        
        if(this.itemSpin.itemType != 1)
        {
                return;
        }
        
        val_12 = this.iconImage;
        val_13 = this.coinIconSprite;
        goto label_10;
        label_7:
        val_12 = this.iconImage;
        val_13 = this.diamondIconSprite;
        label_10:
        val_12.sprite = val_13;
        return;
        label_8:
        if((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) == false)
        {
                return;
        }
        
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CheckSkinUnlock(id:  this.itemSpin.rewardValue)) != false)
        {
                this.iconImage.sprite = this.coinIconSprite;
            WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            string val_7 = mem[3221266283] + 24;
            string val_8 = val_7.ToString();
            this.labelText.text = val_7;
            return;
        }
        
        this.iconImage.sprite = this.listSkinSprites[this.itemSpin.rewardValue];
        UnityEngine.RectTransform val_9 = this.iconImage.rectTransform;
        this.iconImage.sizeDelta = new UnityEngine.Vector2() {x = 120f, y = 120f};
        this.labelText.text = -1610604813;
    }
    public PieceController()
    {
    
    }

}
