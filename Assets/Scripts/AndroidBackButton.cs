using UnityEngine;
public class AndroidBackButton : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button button;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        this.button = this;
    }
    private void Update()
    {
        if((UnityEngine.Input.GetKeyDown(key:  27)) == false)
        {
                return;
        }
        
        R4 + 12 + 176.Invoke();
    }
    public AndroidBackButton()
    {
    
    }

}
