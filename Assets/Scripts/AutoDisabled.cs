using UnityEngine;
public class AutoDisabled : MonoBehaviour
{
    // Methods
    private void DisabledMe()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.GameObject val_2 = this.gameObject;
        -1073701087.Despaw(go:  589110416, delay:  null);
    }
    private void DisabledParentMe()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Transform val_3 = this.parent;
        UnityEngine.GameObject val_4 = this.gameObject;
        -1073701087.Despaw(go:  589222416, delay:  null);
    }
    public AutoDisabled()
    {
    
    }

}
