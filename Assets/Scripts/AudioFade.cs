using UnityEngine;
public class AudioFade
{
    // Methods
    public static System.Collections.IEnumerator FadeOut(UnityEngine.AudioSource audioSource, float fadingTime, System.Func<float, float, float, float> Interpolate)
    {
        AudioFade.<FadeOut>d__0 val_1 = 536898047;
        val_1 = new AudioFade.<FadeOut>d__0(<>1__state:  0);
        if(val_1 != 0)
        {
                22998973 = val_1;
            mem[536898063] = audioSource;
            mem[536898067] = Interpolate;
        }
        else
        {
                mem[16] = audioSource;
            mem[20] = Interpolate;
        }
        
        mem[536898071] = R2;
    }
    public static System.Collections.IEnumerator FadeIn(UnityEngine.AudioSource audioSource, float fadingTime, System.Func<float, float, float, float> Interpolate)
    {
        AudioFade.<FadeIn>d__1 val_1 = 536898045;
        val_1 = new AudioFade.<FadeIn>d__1(<>1__state:  0);
        if(val_1 != 0)
        {
                22998974 = val_1;
            mem[536898061] = audioSource;
            mem[536898065] = Interpolate;
        }
        else
        {
                mem[16] = audioSource;
            mem[20] = Interpolate;
        }
        
        mem[536898069] = R2;
    }
    public AudioFade()
    {
    
    }

}
