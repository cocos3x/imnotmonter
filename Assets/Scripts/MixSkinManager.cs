using UnityEngine;
public class MixSkinManager
{
    // Methods
    public static void SetSkinSkeleton(Spine.Unity.SkeletonAnimation ske, string nameSkin)
    {
        Spine.Skeleton val_1 = ske.Skeleton;
        536893971 = new Spine.Skin(name:  nameSkin);
        Spine.Skin val_3 = static_value_015EF0EC.FindSkin(skinName:  nameSkin);
        val_2.AddSkin(skin:  static_value_015EF0EC);
        ske.SetSkin(newSkin:  536893971);
        ske.SetSlotsToSetupPose();
        ske.Update(deltaTime:  null);
    }
    public static void SetSkinMixSkeleton(Spine.Unity.SkeletonAnimation ske, string[] nameSkins)
    {
        var val_4;
        Spine.Skeleton val_1 = ske.Skeleton;
        Spine.Skin val_2 = 536893971;
        val_4 = 0;
        val_2 = new Spine.Skin(name:  nameSkins[0]);
        if(val_2 >= 1)
        {
                do
        {
            Spine.Skin val_3 = R7.FindSkin(skinName:  334878800);
            val_2.AddSkin(skin:  R7);
            val_4 = val_4 + 1;
        }
        while(val_4 < val_2);
        
        }
        
        if(ske != 0)
        {
                ske.SetSkin(newSkin:  536893971);
        }
        else
        {
                0.SetSkin(newSkin:  536893971);
        }
        
        ske.SetSlotsToSetupPose();
        ske.Update(deltaTime:  null);
    }
    public static void SetTimeScaleCurrentAnim(Spine.Unity.SkeletonAnimation ske, float value)
    {
        Spine.TrackEntry val_1 = ske.state.GetCurrent(trackIndex:  0);
        mem2[0] = R1;
    }
    public static void SetSkinSkeletonGraphic(Spine.Unity.SkeletonGraphic ske, string nameSkin)
    {
        Spine.Skeleton val_1 = ske.Skeleton;
        536893971 = new Spine.Skin(name:  nameSkin);
        Spine.Skin val_3 = static_value_015EF0EE.FindSkin(skinName:  nameSkin);
        val_2.AddSkin(skin:  static_value_015EF0EE);
        ske.SetSkin(newSkin:  536893971);
        ske.SetSlotsToSetupPose();
        if(ske == 0)
        {
            
        }
    
    }
    public static void SetSkeletonDataAsset(Spine.Unity.SkeletonAnimation ske, Spine.Unity.SkeletonDataAsset asset, string skinName)
    {
        if(ske != 0)
        {
                mem2[0] = asset;
            mem2[0] = skinName;
        }
        else
        {
                mem[12] = asset;
            mem[16] = skinName;
        }
    
    }
    public static void SetSkeletonDataAsset(Spine.Unity.SkeletonGraphic ske, Spine.Unity.SkeletonDataAsset asset, string skinName)
    {
        if(ske != 0)
        {
                ske.initialSkinName = skinName;
            ske.skeletonDataAsset = asset;
            ske.Initialize(overwrite:  true);
        }
        else
        {
                mem[128] = skinName;
            mem[124] = asset;
            0.Initialize(overwrite:  true);
        }
        
        ske.SetMaterialDirty();
    }
    public static void SetAnimation(Spine.Unity.SkeletonAnimation ske, string name, bool loop, float timeScale = 1, System.Action _callBack)
    {
        var val_1;
        536899995 = new MixSkinManager.<>c__DisplayClass6_0();
        mem[536900003] = val_1;
        Spine.Animation val_3 = val_1 + 8.FindAnimation(animationName:  name);
        if((val_1 + 8) == 0)
        {
                return;
        }
        
        Spine.AnimationState val_4 = ske.AnimationState;
        Spine.TrackEntry val_5 = ske.SetAnimation(trackIndex:  0, animationName:  name, loop:  loop);
        mem2[0] = _callBack;
        if(mem[536900003] == 0)
        {
                return;
        }
        
        536897929 = new AnimationState.TrackEntryDelegate(object:  536899995, method:  new IntPtr(1610677331));
        ske.add_Complete(value:  536897929);
    }
    public static void SetAnimation(Spine.Unity.SkeletonGraphic ske, string name, bool loop, float timeScale = 1, System.Action _callBack)
    {
        var val_1;
        536899997 = new MixSkinManager.<>c__DisplayClass7_0();
        mem[536900005] = val_1;
        Spine.SkeletonData val_3 = ske.SkeletonData;
        Spine.Animation val_4 = ske.FindAnimation(animationName:  name);
        if(ske == 0)
        {
                return;
        }
        
        Spine.AnimationState val_5 = ske.AnimationState;
        Spine.TrackEntry val_6 = ske.SetAnimation(trackIndex:  0, animationName:  name, loop:  loop);
        mem2[0] = _callBack;
        if(mem[536900005] == 0)
        {
                return;
        }
        
        536897929 = new AnimationState.TrackEntryDelegate(object:  536899997, method:  new IntPtr(1610677335));
        ske.add_Complete(value:  536897929);
    }
    public MixSkinManager()
    {
    
    }

}
