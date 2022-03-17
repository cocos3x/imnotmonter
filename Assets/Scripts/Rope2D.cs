using UnityEngine;
public class Rope2D : MonoBehaviour
{
    // Fields
    public float capLineWidth;
    public Vectrosity.VectorLine line;
    public UnityEngine.Texture2D lineNoel;
    public UnityEngine.Texture2D lineTex;
    public UnityEngine.Color32 lineColor;
    public WrappingRopeLibrary.Scripts.Rope rope;
    public bool rending;
    private bool oneFarme;
    public float distanceRope;
    public System.Collections.Generic.List<UnityEngine.Vector3> wayPoints;
    public System.Collections.Generic.List<UnityEngine.Vector3> wayPointsToMove;
    
    // Methods
    public void CreateLine(string nameLine)
    {
        float val_5 = this.capLineWidth;
        536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        float val_4 = (float)UnityEngine.Screen.width;
        val_4 = val_4 / 1080f;
        val_5 = val_5 * val_4;
        536896697 = new Vectrosity.VectorLine(name:  nameLine, points:  536878517, texture:  this.lineTex, width:  val_4, lineType:  val_5, joins:  0);
        this.line = 536896697;
        this.line.textureScale = val_4;
        mem[this.line].drawDepth = 2;
        this.Calculate();
    }
    private void Update()
    {
        if(this.oneFarme != false)
        {
                this.oneFarme = false;
            this.rope.enabled = false;
        }
        
        if(this.rending == false)
        {
                return;
        }
        
        this.RenderLine();
    }
    public void RenderLine()
    {
        if(this.line == 0)
        {
                return;
        }
        
        this.Calculate();
        float val_1 = this.distanceRope ^ 2147483648;
        this.line.textureOffset = null;
        this.line.points3 = this.wayPoints;
        this.line.color = new UnityEngine.Color32() {r = this.lineColor, g = this.lineColor, b = this.lineColor, a = this.lineColor};
        if(this.line == 0)
        {
                return;
        }
        
        this.line.Draw3D();
    }
    private void Calculate()
    {
        Rope2D val_15;
        var val_16;
        var val_17;
        float val_18;
        float val_19;
        var val_20;
        float val_21;
        var val_22;
        var val_23;
        Rope2D val_24;
        float val_25;
        val_15 = this;
        this.wayPoints.Clear();
        val_16 = 0;
        goto label_2;
        label_30:
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Transform val_2 = this.GetChild(index:  0);
        UnityEngine.Transform val_3 = this.GetComponent<UnityEngine.Transform>();
        if(val_16 == 0)
        {
            goto label_7;
        }
        
        if(val_15 < 1)
        {
            goto label_13;
        }
        
        if(this.wayPoints != 0)
        {
                val_21 = val_15;
        }
        else
        {
                val_21 = 0f;
            val_20 = 0;
        }
        
        if(val_20 <= (-1))
        {
                var val_19 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_19 = val_19 + (((-1) + 4294967294) << 2);
        val_15 = val_15;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = R8, y = R7, z = SB}, rhs:  new UnityEngine.Vector3() {x = (0 + ((-1 + 4294967294)) << 2) + 16, y = (0 + ((-1 + 4294967294)) << 2) + 20, z = (0 + ((-1 + 4294967294)) << 2) + 24})) == false)
        {
            goto label_13;
        }
        
        label_7:
        this.wayPoints.Add(item:  new UnityEngine.Vector3() {x = R8, y = R7, z = SB});
        label_13:
        UnityEngine.Transform val_6 = this.transform;
        int val_7 = this.childCount;
        val_7 = val_7 - 1;
        if(val_16 != val_7)
        {
            goto label_27;
        }
        
        UnityEngine.Transform val_8 = this.transform;
        UnityEngine.Transform val_9 = this.GetChild(index:  0);
        UnityEngine.Transform val_10 = this.GetComponent<UnityEngine.Transform>();
        val_19 = mem[mem[1152921509637409832] + 32];
        val_19 = mem[1152921509637409832] + 32;
        val_21 = mem[mem[1152921509637409832] + 36];
        val_21 = mem[1152921509637409832] + 36;
        val_18 = mem[mem[1152921509637409832] + 40];
        val_18 = mem[1152921509637409832] + 40;
        if(val_16 == 0)
        {
            goto label_21;
        }
        
        if(val_15 < 1)
        {
            goto label_27;
        }
        
        if(this.wayPoints != 0)
        {
                val_23 = val_15;
        }
        else
        {
                val_17 = 12;
            val_23 = 0;
            val_22 = 0;
        }
        
        if(val_22 <= (-1))
        {
                var val_20 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_20 = val_20 + (((-1) + 4294967294) << 2);
        val_15 = val_15;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_19, y = val_21, z = val_18}, rhs:  new UnityEngine.Vector3() {x = (0 + ((-1 + 4294967294)) << 2) + 16, y = (0 + ((-1 + 4294967294)) << 2) + 20, z = (0 + ((-1 + 4294967294)) << 2) + 24})) == false)
        {
            goto label_27;
        }
        
        label_21:
        this.wayPoints.Add(item:  new UnityEngine.Vector3() {x = val_19, y = val_21, z = val_18});
        label_27:
        val_16 = 1;
        label_2:
        UnityEngine.Transform val_13 = this.transform;
        if(val_16 < this.childCount)
        {
            goto label_30;
        }
        
        536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>(collection:  this.wayPoints);
        mem[1152921509637409856] = 536878517;
        val_24 = val_15;
        if(mem[536878529] < 2)
        {
                return;
        }
        
        if(mem[536878529] == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(mem[536878529] <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_21 = mem[536878525] + 32;
        val_21 = (mem[536878525] + 20) - val_21;
        if(mem[536878529] > 1)
        {
                if(mem[536878529] == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(mem[536878529] == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(mem[536878529] == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            float val_22 = -0.3f;
            val_22 = (mem[536878525] + 20) + val_22;
            mem[1152921509637409856].set_Item(index:  0, value:  new UnityEngine.Vector3() {x = mem[536878525] + 16, y = val_22, z = mem[536878525] + 24});
            val_24 = val_15;
        }
        
        val_25 = 0f;
        val_17 = 0;
        val_21 = 1;
        val_18 = 0;
        goto label_44;
        label_50:
        if(mem[1152921509637409856] <= mem[1152921509637409856])
        {
                var val_23 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_19 = this.wayPoints;
        val_23 = val_23 + val_18;
        var val_16 = val_23 + 16;
        if(val_23 <= val_21)
        {
                var val_24 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_24 = val_24 + val_18;
        float val_25 = mem[((0 + val_18) + 16) + (0)];
        float val_17 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_25, y = mem[((0 + val_18) + 16) + (4)], z = mem[((0 + val_18) + 16) + (8)]}, b:  new UnityEngine.Vector3() {x = (0 + val_18) + 28, y = (0 + val_18) + 32, z = (0 + val_18) + 36});
        val_24 = val_15;
        val_21 = 2;
        val_18 = 12;
        val_25 = mem[1152921509637409848] + val_25;
        label_44:
        mem[1152921509637409848] = val_25;
        val_25 = val_25 - 1;
        if((val_21 - 1) < val_25)
        {
            goto label_50;
        }
    
    }
    public Rope2D()
    {
        this.oneFarme = true;
        this.capLineWidth = 20f;
        System.Collections.Generic.List<UnityEngine.Vector3> val_1 = 536878517;
        val_1 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        this.wayPoints = val_1;
        System.Collections.Generic.List<UnityEngine.Vector3> val_2 = 536878517;
        val_2 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        this.wayPointsToMove = val_2;
    }

}
