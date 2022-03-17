using UnityEngine;
public class SingleJoystick : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler
{
    // Fields
    public bool joystickStaysInFixedPosition;
    public int joystickHandleDistance;
    private UnityEngine.GameObject[] tutorials;
    private UnityEngine.UI.Image bgImage;
    private UnityEngine.UI.Image joystickKnobImage;
    private UnityEngine.Vector3 inputVector;
    private UnityEngine.Vector3 unNormalizedInput;
    private UnityEngine.Vector3[] fourCornersArray;
    private UnityEngine.Vector2 bgImageStartPosition;
    public static System.Action<UnityEngine.Vector3> GetInputDirection;
    private bool canDrag;
    private bool checkedCam;
    private UnityEngine.Transform buttonZoom;
    public UnityEngine.Vector2 startScale;
    public UnityEngine.Vector2 endScale;
    
    // Methods
    private void Start()
    {
        var val_21;
        UnityEngine.Vector2 val_22;
        val_21 = 22755328;
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        val_22 = 22713552;
        if(543531664 == 0)
        {
                UnityEngine.Debug.LogError(message:  -1610603543);
        }
        
        UnityEngine.Transform val_3 = this.transform;
        UnityEngine.Transform val_4 = this.GetChild(index:  0);
        UnityEngine.Transform val_5 = this.GetComponent<UnityEngine.Transform>();
        if(543531664 == 0)
        {
                UnityEngine.Debug.LogError(message:  -1610603545);
        }
        
        UnityEngine.Transform val_7 = this.GetComponent<UnityEngine.Transform>();
        if(543531664 == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_9 = this.transform;
        UnityEngine.Transform val_10 = this.GetChild(index:  0);
        UnityEngine.Transform val_11 = this.GetComponent<UnityEngine.Transform>();
        if(543531664 == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_13 = this.GetComponent<UnityEngine.Transform>();
        this.bgImage = this;
        UnityEngine.Transform val_14 = this.transform;
        UnityEngine.Transform val_15 = this.GetChild(index:  0);
        UnityEngine.Transform val_16 = this.GetComponent<UnityEngine.Transform>();
        this.joystickKnobImage = this;
        UnityEngine.RectTransform val_17 = this.rectTransform;
        this.SetAsLastSibling();
        UnityEngine.RectTransform val_18 = mem[this.bgImage].rectTransform;
        mem[this.bgImage].GetWorldCorners(fourCornersArray:  this.fourCornersArray);
        this.bgImageStartPosition = this.fourCornersArray[3];
        mem[1152921509445346000] = this.fourCornersArray[3];
        UnityEngine.RectTransform val_19 = this.rectTransform;
        this.pivot = new UnityEngine.Vector2() {x = 1f, y = 0f};
        val_21 = 0;
        UnityEngine.RectTransform val_20 = mem[this.bgImage].rectTransform;
        val_22 = this.bgImageStartPosition;
        mem[this.bgImage].position = new UnityEngine.Vector3() {x = val_22, y = mem[1152921509445346000], z = 0f};
    }
    public virtual void OnDrag(UnityEngine.EventSystems.PointerEventData ped)
    {
        float val_2;
        float val_3;
        float val_23;
        UnityEngine.RectTransform val_34;
        UnityEngine.Vector2 val_35;
        float val_36;
        float val_37;
        var val_38;
        float val_39;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        UnityEngine.RectTransform val_4 = this.bgImage.rectTransform;
        val_34 = this.bgImage;
        if(ped != 0)
        {
                val_35 = ped.<position>k__BackingField;
        }
        else
        {
                val_36 = 308;
            val_35 = 4;
        }
        
        val_37 = 0f;
        UnityEngine.Camera val_5 = ped.pressEventCamera;
        if((UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  val_34, screenPoint:  new UnityEngine.Vector2() {x = 5.605194E-45f, y = 4.315999E-43f}, cam:  ped, localPoint: out  new UnityEngine.Vector2() {x = 1.973355E-19f, y = val_37})) == false)
        {
                return;
        }
        
        UnityEngine.RectTransform val_7 = this.bgImage.rectTransform;
        UnityEngine.Vector2 val_8 = sizeDelta;
        float val_34 = val_2;
        val_34 = val_2 / val_34;
        UnityEngine.RectTransform val_9 = this.bgImage.rectTransform;
        UnityEngine.Vector2 val_10 = sizeDelta;
        float val_35 = val_3;
        float val_37 = -1f;
        float val_36 = val_34;
        val_34 = this.inputVector;
        val_35 = val_3 / val_35;
        val_38 = 0;
        mem[1152921509445576760] = 0;
        val_36 = val_36 + val_36;
        mem[1152921509445576772] = 0;
        val_37 = (val_35 + val_35) + val_37;
        val_36 = val_36 + 1f;
        this.inputVector = val_36;
        mem[1152921509445576756] = val_37;
        this.unNormalizedInput = val_36;
        mem[1152921509445576768] = val_37;
        float val_12 = val_34.magnitude;
        if(this.bgImage > 0)
        {
                val_38 = val_34;
            UnityEngine.Vector3 val_13 = normalized;
        }
        
        UnityEngine.RectTransform val_14 = this.joystickKnobImage.rectTransform;
        val_36 = this.joystickKnobImage;
        UnityEngine.RectTransform val_15 = this.bgImage.rectTransform;
        UnityEngine.Vector2 val_16 = sizeDelta;
        UnityEngine.RectTransform val_17 = this.bgImage.rectTransform;
        UnityEngine.Vector2 val_18 = sizeDelta;
        float val_38 = (float)this.joystickHandleDistance;
        float val_39 = val_3;
        val_38 = val_2 / val_38;
        val_39 = val_39 / (float)this.joystickHandleDistance;
        val_38 = this.inputVector * val_38;
        val_39 = S18 * val_39;
        val_36.anchoredPosition = new UnityEngine.Vector2() {x = val_38, y = val_39};
        if(this.joystickStaysInFixedPosition != true)
        {
                float val_19 = this.unNormalizedInput.magnitude;
            float val_20 = val_34.magnitude;
            if(this.joystickStaysInFixedPosition > false)
        {
                UnityEngine.RectTransform val_21 = this.bgImage.rectTransform;
            UnityEngine.Vector3 val_22 = position;
            val_37 = val_23;
            float val_41 = val_3;
            UnityEngine.Vector2 val_40 = ped.<delta>k__BackingField;
            if(ped != 0)
        {
            
        }
        else
        {
                val_39 = mem[ped.<delta>k__BackingField + 4];
            val_39 = ped.<delta>k__BackingField.y;
        }
        
            val_40 = val_2 + val_40;
            UnityEngine.RectTransform val_24 = this.bgImage.rectTransform;
            UnityEngine.Vector2 val_25 = sizeDelta;
            float val_26 = val_2 + 0f;
            float val_28 = UnityEngine.Mathf.Clamp(value:  (float)UnityEngine.Screen.width, min:  val_25.y, max:  val_2);
            val_41 = val_41 + val_39;
            UnityEngine.RectTransform val_30 = this.bgImage.rectTransform;
            UnityEngine.Vector2 val_31 = sizeDelta;
            float val_42 = (float)UnityEngine.Screen.height;
            val_42 = val_42 - val_3;
            float val_32 = UnityEngine.Mathf.Clamp(value:  val_42, min:  val_31.y, max:  val_3);
            val_36 = val_41;
            val_34 = 0;
            UnityEngine.RectTransform val_33 = this.bgImage.rectTransform;
            this.bgImage.position = new UnityEngine.Vector3() {x = val_40, y = val_36, z = val_37};
        }
        
        }
        
        if(mem[536893881] == 0)
        {
                return;
        }
        
        mem[536893881].Invoke(obj:  new UnityEngine.Vector3() {x = this.inputVector, y = val_36, z = 0f});
    }
    public virtual void OnPointerDown(UnityEngine.EventSystems.PointerEventData ped)
    {
        if(this.canDrag == false)
        {
                return;
        }
        
        goto typeof(SingleJoystick).__il2cppRuntimeField_F4;
    }
    public virtual void OnPointerUp(UnityEngine.EventSystems.PointerEventData ped)
    {
        var val_2;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.inputVector = new UnityEngine.Vector3();
        mem[1152921509445862196] = ???;
        mem[1152921509445862200] = val_2;
        if(mem[536893881] != 0)
        {
                mem[536893881].Invoke(obj:  new UnityEngine.Vector3() {z = 0f});
        }
        
        UnityEngine.RectTransform val_3 = this.joystickKnobImage.rectTransform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.joystickKnobImage.anchoredPosition = new UnityEngine.Vector2() {x = R5, y = R6};
    }
    public UnityEngine.Vector3 GetInput()
    {
        this = R1 + 32;
        return new UnityEngine.Vector3();
    }
    public SingleJoystick()
    {
        this.joystickHandleDistance = 4;
        this.fourCornersArray = 536882597;
    }

}
