using UnityEngine;
public class GeneratorController : MonoBehaviour
{
    // Fields
    public UnityEngine.SpriteRenderer lamp;
    public UnityEngine.SpriteRenderer glow;
    public UnityEngine.Light point;
    public UnityEngine.UI.Text _text;
    public UnityEngine.UI.Text _text2;
    public Water2D.Water2D_Spawner water2d;
    private float battery;
    private float currentLosesCoef;
    private UnityEngine.Rigidbody2D rb;
    private UnityEngine.Color _c;
    private float _speed;
    private int relaxFrames;
    private int _frames;
    private float avgVolts;
    private float avgRpm;
    
    // Methods
    private void Start()
    {
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        this.rb = this;
    }
    private void FixedUpdate()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.rb)) == false)
        {
                return;
        }
        
        float val_2 = this.rb.angularVelocity;
        float val_8 = 360f;
        val_8 = this.rb / val_8;
        val_8 = this.battery + val_8;
        this.battery = val_8;
        float val_3 = this.rb.angularVelocity;
        float val_9 = this.battery;
        val_9 = val_9 * this.currentLosesCoef;
        float val_10 = 0f;
        val_10 = val_9 * val_10;
        if(this.rb < 0)
        {
                val_9 = val_10;
        }
        
        this.battery = val_9;
        float val_12 = 6.28f;
        UnityEngine.Color val_4 = color;
        float val_11 = 0.01f;
        val_11 = this.battery * val_11;
        float val_5 = UnityEngine.Mathf.Lerp(a:  val_11, b:  val_4.g, t:  this.battery);
        mem2[0] = 0f;
        val_12 = this.rb / val_12;
        this.lamp.color = new UnityEngine.Color() {r = this._c, g = R7, b = R8, a = 0f};
        float val_13 = 0.003f;
        val_13 = this.battery * val_13;
        float val_6 = UnityEngine.Mathf.Lerp(a:  val_13, b:  val_4.g, t:  this.battery);
        this.point.intensity = val_6;
        this.PrintResults(rpm:  UnityEngine.Mathf.Lerp(a:  val_6, b:  val_4.g, t:  this.battery), volts:  val_4.g);
    }
    private void Update()
    {
        float val_4;
        float val_5;
        if(this.water2d == 0)
        {
                return;
        }
        
        mem2[0] = R4 + 32 + 184;
        bool val_2 = UnityEngine.Input.GetMouseButton(button:  0);
        bool val_3 = UnityEngine.Input.GetMouseButton(button:  1);
        if(val_3 == true)
        {
                R4 + 64 = -0.1f;
        }
        
        val_4 = 1065353216;
        if(val_3 == true)
        {
                R4 + 64 = (R4 + 64) + (R4 + 64);
        }
        
        val_5 = 1f;
        if(val_3 == true)
        {
                mem2[0] = R4 + 64;
        }
        
        if(val_3 < 0)
        {
            goto label_4;
        }
        
        val_5 = 60f;
        if(val_3 <= false)
        {
            goto label_5;
        }
        
        val_4 = 17008;
        val_4 = 1114636288;
        label_4:
        mem2[0] = val_5;
        goto label_6;
        label_5:
        val_4 = R4 + 64;
        label_6:
        mem2[0] = val_4;
    }
    private void PrintResults(float rpm, float volts)
    {
        float val_6 = R2;
        if(this._frames > this.relaxFrames)
        {
                float val_6 = (float)this.relaxFrames;
            this._frames = 0;
            val_6 = this.avgVolts / val_6;
            string val_1 = val_6.ToString(format:  -1610611641);
            string val_2 = -1610602629(-1610602629) + 868035348;
            float val_7 = (float)this.relaxFrames;
            val_7 = this.avgRpm / val_7;
            string val_3 = val_7.ToString(format:  -1610611655);
            string val_4 = -1610605117(-1610605117) + 868035348;
            val_6 = -1610605117;
            float val_9 = 0f;
            float val_8 = this.avgVolts;
            val_8 = val_8 * val_9;
            val_9 = this.avgRpm * val_9;
            this.avgVolts = val_8;
            this.avgRpm = val_9;
            return;
        }
        
        float val_10 = val_6;
        float val_11 = R1;
        val_10 = this.avgVolts + val_10;
        val_11 = this.avgRpm + val_11;
        this._frames = this._frames + 1;
        this.avgVolts = val_10;
        this.avgRpm = val_11;
    }
    public GeneratorController()
    {
        this.relaxFrames = 30;
        this.currentLosesCoef = 0.975f;
    }

}
