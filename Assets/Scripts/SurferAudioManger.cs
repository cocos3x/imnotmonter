using UnityEngine;
public class SurferAudioManger : SingletonMonoBehaviour<SurferAudioManger>
{
    // Fields
    private UnityEngine.AudioSource audio;
    private bool HasPlay;
    
    // Methods
    public void CheckPlay()
    {
        if(this.HasPlay == true)
        {
                return;
        }
        
        this.Play();
    }
    public void CheckPasue()
    {
        if(this.HasPlay == false)
        {
                return;
        }
        
        this.Pause();
    }
    private void Play()
    {
        this.audio.Play();
        this.HasPlay = true;
    }
    public void Pause()
    {
        this.audio.Pause();
        this.HasPlay = false;
    }
    public SurferAudioManger()
    {
    
    }

}
