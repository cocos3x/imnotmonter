using UnityEngine;
public class LoadLevelRopeManager : SingletonMonoBehaviour<LoadLevelRopeManager>
{
    // Fields
    private UnityEngine.Camera cameraMain;
    public bool canReSpawnGameMenu;
    private CanvasFollowDevice canvasFollowDevice;
    private string CommonLinkLevel;
    private string CommonLinkLevelBoss;
    public bool isPlaying;
    private string linkLevel;
    private UnityEngine.GameObject ObjLevel;
    
    // Properties
    public UnityEngine.Transform transLevel { get; }
    
    // Methods
    public UnityEngine.Transform get_transLevel()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.ObjLevel)) == false)
        {
                return;
        }
        
        if(this.ObjLevel != 0)
        {
                return this.ObjLevel.transform;
        }
        
        return this.ObjLevel.transform;
    }
    private void LoadLevel(int indexLevel)
    {
        UnityEngine.GameObject val_12;
        UnityEngine.GameObject val_1 = UnityEngine.GameObject.Find(name:  -1610611695);
        if((-1610611695) != 0)
        {
                UnityEngine.Object.Destroy(obj:  -1610611695);
        }
        
        UnityEngine.GameObject val_3 = UnityEngine.GameObject.Find(name:  -1610611693);
        if((-1610611693) != 0)
        {
                UnityEngine.Object.Destroy(obj:  -1610611693);
        }
        
        string val_5 = this.GetLinkLevel(indexLevel:  indexLevel);
        this.linkLevel = this;
        if(this.ObjLevel != 0)
        {
                this.ObjLevel.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  this.ObjLevel);
            UnityEngine.Coroutine val_7 = this.StartCoroutine(methodName:  -1610608793);
            return;
        }
        
        val_12 = 0;
        System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073758215)});
        UnityEngine.Object val_9 = UnityEngine.Resources.Load(path:  mem[this.linkLevel], systemTypeInstance:  1073758215);
        UnityEngine.Transform val_10 = this.transform;
        UnityEngine.Object val_11 = UnityEngine.Object.Instantiate(original:  mem[this.linkLevel], parent:  706076816);
        if(mem[this.linkLevel] != 0)
        {
                if(mem[this.linkLevel] != 536887303)
        {
                mem[this.linkLevel] = 0;
        }
        
            val_12 = mem[this.linkLevel];
        }
        
        this.ObjLevel = val_12;
    }
    private string GetLinkLevel(int indexLevel)
    {
        var val_14;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_14 = mem[3221266339];
        if((mem[3221266339] + 8) == 0)
        {
            goto label_3;
        }
        
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        val_14 = -1073708883;
        if(val_14.IsOldUser == false)
        {
            goto label_5;
        }
        
        label_3:
        if((indexLevel - 4294967290) == 0)
        {
                this = this.CommonLinkLevelBoss;
        }
        
        string val_5 = indexLevel.ToString();
        string val_6 = this + 706189068;
        return;
        label_5:
        object val_7 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_8 = -1073708883.CurrentLevel;
        val_8 = val_8 + 1;
        val_8 = val_8 - 4294967290;
        if(val_8 != 0)
        {
                this = this.CommonLinkLevel;
        }
        
        WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_10 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_12 = (mem[3221266339] + 16) + ((-1073708883.CurrentLevel) << 2);
        val_12 = val_12 + 16;
        string val_13 = val_12.ToString();
        return this + val_12;
    }
    private System.Collections.IEnumerator DelayLoadScene()
    {
        536899607 = new LoadLevelRopeManager.<DelayLoadScene>d__12(<>1__state:  0);
        mem[536899623] = this;
    }
    public override void Awake()
    {
        this.Awake();
    }
    public void SpawLevelStart()
    {
        string val_15;
        var val_16;
        var val_17;
        string val_18;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_3 = this.GetLinkLevel(indexLevel:  -1073708883.CurrentLevelRope);
        val_15 = this.linkLevel;
        this.linkLevel = this;
        if(this.ObjLevel != 0)
        {
                this.ObjLevel.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  this.ObjLevel);
            UnityEngine.Coroutine val_5 = this.StartCoroutine(methodName:  -1610608793);
        }
        else
        {
                System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073758215)});
            UnityEngine.Object val_7 = UnityEngine.Resources.Load(path:  mem[this.linkLevel], systemTypeInstance:  1073758215);
            if(mem[this.linkLevel] != 0)
        {
                val_16 = 536895945;
            val_17 = 22701724;
            val_18 = mem[this.linkLevel];
        }
        else
        {
                string val_10 = this.GetLinkLevel(indexLevel:  UnityEngine.Random.Range(minInclusive:  21, maxExclusive:  30));
            this.linkLevel = this;
            val_16 = 536895945;
            val_17 = 22701724;
            val_18 = this.linkLevel;
        }
        
            val_15 = 0;
            System.Type val_11 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073758215)});
            UnityEngine.Object val_12 = UnityEngine.Resources.Load(path:  val_18, systemTypeInstance:  1073758215);
            UnityEngine.Transform val_13 = this.transform;
            UnityEngine.Object val_14 = UnityEngine.Object.Instantiate(original:  val_18, parent:  706553488);
            if(val_18 != null)
        {
                if(null != 536887303)
        {
                val_18 = 0;
        }
        
            val_15 = val_18;
        }
        
            this.ObjLevel = val_15;
        }
        
        this.ObjLevel.StartLevelTracking();
    }
    private void StartLevelTracking()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_4 = -1073708883.CurrentLevelRope.ToString();
        string val_5 = -1610605113(-1610605113) + 706661652;
        -1073700879.TrackEvent(eventName:  -1610605113);
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CurrentLevelRope) <= (-1073708883.LevelRopePlayed))
        {
                return;
        }
        
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_11 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_13 = -1073708883.CurrentLevelRope.ToString();
        string val_14 = -1610605111(-1610605111) + 706661652;
        -1073700879.TrackEvent(eventName:  -1610605111);
        object val_15 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_16 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.LevelRopePlayed = -1073708883.CurrentLevelRope;
    }
    public void SpawLevel()
    {
        if(this.canReSpawnGameMenu != false)
        {
                AFramework.UI.BaseUIMenu val_1 = AFramework.UI.CanvasManager.Init(dataPath:  -1610605257, defaultMenuIdentifier:  -1610606483);
        }
        
        this.isPlaying = false;
        this.canReSpawnGameMenu = false;
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            536882991 = new System.Action(object:  706785680, method:  new IntPtr(1610680077));
            -1073700871.StartFade(action:  536882991);
        }
        else
        {
                object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
            this.LoadLevel(indexLevel:  -1073708883.CurrentLevelRope);
        }
        
        this.StartLevelTracking();
    }
    public void ZoomCamera(UnityEngine.Vector3 posCamMove, float timeZoom, float timeDelay, System.Action _callback)
    {
        var val_1;
        536899605 = new LoadLevelRopeManager.<>c__DisplayClass17_0();
        mem[536899613] = val_1;
        if((UnityEngine.Object.op_Implicit(exists:  this.cameraMain)) == false)
        {
                return;
        }
        
        float val_5 = this.cameraMain.orthographicSize;
        float val_13 = 0.7f;
        val_13 = this.cameraMain * val_13;
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOOrthoSize(target:  this.cameraMain, endValue:  val_13, duration:  timeDelay);
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  this.cameraMain, delay:  val_13);
        UnityEngine.Transform val_8 = this.cameraMain.transform;
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.cameraMain, endValue:  new UnityEngine.Vector3() {x = posCamMove.x, y = posCamMove.y, z = -10f}, duration:  val_13, snapping:  _callback);
        DG.Tweening.Tweener val_10 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  this.cameraMain, delay:  val_13);
        536895905 = new DG.Tweening.TweenCallback(object:  536899605, method:  new IntPtr(1610680099));
        DG.Tweening.Tweener val_12 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.cameraMain, action:  536895905);
    }
    public void ShowPopupLose()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  -1610604579);
    }
    private System.Collections.IEnumerator ShowLose()
    {
        536899609 = new LoadLevelRopeManager.<ShowLose>d__19(<>1__state:  0);
        mem[536899625] = this;
    }
    public void ActiveChild(bool active)
    {
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Transform val_2 = this.GetChild(index:  0);
        UnityEngine.GameObject val_3 = this.gameObject;
        this.SetActive(value:  active);
    }
    public LoadLevelRopeManager()
    {
        this.CommonLinkLevel = -1610604477;
        this.CommonLinkLevelBoss = -1610606671;
    }
    private bool <DelayLoadScene>b__12_0()
    {
        if((mem[536891408] & true) != 0)
        {
                return UnityEngine.Object.op_Equality(x:  this.ObjLevel, y:  0);
        }
        
        if(mem[536891337] != 0)
        {
                return UnityEngine.Object.op_Equality(x:  this.ObjLevel, y:  0);
        }
        
        return UnityEngine.Object.op_Equality(x:  this.ObjLevel, y:  0);
    }
    private void <SpawLevel>b__16_0()
    {
        object val_10;
        var val_11;
        object val_12;
        System.Action val_13;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        this.LoadLevel(indexLevel:  -1073708883.CurrentLevelRope);
        this.canvasFollowDevice._FixCamSizeFollowScreen();
        if((UnityEngine.Object.op_Implicit(exists:  this.cameraMain)) != false)
        {
                val_10 = 0;
            UnityEngine.Transform val_4 = this.cameraMain.transform;
            this.cameraMain.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = -10f};
        }
        
        GameTool.EventDispatcherExtension.PostEvent(sender:  707631120, eventID:  28);
        GameTool.EventDispatcherExtension.PostEvent(sender:  707631120, eventID:  33);
        this.StopCoroutine(methodName:  -1610604579);
        int val_5 = DG.Tweening.DOTween.Kill(targetOrId:  this.cameraMain, complete:  false);
        UnityEngine.Transform val_6 = this.cameraMain.transform;
        int val_7 = DG.Tweening.DOTween.Kill(targetOrId:  this.cameraMain, complete:  false);
        WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_11 = 536899601;
        if(((mem[536899788] & true) == 0) && (mem[536899717] == 0))
        {
                val_11 = 536899601;
        }
        
        val_12 = mem[536899693];
        val_13 = mem[mem[536899693] + 4];
        val_13 = mem[536899693] + 4;
        if(val_13 == 0)
        {
                if(((mem[536899788] & true) == 0) && (mem[536899717] == 0))
        {
                val_12 = mem[536899693];
        }
        
            val_10 = mem[mem[536899693]];
            val_10 = val_12;
            val_13 = 536882991;
            val_13 = new System.Action(object:  val_10, method:  new IntPtr(1610680095));
            mem2[0] = val_13;
        }
        
        -1073700871.EndFade(action:  536882991);
    }

}
