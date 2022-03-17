using UnityEngine;
public class RandomPositionMover : MonoBehaviour
{
    // Fields
    public float pickerInterval;
    public float radius;
    public UnityEngine.GameObject player;
    public UnityEngine.Vector2 randomPointInCircle;
    
    // Methods
    private void Start()
    {
        this.ScaleLaser();
    }
    public void ScaleLaser()
    {
        UnityEngine.Transform val_1 = this.transform;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScaleY(target:  436292048, endValue:  null, duration:  null);
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  436292048, loops:  0, loopType:  1);
    }
    public RandomPositionMover()
    {
    
    }

}
