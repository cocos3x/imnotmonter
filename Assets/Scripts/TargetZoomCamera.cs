using UnityEngine;
public class TargetZoomCamera : SingletonMonoBehaviour<TargetZoomCamera>
{
    // Fields
    private UnityEngine.Camera _cam;
    private UnityEngine.Transform target;
    public float targetSizeCam;
    public float timeZoom;
    
    // Methods
    public override void Awake()
    {
        UnityEngine.Camera val_1 = UnityEngine.Camera.main;
        this._cam = 0;
        this.Awake();
    }
    private void Start()
    {
    
    }
    private void OnEnable()
    {
    
    }
    private void OnDisable()
    {
    
    }
    private void ResetPositonCam()
    {
        UnityEngine.Transform val_1 = this._cam.transform;
        this._cam.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = -10f};
    }
    public void ZoomCamera()
    {
        float val_4;
        var val_6;
        float val_8 = 0.5f;
        val_8 = this.timeZoom * val_8;
        this.Invoke(methodName:  -1610607735, time:  val_8);
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions.DOOrthoSize(target:  this._cam, endValue:  val_8, duration:  null);
        UnityEngine.Transform val_2 = this._cam.transform;
        UnityEngine.Vector3 val_3 = position;
        UnityEngine.Vector3 val_5 = position;
        float val_9 = -0.3f;
        val_9 = val_6 + val_9;
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOMove(target:  this._cam, endValue:  new UnityEngine.Vector3() {x = val_4, y = val_9, z = -20f}, duration:  this.timeZoom, snapping:  this.timeZoom);
    }
    private void HideItem()
    {
    
    }
    public float GetXDistance()
    {
        var val_3;
        UnityEngine.Transform val_1 = this._cam.transform;
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Vector3 val_4 = position;
        var val_5 = val_3;
        val_5 = val_3 - val_5;
        return (float)val_5;
    }
    public float GetYDistance()
    {
        var val_3;
        UnityEngine.Transform val_1 = this._cam.transform;
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Vector3 val_4 = position;
        var val_5 = val_3;
        val_5 = val_3 - val_5;
        return (float)val_5;
    }
    public TargetZoomCamera()
    {
    
    }

}
