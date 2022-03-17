using UnityEngine;
public class InputController : MonoBehaviour
{
    // Fields
    private UnityEngine.Ray _ray;
    private UnityEngine.Plane _xy;
    private UnityEngine.Camera _cam;
    private float _distance;
    
    // Properties
    public int IndexMouseTarget { get; }
    
    // Methods
    private void Start()
    {
        this.Init();
    }
    private void Init()
    {
        UnityEngine.Camera val_1 = UnityEngine.Camera.main;
        this._cam = 0;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.forward;
        UnityEngine.Plane val_3 = new UnityEngine.Plane(inNormal:  new UnityEngine.Vector3(), inPoint:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
    }
    public UnityEngine.Vector3 GetMousePosition(int indexMouse = 0)
    {
        float val_7;
        float val_8;
        var val_10;
        var val_11 = R2;
        if(UnityEngine.Input.touchCount < (val_11 + 1))
        {
                this = 3267887104;
            mem[1152921509588503572] = 1120403456;
            mem[1152921509588503576] = 1120403456;
            return new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        }
        
        UnityEngine.Touch[] val_3 = UnityEngine.Input.touches;
        var val_4 = val_11 + (val_11 << 4);
        val_11 = 0;
        val_4 = 0 + (val_4 << 2);
        var val_5 = val_4 + 16;
        UnityEngine.Vector2 val_6 = position;
        UnityEngine.Vector3 val_9 = GetWorldPositionOnPlane(screenPosition:  new UnityEngine.Vector3() {x = indexMouse, y = val_7, z = val_8});
        mem[1152921509588503576] = val_10;
        this = val_7;
        return new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
    }
    public int get_IndexMouseTarget()
    {
        if(UnityEngine.Input.touchCount < 1)
        {
                return (int)0;
        }
        
        0 = UnityEngine.Input.touchCount - 1;
        return (int)0;
    }
    public UnityEngine.Vector3 GetWorldPositionOnPlane(UnityEngine.Vector3 screenPosition)
    {
        InputController val_9;
        var val_10;
        UnityEngine.Ray val_2 = ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = screenPosition.x + 52, y = screenPosition.y, z = screenPosition.z});
        mem2[0] = ???;
        var val_3 = (val_2.m_Direction.z + 12) + 12;
        bool val_7 = (val_2.m_Direction.z + 12) + 24.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3(), m_Direction = new UnityEngine.Vector3()}, enter: out  (val_2.m_Direction.z + 12) + 44);
        UnityEngine.Vector3 val_8 = GetPoint(distance:  null);
        mem[1152921509588727576] = val_10;
        this = val_9;
        return new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
    }
    public bool IsMouseDown()
    {
        var val_9;
        if(UnityEngine.Input.touchCount >= 1)
        {
                UnityEngine.Touch val_2 = UnityEngine.Input.GetTouch(index:  687013128);
            if((val_2.m_Radius + 72) != 0f)
        {
                return (bool)val_9;
        }
        
            float val_4 = val_2.m_Radius + 72;
            val_9 = 0 ^ 1;
            return (bool)val_9;
        }
        
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
        {
                UnityEngine.EventSystems.EventSystem val_6 = UnityEngine.EventSystems.EventSystem.current;
            if(0.IsPointerOverGameObject() == true)
        {
                val_9 = 0;
        }
        
            return (bool)val_9;
        }
        
        val_9 = 0;
        return (bool)val_9;
    }
    public bool IsMouseDown2()
    {
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
        {
                return true;
        }
        
        if(UnityEngine.Input.touchCount < 1)
        {
                return UnityEngine.Input.GetMouseButtonDown(button:  0);
        }
        
        UnityEngine.Touch[] val_3 = UnityEngine.Input.touches;
        var val_4 = 0 + 16;
        UnityEngine.TouchPhase val_5 = val_4.phase;
        if(val_4 == 0)
        {
                return true;
        }
        
        return UnityEngine.Input.GetMouseButtonDown(button:  0);
    }
    public bool IsMouseUp()
    {
        var val_11;
        if(UnityEngine.Input.touchCount >= 1)
        {
                UnityEngine.Touch[] val_2 = UnityEngine.Input.touches;
            var val_3 = 0 + 16;
            val_11 = 0;
            UnityEngine.TouchPhase val_4 = val_3.phase;
            if(val_3 != 3)
        {
                return (bool)val_11;
        }
        
            UnityEngine.EventSystems.EventSystem val_5 = UnityEngine.EventSystems.EventSystem.current;
            UnityEngine.Touch[] val_6 = UnityEngine.Input.touches;
            bool val_9 = 0.IsPointerOverGameObject(pointerId:  0 + 16.fingerId);
            val_9 = val_9 ^ 1;
            return (bool)val_9;
        }
        
        if((UnityEngine.Input.GetMouseButtonUp(button:  0)) != false)
        {
                UnityEngine.EventSystems.EventSystem val_11 = UnityEngine.EventSystems.EventSystem.current;
            if(0.IsPointerOverGameObject() == true)
        {
                val_11 = 0;
        }
        
            return (bool)val_11;
        }
        
        val_11 = 0;
        return (bool)val_11;
    }
    public bool IsMouseUp2()
    {
        if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == true)
        {
                return (bool)UnityEngine.Input.GetMouseButtonUp(button:  0);
        }
        
        if(UnityEngine.Input.touchCount < 1)
        {
                return (bool)UnityEngine.Input.GetMouseButtonUp(button:  0);
        }
        
        UnityEngine.Touch val_3 = UnityEngine.Input.GetTouch(index:  687349136);
        var val_6 = val_3.m_Radius + 72;
        val_6 = val_6 - 3;
        1 = val_6 >> 5;
        return (bool)UnityEngine.Input.GetMouseButtonUp(button:  0);
    }
    public bool IsMousePress()
    {
        var val_13;
        if(UnityEngine.Input.touchCount >= 1)
        {
                UnityEngine.Touch[] val_2 = UnityEngine.Input.touches;
            var val_3 = 0 + 16;
            UnityEngine.TouchPhase val_4 = val_3.phase;
            if(val_3 != 1)
        {
                UnityEngine.Touch[] val_5 = UnityEngine.Input.touches;
            var val_6 = 0 + 16;
            val_13 = 0;
            UnityEngine.TouchPhase val_7 = val_6.phase;
            if(val_6 != 2)
        {
                return (bool)val_13;
        }
        
        }
        
            UnityEngine.EventSystems.EventSystem val_8 = UnityEngine.EventSystems.EventSystem.current;
            UnityEngine.Touch[] val_9 = UnityEngine.Input.touches;
            bool val_12 = 0.IsPointerOverGameObject(pointerId:  0 + 16.fingerId);
            val_12 = val_12 ^ 1;
            return (bool)val_12;
        }
        
        if((UnityEngine.Input.GetMouseButton(button:  0)) != false)
        {
                UnityEngine.EventSystems.EventSystem val_14 = UnityEngine.EventSystems.EventSystem.current;
            if(0.IsPointerOverGameObject() == true)
        {
                val_13 = 0;
        }
        
            return (bool)val_13;
        }
        
        val_13 = 0;
        return (bool)val_13;
    }
    public bool IsMousePress2()
    {
        var val_7 = 1;
        if((UnityEngine.Input.GetMouseButton(button:  0)) == true)
        {
                return (bool)val_7;
        }
        
        if(UnityEngine.Input.touchCount >= 1)
        {
                UnityEngine.Touch val_3 = UnityEngine.Input.GetTouch(index:  687573128);
            if((val_3.m_Radius + 72) == (1.401298E-45f))
        {
                return (bool)val_7;
        }
        
            var val_5 = 0 + 16;
            val_5 = val_5 - 2;
            val_7 = val_5 >> 5;
            return (bool)val_7;
        }
        
        val_7 = UnityEngine.Input.GetMouseButton(button:  0);
        return (bool)val_7;
    }
    public InputController()
    {
    
    }

}
