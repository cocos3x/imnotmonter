using UnityEngine;
public class CoinIngamePinPull : Unit
{
    // Fields
    private UnityEngine.Sprite[] listSpriteCoin;
    
    // Methods
    public void RandomSprite()
    {
        string val_1 = Berry.Utils.Utils.GetRandom<System.String>(collection:  this.listSpriteCoin);
        static_value_015E9010.sprite = this.listSpriteCoin;
    }
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        UnityEngine.Vector2 val_1 = velocity;
        if(this > 0)
        {
                return;
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609313, volume:  -2f);
    }
    private void OnTriggerStay2D(UnityEngine.Collider2D collision)
    {
        var val_16;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_16 = -1073701037.CanCheck();
        if(val_16 != false)
        {
                if((collision.CompareTag(tag:  -1610605337)) != false)
        {
                WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_16 = mem[3221266323];
            if(val_16.CanTarget() != false)
        {
                WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem2[0] = 0;
            WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266323].Win();
            WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_16 = -1073701037;
            val_16.Win(delayTime:  null);
        }
        
        }
        
            if((collision.CompareTag(tag:  -1610606719)) == false)
        {
                return;
        }
        
            WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266323].Lose();
            WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701037.Lose();
        }
        else
        {
                if((collision.CompareTag(tag:  -1610606719)) == false)
        {
                return;
        }
        
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_14 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610602573, volume:  null);
        }
        
        UnityEngine.GameObject val_15 = this.gameObject;
        this.SetActive(value:  false);
    }
    public CoinIngamePinPull()
    {
    
    }

}
