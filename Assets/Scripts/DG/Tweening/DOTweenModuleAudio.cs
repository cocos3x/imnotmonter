using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenModuleAudio
    {
        // Methods
        public static DG.Tweening.Tweener DOFade(UnityEngine.AudioSource target, float endValue, float duration)
        {
            float val_5;
            DOTweenModuleAudio.<>c__DisplayClass0_0 val_1 = 536898421;
            val_1 = new DOTweenModuleAudio.<>c__DisplayClass0_0();
            mem[536898429] = target;
            if(val_1 < 0)
            {
                    val_5 = 0f;
            }
            else
            {
                    if(val_1 > 0)
            {
                    val_5 = 1f;
            }
            
            }
            
            536873981 = new DG.Tweening.Core.DOGetter<System.Single>(object:  536898421, method:  new IntPtr(1610690699));
            536874023 = new DG.Tweening.Core.DOSetter<System.Single>(object:  536898421, method:  new IntPtr(1610690701));
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873981, setter:  536874023, endValue:  1f, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873981, target:  mem[536898429]);
        }
        public static DG.Tweening.Tweener DOPitch(UnityEngine.AudioSource target, float endValue, float duration)
        {
            536898423 = new DOTweenModuleAudio.<>c__DisplayClass1_0();
            mem[536898431] = target;
            536873981 = new DG.Tweening.Core.DOGetter<System.Single>(object:  536898423, method:  new IntPtr(1610690705));
            536874023 = new DG.Tweening.Core.DOSetter<System.Single>(object:  536898423, method:  new IntPtr(1610690707));
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873981, setter:  536874023, endValue:  endValue, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873981, target:  mem[536898431]);
        }
        public static DG.Tweening.Tweener DOSetFloat(UnityEngine.Audio.AudioMixer target, string floatName, float endValue, float duration)
        {
            object val_5;
            DOTweenModuleAudio.<>c__DisplayClass2_0 val_1 = 536898425;
            val_1 = new DOTweenModuleAudio.<>c__DisplayClass2_0();
            if(val_1 != 0)
            {
                    val_5 = val_1;
                mem[536898433] = target;
            }
            else
            {
                    val_5 = 8;
                mem[8] = target;
            }
            
            mem[536898437] = floatName;
            536873981 = new DG.Tweening.Core.DOGetter<System.Single>(object:  536898425, method:  new IntPtr(1610690711));
            536874023 = new DG.Tweening.Core.DOSetter<System.Single>(object:  536898425, method:  new IntPtr(1610690713));
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873981, setter:  536874023, endValue:  endValue, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873981, target:  val_5);
        }
        public static int DOComplete(UnityEngine.Audio.AudioMixer target, bool withCallbacks = False)
        {
            if((mem[536885752] & true) != 0)
            {
                    return DG.Tweening.DOTween.Complete(targetOrId:  target, withCallbacks:  withCallbacks);
            }
            
            if(mem[536885681] != 0)
            {
                    return DG.Tweening.DOTween.Complete(targetOrId:  target, withCallbacks:  withCallbacks);
            }
            
            return DG.Tweening.DOTween.Complete(targetOrId:  target, withCallbacks:  withCallbacks);
        }
        public static int DOKill(UnityEngine.Audio.AudioMixer target, bool complete = False)
        {
            if((mem[536885752] & true) != 0)
            {
                    return DG.Tweening.DOTween.Kill(targetOrId:  target, complete:  complete);
            }
            
            if(mem[536885681] != 0)
            {
                    return DG.Tweening.DOTween.Kill(targetOrId:  target, complete:  complete);
            }
            
            return DG.Tweening.DOTween.Kill(targetOrId:  target, complete:  complete);
        }
        public static int DOFlip(UnityEngine.Audio.AudioMixer target)
        {
            if((mem[536885752] & true) != 0)
            {
                    return DG.Tweening.DOTween.Flip(targetOrId:  target);
            }
            
            if(mem[536885681] != 0)
            {
                    return DG.Tweening.DOTween.Flip(targetOrId:  target);
            }
            
            return DG.Tweening.DOTween.Flip(targetOrId:  target);
        }
        public static int DOGoto(UnityEngine.Audio.AudioMixer target, float to, bool andPlay = False)
        {
            if((mem[536885752] & true) != 0)
            {
                    return DG.Tweening.DOTween.Goto(targetOrId:  target, to:  to, andPlay:  andPlay);
            }
            
            if(mem[536885681] != 0)
            {
                    return DG.Tweening.DOTween.Goto(targetOrId:  target, to:  to, andPlay:  andPlay);
            }
            
            return DG.Tweening.DOTween.Goto(targetOrId:  target, to:  to, andPlay:  andPlay);
        }
        public static int DOPause(UnityEngine.Audio.AudioMixer target)
        {
            if((mem[536885752] & true) != 0)
            {
                    return DG.Tweening.DOTween.Pause(targetOrId:  target);
            }
            
            if(mem[536885681] != 0)
            {
                    return DG.Tweening.DOTween.Pause(targetOrId:  target);
            }
            
            return DG.Tweening.DOTween.Pause(targetOrId:  target);
        }
        public static int DOPlay(UnityEngine.Audio.AudioMixer target)
        {
            if((mem[536885752] & true) != 0)
            {
                    return DG.Tweening.DOTween.Play(targetOrId:  target);
            }
            
            if(mem[536885681] != 0)
            {
                    return DG.Tweening.DOTween.Play(targetOrId:  target);
            }
            
            return DG.Tweening.DOTween.Play(targetOrId:  target);
        }
        public static int DOPlayBackwards(UnityEngine.Audio.AudioMixer target)
        {
            if((mem[536885752] & true) != 0)
            {
                    return DG.Tweening.DOTween.PlayBackwards(targetOrId:  target);
            }
            
            if(mem[536885681] != 0)
            {
                    return DG.Tweening.DOTween.PlayBackwards(targetOrId:  target);
            }
            
            return DG.Tweening.DOTween.PlayBackwards(targetOrId:  target);
        }
        public static int DOPlayForward(UnityEngine.Audio.AudioMixer target)
        {
            if((mem[536885752] & true) != 0)
            {
                    return DG.Tweening.DOTween.PlayForward(targetOrId:  target);
            }
            
            if(mem[536885681] != 0)
            {
                    return DG.Tweening.DOTween.PlayForward(targetOrId:  target);
            }
            
            return DG.Tweening.DOTween.PlayForward(targetOrId:  target);
        }
        public static int DORestart(UnityEngine.Audio.AudioMixer target)
        {
            return DG.Tweening.DOTween.Restart(targetOrId:  target, includeDelay:  true, changeDelayTo:  null);
        }
        public static int DORewind(UnityEngine.Audio.AudioMixer target)
        {
            if((mem[536885752] & true) != 0)
            {
                    return DG.Tweening.DOTween.Rewind(targetOrId:  target, includeDelay:  true);
            }
            
            if(mem[536885681] != 0)
            {
                    return DG.Tweening.DOTween.Rewind(targetOrId:  target, includeDelay:  true);
            }
            
            return DG.Tweening.DOTween.Rewind(targetOrId:  target, includeDelay:  true);
        }
        public static int DOSmoothRewind(UnityEngine.Audio.AudioMixer target)
        {
            if((mem[536885752] & true) != 0)
            {
                    return DG.Tweening.DOTween.SmoothRewind(targetOrId:  target);
            }
            
            if(mem[536885681] != 0)
            {
                    return DG.Tweening.DOTween.SmoothRewind(targetOrId:  target);
            }
            
            return DG.Tweening.DOTween.SmoothRewind(targetOrId:  target);
        }
        public static int DOTogglePause(UnityEngine.Audio.AudioMixer target)
        {
            if((mem[536885752] & true) != 0)
            {
                    return DG.Tweening.DOTween.TogglePause(targetOrId:  target);
            }
            
            if(mem[536885681] != 0)
            {
                    return DG.Tweening.DOTween.TogglePause(targetOrId:  target);
            }
            
            return DG.Tweening.DOTween.TogglePause(targetOrId:  target);
        }
    
    }

}
