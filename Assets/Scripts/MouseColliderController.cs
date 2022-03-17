using UnityEngine;
public class MouseColliderController : MonoBehaviour
{
    // Fields
    private UnityEngine.CircleCollider2D col;
    
    // Methods
    private void Start()
    {
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        this.col = this;
    }
    private void Update()
    {
        float val_5;
        float val_6;
        if((UnityEngine.Input.GetMouseButton(button:  0)) != false)
        {
                this.col.enabled = true;
            UnityEngine.Transform val_2 = this.col.transform;
            UnityEngine.Camera val_3 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_4 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector3 val_8 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_5, z = val_6});
            this.col.position = new UnityEngine.Vector3() {x = val_5, y = val_6, z = 0f};
            return;
        }
        
        this.col.enabled = false;
    }
    public MouseColliderController()
    {
    
    }

}
