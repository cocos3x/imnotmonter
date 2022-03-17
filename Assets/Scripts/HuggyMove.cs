using UnityEngine;
public class HuggyMove : MonoBehaviour
{
    // Fields
    private UnityEngine.Collider2D box;
    private bool isDead;
    private bool isMove;
    public SetAnimationPlayer setAnimation;
    private TypeRope typeRope;
    public int waypointindex;
    
    // Methods
    private void Start()
    {
        var val_1;
        this.box.enabled = false;
        val_1 = 536887951;
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_1 = 536887951;
        }
        
        this.setAnimation.SetAnimation(name:  mem[536888043] + 28, loop:  true, _callBack:  0);
        this.typeRope = 1;
    }
    private void OnEnable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  715963920, method:  new IntPtr(1610680265));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  715963920, eventID:  5, callback:  536873423);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  715963920, method:  new IntPtr(1610680267));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  715963920, eventID:  32, callback:  536873423);
    }
    private void OnDisable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  716075920, method:  new IntPtr(1610680269));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  716075920, eventID:  5, callback:  536873423);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  716075920, method:  new IntPtr(1610680271));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  716075920, eventID:  32, callback:  536873423);
    }
    public void MovePeople(System.Collections.Generic.List<UnityEngine.Vector3> waypoints)
    {
        var val_5;
        HuggyMove.<>c__DisplayClass9_0 val_1 = 536899337;
        val_1 = new HuggyMove.<>c__DisplayClass9_0();
        if(val_1 != 0)
        {
                mem[536899345] = this;
        }
        else
        {
                mem[8] = this;
        }
        
        mem[536899349] = waypoints;
        this.isMove = true;
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.Vibrate) != false)
        {
                MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  5, defaultToRegularVibrate:  false, alsoRumble:  false, coroutineSupport:  0, controllerID:  0);
        }
        
        val_5 = 536887951;
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_5 = 536887951;
        }
        
        536882991 = new System.Action(object:  536899337, method:  new IntPtr(1610680277));
        this.setAnimation.SetAnimation(name:  mem[536888043] + 36, loop:  false, _callBack:  536882991);
    }
    private void UpdateIndex(int index)
    {
        this.waypointindex = index;
    }
    private void GoHome()
    {
        float val_4;
        var val_9;
        var val_10;
        string val_11;
        var val_12;
        if(this.isDead == true)
        {
                return;
        }
        
        this.isMove = false;
        this.box.enabled = false;
        GameTool.EventDispatcherExtension.PostEvent(sender:  716448784, eventID:  25);
        UnityEngine.Transform val_1 = this.box.transform;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.Vector3 val_3 = PosHuggy;
        this.position = new UnityEngine.Vector3() {x = R6, y = R7, z = val_4};
        UnityEngine.Transform val_5 = this.transform;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        this.localScale = new UnityEngine.Vector3() {x = R6, y = R7, z = R8};
        this.setAnimation.SetScale();
        this.setAnimation.SetPosPlayerSwing(isSwing:  false);
        val_9 = 536887951;
        var val_8 = mem[536888137];
        val_8 = val_8 & 512;
        if(this.typeRope != 0)
        {
                if((val_8 != 0) && (mem[536888067] == 0))
        {
                val_10 = 536887951;
        }
        
            val_11 = mem[536888043] + 12;
        }
        else
        {
                if((val_8 != 0) && (mem[536888067] == 0))
        {
                val_12 = 536887951;
        }
        
            val_11 = mem[536888043];
        }
        
        536882991 = new System.Action(object:  716448784, method:  new IntPtr(1610680273));
        this.setAnimation.SetAnimation(name:  val_11, loop:  false, _callBack:  536882991);
        GameTool.EventDispatcherExtension.PostEvent(sender:  716448784, eventID:  4);
    }
    private void SetAnimHug()
    {
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                536887951 = 536887951;
        }
        
        this.setAnimation.SetAnimation(name:  mem[536888043] + 32, loop:  false, _callBack:  0);
    }
    private void ChangePosHuggy()
    {
        this.setAnimation.SetPosPlayerSwing(isSwing:  false);
    }
    public void SetAnimIdle()
    {
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                536887951 = 536887951;
        }
        
        this.setAnimation.SetAnimation(name:  mem[536888043] + 40, loop:  true, _callBack:  0);
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if((collision.CompareTag(tag:  -1610608497)) == false)
        {
                return;
        }
        
        this.Dead();
    }
    public void Dead()
    {
        float val_10;
        float val_11;
        float val_12;
        if(this.isDead == true)
        {
                return;
        }
        
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610608733, volume:  null);
        this.isDead = true;
        this.box.enabled = false;
        UnityEngine.Transform val_2 = this.box.transform;
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.GameObject val_4 = -1073700933.gameObject;
        UnityEngine.Transform val_5 = -1073700933.transform;
        this.SetParent(p:  -1073700933);
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.Transform val_8 = this.transform;
        UnityEngine.Vector3 val_9 = position;
        UnityEngine.GameObject val_13 = -1073701087.GetItem(key:  -1610602869, position:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12});
        -1073701087.Despaw(go:  -1073701087, delay:  val_9.x);
        UnityEngine.Transform val_14 = this.transform;
        int val_15 = DG.Tweening.DOTween.Kill(targetOrId:  717070224, complete:  false);
        this.setAnimation.HideSkeleton();
        GameTool.EventDispatcherExtension.PostEvent(sender:  717070224, eventID:  5);
    }
    private void DeadSFX()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610608733, volume:  null);
    }
    public void ChangeLayerShowInUI()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if(mem[3221266280] == true)
        {
                return;
        }
        
        R4 + 20.ChangeLayerShowInUI();
    }
    public HuggyMove()
    {
    
    }
    private void <OnEnable>b__7_0(UnityEngine.Component Comparer, object param)
    {
        if(this.isMove == false)
        {
                return;
        }
        
        this.Dead();
    }
    private void <OnEnable>b__7_1(UnityEngine.Component com, object obj)
    {
        this.ChangeLayerShowInUI();
    }
    private void <OnDisable>b__8_0(UnityEngine.Component Comparer, object param)
    {
        if(this.isMove == false)
        {
                return;
        }
        
        this.Dead();
    }
    private void <OnDisable>b__8_1(UnityEngine.Component com, object obj)
    {
        this.ChangeLayerShowInUI();
    }
    private void <GoHome>b__11_0()
    {
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                536887951 = 536887951;
        }
        
        this.setAnimation.SetAnimation(name:  mem[536888043] + 40, loop:  true, _callBack:  0);
        this.Invoke(methodName:  -1610604651, time:  null);
        UnityEngine.Transform val_1 = this.transform;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.GameObject val_3 = -1073700933.gameObject;
        UnityEngine.Transform val_4 = -1073700933.transform;
        this.SetParent(p:  -1073700933);
    }

}
