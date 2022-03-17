using UnityEngine;
public class FallObstaclePinPullController : MonoBehaviour
{
    // Fields
    private FallObstaclePinPullController.TypeObstaceFall typeObstacleFall;
    private UnityEngine.Rigidbody2D myBody;
    private bool isFalling;
    
    // Methods
    private void FixedUpdate()
    {
        this.CheckFalling();
    }
    private void CheckFalling()
    {
        UnityEngine.Vector2 val_1 = velocity;
        if(this.myBody <= 0)
        {
                0 = 1;
        }
        
        this.isFalling = true;
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if(this.isFalling == false)
        {
                return;
        }
        
        if((collision.CompareTag(tag:  -1610608497)) != false)
        {
                UnityEngine.Transform val_2 = collision.GetComponent<UnityEngine.Transform>();
            collision.Dead();
            if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610608667, volume:  null);
        }
        
        }
        
        if((collision.CompareTag(tag:  -1610605337)) == false)
        {
                return;
        }
        
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266323].Dead();
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701037.Lose();
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610608667, volume:  null);
    }
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if(this.isFalling == false)
        {
                return;
        }
        
        if(this.typeObstacleFall != 1)
        {
                return;
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609943, volume:  null);
    }
    public FallObstaclePinPullController()
    {
    
    }

}
