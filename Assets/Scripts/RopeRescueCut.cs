using UnityEngine;
public class RopeRescueCut : MonoBehaviour
{
    // Fields
    public UnityEngine.SpriteRenderer[] SegmentsPrefabs;
    public SegmentSelectionMode SegmentsMode;
    public LineOverflowMode OverflowMode;
    public bool useBendLimit;
    public int bendLimit;
    public bool HangFirstSegment;
    public UnityEngine.Vector2 FirstSegmentConnectionAnchor;
    public UnityEngine.Vector2 LastSegmentConnectionAnchor;
    public bool HangLastSegment;
    public bool BreakableJoints;
    public float BreakForce;
    public float overlapFactor;
    public System.Collections.Generic.List<UnityEngine.Vector3> nodes;
    public bool EnablePhysics;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    public RopeRescueCut()
    {
        var val_2;
        this.bendLimit = 45;
        this.useBendLimit = true;
        this.BreakForce = 100f;
        val_2 = mem[536882609];
        if(val_2 == 0)
        {
                val_2 = mem[536882609];
        }
        
        mem[536882613] = 3225419776;
        mem[536882617] = 0;
        mem[536882621] = 0;
        mem[536882625] = 1077936128;
        mem[536882629] = 0;
        mem[536882633] = 0;
        536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>(collection:  536882597);
        this.nodes = 536878517;
        this.EnablePhysics = true;
    }

}
