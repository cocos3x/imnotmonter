using UnityEngine;
public class CharacterAnimationController : MonoBehaviour
{
    // Fields
    private Spine.Unity.SkeletonAnimation characterSkeleton;
    private string currentAnimationState;
    private UnityEngine.MeshRenderer meshSkeleton;
    private System.Action eventCallBack;
    
    // Methods
    private void Start()
    {
        Spine.AnimationState val_1 = this.characterSkeleton.AnimationState;
        536897935 = new AnimationState.TrackEntryEventDelegate(object:  668200592, method:  new IntPtr(1610679427));
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
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  668569360);
    }
    private System.Collections.IEnumerator WaitSetSkin(string skinName)
    {
        CharacterAnimationController.<WaitSetSkin>d__8 val_1 = 536898261;
        val_1 = new CharacterAnimationController.<WaitSetSkin>d__8(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536898277] = this;
        }
        else
        {
                mem[16] = this;
        }
        
        mem[536898281] = skinName;
    }
    public void SetSkinMix(string[] skinName)
    {
        System.Collections.IEnumerator val_1 = this.WaitSetSkinMix(skinName:  skinName);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  668842512);
    }
    private System.Collections.IEnumerator WaitSetSkinMix(string[] skinName)
    {
        CharacterAnimationController.<WaitSetSkinMix>d__10 val_1 = 536898263;
        val_1 = new CharacterAnimationController.<WaitSetSkinMix>d__10(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536898279] = this;
        }
        else
        {
                mem[16] = this;
        }
        
        mem[536898283] = skinName;
    }
    public void SetOrderLayer(int value)
    {
        this.meshSkeleton.sortingOrder = value;
    }
    public void SetSortingLayer(string value)
    {
        this.meshSkeleton.sortingLayerName = value;
    }
    public void SetAnimation(string name, bool loop, float timeScale = 1, System.Action _callBack)
    {
        var val_1;
        AnimationState.TrackEntryDelegate val_7;
        CharacterAnimationController.<>c__DisplayClass13_0 val_2 = 536898249;
        val_2 = new CharacterAnimationController.<>c__DisplayClass13_0();
        val_7 = val_2;
        mem[536898257] = val_1;
        Spine.Animation val_3 = this.characterSkeleton.FindAnimation(animationName:  name);
        if(this.characterSkeleton != 0)
        {
                Spine.AnimationState val_4 = this.characterSkeleton.AnimationState;
            Spine.TrackEntry val_5 = this.characterSkeleton.SetAnimation(trackIndex:  0, animationName:  name, loop:  loop);
            mem2[0] = _callBack;
            if(mem[536898257] != 0)
        {
                val_7 = 536897929;
            val_7 = new AnimationState.TrackEntryDelegate(object:  536898249, method:  new IntPtr(1610679501));
            this.characterSkeleton.add_Complete(value:  536897929);
        }
        
        }
        
        this.currentAnimationState = name;
    }
    public void AddAnimation(Spine.Unity.AnimationReferenceAsset animation, bool loop, int trackIndex = 1, float timeScale = 1, System.Action _callBack)
    {
        var val_1;
        536898251 = new CharacterAnimationController.<>c__DisplayClass14_0();
        mem[536898259] = val_1;
        Spine.Animation val_3 = Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  animation);
        Spine.TrackEntry val_4 = this.characterSkeleton.state.AddAnimation(trackIndex:  trackIndex, animation:  animation, loop:  loop, delay:  timeScale);
        mem2[0] = _callBack;
        if(mem[536898259] == 0)
        {
                return;
        }
        
        536897929 = new AnimationState.TrackEntryDelegate(object:  536898251, method:  new IntPtr(1610679505));
        this.characterSkeleton.state.add_Complete(value:  536897929);
    }
    public void AddAnimationWithEvent(Spine.Unity.AnimationReferenceAsset animation, bool loop, int trackIndex = 1, float timeScale = 1, System.Action _callBack, System.Action _callBackEv)
    {
        var val_1;
        536898253 = new CharacterAnimationController.<>c__DisplayClass15_0();
        mem[536898261] = _callBackEv;
        if(val_1 != 0)
        {
                this.eventCallBack = 0;
            mem[1152921509571549992] = val_1;
        }
        
        Spine.Animation val_3 = Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  animation);
        Spine.TrackEntry val_4 = this.characterSkeleton.state.AddAnimation(trackIndex:  trackIndex, animation:  animation, loop:  loop, delay:  timeScale);
        mem2[0] = _callBack;
        if(mem[536898261] == 0)
        {
                return;
        }
        
        536897929 = new AnimationState.TrackEntryDelegate(object:  536898253, method:  new IntPtr(1610679509));
        this.characterSkeleton.state.add_Complete(value:  536897929);
    }
    public void SetAnimationWithEvent(string name, bool loop, float timeScale = 1, System.Action _callBackEv, System.Action _callBackCom)
    {
        var val_1;
        var val_7;
        536898255 = new CharacterAnimationController.<>c__DisplayClass16_0();
        mem[536898263] = val_1;
        this.currentAnimationState = name;
        if(_callBackCom != 0)
        {
                this.eventCallBack = 0;
            mem[1152921509571702952] = _callBackCom;
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
        if(mem[536898263] == 0)
        {
                return;
        }
        
        536897929 = new AnimationState.TrackEntryDelegate(object:  536898255, method:  new IntPtr(1610679513));
        this.characterSkeleton.add_Complete(value:  536897929);
    }
    public void SetAnimationWithLoopCount(string name, bool loop, float timeScale = 1, System.Action _callBack)
    {
        var val_1;
        AnimationState.TrackEntryDelegate val_7;
        CharacterAnimationController.<>c__DisplayClass17_0 val_2 = 536898257;
        val_2 = new CharacterAnimationController.<>c__DisplayClass17_0();
        val_7 = val_2;
        mem[536898265] = val_1;
        Spine.Animation val_3 = this.characterSkeleton.FindAnimation(animationName:  name);
        if(this.characterSkeleton != 0)
        {
                Spine.AnimationState val_4 = this.characterSkeleton.AnimationState;
            Spine.TrackEntry val_5 = this.characterSkeleton.SetAnimation(trackIndex:  0, animationName:  name, loop:  loop);
            mem2[0] = _callBack;
            if(mem[536898265] != 0)
        {
                val_7 = 536897929;
            val_7 = new AnimationState.TrackEntryDelegate(object:  536898257, method:  new IntPtr(1610679517));
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
        if(1152921509572626191 < 1)
        {
                return;
        }
        
        do
        {
            this.ClearTrack(id:  670811919);
        }
        while(1152921509572626191 != 1);
    
    }
    public void SetOpacity(float value)
    {
        UnityEngine.Transform val_1 = this.characterSkeleton.GetComponent<UnityEngine.Transform>();
        mem2[0] = R1;
    }
    public void SetFadeOpacity(float value)
    {
        System.Collections.IEnumerator val_1 = this.FadeOpacity(value:  value);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  671056400);
    }
    private System.Collections.IEnumerator FadeOpacity(float value)
    {
        CharacterAnimationController.<FadeOpacity>d__26 val_1 = 536898259;
        val_1 = new CharacterAnimationController.<FadeOpacity>d__26(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536898275] = this;
        }
        else
        {
                mem[16] = this;
        }
        
        mem[536898279] = R1;
    }
    public CharacterAnimationController()
    {
    
    }
    private bool <WaitSetSkin>b__8_0()
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
    private bool <WaitSetSkinMix>b__10_0()
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
