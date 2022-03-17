using UnityEngine;
public class HandLaserItem : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject[] laserLine;
    
    // Methods
    public void EnabledLaser()
    {
        goto label_0;
        label_4:
        1152921506690760672.SetActive(value:  true);
        0 = 1;
        label_0:
        if(0 < 1152921506690760672)
        {
            goto label_4;
        }
    
    }
    public void DisabledLaser()
    {
        goto label_0;
        label_4:
        1152921506690760672.SetActive(value:  false);
        0 = 1;
        label_0:
        if(0 < 1152921506690760672)
        {
            goto label_4;
        }
    
    }
    public HandLaserItem()
    {
    
    }

}
