using UnityEngine;
public class HuggyController : SingletonMonoBehaviour<HuggyController>
{
    // Fields
    private UnityEngine.RectTransform cage2;
    private HandTarget handRed;
    private HuggyMove huggyMove;
    private UnityEngine.GameObject objectText;
    private UnityEngine.Events.UnityEvent onHandPressing;
    private bool Pressing;
    private int progressIndex;
    private UnityEngine.GameObject[] progressObjects;
    private bool saveCompleted;
    private float timePress;
    
    // Methods
    private void OnEnable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  690628368, method:  new IntPtr(1610679857));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  690628368, eventID:  5, callback:  536873423);
    }
    private void OnDisable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  690740368, method:  new IntPtr(1610679859));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  690740368, eventID:  5, callback:  536873423);
    }
    public void HandPress(HandTarget _handBlue)
    {
        if(this.saveCompleted == false)
        {
                this.saveCompleted = this.Pressing;
            goto label_1;
        }
        
        return;
        label_1:
        this.handRed = _handBlue;
        this.Pressing = true;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610607819, volume:  null);
        this.Invoke(methodName:  -1610610343, time:  null);
        if(this.onHandPressing == 0)
        {
                return;
        }
        
        this.onHandPressing.Invoke();
    }
    public void HandUnPress()
    {
        var val_2;
        if(this.saveCompleted == true)
        {
                return;
        }
        
        if((R4 + 32) == 0)
        {
                return;
        }
        
        val_2 = 0;
        mem2[0] = val_2;
        mem2[0] = val_2;
        R4.CancelInvoke(methodName:  -1610610343);
        goto label_2;
        label_7:
        var val_1 = (R4 + 40) + 0;
        (R4 + 40 + 0) + 16.SetActive(value:  false);
        val_2 = 1;
        label_2:
        if(val_2 < (R4 + 40 + 12))
        {
            goto label_7;
        }
    
    }
    private void ActiveObject()
    {
        var val_1;
        if(this.Pressing == false)
        {
            goto label_1;
        }
        
        if(this.progressIndex <= 3)
        {
            goto label_2;
        }
        
        this.saveCompleted = true;
        this.handRed.stopAll = true;
        this.UnlockCage();
        return;
        label_1:
        val_1 = 0;
        goto label_4;
        label_9:
        UnityEngine.GameObject val_1 = this.progressObjects[val_1];
        val_1.SetActive(value:  false);
        val_1 = 1;
        label_4:
        if(val_1 < val_1)
        {
            goto label_9;
        }
        
        return;
        label_2:
        this.progressObjects[this.progressIndex].SetActive(value:  true);
        int val_3 = this.progressIndex;
        val_3 = val_3 + 1;
        this.progressIndex = val_3;
        this.Invoke(methodName:  -1610610343, time:  null);
    }
    private void UnlockCage()
    {
        float val_3;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610605585, volume:  null);
        UnityEngine.Vector2 val_2 = sizeDelta;
        DG.Tweening.Tweener val_4 = DG.Tweening.DOTweenModuleUI.DOSizeDelta(target:  this.cage2, endValue:  new UnityEngine.Vector2() {x = val_3, y = 0f}, duration:  val_2.x, snapping:  false);
        DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.cage2, ease:  1);
        UnityEngine.Transform val_6 = this.huggyMove.transform;
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.huggyMove, endValue:  val_2.x, duration:  val_2.y, snapping:  true);
        DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  this.huggyMove, delay:  val_2.x);
        DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.huggyMove, ease:  1);
        536895905 = new DG.Tweening.TweenCallback(object:  691458704, method:  new IntPtr(1610679861));
        DG.Tweening.Tweener val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.huggyMove, action:  536895905);
    }
    private void HuggyMove()
    {
        GameTool.EventDispatcherExtension.PostEvent(sender:  691599376, eventID:  34);
        UnityEngine.Transform val_1 = this.huggyMove.transform;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.Transform val_3 = -1073700957.transLevel;
        this.huggyMove.SetParent(p:  -1073700957);
        536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>(collection:  this.handRed.rope2D.wayPointsToMove);
        536878517.Reverse();
        this.huggyMove.MovePeople(waypoints:  536878517);
    }
    private void ShowTextAnim()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.objectText)) == false)
        {
                return;
        }
        
        R4 + 24.SetActive(value:  true);
        Weight val_2 = R4 + 24.GetComponent<Weight>();
        R4.Invoke(methodName:  -1610607733, time:  UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null));
    }
    private void HidenTextAnim()
    {
        UnityEngine.GameObject val_1 = this.objectText.gameObject;
        this.objectText.SetActive(value:  false);
        this.Invoke(methodName:  -1610604569, time:  UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null));
    }
    public HuggyController()
    {
        this.timePress = 1.5f;
    }
    private void <OnEnable>b__10_0(UnityEngine.Component Comparer, object param)
    {
        this.HandUnPress();
    }
    private void <OnDisable>b__11_0(UnityEngine.Component Comparer, object param)
    {
        this.HandUnPress();
    }
    private void <UnlockCage>b__15_0()
    {
        this.huggyMove.SetAnimIdle();
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610605269, volume:  null);
        this.Invoke(methodName:  -1610607701, time:  null);
    }

}
