using UnityEngine;
public class CutRopeManager : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject RopeInstance;
    public UnityEngine.GameObject RopeInstance1;
    public float MinYForDestroy;
    private WrappingRopeLibrary.Scripts.Rope _sourceRope;
    private System.Collections.Generic.List<WrappingRopeLibrary.Scripts.Rope> _ropes;
    private bool _expandRope;
    
    // Methods
    private void Start()
    {
        536878261 = new System.Collections.Generic.List<Page>();
        this._ropes = 536878261;
        if(this.RopeInstance == 0)
        {
                return;
        }
        
        Weight val_3 = this.RopeInstance.GetComponent<Weight>();
        this._sourceRope = this.RopeInstance;
        536891283 = new WrappingRopeLibrary.Events.ObjectWrapEventHandler(object:  871205008, method:  new IntPtr(1610682551));
        this._sourceRope.add_ObjectWrap(value:  536891283);
    }
    public void Rope_ObjectWrapping(WrappingRopeLibrary.Scripts.RopeBase sender, WrappingRopeLibrary.Events.ObjectWrapEventArgs args)
    {
        float val_9;
        float val_10;
        float val_11;
        if(0 == 0)
        {
                return;
        }
        
        DropdownItem val_1 = UnityEngine.Object.Instantiate<DropdownItem>(original:  this.RopeInstance1);
        Weight val_2 = this.RopeInstance1.GetComponent<Weight>();
        this._ropes.Add(item:  this.RopeInstance1);
        mem2[0] = 1;
        UnityEngine.Transform val_3 = this._ropes.transform;
        UnityEngine.Vector3 val_26 = args._wrapPoints[0];
        this._ropes.position = new UnityEngine.Vector3() {x = val_26, y = args._wrapPoints[0], z = args._wrapPoints[0]};
        UnityEngine.Transform val_4 = val_26.transform;
        UnityEngine.Transform val_5 = this._sourceRope.transform;
        UnityEngine.Vector3 val_6 = position;
        val_26.position = new UnityEngine.Vector3() {x = R4, y = R5, z = R6};
        R4 + 20.SetPointInWorldSpace(wrapDistance:  val_6.x);
        R4 + 20 + 24.SetPointInWorldSpace(wrapDistance:  val_6.x);
        R4 + 20 + 24.Relocate(resetPrevBandPoints:  true);
        this.RopeInstance1.AnchoringMode = 1;
        this._sourceRope.AnchoringMode = 0;
        UnityEngine.Transform val_7 = this._sourceRope.transform;
        UnityEngine.Vector3 val_8 = position;
        float val_32 = val_9;
        float val_33 = val_10;
        float val_34 = val_11;
        val_32 = args._wrapPoints[0] - val_32;
        val_33 = args._wrapPoints[0] - val_33;
        val_34 = args._wrapPoints[0] - val_34;
        this._sourceRope.CutRopeNotAnchoring(length:  val_32.magnitude, dir:  871493368);
        this._sourceRope.Relocate(resetPrevBandPoints:  true);
        this._sourceRope.AnchoringMode = 1;
        Weight val_13 = args._target.GetComponent<Weight>();
        UnityEngine.Transform val_14 = args._target.transform;
        UnityEngine.Vector3 val_15 = position;
        UnityEngine.Vector3 val_16 = GetPointVelocity(worldPoint:  new UnityEngine.Vector3() {x = args._target, y = val_9, z = val_10});
        float val_17 = val_9.magnitude;
        this = 22760488;
        UnityEngine.Vector3 val_35 = args._wrapPoints[0];
        UnityEngine.Vector3 val_36 = args._wrapPoints[0];
        UnityEngine.Vector3 val_37 = args._wrapPoints[0];
        UnityEngine.Transform val_18 = args._target.transform;
        UnityEngine.Vector3 val_19 = position;
        float val_38 = val_10;
        val_35 = val_35 - val_9;
        val_36 = val_36 - val_38;
        val_37 = val_37 - val_11;
        val_37 = 871493368 * val_37;
        val_36 = 871493368 * val_36;
        val_35 = 871493368 * val_35;
        Weight val_20 = this._sourceRope.GetComponent<Weight>();
        val_38 = val_36 + val_36;
        this._sourceRope.AddForce(force:  new UnityEngine.Vector3() {x = val_35 + val_35, y = val_38, z = val_37 + val_37}, mode:  2);
        Weight val_23 = this._sourceRope.GetComponent<Weight>();
        float val_39 = 4f;
        val_39 = val_35 * val_39;
        this._sourceRope.AddForce(force:  new UnityEngine.Vector3() {x = val_39, y = val_36 * val_39, z = val_37 * val_39}, mode:  2);
    }
    private void Update()
    {
        this.ManageInput();
        this.ManageOutRopes();
    }
    private void ManageInput()
    {
        if((UnityEngine.Input.GetMouseButtonDown(button:  1)) == true)
        {
                this._expandRope = true;
        }
        
        if((UnityEngine.Input.GetMouseButtonUp(button:  1)) == true)
        {
                this._expandRope = false;
        }
    
    }
    private void ManageOutRopes()
    {
        WrappingRopeLibrary.Scripts.Rope val_9;
        var val_12;
        var val_13;
        536878261 = new System.Collections.Generic.List<Page>();
        val_12 = 0;
        goto label_1;
        label_13:
        if(536878261 <= val_12)
        {
                var val_12 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_12 = val_12 + 0;
        UnityEngine.Transform val_2 = (0 + 0) + 16 + 20.transform;
        UnityEngine.Vector3 val_3 = position;
        if(((0 + 0) + 16 + 20) < 0)
        {
                UnityEngine.Transform val_5 = (0 + 0) + 16 + 24.transform;
            UnityEngine.Vector3 val_6 = position;
            if(((0 + 0) + 16 + 24) < 0)
        {
                536878261.Add(item:  (0 + 0) + 16);
        }
        
        }
        
        val_12 = 1;
        label_1:
        if(val_12 < 536878261)
        {
            goto label_13;
        }
        
        List.Enumerator<T> val_7 = GetEnumerator();
        label_17:
        if(MoveNext() == false)
        {
            goto label_15;
        }
        
        bool val_10 = this._ropes.Remove(item:  val_9);
        goto label_17;
        label_15:
        Dispose();
        val_13 = 0;
        goto label_18;
        label_24:
        if(872021880 <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_13 = mem[536878269];
        val_13 = val_13 + 0;
        UnityEngine.GameObject val_11 = (mem[536878269] + 0) + 16.gameObject;
        UnityEngine.Object.Destroy(obj:  (mem[536878269] + 0) + 16);
        val_13 = 1;
        label_18:
        if(val_13 < mem[536878273])
        {
            goto label_24;
        }
    
    }
    private void FixedUpdate()
    {
        if(this._expandRope == false)
        {
                return;
        }
        
        this._sourceRope.CutRope(length:  UnityEngine.Time.fixedDeltaTime, dir:  -2147483648);
    }
    public CutRopeManager()
    {
    
    }

}
