using UnityEngine;
public class CameraCutRopeController : SingletonMonoBehaviour<CameraCutRopeController>
{
    // Fields
    private UnityEngine.Camera mainCam;
    private float originalSizeCam;
    
    // Methods
    private void Start()
    {
        float val_1 = this.mainCam.orthographicSize;
        this.originalSizeCam = this.mainCam;
    }
    public void MoveToCharacter(bool isWin)
    {
        float val_2;
        var val_3;
        UnityEngine.Object val_35;
        float val_37;
        var val_38;
        UnityEngine.Object val_39;
        var val_40;
        val_35 = isWin;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_37 = val_2;
        val_38 = val_3;
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_39 = mem[3221266327];
        var val_35 = mem[536891407];
        val_35 = val_35 & 512;
        if(val_35 == false)
        {
            goto label_2;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_39)) == false)
        {
            goto label_9;
        }
        
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  mem[3221266339])) == false)
        {
            goto label_9;
        }
        
        WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.Transform val_9 = mem[3221266327].transform;
        UnityEngine.Vector3 val_10 = position;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
        UnityEngine.Bounds val_12 = new UnityEngine.Bounds(center:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7}, size:  new UnityEngine.Vector3());
        WorldTimeAPI val_13 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.Transform val_14 = mem[3221266339].transform;
        UnityEngine.Vector3 val_15 = position;
        val_12.m_Center.x.Encapsulate(point:  new UnityEngine.Vector3());
        UnityEngine.Vector3 val_16 = center;
        goto label_16;
        label_2:
        if((UnityEngine.Object.op_Implicit(exists:  val_39)) == false)
        {
            goto label_32;
        }
        
        WorldTimeAPI val_18 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_40 = mem[3221266327];
        goto label_21;
        label_9:
        WorldTimeAPI val_19 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  mem[3221266327])) != false)
        {
                WorldTimeAPI val_21 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            UnityEngine.Transform val_22 = mem[3221266327].transform;
            UnityEngine.Vector3 val_23 = position;
            val_37 = val_2;
            val_38 = val_3;
        }
        
        WorldTimeAPI val_24 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_35 = mem[3221266339];
        if((UnityEngine.Object.op_Implicit(exists:  val_35)) == false)
        {
            goto label_32;
        }
        
        WorldTimeAPI val_26 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_40 = mem[3221266339];
        label_21:
        UnityEngine.Transform val_27 = val_40.transform;
        UnityEngine.Vector3 val_28 = position;
        label_16:
        val_37 = val_2;
        val_38 = val_3;
        label_32:
        this.ResetPosCamera();
        UnityEngine.Transform val_30 = this.transform;
        DG.Tweening.Tweener val_31 = DG.Tweening.ShortcutExtensions.DOMove(target:  590611472, endValue:  new UnityEngine.Vector3() {x = val_37, y = val_38 + 0.5f, z = -10f}, duration:  0.5f, snapping:  false);
        DG.Tweening.Tweener val_32 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  590611472, ease:  4);
        DG.Tweening.Tweener val_33 = DG.Tweening.ShortcutExtensions.DOOrthoSize(target:  this.mainCam, endValue:  0.5f, duration:  val_28.y);
        DG.Tweening.Tweener val_34 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.mainCam, ease:  4);
    }
    public void ResetPosCamera()
    {
        UnityEngine.Transform val_1 = this.transform;
        int val_2 = DG.Tweening.ShortcutExtensions.DOKill(target:  590735760, complete:  false);
        int val_3 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.mainCam, complete:  false);
        UnityEngine.Transform val_4 = this.transform;
        this.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = -10f};
        this.mainCam.orthographicSize = null;
    }
    public CameraCutRopeController()
    {
    
    }

}
