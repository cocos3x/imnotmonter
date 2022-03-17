using UnityEngine;
public class PatrolWaypoint : MonoBehaviour
{
    // Fields
    public float StopProbability;
    public float StopDuration;
    public float StopDurationVariation;
    
    // Methods
    public PatrolWaypoint()
    {
        this.StopProbability = 0.5f;
        this.StopDuration = 3f;
        this.StopDurationVariation = 2f;
    }

}
