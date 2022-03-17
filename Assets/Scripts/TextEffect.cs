using UnityEngine;
public class TextEffect : MonoBehaviour
{
    // Fields
    private Spine.Unity.SkeletonAnimation animation;
    private string spawn;
    private string idle;
    private string disapear;
    private string[] winString;
    private UnityEngine.GameObject winFX;
    private float idleTime;
    private float delayTimeMin;
    private float delayTimeMax;
    private bool showOnStartGame;
    private bool useSFX;
    private bool firstTime;
    private System.Action eventCallBack;
    private bool isWin;
    
    // Methods
    private void Start()
    {
        Spine.AnimationState val_1 = this.animation.AnimationState;
        536897935 = new AnimationState.TrackEntryEventDelegate(object:  754348048, method:  new IntPtr(1610680825));
        this.animation.add_Event(value:  536897935);
        if(this.showOnStartGame != false)
        {
                System.Collections.IEnumerator val_3 = this.ShowEff();
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  754348048);
        }
        else
        {
                UnityEngine.GameObject val_5 = this.animation.gameObject;
            this.animation.SetActive(value:  false);
        }
        
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  754348048, method:  new IntPtr(1610680839));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  754348048, eventID:  34, callback:  536873423);
    }
    private void OnDisable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  754468240, method:  new IntPtr(1610680841));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  754468240, eventID:  34, callback:  536873423);
    }
    private void StopEffect()
    {
        this.isWin = true;
        if(this.showOnStartGame == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_1 = this.animation.gameObject;
        this.animation.SetActive(value:  false);
    }
    private void HandleAnimationStateEvent(Spine.TrackEntry trackEntry, Spine.Event e)
    {
        bool val_1 = System.String.op_Equality(a:  e.data.name, b:  -1610600473);
        if(val_1 == true)
        {
                val_1 = this.eventCallBack;
        }
        
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.Invoke();
    }
    public void ShowEffect()
    {
        var val_5;
        var val_6;
        if(this.winString != null)
        {
                val_5 = this.winString;
            val_6 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  0);
        }
        else
        {
                val_5 = 12;
            val_6 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  0);
        }
        
        536882991 = new System.Action(object:  754898448, method:  new IntPtr(1610680843));
        this.SetAnimationWithEvent(name:  this.winString[val_6], loop:  false, timeScale:  null, _callBackEv:  1065353216, _callBackCom:  536882991);
        UnityEngine.GameObject val_4 = this.animation.gameObject;
        this.animation.SetActive(value:  true);
    }
    private System.Collections.IEnumerator ShowEff()
    {
        536901821 = new TextEffect.<ShowEff>d__19(<>1__state:  0);
        mem[536901837] = this;
    }
    private System.Collections.IEnumerator IdleEff()
    {
        536901819 = new TextEffect.<IdleEff>d__20(<>1__state:  0);
        mem[536901835] = this;
    }
    public void SetAnimationWithEvent(string name, bool loop, float timeScale = 1, System.Action _callBackEv, System.Action _callBackCom)
    {
        var val_1;
        536901817 = new TextEffect.<>c__DisplayClass21_0();
        mem[536901825] = val_1;
        if(_callBackCom != 0)
        {
                this.eventCallBack = 0;
            mem[1152921509657114308] = _callBackCom;
        }
        
        Spine.Animation val_3 = _callBackCom.FindAnimation(animationName:  name);
        if(_callBackCom == 0)
        {
                return;
        }
        
        Spine.AnimationState val_4 = this.animation.AnimationState;
        Spine.TrackEntry val_5 = this.animation.SetAnimation(trackIndex:  0, animationName:  name, loop:  loop);
        mem2[0] = _callBackEv;
        if(mem[536901825] == 0)
        {
                return;
        }
        
        536897929 = new AnimationState.TrackEntryDelegate(object:  536901817, method:  new IntPtr(1610680875));
        this.animation.add_Complete(value:  536897929);
    }
    public void SetScale()
    {
        float val_8;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Transform val_2 = this.parent;
        if(755432464 == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_4 = this.transform;
        UnityEngine.Transform val_5 = this.transform;
        UnityEngine.Transform val_6 = this.parent;
        UnityEngine.Vector3 val_7 = localScale;
        this.localScale = new UnityEngine.Vector3() {x = val_8, y = 1f, z = 0f};
    }
    public TextEffect()
    {
        this.showOnStartGame = true;
        this.useSFX = true;
    }
    private void <Start>b__14_0(UnityEngine.Component sender, object param)
    {
        this.StopEffect();
    }
    private void <OnDisable>b__15_0(UnityEngine.Component sender, object param)
    {
        this.StopEffect();
    }
    private void <ShowEffect>b__18_0()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610603997, volume:  null);
        if(this.useSFX != false)
        {
                WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610604759, volume:  null);
        }
        
        UnityEngine.GameObject val_3 = this.winFX.gameObject;
        this.winFX.SetActive(value:  true);
    }
    private void <ShowEff>b__19_0()
    {
        System.Collections.IEnumerator val_1 = this.IdleEff();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  756041616);
        MixSkinManager.SetAnimation(ske:  this.animation, name:  this.idle, loop:  true, timeScale:  null, _callBack:  1065353216);
    }
    private void <IdleEff>b__20_0()
    {
        System.Collections.IEnumerator val_1 = this.ShowEff();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  756161808);
    }

}
