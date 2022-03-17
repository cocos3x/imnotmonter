using UnityEngine;
public class PowerOutletController : MonoBehaviour
{
    // Fields
    private UnityEngine.LineRenderer line;
    private UnityEngine.Transform pos_PowerOutlet1;
    private UnityEngine.Transform pos_End;
    private UnityEngine.Transform pos_PowerOutlet2;
    private UnityEngine.GameObject arrowPowerOutlet1;
    private UnityEngine.Events.UnityEvent completedConnectPower;
    private UnityEngine.Animator anim_Electric_1;
    private UnityEngine.Animator anim_Electric_2;
    private bool electricVersion1;
    private UnityEngine.Gradient color;
    private bool updateConnect;
    private bool hasConnect;
    private bool connectElectric1;
    private bool connectElectric2;
    private HandTarget handTarget;
    
    // Methods
    public void RenderLine()
    {
        float val_2;
        float val_3;
        float val_4;
        this.line.positionCount = 2;
        UnityEngine.Vector3 val_1 = position;
        this.line.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4});
        UnityEngine.Vector3 val_5 = position;
        this.line.SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4});
        this.line.sortingLayerName = -1610607863;
        this.line.sortingOrder = 0;
    }
    private void Start()
    {
        UnityEngine.Vector3 val_1 = position;
        this.pos_End.position = new UnityEngine.Vector3() {x = R6, y = R7, z = R8};
        this.arrowPowerOutlet1.SetActive(value:  false);
        this.SetRotationArrow();
        this.SetPosStartLine();
    }
    private void SetPosStartLine()
    {
        float val_4;
        var val_5;
        float val_6;
        UnityEngine.Transform val_1 = this.pos_End.transform;
        UnityEngine.Transform val_2 = this.pos_PowerOutlet1.transform;
        UnityEngine.Vector3 val_3 = position;
        float val_8 = 0f;
        float val_7 = val_4;
        float val_9 = val_6;
        val_7 = val_7 + val_8;
        val_8 = val_5 + val_8;
        val_9 = val_9 + (-0.51f);
        this.pos_End.position = new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_7};
        this.RenderLine();
    }
    private void SetRotationArrow()
    {
        float val_3;
        float val_8;
        float val_15;
        float val_16;
        UnityEngine.Transform val_1 = this.pos_PowerOutlet1.transform;
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Transform val_4 = this.pos_PowerOutlet2.transform;
        UnityEngine.Vector3 val_5 = position;
        UnityEngine.Transform val_6 = this.pos_PowerOutlet1.transform;
        UnityEngine.Vector3 val_7 = position;
        UnityEngine.Transform val_9 = this.pos_PowerOutlet2.transform;
        UnityEngine.Vector3 val_10 = position;
        float val_17 = val_8;
        float val_11 = val_3 - val_3;
        val_17 = val_8 - val_17;
        val_11.Normalize();
        float val_18 = 57.29578f;
        val_18 = val_17 * val_18;
        UnityEngine.GameObject val_12 = this.arrowPowerOutlet1.gameObject;
        UnityEngine.Transform val_13 = this.arrowPowerOutlet1.transform;
        float val_19 = -180f;
        val_19 = val_18 + val_19;
        UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.Euler(x:  val_19, y:  val_10.y, z:  val_11);
        this.arrowPowerOutlet1.rotation = new UnityEngine.Quaternion() {x = val_3, y = val_8, z = val_15, w = val_16};
    }
    private void FixedUpdate()
    {
        float val_4;
        var val_5;
        float val_6;
        if(this.updateConnect == false)
        {
                return;
        }
        
        if(this.hasConnect == true)
        {
                return;
        }
        
        UnityEngine.Transform val_1 = this.pos_End.transform;
        UnityEngine.Transform val_2 = this.handTarget.transform;
        UnityEngine.Vector3 val_3 = position;
        float val_9 = 0f;
        float val_8 = val_4;
        float val_10 = val_6;
        val_8 = val_8 + val_9;
        val_9 = val_5 + val_9;
        val_10 = val_10 + 0.2f;
        this.pos_End.position = new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_8};
        UnityEngine.Vector3 val_7 = position;
        this.line.SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = R4, y = R6});
    }
    public void HandTriggerEnterPowerOutlet1(UnityEngine.Collider2D other)
    {
        float val_7;
        float val_8;
        float val_9;
        if(this.hasConnect == false)
        {
                this.hasConnect = this.connectElectric1;
            goto label_1;
        }
        
        return;
        label_1:
        UnityEngine.GameObject val_1 = other.gameObject;
        if(other.layer != (UnityEngine.LayerMask.NameToLayer(layerName:  -1610608505)))
        {
                return;
        }
        
        UnityEngine.Transform val_4 = other.GetComponent<UnityEngine.Transform>();
        this.handTarget = other;
        if((UnityEngine.Object.op_Implicit(exists:  this.handTarget)) == false)
        {
                return;
        }
        
        this.connectElectric1 = true;
        if(this.connectElectric2 != false)
        {
                this.CheckHandElectric();
            this.handTarget.ReleaseHoldingObject();
            this.updateConnect = false;
            return;
        }
        
        UnityEngine.Vector3 val_6 = position;
        this.line.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9});
        this.arrowPowerOutlet1.SetActive(value:  true);
        this.updateConnect = true;
        UnityEngine.Transform val_10 = this.line.transform;
        this.handTarget.AddHoldingObject(handHoldItem:  this.line);
        this.handTarget.ChangeStatusHand(statusHand:  2);
    }
    public void HandTriggerExitPowerOutlet1(UnityEngine.Collider2D other)
    {
    
    }
    public void HandTriggerEnterPowerOutlet2(UnityEngine.Collider2D other)
    {
        if(this.hasConnect == false)
        {
                this.hasConnect = this.connectElectric2;
            goto label_1;
        }
        
        return;
        label_1:
        UnityEngine.GameObject val_1 = other.gameObject;
        if(other.layer != (UnityEngine.LayerMask.NameToLayer(layerName:  -1610608505)))
        {
                return;
        }
        
        UnityEngine.Transform val_4 = other.GetComponent<UnityEngine.Transform>();
        this.handTarget = other;
        bool val_5 = UnityEngine.Object.op_Implicit(exists:  this.handTarget);
        if(val_5 == true)
        {
                val_5 = this.connectElectric1;
        }
        
        if(val_5 == false)
        {
                return;
        }
        
        this.connectElectric2 = true;
        this.CheckHandElectric();
        this.handTarget.ReleaseHoldingObject();
        this.updateConnect = false;
    }
    public void HandTriggerExitPowerOutlet2(UnityEngine.Collider2D other)
    {
    
    }
    private void CheckHandElectric()
    {
        float val_4;
        float val_5;
        float val_6;
        if(this.connectElectric1 == true)
        {
                this.connectElectric1 = this.connectElectric2;
            goto label_1;
        }
        
        return;
        label_1:
        this.hasConnect = true;
        UnityEngine.Transform val_1 = this.pos_End.transform;
        UnityEngine.Vector3 val_2 = position;
        this.pos_End.position = new UnityEngine.Vector3() {x = R6, y = R7, z = R8};
        UnityEngine.Vector3 val_3 = position;
        this.line.SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6});
        UnityEngine.Vector3 val_7 = position;
        this.line.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6});
        this.anim_Electric_2.Play(stateName:  -1610608569, layer:  0, normalizedTime:  val_7.x);
        this.anim_Electric_1.Play(stateName:  -1610608569, layer:  0, normalizedTime:  val_7.x);
        this.arrowPowerOutlet1.SetActive(value:  false);
        this.line.colorGradient = this.color;
        if(this.completedConnectPower == 0)
        {
                return;
        }
        
        this.completedConnectPower.Invoke();
    }
    private void CheckHandInElectric1(HandTarget _hand)
    {
        this.connectElectric1 = true;
        this.anim_Electric_1.Play(stateName:  -1610608567, layer:  0, normalizedTime:  null);
        this.CheckHandElectric();
    }
    private void CheckHandOutElectric1(HandTarget _hand)
    {
        this.connectElectric1 = false;
    }
    private void CheckHandInElectric2(HandTarget _hand)
    {
        this.connectElectric2 = true;
        this.anim_Electric_2.Play(stateName:  -1610608567, layer:  0, normalizedTime:  null);
        this.CheckHandElectric();
    }
    private void CheckHandOutElectric2(HandTarget _hand)
    {
        this.connectElectric2 = false;
    }
    public void HandDontHold()
    {
        if(this.hasConnect == true)
        {
                return;
        }
        
        mem2[0] = 0;
        mem2[0] = 0;
        R4 + 28.SetActive(value:  false);
        R4.SetPosStartLine();
        R4 + 56.ChangeStatusHand(statusHand:  1);
    }
    public PowerOutletController()
    {
        UnityEngine.Events.UnityEvent val_1 = 536896303;
        val_1 = new UnityEngine.Events.UnityEvent();
        this.completedConnectPower = val_1;
        this.electricVersion1 = true;
    }

}
