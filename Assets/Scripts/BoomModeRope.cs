using UnityEngine;
public class BoomModeRope : MonoBehaviour
{
    // Fields
    private UnityEngine.Collider2D collTriggerPlayer;
    private UnityEngine.GameObject attackDame;
    private UnityEngine.GameObject img;
    private UnityEngine.Events.UnityEvent eventBoom;
    private bool hasTarget;
    
    // Methods
    private void OnTriggerEnter2D(UnityEngine.Collider2D coll)
    {
        if(this.hasTarget == true)
        {
                return;
        }
        
        if((R5.CompareTag(tag:  -1610605337)) == true)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = R5.gameObject;
        if(R5.layer == (UnityEngine.LayerMask.NameToLayer(layerName:  -1610608505)))
        {
                return;
        }
        
        R4.Explosion();
    }
    public void Explosion()
    {
        float val_5;
        float val_6;
        float val_7;
        this.hasTarget = true;
        this.collTriggerPlayer.enabled = false;
        this.img.SetActive(value:  false);
        if(this.eventBoom != 0)
        {
                this.eventBoom.Invoke();
        }
        
        this.attackDame.SetActive(value:  true);
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.Transform val_3 = this.transform;
        UnityEngine.Vector3 val_4 = position;
        UnityEngine.GameObject val_8 = -1073701087.GetItem(key:  -1610602869, position:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_7});
        -1073701087.Despaw(go:  -1073701087, delay:  val_4.x);
        UnityEngine.Coroutine val_9 = this.StartCoroutine(methodName:  -1610604639);
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609919, volume:  val_4.x);
    }
    private System.Collections.IEnumerator SetHideAttackDame()
    {
        536898135 = new BoomModeRope.<SetHideAttackDame>d__7(<>1__state:  0);
        mem[536898151] = this;
    }
    public BoomModeRope()
    {
        UnityEngine.Events.UnityEvent val_1 = 536896303;
        val_1 = new UnityEngine.Events.UnityEvent();
        this.eventBoom = val_1;
    }

}
