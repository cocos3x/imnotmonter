using UnityEngine;
public class SawModeRope : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform[] movePoints;
    private float moveSpeed;
    private float rotateSpeed;
    private float rotateTarget;
    private DG.Tweening.LoopType moveType;
    private bool canRotate;
    private bool startIdle;
    private bool moveInited;
    private DG.Tweening.Sequence mySequence;
    
    // Methods
    private void Start()
    {
        if(this.canRotate != false)
        {
                UnityEngine.Transform val_1 = this.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DORotate(target:  701374480, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = this.rotateTarget}, duration:  this.rotateSpeed, mode:  this.rotateSpeed);
            DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  701374480, loops:  0, loopType:  0);
            DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  701374480, ease:  1);
        }
        
        if(this.startIdle != false)
        {
                this.StartMoveIdle();
            return;
        }
        
        this.SetMove();
    }
    private void SetMove()
    {
        UnityEngine.Transform[] val_9;
        536900875 = new SawModeRope.<>c__DisplayClass10_0();
        mem[536900883] = this;
        val_9 = this.movePoints;
        if(536900883 == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Transform val_9 = this.movePoints[0];
        UnityEngine.Vector3 val_3 = position;
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOMove(target:  701564304, endValue:  new UnityEngine.Vector3(), duration:  this.moveSpeed, snapping:  this.moveSpeed);
        DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetSpeedBased<DG.Tweening.Tweener>(t:  701564304, isSpeedBased:  true);
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  701564304, ease:  1);
        mem[536900887] = this;
        val_9 = 536895905;
        val_9 = new DG.Tweening.TweenCallback(object:  536900875, method:  new IntPtr(1610680027));
        DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  701564304, action:  536895905);
    }
    private void StartMoving()
    {
        var val_9;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        this.mySequence = 0;
        val_9 = 5;
        goto label_3;
        label_8:
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Transform val_10 = this.movePoints[1];
        UnityEngine.Vector3 val_3 = position;
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOMove(target:  701836048, endValue:  new UnityEngine.Vector3(), duration:  this.moveSpeed, snapping:  this.moveSpeed);
        DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetSpeedBased<DG.Tweening.Tweener>(t:  701836048, isSpeedBased:  true);
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  701836048, ease:  1);
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  R7, t:  701836048);
        val_9 = 6;
        label_3:
        if((val_9 - 4) < R7)
        {
            goto label_8;
        }
        
        DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  0, loops:  0, loopType:  this.moveType);
    }
    private void StartMoveIdle()
    {
        float val_13;
        var val_15;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = position;
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOMove(target:  702156944, endValue:  new UnityEngine.Vector3(), duration:  val_2.x, snapping:  false);
        DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
        this.mySequence = 0;
        val_15 = 5;
        goto label_6;
        label_11:
        UnityEngine.Transform val_5 = this.movePoints[0].transform;
        UnityEngine.Transform val_15 = this.movePoints[1];
        UnityEngine.Vector3 val_6 = position;
        val_13 = this.moveSpeed;
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOMove(target:  702156944, endValue:  new UnityEngine.Vector3(), duration:  val_13, snapping:  val_13);
        DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetSpeedBased<DG.Tweening.Tweener>(t:  702156944, isSpeedBased:  true);
        DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  702156944, ease:  1);
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  702156944);
        val_15 = 6;
        label_6:
        if((val_15 - 4) < 0)
        {
            goto label_11;
        }
        
        DG.Tweening.Tweener val_12 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  0, loops:  0, loopType:  this.moveType);
        DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions.DOTimeScale(target:  this.mySequence, endValue:  val_13, duration:  val_6.y);
    }
    public void Move()
    {
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions.DOTimeScale(target:  this.mySequence, endValue:  null, duration:  null);
    }
    public void Stop()
    {
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions.DOTimeScale(target:  this.mySequence, endValue:  null, duration:  null);
    }
    public SawModeRope()
    {
        this.rotateTarget = 360f;
        this.moveType = 1;
        this.canRotate = 1;
    }

}
