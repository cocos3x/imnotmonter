using UnityEngine;
public class PressHandler : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
    // Fields
    public PressHandler.ButtonPressEvent OnPress;
    
    // Methods
    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
    {
        this.OnPress.Invoke();
    }
    public PressHandler()
    {
        PressHandler.ButtonPressEvent val_1 = 536900551;
        val_1 = new PressHandler.ButtonPressEvent();
        this.OnPress = val_1;
    }

}
