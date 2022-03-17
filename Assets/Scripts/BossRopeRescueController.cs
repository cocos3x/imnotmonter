using UnityEngine;
public class BossRopeRescueController : MonoBehaviour
{
    // Fields
    private Spine.Unity.SkeletonAnimation skeletonBoss;
    private UnityEngine.GameObject cavansHeath;
    private UnityEngine.GameObject chestWin;
    private UnityEngine.RectTransform lineHeath;
    private float maxLineHeath;
    private Spine.Unity.SkeletonAnimation skeletonTextHit;
    private Spine.Unity.SkeletonAnimation skeletonText;
    private int <heathBoss>k__BackingField;
    private bool showLose;
    
    // Properties
    public int heathBoss { get; set; }
    
    // Methods
    public int get_heathBoss()
    {
        return (int)this.<heathBoss>k__BackingField;
    }
    private void set_heathBoss(int value)
    {
        this.<heathBoss>k__BackingField = value;
    }
    private System.Collections.IEnumerator Start()
    {
        536898145 = new BossRopeRescueController.<Start>d__12(<>1__state:  0);
        mem[536898161] = this;
    }
    public void SetTriggerDameBoss(UnityEngine.Collider2D other)
    {
        var val_11 = 22999050;
        if((other.CompareTag(tag:  -1610608497)) != true)
        {
                if((other.CompareTag(tag:  -1610607725)) != true)
        {
                if((other.CompareTag(tag:  -1610599497)) == false)
        {
                return;
        }
        
        }
        
        }
        
        val_11 = 22786892;
        if((other.CompareTag(tag:  -1610607725)) != false)
        {
                string val_5 = other.name;
            if((System.String.op_Equality(a:  other, b:  -1610604753)) == true)
        {
                return;
        }
        
        }
        
        this.SetDesplayHeath(valueHeath:  1);
        if((other.CompareTag(tag:  -1610607725)) == false)
        {
                return;
        }
        
        val_11 = 22755292;
        UnityEngine.Transform val_8 = other.GetComponent<UnityEngine.Transform>();
        if(other == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_10 = other.GetComponent<UnityEngine.Transform>();
        other.DestroyItem();
    }
    public void SetAnimBoss(string name, bool loop, System.Action _callBack)
    {
        536898137 = new BossRopeRescueController.<>c__DisplayClass14_0();
        mem[536898145] = _callBack;
        Spine.AnimationState val_2 = this.skeletonBoss.AnimationState;
        Spine.TrackEntry val_3 = this.skeletonBoss.SetAnimation(trackIndex:  0, animationName:  name, loop:  loop);
        536897929 = new AnimationState.TrackEntryDelegate(object:  536898137, method:  new IntPtr(1610680179));
        this.skeletonBoss.add_Complete(value:  536897929);
    }
    private void NextMap()
    {
        if(((mem[536884460] & true) == 0) && (mem[536884389] == 0))
        {
                536884273 = 536884273;
        }
        
        this.SetAnimBoss(name:  mem[536884365] + 8, loop:  true, _callBack:  0);
        this.Invoke(methodName:  -1610608791, time:  null);
    }
    private void DelayMove()
    {
        GameTool.EventDispatcherExtension.PostEvent(sender:  712265360, eventID:  35);
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701005.MoveMap(indexMap:  (-1073701005.TotalHeathBoss) - (this.<heathBoss>k__BackingField));
    }
    private void CompletedLevel()
    {
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Transform val_2 = this.GetChild(index:  1);
        UnityEngine.GameObject val_3 = this.gameObject;
        this.SetActive(value:  false);
        GameTool.EventDispatcherExtension.PostEvent(sender:  712377360, eventID:  4);
    }
    public void SetDesplayHeath(int valueHeath)
    {
        float val_5;
        UnityEngine.RectTransform val_15;
        var val_16;
        var val_17;
        string val_18;
        System.Action val_19;
        var val_20;
        var val_21;
        val_15 = valueHeath;
        this.showLose = false;
        if((this.<heathBoss>k__BackingField) < 1)
        {
                return;
        }
        
        this.StopCoroutine(methodName:  -1610608783);
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  -1610604567);
        GameTool.EventDispatcherExtension.PostEvent(sender:  712509840, eventID:  25, param:  536884213);
        this.cavansHeath.SetActive(value:  true);
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.Vector2 val_4 = sizeDelta;
        float val_15 = (float)-1073701005.TotalHeathBoss;
        val_15 = ((float)this.<heathBoss>k__BackingField) / val_15;
        val_15 = this.maxLineHeath * val_15;
        this.lineHeath.sizeDelta = new UnityEngine.Vector2() {x = val_15, y = val_5};
        int val_16 = this.<heathBoss>k__BackingField;
        val_16 = val_16 - val_15;
        this.<heathBoss>k__BackingField = val_16;
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610609905, volume:  val_15);
            val_16 = 536884273;
            var val_17 = mem[536884459];
            val_17 = val_17 & 512;
            if((this.<heathBoss>k__BackingField) >= 1)
        {
                if((val_17 != 0) && (mem[536884389] == 0))
        {
                val_17 = 536884273;
        }
        
            val_18 = mem[mem[536884365] + 4];
            val_18 = mem[536884365] + 4;
            val_19 = 536882991;
            val_20 = 22754468;
        }
        else
        {
                if((val_17 != 0) && (mem[536884389] == 0))
        {
                val_21 = 536884273;
        }
        
            val_18 = mem[mem[536884365] + 4];
            val_18 = mem[536884365] + 4;
            val_19 = 536882991;
            val_20 = 22754472;
        }
        
