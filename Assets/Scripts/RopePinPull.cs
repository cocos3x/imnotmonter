using UnityEngine;
public class RopePinPull : MonoBehaviour
{
    // Fields
    public UnityEngine.Rigidbody2D hook;
    public UnityEngine.GameObject linkPrefab;
    public Weight weigth;
    public int links;
    public int point;
    public int order;
    public bool canApartTotalRope;
    public bool canCutRope;
    public bool huggyRope;
    public bool useLimitAngle;
    public float lowerLimitAngle;
    public float upperLimitAngle;
    private bool cutted;
    
    // Methods
    private void Start()
    {
        this.GenerateRope();
    }
    private void OnEnable()
    {
        this.canCutRope = true;
    }
    private void GenerateRope()
    {
        float val_11;
        float val_12;
        int val_14;
        UnityEngine.Rigidbody2D val_15;
        var val_16;
        float val_17;
        Weight val_18;
        int val_19;
        UnityEngine.Rigidbody2D val_20;
        var val_21;
        val_14 = this.links;
        if(val_14 < 1)
        {
            goto label_1;
        }
        
        val_15 = this.hook;
        var val_15 = 0;
        val_16 = 22713552;
        val_17 = 4.028715E-38f;
        goto label_2;
        label_16:
        val_15 = this.hook;
        label_2:
        UnityEngine.Transform val_1 = val_15.transform;
        UnityEngine.Transform val_2 = val_15.parent;
        val_18 = true;
        UnityEngine.RectTransform val_3 = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  this.linkPrefab, parent:  val_15);
        val_19 = this.linkPrefab;
        Weight val_4 = val_19.GetComponent<Weight>();
        mem2[0] = this;
        Weight val_5 = val_19.GetComponent<Weight>();
        val_19.connectedBody = 1;
        int val_14 = this.links;
        val_14 = val_14 - 1;
        if(val_15 < val_14)
        {
                Weight val_6 = val_19.GetComponent<Weight>();
        }
        else
        {
                val_18 = this.weigth;
            Weight val_7 = val_19.GetComponent<Weight>();
            val_19 = this.order;
            if(this.useLimitAngle == true)
        {
                this.useLimitAngle = 1;
        }
        
            val_18.ConnectRopeEnd(endRB:  val_19, point:  this.point, order:  val_19, useLimitAngle:  true, lowerAngle:  null, upperAngle:  null);
            val_16 = 22713552;
            val_17 = 4.028715E-38f;
        }
        
        val_14 = this.links;
        val_15 = val_15 + 1;
        if(val_15 < val_14)
        {
            goto label_16;
        }
        
        label_1:
        if(val_14 != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_8 = this.gameObject;
        SynchronizationContextBehavoir val_9 = this.AddComponent<SynchronizationContextBehavoir>();
        if(this != 0)
        {
                this.autoConfigureConnectedAnchor = false;
            val_20 = this.hook;
            val_21 = this;
        }
        else
        {
                val_21 = 0;
            0.autoConfigureConnectedAnchor = false;
            val_20 = this.hook;
        }
        
        this.connectedBody = val_20;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.zero;
        if(this != 0)
        {
                val_21.anchor = new UnityEngine.Vector2() {x = val_11, y = val_12};
        }
        else
        {
                val_21.anchor = new UnityEngine.Vector2() {x = val_11, y = val_12};
        }
        
        val_17 = 0;
        val_21.connectedAnchor = new UnityEngine.Vector2() {x = 0f, y = 0f};
        UnityEngine.Transform val_13 = this.GetComponent<UnityEngine.Transform>();
        val_16 = this;
        val_18 = this.point;
        if(this.useLimitAngle == true)
        {
                val_19 = 1;
        }
        
        this.weigth.ConnectRopeEnd(endRB:  630646160, point:  val_18, order:  this.order, useLimitAngle:  true, lowerAngle:  val_10.x, upperAngle:  val_10.y);
    }
    public void CutRopeCharacter()
    {
        this.weigth.DestroyRope();
    }
    public void CutLink(UnityEngine.Transform _transform)
    {
        float val_3;
        float val_4;
        float val_5;
        if(this.cutted == true)
        {
                return;
        }
        
        this.cutted = true;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        22975222 = -1073701087;
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.GameObject val_6 = val_7.GetItem(key:  -1610608973, position:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_5});
        this.Invoke(methodName:  -1610604649, time:  val_2.x);
    }
    private void SetCanSpawn()
    {
        this.cutted = false;
    }
    public RopePinPull()
    {
        this.links = 7;
        this.canApartTotalRope = true;
        this.canCutRope = true;
    }

}
