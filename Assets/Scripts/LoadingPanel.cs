using UnityEngine;
public class LoadingPanel : MonoBehaviour
{
    // Methods
    private void OnEnable()
    {
        this.Invoke(methodName:  -1610608849, time:  null);
    }
    private void DeactiveAuto()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    public LoadingPanel()
    {
    
    }

}
