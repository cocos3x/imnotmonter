using UnityEngine;
public class ItemAudio : MonoBehaviour
{
    // Fields
    public static bool canPlaySFX;
    private UnityEngine.AudioSource audioSource;
    private bool canPlaySound;
    
    // Methods
    private void Awake()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  750510096, method:  new IntPtr(1610680797));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  750510096, eventID:  15, callback:  536873423);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  750510096, method:  new IntPtr(1610680799));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  750510096, eventID:  16, callback:  536873423);
    }
    private void OnEnable()
    {
        this.CheckSFX();
    }
    public void PlaySFX(string name)
    {
        if(this.canPlaySound == false)
        {
                return;
        }
        
        if(mem[536889365] == 0)
        {
                return;
        }
        
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  name, volume:  null);
    }
    public void CheckSFX()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        bool val_2 = -1073708883.SoundFX;
        if(val_2 == true)
        {
                val_2 = this.canPlaySound;
            goto label_2;
        }
        
        this.audioSource.Stop();
        return;
        label_2:
        this.audioSource.Play();
    }
    public void PlaySound()
    {
        if(this.canPlaySound == false)
        {
                return;
        }
        
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.SoundFX) == false)
        {
                return;
        }
        
        R4 + 12.Play();
    }
    public void StopSound()
    {
        this.audioSource.Stop();
    }
    public ItemAudio()
    {
        this.canPlaySound = true;
    }
    private void <Awake>b__3_0(UnityEngine.Component sender, object param)
    {
        this.CheckSFX();
    }
    private void <Awake>b__3_1(UnityEngine.Component sender, object param)
    {
        this.CheckSFX();
    }

}
