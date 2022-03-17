using UnityEngine;
public abstract class Unit : MonoBehaviour
{
    // Fields
    protected UnityEngine.SpriteRenderer spriteRender;
    protected UnityEngine.Rigidbody2D myBody;
    protected UnityEngine.CircleCollider2D myCollider;
    protected UnityEngine.CircleCollider2D colliderCheck;
    protected UnityEngine.PhysicsMaterial2D normalPhysicMaterial;
    protected UnityEngine.PhysicsMaterial2D stonePhysicMaterial;
    private bool <isStone>k__BackingField;
    
    // Properties
    public bool isStone { get; set; }
    
    // Methods
    public bool get_isStone()
    {
        return (bool)this.<isStone>k__BackingField;
    }
    private void set_isStone(bool value)
    {
        this.<isStone>k__BackingField = value;
    }
    protected virtual void Start()
    {
    
    }
    public void ChangeStone()
    {
        if((this.<isStone>k__BackingField) == true)
        {
                return;
        }
        
        mem2[0] = 1;
        UnityEngine.GameObject val_1 = R4.gameObject;
        R4.layer = UnityEngine.LayerMask.NameToLayer(layerName:  -1610608815);
        R4 + 20.sharedMaterial = R4 + 32;
        R4 + 16.sharedMaterial = R4 + 32;
        R4 + 16.gravityScale = null;
        R4 + 20.isTrigger = false;
        UnityEngine.Coroutine val_3 = R4.StartCoroutine(methodName:  -1610602605);
    }
    protected virtual void SetStatusForChangeStone()
    {
        this.colliderCheck.tag = -1610604361;
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            UnityEngine.Transform val_3 = this.transform;
            UnityEngine.Vector3 val_4 = position;
            UnityEngine.GameObject val_5 = -1073701087.GetItem(key:  -1610602573, position:  new UnityEngine.Vector3() {x = R4, y = R6});
            WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701087.Despaw(go:  -1073701087, delay:  val_4.x);
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610602573, volume:  val_4.x);
    }
    private System.Collections.IEnumerator WaitChangeStone()
    {
        536902149 = new Unit.<WaitChangeStone>d__13(<>1__state:  0);
        mem[536902165] = this;
    }
    protected Unit()
    {
    
    }

}
