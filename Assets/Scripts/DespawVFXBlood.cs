using UnityEngine;
public class DespawVFXBlood : MonoBehaviour
{
    // Fields
    public float timeDelay;
    private bool checkDespaw;
    
    // Methods
    private void OnEnable()
    {
        if(this.checkDespaw != false)
        {
                this.DespawObj();
            return;
        }
        
        this.checkDespaw = true;
        this.Invoke(methodName:  -1610608755, time:  null);
    }
    private void OnDisable()
    {
        if(this.checkDespaw == false)
        {
                return;
        }
        
        this.CancelInvoke(methodName:  -1610608755);
        this.checkDespaw = false;
    }
    private void DespawObj()
    {
        this.checkDespaw = false;
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Transform val_2 = this.transform;
        this.SetParent(p:  0);
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.GameObject val_4 = this.gameObject;
        -1073701087.Despaw(go:  714909584, delay:  null);
    }
    public DespawVFXBlood()
    {
        this.timeDelay = 3f;
    }

}
