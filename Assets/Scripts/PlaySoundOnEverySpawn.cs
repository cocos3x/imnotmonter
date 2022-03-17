using UnityEngine;
public class PlaySoundOnEverySpawn : MonoBehaviour
{
    // Fields
    public UnityEngine.AudioSource sfx;
    
    // Methods
    public void PlaySound()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.sfx)) == false)
        {
                return;
        }
        
        R4 + 12.Play();
    }
    public PlaySoundOnEverySpawn()
    {
    
    }

}
