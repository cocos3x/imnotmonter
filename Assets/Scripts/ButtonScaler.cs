using UnityEngine;
public class ButtonScaler : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
    // Fields
    public UnityEngine.Vector2 startScale;
    public UnityEngine.Vector2 endScale;
    private bool useAudio;
    
    // Methods
    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
    {
        UnityEngine.Transform val_1 = this.transform;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  575918224, endValue:  new UnityEngine.Vector3() {x = this.endScale, z = 0f}, duration:  null);
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  575918224, ease:  1);
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  575918224, isIndependentUpdate:  true);
        if(this.useAudio == false)
        {
                return;
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609857, volume:  null);
    }
    public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
    {
        UnityEngine.Transform val_1 = this.transform;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  576038416, endValue:  new UnityEngine.Vector3() {x = this.startScale, z = 0f}, duration:  null);
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  576038416, ease:  1);
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  576038416, isIndependentUpdate:  true);
    }
    public ButtonScaler()
    {
        this.useAudio = true;
    }

}
