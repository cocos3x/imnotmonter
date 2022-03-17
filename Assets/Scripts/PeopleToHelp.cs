using UnityEngine;
public class PeopleToHelp : MonoBehaviour
{
    // Fields
    private HuggyMove myFollow;
    private UnityEngine.BoxCollider2D boxCollider;
    private UnityEngine.Sprite[] listEmoti;
    private UnityEngine.SpriteRenderer iconEmoti;
    private UnityEngine.GameObject txt_Box;
    private bool isHelp;
    
    // Methods
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        UnityEngine.Object val_12 = 23000570;
        if(this.isHelp != false)
        {
                if(this.enabled == false)
        {
                return;
        }
        
        }
        
        UnityEngine.GameObject val_2 = collision.gameObject;
        val_12 = collision;
        if((val_12.CompareTag(tag:  -1610598855)) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_4 = collision.gameObject;
        Weight val_5 = collision.GetComponent<Weight>();
        val_12 = collision;
        if(val_12 == 0)
        {
                return;
        }
        
        this.isHelp = true;
        UnityEngine.Object.Destroy(obj:  this.boxCollider);
        UnityEngine.GameObject val_7 = collision.gameObject;
        string val_8 = this.name;
        UnityEngine.GameObject val_9 = collision.gameObject;
        string val_10 = collision.name;
        string val_11 = 720376848 + -1610612539(-1610612539) + collision;
        UnityEngine.Debug.Log(message:  720376848);
        this.myFollow.waypointindex = val_12;
        this.enabled = false;
    }
    private System.Collections.IEnumerator OnDelay(int i)
    {
        PeopleToHelp.<OnDelay>d__7 val_1 = 536900279;
        val_1 = new PeopleToHelp.<OnDelay>d__7(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536900299] = this;
        }
        else
        {
                mem[20] = this;
        }
        
        mem[536900295] = i;
    }
    private System.Collections.IEnumerator OnDelay1()
    {
        536900277 = new PeopleToHelp.<OnDelay1>d__8(<>1__state:  0);
        mem[536900293] = this;
    }
    private void OnEnable()
    {
    
    }
    private System.Collections.IEnumerator ShowEmoti(float time)
    {
        PeopleToHelp.<ShowEmoti>d__10 val_1 = 536900281;
        val_1 = new PeopleToHelp.<ShowEmoti>d__10(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536900301] = this;
        }
        else
        {
                mem[20] = this;
        }
        
        mem[536900297] = R1;
    }
    public PeopleToHelp()
    {
    
    }

}
