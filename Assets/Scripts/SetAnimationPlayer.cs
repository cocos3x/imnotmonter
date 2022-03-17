using UnityEngine;
public class SetAnimationPlayer : MonoBehaviour
{
    // Fields
    private Spine.Unity.SkeletonAnimation skeletonAnimation;
    private int skinID;
    private UnityEngine.PolygonCollider2D collider2D;
    private bool botHasSkin;
    private UnityEngine.MeshRenderer[] meshs_foot;
    private UnityEngine.MeshRenderer[] mesh_Hand;
    private UnityEngine.MeshRenderer mesh_Body;
    public bool hadDie;
    private bool checkAnimIdle;
    
    // Properties
    public int GetSkinID { get; }
    
    // Methods
    private void Start()
    {
    
    }
    private void OnEnable()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  -1610604627);
    }
    public int get_GetSkinID()
    {
        return (int)this.skinID;
    }
    public void Death()
    {
        if(this.hadDie == false)
        {
                this.hadDie = true;
            this.hadDie = this.hadDie;
        }
        
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Vector3 val_3 = position;
        if(this.botHasSkin == true)
        {
                this.botHasSkin = 1;
        }
        
        -1073701059.CreateBloodEffect(pos:  new UnityEngine.Vector3() {x = R6, y = R7, z = SL}, isSaw:  false, idSkin:  this.skinID, botHasSkin:  true);
        this.collider2D.enabled = false;
        UnityEngine.Transform val_4 = this.transform;
        int val_5 = DG.Tweening.DOTween.Kill(targetOrId:  731450512, complete:  false);
        UnityEngine.GameObject val_6 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  731450512, t:  val_3.x);
    }
    public void SetPosPlayerSwing(bool isSwing)
    {
        var val_2;
        var val_3;
        UnityEngine.Transform val_1 = this.skeletonAnimation.transform;
        if(isSwing != false)
        {
                val_2 = 16044;
            val_2 = 1051495236;
            val_3 = 49097;
            val_3 = 3217660314;
        }
        else
        {
                val_2 = 0;
            val_3 = 0;
        }
        
        this.skeletonAnimation.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public void SetAnimation(string name, bool loop, System.Action _callBack)
    {
        536901015 = new SetAnimationPlayer.<>c__DisplayClass15_0();
        mem[536901023] = _callBack;
        if((UnityEngine.Object.op_Implicit(exists:  this.skeletonAnimation)) != false)
        {
                Spine.TrackEntry val_3 = this.skeletonAnimation.state.SetAnimation(trackIndex:  0, animationName:  name, loop:  loop);
            this.skeletonAnimation.timeScale = 1f;
            if(mem[536901023] == 0)
        {
                return;
        }
        
            536897929 = new AnimationState.TrackEntryDelegate(object:  536901015, method:  new IntPtr(1610680465));
            this.skeletonAnimation.state.add_Complete(value:  536897929);
            return;
        }
        
        System.Collections.IEnumerator val_5 = this.WaitSkeleton(name:  name, loop:  loop, _callBack:  mem[536901023]);
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  731711376);
    }
    private System.Collections.IEnumerator WaitSkeleton(string name, bool loop, System.Action _callBack)
    {
        SetAnimationPlayer.<WaitSkeleton>d__16 val_1 = 536901025;
        val_1 = new SetAnimationPlayer.<WaitSkeleton>d__16(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536901041] = this;
            mem[536901049] = name;
            mem[536901053] = loop;
        }
        else
        {
                mem[16] = this;
            mem[24] = name;
            mem[28] = loop;
        }
        
        mem[536901045] = _callBack;
    }
    public void SetLayerSwing()
    {
        var val_1;
        var val_2;
        val_1 = 0;
        goto label_1;
        label_5:
        1152921506751708688.sortingLayerName = -1610608815;
        val_1 = 1;
        label_1:
        if(val_1 < 1152921506751708688)
        {
            goto label_5;
        }
        
        val_2 = 0;
        goto label_6;
        label_10:
        1152921506751708688.sortingLayerName = -1610608815;
        val_2 = 1;
        label_6:
        if(val_2 < 1152921506751708688)
        {
            goto label_10;
        }
        
        this.mesh_Body.sortingLayerName = -1610609369;
    }
    public void SetScale()
    {
        UnityEngine.Transform val_1 = this.skeletonAnimation.transform;
        this.skeletonAnimation.localScale = new UnityEngine.Vector3() {x = -0.415f, y = 0.415f, z = 1f};
    }
    public void HideSkeleton()
    {
        UnityEngine.GameObject val_1 = this.skeletonAnimation.gameObject;
        this.skeletonAnimation.SetActive(value:  false);
    }
    public void ChangeLayerShowInUI()
    {
        var val_3;
        var val_4;
        val_3 = 4;
        goto label_1;
        label_9:
        this.meshs_foot[0].sortingLayerName = -1610603225;
        UnityEngine.MeshRenderer val_6 = this.meshs_foot[0];
        val_6.sortingOrder = R7 + 7;
        val_3 = 5;
        label_1:
        if((val_3 - 4) < val_6)
        {
            goto label_9;
        }
        
        val_4 = 4;
        goto label_10;
        label_18:
        this.mesh_Hand[0].sortingLayerName = -1610603225;
        UnityEngine.MeshRenderer val_8 = this.mesh_Hand[0];
        if(val_4 != 4)
        {
                0 = this.meshs_foot;
        }
        
        if(val_4 == 4)
        {
                0 = 1;
        }
        
        val_8.sortingOrder = 1;
        val_4 = 5;
        label_10:
        if((val_4 - 4) < val_8)
        {
            goto label_18;
        }
        
        this.mesh_Body.sortingLayerName = -1610603225;
        this.mesh_Body.sortingOrder = 10;
        UnityEngine.Coroutine val_4 = this.StartCoroutine(methodName:  -1610608781);
    }
    private System.Collections.IEnumerator DelayShowAnimWin()
    {
        536901021 = new SetAnimationPlayer.<DelayShowAnimWin>d__21(<>1__state:  0);
        mem[536901037] = this;
    }
    private System.Collections.IEnumerator SetSkin()
    {
        536901023 = new SetAnimationPlayer.<SetSkin>d__22(<>1__state:  0);
        mem[536901039] = this;
    }
    public SetAnimationPlayer()
    {
    
    }
    private bool <SetSkin>b__22_0()
    {
        if((mem[536891408] & true) != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.skeletonAnimation);
        }
        
        if(mem[536891337] != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.skeletonAnimation);
        }
        
        return UnityEngine.Object.op_Implicit(exists:  this.skeletonAnimation);
    }

}
