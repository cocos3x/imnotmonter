using UnityEngine;
public class MixerAudioManager : MonoBehaviour
{
    // Fields
    public UnityEngine.Audio.AudioMixer masterMixer;
    private string masterMixerGroupName;
    private string musicMixerGroupName;
    private string soundFXMixerGroupName;
    
    // Methods
    private void Start()
    {
        this.Invoke(methodName:  -1610602595, time:  null);
    }
    private void WaitSetSound()
    {
        if((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) == false)
        {
                return;
        }
        
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        this.ChangeMasterVolume(value:  -1073708883.MasterVolume);
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        this.ChangeMusicVolume(value:  -1073708883.MusicVolume);
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        this.ChangeSFXVolume(value:  -1073708883.SoundFXVolume);
    }
    public void ChangeMasterVolume(float value)
    {
        if()
        {
                0.0001f = 1f;
        }
        
        bool val_1 = this.masterMixer.SetFloat(name:  this.masterMixerGroupName, value:  20f);
    }
    public void ChangeMusicVolume(float value)
    {
        if()
        {
                0.0001f = 1f;
        }
        
        bool val_1 = this.masterMixer.SetFloat(name:  this.musicMixerGroupName, value:  20f);
    }
    public void ChangeSFXVolume(float value)
    {
        if()
        {
                0.0001f = 1f;
        }
        
        bool val_1 = this.masterMixer.SetFloat(name:  this.soundFXMixerGroupName, value:  20f);
    }
    public MixerAudioManager()
    {
        this.masterMixerGroupName = -1610606447;
        this.musicMixerGroupName = -1610606217;
        this.soundFXMixerGroupName = -1610604475;
    }

}
