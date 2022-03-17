using UnityEngine;
public class SpringRopeHand : MonoBehaviour
{
    // Fields
    private Spine.Unity.SkeletonAnimation springSkeleton;
    private float myForce;
    
    // Methods
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        float val_7;
        float val_8;
        float val_9;
        UnityEngine.GameObject val_1 = collision.gameObject;
        val_9 = collision;
        if((val_9.CompareTag(tag:  -1610607725)) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = collision.gameObject;
        Weight val_4 = collision.GetComponent<Weight>();
        UnityEngine.Transform val_5 = this.transform;
        UnityEngine.Vector3 val_6 = up;
        float val_9 = val_7;
        float val_10 = val_8;
        val_9 = val_9 * this.myForce;
        val_10 = val_10 * this.myForce;
        val_9 = val_10;
        collision.AddForce(force:  new UnityEngine.Vector2() {x = val_9, y = val_9});
        this.SpringAnim();
    }
    private void SpringAnim()
    {
        536882991 = new System.Action(object:  702872592, method:  new IntPtr(1610680035));
        MixSkinManager.SetAnimation(ske:  this.springSkeleton, name:  -1610606789, loop:  false, timeScale:  null, _callBack:  1065353216);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610604411, volume:  null);
    }
    public SpringRopeHand()
    {
    
    }
    private void <SpringAnim>b__3_0()
    {
        MixSkinManager.SetAnimation(ske:  this.springSkeleton, name:  -1610607513, loop:  false, timeScale:  null, _callBack:  1065353216);
    }

}
