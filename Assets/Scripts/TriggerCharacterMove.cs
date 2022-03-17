using UnityEngine;
public class TriggerCharacterMove : MonoBehaviour
{
    // Fields
    private TriggerCharacterMove.TypeTriggerMove typeTrigger;
    private UnityEngine.BoxCollider2D myCollider;
    private bool chestTrigger;
    private bool characterTrigger;
    
    // Methods
    private void Awake()
    {
        System.Collections.IEnumerator val_1 = this.WaitTimeEnableCollider();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  629817104);
    }
    private void WaitEnableCollider()
    {
        System.Collections.IEnumerator val_1 = this.WaitTimeEnableCollider();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  629929104);
    }
    private System.Collections.IEnumerator WaitTimeEnableCollider()
    {
        536902059 = new TriggerCharacterMove.<WaitTimeEnableCollider>d__6(<>1__state:  0);
        mem[536902075] = this;
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        var val_14;
        var val_15;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_14 = -1073701037;
        if(val_14.CanCheck() == false)
        {
                return;
        }
        
        if(this.typeTrigger > 8)
        {
                return;
        }
        
        var val_3 = 4982172 + (4982172 + (this.typeTrigger) << 2);
        if(this.typeTrigger == 8)
        {
                4982172 + (this.typeTrigger) << 2 = (4982172 + (this.typeTrigger) << 2) & 630161296;
            4982172 + (this.typeTrigger) << 2 = (4982172 + (this.typeTrigger) << 2) & ((IP) >> (4982172 + (this.typeTrigger) << 2 & 630161296));
            4982172 + (this.typeTrigger) << 2 = (4982172 + (this.typeTrigger) << 2) & (this >> (4982172 + (this.typeTrigger) << 2));
            4982172 + (this.typeTrigger) << 2 = (4982172 + (this.typeTrigger) << 2) & (((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        ));
            4982172 + (this.typeTrigger) << 2 = (4982172 + (this.typeTrigger) << 2) & 1260322592;
            4982172 + (this.typeTrigger) << 2 = IP * (4982172 + (this.typeTrigger) << 2);
            mem2[0] = (IP * (((((4982172 + (this.typeTrigger) << 2 & 630161296) & (IP) >> (4982172 + (this.typeTrigger) << 2 & 630161296)) & ((int)this) >> ((4982172 + (this.typeTrigger) << 2 & 630161296) & (IP) >> (498217 + this;
            ((IP * (((((4982172 + (this.typeTrigger) << 2 & 630161296) & (IP) >> (4982172 + (this.typeTrigger) << 2 & 630161296)) & ((int)this) >> ((4982172 + (this.typeTrigger) << 2 & 630161296) & (IP) >> (498217 + this) & (((IP * (((((4982172 + (this.typeTrigger) << 2 & 630161296) & (IP) >> (4982172 + (this.typeTrigger) << 2 & 630161296)) & ((int)this) >> ((4982172 + (this.typeTrigger) << 2 & 630161296) & (IP) >> (498217 + this) << 4982172) = R8 * 4982172;
        }
        
        val_15 = 22791664;
        if((collision.CompareTag(tag:  -1610609357)) == false)
        {
                return;
        }
        
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700989.WaitDoneEnemyTargetMoveCharacter();
        UnityEngine.GameObject val_8 = this.gameObject;
        this.SetActive(value:  false);
    }
    public TriggerCharacterMove()
    {
    
    }

}
