using UnityEngine;
public class MovementManager : Singleton<MovementManager>
{
    // Fields
    public const float XSPEED = 0.4;
    public const float YSPEED = 0.4;
    public const float MAXXDERIVATIVE = 2;
    public const float MAXYDERIVATIVE = 2;
    private UnityEngine.Vector2 _currentPosition;
    
    // Properties
    public UnityEngine.Vector2 CurrentPosition { get; }
    
    // Methods
    protected MovementManager()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this._currentPosition = new UnityEngine.Vector2();
        mem[1152921509776376224] = ???;
        if((mem[536879702] & true) != 0)
        {
                return;
        }
        
        if(mem[536879631] != 0)
        {
                return;
        }
    
    }
    public UnityEngine.Vector2 get_CurrentPosition()
    {
        this = R1 + 12;
        mem[1152921509776488212] = R1 + 16;
        return new UnityEngine.Vector2();
    }
    private void Start()
    {
    
    }
    private void FixedUpdate()
    {
        float val_1 = UnityEngine.Input.GetAxis(axisName:  -1610606233);
        this._currentPosition = this._currentPosition;
        float val_2 = UnityEngine.Input.GetAxis(axisName:  -1610606231);
        mem[1152921509776712224] = ;
        this._currentPosition = -2f;
        mem[1152921509776712224] = -2f;
    }

}
