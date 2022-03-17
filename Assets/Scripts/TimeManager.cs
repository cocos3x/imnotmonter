using UnityEngine;
public class TimeManager : SingletonMonoBehaviour<TimeManager>
{
    // Fields
    private bool isPause;
    private float slowdownFactor;
    private float slowdownLength;
    
    // Methods
    private void OnEnable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  573720592, method:  new IntPtr(1610677945));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  573720592, eventID:  2, callback:  536873423);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  573720592, method:  new IntPtr(1610677947));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  573720592, eventID:  3, callback:  536873423);
    }
    private void OnDisable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  573832592, method:  new IntPtr(1610677949));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  573832592, eventID:  2, callback:  536873423);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  573832592, method:  new IntPtr(1610677951));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  573832592, eventID:  3, callback:  536873423);
    }
    private void Update()
    {
        if(this.isPause == true)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.timeScale;
        float val_2 = 1f / (R4 + 20);
        float val_3 = UnityEngine.Time.unscaledDeltaTime;
        UnityEngine.Time.timeScale = 0;
        UnityEngine.Time.timeScale = UnityEngine.Mathf.Clamp(value:  UnityEngine.Time.timeScale, min:  null, max:  0);
    }
    public void SetPause(bool value)
    {
        this.isPause = value;
    }
    public void DoSlomotion()
    {
        UnityEngine.Time.timeScale = null;
        float val_1 = UnityEngine.Time.timeScale;
        float val_2 = 0.02f;
        val_2 = 0 * val_2;
        UnityEngine.Time.fixedDeltaTime = val_2;
    }
    public void DoSlomotion(float slowdown)
    {
        UnityEngine.Time.timeScale = slowdown;
        float val_1 = UnityEngine.Time.timeScale;
        float val_2 = 0.02f;
        val_2 = 0 * val_2;
        UnityEngine.Time.fixedDeltaTime = val_2;
    }
    public void SetTimeScale(float value)
    {
        UnityEngine.Time.timeScale = value;
    }
    public void DoNormal()
    {
        UnityEngine.Time.timeScale = null;
    }
    public TimeManager()
    {
        this.slowdownFactor = 0.5f;
        this.slowdownLength = 1f;
    }
    private void <OnEnable>b__3_0(UnityEngine.Component o, object sender)
    {
        this.isPause = true;
    }
    private void <OnEnable>b__3_1(UnityEngine.Component o, object sender)
    {
        this.isPause = false;
    }
    private void <OnDisable>b__4_0(UnityEngine.Component o, object sender)
    {
        this.isPause = true;
    }
    private void <OnDisable>b__4_1(UnityEngine.Component o, object sender)
    {
        this.isPause = false;
    }

}
