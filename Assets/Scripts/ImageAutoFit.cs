using UnityEngine;
public class ImageAutoFit : MonoBehaviour
{
    // Fields
    public bool AutoDestroy;
    
    // Methods
    private void Start()
    {
        float val_14;
        float val_15;
        var val_16;
        float val_19;
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        UnityEngine.Rect val_2 = rect;
        float val_3 = width;
        UnityEngine.Rect val_4 = rect;
        float val_5 = height;
        UnityEngine.Transform val_6 = this.GetComponent<UnityEngine.Transform>();
        uint val_17 = 487333664;
        UnityEngine.Rect val_7 = rect;
        float val_8 = width;
        uint val_18 = 487333664;
        val_17 = val_17 / 487333664;
        UnityEngine.Rect val_9 = rect;
        float val_10 = height;
        val_18 = val_18 / 487333664;
        UnityEngine.Transform val_11 = this.transform;
        if(this < 0)
        {
                UnityEngine.Vector3 val_12 = localScale;
            val_19 = val_17 / val_18;
        }
        else
        {
                UnityEngine.Vector3 val_13 = localScale;
            val_19 = val_18 / val_17;
        }
        
        float val_19 = val_14;
        float val_20 = val_15;
        val_19 = val_19 * val_19;
        val_20 = val_19 * val_20;
        val_19 = val_19 * val_16;
        this.localScale = new UnityEngine.Vector3() {x = val_19, y = val_19, z = val_20};
        if(this.AutoDestroy == false)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  487345712);
    }
    public ImageAutoFit()
    {
        this.AutoDestroy = true;
    }

}
