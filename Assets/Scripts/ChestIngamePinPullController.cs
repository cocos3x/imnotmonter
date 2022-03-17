using UnityEngine;
public class ChestIngamePinPullController : MonoBehaviour
{
    // Fields
    private UnityEngine.Rigidbody2D myBody;
    private UnityEngine.BoxCollider2D myCollider;
    private Spine.Unity.SkeletonAnimation mainSkeleton;
    private UnityEngine.GameObject mainObject;
    private bool canCheck;
    private bool canRotateIfTriggerPlayer;
    private bool isFalling;
    
    // Methods
    private void Update()
    {
        this.RotateMainObject();
    }
    private void FixedUpdate()
    {
        if(this.canCheck == false)
        {
                return;
        }
        
        this.CheckFalling();
    }
    private void Collect()
    {
        this.canCheck = false;
        this.myBody.bodyType = 2;
        this.myCollider.enabled = false;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem2[0] = 2;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266323].Win();
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701037.Win(delayTime:  null);
        System.Collections.IEnumerator val_4 = this.OpenChest();
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  632677136);
    }
    private System.Collections.IEnumerator OpenChest()
    {
        536898273 = new ChestIngamePinPullController.<OpenChest>d__10(<>1__state:  0);
        mem[536898289] = this;
    }
    private void RotateMainObject()
    {
        float val_2;
        float val_6;
        float val_7;
        float val_8;
        if(this.canRotateIfTriggerPlayer == false)
        {
                return;
        }
        
        UnityEngine.Vector2 val_1 = velocity;
        if(this.myBody > 0)
        {
                return;
        }
        
        UnityEngine.Transform val_3 = this.mainObject.transform;
        UnityEngine.Transform val_4 = this.mainObject.transform;
        UnityEngine.Quaternion val_5 = rotation;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 3.216758E-16f});
        float val_11 = UnityEngine.Time.deltaTime;
        float val_13 = 20f;
        val_13 = 0 * val_13;
        UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = 3.216758E-16f, y = val_6, z = val_2, w = val_7}, b:  new UnityEngine.Quaternion() {x = val_8}, t:  val_13);
        this.mainObject.rotation = new UnityEngine.Quaternion() {x = val_6, y = val_2, z = val_7, w = val_8};
    }
    private void CheckFalling()
    {
        UnityEngine.Vector2 val_1 = velocity;
        if(this.myBody <= 0)
        {
                0 = 1;
        }
        
        this.isFalling = true;
    }
    private void DestroyObj()
    {
        float val_8;
        float val_9;
        float val_10;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  -1073701113)) != false)
        {
                WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610609353, volume:  null);
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            UnityEngine.Transform val_6 = this.transform;
            UnityEngine.Vector3 val_7 = position;
            UnityEngine.GameObject val_11 = -1073701087.GetItem(key:  -1610604487, position:  new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10});
            WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            22742040 = -1073701087;
            val_14.Despaw(go:  -1073701087, delay:  val_7.x);
        }
        
        UnityEngine.GameObject val_13 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        var val_12;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_12 = -1073701037.CanCheck();
        if(val_12 == false)
        {
            goto label_3;
        }
        
        if((collision.CompareTag(tag:  -1610605337)) != false)
        {
                this.canRotateIfTriggerPlayer = true;
            this.Collect();
        }
        
        if((collision.CompareTag(tag:  -1610606719)) == false)
        {
            goto label_11;
        }
        
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266323].Lose();
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_12 = -1073701037;
        val_12.Lose();
        goto label_10;
        label_3:
        if((collision.CompareTag(tag:  -1610606719)) == false)
        {
            goto label_11;
        }
        
        label_10:
        this.DestroyObj();
        label_11:
        bool val_8 = collision.CompareTag(tag:  -1610608497);
        if(val_8 == true)
        {
                val_8 = this.isFalling;
            goto label_13;
        }
        
        return;
        label_13:
        UnityEngine.Transform val_9 = collision.GetComponent<UnityEngine.Transform>();
        collision.Dead();
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610608667, volume:  null);
    }
    public ChestIngamePinPullController()
    {
        this.canCheck = true;
    }

}
