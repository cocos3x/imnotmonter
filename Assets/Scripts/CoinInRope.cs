using UnityEngine;
public class CoinInRope : MonoBehaviour
{
    // Fields
    private UnityEngine.SpriteRenderer spriteRender;
    private UnityEngine.CircleCollider2D myCollider;
    private TMPro.TextMeshPro valueText;
    private bool isTape;
    private int <CoinValue>k__BackingField;
    
    // Properties
    public int CoinValue { get; set; }
    
    // Methods
    public int get_CoinValue()
    {
        return (int)this.<CoinValue>k__BackingField;
    }
    private void set_CoinValue(int value)
    {
        this.<CoinValue>k__BackingField = value;
    }
    private void Start()
    {
        this.<CoinValue>k__BackingField = 10;
        if((UnityEngine.Object.op_Implicit(exists:  this.valueText)) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = R4 + 20.gameObject;
        R4 + 20.SetActive(value:  false);
    }
    public void Collect()
    {
        var val_4;
        this.ActiveDisplayValueText();
        this.myCollider.enabled = false;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Vector3 val_3 = position;
        float val_9 = 2f;
        val_9 = val_4 + val_9;
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOMoveY(target:  689687312, endValue:  val_9, duration:  val_3.y, snapping:  val_9);
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  689687312, ease:  7);
        536895905 = new DG.Tweening.TweenCallback(object:  689687312, method:  new IntPtr(1610679829));
        DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  689687312, action:  536895905);
    }
    public void ActiveDisplayValueText()
    {
        var val_4;
        UnityEngine.GameObject val_1 = this.valueText.gameObject;
        this.valueText.SetActive(value:  true);
        if(this.isTape != false)
        {
                val_4 = -1610611915;
        }
        else
        {
                string val_2 = this.<CoinValue>k__BackingField.ToString();
            string val_3 = -1610611917(-1610611917) + 689799580;
            val_4 = -1610611917;
        }
        
        this.valueText.text = -1610611917;
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        UnityEngine.GameObject val_1 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610607703)) == false)
        {
                return;
        }
        
        this.Collect();
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609309, volume:  null);
    }
    public CoinInRope()
    {
    
    }
    private void <Collect>b__9_0()
    {
        var val_8;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if(this.isTape != false)
        {
                val_8 = -1073708883.RopeTapeBonusReward;
            -1073708883.RopeTapeBonusReward = val_8 + 1;
        }
        else
        {
                val_8 = -1073708883.RopeCoinBonusReward;
            -1073708883.RopeCoinBonusReward = (this.<CoinValue>k__BackingField) + val_8;
        }
        
        UnityEngine.GameObject val_6 = this.valueText.gameObject;
        this.valueText.SetActive(value:  false);
        UnityEngine.GameObject val_7 = this.gameObject;
        this.SetActive(value:  false);
    }

}
