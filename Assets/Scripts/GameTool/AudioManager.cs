using UnityEngine;

namespace GameTool
{
    public class AudioManager : SingletonMonoBehaviour<GameTool.AudioManager>
    {
        // Fields
        private MixerAudioManager mixerAudioManager;
        private UnityEngine.AudioSource music;
        private UnityEngine.AudioSource sfx;
        public System.Collections.Generic.List<GameTool.AudioManager.MusicTrack> tracks;
        public System.Collections.Generic.List<GameTool.AudioManager.Sound> sounds;
        private static System.Collections.Generic.List<string> mixBuffer;
        private static float mixBufferClearDelay;
        internal string currentTrack;
        
        // Methods
        private GameTool.AudioManager.Sound GetSoundByName(string name)
        {
            536898049 = new AudioManager.<>c__DisplayClass5_0();
            mem[536898057] = name;
            536879269 = new System.Predicate<Page>(object:  536898049, method:  new IntPtr(1610686503));
            if(this.sounds != 0)
            {
                    return this.sounds.Find(match:  536879269);
            }
            
            return this.sounds.Find(match:  536879269);
        }
        public override void Awake()
        {
            this.Awake();
            System.Collections.IEnumerator val_1 = this.MixBufferRoutine();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1131799568);
        }
        private System.Collections.IEnumerator MixBufferRoutine()
        {
            536898053 = new AudioManager.<MixBufferRoutine>d__10(<>1__state:  0);
        }
        public void PlayMusic(string trackName)
        {
            var val_9;
            UnityEngine.AudioClip val_10;
            val_9 = this;
            if((System.String.op_Equality(a:  this.currentTrack, b:  trackName)) == true)
            {
                    return;
            }
            
            if((System.String.op_Inequality(a:  trackName, b:  -1610612735)) != false)
            {
                    this.currentTrack = trackName;
            }
            
            List.Enumerator<T> val_3 = GetEnumerator();
            val_10 = 0;
            val_9 = 22729268;
            goto label_4;
            label_6:
            if((System.String.op_Equality(a:  val_4 + 8, b:  trackName)) == true)
            {
                    val_10 = mem[val_4 + 12];
                val_10 = val_4 + 12;
            }
            
            label_4:
            if(MoveNext() == true)
            {
                goto label_6;
            }
            
            Dispose();
            System.Collections.IEnumerator val_7 = this.CrossFade(to:  val_10);
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  1132035856);
        }
        private System.Collections.IEnumerator CrossFade(UnityEngine.AudioClip to)
        {
            AudioManager.<CrossFade>d__12 val_1 = 536898051;
            val_1 = new AudioManager.<CrossFade>d__12(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536898067] = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            mem[536898071] = to;
        }
        public void FadeVolumnMusic(bool isEnable)
        {
            536875677 = new System.Func<System.Single, System.Single, System.Single, System.Single>(object:  0, method:  new IntPtr(1610644081));
            if(isEnable != false)
            {
                    System.Collections.IEnumerator val_2 = AudioFade.FadeIn(audioSource:  this.music, fadingTime:  null, Interpolate:  1065353216);
            }
            else
            {
                    System.Collections.IEnumerator val_3 = AudioFade.FadeOut(audioSource:  this.music, fadingTime:  null, Interpolate:  1065353216);
            }
            
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.music);
        }
        public void Shot(string clip, float volume = 1)
        {
            var val_5;
            var val_6;
            Sound val_1 = this.GetSoundByName(name:  clip);
            if(this == 0)
            {
                    return;
            }
            
            val_5 = 536883829;
            if(((mem[536884016] & true) == 0) && (mem[536883945] == 0))
            {
                    val_5 = 536883829;
            }
            
            if((mem[536883921].Contains(item:  clip)) == true)
            {
                    return;
            }
            
            if(this.mixerAudioManager.masterMixer == 0)
            {
                    return;
            }
            
            val_6 = 536883829;
            if(((mem[536884016] & true) == 0) && (mem[536883945] == 0))
            {
                    val_6 = 536883829;
            }
            
            mem[536883921].Add(item:  clip);
            float val_3 = this.sfx.volume;
            if(this.sfx != 0)
            {
                    this.sfx.volume = this.sfx;
            }
            
            string val_4 = Berry.Utils.Utils.GetRandom<System.String>(collection:  this.mixerAudioManager);
            this.sfx.PlayOneShot(clip:  this.mixerAudioManager);
        }
        public void StopShot()
        {
            this.sfx.Stop();
        }
        public void SetMusic(bool value)
        {
            object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
            -1073708883.Music = value;
            if(value == true)
            {
                    0f = 1f;
            }
            
            this.SetMusicVolume(value:  1f);
        }
        public void SetMusicVolume(float value)
        {
            object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
            -1073708883.MusicVolume = value;
            this.mixerAudioManager.ChangeMusicVolume(value:  value);
        }
        public void SetSoundFX(bool value)
        {
            object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
            -1073708883.SoundFX = value;
            if(value == true)
            {
                    0f = 1f;
            }
            
            this.SetSoundFXVolume(value:  1f);
        }
        public void SetSoundFXVolume(float value)
        {
            object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
            -1073708883.SoundFXVolume = value;
            this.mixerAudioManager.ChangeSFXVolume(value:  value);
        }
        public void Mute(bool value)
        {
            object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
            -1073708883.MuteAll = value;
            if(value == true)
            {
                    1f = 0;
            }
            
            this.SetMasterWithVolume(value:  0f);
        }
        public void SetMasterWithVolume(float value)
        {
            object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
            -1073708883.MasterVolume = value;
            this.mixerAudioManager.ChangeMasterVolume(value:  value);
        }
        public void ChangeMasterVolume(float value)
        {
            this.mixerAudioManager.ChangeMasterVolume(value:  value);
        }
        public void ChangeMusicVolume(float value)
        {
            this.mixerAudioManager.ChangeMusicVolume(value:  value);
        }
        public void ChangeSFXVolume(float value)
        {
            this.mixerAudioManager.ChangeSFXVolume(value:  value);
        }
        public AudioManager()
        {
            536878567 = new System.Collections.Generic.List<Page>();
            this.tracks = 536878567;
            536878571 = new System.Collections.Generic.List<Page>();
            this.sounds = 536878571;
        }
        private static AudioManager()
        {
            536878341 = new System.Collections.Generic.List<Page>();
            mem2[0] = 536878341;
            mem2[0] = 1028443341;
        }
    
    }

}
