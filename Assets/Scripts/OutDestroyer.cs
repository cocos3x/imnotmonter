using UnityEngine;
public class OutDestroyer : MonoBehaviour
{
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = position;
        if(this >= 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_4 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  875121936);
    }
    public OutDestroyer()
    {
    
    }

}
