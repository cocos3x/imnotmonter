using UnityEngine;
public class CanvasFollowDevice : SingletonMonoBehaviour<CanvasFollowDevice>
{
    // Fields
    public float Aspect;
    public bool GizmosUpdate;
    public bool changeCamSize;
    public bool showDrawLine;
    public bool IsInvert;
    public float CurCamSize;
    public System.Collections.Generic.List<ResolutionInfor> Resolutions;
    private UnityEngine.UI.CanvasScaler _canvasScaler;
    private UnityEngine.Camera _cam;
    
    // Methods
    public override void Awake()
    {
        UnityEngine.Camera val_11;
        this.Awake();
        UnityEngine.GameObject val_1 = this.gameObject;
        Weight val_2 = this.GetComponent<Weight>();
        UnityEngine.Transform val_3 = this.GetComponent<UnityEngine.Transform>();
        this._canvasScaler = this;
        val_11 = this;
        if((UnityEngine.Object.op_Implicit(exists:  this._cam)) != false)
        {
                UnityEngine.Camera val_5 = UnityEngine.Camera.main;
            this._cam = 0;
            val_11 = this._cam;
            this.worldCamera = 0;
        }
        
        this.FixCamSizeFollowScreen();
        string val_7 = UnityEngine.Screen.width.ToString();
        string val_9 = UnityEngine.Screen.height.ToString();
        string val_10 = -1610604919(-1610604919) + 576602764 + -1610611739(-1610611739) + 576602764;
        UnityEngine.Debug.Log(message:  -1610604919);
    }
    private void FixCamSizeFollowScreen()
    {
        UnityEngine.Camera val_27;
        var val_28;
        float val_29;
        var val_30;
        if(576833296 != 0)
        {
                if(this.enabled == false)
        {
                return;
        }
        
        }
        
        if(this._cam == 0)
        {
                UnityEngine.Camera val_4 = UnityEngine.Camera.main;
            this._cam = 0;
        }
        
        if(this._canvasScaler == 0)
        {
                UnityEngine.Transform val_6 = this.GetComponent<UnityEngine.Transform>();
            this._canvasScaler = this;
        }
        
        val_27 = this._cam;
        var val_25 = mem[536891407];
        val_25 = val_25 & 512;
        if(this.IsInvert == false)
        {
            goto label_11;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_27)) == false)
        {
            goto label_19;
        }
        
        val_27 = this._cam;
        float val_8 = val_27.aspect;
        float val_26 = 1f;
        val_26 = val_26 / 0;
        this.Aspect = val_26;
        goto label_19;
        label_11:
        if((UnityEngine.Object.op_Implicit(exists:  val_27)) != false)
        {
                val_27 = this._cam;
            float val_10 = val_27.aspect;
            this.Aspect = 0f;
        }
        
        label_19:
        val_28 = 0;
        goto label_33;
        label_36:
        if(val_27 <= this._canvasScaler)
        {
                var val_27 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_27 = val_27 + (this._canvasScaler << 2);
        bool val_11 = UnityEngine.Mathf.Approximately(a:  val_10, b:  null);
        if(val_11 == true)
        {
            goto label_25;
        }
        
        if(val_11 <= this._canvasScaler)
        {
                var val_28 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_28 = val_28 + (this._canvasScaler << 2);
        if(((0 + (this._canvasScaler) << 2) + 16) <= 0)
        {
            goto label_29;
        }
        
        val_28 = this._canvasScaler + 1;
        if(val_28 <= val_28)
        {
                var val_29 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_29 = val_29 + (val_28 << 2);
        val_27 = mem[(0 + ((this._canvasScaler + 1)) << 2) + 16];
        val_27 = (0 + ((this._canvasScaler + 1)) << 2) + 16;
        if(val_27 >= 0)
        {
            goto label_33;
        }
        
        goto label_34;
        label_29:
        val_28 = this._canvasScaler + 1;
        label_33:
        val_28 = val_28 - 1;
        if(val_28 < val_28)
        {
            goto label_36;
        }
        
        return;
        label_25:
        if(val_11 <= this._canvasScaler)
        {
                var val_30 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_30 = val_30 + (this._canvasScaler << 2);
        this._canvasScaler.m_MatchWidthOrHeight = (0 + (this._canvasScaler) << 2) + 16 + 24;
        bool val_13 = UnityEngine.Object.op_Implicit(exists:  0);
        if(val_13 == true)
        {
                val_13 = this.changeCamSize;
        }
        
        if(val_13 == false)
        {
            goto label_95;
        }
        
        bool val_14 = this._cam.orthographic;
        val_30 = val_14;
        if(val_14 <= this._canvasScaler)
        {
                var val_31 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_31 = val_31 + (this._canvasScaler << 2);
        if(val_30 == false)
        {
            goto label_49;
        }
        
        if(this._cam != 0)
        {
            goto label_51;
        }
        
        goto label_51;
        label_34:
        if(this._canvasScaler <= this._canvasScaler)
        {
                var val_32 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_32 = val_32 + (this._canvasScaler << 2);
        if(val_32 <= this._canvasScaler)
        {
                var val_33 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_33 = val_33 + (this._canvasScaler << 2);
        if(val_33 <= val_28)
        {
                var val_34 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_34 = val_34 + (val_28 << 2);
        if(val_34 <= this._canvasScaler)
        {
                var val_35 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_35 = val_35 + (this._canvasScaler << 2);
        if(val_35 <= val_28)
        {
                var val_36 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_36 = val_36 + (val_28 << 2);
        val_30 = mem[(0 + ((this._canvasScaler + 1)) << 2) + 16];
        val_30 = (0 + ((this._canvasScaler + 1)) << 2) + 16;
        if(val_36 <= this._canvasScaler)
        {
                var val_37 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_37 = val_37 + (this._canvasScaler << 2);
        float val_15 = ((0 + ((this._canvasScaler + 1)) << 2) + 16 + 12) - ((0 + (this._canvasScaler) << 2) + 16 + 12);
        val_15 = (this.Aspect - ((0 + (this._canvasScaler) << 2) + 16 + 12)) / val_15;
        float val_38 = (0 + (this._canvasScaler) << 2) + 16 + 24;
        val_38 = ((0 + ((this._canvasScaler + 1)) << 2) + 16 + 24) - val_38;
        float val_17 = UnityEngine.Mathf.Clamp(value:  val_15, min:  null, max:  val_38);
        mem2[0] = (0 + (this._canvasScaler) << 2) + 16 + 24;
        bool val_18 = UnityEngine.Object.op_Implicit(exists:  0);
        if(val_18 == true)
        {
                val_18 = this.changeCamSize;
        }
        
        if((val_18 == false) || (this._cam.orthographic == false))
        {
            goto label_95;
        }
        
        if(this._cam <= this._canvasScaler)
        {
                var val_39 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_39 = val_39 + (this._canvasScaler << 2);
        if(val_39 <= this._canvasScaler)
        {
                var val_40 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_40 = val_40 + (this._canvasScaler << 2);
        if(val_40 <= val_28)
        {
                var val_41 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_41 = val_41 + (val_28 << 2);
        if(val_41 <= this._canvasScaler)
        {
                var val_42 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_42 = val_42 + (this._canvasScaler << 2);
        val_30 = mem[(0 + (this._canvasScaler) << 2) + 16];
        val_30 = (0 + (this._canvasScaler) << 2) + 16;
        if(val_42 <= val_28)
        {
                var val_43 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_43 = val_43 + (val_28 << 2);
        if(val_43 <= this._canvasScaler)
        {
                var val_44 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_44 = val_44 + (this._canvasScaler << 2);
        val_29 = (this.Aspect - ((0 + (this._canvasScaler) << 2) + 16 + 12)) / (((0 + ((this._canvasScaler + 1)) << 2) + 16 + 12) - ((0 + (this._canvasScaler) << 2) + 16 + 12));
        float val_22 = ((0 + ((this._canvasScaler + 1)) << 2) + 16 + 16) - ((0 + (this._canvasScaler) << 2) + 16 + 16);
        label_51:
        this._cam.orthographicSize = val_29;
        goto label_95;
        label_49:
        this._cam.fieldOfView = UnityEngine.Mathf.Clamp(value:  val_10, min:  null, max:  null);
        label_95:
        val_27 = this._cam;
        if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
        {
                return;
        }
        
        float val_24 = this._cam.orthographicSize;
        this.CurCamSize = 0f;
    }
    private void DrawResolution()
    {
        goto label_1;
        label_9:
        if(true <= R6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        float val_4 = -1.084397E-19f;
        if(0 <= R6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + val_4;
        float val_5 = static_value_0028000F;
        if(this.IsInvert == false)
        {
                1f / val_5 = val_5;
        }
        
        val_5 = val_4 * (1f / val_5);
        float val_2 = val_4 * 0.5f;
        val_5 = val_5 * 0.5f;
        this.DrawLine(width:  val_5, height:  null);
        4 = 5;
        label_1:
        if((4 - 4) < this)
        {
            goto label_9;
        }
    
    }
    private void DrawLine(float width, float height)
    {
        float val_3;
        float val_4;
        float val_5;
        float val_12;
        bool val_46;
        UnityEngine.Transform val_1 = this._cam.transform;
        UnityEngine.Vector3 val_2 = position;
        float val_48 = val_3;
        float val_47 = val_4;
        float val_46 = val_5;
        val_46 = val_46 + 0f;
        val_47 = val_47 + R2;
        val_48 = val_48 - R1;
        UnityEngine.Transform val_6 = this._cam.transform;
        UnityEngine.Vector3 val_7 = position;
        UnityEngine.Color val_8 = UnityEngine.Color.blue;
        val_46 = mem[536885944];
        if((val_46 & true) == 0)
        {
                val_46 = mem[536885873];
        }
        
        UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_48, y = val_47, z = val_46}, end:  new UnityEngine.Vector3() {x = val_3 + R1, y = val_4 + R2, z = val_5 + 0f}, color:  new UnityEngine.Color() {r = val_3, g = val_4, b = val_5, a = val_12});
        UnityEngine.Transform val_13 = this._cam.transform;
        UnityEngine.Vector3 val_14 = position;
        UnityEngine.Transform val_18 = this._cam.transform;
        UnityEngine.Vector3 val_19 = position;
        UnityEngine.Color val_20 = UnityEngine.Color.blue;
        UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_3 + R1, y = val_4 + R2, z = val_5 + 0f}, end:  new UnityEngine.Vector3() {x = val_3 + R1, y = val_4 - R2, z = val_5 + 0f}, color:  new UnityEngine.Color());
        UnityEngine.Transform val_24 = this._cam.transform;
        UnityEngine.Vector3 val_25 = position;
        UnityEngine.Transform val_29 = this._cam.transform;
        UnityEngine.Vector3 val_30 = position;
        UnityEngine.Color val_31 = UnityEngine.Color.blue;
        UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_3 + R1, y = val_4 - R2, z = val_5 + 0f}, end:  new UnityEngine.Vector3() {x = val_3 - R1, y = val_4 - R2, z = val_5 + 0f}, color:  new UnityEngine.Color());
        UnityEngine.Transform val_35 = this._cam.transform;
        UnityEngine.Vector3 val_36 = position;
        UnityEngine.Transform val_40 = this._cam.transform;
        UnityEngine.Vector3 val_41 = position;
        UnityEngine.Color val_42 = UnityEngine.Color.blue;
        UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_3 - R1, y = val_4 - R2, z = val_5 + 0f}, end:  new UnityEngine.Vector3() {x = val_3 - R1, y = val_4 + R2, z = val_5 + 0f}, color:  new UnityEngine.Color());
    }
    public void OrderResolutions()
    {
        var val_3;
        object val_4;
        System.Func<ResolutionInfor, System.Single> val_5;
        val_3 = 536898219;
        if(((mem[536898406] & true) == 0) && (mem[536898335] == 0))
        {
                val_3 = 536898219;
        }
        
        val_4 = mem[536898311];
        val_5 = mem[mem[536898311] + 4];
        val_5 = mem[536898311] + 4;
        if(val_5 == 0)
        {
                if(((mem[536898406] & true) == 0) && (mem[536898335] == 0))
        {
                val_4 = mem[536898311];
        }
        
            val_5 = 536875523;
            val_5 = new System.Func<ResolutionInfor, System.Single>(object:  val_4, method:  new IntPtr(1610677989));
            mem2[0] = val_5;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_2 = System.Linq.Enumerable.OrderBy<ResolutionInfor, System.Single>(source:  this.Resolutions, keySelector:  536875523);
    }
    public void _FixCamSizeFollowScreen()
    {
        this.FixCamSizeFollowScreen();
    }
    public CanvasFollowDevice()
    {
        this.GizmosUpdate = true;
        this.changeCamSize = true;
        536878249 = new System.Collections.Generic.List<Page>();
        ResolutionInfor val_2 = 536892867;
        val_2 = new ResolutionInfor();
        if(val_2 != 0)
        {
                mem[536892875] = -1610608061;
        }
        else
        {
                mem[8] = -1610608061;
        }
        
        mem[536892879] = 1067440879;
        536878249.Add(item:  536892867);
        ResolutionInfor val_3 = 536892867;
        val_3 = new ResolutionInfor();
        if(val_3 != 0)
        {
                mem[536892875] = -1610607107;
        }
        else
        {
                mem[8] = -1610607107;
        }
        
        mem[536892879] = 1068154880;
        536878249.Add(item:  536892867);
        ResolutionInfor val_4 = 536892867;
        val_4 = new ResolutionInfor();
        if(val_4 != 0)
        {
                mem[536892875] = -1610607105;
        }
        else
        {
                mem[8] = -1610607105;
        }
        
        mem[536892879] = 1071877689;
        536878249.Add(item:  536892867);
        ResolutionInfor val_5 = 536892867;
        val_5 = new ResolutionInfor();
        if(val_5 != 0)
        {
                mem[536892875] = -1610607103;
        }
        else
        {
                mem[8] = -1610607103;
        }
        
        mem[536892879] = 1074439011;
        536878249.Add(item:  536892867);
        ResolutionInfor val_6 = 536892867;
        val_6 = new ResolutionInfor();
        if(val_6 != 0)
        {
                mem[536892875] = -1610608059;
        }
        else
        {
                mem[8] = -1610608059;
        }
        
        mem[536892879] = 1077385625;
        536878249.Add(item:  536892867);
        this.Resolutions = 536878249;
    }

}
