using UnityEngine;
public class PlayerController : SingletonMonoBehaviour<PlayerController>
{
    // Fields
    private Spine.Unity.SkeletonAnimation skeleton;
    private UnityEngine.MeshRenderer[] meshHands;
    private UnityEngine.MeshRenderer[] meshs;
    private UnityEngine.SpriteRenderer spriteRendererHandRed;
    private TextEffect textEff;
    private HandTarget handRed;
    private HandTarget handBlue;
    
    // Properties
    public UnityEngine.Vector3 PosHuggy { get; }
    
    // Methods
    public UnityEngine.Vector3 get_PosHuggy()
    {
        float val_3;
        PlayerController val_4;
        var val_5;
        UnityEngine.Transform val_1 = R1 + 12.transform;
        UnityEngine.Vector3 val_2 = position;
        float val_8 = 0f;
        float val_6 = val_3;
        PlayerController val_7 = val_4;
        val_6 = val_6 + val_8;
        val_7 = val_7 + 0.7f;
        val_8 = val_5 + val_8;
        this = val_7;
        mem[1152921509626388244] = val_6;
        mem[1152921509626388248] = val_8;
        return new UnityEngine.Vector3() {x = val_8, y = val_2.y, z = val_7};
    }
    private void Start()
    {
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                536884781 = 536884781;
        }
        
