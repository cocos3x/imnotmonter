using UnityEngine;
public class BaseHuggyController : MonoBehaviour
{
    // Fields
    private bool facingLeft;
    private UnityEngine.GameObject ropeObj;
    private TextEffect textEffect;
    
    // Methods
    private void Start()
    {
        this.SetScale();
    }
    private void SetScale()
    {
        bool val_3;
        float val_4;
        float val_5;
        float val_6;
        val_3 = this.facingLeft;
        UnityEngine.Transform val_1 = this.transform;
        if(val_3 != false)
        {
                val_4 = 49024;
            val_4 = 3212836864;
            val_5 = 1065353216;
            val_6 = 1065353216;
        }
        else
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            val_4 = R6;
            val_5 = R7;
            val_6 = R8;
        }
        
        this.localScale = new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6};
        this.textEffect.SetScale();
    }
    public void Untie()
    {
        this.ropeObj.SetActive(value:  false);
    }
    public BaseHuggyController()
    {
    
    }

}
