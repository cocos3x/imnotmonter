using UnityEngine;
public class TransitionFX : SingletonMonoBehaviour<TransitionFX>
{
    // Fields
    private UnityEngine.Animator animator;
    private System.Action endStartFadeAction;
    private System.Action endEndFadeAction;
    public static bool fadeDone;
    
    // Methods
    public void StartFade(System.Action action)
    {
        mem2[0] = 0;
        if(action != 0)
        {
                this.endStartFadeAction = action;
        }
        
        this.animator.Play(stateName:  -1610603331, layer:  0, normalizedTime:  null);
    }
    public void EndFade(System.Action action)
    {
        if(action != 0)
        {
                this.endEndFadeAction = action;
        }
        
        this.animator.Play(stateName:  -1610603329, layer:  0, normalizedTime:  null);
    }
    public void EndStartFadeAction()
    {
        if(this.endStartFadeAction != 0)
        {
                this.endStartFadeAction.Invoke();
        }
        
        this.endStartFadeAction = 0;
    }
    public void EndFadeAction()
    {
        mem2[0] = 1;
        if(this.endEndFadeAction != 0)
        {
                this.endEndFadeAction.Invoke();
        }
        
        this.endEndFadeAction = 0;
    }
    public TransitionFX()
    {
    
    }

}
