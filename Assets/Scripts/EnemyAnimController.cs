using UnityEngine;
public class EnemyAnimController : MonoBehaviour
{
    // Fields
    private Spine.Unity.SkeletonAnimation characterSkeleton;
    private string currentAnimationState;
    private UnityEngine.MeshRenderer[] meshSkeletonBottom;
    private UnityEngine.MeshRenderer[] meshSkeletonTop;
    private System.Action eventCallBack;
    
    // Methods
    private void Start()
    {
        Spine.AnimationState val_1 = this.characterSkeleton.AnimationState;
        536897935 = new AnimationState.TrackEntryEventDelegate(object:  675515792, method:  new IntPtr(1610679543));
        this.characterSkeleton.add_Event(value:  536897935);
    }
    public void ChangeCharacterSkeleton(Spine.Unity.SkeletonAnimation _characterSkeleton)
    {
        this.characterSkeleton = _characterSkeleton;
    }
    private void HandleAnimationStateEvent(Spine.TrackEntry trackEntry, Spine.Event e)
    {
    
    }
    public void SetSkin(string skinName)
    {
        System.Collections.IEnumerator val_1 = this.WaitSetSkin(skinName:  skinName);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  675884560);
    }
    private System.Collections.IEnumerator WaitSetSkin(string skinName)
    {
        EnemyAnimController.<WaitSetSkin>d__9 val_1 = 536898797;
        val_1 = new EnemyAnimController.<WaitSetSkin>d__9(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536898813] = this;
        }
        else
        {
                mem[16] = this;
        }
        
        mem[536898817] = skinName;
    }
    public void SetSkinMix(string[] skinName)
    {
        System.Collections.IEnumerator val_1 = this.WaitSetSkinMix(skinName:  skinName);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  676157712);
    }
    private System.Collections.IEnumerator WaitSetSkinMix(string[] skinName)
    {
        EnemyAnimController.<WaitSetSkinMix>d__11 val_1 = 536898799;
        val_1 = new EnemyAnimController.<WaitSetSkinMix>d__11(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536898815] = this;
        }
        else
        {
                mem[16] = this;
        }
        
        mem[536898819] = skinName;
    }
    public void SetSortingLayer(string value)
    {
        var val_3;
        var val_4;
        val_3 = 0;
        goto label_1;
        label_8:
        if(2144861712 != 0)
        {
                1152921506751708688.sortingLayerName = value;
        }
        
        val_3 = 1;
        label_1:
        if(val_3 < 1152921506751708688)
        {
            goto label_8;
        }
        
        val_4 = 0;
        goto label_9;
        label_16:
        if(2144861712 != 0)
        {
                1152921506751708688.sortingLayerName = value;
        }
        
        val_4 = 1;
        label_9:
        if(val_4 < 1152921506751708688)
        {
            goto label_16;
        }
    
    }
    public void SetAnimation(string name, bool loop, float timeScale = 1, System.Action _callBack)
    {
        var val_1;
        var val_11;
        AnimationState.TrackEntryDelegate val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_11 = this;
        EnemyAnimController.<>c__DisplayClass13_0 val_2 = 536898785;
        val_2 = new EnemyAnimController.<>c__DisplayClass13_0();
        val_12 = val_2;
        mem[536898793] = val_1;
        if((System.String.op_Equality(a:  name, b:  this.currentAnimationState)) != false)
        {
                val_13 = 22711576;
            val_14 = 536887951;
            if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_14 = 536887951;
        }
        
            if((System.String.op_Equality(a:  name, b:  mem[536888043] + 40)) == true)
        {
                return;
        }
        
        }
        
        if((System.String.op_Equality(a:  name, b:  this.currentAnimationState)) != false)
        {
                val_15 = 536887951;
            if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_15 = 536887951;
        }
        
            val_13 = mem[mem[536888043] + 80];
            val_13 = mem[536888043] + 80;
            if((System.String.op_Equality(a:  name, b:  mem[536888043] + 80 + 16)) != false)
        {
                return;
        }
        
        }
        
        Spine.Animation val_7 = this.characterSkeleton.FindAnimation(animationName:  name);
        if(this.characterSkeleton != 0)
        {
                val_11 = 0;
            Spine.AnimationState val_8 = this.characterSkeleton.AnimationState;
            Spine.TrackEntry val_9 = this.characterSkeleton.SetAnimation(trackIndex:  0, animationName:  name, loop:  loop);
            val_16 = this.characterSkeleton;
            mem2[0] = _callBack;
            if(mem[536898793] != 0)
        {
                val_12 = 536897929;
            val_12 = new AnimationState.TrackEntryDelegate(object:  536898785, method:  new IntPtr(1610679615));
            val_16.add_Complete(value:  536897929);
        }
        
        }
        
        this.currentAnimationState = name;
    }
    public void AddAnimation(Spine.Unity.AnimationReferenceAsset animation, bool loop, int trackIndex = 1, float timeScale = 1, System.Action _callBack)
    {
        var val_1;
        536898787 = new EnemyAnimController.<>c__DisplayClass14_0();
        mem[536898795] = val_1;
        Spine.Animation val_3 = Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  animation);
        Spine.TrackEntry val_4 = this.characterSkeleton.state.AddAnimation(trackIndex:  trackIndex, animation:  animation, loop:  loop, delay:  timeScale);
        mem2[0] = _callBack;
        if(mem[536898795] == 0)
        {
                return;
        }
        
        536897929 = new AnimationState.TrackEntryDelegate(object:  536898787, method:  new IntPtr(1610679619));
        this.characterSkeleton.state.add_Complete(value:  536897929);
    }
    public void AddAnimationWithEvent(Spine.Unity.AnimationReferenceAsset animation, bool loop, int trackIndex = 1, float timeScale = 1, System.Action _callBack, System.Action _callBackEv)
    {
        var val_1;
        536898789 = new EnemyAnimController.<>c__DisplayClass15_0();
        mem[536898797] = _callBackEv;
        if(val_1 != 0)
        {
                this.eventCallBack = 0;
            mem[1152921509578892460] = val_1;
        }
        
        Spine.Animation val_3 = Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  animation);
        Spine.TrackEntry val_4 = this.characterSkeleton.state.AddAnimation(trackIndex:  trackIndex, animation:  animation, loop:  loop, delay:  timeScale);
        mem2[0] = _callBack;
        if(mem[536898797] == 0)
        {
                return;
        }
        
        536897929 = new AnimationState.TrackEntryDelegate(object:  536898789, method:  new IntPtr(1610679623));
        this.characterSkeleton.state.add_Complete(value:  536897929);
    }
    public void SetAnimationWithEvent(string name, bool loop, float timeScale = 1, System.Action _callBackEv, System.Action _callBackCom)
    {
        var val_1;
        var val_7;
        536898791 = new EnemyAnimController.<>c__DisplayClass16_0();
        mem[536898799] = val_1;
        this.currentAnimationState = name;
        if(_callBackCom != 0)
        {
                this.eventCallBack = 0;
            mem[1152921509579045420] = _callBackCom;
        }
        
        Spine.Animation val_3 = _callBackCom.FindAnimation(animationName:  name);
        if(_callBackCom == 0)
        {
                return;
        }
        
        val_7 = 0;
        Spine.AnimationState val_4 = this.characterSkeleton.AnimationState;
        Spine.TrackEntry val_5 = this.characterSkeleton.SetAnimation(trackIndex:  0, animationName:  name, loop:  loop);
        mem2[0] = _callBackEv;
        if(mem[536898799] == 0)
        {
                return;
        }
        
        536897929 = new AnimationState.TrackEntryDelegate(object:  536898791, method:  new IntPtr(1610679627));
        this.characterSkeleton.add_Complete(value:  536897929);
    }
    public void SetAnimationWithLoopCount(string name, bool loop, float timeScale = 1, System.Action _callBack)
    {
        var val_1;
        AnimationState.TrackEntryDelegate val_7;
        EnemyAnimController.<>c__DisplayClass17_0 val_2 = 536898793;
        val_2 = new EnemyAnimController.<>c__DisplayClass17_0();
        val_7 = val_2;
        mem[536898801] = val_1;
        Spine.Animation val_3 = this.characterSkeleton.FindAnimation(animationName:  name);
        if(this.characterSkeleton != 0)
        {
                Spine.AnimationState val_4 = this.characterSkeleton.AnimationState;
            Spine.TrackEntry val_5 = this.characterSkeleton.SetAnimation(trackIndex:  0, animationName:  name, loop:  loop);
            mem2[0] = _callBack;
            if(mem[536898801] != 0)
        {
                val_7 = 536897929;
            val_7 = new AnimationState.TrackEntryDelegate(object:  536898793, method:  new IntPtr(1610679631));
            this.characterSkeleton.add_Complete(value:  536897929);
        }
        
        }
        
        this.currentAnimationState = name;
    }
    public float GetTimeDurationAnimation(string name)
    {
        Spine.Skeleton val_1 = this.characterSkeleton.Skeleton;
        Spine.Animation val_2 = this.characterSkeleton.FindAnimation(animationName:  name);
        return 0f;
    }
    public void SetTimeScaleMain(float value)
    {
        this.characterSkeleton.timeScale = R1;
    }
    public void SetTimeScaleCurrentAnim(float value)
    {
        Spine.TrackEntry val_1 = this.characterSkeleton.state.GetCurrent(trackIndex:  0);
        mem2[0] = R1;
    }
    public void ClearTrack()
    {
        this.currentAnimationState = -1610612735;
        this.characterSkeleton.state.ClearTracks();
    }
    public void ClearTrack(int id)
    {
        this.characterSkeleton.state.ClearTrack(trackIndex:  id);
    }
    public void ClearTrackAdd()
    {
        if(1152921509579968655 < 1)
        {
                return;
        }
        
        do
        {
            this.ClearTrack(id:  678154383);
        }
        while(1152921509579968655 != 1);
    
    }
    public void SetOpacity(float value)
    {
        UnityEngine.Transform val_1 = this.characterSkeleton.GetComponent<UnityEngine.Transform>();
        mem2[0] = R1;
    }
    public void SetFadeOpacity(float value)
    {
        System.Collections.IEnumerator val_1 = this.FadeOpacity(value:  value);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  678398864);
    }
    private System.Collections.IEnumerator FadeOpacity(float value)
    {
        EnemyAnimController.<FadeOpacity>d__26 val_1 = 536898795;
        val_1 = new EnemyAnimController.<FadeOpacity>d__26(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536898811] = this;
        }
        else
        {
                mem[16] = this;
        }
        
        mem[536898815] = R1;
    }
    public EnemyAnimController()
    {
    
    }
    private bool <WaitSetSkin>b__9_0()
    {
        if((mem[536891408] & true) != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.characterSkeleton);
        }
        
        if(mem[536891337] != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.characterSkeleton);
        }
        
        return UnityEngine.Object.op_Implicit(exists:  this.characterSkeleton);
    }
    private bool <WaitSetSkinMix>b__11_0()
    {
        if((mem[536891408] & true) != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.characterSkeleton);
        }
        
        if(mem[536891337] != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.characterSkeleton);
        }
        
        return UnityEngine.Object.op_Implicit(exists:  this.characterSkeleton);
    }

}
