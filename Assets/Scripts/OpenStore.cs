using UnityEngine;
public class OpenStore : MonoBehaviour
{
    // Fields
    private string url;
    private UnityEngine.GameObject androidButton;
    private UnityEngine.GameObject iosButton;
    private OpenStore.StoreData data;
    
    // Methods
    private void Start()
    {
        this.androidButton.SetActive(value:  false);
        this.iosButton.SetActive(value:  false);
        System.Collections.IEnumerator val_1 = this.GetText();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  524050096);
    }
    private System.Collections.IEnumerator GetText()
    {
        536900143 = new OpenStore.<GetText>d__5(<>1__state:  0);
        mem[536900159] = this;
    }
    public void ClickOpenAndroidStore()
    {
    
    }
    public void ClickOpenIOSStore()
    {
    
    }
    public OpenStore()
    {
        this.url = -1610600093;
    }

}
