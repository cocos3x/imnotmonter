using UnityEngine;
public class HandPushButton : MonoBehaviour
{
    // Fields
    private HandPushButton.ButtonDisplay buttonDisplay;
    private UnityEngine.Transform button;
    private UnityEngine.Transform buttonUpPos;
    private UnityEngine.Transform buttonDownPos;
    private UnityEngine.Transform handPassedTarget;
    private UnityEngine.Animator animatorScan;
    private UnityEngine.Events.UnityEvent buttonUpAction;
    private UnityEngine.Events.UnityEvent buttonDownAction;
    private UnityEngine.Color32 selectedColor;
    private UnityEngine.SpriteRenderer[] spriteRenderers;
    private bool isButtonDown;
    
    // Methods
    public void OnTriggerEnterButton(UnityEngine.Collider2D collision)
    {
        HandPushButton val_15;
        UnityEngine.Collider2D val_16;
        UnityEngine.Collider2D val_17;
        val_15 = this;
        val_16 = collision;
        HandPushButton.<>c__DisplayClass11_0 val_1 = 536899237;
        val_1 = new HandPushButton.<>c__DisplayClass11_0();
        mem[536899245] = val_15;
        UnityEngine.GameObject val_2 = val_16.gameObject;
        val_17 = val_16;
        if(this.buttonDisplay != 0)
        {
                if((val_17.CompareTag(tag:  -1610605337)) == false)
        {
                return;
        }
        
            UnityEngine.GameObject val_4 = val_16.gameObject;
            val_17 = val_16.layer;
            if(val_17 != (UnityEngine.LayerMask.NameToLayer(layerName:  -1610608505)))
        {
                return;
        }
        
            UnityEngine.Transform val_7 = val_16.GetComponent<UnityEngine.Transform>();
            val_16 = val_1;
            mem[536899249] = val_16;
            val_17 = mem[536899249];
            if((UnityEngine.Object.op_Implicit(exists:  val_17)) == false)
        {
                return;
        }
        
            if((collision + 64) != 1)
        {
                return;
        }
        
            UnityEngine.Vector3 val_9 = position;
            val_16 = 536882991;
            val_16 = new System.Action(object:  536899237, method:  new IntPtr(1610679745));
            val_17 = 536882991;
            val_17 = new System.Action(object:  536899237, method:  new IntPtr(1610679747));
            UnityEngine.Collider2D val_12 = mem[536899249] + 96;
            mem2[0] = 1;
            mem2[0] = val_16;
            mem2[0] = val_17;
            return;
        }
        
        if((val_17.CompareTag(tag:  -1610607725)) == false)
        {
                return;
        }
        
        this.ButtonDown();
        WorldTimeAPI val_14 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609881, volume:  null);
    }
    public void OnTriggerExitButton(UnityEngine.Collider2D collision)
    {
        UnityEngine.GameObject val_1 = collision.gameObject;
        if(this.buttonDisplay != 0)
        {
                if((collision.CompareTag(tag:  -1610605337)) == false)
        {
                return;
        }
        
            UnityEngine.GameObject val_3 = collision.gameObject;
            if(collision.layer != (UnityEngine.LayerMask.NameToLayer(layerName:  -1610608505)))
        {
                return;
        }
        
            UnityEngine.Transform val_6 = collision.GetComponent<UnityEngine.Transform>();
            bool val_7 = UnityEngine.Object.op_Implicit(exists:  collision);
            if(val_7 == false)
        {
                return;
        }
        
            if(val_7 != true)
        {
                return;
        }
        
            mem2[0] = 0;
            WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610607817, volume:  null);
            return;
        }
        
        if((collision.CompareTag(tag:  -1610607725)) == false)
        {
                return;
        }
        
        this.ButtonUp();
    }
    private void ButtonDown()
    {
        if(this.buttonDisplay != 0)
        {
                this.buttonDownAction.Invoke();
            return;
        }
        
        UnityEngine.Vector3 val_1 = position;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.button, endValue:  new UnityEngine.Vector3(), duration:  val_1.x, snapping:  true);
        536895905 = new DG.Tweening.TweenCallback(object:  684910992, method:  new IntPtr(1610679739));
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.button, action:  536895905);
    }
    private void ButtonUp()
    {
        if(this.buttonDisplay != 0)
        {
                this.buttonUpAction.Invoke();
            return;
        }
        
        UnityEngine.Vector3 val_1 = position;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.button, endValue:  new UnityEngine.Vector3(), duration:  val_1.x, snapping:  true);
        536895905 = new DG.Tweening.TweenCallback(object:  685055760, method:  new IntPtr(1610679741));
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.button, action:  536895905);
    }
    public HandPushButton()
    {
    
    }
    private void <ButtonDown>b__13_0()
    {
        this.buttonDownAction.Invoke();
    }
    private void <ButtonUp>b__14_0()
    {
        this.buttonUpAction.Invoke();
    }

}