            val_19 = new System.Action(object:  712509840, method:  new IntPtr(1610680151));
            this.SetAnimBoss(name:  val_18, loop:  false, _callBack:  536882991);
        }
        
        val_15 = this.lineHeath;
        WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.Vector2 val_11 = sizeDelta;
        float val_18 = (float)-1073701005.TotalHeathBoss;
        val_18 = ((float)this.<heathBoss>k__BackingField) / val_18;
        val_18 = this.maxLineHeath * val_18;
        DG.Tweening.Tweener val_12 = DG.Tweening.DOTweenModuleUI.DOSizeDelta(target:  val_15, endValue:  new UnityEngine.Vector2() {x = val_18, y = val_5}, duration:  val_18, snapping:  false);
        536895905 = new DG.Tweening.TweenCallback(object:  712509840, method:  new IntPtr(1610680153));
        DG.Tweening.Tweener val_14 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  val_15, action:  536895905);
    }
    public void MoveToPos(UnityEngine.Vector3 posMove)
    {
        float val_4;
        float val_7;
        float val_10;
        if(((mem[536884460] & true) == 0) && (mem[536884389] == 0))
        {
                536884273 = 536884273;
        }
        
        this.SetAnimBoss(name:  mem[536884365] + 8, loop:  true, _callBack:  0);
        UnityEngine.Transform val_1 = this.skeletonBoss.transform;
        UnityEngine.Transform val_2 = this.skeletonBoss.transform;
        UnityEngine.Vector3 val_3 = localScale;
        UnityEngine.Transform val_5 = this.skeletonBoss.transform;
        UnityEngine.Vector3 val_6 = localScale;
        UnityEngine.Transform val_8 = this.skeletonBoss.transform;
        UnityEngine.Vector3 val_9 = localScale;
        this.skeletonBoss.localScale = new UnityEngine.Vector3() {x = val_4 ^ 2147483648, y = val_7, z = val_10};
        this.SetAnimBoss(name:  mem[536884365] + 16, loop:  true, _callBack:  0);
        UnityEngine.Transform val_12 = this.transform;
        DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions.DOMoveX(target:  712658704, endValue:  val_9.x, duration:  val_9.y, snapping:  posMove.x);
        DG.Tweening.Tweener val_14 = DG.Tweening.TweenSettingsExtensions.SetSpeedBased<DG.Tweening.Tweener>(t:  712658704);
        536895905 = new DG.Tweening.TweenCallback(object:  712658704, method:  new IntPtr(1610680155));
        DG.Tweening.Tweener val_16 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  712658704, action:  536895905);
        val_7 = posMove.y;
        val_4 = posMove.x;
        val_10 = posMove.z;
        UnityEngine.Coroutine val_17 = this.StartCoroutine(methodName:  -1610604029, value:  536896653);
    }
    private System.Collections.IEnumerator TeleInPos(UnityEngine.Vector3 posMove)
    {
        BossRopeRescueController.<TeleInPos>d__20 val_1 = 536898147;
        val_1 = new BossRopeRescueController.<TeleInPos>d__20(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536898163] = this;
        }
        else
        {
                mem[16] = this;
        }
        
        mem[536898167] = posMove.x;
        mem[536898171] = posMove.y;
        mem[536898175] = posMove.z;
    }
    private System.Collections.IEnumerator ShowTextHit()
    {
        536898143 = new BossRopeRescueController.<ShowTextHit>d__21(<>1__state:  0);
        mem[536898159] = this;
    }
    private void ShowText(bool loser)
    {
        var val_9;
        AnimationState.TrackEntryDelegate val_10;
        var val_11;
        if(loser != false)
        {
                Spine.AnimationState val_1 = this.skeletonText.AnimationState;
            Spine.TrackEntry val_2 = this.skeletonText.SetAnimation(trackIndex:  0, animationName:  -1610599363, loop:  false);
            val_9 = this.skeletonText;
            val_10 = 536897929;
            val_11 = 22754480;
        }
        else
        {
                object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
            Spine.AnimationState val_5 = this.skeletonText.AnimationState;
            if((-1073708883.CurrentLevelRope) >= 50)
        {
                Spine.TrackEntry val_6 = this.skeletonText.SetAnimation(trackIndex:  0, animationName:  -1610600261, loop:  false);
            val_9 = this.skeletonText;
            val_10 = 536897929;
            val_11 = 22754484;
        }
        else
        {
                Spine.TrackEntry val_7 = this.skeletonText.SetAnimation(trackIndex:  0, animationName:  -1610600283, loop:  false);
            val_9 = this.skeletonText;
            val_10 = 536897929;
            val_11 = 22754488;
        }
        
        }
        
        val_10 = new AnimationState.TrackEntryDelegate(object:  713019280, method:  new IntPtr(1610680161));
        val_9.add_Complete(value:  536897929);
    }
    private System.Collections.IEnumerator DelayShowAnimLoser(float time)
    {
        BossRopeRescueController.<DelayShowAnimLoser>d__23 val_1 = 536898139;
        val_1 = new BossRopeRescueController.<DelayShowAnimLoser>d__23(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536898159] = this;
        }
        else
        {
                mem[20] = this;
        }
        
        mem[536898155] = R1;
    }
    public void DelayShowLosePlayer(float timeDelay)
    {
        if(this.showLose == true)
        {
                return;
        }
        
        this.showLose = true;
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  -1610608779, value:  536893745);
    }
    private System.Collections.IEnumerator DelayShowLose(float timeDelay)
    {
        BossRopeRescueController.<DelayShowLose>d__25 val_1 = 536898141;
        val_1 = new BossRopeRescueController.<DelayShowLose>d__25(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536898161] = this;
        }
        else
        {
                mem[20] = this;
        }
        
        mem[536898157] = R1;
    }
    public BossRopeRescueController()
    {
        this.maxLineHeath = 1.72f;
    }
    private void <Start>b__12_0()
    {
        if(((mem[536884460] & true) == 0) && (mem[536884389] == 0))
        {
                536884273 = 536884273;
        }
        
        this.SetAnimBoss(name:  mem[536884365] + 8, loop:  true, _callBack:  0);
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  -1610608783, value:  536893745);
    }
    private void <SetDesplayHeath>b__18_0()
    {
        if(((mem[536884460] & true) == 0) && (mem[536884389] == 0))
        {
                536884273 = 536884273;
        }
        
        this.SetAnimBoss(name:  mem[536884365] + 8, loop:  true, _callBack:  0);
    }
    private void <SetDesplayHeath>b__18_1()
    {
        var val_2;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609917, volume:  null);
        val_2 = 536884273;
        if(((mem[536884460] & true) == 0) && (mem[536884389] == 0))
        {
                val_2 = 536884273;
        }
        
        this.SetAnimBoss(name:  mem[536884365], loop:  false, _callBack:  0);
    }
    private void <SetDesplayHeath>b__18_2()
    {
        this.StopCoroutine(methodName:  -1610608779);
        if((this.<heathBoss>k__BackingField) >= 1)
        {
                this.Invoke(methodName:  -1610606109, time:  null);
            return;
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701045.ShowTextBossDefeat(time:  null);
        }
        
        this.Invoke(methodName:  -1610609247, time:  null);
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.LevelRopeUnlocked) >= (-1073708883.CurrentLevelRope))
        {
                return;
        }
        
        UnityEngine.GameObject val_7 = this.chestWin.gameObject;
        this.chestWin.SetActive(value:  true);
        mem2[0] = 1;
    }
    private void <MoveToPos>b__19_0()
    {
        var val_4;
        float val_7;
        float val_10;
        var val_12;
        UnityEngine.Transform val_1 = this.skeletonBoss.transform;
        UnityEngine.Transform val_2 = this.skeletonBoss.transform;
        UnityEngine.Vector3 val_3 = localScale;
        UnityEngine.Transform val_5 = this.skeletonBoss.transform;
        UnityEngine.Vector3 val_6 = localScale;
        UnityEngine.Transform val_8 = this.skeletonBoss.transform;
        UnityEngine.Vector3 val_9 = localScale;
        this.skeletonBoss.localScale = new UnityEngine.Vector3() {x = val_4 ^ 2147483648, y = val_7, z = val_10};
        val_12 = 536884273;
        if(((mem[536884460] & true) == 0) && (mem[536884389] == 0))
        {
                val_12 = 536884273;
        }
        
        this.SetAnimBoss(name:  mem[536884365] + 8, loop:  true, _callBack:  0);
    }
    private void <ShowText>b__22_0(Spine.TrackEntry e)
    {
        Spine.AnimationState val_1 = this.skeletonText.AnimationState;
        Spine.TrackEntry val_2 = this.skeletonText.SetAnimation(trackIndex:  0, animationName:  -1610600013, loop:  true);
    }
    private void <ShowText>b__22_1(Spine.TrackEntry e)
    {
        Spine.AnimationState val_1 = this.skeletonText.AnimationState;
        Spine.TrackEntry val_2 = this.skeletonText.SetAnimation(trackIndex:  0, animationName:  -1610600013, loop:  true);
    }
    private void <ShowText>b__22_2(Spine.TrackEntry e)
    {
        Spine.AnimationState val_1 = this.skeletonText.AnimationState;
        Spine.TrackEntry val_2 = this.skeletonText.SetAnimation(trackIndex:  0, animationName:  -1610600013, loop:  true);
    }
    private void <DelayShowAnimLoser>b__23_0()
    {
        if(((mem[536884460] & true) == 0) && (mem[536884389] == 0))
        {
                536884273 = 536884273;
        }
        
        this.SetAnimBoss(name:  mem[536884365] + 8, loop:  true, _callBack:  0);
        float val_1 = UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(methodName:  -1610608783, value:  536893745);
    }

}
