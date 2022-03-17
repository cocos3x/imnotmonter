using UnityEngine;
public class SplashSceneManager : SingletonMonoBehaviour<SplashSceneManager>
{
    // Fields
    public UnityEngine.GameObject logo;
    
    // Properties
    private bool FirstOpen { get; set; }
    
    // Methods
    private void Start()
    {
        UnityEngine.Application.targetFrameRate = 60;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.GameMode = 0;
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
            -1073701113.SetMasterWithVolume(value:  -1073708883.MasterVolume);
            WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            object val_7 = AFramework.ManualSingletonMono<System.Object>.I;
            -1073701113.SetMusicVolume(value:  -1073708883.MusicVolume);
            WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            object val_10 = AFramework.ManualSingletonMono<System.Object>.I;
            -1073701113.SetSoundFXVolume(value:  -1073708883.SoundFXVolume);
        }
        
        System.Collections.IEnumerator val_12 = this.LoadSceneStart();
        UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  572480400);
    }
    public void CheckRetry()
    {
        System.Collections.IEnumerator val_1 = this.DelayCheckRetry();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  572592400);
    }
    private System.Collections.IEnumerator DelayCheckRetry()
    {
        536901439 = new SplashSceneManager.<DelayCheckRetry>d__3(<>1__state:  0);
        mem[536901455] = this;
    }
    private System.Collections.IEnumerator LoadSceneStart()
    {
        536901441 = new SplashSceneManager.<LoadSceneStart>d__4(<>1__state:  0);
        mem[536901457] = this;
    }
    private bool get_FirstOpen()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -1610600533, defaultValue:  1);
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    private void set_FirstOpen(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1610600533, value:  value);
    }
    private void LoadLevelStart()
    {
        this.logo.SetActive(value:  false);
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536882991 = new System.Action(object:  573156496, method:  new IntPtr(1610677895));
        bool val_3 = -1073701121.CheckATTReadly(callBack:  536882991);
        if(val_3 != false)
        {
                return;
        }
        
        val_3.LoadScence();
    }
    private void LoadScence()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((-1073708883.ShowCompletedStory) != false)
        {
                -1073700919.LoadSceneHome();
        }
        else
        {
                -1073700919.LoadSceneRopeRescue();
        }
        
        this.FirstOpen = false;
    }
    private void UnlockAllMode()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.RopeRescuelUnlocked = true;
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.PinPullUnlocked = true;
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.CutRescuelUnlocked = true;
    }
    private void UnlimitedResource()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.Coin = 1000000000;
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.Diamond = 1000000000;
    }
    public SplashSceneManager()
    {
    
    }

}
