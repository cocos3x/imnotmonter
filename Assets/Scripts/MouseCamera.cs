using UnityEngine;
public class MouseCamera : MonoBehaviour
{
    // Fields
    public float distance;
    private UnityEngine.Vector2 _startPosition;
    private UnityEngine.Vector2 _currentPosition;
    
    // Methods
    private void Update()
    {
    
    }
    private void Start()
    {
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = eulerAngles;
        this._startPosition = new UnityEngine.Vector2();
        mem[1152921509775928228] = ???;
    }
    private void LateUpdate()
    {
        float val_5;
        float val_6;
        float val_7;
        float val_8;
        float val_1 = UnityEngine.Input.GetAxis(axisName:  -1610606233);
        uint val_10 = 2684361063;
        val_10 = this._currentPosition + val_10;
        this._currentPosition = val_10;
        float val_2 = UnityEngine.Input.GetAxis(axisName:  -1610606231);
        uint val_11 = 2684361065;
        UnityEngine.Vector2 val_12 = this._startPosition;
        val_11 = this._currentPosition - val_11;
        val_12 = val_12 + this._currentPosition;
        UnityEngine.Vector2 val_3 = S4 + val_11;
        mem[1152921509776040236] = val_11;
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(x:  val_11, y:  null, z:  val_12);
        UnityEngine.Transform val_9 = this.transform;
        this.rotation = new UnityEngine.Quaternion() {x = val_5, y = val_6, z = val_7, w = val_8};
    }
    private void FixedUpdate()
    {
    
    }
    public MouseCamera()
    {
        this.distance = 5f;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this._currentPosition = new UnityEngine.Vector2();
        mem[1152921509776264236] = ???;
    }

}
