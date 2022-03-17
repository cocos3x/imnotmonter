using UnityEngine;
public class GUIAnch : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject Rope;
    private WrappingRopeLibrary.Scripts.Rope _ropeEntity;
    private bool[] flags;
    
    // Methods
    private void Start()
    {
        Weight val_1 = this.Rope.GetComponent<Weight>();
        this._ropeEntity = this.Rope;
    }
    private void Update()
    {
        this.flags[0] = false;
        this.flags[0] = false;
    }
    private void FixedUpdate()
    {
        var val_5;
        if(this._ropeEntity == 0)
        {
                return;
        }
        
        if((R4 + 20 + 16) != 0)
        {
                float val_2 = UnityEngine.Time.fixedDeltaTime;
            val_5 = 0;
        }
        else
        {
                if((R4 + 20 + 17) == 0)
        {
                return;
        }
        
            val_5 = 2147483648;
        }
        
        R4 + 16.CutRope(length:  UnityEngine.Time.fixedDeltaTime, dir:  -2147483648);
    }
    private void OnGUI()
    {
        this.TestControls();
    }
    private void TestControls()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_11;
        if(this._ropeEntity == 0)
        {
                return;
        }
        
        UnityEngine.Rect val_2 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_YMin, m_Width = val_2.m_Width, m_Height = val_2.m_XMin});
        UnityEngine.GUIStyle val_3 = UnityEngine.GUIStyle.op_Implicit(str:  -1610601557);
        val_7 = mem[mem[3221271779] + 186];
        val_7 = mem[3221271779] + 186;
        if(val_7 == 1)
        {
                val_7 = mem[mem[3221271779] + 186];
            val_7 = mem[3221271779] + 186;
        }
        
        UnityEngine.GUILayout.BeginVertical(style:  -1610601557, options:  mem[3221271779] + 92);
        UnityEngine.GUIStyle val_4 = UnityEngine.GUIStyle.op_Implicit(str:  -1610601557);
        val_8 = mem[mem[3221271779] + 186];
        val_8 = mem[3221271779] + 186;
        if(val_8 == 1)
        {
                val_8 = mem[mem[3221271779] + 186];
            val_8 = mem[3221271779] + 186;
        }
        
        UnityEngine.GUILayout.BeginHorizontal(style:  -1610601557, options:  mem[3221271779] + 92);
        val_9 = mem[mem[3221271779] + 186];
        val_9 = mem[3221271779] + 186;
        if(val_9 == 1)
        {
                val_9 = mem[mem[3221271779] + 186];
            val_9 = mem[3221271779] + 186;
        }
        
        bool val_5 = UnityEngine.GUILayout.RepeatButton(text:  -1610608975, options:  mem[3221271779] + 92);
        if(val_5 != false)
        {
                if(val_5 != false)
        {
            
        }
        else
        {
            
        }
        
            mem2[0] = 1;
            this.flags[0] = false;
        }
        
        val_11 = mem[mem[3221271779] + 186];
        val_11 = mem[3221271779] + 186;
        if(val_11 == 1)
        {
                val_11 = mem[mem[3221271779] + 186];
            val_11 = mem[3221271779] + 186;
        }
        
        if((UnityEngine.GUILayout.RepeatButton(text:  -1610608339, options:  mem[3221271779] + 92)) != false)
        {
                this.flags[0] = false;
            if(false >= 2)
        {
            
        }
        else
        {
            
        }
        
            mem2[0] = 1;
        }
        
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.EndVertical();
        UnityEngine.GUILayout.EndArea();
    }
    private float GetRopeLength()
    {
        float val_3;
        float val_4;
        float val_5;
        UnityEngine.Transform val_1 = this._ropeEntity.transform;
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Transform val_6 = this._ropeEntity.transform;
        UnityEngine.Vector3 val_7 = position;
        float val_9 = val_3;
        float val_10 = val_4;
        float val_11 = val_5;
        val_9 = val_3 - val_9;
        val_10 = val_4 - val_10;
        val_11 = val_5 - val_11;
        return (float)val_9.magnitude;
    }
    public GUIAnch()
    {
        this.flags = 536881727;
    }

}
