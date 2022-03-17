using UnityEngine;
public class TutorialControllor : MonoBehaviour
{
    // Fields
    private UnityEngine.Events.UnityEvent eventCompletedAnim;
    private Spine.Unity.SkeletonGraphic skeletonGrab;
    
    // Methods
    public void CompletedAnim()
    {
        this.eventCompletedAnim.Invoke();
    }
    public void SetAnimGrabOpen()
    {
        Spine.AnimationState val_1 = this.skeletonGrab.AnimationState;
        Spine.TrackEntry val_2 = this.skeletonGrab.SetAnimation(trackIndex:  0, animationName:  -1610598931, loop:  false);
        536897929 = new AnimationState.TrackEntryDelegate(object:  737257616, method:  new IntPtr(1610680571));
        this.skeletonGrab.add_Complete(value:  536897929);
    }
    private void SetAnimCloseGrab()
    {
        Spine.AnimationState val_1 = this.skeletonGrab.AnimationState;
        Spine.TrackEntry val_2 = this.skeletonGrab.SetAnimation(trackIndex:  0, animationName:  -1610601365, loop:  false);
    }
    public TutorialControllor()
    {
    
    }
    private void <SetAnimGrabOpen>b__3_0(Spine.TrackEntry e)
    {
        this.Invoke(methodName:  -1610604653, time:  null);
    }

}
