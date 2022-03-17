using UnityEngine;
public class AnchoreMouse : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector3 screenPoint;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    private void OnMouseDown()
    {
        float val_5;
        float val_6;
        UnityEngine.Camera val_1 = UnityEngine.Camera.main;
        UnityEngine.GameObject val_2 = this.gameObject;
        UnityEngine.Transform val_3 = this.transform;
        UnityEngine.Vector3 val_4 = position;
        UnityEngine.Vector3 val_8 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_5, z = val_6});
    }
    private void OnMouseDrag()
    {
        float val_2;
        float val_4;
        UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
        UnityEngine.Camera val_5 = UnityEngine.Camera.main;
        UnityEngine.Vector3 val_6 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_2, z = val_4});
        UnityEngine.Transform val_7 = this.transform;
        this.position = new UnityEngine.Vector3() {x = R5, y = R6, z = R7};
    }
    public AnchoreMouse()
    {
    
    }

}
