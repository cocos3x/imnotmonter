using UnityEngine;
public class ItemSpin : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image iconItem;
    private TMPro.TextMeshProUGUI amount;
    
    // Methods
    public void SetData(UnityEngine.Sprite _img, string _amount, bool showtext = True)
    {
        this.iconItem.sprite = _img;
        this.amount.text = _amount;
        UnityEngine.GameObject val_1 = this.amount.gameObject;
        this.amount.SetActive(value:  showtext);
    }
    public ItemSpin()
    {
    
    }

}
