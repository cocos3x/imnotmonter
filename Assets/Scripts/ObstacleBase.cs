using UnityEngine;
public abstract class ObstacleBase : MonoBehaviour
{
    // Fields
    public ObstacleBase.TypeOfObstacle typeOfObstacle;
    protected UnityEngine.SpriteRenderer spriteRenderer;
    protected UnityEngine.Rigidbody2D myBody;
    protected bool isCheckCollider;
    protected bool isFalling;
    protected bool isMoving;
    protected bool isBreakAnotherObstacle;
    protected bool isBury;
    protected float gravityScale;
    protected float mass;
    protected float currentMass;
    protected float maxTimeDestroyWithLaser;
    protected float currentTimeDestroyWithLaser;
    protected bool isCollisionLaser;
    
    // Methods
    protected virtual void Awake()
    {
        goto typeof(ObstacleBase).__il2cppRuntimeField_EC;
    }
    protected virtual void Update()
    {
        this.CheckFalling();
    }
    protected virtual void SetUpStart()
    {
        float val_1 = this.myBody.gravityScale;
        this.gravityScale = this.myBody;
        float val_2 = this.myBody.mass;
        this.mass = this.myBody;
        UnityEngine.GameObject val_3 = this.myBody.gameObject;
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536900137];
        this.name = 536900137;
        this.isCheckCollider = true;
    }
    public abstract void DestroyWithLaser(); // 0
    public abstract void FallWithHang(); // 0
    public abstract void DestroyObject(); // 0
    protected void CheckFalling()
    {
        var val_2;
        bool val_7;
        val_7 = false;
        UnityEngine.Vector2 val_1 = velocity;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        var val_7 = val_2;
        val_7 = val_2 - val_7;
        double val_4 = val_7 * val_7;
        val_3.x = val_3.x + val_3.y;
        if(this.myBody < 0)
        {
            goto label_1;
        }
        
        this.isMoving = true;
        val_7 = false;
        UnityEngine.Vector2 val_5 = velocity;
        if(this.myBody <= 0)
        {
            goto label_3;
        }
        
        this.isFalling = val_7;
        return;
        label_1:
        this.isFalling = val_7;
        this.isMoving = false;
        return;
        label_3:
        this.isFalling = true;
    }
    public void ForceWithDirection(UnityEngine.Vector2 posCollision, UnityEngine.Vector3 direction, float forceValue)
    {
        var val_2;
        if(this.isBury == false)
        {
                this.isBury = this.isFalling;
            goto label_0;
        }
        
        return;
        label_0:
        this.currentMass = this.mass;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.myBody.velocity = new UnityEngine.Vector2() {x = R7, y = R8};
        this.myBody.angularVelocity = val_1.x;
        this.myBody.bodyType = 0;
        float val_3 = direction.x;
        float val_4 = direction.y;
        val_3 = val_3 * val_2;
        val_4 = val_4 * val_2;
        val_3 = val_3 * this.currentMass;
        val_4 = val_4 * this.currentMass;
        this.myBody.AddForce(force:  new UnityEngine.Vector2() {x = val_3, y = val_4}, mode:  1);
    }
    public void ForceWithTNTDirection(UnityEngine.Vector3 direction, float forceValue)
    {
        var val_2;
        if(this.isBury == true)
        {
                return;
        }
        
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.myBody.velocity = new UnityEngine.Vector2() {x = R5, y = R6};
        this.myBody.angularVelocity = val_1.x;
        this.currentMass = this.mass;
        this.myBody.bodyType = 0;
        float val_3 = direction.x;
        float val_4 = direction.y;
        val_3 = val_3 * val_2;
        val_4 = val_4 * val_2;
        val_3 = val_3 * this.currentMass;
        val_4 = val_4 * this.currentMass;
        this.myBody.AddForce(force:  new UnityEngine.Vector2() {x = val_3, y = val_4}, mode:  1);
    }
    public void SetCheckCollider(bool set)
    {
        this.isCheckCollider = set;
    }
    protected ObstacleBase()
    {
    
    }

}
