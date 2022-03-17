using UnityEngine;
public class HandDoorItem : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform doorTransform;
    private UnityEngine.Transform targetTransform;
    private UnityEngine.Vector2 startTransform;
    private float moveSpeed;
    
    // Methods
    private void Start()
    {
        UnityEngine.Vector3 val_1 = position;
        this.startTransform = new UnityEngine.Vector2();
        mem[1152921509582580136] = ???;
    }
    public void OpenDoor()
    {
        UnityEngine.Debug.Log(message:  -1610605589);
        UnityEngine.Vector3 val_1 = position;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.doorTransform, endValue:  new UnityEngine.Vector3(), duration:  this.moveSpeed, snapping:  this.moveSpeed);
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610605583, volume:  this.moveSpeed);
    }
    public void CloseDoor()
    {
        UnityEngine.Debug.Log(message:  -1610609327);
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.doorTransform, endValue:  new UnityEngine.Vector3() {x = this.startTransform, z = 0f}, duration:  this.moveSpeed, snapping:  this.moveSpeed);
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610605583, volume:  this.moveSpeed);
    }
    public HandDoorItem()
    {
    
    }

}
