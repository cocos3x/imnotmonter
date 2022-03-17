using UnityEngine;
public class SawController : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform sawTrans;
    private float speedRotate;
    private float direction;
    
    // Methods
    private void Update()
    {
        this.Rotate();
    }
    private void Rotate()
    {
        float val_2 = UnityEngine.Time.deltaTime;
        uint val_4 = 0;
        val_4 = (this.speedRotate * 0f) * val_4;
        this.sawTrans.Rotate(eulers:  new UnityEngine.Vector3() {z = this.speedRotate * val_4});
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        bool val_3 = collision.CompareTag(tag:  -1610605337);
        if((-1073701037.CanCheck()) != false)
        {
                if(val_3 != false)
        {
                WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266323].Dead();
            WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701037.Lose();
        }
        
            if((collision.CompareTag(tag:  -1610608497)) != false)
        {
                UnityEngine.Transform val_7 = collision.GetComponent<UnityEngine.Transform>();
            collision.Dead();
        }
        
            if((collision.CompareTag(tag:  -1610607699)) == false)
        {
                return;
        }
        
            WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead();
            WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701037.Lose();
            return;
        }
        
        if(val_3 != false)
        {
                WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266323].Dead();
        }
        
        if((collision.CompareTag(tag:  -1610608497)) != false)
        {
                UnityEngine.Transform val_13 = collision.GetComponent<UnityEngine.Transform>();
            collision.Dead();
        }
        
        if((collision.CompareTag(tag:  -1610607699)) == false)
        {
                return;
        }
        
        WorldTimeAPI val_15 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266327].Dead();
    }
    public SawController()
    {
        this.direction = 1f;
    }

}
