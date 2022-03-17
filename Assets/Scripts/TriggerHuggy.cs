using UnityEngine;
public class TriggerHuggy : MonoBehaviour
{
    // Fields
    private bool hasTarget;
    private UnityEngine.Transform handPassedPoint;
    private UnityEngine.Animator animatorScan;
    
    // Methods
    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        float val_8;
        float val_9;
        float val_10;
        UnityEngine.Collider2D val_13;
        UnityEngine.Collider2D val_14;
        val_13 = other;
        TriggerHuggy.<>c__DisplayClass3_0 val_1 = 536902067;
        val_1 = new TriggerHuggy.<>c__DisplayClass3_0();
        mem[536902075] = this;
        UnityEngine.GameObject val_2 = val_13.gameObject;
        val_14 = val_13.layer;
        if(val_14 != (UnityEngine.LayerMask.NameToLayer(layerName:  -1610608505)))
        {
                return;
        }
        
        UnityEngine.Transform val_5 = val_13.GetComponent<UnityEngine.Transform>();
        val_13 = val_1;
        mem[536902079] = val_13;
        val_14 = mem[536902079];
        if((UnityEngine.Object.op_Implicit(exists:  val_14)) == false)
        {
                return;
        }
        
        val_14 = mem[536902079];
        if((other + 64) != 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_7 = position;
        val_13 = 536882991;
        val_13 = new System.Action(object:  536902067, method:  new IntPtr(1610680045));
        val_14 = 536882991;
        val_14 = new System.Action(object:  536902067, method:  new IntPtr(1610680047));
        mem[536902079].HandInTarget(_positon:  new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10}, _callBackHandInTarget:  val_13, _callBackHandOutTarget:  val_14);
    }
    private void OnTriggerExit2D(UnityEngine.Collider2D other)
    {
        UnityEngine.GameObject val_1 = other.gameObject;
        if(other.layer != (UnityEngine.LayerMask.NameToLayer(layerName:  -1610608505)))
        {
                return;
        }
        
        UnityEngine.Transform val_4 = other.GetComponent<UnityEngine.Transform>();
        bool val_5 = UnityEngine.Object.op_Implicit(exists:  other);
        if(val_5 == false)
        {
                return;
        }
        
        if(val_5 == true)
        {
                return;
        }
        
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701023.HandUnPress();
        R4.HandOutTarget();
        R4.ChangeStatusHand(statusHand:  1);
    }
    public TriggerHuggy()
    {
    
    }

}
