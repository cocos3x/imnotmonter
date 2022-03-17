using UnityEngine;
public class TriggerPowerOutliet : MonoBehaviour
{
    // Fields
    private UnityEngine.Events.UnityEvent<UnityEngine.Collider2D> eventEnterHand;
    private UnityEngine.Events.UnityEvent<UnityEngine.Collider2D> eventExitHand;
    
    // Methods
    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        if(this.eventEnterHand == 0)
        {
                return;
        }
        
        this.eventEnterHand.Invoke(arg0:  other);
    }
    private void OnTriggerExit2D(UnityEngine.Collider2D other)
    {
        if(this.eventExitHand == 0)
        {
                return;
        }
        
        this.eventExitHand.Invoke(arg0:  other);
    }
    public TriggerPowerOutliet()
    {
        UnityEngine.Events.UnityEvent<System.String> val_1 = 536880199;
        val_1 = new UnityEngine.Events.UnityEvent<System.String>();
        this.eventEnterHand = val_1;
        UnityEngine.Events.UnityEvent<System.String> val_2 = 536880199;
        val_2 = new UnityEngine.Events.UnityEvent<System.String>();
        this.eventExitHand = val_2;
    }

}
