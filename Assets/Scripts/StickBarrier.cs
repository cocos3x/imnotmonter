using UnityEngine;
public class StickBarrier : MonoBehaviour
{
    // Fields
    private PlatformMoveController platformMoveController;
    private UnityEngine.SpriteRenderer mainSpriteRender;
    private UnityEngine.SpriteRenderer fakeSpriterender;
    private DG.Tweening.DOTweenAnimation[] fakeDoAnim;
    public bool canApartTotalStick;
    private bool isMove;
    
    // Methods
    private void Start()
    {
        this.SetSizeForFakeSpriteRender();
        this.mainSpriteRender.enabled = false;
        UnityEngine.GameObject val_1 = this.fakeSpriterender.gameObject;
        this.fakeSpriterender.SetActive(value:  true);
    }
    public void MoveActivated()
    {
        if(this.isMove != false)
        {
                return;
        }
        
        this.isMove = true;
        this.platformMoveController.MoveByScriptActivated();
        if(this.canApartTotalStick != false)
        {
                WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073700989.ApartTotalStickBarrie();
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610604363, volume:  null);
    }
    public float AngleOfPathMove()
    {
        float val_2;
        float val_3;
        bool val_11;
        float val_12;
        UnityEngine.Vector3 val_1 = GetPositionOfIndex(index:  this.platformMoveController);
        float val_11 = val_2;
        float val_12 = val_3;
        UnityEngine.Vector3 val_4 = GetPositionOfIndex(index:  this.platformMoveController);
        val_11 = val_2 - val_11;
        val_12 = val_3 - val_12;
        UnityEngine.Transform val_5 = this.transform;
        UnityEngine.Vector3 val_6 = up;
        val_3 = val_12;
        val_2 = val_11;
        float val_7 = val_2.sqrMagnitude;
        float val_8 = -val_2.sqrMagnitude;
        if(mem[536890411] >= _TYPE_MAX_)
        {
                float val_14 = 650800524 * 650800536;
        }
        
        if(mem[536890411] >= 0)
        {
                float val_13 = -val_3;
            val_13 = val_3 * val_13;
            val_14 = val_13 / val_14;
            val_11 = mem[536890482];
            if((val_11 & true) == 0)
        {
                val_11 = mem[536890411];
        }
        
            val_12 = (UnityEngine.Mathf.Clamp(value:  val_14, min:  val_6.y, max:  -val_2)) * 57.29578f;
            return val_12;
        }
        
        val_12 = 0f;
        return val_12;
    }
    private void SetSizeForFakeSpriteRender()
    {
        UnityEngine.Vector2 val_1 = size;
        this.fakeSpriterender.size = new UnityEngine.Vector2() {x = R5, y = R6};
    }
    public void BarrieTarget()
    {
        var val_1;
        if(this.isMove == true)
        {
                return;
        }
        
        val_1 = 0;
        goto label_0;
        label_4:
        val_1 = 1;
        label_0:
        if(val_1 < 1152921506740115472)
        {
            goto label_4;
        }
    
    }
    public void BarrieNotTarget()
    {
        goto label_0;
        label_4:
        0 = 1;
        label_0:
        if(0 < 1152921506740115472)
        {
            goto label_4;
        }
    
    }
    public StickBarrier()
    {
        this.canApartTotalStick = true;
    }

}