        this.SetAnimation(name:  mem[536884873], loop:  true, _callBack:  0);
    }
    private void OnEnable()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  -1610604627);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  724797968, method:  new IntPtr(1610680365));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  724797968, eventID:  32, callback:  536873423);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  724797968, method:  new IntPtr(1610680367));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  724797968, eventID:  10, callback:  536873423);
    }
    private void OnDisable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  724909968, method:  new IntPtr(1610680369));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  724909968, eventID:  32, callback:  536873423);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  724909968, method:  new IntPtr(1610680371));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  724909968, eventID:  10, callback:  536873423);
    }
    public void SetAimLose()
    {
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                536884781 = 536884781;
        }
        
        536882991 = new System.Action(object:  725021968, method:  new IntPtr(1610680373));
        this.SetAnimation(name:  mem[536884873] + 12 + 20, loop:  false, _callBack:  536882991);
    }
    public void SetAnimWin(System.Action _callBack)
    {
        var val_11;
        string val_12;
        System.Action val_13;
        var val_14;
        var val_15;
        PlayerController.<>c__DisplayClass13_0 val_1 = 536900315;
        val_1 = new PlayerController.<>c__DisplayClass13_0();
        if(val_1 != 0)
        {
                mem[536900323] = this;
        }
        else
        {
                mem[8] = this;
        }
        
        mem[536900327] = _callBack;
        this.textEff.ShowEffect();
        this.handRed.HideLine(hideHand:  true);
        this.handBlue.HideLine(hideHand:  true);
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_3 = -1073708883.CurrentLevelRope;
        val_3 = val_3 - 0;
        if(val_3 == 0)
        {
            goto label_7;
        }
        
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_5 = -1073708883.CurrentLevel;
        val_5 = val_5 + 1;
        val_5 = val_5 - 0;
        if(val_5 == 0)
        {
            goto label_9;
        }
        
        label_14:
        val_11 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_11 = 536884781;
        }
        
        string val_6 = Berry.Utils.Utils.GetRandom<System.String>(collection:  mem[536884873] + 20);
        val_12 = mem[536884873] + 20;
        val_13 = 536882991;
        val_14 = 22773564;
        goto label_12;
        label_9:
        object val_7 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CurrentLevel) < 1)
        {
            goto label_14;
        }
        
        label_7:
        val_15 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_15 = 536884781;
        }
        
        string val_9 = Berry.Utils.Utils.GetRandom<System.String>(collection:  mem[536884873] + 20);
        val_12 = mem[536884873] + 20;
        val_13 = 536882991;
        val_14 = 22773560;
        label_12:
        val_13 = new System.Action(object:  536900315, method:  new IntPtr(1610680379));
        this.SetAnimation(name:  val_12, loop:  false, _callBack:  536882991);
    }
    private void SetOrderLayerHand()
    {
        var val_2;
        this.spriteRendererHandRed.sortingLayerName = -1610609369;
        this.spriteRendererHandRed.sortingOrder = 12;
        val_2 = 4;
        goto label_3;
        label_11:
        this.meshHands[0].sortingLayerName = -1610609369;
        UnityEngine.MeshRenderer val_4 = this.meshHands[0];
        val_4.sortingOrder = R6 + 11;
        val_2 = 5;
        label_3:
        if((val_2 - 4) < val_4)
        {
            goto label_11;
        }
    
    }
    private void SetAnimation(string name, bool loop, System.Action _callBack)
    {
        536900317 = new PlayerController.<>c__DisplayClass15_0();
        mem[536900325] = _callBack;
        bool val_2 = UnityEngine.Object.op_Implicit(exists:  this.skeleton);
        if(val_2 != false)
        {
                string val_3 = val_2.GetLinkAnim(nameAnim:  name);
            Spine.TrackEntry val_4 = this.skeleton.state.SetAnimation(trackIndex:  0, animationName:  val_2, loop:  loop);
            this.skeleton.timeScale = 1f;
            if(mem[536900325] == 0)
        {
                return;
        }
        
            536897929 = new AnimationState.TrackEntryDelegate(object:  536900317, method:  new IntPtr(1610680385));
            this.skeleton.state.add_Complete(value:  536897929);
            return;
        }
        
        string val_6 = val_2.GetLinkAnim(nameAnim:  name);
        System.Collections.IEnumerator val_7 = this.WaitSkeleton(name:  val_2, loop:  loop, _callBack:  mem[536900325]);
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  725669264);
    }
    private System.Collections.IEnumerator WaitSkeleton(string name, bool loop, System.Action _callBack)
    {
        PlayerController.<WaitSkeleton>d__16 val_1 = 536900329;
        val_1 = new PlayerController.<WaitSkeleton>d__16(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536900345] = this;
            mem[536900353] = name;
            mem[536900357] = loop;
        }
        else
        {
                mem[16] = this;
            mem[24] = name;
            mem[28] = loop;
        }
        
        mem[536900349] = _callBack;
    }
    private System.Collections.IEnumerator SetSkin()
    {
        536900327 = new PlayerController.<SetSkin>d__17(<>1__state:  0);
        mem[536900343] = this;
    }
    private string GetLinkAnim(string nameAnim)
    {
        if((mem[536884968] & true) != 0)
        {
                return mem[536884873] + 24(mem[536884873] + 24) + nameAnim;
        }
        
        if(mem[536884897] != 0)
        {
                return mem[536884873] + 24(mem[536884873] + 24) + nameAnim;
        }
        
        536884781 = 536884781;
        return mem[536884873] + 24(mem[536884873] + 24) + nameAnim;
    }
    public void ChangeLayerShowInUI()
    {
        var val_4;
        var val_5;
        var val_6;
        this.spriteRendererHandRed.sortingLayerName = -1610603225;
        this.spriteRendererHandRed.sortingOrder = 9;
        val_4 = 4;
        goto label_3;
        label_18:
        if(this.meshs[0] != 0)
        {
                this.meshs[0].sortingLayerName = -1610603225;
            UnityEngine.MeshRenderer val_8 = this.meshs[0];
            if(val_4 == 4)
        {
                val_5 = 1;
        }
        else
        {
                val_5 = 3;
        }
        
            val_8.sortingOrder = 3;
        }
        
        val_4 = 5;
        label_3:
        if((val_4 - 4) < val_8)
        {
            goto label_18;
        }
        
        val_6 = 4;
        goto label_19;
        label_32:
        if(this.meshHands[0] != 0)
        {
                this.meshHands[0].sortingLayerName = -1610603225;
            UnityEngine.MeshRenderer val_11 = this.meshHands[0];
            val_11.sortingOrder = 6;
        }
        
        val_6 = 5;
        label_19:
        if((val_6 - 4) < val_11)
        {
            goto label_32;
        }
        
        UnityEngine.Coroutine val_5 = this.StartCoroutine(methodName:  -1610608781);
    }
    private System.Collections.IEnumerator DelayShowAnimWin()
    {
        536900325 = new PlayerController.<DelayShowAnimWin>d__20(<>1__state:  0);
        mem[536900341] = this;
    }
    public void SetTriggerDamePlayer(UnityEngine.Collider2D other)
    {
        if((other.CompareTag(tag:  -1610608497)) == false)
        {
                return;
        }
        
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701029.LevelFailed();
    }
    public void MoveToPos(UnityEngine.Vector3 posMove, float timeMove, System.Action onCompleted)
    {
        var val_1;
        var val_9;
        PlayerController.<>c__DisplayClass22_0 val_2 = 536900323;
        val_2 = new PlayerController.<>c__DisplayClass22_0();
        if(val_2 != 0)
        {
                mem[536900331] = this;
        }
        else
        {
                mem[8] = this;
        }
        
        mem[536900335] = val_1;
        this.handRed.SetStopTargetHand(value:  true);
        this.handBlue.SetStopTargetHand(value:  true);
        this.handRed.SetRenderLine(value:  true);
        this.handBlue.SetRenderLine(value:  true);
        val_9 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_9 = 536884781;
        }
        
        this.SetAnimation(name:  mem[536884873] + 8, loop:  true, _callBack:  0);
        UnityEngine.Transform val_3 = this.transform;
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOMove(target:  727186448, endValue:  new UnityEngine.Vector3() {x = posMove.x, y = posMove.y, z = posMove.z}, duration:  timeMove, snapping:  onCompleted);
        DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetSpeedBased<DG.Tweening.Tweener>(t:  727186448);
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  727186448, ease:  1);
        536895905 = new DG.Tweening.TweenCallback(object:  536900323, method:  new IntPtr(1610680431));
        DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  727186448, action:  536895905);
    }
    public void FixPos()
    {
        float val_4;
        var val_7;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Vector3 val_3 = position;
        UnityEngine.Transform val_5 = this.transform;
        UnityEngine.Vector3 val_6 = position;
        float val_8 = -0.4f;
        val_8 = val_7 + val_8;
        this.position = new UnityEngine.Vector3() {x = val_4, y = val_8, z = 0f};
        this.enabled = false;
    }
    public PlayerController()
    {
    
    }
    private void <OnEnable>b__10_0(UnityEngine.Component com, object obj)
    {
        this.ChangeLayerShowInUI();
    }
    private void <OnEnable>b__10_1(UnityEngine.Component com, object obj)
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  -1610604627);
    }
    private void <OnDisable>b__11_0(UnityEngine.Component com, object obj)
    {
        this.ChangeLayerShowInUI();
    }
    private void <OnDisable>b__11_1(UnityEngine.Component com, object obj)
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  -1610604627);
    }
    private void <SetAimLose>b__12_0()
    {
        var val_2;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610608999, volume:  null);
        val_2 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_2 = 536884781;
        }
        
        this.SetAnimation(name:  mem[536884873] + 16 + 20, loop:  true, _callBack:  0);
    }
    private bool <SetSkin>b__17_0()
    {
        if((mem[536891408] & true) != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.skeleton);
        }
        
        if(mem[536891337] != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.skeleton);
        }
        
        return UnityEngine.Object.op_Implicit(exists:  this.skeleton);
    }

}
