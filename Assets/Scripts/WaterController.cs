using UnityEngine;
public class WaterController : Unit
{
    // Fields
    private UnityEngine.GameObject waterChildObject;
    private UnityEngine.GameObject stoneObject;
    
    // Methods
    private void SetupStart()
    {
        this.waterChildObject.SetActive(value:  true);
        this.stoneObject.SetActive(value:  false);
    }
    protected override void SetStatusForChangeStone()
    {
        this.SetStatusForChangeStone();
        this.waterChildObject.SetActive(value:  false);
        this.stoneObject.SetActive(value:  true);
    }
    private void OnTriggerStay2D(UnityEngine.Collider2D collision)
    {
        if(true != 0)
        {
                return;
        }
        
        if((R5.CompareTag(tag:  -1610604361)) != true)
        {
                if((R5.CompareTag(tag:  -1610606719)) == false)
        {
                return;
        }
        
        }
        
        R4.ChangeStone();
    }
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        float val_8;
        var val_9;
        var val_10;
        if(this != 0)
        {
                UnityEngine.Vector2 val_1 = velocity;
            val_8 = -2f;
            if(this > 0)
        {
                return;
        }
        
            if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
            WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_9 = -1073701113;
            val_10 = 22793624;
        }
        else
        {
                UnityEngine.Vector2 val_5 = velocity;
            val_8 = -2f;
            if(this > 0)
        {
                return;
        }
        
            if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
            WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_9 = -1073701113;
            val_10 = 22797188;
        }
        
        val_9.Shot(clip:  -1610602571, volume:  val_8);
    }
    public WaterController()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
