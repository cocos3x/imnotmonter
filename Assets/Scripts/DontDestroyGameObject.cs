using UnityEngine;
public class DontDestroyGameObject : MonoBehaviour
{
    // Fields
    private static DontDestroyGameObject instance;
    
    // Methods
    private void Awake()
    {
        if(mem[536886141] == 0)
        {
                mem2[0] = this;
            UnityEngine.Object.DontDestroyOnLoad(target:  503956656);
            return;
        }
        
        UnityEngine.GameObject val_2 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  503956656);
    }
    public DontDestroyGameObject()
    {
    
    }

}
