using UnityEngine;
public class TriggerHuggyMove : MonoBehaviour
{
    // Fields
    private bool characterTrigger;
    private bool chestTrigger;
    private UnityEngine.BoxCollider2D myCollider;
    private TriggerHuggyMove.TypeTriggerHuggyMove typeTrigger;
    
    // Methods
    private void Awake()
    {
        this.myCollider.enabled = false;
        this.Invoke(methodName:  -1610602603, time:  null);
    }
    private void WaitEnableCollider()
    {
        this.myCollider.enabled = true;
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        var val_9;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((-1073701079.CanCheck()) == false)
        {
                return;
        }
        
        if(this.typeTrigger != 1)
        {
                if(this.typeTrigger != 0)
        {
                return;
        }
        
            if((collision.CompareTag(tag:  -1610607703)) == false)
        {
                return;
        }
        
            val_9 = 22742212;
            WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073700997.WaitDoneMoveHuggy();
        }
        else
        {
                if((collision.CompareTag(tag:  -1610607703)) == false)
        {
                return;
        }
        
            val_9 = 22742212;
            WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073700997.WaitAllRopeCutDoneMoveHuggy();
        }
        
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266327].Untie();
        UnityEngine.GameObject val_8 = this.gameObject;
        this.SetActive(value:  false);
    }
    public TriggerHuggyMove()
    {
    
    }

}
