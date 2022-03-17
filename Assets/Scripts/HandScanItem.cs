using UnityEngine;
public class HandScanItem : MonoBehaviour
{
    // Fields
    private int scanId;
    private UnityEngine.Events.UnityEvent onScanSuccess;
    private Spine.Unity.SkeletonAnimation skeletonAnimation;
    
    // Methods
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        System.Action val_8;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609881, volume:  null);
        UnityEngine.GameObject val_2 = collision.gameObject;
        val_8 = collision;
        if((val_8.CompareTag(tag:  -1610607725)) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_4 = collision.gameObject;
        Weight val_5 = collision.GetComponent<Weight>();
        if((-1073688989) == this.scanId)
        {
                UnityEngine.GameObject val_6 = collision.gameObject;
            collision.SetActive(value:  false);
            val_8 = 536882991;
            val_8 = new System.Action(object:  685544720, method:  new IntPtr(1610679755));
            MixSkinManager.SetAnimation(ske:  this.skeletonAnimation, name:  -1610598531, loop:  false, timeScale:  null, _callBack:  1065353216);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -1610602495);
    }
    private void ScanObject()
    {
    
    }
    public HandScanItem()
    {
    
    }
    private void <OnCollisionEnter2D>b__3_0()
    {
        MixSkinManager.SetAnimation(ske:  this.skeletonAnimation, name:  -1610600009, loop:  true, timeScale:  null, _callBack:  1065353216);
        this.onScanSuccess.Invoke();
    }

}
