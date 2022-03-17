using UnityEngine;
public class CutTheRopeTouchManager : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject linePrefab;
    public LineBehaviour activeLine;
    private UnityEngine.GameObject line;
    
    // Methods
    private void Update()
    {
        float val_4;
        float val_5;
        CutTheRopeTouchManager val_16;
        object val_17;
        float val_18;
        float val_19;
        LineBehaviour val_20;
        val_16 = this;
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
        {
                UnityEngine.Camera val_2 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector3 val_7 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_4, z = val_5});
            val_17 = mem[1152921509495908636];
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.identity;
            object val_9 = UnityEngine.Object.Instantiate<System.Object>(original:  val_17, position:  new UnityEngine.Vector3() {x = SB, y = SL, z = 0f}, rotation:  new UnityEngine.Quaternion());
            val_16 = val_16;
            mem[1152921509495908644] = val_17;
            Weight val_10 = mem[1152921509495908644].GetComponent<Weight>();
            val_20 = val_16;
            mem[1152921509495908640] = mem[1152921509495908644];
        }
        else
        {
                val_20 = this.activeLine;
        }
        
        if(mem[this.activeLine] != 0)
        {
                UnityEngine.Camera val_12 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_13 = UnityEngine.Input.mousePosition;
            val_19 = val_5;
            UnityEngine.Vector3 val_14 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_4, z = val_19});
            val_17 = mem[this.activeLine];
            val_18 = val_5;
            val_17.updateLine(mousePosition:  new UnityEngine.Vector2() {x = val_4, y = val_18});
        }
        
        if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
        {
                return;
        }
        
        this.activeLine = 0;
        UnityEngine.Object.Destroy(obj:  this.line);
    }
    public CutTheRopeTouchManager()
    {
    
    }

}
